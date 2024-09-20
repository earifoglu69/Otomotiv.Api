using Microsoft.EntityFrameworkCore;
using Otomotiv.Application;
using Otomotiv.Infrastructure.Context;
using Otomotiv.Api.Common.IOC;
using Otomotiv.Application.Extentions;
using Otomotiv.Api.Common.Settings;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
builder.Configuration.SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile($"appsettings.{environment}.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables();

builder.Services.Configure<ConnectionStrings>(builder.Configuration.GetRequiredSection(nameof(ConnectionStrings)));
builder.Services.Configure<TurkuazClientSetting>(builder.Configuration.GetRequiredSection(nameof(TurkuazClientSetting)));


// Add Identity
builder.Services.AddDbContext<OtomotivDbContext>(dbContextOptionsBuilder => dbContextOptionsBuilder.UseNpgsql(builder.Configuration.GetConnectionString("OtomotivConnection")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.UseIocLoader();
ServiceModule.Configure(builder.Services, builder.Configuration);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.ApplyMigrations();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
