﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Supermarket.Domain.Models;

namespace Supermarket.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
