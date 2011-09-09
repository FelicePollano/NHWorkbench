// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Tool.WorkBench.Core.WireAttributes;
using log4net.Appender;
using log4net.Repository.Hierarchy;
using log4net;
using log4net.Core;
using NHibernate.Tool.WorkBench.Core.Commands;
using System.Runtime.Remoting;
using NHibernate.Tool.WorkBench.Core;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Ipc;
using System.Windows.Forms;

namespace NHibernate.Tool.WorkBench.Log
{
    [Model]
    [Export(Type=typeof(ILogModel))]
    public class LogModel:MarshalByRefObject,IAppender,log4net.Appender.RemotingAppender.IRemoteLoggingSink, ILogModel
    {
        public override object InitializeLifetimeService()
        {
            return null;
        }
        List<LoggingEvent> messages = new List<LoggingEvent>();
        public void Clear()
        {
            if (Messages > 0)
            {
                Messages = 0;
                if (null != MessagesCountChanged)
                    MessagesCountChanged(this, EventArgs.Empty);
            }
            if (Warnings >  0)
            {
                Warnings = 0;
                if (null != WarningsCountChanged)
                    WarningsCountChanged(this, EventArgs.Empty);
            }
            if (Errors > 0)
            {
                Errors = 0;
                if (null != ErrorsCountChanged)
                    ErrorsCountChanged(this, EventArgs.Empty);
            }
            if (Debugs > 0)
            {
                Debugs = 0;
                if (null != DebugsCountChanged)
                    DebugsCountChanged(this, EventArgs.Empty);
            }
            messages.Clear();
        }
        ILog log;
        ObjRef oref;
        IpcChannel channel;
        
        public LogModel(ILog log,ICommandRouter router)
        {
            
            Hierarchy h = LogManager.GetRepository() as Hierarchy;
            h.Root.AddAppender(this);
            h.Root.Level = Level.Debug;
            this.log = log;
            router.ExceptionExecuting += new EventHandler<ExecutingExceptionEventArgs>(router_ExceptionExecuting);

            channel = new IpcChannel("log4net");
            
            ChannelServices.RegisterChannel(channel,false);
            oref = RemotingServices.Marshal(this, null);
            ApplicationEnvironment.Instance.LoggerURI = channel.GetUrlsForUri(oref.URI)[0];
        }

        void router_ExceptionExecuting(object sender, ExecutingExceptionEventArgs e)
        {
            log.Error("Error executing command", e.Exception);
        }
        #region IAppender Members

        public void Close()
        {
            
        }
        public event EventHandler ErrorsCountChanged;
        public event EventHandler WarningsCountChanged;
        public event EventHandler DebugsCountChanged;
        public event EventHandler MessagesCountChanged;
        public int Errors { get; private set; }
        public int Warnings { get; private set; }
        public int Messages { get; private set; }
        public int Debugs { get; private set; }
        public void DoAppend(log4net.Core.LoggingEvent loggingEvent)
        {
            messages.Add(loggingEvent);
            if (loggingEvent.Level == Level.Error)
            {
                Errors++;
                if (null != ErrorsCountChanged)
                    ErrorsCountChanged(this, EventArgs.Empty);
            }
            else if (loggingEvent.Level == Level.Warn)
            {
                Warnings++;
                if (null != WarningsCountChanged)
                    WarningsCountChanged(this, EventArgs.Empty);
            }
            else if (loggingEvent.Level == Level.Info)
            {
                Messages++;
                if (null != MessagesCountChanged)
                    MessagesCountChanged(this, EventArgs.Empty);
            }
            else if (loggingEvent.Level == Level.Debug)
            {
                Debugs++;
                if (null != DebugsCountChanged)
                    DebugsCountChanged(this, EventArgs.Empty);
            }
            
        }
        
        public List<LoggingEvent> GetFromNth(int n,int count, bool message,bool warning,bool error,bool debug)
        {
            List<LoggingEvent> ret = new List<LoggingEvent>();
            int i = -1;
            int j=0;
            foreach (LoggingEvent le in messages)
            {
                if (null != le)
                {
                    if (le.Level == Level.Info && message)
                        ++i;
                    if (le.Level == Level.Warn && warning)
                        ++i;
                    if (le.Level == Level.Error && error)
                        ++i;
                    if (le.Level == Level.Debug && debug)
                        ++i;
                    if (i == n && j < count)
                    {
                        ++j;
                        --i;
                        ret.Add(le);
                    }
                }

            }
            return ret;
        }

       

        public string Name
        {
            get;set;
        }

        #endregion

        #region IRemoteLoggingSink Members

        public void LogEvents(LoggingEvent[] events)
        {
            foreach (var le in events)
            {
                    DoAppend(le);
            }
        }

        #endregion
    }
}
