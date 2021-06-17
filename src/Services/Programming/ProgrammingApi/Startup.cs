using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using ProgrammingDataBase;
using ProgrammingServiceProxies;
using ProgrammingServiceProxies.Movie;
using ProgrammingServicesQueries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ProgrammingApi
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
            //DbContext
            services.AddDbContext<ApplicationDbContext>(
             opts => opts.UseSqlite("Data Source=programming.db", x => x.MigrationsHistoryTable("Programming._EFMigrationHistory")));

            //API Controllers
            services.AddControllers();

            //Query Services
            services.AddTransient<IMovieProxy, MovieProxy>();
            services.AddTransient<IProgrammingQueryService, ProgrammingQueryService>();

            //EventHandlers
            services.AddMediatR(Assembly.Load("ProgrammingServiceEventHandler"));

            //ApiUrls
            //services.Configure<ApiUrls>(
            //    opts => Configuration.GetSection("ApiUrls").Bind(opts)
            //    );

            //Proxies
            services.AddHttpClient<IMovieProxy, MovieProxy>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ProgrammingApi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ProgrammingApi v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
