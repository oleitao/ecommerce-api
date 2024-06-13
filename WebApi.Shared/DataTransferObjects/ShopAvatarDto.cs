namespace WebApi.Shared.DataTransferObjects
{
    [Serializable]
    public record ShopAvatarDto(Guid Id, string Public_id, string Url);
    public record ShopAvatarForCreationDto(string Public_id, string Url);
    public record ShopAvatarForUpdateDto(string Public_id, string Url);

}
