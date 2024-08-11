﻿using App.DAL.DataContext;
using App.DAL.Entities;
using App.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DAL.Repositories
{
    public class CategoriesRepository:ICategoriesRepository
    {
        public ChocoledetContext dbContext;
        public CategoriesRepository(ChocoledetContext chocoledetContext)
        {
            dbContext = chocoledetContext;
        }
        public Category GetCategoryById(int id)
        {
            return dbContext.Categories.SingleOrDefault(u => u.CategoryId == id);
        }
    }
}
