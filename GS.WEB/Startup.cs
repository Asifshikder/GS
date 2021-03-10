using GS.DATA.Entities;
using GS.DATA.Entities.Shop;
using GS.REPO;
using GS.SERVICE.Implementation.Blog;
using GS.SERVICE.Implementation.Catelog;
using GS.SERVICE.Implementation.CMS;
using GS.SERVICE.Implementation.CustomPort;
using GS.SERVICE.Interface.Blog;
using GS.SERVICE.Interface.Catelog;
using GS.SERVICE.Interface.CMS;
using GS.SERVICE.Interface.CustomPort;
using GS.SERVICE.Interface.Shop;
using GS.WEB.Models.Handler;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GS.WEB
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
            services.AddDbContext<AppDbContext>(option =>
            {
                option.UseSqlServer(Configuration.GetConnectionString("MSSqlConnection"));
                option.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });
            services.AddIdentity<ApplicationUser, IdentityRole>(
           options =>
           {
               options.Password.RequireDigit = false;
               options.Password.RequiredLength = 6;
               options.Password.RequireLowercase = false;
               options.Password.RequireUppercase = false;
               options.Password.RequireNonAlphanumeric = false;
           }).AddEntityFrameworkStores<AppDbContext>()
           .AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(
                options =>
                {
                    options.LoginPath = new PathString("/Account/Login");
                    options.AccessDeniedPath = new PathString("/Account/AccessDenied");
                    options.LogoutPath = new PathString("/Account/Logout");
                });
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            #region custom port
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddSingleton<IFileHandler, FileHandler>();
            //services.AddTransient<IAccessoriesWindowsPriceRoleService, AccessoriesWindowsPriceRoleService>();
            services.AddTransient<IColorPriceRoleService, ColorPriceRoleService>();
            //services.AddTransient<IHandleLockPriceRoleService, HandleLockPriceRoleService>();
            services.AddTransient<IInstalationTypePriceRoleService, InstalationTypePriceRoleService>();
            services.AddTransient<IOperationStylePriceRoleService, OperationStylePriceRoleService>();
            services.AddTransient<IPatternPriceRoleService, PatternPriceRoleService>();
            services.AddTransient<ISizePriceRoleService, SizePriceRoleService>();
            services.AddTransient<ISurfaceLayerPriceRoleService, SurfaceLayerPriceRoleService>();
            services.AddTransient<IBaseGaragePortService, BaseGaragePortService>();
            //services.AddTransient<IEmergencyLockPriceRoleService, EmergencyLockPriceRoleService>();
            //services.AddTransient<IExtraRemoteControlPriceRoleService, ExtraRemoteControlPriceRoleService>();
            //services.AddTransient<INUmberOfWindowsPriceRoleService, NUmberOfWindowsPriceRoleService>();
            //services.AddTransient<IOldGateRemovePriceRoleService, OldGateRemovePriceRoleService>();
            #endregion

            #region catelog
            services.AddTransient<IColorService, ColorService>();
            services.AddTransient<IProductTypeService, ProductTypeService>();
            services.AddTransient<IModelService, ModelService>();
            services.AddTransient<IOperationStyleService, OperationStyleService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<ISurfaceTypeService, SurfaceTypeService>();
            #endregion

            #region blog
            services.AddTransient<IBlogCategoryService, BlogCategoryService>();
            services.AddTransient<IBlogPostService, BlogPostService>();
            #endregion

            #region delivery
            services.AddTransient<IDeliveryZoneService, DeliveryZoneService>();
            services.AddTransient<IPostalCodeService, PostalCodeService>();
            services.AddTransient<IDeliveryFeeService, DeliveryFeeService>();

            #endregion

            #region Shop
            services.AddTransient<IStoreService, GS.SERVICE.Implementation.Shop.StoreService>();
            services.AddTransient<IStoreEmployeeService, GS.SERVICE.Implementation.Shop.StoreEmployeeService>();

            #endregion

            #region CMS

            services.AddTransient<IAboutUsService, AboutUsService>();
            services.AddTransient<IContactReasonService, ContactReasonService>();
            services.AddTransient<IContactService, ContactService>();
            services.AddTransient<IInstallationService, InstallationService>();
            services.AddTransient<IMainPageService, MainPageService>();
            services.AddTransient<IOldGateStatusService, OldGateStatusService>();
            services.AddTransient<IOurServicesService, OurServicesService>();
            services.AddTransient<IPrivacyPolicyService, PrivacyPolicyService>();
            services.AddTransient<IReturnPolicyService, ReturnPolicyService>();
            services.AddTransient<ITermsOfPurchaseService, TermsOfPurchaseService>();

            #endregion

            services.AddMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(10);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;

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
            app.UseSession();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                        name: "Manage",
                        areaName: "Manage",
                        pattern: "Manage/{controller=Home}/{action=Index}/{id?}"
                        );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");



            });
        }
    }
}
