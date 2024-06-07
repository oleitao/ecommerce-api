using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

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
                    FullName ="oliveira leitao",                
                    Age=36,
                    Gender="M",
                    Birthday= DateTime.Now,
                    Email="oleitao@gmail.com",
                    Hobby="netflix"
                }
            );
        }    
    }
}
