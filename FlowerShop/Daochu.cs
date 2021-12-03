using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FlowerShop
{
    class Daochu
    {
         //导出 excel 数据流方式
        public void ExcelBtnLiu(DataGridView dgvUseName, string name)
        {
            if (dgvUseName.Rows.Count == 0)
            {
                MessageBox.Show("请您检查是否有数据导出", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //提示用户保存文件位置
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xls)|*.xls";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.Title = "导出Excel文件到";
            saveFileDialog.FileName = name;
            DialogResult result = saveFileDialog.ShowDialog();//获取点击取消保存excel文件的按钮事件

            if (result == DialogResult.Cancel) return;//点击取消
            //打开文件流 开始写入
            Stream myStream = saveFileDialog.OpenFile();
            StreamWriter sw = new StreamWriter(myStream, System.Text.Encoding.GetEncoding("gb2312"));
            string str = "";
            try
            {
                //写标题     
                for (int i = 0; i < dgvUseName.ColumnCount; i++)
                {
                    if (i > 0)
                    {
                        str += "\t";
                    }
                    str += dgvUseName.Columns[i].HeaderText;
                }
                sw.WriteLine(str);
                //写内容   
                for (int j = 0; j < dgvUseName.Rows.Count; j++)
                {
                    string tempStr = "";
                    for (int k = 0; k < dgvUseName.Columns.Count; k++)
                    {
                        if (k > 0)
                        {
                            tempStr += "\t";
                        }
                        if (dgvUseName.Rows[j].Cells[k].Value != null)
                        {
                            tempStr += dgvUseName.Rows[j].Cells[k].Value.ToString();
                        }
                        tempStr += "";
                    }
                    sw.WriteLine(tempStr);
                }
                MessageBox.Show("成功导出Excel表", "导出提示");
                sw.Close();
                myStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sw.Close();
                myStream.Close();
            }
        }
    
    }
}
