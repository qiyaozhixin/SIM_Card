using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace System003
{
    public partial class Baobiao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                //创建数据库连接字符串
                string SqlStr = "server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;";
                SqlConnection con = new SqlConnection(SqlStr);  //创建数据库连接对象
                
                if (con.State == ConnectionState.Closed)            //判断连接是否关闭
                {
                    Label2.Text = "SQL Server数据库连接关闭！";
                }
                con.Open();                                 //打开数据库连接
                if (con.State == ConnectionState.Open)          //判断连接是否打开
                {
                    Label1.Text = "SQL Server数据库连接开启！";
                    con.Close();                                //关闭数据库连接
                }
            }

            catch
            {
                Label2.Text = "GG";
            }
        }
    }
}