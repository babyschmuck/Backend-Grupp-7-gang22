using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models.Entities
{
    public class PromoCodeEntity
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int CompanyId { get; set; }
        public CompanyEntity Company { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal Discount { get; set; }

        [Required]
        public long ValidToUnix { get; set; }

        [Required]  
        public string Code { get; set; }

        public IEnumerable<UserPromoCodeEntity> UserPromoCodes { get; set; }
    }
}
