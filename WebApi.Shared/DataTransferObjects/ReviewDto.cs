using Model;

namespace WebApi.Shared.DataTransferObjects
{
    [Serializable]
    public record ReviewDto(Guid Id, string Comment, int Rating, UserDto User, Guid ProductId);

    public record ReviewForCreationDto(string Comment, int Rating, UserDto User, Guid ProductId);

    public record ReviewForUpdateDto(User User, string Comment, int Rating, Guid ProductId);
}
