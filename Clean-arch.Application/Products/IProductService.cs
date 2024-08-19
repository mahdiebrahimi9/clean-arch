using Clean_arch.Application.Products.DTOs;
using Clean_arch.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Application.Products
{
    public interface IProductService
    {
        List<ProductDto> GetProducts();
        ProductDto GetProductById(Guid productId);
        void AddProduct(AddProductDto command);
        void EditProduct(EditProductDto command);
    }
}
