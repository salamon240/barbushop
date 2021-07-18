using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace barbushop
{
    public class TaxC
    {   
        public int newPric { get; set; }
        static double Tax = 0.17;

        public double taxTot(int price)
        {
           
            
                double totPric = 0;
                double Taxs = 0.17;


            totPric = Taxs * price;
            totPric += price;   

                return totPric;

        }
        public double GetTax()
        {
            return Tax;
        }
    }
}