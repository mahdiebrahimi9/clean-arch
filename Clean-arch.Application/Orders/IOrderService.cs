using Clean_arch.Application.Orders.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Application.Orders
{
    public interface IOrderService
    {
        // Dto Sets Service
        List<OrderDto> GetOrders();
        void AddOrder(AddOrderDto command);
        void FinalliOrderDto(FinallyOrderDto command);
        OrderDto GetById(long id);
    }
}
