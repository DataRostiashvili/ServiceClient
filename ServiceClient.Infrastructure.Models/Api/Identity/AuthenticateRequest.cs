using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClient.Infrastructure.Models.Api.Identity
{
    public record AuthenticateRequest(string UserName, string PasswordHash);

}
