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
    public partial class Wodedenglu_new : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void Button8_Click(object sender, EventArgs e)
        //{
        //    if (DropDownList1.Text == "员工登录")
        //    {
        //        string str = TextBox1.Text;
        //        SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");//创建数据库连接对象
        //        if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
        //        {
        //            sqlcon.Open();                              //打开数据库连接
        //        }
        //        SqlCommand sqlcmd = new SqlCommand("select 密码 from aspnet_Yuangongtest where 员工OA = '" + str + "';", sqlcon);
        //        //使用ExecuteReader方法的返回值创建SqlDataReader对象
        //        SqlDataReader sqldr = sqlcmd.ExecuteReader();
        //        while (sqldr.Read())
        //        {
        //            Session["password"] = sqldr[0];
        //        }
        //        sqldr.Close();//关闭SqlDataReader对象
        //        if (TextBox2.Text == Convert.ToString(Session["password"]) && TextBox2.Text != "")
        //        {
        //            SqlCommand sqlcmd2 = new SqlCommand("insert into aspnet_Dengluzhe values ('" + str + "','1');", sqlcon);
        //            //使用ExecuteReader方法的返回值创建SqlDataReader对象
        //            SqlDataReader sqldr2 = sqlcmd2.ExecuteReader();
        //            sqldr2.Close();//关闭SqlDataReader对象
        //            Response.Write("<script>window.alert('登陆成功!');location.href='Default.aspx';</script>");
        //        }
        //        else
        //        {
        //            Response.Write("<script>window.alert('登陆失败，请检查员工OA及密码输入是否正确！');location.href='Wodedenglu.aspx';</script>");
        //        }
        //        sqlcon.Close();//关闭数据库连接
        //    }

        //    else if (DropDownList1.Text == "地推网点或部门经理登录")
        //    {
        //        string str = TextBox1.Text;
        //        SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");//创建数据库连接对象
        //        if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
        //        {
        //            sqlcon.Open();                              //打开数据库连接
        //        }
        //        SqlCommand sqlcmd = new SqlCommand("select 密码 from aspnet_Dituiwangdiantest where 客户经理OA = '" + str + "';", sqlcon);
        //        //使用ExecuteReader方法的返回值创建SqlDataReader对象
        //        SqlDataReader sqldr = sqlcmd.ExecuteReader();
        //        while (sqldr.Read())
        //        {
        //            Session["password"] = sqldr[0];
        //        }
        //        sqldr.Close();//关闭SqlDataReader对象
        //        if (TextBox2.Text == Convert.ToString(Session["password"]) && TextBox2.Text != "")
        //        {
        //            SqlCommand sqlcmd2 = new SqlCommand("insert into aspnet_Dengluzhe values ('" + str + "','2');", sqlcon);
        //            //使用ExecuteReader方法的返回值创建SqlDataReader对象
        //            SqlDataReader sqldr2 = sqlcmd2.ExecuteReader();
        //            sqldr2.Close();//关闭SqlDataReader对象
        //            Response.Write("<script>window.alert('登陆成功!');location.href='Default.aspx';</script>");
        //        }
        //        else
        //        {
        //            Response.Write("<script>window.alert('登陆失败，请检查客户经理OA及密码输入是否正确！');location.href='Wodedenglu.aspx';</script>");
        //        }
        //        sqlcon.Close();//关闭数据库连接
        //    }

        //    else
        //    {
        //        SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");//创建数据库连接对象
        //        if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
        //        {
        //            sqlcon.Open();                              //打开数据库连接
        //        }
        //        SqlCommand sqlcmd = new SqlCommand("select 密码 from aspnet_Dituiwangdiantest where 客户经理OA =  'boss';", sqlcon);
        //        SqlDataReader sqldr = sqlcmd.ExecuteReader();
        //        while (sqldr.Read())
        //        {
        //            Session["password"] = sqldr[0];
        //        }
        //        sqldr.Close();//关闭SqlDataReader对象
        //        if (TextBox2.Text == Convert.ToString(Session["password"]))
        //        {
        //            SqlCommand sqlcmd2 = new SqlCommand("insert into aspnet_Dengluzhe values ('boss','3');", sqlcon);
        //            //使用ExecuteReader方法的返回值创建SqlDataReader对象
        //            SqlDataReader sqldr2 = sqlcmd2.ExecuteReader();
        //            sqldr2.Close();//关闭SqlDataReader对象
        //            Response.Write("<script>window.alert('登陆成功!');location.href='Default.aspx';</script>");
        //        }
        //        else
        //        {
        //            Response.Write("<script>window.alert('登陆失败，请检查密码输入是否正确！');location.href='Wodedenglu.aspx';</script>");
        //        }
        //        sqlcon.Close();//关闭数据库连接
        //    }
        //    Session.Remove("password");
        //}
    }
}