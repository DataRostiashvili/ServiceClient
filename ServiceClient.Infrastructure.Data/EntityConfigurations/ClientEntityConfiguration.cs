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
    


   

   
  

    
   

}
