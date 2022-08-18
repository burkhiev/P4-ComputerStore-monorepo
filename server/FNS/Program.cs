using FNS.Domain.Repositories;
using FNS.Infrastructure;
using FNS.Infrastructure.Repositories;
using FNS.Services.Abstractions;
using FNS.Services.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContextPool<AppDbContext>(options =>
{
    string connString = builder.Configuration.GetConnectionString("Npgsql");
    options.UseNpgsql(connString, opt => opt.UseNodaTime());
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IRootRepository, RootRepository>();
builder.Services.AddTransient<IRootService, RootService>();

var app = builder.Build();

if(app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
