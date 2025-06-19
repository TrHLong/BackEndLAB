using Microsoft.EntityFrameworkCore;
using Product.Models;

var builder = WebApplication.CreateBuilder(args);

// C?u hình DbContext v?i chu?i k?t n?i trong appsettings.json
builder.Services.AddDbContext<ProductDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Thêm các d?ch v? MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// C?u hình routing và controller
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=Index}/{id?}");

app.Run();
