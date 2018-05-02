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
    public partial class Chaxun1_3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToString(Session["quanxian"]) == "")
            {
                Response.Write("<script>window.alert('违规操作！');location.href='Default.aspx';</script>");
            }
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            Session["iccid_xiaoshouchaxun"] = TextBox1.Text;
            Session["taocanleixing_xiaoshouchaxun"] = TextBox2.Text;
            Session["xiaoshouzhe_xiaoshouchaxun"] = TextBox3.Text;
            Response.Redirect("Chaxun3.aspx");
        }
    }
}