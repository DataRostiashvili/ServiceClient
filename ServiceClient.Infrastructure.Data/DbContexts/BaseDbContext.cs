using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ServiceClient.Infrastructure.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClient.Infrastructure.Data.DbContexts
{

    
    public class BaseDbContext : IdentityDbContext<UserEntity, RoleEntity, Guid>
    {
        public BaseDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
