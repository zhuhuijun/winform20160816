namespace WinformFrameSet
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MymenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.FrameSettoolStrip = new System.Windows.Forms.ToolStrip();
            this.tsblistener = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbStatistics = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnCannelAuto = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.MystatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Runtimer = new System.Windows.Forms.Timer(this.components);
            this.CreateTimer = new System.Windows.Forms.Timer(this.components);
            this.ShowContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MynotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBoxMsg = new System.Windows.Forms.GroupBox();
            this.listBoxmsg = new System.Windows.Forms.ListView();
            this.MymenuStrip.SuspendLayout();
            this.FrameSettoolStrip.SuspendLayout();
            this.MystatusStrip.SuspendLayout();
            this.ShowContextMenuStrip.SuspendLayout();
            this.groupBoxMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // MymenuStrip
            // 
            this.MymenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.MymenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MymenuStrip.Name = "MymenuStrip";
            this.MymenuStrip.Size = new System.Drawing.Size(921, 25);
            this.MymenuStrip.TabIndex = 0;
            this.MymenuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(58, 21);
            this.toolStripMenuItem1.Text = "文件(F)";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(59, 21);
            this.toolStripMenuItem2.Text = "编辑(E)";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(60, 21);
            this.toolStripMenuItem3.Text = "视图(V)";
            // 
            // FrameSettoolStrip
            // 
            this.FrameSettoolStrip.AutoSize = false;
            this.FrameSettoolStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.FrameSettoolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsblistener,
            this.toolStripSeparator1,
            this.tsbStatistics,
            this.toolStripSeparator2,
            this.tsBtnCannelAuto,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.toolStripSeparator4,
            this.toolStripLabel3});
            this.FrameSettoolStrip.Location = new System.Drawing.Point(0, 25);
            this.FrameSettoolStrip.Name = "FrameSettoolStrip";
            this.FrameSettoolStrip.Size = new System.Drawing.Size(69, 436);
            this.FrameSettoolStrip.TabIndex = 1;
            this.FrameSettoolStrip.Text = "toolStrip1";
            // 
            // tsblistener
            // 
            this.tsblistener.AutoToolTip = true;
            this.tsblistener.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.tsblistener.ForeColor = System.Drawing.Color.Red;
            this.tsblistener.Image = ((System.Drawing.Image)(resources.GetObject("tsblistener.Image")));
            this.tsblistener.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsblistener.Name = "tsblistener";
            this.tsblistener.Size = new System.Drawing.Size(67, 52);
            this.tsblistener.Text = "停止监听";
            this.tsblistener.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(67, 6);
            // 
            // tsbStatistics
            // 
            this.tsbStatistics.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.tsbStatistics.Image = ((System.Drawing.Image)(resources.GetObject("tsbStatistics.Image")));
            this.tsbStatistics.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbStatistics.Name = "tsbStatistics";
            this.tsbStatistics.Size = new System.Drawing.Size(67, 52);
            this.tsbStatistics.Text = "手动统计";
            this.tsbStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(67, 6);
            // 
            // tsBtnCannelAuto
            // 
            this.tsBtnCannelAuto.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.tsBtnCannelAuto.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnCannelAuto.Image")));
            this.tsBtnCannelAuto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnCannelAuto.Name = "tsBtnCannelAuto";
            this.tsBtnCannelAuto.Size = new System.Drawing.Size(67, 52);
            this.tsBtnCannelAuto.Text = "取消自启";
            this.tsBtnCannelAuto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(67, 6);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(67, 52);
            this.toolStripLabel1.Text = "清除消息";
            this.toolStripLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(67, 6);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.toolStripLabel3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel3.Image")));
            this.toolStripLabel3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(67, 52);
            this.toolStripLabel3.Text = "停止刷新";
            this.toolStripLabel3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MystatusStrip
            // 
            this.MystatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.MystatusStrip.Location = new System.Drawing.Point(69, 439);
            this.MystatusStrip.Name = "MystatusStrip";
            this.MystatusStrip.Size = new System.Drawing.Size(852, 22);
            this.MystatusStrip.TabIndex = 2;
            this.MystatusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.IsLink = true;
            this.toolStripStatusLabel1.LinkColor = System.Drawing.Color.Cyan;
            this.toolStripStatusLabel1.LinkVisited = true;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(212, 17);
            this.toolStripStatusLabel1.Text = "技术支持：中科宇图天下科技有限公司";
            // 
            // Runtimer
            // 
            this.Runtimer.Enabled = true;
            this.Runtimer.Interval = 1000;
            // 
            // ShowContextMenuStrip
            // 
            this.ShowContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.ShowContextMenuStrip.Name = "contextMenuStrip1";
            this.ShowContextMenuStrip.Size = new System.Drawing.Size(137, 48);
            // 
            // ShowToolStripMenuItem
            // 
            this.ShowToolStripMenuItem.Image = global::WinformFrameSet.Properties.Resources.Show;
            this.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem";
            this.ShowToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.ShowToolStripMenuItem.Text = "显示主界面";
            this.ShowToolStripMenuItem.Click += new System.EventHandler(this.ShowToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Image = global::WinformFrameSet.Properties.Resources.Close;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.ExitToolStripMenuItem.Text = "退出程序";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // MynotifyIcon
            // 
            this.MynotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.MynotifyIcon.BalloonTipText = "点击这里可以看到主界面";
            this.MynotifyIcon.BalloonTipTitle = "提示";
            this.MynotifyIcon.ContextMenuStrip = this.ShowContextMenuStrip;
            this.MynotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MynotifyIcon.Icon")));
            this.MynotifyIcon.Text = "数据解析程序";
            this.MynotifyIcon.Visible = true;
            // 
            // groupBoxMsg
            // 
            this.groupBoxMsg.Controls.Add(this.listBoxmsg);
            this.groupBoxMsg.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.groupBoxMsg.Location = new System.Drawing.Point(72, 27);
            this.groupBoxMsg.Name = "groupBoxMsg";
            this.groupBoxMsg.Size = new System.Drawing.Size(849, 409);
            this.groupBoxMsg.TabIndex = 5;
            this.groupBoxMsg.TabStop = false;
            this.groupBoxMsg.Text = "系统实时消息";
            // 
            // listBoxmsg
            // 
            this.listBoxmsg.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.listBoxmsg.Location = new System.Drawing.Point(6, 25);
            this.listBoxmsg.Name = "listBoxmsg";
            this.listBoxmsg.Size = new System.Drawing.Size(837, 378);
            this.listBoxmsg.TabIndex = 0;
            this.listBoxmsg.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 461);
            this.Controls.Add(this.groupBoxMsg);
            this.Controls.Add(this.MystatusStrip);
            this.Controls.Add(this.FrameSettoolStrip);
            this.Controls.Add(this.MymenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MymenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据解析程序";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MymenuStrip.ResumeLayout(false);
            this.MymenuStrip.PerformLayout();
            this.FrameSettoolStrip.ResumeLayout(false);
            this.FrameSettoolStrip.PerformLayout();
            this.MystatusStrip.ResumeLayout(false);
            this.MystatusStrip.PerformLayout();
            this.ShowContextMenuStrip.ResumeLayout(false);
            this.groupBoxMsg.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MymenuStrip;
        private System.Windows.Forms.ToolStrip FrameSettoolStrip;
        private System.Windows.Forms.StatusStrip MystatusStrip;
        private System.Windows.Forms.ToolStripLabel tsblistener;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tsbStatistics;
        private System.Windows.Forms.ToolStripLabel tsBtnCannelAuto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer Runtimer;
        private System.Windows.Forms.Timer CreateTimer;
        private System.Windows.Forms.ContextMenuStrip ShowContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon MynotifyIcon;
        private System.Windows.Forms.GroupBox groupBoxMsg;
        private System.Windows.Forms.ListView listBoxmsg;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}