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
    public partial class Chaxun3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToString(Session["quanxian"]) == "")
                {
                    Response.Write("<script>window.alert('违规操作！');location.href='Default.aspx';</script>");
                }
                SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");//创建数据库连接对象                                                                                                                          //创建SqlCommand对象
                SqlCommand sqlcmd = new SqlCommand("select * from aspnet_Xiaoshoutest where ICCID = '" + Session["iccid_xiaoshouchaxun"] + "'", sqlcon);
                if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
                {
                    sqlcon.Open();                              //打开数据库连接
                }
                //使用ExecuteReader方法的返回值创建SqlDataReader对象
                SqlDataReader sqldr = sqlcmd.ExecuteReader();
                GridView1.DataSource = sqldr;
                GridView1.DataBind();
                sqldr.Close();//关闭SqlDataReader对象
                sqlcon.Close();//关闭数据库连接
                Session.Remove("iccid_xiaoshouchaxun");
            }
            catch
            {

            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {

        }
    }
}