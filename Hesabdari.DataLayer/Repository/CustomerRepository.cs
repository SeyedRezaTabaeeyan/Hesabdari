using Hesabdari.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesabdari.DataLayer.Services
{
    public class CustomerRepository : GenericRepository<Customers>
    {
        Hesabdari_DBEntities db;
        public CustomerRepository(Hesabdari_DBEntities context):base(context)
        {
            db = context;
        }        

        public List<Customers> Search(string search)
        {
            return db.Customers.Where(t => t.FullName.Contains(search)||
                                           t.Mobile.Contains(search)||
                                           t.Email.Contains(search)).ToList();
        }

        public List<CustomerNameIDViewModel> GetNameIDCustomers(string filter)
        {
            return db.Customers.Where(t=>t.FullName.Contains(filter)).Select
                    (t => new CustomerNameIDViewModel
                    {
                        CustomerID = t.CustomerID,
                        FullName = t.FullName
                    }
                    ).ToList();
        }
    }
}
