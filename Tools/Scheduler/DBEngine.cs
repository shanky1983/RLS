using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Configuration.Assemblies;
using Attune.Podium.Common;
//using System.Configuration;


/// <summary>
/// Summary description for DBEngine
/// </summary>
/// 
namespace Attune.Podium.DataAccessEngine
{
    public class DBEngine : IDisposable
    {
        private SqlConnection sqlTransConnection;
        private bool IsTransactional;

        public DBEngine()
        {
            this.sqlTransConnection = new SqlConnection();
            this.sqlTransConnection.ConnectionString = GetConnectionString();
            this.sqlTransConnection.Open();
            
            
        }

        public DBEngine(bool IsTransactional)
        {
            this.sqlTransConnection = new SqlConnection();
            this.sqlTransConnection.ConnectionString = GetConnectionString();
            this.sqlTransConnection.Open();
            
        }
      
        private string GetConnectionString()
        {
            string sqlConnectionString = string.Empty;
            sqlConnectionString = "Server=ashok\\SQLEXPRESS;Database=aTTUNEhEALTH; uid=SA; pwd=A$$une;";
            //Server=attune3;Database=AttuneLive; uid=AttuneLive; pwd=A$$une;

            //sqlConnectionString = ConfigurationManager.ConnectionStrings["AttHealth"].ConnectionString;
            //"Data Source = ; Initial Catalog = AttuneHealth; User ID=Attune;pwd=A$$une;Integrated Security =false";
            //"server = cindrelserver;Initial Catalog=HealthCare _Attune;uid=sa;pwd=Cindrel#14;Integrated Security =false" ;
            return sqlConnectionString;
         }




        public long ExecuteReader(SqlCommand sqlCommand, string colName, out Int64 value)
        {
            long returnCode = -1;
            SqlConnection sqlConnection = new SqlConnection();
            string sqlConnectionString = string.Empty;
            value = 0;
            try
            {

                sqlCommand.Connection = sqlTransConnection;
                using (SqlDataReader dr = sqlCommand.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        value = Convert.ToInt64(dr[colName]);
                    }
                }
            }
            catch (SqlException ex)
            {
                returnCode = 1000;
                CLogger.LogError("Error while executing data reader. Query: " + sqlCommand.CommandText , ex);
            }
            finally
            {

            }
            return returnCode;
        }



        public long ExecuteReader(SqlCommand sqlCommand,string colName, out List<string> values)
        {
            long returnCode = -1;
            SqlConnection sqlConnection = new SqlConnection();
            string sqlConnectionString = string.Empty;            
            values = new List<string>();
            try
            {
                
                sqlCommand.Connection = sqlTransConnection;
                using (SqlDataReader dr = sqlCommand.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        values.Add(dr[colName].ToString());
                    }
                }
            }
            catch (SqlException ex)
            {
                returnCode = 1000;
                CLogger.LogError("Error while executing data reader(returning List<string> values): Query: " + sqlCommand.CommandText, ex);
            }
            finally
            {
               
            }
            return returnCode;
        }


        public long ExecuteDataSet(SqlCommand sqlCommand, out DataSet dataSet)
        {
            long returnCode = -1;
            SqlConnection sqlConnection = new SqlConnection();
            string sqlConnectionString = string.Empty;
            dataSet = new DataSet();
            try
            {
                
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlConnectionString = GetConnectionString();
                sqlConnection.ConnectionString = sqlConnectionString;              
                sqlCommand.Connection = sqlConnection;
                sqlDataAdapter.Fill(dataSet);
                returnCode = 0;

            }
            catch (SqlException ex)
            {
                returnCode = 1000;
                CLogger.LogError("Error while executing data set: Query: " + sqlCommand.CommandText, ex);
            }
            finally
            {
                
            }
            return returnCode;
        }

        public long ExecuteNonQuery(SqlCommand sqlCommand)
        {          
            
            long returnCode = -1;
             try
                 {                
                    sqlCommand.Connection = sqlTransConnection;
                    returnCode = sqlCommand.ExecuteNonQuery();
                    return returnCode;
                 }
                 catch (SqlException ex)
                 {
                     //log error 
                     returnCode = 1001;
                     CLogger.LogError("Error while executing NonQuery. Query: " + sqlCommand.CommandText, ex);
                 }
                 catch (Exception ex)
                 {
                     CLogger.LogError("Exception thrown while executing NonQyery. Query: " + sqlCommand.CommandText, ex);
                    
                 }
             return returnCode;
        }           
           
       
        public void ExecuteTransactionalNonQuery(SqlCommand sqlCommand)
        {
               sqlCommand.Connection = sqlTransConnection;
               sqlCommand.ExecuteNonQuery();
        }


        #region IDisposable Members

        public void Dispose()
        {
           
            if (sqlTransConnection.State == ConnectionState.Open)
                sqlTransConnection.Close();
        }

        #endregion
    }
}
