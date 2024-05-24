namespace WebApi.Entities.Exceptions
{
    public sealed class ProductNotFoundException : NotFoundException
    {
        public ProductNotFoundException(Guid Id) : base($"The product with id: { Id } doesn't exist in the  database.")
        {
            
        }
    }
}
