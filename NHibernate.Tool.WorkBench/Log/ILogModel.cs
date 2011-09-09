using System;
namespace NHibernate.Tool.WorkBench.Log
{
    interface ILogModel
    {
        void Clear();
        int Debugs { get; }
        event EventHandler DebugsCountChanged;
        int Errors { get; }
        event EventHandler ErrorsCountChanged;
        int Messages { get; }
        event EventHandler MessagesCountChanged;
        int Warnings { get; }
        event EventHandler WarningsCountChanged;
    }
}
