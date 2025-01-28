using _07_CodeFirstDoktor.DAL.Concrete;
using _07_CodeFirstDoktor.DAL.Interfaces;
using _07_CodeFirstDoktor.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//middleware
builder.Services.AddDbContext<ProjeDbContext>(x => x.UseSqlServer("Server=DESKTOP-UKJPG3A; Database=Yzl5202-CodeFirst3;Trusted_Connection=true;MultipleActiveResultSets=true;TrustServerCertificate=True;"));

builder.Services.AddScoped<IDoktor, DoktorRepo>();//request bitinceye kadar yaþar
//AddSingleton: Uygulama çalýþtýðý sürece yaþar
//AddTransient: Her requestte yeni bir nesne oluþturur

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Doktor2}/{action=Listele}/{id?}");

app.Run();