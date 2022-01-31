using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Attune.Podium.BusinessEntities;
using Attune.Solution.DAL;
using Attune.Podium.Common;
using Attune.Podium.PerformingNextAction;
namespace Attune.Solution.BusinessComponent
{
    public class NewReports_BL
    {
        ContextDetails globalContextDetails;
        public NewReports_BL()
        {

        }
        public NewReports_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }


    
        public long GetAuditTrailReport(string ExternalVisitID,string ExternalBarcode,int Orgid, out List<AuditTrailReport> lstAuditTrailReport)
        {
            long returnCode = -1;
            lstAuditTrailReport = new List<AuditTrailReport>();
            try
            {
                returnCode = new NewReports_DAL(globalContextDetails).GetAuditTrailReport(ExternalVisitID,ExternalBarcode, Orgid, out lstAuditTrailReport);
            }
            catch (Exception Ex)
            {
                CLogger.LogError("Error While  GetAuditTrailReport in NewReports_BL", Ex);
            }
            return returnCode;
        }

    }
}
