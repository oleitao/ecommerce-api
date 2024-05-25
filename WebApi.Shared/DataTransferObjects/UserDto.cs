namespace WebApi.Shared.DataTransferObjects
{
    [Serializable]
    public record UserDto(Guid Id, string FullName, char Sex, int Age, DateTime Birthday, string Hobby, string Email);


    public record UserForCreationDto(string FullName, char Sex, int Age, DateTime Birthday, string Hobby, string Email);
}
