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
            #endregion
        }
    }
}
