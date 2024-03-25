using Microsoft.AspNetCore.Mvc;
using ProductsManagement.Api.Service.Interfaces;
using ProductsManagement.Data.Models;

namespace ProductsManagement.Api.Service.Controllers
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
        public async Task AddProductAsync(Product product)
        {
            await _productService.AddProductAsyns(product);
        }

        [HttpGet]
        [Route("GetAllProducts")]
        public List<Product> GetAllProducts()
        {
           return _productService.GetAllProductAsync();
        }
    }
}
