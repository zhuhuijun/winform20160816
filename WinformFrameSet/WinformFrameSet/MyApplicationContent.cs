using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinformFrameSet
{
    //WinForm里，默认第一个创建的窗体是主窗体，所以需要用应用程序域来管理
    public class MyApplicationContent : ApplicationContext
    {
        private Form realMainForm;
        /// <summary>
        ///构造函数
        /// </summary>
        /// <param name="mainForm">主窗口</param>
        /// <param name="flashForm">渲染的窗口</param>
        public MyApplicationContent(Form mainForm, Form flashForm)
            : base(mainForm)
        {
            this.realMainForm = mainForm;
            this.MainForm = flashForm;
        }

        protected override void OnMainFormClosed(object sender, EventArgs e)
        {
            if (sender is SoftLogo)
            {
                SoftLogo frm = sender as SoftLogo;
                if (!frm.Exit)
                {
                    this.MainForm = realMainForm;
                    realMainForm.Show();
                }
                else
                {
                    base.OnMainFormClosed(sender, e);
                }
            }
            else
            {
                base.OnMainFormClosed(sender, e);
            }
        }
    }
}
