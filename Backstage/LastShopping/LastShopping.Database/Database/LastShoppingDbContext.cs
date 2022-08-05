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

        public DbSet<ProductType> ProductType => Set<ProductType>();
        public DbSet<ProductImg> ProductImgs => Set<ProductImg>();
        public DbSet<ProductInformation> ProductInformation => Set<ProductInformation>();
        public DbSet<SalesOrderDetails> SalesOrderDetails => Set<SalesOrderDetails>();
        public DbSet<SalesOrder> SalesOrders => Set<SalesOrder>();
        public DbSet<Factory> Factory => Set<Factory>();
        public DbSet<PurchaseOrder> PurchaseOrders => Set<PurchaseOrder>();
        public DbSet<PurchaseOrderDetails> PurchaseOrderDetails => Set<PurchaseOrderDetails>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
