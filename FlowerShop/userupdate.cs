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
    public partial class userupdate : Form
    {
        public userupdate()
        {
            InitializeComponent();
        }
        private void updaterole_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "select rolename from rolename";
                SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
                while (sdr.Read()) { cbid.Items.Add(sdr["rolename"].ToString()); }
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

        private void btupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("update rolename set systemmanage='{0}',ordermanage='{1}',provisionmanage='{2}',resalemanage='{3}' where rolename='{4}'", cbxtgl.Checked, cbgkgl.Checked, cblsgl.Checked, cbgygl.Checked, cbid.Text);
                if (SqlHelper.ExecuteUpdate(sql) > 0)
                {
                    MessageBox.Show("修改权限成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("修改权限失败！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cbid_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from rolename where rolename='" + cbid.Text + "'";
                SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
                while (sdr.Read())
                {
                    cbgkgl.Checked = (bool)sdr["ordermanage"];
                    cbxtgl.Checked = (bool)sdr["systemmanage"];
                    cblsgl.Checked = (bool)sdr["resalemanage"];
                    cbgygl.Checked = (bool)sdr["provisionmanage"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "数据库操作失败提示");
            }
        }

      

        

       

       
    }
}
