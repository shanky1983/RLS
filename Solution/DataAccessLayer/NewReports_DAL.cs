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
using System.Transactions;
namespace Attune.Solution.DAL
{
    public class NewReports_DAL
    {
        ContextDetails globalContextDetails;
        public NewReports_DAL()
        {

        }
        public NewReports_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        

      
        public long GetAuditTrailReport(string ExternalVisitID,string ExternalBarcode,int Orgid, out List<AuditTrailReport> lstAuditTrailReport)
        {

            long returnCode = -1;
            lstAuditTrailReport = new List<AuditTrailReport>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetAuditTrailReportCommand(ExternalVisitID,ExternalBarcode,Orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstAuditTrailReport);
                } 
                
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While GetAuditTrailReport in NewReports_DAL", ex);
            }
            return returnCode;
        }
    }
}
