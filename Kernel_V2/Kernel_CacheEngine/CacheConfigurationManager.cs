using System.Configuration;

namespace  Attune.KernelV2.CacheEngine
{

    public static class CacheConfigurationManager
    {
        #region Constants

        private const string SectionName = "CacheEngineConfiguration";

        public static CacheConfigurationSection Config
        {
            get
            {
                return (CacheConfigurationSection)ConfigurationManager.GetSection(SectionName);
            }
        }

       
        #endregion
    }
}
