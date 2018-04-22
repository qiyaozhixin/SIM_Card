using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace System003
{
    public partial class Kaika3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToString(Session["quanxian"]) == "")
            {
                Response.Write("<script>window.alert('违规操作！');location.href='Default.aspx';</script>");
            }
            Label6.Text += Session["iccid_kaika"];
            Label8.Text += Session["PUKma_kaika"];
            Label10.Text += Session["IDnumber_kaika"];
            Label12.Text += Session["taocanleixing_kaika"];
            Label14.Text += Session["xiaoshoushijian_kaika"];
            Session.Remove("iccid_kaika");
            Session.Remove("PUKma_kaika");
            Session.Remove("IDnumber_kaika");
            Session.Remove("taocanleixing_kaika");
            Session.Remove("xiaoshoushijian_kaika");
        }
    }
}