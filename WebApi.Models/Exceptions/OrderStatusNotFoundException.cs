namespace WebApi.Entities.Exceptions
{
    public sealed class OrderStatusNotFoundException : NotFoundException
    {

        public OrderStatusNotFoundException(Guid Id) : base($"The order status with id: { Id } doesn't exist in the  database.")
        {
            
        }
    }
}
