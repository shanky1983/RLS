using System;
using System.Collections.Generic;
using System.Text;
using Attune.Podium.BusinessEntities;
using Attune.Podium.DataAccessEngine;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using Attune.Podium.Common;
namespace Attune.Solution.DAL
{
    public class NavigationDAL
    {
         ContextDetails globalContextDetails;
        public NavigationDAL()
        {

        }
        public NavigationDAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        //Change dataset to datareader made by syed
        public long GetLandingPage(long roleID, out List<PageRoleMapping> relPagePath)
        {
            long returnCode = 0;
            SqlCommand sqlCommand = new SqlCommand();
			IDataReader dataReader = null;
            relPagePath = null;
            try
            {
                sqlCommand = Command.pGetLandingPageCommand(roleID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.SharedSecondary))
                {
                    dataReader = dbEngine.ExecuteReader(sqlCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out relPagePath);
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
