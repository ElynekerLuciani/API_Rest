using ApiRestModulo1.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiRestModulo1.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
