using ApiRestModulo1.Communication;
using ApiRestModulo1.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiRestModulo1.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<SaveCategoryResponse> SaveAsync(Category category);
        Task<SaveCategoryResponse> UpdateAsync(int id, Category category);
    }
}
