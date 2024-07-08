using AutoMapper;
using IzinModul.DataContext.Contracts;
using IzinModul.DataContext.DataContext;
using IzinModul.DataContext.Implementaion;
using IzinModulManagement.BusinessEngine.Contracts;
using IzinModulManagement.BusinessEngine.Implementaion;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using IzinModul.DataContext.DbModels;
using IzinModulCommon.ConstantModels;
using System.Security.Cryptography;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<IzinModulDataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("connection"),
    sqlOptions => sqlOptions.MigrationsAssembly("IzinTakipModul")));

//builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<IzinModulDataContext>();
//builder.Services.AddDefaultIdentity<Employee>().AddEntityFrameworkStores<IzinModulDataContext>();
builder.Services.AddAutoMapper(typeof(Mapper));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddAntiforgery(options => options.HeaderName = "X-CSRF-TOKEN");
// Register business engine services
builder.Services.AddScoped<IEmployeeLeaveTypeBusinessEngine, EmployeeLeaveTypeBusinessEngine>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddIdentity<Employee, IdentityRole>()
    .AddEntityFrameworkStores<IzinModulDataContext>()
    .AddDefaultTokenProviders();




builder.Services.AddSession();
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
app.UseSession();
app.UseHttpsRedirection();
app.UseStaticFiles();
void Configure(IApplicationBuilder app, IWebHostEnvironment env,
            UserManager<Employee> userManager, RoleManager<IdentityRole> roleManager)
{
    SeedData.Seed(userManager, roleManager);
}
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();
