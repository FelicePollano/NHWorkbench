using System;
namespace NHibernate.Tool.WorkBench.Core
{
    public interface IProbe
    {
        string[] Assemblies { get; set; }
        void Configure();
        string[] ExecuteQuery(string hql, int first, int max);
        System.Collections.Generic.IEnumerable<string> GetProperties(string path);
        ExecutedHqlResults HqlToSql(string hql);
        string Imports { get; }
        string LoggerURI { get; set; }
        string ToolPath { get; set; }
    }
}
