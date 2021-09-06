using ApiRestModulo1.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiRestModulo1.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
