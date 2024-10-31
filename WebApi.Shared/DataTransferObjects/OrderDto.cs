using Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Shared.DataTransferObjects
{
    [Serializable]
    public record OrderDto(Guid Id, User Seller, User Buyer, Product Product, double Quantity, Guid StatusId)
    {

    }

    public record OrderForCreationDto(User Seller, User Buyer, Product Product, Guid StatusId);
    public record OrderForUpdateDto(User Seller, User Buyer, Product Product, double Total, Guid StatusId);
}
