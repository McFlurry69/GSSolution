using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

//Services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

//Middleware
var app = builder.Build();

app.UseHttpsRedirection();
app.MapControllers();

app.Run();