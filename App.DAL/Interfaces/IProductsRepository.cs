using App.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DAL.Interfaces
{
    public interface IProductsRepository
    {
        public Product GetProductById(Guid id);
        public List<Product> GetProducts();
        public Guid CreateProduct(Product product);

    }
}
