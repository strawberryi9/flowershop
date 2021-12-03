using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FlowerShop.method;

namespace FlowerShop
{
    public partial class card : Form
    {

      //  string sql = "select supplier.sname AS 供应商,sphone as 电话,fid as 鲜花编号 ,pnumber as 供应数量,pdate as 供应日期,saddress as 地址,sremarks as 备注 from provision ,supplier where provision.sname =supplier.sname";
        string sql = "select flower.fname AS 鲜花名称,fprimecost as 进价,fsalecost as 售价 ,rnumber as 销售数量,rdate as 销售日期 from resale ,flower where flower.fid =resale.fid";
        public card()
        {
            InitializeComponent();
        }

        private void card_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = SqlHelper.GetTable(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        
    }
}
