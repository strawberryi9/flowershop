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
    public partial class lookprovide : Form
    {
        public lookprovide()
        {
            InitializeComponent();
        }

        private void lookprovide_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "select fid from provision";
                SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
                while (sdr.Read()) { cmbfid.Items.Add(sdr["fid"].ToString()); }
                string sql1 = string.Format("select sname from supplier");
                SqlDataReader sdr1 = SqlHelper.ExecuteReader(sql1);
                while (sdr1.Read()) { cbmsname.Items.Add(sdr1["sname"].ToString()); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmbfid_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbmsname.Text = "--请选择供应商--";
            try
            {
                string sql = "select fid as 鲜花编号,sname as 供应商,pnumber as 供应数量,pdate as 供应日期 from provision where fid='" + cmbfid.Text + "'";
                dgvinfo.DataSource = SqlHelper.GetTable(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cbmsname_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbfid.Text = "--请选择编号--";
            try
            {
                string sql = "select sname as 供应商,saddress as 地址,sphone as 电话,sremarks as 备注 from supplier where sname='" + cbmsname.Text + "'";
                dgvinfo.DataSource = SqlHelper.GetTable(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }  
        }

        private void btlookup_Click(object sender, EventArgs e)
        {
            cbmsname.Text = "--请选择供应商--";
            cmbfid.Text = "--请选择编号--";
            try
            {
                string sql = "select supplier.sname AS 供应商,sphone as 电话,fid as 鲜花编号 ,pnumber as 供应数量,pdate as 供应日期,saddress as 地址,sremarks as 备注 from provision ,supplier where provision.sname =supplier.sname";
                dgvinfo.DataSource = SqlHelper.GetTable(sql);
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

        

        private void btdelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbfid.Text != "--请选择编号--")
                {
                    string sql1 = "delete from provision where fid='" + cmbfid.Text.Trim() + "'";
                    if (SqlHelper.ExecuteUpdate(sql1) > 0)
                    {
                        MessageBox.Show("删除供应信息成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgvinfo.DataSource = SqlHelper.GetTable("select fid as 鲜花编号,sname as 供应商,pnumber as 供应数量,pdate as 供应日期 from provision where fid='" + cmbfid.Text + "'");
                    }
                    else
                    {
                        MessageBox.Show("删除供应信息失败！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                if (cbmsname.Text != "--请选择供应商--")
                {
                    string sql1 = "delete from supplier where sname='" + cbmsname.Text.Trim() + "'";
                    if (SqlHelper.ExecuteUpdate(sql1) > 0)
                    {
                        MessageBox.Show("删除供应商信息成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgvinfo.DataSource = SqlHelper.GetTable("select sname as 供应商,saddress as 地址,sphone as 电话,sremarks as 备注 from supplier where sname='" + cbmsname.Text + "'");
                    }
                    else
                    {
                        MessageBox.Show("删除供应商信息失败！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                if (cbmsname.Text == "--请选择供应商--" && cmbfid.Text == "--请选择编号--")
                {
                    string sql = "select supplier.sname AS 供应商,sphone as 电话,fid as 鲜花编号 ,pnumber as 供应数量,pdate as 供应日期,saddress as 地址,sremarks as 备注 from provision ,supplier where provision.sname =supplier.sname";
                    string sql1 = "delete from provision where fid=" + SqlHelper.GetTable(sql).Rows[dgvinfo.CurrentCell.RowIndex][2].ToString().Trim() + "";
                    if (SqlHelper.ExecuteUpdate(sql1) > 0)
                    {
                        MessageBox.Show("删除供应信息成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgvinfo.DataSource = SqlHelper.GetTable(sql);
                    }
                    else
                    {
                        MessageBox.Show("删除供应信息失败！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

      
      
       
    }
}
