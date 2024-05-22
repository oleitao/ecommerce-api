namespace WebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    public class Review
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
    }
}