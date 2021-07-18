using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace barbushop
{
    public class carts
    {
        public List<Item> Item { get; set; }

        public carts()
        {
            Item = new List<Item>();
        }


        public void AddItem(Item tmp)
        {
            int flag = 1;
            foreach (Item t in Item)
            {
                if (t.productId == tmp.productId)
                {
                    t.Amuont += tmp.Amuont;
                    flag = 0;
                }
            }
            if (flag == 1)
            {
                Item.Add(tmp);
            }

        }



        public void RemoveItem(int productId)
        {
            foreach (Item t in Item)
            {
                if (t.productId == productId)
                {
                    Item.Remove(t);
                    break;
                }
            }
        }
        public void itemEmty()
        {
            Item.Clear();
        }
        public double culclaet()
        {
            double tot = 0;
            foreach (Item t in Item)
            {
                tot += t.Amuont * t.price;
            }
            return tot;
        }

    }
}