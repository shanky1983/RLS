using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Configuration.Assemblies;
using Attune.Podium.Common;
using System.Reflection;
using System.Text;
using System.Collections.Specialized;
using System.IO;
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
      
        private string isDifferent = "";
        public string ISDifferent
        {
            get { return isDifferent; }
            set { isDifferent = value; }
        }


        public DBEngine()
        {
            this.sqlTransConnection = new SqlConnection();
            this.sqlTransConnection.ConnectionString = Utilities.GetConnectionString(SqlConnectionKey.Primary);
            this.sqlTransConnection.Open();
           
        }

        public DBEngine(bool IsTransactional)
        {
            this.sqlTransConnection = new SqlConnection();
            this.sqlTransConnection.ConnectionString = Utilities.GetConnectionString(SqlConnectionKey.Primary);
            this.sqlTransConnection.Open();
        }
        public DBEngine(SqlConnectionKey pKey)
        {
            this.sqlTransConnection = new SqlConnection();
            this.sqlTransConnection.ConnectionString = Utilities.GetConnectionString(pKey);
            this.sqlTransConnection.Open();
        }

        public long ExecuteReader(SqlCommand sqlCommand, string colName, out Int64 value)
        {
            long returnCode = -1;
         
            value = 0;
            try
            {
                DateTime Startdateandtime = DateTime.Now;
                sqlCommand.Connection = sqlTransConnection;
                using (SqlDataReader dr = sqlCommand.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        value = Convert.ToInt64(dr[colName]);
                    }
                }
                LogDatabaseCalls(sqlCommand, Startdateandtime);
            }
            catch (SqlException ex)
            {
                returnCode = 1000;
                CLogger.LogError("Error while executing data reader. Query: " + sqlCommand.CommandText, ex);
            }
            finally
            {

            }
            return returnCode;
        }
        public long ExecuteReader(SqlCommand sqlCommand, string colName, out List<string> values)
        {
            long returnCode = -1;
             
            values = new List<string>();
            try
            {
                DateTime Startdateandtime = DateTime.Now;
                sqlCommand.Connection = sqlTransConnection;
                using (SqlDataReader dr = sqlCommand.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        values.Add(dr[colName].ToString());
                    }
                }
                LogDatabaseCalls(sqlCommand, Startdateandtime);
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

        public IDataReader ExecuteReader(SqlCommand sqlCommand)
        {
            IDataReader dataReader = null;
            try
            {
                DateTime Startdateandtime = DateTime.Now;
                sqlCommand.Connection = sqlTransConnection;
                using (SqlCommand cmd=sqlCommand)
                {
                    dataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                }
                LogDatabaseCalls(sqlCommand, Startdateandtime);

            }
            catch (SqlException ex)
            {
                CLogger.LogError("Error while executing data reader(returning dataReader values): Query: " + sqlCommand.CommandText, ex);
            }
            finally
            {

            }
            return dataReader;
        }

        public long ExecuteDataSet(SqlCommand sqlCommand, out DataSet dataSet)
        {
            long returnCode = -1;
            
            dataSet = new DataSet();
            try
            {
                using (SqlCommand cmd = sqlCommand)
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    sqlCommand.Connection = this.sqlTransConnection;
                    sqlDataAdapter.Fill(dataSet);
                    LogDatabaseCalls(cmd,DateTime.Now);
                    returnCode = 0;
                }
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
        /// <summary>
        /// LogDatabaseCalls method using Database trace file. Wrire the file Courent date time.
        /// </summary>
        /// <param name="ObjSqlCommand"></param>
        /// <param name="StartDatetime"></param>
        private void LogDatabaseCalls(SqlCommand ObjSqlCommand,DateTime StartDatetime )
        {
            try
            {
                object lockobj = new object();
                string ParameterCollections = string.Empty;
                string Formatstring = string.Empty;
                string DisplayType = "LogDatabaseCalls";
                Utilities objUtilities = new Utilities();
                string KeyValue = string.Empty;
                objUtilities.GetApplicationValue(DisplayType, out KeyValue);
                if (KeyValue == "Y")
                {
                    //thisFolder-->"D:\\Application\\Solution\\WepApp\\App_Data\\09-May-2012" 
                    string thisFolder = HttpContext.Current.Request.PhysicalApplicationPath + "App_Data\\" + System.DateTime.Now.ToString("dd-MMM-yyyy") + "";
                    if (Directory.Exists(thisFolder) == false)
                    {
                        Directory.CreateDirectory(thisFolder);
                    }
                    //fileName-->D:\\Application\\Solution\\WepApp\\App_Data\\09-May-2012\\DatabaseCalls_09-May-2012 13.txt
                    string fileName = thisFolder + "\\DatabaseCalls_" + System.DateTime.Now.ToString("dd-MMM-yyyy HH") + ".Txt";
                    //Find the parameters in current ObjSqlCommand
                    foreach (SqlParameter Params in ObjSqlCommand.Parameters)
                    {
                        if (Params.Value != null)
                        {
                            if (Params.DbType.ToString() == "String")
                            {
                                ParameterCollections += "'" + Params.Value.ToString() + "'" + ",";
                            }
                            else if (Params.DbType.ToString() == "DateTime")
                            {
                                ParameterCollections += "'" + Params.Value.ToString() + "'" + ",";
                            }
                            else
                            {
                                if (Params.Value.ToString() == string.Empty && Params.Direction.ToString() == "Output")
                                {
                                    ParameterCollections += "''" + ",";
                                }
                                else
                                {
                                    ParameterCollections += Params.Value.ToString() + ",";
                                }
                            }
                        }
                        else
                        {
                            ParameterCollections += ",";
                        }
                    }
                    if (ParameterCollections != string.Empty && ParameterCollections.Length > 0)
                    {
                        ParameterCollections = ParameterCollections.Remove(ParameterCollections.LastIndexOf(","));
                    }
                    DateTime Enddateandtime = DateTime.Now;
                    TimeSpan ts = Enddateandtime.Subtract(StartDatetime);
                    //Formatstring=>08/May/2012 04.48.01#pGetUser '.','DeejEaAXc/A=','akgo1gjkoe4gb445sy3jnp45',-1,'N'#08/May/2012 04.48.01#12.00000
                    Formatstring = StartDatetime.ToString("dd/MMM/yyyy HH.mm.ss") + "#" + ObjSqlCommand.CommandText.ToString() + " " + ParameterCollections + "#" + Enddateandtime.ToString("dd/MMM/yyyy HH.mm.ss") + "#" + ts.TotalSeconds.ToString();
                    lock (lockobj)
                    {
                        File.AppendAllText(fileName, Formatstring);
                        File.AppendAllText(fileName, Environment.NewLine);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("There is a problem in logging the database calls.", ex);
            }
        }

        public long ExecuteNonQuery(SqlCommand sqlCommand)
        {

            long returnCode = -1;
            try
            {
                DateTime Startdateandtime = DateTime.Now;
                sqlCommand.Connection = sqlTransConnection;
                using (SqlCommand cmd = sqlCommand)
                {
                    returnCode = cmd.ExecuteNonQuery();
                }
                LogDatabaseCalls(sqlCommand, Startdateandtime);
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
            DateTime Startdateandtime = DateTime.Now;
            sqlCommand.Connection = sqlTransConnection;
	            using (SqlCommand cmd = sqlCommand)
	            {
	                cmd.ExecuteNonQuery();
	            }
            LogDatabaseCalls(sqlCommand, Startdateandtime);

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
                if (sqlTransConnection.State == ConnectionState.Open)
                {
                    sqlTransConnection.Close();
                }

                if (this.sqlTransConnection != null)
                {
                    this.sqlTransConnection.Dispose();
                    this.sqlTransConnection = null;
                }
            }
        }

        #endregion
    }
}
