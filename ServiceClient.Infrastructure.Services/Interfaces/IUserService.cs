using ServiceClient.Infrastructure.Models.Api.Identity;
using ServiceClient.Infrastructure.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClient.Infrastructure.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserDTO?> AuthenticateAsync(AuthenticateRequest request);
        Task DeleteAsync(UserDeleteRequest request);
        Task<UserDTO?> GetUserAsync(Guid userId);
        Task<UserDTO?> GetUserAsync(string userName);
        Task Register(RegistrationRequest request);
        Task UpdateAsync(UserUpdateRequest request);
    }
}
