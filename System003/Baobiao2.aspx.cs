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
    public partial class Baobiao21 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToString(Session["quanxian"]) == "")
            {
                Response.Write("<script>window.alert('违规操作！');location.href='Default.aspx';</script>");
            }
            SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");//创建数据库连接对象
            if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
            {
                sqlcon.Open();                              //打开数据库连接
            }
            //创建SqlCommand对象
            SqlCommand sqlcmd = new SqlCommand("select 所在部门 from aspnet_Yuangongtest where 所在部门 IN (select 网点名称 from aspnet_Dituiwangdiantest where 客户经理OA = '" + Session["dangqiandenglu"] + "')", sqlcon);
            //使用ExecuteReader方法的返回值创建SqlDataReader对象
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            if (sqldr.HasRows)//是部门经理
            {
                Button9.Text = "生成报表";
                Label3.Visible = true;
                TextBox1.Visible = true;
            }
            else//是地推网点经理
            {
                Button9.Text = "生成地推网点报表";
                Label3.Visible = false;
                TextBox1.Visible = false;
            }
            sqldr.Dispose();
            sqldr.Close();//关闭SqlDataReader对象
            sqlcon.Close();//关闭数据库连接
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            int i=0;
            SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");//创建数据库连接对象
            if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
            {
                sqlcon.Open();                              //打开数据库连接
            }
            //创建SqlCommand对象
            SqlCommand sqlcmd2 = new SqlCommand("select 员工OA from aspnet_Yuangongtest where 所在部门 IN (select 网点名称 from aspnet_Dituiwangdiantest where 客户经理OA = '" + Session["dangqiandenglu"] + "')", sqlcon);
            //使用ExecuteReader方法的返回值创建SqlDataReader对象
            SqlDataReader sqldr2 = sqlcmd2.ExecuteReader();
            if (sqldr2.HasRows)
            {
                while (sqldr2.Read())
                {
                    if ((string)sqldr2[0] == TextBox1.Text || Convert.ToString(Session["dangqiandenglu"]) == TextBox1.Text)
                    {
                        i++;
                        break;
                    }
                }
            }          
            sqldr2.Dispose();
            sqldr2.Close();//关闭SqlDataReader对象

            //创建SqlCommand对象
            SqlCommand sqlcmd = new SqlCommand("select 所在部门 from aspnet_Yuangongtest where 所在部门 IN (select 网点名称 from aspnet_Dituiwangdiantest where 客户经理OA = '" + Session["dangqiandenglu"] + "')", sqlcon);
            //使用ExecuteReader方法的返回值创建SqlDataReader对象
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            if (sqldr.HasRows)//是部门经理
            {
                Session["yuangongoa_baobiao"] = TextBox1.Text;
                if (TextBox1.Text == "")
                {
                    Response.Write("<script>window.alert('请输入员工OA！');location.href='Baobiao2.aspx';</script>");
                }
                else if (i == 0)
                {
                    Response.Write("<script>window.alert('请输入本部门员工OA！');location.href='Baobiao2.aspx';</script>");
                }
                else if (DropDownList1.Text == "销售报表")
                {
                    Response.Redirect("Baobiaoxiaoshou.aspx");
                }
                else
                {
                    Response.Redirect("Baobiaoyuliang.aspx");
                }
            }
            else//是地推网点经理
            {
                Session["manageroa_baobiao"] = Session["dangqiandenglu"];
                if (DropDownList1.Text == "销售报表")
                {
                    Response.Redirect("Baobiaoxiaoshou.aspx");
                }
                else
                {
                    Response.Redirect("Baobiaoyuliang.aspx");
                }
            }
            sqldr.Dispose();
            sqldr.Close();//关闭SqlDataReader对象
            sqlcon.Close();//关闭数据库连接
        }
    }
}