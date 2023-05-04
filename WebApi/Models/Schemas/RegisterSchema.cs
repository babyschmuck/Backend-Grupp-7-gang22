using System.ComponentModel.DataAnnotations;
using WebApi.Models.Entities;

namespace WebApi.Models.Schemas
{
    public class RegisterSchema
    {
        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;

        [Required]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        public string Password { get; set; } = null!;

        public static implicit operator UserEntity(RegisterSchema schema)
        {
            return new UserEntity()
            {
                FirstName = schema.FirstName,
                LastName = schema.LastName,
                Email = schema.Email,
                PhoneNumber = schema.PhoneNumber,
                Hash = schema.Password
            };
        }
    }
}
