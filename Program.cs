using GTW_App.Data;
using GTW_App.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

// Add services to the container.
services.AddControllersWithViews();

#region Adding the DB Context
services.AddDbContext<GtwDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));
#endregion

var app = builder.Build();

#region Database Seeding
if (app.Environment.IsDevelopment())
{
    using (var scope = app.Services.CreateScope())
    {
        var scropedServices = scope.ServiceProvider;

        SeedData.Initialize(scropedServices);
    }
}
#endregion Database Seeding


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

app.Run();
