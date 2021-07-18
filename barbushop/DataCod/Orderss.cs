using barbushop.DataDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace barbushop
{
    namespace DataCod
    {
        public class Orderss : product
        {
            public int OrderID { get; set; }
            public string OrderDate { get; set; }
            public string DeliveryDate { get; set; }
            public int UserID { get; set; }
            public int BarbushopID { get; set; }
            public int Status { get; set; }
            public int amunt { get; set; }
            public string orderStatus { get; set; }
            public int StatusID { get; set; }
            public Orderss()
            { }

            public Orderss(int orderID, string orderDate, string deliveryDate, int userID, int barbushopID, int status, int Amunt, string OrderStatus)
            {
                this.OrderID = 1;
                this.OrderDate = orderDate;
                this.DeliveryDate = deliveryDate;
                this.UserID = userID;
                this.BarbushopID = barbushopID;
                this.Status = status;
                this.orderStatus = OrderStatus;
                this.amunt = Amunt;
            }
            public int insertNewOrders(int userId, int barbaShopId, int Status)
            {
                return OrderssData.insertNewOrders(userId, barbaShopId, Status);
            }

            public  List<Orderss> GETOrderprodcts(int barbarshopID)
            {
                return OrderssData.GETOrderprodcts(barbarshopID);
            }

            public List<Orderss> chackOrders(int UserId)
            {
                return OrderssData.chackOrders(UserId);

            }

            public  List<Orderss> GETOrderprodctsConfirm(int barbarshopID)
            {
                return OrderssData.GETOrderprodctsConfirm(barbarshopID);
            }

            public List<Orderss> GETOrderprodctsUser(int Userid)
            {
                return OrderssData.GETOrderprodctsUser(Userid);
            }

            public List<Orderss> GetUserOrders(int UserId)
            {
                return OrderssData.GetUserOrders(UserId);

            }
            
            public List<Orderss> GetManagerOrders(int UserId)
            {
                return OrderssData.GetManagerOrders(UserId);

            }
            
            public void updateOrdersFinsh(int orderID)
            {
                OrderssData.updateOrdersFinsh(orderID);
            }

            public int updateOrdersData(int orderID, int status)
            {
               return OrderssData.updateOrdersData(orderID,status);
            }
            
            public void finshOrder(int orderid, int productid, int amunt)
            {
                OrderssData.finshOrder(orderid, productid, amunt);
            }
            
            public  int OrderCencel(int orderId)
            {
              return  OrderssData.OrderCencel(orderId);
            }
            
            public void updateOrdersFinshConfirmData(int orderID)
            {
                OrderssData.updateOrdersFinshConfirmData(orderID);
            }
            //public  List<Orderss> GETOrderprodctsConfirm(int barbarshopID)
            //{
            //    return OrderssData.GETOrderprodctsConfirm(barbarshopID);
            //}
            public  List<Orderss> GETOrderprodctsTest(int barbarshopID)
            {
                return OrderssData.GETOrderprodctsTest(barbarshopID);
            }
            public List<Orderss> GetProductId(int OrderID)
            {
                return OrderssData.GetProductId(OrderID);
            }

            public  List<Orderss> GETOrderprodctsPaid(int barbarshopID)
            {
                return OrderssData.GETOrderprodctsPaid(barbarshopID);
            }

            public List<Orderss> GETOrderprodctsCanceled(int barbarshopID)
            {
                return OrderssData.GETOrderprodctsCanceled(barbarshopID);
            }
            public  List<Orderss> GETOrderprodctsByOrder(int OrderID)
            {
                return OrderssData.GETOrderprodctsByOrder(OrderID);
            }
            public  List<Orderss> GETuserInfoByOrderid(int Orederid)
            {
                return OrderssData.GETuserInfoByOrderid(Orederid);
            }
            public  List<Orderss> GETOrderprodctsbyEMai(int barbarshopID, string Email)
            {
                return OrderssData.GETOrderprodctsbyEMai(barbarshopID, Email);
            }
        }

    }
}