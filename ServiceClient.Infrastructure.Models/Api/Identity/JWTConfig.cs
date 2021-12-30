using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClient.Infrastructure.Models.Api.Identity
{

    public record JWTConfig(string Key, string Issuer, string Audience, string Expiration);
    
}
