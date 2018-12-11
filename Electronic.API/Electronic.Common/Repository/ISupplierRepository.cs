﻿using Electronic.DataAccess.Models;
using Electronic.DataAccess.Params;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronic.Common.Repository
{
   public interface ISupplierRepository
    {
        List<Supplier> Get();
        Supplier Get(int? Id);
        bool Insert(SuppliersParam supplierParam);
        bool Update(int? Id, SuppliersParam supplierParam);
        bool Delete(int? Id);
    }
}
