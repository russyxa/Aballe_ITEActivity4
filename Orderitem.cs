using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aballe_ITEActivity4
{
    /// <summary>
    /// Represents a single line item in the customer's order.
    /// </summary>
    public class OrderItem
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Computed total price for this line item.
        /// </summary>
        public decimal TotalPrice => UnitPrice * Quantity;

        public OrderItem(string productName, decimal unitPrice)
        {
            ProductName = productName;
            UnitPrice = unitPrice;
            Quantity = 1;
        }
    }
}
