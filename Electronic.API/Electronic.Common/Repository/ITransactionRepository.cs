using Electronic.DataAccess.Models;
using Electronic.DataAccess.Params;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronic.Common.Repository
{
    public interface ITransactionRepository
    {
        List<Transaction> Get();
        Transaction Get(int? Id);
        bool Insert(TransactionParam transactionParam);
    }
}
