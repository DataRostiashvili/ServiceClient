using ServiceClient.Infrastructure.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceClient.Infrastructure.Data.DbContexts;
using ServiceClient.Infrastructure.Models.Entity;

namespace ServiceClient.Infrastructure.Data.Repositories
{
    public class UserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(
            ApplicationDbContext context
            )
        {
            _context = context;
        }
        public IEnumerable<UserEntity> GetByPredicate(Func<UserEntity, bool> predicate)
        {
            return _context.Users.Where(predicate);
        }
    }
}
