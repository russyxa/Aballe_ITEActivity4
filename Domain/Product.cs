using System;

namespace Aballe_ITEActivity4.Domain
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime CreatedAt { get; set; }

        public Product() { }

        public Product(string name, decimal price, string imagePath)
        {
            Name = name;
            Price = price;
            ImagePath = imagePath;
            IsAvailable = true;
        }

        public string FormattedPrice => $"₱{Price:F2}";
    }
}