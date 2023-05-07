using Microsoft.EntityFrameworkCore;
using System.Net;
using WebApi.Models.Entities;


namespace WebApi.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Unique


       

            OnModelCreatingUserEntity(modelBuilder);
            OnModelCreatingAddressEntity(modelBuilder);
            OnModelCreatingCompanyEntity(modelBuilder);
            OnModelCreatingProductEntity(modelBuilder);
            OnModelCreatingReviewEntity(modelBuilder);
            OnModelCreatingUserPromoCodeEntity(modelBuilder);
            OnModelCreatingPromoCodeEntity(modelBuilder);
            OnModelCreatingPaymentDetailEntity(modelBuilder);
            OnModelCreatingOrderStatusTypeEntity(modelBuilder);
            OnModelCreatingOrderStatusEntity(modelBuilder);
            OnModelCreatingOrderProductEntity(modelBuilder);
            OnModelCreatingOrderEntity(modelBuilder);
        }

        private void OnModelCreatingUserEntity(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>()
                    .HasIndex(u => u.Email)
                    .IsUnique();

            modelBuilder.Entity<UserEntity>()
                .HasMany(u => u.Addresses)
                .WithOne(a => a.User)
                .HasForeignKey(a => a.UserId);

            modelBuilder.Entity<UserEntity>()
                .HasMany(u => u.PaymentDetails)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);

            modelBuilder.Entity<UserEntity>()
                .HasMany(u => u.Reviews)
                .WithOne(r => r.User)
                .HasForeignKey(r => r.UserId);

            modelBuilder.Entity<UserEntity>()
                .HasMany(u => u.Orders)
                .WithOne(o => o.User)
                .HasForeignKey(o => o.UserId);
        }
        private void OnModelCreatingAddressEntity(ModelBuilder modelBuilder)
        {

        }
        private void OnModelCreatingCompanyEntity(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanyEntity>()
              .HasMany(c => c.Products)
              .WithOne(p => p.Company)
              .HasForeignKey(p => p.CompanyId);
        }
        private void OnModelCreatingProductEntity(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductEntity>()
               .HasMany(p => p.Reviews)
               .WithOne(r => r.Product)
               .HasForeignKey(r => r.ProductId);
        }
        private void OnModelCreatingReviewEntity(ModelBuilder modelBuilder)
        {

        }
        private void OnModelCreatingUserPromoCodeEntity(ModelBuilder modelBuilder)
        {

        }
        private void OnModelCreatingPromoCodeEntity(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PromoCodeEntity>()
                .Property(p => p.Discount)
                .HasPrecision(3,2);
        }
        private void OnModelCreatingPaymentDetailEntity(ModelBuilder modelBuilder)
        {

        }
        private void OnModelCreatingOrderStatusTypeEntity(ModelBuilder modelBuilder)
        {

        }
        private void OnModelCreatingOrderStatusEntity(ModelBuilder modelBuilder)
        {

        }
        private void OnModelCreatingOrderProductEntity(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderProductEntity>()
                .HasKey(op => new { op.OrderId, op.ProductId });
        }
        private void OnModelCreatingOrderEntity(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderEntity>()
                .HasMany(o => o.OrderStatuses)
                .WithOne(os => os.Order)
                .HasForeignKey(os => os.OrderId);
        }

        public DbSet<UserPromoCodeEntity> UserPromoCodes { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<ReviewEntity> Reviews { get; set; }
        public DbSet<PromoCodeEntity> PromoCodes { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<PaymentDetailEntity> PaymentDetails { get; set; }
        public DbSet<OrderStatusTypeEntity> OrderStatusTypes { get; set; }
        public DbSet<OrderStatusEntity> OrderStatuses { get; set; }
        public DbSet<OrderProductEntity> OrderProducts { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<CompanyEntity> Companies { get; set; }
        public DbSet<AddressEntity> Addresses { get; set; }
    }
}
