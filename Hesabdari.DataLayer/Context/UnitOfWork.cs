using Hesabdari.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesabdari.DataLayer.Context
{
    public class UnitOfWork:IDisposable
    {
        Hesabdari_DBEntities db = new Hesabdari_DBEntities();
        private CustomerRepository _customerRepository;
        public CustomerRepository CustomerRepository { 
            get{
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(db);
                }
                return _customerRepository;
             }
        }
        private TransactionRepository _transactionRepository;
        public TransactionRepository TransactionRepository
        {
            get
            {
                if (_transactionRepository == null)
                {
                    _transactionRepository = new TransactionRepository(db);
                }
                return _transactionRepository;
            }
                
        }
        private GenericRepository<Login> _loginRepository ;

        public GenericRepository<Login> LoginRepository 
        {
            get
            {
                if (_loginRepository == null)
                {
                    _loginRepository = new GenericRepository<Login>(db);
                }
                return _loginRepository;
            }
         }

        public void Dispose()
        {
            try
            {
                db.SaveChanges();                
            }
            catch
            {
               
            }
            db.Dispose();

        }
    }
}
