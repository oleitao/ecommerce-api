namespace WebApi.Entities.Exceptions
{
    public sealed class MaxNameRangeBadRequestException : BadRequestException
    {
        public MaxNameRangeBadRequestException() : base("Max name must be less than 500 characters")
        {
            
        }
    }
}
