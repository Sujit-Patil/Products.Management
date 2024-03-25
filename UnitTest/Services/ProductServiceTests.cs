using Moq;
using Products.Management.ApiService;
using Products.Management.ApiService.Interfaces;
using ProductsManagement.Data.Interfaces;

namespace Products.Management.ApiServicesTests.Services
{
    [TestClass]
    public class ProductServiceTests
    {
        private readonly Mock<IProductRepository> _productRepository;
        private IProductService _service;
        public ProductServiceTests()
        {
            _productRepository = new Mock<IProductRepository>();
            _service = new ProductService(_productRepository.Object);
        }
    }
}
