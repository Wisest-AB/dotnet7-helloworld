var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "dotnet7 ftw!");

app.Run();
