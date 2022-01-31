using System;

namespace  Attune.KernelV2.CacheEngine
{
    public interface ICacheProvider
    {
        void Set<T>(string key, T value);

        void Set<T>(string key, T value, DateTime datetime);

        T Get<T>(string key);

        bool Remove(string key);

        bool IsInCache(string key);
    }
}
