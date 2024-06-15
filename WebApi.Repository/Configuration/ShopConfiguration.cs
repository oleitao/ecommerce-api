using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

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
                    ShopAvatarId = Guid.NewGuid(),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Amazon Ltd",
                    Id = Guid.NewGuid(),
                    ShopAvatarId = Guid.NewGuid(),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Amazon Ltd",
                    Id = Guid.NewGuid(),
                    ShopAvatarId = Guid.NewGuid(),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Louis Vuitton",
                    Id = Guid.NewGuid(),
                    ShopAvatarId = Guid.NewGuid(),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Shodagor Ltd",
                    Id = Guid.NewGuid(),
                    ShopAvatarId = Guid.NewGuid(),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Amazon Ltd",
                    Id = Guid.NewGuid(),
                    ShopAvatarId = Guid.NewGuid(),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Asus Ltd",
                    Id = Guid.NewGuid(),
                    ShopAvatarId = Guid.NewGuid(),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Acer Ltd",
                    Id = Guid.NewGuid(),
                    ShopAvatarId = Guid.NewGuid(),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Dove Inc",
                    Id = Guid.NewGuid(),
                    ShopAvatarId = Guid.NewGuid(),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Dove Inc",
                    Id = Guid.NewGuid(),
                    ShopAvatarId = Guid.NewGuid(),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "3W CLINIC",
                    Id = Guid.NewGuid(),
                    ShopAvatarId = Guid.NewGuid(),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Vaseline Inc.",
                    Id = Guid.NewGuid(),
                    ShopAvatarId = Guid.NewGuid(),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Tiaa Ltd",
                    Id = Guid.NewGuid(),
                    ShopAvatarId = Guid.NewGuid(),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "SAMSUNG",
                    Id = Guid.NewGuid(),
                    ShopAvatarId = Guid.NewGuid(),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "SAMSUNG",
                    Id = Guid.NewGuid(),
                    ShopAvatarId = Guid.NewGuid(),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Energy System",
                    Id = Guid.NewGuid(),
                    ShopAvatarId = Guid.NewGuid(),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Unbranded",
                    Id = Guid.NewGuid(),
                    ShopAvatarId = Guid.NewGuid(),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Unik",
                    Id = Guid.NewGuid(),
                    ShopAvatarId = Guid.NewGuid(),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Oppo Ltd",
                    Id = Guid.NewGuid(),
                    ShopAvatarId = Guid.NewGuid(),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Lenovo Ltd",
                    Id = Guid.NewGuid(),
                    ShopAvatarId = Guid.NewGuid(),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Unik",
                    Id = Guid.NewGuid(),
                    ShopAvatarId = Guid.NewGuid(),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Apple inc.",
                    Id = Guid.NewGuid(),
                    ShopAvatarId = Guid.NewGuid(),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Shahriar Watch House",
                    Id = Guid.NewGuid(),
                    ShopAvatarId = Guid.NewGuid(),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Alisha Shoes Mart",
                    Id = Guid.NewGuid(),
                    ShopAvatarId = Guid.NewGuid(),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Shahriar Watch House",
                    Id = Guid.NewGuid(),
                    ShopAvatarId = Guid.NewGuid(),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Amazon Ltd",
                    Id = Guid.NewGuid(),
                    ShopAvatarId = Guid.NewGuid(),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Asus Ltd",
                    Id = Guid.NewGuid(),
                    ShopAvatarId = Guid.NewGuid(),
                    Ratings = 4
                },
                new Shop
                {
                    Name = "Amazon Ltd",
                    Id = Guid.NewGuid(),
                    ShopAvatarId = Guid.NewGuid(),
                    Ratings = 4
                }
            );
        }
    }
}
