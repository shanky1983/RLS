using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.SqlClient;
using Attune.Podium.Common;
using Attune.Podium.BusinessEntities;
using Attune.Podium.DataAccessEngine;
using ReportExportCommand;

namespace ReportDataAccessLayer
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

            cmd = ReportCommand.pGetExecuteSpForReportExcelCommand(fdate, Tdate, pExcelReportId, pExcelReportName, pToExecute, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
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

        public long GetTestStatReport(DateTime FromDate, DateTime ToDate, int LocationId, int Routine, long ClientID, out DataSet DtTestStatistics)
        {
            long returnCode = -1;
            DtTestStatistics = new DataSet();

            SqlCommand cmd = new SqlCommand();
            cmd = ReportCommand.pGetTestStatisticsReportCommand(FromDate, ToDate, LocationId, Routine, ClientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    DtTestStatistics = ds;
                    returnCode = 0;
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Master_DAL GetTestStatReport", ex);
            }
            return returnCode;
        }

        public long GetAuditTrailReport(string ExternalVisitID, int Orgid, out List<AuditTrailReport> lstAuditTrailReport)
        {

            long returnCode = -1;
            lstAuditTrailReport = new List<AuditTrailReport>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = ReportCommand.pGetAuditTrailReportCommand(ExternalVisitID, Orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
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

        public long GetListOfLabUsers(long OrgId, out List<Users> lstUsersDetails)
        {
            long returnCode = -1;
            lstUsersDetails = new List<Users>();

            SqlCommand cmd = ReportCommand.pGetListOfLabUsersCommand(OrgId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstUsersDetails);
            }
            return returnCode;
        }
        public long GetPatientStatusDetails(DateTime pFromDate, DateTime pToDate, long pUserId, int pLocationId, string pLabNumber, string pStatus, out List<Patient> lstPatient)
        {
            long returnCode = -1;
            lstPatient = new List<Patient>();
            try
            {

                SqlCommand cmd = ReportCommand.pGetPatientStatusDetailsCommand(pFromDate, pToDate, pUserId, pLocationId, pLabNumber, pStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatient);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetPatientStatusDetails", ex);
            }
            return returnCode;
        }

        public long GetPendingList(int OrgID, long RoleID, long InvID, string InvType, LoginDetail LDetail,
                          string IsTrustedDetails, long deviceid, long pProtocalGroupID, DateTime fromdate, DateTime todate, string pStatus, int LocationID, int DepartmentID, string pGroupLevel, out List<PatientInvestigation> lstInvestigation)
        {
            long result = -1;
            lstInvestigation = new List<PatientInvestigation>();
            DataTable DtLDetail = UDT_DAL.ConvertToLoginDetail(LDetail);
            SqlCommand cmd = ReportCommand.pGetPendingListCommand(OrgID, RoleID, InvID, InvType, DtLDetail, IsTrustedDetails, deviceid, pProtocalGroupID, fromdate, todate, pStatus, LocationID, DepartmentID, pGroupLevel, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        result = Utilities.ConvertTo(ds.Tables[0], out lstInvestigation);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPendingList Investigation_DAL", ex);
            }

            return result;
        }

        public long GetPatientTrackingDetails(long OrgID, string Name, string VisitNumber, string BarcodeNumber, long VsitID, string PatientNumber,
out List<PatientVisitDetails> lstPatientVisitDetails, out List<PatientInvSample> lstPatientInvSample,
out List<PatientInvestigation> lstPatientInvestigation)
        {
            long returnCode = -1;
            lstPatientVisitDetails = new List<PatientVisitDetails>();
            lstPatientInvSample = new List<PatientInvSample>();
            lstPatientInvestigation = new List<PatientInvestigation>();
            SqlCommand cmd = ReportCommand.pGetPatientTrackingDetailsCommand(OrgID, Name, VisitNumber, BarcodeNumber, VsitID, PatientNumber, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientVisitDetails);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPatientInvSample);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPatientInvestigation);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientTrackingDetails in Patient_DAL", ex);
            }
            return returnCode;
        }
        public long SearchBillOptionDetails(string strBillNo, string strBillFromDate, string strBillToDate, string strPatientName, int iPhysicianID, int OrgID, string PatientNumber, string ClientID, string VisitNumber, out List<BillSearch> billSearch, int pageSize, int StartRowIndex, out int totalRows, int LocationID)
        {
            long returnCode = -1;
            System.Data.SqlClient.SqlCommand cmd;
            cmd = ReportCommand.pSearchBillDetailsCommand(strBillNo, strBillFromDate, strBillToDate, strPatientName, iPhysicianID, OrgID, PatientNumber, ClientID, VisitNumber, pageSize, StartRowIndex, out totalRows, LocationID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            billSearch = new List<BillSearch>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out billSearch);
                totalRows = Convert.ToInt32(ds.Tables[1].Rows[0]["totalRows"]);
            }
            return returnCode;
        }

        public long GetdropdownValuesforTATReport(int OrgID, out List<OrganizationAddress> lstOrganizationAddress, out List<InvestigationStatus> lstInvestigationStatus)
        {

            long returnCode = -1;
            lstOrganizationAddress = new List<OrganizationAddress>();
            lstInvestigationStatus = new List<InvestigationStatus>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = ReportCommand.pGetdropdownValuesforTATReportCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstOrganizationAddress);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstInvestigationStatus);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While GetdropdownValuesforTATReport in NewReports_DAL", ex);
            }
            return returnCode;
        }

        public long GetTATAnalysisReport(DateTime FromDate, DateTime ToDate, int Routine, int LocationID, long ClientID, string FromStatus, string ToStatus, out DataSet DtlstTATAnalysis)
        {
            long returnCode = -1;
            DtlstTATAnalysis = new DataSet();

            SqlCommand cmd = new SqlCommand();
            cmd = ReportCommand.PgetTATAnalysisreportCommand(FromDate, ToDate, Routine, LocationID, ClientID, FromStatus, ToStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    DtlstTATAnalysis = ds;
                    returnCode = 0;
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in NewReports_DAL GetTATAnalysisReport", ex);
            }
            return returnCode;
        }
        public long GetEpisodeReport(int trustedOrgID, int locationID, DateTime fDate, DateTime tDate, string episodeNo, string patientName, string testName, string clientName, int OrgID, out List<EpisodeReport> lstEpisodeReportList)
        {
            long returnCode = -1;
            lstEpisodeReportList = new List<EpisodeReport>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = ReportCommand.pGetEpisodeReportCommand(trustedOrgID, locationID, fDate, tDate, episodeNo, patientName, testName, clientName, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstEpisodeReportList);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetEpisodeReport", ex);
            }
            return returnCode;
        }
        public long getAntibioticsstatsReport(int OrgID, DateTime FromDate, DateTime ToDate, long ClientID, out DataSet _dsStatics)
        {
            long returnCode = -1;
            _dsStatics = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = ReportCommand.pgetAntibioticsstatsReportCommand(OrgID, FromDate, ToDate, ClientID);
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    _dsStatics = ds;
                    returnCode = 0;
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in NewReports_DAL GetAntibiotics Stats Report", ex);
            }
            return returnCode;
        }
        public long GetHourlyEpisodeStatReport(int OrgID, DateTime FromDate, DateTime ToDate, out DataSet _dsHourly)
        {
            long returnCode = -1;
            _dsHourly = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = ReportCommand.pGetHourlyBasedStatisticsReportnewCommand(OrgID, FromDate, ToDate, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    _dsHourly = ds;
                    returnCode = 0;
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in NewReports_DAL GetHourly Episode StatReport", ex);
            }
            return returnCode;
        }
        public long GetInvestigationValuesReport(string FromDate, string ToDate, long ClientID, out List<InvestigationsValueReport> lstInvestigationValuesReport)
        {
            long returnCode = -1;
            lstInvestigationValuesReport = new List<InvestigationsValueReport>();

            SqlCommand cmd = new SqlCommand();
            cmd = ReportCommand.pGetInvestigationsValueReportCommand(FromDate, ToDate, ClientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvestigationValuesReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in NewReports_DAL GetInvestigationValuesReport", ex);
            }
            return returnCode;
        }
        public long CancelledBillReport(string SearchType, string strBillFromDate, string strBillToDate, long clientID, long CountryID, int OrgID, out List<CancelledBillReport> lstFiftyBillSearch, out List<CancelledBillReport> billSearch)
        {
            long returnCode = -1;
            billSearch = new List<CancelledBillReport>();
            lstFiftyBillSearch = new List<CancelledBillReport>();
            try
            {
                System.Data.SqlClient.SqlCommand cmd;
                cmd = ReportCommand.pGetCancelledBillReportCommand(SearchType, strBillFromDate, strBillToDate, clientID, CountryID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstFiftyBillSearch);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out billSearch);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While Get CancelledBillReport", ex);
            }
            return returnCode;
        }

        public long GetClientMappedCountryNames(long OrgID, out List<Country> lstCountry)
        {
            long returnCode = -1;
            lstCountry = new List<Country>();
            try
            {
                SqlCommand cmd = ReportCommand.pGetClientMappedCountryNamesCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstCountry);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetClientMappedCountryNames", ex);
            }
            return returnCode;

        }
        public long GetBillsfortheDayClientMonthlyReport(string SearchType, long OrgID, long clientID, long CountryID, out List<BillsfortheDayClientWiseMonthlyReport> lstBillReportList)
        {
            long returnCode = -1;
            lstBillReportList = new List<BillsfortheDayClientWiseMonthlyReport>();

            try
            {
                System.Data.SqlClient.SqlCommand cmd;
                cmd = ReportCommand.pGetBillsfortheDayClientWiseMonthlyReportCommand(SearchType, OrgID, clientID, CountryID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBillReportList);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While Get GetBillsfortheDayClientMonthlyReport", ex);
            }
            return returnCode;
        }

        public long GetPeriodwiseMeanTATReport(int OrgId, string SearchType, DateTime strBillFromDate, DateTime strBillToDate, out List<PeriodWiseMeanTAT> lstMeanTAT)
        {
            long returnCode = -1;
            lstMeanTAT = new List<PeriodWiseMeanTAT>();
            try
            {
                System.Data.SqlClient.SqlCommand cmd;
                cmd = ReportCommand.pGetPeriodwiseMeanTATReportCommand(OrgId, SearchType, strBillFromDate, strBillToDate, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstMeanTAT);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While Get GetPeriodwiseMeanTATReport", ex);
            }
            return returnCode;
        }
        public long GetInvestigatonStatusDeptWiseReport(DateTime strBillFromDate, DateTime strBillToDate, long clientID, long CountryID, out List<InvestigatonStatusDeptWiseReport> lstDWR)
        {
            long returnCode = -1;
            lstDWR = new List<InvestigatonStatusDeptWiseReport>();
            try
            {
                System.Data.SqlClient.SqlCommand cmd;
                cmd = ReportCommand.pGetInvestigationStatusDeptWiseReportCommand(strBillFromDate, strBillToDate, clientID, CountryID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDWR);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While Get CancelledBillReport", ex);
            }
            return returnCode;
        }
        public long GetBillsfortheDayTestMonthlyReport(string SearchType, long OrgID, long CountryID, int ProcessingLoc, int RegisLoc, int Category, out List<BillsfortheDayTestWiseMonthlyReport> lstTestReportList)
        {
            long returnCode = -1;
            lstTestReportList = new List<BillsfortheDayTestWiseMonthlyReport>();

            try
            {
                System.Data.SqlClient.SqlCommand cmd;
                cmd = ReportCommand.pGetBillsfortheDaytestWiseMonthlyReportCommand(SearchType, OrgID, CountryID, ProcessingLoc, RegisLoc, Category, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstTestReportList);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While Get GetBillsfortheDayClientMonthlyReport", ex);
            }
            return returnCode;
        }
        public long GetWeeklyMeanPRETATReport(int OrgId, string TestType, string SearchType, int Countryid, long Clientid, int Deptid, out List<MeanTATSummaryReport> lstMeanTAT)
        {
            long returnCode = -1;
            lstMeanTAT = new List<MeanTATSummaryReport>();
            try
            {
                System.Data.SqlClient.SqlCommand cmd;
                cmd = ReportCommand.pGetWeeklyPreTATReportCommand(OrgId, TestType, SearchType, Countryid, Clientid, Deptid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstMeanTAT);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While Get GetWeeklyMeanTATReport", ex);
            }
            return returnCode;
        }
        public long GetPendingsamplesReport(int OrgId, DateTime strBillFromDate, DateTime strBillToDate, out List<PendingsamplesReport> lstFiftyBillReportList, out List<PendingsamplesReport> lstBillReportList)
        {
            long returnCode = -1;
            lstBillReportList = new List<PendingsamplesReport>();
            lstFiftyBillReportList = new List<PendingsamplesReport>();
            try
            {
                System.Data.SqlClient.SqlCommand cmd;
                cmd = ReportCommand.pGetPendingsamplesReportCommand(OrgId, strBillFromDate, strBillToDate, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstFiftyBillReportList);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstBillReportList);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While Get GetPendingsamplesReport", ex);
            }
            return returnCode;
        }
        public long GetBillsfortheDayReport(string SearchType, string strBillFromDate, string strBillToDate, long clientID, long CountryID, out List<BillsfortheDayReport> lstFiftyBillReportList, out List<BillsfortheDayReport> lstBillReportList)
        {
            long returnCode = -1;
            lstBillReportList = new List<BillsfortheDayReport>();
            lstFiftyBillReportList = new List<BillsfortheDayReport>();
            try
            {
                System.Data.SqlClient.SqlCommand cmd;
                cmd = ReportCommand.pGetBillsfortheDayReportCommand(SearchType, strBillFromDate, strBillToDate, clientID, CountryID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstFiftyBillReportList);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstBillReportList);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While Get GetBillsfortheDayReport", ex);
            }
            return returnCode;
        }
        public long GetWeeklyMeanTATReport(int OrgId, string TestType, string SearchType, int Countryid, long Clientid, int Deptid, out List<MeanTATSummaryReport> lstMeanTAT)
        {
            long returnCode = -1;
            lstMeanTAT = new List<MeanTATSummaryReport>();
            try
            {
                System.Data.SqlClient.SqlCommand cmd;
                cmd = ReportCommand.pGetWeeklyMeanTATReportCommand(OrgId, TestType, SearchType, Countryid, Clientid, Deptid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstMeanTAT);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While Get GetWeeklyMeanTATReport", ex);
            }
            return returnCode;
        }
        public long GetCountryWiseClientNames(string SearchText, long OrgID, long Countryid, out List<ClientMaster> lstClients)
        {
            long returnCode = -1;
            lstClients = new List<ClientMaster>();
            try
            {
                SqlCommand cmd = ReportCommand.pGetCountryWiseClientNamesCommand(SearchText, OrgID, Countryid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstClients);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetCountryWiseClientNames", ex);
            }
            return returnCode;

        }
        public long GetRoundNameList(string prefixText, int pOrgID, string searchType, out List<RoundMaster> lstRoundMaster)
        {
            long returnCode = -1;
            lstRoundMaster = new List<RoundMaster>();
            SqlCommand cmd = ReportCommand.pGetRoundNameListCommand(prefixText, pOrgID, searchType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstRoundMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientListForQuickBill in Inventory_DAL", ex);
            }
            return returnCode;
        }
        public long getBloodGrpCard(int OrgID, DateTime FromDate, DateTime ToDate, int AddressID, long RoundID, out List<BloodGroupCard> lstbldgrpcrd)
        {
            long returnCode = -1;
            lstbldgrpcrd = new List<BloodGroupCard>();
            SqlCommand cmd = new SqlCommand();
            cmd = ReportCommand.pGetBloodGroupCardCommand(OrgID, FromDate, ToDate, AddressID, RoundID);
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstbldgrpcrd);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in NewReports_DAL GetAntibiotics Stats Report", ex);
            }
            return returnCode;
        }
        public long GetVisitWiseSearchMISReport(long Orgid, long Location, long VisitType, string VisitStatus, long PatientId, string VisitNo, string ReferenceNo, long MobileNumber, long ClientID,
             long RefPhyID, string FromDate, string ToDate, out List<VisitWiseSearchMISReport> lstVisitWiseSearchMISReport)
        {
            long returnCode = -1;
            lstVisitWiseSearchMISReport = new List<VisitWiseSearchMISReport>();
            try
            {

                System.Data.SqlClient.SqlCommand cmd;
                cmd = ReportCommand.pGetVisitWiseSearchMISReportCommand(Orgid, Location, VisitType, VisitStatus, PatientId, VisitNo, ReferenceNo, MobileNumber,
                ClientID, RefPhyID, FromDate, ToDate, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstVisitWiseSearchMISReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetVisitWiseSearchMISReport ReportExcel_BL", ex);
            }
            return returnCode;

        }
    }
}
