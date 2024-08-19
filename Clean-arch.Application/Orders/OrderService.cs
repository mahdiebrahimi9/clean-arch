using Clean_arch.Application.Orders.DTOs;
using Clean_arch.Contracts;
using Clean_arch.Domain.Orders;
using Clean_arch.Domain.Orders.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Application.Orders
{
    // Apllicatioan Layer UseCase
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repository;
        private readonly ISmsServiecs _smsService;

        public OrderService(IOrderRepository repository, ISmsServiecs smsServiecs)
        {
            _repository = repository;
            _smsService = smsServiecs;
        }

        public void AddOrder(AddOrderDto command)
        {
            // DTO Order Data Added To Base Domain Order Entites
            var order = new Order(command.ProductId, command.Count, command.Price);
            _repository.Add(order);
        }

        public void FinalliOrderDto(FinallyOrderDto command)
        {
            var order = _repository.GetById(command.OrderId);
            order.Finally();
            _repository.Update(order);
            _repository.SaveChange();

            _smsService.SendSms(new SmsBody()
            {
                PhoneNumber="0920142546",
                Message="Test Sms"
            });
        }

        public OrderDto GetById(long id)
        {
            var order = _repository.GetById(id);
            return new OrderDto()
            {
                Id = order.Id,
                ProductId = order.ProductId,
                Price = order.Price,
                Count = order.Count,

            };
        }

        public List<OrderDto> GetOrders()
        {
            return _repository.GetList().Select(order => new OrderDto()
            {
                Count = order.Count,
                Price = order.Price,
                ProductId = order.ProductId,
                Id = order.Id

            }).ToList();

        }
    }
}
