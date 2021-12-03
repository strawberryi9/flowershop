using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using FlowerShop.method;

namespace FlowerShop
{
    public partial class updatetask : Form
    {
        public DataGridViewRow dgvr;//声明一个DataGridViewRow对象
        public updatetask(DataGridViewRow dgvr1)
        {
            InitializeComponent();
            dgvr = dgvr1;
            getValue();

         
        }
        public void getValue()                           //给控件赋值
        {
            tbuser.Text = dgvr.Cells["顾客姓名"].Value.ToString();
            tbtime1.Text = dgvr.Cells["送货时间"].Value.ToString();
            tbtime.Text = dgvr.Cells["订购日期"].Value.ToString();
            tbtel.Text = dgvr.Cells["电话"].Value.ToString();
            string id = dgvr.Cells["鲜花编号"].Value.ToString();
            try
            {
                int i = Convert.ToInt32(id);
                string sql = "select * from flower where fid=" + i + "";
                SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
                while (sdr.Read()) { tbfname.Text = sdr["fname"].ToString(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            string task = dgvr.Cells["任务进度"].Value.ToString();
            if (task == rb1.Text)
                rb1.Checked = true;
            if (task == rb2.Text)
                rb2.Checked = true;
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            string task;
            if (rb1.Checked == true)
                task = "已完成";
            else
                task = "未完成";
            try
            {
                string sql = string.Format("update orderform set otask='{0}'where cid in(select cid from customer where cname='{1}')", task, tbuser.Text);
                if (SqlHelper.ExecuteUpdate(sql) > 0)
                {
                    MessageBox.Show("修改订购任务成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("修改订购任务失败！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            this.Close();
            }
        }
    }

