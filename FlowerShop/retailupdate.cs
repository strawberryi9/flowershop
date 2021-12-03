using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using FlowerShop.method;


namespace FlowerShop
{
    public partial class retailupdate : Form
    {
        public retailupdate()
        {
            InitializeComponent();
        }
        inputnumber num = new inputnumber();

        private void retailupdate_Load(object sender, EventArgs e)
        {

            num.ForceNumberInput(tbinumber);
            try
            {
                string sql = "select fid from flower";
                SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
                while (sdr.Read()) { cmbfid.Items.Add(sdr["fid"].ToString()); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "数据库操作失败提示");
            }
        }

        private void cmbfid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select flower.fid,fname,fsalecost,rnumber,rdate from flower,resale where flower.fid =resale.fid and flower.fid='" + cmbfid.Text + "'";
                SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
                while (sdr.Read())
                {
                    tbfname.Text = sdr["fname"].ToString();
                    tbfsalecost.Text = sdr["fsalecost"].ToString();
                    tbinumber.Text = sdr["rnumber"].ToString();
                    dtptime.Text = sdr["rdate"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "数据库操作失败提示");
            }
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("update resale set fid='{0}',rnumber='{1}',rdate='{2}' where fid='{3}'", cmbfid.Text.Trim(), tbinumber.Text.Trim(), dtptime.Text.Trim(), cmbfid.Text.Trim());
                if (SqlHelper.ExecuteUpdate(sql) > 0)
                {
                    MessageBox.Show("修改零售信息成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("修改零售信息失败！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            tbinumber.Text = "";
            tbfsalecost.Text = "";
            tbfname.Text = "";
            dtptime.Text = DateTime.Now.ToLongDateString();
            cmbfid.Text = "--请选择编号--";
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
