using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Entities
{
    public class AddressEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = null!;
        [Required]
        public string FirstName { get; set; } = null!;
        [Required]
        public string LastName { get; set; } = null!;
        [Required]
        public string Street { get; set; } = null!;
        [Required]
        public string PostalCode { get; set; } = null!;
        [Required]
        public string City { get; set; } = null!;

        [Required]
        public int UserId { get; set; }
        public UserEntity User { get; set; }
    }
}
