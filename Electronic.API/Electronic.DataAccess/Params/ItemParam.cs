using Electronic.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronic.DataAccess.Params
{
    public class ItemParam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> Stock { get; set; }

        //public ItemParam() { }
        //public ItemParam(Item item)
        //{
        //    Id = item.Id;
        //    Name = item.Name;
        //    Price = item.Price;
        //    Stock = item.Stock;
        //}
    }
}
