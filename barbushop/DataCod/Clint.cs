using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using barbushop.DataDB;
  
    
    namespace barbushop
{
    namespace DataCod {

        public partial class Clint
        {
            public int UserID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }
            public int City { get; set; }
            public string Gender { get; set; }
            public string Password { get; set; }

            public Clint()
            { }
            public Clint(int userID, string firstname, string lastname, string phonenumber, string email, int city, string gender,string password)
            {
                this.UserID = userID;
                this.FirstName = firstname;
                this.LastName = lastname;
                this.PhoneNumber = phonenumber;
                this.Email = email;
                this.City = city;
                this.Gender = gender;
                this.Password = password;

            }
            public List<Clint> GETMuser(int UserID)
            {
                return ClintData.GETMuser(UserID);

            }

            public int insertUser_data()
            { 
                return ClintData.insertUser_data(this);
            }

            //public List<Clint> Getuseer(string email, string password)
            //{
               

            //        return ClintData.Getuseer(email, password);

            //}
            public int Getuseer(string email, string password)
            {


                return ClintData.Getuseer(email, password);

            }
            public int GetMuseerId(int BarbrshopId)
            {


                return ClintData.GetMuseerId(BarbrshopId);

            }
            public  void updateUser(int userID)
            {
                ClintData.updateUser(userID, this);
            }

            //public int chackingEUser(int userid)
            //{

            //    return ClintData.chackingEUser(userid);

            //}
            public int chackingMUser(int userid)
            {

                return ClintData.chackingMUser(userid);

            }
            public  List<Clint> GETuserInfo(int UserID)
            {
                return ClintData.GETuserInfo(UserID);
            }
            
        }

    }
}
    

