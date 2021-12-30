using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceClient.Infrastructure.Data.Seed;
using ServiceClient.Infrastructure.Models.Entity;

namespace ServiceClient.Infrastructure.Data.DbContexts
{
    public class ApplicationDbContext : BaseDbContext
    {

        //public DbSet<ClientEntity> Clients { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<ServiceProviderEntity> ServiceProviders { get; set; }
        public DbSet<GroupEntity> Groups { get; set; }
        public DbSet<ReviewEntity> Reviews { get; set; }
        public DbSet<ServicePacketEntity> ServicePackets { get; set; }
        public DbSet<ServiceDescriptionEntity> ServiceDescriptions { get; set; }
        public DbSet<WeekSchdeuleEntity> WeekSchdeules { get; set; }


        protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.ApplySeedData();
        }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }


    }
}
