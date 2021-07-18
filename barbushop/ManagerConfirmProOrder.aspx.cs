using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace barbushop
{
    public partial class ManagerConfirmProOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void confirmlOrder(object sender, CommandEventArgs e)
        {
            string p = e.CommandArgument.ToString();
            int orderID = int.Parse(p);
          

        }
    }
}