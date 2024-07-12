using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System.Text;

namespace WebApi.Tests
{
    public abstract class BaseTest
    {
        public HttpClient Client { get; set; }
        public string ApiUri { get; set; }
        public BaseTest()
        {
            var appFactory = new WebApplicationFactory<Startup>();
            Client = appFactory.CreateClient();
            ApiUri = Client?.BaseAddress?.AbsoluteUri;
        }

        public StringContent JsonData<T>(T data)
        {
            var json = JsonConvert.SerializeObject(data);
            return new StringContent(json, Encoding.UTF8, "application/json");
        }
        public T ObjectData<T>(string json)
        {
            var result = JsonConvert.DeserializeObject<T>(json);
            return result;
        }

        public string GetJson(string file)
        {
            return File.ReadAllText(Directory.GetCurrentDirectory() + @"\json\" + file);
        }
    }
}