using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FlowerShop.method;

namespace FlowerShop
{
    public partial class customerinfo : Form
    {
        public customerinfo()
        {
            InitializeComponent();
        }
        dtpchange dtp = new dtpchange();
        inputnumber num = new inputnumber();
        private void btcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            SolidBrush _Brush = new SolidBrush(Color.Black);//单色画刷 
            RectangleF _TabTextArea = (RectangleF)tabControl1.GetTabRect(e.Index);//绘制区域 
            StringFormat _sf = new StringFormat();//封装文本布局格式信息 
            _sf.LineAlignment = StringAlignment.Center; _sf.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(tabControl1.Controls[e.Index].Text, SystemInformation.MenuFont, _Brush, _TabTextArea, _sf);
        }

        public string sqll = "SELECT customer.cid AS 顾客编号,cname AS 顾客姓名,csex AS 性别,cphone AS 电话,fid AS 鲜花编号, onumber AS 订购数量,odate AS 订购日期,oimmediately AS 送货时间,odestination AS 送货地点, otask AS 任务进度,oremarks AS 备注信息 FROM   customer,orderform WHERE customer.cid =orderform.cid ";

        private void customerinfo_Load(object sender, EventArgs e)
        {
             tbcname.Text = "";
            tbphone.Text = "";
            dtp.InitDateTimePicker(dtpend);
            dtp.InitDateTimePicker(dtpstart);
            num.ForceNumberInput(tbphone);
            num.ForceNumberInput(tbphone1);
            num.ForceNumberInput(tbtel);
            num.ForceNumberInput(tbnumber);
            try
            {
                string sql = "select fname from flower";
                SqlDataReader sdr =  SqlHelper.ExecuteReader(sql);
                while (sdr.Read())
                {
                    cmbfname.Items.Add(sdr["fname"].ToString());
                    cmbflower.Items.Add(sdr["fname"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        
        }

        private void btcan_Click(object sender, EventArgs e)
        {
            tbcname.Text = "";
            tbphone.Text = "";
         
            measure mm = new measure();


        }

        private void btcancel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btselect_Click(object sender, EventArgs e)  //查询界面
        {
            string user = tbcname.Text.Trim();
            string phone = tbphone.Text.Trim();
            string start = dtpstart.Text.Trim();
            string end = dtpend.Text.Trim();
            if (user == "" && phone == "" && start == "" && end == "")
            {
                MessageBox.Show("请输入想要查询的条件信息！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                if (user != "")
                {
                    string sql1 = sqll + " and cname='" + user + "'";
                    DataTable dt = SqlHelper.GetTable(sql1);
                    dataGridView1.DataSource = dt;
                }
                if (phone != "")
                {
                    string sql2 = sqll + "and cphone='" + phone + "'";
                    DataTable dt = SqlHelper.GetTable(sql2);
                    dataGridView1.DataSource = dt;
                }
                if (start != "" && end != "")
                {
                    DateTime dt1 = Convert.ToDateTime(start);
                    DateTime dt2 = Convert.ToDateTime(end);
                    string sql3 = sqll + "and odate between'" + dt1.ToString("yyyy-MM-dd") + "'and'" + dt2.ToString("yyyy-MM-dd") + "'";
                    DataTable dt = SqlHelper.GetTable(sql3);
                    dataGridView1.DataSource = dt;
                }
                tbcname.Text = "";
                tbphone.Text = "";
                dtp.InitDateTimePicker(dtpstart);
                dtp.InitDateTimePicker(dtpend);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btreset1_Click(object sender, EventArgs e)  //修改界面重置按钮
        {
            cmbflower.Text = "--请选择花名--";
            tbuser.Text = "";
            rdbman.Checked = true;
            tbflid.Text = "";
            tbnum.Text = "";
            dtpdata.Text = DateTime.Now.ToLongDateString();
            dtpdata1.Text = DateTime.Now.ToLongDateString();
            tbaddress1.Text = "";
            tbbz.Text = "";
            tbtel.Text = "";
        }

        private void btreset_Click(object sender, EventArgs e)  //添加界面重置按钮
        {
            tbname.Text = "";
            rdbman.Checked = true;
            cmbfname.Text = "--请选择花名--";
            tbfid.Text = "";
            tbphone1.Text = "";
            tbnumber.Text = "";
            tbaddress.Text = "";
            tbremarks.Text = "";
            dtptime.Text = DateTime.Now.ToLongDateString();
            dtptime1.Text = DateTime.Now.ToLongDateString();
        }

        private void btadd_Click(object sender, EventArgs e)  //添加按钮
        {
            if (tbname.Text == "" || tbfid.Text == "" || tbphone1.Text == "" || tbnumber.Text == "" || tbaddress.Text == "" || tbremarks.Text == "")
            {
                MessageBox.Show("请输入完整信息！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string sex;
            if (rdbman.Checked == true)
                sex = "男";
            else
                sex = "女";
            try
            {
                string sql = "select * from customer  where cid=''";
                if (SqlHelper.ExecuteScalar(sql) == null)
                {
                    sql = string.Format("insert into customer output inserted.cid values('{0}','{1}','{2}') select scope_identity()", tbname.Text.Trim(), sex, tbphone1.Text.Trim());
                    int i = (int)SqlHelper.ExecuteScalar(sql);
                    string sql1 = string.Format("insert into  orderform values('{0}','{1}','{2}','{3}','{4}','{5}','未完成','{6}')", tbfid.Text.Trim(), i, tbnumber.Text.Trim(), dtptime.Text.Trim(), dtptime1.Text.Trim(), tbaddress.Text.Trim(), tbremarks.Text.Trim());
                    if (SqlHelper.ExecuteUpdate(sql1) > 0)
                    {
                        MessageBox.Show("添加顾客订购信息成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("添加顾客订购信息失败！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmbfname_SelectedIndexChanged(object sender, EventArgs e)  //添加界面花名改变事件
        {
            try
            {
                string sql = "select * from flower where fname='" + cmbfname.Text + "'";
                SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
                while (sdr.Read())
                {
                    tbfid.Text = sdr["fid"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbtel_TextChanged(object sender, EventArgs e)  //电话改变事件
        {
            if (tbtel.TextLength == 11)
            {
                try
                {
                    sqll = sqll + "and cphone='" + tbtel.Text + "'";
                    SqlDataReader sdr = SqlHelper.ExecuteReader(sqll);
                    if (sdr.HasRows)
                    {
                        while (sdr.Read())
                        {
                            tbuser.Text = sdr["顾客姓名"].ToString();
                            string sex = sdr["性别"].ToString();
                            if (sex == rdbman.Text)
                                rdbman.Checked = true;
                            if (sex == rbweman.Text)
                                rbweman.Checked = true;
                            tbflid.Text = sdr["鲜花编号"].ToString();
                            tbnum.Text = sdr["订购数量"].ToString();
                            dtpdata.Text = sdr["订购日期"].ToString();
                            dtpdata1.Text = sdr["送货时间"].ToString();
                            tbaddress1.Text = sdr["送货地点"].ToString();
                            tbbz.Text = sdr["备注信息"].ToString();
                        }
                        int i = Convert.ToInt32(tbflid.Text.Trim());
                        string sql1 = string.Format("select fname from flower where fid={0}", i);
                        cmbflower.Text = (string)SqlHelper.ExecuteScalar(sql1); ;
                    }
                    else
                    {
                        sdr.Close();
                        MessageBox.Show("此顾客电话信息不存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }       
        }

        private void btupdate_Click(object sender, EventArgs e)  //修改按钮
        {
            if (tbuser.Text == "" || tbflid.Text == "" || tbtel.Text == "" || tbnum.Text == "" || tbaddress1.Text == "" || tbbz.Text == "")
            {
                MessageBox.Show("请输入完整信息！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string sex;
            if (rdbman.Checked == true)
                sex = "男";
            else
                sex = "女";
            try
            {
                string sql = string.Format("update customer set cname='{0}',csex='{1}',cphone='{2}' where cphone='{3}'", tbuser.Text.Trim(), sex, tbtel.Text.Trim(), tbtel.Text.Trim());
                if (SqlHelper.ExecuteUpdate(sql) > 0)
                {
                    string sql1 = string.Format("update orderform set fid='{0}',onumber='{1}',odate='{2}',oimmediately='{3}',odestination='{4}',oremarks='{5}'where cid in(select cid from customer where cphone='{6}')", tbflid.Text.Trim(), tbnum.Text.Trim(), dtpdata.Text.Trim(), dtpdata1.Text.Trim(), tbaddress1.Text.Trim(), tbbz.Text.Trim(), tbtel.Text.Trim());
                    if (SqlHelper.ExecuteUpdate(sql1) > 0)
                        MessageBox.Show("修改顾客订购信息成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                        MessageBox.Show("修改顾客订购信息失败！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("修改顾客订购信息失败！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmbflower_SelectedValueChanged(object sender, EventArgs e)   //修改界面花名改变事件
        {
            try
            {
                string sql = "select * from flower where fname='" + cmbflower.Text + "'";
                SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
                while (sdr.Read()) { tbflid.Text = sdr["fid"].ToString(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

       


       

        

       

        

        

       
        
    }
}
