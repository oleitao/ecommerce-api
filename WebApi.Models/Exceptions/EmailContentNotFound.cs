namespace WebApi.Entities.Exceptions
{
    public sealed class EmailContentNotFound : NotFoundException
    {
        private Guid accountValidation;

        public EmailContentNotFound(string message) : base($"The email content doesn't exist in the  database.")
        {
        }

        public EmailContentNotFound(Guid id) : base($"The email id content {id} doesn't exist in the  database.")
        { }
    }
}
