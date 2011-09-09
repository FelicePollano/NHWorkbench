// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NHibernate.Tool.WorkBench.Core.WireAttributes.UiHelpers
{
    public class WaitCursor:IDisposable
    {
        public WaitCursor()
        {
            Cursor.Current = Cursors.WaitCursor;
        }
        #region IDisposable Members

        public void Dispose()
        {
            Cursor.Current = Cursors.Default;
        }

        #endregion
    }
}
