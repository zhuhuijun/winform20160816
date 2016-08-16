using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ControlHelper;
using System.Threading;

namespace WinformFrameSet
{
    public partial class SoftLogo : Form
    {
        #region 属性
        /// <summary>
        /// 判断界面是否已经退出
        /// </summary>
        private bool exit;
        public bool Exit
        {
            get { return exit; }
        }
        #endregion

        #region 构造方法
        public SoftLogo()
        {
            InitializeComponent();
            //设置背景图片某部分透明
            FormBackgroundHelper helper = new FormBackgroundHelper(this, new Bitmap(this.BackgroundImage));
            helper.CreateControlRegion();
        }
        #endregion

        #region 事件
        /// <summary>
        /// 页面加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SoftLogo_Load(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(Program.InitApp), this);
        }
        //关闭启动窗体，如果需要中止程序，传参数false
        public void CloseForm(Object o)
        {
            this.exit = Convert.ToBoolean(o);
            this.Close();
        }
        #endregion

        #region 打印消息
        /// <summary>
        /// 消息提示
        /// </summary>
        /// <param name="msg"></param>
        public void PrintMsg(Object msg)
        {
             lbShowMsg.Text = msg.ToString();
        }
        #endregion

    }
}
