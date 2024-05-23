namespace WebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    public class ShopAvatar
    {
        public int Id { get; set; }
        public string PublicId { get; set; }
        public string Url { get; set; }
    }
}