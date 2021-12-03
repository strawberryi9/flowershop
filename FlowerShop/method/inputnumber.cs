using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerShop.method
{
    class inputnumber
    {
        public void ForceNumberInput(TextBox tb)
        {
            tb.KeyPress -= TextBox_KeyPress;
            tb.KeyPress += TextBox_KeyPress;
        }
        public static void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字键，也不是回车键、Backspace键，第一个输入不是负号，则取消该输入
            if (!(Char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)13) && (e.KeyChar != (char)8)
                && (!((((TextBox)sender).Text == "") && (e.KeyChar == (char)45))))
            {
                e.Handled = true;
            }
        }
    }
}
