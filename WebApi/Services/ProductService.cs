using WebApi.Models.Dtos;
using WebApi.Models.Entities;
using WebApi.Models.Schemas;
using WebApi.Repositories;

namespace WebApi.Services
{
    public class ProductService
    {
        private readonly ProductRepository _repo;

        public ProductService(ProductRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<ProductEntity>> GetAllProducts()
        {
            var productList = await _repo.GetAllAsync();
            return productList;
        }

        public async Task<Product> CreateProduct(ProductSchema schema)
        {
            var entity = await _repo.AddAsync(schema);
            return entity;
        }
    }
}
