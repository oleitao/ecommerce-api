namespace WebApi.Repository;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Model;
using WebApi.Repository.Configuration;

public class RepositoryContext : IdentityDbContext<User>
{

    public RepositoryContext(DbContextOptions options)
        : base(options)
    {

    }

    public virtual DbSet<Category> Categories
    {
        get;
        set;
    }

    public virtual DbSet<ImageUrl> ImageUrls
    {
        get;
        set;
    }

    public virtual DbSet<Product> Products
    {
        get;
        set;
    }

    public virtual DbSet<User> Users
    {
        get;
        set;
    }

    public virtual DbSet<Review> Reviews
    {
        get;
        set;
    }

    public virtual DbSet<Shop> Shops
    {
        get;
        set;
    }

    public virtual DbSet<ShopAvatar> ShopAvatars
    {
        get;
        set;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        this.CategoryMapping(modelBuilder);
        this.ImageUrlMapping(modelBuilder);
        this.ProductMapping(modelBuilder);
        this.UserMapping(modelBuilder);
        this.ReviewMapping(modelBuilder);
        this.ShopMapping(modelBuilder);
        this.ShopAvatarMapping(modelBuilder);

        RelationshipsMapping(modelBuilder);

        modelBuilder.ApplyConfiguration(new RoleConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new ShopAvatarConfiguration());
        modelBuilder.ApplyConfiguration(new ImageUrlConfiguration());
        modelBuilder.ApplyConfiguration(new ShopConfiguration());
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        modelBuilder.ApplyConfiguration(new ReviewConfiguration());
        
    }

    #region Category Mapping

    private void CategoryMapping(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().ToTable(@"Categories");
        modelBuilder.Entity<Category>().Property(x => x.Id).HasColumnName(@"Id").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<Category>().Property(x => x.Title).HasColumnName(@"Title").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<Category>().Property(x => x.SubTitle).HasColumnName(@"SubTitle").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<Category>().Property(x => x.ImageUrl).HasColumnName(@"ImageUrl").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<Category>().HasKey(@"Id");
    }

    #endregion

    #region ImageUrl Mapping

    private void ImageUrlMapping(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ImageUrl>().ToTable(@"ImageUrls");
        modelBuilder.Entity<ImageUrl>().Property(x => x.Id).HasColumnName(@"Id").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<ImageUrl>().Property(x => x.Public_id).HasColumnName(@"Public_id").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<ImageUrl>().Property(x => x.Url).HasColumnName(@"Url").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<ImageUrl>().Property(x => x.ProductId).HasColumnName(@"ProductId").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<ImageUrl>().HasKey(@"Id");
    }

    #endregion

    #region Product Mapping

    private void ProductMapping(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().ToTable(@"Products");
        modelBuilder.Entity<Product>().Property(x => x.Id).HasColumnName(@"Id").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<Product>().Property(x => x.Name).HasColumnName(@"Name").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<Product>().Property(x => x.Description).HasColumnName(@"Description").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<Product>().Property(x => x.Price).HasColumnName(@"Price").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<Product>().Property(x => x.Discount_price).HasColumnName(@"Discount_price").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<Product>().Property(x => x.Rating).HasColumnName(@"Rating").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<Product>().Property(x => x.Total_sell).HasColumnName(@"Total_sell").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<Product>().Property(x => x.Stock).HasColumnName(@"Stock").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<Product>().Property(x => x.CategoryId).HasColumnName(@"CategoryId").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<Product>().Property(x => x.ShopId).HasColumnName(@"ShopId").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<Product>().HasKey(@"Id");
    }

    #endregion

    #region User Mapping

    private void UserMapping(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToTable(@"Users");
        modelBuilder.Entity<User>().Property(x => x.Id).HasColumnName(@"Id").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<User>().Property(x => x.FullName).HasColumnName(@"FullName").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<User>().Property(x => x.Birthday).HasColumnName(@"Birthday").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<User>().Property(x => x.Hobby).HasColumnName(@"Hobby").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<User>().Property(x => x.Email).HasColumnName(@"Email").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<User>().Property(x => x.Gender).HasColumnName(@"Gender").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<User>().Property(x => x.Age).HasColumnName(@"Age").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<User>().HasKey(@"Id");
    }

    #endregion

    #region Review Mapping

    private void ReviewMapping(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Review>().ToTable(@"Reviews");
        modelBuilder.Entity<Review>().Property(x => x.Id).HasColumnName(@"Id").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<Review>().Property(x => x.Comment).HasColumnName(@"Comment").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<Review>().Property(x => x.Rating).HasColumnName(@"Rating").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<Review>().Property(x => x.UserId).HasColumnName(@"UserId").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<Review>().Property(x => x.ProductId).HasColumnName(@"ProductId").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<Review>().HasKey(@"Id");
    }

    #endregion

    #region Shop Mapping

    private void ShopMapping(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Shop>().ToTable(@"Shops");
        modelBuilder.Entity<Shop>().Property(x => x.Id).HasColumnName(@"Id").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<Shop>().Property(x => x.Name).HasColumnName(@"Name").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<Shop>().Property(x => x.Ratings).HasColumnName(@"Ratings").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<Shop>().Property(x => x.ShopAvatarId).HasColumnName(@"ShopAvatarId").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<Shop>().HasKey(@"Id");
    }

    #endregion

    #region ShopAvatar Mapping

    private void ShopAvatarMapping(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ShopAvatar>().ToTable(@"ShopAvatars");
        modelBuilder.Entity<ShopAvatar>().Property(x => x.Id).HasColumnName(@"Id").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<ShopAvatar>().Property(x => x.Public_id).HasColumnName(@"Public_id").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<ShopAvatar>().Property(x => x.Url).HasColumnName(@"Url").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<ShopAvatar>().HasKey(@"Id");
    }

    #endregion

    private void RelationshipsMapping(ModelBuilder modelBuilder)
    {
    }

    public bool HasChanges()
    {
        return ChangeTracker.Entries().Any(e => e.State == Microsoft.EntityFrameworkCore.EntityState.Added || e.State == Microsoft.EntityFrameworkCore.EntityState.Modified || e.State == Microsoft.EntityFrameworkCore.EntityState.Deleted);
    }

}
