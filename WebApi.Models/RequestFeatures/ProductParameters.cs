namespace WebApi.Entities.RequestFeatures
{
    public class ProductParameters : RequestParameters
    {
        public uint MinName { get; set; }

        public uint MaxName { get; set; } = 500;

        public bool ValidNameRange => MaxName > MinName;

        public string? SearchTerm { get; set; }

        public ProductParameters() => OrderBy = "Name";
    }
}
