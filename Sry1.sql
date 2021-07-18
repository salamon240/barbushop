select *
from Users u join Rolle r on u.UserID=r.UserID join Citys c on c.cityID=u.Address
where BarbushopID=46