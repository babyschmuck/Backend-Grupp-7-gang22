using System.ComponentModel.DataAnnotations;

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
        public decimal Price { get; set; }


        [Required]
        public int CompanyId { get; set; }
        public CompanyEntity Company { get; set; }

        public IEnumerable<ReviewEntity> Reviews { get; set; }
    }
}
