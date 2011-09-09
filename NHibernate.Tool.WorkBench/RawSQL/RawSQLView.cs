using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using NHibernate.Tool.WorkBench.Core.WireAttributes;
using NHibernate.Tool.WorkBench.Core;

namespace NHibernate.Tool.WorkBench.RawSQL
{
    [PresenterView(Singleton = true)]
    public partial class RawSQLView :  DockContent
    {
        public RawSQLView(MainForm form)
        {
            InitializeComponent();
            this.DockAreas = ~DockAreas.Document;
            ShowHint = DockState.DockBottom;
            Show(form.DockPanel);
        }

        public void ShowResults(ExecutedHqlResults executedHqlResults)
        {
            SetSQL(executedHqlResults.Body,null!=executedHqlResults.Exception? executedHqlResults.Exception.Message:"");
        }
        private void SetSQL(string sql, string error)
        {
            this.textBoxSQL.Text = sql;
            if (!string.IsNullOrEmpty(error))
            {
                panelError.Visible = true;
                labelErrorText.Text = error;
            }
            else
            {
                panelError.Visible = false;
            }

        }
    }
}
