using WebApi.Helpers;
using WebApi.Models.Entities;
using WebApi.Models.Schemas;
using WebApi.Repositories;

namespace WebApi.Services
{
    public class UserService
    {
        private readonly UserRepository _repository;
        public UserService(UserRepository repository) 
        { 
            _repository  = repository;
        }
        public async Task<string> LoginAsync(LoginSchema schema)
        {
            UserEntity user = await _repository.GetAsync(x => x.Email == schema.Email);
            if (user == null)
                throw new Exception("Invalid email or password.");

            if (!PasswordManager.VerifyPassword(schema.Password, user.Hash))
                throw new Exception("Invalid email or password.");

            //jwt token later
            return "";
        }
        public async Task<string> RegisterAsync(RegisterSchema schema)
        {
            UserEntity user = await _repository.GetAsync(x => x.Email == schema.Email);
            if (user != null)
                throw new Exception("Email already exists.");

            schema.Password = PasswordManager.GenerateHash(schema.Password);

            await _repository.AddAsync(schema);
            
            //jwt token later
            return "";
        }
    }
}
