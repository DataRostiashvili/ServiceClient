using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceClient.Infrastructure.Models.Entity;

namespace ServiceClient.Infrastructure.Data.EntityConfigurations
{
    internal class ClientEntityConfiguration : IEntityTypeConfiguration<ClientEntity>
    {
        public void Configure(EntityTypeBuilder<ClientEntity> builder)
        {

        }
    }


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
               .WithMany(g=> g.ClientGroups)
               .HasForeignKey(cg => cg.GroupId);
        }
    }

    internal class ReviewEntityConfiguration : IEntityTypeConfiguration<ReviewEntity>
    {
        public void Configure(EntityTypeBuilder<ReviewEntity> builder)
        {
            builder
                .Property(r => r.Review)
                .HasMaxLength(1024)
                .IsRequired();


        }
    }
    internal class ServiceDescriptionEntityConfiguration : IEntityTypeConfiguration<ServiceDescriptionEntity>
    {
        public void Configure(EntityTypeBuilder<ServiceDescriptionEntity> builder)
        {
            builder
               .Property(s => s.Description)
               .HasMaxLength(2048);
        }
    }

    internal class ServicePacketEntityConfiguration : IEntityTypeConfiguration<ServicePacketEntity>
    {
        public void Configure(EntityTypeBuilder<ServicePacketEntity> builder)
        {
            builder
               .HasOne(p => p.ServiceDescription)
               .WithOne(d => d.ServicePack);
            builder
               .HasOne(p => p.Payment)
               .WithOne(p=> p.ServicePack);
        }
    }
    internal class PaymentEntityConfiguration : IEntityTypeConfiguration<PaymentEntity>
    {
        public void Configure(EntityTypeBuilder<PaymentEntity> builder)
        {
            builder
               .HasOne(p => p.ServiceDescription)
               .WithOne(d => d.ServicePack);
            builder
               .HasOne(p => p.Payment)
               .WithOne(p => p.ServicePack);

            builder
               .Property(p => p.Currency)
               .HasConversion<string>();
            builder
               .Property(p => p.PaymentType)
               .HasConversion<string>();

        }
    }

}
