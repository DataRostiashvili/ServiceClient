using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ServiceClient.Infrastructure.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClient.Infrastructure.Data.EntityConfigurations
{
    internal class ClientGroupEntityConfiguration : IEntityTypeConfiguration<ClientGroupEntity>
    {
        public void Configure(EntityTypeBuilder<ClientGroupEntity> modelBuilder)
        {
            modelBuilder
                .HasOne(cg => cg.Client)
                .WithMany(c => c.ClientGroups)
                .HasForeignKey(cg => cg.ClientId);

            modelBuilder
               .HasOne(cg => cg.Group)
               .WithMany(g => g.ClientGroups)
               .HasForeignKey(cg => cg.GroupId);
        }
    }
}
