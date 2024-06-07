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
                    Rating=5
                }
            );
        }    
    }
}
