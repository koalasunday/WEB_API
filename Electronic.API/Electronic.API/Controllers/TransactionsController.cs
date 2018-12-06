using Electronic.BussinessLogic.Service;
using Electronic.DataAccess.Models;
using Electronic.DataAccess.Params;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Electronic.API.Controllers
{
    [EnableCors(origins:"*", headers:"*", methods:"*")]
    public class TransactionsController : ApiController
    {
        private readonly ITransactionService _transactionService;

        public TransactionsController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        // GET: api/Transactions
        public List<Transaction> Get()
        {
            var get = _transactionService.Get();
            return get;
        }

        // GET: api/Transactions/5
        public Transaction Get(int id)
        {
            var get = _transactionService.Get(id);
            return get;
        }

        // POST: api/Transactions
        [HttpPost]
        public void Post(TransactionParam transactionParam)
        {
            _transactionService.Insert(transactionParam);
        }

        // PUT: api/Transactions/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Transactions/5
        public void Delete(int id)
        {
        }
    }
}
