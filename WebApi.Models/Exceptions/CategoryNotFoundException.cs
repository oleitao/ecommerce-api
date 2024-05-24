namespace WebApi.Entities.Exceptions
{
    public sealed class CategoryNotFoundException : NotFoundException
    {
        public CategoryNotFoundException(Guid Id) : base($"The category with id: { Id } doesn't exist in the  database.")
        {
            
        }
    }
}
