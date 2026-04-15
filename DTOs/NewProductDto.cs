using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aballe_ITEActivity4.DTOs
{
    /// <summary>
    /// Carries AddProductForm input to the datastore.
    /// </summary>
    public class NewProductDto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }
    }
}
