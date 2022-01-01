using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using ServiceClient.Infrastructure.Models.Api.Identity;
using ServiceClient.Infrastructure.Models.DTO;
using ServiceClient.Infrastructure.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClient.Infrastructure.Services
{
  
    public class TokenService : ITokenService
    {
        private readonly JWTConfig _jwtConfig;

        public TokenService(IOptions<JWTConfig> jwtConfig)
        {
            _jwtConfig = jwtConfig.Value;
        }

        public string BuildToken(UserDTO user)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, user.Name),
                new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString())
             };

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtConfig.Key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
            var tokenDescriptor = new JwtSecurityToken(_jwtConfig.Issuer, _jwtConfig.Audience, claims,
                expires: DateTime.Now.Add(TimeSpan.Parse(_jwtConfig.Expiration)), signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);
        }
    }
}
