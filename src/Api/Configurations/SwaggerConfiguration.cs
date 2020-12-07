using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Api.Configurations
{
    public static class SwaggerConfiguration
    {
        public static IServiceCollection ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(config =>
            {
                config.SwaggerDoc("v1", new OpenApiInfo
                { 
                    Title = "FootieManager App",
                    Version = "v1",
                    Description = "Demo .NET Core restful API implementing CQRS and Clean Architecture."
                });
            });
            services.AddSwaggerGenNewtonsoftSupport();

            return services;
        }

        public static void ConfigureSwagger(this IApplicationBuilder app)
        {
            app.UseSwagger();

            app.UseSwaggerUI(config =>
            {
                config.SwaggerEndpoint("/swagger/v1/swagger.json", "FootieManager App V1");
                config.RoutePrefix = string.Empty;
            });
        }
    }
}
