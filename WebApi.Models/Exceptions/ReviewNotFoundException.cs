namespace WebApi.Entities.Exceptions
{
    public sealed class ReviewNotFoundException : NotFoundException
    {
        public ReviewNotFoundException(Guid Id) : base($"The revview with id: { Id } doesn't exist in the  database.")
        {
            
        }
    }
}
