namespace WebApi.Helpers;

using AutoMapper;
using WebApi.Entities;
using WebApi.Models.Categories;
using WebApi.Models.Products;
using WebApi.Models.Users;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        #region Category
        // CreateCategoryRequest -> Category
        CreateMap<CreateCategoryRequest, Category>();

        // UpdateCategoryRequest -> Category
        CreateMap<UpdateCategoryRequest, Category>()
            .ForAllMembers(x => x.Condition(
                (src, dest, prop) =>
                {
                    // ignore both null & empty string properties
                    if (prop == null) return false;
                    if (prop.GetType() == typeof(string) && string.IsNullOrEmpty((string)prop)) return false;

                    return true;
                }
            ));
        #endregion

        #region ImageURL
        // CreateImageURLRequest -> ImageURL
        CreateMap<CreateImageURLRequest, ImageUrl>();

        // UpdateImageURLRequest -> ImageURL
        CreateMap<UpdateImageURLRequest, ImageUrl>()
            .ForAllMembers(x => x.Condition(
                (src, dest, prop) =>
                {
                    // ignore both null & empty string properties
                    if (prop == null) return false;
                    if (prop.GetType() == typeof(string) && string.IsNullOrEmpty((string)prop)) return false;

                    return true;
                }
            ));
        #endregion

        #region Product
        // CreateProductRequest -> Product
        CreateMap<CreateProductRequest, Product>();

        // UpdateProductRequest -> Product
        CreateMap<UpdateProductRequest, Product>()
            .ForAllMembers(x => x.Condition(
                (src, dest, prop) =>
                {
                    // ignore both null & empty string properties
                    if (prop == null) return false;
                    if (prop.GetType() == typeof(string) && string.IsNullOrEmpty((string)prop)) return false;

                    return true;
                }
            ));
        #endregion

        #region Review
        // CreateReviewRequest -> Review
        CreateMap<CreateReviewRequest, Review>();

        // UpdateReviewRequest -> Review
        CreateMap<UpdateReviewRequest, Review>()
            .ForAllMembers(x => x.Condition(
                (src, dest, prop) =>
                {
                    // ignore both null & empty string properties
                    if (prop == null) return false;
                    if (prop.GetType() == typeof(string) && string.IsNullOrEmpty((string)prop)) return false;

                    return true;
                }
            ));
        #endregion

        #region ShopAvatar
        // CreateShopAvatarRequest -> ShopAvatar
        CreateMap<CreateShopAvatarRequest, ShopAvatar>();

        // UpdateShopAvatarRequest -> ShopAvatar
        CreateMap<UpdateShopAvatarRequest, ShopAvatar>()
            .ForAllMembers(x => x.Condition(
                (src, dest, prop) =>
                {
                    // ignore both null & empty string properties
                    if (prop == null) return false;
                    if (prop.GetType() == typeof(string) && string.IsNullOrEmpty((string)prop)) return false;

                    return true;
                }
            ));
        #endregion

        #region Shop
        // CreateShopRequest -> Shop
        CreateMap<CreateShopRequest, Shop>();

        // UpdateShopRequest -> Shop
        CreateMap<UpdateShopRequest, Shop>()
            .ForAllMembers(x => x.Condition(
                (src, dest, prop) =>
                {
                    // ignore both null & empty string properties
                    if (prop == null) return false;
                    if (prop.GetType() == typeof(string) && string.IsNullOrEmpty((string)prop)) return false;

                    return true;
                }
            ));
        #endregion

        #region User
        // CreateUserRequest -> User
        CreateMap<CreateUserRequest, User>();

        // UpdateUserRequest -> User
        CreateMap<UpdateUserRequest, User>()
            .ForAllMembers(x => x.Condition(
                (src, dest, prop) =>
                {
                    // ignore both null & empty string properties
                    if (prop == null) return false;
                    if (prop.GetType() == typeof(string) && string.IsNullOrEmpty((string)prop)) return false;

                    return true;
                }
            ));
        #endregion
    }
}