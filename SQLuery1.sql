 select m.MUserID,u.UserID,u.FName,u.LName,u.Email,u.phonNumber,m.HairCut,t.Time,m.MeetingDate,DATEDIFF(day,m.MeetingDate,GETDATE())as dateNow from Users u join Meetings m on u.UserID = m.UserID join Times t on m.MeetingTime = t.MeetingTime 
 where m.BarbushopID = 29  
                order by t.Time