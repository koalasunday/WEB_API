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
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository _supplierRepository;

        public SupplierService() { }

        public SupplierService(ISupplierRepository supplierRepository)
        {
            this._supplierRepository = supplierRepository;
        }

        public bool Delete(int? Id)
        {
            return _supplierRepository.Delete(Id);
        }

        public List<Supplier> Get()
        {
            return _supplierRepository.Get();
        }

        public Supplier Get(int? Id)
        {
            return _supplierRepository.Get(Id);
        }

        public bool Insert(SuppliersParam supplierParam)
        {
            return _supplierRepository.Insert(supplierParam);
        }

        public bool Update(int? Id, SuppliersParam supplierParam)
        {
            return _supplierRepository.Update(Id, supplierParam);
        }
    }
}
