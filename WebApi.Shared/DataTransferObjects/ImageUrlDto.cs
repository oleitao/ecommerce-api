namespace WebApi.Shared.DataTransferObjects
{
    [Serializable]
    public record ImageUrlDto(Guid Id, string PublicUrl, string Url);
    public record ImageUrlForCreationDto(string PublicUrl, string Url);

    public record ImageUrlForUpdateDto(string PublicUrl, string Url);
}
