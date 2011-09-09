// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Tool.WorkBench.Core;

namespace NHibernate.Tool.WorkBench
{
    public interface IQueryTranslator
    {
        ExecutedHqlResults Translate(string hql);
        string[] Execute(string hql, int firstResult, int maxResults);
    }
}
