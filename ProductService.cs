using demoWeb.Data;
using demoWeb.Models;
using demoWeb.Services.Product;
using Microsoft.EntityFrameworkCore;

namespace demoWeb.Services.Products;

public class ProductService : IProductService
{
    
    private readonly AppDbContext _context;

    public ProductService(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<Models.Product>> GetAllProductsAsync()
    {
        return await _context.Products.Include(product => product.Category).ToListAsync();
    }

    public Task<Models.Product> GetProductById(int Id)
    {
        throw new NotImplementedException();
    }

    public Task CreateProductAsync(Models.Product product)
    {
        throw new NotImplementedException();
    }

    public Task UpdateProductAsync(Models.Product product)
    {
        throw new NotImplementedException();
    }

    public Task DeleteProductAsync(int Id)
    {
        throw new NotImplementedException();
    }
}