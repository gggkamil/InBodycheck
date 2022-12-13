using InBodycheck.Models;
using InBodycheck.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<BIllMangerContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("BillManagerDatabase")));
builder.Services.AddTransient<IBillRepository, BillRepository>();
var app = builder.Build();


app.UseHttpsRedirection();
app.UseStaticFiles();


app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Bill}/{action=Index}/{id?}");

app.Run();