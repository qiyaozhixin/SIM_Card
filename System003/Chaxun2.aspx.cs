﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace System003
{
    public partial class Chaxun : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //try
            //{              
            if (Convert.ToString(Session["quanxian"]) == "")
            {
                Response.Write("<script>window.alert('违规操作！');location.href='Default.aspx';</script>");
            }
            string kuweimingcheng;
            string diaoboren;
            string iccid;
            string where1;
            string and1 = "";
            string and2 = "";
            int i = 0;
            int j = 0;
            if (Convert.ToString(Session["kuweimingcheng_diaobochaxun"]) != "" || Convert.ToString(Session["diaoboren_diaobochaxun"]) != "" || Convert.ToString(Session["iccid_diaobochaxun"]) != "")
            {
                where1 = "where";
            }
            else
            {
                where1 = "";
            }

            if (Convert.ToString(Session["kuweimingcheng_diaobochaxun"]) == "")
            {
                kuweimingcheng = "";
            }
            else
            {
                kuweimingcheng = "库位名称 = '" + Session["kuweimingcheng_diaobochaxun"] + "'";
                i = 1;
            }
            if (Convert.ToString(Session["diaoboren_diaobochaxun"]) == "")
            {
                diaoboren = "";
            }
            else
            {
                if (i==1)
                {
                    and1 = "and";
                }
                diaoboren = " 调拨人 = '" + Session["diaoboren_diaobochaxun"] + "' ";
                j = 1;
            }
            if (Convert.ToString(Session["iccid_diaobochaxun"]) == "")
            {
                iccid = "";
            }
            else
            {
                if (i == 1 || j == 1)
                {
                    and2 = "and";
                }
                iccid = " ICCID = '" + Session["iccid_diaobochaxun"] + "'";
            }

            //SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=123456;");//创建数据库连接对象                                                                                                                          //创建SqlCommand对象
            ////SqlCommand sqlcmd = new SqlCommand("select * from aspnet_Diaobotest where 库位名称 = '" + Session["kuweimingcheng_diaobochaxun"] + "' and 调拨人 = '" + Session["diaoboren_diaobochaxun"] + "' and ICCID = '" + Session["iccid_diaobochaxun"] + "'", sqlcon);
            //SqlCommand sqlcmd = new SqlCommand("select * from aspnet_Diaobotest " + where1 + " " + kuweimingcheng + " " + and1 + " " + diaoboren + " " + and2 + " " + iccid + " ", sqlcon);
            ////SqlCommand sqlcmd = new SqlCommand("select * from aspnet_Diaobotest " + where1 + " " + kuweimingcheng + " " + diaoboren + " ", sqlcon);
            ////SqlCommand sqlcmd = new SqlCommand("select * from aspnet_Diaobotest " + where1 + " " + kuweimingcheng + "", sqlcon);
            ////SqlCommand sqlcmd = new SqlCommand("select * from aspnet_Diaobotest " + where1 + " 库位名称 = '2014061132'", sqlcon);
            ////SqlCommand sqlcmd = new SqlCommand("select * from aspnet_Diaobotest where 库位名称 = '2014061132'", sqlcon);
            ////SqlCommand sqlcmd = new SqlCommand("select * from aspnet_Diaobotest", sqlcon);
            //if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
            //{
            //    sqlcon.Open();                              //打开数据库连接
            //}
            ////使用ExecuteReader方法的返回值创建SqlDataReader对象
            //SqlDataReader sqldr = sqlcmd.ExecuteReader();
            //GridView1.DataSource = sqldr;
            //GridView1.DataBind();
            //sqldr.Close();//关闭SqlDataReader对象


            //定义数据库连接字符串
            SqlConnection con = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=123456;");
            //定义执行查询操作的SQL语句
            string sqlstr = "select * from aspnet_Diaobotest " + where1 + " " + kuweimingcheng + " " + and1 + " " + diaoboren + " " + and2 + " " + iccid + " ";
            //创建数据适配器
            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            //创建数据集
            DataSet ds = new DataSet();
            //填充数据集
            da.Fill(ds);
            //设置GridView控件的数据源为创建的数据集ds
            GridView1.DataSource = ds;
            //将数据库表中的主键字段放入GridView控件的DataKeyNames属性中
            GridView1.DataKeyNames = new string[] { "DBID" };
            //绑定数据库表中数据
            GridView1.DataBind();
            con.Close();//关闭数据库连接
            //Session.Remove("iccid_diaobochaxun");
            //Session.Remove("diaoboren_diaobochaxun");
            //Session.Remove("kuweimingcheng_diaobochaxun");
            //}
            //catch
            //{

            //}
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            
        }

        public void BindData()
        {
            string kuweimingcheng;
            string diaoboren;
            string iccid;
            string where1;
            string and1 = "";
            string and2 = "";
            int i = 0;
            int j = 0;
            if (Convert.ToString(Session["kuweimingcheng_diaobochaxun"]) != "" || Convert.ToString(Session["diaoboren_diaobochaxun"]) != "" || Convert.ToString(Session["iccid_diaobochaxun"]) != "")
            {
                where1 = "where";
            }
            else
            {
                where1 = "";
            }

            if (Convert.ToString(Session["kuweimingcheng_diaobochaxun"]) == "")
            {
                kuweimingcheng = "";
            }
            else
            {
                kuweimingcheng = "库位名称 = '" + Session["kuweimingcheng_diaobochaxun"] + "'";
                i = 1;
            }
            if (Convert.ToString(Session["diaoboren_diaobochaxun"]) == "")
            {
                diaoboren = "";
            }
            else
            {
                if (i == 1)
                {
                    and1 = "and";
                }
                diaoboren = " 调拨人 = '" + Session["diaoboren_diaobochaxun"] + "' ";
                j = 1;
            }
            if (Convert.ToString(Session["iccid_diaobochaxun"]) == "")
            {
                iccid = "";
            }
            else
            {
                if (i == 1 || j == 1)
                {
                    and2 = "and";
                }
                iccid = " ICCID = '" + Session["iccid_diaobochaxun"] + "'";
            }
            //定义数据库连接字符串
            SqlConnection con = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=123456;");
            //定义执行查询操作的SQL语句
            string sqlstr = "select * from aspnet_Diaobotest " + where1 + " " + kuweimingcheng + " " + and1 + " " + diaoboren + " " + and2 + " " + iccid + " ";
            //创建数据适配器
            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            //创建数据集
            DataSet ds = new DataSet();
            //填充数据集
            da.Fill(ds);
            //设置GridView控件的数据源为创建的数据集ds
            GridView1.DataSource = ds;
            //将数据库表中的主键字段放入GridView控件的DataKeyNames属性中
            GridView1.DataKeyNames = new string[] { "DBID" };
            //绑定数据库表中数据
            GridView1.DataBind();
            con.Close();//关闭数据库连接
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            BindData();//数据绑定
        }
    }
}