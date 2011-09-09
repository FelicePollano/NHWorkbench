// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHibernate.Tool.WorkBench.Core
{
    public interface ITypeFactory
    {
        T Get<T>();
        T Get<T>(string name);
        object Get(Type t);
    }
}
