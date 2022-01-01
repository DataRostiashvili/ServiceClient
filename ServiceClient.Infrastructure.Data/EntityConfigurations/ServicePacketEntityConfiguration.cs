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
    internal class ServicePacketEntityConfiguration : IEntityTypeConfiguration<ServicePacketEntity>
    {
        public void Configure(EntityTypeBuilder<ServicePacketEntity> builder)
        {
            builder
               .HasOne(p => p.ServiceDescription)
               .WithOne(d => d.ServicePack)
               .HasForeignKey<ServiceDescriptionEntity>(d => d.ServicePackId);

            builder
               .HasOne(p => p.Payment)
               .WithOne(p => p.ServicePack)
               .HasForeignKey<PaymentEntity>(p => p.ServicePackId);
        }
    }
}
