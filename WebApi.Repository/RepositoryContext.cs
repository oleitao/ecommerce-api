namespace WebApi.Repository;

using Microsoft.EntityFrameworkCore;
using WebApi.Entities.Models;
using WebApi.Repository.Configuration;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new ImageUrlConfiguration());
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        modelBuilder.ApplyConfiguration(new ReviewConfiguration());
        modelBuilder.ApplyConfiguration(new ShopAvatarConfiguration());
        modelBuilder.ApplyConfiguration(new ShopConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<ImageUrl> ImageUrls { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Shop> Shops { get; set; }
    public DbSet<ShopAvatar> ShopAvatars { get; set; }
    public DbSet<User> Users { get; set; }

}