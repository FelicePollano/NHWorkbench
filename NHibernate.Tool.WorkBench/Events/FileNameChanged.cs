// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHibernate.Tool.WorkBench.Events
{
    class FileNameChanged:EventArgs
    {
        public string  PrevPath { get; set; }
        public string NewPath { get; set; }
    }
}
