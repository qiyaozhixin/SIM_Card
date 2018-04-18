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
    public partial class Diaobo2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //调用自定义方法绑定数据到控件
                BindData();
            }
        }

        public void BindData()
        {
            if (int.Parse(Session["quanxian"].ToString()) == 3)
            {
                //定义执行查询操作的SQL语句
                string sqlstr = "select * from aspnet_Cardtest where 当前库位 <> '" + Session["kuwei_diaobo"] + "' and 卡状态 <> 1;";
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
                GridView1.DataKeyNames = new string[] { "ICCID" };
                //绑定数据库表中数据
                GridView1.DataBind();
            }
            else if (int.Parse(Session["quanxian"].ToString()) == 2)
            {
                if (Convert.ToString(Session["manager_diaobo"]) == "dituijingli")
                {
                    //定义执行查询操作的SQL语句
                    string sqlstr = "select * from aspnet_Cardtest where 当前库位 = '" + Session["dangqiandenglu"] + "' and 卡状态 <> 1;";
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
                    GridView1.DataKeyNames = new string[] { "ICCID" };
                    //绑定数据库表中数据
                    GridView1.DataBind();
                }
                else
                {
                    //定义执行查询操作的SQL语句
                    string sqlstr = "select * from aspnet_Cardtest where 卡状态 <> 1 and (当前库位 IN (select 员工OA from aspnet_Yuangongtest where 所在部门 IN (select 网点名称 from aspnet_Dituiwangdiantest where 客户经理OA = '" + Session["dangqiandenglu"] + "')) or 当前库位 = '" + Session["dangqiandenglu"] + "') and 当前库位 <> '" + Session["kuwei_diaobo"] + "'";
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
                    GridView1.DataKeyNames = new string[] { "ICCID" };
                    //绑定数据库表中数据
                    GridView1.DataBind();
                }
            }
            else if (int.Parse(Session["quanxian"].ToString()) == 1)
            {
                //定义执行查询操作的SQL语句
                string sqlstr = "select * from aspnet_Cardtest where 当前库位 = '" + Session["dangqiandenglu"] + "' and 卡状态 <> 1;";
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
                GridView1.DataKeyNames = new string[] { "ICCID" };
                //绑定数据库表中数据
                GridView1.DataBind();
            }
            ////定义执行查询操作的SQL语句
            //string sqlstr = "select * from aspnet_Cardtest where 当前库位 = '" + Session["dangqiandenglu"] + "' and 卡状态 <> 1;";
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
            //GridView1.DataKeyNames = new string[] { "ICCID" };
            ////绑定数据库表中数据
            //GridView1.DataBind();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon2 = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");//创建数据库连接对象                                                                                                                     //创建SqlCommand对象
            SqlCommand sqlcmd2 = new SqlCommand("delete from aspnet_Linshika", sqlcon2);
            if (sqlcon2.State == ConnectionState.Closed)     //判断连接是否关闭
            {
                sqlcon2.Open();                              //打开数据库连接
            }
            //使用ExecuteReader方法的返回值创建SqlDataReader对象
            SqlDataReader sqldr2 = sqlcmd2.ExecuteReader();
            sqldr2.Close();//关闭SqlDataReader对象
            sqlcon2.Close();//关闭数据库连接

            int check = 0;
            for (int i = 0; i <= GridView1.Rows.Count - 1; i++)
            {
                CheckBox cbox = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");
                if (cbox.Checked == true)
                {
                    string str = GridView1.Rows[i].Cells[0].Text;//获取想要的行
                    SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");//创建数据库连接对象
                    if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
                    {
                        sqlcon.Open();                              //打开数据库连接
                    }
                    SqlCommand sqlcmd = new SqlCommand("insert into aspnet_Linshika values('" + GridView1.Rows[i].Cells[0].Text + "')", sqlcon);
                    SqlDataReader sqldr = sqlcmd.ExecuteReader();
                    sqldr.Close();//关闭SqlDataReader对象
                    sqlcon.Close();//关闭数据库连接
                    check++;
                }
            }
            if (check == 0)
            {
                Response.Write("<script>window.alert('请至少选择一张卡！');location.href='Diaobo2.aspx';</script>");
            }
            else
            {
                Response.Redirect("Diaobo3.aspx");
            }
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= GridView1.Rows.Count - 1; i++)
            {
                CheckBox cbox = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");              
                cbox.Checked = true;
            }
        }
    }
}