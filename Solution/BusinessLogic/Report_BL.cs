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
using Attune.Podium.BusinessEntities.CustomEntities;

namespace Attune.Solution.BusinessComponent
{
    public class Report_BL
    {
        ContextDetails globalContextDetails;
        public Report_BL()
        {

        }
        public Report_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetReportItems(long roleID, long orgID, out List<GetReportDetails> lstGroupItems, out List<GetReportDetails> lstReportItems)
        {
            long returnCode = -1;
            lstGroupItems = null;
            lstReportItems = null;
            try
            {
                Report_DAL objReportDal = new Report_DAL(globalContextDetails);
                returnCode = objReportDal.GetReportItems(roleID, orgID, out lstGroupItems, out lstReportItems);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetReportItems", excp);
            }

            return returnCode;
        }

        public long GetReportPath(long ReportID, out List<ReportMaster> ReportName)
        {
            ReportName = new List<ReportMaster>();
            long returnCode = -1;
            try
            {
                Report_DAL objReportDal = new Report_DAL(globalContextDetails);
                returnCode = objReportDal.GetReportPath(ReportID, out ReportName);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetReportPath", excp);
            }

            return returnCode;
        }
        public long GetCommunicableDiseasesICD(int OrgID, out List<CommunicableDiseaseMaster> CDS)
        {
            long returnCode = -1;
            CDS = new List<CommunicableDiseaseMaster>();
            try
            {
                Report_DAL objReportDAL = new Report_DAL(globalContextDetails);
                returnCode = objReportDAL.GetCommunicableDiseasesICD(OrgID, out CDS);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetReportCommunicableDiseases", ex);
            }
            return returnCode;
        }


        public long GetInvestigationCollectionReport(List<OrderedInvestigations> OrderedInves, DateTime strBillFromDate, DateTime strBillToDate, int OrgID, string Type, out List<BillLineItems> resultItems)
        {
            long returnCode = -1;
            resultItems = new List<BillLineItems>();

            try
            {
                Report_DAL reportDAL = new Report_DAL(globalContextDetails);

                returnCode = reportDAL.GetInvestigationCollectionReport(OrderedInves, strBillFromDate, strBillToDate, OrgID, Type, out resultItems);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing pGetItemWiseReport Report_BL", e);
            }
            return returnCode;
        }



        public long GetScheduleDrugsReport(DateTime pFromDate, DateTime pToDate, int pOrgID, int LocationID, out List<BillingDetails> lBillingDetails)
        {
            lBillingDetails = new List<BillingDetails>();
            long returnCode = -1;
            try
            {
                Report_DAL objReportDal = new Report_DAL(globalContextDetails);
                returnCode = objReportDal.GetScheduleDrugsReport(pFromDate, pToDate, pOrgID, LocationID, out lBillingDetails);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetStockReport", excp);
            }

            return returnCode;
        }
        public long GetCommunicableDiseasesReport(int OrgID, DateTime fromdate, DateTime todate, string ICDCode, out List<PatientVisit> patientVisit)
        {
            long returnCode = -1;
            patientVisit = new List<PatientVisit>();
            try
            {
                Report_DAL objReportDAL = new Report_DAL(globalContextDetails);
                returnCode = objReportDAL.GetCommunicableDiseasesReport(OrgID, fromdate, todate, ICDCode, out patientVisit);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetCommunicableDiseasesReport", ex);
            }
            return returnCode;
        }
        public long GetCollectionReportOPIP(DateTime pFromDate, DateTime pToDate, int pOrgID, long pLID, int pVisitType, int CurrencyID, out List<DayWiseCollectionReport> lstDayWiseReport, out decimal pTotalBillAmt, out decimal pTotalPreDueReceived, out decimal pTotalDiscount, out decimal pTotalNetValue, out decimal pTotalReceivedAmt, out decimal pTotalDue, out decimal pTax, out decimal pServiceCharge)
        {
            long returnCode = -1;
            lstDayWiseReport = new List<DayWiseCollectionReport>();
            pTotalBillAmt = -1;
            pTotalPreDueReceived = -1;
            pTotalDiscount = -1;
            pTotalNetValue = -1;
            pTotalReceivedAmt = -1;
            pTotalDue = -1;
            pTax = -1;
            pServiceCharge = -1;
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetCollectionReportOPIP(pFromDate, pToDate, pOrgID, pLID, pVisitType, CurrencyID, out lstDayWiseReport, out pTotalBillAmt, out pTotalPreDueReceived, out pTotalDiscount, out pTotalNetValue, out pTotalReceivedAmt, out pTotalDue, out pTax, out pServiceCharge);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetCollectionReportOPIP", ex);
            }
            return returnCode;
        }
        public long GetBillWiseReportOPIP(DateTime pFromDate, DateTime pToDate, int pOrgID, long pLID, int pVisitType, int CurrencyID, out List<DayWiseCollectionReport> lstDayWiseReport, out decimal pTotalBillAmt, out decimal pTotalPreDueReceived, out decimal pTotalDiscount, out decimal pTotalNetValue, out decimal pTotalReceivedAmt, out decimal pTotalDue, out decimal pTax, out decimal pServiceCharge)
        {
            long returnCode = -1;
            lstDayWiseReport = new List<DayWiseCollectionReport>();
            pTotalBillAmt = -1;
            pTotalPreDueReceived = -1;
            pTotalDiscount = -1;
            pTotalNetValue = -1;
            pTotalReceivedAmt = -1;
            pTotalDue = -1;
            pTax = -1;
            pServiceCharge = -1;
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetBillWiseReportOPIP(pFromDate, pToDate, pOrgID, pLID, pVisitType, CurrencyID, out lstDayWiseReport, out pTotalBillAmt, out pTotalPreDueReceived, out pTotalDiscount, out pTotalNetValue, out pTotalReceivedAmt, out pTotalDue, out pTax, out pServiceCharge);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetCollectionReportOPIP", ex);
            }
            return returnCode;
        }
        public long GetRoomCollectionReportIP(DateTime pFromDate, DateTime pToDate, int pOrgID, out List<DayWiseCollectionReport> lstDayWiseReport, out decimal pTotal, long pOrgAddId)
        {
            long returnCode = -1;
            lstDayWiseReport = new List<DayWiseCollectionReport>();
            pTotal = -1;
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetRoomCollectionReportIP(pFromDate, pToDate, pOrgID, out lstDayWiseReport, out pTotal, pOrgAddId);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetRoomCollectionReportIP", ex);
            }
            return returnCode;
        }

        public long GetCollectionReportDeptWise(DateTime pFromDate, DateTime pToDate, int pOrgID, long pLID, int pVisitType, out List<DayWiseCollectionReport> lstDeptWiseReport, out decimal pTotalBillAmt, out decimal pTotalPreDueReceived, out decimal pTotalDiscount, out decimal pTotalNetValue, out decimal pTotalReceivedAmt, out decimal pTotalDue, out decimal pTax, out decimal pServiceCharge)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            pTotalBillAmt = -1;
            pTotalPreDueReceived = -1;
            pTotalDiscount = -1;
            pTotalNetValue = -1;
            pTotalReceivedAmt = -1;
            pTotalDue = -1;
            pTax = -1;
            pServiceCharge = -1;
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetCollectionReportDeptWise(pFromDate, pToDate, pOrgID, pLID, pVisitType, out lstDeptWiseReport, out pTotalBillAmt, out pTotalPreDueReceived, out pTotalDiscount, out pTotalNetValue, out pTotalReceivedAmt, out pTotalDue, out pTax, out pServiceCharge);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetCollectionReportDeptWise", ex);
            }
            return returnCode;
        }

        public long GetCollectionRptDptWiseOPIP(DateTime pFromDate, DateTime pToDate, int pOrgID, long pLID, int pVisitType, out List<DayWiseCollectionReport> lstDeptWiseReport, out decimal pTotalItemAmt, out decimal pTotalDiscount, out decimal pTotalReceivedAmt, out decimal pTotalDue, out decimal pTax, out decimal pServiceCharge, string reportType)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            pTotalItemAmt = -1;
            pTotalDiscount = -1;
            pTotalReceivedAmt = -1;
            pTotalDue = -1;
            pTax = -1;
            pServiceCharge = -1;
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetCollectionRptDptWiseOPIP(pFromDate, pToDate, pOrgID, pLID, pVisitType, out lstDeptWiseReport, out pTotalItemAmt, out pTotalDiscount, out pTotalReceivedAmt, out pTotalDue, out pTax, out pServiceCharge, reportType);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetCollectionRptDptWiseOPIP", ex);
            }
            return returnCode;
        }
        public long GetDepartmentWiseDetailReportPopUp(DateTime pFromDate, DateTime pToDate, int pOrgID, int pVisitType, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetDepartmentWiseDetailReportPopUp(pFromDate, pToDate, pOrgID, pVisitType, out lstDeptWiseReport);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetDepartmentWiseDetailReportPopUp", ex);
            }
            return returnCode;
        }
        public long GetCollectionRptIndDeptOPIP(DateTime pFDate, DateTime pTDate, int pOrgID, int pVisitType, string feeType, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetCollectionRptIndDeptOPIP(pFDate, pTDate, pOrgID, pVisitType, feeType, out lstDeptWiseReport);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetCollectionRptIndDeptOPIP", ex);
            }
            return returnCode;
        }


        public long GetCreditCardStmt(DateTime pFromDate, DateTime pToDate, int pOrgID, int pVisitType, int pLocation, int pReportType, string Receivedby, string PatientName, out List<DayWiseCollectionReport> lstDeptWiseReport, out decimal pTotalCardAmt, out decimal pTotalServiceCharge, int PaymentTypeID)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            pTotalCardAmt = -1;
            pTotalServiceCharge = -1;
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetCreditCardStmt(pFromDate, pToDate, pOrgID, pVisitType, pLocation, pReportType, Receivedby, PatientName, out lstDeptWiseReport, out pTotalCardAmt, out pTotalServiceCharge, PaymentTypeID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetCreditCardStmt", ex);
            }
            return returnCode;
        }
        public long GetUserwiseAuthorisedBy(long orgID, out List<Users> Users, out List<OrgUsers> OrgUsers)
        {
            Users = new List<Users>();
            OrgUsers = new List<OrgUsers>();
            long returnCode = -1;
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetUserwiseAuthorisedBy(orgID, out Users, out  OrgUsers);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Userwise and Authorized by details using pGetUserwiseAuthorisedBy sp", ex);
            }
            return returnCode;
        }
        public long GetDueandDiscount(DateTime pFromDate, DateTime pToDate, int pOrgID, int pVisitType, string pRequestType, string PName, string PNo, out List<DayWiseCollectionReport> lstDeptWiseReport, out decimal pTotalDiscount)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            pTotalDiscount = -1;
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetDueandDiscount(pFromDate, pToDate, pOrgID, pVisitType, pRequestType, PName, PNo, out lstDeptWiseReport, out pTotalDiscount);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetDueandDiscount", ex);
            }
            return returnCode;
        }
        public long GetPatientReport(string pFromDate, string pToDate, int pOrgID, int pVisitType, string pRequestType, int pSpecialityID, long phyID, List<DayWiseCollectionReport> lstSpecialityIDs, List<DayWiseCollectionReport> lstPhysicianIDs, out List<DayWiseCollectionReport> lstDeptWiseReport, out List<Physician> lstPhysician)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            lstPhysician = new List<Physician>();


            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetPatientReport(pFromDate, pToDate, pOrgID, pVisitType, pRequestType, pSpecialityID, phyID, lstSpecialityIDs, lstPhysicianIDs, out lstDeptWiseReport, out lstPhysician);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetPatientReport", ex);
            }
            return returnCode;
        }

        public long GetSurgeryTeamWiseReport(DataTable dt, DateTime pFromDate, DateTime pToDate, int pOrgID, long pSurgenID, long pAnesthetistID, string pTreatmentName, string pSearchType, out List<SurgeryBillingMaster> lstSurgeryBillingMaster, out List<Physician> lstSurgeon, out List<Physician> lstAnesthetist, out List<SurgeryBillingMaster> lstTreatmentName)
        {

            long returnCode = -1;
            lstSurgeryBillingMaster = new List<SurgeryBillingMaster>();
            lstSurgeon = new List<Physician>();
            lstAnesthetist = new List<Physician>();
            lstTreatmentName = new List<SurgeryBillingMaster>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetSurgeryTeamWiseReport(dt, pFromDate, pToDate, pOrgID, pSurgenID, pAnesthetistID, pTreatmentName, pSearchType, out lstSurgeryBillingMaster, out lstSurgeon, out lstAnesthetist, out lstTreatmentName);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetPatientReport", ex);
            }
            return returnCode;
        }

        public long GetVacantRoomReport(DateTime fDate, DateTime tDate, int pOrgID, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetVacantRoomReport(fDate, tDate, pOrgID, out lstDeptWiseReport);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetVacantRoomReport", ex);
            }
            return returnCode;
        }

        public long GetBirthStatisticsReport(DateTime fDate, DateTime tDate, int pOrgID, long pLoginID, int pProType, int pDeliveryType, string psex, out List<Patient> lstBirthStat)
        {
            long returnCode = -1;
            lstBirthStat = new List<Patient>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetBirthStatisticsReport(fDate, tDate, pOrgID, pLoginID, pProType, pDeliveryType, psex, out lstBirthStat);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetBirthStatisticsReport", ex);
            }
            return returnCode;
        }

        public long GetLabStatisticsReport(DateTime fDate, DateTime tDate, int pOrgID, int pVisitType, string pHeaderName, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetLabStatisticsReport(fDate, tDate, pOrgID, pVisitType, pHeaderName, out lstDeptWiseReport);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetLabStatisticsReport", ex);
            }
            return returnCode;
        }
        public long GetLabStatisticsReportSummary(DateTime fDate, DateTime tDate, int pOrgID, int pVisitType, string pHeaderName, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetLabStatisticsReportSummary(fDate, tDate, pOrgID, pVisitType, pHeaderName, out lstDeptWiseReport);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetLabStatisticsReportSummary", ex);
            }
            return returnCode;
        }

        public long GetLabStatSplitReport(DateTime pDate, string pDept, int pVisitType, int pOrgID, string pHeaderName, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetLabStatSplitReport(pDate, pDept, pVisitType, pOrgID, pHeaderName, out lstDeptWiseReport);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetLabStatSplitReport", ex);
            }
            return returnCode;
        }

        public long GetDoctorsStatisticsReport(DateTime fDate, DateTime tDate, int pOrgID, int pVisitType, int pSpecialityID, long phyID, List<DayWiseCollectionReport> lstSpecialityIDs, List<DayWiseCollectionReport> lstPhysicianIDs, out List<DayWiseCollectionReport> lstDeptWiseReport, out List<Physician> lstPhysician)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            lstPhysician = new List<Physician>();

            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetDoctorsStatisticsReport(fDate, tDate, pOrgID, pVisitType, pSpecialityID, phyID, lstSpecialityIDs, lstPhysicianIDs, out lstDeptWiseReport, out lstPhysician);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetDoctorsStatisticsReport", ex);
            }
            return returnCode;
        }

        public long CountPatientReport(DateTime pFromDate, DateTime pToDate, int pOrgID, string pRequestType, List<DayWiseCollectionReport> lstSpecialityIDs, List<DayWiseCollectionReport> lstPhysicianIDs, out List<DayWiseCollectionReport> lstPhysician)
        {
            long returnCode = -1;
            lstPhysician = new List<DayWiseCollectionReport>();


            try
            {
                returnCode = new Report_DAL(globalContextDetails).CountPatientReport(pFromDate, pToDate, pOrgID, pRequestType, lstSpecialityIDs, lstPhysicianIDs, out lstPhysician);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL CountPatientReport", ex);
            }
            return returnCode;
        }
        public long GetAdmCancelledReport(DateTime pFromDate, DateTime pToDate, int pOrgID, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetAdmCancelledReport(pFromDate, pToDate, pOrgID, out lstDeptWiseReport);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetAdmCancelledReport", ex);
            }
            return returnCode;
        }
        public long GetDeathStatReport(DateTime pFromDate, DateTime pToDate, int pOrgID, string txt, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetDeathStatReport(pFromDate, pToDate, pOrgID, txt, out lstDeptWiseReport);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetDeathStatReport", ex);
            }
            return returnCode;
        }
        public long GetWardOccupancyReport(DateTime pFromDate, DateTime pToDate, int pOrgID, int pageSize, int startRowIndex, out int totalRows, out List<WardOccupancy> lstWardOccupancyReport)
        {
            long returnCode = -1;
            totalRows = -1;
            lstWardOccupancyReport = new List<WardOccupancy>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetWardOccupancyReport(pFromDate, pToDate, pOrgID, pageSize, startRowIndex, out totalRows, out lstWardOccupancyReport);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetDeathStatReport", ex);
            }
            return returnCode;
        }
        public long GetLabTestStatReport(DateTime fDate, DateTime tDate, int pOrgID, int pVisitType, string pHeaderName, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetLabTestStatReport(fDate, tDate, pOrgID, pVisitType, pHeaderName, out lstDeptWiseReport);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetLabTestStatReport", ex);
            }
            return returnCode;
        }
        public long GetDischargeAnalysisReport(DateTime pFromDate, DateTime pToDate, int pOrgID, int pVisitType, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetDischargeAnalysisReport(pFromDate, pToDate, pOrgID, pVisitType, out lstDeptWiseReport);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetDischargeAnalysisReport", ex);
            }
            return returnCode;
        }
        public long GetColRptIndDeptSummaryOPIP(DateTime pFDate, DateTime pTDate, int pOrgID, int pVisitType, string feeType, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetColRptIndDeptSummaryOPIP(pFDate, pTDate, pOrgID, pVisitType, feeType, out lstDeptWiseReport);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetColRptIndDeptSummaryOPIP", ex);
            }
            return returnCode;
        }




        public long GetMRDSnapShotView(int pOrgID, DateTime pFromDate, DateTime pToDate, out int pActiveIPList, out int pTodaysOPList, out int pTodaysSurgery, out int pBirthCounts, out int pImagingCountsOP, out int pImagingCountsIP, out int pImagingCountsOPIP, out int pLabCountsOP, out int pLabCountsIP, out int pLabCountsOPIP, out int pDischargeCounts, out int pInfectiousDisease, out int pNotifiableDiseases)
        {
            long returnCode = -1;
            pActiveIPList = -1;
            pTodaysOPList = -1;
            pTodaysSurgery = -1;
            pLabCountsOP = -1;
            pLabCountsIP = -1;
            pLabCountsOPIP = -1;
            pImagingCountsOP = -1;
            pImagingCountsIP = -1;
            pImagingCountsOPIP = -1;
            pBirthCounts = -1;
            pDischargeCounts = -1;
            pInfectiousDisease = -1;
            pNotifiableDiseases = -1;

            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetMRDSnapShotView(pOrgID, pFromDate, pToDate, out pActiveIPList, out pTodaysOPList, out pTodaysSurgery, out pBirthCounts, out pImagingCountsOP, out pImagingCountsIP, out pImagingCountsOPIP, out pLabCountsOP, out pLabCountsIP, out pLabCountsOPIP, out pDischargeCounts, out pInfectiousDisease, out pNotifiableDiseases);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetMRDSnapShotView BL", ex);
            }

            return returnCode;
        }

        public long InsertMRDDischargeAnalysis(int pOrgID, List<MRDDischargeAnalysis> lstMRDDA, out long retCode)
        {
            long returnCode = -1;
            retCode = -1;
            try
            {

                returnCode = new Report_DAL(globalContextDetails).InsertMRDDischargeAnalysis(pOrgID, lstMRDDA, out retCode);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL InsertMRDDischargeAnalysis", ex);
            }

            return returnCode;
        }



        public long GetMRDDischargeAnalysis(int pOrgID, out List<MRDDischargeAnalysis> lstMRDDA)
        {
            long returnCode = -1;
            lstMRDDA = new List<MRDDischargeAnalysis>();

            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetMRDDischargeAnalysis(pOrgID, out lstMRDDA);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetMRDDischargeAnalysis", ex);
            }

            return returnCode;
        }
        public long GetLabTestStatReportSummary(DateTime fDate, DateTime tDate, int pOrgID, int pVisitType, string pHeaderName, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetLabTestStatReportSummary(fDate, tDate, pOrgID, pVisitType, pHeaderName, out lstDeptWiseReport);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetLabTestStatReport", ex);
            }
            return returnCode;
        }

        public long GetProcedureStatisticsReport(DateTime fDate, DateTime tDate, int pOrgID, int pVisitType, string pHeaderName, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetProcedureStatisticsReport(fDate, tDate, pOrgID, pVisitType, pHeaderName, out lstDeptWiseReport);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetProcedureStatisticsReport", ex);
            }
            return returnCode;
        }
        public long GetProStatisticsReportSummary(DateTime fDate, DateTime tDate, int pOrgID, int pVisitType, string pHeaderName, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetProStatisticsReportSummary(fDate, tDate, pOrgID, pVisitType, pHeaderName, out lstDeptWiseReport);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetProStatisticsReportSummary", ex);
            }
            return returnCode;
        }

        public long GetICDReport(int OrgID, string ReportView, DateTime fDate, DateTime tDate, List<PatientComplaint> lstPatientComplaint, out List<Patient> lstPatientICDSummary, out List<Patient> lstPatientICDDetail)
        {
            long returnCode = -1;
            lstPatientICDDetail = new List<Patient>();
            lstPatientICDSummary = new List<Patient>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetICDReport(OrgID, ReportView, fDate, tDate, lstPatientComplaint, out lstPatientICDSummary, out lstPatientICDDetail);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetICDReport", ex);
            }
            return returnCode;
        }
        public long GetDiseaseBurdenReport(int OrgID, string ReportView, DateTime fDate, DateTime tDate, List<PatientComplaint> lstPatientComplaint, out List<Patient> lstPatientICDSummary, out List<Patient> lstPatientICDDetail, bool Icdcode)
        {
            long returnCode = -1;
            lstPatientICDDetail = new List<Patient>();
            lstPatientICDSummary = new List<Patient>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetDiseaseBurdenReport(OrgID, ReportView, fDate, tDate, lstPatientComplaint, out lstPatientICDSummary, out lstPatientICDDetail, Icdcode);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetICDReport", ex);
            }
            return returnCode;
        }
        public long GetBillWiseDeptCollectionReport(DateTime pFromDate, DateTime pToDate, int pOrgID, long pLID, int pVisitType, int CurrencyID, out List<DayWiseCollectionReport> lstDeptWiseReport, out decimal pTotalItemAmt, out decimal pTotalDiscount, out decimal pTotalReceivedAmt, out decimal pTotalDue, out decimal pTax, out decimal pServiceCharge, string reportType)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            pTotalItemAmt = -1;
            pTotalDiscount = -1;
            pTotalReceivedAmt = -1;
            pTotalDue = -1;
            pTax = -1;
            pServiceCharge = -1;
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetBillWiseDeptCollectionReport(pFromDate, pToDate, pOrgID, pLID, pVisitType, CurrencyID, out lstDeptWiseReport, out pTotalItemAmt, out pTotalDiscount, out pTotalReceivedAmt, out pTotalDue, out pTax, out pServiceCharge, reportType);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetBillWiseDeptCollectionReport", ex);
            }
            return returnCode;
        }

        public long GetBillWiseDeptWiseCollection(DateTime pFromDate, DateTime pToDate, int pOrgID, long pLID, int pVisitType, out List<DayWiseCollectionReport> lstDeptWiseReport, out decimal pTotalItemAmt, out decimal pTotalDiscount, out decimal pTotalReceivedAmt, out decimal pTotalDue, out decimal pTax, out decimal pServiceCharge, string reportType)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            pTotalItemAmt = -1;
            pTotalDiscount = -1;
            pTotalReceivedAmt = -1;
            pTotalDue = -1;
            pTax = -1;
            pServiceCharge = -1;
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetBillWiseDeptWiseCollection(pFromDate, pToDate, pOrgID, pLID, pVisitType, out lstDeptWiseReport, out pTotalItemAmt, out pTotalDiscount, out pTotalReceivedAmt, out pTotalDue, out pTax, out pServiceCharge, reportType);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetBillWiseDeptWiseCollection", ex);
            }
            return returnCode;
        }

        public long CustomerTrackerTVC(DateTime fdate, DateTime tdate, out List<CusTrackerReport> FrToVisitCount)
        {
            long returnCode = -1;
            FrToVisitCount = new List<CusTrackerReport>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).CustomerTrackerTVC(fdate, tdate, out FrToVisitCount);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetTotalVisitCount", ex);
            }
            return returnCode;
        }

        public long CustomerTrackerDetRpt(DateTime fdate, DateTime tdate, int orgid, int orgaddrid, out List<CusTrackerReport> DetailedOPRpt, out List<CusTrackerReport> DetailedIPRpt, out List<CusTrackerReport> DischDtlrpt, out int DischargeSummaryCount, out int PatientsDischarged)
        {
            long returnCode = -1;
            DetailedOPRpt = new List<CusTrackerReport>();
            DetailedIPRpt = new List<CusTrackerReport>();
            DischDtlrpt = new List<CusTrackerReport>();
            DischargeSummaryCount = -1;
            PatientsDischarged = -1;
            try
            {
                returnCode = new Report_DAL(globalContextDetails).CustomerTrackerDetRpt(fdate, tdate, orgid, orgaddrid, out DetailedOPRpt, out DetailedIPRpt, out DischDtlrpt, out DischargeSummaryCount, out PatientsDischarged);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetDetailedVisitCount", ex);
            }
            return returnCode;
        }

        public long GetCollectionRptDptWiseOPIPDetalis(DateTime pFromDate, DateTime pToDate, int pOrgID, long pLID, int pVisitType, out List<DayWiseCollectionReport> lstDeptWiseReport, out decimal pTotalItemAmt, out decimal pTotalDiscount, out decimal pTotalReceivedAmt, out decimal pTotalDue, out decimal pTax, out decimal pServiceCharge, string reportType)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            pTotalItemAmt = -1;
            pTotalDiscount = -1;
            pTotalReceivedAmt = -1;
            pTotalDue = -1;
            pTax = -1;
            pServiceCharge = -1;
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetCollectionRptDptWiseOPIPDetalis(pFromDate, pToDate, pOrgID, pLID, pVisitType, out lstDeptWiseReport, out pTotalItemAmt, out pTotalDiscount, out pTotalReceivedAmt, out pTotalDue, out pTax, out pServiceCharge, reportType);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetCollectionRptDptWiseOPIPDetalis", ex);
            }
            return returnCode;
        }

        public long GetDptWiseRevenueReport(DateTime pFromDate, DateTime pToDate, int pOrgID, long pLID, int pVisitType, out List<DayWiseCollectionReport> lstDeptWiseReport, out decimal pTotalItemAmt, out decimal pTotalDiscount, out decimal pTotalReceivedAmt, out decimal pTotalDue, out decimal pTax, out decimal pServiceCharge, string reportType)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            pTotalItemAmt = -1;
            pTotalDiscount = -1;
            pTotalReceivedAmt = -1;
            pTotalDue = -1;
            pTax = -1;
            pServiceCharge = -1;
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetDptWiseRevenueReport(pFromDate, pToDate, pOrgID, pLID, pVisitType, out lstDeptWiseReport, out pTotalItemAmt, out pTotalDiscount, out pTotalReceivedAmt, out pTotalDue, out pTax, out pServiceCharge, reportType);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetCollectionRptDptWiseOPIPDetalis", ex);
            }
            return returnCode;
        }


        public long GetReportProfile(int pOrgID, long pReportID, out List<ReportProfile> lstReportProfile)
        {
            long returnCode = -1;
            lstReportProfile = new List<ReportProfile>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetReportProfile(pOrgID, pReportID, out lstReportProfile);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetReportProfile", ex);
            }
            return returnCode;
        }

        public long SaveReportProfile(int pOrgId, long pReportID, string pCurrentConfigValue, string pFlag)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Report_DAL(globalContextDetails).SaveReportProfile(pOrgId, pReportID, pCurrentConfigValue, pFlag);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveReportProfile in Report_BL", ex);
            }
            return returnCode;
        }
        public long GetDuePaidDetailsReport(DateTime FromDate, DateTime ToDate, int OrgID, int CurrencyID, int pLocationID, string PaymentMode, out List<DuePaidDetail> lstDuePaidDetail)
        {
            long returnCode = -1;
            lstDuePaidDetail = new List<DuePaidDetail>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetDuePaidDetailsReport(FromDate, ToDate, OrgID, CurrencyID, pLocationID, PaymentMode, out lstDuePaidDetail);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetDuePaidDetailsReport", ex);
            }
            return returnCode;
        }
        public long GetmidniteReport(DateTime FromDate, int OrgID, out List<MidNitesensexreport> lstDuePaidDetail)
        {
            long returnCode = -1;
            lstDuePaidDetail = new List<MidNitesensexreport>();
            try
            {
                //returnCode = new Report_DAL(globalContextDetails).GetmidniteReport(FromDate, OrgID, out lstDuePaidDetail);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetDuePaidDetailsReport", ex);
            }
            return returnCode;
        }


        public long GetNonReimbursableForUpdate(int pOrgID, long TPAID, string TPAType, out List<NonReimbursableItems> lstNonReimbursableItems)
        {
            long returnCode = -1;
            lstNonReimbursableItems = new List<NonReimbursableItems>();

            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetNonReimbursableForUpdate(pOrgID, TPAID, TPAType, out lstNonReimbursableItems);


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetNonReimbursableForUpdate", ex);
            }
            return returnCode;
        }


        public long SaveNonReimbursableItems(int pOrgId, long pLid, List<NonReimbursableItems> lstNonReimbursableItems)
        {
            long returnCode = -1;

            try
            {
                returnCode = new Report_DAL(globalContextDetails).SaveNonReimbursableItems(pOrgId, pLid, lstNonReimbursableItems);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveNonReimbursableItems in Report_BL", ex);
            }
            return returnCode;
        }



        //public long GetNonReimbursableForUpdate(int pOrgID, long TPAID, string TPAType, out List<NonReimbursableItems> lstNonReimbursableItems)
        //{
        //    long returnCode = -1;
        //    lstNonReimbursableItems = new List<NonReimbursableItems>();
        //    try
        //    {
        //        returnCode = new Report_DAL(globalContextDetails).GetNonReimbursableForUpdate(pOrgID, TPAID, TPAType, out lstNonReimbursableItems);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error in Report BL GetNonReimbursableForUpdate", ex);
        //    }
        //    return returnCode;
        //}


        //public long SaveNonReimbursableItems(int pOrgId, long pLid, List<NonReimbursableItems> lstNonReimbursableItems)
        //{
        //    long returnCode = -1;

        //    try
        //    {
        //        returnCode = new Report_DAL(globalContextDetails).SaveNonReimbursableItems(pOrgId, pLid, lstNonReimbursableItems);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error while executing SaveNonReimbursableItems in Report_BL", ex);
        //    }
        //    return returnCode;
        //}

        public long GetDailyExpensesReportForDynamic(DateTime fromdate, DateTime todate, int OrgID, string ReceiverType, int locationId, out DataTable lstCashOutFlow, out List<CashOutFlow> lstHead, DataTable dtusersIDs, out decimal pTotalExpenseAmt)
        {
            long returnCode = -1;
            lstCashOutFlow = new DataTable();
            lstHead = new List<CashOutFlow>();
            pTotalExpenseAmt = 0;
            try
            {
                Report_DAL objReportDAL = new Report_DAL(globalContextDetails);
                returnCode = objReportDAL.GetDailyExpensesReportForDynamic(fromdate, todate, OrgID, ReceiverType, locationId, out lstCashOutFlow, out lstHead, dtusersIDs, out pTotalExpenseAmt);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDailyExpensesReport_BL", ex);
            }
            return returnCode;
        }
        public long GetIncomeSourceReport(DateTime fromdate, DateTime todate, int OrgID, long LoginID, int CurrencyID, out List<IncSourcePaidDetails> IncSourceDetails)
        {
            long returnnCode = -1;
            IncSourceDetails = new List<IncSourcePaidDetails>();
            try
            {
                returnnCode = new Report_DAL(globalContextDetails).GetIncomeSourceReport(fromdate, todate, OrgID, LoginID, CurrencyID, out IncSourceDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetIncomeSourceReport in Report_BL", ex);
            }
            return returnnCode;
        }

        public long GetPatientDepositDetailsRpt(DateTime FromDate, DateTime ToDate, int OrgID, string PName, string flag, out  List<Patient> lstPatient)
        {
            long returnCode = -1;
            lstPatient = new List<Patient>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetPatientDepositDetailsRpt(FromDate, ToDate, OrgID, PName, flag, out lstPatient);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetPatientDepositDetailsRpt", ex);
            }
            return returnCode;
        }

        public long GetOPIPNewAndRevisitSummary(int OrgID, DateTime fDate, DateTime tDate, out  List<PatientVisitDetails> lstDetails)
        {
            long returnCode = -1;
            lstDetails = new List<PatientVisitDetails>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetOPIPNewAndRevisitSummary(OrgID, fDate, tDate, out lstDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetOPIPNewAndRevisitSummary in Report_BL", ex);
            }
            return returnCode;
        }
        public long GetPatientWiseCombinedReport(DateTime fromDate, DateTime toDate, int OrgID, long PhyID, out  List<PatientWiseCombinedReport> lstPatientWiseCombinedReport)
        {
            long returnCode = -1;
            lstPatientWiseCombinedReport = new List<PatientWiseCombinedReport>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetPatientWiseCombinedReport(fromDate, toDate, OrgID, PhyID, out lstPatientWiseCombinedReport);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetPatientWiseCombinedReport in Report_BL", ex);
            }
            return returnCode;
        }
        public long GetDepartmentWiseCollectionReport(DateTime fromDate, DateTime toDate, int OrgID, int vType, out  List<DayWiseCollectionReport> lstCash, out  List<DayWiseCollectionReport> lstCredit, out  List<DayWiseCollectionReport> lstTotal, out decimal pTotalDiscount, out decimal pTotalRefund, out decimal pTotalDue, out decimal pTotalGrossAmount, out decimal pTotalAdvance, out decimal pCashDiscount, out decimal pCreditDiscount, out decimal pTotalDeposit)
        {
            long returnCode = -1;
            lstCash = new List<DayWiseCollectionReport>();
            lstCredit = new List<DayWiseCollectionReport>();
            lstTotal = new List<DayWiseCollectionReport>();
            pTotalDiscount = -1;
            pTotalRefund = -1;
            pTotalDue = -1;
            pTotalGrossAmount = -1;
            pTotalAdvance = -1;
            pCashDiscount = -1;
            pCreditDiscount = -1;
            pTotalDeposit = -1;
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetDepartmentWiseCollectionReport(fromDate, toDate, OrgID, vType, out lstCash, out lstCredit, out lstTotal, out pTotalDiscount, out pTotalRefund, out pTotalDue, out pTotalGrossAmount, out pTotalAdvance, out pCashDiscount, out pCreditDiscount, out pTotalDeposit);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetDepartmentWiseCollectionReport in Report_BL", ex);
            }
            return returnCode;
        }
        public long GetDepartmentWiseDetailReport(DateTime fromDate, DateTime toDate, int OrgID, int vType, out  List<DayWiseCollectionReport> lstCash, out  List<DayWiseCollectionReport> lstCredit, out  List<DayWiseCollectionReport> lstTotal, out decimal pTotalDiscount, out decimal pTotalRefund, out decimal pTotalDue, out decimal pTotalGrossAmount, out decimal pTotalAdvance, out decimal pCashDiscount, out decimal pCreditDiscount, out decimal pTotalDeposit)
        {
            long returnCode = -1;
            lstCash = new List<DayWiseCollectionReport>();
            lstCredit = new List<DayWiseCollectionReport>();
            lstTotal = new List<DayWiseCollectionReport>();
            pTotalDiscount = -1;
            pTotalRefund = -1;
            pTotalDue = -1;
            pTotalGrossAmount = -1;
            pTotalAdvance = -1;
            pCashDiscount = -1;
            pCreditDiscount = -1;
            pTotalDeposit = -1;
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetDepartmentWiseDetailReport(fromDate, toDate, OrgID, vType, out lstCash, out lstCredit, out lstTotal, out pTotalDiscount, out pTotalRefund, out pTotalDue, out pTotalGrossAmount, out pTotalAdvance, out pCashDiscount, out pCreditDiscount, out pTotalDeposit);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetDepartmentWiseCollectionReport in Report_BL", ex);
            }
            return returnCode;
        }

        public long GetDayWiseDisChargeReport(DateTime FromDate, DateTime ToDate, int OrgID, out List<DayWiseCollectionReport> lstDayWiseDischargeReport, int pVisitType, long pLoginID, int pCurrencyID)
        {
            long returnCode = -1;


            lstDayWiseDischargeReport = new List<DayWiseCollectionReport>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetDayWiseDisChargrgeReport(FromDate, ToDate, OrgID, out lstDayWiseDischargeReport, pVisitType, pLoginID, pCurrencyID);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetDayWiseDischargeReport in Report_BL", ex);
            }
            return returnCode;
        }

        public long GetMonthWiseDischargeReport(DateTime FromDate, DateTime ToDate, int OrgID, out List<DayWiseCollectionReport> lstMonthWiseDischargeReport)
        {
            long returnCode = -1;
            lstMonthWiseDischargeReport = new List<DayWiseCollectionReport>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetMonthWiseDischargeReport(FromDate, ToDate, OrgID, out lstMonthWiseDischargeReport);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetMonthWiseDischargeReport in Report_BL", ex);
            }
            return returnCode;
        }
        public long GetPatientWiseDepositDetails(int OrgID, long PatientID, out List<Patient> lstPatient, out List<PatientDepositHistory> lstPatientDepHis, out List<PatientDepositUsage> lstPatientDepUsage)
        {
            long returnCode = -1;
            lstPatient = new List<Patient>();
            lstPatientDepHis = new List<PatientDepositHistory>();
            lstPatientDepUsage = new List<PatientDepositUsage>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetPatientWiseDepositDetails(OrgID, PatientID, out lstPatient, out lstPatientDepHis, out lstPatientDepUsage);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetPatientWiseDepositDetails", ex);
            }
            return returnCode;
        }

        public long GetRoomListRpt(int OrgID, int OrgAddID, out List<RoomBookingDetails> lstRoomDetails)
        {
            long returnCode = -1;
            lstRoomDetails = new List<RoomBookingDetails>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetRoomListRpt(OrgID, OrgAddID, out lstRoomDetails);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetRoomListRpt in Report_BL", ex);
            }
            return returnCode;
        }
        public long GetDaywiseAdmissionDischargeRpt(DateTime Fdate, DateTime Tdate, int OrgID, string Status, out List<DayWiseCollectionReport> lstDWADR)
        {
            long returnCode = -1;
            lstDWADR = new List<DayWiseCollectionReport>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetDayWiseAdmissionDischargeRpt(Fdate, Tdate, OrgID, Status, out lstDWADR);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetDaywiseAdmissionDischargeRpt in Report_BL", ex);
            }
            return returnCode;


        }
        public long GetCollectionReportOPIP(DateTime pFromDate, DateTime pToDate, int pOrgID, long pLID, int pVisitType, int CurrencyID, string advFilter, string btFilter, out List<DayWiseCollectionReport> lstDayWiseReport, out decimal pTotalBillAmt, out decimal pTotalPreDueReceived, out decimal pTotalDiscount, out decimal pTotalNetValue, out decimal pTotalReceivedAmt, out decimal pTotalDue, out decimal pTax, out decimal pServiceCharge, out List<DayWiseCollectionReport> lstDescription)
        {
            long returnCode = -1;
            lstDayWiseReport = new List<DayWiseCollectionReport>();
            lstDescription = new List<DayWiseCollectionReport>();
            pTotalBillAmt = -1;
            pTotalPreDueReceived = -1;
            pTotalDiscount = -1;
            pTotalNetValue = -1;
            pTotalReceivedAmt = -1;
            pTotalDue = -1;
            pTax = -1;
            pServiceCharge = -1;
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetCollectionReportOPIP(pFromDate, pToDate, pOrgID, pLID, pVisitType, CurrencyID, advFilter, btFilter, out lstDayWiseReport, out pTotalBillAmt, out pTotalPreDueReceived, out pTotalDiscount, out pTotalNetValue, out pTotalReceivedAmt, out pTotalDue, out pTax, out pServiceCharge, out lstDescription);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetCollectionReportOPIP", ex);
            }
            return returnCode;
        }

        public long GetCollectionReportOPIPSummary(DateTime pFromDate, DateTime pToDate, int pOrgID, long pLID, int pVisitType, int CurrencyID, out List<SalesTax> lstDayWiseReport, out decimal pTotalBillAmt, out decimal pTotalPreDueReceived, out decimal pTotalDiscount, out decimal pTotalNetValue, out decimal pTotalReceivedAmt, out decimal pTotalDue, out decimal pTax, out decimal pServiceCharge)
        {
            long returnCode = -1;
            lstDayWiseReport = new List<SalesTax>();
            pTotalBillAmt = -1;
            pTotalPreDueReceived = -1;
            pTotalDiscount = -1;
            pTotalNetValue = -1;
            pTotalReceivedAmt = -1;
            pTotalDue = -1;
            pTax = -1;
            pServiceCharge = -1;
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetCollectionReportOPIPSummary(pFromDate, pToDate, pOrgID, pLID, pVisitType, CurrencyID, out lstDayWiseReport, out pTotalBillAmt, out pTotalPreDueReceived, out pTotalDiscount, out pTotalNetValue, out pTotalReceivedAmt, out pTotalDue, out pTax, out pServiceCharge);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetCollectionReportOPIP", ex);
            }
            return returnCode;
        }
        public long GetTPACORPoutstandingreport(DateTime Fdate, DateTime Tdate, int OrgID, int VisitType, out List<Patient> lstResult)
        {
            long returnCode = -1;
            lstResult = new List<Patient>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetTPACORPoutstandingreport(Fdate, Tdate, OrgID, VisitType, out lstResult);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetTPACORPoutstandingreport in Report_BL", ex);
            }
            return returnCode;


        }
        public long GetInpatientDueReport(DateTime pFromDate, DateTime pToDate, int pOrgID, int pVisitType, string pRequestType, int pageSize, int startRowIndex, out int totalRows, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            totalRows = -1;
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetInpatientDueReport(pFromDate, pToDate, pOrgID, pVisitType, pRequestType, pageSize, startRowIndex, out totalRows, out lstDeptWiseReport);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetInpatientDueReport", ex);
            }
            return returnCode;
        }
        public long GetPatientLedgerReport(string PatientNumber, string FromDate, string ToDate, int OrgID, int VisitType, out List<DayWiseCollectionReport> lstDWADR)
        {
            long returnCode = -1;
            lstDWADR = new List<DayWiseCollectionReport>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetPatientLedgerReport(PatientNumber, FromDate, ToDate, OrgID, VisitType, out lstDWADR);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetPatientLedgerReport in Report_BL", ex);
            }
            return returnCode;
        }
        public long pGetCheckDDStmt(DateTime pFromDate, DateTime pToDate, int pOrgID, int pVisitType, out List<DayWiseCollectionReport> lstDeptWiseReport, out decimal pTotalCardAmt, out decimal pTotalServiceCharge)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            pTotalCardAmt = -1;
            pTotalServiceCharge = -1;
            try
            {
                returnCode = new Report_DAL(globalContextDetails).pGetCheckDDStmt(pFromDate, pToDate, pOrgID, pVisitType, out lstDeptWiseReport, out pTotalCardAmt, out pTotalServiceCharge);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetCreditCardStmt", ex);
            }
            return returnCode;
        }

        public long SaveMappedReports(int RoleID, int OrgID, DataTable DtRptList)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Report_DAL(globalContextDetails).SaveMappedReports(RoleID, OrgID, DtRptList);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report_BL SaveMappedReportDetails", ex);
            }
            return returnCode;
        }
        public long GetCreditLimitReport(string pFromDate, string pToDate, int pOrgID, string pVisitType, out List<Patient> lstFinalBill)
        {
            long returnCode = -1;
            lstFinalBill = new List<Patient>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetCreditLimitReport(pFromDate, pToDate, pOrgID, pVisitType, out lstFinalBill);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetCreditLimitReport", ex);
            }
            return returnCode;
        }
        public long GetTATReport(DateTime pFromDate, DateTime pToDate, int pOrgID, long LocationID,long DeptID, out List<LabTestTATReport> lstTATReport)
        {
            long returnCode = -1;
            lstTATReport = new List<LabTestTATReport>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetTATReport(pFromDate, pToDate, pOrgID, LocationID, DeptID,out lstTATReport);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetCreditLimitReport", ex);
            }
            return returnCode;
        }
        public long GetPharmacyDueReport(DateTime pFromDate, DateTime pToDate, int pOrgID, int OrgAddID, string IsCreditBill, int visitType, string FeeType, out List<DayWiseCollectionReport> lstReport)
        {
            long returnCode = -1;
            lstReport = new List<DayWiseCollectionReport>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetPharmacyDueReport(pFromDate, pToDate, pOrgID, OrgAddID, IsCreditBill, visitType, FeeType, out lstReport);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetPharmacyDueReport", ex);
            }
            return returnCode;
        }
        public long SaveReportSnapshot(DataTable pReportData, DataTable pInvoiceData, Int64 pVisitID, Int32 pOrgID, Int64 pOrgAddressID, Int64 pCreatedBy)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Report_DAL(globalContextDetails).SaveReportSnapshot(pReportData, pInvoiceData, pVisitID, pOrgID, pOrgAddressID, pCreatedBy);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL SaveReportSnapshot", ex);
            }
            return returnCode;
        }
        public long pGetReportPathByVisitID(DataTable dt, out List<ApprovedReports> lstReportSnapshot)
        {
            long returnCode = -1;
            lstReportSnapshot = new List<ApprovedReports>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetReportPathByVisitID(dt, out lstReportSnapshot);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetReportSnapshot", ex);
            }
            return returnCode;
        }
        public long SavePrintedReport(DataTable pReportData, Int64 pVisitID, Int32 pOrgID, Int64 pRoleID, Int64 pOrgAddressID, Int64 pCreatedBy, String pType, String pRecipient, string Category)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Report_DAL(globalContextDetails).SavePrintedReport(pReportData, pVisitID, pOrgID, pRoleID, pOrgAddressID, pCreatedBy, pType, pRecipient, Category);
            }
            catch (Exception ex)
            {
                returnCode = -1;
                CLogger.LogError("Error in Report BL SavePrintedReport", ex);
            }
            return returnCode;
        }
        public long GetReportSnapshot(Int32 pOrgID, Int64 pOrgAddressID, Int64 pVisitID, bool pUpdateStatus, string ReportType, out List<ReportSnapshot> lstReportSnapshot)
        {
            long returnCode = -1;
            lstReportSnapshot = new List<ReportSnapshot>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetReportSnapshot(pOrgID, pOrgAddressID, pVisitID, pUpdateStatus, ReportType, out lstReportSnapshot);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetReportSnapshot", ex);
            }
            return returnCode;
        }
        public long GetBedBookedReport(DateTime pFromDate, DateTime pToDate, int pOrgID, int pageSize, int startRowIndex, out int totalRows, out List<WardOccupancy> lstWardOccupancyReport)
        {
            long returnCode = -1;
            totalRows = -1;
            lstWardOccupancyReport = new List<WardOccupancy>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetBedBookedReport(pFromDate, pToDate, pOrgID, pageSize, startRowIndex, out totalRows, out lstWardOccupancyReport);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetBedBookedReport", ex);
            }
            return returnCode;
        }
        public long GetPhysicianTDSReport(DateTime pFromDate, DateTime pToDate, int pOrgID, long physicianid, string vtype, out List<CashFlowSummary> lstcashoutflowsummarys)
        {
            long returnCode = -1;
            lstcashoutflowsummarys = new List<CashFlowSummary>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetPhysicianTDSReport(pFromDate, pToDate, pOrgID, physicianid, vtype, out  lstcashoutflowsummarys);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetPhysicianTDSReport", ex);
            }
            return returnCode;
        }

        public long GetOPCollectionReportLIMS(DateTime fDate, DateTime tDate, int pOrgID, long LID, int retreiveDataBaseOnVtype, int currencyID, int OrgDet, string pReportType, long ClientID, int OrgAddressID, string strObj, int ClientTypeID, int RefPhyID, int RefHospitalID, out List<DayWiseCollectionReport> lstDayWiseReport)
        {
            long returnCode = -1;
            lstDayWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetOPCollectionReportLIMS(fDate, tDate, pOrgID, LID, retreiveDataBaseOnVtype, currencyID, OrgDet, pReportType, ClientID, OrgAddressID, strObj, ClientTypeID, RefPhyID, RefHospitalID, out lstDayWiseReport);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetOPCollectionReportLIMS", ex);
            }
            return returnCode;
        }
        public long GetInvoiceCollectionReportLIMS(DateTime fDate, DateTime tDate, int pOrgID, long LID,  string pReportType, long ClientID, int OrgAddressID, 
            out List<InvoiceCollectionReport> lstDayWiseReport, out List<InvoiceCollectionReport> lstDayWiseReport1
            , out List<InvoiceCollectionReport> lstDayWiseReport2, out List<InvoiceCollectionReport> lstDayWiseReport3)
        {
            long returnCode = -1;
            lstDayWiseReport = new List<InvoiceCollectionReport>();
            lstDayWiseReport1 = new List<InvoiceCollectionReport>();
            lstDayWiseReport2 = new List<InvoiceCollectionReport>();
            lstDayWiseReport3 = new List<InvoiceCollectionReport>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetInvoiceCollectionReportLIMS(fDate, tDate, pOrgID, LID,  pReportType, ClientID, OrgAddressID,  out lstDayWiseReport, out lstDayWiseReport1, out lstDayWiseReport2, out lstDayWiseReport3);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetInvoiceCollectionReportLIMS", ex);
            }
            return returnCode;
        }
        public long GetDailyTransactionDetails(DateTime fDate, DateTime tDate, int pOrgID, int OrgAddressID, string PatientName, string UserName, string ClientName, out List<DayWiseCollectionReport> lstDailyTransReport, out decimal pTotalAmt)
        {
            long returnCode = -1;
            pTotalAmt = -1;
            lstDailyTransReport = new List<DayWiseCollectionReport>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetDailyTransactionDetails(fDate, tDate, pOrgID, OrgAddressID, PatientName, UserName, ClientName, out lstDailyTransReport, out pTotalAmt);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetDailyTransactionDetails", ex);
            }
            return returnCode;
        }
        public long GetCreditCardStmtLims(DateTime pFromDate, DateTime pToDate, int pOrgID, int pVisitType, out List<DayWiseCollectionReport> lstDeptWiseReport, out decimal pTotalCardAmt, out decimal pTotalServiceCharge, int PaymentTypeID)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            pTotalCardAmt = -1;
            pTotalServiceCharge = -1;
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetCreditCardStmtLims(pFromDate, pToDate, pOrgID, pVisitType, out lstDeptWiseReport, out pTotalCardAmt, out pTotalServiceCharge, PaymentTypeID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetCreditCardStmt", ex);
            }
            return returnCode;
        }

        public long GetDueandDiscountLims(DateTime pFromDate, DateTime pToDate, int pOrgID, string userwise, string authorizedBy, int pVisitType, int preporttype, string pRequestType, string PName, string PNo, int pLocationID, int ClientTypeID, long ClientID, out List<DayWiseCollectionReport> lstDeptWiseReport, out decimal pTotalDiscount)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            pTotalDiscount = -1;
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetDueandDiscountLims(pFromDate, pToDate, pOrgID, userwise, authorizedBy, pVisitType, preporttype, pRequestType, PName, PNo, pLocationID, ClientTypeID, ClientID, out lstDeptWiseReport, out pTotalDiscount);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetDueandDiscount", ex);
            }
            return returnCode;
        }

        public long GetBillWiseDeptCollectionReportLims(DateTime pFromDate, DateTime pToDate, int pOrgID, long pLID, int pVisitType, int CurrencyID, out List<DayWiseCollectionReport> lstDeptWiseReport, out decimal pTotalItemAmt, out decimal pTotalDiscount, out decimal pTotalReceivedAmt, out decimal pTotalDue, out decimal pTax, out decimal pServiceCharge, string reportType)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            pTotalItemAmt = -1;
            pTotalDiscount = -1;
            pTotalReceivedAmt = -1;
            pTotalDue = -1;
            pTax = -1;
            pServiceCharge = -1;
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetBillWiseDeptCollectionReportLims(pFromDate, pToDate, pOrgID, pLID, pVisitType, CurrencyID, out lstDeptWiseReport, out pTotalItemAmt, out pTotalDiscount, out pTotalReceivedAmt, out pTotalDue, out pTax, out pServiceCharge, reportType);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetBillWiseDeptCollectionReport", ex);
            }
            return returnCode;
        }
        public long GetDepartmentWiseCollectionReportLims(DateTime fromDate, DateTime toDate, int OrgID, int vType, out  List<DayWiseCollectionReport> lstCash, out  List<DayWiseCollectionReport> lstCredit, out  List<DayWiseCollectionReport> lstTotal, out decimal pTotalDiscount, out decimal pTotalRefund, out decimal pTotalDue, out decimal pTotalGrossAmount, out decimal pTotalAdvance, out decimal pCashDiscount, out decimal pCreditDiscount, out decimal pTotalDeposit)
        {
            long returnCode = -1;
            lstCash = new List<DayWiseCollectionReport>();
            lstCredit = new List<DayWiseCollectionReport>();
            lstTotal = new List<DayWiseCollectionReport>();
            pTotalDiscount = -1;
            pTotalRefund = -1;
            pTotalDue = -1;
            pTotalGrossAmount = -1;
            pTotalAdvance = -1;
            pCashDiscount = -1;
            pCreditDiscount = -1;
            pTotalDeposit = -1;
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetDepartmentWiseCollectionReportLims(fromDate, toDate, OrgID, vType, out lstCash, out lstCredit, out lstTotal, out pTotalDiscount, out pTotalRefund, out pTotalDue, out pTotalGrossAmount, out pTotalAdvance, out pCashDiscount, out pCreditDiscount, out pTotalDeposit);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetDepartmentWiseCollectionReport in Report_BL", ex);
            }
            return returnCode;
        }
        public long GetDepartmentWiseDetailReportLims(DateTime fromDate, DateTime toDate, int OrgID, int vType, out  List<DayWiseCollectionReport> lstCash, out  List<DayWiseCollectionReport> lstCredit, out  List<DayWiseCollectionReport> lstTotal, out decimal pTotalDiscount, out decimal pTotalRefund, out decimal pTotalDue, out decimal pTotalGrossAmount, out decimal pTotalAdvance, out decimal pCashDiscount, out decimal pCreditDiscount, out decimal pTotalDeposit)
        {
            long returnCode = -1;
            lstCash = new List<DayWiseCollectionReport>();
            lstCredit = new List<DayWiseCollectionReport>();
            lstTotal = new List<DayWiseCollectionReport>();
            pTotalDiscount = -1;
            pTotalRefund = -1;
            pTotalDue = -1;
            pTotalGrossAmount = -1;
            pTotalAdvance = -1;
            pCashDiscount = -1;
            pCreditDiscount = -1;
            pTotalDeposit = -1;
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetDepartmentWiseDetailReportLims(fromDate, toDate, OrgID, vType, out lstCash, out lstCredit, out lstTotal, out pTotalDiscount, out pTotalRefund, out pTotalDue, out pTotalGrossAmount, out pTotalAdvance, out pCashDiscount, out pCreditDiscount, out pTotalDeposit);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetDepartmentWiseCollectionReport in Report_BL", ex);
            }
            return returnCode;
        }
        public long GetLabTestStatReportSummaryLims(DateTime fDate, DateTime tDate, int pOrgID, int pVisitType, string pHeaderName, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetLabTestStatReportSummaryLims(fDate, tDate, pOrgID, pVisitType, pHeaderName, out lstDeptWiseReport);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetLabTestStatReport", ex);
            }
            return returnCode;
        }
        public long GetLabStatisticsReportLIMS(DateTime pFromDate, DateTime pToDate, int pOrgID, int pOrgDet, int pDeptID, int SampleID, long ClientID, out List<InvLimsReport> lstInvLimsReport, int OrgAddID, string TestType, int RefHospitalID, int RefPhysicianID, int ClientTypeID)
        {
            long returnCode = -1;
            lstInvLimsReport = new List<InvLimsReport>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetLabStatisticsReportLIMS(pFromDate, pToDate, pOrgID, pOrgDet, pDeptID, SampleID, ClientID, out  lstInvLimsReport, OrgAddID, TestType, RefHospitalID, RefPhysicianID, ClientTypeID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetLabStatisticsReportLIMS", ex);
            }
            return returnCode;
        }
        public long GetLabStatisticsReportLim(DateTime fDate, DateTime tDate, int pOrgID, int pVisitType, string pHeaderName, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetLabStatisticsReportLim(fDate, tDate, pOrgID, pVisitType, pHeaderName, out lstDeptWiseReport);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetLabStatisticsReportLim", ex);
            }
            return returnCode;
        }
        public long GetLabTestStatReportLims(DateTime fDate, DateTime tDate, int pOrgID, int pVisitType, string pHeaderName, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetLabTestStatReportLims(fDate, tDate, pOrgID, pVisitType, pHeaderName, out lstDeptWiseReport);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetLabTestStatReportLims", ex);
            }
            return returnCode;
        }

        public long GetReportPrintHistory(Int32 pOrgID, Int64 pVisitID, String pType, out List<ReportPrintHistory> lstReportPrintHistory)
        {
            long returnCode = -1;
            lstReportPrintHistory = new List<ReportPrintHistory>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetReportPrintHistory(pOrgID, pVisitID, pType, out lstReportPrintHistory);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetReportPrintHistory", ex);
            }
            return returnCode;
        }

        public long GetSMSAlertReport(DateTime pFromDate, DateTime pToDate, int pOrgID, out List<PatientPrescription> lstPatientPrescription)
        {
            long returnCode = -1;
            lstPatientPrescription = new List<PatientPrescription>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetSMSAlertReport(pFromDate, pToDate, pOrgID, out lstPatientPrescription);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetSMSAlertReport", ex);
            }
            return returnCode;
        }

        public long GetEMITrackingReport(DateTime pFromDate, DateTime pToDate, string BankName, out List<AmountReceivedDetails> lstAmountReceivedDetails)
        {
            long returnCode = -1;
            lstAmountReceivedDetails = new List<AmountReceivedDetails>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetEMITrackingReport(pFromDate, pToDate, BankName, out lstAmountReceivedDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetEMITrackingReport", ex);
            }
            return returnCode;
        }

        public long GetEstimationVsConsumtionReport(DateTime pFromDate, DateTime pToDate, string SearchItem, out List<BillofMaterialDetails> lstBillofMaterialDetails)
        {
            long returnCode = -1;
            lstBillofMaterialDetails = new List<BillofMaterialDetails>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetEstimationVsConsumtionReport(pFromDate, pToDate, SearchItem, out lstBillofMaterialDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetEMITrackingReport", ex);
            }
            return returnCode;
        }

        public long GetLabTestCountReportDetail(DateTime fromDate, DateTime toDate, int OrgID, long OrgAddID, string testName, List<InvDeptMaster> lstInvDeptMaster, string reportType, int ClientType, int ClientID, string TestCategory, int RefPhysicianID, int RefHospitalID, int AnalyzerID, int PageSize, int currentPageNo, out int totalRows, out List<InvestigationStatusReport> lstPatientInvestigationStatus)
        {
            long returnCode = -1;
            totalRows = -1;
            lstPatientInvestigationStatus = new List<InvestigationStatusReport>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetLabTestCountReportDetail(fromDate, toDate, OrgID, OrgAddID, testName, lstInvDeptMaster, reportType, ClientType, ClientID, TestCategory, RefPhysicianID, RefHospitalID, AnalyzerID, PageSize, currentPageNo, out totalRows, out lstPatientInvestigationStatus);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetLabTestCountReportDetail", ex);
            }
            return returnCode;
        }


        public long GetWriteOffReportDetail(DateTime fromDate, DateTime toDate, int OrgID, int ILocationID, long WriteOffID, string WriteOffType, int ClientTypeID, out List<PatientDueDetails> lstWriteOffDetail)
        {
            long returnCode = -1;
            lstWriteOffDetail = new List<PatientDueDetails>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetWriteOffReportDetail(fromDate, toDate, OrgID, ILocationID, WriteOffID, WriteOffType, ClientTypeID, out lstWriteOffDetail);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetWriteOffReportDetail", ex);
            }
            return returnCode;
        }



        public long GetCourierDetailsReport(long OrgID, int ILocationID, string Status, int RefOrgID, int RefPhyID, DateTime fromDate, DateTime toDate, long ClientID, int ClientTypeId, int CourierBoyID, string DispatchTypeid, long DispatchModeid, out List<DayWiseCollectionReport> lstCourierDetailsReport, out List<OrderedInvestigations> lstordred, int pagesize, int startrowindex, out int totalrows)
        {
            long returnCode = -1;
            totalrows = -1;
            lstCourierDetailsReport = new List<DayWiseCollectionReport>();
            lstordred = new List<OrderedInvestigations>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetCourierDetailsReport(OrgID, ILocationID, Status, RefOrgID, RefPhyID, fromDate, toDate, ClientID, ClientTypeId, CourierBoyID, DispatchTypeid, DispatchModeid, out lstCourierDetailsReport, out lstordred, pagesize, startrowindex, out totalrows);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetCourierDetailsReport ", ex);
            }
            return returnCode;
        }





        public long GetOrgCollectionReport(DateTime fDate, DateTime tDate, int pOrgID, long LID, int retreiveDataBaseOnVtype, int currencyID, int OrgDet, string pReportType, long ClientID, int OrgAddressID, string strObj, int ClientTypeID, int RefPhyID, int RefHospitalID, DataTable dtUserIDs, out List<DayWiseCollectionReport> lstDayWiseReport)
        {
            long returnCode = -1;
            lstDayWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetOrgCollectionReport(fDate, tDate, pOrgID, LID, retreiveDataBaseOnVtype, currencyID, OrgDet, pReportType, ClientID, OrgAddressID, strObj, ClientTypeID, RefPhyID, RefHospitalID, dtUserIDs, out lstDayWiseReport);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetOrgCollectionReport", ex);
            }
            return returnCode;
        }
        public long AmtDeptDetailsReport(DateTime pFromDate, DateTime pToDate, int pOrgID, out List<AmountDebtClosureDetails> lstACD)
        {
            long returnCode = -1;
            lstACD = new List<AmountDebtClosureDetails>();
            try
            {
                returnCode = new Report_DAL().AmtDeptDetailsReport(pFromDate, pToDate, pOrgID, out lstACD);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetAdmCancelledReport", ex);
            }
            return returnCode;
        }

        public long GetOrgApprovedReport(int OrgID, string approvedtime, string service, out List<ApprovedReports> lstDayWiseReport)
        {
            long returnCode = -1;
            lstDayWiseReport = new List<ApprovedReports>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetApprovedReport(OrgID, approvedtime, service, out lstDayWiseReport);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetOrgCollectionReport", ex);
            }
            return returnCode;
        }

        public long SavepdfReport(DataTable Visitids, Int64 Roleid, Int32 orgid, String pRecipient, String Method)
        {
            long returnCode = -1;
            try
            {
                Report_DAL ds = new Report_DAL();
                returnCode = ds.SavepdfReport(Visitids, Roleid, orgid, pRecipient, Method);
            }
            catch (Exception ex)
            {
                returnCode = -1;
                CLogger.LogError("Error in Report BL SavePrintedReport", ex);
            }
            return returnCode;
        }

        public long GetCheckDueAmount(long PatientID, long VisitID, long OrgID, long OrgAddressId, string Type, out string IsDuePending)
        {
            long returnCode = -1;
            IsDuePending = string.Empty;
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetCheckDueAmount(PatientID, VisitID, OrgID, OrgAddressId, Type, out IsDuePending);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetCheckDueAmount", ex);
            }
            return returnCode;
        }

        public long UpdateNotification(DataTable pReportData, DataTable pInvoicetData)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Report_DAL(globalContextDetails).UpdateNotification(pReportData, pInvoicetData);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL UpdateNotification", ex);
            }
            return returnCode;
        }


        public long GetPath(int OrgID, long VisitID, string category, out List<ReportSnapshot> ReportPath)
        {
            ReportPath = new List<ReportSnapshot>();
            long returnCode = -1;
            try
            {
                Report_DAL objReportDal = new Report_DAL(globalContextDetails);
                returnCode = objReportDal.GetPath(OrgID, VisitID, category, out ReportPath);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetReportPath", excp);
            }

            return returnCode;
        }
        public long SaveReportBarcodeDetails(long pVisitID, int pOrgID, byte[] pBarcode, string BarcodeType)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Report_DAL().SaveReportBarcodeDetails(pVisitID, pOrgID, pBarcode, BarcodeType);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL SaveReportBarcodeDetails", ex);
            }
            return returnCode;
        }
        public long InsertNotificationManual(long OrgId, long Locationid, long Visitid, string Type, string Emailaddress)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Report_DAL(globalContextDetails).InsertNotificationManual(OrgId, Locationid, Visitid, Type, Emailaddress);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL DepartmentWiseCollectionDetails", ex);
            }
            return returnCode;
        }
        public long GetHomeCollectionCancelledReport(long loginID, string status, DateTime FromDate, DateTime ToDate, out List<HomeCollectionCancel> lstHomeCollectionCancel)
        {
            long returnCode = -1;
            lstHomeCollectionCancel = new List<HomeCollectionCancel>();
            try
            {
                Report_DAL  reportDAL = new Report_DAL(globalContextDetails);

                returnCode = reportDAL.GetHomeCollectionCancelledReport(loginID, status, FromDate, ToDate, out lstHomeCollectionCancel);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetVisitWiseSearchMISReport ReportExcel_BL", ex);
            }
            return returnCode;

        }

        public long GetExpence(int ReportType, DateTime fromdate, DateTime todate, int OrgID, string UserName,out List<ExpenseReport> ExpenseDetails)
        {
            long returnCode = -1;
            ExpenseDetails = new List<ExpenseReport>();
            try
            {
                Report_DAL reportDAL = new Report_DAL(globalContextDetails);

                returnCode = reportDAL.GetExpence(ReportType, fromdate, todate, OrgID, UserName, out ExpenseDetails);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetExpence Report_BL", ex);
            }
            return returnCode;
        }
 /*added By jagatheesh  for Test wise Analyzer report*/
        public long GetTestWiseAnalyzerReportLims(int ReportType, DateTime fDate, DateTime tDate, int IntOrgID, string AnalyzerName, int ClientLocation, int TestId, out List<TestWiseAnalyzerReport> lstdata)
        {
            Report_DAL rpt_DAL = new Report_DAL();
            long returnCode = -1;
            lstdata = new List<TestWiseAnalyzerReport>();
            try
            {
                returnCode = rpt_DAL.GetTestWiseAnalyzerReportLims(ReportType, fDate, tDate, IntOrgID, AnalyzerName, ClientLocation, TestId, out lstdata);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetTestWiseAnalyzerReportLims", ex);
            }
            return returnCode;
        }
        /* End Added */
		        public long getClientIncome_Report(DateTime Fdate, DateTime Tdate, int OrgID, long ClientID, string ClientName, out DataSet dsResult, out int RowCount)
        {
            long returnCode = -1;
            dsResult = new DataSet();
            RowCount = 0;
            try
            {
                returnCode = new Report_DAL(globalContextDetails).getClientIncome_Report(Fdate, Tdate, OrgID, ClientID, ClientName, out dsResult, out RowCount);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While get ClientIncome_Report in Report_BL", ex);
            }
            return returnCode;


        }
        public long getClientStatics_Report(DateTime Fdate, DateTime Tdate, int OrgID, string ClientName,int reporttype, out DataSet dsResult)
        {
            long returnCode = -1;
            dsResult = new DataSet();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).getClientStatics_Report(Fdate, Tdate, OrgID, ClientName, reporttype,out dsResult);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While get ClientStatics_Report in Report_BL", ex);
            }
            return returnCode;
        }

        /****added by sree krishna for Waters ****/

        public long SaveWatersReportBarcodeDetails(string pVisitNumber, int pOrgID, byte[] pBarcode, string BarcodeType)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Report_DAL().SaveWatersReportBarcodeDetails(pVisitNumber, pOrgID, pBarcode, BarcodeType);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL SaveReportBarcodeDetails", ex);
            }
            return returnCode;
        }

        public long GetAttachmentName(long visitID, out List<Notifications> lstnotifations)
        {
            long returnCode = -1;
            lstnotifations = null;
            try
            {
                Report_DAL objReportDal = new Report_DAL(globalContextDetails);
                returnCode = objReportDal.GetAttachmentName(visitID, out lstnotifations);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetAttachmentName", excp);
            }

            return returnCode;
        }
 public long GetKPITATReport(DateTime fromdate, DateTime todate, string VisitNo, string HistoNo, string Specimen, string Status, string TatDelay, out List<HistopathologyTATReport> lsthisto)
        {
            long lresult = -1;
            lsthisto = new List<HistopathologyTATReport>();
            try
            {

                Report_DAL invdal = new Report_DAL(globalContextDetails);
                lresult = invdal.GetKPITATReport(fromdate, todate, VisitNo, HistoNo, Specimen, Status, TatDelay, out lsthisto);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetKPITATReport BL", ex);
            }
            return lresult;
        }
public long GetHistoDetailedReport(DateTime fromdate, DateTime todate, string PatientNo, string PatientName, string VisitNo, string HistoNo, string Specimen, long TestID, string Impression, string Malignant, string WHOClassification, string Staging, string Grading, out List<HistopathexaminationReport> lsthisto)
        {
            long lresult = -1;
            lsthisto = new List<HistopathexaminationReport>();
            try
            {

                Report_DAL invdal = new Report_DAL(globalContextDetails);
                lresult = invdal.GetHistoDetailedReport(fromdate, todate,PatientNo,PatientName, VisitNo, HistoNo, Specimen,TestID,Impression,Malignant,WHOClassification,Staging,Grading, out lsthisto);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetKPITATReport BL", ex);
            }
            return lresult;
        }
        public long PgetCashOutFlowPaymentReport(long LocationID, string PayableType, string FromDate, string ToDate, out DataTable dt)
        {
            long lresult = -1;
            dt = new DataTable();
            try
            {
                Report_DAL invdal = new Report_DAL(globalContextDetails);
                invdal.PgetCashOutFlowPaymentReport(LocationID, PayableType, FromDate, ToDate, out dt);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing PgetCashOutFlowPaymentReport BL", ex);

            }
            return lresult;
        }

		 /// <summary>
        /// Get Report details in Delivery Queue
        /// </summary>
        /// <param name="pOrgID"></param>
        /// <param name="pNotificationId"></param>
        /// <param name="pOrgAddressID"></param>
        /// <param name="pVisitID"></param>
        /// <param name="pUpdateStatus"></param>
        /// <param name="ReportType"></param>
        /// <param name="lstReportSnapshot"></param>
        /// <returns></returns>
        public long GetReportSnapshotNotifications(Int32 pOrgID, Int64 @pNotificationId, Int64 pOrgAddressID, Int64 pVisitID, bool pUpdateStatus, string ReportType, out List<ReportSnapshot> lstReportSnapshot)
        {
            long returnCode = -1;
            lstReportSnapshot = new List<ReportSnapshot>();
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetReportSnapshotNotifications(pOrgID, @pNotificationId, pOrgAddressID, pVisitID, pUpdateStatus, ReportType, out lstReportSnapshot);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetReportPathByVisitID in Report_BL", ex);
            }
            return returnCode;
        }

        // Start | Kiosk Printing Service | Velmurugan D | 30-Nov-2018
        public long GetPatientDetailsVisitNumber(string visitNumber, out List<ReportPrinting> lstReportPrinting)
        {
            lstReportPrinting = new List<ReportPrinting>();
            long returnCode = -1;
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetPatientDetailsVisitNumber(visitNumber, out lstReportPrinting);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return returnCode;
        }

        public long GetpatientReportPrintDetails(long visitID, int OrgID, out List<ReportPrinting> lstReportPrinting)
        {
            lstReportPrinting = new List<ReportPrinting>();
            long returnCode = -1;
            try
            {

                returnCode = new Report_DAL(globalContextDetails).GetpatientReportPrintDetails(visitID, OrgID, out lstReportPrinting);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return returnCode;
        }

        public long GetpatientinvestigationforvisitNumber(long visitID, int OrgID, string Guid, out List<ReportPrinting> lstReportPrinting)
        {
            lstReportPrinting = new List<ReportPrinting>();
            long returnCode = -1;
            try
            {

                returnCode = new Report_DAL(globalContextDetails).GetpatientinvestigationforvisitNumber(visitID, OrgID, Guid, out lstReportPrinting);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return returnCode;
        }


        public long GetPatientReportPrintingStatus(long visitID, out List<ReportPrinting> lstReportPrinting)
        {
            lstReportPrinting = new List<ReportPrinting>();
            long returnCode = -1;
            try
            {

                returnCode = new Report_DAL(globalContextDetails).GetPatientReportPrintingStatus(visitID, out lstReportPrinting);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return returnCode;
        }


        public SmartReport GetSmartReportNotification(long NotificationID, out string Paths)
        {
            long result = -1;
            Paths = "";
            SmartReport lstSmartReport = new SmartReport();
            Report_DAL objReportDal = new Report_DAL(globalContextDetails);
            try
            {


                lstSmartReport = objReportDal.GetSmartReportNotification(NotificationID, out Paths);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetSmartReportNotification:", ex);
            }
            return lstSmartReport;
        }
        public long UpdateSmartReportNotificationAPI(long NotificationID, long PatientVisitid, long OrgID, string Status)
        {
            long result = -1;

            Report_DAL objReportDal = new Report_DAL(globalContextDetails);
            try
            {
                result = objReportDal.UpdateSmartReportNotificationAPI(NotificationID, PatientVisitid, OrgID, Status);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetSmartReportNotification:", ex);
            }
            return result;
        }

        public long GetSmartReportMailNotification(long PatientVisitid, int OrgID, out List<ApprovedReports> lstReport)
        {
            long result = -1;
            lstReport = new List<ApprovedReports>();
            Report_DAL objReportDal = new Report_DAL(globalContextDetails);
            try
            {
                result = objReportDal.GetSmartReportMailNotification(PatientVisitid, OrgID, out lstReport);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetSmartReportNotification:", ex);
            }
            return result;
        }

        // END | Kiosk Printing Service | Velmurugan D | 30-Nov-2018
		
		 public long GetCustomizedReportList(long OrgId, out List<ReportMaster> lstreport)
        {
            lstreport = new List<ReportMaster>();
            long returnCode = -1;
            try
            {
                Report_DAL objReportDal = new Report_DAL(globalContextDetails);
                returnCode = objReportDal.GetCustomizedReportList(OrgId, out lstreport);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetCustomizedReportList", excp);
            }

            return returnCode;
        }

        public DataSet CustomizedReport(long ReportID, DateTime Fdate, DateTime Tdate, long ClientID, int VisitType, string TestDetail, int DeptID)
        {
            DataSet set = new DataSet();
            try
            {
                set = new Report_DAL(this.globalContextDetails).CustomizedReport(ReportID, Fdate, Tdate, ClientID, VisitType,TestDetail,DeptID);
            }
            catch (Exception exception)
            {
                CLogger.LogError("Error in Report_BL - CustomizedReport", exception);
            }
            return set;
        }
        public long GetDaywiseCollectionRevenueReport(DateTime pFromDate, DateTime pToDate, int pOrgID, long LocationID,long ClientID, out List<DayWiseCollectionRevenueReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionRevenueReport>();
           
            try
            {
                returnCode = new Report_DAL(globalContextDetails).GetDaywiseCollectionRevenueReport(pFromDate, pToDate, pOrgID, LocationID, ClientID, out lstDeptWiseReport);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetDaywiseCollectionRevenueReport", ex);
            }
            return returnCode;
        }

    }
}
