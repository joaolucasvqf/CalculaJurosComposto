using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using TaxaJurosApi.Interfaces;
using TaxaJurosApi.Models;

namespace TaxaJurosApi
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
                    Title = "Taxa Juros API",
                    Description = "Faz um cálculo em memória, de juros compostos",
                    Version = "V1"
                });
            });
            services.AddTransient<ITaxaJuros, TaxaJuros>();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(opt =>
                {
                    opt.SwaggerEndpoint("/swagger/V1/swagger.json", "Swagger Taxa Juros API");
                    opt.RoutePrefix = "docsTaxaJurosApi";
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
