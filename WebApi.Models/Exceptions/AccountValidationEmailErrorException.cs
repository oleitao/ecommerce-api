namespace WebApi.Entities.Exceptions
{
    public sealed class AccountValidationEmailErrorException : NotFoundException
    {
        public AccountValidationEmailErrorException()
        {
        }

        public AccountValidationEmailErrorException(string message) : base(message)
        {
        }
    }
}
