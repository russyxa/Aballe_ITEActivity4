using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aballe_ITEActivity4.DTOs
{
    /// <summary>
    /// Used to display products on the menu panel (UserControl1 cards).
    /// </summary>
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string FormattedPrice { get; set; }
        public string ImagePath { get; set; }
    }
}
