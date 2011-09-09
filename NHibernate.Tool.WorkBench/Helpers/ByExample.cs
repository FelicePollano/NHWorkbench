// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHibernate.Tool.WorkBench.Helpers
{
    public static class ByExample
    {
        public static T Cast<T>(T Example, object o)
        {
            return (T)o;
        }
    }
}
