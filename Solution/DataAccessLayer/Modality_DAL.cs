using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities;
using Attune.Podium.Common;


namespace Attune.Solution.DAL
{
    public class Modality_DAL
    {
        ContextDetails globalContextDetails;
        public Modality_DAL()
        {

        }
        public Modality_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public long GetModalityListByOrg(int orgID, out List<Modality> lstModality)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetModalityListByOrgCommand(orgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstModality = new List<Modality>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstModality);
            }
            return returnCode;
        }
        
    }
}
