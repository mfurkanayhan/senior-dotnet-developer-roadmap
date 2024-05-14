using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// MongoDb yapýlandýrmasý için 

var mongoSettings = builder.Configuration.GetSection("MongoDBSettings");
builder.Services.AddSingleton<IMongoClient>(serviceProvider =>
{
    return new MongoClient(mongoSettings["ConnectionString"]);
});

builder.Services.AddScoped(serviceProvider =>
{
    var client = serviceProvider.GetRequiredService<IMongoClient>();
    var databaseName = mongoSettings["tododb"];
    return client.GetDatabase(databaseName);
});

builder.Services.AddCors(configure =>
{
    configure.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

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
