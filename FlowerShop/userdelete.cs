using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FlowerShop.method;

namespace FlowerShop
{
    public partial class userdelete : Form
    {
        public userdelete()
        {
            InitializeComponent();
        }
        private void userdelete_Load(object sender, EventArgs e)
        {
            measure user = new measure();
            user.anduntocom(comname);

           
        }
        private void btcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            measure u = new measure();
            if (u.deleteuser(comname.Text) == 1)
            {
                MessageBox.Show("用户" + comname.Text + "删除成功！");
            }


        }

       
    }
}
