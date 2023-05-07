using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models.Entities
{
    public class OrderStatusEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public long EstTimeUnix { get; set; }

        [ForeignKey(nameof(OrderStatusTypeId))]
        public int OrderStatusTypeId { get; set; }
        public OrderStatusTypeEntity OrderStatusType { get; set; }

        [Required]
        public int OrderId { get; set; }
        public OrderEntity Order { get; set; }
    }
}
