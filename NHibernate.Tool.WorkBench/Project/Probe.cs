// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using log4net;
using log4net.Config;
using log4net.Appender;
using log4net.Core;
using System.Reflection;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using NHibernate.Tool.WorkBench.Helpers;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels.Ipc;
using System.Runtime.Remoting.Channels;
using System.Threading;
using System.Collections;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;
using System.Diagnostics;
using System.Data;
using NHibernate.Tool.WorkBench.Core;

namespace NHibernate.Tool.WorkBench.Project
{
    class Probe:MarshalByRefObject, IProbe
    {
        
        public string ToolPath { get; set; }
        
        public Probe()
        {
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
            AppDomain.CurrentDomain.AssemblyLoad += new AssemblyLoadEventHandler(CurrentDomain_AssemblyLoad);
        }
        public string[] Assemblies { get; set; }
        void CurrentDomain_AssemblyLoad(object sender, AssemblyLoadEventArgs args)
        {
            if (null != logger)
                logger.Info("Loading ..." + args.LoadedAssembly.FullName+" from"+args.LoadedAssembly.Location);
        }

        System.Reflection.Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            string temptative =args.Name.Split(',')[0];
            Assembly asm = null;
            try
            {
                asm = Assembly.LoadFrom(Path.Combine(ToolPath, string.Concat(temptative, ".dll")));
            }
            catch
            {
                try
                {
                    asm = Assembly.LoadFrom(Path.Combine(ToolPath, string.Concat(temptative, ".exe")));
                }
                catch
                { 
                }
            }
            return asm;
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }
        public string LoggerURI { get; set; }
        ILog logger;
        public string Imports { get; private set; }
        object cfg;
        object sessionFactory;
        public void Configure()
        {
            IAppender ra = CreateAppender();
            BasicConfigurator.Configure(ra);
            logger = LogManager.GetLogger("Probe");
            logger.Info("Configuring...");
            Assembly asm = Assembly.Load("NHibernate");
            var cfgType = asm.GetType("NHibernate.Cfg.Configuration");
            cfg = Activator.CreateInstance(cfgType);
            cfg.GetType().GetMethod("Configure",new System.Type[0]).Invoke(cfg, null);
            foreach (string s in Assemblies)
            {
                var addAssembly = cfgType.GetMethod("AddAssembly",new System.Type[]{typeof(Assembly)});
                addAssembly.Invoke(cfg,new object[]{ Assembly.LoadFrom(s)});
            }

            var imports = cfg.GetType().GetProperty("Imports").GetValue(cfg,null) as IDictionary<string,string>;
            JavaScriptSerializer ser = new JavaScriptSerializer();
            Imports = ser.Serialize(imports);
            
            sessionFactory = cfgType.GetMethod("BuildSessionFactory", new System.Type[0]).Invoke(cfg, null);
            
        }

        private IAppender CreateAppender()
        {
            RemotingAppender ra = new RemotingAppender();
            ra.Layout = new log4net.Layout.SimpleLayout();
            ra.Sink = LoggerURI;
            ra.BufferSize = 1;
            ra.Lossy = false;
            ra.ActivateOptions();
            return ra;
        }

        private static readonly MethodInfo getQuery =
            System.Type.GetType("NHibernate.Impl.SessionImpl,NHibernate").GetMethod("GetQueries");


        private static readonly MethodInfo prepareQueryCommand =
             System.Type.GetType("NHibernate.Hql.Classic.QueryTranslator,NHibernate").GetMethod("PrepareQueryCommand", BindingFlags.NonPublic | BindingFlags.Instance);

        public ExecutedHqlResults HqlToSql(string hql)
        {
            ExecutedHqlResults res = new ExecutedHqlResults();
            res.Body = string.Empty;
            try
            {

                System.Type qtType = System.Type.GetType("NHibernate.Hql.Ast.ANTLR.QueryTranslatorImpl, NHibernate");
                using (var session = sessionFactory.GetType().GetMethod("OpenSession",new System.Type[0]).Invoke(sessionFactory, new object[0]) as IDisposable)
                {
                    var qp = Activator.CreateInstance(System.Type.GetType("NHibernate.Engine.QueryParameters, NHibernate"));
                    if (qtType == null)
                    {
                        logger.Debug("Using classic translator");
                        StringBuilder sb = new StringBuilder();
                        IEnumerable queryTranslators =
                            getQuery.Invoke(session, new object[] { hql, false }) as IEnumerable;

                        foreach (var translator in queryTranslators)
                        {
                            IDbCommand cmd = (IDbCommand)prepareQueryCommand.Invoke(translator, new object[] { qp, false, session });
                            sb.AppendLine( cmd.CommandText);
                        }
                        
                        res.Body = sb.ToString();
                    }
                    else
                    {
                        logger.Debug("Using ANTLR translator");
                        
                        var tFilter = typeof(Dictionary<,>).MakeGenericType(typeof(string),System.Type.GetType("NHibernate.IFilter, NHibernate"));
                        var filter = Activator.CreateInstance(tFilter);
                        var translator = Activator.CreateInstance(qtType, "wb", hql, filter, sessionFactory);
                        qtType.GetMethod("Compile",new System.Type[]{typeof(IDictionary<string,string>),typeof(bool)}).Invoke(translator,new object[]{ new Dictionary<string,string>(),false});
                        //var chunks = qtType.GetMethod("List").Invoke(activator,new object[]{session,qp} ) as IEnumerable;
                        res.Body = qtType.GetProperty("SQLString").GetValue(translator, null) as string;
                    }
                }
            }
            catch (Exception e)
            {
                // sorry but some exception are not marked as serializable
                if( e.InnerException != null )
                    res.Exception = new Exception(e.InnerException.Message);
            }
            res.Body = res.Body.Replace(",", "\r\n,");
            return res;
        }

        public IEnumerable<string> GetProperties(string path)
        {
            var mapping = cfg.GetType().GetMethod("GetClassMapping", new System.Type[] { typeof(string) }).Invoke(cfg, new object[] { path });
            if (null == mapping)
            {
                System.Type t = System.Type.GetType(path);
                if (t != null)
                {
                    mapping = cfg.GetType().GetMethod("GetClassMapping", new System.Type[] { typeof(System.Type) }).Invoke(cfg, new object[] { t });
                }
            }
            if (null != mapping)
            {
                List<string> props = new List<string>();
                JavaScriptSerializer ser = new JavaScriptSerializer();
                var id = mapping.GetType().GetProperty("IdentifierProperty").GetValue(mapping, null);
                if (null != id)
                {
                    var t = id.GetType().GetProperty("Type").GetValue(id, null);
                    var value = id.GetType().GetProperty("Value").GetValue(id, null);
                    props.Add(
                       ser.Serialize(
                           new
                           {
                               Name = id.GetType().GetProperty("Name").GetValue(id, null)
                               ,
                               Type = t.GetType().GetProperty("Name").GetValue(t, null)
                               ,
                               Value = NHValueJSonHelper.GetJSonSerializable(value)
                           }
                       )
                       );
                }
                IEnumerable enu =  mapping.GetType().GetProperty("PropertyClosureIterator").GetValue(mapping, null) as IEnumerable;
                foreach (var p in enu)
                {
                    var t = p.GetType().GetProperty("Type").GetValue(p, null);
                    var value = p.GetType().GetProperty("Value").GetValue(p, null);
                    //var returned = t.GetType().GetProperty("ReturnedClass").GetValue(t, null);
                    props.Add(
                        ser.Serialize(
                            new
                            {
                                Name = p.GetType().GetProperty("Name").GetValue(p, null)
                                ,Type =  t.GetType().GetProperty("Name").GetValue(t, null)
                                ,Value = NHValueJSonHelper.GetJSonSerializable(value)
                            }
                        )
                        );
                }
                return props.ToArray();
            }
            else
            {
                return new string[0];
            }
        }

        public string[] ExecuteQuery(string hql,int first,int max)
        {
            using (var session = sessionFactory.GetType().GetMethod("OpenSession",new System.Type[0]).Invoke(sessionFactory, new object[0]) as IDisposable)
            {
                List<object> list = new List<object>();
               var q = session.GetType().GetMethod("CreateQuery",new System.Type[]{typeof(string)}).Invoke(session,new object[]{hql});
               if (max > 0)
               {
                   q.GetType().GetMethod("SetFirstResult", new System.Type[] { typeof(int) }).Invoke(q, new object[] { first });
                   q.GetType().GetMethod("SetMaxResults", new System.Type[] { typeof(int) }).Invoke(q, new object[] { max });
               }
               q.GetType().GetMethod("List", new System.Type[] { typeof(IList) }).Invoke(q, new object[] { list });
               return ToStringRepresentation(list);
            }
        }

        private string[] ToStringRepresentation(List<object> list)
        {
            List<string> s = new List<string>();
            foreach (var o in list)
            {
                s.Add(MakeJSONRep(o));
            }
            return s.ToArray();
        }

        private string MakeJSONRep(object o)
        {
            StringBuilder sb = new StringBuilder();
            List<string> aggregates = new List<string>();

            if (o is IEnumerable && !(o is string))
            {
                sb.Append("[ ");
                foreach (var oo in o as IEnumerable)
                {
                    sb.Append(string.Concat(MakeJSONRep(oo), " "));
                }
                sb.Append(" ]");
            }
            else
            {
                if (o.GetType() == typeof(string) || o.GetType().IsValueType)
                {
                    sb.Append(o.ToString());
                }
                else
                {
                    sb.Append("{ ");
                    foreach (PropertyInfo pi in o.GetType().GetProperties())
                    {
                        if (pi.PropertyType.IsValueType || pi.PropertyType == typeof(string))
                        {
                            sb.Append(pi.Name);
                            sb.Append(":");
                            string val = pi.GetValue(o, null) != null ? pi.GetValue(o, null).ToString() : "(null)";
                            sb.Append(string.Concat("\"", val, "\""));
                            sb.Append(" ");
                        }
                        else
                        {
                            aggregates.Add(pi.Name);
                        }
                    }
                    foreach (string agg in aggregates)
                    {
                        sb.Append(agg);
                        sb.Append(":");
                        sb.Append("\"{...}\"");
                        sb.Append(" ");
                    }
                    sb.Append(" }");
                }
            }
            return sb.ToString();
        }
    }
}
