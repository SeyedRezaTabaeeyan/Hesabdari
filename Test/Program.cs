using Hesabdari.Utility.Convertor;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime miladi = DateTime.Now;
            DateTime shamsi = miladi.ToShamsi();            
            DateTime dateTime = new DateTime(shamsi.Year, shamsi.Month, 30, new PersianCalendar()); ;
            Console.WriteLine(dateTime);
            dateTime = dateTime.ToMiladi();
            Console.WriteLine(dateTime);
            dateTime = dateTime.ToShamsi();
            Console.WriteLine(dateTime);
            PersianCalendar pc = new PersianCalendar();
            try
            {
                DateTime dateTime1 = new DateTime(pc.GetYear(miladi), pc.GetMonth(miladi), 30);
                //Console.WriteLine(dateTime1);
            }
            catch
            {
                Console.WriteLine("Error");
            }           
            
            Console.ReadLine();
            
            
        }
    }
}
