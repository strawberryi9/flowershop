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
    public partial class floweradd : Form
    {
        public floweradd()
        {
            InitializeComponent();
        }
        private void floweradd_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "select iid from inventory";
                SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
                while (sdr.Read()) { cbid.Items.Add(sdr["iid"].ToString()); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void cbid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from inventory where iid='" + cbid.Text + "'";
                SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
                while (sdr.Read())
                {
                    tbiname.Text = sdr["iname"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btok_Click(object sender, EventArgs e)
        {
            string flanguage = tbflanguage.Text.Trim();
            string fname = tbfname.Text.Trim();
            string fprice = tbfprice.Text.Trim();
            string salecost = tbfsalecost.Text.Trim();
            string iid = cbid.Text.Trim();
            if (flanguage == "" || fname == "" || fprice == "" || salecost == "" || iid == "")
            {
                MessageBox.Show("请输入完整信息！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                string sql = "select * from flower where fname='" + fname + "'";
                if (SqlHelper.ExecuteScalar(sql) == null)
                {
                    sql = string.Format("insert into flower values('{0}','{1}',{2},{3},{4})", fname, flanguage, fprice, salecost, iid);
                    if (SqlHelper.ExecuteUpdate(sql) > 0)
                    {
                        MessageBox.Show("添加鲜花信息成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("鲜花名称：" + fname + "已经存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            tbflanguage.Text = "";
            tbfname.Text = "";
            tbfprice.Text = "";
            tbfsalecost.Text = "";
            cbid.Text = "--请选择仓库编号--";
            tbiname.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

       

      
    }
}
