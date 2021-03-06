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

    public partial class DetailTransaction
    {
        public DetailTransaction() { }

        public DetailTransaction(TransactionParam transactionParam)
        {
            this.Id = transactionParam.DetailTransactions_Id;
            this.Quantity = transactionParam.DetailTransactions_Quantity;
            this.Price = transactionParam.DetailTransactions_Price;
        }

        public int Id { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> Transactions_Id { get; set; }
        public Nullable<int> Items_Id { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual Transaction Transaction { get; set; }
    }
}
