using App.DAL.Interfaces;
using App.DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BL.Interfaces
{
    public interface ICategoryService
    {
        public CategoryDTO GetCategoryById(int id);

    }
}
