using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.Common;
using Attune.Podium.BusinessEntities;
using Attune.Solution.DAL;

namespace Attune.Podium.DataAccessLayer
{
    public class EMRDAL
    {

         ContextDetails globalContextDetails;
        public EMRDAL()
        {

        }
        public EMRDAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetEMRAttributeValues(string ParentAttType, DataTable dt, string flag, out List<EMRAttributeClass> lstEMR,out int returncode)
        {
            long returnCode = -1;
            returncode = -1;
            lstEMR = new List<EMRAttributeClass>();
            DataSet ds = new DataSet();
            try
            {               
                SqlCommand cmd = Command.pEMREditCommand(dt, ParentAttType, flag,out returncode,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    returncode = Convert.ToInt32(cmd.Parameters["@return"].Value);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstEMR);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in InsertDiagnosticsPKG SmartAccessorDAL", ex);
            }
            return returnCode;
        }
    }
}
