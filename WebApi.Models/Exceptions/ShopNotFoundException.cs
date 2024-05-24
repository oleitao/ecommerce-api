namespace WebApi.Entities.Exceptions
{
    public sealed class ShopNotFoundException : NotFoundException
    {
        public ShopNotFoundException(Guid Id) : base($"The shop with id: { Id } doesn't exist in the  database.")
        {
            
        }
    }
}
