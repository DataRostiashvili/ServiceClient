using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClient.Infrastructure.Models.Api.Identity
{
    public record RegistrationRequest(
        string UserName,
        string PasswordHash,
        string Name,
        string Surname,
        string? Address);

}
