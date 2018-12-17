//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Electronic.DataAccess.Models
{
    using Params;
    using System;
    using System.Collections.Generic;

    public partial class Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Item()
        {
            this.DetailTransactions = new HashSet<DetailTransaction>();
        }
        public Item(ItemParam itemParam)
        {
            this.Id = itemParam.Id;
            this.Name = itemParam.Name;
            this.Price = itemParam.Price;
            this.Stock = itemParam.Stock;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public virtual void Update(ItemParam itemParam)
        {
            this.Id = itemParam.Id;
            this.Name = itemParam.Name;
            this.Price = itemParam.Price;
            this.Stock = itemParam.Stock;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public virtual void Delete()
        {
            this.IsDelete = true;
            this.Deletedate = DateTimeOffset.Now.LocalDateTime;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> Stock { get; set; }
        public Nullable<System.DateTimeOffset> CreateDate { get; set; }
        public Nullable<System.DateTimeOffset> UpdateDate { get; set; }
        public Nullable<System.DateTimeOffset> Deletedate { get; set; }
        public bool IsDelete { get; set; }
        public Nullable<int> Suppliers_Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailTransaction> DetailTransactions { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
