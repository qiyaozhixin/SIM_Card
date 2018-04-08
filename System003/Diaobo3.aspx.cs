using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace System003
{
    public partial class Diaobo3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");//创建数据库连接对象
                                                                                                                          //创建SqlCommand对象
                SqlCommand sqlcmd = new SqlCommand("select * from aspnet_Linshiyuangong", sqlcon);
                if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
                {
                    sqlcon.Open();                              //打开数据库连接
                }
                //使用ExecuteReader方法的返回值创建SqlDataReader对象
                SqlDataReader sqldr = sqlcmd.ExecuteReader();

                //Label2.Text = "adadasd";
                //Label1.Text = sqldr.GetString(sqldr.GetOrdinal("OA")).Trim();
                while(sqldr.Read())
                {
                    Label1.Text += sqldr["OA"] + "<br>";
                }
                
                sqldr.Close();//关闭SqlDataReader对象
                sqlcon.Close();//关闭数据库连接




                //SqlCommand sqlcmdview1 = new SqlCommand("select * from aspnet_Linshiyuangong", sqlcon);
                //SqlDataReader sqldrview1 = sqlcmdview1.ExecuteReader();
                //Label1.Text = sqldrview1.GetString(sqldrview1.GetOrdinal("OA"));
                //Label1.Text = "adadasd";

                //sqldr.Close();//关闭SqlDataReader对象
                //sqldrview1.Close();//关闭SqlDataReader对象
                //sqlcon.Close();//关闭数据库连接  
            }
            catch
            {

            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");//创建数据库连接对象
            if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
            {
                sqlcon.Open();                              //打开数据库连接
            }
            SqlCommand sqlcmd = new SqlCommand("delete from aspnet_Linshiyuangong", sqlcon);
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            sqldr.Close();//关闭SqlDataReader对象
            sqlcon.Close();//关闭数据库连接
            Response.Redirect("Diaobo.aspx");
        }
    }
}