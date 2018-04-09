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
    public partial class Wodezhuce : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");//创建数据库连接对象
                if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
                {
                    sqlcon.Open();                              //打开数据库连接
                }
                SqlCommand sqlcmd = new SqlCommand("insert into aspnet_Yuangongtest values('" + TextBox1.Text + "','" + TextBox3.Text + "','" + DropDownList1.Text + "','" + TextBox2.Text + "',null)", sqlcon);
                SqlDataReader sqldr = sqlcmd.ExecuteReader();
                Response.Write("<script>window.alert('注册成功!');location.href='Default.aspx';</script>");
                sqldr.Close();//关闭SqlDataReader对象
                sqlcon.Close();//关闭数据库连接
            }
            catch
            {
                Response.Write("<script>window.alert('注册失败,此员工已完成注册!');location.href='Wodezhuce.aspx';</script>");
            }
        }
    }
}