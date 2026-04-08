using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
// Keep the app minimal: expose only the root endpoint. No Swagger or
// other middleware are registered to avoid adding package dependencies at
// this scaffold stage.
app.MapGet("/", () => Results.Ok(new { status = "ok" }));

app.Run();
