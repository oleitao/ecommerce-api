namespace WebApi.Shared.DataTransferObjects
{
    [Serializable]
    public record ImageUrlDto(Guid Id, string PublicUrl, string Url);
}
