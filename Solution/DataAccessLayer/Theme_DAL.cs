using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.SqlClient;
using System.Collections.Generic;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities;
using Attune.Podium.Common;

namespace Attune.Solution.DAL
{
   public class Theme_DAL
    {
        ContextDetails globalContextDetails;
        public Theme_DAL()
        {
            
        }
        public Theme_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long UpdateThemeByLID(long lid, long ThemeID)
        {
            long lresult = -1;
            SqlCommand cmd = Command.pUpdateThemeByLIDCommand(lid, ThemeID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@return", SqlDbType.Int);
            cmd.Parameters["@return"].Direction = ParameterDirection.ReturnValue;

            try
            {

                using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.Shared))
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    lresult = Convert.ToInt16(cmd.Parameters["@return"].Value.ToString());
                }


            }

            catch (Exception ex)
            {
                CLogger.LogError("Error while Check login details" + cmd.CommandText, ex);
            }

            return lresult;



        }

        public long GetTheme(out List<Theme> lstTheme)
        {
            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
            lstTheme = new List<Theme>();
            IDataReader dataReader = null;
            try
            {
                cmd = Command.pGetThemeByUserCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.SharedSecondary))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstTheme);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error Loading GetTheme from Theme_DAL", ex);
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
