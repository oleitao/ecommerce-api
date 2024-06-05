namespace WebApi.Entities.RequestFeatures
{
    public class CategoryParameters : RequestFeatures.RequestParameters
    {
        public string? SearchTerm { get; set; }

        public CategoryParameters() => OrderBy = "Title";
        public string? Fields { get; set; }
    }
}
