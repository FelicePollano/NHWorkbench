// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;

namespace NHibernate.Tool.WorkBench.Core
{
    internal class TypeFactory:ITypeFactory
    {
        
        IUnityContainer container;
        public TypeFactory(IUnityContainer container)
        {
            this.container = container;
        }
        #region ITypeFactory Members

        public T Get<T>()
        {
            return container.Resolve<T>();
        }
        public T Get<T>(string name)
        {
            return container.Resolve<T>(name);
        }

        public object Get(Type t)
        {
            return container.Resolve(t);
        }

        #endregion
    }
}
