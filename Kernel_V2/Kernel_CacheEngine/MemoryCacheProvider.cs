using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Caching;

namespace Attune.KernelV2.CacheEngine
{
    public class MemoryCacheProvider : ICacheProvider
    {
     
        private string _dns;

        public MemoryCacheProvider()
        {
            string _host = CacheConfigurationManager.Config.Host;
            _dns = CacheConfigurationManager.Config.Dns;

        }

        public void Set<T>(string key, T value)
        {
            Set(key, value, DateTime.MaxValue);
        }

        public void Set<T>(string key, T value, DateTime datetime)
        {
            key = _dns + "_" + key;
            var cache = MemoryCache.Default;
            string appPath = System.Web.Hosting.HostingEnvironment.MapPath(@"~/App_Data/");
            if (!Directory.Exists(appPath))
            {
                Directory.CreateDirectory(appPath);
            }
            string filename = appPath + "\\" + key;
            if (!File.Exists(filename))
            {
                StreamWriter writer = File.CreateText(filename);
                writer.WriteLine(".log");
                writer.Close();
            }
            var cachePolicy = new CacheItemPolicy();
            cachePolicy.AbsoluteExpiration = DateTime.SpecifyKind(datetime, DateTimeKind.Utc);
            List<string> filePaths = new List<string> {filename};
            cachePolicy.ChangeMonitors.Add(new HostFileChangeMonitor(filePaths));
            cache.Set(key, value, cachePolicy);
        }

        public T Get<T>(string key)
        {
            T result = default(T);
            key = _dns + "_" + key;
            var cache = MemoryCache.Default;
            if (cache[key] != null)
            {
                result = (T)cache[key];
            }
            return result;
        }

        public bool Remove(string key)
        {
            bool removed = false;
            key = _dns + "_" + key;
            var cache = MemoryCache.Default;
            if (cache[key] != null)
            {
                cache.Remove(key);
                removed = true;
            }

            return removed;
        }

        public bool IsInCache(string key)
        {
            key = _dns + "_" + key;
            var cache = MemoryCache.Default;
            bool isInCache = cache[key] != null;
            return isInCache;
        }
    }
}