namespace WebApi.Entities.Exceptions
{
    public sealed class ImageUrlsNotFoundException : NotFoundException
    {
        public ImageUrlsNotFoundException() : base($"ImageUrls doesn't exist in the  database.")
        {
            
        }
    }
}
