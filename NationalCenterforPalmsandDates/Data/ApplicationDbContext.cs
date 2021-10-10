using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NationalCenterforPalmsandDates.Models;
using NationalCenterforPalmsandDates.ViewModels;

namespace NationalCenterforPalmsandDates.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityUser>().ToTable("Users", "Security");
            builder.Entity<IdentityRole>().ToTable("Roles", "Security");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles", "Security");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims", "Security");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins", "Security");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RolesClaims", "Security");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens", "Security");
        }

        public DbSet<DatesSetting> DatesSettings { get; set; }
        public DbSet<BankSetting> BankSettings { get; set; }
        public DbSet<FarmerSetting> FarmerSettings { get; set; }
        public DbSet<SeasonSetting> SeasonSettings { get; set; }
        public DbSet<SectorSetting> SectorSettings { get; set; }
        public DbSet<SectoreQuantatiesSetting> SectoreQuantatiesSettings { get; set; }
        public DbSet<NationalCenterforPalmsandDates.ViewModels.BankSettingViewModel> BankSettingViewModel { get; set; }
        public DbSet<NationalCenterforPalmsandDates.ViewModels.DatesSettingViewModel> DatesSettingViewModel { get; set; }
        public DbSet<NationalCenterforPalmsandDates.ViewModels.SectorSettingViewModel> SectorSettingViewModel { get; set; }
        public DbSet<NationalCenterforPalmsandDates.ViewModels.SectoreQuantatiesSettingViewModel> SectoreQuantatiesSettingViewModel { get; set; }
        public DbSet<NationalCenterforPalmsandDates.ViewModels.SeasonSettingViewModel> SeasonSettingViewModel { get; set; }

    }
}
