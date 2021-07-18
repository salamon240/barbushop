using barbushop.DataDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace barbushop
{
    namespace DataCod
    {
        public class product:Barabshops
        {
            public int productId { get; set; }
            public string ProdName { get; set; }
            public string ProdNote { get; set; }
            public double ProdPriceType { get; set; }
            public string ProdPicname { get; set; }
            public int ProdCapacity { get; set; }


            public product()
            { }

            public product(string Prodname, string Prodnote, int Price, string PicName, int Capacit)
            {
                this.ProdName = Prodname;
                this.ProdNote = Prodnote;
                this.ProdPriceType = Price;
                this.ProdPicname = PicName;
                this.ProdCapacity = Capacit;
            }

            public int MangerADDpic()
            { 
                int retval = ProductData.MangerADDpic(this);
                productId = retval;
                return retval;
            }

            public  int updateProductCpactiy(int productid, int barbshopid, int prodCap)
            {
               return ProductData.updateProductCpactiy(productid, barbshopid, prodCap);
            }

            public  List<product> GetPicName(int barabshopID)
            {
                return ProductData.GetPicName(barabshopID);
            }

            public  int updateProductNote(int productid, int barbshopid,string prodNote)
            {
               return ProductData.updateProductNote(productid, barbshopid, prodNote);
            }

            public  int updateProductPrice(int productid, int barbshopid, double prodPrice)
            {
               return ProductData.updateProductPrice(productid, barbshopid, prodPrice);
            }

            public int DeleteProduct(int productid, int barbshopid)
            {
              return  ProductData.DeleteProduct(productid, barbshopid);
            }

            public List<product> GetPicByID(int productId)
            {
               return ProductData.GetPicByID(productId);
            }

            public  List<product> GetPicNameByCat(int barabshopID, int Catid)
            {
                return ProductData.GetPicNameByCat(barabshopID, Catid);
            }
        }

    }


}