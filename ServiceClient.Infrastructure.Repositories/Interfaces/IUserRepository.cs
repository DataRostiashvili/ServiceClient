using ServiceClient.Infrastructure.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClient.Infrastructure.Data.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task DeleteAsync(UserEntity user);
        IEnumerable<UserEntity> GetByPredicate(Func<UserEntity, bool> predicate);
        Task InsertAsync(UserEntity user);
        Task UpdateAsync(UserEntity user);
    }
}
