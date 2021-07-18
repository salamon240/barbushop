select p.Name,p.PriceType,p.BarbushopID,o.UserID,po.Amunt,o.BarbushopID
from Productss p join ProductsOrders po on p.ProductsID=po.ProductsID 
join Orderss o on po.OrderID=o.OrderID 

where o.UserID=9