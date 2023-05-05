using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Entities
{
    public class CompanyEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }


        public IEnumerable<ProductEntity> Products { get; set; }
    }
}
