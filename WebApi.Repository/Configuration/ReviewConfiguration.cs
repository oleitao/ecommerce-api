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
                    UserId = Guid.Parse("F3D2300A-C9CF-49B4-B137-ACA949BF3B6A"),
                    Comment ="comment",
                    Rating=5
                }
            );
        }    
    }
}
