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
    internal class ServiceDescriptionEntityConfiguration : IEntityTypeConfiguration<ServiceDescriptionEntity>
    {
        public void Configure(EntityTypeBuilder<ServiceDescriptionEntity> builder)
        {
            builder
               .Property(s => s.Description)
               .HasMaxLength(2048);
        }
    }
}
