using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FlowerShop.method
{
    class measure
    {
        //对象初始化，sqlconnection是类，con是对象，蓝色的都是类，都需要用new来进行初始化，引用类都需要加（）
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader qlddr = null;
        // .\\是电脑的IP地址，database数据库名称
        string s = "Data Source=.\\;database=FlowerShop;uid=sa;pwd=123456";
        SqlConnection getcon;
        #region     ///数据库连接函数
        public SqlConnection getsqlconnect()
        {
            getcon = new SqlConnection(s);
            getcon.Open();
            return getcon;
        }
        #endregion

        #region     ///用户名和密码的验证，判断密码是否正确
        public int logininfofind(string na, string pa)   //入口，将来接收用户名和密码  IPO
        {


            int i = 0;
            ClassMD5 md5 = new ClassMD5();
            try   //1.连接数据库 2.用收到的用户名和密码进行匹配，在数据库中的数据表中进行查询，看收到的用户名和密码是否存在或者正确
            {

                string ss = "select * from Userinfo where name='" + na + "'  ";
                con = getsqlconnect();   //已初始化且定义的类可直接调用
                cmd = new SqlCommand(ss, con);   //执行结果放入cmd中,执行sql语句
                qlddr = cmd.ExecuteReader(); //select语句执行结果保存在qlddr数据容器中
                qlddr.Read();   //读容器里的数据
                if (qlddr.HasRows)  //如果找到数据，返回1
                {

                    if (md5.Md5Decrypt(qlddr[1].ToString()) == pa)
                    {

                        return i = 1;

                    }
                    else
                    {

                        return i = 0;   //信息不存在
                    }

                }
                else
                {
                    return i = 0;
                }
                qlddr.Close();
            }
            catch (Exception ee)    //捕捉异常
            {
                MessageBox.Show(ee.Message.ToString());   //将异常输出，tostring强制转换
                return i = 2;

            }
          
        }
        #endregion

        #region     ///用户名和密码的验证
        public int userfind(string na)   //入口，将来接收用户名和密码  IPO
        {
            int i = 0;
            try   //1.连接数据库 2.用收到的用户名和密码进行匹配，在数据库中的数据表中进行查询，看收到的用户名和密码是否存在或者正确
            {
                string ss = "select * from Userinfo where name='" + na + "'";
                con = getsqlconnect();   //已初始化且定义的类可直接调用
                cmd = new SqlCommand(ss, con);   //执行结果放入cmd中,执行sql语句
                qlddr = cmd.ExecuteReader(); //select语句执行结果保存在qlddr数据容器中
                qlddr.Read();   //读容器里的数据
                if (qlddr.HasRows)   //如果找到数据，返回1
                {
                    return i = 1;
                }
                qlddr.Close();
                return i;   //如果没找到，则输出初始值0，表示没找到

            }
            catch (Exception ee)    //捕捉异常
            {
                MessageBox.Show(ee.Message.ToString());   //将异常输出，tostring强制转换
                return i = 2;

            }


        }
        #endregion

        #region      //用户名和身份验证,判断身份
        public int useridfind(string na, string userid)
        {
            int i = 0;
            try
            {
                string ss = "select * from  Userinfo where name='" + na + "' and rolename='" + userid + "'";
                con = getsqlconnect();  // 已初始化且定义的类可直接调用
                cmd = new SqlCommand(ss, con);
                qlddr = cmd.ExecuteReader();
                qlddr.Read();
                if (qlddr.HasRows)   //判断qlddr是否为空，用行数是否为0进行判断
                {
                    return i = 1;//用户名和密码都正确
                }

                qlddr.Close();
                return i;
            }
            catch (Exception ee)   //捕捉异常
            {
                MessageBox.Show(ee.Message.ToString());     //将异常输出,tostring强制转换
                return i = 2;
            }
        }

        #endregion


        #region     ///新建用户
        public int createuser(string na, string pa, string idcard)   //入口，将来接收用户名和密码  IPO
        {
            int i = 0;
            try   //1.连接数据库 2.用收到的用户名和密码进行匹配，在数据库中的数据表中进行查询，看收到的用户名和密码是否存在或者正确
            {

                string ss = "insert into Userinfo values('" + na + "' ,'" + pa + "','" + idcard + "')";
                con = getsqlconnect();   //已初始化且定义的类可直接调用
                cmd = new SqlCommand(ss, con);   //执行结果放入cmd中,执行sql语句
                i = cmd.ExecuteNonQuery(); //
                return i = 1;

            }
            catch (Exception ee)    //捕捉异常
            {
                MessageBox.Show(ee.Message.ToString());   //将异常输出，tostring强制转换
                return i = 2;

            }


        }
        #endregion

        #region     ///删除用户
        public int deleteuser(string name)   //
        {
            int k = 0;
            try
            {
                string ss = "delete Userinfo where name='" + name + "' ";
                con = getsqlconnect();   //已初始化且定义的类可直接调用,连接数据库
                cmd = new SqlCommand(ss, con);   //执行结果放入cmd中,执行sql语句
                k = cmd.ExecuteNonQuery(); //
                return k = 1;
                //如果没找到，则输出初始值0，表示没找到

            }
            catch (Exception ee)    //捕捉异常
            {
                MessageBox.Show(ee.Message.ToString());   //将异常输出，tostring强制转换
                return k = 2;

            }


        }
        #endregion

        #region ///将数据表中的用户名字段所有值显示在combox中
        public void anduntocom(ComboBox combox)
        {
            try
            {
                string ss = "select name from  Userinfo";//模糊查询
                con = getsqlconnect();//已初始化且定义的类可直接调用
                cmd = new SqlCommand(ss, con);//执行结果放入cmd中，执行sql语句
                qlddr = cmd.ExecuteReader();

                while (qlddr.Read()) //判断行数
                {
                    combox.Items.Add(qlddr[0].ToString());
                }
                qlddr.Close();

            }
            catch (Exception ee) //捕捉异常
            {
                MessageBox.Show(ee.Message.ToString()); //输出异常
            }

        }

        #endregion




        #region //清空数据表
        public void dvclear(DataGridView dv1, int m) //j代表数据表的列数，假设j=9
        {
            int i;
            int j;
            for (i = 0; i < dv1.RowCount; i++)
            {
                for (j = 0; j < m; j++)
                {
                    dv1[j, i].Value = "";
                }
            }

        }
        #endregion



        #region     ///花类是否唯一
        public int flowerfind(string id)   //入口，将来接收用户名和密码  IPO
        {
            int i = 0;
            try   //1.连接数据库 2.用收到的用户名和密码进行匹配，在数据库中的数据表中进行查询，看收到的用户名和密码是否存在或者正确
            {
                string ss = "select * from inventory where fid='" + id + "'";
                con = getsqlconnect();   //已初始化且定义的类可直接调用
                cmd = new SqlCommand(ss, con);   //执行结果放入cmd中,执行sql语句
                qlddr = cmd.ExecuteReader(); //select语句执行结果保存在qlddr数据容器中
                qlddr.Read();   //读容器里的数据
                if (qlddr.HasRows)   //如果找到数据，返回1
                {
                    return i = 1;
                }
                qlddr.Close();
                return i;   //如果没找到，则输出初始值0，表示没找到

            }
            catch (Exception ee)    //捕捉异常
            {
                MessageBox.Show(ee.Message.ToString());   //将异常输出，tostring强制转换
                return i = 2;

            }


        }
        #endregion


        #region     ///修改用户库存
        public int updateretail(string fid)   //
        {
            int i = 0;
            try
            {
              //  string ss = "update Table_user set id='" + userid + "', flag='" + userflag + "' where username='" + name + "'";
                string ss = "update inventory set inventoy.ileft=inventory.ileft-resale.rnumber  from inventory,resale where inventory.fid =resale.fid";
                con = getsqlconnect();   //已初始化且定义的类可直接调用,连接数据库
                cmd = new SqlCommand(ss, con);   //执行结果放入cmd中,执行sql语句
                i = cmd.ExecuteNonQuery(); //
                return i = 1;
                //如果没找到，则输出初始值0，表示没找到

            }
            catch (Exception ee)    //捕捉异常
            {
                MessageBox.Show(ee.Message.ToString());   //将异常输出，tostring强制转换
                return i = 2;

            }


        }
        #endregion

    }
}
