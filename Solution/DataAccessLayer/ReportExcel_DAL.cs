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
    public class ReportExcel_DAL
    {
        ContextDetails globalContextDetails;
        public ReportExcel_DAL()
        {

        }
        public ReportExcel_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }


       public long GetExportReportItems(DateTime fdate, DateTime Tdate, int pExcelReportId, string pExcelReportName, string pToExecute, int OrgID, out List<GetReportDetails> lstReportItems, out DataSet ds)
        {
            long returnCode = -1;

            SqlCommand cmd = new SqlCommand();

            cmd = Command.pGetExecuteSpForReportExcelCommand(fdate, Tdate, pExcelReportId, pExcelReportName, pToExecute, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstReportItems = new List<GetReportDetails>();
            ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstReportItems);
            }
            return returnCode;
        }
        ///Karthick/////////////
        public long GetTNPReport(DateTime FromDate, DateTime ToDate, int orgid, out DataSet DtlstTNPReport)
        {
            long returnCode = -1;
            DtlstTNPReport = new DataSet();

            SqlCommand cmd = new SqlCommand();
            cmd = Command.PGettestnotprocessTNPReportCommand(FromDate, ToDate, orgid);
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    DtlstTNPReport = ds;
                    returnCode = 0;
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in NewReports_DAL GetTATAnalysisReport", ex);
            }
            return returnCode;
        }
      


    }
}
