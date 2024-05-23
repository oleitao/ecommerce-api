namespace WebApi.Helpers;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebApi.Entities;

public class DataContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;

        //Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sql server with connection string from app settings
        options.UseSqlServer(Configuration.GetConnectionString("ApiDatabase")).
        UseSnakeCaseNamingConvention();
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<ImageUrl> ImageUrls { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Shop> Shops { get; set; }
    public DbSet<ShopAvatar> ShopAvatars { get; set; }
    public DbSet<User> Users { get; set; }

}