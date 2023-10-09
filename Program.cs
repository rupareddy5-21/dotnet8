var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World, DOTNET|8.0 on Linux App Services! #Github Actions");

app.Run();
