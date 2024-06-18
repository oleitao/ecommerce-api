namespace WebApi.Shared.DataTransferObjects
{
    [Serializable]
    public record CategoryDto(Guid Id, string Title, string SubTitle, string Image_Url);


    public record CategoryForCreationDto(string Title, string SubTitle, string Image_Url);

    public record CategoryForUpdateDto(string Title, string SubTitle, string Image_Url);
}
