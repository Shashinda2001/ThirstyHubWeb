using System.Runtime.CompilerServices;
using ThirstyHubWeb.Data.Interfaces;
using ThirstyHubWeb.Data.Mocks;
using Microsoft.Extensions.Configuration;
using ThirstyHubWeb.Data;
using Microsoft.EntityFrameworkCore;
using ThirstyHubWeb.Data.Repositories;
using ThirstyHubWeb.Data.Models;


var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options => 
options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection") ));


//builder.Services.AddTransient<ICategoryRepository,MockCategoryRepository>();
//builder.Services.AddTransient<IDrinkRepository, MockDrinkRepository>();

builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<IDrinkRepository, DrinkRepository>();


var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbInitializer = scope.ServiceProvider.GetRequiredService<DbInitializer>();
    DbInitializer.Seed(app);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//DbInitializer.Seed(app);

app.Run();
