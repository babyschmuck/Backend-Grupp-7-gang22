using WebApi.Contexts;
using WebApi.Models.Entities;

namespace WebApi.Repositories
{
    public class UserRepository : Repository<UserEntity>
    {
        private readonly DataContext _context;
        public UserRepository(DataContext context) : base(context)
        { 
            _context = context;
        }

        
    }
}
