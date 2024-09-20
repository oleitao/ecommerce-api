namespace WebApi.Entities.Exceptions
{
    public sealed class IdParametersBadException : NotFoundException
    {
        public IdParametersBadException() : base("Parameter ids is null")
        {
        }

        public IdParametersBadException(Guid Id) : base("Parameter ids is null")
        {
            
        }
    }
}
