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
    public partial class Baobiao2 : System.Web.UI.Page
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
            //Session["yuangongoa_baobiao"] = "";
            //if (DropDownList2.Text == "员工直销")
            //{
            //    Session["yuangongoa_baobiao"] = TextBox1.Text;
            //    if (TextBox1.Text == "")
            //    {
            //        Response.Write("<script>window.alert('请输入员工OA！');location.href='Baobiao2.aspx';</script>");
            //    }
            //    else if (DropDownList1.Text == "销售报表")
            //    {
            //        Response.Redirect("Baobiaoxiaoshou.aspx");
            //    }
            //    else
            //    {
            //        Response.Redirect("Baobiaoyuliang.aspx");
            //    }
            //}
            //else
            //{
            //    Session["manageroa_baobiao"] = TextBox1.Text;
            //    if (TextBox1.Text == "")
            //    {
            //        Response.Write("<script>window.alert('请输入员工OA！');location.href='Baobiao2.aspx';</script>");
            //    }
            //    else if (DropDownList1.Text == "销售报表")
            //    {
            //        Response.Redirect("Baobiaoxiaoshou.aspx");
            //    }
            //    else
            //    {
            //        Response.Redirect("Baobiaoyuliang.aspx");
            //    }
            //}

            int i = 0;
            int j = 0;
            SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");//创建数据库连接对象
            if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
            {
                sqlcon.Open();                              //打开数据库连接
            }
            //创建SqlCommand对象
            SqlCommand sqlcmd2 = new SqlCommand("select 员工OA from aspnet_Yuangongtest", sqlcon);
            //使用ExecuteReader方法的返回值创建SqlDataReader对象
            SqlDataReader sqldr2 = sqlcmd2.ExecuteReader();
            if (sqldr2.HasRows)
            {
                while (sqldr2.Read())
                {
                    if ((string)sqldr2[0] == TextBox1.Text)
                    {
                        i++;
                        break;
                    }
                }
            }
            sqldr2.Dispose();
            sqldr2.Close();//关闭SqlDataReader对象

            SqlCommand sqlcmd = new SqlCommand("select 客户经理OA from aspnet_Dituiwangdiantest", sqlcon);
            //使用ExecuteReader方法的返回值创建SqlDataReader对象
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            if (sqldr.HasRows)
            {
                while (sqldr.Read())
                {
                    if ((string)sqldr[0] == TextBox1.Text)
                    {
                        j++;
                        break;
                    }
                }
            }
            sqldr.Dispose();
            sqldr.Close();//关闭SqlDataReader对象
            sqlcon.Close();//关闭数据库连接

            Session["yuangongoa_baobiao"] = "";
            if(i == 1)
            {
                Session["yuangongoa_baobiao"] = TextBox1.Text;
                if (DropDownList1.Text == "销售报表")
                {
                    Response.Redirect("Baobiaoxiaoshou.aspx");
                }
                else
                {
                    Response.Redirect("Baobiaoyuliang.aspx");
                }
            }
            else if (j == 1)
            {
                Session["manageroa_baobiao"] = TextBox1.Text;
                if (DropDownList1.Text == "销售报表")
                {
                    Response.Redirect("Baobiaoxiaoshou.aspx");
                }
                else
                {
                    Response.Redirect("Baobiaoyuliang.aspx");
                }
            }
            else if (TextBox1.Text == "")
            {
                Response.Write("<script>window.alert('请输入员工OA！');location.href='Baobiao3.aspx';</script>");
            }
            else
            {
                Response.Write("<script>window.alert('OA输入错误，此OA不存在！');location.href='Baobiao3.aspx';</script>");
            }
        }
    }
}