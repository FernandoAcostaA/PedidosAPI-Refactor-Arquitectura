var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "CI Pipeline OK - Pedidos API Refactor");

app.Run();
