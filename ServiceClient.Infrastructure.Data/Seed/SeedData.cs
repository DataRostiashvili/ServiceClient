using ServiceClient.Infrastructure.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClient.Infrastructure.Data.Seed
{
    internal static class SeedData
    {
        internal static IEnumerable<ClientEntity> GetCleints()
        {
            return Enumerable.Empty<ClientEntity>();
        }
    }
}
