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
    public partial class inventoryselect : Form
    {
        public inventoryselect()
        {
            InitializeComponent();
        }

        private void inventoryselect_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "select fid from flower";
                SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
                while (sdr.Read()) { cmbfid.Items.Add(sdr["fid"].ToString()); }
                sdr.Close();
                sql = string.Format("select iid from inventory");
                sdr = SqlHelper.ExecuteReader(sql);
                while (sdr.Read()) { cmbiid.Items.Add(sdr["iid"].ToString()); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }   

        }

        private void btselect_Click(object sender, EventArgs e)
        {
            string sql = "select iid as 库存编号,iname as 库存名称,fid as 花编号,inumber as 库存花数量,ioutput as 出库数量,ileft as 剩余库存量 from inventory";
            if (cmbfid.Text != "--请选择编号--")
            {
                sql = "select iid as 库存编号,iname as 库存名称,fid as 花编号,inumber as 库存花数量,ioutput as 出库数量,ileft as 剩余库存量 from inventory where ','+fid+',' like '%," + cmbfid.Text + ",%'";
            }
            if (cmbiid.Text != "--请选择编号--")
            {
                sql = "select iid as 库存编号,iname as 库存名称,fid as 花编号,inumber as 库存花数量,ioutput as 出库数量,ileft as 剩余库存量 from inventory where iid='" + cmbiid.Text + "'";
            }
            try
            {
                dataGridView1.DataSource = SqlHelper.GetTable(sql);
                cmbfid.Text = "--请选择编号--";
                cmbiid.Text = "--请选择编号--";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            cmbfid.Text = "--请选择编号--";
            cmbiid.Text = "--请选择编号--";
            dataGridView1.DataSource = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
