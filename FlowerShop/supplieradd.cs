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
    public partial class supplieradd : Form
    {
        public supplieradd()
        {
            InitializeComponent();
        }
        inputnumber num = new inputnumber();

        private void supplieradd_Load(object sender, EventArgs e)
        {
            num.ForceNumberInput(tbphone);
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            string name = tbsname.Text.Trim();
            string address = tbaddress.Text.Trim();
            string phone = tbphone.Text.Trim();
            string remarks = tbremarks.Text.Trim();
            if (name == "" || address == "" || phone == "" || remarks == "")
            {
                MessageBox.Show("请输入完整信息！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                string sql = "select * from supplier where sname='" + name + "'";
                if (SqlHelper.ExecuteScalar(sql) == null)
                {
                    sql = string.Format("insert into supplier values('{0}','{1}','{2}','{3}')", name, address, phone, remarks);
                    if (SqlHelper.ExecuteUpdate(sql) > 0)
                    {
                        MessageBox.Show("添加供应商信息成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("添加供应商信息失败！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }             
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            tbsname.Text = "";
            tbaddress.Text = "";
            tbphone.Text = "";
            tbremarks.Text = "";
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
