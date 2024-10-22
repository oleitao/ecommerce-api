using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;
using WebApi.Entities;

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
                    FullName = "admin",
                    Gender = "O",
                    Birthday = DateTime.Now,
                    Email = "admin@gmail.com",
                    UserName = "admin",
                    RoleId = RolesHelper.RoleIdAdmin,
                    EmailConfirmed = true,
                    PasswordHash = "AQAAAAIAAYagAAAAEKA+oETTkFw0v/4IzUhePND8AQ7QjBymjlxRnwi5SbrNY1OJDU88LQZF08pK+exlsA=="

                },
                new User
                {
                    Id = "efbcf454-0125-41ff-ac91-75d1564af045",
                    FullName = "seller",
                    Gender = "O",
                    Birthday = DateTime.Now,
                    Email = "seller@gmail.com",
                    UserName = "seller",
                    RoleId = RolesHelper.RoleIdSeller,
                    EmailConfirmed = true,
                    PasswordHash = "AQAAAAIAAYagAAAAEKA+oETTkFw0v/4IzUhePND8AQ7QjBymjlxRnwi5SbrNY1OJDU88LQZF08pK+exlsA=="
                },
                new User
                {
                    Id = "efbcf454-0125-41ff-ac91-75d1564af046",
                    FullName = "user",
                    Gender = "O",
                    Birthday = DateTime.Now,
                    Email = "user@gmail.com",
                    UserName = "user",
                    RoleId = RolesHelper.RoleIdUser,
                    EmailConfirmed = true,
                    PasswordHash = "AQAAAAIAAYagAAAAEKA+oETTkFw0v/4IzUhePND8AQ7QjBymjlxRnwi5SbrNY1OJDU88LQZF08pK+exlsA=="
                }
            );
        }
    }
}
