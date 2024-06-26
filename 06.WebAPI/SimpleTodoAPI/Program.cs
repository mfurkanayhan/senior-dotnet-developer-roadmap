// This is where we register services and manage Dependency Injection.
var builder = WebApplication.CreateBuilder(args);

// CORS settings....
builder.Services.AddCors(cfr =>
{
    cfr.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyMethod().AllowAnyOrigin().AllowAnyHeader();
    });
    //cfr.AddPolicy("Deneme1", policy =>
    //{
    //    policy.AllowAnyMethod().AllowAnyOrigin().AllowAnyHeader();
    //});
    //cfr.AddPolicy("Deneme2", policy =>
    //{
    //    policy.AllowAnyMethod().AllowAnyOrigin().AllowAnyHeader();
    //});
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Middleware
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
