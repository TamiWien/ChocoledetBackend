using App.BL.Interfaces;
using App.BL.Mappers;
using App.DAL.DataContext;
using App.DAL.Entities;
using App.DAL.Interfaces;
using App.DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BL.Services
{
    public class ProductService: IProductService
    {
        public IProductsRepository products;
        public ProductService(IProductsRepository productsRepository)
        {
            products = productsRepository;
        }
        public ProductDTO GetProductById(Guid id)
        {
            return ProductMapper.Map(products.GetProductById(id));
        }
        public List<ProductDTO> GetProducts()
        {
            List<Product> productList = products.GetProducts();

            return productList.Select(u => ProductMapper.Map(u)).ToList();  
        }
        public Guid CreateProduct(ProductDTO product)
        {
            return products.CreateProduct(ProductMapper.Map(product));
        }
    }
}
