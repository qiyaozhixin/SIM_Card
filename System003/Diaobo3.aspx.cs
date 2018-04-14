using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace System003
{
    public partial class Diaobo3 : System.Web.UI.Page
    {
        string diaoboren;
        string[] iccid = new string[1000];
        int i = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Label1.Text += Session["kuwei_diaobo"];
                SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");//创建数据库连接对象
                if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
                {
                    sqlcon.Open();                              //打开数据库连接
                }
                //创建SqlCommand对象
                SqlCommand sqlcmd = new SqlCommand("select * from aspnet_Linshika", sqlcon);
                //使用ExecuteReader方法的返回值创建SqlDataReader对象
                SqlDataReader sqldr = sqlcmd.ExecuteReader();
                if (sqldr.HasRows)
                {
                    while (sqldr.Read())
                    {
                        Label4.Text += sqldr[0] + "<br>";
                    }
                }
                sqldr.Dispose();
                sqldr.Close();//关闭SqlDataReader对象
                sqlcon.Close();//关闭数据库连接
            }
            catch
            {

            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            //string diaoboren, kuweimingcheng, shenqingshijian, iccid;
            SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");//创建数据库连接对象
            if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
            {
                sqlcon.Open();                              //打开数据库连接
            }
            SqlCommand sqlcmd = new SqlCommand("select * from aspnet_Dengluzhe", sqlcon);
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            if (sqldr.Read())
            {
                diaoboren = (string)sqldr[0];
            }
            sqldr.Close();//关闭SqlDataReader对象
          
            SqlCommand sqlcmd3 = new SqlCommand("select * from aspnet_Linshika", sqlcon);
            SqlDataReader sqldr3 = sqlcmd3.ExecuteReader();
            while (sqldr3.Read())
            {
                iccid[i] = (string)sqldr3[0];
                i++;
            }
            sqldr3.Close();//关闭SqlDataReader对象
            
            Session["shengqingshijian_diaobo"] = DateTime.Now.ToLocalTime().ToString();
            for (int j = 0; j < i; j++)
            {
                SqlCommand sqlcmd4 = new SqlCommand("insert into aspnet_Diaobotest(库位名称,调拨人,ICCID,申请时间) values ('" + Session["kuwei_diaobo"] + "','" + diaoboren + "','" + iccid[j] + "','" + Session["shengqingshijian_diaobo"] + "');update aspnet_Cardtest set 当前库位 = '" + Session["kuwei_diaobo"] + "' where ICCID = '" + iccid[j] + "';update aspnet_Cardtest set 最近调拨 = '" + diaoboren + "' where ICCID = '" + iccid[j] + "';", sqlcon);
                SqlDataReader sqldr4 = sqlcmd4.ExecuteReader();
                sqldr4.Close();//关闭SqlDataReader对象
            }
            sqlcon.Close();//关闭数据库连接
            Response.Write("<script>window.alert('调拨成功！');location.href='Diaobo4.aspx';</script>");
        }
    }
}