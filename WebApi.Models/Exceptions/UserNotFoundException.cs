namespace WebApi.Entities.Exceptions
{
    public sealed class UserNotFoundException : NotFoundException
    {
        public UserNotFoundException()
        {
        }

        public UserNotFoundException(Guid Id) : base($"The user with id: { Id } doesn't exist in the  database.")
        {
            
        }

        public UserNotFoundException(string message) : base($"The user with username: {message} doesn't exist in the  database.")
        {
        }
    }
}
