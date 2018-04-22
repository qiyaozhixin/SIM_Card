using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace System003
{
    public partial class Wode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToString(Session["quanxian"]) == "")
            {
                Response.Write("<script>window.alert('违规操作！');location.href='Default.aspx';</script>");
            }
            Button13.Visible = false;
            Button14.Visible = false;
            Label4.Visible = false;
            Label5.Visible = false;
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Button13.Visible = true;
            Button14.Visible = true;
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Label4.Visible = true;
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            Label5.Visible = true;
        }
    }
}