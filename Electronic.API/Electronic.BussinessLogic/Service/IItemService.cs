using Electronic.DataAccess.Models;
using Electronic.DataAccess.Params;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronic.BussinessLogic.Service
{
    public interface IItemService
    {
        List<Item> Get();
        Item Get(int? Id);
        void Insert(ItemParam itemParam);
        void Update(int? id, ItemParam itemParam);
        void Delete(int? Id);
    }
}
