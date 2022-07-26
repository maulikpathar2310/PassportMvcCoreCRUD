using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PassportMvcCoreCRUD.Areas.Identity.Data;
using System.Configuration;
using MailKit.Security;
using System.Net.Mail;
using PassportMvcCoreCRUD.Services;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("PassportMvcCoreCRUDContextConnection") ?? throw new InvalidOperationException("Connection string 'PassportMvcCoreCRUDContextConnection' not found.");

builder.Services.AddDbContext<PassportMvcCoreCRUDContext>(options =>
    options.UseSqlServer(connectionString));;

builder.Services.AddIdentity<PassportMvcCoreCRUDUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<PassportMvcCoreCRUDContext>().AddDefaultTokenProviders();

//builder.Services.AddDefaultIdentity<PassportMvcCoreCRUDUser>()
//                .AddRoles<IdentityRole>().AddEntityFrameworkStores<PassportMvcCoreCRUDContext>();

//builder.Services.AddSingleton<IUserEmailStore, EmailSender>();

//builder.Services.Configure<MailSettings>(Configuration.GetSection("MailSettings"));
builder.Services.AddTransient<IEmailSender, EmailSender>();

builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

//builder.Services.AddTransient<IEmailSender, YourEmailSender>();
//builder.Services.AddTransient<IEmailSender, YourSmsSender>();

builder.Services.AddAuthorization(options => {
    options.AddPolicy("readpolicy",
        builder => builder.RequireRole("Admin","User"));
    options.AddPolicy("writepolicy",
        builder => builder.RequireRole("Admin"));
});

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSession(options =>
    { 
        options.IdleTimeout = TimeSpan.FromMinutes(2); 
    });
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
app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();
