using ProductsManagement.Data.Models;

namespace ProductsManagement.Api.Service.Interfaces
{
    public interface IProductService
    {
        public Task AddProductAsyns(Product product);
        public Task UpdateProductAsync(Product product);
        public Task DeleteProductAsync(Product product);
        public Task<Product?> GetProductByIdAsync(int id);
        public List<Product> GetAllProducts();
    }
}
