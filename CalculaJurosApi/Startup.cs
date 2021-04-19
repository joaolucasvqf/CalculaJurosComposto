using CalculaJurosApi.Interfaces;
using CalculaJurosApi.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace CalculaJurosApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(opt =>
            {
                opt.SwaggerDoc("V1", new OpenApiInfo
                {
                    Title = "Calcula Juros API",
                    Description = "Faz um cálculo em memória, de juros compostos",
                    Version = "V1"
                });
            });

            services.AddTransient<ICalculaJuros, CalculaJuros>();
            services.AddTransient<IShowMeTheCode, ShowMeTheCode>();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(opt =>
                {
                    opt.SwaggerEndpoint("/swagger/V1/swagger.json", "Swagger Calcula Juros API");
                    opt.RoutePrefix = "docs";
                });
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
