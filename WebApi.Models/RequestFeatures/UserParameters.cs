namespace WebApi.Entities.RequestFeatures
{
    public class UserParameters : RequestFeatures.RequestParameters
    {
        public DateTime MinAge { get; set; }

        public DateTime MaxAge { get; set; } = DateTime.MaxValue;

        public bool ValidAgeRange => MaxAge > MinAge;

        public string? SearchTerm { get; set; }

        public UserParameters() => OrderBy = "FullName";
    }
}
