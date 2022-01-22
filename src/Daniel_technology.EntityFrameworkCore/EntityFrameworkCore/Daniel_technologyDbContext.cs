using Daniel_technology.Models;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Daniel_technology.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class Daniel_technologyDbContext :
    AbpDbContext<Daniel_technologyDbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    #region Entities from the modules

    /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityDbContext and ITenantManagementDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    //Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }

    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    #endregion

    #region 自定义
    public DbSet<AccountDetails> AccountDetails { get; set; }
    public DbSet<WarehouseManagement> WarehouseManagements { get; set; }
    public DbSet<Warehouse> Warehouses { get; set; }
    public DbSet<UserStatistics> UserStatistics { get; set; }
    public DbSet<UserRoleModel> UserRoleModels { get; set; }
    public DbSet<UserModel> UserModels { get; set; }
    public DbSet<TransactionType> TransactionTypes { get; set; }
    public DbSet<TransactionManagementModel> TransactionManagementModels { get; set; }
    public DbSet<TransactionDetail> TransactionDetails { get; set; }
    public DbSet<TransactionClassification> TransactionClassifications { get; set; }

    public DbSet<TradingInformation> TradingInformation { get; set; }
    public DbSet<Statistics> Statistics { get; set; }
    public DbSet<RoleModel> RoleModels { get; set; }
    public DbSet<RoleMenuModel> RoleMenuModels { get; set; }
    public DbSet<RegisterSourceModel> RegisterSourceModels { get; set; }

    public DbSet<PayType> PayTypes { get; set; }
    public DbSet<MerchantsRoleModel> MerchantsRoleModels { get; set; }
    public DbSet<MerchantsInformationModel> MerchantsInformationModels { get; set; }
    public DbSet<MerchantsAddresModel> MerchantsAddresModels { get; set; }
    public DbSet<Merchant_Goods> Merchant_Goods { get; set; }

    public DbSet<MenuModel> MenuModels { get; set; }
    public DbSet<MemberModel> MemberModels { get; set; }

    public DbSet<MemberInformationModel> MemberInformationModels { get; set; }
    public DbSet<ManagementModel> ManagementModels { get; set; }

    public DbSet<Equipuse> Equipuses { get; set; }
    public DbSet<Equipspecification> Equipspecifications { get; set; }

    public DbSet<EquipInfos> EquipInfos { get; set; }
    public DbSet<Consumption> Consumptions { get; set; }
    public DbSet<ConfigurationModel> ConfigurationModels { get; set; }
    public DbSet<ClosingDetail> ClosingDetails { get; set; }
    public DbSet<BusinessManagementModel> BusinessManagementModels { get; set; }
    public DbSet<AddressModel> AddressModels { get; set; }
    #endregion

    public Daniel_technologyDbContext(DbContextOptions<Daniel_technologyDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        #region 自定义
        builder.Entity<AccountDetails>(b =>
        {
            b.ToTable("tb_accountdetails");
        });

        builder.Entity<WarehouseManagement>(b =>
        {
            b.ToTable("tb_warehouseManagements");
        });

        builder.Entity<Warehouse>(b =>
        {
            b.ToTable("tb_warehouses");
        });

        builder.Entity<UserStatistics>(b =>
        {
            b.ToTable("tb_userStatistics");
        });

        builder.Entity<UserRoleModel>(b =>
        {
            b.ToTable("tb_userRoleModels");
        });

        builder.Entity<UserModel>(b =>
        {
            b.ToTable("tb_userModels");
        });

        builder.Entity<TransactionType>(b =>
        {
            b.ToTable("tb_transactionTypes");
        });

        builder.Entity<TransactionManagementModel>(b =>
        {
            b.ToTable("tb_transactionManagementModels");
        });

        builder.Entity<TransactionDetail>(b =>
        {
            b.ToTable("tb_transactionDetails");
        });

        builder.Entity<TransactionClassification>(b =>
        {
            b.ToTable("tb_transactionClassifications");
        });


        builder.Entity<TradingInformation>(b =>
        {
            b.ToTable("tb_tradingInformation");
        });

        builder.Entity<Statistics>(b =>
        {
            b.ToTable("tb_statistics");
        });

        builder.Entity<RoleModel>(b =>
        {
            b.ToTable("tb_roleModels");
        });

        builder.Entity<RoleMenuModel>(b =>
        {
            b.ToTable("tb_roleMenuModels");
        });

        builder.Entity<RegisterSourceModel>(b =>
        {
            b.ToTable("tb_registerSourceModels");
        });

        builder.Entity<PayType>(b =>
        {
            b.ToTable("tb_payTypes");
        });

        builder.Entity<MerchantsRoleModel>(b =>
        {
            b.ToTable("tb_merchantsRoleModels");
        });

        builder.Entity<MerchantsInformationModel>(b =>
        {
            b.ToTable("tb_merchantsInformationModels");
        });

        builder.Entity<MerchantsAddresModel>(b =>
        {
            b.ToTable("tb_ merchantsAddresModels");
        });

        builder.Entity<Merchant_Goods>(b =>
        {
            b.ToTable("tb_merchant_Goods");
        });

        builder.Entity<MenuModel>(b =>
        {
            b.ToTable("tb_menuModels");
        });

        builder.Entity<MemberModel>(b =>
        {
            b.ToTable("tb_memberModels");
        });

        builder.Entity<MemberInformationModel>(b =>
        {
            b.ToTable("tb_memberInformationModels");
        });

        builder.Entity<ManagementModel>(b =>
        {
            b.ToTable("tb_managementModels");
        });

        builder.Entity<Equipuse>(b =>
        {
            b.ToTable("tb_equipuses");
        });

        builder.Entity<Equipspecification>(b =>
        {
            b.ToTable("tb_equipspecifications");
        });

        builder.Entity<EquipInfos>(b =>
        {
            b.ToTable("tb_equipInfos");
        });

        builder.Entity<Consumption>(b =>
        {
            b.ToTable("tb_consumptions");
        });

        builder.Entity<ConfigurationModel>(b =>
        {
            b.ToTable("tb_configurationModels");
        });

        builder.Entity<ClosingDetail>(b =>
        {
            b.ToTable("tb_closingDetails");
        });

        builder.Entity<BusinessManagementModel>(b =>
        {
            b.ToTable("tb_businessManagementModels");
        });

        builder.Entity<AddressModel>(b =>
        {
            b.ToTable("tb_addressModels");
        });
        #endregion

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureIdentityServer();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();

        /* Configure your own tables/entities inside here */

        //builder.Entity<YourEntity>(b =>
        //{
        //    b.ToTable(Daniel_technologyConsts.DbTablePrefix + "YourEntities", Daniel_technologyConsts.DbSchema);
        //    b.ConfigureByConvention(); //auto configure for the base class props
        //    //...
        //});
    }
}
