using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronic.DataAccess.Models;
using Electronic.DataAccess.Params;

namespace Electronic.Common.Repository.Master
{
    public class TransactionRepository : ITransactionRepository
    {
        MyContext _Context = new MyContext();
        private bool status = false;
        public List<Transaction> Get()
        {
            return _Context.Transactions.ToList();
        }

        public Transaction Get(int? Id)
        {
            if (Id == null)
            {
                throw new NullReferenceException("Value cannot be null");
            }
            var getData = _Context.Transactions.Find(Id);
            if (getData == null)
            {
                throw new NullReferenceException("Value cannot be null");
            }
            return getData;
        }

        public bool Insert(TransactionParam transactionParam)
        {
            var get = new Transaction(transactionParam);
            _Context.Transactions.Add(get);
            var result = _Context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }
    }
}
