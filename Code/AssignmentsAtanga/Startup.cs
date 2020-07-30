using AssignmentsAtanga.Areas.Assignments.Models;
using AssignmentsAtanga.Areas.Identity.Data;
using AssignmentsAtanga.Areas.MovieList.Models;
using AssignmentsAtanga.Areas.Olympic.Models;
using AssignmentsAtanga.Areas.TicketSystem.Models;
using AssignmentsAtanga.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AssignmentsAtanga
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
            services.AddRazorPages();
            services.AddMemoryCache();
            services.AddSession();

            services.AddControllersWithViews();

            services.AddDbContext<MovieContext>(options => options.UseSqlServer(
                Configuration.GetConnectionString("MovieContext")));
            
            services.AddDbContext<StudentContext>(options => options.UseSqlServer(
               Configuration.GetConnectionString("StudentContext")));

            services.AddDbContext<CountryContext>(options => options.UseSqlServer(
               Configuration.GetConnectionString("CountryContext")));

            services.AddDbContext<TicketContext>(options => options.UseSqlServer(
               Configuration.GetConnectionString("TicketContext")));

            services.AddDbContext<AssignDbContext>(options => options.UseSqlServer(
               Configuration.GetConnectionString("AssignDbContextConnection")));

            //Indentification User
            services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<AssignDbContext>();


            services.AddRouting(options =>
            {
                options.LowercaseUrls = true;
                options.AppendTrailingSlash = true;
            });
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
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseSession();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();

                endpoints.MapControllers();

                endpoints.MapControllerRoute(
                   "areaRoute",
                   pattern: "{area:exists}/{controller=TicketSystem}/{action=Index}/{id}/{slug?}");


                endpoints.MapControllerRoute(
                    name: "custom",
                    pattern: "{area:exists}/{controller=Olympic}/{action=Index}/game/{activeGame}/cat/{activeCat}");

                endpoints.MapControllerRoute(
                   "areaRoute",
                   pattern: "{area:exists}/{controller=Olympic}/{action=Index}/{id}/{slug?}");
              

                endpoints.MapControllerRoute(
                   "areaRoute",
                   pattern: "{area:exists}/{controller=Assignments}/{action=Index}/{id}/{slug?}");

                endpoints.MapControllerRoute(
                   "areaRoute",
                   pattern: "{area:exists}/{controller=Reports}/{action=Index}/{id?}/{slug?}");

                endpoints.MapControllerRoute(
                   "areaRoute",
                   pattern: "{area:exists}/{controller=Users}/{action=Index}/{id?}/{slug?}");

                endpoints.MapControllerRoute(
                   "areaRoute",
                   pattern: "{area:exists}/{controller=Admin}/{action=Index}/{id?}/{slug?}");

                endpoints.MapControllerRoute(
                    "areaRoute",
                   pattern: "{area:exists}/{controller=MovieList}/{action=Index}/{id?}/{slug?}");
               
                endpoints.MapControllerRoute(
                  name: "default",
                  pattern: "{controller=Home}/{action=Index}/{id?}");

            });
        }
    }
}
