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
    public partial class Chaxun1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToString(Session["quanxian"]) == "")
            {
                Response.Write("<script>window.alert('违规操作！');location.href='Default.aspx';</script>");
            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            int i = 0;
            SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=123456;");//创建数据库连接对象
            if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
            {
                sqlcon.Open();                              //打开数据库连接
            }
            //创建SqlCommand对象
            SqlCommand sqlcmd = new SqlCommand("select ICCID from aspnet_Cardtest", sqlcon);
            //使用ExecuteReader方法的返回值创建SqlDataReader对象
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            if (sqldr.HasRows)
            {
                while (sqldr.Read())
                {
                    if ((string)sqldr[0] == TextBox1.Text)
                    {
                        i++;
                        break;
                    }
                }
            }
            sqldr.Dispose();
            sqldr.Close();//关闭SqlDataReader对象
            sqlcon.Close();//关闭数据库连接

            Session["iccid_diaobochaxun"] = TextBox1.Text;
            if(TextBox1.Text == "")
            {
                Response.Write("<script>window.alert('请输入ICCID！');location.href='Chaxun.aspx';</script>");
            }
            else if(i == 1)
            {
                Response.Redirect("Chaxun2.aspx");
            }
            else
            {
                Response.Write("<script>window.alert('ICCID输入错误，此卡不存在！');location.href='Chaxun.aspx';</script>");
            }
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            int i = 0;
            SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=123456;");//创建数据库连接对象
            if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
            {
                sqlcon.Open();                              //打开数据库连接
            }
            //创建SqlCommand对象
            SqlCommand sqlcmd = new SqlCommand("select ICCID from aspnet_Cardtest", sqlcon);
            //使用ExecuteReader方法的返回值创建SqlDataReader对象
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            if (sqldr.HasRows)
            {
                while (sqldr.Read())
                {
                    if ((string)sqldr[0] == TextBox1.Text)
                    {
                        i++;
                        break;
                    }
                }
            }
            sqldr.Dispose();
            sqldr.Close();//关闭SqlDataReader对象
            sqlcon.Close();//关闭数据库连接

            Session["iccid_xiaoshouchaxun"] = TextBox1.Text;
            if (TextBox1.Text == "")
            {
                Response.Write("<script>window.alert('请输入ICCID！');location.href='Chaxun.aspx';</script>");
            }
            else if (i == 1)
            {
                Response.Redirect("Chaxun3.aspx");
            }
            else
            {
                Response.Write("<script>window.alert('ICCID输入错误，此卡不存在！');location.href='Chaxun.aspx';</script>");
            }
        }
    }
}