using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartApp
{
    public partial class FSetting : Form
    {
        public FSetting()
        {
            InitializeComponent();
        }
        Configuration config;

        private void getData(int time, string path, string pathLocal, string databasseName, bool autoUpdate)
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["time"].Value = Convert.ToString(time);
            config.AppSettings.Settings["path"].Value = path;
            config.AppSettings.Settings["pathLocal"].Value = pathLocal;
            config.AppSettings.Settings["dataName"].Value = databasseName;
            config.AppSettings.Settings["autoUpdate"].Value = Convert.ToString(autoUpdate);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSetting");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void CkbAutoUpdate_CheckStateChanged(object sender, EventArgs e)
        {


        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog openFileDialog = new CommonOpenFileDialog();
            openFileDialog.IsFolderPicker = true;
            if (openFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtPath.Text = openFileDialog.FileName;
            }

        }

        private void btnSelectLocal_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog openFileDialog = new CommonOpenFileDialog();
            openFileDialog.IsFolderPicker = true;
            if (openFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtPathlocal.Text = openFileDialog.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int time = Convert.ToInt32(CbTime.Text);
            string path = txtPath.Text;
            string pathLocal = txtPathlocal.Text;
            string databasseName = CbDataName.Text;
            bool autoUpdate = false;
            if (autoUpdate == CkbAutoUpdate.Checked)
            {
                autoUpdate = true;
            }
            getData(time,path,pathLocal,databasseName,autoUpdate);
        }
    }
}
