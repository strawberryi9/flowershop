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
    public partial class retailadd : Form
    {
        dtpchange dtp = new dtpchange();
        inputnumber num = new inputnumber();
        public retailadd()
        {
           
            InitializeComponent();
        }

        private void cmbfid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from flower where fid='" + cmbfid.Text + "'";
                SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
                while (sdr.Read())
                {
                    tbfname.Text = sdr["fname"].ToString();
                    tbfsalecost.Text = sdr["fsalecost"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "数据库操作失败提示");
            }           
        }

        private void retailadd_Load(object sender, EventArgs e)
        {
            num.ForceNumberInput(tbinumber);
            try
            {
                string sql = "select fid from flower";
                SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
                while (sdr.Read()) { cmbfid.Items.Add(sdr["fid"].ToString()); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void btadd_Click(object sender, EventArgs e)
        {
            string id = cmbfid.Text.Trim();
            string number = tbinumber.Text.Trim();
            string time = dtptime.Text.Trim();
            if (id == "--请选择编号--" || number == "")
            {
                MessageBox.Show("请完善信息！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                string sql = "select * from resale where rid=''";
                if (SqlHelper.ExecuteScalar(sql) == null)
                {
                  
                    sql = string.Format("insert into resale values('{0}','{1}','{2}')", id, number, time);
                    if (SqlHelper.ExecuteUpdate(sql) > 0)
                    {
                        //sql = string.Format("update inventory set inventoy.ileft=inventory.ileft-resale.rnumber  from inventory,resale where inventory.fid =resale.fid");
                      
                        
                        MessageBox.Show("添加零售信息成功！", "信息提示");
                   
                     
                    }
                }
                else
                {
                    MessageBox.Show("添加零售信息失败！", "信息提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            tbfname.Text = "";
            tbfsalecost.Text = "";
            tbinumber.Text = "";
            cmbfid.Text = "--请选择编号--";
            dtptime.Text = DateTime.Now.ToLongDateString(); 
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbinumber_TextChanged(object sender, EventArgs e)
        {
            
        }

        

    }
}
