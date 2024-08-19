using Clean_arch.Domain.Orders;
using Clean_arch.Domain.Products;

namespace Clean_arch.Infrastructuer
{
    public class Context
    {
        public List<Product> products { get; set; }
        public List<Order> orders { get; set; } = new List<Order>() { new Order(Guid.NewGuid(), 25, 60) };
    }
}
