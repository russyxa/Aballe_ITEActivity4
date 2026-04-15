using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aballe_ITEActivity4.DTOs
{
    /// <summary>
    /// Bundles everything needed to save a completed transaction to the DB.
    /// </summary>
    public class CheckoutDto
    {
        public int CashierId { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Tendered { get; set; }
        public decimal ChangeAmount => Tendered - TotalAmount;
        public List<CartItemDto> Items { get; set; } = new List<CartItemDto>();
    }
}
