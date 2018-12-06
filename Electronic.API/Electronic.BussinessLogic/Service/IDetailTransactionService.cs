using Electronic.DataAccess.Models;
using Electronic.DataAccess.Params;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronic.BussinessLogic.Service
{
    public interface IDetailTransactionService
    {
        List<DetailTransaction> Get();
        DetailTransaction Get(int? Id);
        void Insert(TransactionParam transactionParam);
    }
}
