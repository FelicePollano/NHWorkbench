// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHibernate.Tool.WorkBench.Core.WireAttributes
{
    [AttributeUsage(AttributeTargets.Class,AllowMultiple=true)]
    public class ExportAttribute:Attribute
    {
        public Type Type { get; set; }
    }
}
