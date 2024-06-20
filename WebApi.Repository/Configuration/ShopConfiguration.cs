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
                    Id = Guid.Parse("C2264D48-6F36-4B1A-BF95-3C62F67F2AC0"),
                    ShopAvatarId = Guid.Parse("41635D09-6C09-40CD-89C5-17F81AB497FC"),
                    Ratings = 4,
                    ProductId = Guid.Parse("398E76BB-70F0-4712-AF76-10726BB6DD92")
                }
            );
        }
    }
}
