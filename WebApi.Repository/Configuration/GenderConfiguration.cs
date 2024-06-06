using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Entities.Models;

namespace WebApi.Repository.Configuration
{
    internal class GenderConfiguration : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder) 
        {
            builder.HasData
            (
                new Gender
                {
                    Id = 1,
                    Name= "M"
                },
                new Gender
                {
                    Id = 2,
                    Name = "F"
                }
            );
        }    
    }
}
