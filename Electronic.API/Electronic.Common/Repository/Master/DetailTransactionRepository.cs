using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronic.DataAccess.Models;
using Electronic.DataAccess.Params;

namespace Electronic.Common.Repository.Master
{
    public class DetailTransactionRepository : IDetailTransactionRepository
    {
        MyContext _context = new MyContext();
        private bool status = false;
        public List<DetailTransaction> Get()
        {
            return _context.DetailTransactions.ToList();
        }

        public DetailTransaction Get(int? Id)
        {
            if (Id == null)
            {
                throw new NullReferenceException("Value cannot be null");
            }
            var getData = _context.DetailTransactions.Find(Id);
            if (getData == null)
            {
                throw new NullReferenceException("Value cannot be null");
            }
            return getData;
        }

        public bool Insert(TransactionParam transactionParam)
        {
            var get = new DetailTransaction(transactionParam);
            _context.DetailTransactions.Add(get);
            var result = _context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }
    }
}
