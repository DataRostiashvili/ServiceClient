
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Identity.Web;
using ServiceClient.Infrastructure.Data.DbContexts;
using ServiceClient.Infrastructure.Models.Entity;
using Npgsql.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ServiceClient.Identity.Api.ServiceCollection;
using ServiceClient.Infrastructure.Models.Api.Identity;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApiVersioning(opt =>
{
    opt.AssumeDefaultVersionWhenUnspecified = true;
    opt.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
    opt.ReportApiVersions = true;
});

builder.Services.Configure<JWTConfig>(builder.Configuration.GetSection("Jwt"));
builder.Services.AddJWTAuthentication(builder.Configuration);
builder.Services.AddAutoMapper(Assembly.Load("ServiceClient.Infrastructe.Mappings"));


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

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
