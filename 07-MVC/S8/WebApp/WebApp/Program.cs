using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApp.Context;
using WebApp.Managers;
using WebApp.Services;

namespace WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddSession(s => s.IdleTimeout = TimeSpan.FromMinutes(20));

            builder.Services.AddDbContext<SchoolDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("LocalConnection")));

            builder.Services.AddIdentity<IdentityUser,IdentityRole>().AddEntityFrameworkStores<SchoolDbContext>();

            builder.Services.AddScoped<IDepartmentManager,DepartmentRepository>();
            builder.Services.AddScoped<IStudentManager, StudentRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseSession();

            ////Logging
            //app.Use(async (contex, next) =>
            //{
            //    Console.WriteLine($"Request path => {contex.Request.Path}");
            //    await next();
            //});
            ////Block Users 
            //app.Use(async (contex, next) =>
            //{
            //    if (contex.Request.Query["role"] != "admin")
            //    {
            //        await contex.Response.WriteAsync("Access Denied...");
            //        return;
            //    }
            //    await next();
            //});

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
