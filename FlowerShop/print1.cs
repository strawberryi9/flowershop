using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace FlowerShop
{
    public partial class printTestForm : Form
    {
        DGVPrinter dgvPrinter;
        public printTestForm()
        {
            InitializeComponent();
            //dataGridView1.DataSource = CreateTestingDataTable();

            SqlConnection con = new SqlConnection("Data Source=.\\;database=FlowerShop;uid=sa;pwd=123456");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT customer.cid AS 顾客编号,cname AS 顾客姓名,cphone AS 电话,fid AS 鲜花编号, odate AS 订购日期,oimmediately AS 送货时间,otask AS 任务进度 FROM   customer,orderform WHERE customer.cid =orderform.cid ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            dgvPrinter = new DGVPrinter();
            dgvPrinter.SourceDGV = dataGridView1;
        }
       

        private void btn_print_Click(object sender, EventArgs e)
        {
            
            dgvPrinter.PrintDataGridView(dataGridView1);
        }

        private void btn_Setting_Click(object sender, EventArgs e)
        {
            dgvPrinter.SetupPage();
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            dgvPrinter.PrintPreview();
        }
    }
}
