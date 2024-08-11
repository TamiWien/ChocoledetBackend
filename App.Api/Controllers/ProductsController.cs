using App.Api.Mappers;
using App.Api.Models;
using App.BL.Interfaces;
using App.BL.Services;
using App.DAL.Entities;
using App.DTO.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;
        public ProductsController(IProductService productsService)
        {
            _productService = productsService;
        }
        [HttpGet("{id}")]
        public ProductDTO GetProductById(Guid id)
        {
            return _productService.GetProductById(id);
        }
        [HttpGet]
        public List<ProductDTO> GetProducts()
        {
            return _productService.GetProducts();
        }
        [HttpPost]
        public Guid CreateProduct(ProductRequest product)
        {
            return _productService.CreateProduct(ProductMapper.Map(product));
        }
    }
}
