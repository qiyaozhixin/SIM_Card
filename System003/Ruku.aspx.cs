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
    public partial class Ruku : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Session["iccid_ruku"] = TextBox1.Text;
            Session["PUKma_ruku"] = TextBox2.Text;

            SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");//创建数据库连接对象                                                                                                                     //创建SqlCommand对象
            SqlCommand sqlcmd = new SqlCommand("insert into aspnet_Cardtest(ICCID,当前库位,PUK码,卡状态) values ('" + Session["iccid_ruku"] + "','" + Session["dangqiandenglu"] + "','" + Session["PUKma_ruku"] + "','0');", sqlcon);
            if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
            {
                sqlcon.Open();                              //打开数据库连接
            }
            //使用ExecuteReader方法的返回值创建SqlDataReader对象
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            sqldr.Close();//关闭SqlDataReader对象
            sqlcon.Close();//关闭数据库连接

            Session.Remove("iccid_ruku");
            Session.Remove("PUKma_ruku");

            Response.Write("<script>window.alert('入库成功！');location.href='Ruku.aspx';</script>");
        }
    }
}