// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Ors.Rams.UI.Integration.PartProgramManager;
using NHibernate.Tool.WorkBench.Main;
using NHibernate.Tool.WorkBench.Core;
using log4net;
using log4net.Config;


namespace NHibernate.Tool.WorkBench
{
    static class Program
    {
        static ITypeFactory factory;
        private const string NHIBERNATE_WORKBENCH_PATH = "NHIBERNATE_WORKBENCH_PATH";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            XmlConfigurator.Configure();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Environment.SetEnvironmentVariable(NHIBERNATE_WORKBENCH_PATH, typeof(Program).Assembly.Location, EnvironmentVariableTarget.User);
            factory = BootStrap.Boot(typeof(Program).Assembly.GetName().Name
                , typeof(Program).Assembly
                );
            IPresenter main  = factory.Get<MainPresenter>();
            AppDomain.CurrentDomain.AssemblyLoad += new AssemblyLoadEventHandler(CurrentDomain_AssemblyLoad);
            main.Startup();
            
        }

        static void CurrentDomain_AssemblyLoad(object sender, AssemblyLoadEventArgs args)
        {
            factory.Get<ILog>().Info(String.Concat("Loading ... ", args.LoadedAssembly.FullName));
        }
    }
}
