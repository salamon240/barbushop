     select * 
     from Productss p join ProductsOrders po on p.ProductsID=po.ProductsID 
     join Orderss o on o.OrderID=po.OrderID 
     join Users u on o.UserID=u.UserID join Barbushops b on b.BarbushopID=o.BarbushopID
     join Citys c on c.cityID=u.Address 
     where o.UserID = 15
