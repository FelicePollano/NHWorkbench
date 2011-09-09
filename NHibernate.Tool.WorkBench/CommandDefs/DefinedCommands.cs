// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Tool.WorkBench.Core.Commands;

namespace NHibernate.Tool.WorkBench.CommandDefs
{
    static class DefinedCommands
    {
        public static readonly Command NewProject = new Command();
        public static readonly Command SaveProject = new Command();
        public static readonly Command SaveProjectAs = new Command();
        public static readonly Command OpenProject = new Command();
        public static readonly Command Save = new Command();
        public static readonly Command SaveAs = new Command();
        public static readonly Command SelectAll = new Command();
        public static readonly Command Copy = new Command();
        public static readonly Command Cut = new Command();
        public static readonly Command Paste = new Command();
        public static readonly Command Undo = new Command();
        public static readonly Command Redo = new Command();
        public static readonly Command NewConfig = new Command();
        public static readonly Command NewMapping = new Command();
        public static readonly Command NewHql = new Command();
        public static readonly Command OpenFile = new Command();
        public static readonly Command CreateProbe = new Command();
        public static readonly Command Run = new Command();

    }
}