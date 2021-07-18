using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using barbushop;
using barbushop.DataCod;


namespace barbushop

{
    public partial class login1 : System.Web.UI.Page

    {


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { filldatacity(); }
            

        }
   
        protected void filldatacity()
        {
            String cs = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("select cityID,Name from Citys", con);
                con.Open();

                DropDownListCity.DataSource = cmd.ExecuteReader();
                DropDownListCity.DataTextField = "Name";
                DropDownListCity.DataValueField = "cityID";
                DropDownListCity.DataBind();
                ListItem li = new ListItem("בחר עיר", "-1");
                DropDownListCity.Items.Insert(0, li);


            }
        }

        protected void btnUserS_Click(object sender, EventArgs e)

        {


            if (genderMale.Checked)
            {
                Session["Gander"] = genderMale.Value;
            }
            else
            {
                Session["Gander"] = genderFemale.Value;
            }

            //filldata();
            Clint Temp= new Clint()
            {    FirstName = TextFname.Text,
                 LastName=TextLname.Text,
                 PhoneNumber = Textphon.Text,
                 Password = TextPassword.Text,
                  Email=TextEmail.Text,
                  City = int.Parse(DropDownListCity.SelectedItem.Value),
                  Gender =Session["Gander"].ToString()
             
              
            };
            Temp.insertUser_data();
            Session["userid"] = Temp;
            Response.Redirect("userMain.aspx");
            

        }

    }
}

