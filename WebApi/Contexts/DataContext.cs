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
            modelBuilder.Entity<UserEntity>()
                .HasIndex(u => u.Email)
                .IsUnique();


            modelBuilder.Entity<UserEntity>()
                .HasMany(u => u.Addresses)
                .WithOne(a => a.User)
                .HasForeignKey(a => a.UserId);

            modelBuilder.Entity<UserEntity>().HasMany(u => u.PaymentDetails)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);

            modelBuilder.Entity<ProductEntity>().HasMany(p => p.Reviews)
                .WithOne(r => r.Product)
                .HasForeignKey(r => r.ProductId);

            modelBuilder.Entity<CompanyEntity>().HasMany(c => c.Products)
                .WithOne(p => p.Company)
                .HasForeignKey(p => p.CompanyId);
        }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<AddressEntity> Addresses { get; set; }
        public DbSet<PaymentDetailEntity> PaymentDetails { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CompanyEntity> Companies { get; set; }
        public DbSet<ReviewEntity> Reviews { get; set; }
    }
}
