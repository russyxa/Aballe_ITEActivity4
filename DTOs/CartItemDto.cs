using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aballe_ITEActivity4;

namespace Aballe_ITEActivity4.DTOs
{
    /// <summary>
    /// Represents one row in the order DataGridView.
    /// </summary>
    public class CartItemDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CupSize { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice => UnitPrice * Quantity;

        // Display helpers for the grid
        public string DisplayName => $"{ProductName} ({CupSize})";
        public string FormattedUnitPrice => $"₱{UnitPrice:F2}";
        public string FormattedTotalPrice => $"₱{TotalPrice:F2}";
    }
}
