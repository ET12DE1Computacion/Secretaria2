using DominioSecretaria.ADO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace BackEndSecretaria
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

            //Configuracion de archivo de configuracion
            string connectionstring = Configuration.GetConnectionString("secretaria");
            
            services.AddDbContext<Contexto>(option => option.UseMySQL(connectionstring, b => b.MigrationsAssembly("BackEndSecretaria")));
            
            services.AddScoped<DbContext, Contexto>();

            //Configuracion Swagger
            services.AddSwaggerGen(option =>
            {
                option.SwaggerDoc("v1", new Info
                {
                    Title = "Secretaría",
                    Version = "V1.0",
                    Description = "API"
                });

                //Configuracion Token (Autorizacion)
                //option.AddSecurityDefinition("JWT", new ApiKeyScheme { In = "header", Description = "Please enter JWT", Name = "Token", Type = "apiKey" });

                //option.AddSecurityRequirement(new Dictionary<string, IEnumerable<string>> {
                //    { "JWT", Enumerable.Empty<string>() },
                //});
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            //Configuracion Swagger            
            app.UseSwagger();

            app.UseSwaggerUI(option =>
            {
                option.SwaggerEndpoint("/swagger/v1/swagger.json", "Secretaría v1.0");
            });

            app.UseMvc();
        }
    }
}
