namespace WebApi.Shared.DataTransferObjects
{
    [Serializable]
    public record ShopAvatarDto(Guid Id, string PublicId, string Url);
}
