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
                    Id = "efbcf454-0125-41ff-ac91-75d1564af044",
                    FullName = "user1",
                    Gender = "M",
                    Birthday = DateTime.Now,
                    Email = "cp5469@protonmail.com",
                    UserName = "admin"
                },
                new User
                {
                    Id = "efbcf454-0125-41ff-ac91-75d1564af045",
                    FullName = "user2",
                    Gender = "M",
                    Birthday = DateTime.Now,
                    Email = "luis.figo@gmail.com",
                    UserName = "user2"
                },
                new User
                {
                    Id = "efbcf454-0125-41ff-ac91-75d1564af046",
                    FullName = "user3",
                    Gender = "O",
                    Birthday = DateTime.Now,
                    Email = "bruno.carvalho@gmail.com",
                    UserName = "user3"
                }
            );
        }
    }
}
