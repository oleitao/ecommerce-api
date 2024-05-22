namespace WebApi.Entities
{
    using System;
    using System.Text.Json.Serialization;
    public class ImageUrl
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string PublicUrl { get; set; }
        public string Url { get; set; }
    }
}
