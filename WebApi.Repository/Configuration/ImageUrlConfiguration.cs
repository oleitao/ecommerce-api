using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace WebApi.Repository.Configuration
{
    internal class ImageUrlConfiguration : IEntityTypeConfiguration<ImageUrl>
    {
        public void Configure(EntityTypeBuilder<ImageUrl> builder) 
        {
            /*
            builder.HasData
            (
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    Public_id = "test",
                    Url = "https://www.istorebangladesh.com/images/thumbs/0000286_macbook-pro-m1_550.png",
                    ProductId = Guid.NewGuid()
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    Public_id = "test",
                    Url = "https://www.custommacbd.com/cdn/shop/products/AppleMacBookProwithM2chip2022model_8GB_256GB_CustomMacBD_540x.jpg?v=1659438499",
                    ProductId = Guid.NewGuid()
                }
            );
            */
        }    
    }
}
