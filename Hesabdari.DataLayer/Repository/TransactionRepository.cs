using Hesabdari.Utility.Convertor;
using Hesabdari.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesabdari.DataLayer.Services
{
    public class TransactionRepository :GenericRepository<Transaction>
    {
        Hesabdari_DBEntities db;
        public TransactionRepository(Hesabdari_DBEntities context) :base (context)
        {
            db = context;
        }
        public List<ReportingViewModel> 
            GetAllReportingByFilter(int TypeID,int customerID,DateTime? startDate,DateTime? endDate)
        {
            IQueryable<Transaction> query= db.Transaction;
            if (TypeID != 0)
            {
                query = query.Where(t => t.TypeID == TypeID);
            }            
            if (customerID != 0)
            {
                query = query.Where(t => t.CustomerID == customerID);
            }
            if (startDate != null)
            {
                query = query.Where(t => t.DateTime >= startDate);
            }
            if (endDate != null)
            {
                query = query.Where(t => t.DateTime <= endDate);
            }

            return query.ToList().Select(t => new ReportingViewModel
            {
                ID=t.ID,
                Fullname = t.Customers.FullName,
                Amount = t.Amount,
                TypeTitle = t.AccountingTypes.TypeTitle,
                DateTime = t.DateTime.ToShamsi(),
                Description = t.Description
            }).ToList();
        }

        public ReportingViewModel GetReportingByID(int ID)
        {
            return db.Transaction.Where(t => t.ID == ID).ToList().Select(t => new ReportingViewModel
            {
                ID=t.ID,
                Fullname = t.Customers.FullName,
                Amount = t.Amount,
                TypeTitle = t.AccountingTypes.TypeTitle,
                DateTime = t.DateTime.ToShamsi(),
                Description = t.Description
            }).FirstOrDefault();
        }

    }
}
