// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHibernate.Tool.WorkBench.Core.Commands
{
    public class CommandBinding
    {
        public Command Command {get;set;}
        public Action Execute { get; set; }
        public Func<bool> CanExecute { get; set; }
    }
}
