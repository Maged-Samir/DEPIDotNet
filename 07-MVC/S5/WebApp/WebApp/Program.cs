using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApp.Context;
using WebApp.Managers;
using WebApp.Models;
using WebApp.Repos;

namespace WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });


            //builder.Services.AddDbContext<SchoolDbContext>(options => options.UseSqlServer("Server=.;Database=SchoolV3;Integrated Security =True;Encrypt =False"));

            builder.Services.AddDbContext<SchoolDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("LocalConnection")));

            builder.Services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<SchoolDbContext>();

            builder.Services.AddScoped<IDepartmentManager, DepartmentRepository>();
            builder.Services.AddScoped<IStudentmManager,StudentRepository>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            
            app.UseSession();

            app.Use(async (context, next) =>
            {
                Console.WriteLine($"Our Request Path:{context.Request.Path}");
                await next();
            });

            app.Use(async (context, next) =>
            {
                if (context.Request.Query["name"] == "admin")
                {
                   await context.Response.WriteAsync("Access Denied");
                    return;
                }
                await next();
            });

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
