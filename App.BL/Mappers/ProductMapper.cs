﻿using App.DAL.Entities;
using App.DTO.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BL.Mappers
{
    internal static class ProductMapper
    {
        internal static Product Map(ProductDTO product)
        {
            return new Product
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                CategoryId = product.CategoryId,
                Price = product.Price,
                ImagePath = product.ImagePath,
            };
        }
        internal static ProductDTO Map(Product product)
        {
            return new ProductDTO
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                CategoryId = product.CategoryId,
                Price = product.Price,
                ImagePath = product.ImagePath,
            };
        }
    }
}
