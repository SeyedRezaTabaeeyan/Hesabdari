using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesabdari.ViewModels
{
    public class ReportBalanceViewModel
    {   
        public string Fullname { get; set; }
        public string FromShamsiDate { get; set; }
        public string ToShamsiDate { get; set; }
        public int SumReceive { get; set; }
        public int SumPay { get; set; }
        public int Remaining { get; set; }
    }
}
