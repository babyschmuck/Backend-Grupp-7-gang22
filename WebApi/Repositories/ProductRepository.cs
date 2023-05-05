using WebApi.Contexts;
using WebApi.Models.Entities;

namespace WebApi.Repositories
{
    public class ProductRepository : Repository<ProductEntity>
    {
        public ProductRepository(DataContext context) : base(context)
        {
        }
    }
}
