using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Entities.Models;

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
                    UserId = Guid.NewGuid(),
                    Comment ="comment",
                    Rating=5
                }
            );
        }    
    }
}
