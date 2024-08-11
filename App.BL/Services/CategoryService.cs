using App.BL.Interfaces;
using App.BL.Mappers;
using App.DAL.DataContext;
using App.DAL.Entities;
using App.DAL.Interfaces;
using App.DAL.Repositories;
using App.DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BL.Services
{
    public class CategoryService: ICategoryService
    {
        public ICategoriesRepository categories;
        public CategoryService(ICategoriesRepository categoriesRepository)
        {
            categories = categoriesRepository;
        }
        public CategoryDTO GetCategoryById(int id)
        {
            return CategoryMapper.Map(categories.GetCategoryById(id));
        }
    }

}
