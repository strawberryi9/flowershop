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
    public partial class repasswd : Form
    {
        public repasswd()
        {
            InitializeComponent();
        }

        private void btok_Click(object sender, EventArgs e)
        {
            if (tbuser.Text.Trim() == "" || tbpwd.Text.Trim() == "" || tbnewpwd.Text.Trim() == "" || tbrepwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入完整信息！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                string sql = string.Format("select * from userinfo where name='{0}'and pwd='{1}'", tbuser.Text.Trim(), tbpwd.Text.Trim());
                SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
                if (sdr.HasRows)
                {
                    sdr.Read();
                    if (sdr["name"].ToString() == tbuser.Text.Trim() && sdr["pwd"].ToString() == tbpwd.Text.Trim())
                    {
                        if (tbrepwd.Text.Trim() == tbnewpwd.Text.Trim())
                        {
                            sql = string.Format("update userinfo set pwd='{0}'where name='{1}'", tbrepwd.Text.Trim(), tbuser.Text.Trim());
                            if (SqlHelper.ExecuteUpdate(sql) > 0)
                            {
                                MessageBox.Show("修改密码成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("修改密码失败！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            sdr.Close();
                            MessageBox.Show("输入两次密码输入不一致，请重新输入！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            tbnewpwd.Clear();
                            tbnewpwd.Focus();
                            tbrepwd.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码输入有误，请重新输入！", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning); }       

        }

        private void btreset_Click(object sender, EventArgs e)
        {
            tbuser.Text = "";
            tbpwd.Text = "";
            tbnewpwd.Text = "";
            tbrepwd.Text = "";
        }

    }
}
