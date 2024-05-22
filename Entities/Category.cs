namespace WebApi.Entities
{
    using System;
    using System.Text.Json.Serialization;

    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string ImageUrl { get; set; }
    }
}