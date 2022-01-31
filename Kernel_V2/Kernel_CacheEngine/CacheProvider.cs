using System;

namespace Attune.KernelV2.CacheEngine
{
    //public class CacheKey
    //{
    //    public const string
    //    MenuCache = "{0}_MenuCache",
    //    MetaDataCache = "{0}_MetaData",
    //    MetaValueCache = "{0}_MetaValue",        
    //    ConfigCache = "{0}_Config",

    //    SalutationCache = "Salutation",
    //    CountryCache = "Country",
    //    StateCache = "State";
    //}

    public class CacheProvider : ICacheProvider
    {
        public string GetKey(string pKey, int pOrgId)
        {
            return string.Format(pKey, pOrgId);
        }
        ICacheProvider _cacheProvider;
        public CacheProvider()
        {
            switch (CacheConfigurationManager.Config.CacheProvider)
            {
                case "redis":
                    _cacheProvider = new RedisCacheProvider();
                    break;
                default:
                    _cacheProvider = new MemoryCacheProvider();
                    break;
            }

        }
        public CacheProvider(long dbId)
        {
            switch (CacheConfigurationManager.Config.CacheProvider)
            {
                case "redis":
                    _cacheProvider = new RedisCacheProvider(dbId);
                    break;
                default:
                    _cacheProvider = new MemoryCacheProvider();
                    break;
            }
        }
        public T Get<T>(string key)
        {
            return _cacheProvider.Get<T>(key);
        }
        public bool IsInCache(string key)
        {
            return _cacheProvider.IsInCache(key);
        }
        public bool Remove(string key)
        {
            return _cacheProvider.Remove(key);
        }
        public void Set<T>(string key, T value)
        {
            _cacheProvider.Set<T>(key, value);
        }
        public void Set<T>(string key, T value, DateTime datetime)
        {
            _cacheProvider.Set<T>(key, value, datetime);
        }
    }
}
