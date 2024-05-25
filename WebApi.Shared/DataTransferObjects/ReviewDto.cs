using WebApi.Entities.Models;

namespace WebApi.Shared.DataTransferObjects
{
    [Serializable]
    public record ReviewDto(Guid Id,User User,string Comment,int Rating);
}
