using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NCKH_Laptop.Areas.Admin.Models;

namespace NCKH_Laptop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }


        public DbSet<BrandModel> Brand { get; set; }
        public DbSet<CategoryModel> Category { get; set; }
        public DbSet<ProductModel> Product { get; set; }
        public DbSet<OrdersModel> Order { get; set; }
        public DbSet<InventoriesModel> Inventory { get; set; }
        public DbSet<OrderDetaiModel> Order_Detai { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BrandModel>()
                .HasMany(e => e.Prodcut)
                .WithOne(e => e.Brand)
                .HasForeignKey(e => e.HangId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProductModel>()
                  .HasOne(e => e.Brand)
                  .WithMany(e => e.Prodcut)
                  .HasForeignKey(e => e.HangId)
                  .IsRequired()
                  .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CategoryModel>()
                .HasMany(e => e.Prodcut)
                .WithOne(e => e.Category)
                .HasForeignKey(e => e.LoaiId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
            
            modelBuilder.Entity<OrdersModel>()
                .HasOne(e => e.User)
                .WithMany()
                .HasForeignKey(e => e.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProductModel>()
                 .HasOne(e => e.Category)
                 .WithMany(e => e.Prodcut)
                 .HasForeignKey(e => e.LoaiId)
                 .IsRequired()
                 .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProductModel>()
               .HasMany(e => e.Order_Detai)
               .WithOne(e => e.product)
               .HasForeignKey(e => e.ProductId)
               .IsRequired()
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrdersModel>()
               .HasMany(e => e.ctdh)
               .WithOne(e => e.order)
               .HasForeignKey(e => e.OrderId)
               .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProductModel>()
               .HasMany(e => e.Inventory)
               .WithOne(e => e.product)
               .HasForeignKey(e => e.ProductId)
               .IsRequired()
               .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<ProductModel>()

               .Property(p => p.PhanTramGiam)
               .HasColumnType("decimal(18,2)");
            modelBuilder.Entity<ProductModel>()
                .Property(p => p.Gia)
                .HasColumnType("decimal(18,2)");
        }
    }
}
