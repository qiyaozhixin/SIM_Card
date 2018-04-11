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
            SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");//创建数据库连接对象                                                                                                                     //创建SqlCommand对象
            SqlCommand sqlcmd = new SqlCommand("select * from aspnet_Dengluzhe", sqlcon);
            if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
            {
                sqlcon.Open();                              //打开数据库连接
            }
            //使用ExecuteReader方法的返回值创建SqlDataReader对象
            Label2.Text = string.Format("{0}", sqlcmd.ExecuteScalar());
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            Button8.Visible = false;
            Label1.Visible = true;
            Button7.Visible = true;
            //Label3.Visible = false;
            if (sqldr.Read())//有登陆
            {
                //Label2.Text += sqldr[0];
                //Label2.Text = string.Format("{0}", sqlcmd.ExecuteScalar());
                Button8.Visible = true;
                //Button7.Visible = false;
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
                Button9.Visible = true;
            }
            sqldr.Close();//关闭SqlDataReader对象
            sqlcon.Close();//关闭数据库连接
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");//创建数据库连接对象                                                                                                                    //创建SqlCommand对象
            SqlCommand sqlcmd = new SqlCommand("delete from aspnet_Dengluzhe", sqlcon);
            if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
            {
                sqlcon.Open();                              //打开数据库连接
            }
            //使用ExecuteReader方法的返回值创建SqlDataReader对象
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            sqldr.Close();//关闭SqlDataReader对象
            sqlcon.Close();//关闭数据库连接
            //System.Threading.Thread.Sleep(3000);
            Response.Redirect("Wodedenglu.aspx");
        }
    }
}