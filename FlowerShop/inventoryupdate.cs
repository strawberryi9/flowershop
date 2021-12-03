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
    public partial class inventoryupdate : Form
    {
        public DataGridViewRow dgvr;
        public inventoryupdate(DataGridViewRow dgvr1)
        {
            InitializeComponent();
            dgvr = dgvr1;
            getValue();
        }

        public void getValue()
        {
            tbname.Text = dgvr.Cells["库存名称"].Value.ToString();
            tbsum.Text = dgvr.Cells["鲜花总数"].Value.ToString();
            tbout.Text = dgvr.Cells["出库数量"].Value.ToString();
            tbresidue.Text = dgvr.Cells["剩余花量"].Value.ToString();
            tbfid.Text = dgvr.Cells["鲜花编号"].Value.ToString();
        }
        private void btcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
             int iout = Convert.ToInt32(tbout.Text.Trim());
            int sum = Convert.ToInt32(tbsum.Text.Trim());
            tbresidue.Text = (sum - iout).ToString() ;
            try
            {
                string sql = string.Format("update inventory set iname='{0}',fid='{1}',inumber='{2}',ioutput='{3}',ileft='{4}' where fid='{5}'",tbname.Text.Trim(),tbfid.Text.Trim(),sum,iout,tbresidue.Text.Trim(),tbfid.Text.Trim());
                if (SqlHelper.ExecuteUpdate(sql) > 0)
                {
                    MessageBox.Show("修改仓库信息成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("修改仓库信息失败！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

