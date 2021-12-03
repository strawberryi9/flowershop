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
    public partial class customerorder : Form
    {
      
        public customerorder()
        {
            InitializeComponent();


        }
        public string sql = "SELECT customer.cid AS 顾客编号,cname AS 顾客姓名,cphone AS 电话,fid AS 鲜花编号, odate AS 订购日期,oimmediately AS 送货时间,otask AS 任务进度 FROM   customer,orderform WHERE customer.cid =orderform.cid ";

        private void btfinish_Click(object sender, EventArgs e)
        {
            try
            {
                string sql1 = sql + "and otask='已完成'";
                dataGridView1.DataSource = SqlHelper.GetTable(sql1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

       

        private void btnofinish_Click(object sender, EventArgs e)
        {
            try
            {
                string sql2 = sql + "and otask='未完成'";
                dataGridView1.DataSource = SqlHelper.GetTable(sql2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

       

        private void tsl_finish_Click(object sender, EventArgs e)
        {
            try
            {
                string sql1 = sql + "and otask='已完成'";
                dataGridView1.DataSource = SqlHelper.GetTable(sql1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tsl_nofinish_Click(object sender, EventArgs e)
        {
            try
            {
                string sql2 = sql + "and otask='未完成'";
                dataGridView1.DataSource = SqlHelper.GetTable(sql2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tspupdate_Click(object sender, EventArgs e)
        {
            updatetask ut = new updatetask(dataGridView1.CurrentRow);  //获取点击的那行
            ut.Show();          //显示窗体

         
        }

      

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {



           updatetask ut= new updatetask(dataGridView1.CurrentRow);  //获取点击的那行
            ut.Show();          //显示窗体
        
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex >= 0 && dataGridView1.DataSource != null && dataGridView1.CurrentCell != null)
            {
                string sql1 = "delete from customer where cid=" + SqlHelper.GetTable(sql).Rows[dataGridView1.CurrentCell.RowIndex][0].ToString().Trim() + "";
                string sql2 = "delete from orderform where cid=" + SqlHelper.GetTable(sql).Rows[dataGridView1.CurrentCell.RowIndex][0].ToString().Trim() + "";
                try
                {
                    if (SqlHelper.ExecuteUpdate(sql1) > 0)
                    {
                        if (SqlHelper.ExecuteUpdate(sql2) > 0)
                        {
                            MessageBox.Show("删除顾客订购信息成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            push();
                        }
                        else
                        {
                            MessageBox.Show("删除顾客订购失败！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("删除顾客订购失败！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }   
        }

        private void customerorder_Load(object sender, EventArgs e)
        {
            push();
        }
        private void push()
        {
            try
            {
                dataGridView1.DataSource = SqlHelper.GetTable(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tsl_lookup_Click(object sender, EventArgs e)
        {
            push();
        }

      

    }
}
