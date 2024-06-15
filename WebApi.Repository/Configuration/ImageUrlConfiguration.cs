using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace WebApi.Repository.Configuration
{
    internal class ImageUrlConfiguration : IEntityTypeConfiguration<ImageUrl>
    {
        public void Configure(EntityTypeBuilder<ImageUrl> builder) 
        {
            builder.HasData
            (
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://www.istorebangladesh.com/images/thumbs/0000286_macbook-pro-m1_550.png"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://www.custommacbd.com/cdn/shop/products/AppleMacBookProwithM2chip2022model_8GB_256GB_CustomMacBD_540x.jpg?v=1659438499"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://m.media-amazon.com/images/I/31Vle5fVdaL.jpg"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://adminapi.applegadgetsbd.com/storage/media/large/iPhone-14-Pro-Max-Silver-8456.jpg"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR_TxUk8mcOtG7_mZmNA6TOZZbADyp3L3HHCg&usqp=CAU"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR_TxUk8mcOtG7_mZmNA6TOZZbADyp3L3HHCg&usqp=CAU"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSSP2a13umWJp5HCeGtJtw9EuW8opwZfY7r6Q&usqp=CAU"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSSP2a13umWJp5HCeGtJtw9EuW8opwZfY7r6Q&usqp=CAU"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSSP2a13umWJp5HCeGtJtw9EuW8opwZfY7r6Q&usqp=CAU"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdUieJcGTqKDqG2pwd8y0PngaUFR0EvjuqPw&usqp=CAU"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdUieJcGTqKDqG2pwd8y0PngaUFR0EvjuqPw&usqp=CAU"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS1eifg73dBnUR8qM29W4H7iXk9NCRskq67KQ&usqp=CAU"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS1eifg73dBnUR8qM29W4H7iXk9NCRskq67KQ&usqp=CAU"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://dlcdnwebimgs.asus.com/gain/0ad9bdfe-9c75-41fb-82f5-6a6bf25bab22/w800"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://dlcdnwebimgs.asus.com/gain/0ad9bdfe-9c75-41fb-82f5-6a6bf25bab22/w800"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQc4HSepwRQjDLQitxc9LHPjdKN-8pYQPGlDA&usqp=CAU"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQc4HSepwRQjDLQitxc9LHPjdKN-8pYQPGlDA&usqp=CAU"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT7lvpJRN10N75r-1ssE_0tpl9dvmOEiKQzXQ&usqp=CAU"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT7lvpJRN10N75r-1ssE_0tpl9dvmOEiKQzXQ&usqp=CAU"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTvyCDsCiIgME0mgv_vJYB-285xwWl3bC-pSw&usqp=CAU"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTvyCDsCiIgME0mgv_vJYB-285xwWl3bC-pSw&usqp=CAU"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSwSpfSyrQUCFFTMei2zILF0-xFsIYgNgVVSA&usqp=CAU"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSwSpfSyrQUCFFTMei2zILF0-xFsIYgNgVVSA&usqp=CAU"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSXd2u896WCZISe8VyWsmvOQhwbLREi0O93YQ&usqp=CAU"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSXd2u896WCZISe8VyWsmvOQhwbLREi0O93YQ&usqp=CAU"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ6AmSV387Vy0EVlO6hYPgsKqPnIA_qxq41oA&usqp=CAU"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ6AmSV387Vy0EVlO6hYPgsKqPnIA_qxq41oA&usqp=CAU"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTBOB80TIoBkL_NaeJ_5lG5LuUsD0IYEDXFJg&usqp=CAU"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS2zcpFb-6hMeoBVWrfp4LazbLD3a1tEjJjY2oYq45yJOyb28WIIYBoJ3qZMsmFdImBSZk&usqp=CAU"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR1GMCvSHthjghTol1tXK_t4eW7Vk-EuBvdnQ&usqp=CAU"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR1GMCvSHthjghTol1tXK_t4eW7Vk-EuBvdnQ&usqp=CAU"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTg7XWy1cmt1D3uUjF29eo2q4HgqJaGEu9XDg&usqp=CAU"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTg7XWy1cmt1D3uUjF29eo2q4HgqJaGEu9XDg&usqp=CAU"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQCEvcavb1VnIbFqFEh_5sgzYPgjcVAbFLl7g&usqp=CAU"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQCEvcavb1VnIbFqFEh_5sgzYPgjcVAbFLl7g&usqp=CAU"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSdd3n1bpYxsBGOpZ6ZgUPIKdLVChEegzOBnQ&usqp=CAU"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSdd3n1bpYxsBGOpZ6ZgUPIKdLVChEegzOBnQ&usqp=CAU"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR42FePhUrLX424aLie09J4Pfkn03T8h3D7PQ&usqp=CAU"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://www.lenovo.com/medias/lenovo-tablet-p10-2.png?context=bWFzdGVyfHJvb3R8NTI0NzIyfGltYWdlL3BuZ3xoM2IvaDFkLzk4MTA1NjI0ODIyMDYucG5nfDI1OGI3YjlkODNkMzI2OThkOWEwMjM1NjliNjI5ZDQ3ZjMxZTg4ZDQ5ZmE5NGY3NTEyYjMwYTA0NDBlM2VhZDA"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://www.lenovo.com/medias/lenovo-tablet-p10-2.png?context=bWFzdGVyfHJvb3R8NTI0NzIyfGltYWdlL3BuZ3xoM2IvaDFkLzk4MTA1NjI0ODIyMDYucG5nfDI1OGI3YjlkODNkMzI2OThkOWEwMjM1NjliNjI5ZDQ3ZjMxZTg4ZDQ5ZmE5NGY3NTEyYjMwYTA0NDBlM2VhZDA"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRoJTwIqCk049REtJbZL5xEYO5W9m6iUiSRSg&usqp=CAU"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRoJTwIqCk049REtJbZL5xEYO5W9m6iUiSRSg&usqp=CAU"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://www.istorebangladesh.com/images/thumbs/0000286_macbook-pro-m1_550.png"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://www.istorebangladesh.com/images/thumbs/0000286_macbook-pro-m1_550.png"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://i0.wp.com/eccocibd.com/wp-content/uploads/2022/01/1802NL02_1.png?fit=550%2C550&ssl=1"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://i0.wp.com/eccocibd.com/wp-content/uploads/2022/01/1802NL02_1.png?fit=550%2C550&ssl=1"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://mirzacdns3.s3.ap-south-1.amazonaws.com/cache/catalog/RLV0015/2-800x800.jpg"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://mirzacdns3.s3.ap-south-1.amazonaws.com/cache/catalog/RLV0015/2-800x800.jpg"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://i0.wp.com/eccocibd.com/wp-content/uploads/2022/01/1802NL02_1.png?fit=550%2C550&ssl=1"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://i0.wp.com/eccocibd.com/wp-content/uploads/2022/01/1802NL02_1.png?fit=550%2C550&ssl=1"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://m.media-amazon.com/images/I/31Vle5fVdaL.jpg"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://m.media-amazon.com/images/I/31Vle5fVdaL.jpg"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://www.startech.com.bd/image/cache/catalog/headphone/havit/h763d/h763d-02-500x500.jpg"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://eratablet.com/wp-content/uploads/2022/08/H51ba6537405f4948972e293927673546u.jpg"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://www.bdstall.com/asset/product-image/giant_213181.jpg"
                },
                new ImageUrl
                {
                    Id = Guid.NewGuid(),
                    PublicId = "test",
                    Url = "https://unixnetworkbd.com/image/cache/wp/gj/unix_network_images/product/gaming-pc-9th-gen-core-i7-9700k/Gaming-PC-9th-Gen-Core-i7-9700k-Unix-Computer-jashore-bangladesh-500x500.webp"
                }
            );            
        }    
    }
}
