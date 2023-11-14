using ILS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using ILS.Data;
using ILS.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<ILSdb>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("ILSdb")));
builder.Services.AddDbContext<ILSContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("ILSdb_Identity")));

builder.Services.AddDefaultIdentity<ILSUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddDefaultTokenProviders()
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ILSContext>();



// Add services to the container.
builder.Services.AddControllersWithViews();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();
