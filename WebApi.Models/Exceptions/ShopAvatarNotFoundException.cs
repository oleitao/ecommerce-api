namespace WebApi.Entities.Exceptions
{
    public sealed class ShopAvatarNotFoundException : NotFoundException
    {
        public ShopAvatarNotFoundException(Guid Id) : base($"The shop avatar with id: { Id } doesn't exist in the  database.")
        {
            
        }
    }
}
