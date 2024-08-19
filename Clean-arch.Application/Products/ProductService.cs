using Clean_arch.Application.Products.DTOs;
using Clean_arch.Domain.Products;
using Clean_arch.Domain.Products.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Application.Products
{
    public class ProductService : IProductService
    {
        private IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }
        public void AddProduct(AddProductDto command)
        {
            _repository.Add(new Product(command.Title, command.Price));
            _repository.Save();
        }

        public void EditProduct(EditProductDto command)
        {
            var product = _repository.GetById(command.Id);
            product.Edit(command.Title, command.Price);
            _repository.Update(product);
            _repository.Save();
        }

        public ProductDto GetProductById(Guid productId)
        {
            var product = _repository.GetById(productId);
            return new ProductDto()
            {
                Id = productId,
                Title = product.Title,
                Price = product.Price
            };


        }

        public List<ProductDto> GetProducts()
        {
            return _repository.GetList().Select(product => new ProductDto()
            {
                Id = product.Id,
                Title = product.Title,
                Price = product.Price
            }).ToList();
        }
    }
}
