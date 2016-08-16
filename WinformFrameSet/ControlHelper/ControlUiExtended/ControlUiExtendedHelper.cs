using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlHelper
{
    public static class ControlUiExtendedHelper
    {
        /// <summary>
        /// 不带参数的处理方法
        /// </summary>
        public delegate void InvokeHandler();
        public static void UIInvoke(this Control control, InvokeHandler handler)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(handler);
            }
            else
            {
                handler();
            }
        }
    }
}
