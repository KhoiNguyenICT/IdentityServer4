using Google.Application.Configurations.Systems;
using Google.Common.Constants;
using Google.Model;
using Google.Service.Implementations;
using Google.Service.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using System.Net;
using System.Net.Http;
using System.Reflection;
using AutoMapper;
using Google.Application.Extensions;
using Google.Common.Extensions;
using Google.Service.Mappers;
using Microsoft.AspNetCore.Http.Features;

namespace Google.Application
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment env, IHostingEnvironment environment)
        {
            Configuration = configuration;
            _environment = environment;
        }

        private readonly IHostingEnvironment _environment;
        private readonly string _assemblyName = typeof(Startup).GetTypeInfo().Assembly.GetName().Name;
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<FormOptions>(x => x.ValueCountLimit = 2048);
            services.AddDbContext<AppDbContext>(options => options.UseNpgsql(Configuration.GetConnectionString(ConfigurationKeys.DefaultConnection), x => x.MigrationsAssembly(_assemblyName)));

            services.ConfigureIdentityService(Configuration, _environment);
            ConfigIoc(services);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v2", new Info { Title = "ICP APIs", Version = "2.0.0" });
            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
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
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseCors(policy => policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().AllowCredentials());
            app.UseImageResizer();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseIdentityServer();
            app.UseAuthentication();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v2/swagger.json", "ICP API V2");
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Authentication}/{action=Login}/{id?}");
            });
        }

        public void ConfigIoc(IServiceCollection services)
        {
            services.AddImageResizer();
            services.AddSingleton<HttpClient>();
            services.AddSingleton<WebClient>();
            services.AddScoped<AppInitializer>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IChannelService, ChannelService>();
            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<IPlaylistService, PlaylistService>();
            services.AddScoped<ITagService, TagService>();
            services.AddScoped<IVideoPlaylistService, VideoPlaylistService>();
            services.AddScoped<IVideoService, VideoService>();
            services.AddScoped<IAssetService, AssetService>();
            services.AddScoped<IAccountService, AccountService>();

            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<DtoMappingProfile>();
                cfg.IgnoreUnmapped();
            });
            services.AddSingleton(Mapper.Instance.RegisterMap());
        }
    }
}