using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HqlIntellisense;

namespace Fatica.Labs.HqlEditor.TestBed
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            hqlEditor1.NHConfigDataProvider = new SimpleConfigurationProvider(TestHqlIntellisense.Tests.CreateCfg());
        }
    }
}
