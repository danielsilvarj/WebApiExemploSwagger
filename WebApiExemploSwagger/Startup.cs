using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using WebApiExemploSwagger.Data;
using Swashbuckle.AspNetCore.Swagger;
using WebApiExemploSwagger.Models;
using WebApiExemploSwagger.Response;
using AutoMapper;

namespace WebApiExemploSwagger
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

            services.AddDbContext<WebApiExemploSwaggerContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("WebApiExemploSwaggerContext")));


            #region Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new Info
                    {
                        Title = "Api Exemplo com Swagger no CORE",
                        Version ="v1",
                        Description = "Exemplo de API REST criada no ASP.NET CORE",
                        Contact = new Contact
                        {
                            Name ="Daniel Silva",
                            Url = "https://github.com/danielsilvarj"
                        }
                    });
            });
            #endregion

            #region AutoMapper
            var configAutoMapper = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Produto, ProdutoCreateResponse>();
            });
            IMapper mapper = configAutoMapper.CreateMapper();
            services.AddSingleton(mapper);
            #endregion

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
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Exemplo");
            });
        }
    }
}
