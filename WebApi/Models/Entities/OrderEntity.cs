using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models.Entities
{
    public class OrderEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }
        public UserEntity User { get; set; }

        [Required]
        public int PaymentDetailId { get; set; }


        [Required]
        public int AddressId { get; set; }
  

        [Required]
        public int PromoCodeId { get; set; }
        public PromoCodeEntity PromoCode { get; set; }

        public IEnumerable<OrderStatusEntity> OrderStatuses { get; set; }

        public IEnumerable<OrderProductEntity> OrderProducts { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal TotalPrice { get; set; }
    }
}
