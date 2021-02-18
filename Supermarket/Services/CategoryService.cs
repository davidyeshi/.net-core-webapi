using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Supermarket.Domain.Models;
using Supermarket.Domain.Repositories;
using Supermarket.Domain.Services;
using Supermarket.Domain.Services.Communication;

namespace Supermarket.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            _categoryRepository = categoryRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            // we need to access the database and return all categories, 
            // then we need to return this data to the client
            return await _categoryRepository.ListAsync();
        }

        public async Task<SaveCategoryResponse> SaveAsync(Category category)
        {
            try
            {
                await _categoryRepository.AddAsync(category);
                await _unitOfWork.CompleteAsync();

                return new SaveCategoryResponse(category);
            }
            catch (Exception e)
            {
                // Do some logging stuff
                return new SaveCategoryResponse($"An errror occured when saving the category: {e}");
            }
        }
    }
}
