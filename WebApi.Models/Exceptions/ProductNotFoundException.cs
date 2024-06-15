namespace WebApi.Entities.Exceptions
{
    public sealed class ProductsNotFoundException : NotFoundException
    {
        public ProductsNotFoundException() : base($"Products doesn't exist in the  database.")
        {
            
        }
    }
}
