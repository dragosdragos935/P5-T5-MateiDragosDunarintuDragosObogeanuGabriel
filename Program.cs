using aplicatie.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.IO;

namespace aplicatie
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Adaugă serviciile în container.
            ConfigureServices(builder.Services, builder.Configuration);

            WebApplication app = builder.Build();

            // Configurează pipeline-ul de request-uri HTTP.
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Documentation v1");
                });
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            // Adăugăm un handler pentru ruta care va servi fișierul welcome_page.html
            app.MapGet("/", async context =>
            {
                var file = Path.Combine(app.Environment.ContentRootPath, "wwwroot", "front-end", "welcome_page.html");
                if (File.Exists(file))
                {
                    await context.Response.SendFileAsync(file);
                }
                else
                {
                    context.Response.StatusCode = 404;
                    await context.Response.WriteAsync("Pagina nu a fost găsită.\n" +
                                                      "Dacă vezi această pagină, este posibil ca fișierul 'welcome_page.html' să lipsească sau să fie denumit greșit.\n" +
                                                      "Asigură-te că fișierul 'welcome_page.html' există în directorul 'wwwroot/front-end' al aplicației tale.");
                }
            });

            app.Run();
        }

        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            // Adaugă serviciile necesare în container
            services.AddControllersWithViews();
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IUserRepository, UserRepository>();

            // Adaugă serviciile Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API Documentation", Version = "v1" });
            });

            // Alte servicii necesare pot fi adăugate aici
        }

    }
}
