using LastShopping.Database.UserAppModels;
using Microsoft.EntityFrameworkCore;

namespace LastShopping.Database.DbContextModel
{
    public class UserAppDbContext : DbContext
    {
        public UserAppDbContext(DbContextOptions<UserAppDbContext> options) : base(options)
        {
        }

        public DbSet<UserMain> UserMain => Set<UserMain>();
        public DbSet<UserLoginLog> UserLoginLogs => Set<UserLoginLog>();
        public DbSet<UserRefreshTokenLog> UserRefreshTokenLogs => Set<UserRefreshTokenLog>();
        public DbSet<ManagerMain> ManagerMain => Set<ManagerMain>();
        public DbSet<ManagerLoginLog> ManagerLoginLogs => Set<ManagerLoginLog>();
        public DbSet<ManagerRefreshTokenLog> ManagerRefreshTokenLogs => Set<ManagerRefreshTokenLog>();
        public DbSet<ManagerRole> ManagerRole => Set<ManagerRole>();
        public DbSet<ManagerRoleAuth> ManagerRoleAuths => Set<ManagerRoleAuth>();
        public DbSet<ManagerRouter> ManagerRouter => Set<ManagerRouter>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRefreshTokenLog>()
                .HasKey(a => new { a.RefreshToken, a.UserMainId });
            modelBuilder.Entity<ManagerRefreshTokenLog>()
                .HasKey(a => new { a.RefreshToken, a.ManagerMainId });
            modelBuilder.Entity<ManagerRoleAuth>()
                .HasKey(a => new { a.ManagerRoleId, a.ManagerRouterId });
        }
    }
}
