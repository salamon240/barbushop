using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace barbushop
{
    public partial class user : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void btnPerson_Click(object sender, EventArgs e)
        {
            Session["userid"] = null;
            Response.Redirect("default.aspx");
        }
    }
}