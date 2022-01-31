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

namespace Attune.Solution.BusinessComponent
{
    public class ReportExcel_BL
    {
        ContextDetails globalContextDetails;
        public ReportExcel_BL()
        {

        }
        public ReportExcel_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
         public long GetExportReportItems(DateTime fdate, DateTime Tdate, int pExcelReportId, string pExcelReportName, string pToExecute, int OrgID, out List<GetReportDetails> lstReportItems, out DataSet ds)
        {
            long returnCode = -1;
            lstReportItems = null;
            ds = null;
            try
            {
                ReportExcel_DAL objReportDal = new ReportExcel_DAL(globalContextDetails);
                returnCode = objReportDal.GetExportReportItems(fdate, Tdate, pExcelReportId, pExcelReportName, pToExecute, OrgID, out lstReportItems, out ds);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetExportReportItems", excp);
            }

            return returnCode;
        }
        ///Karthick/////////////
        public long GetTNPReport(DateTime FromDate, DateTime ToDate, int orgid, out DataSet DtlstTNPReport)
        {
            long returnCode = -1;
            DtlstTNPReport = new DataSet();
            try
            {
                ReportExcel_DAL objReportDal = new ReportExcel_DAL(globalContextDetails);
                returnCode = objReportDal.GetTNPReport(FromDate, ToDate, orgid, out DtlstTNPReport);
            }
            catch (Exception Ex)
            {
                CLogger.LogError("Error While  GetTATAnalysisReport in NewReports_BL", Ex);
            }
            return returnCode;
        }
       
    }
}
