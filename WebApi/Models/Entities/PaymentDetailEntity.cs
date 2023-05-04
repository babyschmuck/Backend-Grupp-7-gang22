using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Entities
{
    public class PaymentDetailEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CardName { get; set; } = null!;
        [Required]
        public string CardNumber { get; set; } = null!;
        [Required]
        public string Cvv { get; set; } = null!;
        [Required]
        public string MmYy { get; set; } = null!;

        [Required]
        public int UserId { get; set; }
        public UserEntity User { get; set; }
    }
}
