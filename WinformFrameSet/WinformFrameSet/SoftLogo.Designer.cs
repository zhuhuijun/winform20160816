namespace WinformFrameSet
{
    partial class SoftLogo
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
            this.lbShowMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbShowMsg
            // 
            this.lbShowMsg.AutoSize = true;
            this.lbShowMsg.BackColor = System.Drawing.Color.Transparent;
            this.lbShowMsg.ForeColor = System.Drawing.Color.Transparent;
            this.lbShowMsg.Location = new System.Drawing.Point(253, 292);
            this.lbShowMsg.Name = "lbShowMsg";
            this.lbShowMsg.Size = new System.Drawing.Size(0, 12);
            this.lbShowMsg.TabIndex = 0;
            // 
            // SoftLogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinformFrameSet.Properties.Resources.数据解析启动1;
            this.ClientSize = new System.Drawing.Size(581, 337);
            this.Controls.Add(this.lbShowMsg);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SoftLogo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoftLogo";
            this.Load += new System.EventHandler(this.SoftLogo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbShowMsg;
    }
}