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
    public partial class Diaobo4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Label1.Text += Session["kuwei_diaobo"];
                SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");//创建数据库连接对象
                if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
                {
                    sqlcon.Open();                              //打开数据库连接
                }
                //创建SqlCommand对象
                SqlCommand sqlcmd = new SqlCommand("select * from aspnet_Linshika;select * from aspnet_Dengluzhe", sqlcon);
                //使用ExecuteReader方法的返回值创建SqlDataReader对象
                SqlDataReader sqldr = sqlcmd.ExecuteReader();
                do
                {
                    if (sqldr.HasRows)
                    {
                        while (sqldr.Read())
                        {
                            Label4.Text += sqldr[0] + "<br>";
                        }
                    }
                }
                while (sqldr.NextResult() == false);
                if (sqldr.HasRows)
                {
                    while (sqldr.Read())
                    {
                        Label9.Text += sqldr[0] + "<br>";
                    }
                }
                sqldr.Dispose();
                sqldr.Close();//关闭SqlDataReader对象
                sqlcon.Close();//关闭数据库连接
                Label6.Text += Session["shengqingshijian_diaobo"];
                Session.Remove("kuwei_diaobo");
                Session.Remove("shengqingshijian_diaobo");
            }
            catch
            {

            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("Diaobo.aspx");
        }
    }
}