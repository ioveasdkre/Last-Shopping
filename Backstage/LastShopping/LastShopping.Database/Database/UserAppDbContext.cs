using LastShopping.Database.UserAppModels;
using Microsoft.EntityFrameworkCore;

namespace LastShopping.Database.Database
{
    public class UserAppDbContext : DbContext
    {
        public UserAppDbContext(DbContextOptions<UserAppDbContext> options) : base(options)
        {
        }

        public DbSet<UserMain> UserMain { get; set; }
        public DbSet<UserLoginLog> UserLoginLogs { get; set; }
        public DbSet<UserRefreshTokenLog> UserRefreshTokenLogs { get; set; }
        public DbSet<ManagerMain> ManagerMain { get; set; }
        public DbSet<ManagerLoginLog> ManagerLoginLogs { get; set; }
        public DbSet<ManagerRefreshTokenLog> ManagerRefreshTokenLogs { get; set; }
        public DbSet<ManagerRole> ManagerRole { get; set; }
        public DbSet<ManagerRoleAuth> ManagerRoleAuths { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRefreshTokenLog>()
                .HasKey(a => new { a.RefreshToken, a.UserId });
            modelBuilder.Entity<ManagerRefreshTokenLog>()
                .HasKey(a => new { a.RefreshToken, a.ManagerId });
            modelBuilder.Entity<ManagerRoleAuth>()
                .HasKey(a => new { a.RouterId, a.ManagerRoleId });
        }
    }
}
