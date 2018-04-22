using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace System003
{
    public partial class Baobiao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToString(Session["quanxian"]) == "")
            {
                Response.Write("<script>window.alert('违规操作！');location.href='Default.aspx';</script>");
            }
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Session["yuangongoa_baobiao"] = Session["dangqiandenglu"];
            if (DropDownList1.Text == "销售报表")
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