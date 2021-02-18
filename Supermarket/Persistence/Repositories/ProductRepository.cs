using Microsoft.EntityFrameworkCore;
using Supermarket.Domain.Models;
using Supermarket.Domain.Repositories;
using Supermarket.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.Persistence.Repositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Product>> ListAsync()
        {
            // Notice p=>p.Category
            // We can chain this syntax to include as many
            // entities as necessary when querying data
            return await _context.Products.Include(p => p.Category)
                                          .ToListAsync();
        }
    }
}
