using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Entities.Models;

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
                    Id=Guid.NewGuid(),
                    Title = "Computers and Laptops",
                    SubTitle = "",
                    ImageUrl = "https://cdn.shopify.com/s/files/1/1706/9177/products/NEWAppleMacbookProwithM1ProChip14InchLaptop2021ModelMKGQ3LL_A_16GB_1TBSSD_custommacbd.jpg?v=1659592838"
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Title = "cosmetics and body care",
                    SubTitle = "",
                    ImageUrl = "https://indian-retailer.s3.ap-south-1.amazonaws.com/s3fs-public/2021-07/kosme1.png"
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Title = "Accesories",
                    SubTitle = "",
                    ImageUrl = "https://img.freepik.com/free-vector/ordering-goods-online-internet-store-online-shopping-niche-e-commerce-website-mother-buying-babies-clothes-footwear-toys-infant-accessories_335657-2345.jpg?w=2000"
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Title = "Cloths",
                    SubTitle = "",
                    ImageUrl = "https://www.shift4shop.com/2015/images/industries/clothing/clothing-apparel.png"
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Title = "Shoes",
                    SubTitle = "",
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQvBQPQMVNRd6TtDkGs2dCri0Y-rxKkFOiEWw&usqp=CAU"
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Title = "Gifts",
                    SubTitle = "",
                    ImageUrl = "https://searchspring.com/wp-content/uploads/2022/10/Hero-Image-Platform-Others-2.png"
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Title = "Pet Care",
                    SubTitle = "",
                    ImageUrl = "https://cdn.openpr.com/T/c/Tc15444071_g.jpg"
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Title = "Mobile and Tablets",
                    SubTitle = "",
                    ImageUrl = "https://st-troy.mncdn.com/mnresize/1500/1500/Content/media/ProductImg/original/mpwp3tua-apple-iphone-14-256gb-mavi-mpwp3tua-637986832343472449.jpg"
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Title = "Music and Gaming",
                    SubTitle = "",
                    ImageUrl = "https://static.vecteezy.com/system/resources/previews/011/996/555/original/3d-black-headphone-illustration-ecommerce-icon-png.png"
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Title = "Others",
                    SubTitle = "",
                    ImageUrl = ""
                }
            );
        }    
    }
}
