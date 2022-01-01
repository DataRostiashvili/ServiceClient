
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Identity.Web;
using ServiceClient.Infrastructure.Data.DbContexts;
using ServiceClient.Infrastructure.Models.Entity;
using Npgsql.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ServiceClient.Infrastructure.Models.Api.Identity;
using System.Reflection;
using Microsoft.AspNetCore.Diagnostics;
using ServiceClient.Infrastructure.Utils;
using ServiceClient.Api.Identity.ServiceCollection;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Identity", Version = "v1" });
});


builder.Services.AddApplicationVersioning();
builder.Services.Configure<JWTConfig>(builder.Configuration.GetSection("Jwt"));
builder.Services.AddJWTAuthentication(builder.Configuration);
builder.Services.AddApplicationCors();
builder.Services.AddApplicationMappings();
builder.Services.AddApplicationValidation();



builder.Services.AddDbContext<ApplicationDbContext>(opt =>
{
    opt.UseNpgsql(builder.Configuration.GetConnectionString("Postgres.Development"));
});


var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<AppExceptionHandlerMiddleware>();

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();



app.MapControllers();

app.Run();
