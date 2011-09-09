using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Tool.WorkBench.Core.WireAttributes;
using NHibernate.Tool.WorkBench.Core;

namespace NHibernate.Tool.WorkBench.RawSQL
{
    [Model]
    class RawSQLModel
    {
        public readonly static ExecutedHqlResults EmptyResults = new ExecutedHqlResults() { Body="" };
        public ExecutedHqlResults Results { get; set; }
        public RawSQLModel()
        {
            Results = EmptyResults;
        }
    }
}
