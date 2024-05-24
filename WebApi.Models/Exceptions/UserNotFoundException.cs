namespace WebApi.Entities.Exceptions
{
    public sealed class UserNotFoundException : NotFoundException
    {
        public UserNotFoundException(Guid Id) : base($"The user with id: { Id } doesn't exist in the  database.")
        {
            
        }
    }
}
