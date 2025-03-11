using api.DTOs.Category;
using api.Models;

namespace api.Interfaces
{
    public interface ICategoryRepository
    {
        Task<List<CategoryDto>> GetCategoriesAsync();
        Task<Category?> GetCategoryByIdAsync(int id);
        Task<Category> CreateCategoryAsync(Category categoryModel);
        Task<Category?> UpdateCategoryAsync(int id, UpdateCategoryRequestDto categoryDto);
        Task<Category?> DeleteCategoryAsync(int id);
    }
}
