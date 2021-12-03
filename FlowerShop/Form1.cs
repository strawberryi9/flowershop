using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlowerShop.method;

namespace FlowerShop
{
    public partial class Form1 : Form
    {
        static public Form1 mf = null;
       
        public Form1(string rolename)
        {
            mf = this;
            InitializeComponent();
            this.Width = 900;
            this.Height = 635;
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = System.Environment.CurrentDirectory + "//PageColor1.ssk";


            string sqlString = @"Data Source=.;Initial Catalog=FlowerShop;uid=sa;pwd=123456";
            string sql = string.Format("select * from rolename where rolename='{0}'", rolename);
            using (SqlConnection conn = new SqlConnection(sqlString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = sql;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        用户信息管理.Visible = (bool)sdr["systemmanage"];
                        零售信息管理.Visible = (bool)sdr["resalemanage"];
                        顾客订购管理.Visible = (bool)sdr["ordermanage"];
                        花店供应管理.Visible = (bool)sdr["provisionmanage"];

                    }
                    sdr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "数据库操作问题提示");
                }
                finally
                {
                    conn.Close();
                }
            }
 
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //启动首先展示主页
            splitContainer1.Panel2.Controls.Clear();//每次执行时清空panel2
          
            main aa = new main();
            aa.Parent = splitContainer1.Panel2;
            aa.Dock = DockStyle.Fill;//设置用户控件充满panel2
            aa.Show();
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

        private void 主页_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            main aa = new main();
            aa.Parent = splitContainer1.Panel2;
            aa.Dock = DockStyle.Fill;
            aa.Show();
        }

        private void 添加用户_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            useradd ua = new useradd();
            ua.TopLevel = false;
            ua.Parent = splitContainer1.Panel2;
            ua.Dock = DockStyle.Fill;
            ua.Show();
        }

        private void 修改用户_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            userupdate uu = new userupdate();
            uu.TopLevel = false;
            uu.Parent = splitContainer1.Panel2;
            uu.Dock = DockStyle.Fill;
            uu.Show();
        }

        private void 删除用户_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            userdelete ud = new userdelete();
            ud.TopLevel = false;
            ud.Parent = splitContainer1.Panel2;
            ud.Dock = DockStyle.Fill;
            ud.Show();
        }

        private void 添加花类_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            floweradd cc = new floweradd();
            cc.TopLevel = false;
            cc.Parent = splitContainer1.Panel2;
            cc.Dock = DockStyle.Fill;
            cc.Show();
        }

        private void 修改花类_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            flowerupdate er3 = new flowerupdate();
            er3.TopLevel = false;
            er3.Parent = splitContainer1.Panel2;
            er3.Dock = DockStyle.Fill;
            er3.Show();
        }

        private void 浏览花类_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            flowerlookup er2 = new flowerlookup();
            er2.Parent = splitContainer1.Panel2;
            er2.Dock = DockStyle.Fill;
            er2.Show();
        }

        private void 添加零售_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            retailadd ra = new retailadd();
            ra.TopLevel = false;
            ra.Parent = splitContainer1.Panel2;
            ra.Dock = DockStyle.Fill;
            ra.Show();
        }

        private void 修改零售_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            retailupdate ru = new retailupdate();
            ru.TopLevel = false;
            ru.Parent = splitContainer1.Panel2;
            ru.Dock = DockStyle.Fill;
            ru.Show();
        }

        private void 查询零售_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            retailselect rs = new retailselect();
            rs.TopLevel = false;
            rs.Parent = splitContainer1.Panel2;
            rs.Dock = DockStyle.Fill;
            rs.Show();
        }

        private void 顾客信息_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            customerinfo cu = new customerinfo();
            cu.TopLevel = false;
            cu.Parent = splitContainer1.Panel2;
            cu.Dock = DockStyle.Fill;
            cu.Show();
        }

        private void 顾客订购信息_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            customerorder co = new customerorder();
            co.TopLevel = false;
            co.Parent = splitContainer1.Panel2;
            co.Dock = DockStyle.Fill;
            co.Show();
        }

        private void 浏览供应信息_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            lookprovide lp = new lookprovide();
            lp.TopLevel = false;
            lp.Parent = splitContainer1.Panel2;
            lp.Dock = DockStyle.Fill;
            lp.Show();
        }

        private void 添加供应信息_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            provideadd pa = new provideadd();
            pa.TopLevel = false;
            pa.Parent = splitContainer1.Panel2;
            pa.Dock = DockStyle.Fill;
            pa.Show();
        }

        private void 修改供应信息_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            provideupdate pud = new provideupdate();
            pud.TopLevel = false;
            pud.Parent = splitContainer1.Panel2;
            pud.Dock = DockStyle.Fill;
            pud.Show();
        }

        private void 添加供应商信息_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            supplieradd sa = new supplieradd();
            sa.TopLevel = false;
            sa.Parent = splitContainer1.Panel2;
            sa.Dock = DockStyle.Fill;
            sa.Show();
        }

        private void 查询仓库信息_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            inventoryselect ise = new inventoryselect();
            ise.TopLevel = false;
            ise.Parent = splitContainer1.Panel2;
            ise.Dock = DockStyle.Fill;
            ise.Show();
        }

        private void 浏览仓库信息_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            warehoselook wl = new warehoselook();
            wl.TopLevel = false;
            wl.Parent = splitContainer1.Panel2;
            wl.Dock = DockStyle.Fill;
            wl.Show();
        }

        private void 修改密码_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            repasswd rp = new repasswd();
            rp.TopLevel = false;
            rp.Parent = splitContainer1.Panel2;
            rp.Dock = DockStyle.Fill;
            rp.Show();
        }

      

        private void 数据库备份_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            backup bu = new backup();
            bu.TopLevel = false;
            bu.Parent = splitContainer1.Panel2;
            bu.Dock = DockStyle.Fill;
            bu.Show();
        }

        private void 打印_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            printTestForm pr = new printTestForm();
            pr.TopLevel = false;
            pr.Parent = splitContainer1.Panel2;
            pr.Dock = DockStyle.Fill;
            pr.Show();
        }

        private void 重启_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //private void 报表_Click(object sender, EventArgs e)  //营业额
        //{
        //    splitContainer1.Panel2.Controls.Clear();
        //    card ca = new card();
        //    ca.TopLevel = false;
        //    ca.Parent = splitContainer1.Panel2;
        //    ca.Dock = DockStyle.Fill;
        //    ca.Show();
        //}

      

       
       

       

    

      
       

      
       

       
       
       
       

      
       

      

      


       

      
      

    

       

      

      
    }
}
