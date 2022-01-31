using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities;
using System.Collections.Generic;
using Attune.Podium.Common;
using System.Data.Common;

namespace Attune.Solution.DAL
{
    public class Banners_DAL
    {
        ContextDetails globalContextDetails;
        public Banners_DAL()
        {

        }
        public Banners_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        // changed dataset to datareader by Arivalagan
        public long GetBannersText(long pRoleID, long pLoginID, int pOrgID, out List<Banners> lstBanners)
        {
            long returnCode = -1;
            lstBanners = new List<Banners>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetBannersTextCommand(pRoleID, pLoginID, pOrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                     dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstBanners);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Errror in DAL GetBannersText", ex);
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
