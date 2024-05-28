namespace WebApi.Entities.Exceptions
{
    public sealed class CategoryCollectionBadRequest : NotFoundException
    {
        public CategoryCollectionBadRequest() : base("Category collection sent from a client is null.")
        {

        }
    }
}
