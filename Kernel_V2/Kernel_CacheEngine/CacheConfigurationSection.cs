using System.Configuration;

namespace  Attune.KernelV2.CacheEngine
{
    public class CacheConfigurationSection : ConfigurationSection
    {
        #region Constants

        private const string HostAttributeName = "host";
        private const string PortAttributeName = "port";
        private const string PasswordAttributeName = "password";
         
        private const string DnsAttributeName = "dns";
        private const string CacheProviderAttributeName = "cacheProvider";

        #endregion

        #region Properties

        [ConfigurationProperty(HostAttributeName, IsRequired = true)]
        public string Host
        {
            get { return this[HostAttributeName].ToString(); }
        }

        [ConfigurationProperty(CacheProviderAttributeName, IsRequired = false)]
        public string CacheProvider
        {
            get { return this[CacheProviderAttributeName].ToString(); }
        }

        [ConfigurationProperty(PortAttributeName, IsRequired = true)]
        public int Port
        {
            get { return (int)this[PortAttributeName]; }
        }

        [ConfigurationProperty(PasswordAttributeName, IsRequired = false)]
        public string Password
        {
            get { return this[PasswordAttributeName].ToString(); }
        }

        

        [ConfigurationProperty(DnsAttributeName, IsRequired = true)]
        public string Dns
        {
            get { return this[DnsAttributeName].ToString(); }
        }

        #endregion
    }
}
