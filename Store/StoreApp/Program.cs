using Microsoft.AspNetCore.Builder;
//web uygulams� in�aa edici
var builder = WebApplication.CreateBuilder(args);
//controller ve view lar�n beraber kullan�laca��n� belirttik
builder.Services.AddControllersWithViews();

var app = builder.Build();
//Her �eye elle map edemeyiz bu k�sm� otomatik yapmam�z laz�m
//app.MapGet("/", () => "Hello World!");
//app.MapGet("/btk", () => "BTK");

app.UseHttpsRedirection();
app.UseRouting();

app.MapControllerRoute(
    name:"default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
