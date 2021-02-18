using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Supermarket.Domain.Models;
using Supermarket.Domain.Repositories;
using Supermarket.Domain.Services;

namespace Supermarket.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            // we need to access the database and return all categories, 
            // then we need to return this data to the client
            return await _categoryRepository.ListAsync();
        }
    }
}
