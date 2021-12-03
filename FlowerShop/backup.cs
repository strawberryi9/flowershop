using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FlowerShop.method;
using System.Data.SqlClient;

namespace FlowerShop
{
    public partial class backup : Form
    {
        public backup()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtpath.Text = folderBrowserDialog1.SelectedPath.ToString();
            }
        }

        private void btok_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtpath.Text != "")
                {
                    Backup geCon = new Backup();
                    SqlConnection con = geCon.getsqlconnect();
                    string strBac1 = "backup database FlowerShop to disk='" + txtpath.Text.Trim() + "\\" + txtname.Text.Trim() + ".bak'";
                    SqlCommand Cmd = new SqlCommand(strBac1, con);
                    if (Cmd.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("数据备份成功！", "提示框", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("数据备份失败！", "提示框", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("请填写备份的正确位置及文件名", "提示框", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtpath.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
