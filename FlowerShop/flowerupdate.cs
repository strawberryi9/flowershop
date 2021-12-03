using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using FlowerShop.method;

namespace FlowerShop
{
    public partial class flowerupdate : Form
    {
        public flowerupdate()
        {
            InitializeComponent();
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowerupdate_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "select fname from flower";
                SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
                while (sdr.Read()) { cmbfname.Items.Add(sdr["fname"].ToString()); }
                string sql1 = string.Format("select iid from inventory");
                SqlDataReader sdr1 = SqlHelper.ExecuteReader(sql1);
                while (sdr1.Read()) { cmbiid.Items.Add(sdr1["iid"].ToString()); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string sql1 = string.Format("update flower set fname='{0}',flanguage='{1}',fprimecost='{2}',fsalecost='{3}',iid='{4}' where fid='{5}'", cmbfname.Text.Trim(), tbflanguage.Text.Trim(), tbfprice.Text.Trim(), tbfsalecost.Text.Trim(), cmbiid.Text.Trim(), tbfid.Text.Trim());
                if (SqlHelper.ExecuteUpdate(sql1) > 0)
                {
                    MessageBox.Show("修改鲜花信息成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("修改鲜花信息失败！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            tbfid.Text = "";
            tbflanguage.Text = "";
            tbfprice.Text = "";
            tbfsalecost.Text = "";
            cmbfname.Text = "--请选择花名--";
        }

        private void cmbfname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from flower where fname='" + cmbfname.Text + "'";
                SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
                while (sdr.Read())
                {
                    tbfid.Text = sdr["fid"].ToString();
                    tbflanguage.Text = sdr["flanguage"].ToString();
                    tbfprice.Text = sdr["fprimecost"].ToString();
                    tbfsalecost.Text = sdr["fsalecost"].ToString();
                    cmbiid.Text = sdr["iid"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "数据库操作失败提示");
            }
        }
    }
}
