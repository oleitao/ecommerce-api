namespace WebApi.Entities.Exceptions
{
    public sealed class InboxNotFoundException : NotFoundException
    {
        public InboxNotFoundException() : base($"The inbox doesn't exist in the  database.")
        {
        }

        public InboxNotFoundException(Guid Id) : base($"The inbox with id: { Id } doesn't exist in the  database.")
        {
            
        }

        public InboxNotFoundException(string message) : base($"The inbox with name: {message} doesn't exist in the  database.")
        {
        }
    }
}
