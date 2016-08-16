using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace WinformFrameSet
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Mutex menux = new Mutex(true, "OnlyRun");
            if (menux.WaitOne(0, false))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                MyApplicationContent appContent = new MyApplicationContent(new MainForm(), new SoftLogo());
                Application.Run(appContent);
            }
            else
            {
                MessageBox.Show("已有一个程序已经在运行,请不要开启多个!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }
        /// <summary>
        /// 定义一个委托，用来更新主界面消息
        /// </summary>
        /// <param name="o"></param>
        public delegate void UiThreadProc(Object o);
        /// <summary>
        /// 完成耗时操作，界面提示不至于界面假死
        /// </summary>
        /// <param name="parm"></param>
        public static void InitApp(Object parm)
        {
            SoftLogo startup = parm as SoftLogo;
            startup.Invoke(new UiThreadProc(startup.PrintMsg), "正在初始化...");
            Thread.Sleep(500);
            startup.Invoke(new UiThreadProc(startup.PrintMsg), "系统初始化完成...");
            Thread.Sleep(1000);
            startup.Invoke(new UiThreadProc(startup.PrintMsg), "正在登入系统主界面，请稍后...");
            Thread.Sleep(500);
            startup.Invoke(new UiThreadProc(startup.CloseForm), false);
        }
    }
}
