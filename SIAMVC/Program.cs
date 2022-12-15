using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using SIAMVC.Models;
var connectionString = "server=localhost;port=3306;user=root;password=admin;database=dbsia";
var serverVersion = ServerVersion.AutoDetect(connectionString);
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<RegistroReportes>(x => x.UseMySql(connectionString, serverVersion));
var app = builder.Build();

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
