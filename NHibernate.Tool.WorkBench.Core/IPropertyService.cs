using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHibernate.Tool.WorkBench.Core
{
    public interface IPropertyService
    {
        object GetProperty(string name);
    }
}
