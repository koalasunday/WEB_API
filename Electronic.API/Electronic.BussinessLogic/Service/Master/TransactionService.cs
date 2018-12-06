using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronic.DataAccess.Models;
using Electronic.DataAccess.Params;
using Electronic.Common.Repository;

namespace Electronic.BussinessLogic.Service.Master
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;

        public TransactionService() { }
        
        public TransactionService(ITransactionRepository transactionRepository)
        {
            this._transactionRepository = transactionRepository;
        }
        public List<Transaction> Get()
        {
            return _transactionRepository.Get();
        }

        public Transaction Get(int? Id)
        {
            return _transactionRepository.Get(Id);
        }

        public void Insert(TransactionParam transactionParam)
        {
            _transactionRepository.Insert(transactionParam);
        }
    }
}
