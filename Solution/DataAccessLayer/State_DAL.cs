using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities;
using System.Data.SqlClient;
using Attune.Podium.Common;
namespace Attune.Solution.DAL
{
    public class State_DAL
    {
        ContextDetails globalContextDetails;
        public State_DAL()
        {
            
        }
        public State_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public DataSet LoadComboState(Attune.Podium.BusinessEntities.State objState,int CountryId)
        {

            DataSet ds = new DataSet();
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Cproc_Get_HC_State";



            objCommand.Parameters.Add("@pCountryId", SqlDbType.TinyInt);
            objCommand.Parameters["@pCountryId"].Value = CountryId;

            Attune.Podium.DataAccessEngine.DBEngine objDB = new DBEngine();


            return ds;
        }

        public long GetStateByCountry(int CountryId,out List<State> states)
        {
            long returnCode = -1;
            SqlCommand sqlCommand = new SqlCommand();
			IDataReader dataReader = null;
            states = new List<State>();
            try
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "pGetStateByCountryLis";
                sqlCommand.Parameters.Add("@pCountryId", SqlDbType.TinyInt);
                sqlCommand.Parameters["@pCountryId"].Value = CountryId;
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(sqlCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out states);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetPerformingAction", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            } 
            return returnCode;
        }
    }
}
