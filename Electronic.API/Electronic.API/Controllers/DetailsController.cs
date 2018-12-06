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
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class DetailsController : ApiController
    {
        private readonly IDetailTransactionService _detailTransactionService;

        public DetailsController(IDetailTransactionService detailTransactionService)
        {
            _detailTransactionService = detailTransactionService;
        }

        // GET: api/Details
        public List<DetailTransaction> Get()
        {
            var get = _detailTransactionService.Get();
            return get;
        }

        // GET: api/Details/5
        public DetailTransaction Get(int id)
        {
            var get = _detailTransactionService.Get(id);
            return get;
        }

        // POST: api/Details
        public void Post(TransactionParam transactionParam)
        {
            _detailTransactionService.Insert(transactionParam);
        }

        // PUT: api/Details/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Details/5
        public void Delete(int id)
        {
        }
    }
}
