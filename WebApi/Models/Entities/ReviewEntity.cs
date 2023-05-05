using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Entities
{
    public class ReviewEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Comment { get; set; } = null!;

        [Required]
        public int Rating { get; set; }


        [Required]
        public int ProductId { get; set; }
        public ProductEntity Product { get; set; }

        [Required]
        public int UserId { get; set; }
        public UserEntity User { get; set; }

    }
}
