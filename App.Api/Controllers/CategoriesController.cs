using App.BL.Interfaces;
using App.BL.Services;
using App.DTO.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoriesService)
        {
            _categoryService = categoriesService;
        }
        [HttpGet("{id}")]
        public CategoryDTO GetCategoryById(int id)
        {
            return _categoryService.GetCategoryById(id);
        }
    }
}
