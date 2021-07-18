select * from Users where UserID=(select r.UserID from Users u join Barbushops b on u.UserID=b.UserID join Rolle r on b.UserID=r.MuserID 
where u.UserID=99)