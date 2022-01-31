using Attune.KernelV2.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace Attune.KernelV2
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext()
            : base(Utilities.Utility.GetConnection())
        {
     
        }

        public DbSet<VendorOrgMapping> VendorOrgMapping { get; set; }

        public DbSet<login> login { get; set; }
        public DbSet<LoggedInUsers> LoggedInUsers { get; set; }
        public DbSet<RefreshTokens> RefreshTokens { get; set; }
        public DbSet<IntegrationTypeMaster> IntegrationTypeMaster { get; set; }

        public DbSet<VendorOrgAddressMapping> VendorOrgAddressMapping { get; set; }

        public DbSet<VendorMaster> VendorMaster { get; set; }

        public DbSet<LocationUserMap> LocationUserMap { get; set; }

        public DbSet<LoginRole> LoginRole { get; set; }

        public DbSet<Role> Role { get; set; }

        public DbSet<organizationAddress> organizationAddress { get; set; }

        public DbSet<organization> organization { get; set; }

        public DbSet<LoggedInProfile> LoggedInProfile { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }

}