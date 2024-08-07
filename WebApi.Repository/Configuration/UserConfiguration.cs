﻿using Microsoft.EntityFrameworkCore;
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
                    Id= "efbcf454-0125-41ff-ac91-75d1564af044",
                    FullName ="oliveira leitao",                
                    Age=36,
                    Gender="M",
                    Birthday= DateTime.Now,
                    Email= "cp5469@protonmail.com",
                    Hobby="netflix",
                    UserName = "oleitao",                      
                },
                new User
                {
                    Id = "efbcf454-0125-41ff-ac91-75d1564af045",
                    FullName = "luis figo",
                    Age = 51,
                    Gender = "M",
                    Birthday = DateTime.Now,
                    Email = "olivleitao@gmail.com",
                    Hobby = "cinema",
                    UserName = "figolu",
                }
            );
        }    
    }
}
