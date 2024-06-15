using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace WebApi.Repository.Configuration
{
    internal class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder) 
        {
            builder.HasData
            (
                new Review
                {
                    Id = Guid.NewGuid(),
                    Comment ="comment",
                    Rating=5,
                    UserId = Guid.Parse("efbcf454-0125-41ff-ac91-75d1564af044"),
                    ProductId = Guid.Parse("398E76BB-70F0-4712-AF76-10726BB6DD92")
                }
            );
        }    
    }
}
