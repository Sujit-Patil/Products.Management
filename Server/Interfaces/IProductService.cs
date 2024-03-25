using ProductsManagement.Data.Models;

namespace Products.Management.ApiService.Interfaces
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
