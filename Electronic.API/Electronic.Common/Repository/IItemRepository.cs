using Electronic.DataAccess.Models;
using Electronic.DataAccess.Params;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronic.Common.Repository
{
    public interface IItemRepository
    {
        List<Item> Get();
        Item Get(int? Id);
        bool Insert(ItemParam itemParam);
        bool Update(int? Id, ItemParam itemParam);
        bool Delete(int? Id);
    }
}
