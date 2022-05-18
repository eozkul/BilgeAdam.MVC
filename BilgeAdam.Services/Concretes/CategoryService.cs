using BilgeAdam.Common.Dtos;
using BilgeAdam.Data;
using BilgeAdam.Data.Entities;
using BilgeAdam.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Services.Concretes
{
    internal class CategoryService:ICategoryService
    {

        private readonly NorthwindDbContext dbContext;

        public CategoryService(NorthwindDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void AddCategory(CategoryAddDto dto)
        {
            dbContext.Categories.Add(new Category
            {
             CategoryName=dto.Name,
             Description=dto.Description,            
             
            });
            dbContext.SaveChanges();
        }

        public void DeleteCategory(int categoryId)
        {
            var result = dbContext.Categories.Where(c => c.CategoryID == categoryId).Single();
            if (result is not null)
            {
                dbContext.Categories.Remove(result);
                dbContext.SaveChanges();
            }
            return;

        }

    }
}

