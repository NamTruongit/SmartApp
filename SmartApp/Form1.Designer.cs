namespace SmartApp
{
    partial class FMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RdClient = new System.Windows.Forms.RadioButton();
            this.RdServer = new System.Windows.Forms.RadioButton();
            this.lbSetting = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // RdClient
            // 
            this.RdClient.AutoSize = true;
            this.RdClient.Location = new System.Drawing.Point(50, 17);
            this.RdClient.Margin = new System.Windows.Forms.Padding(4);
            this.RdClient.Name = "RdClient";
            this.RdClient.Size = new System.Drawing.Size(68, 25);
            this.RdClient.TabIndex = 0;
            this.RdClient.TabStop = true;
            this.RdClient.Text = "Client";
            this.RdClient.UseVisualStyleBackColor = true;
            this.RdClient.CheckedChanged += new System.EventHandler(this.RdClient_CheckedChanged);
            // 
            // RdServer
            // 
            this.RdServer.AutoSize = true;
            this.RdServer.Location = new System.Drawing.Point(50, 62);
            this.RdServer.Margin = new System.Windows.Forms.Padding(4);
            this.RdServer.Name = "RdServer";
            this.RdServer.Size = new System.Drawing.Size(73, 25);
            this.RdServer.TabIndex = 0;
            this.RdServer.TabStop = true;
            this.RdServer.Text = "Server";
            this.RdServer.UseVisualStyleBackColor = true;
            this.RdServer.CheckedChanged += new System.EventHandler(this.RdServer_CheckedChanged);
            // 
            // lbSetting
            // 
            this.lbSetting.AutoSize = true;
            this.lbSetting.Location = new System.Drawing.Point(267, 9);
            this.lbSetting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSetting.Name = "lbSetting";
            this.lbSetting.Size = new System.Drawing.Size(59, 21);
            this.lbSetting.TabIndex = 1;
            this.lbSetting.TabStop = true;
            this.lbSetting.Text = "Setting";
            this.lbSetting.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbSetting_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.RdClient);
            this.panel1.Controls.Add(this.RdServer);
            this.panel1.Location = new System.Drawing.Point(86, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 122);
            this.panel1.TabIndex = 2;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(86, 170);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 34);
            this.BtnStart.TabIndex = 3;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(178, 170);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(75, 34);
            this.BtnStop.TabIndex = 3;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(245, 343);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(74, 21);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Database";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 373);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbSetting);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RdClient;
        private System.Windows.Forms.RadioButton RdServer;
        private System.Windows.Forms.LinkLabel lbSetting;
        private System.Windows.Forms.Panel panel1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
