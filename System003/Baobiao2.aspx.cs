using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace System003
{
    public partial class Baobiao2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Session["baobiaoyuangongoa"] = TextBox1.Text;
            if (TextBox1.Text == "")
            {
                Response.Write("<script>window.alert('请输入员工OA！');location.href='Baobiao2.aspx';</script>");
            }
            else if (DropDownList1.Text == "销售报表")
            {
                Response.Redirect("Baobiaoxiaoshou.aspx");
            }
            else
            {
                Response.Redirect("Baobiaoyuliang.aspx");
            }
        }
    }
}