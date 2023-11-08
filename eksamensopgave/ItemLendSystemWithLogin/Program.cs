using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ItemLendSystemWithLogin.Data;
using ItemLendSystemWithLogin.Areas.Identity.Data;
using ItemLendSystemWithLogin.Models;
using Microsoft.Extensions.Configuration;




var builder = WebApplication.CreateBuilder(args);
var connectionStringForLoginData = builder.Configuration.GetConnectionString("ItemLendSystemWithLoginDBContextConnection") ?? throw new InvalidOperationException("Connection string 'ItemLendSystemWithLoginDBContextConnection' not found.");
var connectionStringForItemLendSystem = builder.Configuration.GetConnectionString("ItemLendSystemwithLogin_systemDB") ?? throw new InvalidOperationException("Connection string 'ItemLendSystemwithLogin_systemDB' not found.");

builder.Services.AddDbContext<ItemLendSystemWithLoginDBContext>(options => options.UseSqlServer(connectionStringForLoginData));
builder.Services.AddDbContext<ItemLendSystemwithLogin_systemDB>(opt => opt.UseSqlServer(connectionStringForItemLendSystem));

builder.Services.AddDefaultIdentity<ItemLendSystemWithLoginUser>(options => options.SignIn.RequireConfirmedAccount = false)
   .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ItemLendSystemWithLoginDBContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireUppercase = false;
});

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

using (var scope = app.Services.CreateScope())
{
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    var roles = new[] { "Admin", "Owner", "Borrower" };
    foreach (var role in roles)
    {
        if (!await roleManager.RoleExistsAsync(role))
            await roleManager.CreateAsync(new IdentityRole(role));
    }
}


using (var scope = app.Services.CreateScope())
{
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ItemLendSystemWithLoginUser>>();
    
    string email = "admin@admin.com";
    string password = "Test123!!";
    if (await userManager.FindByEmailAsync(email) == null)

    {
        var user = new ItemLendSystemWithLoginUser();
        user.UserName = email;
        user.Email = email;
     
        await userManager.CreateAsync(user, password);
        await userManager.AddToRoleAsync(user, "Admin");
    }
}


app.MapRazorPages();

app.Run();