namespace WebApi.Entities.Exceptions
{
    public sealed class CategoryNotFoundException : NotFoundException
    {
        public CategoryNotFoundException() : base($"The category doesn't exist in the  database.")
        {
        }

        public CategoryNotFoundException(Guid Id) : base($"The category with id: { Id } doesn't exist in the  database.")
        {
            
        }

        public CategoryNotFoundException(string message) : base($"The category with name: {message} doesn't exist in the  database.")
        {
        }
    }
}
