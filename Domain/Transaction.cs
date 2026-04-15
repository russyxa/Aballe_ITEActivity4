using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aballe_ITEActivity4.Domain
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public int UserId { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Tendered { get; set; }
        public decimal ChangeAmount { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
