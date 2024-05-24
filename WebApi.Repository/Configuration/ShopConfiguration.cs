using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Entities.Models;

namespace WebApi.Repository.Configuration
{
    internal class ShopConfiguration : IEntityTypeConfiguration<Shop>
    {
        public void Configure(EntityTypeBuilder<Shop> builder) 
        {
            builder.HasData
            (
                new Shop
                {
                    Name = "Apple inc",
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("E6F56553-8663-4DD3-A4F0-8E21FBC2C16A"),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Amazon Ltd",
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("E6F56553-8663-4DD3-A4F0-8E21FBC2C16A"),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Amazon Ltd",
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("E6F56553-8663-4DD3-A4F0-8E21FBC2C16A"),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Louis Vuitton",
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("E6F56553-8663-4DD3-A4F0-8E21FBC2C16A"),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Shodagor Ltd",
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("E6F56553-8663-4DD3-A4F0-8E21FBC2C16A"),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Amazon Ltd",
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("E6F56553-8663-4DD3-A4F0-8E21FBC2C16A"),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Asus Ltd",
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("E6F56553-8663-4DD3-A4F0-8E21FBC2C16A"),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Acer Ltd",
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("E6F56553-8663-4DD3-A4F0-8E21FBC2C16A"),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Dove Inc",
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("E6F56553-8663-4DD3-A4F0-8E21FBC2C16A"),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Dove Inc",
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("E6F56553-8663-4DD3-A4F0-8E21FBC2C16A"),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "3W CLINIC",
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("E6F56553-8663-4DD3-A4F0-8E21FBC2C16A"),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Vaseline Inc.",
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("E6F56553-8663-4DD3-A4F0-8E21FBC2C16A"),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Tiaa Ltd",
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("E6F56553-8663-4DD3-A4F0-8E21FBC2C16A"),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "SAMSUNG",
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("E6F56553-8663-4DD3-A4F0-8E21FBC2C16A"),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "SAMSUNG",
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("E6F56553-8663-4DD3-A4F0-8E21FBC2C16A"),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Energy System",
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("E6F56553-8663-4DD3-A4F0-8E21FBC2C16A"),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Unbranded",
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("E6F56553-8663-4DD3-A4F0-8E21FBC2C16A"),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Unik",
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("E6F56553-8663-4DD3-A4F0-8E21FBC2C16A"),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Oppo Ltd",
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("E6F56553-8663-4DD3-A4F0-8E21FBC2C16A"),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Lenovo Ltd",
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("E6F56553-8663-4DD3-A4F0-8E21FBC2C16A"),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Unik",
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("E6F56553-8663-4DD3-A4F0-8E21FBC2C16A"),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Apple inc.",
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("E6F56553-8663-4DD3-A4F0-8E21FBC2C16A"),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Shahriar Watch House",
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("E6F56553-8663-4DD3-A4F0-8E21FBC2C16A"),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Alisha Shoes Mart",
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("E6F56553-8663-4DD3-A4F0-8E21FBC2C16A"),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Shahriar Watch House",
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("E6F56553-8663-4DD3-A4F0-8E21FBC2C16A"),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Amazon Ltd",
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("E6F56553-8663-4DD3-A4F0-8E21FBC2C16A"),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Asus Ltd",
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("E6F56553-8663-4DD3-A4F0-8E21FBC2C16A"),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Amazon Ltd",
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("E6F56553-8663-4DD3-A4F0-8E21FBC2C16A"),
                    Ratings = 4
                }
            );
        }    
    }
}
