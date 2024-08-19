using Clean_arch.Domain.Products;
using Clean_arch.Domain.Products.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Infrastructuer.Presistent.Memory.Products
{
    public class ProductRepository : IProductRepository
    {
        private Context _context;
        public ProductRepository(Context context)
        {
            _context = context;
        }
        public void Add(Product product)
        {
            _context.products.Add(product);
        }

        public Product GetById(Guid id)
        {
            return _context.products.FirstOrDefault(f => f.Id == id);
        }

        public List<Product> GetList()
        {
            return _context.products;
        }

        public void Remove(Product product)
        {
            _context.products.Remove(product);
        }

        public void Save()
        {
            //
        }

        public void Update(Product product)
        {
            var oldProduct = GetById(product.Id);
            _context.products.Remove(oldProduct);
            Add(product);
        }
    }
}
