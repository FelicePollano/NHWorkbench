// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHibernate.Tool.WorkBench.Core.Commands
{
    public interface ICommandRouter
    {
        void Register(ISupportsCommands agent);
        void Unregister(ISupportsCommands agent);
        void BindToUI<T>(Command cmd,T UIItem, string executeEvent, Action<T,bool> updateAction);
        void Execute(Command cmd);
        event EventHandler PreExecute;
        event EventHandler<ExecutingExceptionEventArgs> ExceptionExecuting;
    }
}
