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
    internal class PaymentEntityConfiguration : IEntityTypeConfiguration<PaymentEntity>
    {
        public void Configure(EntityTypeBuilder<PaymentEntity> builder)
        {
            builder
               .Property(p => p.Currency)
               .HasConversion<string>();
            builder
               .Property(p => p.PaymentType)
               .HasConversion<string>();

        }
    }
}
