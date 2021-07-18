using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using barbushop.DataDB;

namespace barbushop
{
    namespace DataCod
    {
        public class Meetings:Barabshops
        {
            public int MeetingID { get; set; }

            public string MeetingDate { get; set; }

            public string MeetingTime { get; set; }
            //public int BarbushopID { get; set; }
            public string Time { get; set; }
            public string HairCut { get; set; }
            public int MUserID { get; set; }
            public int Status { get; set; }
            public string BarberName { get; set; }
            public int dayLeft { get; set; }
            public string StatusName { get; set; }

            public  List<Meetings> GetBMangerMeetingss(int barID)
            {
                return MeetingsData.GetBMangerMeetingss(barID);
                    
            }
            public List<Meetings> GetMeetingss(int userId)
            {
                return MeetingsData.GetMeetingss(userId);
            }
            public List<Meetings> GetDayMettings(int userId)
            {
                return MeetingsData.GetDayMettings(userId);
            }
            public List<Meetings> GetMangerMeetingss(int Muserid)
            {
                return MeetingsData.GetMangerMeetingss(Muserid);
            }
            public  List<Meetings> GetUserByMeeting(int meetingID)
            {
                return MeetingsData.GetUserByMeeting(meetingID);
            }
            public  int DeleteMeetings(int MeetingID,int status)
            {
               return MeetingsData.DeleteMeetings(MeetingID,status);
            }
            public List<Meetings> GetDayMettingsUser(int BarId)
            {
                return MeetingsData.GetDayMettingsUser(BarId);
            }

            public  int InsertMeetings(string Meetingdate, string MeetingTime, int userID, string HairCut, int MUserID, int Status, int barid, string barberName)
            {
                return MeetingsData.InsertMeetings(Meetingdate, MeetingTime, userID, HairCut, MUserID, Status, barid, barberName);
            }
        }

    }
    

   
}