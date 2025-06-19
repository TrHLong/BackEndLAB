using Microsoft.EntityFrameworkCore;
using Product.Models;

var builder = WebApplication.CreateBuilder(args);

// C?u h�nh DbContext v?i chu?i k?t n?i trong appsettings.json
builder.Services.AddDbContext<ProductDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Th�m c�c d?ch v? MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// C?u h�nh routing v� controller
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=Index}/{id?}");

app.Run();
