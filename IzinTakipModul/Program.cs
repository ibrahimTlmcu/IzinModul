using AutoMapper;
using IzinModul.DataContext.Contracts;
using IzinModul.DataContext.DataContext;
using IzinModul.DataContext.Implementaion;
using IzinModulManagement.BusinessEngine.Contracts;
using IzinModulManagement.BusinessEngine.Implementaion;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<IzinModulDataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("connection"),
    sqlOptions => sqlOptions.MigrationsAssembly("IzinTakipModul")));

builder.Services.AddAutoMapper(typeof(Mapper));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Register business engine services
builder.Services.AddScoped<IEmployeeLeaveTypeBusinessEngine, EmployeeLeaveTypeBusinessEngine>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

// Add Razor Pages with runtime compilation
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

// Add controllers with views
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
    endpoints.MapRazorPages();
});

app.Run();
