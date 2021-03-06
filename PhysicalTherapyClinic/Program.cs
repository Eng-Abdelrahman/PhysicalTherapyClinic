using Microsoft.EntityFrameworkCore;
using PhysicalTherapyClinic.Domain;
using PhysicalTherapyClinic.Services;
using PhysicalTherapyClinic.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContextPool<PTDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("PTCConnStr")));

builder.Services.AddScoped(typeof(IClientServicesService), typeof(ClientServicesService));
builder.Services.AddScoped(typeof(IDropDownListService), typeof(DropDownListService));

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
