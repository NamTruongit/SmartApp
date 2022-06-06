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
    }
}
