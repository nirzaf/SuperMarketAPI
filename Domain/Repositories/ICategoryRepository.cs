using SuperMarketAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperMarketAPI.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
