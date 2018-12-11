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
    public class SuppliersController : ApiController
    {
        private readonly ISupplierService _supplierService;

        public SuppliersController() { }

        public SuppliersController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        // GET: api/Suppliers
        public List<Supplier> Get()
        {
            var get = _supplierService.Get();
            return get;
        }

        // GET: api/Suppliers/5
        public Supplier Get(int id)
        {
            var get = _supplierService.Get(id);
            return get;
        }

        [HttpPost]
        // POST: api/Suppliers
        public void Post(SuppliersParam supplierParam)
        {
            _supplierService.Insert(supplierParam);
        }

        // PUT: api/Suppliers/5
        public void Put(int id, SuppliersParam supplierParam)
        {
            _supplierService.Update(id, supplierParam);
        }

        // DELETE: api/Suppliers/5
        public void Delete(int id)
        {
            _supplierService.Delete(id);
        }
    }
}
