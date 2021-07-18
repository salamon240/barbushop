using barbushop.DataDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace barbushop
{
    namespace DataCod
    {
        public class DayOff:Barabshops
        {
            public int DayOffID { get; set; }
            public string DateDayOff { get; set; }
            public string daynow { get; set; }
            public DayOff()
            {

            }
            public DayOff(string dateDayOff)
            {
                this.DateDayOff = dateDayOff;
            }
            public  int insertrDayOff(int MuserID, string dayoff, int BarID)
            {
               return DayOffData.insertrDayOff(MuserID, dayoff, BarID);
            }
            public  List<DayOff> GetDays(int Barid)
            {
                return DayOffData.GetDays(Barid);
            }

        }

    }
}