select u.FName,u.LName,u.phonNumber,u.Email,m.HairCut,m.MeetingDate,t.Time
from Meetings m join Users u on m.UserID=u.UserID join Times t on m.MeetingTime=t.MeetingTime
where m.MUserID=76 and m.Status=1