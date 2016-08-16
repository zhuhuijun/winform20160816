using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Threading;
using ControlHelper;
using Utils.Helper;
namespace WinformFrameSet
{
    public partial class MainForm : Form
    {
        Form1 form1 = null;
        private Thread saveDataPackageThread = null;
        #region 属性
        /// <summary>
        /// XML帮助类
        /// </summary>
        private XmlUtils xml = null;
        //是否提示设置为开机启动项
        private bool isOne = true;
        private bool isAutoStartOk;
        public bool IsAutoStartOk
        {
            get { return isAutoStartOk; }
            set { isAutoStartOk = value; }
        }
        //是否可以关闭
        private bool IsClose = false;
        #endregion

        #region 构造方法
        /// <summary>默认构造方法
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            try
            {
                InitConfig();
                //窗口显示事件
                this.Load += new EventHandler(SoftMain_Load);
                Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
            }
            catch (Exception ex)
            {
                this.UIInvoke(() =>
                {
                    this.listBoxmsg.Items.Insert(0, "出现如下错误：" + ex.Message);
                    this.listBoxmsg.Items[0].ForeColor = Color.Red;
                });
            }
        }
        /// <summary>load事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SoftMain_Load(object sender, EventArgs e)
        {
            #region 卸载事件及启动状态设置
            if (isOne)
            {
                //询问是否设置成开机启动项
                IsAutoStart();
                if (!this.IsAutoStartOk)
                {
                    this.tsBtnCannelAuto.Image = Properties.Resources.AutoStart;
                    this.tsBtnCannelAuto.Text = "设为自启";
                }
                this.Load -= new EventHandler(SoftMain_Load);
            }
            #endregion
        }
        /// <summary>退出的委托事件
        /// </summary>退出的委托事件
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Application_ApplicationExit(object sender, EventArgs e)
        {
            this.Runtimer.Stop();
            this.Runtimer.Dispose();
        }

        #endregion
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (form1 == null)
            {
                form1 = new Form1();
            }
            else
            {
                form1.Activate();
            }
            form1.MdiParent = this;
            form1.Show();

        }

        #region 基础方法
        /// <summary>
        /// 初始化配置文件
        /// </summary>
        private void InitConfig()
        {
            try
            {
                xml = new XmlUtils("ConfigPath", "SystemConfig.xml");
               // cfm = xml.Deserialize(typeof(ConfigModel)) as ConfigModel;
            }
            catch (Exception ex)
            {
                this.UIInvoke(() =>
                {
                    this.listBoxmsg.Items.Insert(0, "出现如下错误：" + ex.Message);
                    this.listBoxmsg.Items[0].ForeColor = Color.Red;
                });
            }
        }
        private void IsAutoStart()
        {
            try
            {
                this.isOne = false;
                RegistryKey hklm = Registry.LocalMachine;
                RegistryKey run = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                //未设置开机启动
                if (run.GetValue("YutuDataAnalyzing") == null)
                {
                    DialogResult result = MessageBox.Show("此程序尚未设置成开机启动，强烈建议设置为开机启动！现在设置吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        register();
                        this.IsAutoStartOk = true;
                    }
                    else
                    {
                        this.IsAutoStartOk = false;
                    }
                }
                else
                {
                    this.IsAutoStartOk = true;
                }
            }
            catch
            {
                MessageBox.Show("请以管理员身份运行程序！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.IsAutoStartOk = false;
            }
        }
        /// <summary>
        /// 将程序的开机启动写入注册表
        /// </summary>
        private void register()
        {
            string starupPath = Application.ExecutablePath;
            //class Micosoft.Win32.RegistryKey. 表示Window注册表中项级节点,此类是注册表装.
            RegistryKey loca = Registry.LocalMachine;
            RegistryKey run = loca.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
            try
            {
                run.SetValue("YutuDataAnalyzing", starupPath);
                MessageBox.Show("开机自动启动添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loca.Close();
                run.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region 事件
        /// <summary>窗体关闭事件
        /// 窗体关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (!IsClose)
                {
                    DialogResult result = MessageBox.Show("确定要将程序隐藏到任务栏吗？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        this.ShowInTaskbar = false;
                        this.Hide();
                        this.MynotifyIcon.ShowBalloonTip(10 * 1000, "提示", "通过系统托盘中的小图标，可快速回到系统主界面！", ToolTipIcon.Info);
                        this.ShowContextMenuStrip.Enabled = true;
                        e.Cancel = true;
                    }
                    if (result == DialogResult.No)
                    {
                        IsClose = true;
                        this.Close();
                        e.Cancel = false;
                        return;
                    }
                    if (result == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                    e.Cancel = true;
                }
                else
                {
                    IsClose = false;
                }
            }
            catch (Exception ex)
            {
                this.UIInvoke(() =>
                {
                    this.listBoxmsg.Items.Insert(0, "出现如下错误：" + ex.Message);
                    this.listBoxmsg.Items[0].ForeColor = Color.Red;
                });
            }
        }
        /// <summary>显示主窗口
        /// 显示主窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.ShowInTaskbar = true;
                this.Show();
                this.ShowContextMenuStrip.Enabled = false;
                //this.treeViews.ExpandAll();
                // Win32.AnimateWindow(this.Handle, 2000, Win32.AW_HOR_NEGATIVE);
            }
            catch (Exception ex)
            {
                this.UIInvoke(() =>
                {
                    this.listBoxmsg.Items.Insert(0, "出现如下错误：" + ex.Message);
                    this.listBoxmsg.Items[0].ForeColor = Color.Red;
                });
            }
        }
        /// <summary>退出程序
        /// 退出程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.ShowInTaskbar = false;
                IsClose = true;
                this.Close();
            }
            catch (Exception ex)
            {
                this.UIInvoke(() =>
                {
                    this.listBoxmsg.Items.Insert(0, "出现如下错误：" + ex.Message);
                    this.listBoxmsg.Items[0].ForeColor = Color.Red;
                });
            }

        }
        #endregion

    }
}
