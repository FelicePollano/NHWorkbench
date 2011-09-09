// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHibernate.Tool.WorkBench.Core.Commands
{
    public class ExecutingExceptionEventArgs:EventArgs
    {
        public Exception Exception { get; set; }
    }
}
