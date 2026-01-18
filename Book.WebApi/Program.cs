using Book.WebApi;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Test");
builder.Services.AddDbContext<DataBaseContext>(o => o.UseNpgsql(connectionString));
var app = builder.Build();

app.MapGet("/", async (DataBaseContext db) => await db.Books.ToListAsync());

await app.RunAsync();