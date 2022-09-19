using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Infrastructure.Persistance.DBcontext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Persistance.IRepository;
using Infrastructure.Persistance.Repository;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace ElectronicSalesManagement
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

            //services.AddDbContext<EFContext>(options =>
            //    options.UseSqlServer(Configuration.GetConnectionString("Connect")));

            services.AddDbContext<EFContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("Connect_Tr")));

            services.AddMvc(option => option.EnableEndpointRouting = false); // config cho route
            //services.AddAutoMapper(typeof(AutoMapperProfile).Assembly); //Install-Package AutoMapper.Extensions.Microsoft.DependencyInjection -Version 8.1.0
            //add Install-Package Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation -Version 3.1.9
            services.AddRazorPages().AddRazorRuntimeCompilation();
            //tao moi lien ket AddScoped<> giua Interface va Repository
            services.AddScoped<IDetailOrderRepository, DetailOrderRepository>();
            services.AddScoped<IDistrictRepository, DistrictRepository>();
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProvinceRepository, ProvinceRepository>();
            services.AddScoped<IWardRepository, WardRepository>();
            services.AddScoped<ISaleRepository, SaleRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();

            services.AddSession(cfg => {                    // Đăng ký dịch vụ Session
                cfg.Cookie.Name = "BaConSoi";             // Đặt tên Session - tên này sử dụng ở Browser (Cookie)
                cfg.IdleTimeout = new TimeSpan(0, 120, 0);    // Thời gian tồn tại của Session
            });

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();
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


            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "{controller=Home}/{action=Index}/{id?}");
            //});

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseSession();
            app.UseAuthentication();
            app.UseCookiePolicy(); // new
            app.UseStaticFiles(); // new

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
