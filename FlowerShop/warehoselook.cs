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
    public partial class warehoselook : Form
    {

        string sql = "select iid as 库存编号,iname as 库存名称,fid as 鲜花编号,inumber as 鲜花总数,ioutput as 出库数量,ileft as 剩余花量 from inventory";
        public warehoselook()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            addinventory ai = new addinventory();
            ai.Show();
        }

        private void warehoselook_Load(object sender, EventArgs e)
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

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            inventoryupdate iu = new inventoryupdate(dataGridView1.CurrentRow);
            iu.Show();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            try
            {
                string sql1 = "delete from inventory where iid=" + SqlHelper.GetTable(sql).Rows[dataGridView1.CurrentCell.RowIndex][0].ToString().Trim() + "";
                if (SqlHelper.ExecuteUpdate(sql1) > 0)
                {
                    MessageBox.Show("删除仓库信息成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataGridView1.DataSource = SqlHelper.GetTable(sql);
                }
                else
                {
                    MessageBox.Show("删除仓库信息失败！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    
    }
}
