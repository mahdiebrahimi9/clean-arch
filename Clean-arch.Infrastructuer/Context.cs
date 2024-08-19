using Clean_arch.Domain.Orders;
using Clean_arch.Domain.Products;

namespace Clean_arch.Infrastructuer
{
    public class Context
    {
        public List<Product> Products { get; set; }
        public List<Order> Orders { get; set; }
    }
}
