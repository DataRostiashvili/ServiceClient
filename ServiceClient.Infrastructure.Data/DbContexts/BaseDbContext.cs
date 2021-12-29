using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClient.Infrastructure.Data.DbContexts
{

    public interface IBaseDbContext
    {

    }
    public class BaseDbContext : DbContext, IBaseDbContext
    {
       
    }
}
