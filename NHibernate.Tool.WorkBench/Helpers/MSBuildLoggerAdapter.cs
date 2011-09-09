// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using Microsoft.Build.Framework;


namespace NHibernate.Tool.WorkBench.Helpers
{
    class MSBuildLoggerAdapter:Microsoft.Build.Framework.ILogger
    {
        ILog logger;
        public MSBuildLoggerAdapter(ILog logger)
        {
            this.logger = logger;
            BuildFinished = new BuildFinishedEventHandler(eventSource_BuildFinished);
            BuildStarted = new BuildStartedEventHandler(eventSource_BuildStarted);
            BuildError = new BuildErrorEventHandler(eventSource_ErrorRaised);
            BuildMessage = new BuildMessageEventHandler(eventSource_MessageRaised);
            BuildWarning = new BuildWarningEventHandler(eventSource_WarningRaised);
        }

        #region ILogger Members
        BuildFinishedEventHandler BuildFinished;
        BuildStartedEventHandler BuildStarted;
        BuildErrorEventHandler BuildError;
        BuildMessageEventHandler BuildMessage;
        BuildWarningEventHandler BuildWarning;
        IEventSource eventSource;

        public void Initialize(IEventSource eventSource)
        {
            this.eventSource = eventSource;
            eventSource.BuildFinished += BuildFinished;
            eventSource.BuildStarted += BuildStarted;
            eventSource.ErrorRaised += BuildError;
            eventSource.MessageRaised += BuildMessage;
            eventSource.WarningRaised += BuildWarning;
        }

        void eventSource_WarningRaised(object sender, BuildWarningEventArgs e)
        {
            logger.Warn(e.Message);
        }

        void eventSource_MessageRaised(object sender, BuildMessageEventArgs e)
        {
            logger.Info(e.Message);
        }

        void eventSource_ErrorRaised(object sender, BuildErrorEventArgs e)
        {
            logger.Error(e.Message);
        }

        void eventSource_BuildStarted(object sender, BuildStartedEventArgs e)
        {
            logger.Info(e.Message);
        }

        void eventSource_BuildFinished(object sender, BuildFinishedEventArgs e)
        {
            logger.Info(e.Message);
        }

        

        public string Parameters
        {
            get;set;
           
        }

        public void Shutdown()
        {
            eventSource.BuildFinished -= BuildFinished;
            eventSource.BuildStarted -= BuildStarted;
            eventSource.ErrorRaised -= BuildError;
            eventSource.MessageRaised -= BuildMessage;
            eventSource.WarningRaised -= BuildWarning;
        }

        public LoggerVerbosity Verbosity
        {
            get;set;
        }

        #endregion
    }
}
