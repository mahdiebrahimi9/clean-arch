using Clean_arch.Application.Orders;
using Clean_arch.Application.Products;
using Clean_arch.Contracts;
using Clean_arch.Domain.Orders.Repository;
using Clean_arch.Domain.Products.Repository;
using Clean_arch.Infrastructuer;
using Clean_arch.Infrastructuer.Presistent.Memory.Orders;
using Clean_arch.Infrastructuer.Presistent.Memory.Products;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Config
{
    public class ProjectBootstrapper
    {
        public static void Init(IServiceCollection service)
        {
            service.AddTransient<IOrderService, OrderService>();
            service.AddTransient<IProductService, ProductService>();
            service.AddTransient<IProductRepository, ProductRepository>();
            service.AddTransient<IOrderRepository, OrderRepository>();

            service.AddScoped<ISmsServiecs, SmsService>();
            service.AddSingleton<Context>();
        }

    }
}
