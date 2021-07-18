using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using barbushop.DataDB;

namespace barbushop
{
    namespace DataCod
    {
        public class Barabshops:Clint
        {

            public int BarbushopID { get; set; }

            public string BarbName { get; set; }
            public string Address { get; set; }
            public string pHonNumber { get; set; }
            public int MUserID { get; set; }
            public int BCity { get; set; }
            public List<product> Products { get; set; }
            public Barabshops()
            { }
            public Barabshops(int userID)
            {
                this.MUserID = userID;
              
            }
            public Barabshops(int userID, string firstname, string lastname, string phonenumber, string email, int city, string gender, string password, int barbushopID, string barbName, string phonNumber, int cityID) : base(userID, firstname, lastname, phonenumber, email, city, gender, password)
            {
                this.BarbushopID = barbushopID;
                this.BarbName = barbName;
                this.pHonNumber = phonNumber;
                this.City = cityID;
            }

            public int insertBarbar_data()
            {
                
                return BarabshopsData.insertBarbar_data(this);
            }
            public  int GetMbarID(int MuserID)
            {
                return BarabshopsData.GetMbarID(MuserID);
            }

            public int GetbarID(int MuserID)
            {
                return BarabshopsData.GetbarID(MuserID);

            }

            public int insertrOLL(int MuserID, int Euser, int BarID,int status)
            {
                return BarabshopsData.insertrOLL(MuserID, Euser, BarID,status);

            }
            public  string GetMname(int barID)
            {
                return BarabshopsData.GetMname(barID);
            }
            public  int updateROll(int Muser, int barbshopid, string PICname)
            {
                return BarabshopsData.updateROll(Muser, barbshopid, PICname);

            }

            public  List<Barabshops> GetPicName(int muser)
            {
                return BarabshopsData.GetPicName(muser);

            }
            public List<Barabshops> allProfil(int baid)
            {
                return BarabshopsData.allProfil(baid);

            }
        }

    }
    
}