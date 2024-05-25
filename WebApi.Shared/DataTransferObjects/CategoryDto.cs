namespace WebApi.Shared.DataTransferObjects
{
    [Serializable]
    public record CategoryDto(Guid Id, string Title, string SubTitle, string ImageUrl);
}
