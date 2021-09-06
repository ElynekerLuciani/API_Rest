using ApiRestModulo1.Domain.Models;
using ApiRestModulo1.Domain.Repositories;
using ApiRestModulo1.Domain.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiRestModulo1.Services
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
