﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using ServiceClient.Infrastructure.Models.Api.Identity;
using System.Text;

namespace ServiceClient.Identity.Api.ServiceCollection
{
    public static class ServiceCollectionExtention
    {
        public static IServiceCollection AddJWTAuthentication(this IServiceCollection services, IConfiguration Configuration)
        {

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
            {
                opt.TokenValidationParameters = new()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = Configuration["Jwt:Issuer"],
                    ValidAudience =  Configuration["Jwt:Issuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
                };
            });

            return services;
        }
    }
}