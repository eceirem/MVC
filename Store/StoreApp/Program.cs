using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Contracts;
using Services;
using Services.Contracts;

//web uygulams� in�aa edici
var builder = WebApplication.CreateBuilder(args);
//controller ve view lar�n beraber kullan�laca��n� belirttik
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<RepositoryContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"),
        b=> b.MigrationsAssembly("StoreApp"));
});

builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

builder.Services.AddScoped<IServiceManager, ServiceManager>();
builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();


var app = builder.Build();

//statik dosyalar� kullanmak istiyorum
app.UseStaticFiles();
//Her �eye elle map edemeyiz bu k�sm� otomatik yapmam�z laz�m
//app.MapGet("/", () => "Hello World!");
//app.MapGet("/btk", () => "BTK");

app.UseHttpsRedirection();
app.UseRouting();

app.MapControllerRoute(
    name:"default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
