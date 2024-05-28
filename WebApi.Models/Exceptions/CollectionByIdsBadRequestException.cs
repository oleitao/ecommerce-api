namespace WebApi.Entities.Exceptions
{
    public sealed class CollectionByIdsBadRequestException : BadRequestException
    {
        public CollectionByIdsBadRequestException()
            : base("Collection count mismath comparing to ids.")
        {
            
        }
    }
}
