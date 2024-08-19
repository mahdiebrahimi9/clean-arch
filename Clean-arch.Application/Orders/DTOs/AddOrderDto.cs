using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Data Transfer Object  ( DTO )
/*
 * A DTO is a simple, plain object used for transferring data between
 * software application layers and, more commonly, between the server and client in an API .
*/

namespace Clean_arch.Application.Orders.DTOs
{
    // Return Order
    public class OrderDto
    {
        public long Id { get; set; }
        public Guid ProductId { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }

    }

    public class AddOrderDto
    {
        public Guid ProductId { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
    }
    public class FinallyOrderDto
    {
        public long OrderId { get; set; }
    }
}
