using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace barbushop
{
    public class Item
    {
       

        public int productId { get; set; }
        public string prodName { get; set; }
        public string prodNote { get; set; }
        public double price { get; set; }
        public string picName { get; set; }
        public int capacity { get; set; }
        public int Amuont { get; set; }


        //public Items(int productId, string ProdName, string ProdNote, int Price, string PicName, int Capacity, int amuont)
        //{
        //    this.productId = productId;
        //    this.prodName = ProdName;
        //    this.prodNote = ProdNote;
        //    this.price = Price;
        //    this.picName = PicName;
        //    this.capacity = Capacity;
        //    this.Amuont = amuont;
        //}

        public Item(int ProductId, string ProdName, double pric, string PicName, int cpts, int amunt)
        {
            this.productId = ProductId;
            this.prodName = ProdName;
            this.price = pric;
            this.picName = PicName;
            this.capacity = cpts;
            this.Amuont = amunt;
        }

       
    }
}