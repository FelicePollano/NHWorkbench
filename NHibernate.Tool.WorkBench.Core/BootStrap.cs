// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net.Config;
using Microsoft.Practices.Unity;
using log4net;
using System.Reflection;

using System.Configuration;
using Microsoft.Practices.ObjectBuilder2;
using Microsoft.Practices.Unity.ObjectBuilder;
using System.IO;
using NHibernate.Tool.WorkBench.Core;
using NHibernate.Tool.WorkBench.Core.Commands;
using NHibernate.Tool.WorkBench.Core.WireAttributes;
using System.Windows.Forms;



namespace Ors.Rams.UI.Integration.PartProgramManager
{
    public static class BootStrap
    {
        static IUnityContainer container;
        static ITypeFactory factory;
        public static ITypeFactory Boot(string loggerName,Assembly asm) 
        {
            XmlConfigurator.Configure();
            container = new UnityContainer();
            
            RegisterKnownTypes(asm);
            RegisterKnownTypes(typeof(ITypeFactory).Assembly);
           
            container.RegisterInstance<ITypeFactory>(new TypeFactory(container));
            container.RegisterInstance<ILog>(LogManager.GetLogger(loggerName));
            
            container.RegisterInstance<ICommandRouter>(new CommandRouterImpl());
            factory = container.Resolve<ITypeFactory>();

            factory.Get<ILog>().Info(".=.=.=. " + Assembly.GetExecutingAssembly().GetName().Name + " =.=.=.=");
            factory.Get<ILog>().Info("Version:" + Assembly.GetExecutingAssembly().GetName().Version.ToString());

            string dataPath = ApplicationEnvironment.Instance.DataPath;
            if (!Directory.Exists(dataPath))
            {
                factory.Get<ILog>().Error("L'applicazione non riesce a creare il percorso dati:" + dataPath);
            }
            factory.Get<ILog>().Debug("Data path applicazione:"+dataPath);

            container.AddExtension(new WireImportExports());
            return factory;
        }

       
        private static void RegisterKnownTypes(Assembly assembly)
        {
            foreach (Type t in assembly.GetTypes())
            {
                if (!t.IsAbstract)
                {
                    ModelAttribute[] models = t.GetCustomAttributes(typeof(ModelAttribute), true) as ModelAttribute[];
                    if (models.Length > 0)
                        container.RegisterType(t);

                    PresenterViewAttribute[] views = t.GetCustomAttributes(typeof(PresenterViewAttribute), true) as PresenterViewAttribute[];
                    if (views.Length > 0)
                    {
                        if (views[0].Singleton == false)
                            container.RegisterType(t);
                        else
                            container.RegisterType(t, new ContainerControlledLifetimeManager());
                    }

                    PresenterAttribute[] presenters = t.GetCustomAttributes(typeof(PresenterAttribute), true) as PresenterAttribute[];
                    if (presenters.Length > 0)
                        container.RegisterType(t);
                }
            }
        }
    }
}
