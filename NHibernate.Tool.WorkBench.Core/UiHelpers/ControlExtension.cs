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

    public static class ControlExtentions
    {
        public delegate void InvokeHandler();
        public static bool SafeInvoke(this Control control, InvokeHandler handler)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(handler);
                return false;
            }
            else
                handler.Invoke();
            return true;
        }

    }
}
