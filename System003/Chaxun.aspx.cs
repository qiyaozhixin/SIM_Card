using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace System003
{
    public partial class Chaxun1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Session["iccid"] = TextBox1.Text;
            Response.Redirect("Chaxun2.aspx");
        }
    }
}