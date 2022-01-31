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
    public class RoleMenu_DAL
    {
        ContextDetails globalContextDetails;
        public RoleMenu_DAL()
        {
            
        }
        public RoleMenu_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public long GetMenuItems(int roleID, int orgID, int parentID, out List<Alacarte> lstMenuItems)
        {
            long returnCode = -1;
            lstMenuItems = null;
            IDataReader dataReader = null;
            SqlCommand cmd = new SqlCommand();
            try
            {                
                cmd = Command.pGetMenuItemsCommand(roleID, orgID, parentID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.SharedSecondary))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstMenuItems);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in RoleMenu_DAL GetMenuItems", ex);
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

        public long GetLocationPageMap(int locationID, int roleID, int orgID, int parentID, out List<Alacarte> lstLocationPageMap)
        {
            long returnCode = -1;
            lstLocationPageMap = new List<Alacarte>();
            SqlCommand cmd = new SqlCommand();
            IDataReader dataReader = null;
            try
            {
               cmd = Command.pGetLocationPageMapCommand(locationID, roleID, orgID, parentID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstLocationPageMap);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetVitekDeviceIntegrationResult Integration_DAL", e);
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
