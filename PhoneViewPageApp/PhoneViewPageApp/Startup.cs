using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.Webpack;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PhoneViewPageApp.Models;

namespace PhoneViewPageApp
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            string connectionString = "Data Source=DESKTOP-6PVPTNF\\SQLEXPRESS;Initial Catalog=PhoneDB;Integrated Security=True;";
            
            services.AddDbContext<PhoneContext>(options => options.UseSqlServer(connectionString));

            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
                {
                    HotModuleReplacement = true
                });
            }

            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseMvc();
        }
    }
}