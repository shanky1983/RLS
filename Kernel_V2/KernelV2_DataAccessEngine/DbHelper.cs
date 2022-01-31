using System;
using System.Data;
using System.Data.Common;

namespace Attune.KernelV2.DataAccessEngine
{
    public class DbHelper : IDisposable
    {
        public DbConnection dbConnection { get; set; }

        public DbHelper()
        {
            dbConnection = DBFactory.GetConnection();
            dbConnection.ConnectionString = ConfigurationProvider.GetConnectionString();
            dbConnection.Open();
        }


        public  DbDataReader ExecuteReader(DbCommand myCommand)
        {
             
            myCommand.Connection = dbConnection;
            DbDataReader dbDataReader = myCommand.ExecuteReader();
            return dbDataReader;
        }

        public  long ExecuteNonQuery(DbCommand myCommand)
        {
            
            myCommand.Connection = dbConnection;
            long returnCode = myCommand.ExecuteNonQuery();
            return returnCode;
        }

        public void Close()
        {
            if (dbConnection.State == ConnectionState.Open)
                dbConnection.Close();
        }

        #region IDisposable Members

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (dbConnection != null)
                {
                    dbConnection.Dispose();
                    dbConnection = null;
                }
            }
        }

        #endregion
    }
}

