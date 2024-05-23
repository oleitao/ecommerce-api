namespace WebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public char Sex { get; set; }
        public int Age { get; set; }
        public DateTime? Birthday { get; set; }
        public string Hobby { get; set; }
        public string Email { get; set; }
    }
}