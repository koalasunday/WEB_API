using Electronic.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronic.DataAccess.Params
{
    public class SuppliersParam
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public SuppliersParam() { }

        public SuppliersParam(Supplier supplier)
        {
            this.Id = supplier.Id;
            this.Name = supplier.Name;
        }

        
    }
}
