using MyService.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Enkel health-check
app.MapGet("/", () => Results.Ok("MyService.Api is running!"));

// Enkel endpoint som använder Calculator-service
app.MapGet("/add", (int a, int b) =>
{
    var result = Calculator.Add(a, b);
    return Results.Ok(result);
});

app.Run();

// Behövs ibland för integrationstester
public partial class Program { }
