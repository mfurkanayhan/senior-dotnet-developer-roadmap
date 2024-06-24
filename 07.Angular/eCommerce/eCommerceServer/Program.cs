// IoC Container => Inversion Of Control

// Startup.cs
// Dependency Injection
using Microsoft.IdentityModel.Tokens;
using System.Reflection;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(configure =>
{
    configure.AddDefaultPolicy(policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthentication().AddJwtBearer(options =>
{
    options.TokenValidationParameters = new()
    {
        // Token'da kontrol edilmesini istedi�imiz de�erler..

        ValidateIssuer = true, // Issuer de�erinin kontrol edilmesini, e�er g�nderilen Token'daki Issuer de�eri yanl��sa hata vermesini sa�lamak i�in buray� "true" yap�yoruz.

        ValidateAudience = true, // Audience de�erinin kontrol edilmesini sa�l�yoruz.

        ValidateLifetime = true, // Expire s�resinin kontrol edilmesini istersek, yani s�resi dolmu� Token'lar�n �al��mamas�n� istersek "ValidateLifetime" de�erini "True" yap�yoruz. E�er s�n�rs�z �al��an bir Token olu�turmak istersek bu de�eri "False" yapabiliriz.

        ValidateIssuerSigningKey = true, // Olu�turaca��m�z g�venlik anahtar�n�n kontrol edilip edilmeyece�ini bu se�enekle belirleriz.
        
        // Ard�ndan bu alanlar�n "Default" de�erlerini belirleriz.
        ValidIssuer = builder.Configuration.GetSection("Jwt:Issuer").Value, // Bu de�er Token'� olu�tururken verdi�imiz de�er ile (mutlaka) ayn� olmal�.

        ValidAudience = builder.Configuration.GetSection("Jwt:Audience").Value, // 

        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration.GetSection("Jwt:SecretKey").Value ?? ""))
    };
});

// Middleware
var app = builder.Build();

// Proje 3 a�amadan olu�ur.
// Development -> Test -> Production

// Swagger'� sadece "Development" a�amas�nda g�ster diyor.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseSwagger();
app.UseSwaggerUI();

app.UseCors();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();