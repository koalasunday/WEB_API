using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronic.DataAccess.Models;
using Electronic.DataAccess.Params;

namespace Electronic.Common.Repository.Master
{
    public class ItemRepository : IItemRepository
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

        public List<Item> Get()
        {
            //List<Item> items = new List<Item>();
            //using (MyContext dc = new MyContext())
            //{
            //    items = dc.Items.OrderBy(a => a.Name).ToList();
            //}

            return _context.Items.Where(x => x.IsDelete == false).OrderBy(a => a.Name).ToList();
        }

        public Item Get(int? Id)
        {
            if (Id == null)
            {
                throw new NullReferenceException("Value cannot be null");
            }
            var getData = _context.Items.Find(Id);
            if (getData == null)
            {
                throw new NullReferenceException("Value cannot be null");
            }
            return getData;
        }

        public bool Insert(ItemParam itemParam)
        {
            var get = new Item(itemParam);
            _context.Items.Add(get);
            var result = _context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public bool Update(int? Id, ItemParam itemParam)
        {
            var get = Get(Id);
            get.Update(itemParam);
            var result = _context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }
    }
}
