﻿using System;
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
                SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");//创建数据库连接对象
                if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
                {
                    sqlcon.Open();                              //打开数据库连接
                }
                //创建SqlCommand对象
                SqlCommand sqlcmd = new SqlCommand("select 所在部门 from aspnet_Yuangongtest where 员工OA = '" + Session["baobiaoyuangongoa"] + "';select count(*) from aspnet_Diaobotest where 库位名称 = '" + Session["baobiaoyuangongoa"] + "'", sqlcon);
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
                Label6.Text += Session["baobiaoyuangongoa"];
                Label10.Text = DateTime.Now.ToLocalTime().ToString();
            }
            catch
            {

            }
        }
    }
}