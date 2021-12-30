using ServiceClient.Infrastructure.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceClient.Infrastructure.Data.DbContexts;
using ServiceClient.Infrastructure.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace ServiceClient.Infrastructure.Data.Repositories
{
    public class UserRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<UserEntity> _users;
        public UserRepository(
            ApplicationDbContext context
            )
        {
            _context = context;
            _users = _context.Users;
        }
        public IEnumerable<UserEntity> GetByPredicate(Func<UserEntity, bool> predicate)
        {
            return _users.Where(predicate);
        }

        public async Task InsertAsync(UserEntity user)
        {
           await _users.AddAsync(user);
           await  _context.SaveChangesAsync();
        }
    }
}
