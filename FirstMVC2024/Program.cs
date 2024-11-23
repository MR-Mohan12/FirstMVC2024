using FirstMVC2024.Context;
using FirstMVC2024.Repository;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.AddScoped<IEmployeeRepositorycs, EmployeeRespository>();
builder.Services.AddScoped<IEmployeeRepositorycs, SqlEmployeeRepository>();
builder.Services.AddScoped<EmployeeDbContext, EmployeeDbContext>();

builder.Services.AddDbContext<EmployeeDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


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
    pattern: "{controller=EmployeeController1}/{action=Index}/{id?}");

app.Run();
