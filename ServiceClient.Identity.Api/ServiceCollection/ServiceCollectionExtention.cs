using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using ServiceClient.Infrastructure.Data.DbContexts;
using ServiceClient.Infrastructure.Mappings;
using ServiceClient.Infrastructure.Models.Api.Identity;
using ServiceClient.Infrastructure.Validation;
using ServiceClient.Infrastructure.Validation.API.Identity;
using System.Reflection;
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
                    ValidAudience = Configuration["Jwt:Issuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
                };
            });

            return services;
        }


        public static IServiceCollection AddApplicationMappings(this IServiceCollection services)
        {

            services.AddAutoMapper(typeof(UserMappings));

           

            return services;
        }
        public static IServiceCollection AddApplicationVersioning(this IServiceCollection services)
        {

            services.AddApiVersioning(opt =>
            {
                opt.AssumeDefaultVersionWhenUnspecified = true;
                opt.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
                opt.ReportApiVersions = true;
            });

            return services;
        }

        public static IServiceCollection AddApplicationValidation(this IServiceCollection services)
        {

            services.AddFluentValidation(conf => conf.RegisterValidatorsFromAssemblyContaining<RegistrationRequestValidator>());


            return services;
        }

        public static IServiceCollection AddApplicationCors(this IServiceCollection services)
        {

            services.AddCors(options =>
            {
                options.AddPolicy(
                  "CorsPolicy",
                  builder => builder
                  .AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader());
            });

            return services;
        }
    }


}
