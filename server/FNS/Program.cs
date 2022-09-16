using FNS.Domain.Repositories;
using FNS.ContextsInfrastructure.Repositories;
using FNS.Services.Abstractions;
using FNS.Services.Services;
using Microsoft.EntityFrameworkCore;
using FNS.Presentation.Utilities.ExtensionMethods;
using System.Text.Json;
using FNS.Contexts.Infrastructure;
using FNS.Domain.Models.Identity;
using FNS.Presentation.Utilities.Converters;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using FNS.Presentation.Utilities.Auth;
using Microsoft.OpenApi.Models;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContextPool<AppDbContext>(options =>
{
    string connString = builder.Configuration.GetConnectionString("Npgsql");
    options.UseNpgsql(connString, opt => opt.UseNodaTime());
});


builder.Services.AddIdentity<User, Role>(options =>
{
    options.User.RequireUniqueEmail = true;

    options.Password.RequiredLength = 5;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireDigit = false;
})
    .AddEntityFrameworkStores<AppDbContext>();


builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(options =>
    {
        options.RequireHttpsMetadata = false;

        options.TokenValidationParameters = new TokenValidationParameters
        {            
            ValidIssuer = JwtAuthenticateOptions.Issuer,
            ValidateIssuer = true,
            ValidAudience = JwtAuthenticateOptions.Audience,
            ValidateAudience = true,
            IssuerSigningKey = JwtAuthenticateOptions.SymmetricSecurityKey,
            ValidateIssuerSigningKey = true,
            ValidateLifetime = true,
            ClockSkew = TimeSpan.Zero,
        };
    });

builder.Services.AddAuthorization();


builder.Services.AddTransient<IRootRepository, RootRepository>();
builder.Services.AddTransient<IRootService, RootService>();
builder.Services.AddGlobalErrorHandler();

builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Bearer Authorization", // ???
        Description = "JWT Authorization header using the Bearer scheme.\nExample: \"Authorization: Bearer {token}\"", // should
        Scheme = JwtBearerDefaults.AuthenticationScheme, // required
        In = ParameterLocation.Header, // required
        Type = SecuritySchemeType.Http // required SecuritySchemeType.Http
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Id = "Bearer",
                    Type = ReferenceType.SecurityScheme,
                }
            },
            new List<string>()
        }
    });
});


builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.DictionaryKeyPolicy = JsonNamingPolicy.CamelCase;
        options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
        options.JsonSerializerOptions.Converters.Add(new NodaTimeInstantConverter());
    });

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
