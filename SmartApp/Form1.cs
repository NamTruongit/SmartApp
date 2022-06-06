using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartApp
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void lbSetting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FSetting fSetting = new FSetting();
            this.Hide();
            fSetting.ShowDialog();
            this.Show();
        }

        #region properties
        private string status = "";



        #endregion end properties
        #region method
        private void check(Panel panel)
        {
            RadioButton rb = null;
            if (rb != null)
            {
                MessageBox.Show(rb.Text);
            }
        }

        #endregion end method

        #region event
        private void RdClient_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {
                status = radioButton.Text;
            }
        }

        private void RdServer_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {
                status = radioButton.Text;
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (status == "Client")
            {
                MessageBox.Show("Client is running");
            }
            else if (status == "Server")
            {
                MessageBox.Show("Server is running");
            }
            else
            {
                MessageBox.Show("Select 1 of them");
            }
        }
        #endregion event

    }
}
