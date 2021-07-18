using barbushop.DataCod;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace barbushop
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        bool prodIn = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                filldatacity();

            }

        }

        protected void filldatacity()
        {
            String cs = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ConnectionString;
            using(SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("select cityID,Name from Citys" , con);
                con.Open();
               
                DropDownList1.DataSource = cmd.ExecuteReader();
                DropDownList1.DataTextField = "Name";
                DropDownList1.DataValueField = "cityID";
                DropDownList1.DataBind();
                ListItem li = new ListItem("בחר עיר", "-1");
                DropDownList1.Items.Insert(0, li);

                
            }
        }



      
    

        //protected void Chackprod()
        //{

        //    var picname = Session["fileName"].ToString();
        //    product prod = new product();
        //    //prodIn = prod.Chackprod(picname);
        //    DataTable data = new MyDB().Where("ProdPicname", picname).Get("Productss", "ProdName");
        //    if (data.Rows.Count > 0)
        //    {

        //        prodIn = true;
        //    }


        //}




        protected void MangerSignUp_Click(object sender, EventArgs e)

        {
            int BarID = 0;

            Clint emp = new Clint()
            {
                FirstName = TextFname.Text,
                LastName = TextLname.Text,
                PhoneNumber = Textphon.Text,
                Password = TextBox1.Text,
                Email = TextEmail.Text,
                City = int.Parse(DropDownList1.SelectedItem.Value),
                //Gender = Session["Gander"].ToString()


            };
            emp.insertUser_data();
           
            if (emp !=null)
            {
              int user= emp.Getuseer(emp.Email, emp.Password);
                Session["Muserid"] = user;
            }
            Barabshops bar = new Barabshops()
            {
                BarbName = TexbarberName.Text,
                pHonNumber = TexBarberPhon.Text,
                Address = TexbarberAdrres.Text,
                MUserID = (int)Session["Muserid"],
                BCity = emp.City



            };
            bar.insertBarbar_data();
            BarID = bar.GetMbarID((int)Session["Muserid"]);
            bar.insertrOLL(2, (int)Session["Muserid"], BarID,1);
            //Session["barbashop"] = bar;
            Session["BarabshopID"] = bar;
            Response.Redirect("AddEmployees.aspx");
          

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        { 
           
                
                Session["idcity"] = DropDownList1.SelectedValue;

            
        }

    }
}