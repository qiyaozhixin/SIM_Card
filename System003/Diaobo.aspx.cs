using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace System003
{
    public partial class Diaobo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Button7.Visible = true;
            //Button8.Visible = true;
            if (!IsPostBack)
            {
                //调用自定义方法绑定数据到控件
                BindData();

                if (int.Parse(Session["quanxian"].ToString()) == 3)
                {
                    SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");//创建数据库连接对象                                                                                                                          //创建SqlCommand对象
                    SqlCommand sqlcmd = new SqlCommand("select * from aspnet_Cardtest where 卡状态 <> 1", sqlcon);
                    if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
                    {
                        sqlcon.Open();                              //打开数据库连接
                    }
                    //使用ExecuteReader方法的返回值创建SqlDataReader对象
                    SqlDataReader sqldr = sqlcmd.ExecuteReader();
                    if (sqldr.HasRows)
                    {

                    }
                    else
                    {
                        Response.Write("<script>window.alert('当前库位中没有可调拨的电话卡！');location.href='Default.aspx';</script>");
                    }
                    sqldr.Close();//关闭SqlDataReader对象
                    sqlcon.Close();//关闭数据库连接
                }
                else if (int.Parse(Session["quanxian"].ToString()) == 2)
                {
                    if (Convert.ToString(Session["manager_diaobo"]) == "dituijingli")
                    {
                        SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");//创建数据库连接对象                                                                                                                          //创建SqlCommand对象
                        SqlCommand sqlcmd = new SqlCommand("select * from aspnet_Cardtest where 当前库位 = '" + Session["dangqiandenglu"] + "' and 卡状态 <> 1", sqlcon);
                        if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
                        {
                            sqlcon.Open();                              //打开数据库连接
                        }
                        //使用ExecuteReader方法的返回值创建SqlDataReader对象
                        SqlDataReader sqldr = sqlcmd.ExecuteReader();
                        if (sqldr.HasRows)
                        {

                        }
                        else
                        {
                            Response.Write("<script>window.alert('当前库位中没有可调拨的电话卡！');location.href='Default.aspx';</script>");
                        }
                        sqldr.Close();//关闭SqlDataReader对象
                        sqlcon.Close();//关闭数据库连接
                    }
                    else
                    {
                        SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");//创建数据库连接对象                                                                                                                          //创建SqlCommand对象
                        SqlCommand sqlcmd = new SqlCommand("select * from aspnet_Cardtest where 卡状态 <> 1 and (当前库位 IN (select 员工OA from aspnet_Yuangongtest where 所在部门 IN (select 网点名称 from aspnet_Dituiwangdiantest where 客户经理OA = '" + Session["dangqiandenglu"] + "')) or 当前库位 = '" + Session["dangqiandenglu"] + "')", sqlcon);
                        if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
                        {
                            sqlcon.Open();                              //打开数据库连接
                        }
                        //使用ExecuteReader方法的返回值创建SqlDataReader对象
                        SqlDataReader sqldr = sqlcmd.ExecuteReader();
                        if (sqldr.HasRows)
                        {

                        }
                        else
                        {
                            Response.Write("<script>window.alert('当前库位中没有可调拨的电话卡！');location.href='Default.aspx';</script>");
                        }
                        sqldr.Close();//关闭SqlDataReader对象
                        sqlcon.Close();//关闭数据库连接
                    }
                }
                else if (int.Parse(Session["quanxian"].ToString()) == 1)
                {
                    SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");//创建数据库连接对象                                                                                                                          //创建SqlCommand对象
                    SqlCommand sqlcmd = new SqlCommand("select * from aspnet_Cardtest where 当前库位 = '" + Session["dangqiandenglu"] + "' and 卡状态 <> 1", sqlcon);
                    if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
                    {
                        sqlcon.Open();                              //打开数据库连接
                    }
                    //使用ExecuteReader方法的返回值创建SqlDataReader对象
                    SqlDataReader sqldr = sqlcmd.ExecuteReader();
                    if (sqldr.HasRows)
                    {

                    }
                    else
                    {
                        Response.Write("<script>window.alert('当前库位中没有可调拨的电话卡！');location.href='Default.aspx';</script>");
                    }
                    sqldr.Close();//关闭SqlDataReader对象
                    sqlcon.Close();//关闭数据库连接
                }
                //SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");//创建数据库连接对象                                                                                                                          //创建SqlCommand对象
                //SqlCommand sqlcmd = new SqlCommand("select * from aspnet_Cardtest where 当前库位 = '" + Session["dangqiandenglu"] + "' and 卡状态 <> 1", sqlcon);
                //if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
                //{
                //    sqlcon.Open();                              //打开数据库连接
                //}
                ////使用ExecuteReader方法的返回值创建SqlDataReader对象
                //SqlDataReader sqldr = sqlcmd.ExecuteReader();
                //if (sqldr.HasRows)
                //{

                //}
                //else
                //{
                //    Response.Write("<script>window.alert('当前库位中没有可调拨的电话卡！');location.href='Default.aspx';</script>");
                //}
                //sqldr.Close();//关闭SqlDataReader对象
                //sqlcon.Close();//关闭数据库连接
            }
        }

        public void BindData()
        {
            if (int.Parse(Session["quanxian"].ToString()) == 3)
            {
                //定义执行查询操作的SQL语句
                string sqlstr = "select * from aspnet_Yuangongtest";
                //创建数据库连接对象
                SqlConnection con = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");
                //创建数据适配器
                SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
                //创建数据集
                DataSet ds = new DataSet();
                //填充数据集
                da.Fill(ds);
                //设置GridView控件的数据源为创建的数据集ds
                GridView1.DataSource = ds;
                //将数据库表中的主键字段放入GridView控件的DataKeyNames属性中
                GridView1.DataKeyNames = new string[] { "员工OA" };
                //绑定数据库表中数据
                GridView1.DataBind();
            }
            else if (int.Parse(Session["quanxian"].ToString()) == 2)
            {
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
                    Button7.Visible = false;
                    Button8.Visible = false;
                    Session["manager_diaobo"] = "bumenjingli";
                    //定义执行查询操作的SQL语句
                    string sqlstr = "select * from aspnet_Yuangongtest where 所在部门 IN (select 网点名称 from aspnet_Dituiwangdiantest where 客户经理OA = '" + Session["dangqiandenglu"] + "')";
                    //创建数据库连接对象
                    SqlConnection con = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");
                    //创建数据适配器
                    SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
                    //创建数据集
                    DataSet ds = new DataSet();
                    //填充数据集
                    da.Fill(ds);
                    //设置GridView控件的数据源为创建的数据集ds
                    GridView1.DataSource = ds;
                    //将数据库表中的主键字段放入GridView控件的DataKeyNames属性中
                    GridView1.DataKeyNames = new string[] { "员工OA" };
                    //绑定数据库表中数据
                    GridView1.DataBind();
                }
                else//是地推网点经理
                {
                    Button7.Visible = false;
                    Button8.Visible = false;
                    Session["manager_diaobo"] = "dituijingli";
                    //定义执行查询操作的SQL语句
                    string sqlstr = "select * from aspnet_Dituiwangdiantest where 客户经理OA <> '" + Session["dangqiandenglu"] + "' and 客户经理OA <> 'boss' and 客户经理OA NOT LIKE 'bumenmanager%'";
                    //创建数据库连接对象
                    SqlConnection con = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");
                    //创建数据适配器
                    SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
                    //创建数据集
                    DataSet ds = new DataSet();
                    //填充数据集
                    da.Fill(ds);
                    //设置GridView控件的数据源为创建的数据集ds
                    GridView2.DataSource = ds;
                    //将数据库表中的主键字段放入GridView控件的DataKeyNames属性中
                    GridView2.DataKeyNames = new string[] { "客户经理OA" };
                    //绑定数据库表中数据
                    GridView2.DataBind();
                }
                sqldr.Dispose();
                sqldr.Close();//关闭SqlDataReader对象
                sqlcon.Close();//关闭数据库连接
            }
            else if (int.Parse(Session["quanxian"].ToString()) == 1)
            {
                Button7.Visible = false;
                Button8.Visible = false;
                //定义执行查询操作的SQL语句
                string sqlstr = "select * from aspnet_Yuangongtest where 所在部门 IN(select 所在部门 from aspnet_Yuangongtest where 员工OA = '" + Session["dangqiandenglu"] + "') and 员工OA <> '" + Session["dangqiandenglu"] + "'";
                //创建数据库连接对象
                SqlConnection con = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");
                //创建数据适配器
                SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
                //创建数据集
                DataSet ds = new DataSet();
                //填充数据集
                da.Fill(ds);
                //设置GridView控件的数据源为创建的数据集ds
                GridView1.DataSource = ds;
                //将数据库表中的主键字段放入GridView控件的DataKeyNames属性中
                GridView1.DataKeyNames = new string[] { "员工OA" };
                //绑定数据库表中数据
                GridView1.DataBind();
            }
            ////定义执行查询操作的SQL语句
            //string sqlstr = "select * from aspnet_Yuangongtest where 员工OA <> '" + Session["dangqiandenglu"] + "'";
            ////创建数据库连接对象
            //SqlConnection con = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");
            ////创建数据适配器
            //SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            ////创建数据集
            //DataSet ds = new DataSet();
            ////填充数据集
            //da.Fill(ds);
            ////设置GridView控件的数据源为创建的数据集ds
            //GridView1.DataSource = ds;
            ////将数据库表中的主键字段放入GridView控件的DataKeyNames属性中
            //GridView1.DataKeyNames = new string[] { "员工OA" };
            ////绑定数据库表中数据
            //GridView1.DataBind();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");//创建数据库连接对象                                                                                                                         //创建SqlCommand对象
            SqlCommand sqlcmd = new SqlCommand("select * from aspnet_Yuangongtest", sqlcon);
            if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
            {
                sqlcon.Open();                              //打开数据库连接
            }
            //使用ExecuteReader方法的返回值创建SqlDataReader对象
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            GridView1.DataSource = sqldr;
            GridView1.DataBind();
            GridView1.Visible = true;
            GridView2.Visible = false;
            sqldr.Close();//关闭SqlDataReader对象
            sqlcon.Close();//关闭数据库连接
                                 
            //SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");//创建数据库连接对象                                                                                                                         //创建SqlCommand对象
            //SqlCommand sqlcmd = new SqlCommand("select * from aspnet_Yuangongtest where 员工OA <> '" + Session["dangqiandenglu"] + "'", sqlcon);
            //if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
            //{
            //    sqlcon.Open();                              //打开数据库连接
            //}
            ////使用ExecuteReader方法的返回值创建SqlDataReader对象
            //SqlDataReader sqldr = sqlcmd.ExecuteReader();
            //GridView1.DataSource = sqldr;
            //GridView1.DataBind();
            //GridView1.Visible = true;
            //GridView2.Visible = false;
            //sqldr.Close();//关闭SqlDataReader对象
            //sqlcon.Close();//关闭数据库连接
        }

        protected void Button8_Click(object sender, EventArgs e)
        { 
            SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");//创建数据库连接对象                                                                                                                         //创建SqlCommand对象
            SqlCommand sqlcmd = new SqlCommand("select * from aspnet_Dituiwangdiantest where 客户经理OA <> '" + Session["dangqiandenglu"] + "'", sqlcon);
            if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
            {
                sqlcon.Open();                              //打开数据库连接
            }
            //使用ExecuteReader方法的返回值创建SqlDataReader对象
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            GridView2.DataSource = sqldr;
            GridView2.DataBind();
            GridView2.Visible = true;
            GridView1.Visible = false;
            sqldr.Close();//关闭SqlDataReader对象
            sqlcon.Close();//关闭数据库连接
                 
            //SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");//创建数据库连接对象                                                                                                                         //创建SqlCommand对象
            //SqlCommand sqlcmd = new SqlCommand("select * from aspnet_Dituiwangdiantest where 客户经理OA <> '" + Session["dangqiandenglu"] + "'", sqlcon);
            //if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
            //{
            //    sqlcon.Open();                              //打开数据库连接
            //}
            ////使用ExecuteReader方法的返回值创建SqlDataReader对象
            //SqlDataReader sqldr = sqlcmd.ExecuteReader();
            //GridView2.DataSource = sqldr;
            //GridView2.DataBind();
            //GridView2.Visible = true;
            //GridView1.Visible = false;
            //sqldr.Close();//关闭SqlDataReader对象
            //sqlcon.Close();//关闭数据库连接
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            if (int.Parse(Session["quanxian"].ToString()) == 3)
            {
                int check = 0;
                for (int i = 0; i <= GridView1.Rows.Count - 1; i++)
                {
                    CheckBox cbox = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");
                    if (cbox.Checked == true)
                    {
                        Session["kuwei_diaobo"] = GridView1.Rows[i].Cells[0].Text;
                        check++;
                    }
                }
                for (int j = 0; j <= GridView2.Rows.Count - 1; j++)
                {
                    CheckBox cbox2 = (CheckBox)GridView2.Rows[j].FindControl("CheckBox2");
                    if (cbox2.Checked == true)
                    {
                        Session["kuwei_diaobo"] = GridView2.Rows[j].Cells[0].Text;
                        check++;
                    }
                }
                if (check == 1)
                {
                    Response.Redirect("Diaobo2.aspx");
                }
                else if (check == 0)
                {
                    Response.Write("<script>window.alert('请至少选择一名员工！');location.href='Diaobo.aspx';</script>");
                }
                else
                {
                    Response.Write("<script>window.alert('只能选择一名员工，请重新选择！');location.href='Diaobo.aspx';</script>");
                }
            }
            else if (int.Parse(Session["quanxian"].ToString()) == 2)
            {
                if (Convert.ToString(Session["manager_diaobo"]) == "dituijingli")
                {
                    int check = 0;
                    for (int j = 0; j <= GridView2.Rows.Count - 1; j++)
                    {
                        CheckBox cbox2 = (CheckBox)GridView2.Rows[j].FindControl("CheckBox2");
                        if (cbox2.Checked == true)
                        {
                            Session["kuwei_diaobo"] = GridView2.Rows[j].Cells[0].Text;
                            check++;
                        }
                    }
                    if (check == 1)
                    {
                        Response.Redirect("Diaobo2.aspx");
                    }
                    else if (check == 0)
                    {
                        Response.Write("<script>window.alert('请至少选择一名员工！');location.href='Diaobo.aspx';</script>");
                    }
                    else
                    {
                        Response.Write("<script>window.alert('只能选择一名员工，请重新选择！');location.href='Diaobo.aspx';</script>");
                    }
                }
                else
                {
                    int check = 0;
                    for (int i = 0; i <= GridView1.Rows.Count - 1; i++)
                    {
                        CheckBox cbox = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");
                        if (cbox.Checked == true)
                        {
                            Session["kuwei_diaobo"] = GridView1.Rows[i].Cells[0].Text;
                            check++;
                        }
                    }
                    if (check == 1)
                    {
                        Response.Redirect("Diaobo2.aspx");
                    }
                    else if (check == 0)
                    {
                        Response.Write("<script>window.alert('请至少选择一名员工！');location.href='Diaobo.aspx';</script>");
                    }
                    else
                    {
                        Response.Write("<script>window.alert('只能选择一名员工，请重新选择！');location.href='Diaobo.aspx';</script>");
                    }
                }
            }
            else if (int.Parse(Session["quanxian"].ToString()) == 1)
            {
                int check = 0;
                for (int i = 0; i <= GridView1.Rows.Count - 1; i++)
                {
                    CheckBox cbox = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");
                    if (cbox.Checked == true)
                    {
                        Session["kuwei_diaobo"] = GridView1.Rows[i].Cells[0].Text;
                        check++;
                    }
                }               
                if (check == 1)
                {
                    Response.Redirect("Diaobo2.aspx");
                }
                else if (check == 0)
                {
                    Response.Write("<script>window.alert('请至少选择一名员工！');location.href='Diaobo.aspx';</script>");
                }
                else
                {
                    Response.Write("<script>window.alert('只能选择一名员工，请重新选择！');location.href='Diaobo.aspx';</script>");
                }
            }          
        }
    }
}