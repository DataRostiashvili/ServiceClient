using Microsoft.EntityFrameworkCore;
using ServiceClient.Infrastructure.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClient.Infrastructure.Data.Seed
{
    internal static class ApplySeedData
    {
        public static void ApplyIdentity(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientEntity>(b =>
            {
                b.HasData(SeedData.GetCleints());
            });
        }
    }
}
