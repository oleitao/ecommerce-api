using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace WebApi.Repository.Configuration
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder) 
        {
            builder.HasData
            (
                new Product
                {
                    Id = Guid.Parse("398E76BB-70F0-4712-AF76-10726BB6DD92"),
                    CategoryId = Guid.Parse("6E27B4B8-E66C-450A-BF41-58344B208512"),
                    Name = "MacBook pro M2 chipset 256gb ssd 8gb ram space-gray color with apple 1 year warranty",
                    Description = "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.",
                    Price = 0,
                    Discount_price = 0,
                    Rating = 0,
                    Total_sell = 0,
                    Stock = 0,
                    ShopId = Guid.Parse("C2264D48-6F36-4B1A-BF95-3C62F67F2AC0")
                },
                new Product
                {
                    Id = Guid.Parse("398E76BB-70F0-4712-AF76-10726BB6DD93"),
                    CategoryId = Guid.Parse("6E27B4B8-E66C-450A-BF41-58344B208512"),
                    Name = "Iphone 14 pro max 256 gb ssd and 8 gb ram silver colour",
                    Description = "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.",
                    Price = 0,
                    Discount_price = 0,
                    Rating = 0,
                    Total_sell = 0,
                    Stock = 0,
                    ShopId = Guid.Parse("C2264D48-6F36-4B1A-BF95-3C62F67F2AC0")
                }
            );
        }    
    }
}
