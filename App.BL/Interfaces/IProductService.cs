using App.DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BL.Interfaces
{
    public interface IProductService
    {
        public ProductDTO GetProductById(Guid id);
        public List<ProductDTO> GetProducts();
        public Guid CreateProduct(ProductDTO product);

    }
}
