using ExploreCalifornia.Data;
using ExploreCalifornia.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ExploreCalifornia
{
    public class Startup
    {
        private readonly IConfiguration configuration;   

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Services
            services.AddTransient<FormattingService>();
            services.AddSingleton<TourService>();

            services.AddMvc();

            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<IdentityDBContext>();

            //Database
            services.AddDbContext<ExploreDBContext>(options => options.UseSqlServer(configuration.GetValue<String>("DefaultConnection")));
            services.AddDbContext<IdentityDBContext>(options => options.UseSqlServer(configuration.GetValue<String>("IdentityConnection")));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseExceptionHandler("/error.html");

            if (env.IsDevelopment()){app.UseDeveloperExceptionPage();}

            app.UseStatusCodePages();
            app.UseAuthentication();
            app.UseHttpsRedirection();

            app.UseMvc(routes =>
            {
                routes.MapRoute("Default", "{controller=Home}/{action=Index}/{id:int?}");

            });

            app.UseFileServer();
        }
    }
}


//Added spceials service, added specials enum
//added entities