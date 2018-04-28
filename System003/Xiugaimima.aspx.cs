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
    public partial class Xiugaimima : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToString(Session["quanxian"]) == "")
            {
                Response.Write("<script>window.alert('违规操作！');location.href='Default.aspx';</script>");
            }
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            if (int.Parse(Session["quanxian"].ToString()) == 1)
            {
                SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=123456;");//创建数据库连接对象                                                                                                                         //创建SqlCommand对象
                SqlCommand sqlcmd = new SqlCommand("select 密码 from aspnet_Yuangongtest where 员工OA = '" + Session["dangqiandenglu"] + "'", sqlcon);
                if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
                {
                    sqlcon.Open();                              //打开数据库连接
                }
                //使用ExecuteReader方法的返回值创建SqlDataReader对象
                SqlDataReader sqldr = sqlcmd.ExecuteReader();
                if (sqldr.HasRows)
                {
                    while (sqldr.Read())
                    {
                        Session["mima_xiugai"] = sqldr[0];
                    }
                }
                sqldr.Close();//关闭SqlDataReader对象   
                if (Convert.ToString(Session["mima_xiugai"]) != TextBox1.Text)
                {
                    Response.Write("<script>window.alert('原密码输入错误！');location.href='Xiugaimima.aspx';</script>");                 
                }
                if (TextBox2.Text == "")
                {
                    Response.Write("<script>window.alert('修改后密码不能为空!');location.href='Xiugaimima.aspx';</script>");
                }
                else
                {
                    SqlCommand sqlcmd2 = new SqlCommand("update aspnet_Yuangongtest set 密码 = '" + TextBox2.Text + "' where 员工OA = '" + Session["dangqiandenglu"] + "';", sqlcon);
                    //使用ExecuteReader方法的返回值创建SqlDataReader对象
                    SqlDataReader sqldr2 = sqlcmd2.ExecuteReader();
                    sqldr2.Close();//关闭SqlDataReader对象
                    Response.Write("<script>window.alert('修改成功!');location.href='Xiugaimima.aspx';</script>");
                }
                sqlcon.Close();//关闭数据库连接
            }
            else
            {
                SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=123456;");//创建数据库连接对象                                                                                                                         //创建SqlCommand对象
                SqlCommand sqlcmd = new SqlCommand("select 密码 from aspnet_Dituiwangdiantest where 客户经理OA = '" + Session["dangqiandenglu"] + "'", sqlcon);
                if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
                {
                    sqlcon.Open();                              //打开数据库连接
                }
                //使用ExecuteReader方法的返回值创建SqlDataReader对象
                SqlDataReader sqldr = sqlcmd.ExecuteReader();
                if (sqldr.HasRows)
                {
                    while (sqldr.Read())
                    {
                        Session["mima_xiugai"] = sqldr[0];
                    }
                }
                sqldr.Close();//关闭SqlDataReader对象
                if (Convert.ToString(Session["mima_xiugai"]) != TextBox1.Text)
                {
                    Response.Write("<script>window.alert('原密码输入错误！');location.href='Xiugaimima.aspx';</script>");     
                }
                if (TextBox2.Text == "")
                {
                    Response.Write("<script>window.alert('修改后密码不能为空!');location.href='Xiugaimima.aspx';</script>");
                }
                else
                {
                    SqlCommand sqlcmd2 = new SqlCommand("update aspnet_Dituiwangdiantest set 密码 = '" + TextBox2.Text + "' where 客户经理OA = '" + Session["dangqiandenglu"] + "';", sqlcon);
                    //使用ExecuteReader方法的返回值创建SqlDataReader对象
                    SqlDataReader sqldr2 = sqlcmd2.ExecuteReader();
                    sqldr2.Close();//关闭SqlDataReader对象
                    Response.Write("<script>window.alert('修改成功!');location.href='Xiugaimima.aspx';</script>");
                }
                sqlcon.Close();//关闭数据库连接
            }
            Session.Remove("mima_xiugai");
        }
    }
}