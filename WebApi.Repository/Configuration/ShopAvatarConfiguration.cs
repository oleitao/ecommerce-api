using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace WebApi.Repository.Configuration
{
    internal class ShopAvatarConfiguration : IEntityTypeConfiguration<ShopAvatar>
    {
        public void Configure(EntityTypeBuilder<ShopAvatar> builder) 
        {
            builder.HasData
            (                
                new ShopAvatar
                {
                    Id = Guid.Parse("41635D09-6C09-40CD-89C5-17F81AB497FC"),                     
                    Public_id = "test",
                    Url = "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png"
                }
            );
        }    
    }
}
