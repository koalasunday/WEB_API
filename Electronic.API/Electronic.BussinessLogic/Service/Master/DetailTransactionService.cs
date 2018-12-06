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
    public class DetailTransactionService : IDetailTransactionService
    {
        private readonly IDetailTransactionRepository _detailTransactionRepository;

        public DetailTransactionService() { }

        public DetailTransactionService(IDetailTransactionRepository detailTransactionRepository)
        {
            this._detailTransactionRepository = detailTransactionRepository;
        }

        public List<DetailTransaction> Get()
        {
            return _detailTransactionRepository.Get();
        }

        public DetailTransaction Get(int? Id)
        {
            return _detailTransactionRepository.Get(Id);
        }

        public void Insert(TransactionParam transactionParam)
        {
            _detailTransactionRepository.Insert(transactionParam);
        }
    }
}
