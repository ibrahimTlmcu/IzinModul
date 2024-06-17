using AutoMapper;
using IzinModul.DataContext.Contracts;
using IzinModul.DataContext.DataContext;
using IzinModul.DataContext.Implementaion;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(typeof(Mapper));
builder.Services.AddScoped<IEmployeeLeaveAlllocationRepository, EmployeeLeaveAlllocationRepository>();
builder.Services.AddScoped<IEmployeeLeaveRequesRepository, EmployeeLeaveRequestRepository>();
builder.Services.AddScoped<IEmployeeLeaveTypeRepository, EmployeeLeaveTypeRepository>();

builder.Services.AddDbContext<IzinModulDataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("connection"),
    sqlOptions => sqlOptions.MigrationsAssembly("IzinTakipModul")));

// Add services to the container.
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();


app.Run();
