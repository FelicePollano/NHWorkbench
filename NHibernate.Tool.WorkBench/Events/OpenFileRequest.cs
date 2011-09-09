// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHibernate.Tool.WorkBench.Events
{
    class OpenFileRequest:EventArgs
    {
        public string FilePath { get; set; }
    }
}
