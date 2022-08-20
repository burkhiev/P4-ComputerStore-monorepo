using FNS.Domain.Repositories;
using FNS.Infrastructure;
using FNS.Infrastructure.Repositories;
using FNS.Presentation.Middlewares;
using FNS.Services.Abstractions;
using FNS.Services.Services;
using Microsoft.EntityFrameworkCore;
using FNS.Presentation.Utilities.ExtensionMethods;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.DictionaryKeyPolicy = JsonNamingPolicy.CamelCase;
        options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
    });

builder.Services.AddDbContextPool<AppDbContext>(options =>
{
    string connString = builder.Configuration.GetConnectionString("Npgsql");
    options.UseNpgsql(connString, opt => opt.UseNodaTime());
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IRootRepository, RootRepository>();
builder.Services.AddTransient<IRootService, RootService>();
builder.Services.AddSingleton<ErrorHandlingMiddleware>();

var app = builder.Build();

if(app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseGlobalErrorHandler();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
