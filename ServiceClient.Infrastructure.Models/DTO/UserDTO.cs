using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClient.Infrastructure.Models.DTO
{
    
    public record UserDTO(Guid UserId, string Name, string Surname, string? StateIdNumber, string? Address);
}
