using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FlowerShop.method;

namespace FlowerShop
{
    public partial class addinventory : Form
    {
        public addinventory()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             int iout = Convert.ToInt32(tbout.Text.Trim());
            int sum = Convert.ToInt32(tbsum.Text.Trim());
            tbresidue.Text = (sum - iout).ToString();

             measure usercheak = new measure();
            try
            {
                string sql = string.Format("insert into inventory values('{0}','{1}',{2},{3},{4})", tbname.Text.Trim(), tbfid.Text.Trim(), sum, iout, tbresidue.Text.Trim());
                if (SqlHelper.ExecuteUpdate(sql) > 0)
                {
                //    if (usercheak.flowerfind(tbfid.Text) == 1)
                //    {
                //        DialogResult MsgBoxResult;
                //        MsgBoxResult = MessageBox.Show("此花以被添加！确定要添加吗？", "信息提示", MessageBoxButtons.OKCancel);
                //        if (MsgBoxResult == DialogResult.Yes)
                //        {
                            MessageBox.Show("添加仓库信息成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                      
                   
                //    }

              


                 
                else
                {
                    MessageBox.Show("添加仓库信息失败！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
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
      
        
    }
}
