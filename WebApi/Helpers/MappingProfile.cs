using AutoMapper;
using Model;
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

            CreateMap<CategoryForUpdateDto, Category>();

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

            CreateMap<ImageUrlForUpdateDto, ImageUrl>();
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

            CreateMap<ProductForUpdateDto, Product>();

            CreateMap<ProductForUpdateDto, Product>().ReverseMap();

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

            CreateMap<ReviewForUpdateDto, Review>();
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

            CreateMap<ShopAvatarForUpdateDto, ShopAvatar>();
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

            CreateMap<ShopForUpdateDto, Shop>();
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


            CreateMap<UserForUpdateDto, User>();
            #endregion

            #region ProductsByCategory

            CreateMap<ProductForCreationDto, Product>();

            #endregion

            #region UserRegistration

            CreateMap<UserForRegistrationDto, User>();

            #endregion
        }
    }
}
