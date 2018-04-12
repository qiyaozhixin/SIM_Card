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
    public partial class Kaika : System.Web.UI.Page
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
            //定义执行查询操作的SQL语句
            string sqlstr = "select * from aspnet_Cardtest where 当前库位 = '" + Session["dangqiandenglu"] + "'";
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

        protected void Button10_Click(object sender, EventArgs e)
        {
            int check = 0;
            for (int i = 0; i <= GridView1.Rows.Count - 1; i++)
            {
                CheckBox cbox = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");
                if (cbox.Checked == true)
                {
                    Session["iccid_kaika"] = GridView1.Rows[i].Cells[0].Text;//获取想要的行
                    Session["PUKma_kaika"] = GridView1.Rows[i].Cells[1].Text;//获取想要的行
                    check++;
                }
            }
            Session["IDnumber_kaika"] = TextBox2.Text;
            Session["taocanleixing_kaika"] = DropDownList1.Text;
            if (check == 1)
            {
                Response.Redirect("Kaika2.aspx");
            }
            else
            {
                Response.Write("<script>window.alert('只能选择一张卡，请重新选择！');location.href='Kaika.aspx';</script>");
            }
        }
    }
}