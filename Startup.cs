using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace aplicatie
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            // Adaugă serviciile Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API Documentation", Version = "v1" });
            });
        }

        // Alte metode de configurare pot fi adăugate aici, cum ar fi Configure() pentru configurarea pipeline-ului de request-uri HTTP.
    }
}
