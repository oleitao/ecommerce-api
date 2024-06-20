using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace WebApi.Repository.Configuration
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder) 
        {
            builder.HasData
            (
                new Category
                {
                    Id=Guid.Parse("6E27B4B8-E66C-450A-BF41-58344B208512"),
                    Title = "Computers and Laptops",
                    SubTitle = "",
                    Image_Url = "https://cdn.shopify.com/s/files/1/1706/9177/products/NEWAppleMacbookProwithM1ProChip14InchLaptop2021ModelMKGQ3LL_A_16GB_1TBSSD_custommacbd.jpg?v=1659592838"
                },
                new Category
                {
                    Id = Guid.Parse("6E27B4B8-E66C-450A-BF41-58344B208513"),
                    Title = "cosmetics and body care",
                    SubTitle = "",
                    Image_Url = "https://indian-retailer.s3.ap-south-1.amazonaws.com/s3fs-public/2021-07/kosme1.png"
                }
            );
        }    
    }
}
