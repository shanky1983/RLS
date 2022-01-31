using System.Configuration;
using Attune.Cryptography;
using Attune.KernelV2.Utilities;

namespace Attune.KernelV2.DataAccessEngine
{
    public class ConfigurationProvider
    {
        
        public static string GetConnectionString()
        {
            string transConnection = ConfigurationManager.ConnectionStrings[Constants.DATABASE_CONNECTION_CONFIG_KEY].ConnectionString;
            CCryptography obj = new CCryptFactory().GetDecryptor();
            obj.Crypt(transConnection, out transConnection);
            return transConnection;
        }
        public static string GetConnectionString(string connectionStrings)
        {
            string transConnection = ConfigurationManager.ConnectionStrings[connectionStrings].ConnectionString;
            return transConnection;
        }
        public static DataProviderType GetDbProvider()
        {
            return  DataProviderType.MsSql;
            
        }
            



    }
}
