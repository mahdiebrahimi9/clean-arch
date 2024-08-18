using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Domain.Products.Repository
{
    public interface IProductRepository
    {
        List<Product> GetList();
        Product GetById(Guid id);
        void Add(Product product);
        void Update(Product product);
        void Remove(Product product);
        void Save();
    }
}
