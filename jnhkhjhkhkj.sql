select ms.StatusName, m.BarberName,u.PhoneNumber, b.phonNumber,b.Address,b.BarbName,m.MeetingID,MeetingDate,m.HairCut,t.Time,DATEDIFF(day,GETDATE(),m.MeetingDate)as dateNow ,convert(varchar(10), m.MeetingDate, 103)as date
from Users u join Meetings m on u.UserID=m.UserID 
join Barbushops b on m.BarbushopID=b.BarbushopID 
join Times t on t.MeetingTime=m.MeetingTime  
join Rolle r on b.UserID=r.UserID 
join MeetingsStatus ms on m.Status=ms.MstatusID
where u.UserID = 15
and m.Status=1
                and m.Status!=4
          order by m.MeetingDate

