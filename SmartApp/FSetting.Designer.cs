namespace SmartApp
{
    partial class FSetting
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
            this.label1 = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Panel();
            this.CbTime = new System.Windows.Forms.ComboBox();
            this.CkbAutoUpdate = new System.Windows.Forms.CheckBox();
            this.CbDataName = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSelectLocal = new System.Windows.Forms.Button();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.txtPathlocal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lbpath = new System.Windows.Forms.Label();
            this.b.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time";
            // 
            // b
            // 
            this.b.Controls.Add(this.CbTime);
            this.b.Controls.Add(this.CkbAutoUpdate);
            this.b.Controls.Add(this.CbDataName);
            this.b.Controls.Add(this.btnSave);
            this.b.Controls.Add(this.btnSelectLocal);
            this.b.Controls.Add(this.btnSelectPath);
            this.b.Controls.Add(this.txtPathlocal);
            this.b.Controls.Add(this.label2);
            this.b.Controls.Add(this.label3);
            this.b.Controls.Add(this.txtPath);
            this.b.Controls.Add(this.lbpath);
            this.b.Controls.Add(this.label1);
            this.b.Location = new System.Drawing.Point(12, 12);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(601, 308);
            this.b.TabIndex = 1;
            // 
            // CbTime
            // 
            this.CbTime.FormattingEnabled = true;
            this.CbTime.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "30",
            "40",
            "50",
            "60"});
            this.CbTime.Location = new System.Drawing.Point(194, 29);
            this.CbTime.Name = "CbTime";
            this.CbTime.Size = new System.Drawing.Size(212, 28);
            this.CbTime.TabIndex = 1;
            // 
            // CkbAutoUpdate
            // 
            this.CkbAutoUpdate.AutoSize = true;
            this.CkbAutoUpdate.Location = new System.Drawing.Point(194, 202);
            this.CkbAutoUpdate.Name = "CkbAutoUpdate";
            this.CkbAutoUpdate.Size = new System.Drawing.Size(116, 24);
            this.CkbAutoUpdate.TabIndex = 7;
            this.CkbAutoUpdate.Text = "Auto update";
            this.CkbAutoUpdate.UseVisualStyleBackColor = true;
            // 
            // CbDataName
            // 
            this.CbDataName.FormattingEnabled = true;
            this.CbDataName.Items.AddRange(new object[] {
            "Hue",
            "SaiGon",
            "DaNang"});
            this.CbDataName.Location = new System.Drawing.Point(194, 151);
            this.CbDataName.Name = "CbDataName";
            this.CbDataName.Size = new System.Drawing.Size(212, 28);
            this.CbDataName.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(321, 200);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 26);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSelectLocal
            // 
            this.btnSelectLocal.Location = new System.Drawing.Point(452, 108);
            this.btnSelectLocal.Name = "btnSelectLocal";
            this.btnSelectLocal.Size = new System.Drawing.Size(85, 26);
            this.btnSelectLocal.TabIndex = 5;
            this.btnSelectLocal.Text = "Select";
            this.btnSelectLocal.UseVisualStyleBackColor = true;
            this.btnSelectLocal.Click += new System.EventHandler(this.btnSelectLocal_Click);
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(452, 67);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(85, 26);
            this.btnSelectPath.TabIndex = 3;
            this.btnSelectPath.Text = "Select";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // txtPathlocal
            // 
            this.txtPathlocal.Location = new System.Drawing.Point(192, 108);
            this.txtPathlocal.Name = "txtPathlocal";
            this.txtPathlocal.Size = new System.Drawing.Size(214, 26);
            this.txtPathlocal.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Path save local";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(192, 67);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(214, 26);
            this.txtPath.TabIndex = 2;
            // 
            // lbpath
            // 
            this.lbpath.AutoSize = true;
            this.lbpath.Location = new System.Drawing.Point(36, 73);
            this.lbpath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbpath.Name = "lbpath";
            this.lbpath.Size = new System.Drawing.Size(42, 20);
            this.lbpath.TabIndex = 0;
            this.lbpath.Text = "Path";
            // 
            // FSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 334);
            this.Controls.Add(this.b);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.b.ResumeLayout(false);
            this.b.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel b;
        private System.Windows.Forms.TextBox txtPathlocal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lbpath;
        private System.Windows.Forms.ComboBox CbDataName;
        private System.Windows.Forms.Button btnSelectLocal;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CkbAutoUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox CbTime;
    }
}