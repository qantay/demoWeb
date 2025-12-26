using System.Xml.Serialization;
using demoWeb.Data;
using demoWeb.Models;
using Microsoft.EntityFrameworkCore;


namespace demoWeb.Services;

public class CategoryServices : ICategoryService
{
    private readonly AppDbContext _context;
    public CategoryServices(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<Category>> GetAllCategoryAsync()
    {
        return await _context.Categories.ToListAsync();
    }

    public async Task<Category> GetCategoryByIdAsync(int Id)
    {
        return await _context.Categories.FindAsync(Id);
    }

    public async Task CreateCategoryAsync(Category category)
    {
        _context.Categories.Add(category);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateCategoryAsync(Category category)
    {
        _context.Categories.Update(category);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteCategoryAsync(int Id)
    {
        var category = await _context.Categories.FindAsync(Id);
        if (category  != null)
        {
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
        }
    }
}