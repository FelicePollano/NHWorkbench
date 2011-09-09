// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Tool.WorkBench.Core.WireAttributes;
using NHibernate.Tool.WorkBench.Core;
using log4net.Appender;
using NHibernate.Tool.WorkBench.Core.Commands;

namespace NHibernate.Tool.WorkBench.Log
{
    [Presenter]
    class LogPresenter:IPresenter
    {
        LogView view;
        
        public LogPresenter(LogView view)
        {
            this.view = view;
        }

        #region IPresenter Members

        public object View
        {
            get { return view; }
        }

        public event EventHandler Disposed;

        public void Startup()
        {
            
        }
        #endregion
    }
}
