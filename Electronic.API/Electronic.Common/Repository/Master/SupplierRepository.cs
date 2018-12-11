using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronic.DataAccess.Models;
using Electronic.DataAccess.Params;

namespace Electronic.Common.Repository.Master
{
    public class SupplierRepository : ISupplierRepository
    {
        MyContext _context = new MyContext();
        private bool status = false;

        public bool Delete(int? Id)
        {
            var get = Get(Id);
            get.Delete();
            var result = _context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public List<Supplier> Get()
        {
            return _context.Suppliers.Where(x => x.IsDelete == false).ToList();
        }

        public Supplier Get(int? Id)
        {
            if (Id == null)
            {
                throw new NullReferenceException("Value cannot be null");
            }
            var getData = _context.Suppliers.Find(Id);
            if (getData == null)
            {
                throw new NullReferenceException("Value cannot be null");
            }
            return getData;
        }

        public bool Insert(SuppliersParam supplierParam)
        {
            var get = new Supplier(supplierParam);
            _context.Suppliers.Add(get);
            var result = _context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public bool Update(int? Id, SuppliersParam supplierParam)
        {
            var get = Get(Id);
            get.Update(supplierParam);
            var result = _context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }
    }
}
