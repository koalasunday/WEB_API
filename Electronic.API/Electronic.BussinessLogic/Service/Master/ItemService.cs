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
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;

        public ItemService() { }

        public ItemService(IItemRepository itemRepository)
        {
            this._itemRepository = itemRepository;
        }
        public void Delete(int? Id)
        {
            _itemRepository.Delete(Id);
        }

        public List<Item> Get()
        {
            return _itemRepository.Get();
        }

        public Item Get(int? Id)
        {
            return _itemRepository.Get(Id);
        }

        public void Insert(ItemParam itemParam)
        {
            _itemRepository.Insert(itemParam);
        }

        public void Update(int? id, ItemParam itemParam)
        {
            _itemRepository.Update(id, itemParam);
        }
    }
}
