using System.Data.Common;
using System.Data.SqlClient;
using Attune.KernelV2.Utilities;
using MySql.Data.MySqlClient;

namespace Attune.KernelV2.DataAccessEngine
{

    public class DBFactory
    {
        
        public static DbConnection GetConnection()
        {
            DataProviderType providerType = ConfigurationProvider.GetDbProvider();

            switch (providerType)
            {
                case DataProviderType.MsSql:
                    return new SqlConnection();
                case DataProviderType.MySql:
                    return new MySqlConnection();
                default:
                    return null;
            }
        }

        public static DbCommand GetCommand()
        {
            DataProviderType providerType = ConfigurationProvider.GetDbProvider();
            switch (providerType)
            {
                case DataProviderType.MsSql:
                    return new SqlCommand();
                case DataProviderType.MySql:
                    return new MySqlCommand();
                default:
                    return null;
            }
        }
    }
}
