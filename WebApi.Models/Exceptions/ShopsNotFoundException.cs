namespace WebApi.Entities.Exceptions
{
    public sealed class ShopsNotFoundException : NotFoundException
    {
        public ShopsNotFoundException() : base($"Shops doesn't exist in the  database.")
        {
            
        }
    }
}
