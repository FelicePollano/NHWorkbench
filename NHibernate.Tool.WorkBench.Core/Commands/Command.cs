// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHibernate.Tool.WorkBench.Core.Commands
{
    public  class Command
    {
        public string ID { get; set; }
        public Command()
        {
            ID = Guid.NewGuid().ToString();
        }
    }
}
