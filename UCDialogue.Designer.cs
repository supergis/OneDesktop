﻿namespace OneDesktop
{
    partial class UCDialogue
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDialogue));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbConnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.textMsg = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.tbSendMsg = new System.Windows.Forms.ToolStripButton();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.textMsgInput = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbConnect,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripButton3,
            this.toolStripButton7,
            this.toolStripButton8});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(246, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbConnect
            // 
            this.tbConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbConnect.Image = ((System.Drawing.Image)(resources.GetObject("tbConnect.Image")));
            this.tbConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbConnect.Name = "tbConnect";
            this.tbConnect.Size = new System.Drawing.Size(23, 22);
            this.tbConnect.Text = "登录到协同服务器";
            this.tbConnect.Click += new System.EventHandler(this.tbConnect_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "设置协同服务参数";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "toolStripButton7";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "toolStripButton8";
            // 
            // textMsg
            // 
            this.textMsg.Dock = System.Windows.Forms.DockStyle.Top;
            this.textMsg.Location = new System.Drawing.Point(0, 25);
            this.textMsg.Multiline = true;
            this.textMsg.Name = "textMsg";
            this.textMsg.Size = new System.Drawing.Size(246, 155);
            this.textMsg.TabIndex = 5;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitter1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 180);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(246, 10);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.tbSendMsg});
            this.toolStrip2.Location = new System.Drawing.Point(0, 190);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip2.Size = new System.Drawing.Size(246, 25);
            this.toolStrip2.TabIndex = 8;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton2";
            // 
            // tbSendMsg
            // 
            this.tbSendMsg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbSendMsg.Image = ((System.Drawing.Image)(resources.GetObject("tbSendMsg.Image")));
            this.tbSendMsg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSendMsg.Name = "tbSendMsg";
            this.tbSendMsg.Size = new System.Drawing.Size(23, 22);
            this.tbSendMsg.Text = "SendMsg";
            this.tbSendMsg.Click += new System.EventHandler(this.tbSendMsg_Click);
            // 
            // textStatus
            // 
            this.textStatus.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textStatus.Location = new System.Drawing.Point(0, 358);
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(246, 21);
            this.textStatus.TabIndex = 10;
            this.textStatus.Text = "Status";
            // 
            // textMsgInput
            // 
            this.textMsgInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textMsgInput.Location = new System.Drawing.Point(0, 215);
            this.textMsgInput.Multiline = true;
            this.textMsgInput.Name = "textMsgInput";
            this.textMsgInput.Size = new System.Drawing.Size(246, 143);
            this.textMsgInput.TabIndex = 11;
            // 
            // UCDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textMsgInput);
            this.Controls.Add(this.textStatus);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.textMsg);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UCDialogue";
            this.Size = new System.Drawing.Size(246, 379);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbConnect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.TextBox textMsg;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton tbSendMsg;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.TextBox textStatus;
        private System.Windows.Forms.TextBox textMsgInput;

    }
}
