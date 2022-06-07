namespace SmartApp
{
    partial class FData
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
            this.CbData = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbLink = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Database";
            // 
            // CbData
            // 
            this.CbData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbData.FormattingEnabled = true;
            this.CbData.Items.AddRange(new object[] {
            "DaNang",
            "Hue",
            "SaiGon"});
            this.CbData.Location = new System.Drawing.Point(228, 28);
            this.CbData.Name = "CbData";
            this.CbData.Size = new System.Drawing.Size(298, 29);
            this.CbData.TabIndex = 1;
            this.CbData.SelectedIndexChanged += new System.EventHandler(this.CbData_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select :";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(296, 74);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(25, 21);
            this.lbData.TabIndex = 2;
            this.lbData.Text = ".....";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "LinkDatabase :";
            // 
            // lbLink
            // 
            this.lbLink.AutoSize = true;
            this.lbLink.Location = new System.Drawing.Point(346, 104);
            this.lbLink.Name = "lbLink";
            this.lbLink.Size = new System.Drawing.Size(28, 21);
            this.lbLink.TabIndex = 4;
            this.lbLink.Text = "......";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1005, 418);
            this.dataGridView1.TabIndex = 5;
            // 
            // FData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 580);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbLink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbData);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbLink;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}