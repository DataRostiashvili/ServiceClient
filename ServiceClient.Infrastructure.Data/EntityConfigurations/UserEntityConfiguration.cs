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
    internal class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder
                .Property(p => p.UserName)
                .HasMaxLength(32)
                .IsRequired();

            builder
                .Property(p => p.PasswordHash)
                .IsRequired();

            builder
               .Property(p => p.Name)
               .HasMaxLength(64)
               .IsRequired();

            builder
               .Property(p => p.Surname)
               .HasMaxLength(128)
               .IsRequired();

            builder
               .Property(p => p.IdNumber)
               .HasMaxLength(11);

            builder
               .Property(p => p.Address)
               .HasMaxLength(512);

            builder
               .Property(p => p.EmailAddress)
               .HasMaxLength(256)
               .IsRequired();

            builder
               .Property(p => p.PhoneNumber)
               .HasMaxLength(32);

        }
    }
}
