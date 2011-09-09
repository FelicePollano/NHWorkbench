// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHibernate.Tool.WorkBench.Core
{
    public interface IPresenter
    {
         object View { get;  }
         event EventHandler Disposed;
         void Startup();
    }
}
