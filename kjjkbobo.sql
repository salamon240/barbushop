  select*,convert(varchar(10), m.MeetingDate, 103)as date 
  from Meetings m join Users u on m.UserID=u.UserID 
  join Times t on m.MeetingTime=t.MeetingTime where m.MUserID = 1114

