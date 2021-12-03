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
    public partial class provideupdate : Form
    {
        public provideupdate()
        {
            InitializeComponent();
        }
        inputnumber num = new inputnumber();

        private void provideupdate_Load(object sender, EventArgs e)
        {
            num.ForceNumberInput(tbinumber);
            try
            {
                string sql = "select sname from supplier";
                SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
                while (sdr.Read()) { cmbsname.Items.Add(sdr["sname"].ToString()); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btupdate_Click(object sender, EventArgs e)
        {

            try
            {
                string sql = string.Format("update provision set fid='{0}',pnumber='{1}',pdate='{2}' where sname='{3}'", tbfid.Text.Trim(), tbinumber.Text.Trim(), dtptime.Text.Trim(), cmbsname.Text.Trim());
                if (SqlHelper.ExecuteUpdate(sql) > 0)
                {
                    MessageBox.Show("修改供应信息成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("修改供应信息失败！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            tbfid.Clear();
            tbinumber.Clear();
            tbphone.Clear();
            tbremarks.Clear();
            cmbfname.Text = "--请选择编号--";
            cmbsname.Text = "--请选择供应商--";
            dtptime.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbsname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select flower.fid,fname,provision.sname,pnumber,pdate,sphone,sremarks from flower,provision,supplier where flower.fid = provision.fid and provision.sname = supplier.sname and provision.sname ='" + cmbsname.Text + "'";
                SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
                while (sdr.Read())
                {
                    tbfid.Text = sdr["fid"].ToString();
                    tbinumber.Text = sdr["pnumber"].ToString();
                    tbphone.Text = sdr["sphone"].ToString();
                    tbremarks.Text = sdr["sremarks"].ToString();
                    dtptime.Text = sdr["pdate"].ToString();
                    cmbfname.Text = sdr["fname"].ToString();
                }
                string sql1 = ";with mycte as(select a.sname,a.sremarks+',' as 'sremarks',CHARINDEX(',',a.sremarks) as sta,CHARINDEX(',',a.sremarks)-1 as lens from supplier a union ALL select sname,sremarks,CHARINDEX(',',sremarks,sta+1)as sta , CHARINDEX(',',sremarks,sta + 1) - sta - 1 as lens from mycte where (sta <> 0))select sname,substring(sremarks,sta - lens,lens)from mycte where (sta <> 0) and sname='" + cmbsname.Text + "'";
                SqlDataReader sdr1 = SqlHelper.ExecuteReader(sql1);
                while (sdr1.Read()) { cmbfname.Items.Add(sdr1[1].ToString()); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "数据库操作失败提示");
            }
        }

        private void cmbfname_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from flower where fname='" + cmbfname.Text + "'";
                SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
                while (sdr.Read()) { tbfid.Text = sdr["fid"].ToString(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "数据库操作失败提示");
            }
        }

       
    }
}
