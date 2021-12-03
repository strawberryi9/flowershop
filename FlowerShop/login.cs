using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FlowerShop.method;


namespace FlowerShop
{
    public partial class login : Form
    {
        public login()
        {


            InitializeComponent();
        }
           ValidCode validCode = new ValidCode(5, ValidCode.CodeType.Numbers); //验证码

        private void login_Load(object sender, EventArgs e)
        {
            picValidCode.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());
        }

        private void btok_Click(object sender, EventArgs e)
        {

           measure usercheak = new measure();   //Classuser()是类Classuser的构造函数

            if (tbusername.Text == "")
            {
                picValidCode.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());

                MessageBox.Show("用户名不能为空，请输入用户名！");
            }
            else if (tbpasswd.Text == "")
            {
                picValidCode.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());

                MessageBox.Show("密码不能为空，请输入密码！");
            }
            else if (comboBox1.Text == "")
            {
                picValidCode.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());

                MessageBox.Show("请选择登录身份！");
            }
            else if (usercheak.userfind(tbusername.Text) != 1)   //判断用户是否存在
            {
                picValidCode.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());

                MessageBox.Show("该用户不存在！");
            }
            else if (usercheak.logininfofind(tbusername.Text, tbpasswd.Text) != 1)  //判断该用户存在的密码是否正确
            {
                picValidCode.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());

                MessageBox.Show("该用户存在的密码不正确！");
            }
            else if (usercheak.useridfind(tbusername.Text, comboBox1.Text) != 1)
            {
                picValidCode.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());

                MessageBox.Show("该用户对应的身份不正确！");
            }

            else if (!this.txtValidCode.Text.Equals(validCode.CheckCode))
            {
                picValidCode.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());
                MessageBox.Show("请输入正确的验证码！", "提示");

            }






            else
            {
                this.Hide();   //将现有窗体隐藏

                Form1 frm = new Form1(comboBox1.Text);   //调用frammain函数

                frm.Show();   //将目标Frmmain窗体展示出来
               
               
            }

        }


        private void btclear_Click(object sender, EventArgs e)
        {
             tbusername.Text = "";
           
            tbpasswd.Clear();
            txtValidCode.Clear();
        }

        private void picValidCode_Click(object sender, EventArgs e)
        {
            ValidCode validCode = new ValidCode(5, ValidCode.CodeType.Numbers); //验证码
            picValidCode.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());
        }


        protected override CreateParams CreateParams  //防止界面闪烁
        {
            get
            {
                CreateParams paras = base.CreateParams;
                paras.ExStyle |= 0x02000000;
                return paras;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      

        
    }
}
