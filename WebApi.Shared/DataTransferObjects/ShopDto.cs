﻿using Model;

namespace WebApi.Shared.DataTransferObjects
{
    [Serializable]
    public record ShopDto(Guid Id, Guid ProductId, string Name, ShopAvatar? Shop_avatar, int Ratings, Guid ShopAvatarId);


    public record ShopForCreationDto
    (
        string Name, 
        ShopAvatarForCreationDto? Shop_avatar,
        double Ratings,
        Guid ProductId,
        Guid ShopAvatarId
    );

    public record ShopForUpdateDto(Guid ProductId, string Name, ShopAvatar? Shop_avatar, double Ratings, Guid ShopAvatarId);
}
