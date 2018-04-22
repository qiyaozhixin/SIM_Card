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
    public partial class Kaika2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToString(Session["quanxian"]) == "")
            {
                Response.Write("<script>window.alert('违规操作！');location.href='Default.aspx';</script>");
            }
            Label6.Text += Session["iccid_kaika"];
            Label8.Text += Session["PUKma_kaika"];
            Label10.Text += Session["IDnumber_kaika"];
            Label12.Text += Session["taocanleixing_kaika"];
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            //xiaoshoushijian = DateTime.Now.ToLocalTime().ToString();
            Session["xiaoshoushijian_kaika"] = DateTime.Now.ToLocalTime().ToString();
            SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");//创建数据库连接对象                                                                                                                    //创建SqlCommand对象
            SqlCommand sqlcmd = new SqlCommand("insert into aspnet_Xiaoshoutest(ICCID,PUK码,套餐类型,销售者,销售时间,身份证号) values ('" + Session["iccid_kaika"] + "','" + Session["PUKma_kaika"] + "','" + Session["taocanleixing_kaika"] + "','" + Session["dangqiandenglu"] + "','" + Session["xiaoshoushijian_kaika"] + "','" + Session["IDnumber_kaika"] + "');update aspnet_Cardtest set 卡状态 = 1 where ICCID = '" + Session["iccid_kaika"] + "';update aspnet_Cardtest set 用户号码 = '" + Session["IDnumber_kaika"] + "' where ICCID = '" + Session["iccid_kaika"] + "';", sqlcon);
            if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
            {
                sqlcon.Open();                              //打开数据库连接
            }
            //使用ExecuteReader方法的返回值创建SqlDataReader对象
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            sqldr.Close();//关闭SqlDataReader对象
            sqlcon.Close();//关闭数据库连接
            Response.Write("<script>window.alert('销售完成！');location.href='Kaika3.aspx';</script>");
        }
    }
}