using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using WebApi.Helpers;
using WebApi.Models.Entities;
using WebApi.Models.Schemas;
using WebApi.Repositories;

namespace WebApi.Services
{
    public class UserService
    {
        private readonly UserRepository _repository;
        private readonly JwtToken _jwt;
        public UserService(UserRepository repository, JwtToken jwt)
        {
            _repository = repository;
            _jwt = jwt;
        }
        public async Task<string> LoginAsync(LoginSchema schema)
        {
            UserEntity user = await _repository.GetAsync(x => x.Email == schema.Email);
            if (user == null)
                throw new Exception("Invalid email or password.");

            if (!PasswordManager.VerifyPassword(schema.Password, user.Hash))
                throw new Exception("Invalid email or password.");

            //jwt token later
            var claimsIdentity = new ClaimsIdentity(new Claim[]
            {
                new Claim("id", user.Id.ToString()),
                new Claim("email", user.Email),
                new Claim("name", user.FirstName)
            });
            
            if(schema.RememberMe == true)
                return _jwt.Generate(claimsIdentity, DateTime.Now.AddDays(90));

            return _jwt.Generate(claimsIdentity, DateTime.Now.AddHours(1));
        }
        public async Task<string> RegisterAsync(RegisterSchema schema)
        {
            UserEntity user = await _repository.GetAsync(x => x.Email == schema.Email);
            if (user != null)
                throw new Exception("Email already exists.");

            schema.Password = PasswordManager.GenerateHash(schema.Password);

            user = await _repository.AddAsync(schema);

            //jwt token later
            var claimsIdentity = new ClaimsIdentity(new Claim[]
            {
                new Claim("id", user.Id.ToString()),
                new Claim("email", user.Email),
                new Claim("name", user.FirstName)
            });
            
            return _jwt.Generate(claimsIdentity, DateTime.Now.AddHours(1));
        }
    }
}
