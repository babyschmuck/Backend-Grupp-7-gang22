using System.ComponentModel.DataAnnotations;
using System.Net;

namespace WebApi.Models.Entities
{
    public class UserEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;

        [Required]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        public string Hash { get; set; } = null!;

        [Required]
        public string Otp { get; set; } = "000000";

        public IEnumerable<AddressEntity> Addresses { get; set; }
        public IEnumerable<PaymentDetailEntity> PaymentDetails { get; set; }
        public IEnumerable<ReviewEntity> Reviews { get; set; }
        public IEnumerable<OrderEntity> Orders { get; set; }

        public IEnumerable<UserPromoCodeEntity> UserPromoCodes { get; set; }
    }
}
