using ServiceClient.Infrastructure.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClient.Infrastructure.Services.Interfaces
{
    public interface ITokenService
    {
        string BuildToken(UserDTO user);
    }
}
