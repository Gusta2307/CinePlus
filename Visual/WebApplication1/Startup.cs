using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
//using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Identity;
//using ProgServicesQueries;
//using MovieDataBase;
//using MediatR;
using System.Reflection;
using IdentityDataBase;
using IdentityDomain;
using IdentityServicesQueries;
//using ProgServiceProxies;
//using ProgServiceProxies.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserServiceEventHandler;
//using Microsoft.OpenApi.Models;
using ProgrammingServicesQueries;
using ProgrammingServiceProxies.Movie;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieServicesQueries;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace WebApplication1
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
            services.AddControllersWithViews();

            #region Startup Identity !OK!
            //DbContext
            services.AddDbContext<IdentityDataBase.ApplicationDbContext>(
             opts => opts.UseSqlite("Data Source=usersLogg.db", x => x.MigrationsHistoryTable("UserLogging._EFMigrationHistory")));

            //Event handlers
            services.AddMediatR(Assembly.Load("UserServiceEventHandler"));

            // Query services
            services.AddTransient<IUserQueryService, UserQueryService>();

            //Identity
            services.AddIdentity<User, IdentityRole>(options =>
            {
                options.User.RequireUniqueEmail = false;
            })
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();

            //Identity Configuration
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;
            }
            );

            #endregion

            #region Movie !OK!
            //DbContext
            services.AddDbContext<MovieDataBase.ApplicationDbContext>(
             opts => opts.UseSqlite("Data Source=movie.db", x => x.MigrationsHistoryTable("Movies._EFMigrationHistory")));

            ////API Controllers
            services.AddControllers();

            //Query Services
            services.AddTransient<IMovieQueryService, MovieQueryService>();

            //EventHandlers
            services.AddMediatR(Assembly.Load("MovieServiceEventHandler"));
            #endregion

            #region Programming


            #endregion

            //services.AddDbContext<ApplicationDbContext>(
            // opts => opts.UseSqlite("Data Source=C:\\Users\\Gustavo\\Desktop\\LAST!!!!!!\\ultimo\\Cine++\\Cine+Project\\src\\Services\\Identity\\IdentityApi\\usersLogg.db", x => x.MigrationsHistoryTable("UserLogging._EFMigrationHistory")));

            services.AddDbContext<ProgrammingDataBase.ApplicationDbContext>(
            opts => opts.UseSqlite("Data Source=C:\\Users\\Gustavo\\Desktop\\Ultimo\\ClassLibrary1\\src\\Services\\Programming\\ProgrammingApi\\programming.db", x => x.MigrationsHistoryTable("Programming._EFMigrationHistory")));

            //services.AddControllers();

            //Query Services
            //services.AddTransient<IUserQueryService, UserQueryService>();

            //Event Handler
            //services.AddMediatR(Assembly.Load("UserServiceEventHandler"));

            ////Identity
            //services.AddIdentity<User, IdentityRole>(options =>
            //{
            //    options.User.RequireUniqueEmail = false;
            //})
            //.AddEntityFrameworkStores<ApplicationDbContext>()
            //.AddDefaultTokenProviders();

            ////Identity Configuration
            //services.Configure<IdentityOptions>(options =>
            //{
            //    options.Password.RequireDigit = false;
            //    options.Password.RequireLowercase = false;
            //    options.Password.RequireNonAlphanumeric = false;
            //    options.Password.RequiredLength = 6;
            //    options.Password.RequiredUniqueChars = 1;
            //}
            //);

            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebApplication1", Version = "v1" });
            //});


            //Query Services
            services.AddTransient<ProgrammingServiceProxies.Movie.IMovieProxy, ProgrammingServiceProxies.Movie.MovieProxy>();
            services.AddTransient<IProgrammingQueryService, ProgrammingQueryService>();

            ////EventHandlers
            services.AddMediatR(Assembly.Load("ProgrammingServiceEventHandler"));

            ////ApiUrls
            services.Configure<ProgrammingServiceProxies.ApiUrls>(
                opts => Configuration.GetSection("ApiUrls").Bind(opts)
                );

            //Proxies
            services.AddHttpClient<IMovieProxy, MovieProxy>();

            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new OpenApiInfo { Title = "ProgApi", Version = "v1" });
            //});

            //        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            //.AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options => Configuration.Bind("JwtSettings", options))
            //.AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options => Configuration.Bind("CookieSettings", options));


            var key = Encoding.ASCII.GetBytes(Configuration.GetValue<string>("SecretKey"));

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            services.AddMvc();
            services.AddAuthentication();

        }
        
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
