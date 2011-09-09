using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System.IO;
using NHibernate.Tool.hbm2net;

namespace NHibernate.Tool.WorkBench.Tasks
{
    public class Hbm2netTask:Task,IFileCreationObserver
    {
        public Hbm2netTask()
        {

        }
        public override bool Execute()
        {
            string configFile = Path.GetTempFileName();


            string[] args = new string[] { ".\\*.hbm.xml", "--output=generated" };
            //CodeGenerator.Generate(args, this);
            return true;
        }

        #region IFileCreationObserver Members

        public void FileCreated(string path)
        {
            
        }

        #endregion
    }
}
