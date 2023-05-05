using System.ComponentModel.DataAnnotations;
using WebApi.Models.Entities;

namespace WebApi.Models.Schemas
{
    public class ProductSchema
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public decimal Price { get; set; }

        public int CompanyId { get; set; }


        public static implicit operator ProductEntity(ProductSchema schema)
        {
            return new ProductEntity
            {
                Name = schema.Name,
                Description = schema.Description,
                Rating = schema.Rating,
                Price = schema.Price,
                CompanyId = schema.CompanyId,
                
            };
        }
    }
}
