namespace WebApi.Entities.Exceptions
{
    public sealed class EmailContentNotFound : NotFoundException
    {        
        public EmailContentNotFound(Guid id) : base($"The email id content {id} doesn't exist in the  database.")
        { }
    }
}
