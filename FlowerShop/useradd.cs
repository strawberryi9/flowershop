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
    public partial class useradd : Form
    {
        public useradd()
        {
            InitializeComponent();
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            string user = username.Text.Trim();
            string pwd = password.Text.Trim();
            string repwd = conpwd.Text.Trim();
            string idcard = cbid.Text.Trim();

              measure uu = new measure();
            //密码加密
            ClassMD5 md5 = new ClassMD5();

            if (user == "" || pwd == "" || repwd == "" || idcard == "")
            {
                MessageBox.Show("请输入完整信息！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (pwd != repwd)
            {
                MessageBox.Show("两次密码输入不一致！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
           
                if (uu.createuser(username.Text,md5.Md5Encrypt(password.Text),cbid.Text) == 1)
                {
                   
                        MessageBox.Show("添加用户信息成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                
                else
                {
                    MessageBox.Show("添加用户信息失败！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
         
        

        private void btclear_Click(object sender, EventArgs e)
        {
            username.Text = "";
            password.Text = "";
            conpwd.Text = "";
            cbid.Text = " ——请选择身份——";
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        
    }
}
