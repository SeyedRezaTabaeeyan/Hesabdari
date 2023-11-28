using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesabdari.ViewModels
{
    public class ReportingViewModel
    {
        public int ID { get; set; }
        public string Fullname { get; set; }
        public int Amount { get; set; }
        public string TypeTitle { get; set; }
        public string DateTime { get; set; }
        public string Description { get; set; }
    }
}
