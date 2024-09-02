using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using StoreApp.Models;
//web uygulamsý inþaa edici
var builder = WebApplication.CreateBuilder(args);
//controller ve view larýn beraber kullanýlacaðýný belirttik
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<RepositoryContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"));
});

var app = builder.Build();
//Her þeye elle map edemeyiz bu kýsmý otomatik yapmamýz lazým
//app.MapGet("/", () => "Hello World!");
//app.MapGet("/btk", () => "BTK");

app.UseHttpsRedirection();
app.UseRouting();

app.MapControllerRoute(
    name:"default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
