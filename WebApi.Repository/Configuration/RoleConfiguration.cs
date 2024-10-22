using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;
using WebApi.Entities;

namespace WebApi.Repository.Configuration
{
    internal class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {

            builder.HasData
            (
                new Role
                {
                    Id = RolesHelper.RoleIdUser,
                    Name = RolesHelper.User,
                    NormalizedName = RolesHelper.User.ToUpper()
                },
                new Role
                {
                    Id = RolesHelper.RoleIdSeller,
                    Name = RolesHelper.Seller,
                    NormalizedName = RolesHelper.Seller.ToUpper()
                },
                new Role
                {
                    Id = RolesHelper.RoleIdAdmin,
                    Name = RolesHelper.Admin,
                    NormalizedName = RolesHelper.Admin.ToUpper()
                }
            );

        }
    }
}