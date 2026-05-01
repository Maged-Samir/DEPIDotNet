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
            builder.Services.AddSession();

            builder.Services.AddDbContext<SchoolDbContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("SchoolDbConnection")));

            builder.Services.AddIdentity<IdentityUser,IdentityRole>()
            .AddEntityFrameworkStores<SchoolDbContext>()
            .AddDefaultTokenProviders();

            builder.Services.AddScoped<IDepartmentManager,DepartmentRepository>();
            builder.Services.AddScoped<IStudentManager, StudentRepository>();


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

            app.UseAuthorization();

            app.MapStaticAssets();

            app.UseSession();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
