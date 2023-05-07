using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using WebApi.Models.Dtos;

namespace WebApi.Models.Entities
{
    public class ProductEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int Rating { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }


        [Required]
        public int CompanyId { get; set; }
        public CompanyEntity Company { get; set; }

        public IEnumerable<ReviewEntity> Reviews { get; set; }

        public IEnumerable<OrderProductEntity> OrderProducts { get; set; }

        public static implicit operator Product(ProductEntity entity)
        {
            return new Product
            {
                Id = entity.Id,
                Description = entity.Description,
                Name = entity.Name,
                Price = entity.Price,
                Rating = entity.Rating,
            };
        }
    }
}
