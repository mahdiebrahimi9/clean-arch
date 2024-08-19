using Clean_arch.Domain.Orders;
using Clean_arch.Domain.Orders.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Infrastructuer.Presistent.Memory.Orders
{
    public class OrderRepository : IOrderRepository
    {
        private Context _context;
        public void Add(Order order)
        {
            _context.Orders.Add(order);
        }

        public Order GetById(long id)
        {
            return _context.Orders.FirstOrDefault(order => order.Id == id);
        }

        public List<Order> GetList()
        {
            return _context.Orders;
        }

        public void SaveChange()
        {
            //
        }

        public void Update(Order order)
        {
            var oldOlrder = GetById(order.Id);
            _context.Orders.Remove(oldOlrder);
            Add(order);
        }
    }
}
