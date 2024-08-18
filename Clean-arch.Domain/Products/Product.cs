using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Domain.Products
{
    public class Product
    {
        public Guid Id { get; private set; }
        public string? Title { get; private set; }
        public int Price { get; private set; }


        public Product(string title, int price)
        {
            Guard(title);
            PriceRange(price);
            Id = Guid.NewGuid();
            Title = title;
            Price = price;
        }

        public void Edit(string title, int price)
        {
            Guard(title);
            PriceRange(price);
            Title = title;
            Price = price;
        }
        private void Guard(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentNullException("title");
        }
        private void PriceRange(int price)
        {
            if (price < 0)
                throw new ArgumentOutOfRangeException();
        }
    }
}
