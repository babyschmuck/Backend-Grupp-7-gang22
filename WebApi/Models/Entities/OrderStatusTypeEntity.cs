using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Entities
{
    public class OrderStatusTypeEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;
    }
}
