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
        // Token'da kontrol edilmesini istediðimiz deðerler..

        ValidateIssuer = true, // Issuer deðerinin kontrol edilmesini, eðer gönderilen Token'daki Issuer deðeri yanlýþsa hata vermesini saðlamak için burayý "true" yapýyoruz.

        ValidateAudience = true, // Audience deðerinin kontrol edilmesini saðlýyoruz.

        ValidateLifetime = true, // Expire süresinin kontrol edilmesini istersek, yani süresi dolmuþ Token'larýn çalýþmamasýný istersek "ValidateLifetime" deðerini "True" yapýyoruz. Eðer sýnýrsýz çalýþan bir Token oluþturmak istersek bu deðeri "False" yapabiliriz.

        ValidateIssuerSigningKey = true, // Oluþturacaðýmýz güvenlik anahtarýnýn kontrol edilip edilmeyeceðini bu seçenekle belirleriz.
        
        // Ardýndan bu alanlarýn "Default" deðerlerini belirleriz.
        ValidIssuer = builder.Configuration.GetSection("Jwt:Issuer").Value, // Bu deðer Token'ý oluþtururken verdiðimiz deðer ile (mutlaka) ayný olmalý.

        ValidAudience = builder.Configuration.GetSection("Jwt:Audience").Value, // 

        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration.GetSection("Jwt:SecretKey").Value ?? ""))
    };
});

// Middleware
var app = builder.Build();

// Proje 3 aþamadan oluþur.
// Development -> Test -> Production

// Swagger'ý sadece "Development" aþamasýnda göster diyor.
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