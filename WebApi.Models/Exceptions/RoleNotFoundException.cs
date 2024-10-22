namespace WebApi.Entities.Exceptions
{
    public sealed class RoleNotFoundException : NotFoundException
    {
        public RoleNotFoundException()
        {
        }

        public RoleNotFoundException(Guid Id) : base($"The role with id: { Id } doesn't exist in the  database.")
        {
            
        }

        public RoleNotFoundException(string message) : base($"The role: {message} doesn't exist in the  database.")
        {
        }
    }
}
