using System;
using System.Collections.Generic;
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
            Response.Write("<script>alert('提示：激活前需准备好本人的身份证和SIM卡！')</script>");
        }
    }
}