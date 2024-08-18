using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Domain.Orders
{
    //Domain Entiti
    // دامین نقطعه اصلی ما است که انتیتی های ما قرار میگیرد
    public class Order
    {
        // Entiti
        public long Id { get;private set; }
        public Guid ProductId { get; private set; }
        public int Count { get; private set; }
        public int Price { get; private set; }
        public bool IsFinally { get; private set; }
        public DateTime FinallyDate { get; private set; }
        public int TotalPrice { get; private set; }


        public Order(Guid productId, int count, int price)
        {
            PriceRange(price);
            Guard(count);
            ProductId = productId;
            Count = count;
            Price = price;
        }

        // Added Product (Count)
        public void IncreaseProductCount(int count)
        {

            Guard(count);
            Count = +count;
        }

        public void Finally()
        {
            IsFinally = true;
            FinallyDate = DateTime.Now;
        }

        // Entities Exception
        private void Guard(int count)
        {
            if (count < 1)
                throw new ArgumentException();
        }

        private void PriceRange(int price)
        {
            if (price < 0)
                throw new ArgumentOutOfRangeException();
        }
    }
}
