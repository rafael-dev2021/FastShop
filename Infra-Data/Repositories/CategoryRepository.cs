﻿using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra_Data.Repositories
{
    internal class CategoryRepository : ICategoryRepository
    {
        public Task<Category> CreateAsync(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task<Category> DeleteAsync(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryWithProductCount>> GetCategoriesWithProductCountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Category>> GetEntitiesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Category> UpdateAsync(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
