using Hesabdari.DataLayer.Context;
using Hesabdari.Utility.Convertor;
using Hesabdari.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesabdari.Business
{
    public static class Report
    {
        public static ReportBalanceViewModel ReportMonth()
        {
            DateTime startDate = DateTime.Now.FirstDayOfCurrentShamsiMonth();            
            DateTime endDate=DateTime.Now.LastDayOfCurrentShamsiMonth();
            using(UnitOfWork db=new UnitOfWork())
            {
                var report = new ReportBalanceViewModel()
                {
                    FromShamsiDate = startDate.ToShamsi(),
                    ToShamsiDate=endDate.ToShamsi(),
                    SumReceive = db.TransactionRepository.GetAllReportingByFilter(TypeID:1,customerID:0, startDate, endDate).Select(t => t.Amount).Sum(),
                    SumPay= db.TransactionRepository.GetAllReportingByFilter(TypeID: 2, customerID: 0, startDate, endDate).Select(t => t.Amount).Sum(),
                };
                report.Remaining = report.SumReceive - report.SumPay;
                return report;
            }
            
        }
        public static List<ReportBalanceViewModel> ReportComPlex(int customerID,DateTime? startDate,DateTime? endDate)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var report = new ReportBalanceViewModel()
                {
                    FromShamsiDate = (startDate == null) ? "همیشه" : startDate.Value.ToShamsi(),
                    ToShamsiDate = (endDate == null) ? "همیشه" : endDate.Value.ToShamsi(),
                    SumReceive = db.TransactionRepository.GetAllReportingByFilter(TypeID: 1, customerID, startDate, endDate).Select(t => t.Amount).Sum(),
                    SumPay = db.TransactionRepository.GetAllReportingByFilter(TypeID: 2, customerID, startDate, endDate).Select(t => t.Amount).Sum(),
                };
                report.Fullname = (customerID == 0) ? "همه" : db.CustomerRepository.GetByID(customerID).FullName;
                report.Remaining = report.SumReceive - report.SumPay;
                List<ReportBalanceViewModel> listReport = new List<ReportBalanceViewModel>();
                listReport.Add(report);
                    
                return listReport;
            }        
        }
    }
}
