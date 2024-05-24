using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Entities.Models;

namespace WebApi.Repository.Configuration
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder) 
        {
            builder.HasData
            (
                new User
                {
                    Id=Guid.NewGuid(),
                    FullName ="",
                    Sex ='M',
                    Age=36,
                    Birthday= DateTime.Now,
                    Email="oleitao@gmail.com",
                    Hobby="swiming"
                }
            );
        }    
    }
}
