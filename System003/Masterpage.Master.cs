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
    public partial class Masterpage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["quanxian"] = 0;
            SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=123456;");//创建数据库连接对象                                                                                                                     //创建SqlCommand对象
            SqlCommand sqlcmd = new SqlCommand("select OA from aspnet_Dengluzhe;select 权限 from aspnet_Dengluzhe", sqlcon);
            if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
            {
                sqlcon.Open();                              //打开数据库连接
            }
            //使用ExecuteReader方法的返回值创建SqlDataReader对象
            //Label2.Text = string.Format("{0}", sqlcmd.ExecuteScalar());
            //Session["dangqiandenglu"] = string.Format("{0}", sqlcmd.ExecuteScalar());
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            do
            {
                if (sqldr.HasRows)
                {
                    while (sqldr.Read())
                    {
                        //Label2.Text += sqldr[0];
                        //Session["dangqiandenglu"] = Label2.Text;
                        Session["dangqiandenglu"] = sqldr[0];
                        if(Label2.Text == "")
                        {
                            Label2.Text += Session["dangqiandenglu"];
                        }
                    }
                }
            }
            while (sqldr.NextResult() == false);
            if (sqldr.HasRows)
            {
                while (sqldr.Read())
                {
                    Session["quanxian"] = sqldr[0];
                }
            }
            Button8.Visible = false;
            Label1.Visible = true;
            Button7.Visible = true;
            if (int.Parse(Session["quanxian"].ToString()) == 3)//有登陆
            {
                Button8.Visible = true;
                Button11.Visible = true;
            }
            else if(int.Parse(Session["quanxian"].ToString()) == 2)
            {
                Button8.Visible = true;
            }
            else if (int.Parse(Session["quanxian"].ToString()) == 1)
            {
                Button8.Visible = true;
                Button10.Visible = false;
            }
            else//还未登陆
            {
                Label1.Visible = false;
                Label3.Visible = true;
                Button1.Visible = false;
                Button2.Visible = false;
                Button3.Visible = false;
                Button4.Visible = false;
                Button7.Visible = false;
                Button10.Visible = false;
                Button9.Visible = true;
                Button11.Visible = false;
            }
            sqldr.Close();//关闭SqlDataReader对象
            sqlcon.Close();//关闭数据库连接
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=123456;");//创建数据库连接对象                                                                                                                    //创建SqlCommand对象
            SqlCommand sqlcmd = new SqlCommand("delete from aspnet_Dengluzhe", sqlcon);
            if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
            {
                sqlcon.Open();                              //打开数据库连接
            }
            //使用ExecuteReader方法的返回值创建SqlDataReader对象
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            sqldr.Close();//关闭SqlDataReader对象
            sqlcon.Close();//关闭数据库连接
            Session.Remove("dangqiandenglu");
            Session.Remove("quanxian");
            Response.Redirect("Wodedenglu.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Write("<script>window.alert('提示：激活前需准备好本人的身份证和SIM卡！');location.href='Kaika.aspx';</script>");
        }

        protected void Button3_Click(object sender, EventArgs e)
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