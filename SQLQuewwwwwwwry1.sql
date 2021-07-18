select* from Meetings m join Users u on m.UserID=u.UserID join Times t on m.MeetingTime=t.MeetingTime where m.BarbushopID =1048
order by m.MeetingDate