using demoWeb.Models;

namespace demoWeb.Services;

public interface ICategoryService
{
    Task<List<Category>> GetAllCategoryAsync();
    Task<Category> GetCategoryByIdAsync(int Id);
    Task CreateCategoryAsync(Category category);
    Task UpdateCategoryAsync(Category category);
    Task DeleteCategoryAsync(int Id);
}