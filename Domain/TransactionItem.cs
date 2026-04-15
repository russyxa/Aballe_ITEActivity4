using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aballe_ITEActivity4.Domain
{
    public class TransactionItem
    {
        public int ItemId { get; set; }
        public int TransactionId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CupSize { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice => UnitPrice * Quantity;
    }
}
