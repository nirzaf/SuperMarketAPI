using SuperMarketAPI.Domain.Repositories;
using SuperMarketAPI.Domain.Services;
using SuperMarketAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperMarketAPI.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRepository.ListAsync();
        }
    }
}
