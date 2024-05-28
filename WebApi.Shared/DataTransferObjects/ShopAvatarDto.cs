namespace WebApi.Shared.DataTransferObjects
{
    [Serializable]
    public record ShopAvatarDto(Guid Id, string PublicId, string Url);

    public record ShopAvatarForCreationDto(string PublicId, string Url);
    public record ShopAvatarForUpdateDto(string PublicId, string Url);

}
