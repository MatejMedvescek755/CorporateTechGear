using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;

namespace CorporateTechGear
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<web.Data.ShopContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("ShopContext")));
            
            services.AddCors(options =>{ options.AddPolicy("ReactPolicy", builder =>
            {
                builder.WithOrigins("http://localhost:7000")
                       .AllowAnyHeader()
                       .AllowAnyMethod();
            });
    });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors("ReactPolicy");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

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

            // Set Home view as the default page
            app.Use(async (context, next) =>
            {
                if (context.Request.Path == "/")
                {
                    context.Request.Path = "/Home/Index";
                }
                await next();
            });
        }
    }
}
