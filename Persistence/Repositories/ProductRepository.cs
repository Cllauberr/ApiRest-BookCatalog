using System.Linq;
using System.Threading.Tasks;
using api_rest.Domain.Models;
using api_rest.Domain.Helpers;
using System.Collections.Generic;
using api_rest.Domain.Repositories;
using api_rest.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace api_rest.Persistence.Repositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context){ }

        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _context.Products.Include(p => p.Category)
                                          .ToListAsync();
        }
        
        public async Task<IEnumerable<Product>> FindByPlatformAsync(EUnitOfBook book)
        {
            return await _context.Products.Where(x => x.UnitOfBook.HasFlag(book)).ToListAsync();
        }

        public async Task<Product> FindByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }
    }

}
