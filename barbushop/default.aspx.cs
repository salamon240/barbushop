using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using barbushop.DataCod;

namespace barbushop
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { if (!IsPostBack)
            {
                if (Session["Euserid"] != null)
                {
                    Session["Euserid"] = null;

                }

                if (Session["Muserid"] != null)
                {
                    Session["Muserid"] = null;

                }
            }
        }

        protected void UserLogin(object sender, EventArgs e)
        {
            
            int userid = 0;
            Clint user = new Clint();
            Barabshops barid = new Barabshops();
             userid = user.Getuseer(TexUserLOgEmail.Text, TexUserLogPass.Text);
         
            if (userid !=0)
            {  
                
                Session["userid"] = userid;

                Response.Redirect("userMain.aspx");
            }
            else
            {
                TexUserLOgEmail.Text = "מייל לא נכון";
                TexUserLogPass.Text = "סיסמא לא נכונה ";
            }


        }
        protected void MUserLogin(object sender, EventArgs e)
        {
            int barid = 0;
            int isExist = 0;
            int userid = 0;
            Clint user = new Clint();
            Barabshops bar = new Barabshops();
            userid = user.Getuseer(TexEmailM.Text, TexPasslogM.Text);
            barid = bar.GetbarID(userid);
            Session["BarabshopID"] = barid;
            if (userid != 0)
            {
                if(barid!=0)
                {
                    isExist = user.chackingMUser(userid);
                    if (isExist == 1)
                    {
                        Session["Euserid"] = userid;
                        Response.Redirect("managerMain.aspx");
                    }
                    else
                    {

                        if (isExist == 2)
                        {
                            Session["Muserid"] = userid;
                            Response.Redirect("managerMain.aspx");
                        }
                        else
                        {
                            TexUserLOgEmail.Text = " משתמש לא קיים ";
                            TexUserLogPass.Text = "סיסמא לא נכונה ";

                        }
                    }
                }
                else 
                {
                    if (userid != 0)
                    {

                        Session["userid"] = userid;

                        Response.Redirect("userMain.aspx");
                    }
                    else
                    {
                        TexUserLOgEmail.Text = "מייל לא נכון";
                        TexUserLogPass.Text = "סיסמא לא נכונה ";
                    }

                }
                
            }
            else
            {
                TexUserLOgEmail.Text = "מייל לא נכון";
                TexUserLogPass.Text = "סיסמא לא נכונה ";
            }
          

        }

    }
}