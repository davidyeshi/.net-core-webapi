using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Supermarket.Resources
{
    // Used for creating a new category, we don't have an ID yet,
    // and it means we need a resource that represents a category containing only its name
    public class SaveCategoryResource
    {
        // .net core pipeline uses these attributes to validate
        // request and response
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
