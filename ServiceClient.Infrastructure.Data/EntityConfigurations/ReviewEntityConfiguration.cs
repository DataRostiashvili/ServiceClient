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
}
