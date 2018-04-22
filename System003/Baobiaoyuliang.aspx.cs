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
    public partial class Baobiaoyuliang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToString(Session["quanxian"]) == "")
                {
                    Response.Write("<script>window.alert('违规操作！');location.href='Default.aspx';</script>");
                }
                if (Convert.ToString(Session["yuangongoa_baobiao"]) != "")
                {
                    SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=123456;");//创建数据库连接对象
                    if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
                    {
                        sqlcon.Open();                              //打开数据库连接
                    }
                    //创建SqlCommand对象
                    SqlCommand sqlcmd = new SqlCommand("select 所在部门 from aspnet_Yuangongtest where 员工OA = '" + Session["yuangongoa_baobiao"] + "';select count(*) from aspnet_Cardtest where 当前库位 = '" + Session["yuangongoa_baobiao"] + "' and 卡状态 <> 1", sqlcon);
                    //使用ExecuteReader方法的返回值创建SqlDataReader对象
                    SqlDataReader sqldr = sqlcmd.ExecuteReader();
                    do
                    {
                        if (sqldr.HasRows)
                        {
                            while (sqldr.Read())
                            {
                                Label4.Text += sqldr[0];
                            }
                        }
                    }
                    while (sqldr.NextResult() == false);
                    if (sqldr.HasRows)
                    {
                        while (sqldr.Read())
                        {
                            Label8.Text += sqldr[0];
                        }
                    }
                    sqldr.Dispose();
                    sqldr.Close();//关闭SqlDataReader对象
                    sqlcon.Close();//关闭数据库连接
                    Label6.Text += Session["yuangongoa_baobiao"];
                    Label10.Text = DateTime.Now.ToLocalTime().ToString();
                    Session.Remove("yuangongoa_baobiao");
                }

                else
                {
                    SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=123456;");//创建数据库连接对象
                    if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
                    {
                        sqlcon.Open();                              //打开数据库连接
                    }
                    //创建SqlCommand对象
                    SqlCommand sqlcmd = new SqlCommand("select 网点名称 from aspnet_Dituiwangdiantest where 客户经理OA = '" + Session["manageroa_baobiao"] + "';select count(*) from aspnet_Cardtest where 当前库位 = '" + Session["manageroa_baobiao"] + "' and 卡状态 <> 1", sqlcon);
                    //使用ExecuteReader方法的返回值创建SqlDataReader对象
                    SqlDataReader sqldr = sqlcmd.ExecuteReader();
                    do
                    {
                        if (sqldr.HasRows)
                        {
                            while (sqldr.Read())
                            {
                                Label4.Text += sqldr[0];
                            }
                        }
                    }
                    while (sqldr.NextResult() == false);
                    if (sqldr.HasRows)
                    {
                        while (sqldr.Read())
                        {
                            Label8.Text += sqldr[0];
                        }
                    }
                    sqldr.Dispose();
                    sqldr.Close();//关闭SqlDataReader对象
                    sqlcon.Close();//关闭数据库连接
                    Label6.Text += Session["manageroa_baobiao"];
                    Label10.Text = DateTime.Now.ToLocalTime().ToString();
                    Session.Remove("manageroa_baobiao");
                }
            }
            catch
            {

            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            if (int.Parse(Session["quanxian"].ToString()) == 1)
            {
                Response.Redirect("Baobiao.aspx");
            }
            if (int.Parse(Session["quanxian"].ToString()) == 2)
            {
                Response.Redirect("Baobiao2.aspx");
            }
            if (int.Parse(Session["quanxian"].ToString()) == 3)
            {
                Response.Redirect("Baobiao3.aspx");
            }
        }
    }
}