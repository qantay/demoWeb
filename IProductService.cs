using demoWeb.Components.Pages.Products;

namespace demoWeb.Services.Product;

public interface IProductService
{
   Task<List<Models.Product>> GetAllProductsAsync();
   Task<Models.Product> GetProductById(int Id);
   Task CreateProductAsync(Models.Product product);
   Task UpdateProductAsync(Models.Product product);
   Task DeleteProductAsync(int Id);
}