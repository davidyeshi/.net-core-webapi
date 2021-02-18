using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Supermarket.Domain.Models;
using Supermarket.Domain.Services.Communication;

namespace Supermarket.Domain.Services
{
    public interface ICategoryService
    {
        // method must asynchronously return an enumeration of categories
        Task<IEnumerable<Category>> ListAsync();

        // Add the save method
        Task<SaveCategoryResponse> SaveAsync(Category category);
        Task<SaveCategoryResponse> UpdateAsync(int id, Category category);

    }
}
