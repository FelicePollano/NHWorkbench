// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHibernate.Tool.WorkBench.Core.WireAttributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple=false)]
    public class PresenterViewAttribute:Attribute
    {
        public bool Singleton { get; set; }
    }
}
