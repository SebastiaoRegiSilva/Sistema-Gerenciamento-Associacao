using Hort.Etec.Apm.Domain.Alunos;
using Hort.Etec.Apm.Domain.Armarios;
using Hort.Etec.Apm.Domain.Classes;
using Hort.Etec.Apm.Domain.Emails;
using Hort.Etec.Apm.Domain.Predios;
using Hort.Etec.Apm.Domain.Responsaveis;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Hort.Etec.Apm.Infra.Alunos;
using Hort.Etec.Apm.Infra.Armarios;
using Hort.Etec.Apm.Infra.Classes;
using Hort.Etec.Apm.Infra.Emails;
using Hort.Etec.Apm.Infra.Predios;
using Hort.Etec.Apm.Infra.Responsaveis;

namespace Hort.Etec.Apm.Api
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
            var mongoConString = Configuration.GetValue<string>("DB:Mongo:ConString");
            var mongoDatabase = Configuration.GetValue<string>("DB:Mongo:Database");

            var alunoRep = new AlunoRepository(mongoConString, mongoDatabase);
            var alunoService = new AlunoService(alunoRep);
            services.AddSingleton(alunoService);

            var classeRep = new ClasseRepository(mongoConString, mongoDatabase);
            var classeService = new ClasseService(classeRep);
            services.AddSingleton(classeService);

            var emailRep = new EmailRepository(mongoConString, mongoDatabase);
            var emailService = new EmailService(emailRep);
            services.AddSingleton(emailService);

            var predioRep = new PredioRepository(mongoConString, mongoDatabase);
            var predioService = new PredioService(predioRep);
            services.AddSingleton(predioService);

            var armarioRep = new ArmarioRepository(mongoConString, mongoDatabase);
            var armarioService = new ArmarioService(armarioRep, alunoService, predioService);
            services.AddSingleton(armarioService);

            var responsavelRep = new ResponsavelRepository(mongoConString, mongoDatabase);
            var responsavelService = new ResponsavelService(responsavelRep);
            services.AddSingleton(responsavelService);

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Hort.Etec.Apm", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Corrigir, pois está rodando como se fosse em produção.
            if (!env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                    options.RoutePrefix = string.Empty;
                });
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}