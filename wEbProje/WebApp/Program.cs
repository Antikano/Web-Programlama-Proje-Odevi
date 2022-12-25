using DataAccess.Concrete.EntityFramework;
using Entities.Identity;
using Microsoft.AspNetCore.Authentication.Cookies;
using WebApp.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();



builder.Services.AddDbContext<KitapContext>();
builder.Services.AddIdentity<AppUser, AppRole>(_ => {
    _.Password.RequiredLength = 5;
    _.Password.RequireNonAlphanumeric = false; //Alfanumerik zorunluluğunu kaldırıyoruz.
    _.Password.RequireLowercase = true; //Küçük harf zorunluluğunu kaldırıyoruz.
    _.Password.RequireUppercase = true; //Büyük harf zorunluluğunu kaldırıyoruz.
    _.Password.RequireDigit = false; //0-9 arası sayısal karakter zorunluluğunu kaldırıyoruz.
}
).AddErrorDescriber<CustomIdentityErrorDescriber>().AddEntityFrameworkStores<KitapContext>();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Login/Index";
    options.LogoutPath= "/Login/Index";    
});

//builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
//{
//    options.LoginPath= "/Login/Index";
//});


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

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
