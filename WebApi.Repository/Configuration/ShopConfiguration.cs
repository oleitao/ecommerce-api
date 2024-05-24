using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Entities.Models;

namespace WebApi.Repository.Configuration
{
    internal class ShopConfiguration : IEntityTypeConfiguration<Shop>
    {
        public void Configure(EntityTypeBuilder<Shop> builder) 
        {
            /*

            builder.HasData
            (
                new Shop
                {
                    Name = "Apple inc",
                    ProductId = new Guid(""),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Amazon Ltd",
                    ProductId = new Guid(""),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Amazon Ltd",
                    ProductId = new Guid(""),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Louis Vuitton",
                    ProductId = new Guid(""),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Shodagor Ltd",
                    ProductId = new Guid(""),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Amazon Ltd",
                    ProductId = new Guid(""),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Asus Ltd",
                    ProductId = new Guid(""),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Acer Ltd",
                    ProductId = new Guid(""),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Dove Inc",
                    ProductId = new Guid(""),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Dove Inc",
                    ProductId = new Guid(""),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "3W CLINIC",
                    ProductId = new Guid(""),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Vaseline Inc.",
                    ProductId = new Guid(""),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Tiaa Ltd",
                    ProductId = new Guid(""),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "SAMSUNG",
                    ProductId = new Guid(""),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "SAMSUNG",
                    ProductId = new Guid(""),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Energy System",
                    ProductId = new Guid(""),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Unbranded",
                    ProductId = new Guid(""),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Unik",
                    ProductId = new Guid(""),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Oppo Ltd",
                    ProductId = new Guid(""),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Lenovo Ltd",
                    ProductId = new Guid(""),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Unik",
                    ProductId = new Guid(""),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Apple inc.",
                    ProductId = new Guid(""),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Shahriar Watch House",
                    ProductId = new Guid(""),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Alisha Shoes Mart",
                    ProductId = new Guid(""),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Shahriar Watch House",
                    ProductId = new Guid(""),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Amazon Ltd",
                    ProductId = new Guid(""),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Asus Ltd",
                    ProductId = new Guid(""),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Amazon Ltd",
                    ProductId = new Guid(""),
                    Ratings = 4
                }
            );

            */
        }    
    }
}
