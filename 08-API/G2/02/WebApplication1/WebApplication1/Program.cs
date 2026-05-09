
using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddSwaggerGen();
            builder.Services.AddControllers();

            builder.Services.AddDbContext<PointOfSaleContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("PointOfSaleConnection")));


            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecification",
                    builder => builder.WithOrigins("http://127.0.0.1:5500")
                    .AllowAnyMethod().AllowAnyHeader());
            });

            //builder.Services.AddScoped<ICategoryManager,CategoryService>();

            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseCors("AllowSpecification");
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
