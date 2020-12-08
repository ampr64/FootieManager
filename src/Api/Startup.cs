using Api.Configurations;
using Api.Filters;
using FluentValidation.AspNetCore;
using Infrastructure.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;

namespace Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddInfrastructure(Configuration);

            services.ConfigureApplicationServices();

            services.ConfigureMediatR();

            services.ConfigureMappings();

            services.ConfigureSwagger();

            services.ConfigureFluentValidations();

            services.AddHttpContextAccessor();

            services.AddControllers(options =>
                options.Filters.Add(new ApiExceptionFilterAttribute()))
                    .AddFluentValidation()
                    .AddNewtonsoftJson(opts =>
                    {
                        opts.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                    });

            services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
                app.ConfigureSwagger();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(
                opts => opts
                    .SetIsOriginAllowed(o => _ = true)
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                );

            app.UseAuthentication();

            app.UseIdentityServer();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
