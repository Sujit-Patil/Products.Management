using Microsoft.AspNetCore.Mvc;
using Products.Management.ApiService.Interfaces;
using ProductsManagement.Data.Models;

namespace Products.Management.ApiService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService) 
        {
            _productService = productService;
        }

        [HttpPost]
        [Route("AddProduct")]
        public async Task AddProductAsync(Product product)
        {
            await _productService.AddProductAsyns(product);
        }

        [HttpGet]
        [Route("GetAllProducts")]
        public List<Product> GetAllProducts()
        {
           return _productService.GetAllProducts();
        }

        [HttpGet]
        [Route("GetProductById")]
        public async Task<Product?> GetProductById(int id)
        {
            return await _productService.GetProductByIdAsync(id);
        }

        [HttpPut]
        [Route("UpdateProduct")]
        public async Task UpdateProduct(Product product)
        {
             await _productService.UpdateProductAsync(product);
        }

        [HttpDelete]
        [Route("DeleteProduct")]
        public async Task DeleteProductAsync(Product product)
        {
           await _productService.DeleteProductAsync(product);
        }
    }
}
