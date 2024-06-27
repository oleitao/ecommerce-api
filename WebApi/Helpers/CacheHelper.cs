using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using StackExchange.Redis;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Helpers
{
    public static class CacheHelper
    {
        public static List<RedisKey> SearchAllKeys(IConnectionMultiplexer mupex, string region)
        {
            List<RedisKey> keys = new List<RedisKey>();
            IServer server = mupex.GetServer("localhost", 6379);
            foreach (var key in server.Keys(0, $"{region}:*", 1000))
            {
                keys.Add(key);
            }

            return keys;
        }

        public static async void SetKey<T>(T model, string key, IDistributedCache cache) where T : class
        {
            string strValue = JsonConvert.SerializeObject(model);
            await cache.SetAsync(key, Encoding.ASCII.GetBytes(strValue));
        }

        public static async Task<T> GetKey<T>(string key, IDistributedCache cache)
        {
            string cacheValue = await cache.GetStringAsync($"{key}");
            if( cacheValue is not null)
                return JsonConvert.DeserializeObject<T>(cacheValue);

            return JsonConvert.DeserializeObject<T>(string.Empty);
        }
    }
}
