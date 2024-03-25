using ProductsManagement.Api.Service.Interfaces;
using ProductsManagement.Data.Interfaces;
using ProductsManagement.Data.Models;

namespace ProductsManagement.Api.Service.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task AddProductAsyns(Product product)
        {
            await _productRepository.AddAsync(product);
            await _productRepository.CompleteAsync();
        }

        public async Task UpdateProductAsync(Product product)
        {
           await _productRepository.UpdateAsync(product);
           await _productRepository.CompleteAsync();
        }

        public async Task<Product?> GetProductByIdAsync(int id)
        {
            return await _productRepository.
                FirstOrDefaultAsync(x => x.Id == id);
        }

        public List<Product> GetAllProducts()
        {
            var productList = _productRepository.GetAll();
            return (List<Product>)productList;
        }

        public async Task DeleteProductAsync(Product product)
        {
            _productRepository.Delete(product);
            await _productRepository.CompleteAsync();
        }
    }
}
