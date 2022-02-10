﻿using System.Threading.Tasks;
using api_rest.Domain.Models;
using api_rest.Domain.Helpers;
using System.Collections.Generic;

namespace api_rest.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> ListAsync();
        Task<Product> FindByIdAsync(int id);
        Task<IEnumerable<Product>> FindByPlatformAsync(EUnitOfBook platform);
    }
}
