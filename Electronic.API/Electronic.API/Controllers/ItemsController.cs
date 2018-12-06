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
    public class ItemsController : ApiController
    {
        private readonly IItemService _itemService;

        public ItemsController() { }

        public ItemsController(IItemService itemService)
        {
            _itemService = itemService;
        }

        // GET: api/Item
        public List<Item> Get()
        {
            var get = _itemService.Get();
            return get;
        }

        // GET: api/Item/5
        public Item Get(int id)
        {
            var get = _itemService.Get(id);
            return get;
        }

        // POST: api/Item
        [HttpPost]
        public void Post(ItemParam itemParam)
        {
            _itemService.Insert(itemParam);
        }

        // PUT: api/Item/5
        public void Put(int id, ItemParam itemParam)
        {
            _itemService.Update(id, itemParam);
        }

        // DELETE: api/Item/5
        public void Delete(int id)
        {
            _itemService.Delete(id);
        }
    }
}
