namespace WebApi.Shared.DataTransferObjects
{
    [Serializable]
    public record OrderStatusDto(Guid Id, string Status);
}
