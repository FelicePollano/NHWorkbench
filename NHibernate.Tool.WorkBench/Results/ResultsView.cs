using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate.Tool.WorkBench.Core.WireAttributes;
using WeifenLuo.WinFormsUI.Docking;

namespace NHibernate.Tool.WorkBench.Results
{
    [PresenterView(Singleton=true)]
    public partial class ResultsView : DockContent
    {
        public ResultsView(MainForm form)
        {
            InitializeComponent();
            ShowHint = DockState.DockRight;
            this.DockAreas = ~DockAreas.Document;
            Show(form.DockPanel);
            listViewResults.RetrieveVirtualItem += new RetrieveVirtualItemEventHandler(listViewResults_RetrieveVirtualItem);
            listViewResults.DrawItem += new DrawListViewItemEventHandler(listViewResults_DrawItem);
            listViewResults.DrawColumnHeader += new DrawListViewColumnHeaderEventHandler(listViewResults_DrawColumnHeader);
        }

        void listViewResults_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
            
        }

        void listViewResults_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            if (0 != (e.State & ListViewItemStates.Selected))
            {
                e.Graphics.FillRectangle(Brushes.Yellow, e.Bounds);
                //ForeColor = Color.White;
            }
            else
            {
                //ForeColor = Color.Black;
                if (e.ItemIndex % 2 == 0)
                {
                    e.Graphics.FillRectangle(Brushes.BlanchedAlmond, e.Bounds);
                }
                else
                {
                    e.Graphics.FillRectangle(Brushes.White, e.Bounds);
                }
                if (0 != (e.State & ListViewItemStates.Focused))
                {
                    e.DrawFocusRectangle();
                }
            }
            e.DrawText();
        }

        void listViewResults_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (e.ItemIndex >= 0 && e.ItemIndex < dataStream.Length)
            {
                e.Item = new ListViewItem(dataStream[e.ItemIndex]);
            }
        }
        string[] dataStream = new string[0];
        public void ShowResults(string[] p)
        {
            dataStream = p;
            listViewResults.VirtualListSize = p.Length;
            listViewResults.Refresh();
        }
    }
}
