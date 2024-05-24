namespace WebApi.Entities.Exceptions
{
    public sealed class ImageUrlNotFoundException : NotFoundException
    {
        public ImageUrlNotFoundException(Guid Id) : base($"The imageUrl with id: { Id } doesn't exist in the  database.")
        {
            
        }
    }
}
