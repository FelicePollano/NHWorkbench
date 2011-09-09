// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHibernate.Tool.WorkBench.Core
{
    [Serializable]
    public class ExecutedHqlResults
    {
        public Exception Exception { get; set; }
        public string Body { get; set; }
    }
}
