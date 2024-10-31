namespace WebApi.Entities.Exceptions
{
    public sealed class OrderNotFoundException : NotFoundException
    {
        public OrderNotFoundException() : base($"The order doesn't exist in the  database.")
        {
        }

        public OrderNotFoundException(Guid Id) : base($"The order with id: { Id } doesn't exist in the  database.")
        {
            
        }

        public OrderNotFoundException(string message) : base($"The order with name: {message} doesn't exist in the  database.")
        {
        }
    }
}
