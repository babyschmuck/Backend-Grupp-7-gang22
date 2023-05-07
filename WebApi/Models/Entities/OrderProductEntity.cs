using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Entities
{
    public class OrderProductEntity
    {
        public int ProductId { get; set; }
        public ProductEntity Product { get; set; }

        public int OrderId { get;set; }
        public OrderEntity Order { get; set; }

        public int Amount { get; set; }
    }
}
