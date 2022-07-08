using Backstage.Models;
using Backstage.Models.Enum;
using Microsoft.EntityFrameworkCore;

namespace Backstage.DbContextModel
{
    public class ShoppingMallDbContext : DbContext
    {
        public ShoppingMallDbContext(DbContextOptions<ShoppingMallDbContext> options) : base(options)
        {
        }

        public DbSet<UserMain> UserMain { get; set; }
        public DbSet<UserLoginLog> UserLoginLogs { get; set; }
        public DbSet<UserRefreshTokenLog> UserRefreshTokenLogs { get; set; }
        public DbSet<ManagerMain> ManagerMain { get; set; }
        public DbSet<ManagerRole> ManagerRole { get; set; }
        public DbSet<ManagerRoleAuth> ManagerRoleAuths { get; set; }
        public DbSet<ManagerLoginLog> ManagerLoginLogs { get; set; }
        public DbSet<ManagerRefreshTokenLog> ManagerRefreshTokenLogs { get; set; }
        public DbSet<Router> Router { get; set; }
        public DbSet<ProductType> ProductType { get; set; }
        public DbSet<ProductImg> ProductImgs { get; set; }
        public DbSet<ProductInformation> ProductInformation { get; set; }
        public DbSet<SalesOrderDetails> SalesOrderDetails { get; set; }
        public DbSet<SalesOrder> SalesOrders { get; set; }
        public DbSet<Factory> Factory { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<PurchaseOrderDetails> PurchaseOrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRefreshTokenLog>()
                .HasKey(a => new { a.RefreshToken, a.UserId });
            modelBuilder.Entity<ManagerRoleAuth>()
                .HasKey(a => new { a.RouterId, a.ManagerRoleId });
            modelBuilder.Entity<ManagerRefreshTokenLog>()
                .HasKey(a => new { a.RefreshToken, a.ManagerId });
            modelBuilder.Entity<SalesOrderDetails>()
                .HasKey(a => new { a.OrderId, a.ProductInformationId });
            modelBuilder.Entity<PurchaseOrderDetails>()
                .HasKey(a => new { a.PurchaseOrderId, a.ProductInformationId });

            modelBuilder
                .Entity<SalesOrderDetails>()
                .Property(e => e.OrderStatus)
                .HasConversion(
                    v => v.ToString(),
                    v => (OrderStatus)Enum.Parse(typeof(OrderStatus), v));
        }
    }
}
