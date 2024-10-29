namespace WebApi.Shared.DataTransferObjects
{
    [Serializable]
    public record InboxDto(Guid Id, string Message, Guid From, Guid To, DateTime Stamp);

    public record InboxMessageDto(Guid Id, string Message, string From, DateTime Stamp);

    public record InboxForCreationDto(string Message, Guid From, Guid To, DateTime Stamp);
}
