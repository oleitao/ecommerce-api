namespace WebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    public class Shop
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public IEnumerable<ShopAvatar> ShopAvatars { get; set; }
        public int Ratings { get; set; }
    }
}