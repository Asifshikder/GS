using GS.DATA.Entities;
using GS.DATA.Entities.Blog;
using GS.DATA.Entities.Catelog;
using GS.DATA.Entities.CMS;
using GS.DATA.Entities.CustomPort;
using GS.DATA.Entities.Delivery;
using GS.DATA.Entities.Shop;
using GS.DATA.Map;
using GS.DATA.Map.Blog;
using GS.DATA.Map.Catelog;
using GS.DATA.Map.CMS;
using GS.DATA.Map.CustomPort;
using GS.DATA.Map.Delivery;
using GS.DATA.Map.Shop;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace GS.REPO
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            #region catelog
            new ColorMap(modelBuilder.Entity<Color>());
            new BrandMap(modelBuilder.Entity<Brand>());
            new HeightMap(modelBuilder.Entity<Height>());
            new WidthMap(modelBuilder.Entity<Width>());
            new ModelMap(modelBuilder.Entity<Model>());
            new ProductTypeMap(modelBuilder.Entity<ProductType>());
            new SurfaceTypeMap(modelBuilder.Entity<SurfaceType>());
            new ProductMap(modelBuilder.Entity<Product>());
            new OperationStyleMap(modelBuilder.Entity<OperationStyle>());
            new ProductInstallMap(modelBuilder.Entity<ProductInstall>());
            #endregion
            #region anpassa
            new ColorPriceRoleMap(modelBuilder.Entity<ColorPriceRole>());
            new OperationStylePriceRoleMap(modelBuilder.Entity<OperationStylePriceRole>());
            new InstalationTypePriceRoleMap(modelBuilder.Entity<InstalationTypePriceRole>());
            new PatternPriceRoleMap(modelBuilder.Entity<PatternPriceRole>());
            new SizePriceRoleMap(modelBuilder.Entity<SizePriceRole>());
            new SurfaceLayerPriceRoleMap(modelBuilder.Entity<SurfaceLayerPriceRole>());
            new BaseGaragePortMap(modelBuilder.Entity<BaseGaragePort>());
            //new EmergencyLockPriceRoleMap(modelBuilder.Entity<EmergencyLockPriceRole>());
            //new ExtraRemoteControlPriceRoleMap(modelBuilder.Entity<ExtraRemoteControlPriceRole>());
            #endregion
            #region blog
            new BlogPostMap(modelBuilder.Entity<BlogPost>());
            new BlogCategoryMap(modelBuilder.Entity<BlogCategory>());
            #endregion
            #region delivery     
            new DeliveryFeeMap(modelBuilder.Entity<DeliveryFee>());
            new DeliveryZoneMap(modelBuilder.Entity<DeliveryZone>());
            new PostalCodeMap(modelBuilder.Entity<PostalCode>());
            #endregion

            #region store
            new StoreMap(modelBuilder.Entity<Store>());
            new StoreEmplpyeeMap(modelBuilder.Entity<StoreEmployee>());
            #endregion

            #region cms
            new AboutUsMap(modelBuilder.Entity<AboutUs>());
            new ContactMap(modelBuilder.Entity<Contact>());
            new ContactReasonMap(modelBuilder.Entity<ContactReason>());
            new InstallationMap(modelBuilder.Entity<Installation>());
            new MainPageMap(modelBuilder.Entity<MainPage>());
            new OldGateStatusMap(modelBuilder.Entity<OldGateStatus>());
            new OurServiceMap(modelBuilder.Entity<OurServices>());
            new PrivacyPolicyMap(modelBuilder.Entity<PrivacyPolicy>());
            new ReturnPolicyMap(modelBuilder.Entity<ReturnPolicy>());
            new TermsOfPurchaseMap(modelBuilder.Entity<TermsOfPurchase>());
            #endregion
        }
    }
}