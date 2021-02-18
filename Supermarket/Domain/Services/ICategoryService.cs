using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Supermarket.Domain.Models;

namespace Supermarket.Domain.Services
{
    public interface ICategoryService
    {
        // method must asynchronously return an enumeration of categories
        Task<IEnumerable<Category>> ListAsync();
    }
}
