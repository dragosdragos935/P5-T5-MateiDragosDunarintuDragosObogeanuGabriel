using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Configure services
        builder.Services.AddRouting(); // Move service registration before Build()

        var app = builder.Build();

        // Serve the frontend files
        var frontEndDirectory = Path.Combine(Directory.GetCurrentDirectory(), "front-end");
        var welcomePagePath = Path.Combine(frontEndDirectory, "welcome_page.html");
        var cssFilePath = Path.Combine(frontEndDirectory, "styles.css");

        app.UseStaticFiles(new StaticFileOptions
        {
            FileProvider = new PhysicalFileProvider(frontEndDirectory),
            RequestPath = "/front-end" // Update the RequestPath to match the frontend path
        });

        app.MapGet("/", context =>
        {
            if (File.Exists(welcomePagePath))
            {
                var content = File.ReadAllText(welcomePagePath);
                // Ensure CSS file is linked in the HTML file
                content = content.Replace("</head>", $"<link rel=\"stylesheet\" type=\"text/css\" href=\"/front-end/styles.css\"></head>");
                return context.Response.WriteAsync(content);
            }
            else
            {
                return context.Response.WriteAsync("Welcome page not found.");
            }
        });

        // Define API endpoints
        app.MapGet("/weatherforecast", async context =>
        {
            // Your API logic here
            await context.Response.WriteAsync("Hello from API!");
        });

        // Start the web server
        app.Run(); // Make sure your application is configured to listen on the correct port
    }
}
