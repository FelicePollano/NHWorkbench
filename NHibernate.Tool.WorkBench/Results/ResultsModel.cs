using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Tool.WorkBench.Core.WireAttributes;

namespace NHibernate.Tool.WorkBench.Results
{
    [Model]
    class ResultsModel
    {
        public static readonly string[] NoResults = new string[0];
        public string[] Results { get; set; }
    }
}
