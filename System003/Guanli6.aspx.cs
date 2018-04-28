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
    public partial class Guanli6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToString(Session["quanxian"]) == "")
            {
                Response.Write("<script>window.alert('违规操作！');location.href='Default.aspx';</script>");
            }

            if (!IsPostBack)
            {
                //调用自定义方法绑定数据到控件
                BindData();
            }
        }


        public void BindData()
        {
            //定义数据库连接字符串
            SqlConnection con = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=123456;");
            //定义执行查询操作的SQL语句
            string sqlstr = "select * from aspnet_Xiaoshoutest";
            //创建数据适配器
            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            //创建数据集
            DataSet ds = new DataSet();
            //填充数据集
            da.Fill(ds);
            //设置GridView控件的数据源为创建的数据集ds
            GridView1.DataSource = ds;
            //将数据库表中的主键字段放入GridView控件的DataKeyNames属性中
            GridView1.DataKeyNames = new string[] { "XSID" };
            //绑定数据库表中数据
            GridView1.DataBind();
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string delete_sql = "delete from aspnet_Xiaoshoutest where XSID='" + GridView1.DataKeys[e.RowIndex].Value.ToString() + "'";
            bool delete = ExceSQL(delete_sql);//调用ExceSQL执行删除操作
            if (delete)
            {
                Response.Write("<script language=javascript>alert('删除成功！')</script>");
                BindData();//调用自定义方法重新绑定控件中数据
            }
            else
            {
                Response.Write("<script language=javascript>alert('删除失败！')</script>");
            }
        }
        /// <summary>
        /// 此方法用来执行SQL语句
        /// </summary>
        /// <param name="SqlCom">要执行的SQL语句</param>
        /// <returns></returns>
        public bool ExceSQL(string strSqlCom)
        {
            //定义数据库连接字符串
            SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=123456;");
            SqlCommand sqlcom = new SqlCommand(strSqlCom, sqlcon);
            try
            {
                //判断数据库是否为连连状态
                if (sqlcon.State == System.Data.ConnectionState.Closed)
                { sqlcon.Open(); }
                //执行SQL语句
                sqlcom.ExecuteNonQuery();
                //SQL语句执行成功，返回true值
                return true;
            }
            catch
            {
                //SQL语句执行失败，返回false值
                return false;
            }
            finally
            {
                //关闭数据库连接
                sqlcon.Close();
            }
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //取得编辑行的关键字段的值
            string xsid = GridView1.DataKeys[e.RowIndex].Value.ToString();
            //取得文本框中输入的内容
            string iccid = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[1].Controls[0])).Text.ToString().Trim();
            string taocanleixing = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[2].Controls[0])).Text.ToString().Trim();
            string xiaoshouzhe = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[3].Controls[0])).Text.ToString().Trim();
            string xiaoshoushijian = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[4].Controls[0])).Text.ToString().Trim();
            //定义更新操作的SQL语句
            string update_sql = "update aspnet_Xiaoshoutest set ICCID='" + iccid + "',套餐类型='" + taocanleixing + "',销售者='" + xiaoshouzhe + "',销售时间='" + xiaoshoushijian + "' where XSID='" + xsid + "'";
            bool update = ExceSQL(update_sql);//调用ExceSQL执行更新操作
            if (update)
            {
                Response.Write("<script language=javascript>alert('修改成功！')</script>");
                //设置GridView控件的编辑项的索引为－1，即取消编辑
                GridView1.EditIndex = -1;
                BindData();
            }
            else
            {
                Response.Write("<script language=javascript>alert('修改失败！');</script>");
            }
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            //设置GridView控件的编辑项的索引为－1，即取消编辑
            GridView1.EditIndex = -1;
            BindData();//数据绑定
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            BindData();//数据绑定
        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            BindData();//数据绑定
        }
    }
}