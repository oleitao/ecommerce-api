using Model;

namespace WebApi.Shared.DataTransferObjects
{
    [Serializable]
    public record ShopDto(Guid Id, Guid ProductId, string Name, ShopAvatar ShopAvatars, int Ratings);


    public record ShopForCreationDto
    (
        string Name, 
        ShopAvatarForCreationDto Shop_avatar,
        double Ratings,
        Guid ProductId
    );

    public record ShopForUpdateDto(Guid ProductId, string Name, ShopAvatar ShopAvatars, double Ratings, Guid ShopAvatarId);
}
