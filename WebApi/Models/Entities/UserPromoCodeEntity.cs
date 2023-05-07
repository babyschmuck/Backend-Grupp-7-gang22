using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using WebApi.Models.Dtos;

namespace WebApi.Models.Entities
{
    [PrimaryKey(nameof(UserId), nameof(PromoCodeId))]
    public class UserPromoCodeEntity
    {
        public int UserId { get; set; }
        public UserEntity User { get; set; }

        public int PromoCodeId { get; set; }
        public PromoCodeEntity PromoCode { get; set; }

        public bool Used { get; set; } = false;
    }
}
