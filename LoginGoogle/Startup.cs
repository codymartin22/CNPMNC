using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Owin.Security.Google;
using Owin;
using Microsoft.Owin;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace LoginGoogle
{ }
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
        services.AddAuthentication(option =>
        {
            option.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            option.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            option.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
        }).AddFacebook(FacebookOptions =>
        {
            FacebookOptions.AppId = "4398183950223941";
            FacebookOptions.AppSecret = "2830e4531ed603c39c91e4b1ff8d230b";
        })
        //.AddGoogle(GoogleOptions =>
        //{
        //    GoogleOptions.ClientId = "964979486722-239v33obu42ahv39bk38ipdmu2bm2s7e.apps.googleusercontent.com";
        //    GoogleOptions.ClientSecret = "gD80sHyScTdc6udYUytP87p2";
        //})
        .AddCookie();
        services.AddControllersWithViews();
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseAuthentication();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

    }
}
