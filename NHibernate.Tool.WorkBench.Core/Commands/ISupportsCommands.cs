// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHibernate.Tool.WorkBench.Core.Commands
{
    public interface ISupportsCommands
    {
        CommandBinding[] Bindings{ get;}
        bool Active { get; }
    }
}
