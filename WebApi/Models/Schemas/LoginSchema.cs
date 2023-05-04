using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Schemas
{
    public class LoginSchema
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }


    }
}
