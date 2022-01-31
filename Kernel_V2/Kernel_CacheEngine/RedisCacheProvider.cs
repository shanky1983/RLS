using ServiceStack.Redis;
using System;

namespace Attune.KernelV2.CacheEngine
{
    public class RedisCacheProvider : ICacheProvider
    {


        RedisClient _client;
        private string _dns;

        public RedisCacheProvider()
        {
            string _host = CacheConfigurationManager.Config.Host;
            int _port = CacheConfigurationManager.Config.Port;
            string _password = CacheConfigurationManager.Config.Password;
            _dns = CacheConfigurationManager.Config.Dns;
            _client = new RedisClient(_host, _port, null, 0);
        }

        public RedisCacheProvider(long dbId)
        {
            string _host = CacheConfigurationManager.Config.Host;
            int _port = CacheConfigurationManager.Config.Port;
            string _password = CacheConfigurationManager.Config.Password;
             _dns = CacheConfigurationManager.Config.Dns;
            long _db = dbId;
            _client = new RedisClient(_host, _port, null, _db);
        }

        public void Set<T>(string key, T value)
        {

            Set(key, value, DateTime.MaxValue);
        }

        public void Set<T>(string key, T value, DateTime datetime)
        {
            key = _dns + "_" + key;
            using (_client)
            {
                _client.Set(key, value, datetime);
            }
        }

        public T Get<T>(string key)
        {
            T result = default(T);
            key = _dns + "_" + key;

            using (_client)
            {
                var wrapper = _client.As<T>();

                result = wrapper.GetValue(key);
            }

            return result;
        }

        public bool Remove(string key)
        {
            bool removed;
            key = _dns + "_" + key;

            using (_client)
            {
                removed = _client.Remove(key);
            }

            return removed;
        }

        public bool IsInCache(string key)
        {
            bool isInCache;
            key = _dns + "_" + key;

            using (_client)
            {
                isInCache = _client.ContainsKey(key);
            }

            return isInCache;
        }
    }
}
