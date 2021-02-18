using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.Domain.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Mapping the relationship between categories and products
        // Category has many related products
        public IList<Product> Products { get; set; } = new List<Product>();
    }
}
