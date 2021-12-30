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
            return new ClientEntity[]
            {
                new ClientEntity
                {
                    Name = "Data",
                    Surname = "Rostiashvili",
                    Address = "Manavi",
                    CreatedAt = DateTime.Now
                },
                new ClientEntity
                {
                    Name = "Friedrich",
                    Surname = "Nietzche",
                    Address = "German",
                    CreatedAt = DateTime.Now
                },
                new ClientEntity
                {
                    Name = "Jesus",
                    Surname = "Christ",
                    Address = "New Yourk",
                    CreatedAt = DateTime.Now
                }
            };
        }
    }
}
