using FlowerShop.Models;
using FlowerShop.Models.Interface;
using FlowerShop.Models.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSession();
builder.Services.AddDbContext<DatabaseContext>(
    options =>
    {
        options.UseLazyLoadingProxies().UseSqlServer(builder.Configuration["ConnectionStrings:DemoEFCore"]);
    }
);
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IAccountService, AccountService>();

var app = builder.Build();


app.UseSession();
app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}");
app.Run();
