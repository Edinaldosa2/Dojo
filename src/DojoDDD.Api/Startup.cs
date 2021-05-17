using DojoDDD.Api.DojoDDD.Domain;
using DojoDDD.Api.DojoDDD.Domain.Models.Clientes;
using DojoDDD.Api.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace DojoDDD.Api
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
            services.AddLogging();

            services.AddSingleton<DataStore>();
            //services.AddTransient<IClienteServico, ClienteServico>(); Criar o do serviço
            services.AddTransient<IClienteRepositorio, ClienteRepositorio>();
            services.AddTransient<IProdutoRepositorio, ProdutoRepositorio>();
            //services.AddTransient<IProdutoServico, ProdutoServico>(); Criar o do serviço
            services.AddTransient<IOrdemCompraServico, OrdemCompraServico>();
            services.AddTransient<IOrdemCompraRepositorio, OrdemCompraRepositorio>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddSwaggerGen();
            // Swagger adicionado para melhor visualização
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(x=> { x.SwaggerEndpoint("/swagger/v1/swagger.json", "Dojo API V1"); });
            // Swagger adicionado para melhor visualização             
        }
    }
}
