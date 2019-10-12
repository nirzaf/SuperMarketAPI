using Microsoft.EntityFrameworkCore;
using SuperMarketAPI.Domain.Repositories;
using SuperMarketAPI.Models;
using SuperMarketAPI.Persistence.Context;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperMarketAPI.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}
