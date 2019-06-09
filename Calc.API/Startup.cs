using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace Calc.API
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new Info
                {
                    Version = "V1.0",
                    Title = "Calcular Juros compostos",
                    Description = "API desenvolvida em APS.NET Core 2.2 com duas funcionalidade:\n\n" +
                    " * Endpoint /showmethecode: Retornar a URL do repositório da aplicação no GitHub.\n\n" +
                    " * Endpoint /calculajuros: Retornar o resultado de juros compostos aplicados ao valor inicial e a quantidade de meses informado, considerando a taxa fixa de 1% ao mês.",
                    Contact = new Contact
                    {
                        Name = "Ajala Oliveira",
                        Url = "https://www.linkedin.com/in/ajala-oliveira-85917442/"
                    },
                    License = new License
                    {
                        Name = "GitHub - Repository",
                        Url = "https://github.com/AjalaOliveira/Calc.API"
                    }
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();

            app.UseSwagger();
            app.UseSwaggerUI(s => 
            {
                s.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1.0");
            });
        }
    }
}
