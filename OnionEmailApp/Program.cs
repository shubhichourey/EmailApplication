using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using OnionEmailApp.Application.Interfaces;
using OnionEmailApp.Application.Services;
using OnionEmailApp.Domain.Interfaces;
using OnionEmailApp.Infrastructure.Persistence;
using OnionEmailApp.Infrastructure.Repositories;
using OnionEmailApp.Infrastructure.Services;



var builder = WebApplication.CreateBuilder(args);

// ✅ Load Configuration
var configuration = builder.Configuration;

// ✅ Add Database Context (SQL Server)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));


// ✅ Register Application Services
builder.Services.AddScoped<IEmailService, EmailService>();



// ✅ Register Infrastructure Services
builder.Services.AddScoped<IEmailRepository, EmailRepository>(); // Email Repository
builder.Services.AddScoped<IEmailSender, OnionEmailApp.Infrastructure.Services.EmailSender>();



// ✅ Add Controllers and Views
builder.Services.AddControllersWithViews();

var app = builder.Build();

// ✅ Configure the HTTP Request Pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

// ✅ Set Default Route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
