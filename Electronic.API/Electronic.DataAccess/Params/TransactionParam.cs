using Electronic.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronic.DataAccess.Params
{
    public class TransactionParam
    {
        public int Transactions_Id { get; set; }
        public string TransactionCode { get; set; }

        public int DetailTransactions_Id { get; set; }
        public Nullable<int> DetailTransactions_Quantity { get; set; }
        public Nullable<int> DetailTransactions_Price { get; set; }

        public Nullable<int> Items_Id { get; set; }
        public string Items_Name { get; set; }

    }
}
