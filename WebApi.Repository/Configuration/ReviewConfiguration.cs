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
                    Id = Guid.NewGuid(),
                    UserId = Guid.Parse("1C416A29-298E-4C21-A3EB-A8D1FEBEA78B"),
                    Comment ="comment",
                    Rating=5
                }
            );
        }    
    }
}
