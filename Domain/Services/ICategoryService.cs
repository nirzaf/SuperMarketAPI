using SuperMarketAPI.Domain.Services.Communication;
using SuperMarketAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperMarketAPI.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<SaveCategoryResponse> SaveAsync(Category category);
    }
}
