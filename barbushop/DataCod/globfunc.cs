using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace barbushop
{
    public class globfunc
    {
        public static string calcTime (int index)
        {
            //0-08:00
            //1-08:30
            //2-09:00
            //3-09:30
            //4-10:00
                int hour = (index / 2) + 8;
            int minute = (index % 2) * 30;
            return hour + ":" + minute+"0";
        }
        public static int calcTime(string time)
        {
            //0-08:00
            //1-08:30
            //2-09:00
            //3-09:30
            //4-10:00
            string[] arr = time.Split(':');
            int hour = int.Parse(arr[0]);
            int minute = int.Parse(arr[1]);
            int index = hour - 8;
            if(minute==30)
            {
                index++;
            }

            return index;
        }
        public  int cpaProduct(int amunt,int cap)
        {
            int newCap = 0;
            newCap = cap - amunt;
            return newCap;
        }
    }
}