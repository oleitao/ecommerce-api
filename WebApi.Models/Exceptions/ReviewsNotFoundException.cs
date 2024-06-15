namespace WebApi.Entities.Exceptions
{
    public sealed class ReviewsNotFoundException : NotFoundException
    {
        public ReviewsNotFoundException() : base($"Revview doesn't exist in the  database.")
        {
            
        }
    }
}
