using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FlowerShop.method;

namespace FlowerShop
{
    public partial class retailselect : Form
    {
        public retailselect()
        {
            InitializeComponent();
        }

        private void retailselect_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "select fid from flower";
                SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
                while (sdr.Read()) { cmbfid.Items.Add(sdr["fid"].ToString()); }
                sql = string.Format("select rid from resale");
                SqlDataReader sdr1 = SqlHelper.ExecuteReader(sql);
                while (sdr1.Read()) { cmbrid.Items.Add(sdr1["rid"].ToString()); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmbrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbfid.Text = "--请选择编号--";
            try
            {
              
                if (cmbrid.Text != "--请选择编号--")
                {
                    string sql1 = "select rid as 零售编号,fid as 花编号,rnumber as 零售数量,rdate as 零售时间 from resale where rid='" + cmbrid.Text.Trim() + "'";
                    dataGridView1.DataSource = SqlHelper.GetTable(sql1);
                    cmbrid.Text = "--请选择编号--";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void cmbfid_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbrid.Text = "--请选择编号--";
            try
            {
                if (cmbfid.Text != "--请选择编号--")
                {
                    string sql = "select rid as 零售编号,fid as 花编号,rnumber as 零售数量,rdate as 零售时间 from resale where fid='" + cmbfid.Text.Trim() + "'";
                    dataGridView1.DataSource = SqlHelper.GetTable(sql);
                    cmbfid.Text = "--请选择编号--";
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btselect_Click(object sender, EventArgs e)
        {
            cmbfid.Text = "--请选择编号--";
            cmbrid.Text = "--请选择编号--";
            try
            {
               
                    string sql = "select rid as 零售编号,fid as 花编号,rnumber as 零售数量,rdate as 零售时间 from resale ";
                    dataGridView1.DataSource = SqlHelper.GetTable(sql);
                 
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";
            cmbfid.Text = "--请选择编号--";
            cmbrid.Text = "--请选择编号--";
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        
    }
}
