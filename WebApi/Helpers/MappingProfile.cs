using AutoMapper;
using WebApi.Entities.Models;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Helpers
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            #region Category

            CreateMap<Category, CategoryDto>()
                .ForAllMembers(x => x.Condition(
                    (src, dest, prop) =>
                    {
                        // ignore both null & empty string properties
                        if (prop == null) return false;
                        if (prop.GetType() == typeof(string) && string.IsNullOrEmpty((string)prop)) return false;

                        return true;
                    }
                ));

            CreateMap<Category, CategoryDto>();

            CreateMap<CategoryForCreationDto, Category>();

            #endregion

            #region ImageUrl

            // UpdateImageURLRequest -> ImageURL
            CreateMap<ImageUrl, ImageUrlDto>()
                .ForAllMembers(x => x.Condition(
                (src, dest, prop) =>
                {
                    // ignore both null & empty string properties
                    if (prop == null) return false;
                    if (prop.GetType() == typeof(string) && string.IsNullOrEmpty((string)prop)) return false;

                    return true;
                }
            ));

            CreateMap<ImageUrl, ImageUrlDto>();

            CreateMap<ImageUrlForCreationDto, ImageUrl>();
            #endregion

            #region Product

            CreateMap<Product, ProductDto>()
                .ForAllMembers(x => x.Condition(
                    (src, dest, prop) =>
                    {
                        // ignore both null & empty string properties
                        if (prop == null) return false;
                        if (prop.GetType() == typeof(string) && string.IsNullOrEmpty((string)prop)) return false;

                        return true;
                    }
                ));

            CreateMap<Product, ProductDto>();

            CreateMap<ProductForCreationDto, Product>();

            #endregion

            #region Review

            CreateMap<Review, ReviewDto>()
                .ForAllMembers(x => x.Condition(
                    (src, dest, prop) =>
                    {
                        // ignore both null & empty string properties
                        if (prop == null) return false;
                        if (prop.GetType() == typeof(string) && string.IsNullOrEmpty((string)prop)) return false;

                        return true;
                    }
                ));

            CreateMap<Review, ReviewDto>();

            CreateMap<ReviewForCreationDto, Review>();
            #endregion

            #region ShopAvatar

            CreateMap<ShopAvatar, ShopAvatarDto>()
                .ForAllMembers(x => x.Condition(
                    (src, dest, prop) =>
                    {
                        // ignore both null & empty string properties
                        if (prop == null) return false;
                        if (prop.GetType() == typeof(string) && string.IsNullOrEmpty((string)prop)) return false;

                        return true;
                    }
                ));

            CreateMap<ShopAvatar, ShopAvatarDto>();

            CreateMap<ShopAvatarForCreationDto, ShopAvatar>();
            #endregion

            #region Shop

            CreateMap<Shop, ShopDto>()
                .ForAllMembers(x => x.Condition(
                    (src, dest, prop) =>
                    {
                        // ignore both null & empty string properties
                        if (prop == null) return false;
                        if (prop.GetType() == typeof(string) && string.IsNullOrEmpty((string)prop)) return false;

                        return true;
                    }
                ));

            CreateMap<Shop, ShopDto>();

            CreateMap<ShopForCreationDto, Shop>();
            #endregion

            #region User

            CreateMap<User, UserDto>()
                .ForAllMembers(x => x.Condition(
                    (src, dest, prop) =>
                    {
                        // ignore both null & empty string properties
                        if (prop == null) return false;
                        if (prop.GetType() == typeof(string) && string.IsNullOrEmpty((string)prop)) return false;

                        return true;
                    }
                ));

            CreateMap<User, UserDto>();

            CreateMap<UserForCreationDto, User>();
            #endregion
        }
    }
}
