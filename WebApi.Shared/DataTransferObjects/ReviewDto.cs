using WebApi.Entities.Models;

namespace WebApi.Shared.DataTransferObjects
{
    [Serializable]
    public record ReviewDto(Guid Id,User User,string Comment,int Rating);

    public record ReviewForCreationDto(User User, string Comment, int Rating);

    public record ReviewForUpdateDto(User User, string Comment, int Rating);
}
