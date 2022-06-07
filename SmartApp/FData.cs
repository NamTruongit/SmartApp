using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartApp
{
    public partial class FData : Form
    {
        public FData()
        {
            InitializeComponent();
        }

        #region Properties
        private static SqlConnection cn;
        private static SqlCommand cmd;
        private string ConnectionStr ="";
        #endregion end properties

        #region Method
    
        private void LoadData(string ConnectionStr)
        {
            using (cn = new SqlConnection(ConnectionStr))
            {
                cn.Open();
                string qery = "select * from dbo.customer";
                cmd = new SqlCommand(qery, cn);
                
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                cn.Close();
                dataGridView1.DataSource = table;
            }
        }


        #endregion Method

        #region events
        private void CbData_SelectedIndexChanged(object sender, EventArgs e)
        {

            lbData.Text = CbData.Text;

            string text = CbData.Text;
            switch (text)
            {
                case "Hue":
                    lbLink.Text = ConfigurationManager.AppSettings["HueDatabase"];
                    LoadData(lbLink.Text);
                    break;
                case "DaNang":
                    lbLink.Text = ConfigurationManager.AppSettings["DaNangDatabase"];
                    LoadData(lbLink.Text);
                    break;
                case "SaiGon":
                    lbLink.Text = ConfigurationManager.AppSettings["SaiGonDatabase"];
                    LoadData(lbLink.Text);
                    break;

                default:
                    break;
            }
        }
        #endregion end events


    }
}
