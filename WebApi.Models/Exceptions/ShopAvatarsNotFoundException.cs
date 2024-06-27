namespace WebApi.Entities.Exceptions
{
    public sealed class ShopAvatarsNotFoundException : NotFoundException
    {
        public ShopAvatarsNotFoundException() : base($"The shops avatars doesn't exist in the  database.")
        {
            
        }
    }
}
