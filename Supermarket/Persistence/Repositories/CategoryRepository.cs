using Supermarket.Domain.Models;
using Supermarket.Domain.Repositories;
using Supermarket.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.Persistence.Repositories
{
    // Repository inherits the BaseRepository and implements ICategoryRepository.
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context) { }

        public async Task AddAsync(Category category)
        {
            await _context.Categories.AddAsync(category);
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            // We use the Categories database saet to accesss
            // the categories table and then call the extension
            // method ToListAsync, which is responsible for
            // transforming the result of a query into a collection of categories.
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> FindByIdAsync(int id)
        {
            return await _context.Categories.FindAsync(id);
        }

        public void Update(Category category)
        {
            _context.Categories.Update(category);
        }
    }
}
