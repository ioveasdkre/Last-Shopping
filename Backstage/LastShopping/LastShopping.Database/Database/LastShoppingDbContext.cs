using LastShopping.Database.LastShoppingModels;
using LastShopping.Database.Models;
using LastShopping.Database.Models.Enum;
using Microsoft.EntityFrameworkCore;

namespace LastShopping.Database.DbContextModel
{
    public class LastShoppingDbContext : DbContext
    {
        public LastShoppingDbContext(DbContextOptions<LastShoppingDbContext> options) : base(options)
        {
        }

        public DbSet<ManagerRole> ManagerRole { get; set; }
        public DbSet<ManagerRoleAuth> ManagerRoleAuths { get; set; }
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
            modelBuilder.Entity<ManagerRoleAuth>()
                .HasKey(a => new { a.RouterId, a.ManagerRoleId });
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
