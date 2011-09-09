// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHibernate.Tool.WorkBench.Events
{
    class ProjectFileMoved:EventArgs
    {
        public string PreviousPath { get; set; }
        public string NewPath { get; set; }
    }
}
