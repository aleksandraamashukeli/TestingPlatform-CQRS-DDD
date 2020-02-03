using AutoMapper;
using DataAccessLayer;
using DataAccessLayer.Models;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services.User.Commands;

namespace ApplicationUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration,IHostingEnvironment env)
        {
            Configuration = configuration;
            Environment = env;
        }

        public IConfiguration Configuration { get; }
        public IHostingEnvironment Environment { get;}

        public void ConfigureServices(IServiceCollection services)
        {
     
            services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DatabaseConn")));


            services.ConfigureApplicationCookie(confing =>
            {
                confing.Cookie.Name = "Identity.Cookies";
                confing.LoginPath = "/Account/Login/";
            });


            services.AddIdentity<User, IdentityRole>(config => 
            {
                config.Password.RequiredLength = 0;
                config.Password.RequireDigit = false;
                config.Password.RequireNonAlphanumeric = false;
                config.Password.RequireUppercase = false;
            })
                .AddEntityFrameworkStores<DatabaseContext>()
                .AddDefaultTokenProviders();


            services.AddMediatR(typeof(CreateUser).Assembly);
          

            services.AddScoped<IRepository<Test>, Repository<Test>>();
            services.AddScoped<IRepository<Question>, Repository<Question>>();
            services.AddScoped<IRepository<Answer>, Repository<Answer>>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddAutoMapper(typeof(Startup).Assembly, typeof(CreateUser).Assembly);
            services.AddMvc();
        }
        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
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
            app.UseCookiePolicy();

            app.UseAuthentication();
            
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
