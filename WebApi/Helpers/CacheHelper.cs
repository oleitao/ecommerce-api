using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using StackExchange.Redis;
using System.Collections.Generic;
using System.Text;

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

        public static async void SetKey<T>(T category, string key, IDistributedCache cache) where T : class
        {
            string strValue = JsonConvert.SerializeObject(category);
            await cache.SetAsync(key, Encoding.ASCII.GetBytes(strValue));
        }
    }
}
