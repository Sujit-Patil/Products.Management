using ProductsManagement.Data.DBContext;
using ProductsManagement.Data.Interfaces;
using ProductsManagement.Data.Models;

namespace ProductsManagement.Data.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext Context) : base(Context)
        {
        }
    }
}
