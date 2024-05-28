namespace WebApi.Shared.DataTransferObjects
{
    [Serializable]
    public record CategoryDto(Guid Id, string Title, string SubTitle, string ImageUrl);


    public record CategoryForCreationDto(string Title, string SubTitle, string ImageUrl);

    public record CategoryForUpdateDto(string Title, string SubTitle, string ImageUrl);
}
