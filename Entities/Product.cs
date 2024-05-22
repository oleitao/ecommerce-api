namespace WebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    public class Product
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Discount_Price { get; set; }
        public int Rating { get; set; }
        public int Total_Sell { get; set; }
        public int Stock { get; set; }
    }
}