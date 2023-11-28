using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesabdari.Utility.Convertor
{
    public static class DateConvertor
    {
        public static string ToShamsi(this DateTime miladi)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(miladi).ToString()+"/"+ pc.GetMonth(miladi).ToString("00") 
                + "/" + pc.GetDayOfMonth(miladi).ToString("00");
        }

        public static DateTime ToMiladi(string shamsi)
        {
            return new DateTime(int.Parse(shamsi.Split('/')[0]), int.Parse(shamsi.Split('/')[1]), int.Parse(shamsi.Split('/')[2]), new PersianCalendar());
        }        
        public static DateTime FirstDayOfCurrentShamsiMonth(this DateTime miladi)
        {
            string shamsi = miladi.ToShamsi();
            return new DateTime(int.Parse(shamsi.Split('/')[0]), int.Parse(shamsi.Split('/')[1]),1, new PersianCalendar());
        }
        public static DateTime LastDayOfCurrentShamsiMonth(this DateTime miladi)
        {
            string shamsi = miladi.ToShamsi();
            
            if (int.Parse(shamsi.Split('/')[1]) <= 6)
            {
                return new DateTime(int.Parse(shamsi.Split('/')[0]), int.Parse(shamsi.Split('/')[1]), 31, new PersianCalendar());
            }
            if (int.Parse(shamsi.Split('/')[1]) == 12)
            {
                return new DateTime(int.Parse(shamsi.Split('/')[0]), int.Parse(shamsi.Split('/')[1]), 29, new PersianCalendar());
            }
            return new DateTime(int.Parse(shamsi.Split('/')[0]), int.Parse(shamsi.Split('/')[1]), 30, new PersianCalendar());
        }
    }
}
