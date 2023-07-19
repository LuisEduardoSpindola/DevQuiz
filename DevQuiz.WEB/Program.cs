using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using DevQuiz.WEB.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using NuGet.LibraryModel;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DbContextConnection") ?? throw new InvalidOperationException("Connection string 'DbContextConnection' not found.");

builder.Services.AddDbContext<DbContextIdentity>(options => options.UseSqlServer(connectionString));
builder.Services.AddScoped<RoleManager<IdentityRole>>(); // Adicione esta linha para registrar o RoleManager<IdentityRole>
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
.AddEntityFrameworkStores<DbContextIdentity>();

// Add services to the container.
builder.Services.AddControllersWithViews();
// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.MapRazorPages();

app.Run();
