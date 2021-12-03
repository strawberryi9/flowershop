using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using FlowerShop.method;

namespace FlowerShop
{
    public partial class flowerlookup : UserControl
    {
        public flowerlookup()
        {
            InitializeComponent();
        }

      

        private void flowerlookup_Load(object sender, EventArgs e)
        {
            try
            {
                string sql1 = "select fname from flower";
                SqlDataReader sdr = SqlHelper.ExecuteReader(sql1);
                while (sdr.Read()) { cmbfname.Items.Add(sdr["fname"].ToString()); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmbfname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select fid as 鲜花编号,fname as 鲜花名称,flanguage as 花语,fprimecost as 进货价,fsalecost as 销售价,iid as 库存编号 from flower where fname='" + cmbfname.Text.Trim() + "'";
                SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
                while (sdr.Read())
                { tbfid.Text = sdr["鲜花编号"].ToString(); }
                string sql1 = "select fid as 鲜花编号,fname as 鲜花名称,flanguage as 花语,fprimecost as 进货价,fsalecost as 销售价,iid as 库存编号 from flower where fname='" + cmbfname.Text.Trim() + "'";
                dataGridView1.DataSource = SqlHelper.GetTable(sql1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btok_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select fid as 鲜花编号,fname as 鲜花名称,flanguage as 花语,fprimecost as 进货价,fsalecost as 销售价,iid as 库存编号 from flower";
                dataGridView1.DataSource = SqlHelper.GetTable(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
        private void btdelete_Click(object sender, EventArgs e)
        {
            try
            {
                string sql1 = "delete from flower where fid='" + tbfid.Text.Trim() + "'";
                if (SqlHelper.ExecuteUpdate(sql1) > 0)
                {
                    MessageBox.Show("删除鲜花信息成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("删除鲜花信息失败！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bt_out_Click(object sender, EventArgs e)
        {
            Daochu s = new Daochu();
            s.ExcelBtnLiu(dataGridView1, "");
        }

       
       
     

        


       

       
    }
}
