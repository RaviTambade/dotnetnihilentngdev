var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();
//Cors enabling
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder => builder.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader());
});

var app = builder.Build();

//Request Processing Logic

//rest API  with HTTP Get Request using minimal APIs
app.MapGet("/hello", () =>
{
    return "Hello World!";
});

app.MapGet("/api/products", () =>
{
    return new[]
    {
        new { Id = 1, Name = "Gerbera", Price = 9.99 },
        new { Id = 2, Name = "Rose", Price = 19.99 },
        new { Id = 3, Name = "Tulip", Price = 29.99 }
    };
});

app.Run();