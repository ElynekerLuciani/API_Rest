using ApiRestModulo1.Communication;
using ApiRestModulo1.Domain.Models;
using ApiRestModulo1.Domain.Repositories;
using ApiRestModulo1.Domain.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using ApiRestModulo1.Communication;

namespace ApiRestModulo1.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            _categoryRepository = categoryRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRepository.ListAsync();
        }

        public async Task<SaveCategoryResponse> SaveAsync(Category category)
        {
            try
            {
                await _categoryRepository.AddAsync(category);
                await _unitOfWork.CompleteAsync();

                return new SaveCategoryResponse(category);

            }catch(Exception e)
            {
                return new SaveCategoryResponse($"An error ocurred when saving the category: { e.Message }");
            }
        }

        public async Task<SaveCategoryResponse> UpdateAsync(int id, Category category)
        {
            var existingCategory = await _categoryRepository.FindByIdAsync(id);

            if (existingCategory == null)
                return new SaveCategoryResponse("Category not found");

            existingCategory.Name = category.Name;

            try
            {
                _categoryRepository.Update(existingCategory);
                await _unitOfWork.CompleteAsync();

                return new SaveCategoryResponse(existingCategory);
            } catch(Exception e)
            {
                return new SaveCategoryResponse($"An error occurred when updating the category: {e.Message}");
            }
        }
    }
}
