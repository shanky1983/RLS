using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using Attune.Podium.BusinessEntities;
using ReportDataAccessLayer;
using Attune.Podium.Common;

namespace ReportBusinessLogic
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
                ReportDataAccessLayer.ReportExcel_DAL objReportDal = new ReportDataAccessLayer.ReportExcel_DAL(globalContextDetails);
                returnCode = objReportDal.GetExportReportItems(fdate, Tdate, pExcelReportId, pExcelReportName, pToExecute, OrgID, out lstReportItems, out ds);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetExportReportItems", excp);
            }

            return returnCode;
        }

        public long GetTestStatReport(DateTime FromDate, DateTime ToDate, int LocationId, int Routine, long ClientID, out DataSet DtTestStatistics)
        {
            long returnCode = -1;
            DtTestStatistics = new DataSet();
            ReportExcel_DAL objReportDal = new ReportExcel_DAL(globalContextDetails);
            try
            {

                returnCode = objReportDal.GetTestStatReport(FromDate, ToDate, LocationId, Routine, ClientID, out DtTestStatistics);
            }
            catch (Exception Ex)
            {
                CLogger.LogError("Error While  GetTestStatReport", Ex);
            }
            return returnCode;
        }

        public long GetAuditTrailReport(string ExternalVisitID, int Orgid, out List<AuditTrailReport> lstAuditTrailReport)
        {
            long returnCode = -1;
            lstAuditTrailReport = new List<AuditTrailReport>();
            ReportExcel_DAL objReportDal = new ReportExcel_DAL(globalContextDetails);
            try
            {
                returnCode = objReportDal.GetAuditTrailReport(ExternalVisitID, Orgid, out lstAuditTrailReport);
            }
            catch (Exception Ex)
            {
                CLogger.LogError("Error While  GetAuditTrailReport in NewReports_BL", Ex);
            }
            return returnCode;
        }
        public long GetListOfLabUsers(long OrgId, out List<Users> lstUsersDetails)
        {
            long returnCode = -1;
            lstUsersDetails = new List<Users>();
            ReportExcel_DAL objReportDal = new ReportExcel_DAL(globalContextDetails);
            try
            {
                returnCode = objReportDal.GetListOfLabUsers(OrgId, out lstUsersDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetListOfUsers", ex);
            }
            return returnCode;
        }

        public long GetPatientStatusDetails(DateTime pFromDate, DateTime pToDate, long pUserId, int pLocationId, string pLabNumber, string pStatus, out List<Patient> lstPatient)
        {
            long returnCode = -1;
            lstPatient = new List<Patient>();
            try
            {
                ReportExcel_DAL objReportDal = new ReportExcel_DAL(globalContextDetails);
                returnCode = objReportDal.GetPatientStatusDetails(pFromDate, pToDate, pUserId, pLocationId, pLabNumber, pStatus, out lstPatient);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetPatientStatusDetails", ex);
            }
            return returnCode;
        }
        public long GetPendingList(int OrgID, long RoleID, long InvID, string InvType, LoginDetail LDetail,
                   string IsTrustedDetails, long deviceid, long pProtocalGroupID, DateTime fromdate, DateTime todate, string pStatus, int locId, int deptId, string pGroupLevel, out List<PatientInvestigation> lstInvestigation)
        {
            long result = -1;
            lstInvestigation = new List<PatientInvestigation>();

            try
            {
                ReportExcel_DAL objReportDal = new ReportExcel_DAL(globalContextDetails);
                result = objReportDal.GetPendingList(OrgID, RoleID, InvID, InvType, LDetail, IsTrustedDetails, deviceid, pProtocalGroupID, fromdate, todate, pStatus, locId, deptId, pGroupLevel, out lstInvestigation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPendingList", ex);
            }
            return result;
        }
        public long GetPatientTrackingDetails(long OrgID, string Name, string VisitNumber, string BarcodeNumber, long VsitID, string PatientNumber,
 out List<PatientVisitDetails> lstPatientVisitDetails, out List<PatientInvSample> lstPatientInvSample, out List<PatientInvestigation> lstPatientInvestigation)
        {
            long returnCode = -1;
            lstPatientVisitDetails = new List<PatientVisitDetails>();
            lstPatientInvSample = new List<PatientInvSample>();
            lstPatientInvestigation = new List<PatientInvestigation>();
            ReportExcel_DAL objReportDal = new ReportExcel_DAL(globalContextDetails);
            try
            {
                returnCode = objReportDal.GetPatientTrackingDetails(OrgID, Name, VisitNumber, BarcodeNumber, VsitID, PatientNumber,
                    out lstPatientVisitDetails, out lstPatientInvSample, out lstPatientInvestigation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientTrackingDetails in Patient_BL", ex);
            }
            return returnCode;
        }
        public long SearchBillOptionDetails(string strBillNo, string strBillFromDate, string strBillToDate, string strPatientName, int iphysicianID, int OrgID, string PatientNumber, string ClientID, string VisitNumber, out List<BillSearch> billSearch, int pageSize, int StartRowIndex, out int totalRows, int LocationID)
        {
            long returnCode = -1;
            totalRows = 0;
            billSearch = new List<BillSearch>();
            try
            {
                ReportExcel_DAL objReportDal = new ReportExcel_DAL(globalContextDetails);
                returnCode = objReportDal.SearchBillOptionDetails(strBillNo, strBillFromDate, strBillToDate, strPatientName, iphysicianID, OrgID, PatientNumber, ClientID, VisitNumber, out billSearch, pageSize, StartRowIndex, out totalRows, LocationID);
                foreach (BillSearch bill in billSearch)
                {
                    bill.Name = bill.TitleName + ' ' + bill.Name;
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SearchBill BL", ex);
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
                ReportExcel_DAL objReportDal = new ReportExcel_DAL(globalContextDetails);

                returnCode = objReportDal.GetdropdownValuesforTATReport(OrgID, out lstOrganizationAddress, out lstInvestigationStatus);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While  GetdropdownValuesforTATReport in NewReports_BL", ex);

            }
            return returnCode;
        }

        public long GetTATAnalysisReport(DateTime FromDate, DateTime ToDate, int Routine, int LocationID, long ClientID, string FromStatus, string ToStatus, out DataSet DtlstTATAnalysis)
        {
            long returnCode = -1;
            DtlstTATAnalysis = new DataSet();
            try
            {
                ReportExcel_DAL objReportDal = new ReportExcel_DAL(globalContextDetails);
                returnCode = objReportDal.GetTATAnalysisReport(FromDate, ToDate, Routine, LocationID, ClientID, FromStatus, ToStatus, out DtlstTATAnalysis);
            }
            catch (Exception Ex)
            {
                CLogger.LogError("Error While  GetTATAnalysisReport in NewReports_BL", Ex);
            }
            return returnCode;
        }

        public long GetEpisodeReport(int trustedOrgID, int locationID, DateTime fDate, DateTime tDate, string episodeNo, string patientName, string testName, string clientName, int OrgID, out List<EpisodeReport> lstEpisodeReportList)
        {
            long returnCode = -1;
            lstEpisodeReportList = new List<EpisodeReport>();
            try
            {
                ReportExcel_DAL objReportDal = new ReportExcel_DAL(globalContextDetails);
                returnCode = objReportDal.GetEpisodeReport(trustedOrgID, locationID, fDate, tDate, episodeNo, patientName, testName, clientName, OrgID, out lstEpisodeReportList);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetEpisodeReport", ex);
            }
            return returnCode;
        }
        public long getAntibioticsstatsReport(int OrgID, DateTime FromDate, DateTime ToDate, long ClientID, out DataSet _dsStatics)
        {
            long returnCode = -1;
            _dsStatics = new DataSet();
            //  lstInvestigationValuesReport = new List<InvestigationsValueReport>();
            try
            {
                ReportExcel_DAL objReportDal = new ReportExcel_DAL(globalContextDetails);
                returnCode = objReportDal.getAntibioticsstatsReport(OrgID, FromDate, ToDate, ClientID, out _dsStatics);
            }
            catch (Exception Ex)
            {
                CLogger.LogError("Error While  GetAntibiotics Stats Report", Ex);
            }
            return returnCode;
        }
        public long GetHourlyEpisodeStatReport(int OrgID, DateTime FromDate, DateTime ToDate, out DataSet _dsHourly)
        {

            long returnCode = -1;
            _dsHourly = new DataSet();

            try
            {
                returnCode = new ReportExcel_DAL(globalContextDetails).GetHourlyEpisodeStatReport(OrgID, FromDate, ToDate, out _dsHourly);
            }
            catch (Exception Ex)
            {
                CLogger.LogError("Error While GetHourly Episode StatReport", Ex);
            }
            return returnCode;
        }
        public long GetInvestigationValuesReport(string FromDate, string ToDate, long ClientID, out List<InvestigationsValueReport> lstInvestigationValuesReport)
        {
            long returnCode = -1;
            lstInvestigationValuesReport = new List<InvestigationsValueReport>();
            try
            {
                returnCode = new ReportExcel_DAL(globalContextDetails).GetInvestigationValuesReport(FromDate, ToDate, ClientID, out lstInvestigationValuesReport);
            }
            catch (Exception Ex)
            {
                CLogger.LogError("Error While  GetInvestigationValuesReport in NewReports_BL", Ex);
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
                ReportExcel_DAL reportDAL = new ReportExcel_DAL(globalContextDetails);
                returnCode = reportDAL.CancelledBillReport(SearchType, strBillFromDate, strBillToDate, clientID, CountryID, OrgID, out lstFiftyBillSearch, out billSearch);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing CancelledBillReport ReportExcel_BL", ex);
            }
            return returnCode;
        }
        public long GetClientMappedCountryNames(long OrgID, out List<Country> lstCountry)
        {
            long returnCode = -1;
            lstCountry = new List<Country>();
            try
            {
                returnCode = new ReportExcel_DAL(globalContextDetails).GetClientMappedCountryNames(OrgID, out lstCountry);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetClientMappedCountryNames in Master_BL.cs", ex);
            }
            return returnCode;
        }
        public long GetBillsfortheDayClientMonthlyReport(string SearchType, long OrgID, long clientID, long CountryID, out List<BillsfortheDayClientWiseMonthlyReport> lstBillReportList)
        {
            long returnCode = -1;
            lstBillReportList = new List<BillsfortheDayClientWiseMonthlyReport>();

            try
            {
                ReportExcel_DAL reportDAL = new ReportExcel_DAL(globalContextDetails);
                returnCode = reportDAL.GetBillsfortheDayClientMonthlyReport(SearchType, OrgID, clientID, CountryID, out lstBillReportList);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetBillsfortheDayClientMonthlyReport ReportExcel_BL", ex);
            }
            return returnCode;
        }

        public long GetPeriodwiseMeanTATReport(int OrgId, string SearchType, DateTime strBillFromDate, DateTime strBillToDate, out List<PeriodWiseMeanTAT> lstMeanTAT)
        {
            long returnCode = -1;
            lstMeanTAT = new List<PeriodWiseMeanTAT>();
            try
            {
                ReportExcel_DAL reportDAL = new ReportExcel_DAL(globalContextDetails);
                returnCode = reportDAL.GetPeriodwiseMeanTATReport(OrgId, SearchType, strBillFromDate, strBillToDate, out lstMeanTAT);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPeriodwiseMeanTATReport ReportExcel_BL", ex);
            }
            return returnCode;
        }
        public long GetInvestigatonStatusDeptWiseReport(DateTime strBillFromDate, DateTime strBillToDate, long clientID, long CountryID, out List<InvestigatonStatusDeptWiseReport> lstDWR)
        {
            long returnCode = -1;
            lstDWR = new List<InvestigatonStatusDeptWiseReport>();

            try
            {
                ReportExcel_DAL reportDAL = new ReportExcel_DAL(globalContextDetails);
                returnCode = reportDAL.GetInvestigatonStatusDeptWiseReport(strBillFromDate, strBillToDate, clientID, CountryID, out lstDWR);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigatonStatusDeptWiseReport ReportExcel_BL", ex);
            }
            return returnCode;
        }
        public long GetBillsfortheDayTestMonthlyReport(string SearchType, long OrgID, long CountryID, int ProcessingLoc, int RegisLoc, int Category, out List<BillsfortheDayTestWiseMonthlyReport> lstTestReportList)
        {
            long returnCode = -1;
            lstTestReportList = new List<BillsfortheDayTestWiseMonthlyReport>();

            try
            {
                ReportExcel_DAL reportDAL = new ReportExcel_DAL(globalContextDetails);
                returnCode = reportDAL.GetBillsfortheDayTestMonthlyReport(SearchType, OrgID, CountryID, ProcessingLoc, RegisLoc, Category, out lstTestReportList);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetBillsfortheDayClientMonthlyReport ReportExcel_BL", ex);
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
                ReportExcel_DAL reportDAL = new ReportExcel_DAL(globalContextDetails);
                returnCode = reportDAL.GetPendingsamplesReport(OrgId, strBillFromDate, strBillToDate, out lstFiftyBillReportList, out lstBillReportList);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPendingsamplesReport ReportExcel_BL", ex);
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
                ReportExcel_DAL reportDAL = new ReportExcel_DAL(globalContextDetails);
                returnCode = reportDAL.GetBillsfortheDayReport(SearchType, strBillFromDate, strBillToDate, clientID, CountryID, out lstFiftyBillReportList, out lstBillReportList);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetBillsfortheDayReport ReportExcel_BL", ex);
            }
            return returnCode;
        }
        public long GetWeeklyMeanTATReport(int OrgId, string TestType, string SearchType, int Countryid, long Clientid, int Deptid, out List<MeanTATSummaryReport> lstMeanTAT)
        {
            long returnCode = -1;
            lstMeanTAT = new List<MeanTATSummaryReport>();
            try
            {
                ReportExcel_DAL reportDAL = new ReportExcel_DAL(globalContextDetails);
                returnCode = reportDAL.GetWeeklyMeanTATReport(OrgId, TestType, SearchType, Countryid, Clientid, Deptid, out lstMeanTAT);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetWeeklyMeanTATReport ReportExcel_BL", ex);
            }
            return returnCode;

        }
        public long GetWeeklyMeanPRETATReport(int OrgId, string TestType, string SearchType, int Countryid, long Clientid, int Deptid, out List<MeanTATSummaryReport> lstMeanTAT)
        {
            long returnCode = -1;
            lstMeanTAT = new List<MeanTATSummaryReport>();
            try
            {
                ReportExcel_DAL reportDAL = new ReportExcel_DAL(globalContextDetails);
                returnCode = reportDAL.GetWeeklyMeanPRETATReport(OrgId, TestType, SearchType, Countryid, Clientid, Deptid, out lstMeanTAT);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetWeeklyMeanTATReport ReportExcel_BL", ex);
            }
            return returnCode;

        }

        public long GetCountryWiseClientNames(string SearchText, long OrgID, long Countryid, out List<ClientMaster> lstClients)
        {
            long returnCode = -1;
            lstClients = new List<ClientMaster>();
            try
            {
                returnCode = new ReportExcel_DAL(globalContextDetails).GetCountryWiseClientNames(SearchText, OrgID, Countryid, out lstClients);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetCountryWiseClientNames in Master_BL.cs", ex);
            }
            return returnCode;
        }
        public long GetRoundNameList(string prefixText, int pOrgID, string searchType, out List<RoundMaster> lstRoundMaster)
        {
            long returnCode = -1;
            lstRoundMaster = new List<RoundMaster>();
            ReportExcel_DAL roundNameDAL = new ReportExcel_DAL(globalContextDetails);
            try
            {
                returnCode = roundNameDAL.GetRoundNameList(prefixText, pOrgID, searchType, out lstRoundMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetRoundNameList in Billing Engine", ex);
            }
            return returnCode;
        }
        public long getBloodGrpCard(int OrgID, DateTime FromDate, DateTime ToDate, int AddressID, long RoundID, out List<BloodGroupCard> lstbldgrpcrd)
        {
            long returnCode = -1;
            lstbldgrpcrd = new List<BloodGroupCard>();
            //  lstInvestigationValuesReport = new List<InvestigationsValueReport>();
            try
            {
                returnCode = new ReportExcel_DAL(globalContextDetails).getBloodGrpCard(OrgID, FromDate, ToDate, AddressID, RoundID, out lstbldgrpcrd);
            }
            catch (Exception Ex)
            {
                CLogger.LogError("Error While  GetAntibiotics Stats Report", Ex);
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
                ReportExcel_DAL reportDAL = new ReportExcel_DAL(globalContextDetails);
                returnCode = reportDAL.GetVisitWiseSearchMISReport(Orgid, Location, VisitType, VisitStatus, PatientId, VisitNo, ReferenceNo, MobileNumber,
                ClientID, RefPhyID, FromDate, ToDate, out lstVisitWiseSearchMISReport);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetVisitWiseSearchMISReport ReportExcel_BL", ex);
            }
            return returnCode;

        }
    }
}
