using System;
using System.Data;
using System.Configuration;
using System.Web;
using Attune.Solution.DAL;
using Attune.Podium.BusinessEntities;
using System.Collections.Generic;
using Attune.Podium.Common;

namespace Attune.Solution.BusinessComponent
{
    public class AdminReports_BL
    {
       ContextDetails globalContextDetails;
        public AdminReports_BL()
        {

        }
        public AdminReports_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public long GetVisitPurposeForReports(int OrgID, out List<AdminReports> lstVisitPurpose)
        {
            long returnCode = -1;
            lstVisitPurpose = new List<AdminReports>();
            try
            {
                AdminReports_DAL adminReportsDAL = new AdminReports_DAL(globalContextDetails);
                returnCode = adminReportsDAL.GetVisitPurposeForReports(OrgID, out lstVisitPurpose);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetVisitPurposeForReports in AdminReports_BL", ex);
            }
            return returnCode;
        }
        public long GetInvestigationRates(int OrgID, int iValue, long pRateID, long RateRefID, long ParentRefID, string Code,
           out List<AdminInvestigationRate> lstRates, out List<AdminInvestigationRate> lstgridRates, int PageIndex, int PageSize, string pName, out int PageCount, string Rate, string InvDeptID)
        {
            long returnCode = -1;
            PageCount = 0;
            lstRates = new List<AdminInvestigationRate>();
            lstgridRates = new List<AdminInvestigationRate>();
            try
            {
                AdminReports_DAL adminReportsDAL = new AdminReports_DAL(globalContextDetails);
                returnCode = adminReportsDAL.GetInvestigationRates(OrgID, iValue, pRateID, RateRefID, ParentRefID, Code, out lstRates, out lstgridRates, PageIndex, PageSize, pName, out PageCount, Rate, InvDeptID);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetInvestigationRates in AdminReports_BL", ex);
            }
            return returnCode;
        }

        public long GetVisitSubType(out List<VisitSubType> lstVisitSubType)
        {
            long returnCode = -1;
            lstVisitSubType = new List<VisitSubType>();
            try
            {
                AdminReports_DAL AdminReportsDAL = new AdminReports_DAL(globalContextDetails);
                returnCode = AdminReportsDAL.GetVisitSubType(out lstVisitSubType);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetVisitSubType in AdminReports_BL", ex);
            }
            return returnCode;
        }

        public long SearchInvestigationRates(int OrgID, int DdlID, int iClientId, string pName, out List<AdminInvestigationRate> lstInvRate)
        {
            long returnCode = -1;
            lstInvRate = new List<AdminInvestigationRate>();
            try
            {
                AdminReports_DAL adminReportsDAL = new AdminReports_DAL(globalContextDetails);
                returnCode = adminReportsDAL.SearchInvestigationRates(OrgID, DdlID, iClientId, pName, out lstInvRate);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetInvestigationRates in AdminReports_BL", ex);
            }
            return returnCode;
        }

       
         
        public long SaveInvestigationRate(List<AdminInvestigationRate> lstAdminRate, int dlValue, int dClientId, long Lid,
            int OrgID, long RateRefID, long ParentID, string Code, List<FeeSplitSeriveDetails> lstSplitDetails, string Reason)
        {
            long returnCode = -1;
            AdminReports_DAL adminReportsDAL = new AdminReports_DAL(globalContextDetails);
              
            try
            {

                returnCode = adminReportsDAL.SaveInvestigationRate(lstAdminRate, lstSplitDetails, dlValue, dClientId, Lid, OrgID, RateRefID, ParentID, Code, Reason);

            }
            catch (Exception excp)
            {
			CLogger.LogError("Error while executing SaveInvestigationRate in AdminReports_BL", excp);
            }
            return returnCode;
        }

        public long SaveRateSubTypeMapping(int OrgID, List<RateSubTypeMapping> lstRateSubTypeMapping)
        {
            long returnCode = -1;
            AdminReports_DAL adminreportDAL = new AdminReports_DAL(globalContextDetails);
             
            try
            {
                returnCode = adminreportDAL.SaveRateSubTypeMapping(OrgID, lstRateSubTypeMapping);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing SaveRateSubTypeMapping in AdminReports_BL", excp);
            }
            return returnCode;
        }

        public long GetVisitSubTypeID(int OrgID, int rateid, out List<RateSubTypeMapping> lstRateSubTypeMapping)
        {
            long returnCode = -1;
            AdminReports_DAL adminreportDAL = new AdminReports_DAL(globalContextDetails);
            lstRateSubTypeMapping = new List<RateSubTypeMapping>();
            try
            {
                returnCode = adminreportDAL.GetVisitSubTypeID(OrgID, rateid, out lstRateSubTypeMapping);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetVisitSubTypeID in AdminReports_BL", excp);
            }
            return returnCode;
        }

        //public long pGetProcedureDetail(string pName, int pOrgID, out List<ProcedureMaster> lstInvRate)
        //{
        //    long returnCode = -1;
        //    AdminReports_DAL adminReportsDAL = new AdminReports_DAL(globalContextDetails);
        //    lstInvRate = new List<ProcedureMaster>();
        //    try
        //    {
        //        returnCode = adminReportsDAL.pGetProcedureDetail(pName,pOrgID,out lstInvRate);
        //    }
        //    catch (Exception excp)
        //    {
        //        CLogger.LogError("Error while executing SaveInvestigationRate BL", excp);
        //    }
        //    return returnCode;
        //}

        //public long pInsertProcedureDetails(string pName, int pOrgID, long pLoginID)
        //{
        //    long returnCode = -1;
        //    AdminReports_DAL adminReportsDAL = new AdminReports_DAL(globalContextDetails);
        //    //lstInvRate = new List<ProcedureMaster>();
        //    try
        //    {
        //        returnCode = adminReportsDAL.pInsertProcedureDetails(pName, pOrgID, pLoginID);
        //    }
        //    catch (Exception excp)
        //    {
        //        CLogger.LogError("Error while executing SaveInvestigationRate BL", excp);
        //    }
        //    return returnCode;
        //}

        public long SaveReferenceRange(List<AdminInvestigationRate> lstInvestigation, int orgID)
        {
            long returnCode = -1;
            AdminReports_DAL adminReportsDAL = new AdminReports_DAL(globalContextDetails);
            
            try
            {
                returnCode = adminReportsDAL.SaveReferenceRange(lstInvestigation, orgID);
            }
            catch (Exception excp)
            {
			CLogger.LogError("Error while executing SaveReferenceRange in AdminReports_BL", excp);
            }
            return returnCode;
        }

        //public long GetUserstoManage(int pOrgID, string pName, int chkValue, out List<Users> lstUsers)
        //{
        //    long returnCode = -1;

        //    lstUsers = new List<Users>();

        //    try
        //    {
        //        returnCode = new AdminReports_DAL(globalContextDetails).GetUserstoManage(pOrgID, pName, chkValue, out lstUsers);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error in BL GetUserstoManage", ex);
        //    }
        //    return returnCode;
        //}

        public long GetUserstoManage(int pOrgID, string pName, int chkValue, int pageSize, int startRowIndex, string pCategory, out int totalRows, out List<Users> lstUsers, out List<Users> lstUsersForExcel)
        {
            long returnCode = -1;
            totalRows = 0;
            lstUsers = new List<Users>();
            lstUsersForExcel = new List<Users>();
            try
            {
                returnCode = new AdminReports_DAL(globalContextDetails).GetUserstoManage(pOrgID, pName, chkValue, pageSize, startRowIndex, pCategory, out totalRows, out lstUsers, out lstUsersForExcel);
            }
            catch (Exception excp)
            {
			CLogger.LogError("Error while executing GetUserstoManage in AdminReports_BL", excp);
            }
            return returnCode;
        }

        public long GetUserDetailtoManage(long pLogID, string pRName, long pAddID, int pOrgID, out List<Login> lstLogin, out List<Role> lstRole, out List<OrgUsers> lstOrgUsers, out List<Physician> lstPhySpeciality)
        {
            long returnCode = -1;
            lstLogin = new List<Login>();
            lstRole = new List<Role>();
            lstOrgUsers = new List<OrgUsers>();
            lstPhySpeciality = new List<Physician>();
            try
            {
                returnCode = new AdminReports_DAL(globalContextDetails).GetUserDetailtoManage(pLogID, pRName, pAddID, pOrgID, out lstLogin, out lstRole, out lstOrgUsers, out lstPhySpeciality);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetUserDetailtoManage in AdminReports_BL", ex);
            }

            return returnCode;
        }

        public long UpdateUserDetails(OrgUsers e, long ModifiedBy)
        {
            long returnCode = -1;

            try
            {
                returnCode = new AdminReports_DAL(globalContextDetails).UpdateUserDetails(e, ModifiedBy);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing UpdateUserDetails in AdminReports_BL", ex);
            }
            return returnCode;
        }

        public long DeleteUserDetail(long pLoginId, long pOrgUserId, string rName, long pRoleId, long ModifiedBy)
        {
            long returnCode = -1;

            try
            {
                returnCode = new AdminReports_DAL(globalContextDetails).DeleteUserDetail(pLoginId, pOrgUserId, rName, pRoleId, ModifiedBy);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing DeleteUserDetail in AdminReports_BL", ex);
            }

            return returnCode;
        }

        public long UpdateUserDetail(long pLoginId, long pOrgUserId, string rName, long pRoleId, long ModifiedBy, string phyType)
        {
            long returnCode = -1;

            try
            {
                returnCode = new AdminReports_DAL(globalContextDetails).UpdateUserDetail(pLoginId, pOrgUserId, rName, pRoleId, ModifiedBy, phyType);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing UpdateUserDetail in AdminReports_BL", ex);
            }

            return returnCode;
        }
        public long pInsertMedicalIndentMaster(int pOrgID, string pName, int pModifiedBy, int pMedicalIdentID)
        {
            long returnCode = -1;
            try
            {
                returnCode = new AdminReports_DAL(globalContextDetails).pInsertMedicalIndentMaster(pOrgID, pName, pModifiedBy, pMedicalIdentID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pInsertMedicalIndentMaster in AdminReports_BL", ex);
            }
            return returnCode;
        }
        public long pDeleteMedicalIndent(int pOrgID, int pID)
        {
            long returnCode = -1;
            try
            {
                returnCode = new AdminReports_DAL(globalContextDetails).pDeleteMedicalIndent(pOrgID, pID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pDeleteMedicalIndent in AdminReports_BL", ex);
            }
            return returnCode;
        }
        //public long UpdateMedicalIndent(int pOrgID, string pName, int pID,int pModifiedBy)
        //{
        //    long returnCode = -1;
        //    try
        //    {
        //        returnCode = new AdminReports_DAL(globalContextDetails).UpdateMedicalIndent(pOrgID, pName, pID,pModifiedBy);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error in BL UpdateUserDetail", ex);
        //    }
        //    return returnCode;
        //}
        //public long GetUserNames(string pNames, int pOrgId, out List<OrgUsers> lstOrgUsers)
        //{
        //    long returnCode = -1;
        //    lstOrgUsers = new List<OrgUsers>();
        //    try
        //    {
        //        returnCode = new AdminReports_DAL(globalContextDetails).GetUserNames(pNames, pOrgId, out lstOrgUsers);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error in BL GetUserNames", ex);
        //    }
        //    return returnCode;
        //}

        public long GetUserNames(string pNames, int pOrgId, string pCategory, string pStatus, out List<OrgUsers> lstOrgUsers)
        {
            long returnCode = -1;
            lstOrgUsers = new List<OrgUsers>();
            try
            {
                returnCode = new AdminReports_DAL(globalContextDetails).GetUserNames(pNames, pOrgId, pCategory, pStatus, out lstOrgUsers);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetUserNames in AdminReports_BL", ex);
            }
            return returnCode;
        }

        public long CountifUserDataExists(long pLogId, long pRoleID, string pRoleName, out int pCount, out int pCountRole)
        {
            pCount = -1;
            pCountRole = -1;
            long returnCode = -1;
            try
            {
                returnCode = new AdminReports_DAL(globalContextDetails).CountifUserDataExists(pLogId, pRoleID, pRoleName, out pCount, out pCountRole);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing CountifUserDataExists in AdminReports_BL", ex);
            }
            return returnCode;
        }

        public long GetPhysicianSpecialityList(long pLoginID, out List<Physician> lstPhysicianSpeciality)
        {
            long returnCode = -1;

            lstPhysicianSpeciality = new List<Physician>();
            try
            {
                returnCode = new AdminReports_DAL(globalContextDetails).GetPhysicianSpecialityList(pLoginID, out lstPhysicianSpeciality);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetPhysicianSpecialityList in AdminReports_BL", ex);
            }

            return returnCode;
        }

        public long GetPVDetailOnSecCode(int pOrgID, string pSecCode, out List<Patient> lstPatient, out int pCount)
        {
            long returnCode = -1;
            pCount = -1;
            lstPatient = new List<Patient>();
            try
            {
                returnCode = new AdminReports_DAL(globalContextDetails).GetPVDetailOnSecCode(pOrgID, pSecCode, out lstPatient, out pCount);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetPVDetailOnSecCode in AdminReports_BL", ex);
            }
            return returnCode;
        }
        public long UpdateRatesFromClientToClient(int typeID, long fromClientID, long toClientID, decimal addReduceValue, string addReduceType, long LID, int OrgID, long FromRateRefID, long FromParentID, long ToRateRefID, long ToParentID, String IsAction, string Rate, int FromOrgID)
        {
            long returnCode = -1;
            AdminReports_DAL arDAL = new AdminReports_DAL(globalContextDetails);
            try
            {
                returnCode = arDAL.UpdateRatesFromClientToClient(typeID, fromClientID, toClientID, addReduceValue, addReduceType, LID, OrgID, FromRateRefID, FromParentID, ToRateRefID, ToParentID, IsAction, Rate, FromOrgID);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing UpdateRatesFromClientToClient in AdminReports_BL", ex);
            }
            return returnCode;
        }

        public long GetPhysicianWiseCollectionSummary(long OrgID, long PhysicianID, DateTime dFromDate, DateTime dToDate, string isCreditBill, out List<CashFlowSummary> lstCashFlowSummary, out List<CashFlowSummary> lstCashFlowSummarySubTotal)
        {
            long returnCode = -1;
            AdminReports_DAL arDAL = new AdminReports_DAL(globalContextDetails);
            lstCashFlowSummary = new List<CashFlowSummary>();
            lstCashFlowSummarySubTotal = new List<CashFlowSummary>();
            try
            {
                returnCode = arDAL.GetPhysicianWiseCollectionSummary(OrgID, PhysicianID, dFromDate, dToDate, isCreditBill, out lstCashFlowSummary, out lstCashFlowSummarySubTotal);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetPhysicianWiseCollectionSummary in AdminReports_BL", ex);
            }
            return returnCode;
        }

        public long GetPhysicianWiseCollectionDetail(long OrgID, long PhysicianID, DateTime dFromDate, DateTime dToDate, string type, string feeType, string isCreditBill, out List<CashFlowSummary> lstCashFlowSummary)
        {
            long returnCode = -1;
            AdminReports_DAL arDAL = new AdminReports_DAL(globalContextDetails);
            lstCashFlowSummary = new List<CashFlowSummary>();
            try
            {
                returnCode = arDAL.GetPhysicianWiseCollectionDetail(OrgID, PhysicianID, dFromDate, dToDate, type, feeType, isCreditBill, out lstCashFlowSummary);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetPhysicianWiseCollectionDetail in AdminReports_BL", ex);
            }
            return returnCode;
        }

        public long GetDailyReports(DateTime fromDate, DateTime toDate, int loginID, int orgID, out List<DailyReport> cashBillList, out List<DailyReport> creditBillList, out List<DailyReport> dueReceivedBillList, out List<DailyReport> cancelledBillList, out decimal cashAmount, out decimal creditAmount, out decimal dueReceivedAmount, out decimal pendingDueAmount, out decimal discountAmount)
        {
            long returnCode = -1;
            cashAmount = 0;
            creditAmount = 0;
            dueReceivedAmount = 0;
            pendingDueAmount = 0;
            discountAmount = 0;
            cashBillList = new List<DailyReport>();
            creditBillList = new List<DailyReport>();
            dueReceivedBillList = new List<DailyReport>();
            cancelledBillList = new List<DailyReport>();
            try
            {
                returnCode = new AdminReports_DAL(globalContextDetails).GetDailyReports(fromDate, toDate, loginID, orgID, out cashBillList, out creditBillList, out dueReceivedBillList, out cancelledBillList, out cashAmount, out creditAmount, out dueReceivedAmount, out pendingDueAmount, out discountAmount);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetDailyReports in AdminReports_BL", ex);
            }
            return returnCode;
        }

        public long SearchDueBills(DateTime strBillFromDate, DateTime strBillToDate, int OrgID, string pType, out List<DailyReport> dueSearch)
        {
            long returnCode = -1;
            dueSearch = new List<DailyReport>();
            try
            {
                AdminReports_DAL patientDAL = new AdminReports_DAL(globalContextDetails);
                returnCode = patientDAL.SearchDueBills(strBillFromDate, strBillToDate, OrgID, pType, out dueSearch);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SearchDueBills in AdminReports_BL", ex);
            }
            return returnCode;
        }

        public long GetSamplesReport(int hospitalID, int physicianID, DateTime fromDate, DateTime toDate, int OrgID, out List<PatientVisit> lstSamplesReport)
        {
            long returnCode = -1;
            lstSamplesReport = new List<PatientVisit>();
            returnCode =
            new AdminReports_DAL(globalContextDetails).GetSamplesReport(hospitalID, physicianID, fromDate, toDate, OrgID, out lstSamplesReport);
            return returnCode;
        }
        public long GetPhysicianWiseWardVisit(DateTime dFromDate, DateTime dToDate, long PhysicianID, int orgAddressID, out List<Patient> lstPatient)
        {
            long returnCode = -1;
            AdminReports_DAL arDAL = new AdminReports_DAL(globalContextDetails);
            lstPatient = new List<Patient>();
            try
            {
                returnCode = arDAL.GetPhysicianWiseWardVisit(dFromDate, dToDate, PhysicianID, orgAddressID, out lstPatient);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetPhysicianWiseWardVisit in AdminReports_BL", ex);
            }
            return returnCode;
        }

        public long GetIPBilledVsActuals(int OrgID, DateTime dFromDate, DateTime dToDate, string serviceType, out List<FinalBill> lstFinalBill)
        {
            long returnCode = -1;
            AdminReports_DAL arDAL = new AdminReports_DAL(globalContextDetails);
            lstFinalBill = new List<FinalBill>();
            try
            {
                returnCode = arDAL.GetIPBilledVsActuals(OrgID, dFromDate, dToDate, serviceType, out lstFinalBill);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetIPBilledVsActuals in AdminReports_BL", ex);
            }
            return returnCode;
        }
        public long pGetRateTypeMaster(int orgID, string OrgType, out List<RateMaster> lstRate)
        {
            long returnCode = -1;
            AdminReports_DAL adminReportsDAL = new AdminReports_DAL(globalContextDetails);
            lstRate = new List<RateMaster>();
            try
            {
                returnCode = adminReportsDAL.pGetRateTypeMaster(orgID, OrgType, out lstRate);
            }
            catch (Exception excp)
            {
			CLogger.LogError("Error while executing pGetRateTypeMaster in AdminReports_BL", excp);
            }
            return returnCode;
        }



        public long pGetRateMaster(int orgID, out List<RateTypeMaster> lstRate)
        {
            long returnCode = -1;
            AdminReports_DAL adminReportsDAL = new AdminReports_DAL(globalContextDetails);
            lstRate = new List<RateTypeMaster>();
            try
            {
                returnCode = adminReportsDAL.pGetRateMaster(orgID, out lstRate);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing pGetRateMaster in AdminReports_BL", excp);
            }
            return returnCode;
        }



        public long pInsertRateType(int pOrgID, string pName, long pModifiedBy, long PolicyID, string VendorType, string VendorSubType, string Comments, out long returnCode)
        {
            returnCode = -1;
            try
            {
                returnCode = new AdminReports_DAL(globalContextDetails).pInsertRateType(pOrgID, pName, pModifiedBy, PolicyID, VendorType, VendorSubType, Comments, out returnCode);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pInsertRateType in AdminReports_BL", ex);
            }
            return returnCode;
        }


        public long pDeleteRateType(int pOrgID, string pName, int pID)
        {
            long returnCode = -1;
            try
            {
                returnCode = new AdminReports_DAL(globalContextDetails).pDeleteRateType(pOrgID, pName, pID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pDeleteRateType in AdminReports_BL", ex);
            }
            return returnCode;
        }


        public long UpdateRateType(int pOrgID, string pName, int pID, long pModifiedBy, long PolicyID, string VendorType, string VendorSubType, string Comments)
        {
            long returnCode = -1;
            try
            {
                returnCode = new AdminReports_DAL(globalContextDetails).UpdateRateType(pOrgID, pName, pID, pModifiedBy, PolicyID, VendorType, VendorSubType, Comments);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateRateType in AdminReports_BL", ex);
            }
            return returnCode;
        }


        public long GetMedicalIndentMaster(int pOrgID, out List<MedicalIndentMaster> MDI)
        {
            long returnCode = -1;
            MDI = new List<MedicalIndentMaster>();

            try
            {
                returnCode = new AdminReports_DAL(globalContextDetails).GetMedicalIndentMaster(pOrgID, out MDI);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetMedicalIndentMaster in AdminReports_BL", ex);
            }
            return returnCode;
        }
        public long pGetClaimAmountLogic(int orgID, out List<ClaimAmountLogic> lstClaim)
        {
            long returnCode = -1;
            AdminReports_DAL adminReportsDAL = new AdminReports_DAL(globalContextDetails);
            lstClaim = new List<ClaimAmountLogic>();
            try
            {
                returnCode = adminReportsDAL.pGetClaimAmountLogic(orgID, out lstClaim);
            }
            catch (Exception excp)
            {
			CLogger.LogError("Error while executing pGetClaimAmountLogic in AdminReports_BL", excp);
            }
            return returnCode;
        }

        public long GetPhysicianReports(DateTime dFromDate, DateTime dToDate, long OrgID, string PhysicianID, out List<DayWiseCollectionReport> lstphySummary)
        {
            long returnCode = -1;
            AdminReports_DAL arDAL = new AdminReports_DAL(globalContextDetails);
            lstphySummary = new List<DayWiseCollectionReport>();

            try
            {
                returnCode = arDAL.GetPhysicianReports(dFromDate, dToDate, OrgID, PhysicianID, out lstphySummary);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetPhysicianReports in AdminReports_BL", ex);
            }
            return returnCode;
        }
        public long InsertVisitStateChanged(string BillNumber, int OrgID, long ApprovedBy, string Reason, long CreatedBy, string isDayCare)
        {
            long returnCode = -1;
            try
            {
                returnCode = new AdminReports_DAL(globalContextDetails).InsertVisitStateChanged(BillNumber, OrgID, ApprovedBy, Reason, CreatedBy, isDayCare);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing InsertVisitStateChanged in AdminReports_BL", ex);
            }
            return returnCode;
        }
        public long GetUserNameWithLoginID(string pNames, int pOrgId,string pAuthTypeName, out List<OrgUsers> lstOrgUsers)
        {
            long returnCode = -1;
            lstOrgUsers = new List<OrgUsers>();
            try
            {
                returnCode = new AdminReports_DAL(globalContextDetails).GetUserNameWithLoginID(pNames, pOrgId,pAuthTypeName, out lstOrgUsers);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetUserNames in AdminReports_BL", ex);
            }
            return returnCode;
        }
        public long GetBillNoDetails(string BillNumber, int OrgID, out List<Patient> lstPatientBillDetails)
        {
            long returnCode = -1;
            lstPatientBillDetails = new List<Patient>();
            try
            {
                AdminReports_DAL adminReportsDAL = new AdminReports_DAL(globalContextDetails);
                returnCode = adminReportsDAL.GetBillNoDetails(BillNumber, OrgID, out lstPatientBillDetails);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetBillNoDetails in AdminReports_BL", ex);
            }
            return returnCode;
        }
        public long pGetOrgLoction(out List<Organization> lstOrg)
        {
            long returnCode = -1;
            AdminReports_DAL arDAL = new AdminReports_DAL(globalContextDetails);
            lstOrg = new List<Organization>();

            try
            {
                returnCode = arDAL.pGetOrgLoction(out lstOrg);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetOrgLoction in AdminReports_BL", ex);
            }
            return returnCode;
        }
        public long pGetOrganizationLocation(long OrgID, long addid, int chid, out List<OrganizationAddress> lstOrgLocation)
        {
            long returnCode = -1;
            AdminReports_DAL arDAL = new AdminReports_DAL(globalContextDetails);
            lstOrgLocation = new List<OrganizationAddress>();

            try
            {
                returnCode = arDAL.pGetOrganizationLocation(OrgID, addid, chid, out lstOrgLocation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetOrganizationLocation in AdminReports_BL", ex);
            }
            return returnCode;
        }
        public long GetOrganizationLocationClient(long  OrgID, out List<ClientMaster> lstOrgLocationClient)
        {
            long returnCode = -1;
            AdminReports_DAL arDAL = new AdminReports_DAL(globalContextDetails);
            lstOrgLocationClient = new List<ClientMaster>();

            try
            {
                returnCode = arDAL.GetOrganizationLocationClient(OrgID, out lstOrgLocationClient);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetOrganizationLocationClient in AdminReports_BL", ex);
            }
            return returnCode;
        }
        public long GetMappedAndDefaultClient(long OrgID, long OrgAddID, out List<ClientMaster> lstdefLocationClient)
        {
            long returnCode = -1;
            AdminReports_DAL arDAL = new AdminReports_DAL(globalContextDetails);
            lstdefLocationClient = new List<ClientMaster>();

            try
            {
                returnCode = arDAL.GetMappedAndDefaultClient(OrgID, OrgAddID, out lstdefLocationClient);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetMappedAndDefaultClient in AdminReports_BL", ex);
            }
            return returnCode;
        }

        public long IDUOrgLocation(long OrgID, UserAddress useAddress, string location, string type, long id, string LocationCode, string CenterTypeCode, string isdefault, string ismappedclients, string status, string DefaultClientID, byte[] Logo, List<InvClientMaster> lstClient, List<InvClientMaster> lstRemoveClient, int IsScanInScanOut, out List<OrganizationAddress> lstOrgLocation)
        {
            long returnCode = -1;
            AdminReports_DAL arDAL = new AdminReports_DAL(globalContextDetails);
            lstOrgLocation = new List<OrganizationAddress>();

            try
            {
                returnCode = arDAL.IDUOrgLocation(OrgID, useAddress, location, type, id, LocationCode, CenterTypeCode, isdefault,ismappedclients ,status,DefaultClientID,Logo, lstClient, lstRemoveClient,IsScanInScanOut,out lstOrgLocation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing IDUOrgLocation in AdminReports_BL", ex);
            }
            return returnCode;
        }

        
        public long SaveMappedItems(List<AdminInvestigationRate> lstMappedRates, int iValue, long ClientId, long TPAId, long RateId, long LID, int OrgID)
        {
            long returnCode = -1;
            AdminReports_DAL arDAL = new AdminReports_DAL(globalContextDetails);
           

            try
            {
                returnCode = arDAL.SaveMappedItems(lstMappedRates, iValue, ClientId, TPAId, RateId, LID, OrgID);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SaveMappedItems in AdminReports_BL", ex);
            }
            return returnCode;
        }
        public long GetSpkgContentRate(long PackageID, int OrgID, long ClientID, out List<SurgeryPackageFeeTypeRateMaster> lSurgeryPkgMaster)
        {
            long returnCode = -1;
            lSurgeryPkgMaster = new List<SurgeryPackageFeeTypeRateMaster>();
            try
            {
                returnCode = new AdminReports_DAL(globalContextDetails).GetSpkgContentRate(PackageID, OrgID, ClientID, out lSurgeryPkgMaster);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetSpkgContentRate in AdminReports_BL", ex);
            }
            return returnCode;
        }
        public long SaveSurgerypacakageContentRate(List<SurgeryPackageFeeTypeRateMaster> lstRatesspkg)
        {
            long returnCode = -1;
            
            try
            {
                returnCode = new AdminReports_DAL(globalContextDetails).SaveSurgerypacakageContentRate(lstRatesspkg);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing InsertVisitStateChanged in AdminReports_BL", ex);
            }
            return returnCode;
        }
     
        public long GetRateOrgMapping(int OrgID, int pageSize,string RateCardName, int StartRowIndex, out int totalRows, out List<RateRefOrgMapping> lstRateRefOrgMapping)
        {
            long returnCode = -1;
            totalRows = 0;
            lstRateRefOrgMapping = new List<RateRefOrgMapping>();
            try
            {
                returnCode = new AdminReports_DAL(globalContextDetails).GetRateOrgMapping(OrgID, pageSize, RateCardName,StartRowIndex, out totalRows, out lstRateRefOrgMapping);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetRateOrgMapping in AdminReports_BL", ex);
            }
            return returnCode;
        }
        public long SaveRateOrgMap(string RateName, int RateID, int TrustedOrgID, int LoggedinOrgID, long PolicyID, string QueryType, long CreatedBy)
        {
            long returnCode = -1;
            try
            {
                returnCode = new AdminReports_DAL(globalContextDetails).SaveRateOrgMap(RateName, RateID, TrustedOrgID, LoggedinOrgID, PolicyID, QueryType, CreatedBy);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SaveRateOrgMap in AdminReports_BL", ex);
            }
            return returnCode;
        }
        public long GetSharingOrganizations(int orgID, out List<Organization> lstorgn)
        {
            long returnCode = -1;
            lstorgn = new List<Organization>();
            try
            {
                returnCode = new AdminReports_DAL(globalContextDetails).GetSharingOrganizations(orgID, out lstorgn);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSharingOrganizations in AdminReports_BL", ex);
            }
            return returnCode;

        }
        public long pGetRateTypeMasters(int orgID, out List<PageContextkey> lstRate)
        {
            long returnCode = -1;
            AdminReports_DAL adminReportsDAL = new AdminReports_DAL(globalContextDetails);
            lstRate = new List<PageContextkey>();
            try
            {
                returnCode = adminReportsDAL.pGetRateTypeMasters(orgID, out lstRate);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing pGetRateTypeMasters in AdminReports_BL", excp);
            }
            return returnCode;
        }
        public long GetSampleContainer(int OrgID, out List<InvSampleMaster> lstInvSampleMaster, out List<InvestigationSampleContainer> lstInvSampleContainer)
        {
            long returnCode = -1;
            AdminReports_DAL Admin_DAL = new AdminReports_DAL(globalContextDetails);
            lstInvSampleMaster = new List<InvSampleMaster>();
            lstInvSampleContainer = new List<InvestigationSampleContainer>();
            try
            {
                returnCode = Admin_DAL.GetSampleContainer(OrgID, out lstInvSampleMaster, out lstInvSampleContainer);
            }
            catch (Exception excp)
            {
			CLogger.LogError("Error while executing GetSampleContainer in AdminReports_BL", excp);
            }
            return returnCode;
        }
        public long SaveSampleContainer(int OrgID, string SampleName, string SampleCode, string SampleDesc, long SampleID, string SampleType,String Status)
        {
            long returnCode = -1;
            AdminReports_DAL Admin_DAL = new AdminReports_DAL(globalContextDetails); 
            try
            {
                returnCode = Admin_DAL.SaveSampleContainer(OrgID, SampleName, SampleCode, SampleDesc, SampleID, SampleType, Status);
            }
            catch (Exception excp)
            {
			CLogger.LogError("Error while executing SaveSampleContainer in AdminReports_BL", excp);
            }
            return returnCode;
        }
       public long SaveAnalyzerDetails(int OrgID, int LocationID, List<InvInstrumentMaster> lstInvInstrumentMaster, out long InstrumentID)
        {
            long returnCode = -1;
            InstrumentID = 0;
            try
            {
                returnCode = new AdminReports_DAL(globalContextDetails).SaveAnalyzerDetails(OrgID, LocationID, lstInvInstrumentMaster, out InstrumentID);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SaveAnalyzerDetails in AdminReports_BL", ex);
            }
            return returnCode;
        } 
        public long GetTrustedOrganizationAddress(int orgid, out List<Organization> lstorg)
        {
            long returnCode = -1;
            lstorg=new List<Organization>();
            AdminReports_DAL Admin_DAL = new AdminReports_DAL(globalContextDetails);
            try
            {
                returnCode =  Admin_DAL.GetTrustedOrganizationAddress(orgid, out lstorg);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetTrustedOrganizationAddress in AdminReports_BL", ex);
            }
            return returnCode;

        }

        public long GetUserNamewithID(string pNames, int pOrgId, out List<OrgUsers> lstOrgUsers)
        {
            long returnCode = -1;
            lstOrgUsers = new List<OrgUsers>();
            try
            {
                returnCode = new AdminReports_DAL(globalContextDetails).GetUserNameWithID(pNames, pOrgId, out lstOrgUsers);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing GetUserNames in AdminReports_BL", ex);
            }
            return returnCode;
        }
        public long GetRateTypeMasterNew(int orgID, string OrgType,string RateName, int pageSize, int StartRowIndex, out int totalRows, out List<RateMaster> lstRate)
        {
            long returnCode = -1;
            totalRows = 0;
            AdminReports_DAL adminReportsDAL = new AdminReports_DAL(globalContextDetails);
            lstRate = new List<RateMaster>();
            try
            {
                returnCode = adminReportsDAL.GetRateTypeMasterNew(orgID, OrgType,RateName, pageSize, StartRowIndex, out totalRows, out lstRate);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetRateTypeMasterNew in AdminReports_BL", excp);
            }
            return returnCode;
        }


        public long SaveratesDetails(DataTable dtpratetest, long pRateID)
        {
        

            long returnCode = -1;
            try
            {
                AdminReports_DAL ratesuploadDAL = new AdminReports_DAL(globalContextDetails);
                returnCode = ratesuploadDAL.SaveratesDetails(dtpratetest, pRateID);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SaveratesDetails in AdminReports_BL", ex);
            }
            return returnCode;
        
        }
        #region  ManageRates ISMapped Added
        public long RemoveInvestigationRate(List<AdminInvestigationRate> lstAdminRate, int dlValue, int dClientId,
          int OrgID, List<FeeSplitSeriveDetails> lstSplitDetails)
        {
            long returnCode = -1;
            AdminReports_DAL adminReportsDAL = new AdminReports_DAL(globalContextDetails);
            try
            {

                returnCode = adminReportsDAL.RemoveInvestigationRate(lstAdminRate, lstSplitDetails, dlValue, dClientId, OrgID);

            }

            catch (Exception excp)
            {
			CLogger.LogError("Error while executing RemoveInvestigationRate in AdminReports_BL", excp);
            }

            return returnCode;

        }
        #endregion
        #region Newinstance creation
        public long pgetmyloc(int insid, out List<NewInstanceWaitingCustomers> lstloc)
        {
            long returnCode = -1;
            AdminReports_DAL admindal = new AdminReports_DAL(globalContextDetails);
            lstloc = new List<NewInstanceWaitingCustomers>();
            try
            {
                returnCode = admindal.pgetmyloc(insid, out lstloc);
            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing pgetmyloc in AdminReports_BL", ex);
            }
            return returnCode;

        }
        #endregion
        public long SearchDoctorPayout(int PhysicianID, DateTime strBillFromDate, DateTime strBillToDate, byte Mode, List<DoctorPayoutDetails> lstFinalbillid, List<DoctorPayoutDetails> lstDocPayout, out List<DoctorPayoutDetails> lstDoctorpayout)
        {
            long returnCode = -1;
            lstDoctorpayout = new List<DoctorPayoutDetails>();
            try
            {
                AdminReports_DAL patientDAL = new AdminReports_DAL(globalContextDetails);
                returnCode = patientDAL.SearchDoctorPayout(PhysicianID, strBillFromDate, strBillToDate, Mode, lstFinalbillid, lstDocPayout, out lstDoctorpayout);

            }
            catch (Exception ex)
            {
			CLogger.LogError("Error while executing SearchDueBills in AdminReports_BL", ex);
            }
            return returnCode;
        }
        public long GetHolidayMaster(int pOrgID, out List<Holidaymaster> lstHolidaymaster)
        {
            lstHolidaymaster = new List<Holidaymaster>();
            long returnCode = -1;
            try
            {
                AdminReports_DAL arDAL = new AdminReports_DAL(globalContextDetails);
                returnCode = arDAL.GetHolidayMaster(pOrgID, out lstHolidaymaster);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing GetHolidayMaster AdminReports_BL", ex);
            }
            return returnCode;
        }
        public long GetScheduleDay(int OrgID, out List<CodingScheme> lstScheduleday)
        {
            lstScheduleday = new List<CodingScheme>();
            long returnCode = -1;
            try
            {
                AdminReports_DAL arDAL = new AdminReports_DAL(globalContextDetails);
                returnCode = arDAL.GetScheduleDay(OrgID, out lstScheduleday);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing GetScheduleDay AdminReports_BL", ex);
            }
            return returnCode;
        }

        public long SaveManageSchedule(List<TATSchedule> lstTATSchedule, List<Holidaymaster> lstHolidaymaster, out string outMessage)
        {
            long returnCode = -1;
            AdminReports_DAL arDAL = new AdminReports_DAL(globalContextDetails);
            outMessage = string.Empty;

            try
            {
                returnCode = arDAL.SaveManageSchedule(lstTATSchedule, lstHolidaymaster, out outMessage);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in AdminReports_BL SaveManageSchedule", ex);
            }
            return returnCode;
        }



        public long GetManageSchedule(int pagesize, int pageindex, string search, out List<TATSchedule> lstTATSchedule, out List<Holidaymaster> lstHolidaymaster)
        {
            long returnCode = -1;
            AdminReports_DAL arDAL = new AdminReports_DAL(globalContextDetails);
            lstTATSchedule = new List<TATSchedule>();
            lstHolidaymaster = new List<Holidaymaster>();
            List<SlotValue> lstSlotValue = new List<SlotValue>();
            try
            {
                returnCode = arDAL.GetManageSchedule(pagesize, pageindex, search, out lstTATSchedule, out lstSlotValue, out lstHolidaymaster);
                if (lstSlotValue.Count > 0)
                {
                    foreach (var tatschedule in lstTATSchedule)
                    {
                        tatschedule.SlotValue = new List<SlotValue>();
                        foreach (var slotvalue in lstSlotValue)
                        {
                            if (slotvalue.scheduleid == tatschedule.Scheduleid)
                            {
                                tatschedule.SlotValue.Add(slotvalue);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetManageSchedule in AdminReport_BL", ex);
            }
            return returnCode;
        }


        public long EditManageSchedule(int Scheduleid, out List<TATSchedule> lstTATSchedule, out List<Holidaymaster> lstHolidaymaster)
        {
            long returnCode = -1;
            AdminReports_DAL arDAL = new AdminReports_DAL(globalContextDetails);
            List<SlotValue> lstSlotValue = new List<SlotValue>();
            lstTATSchedule = new List<TATSchedule>();
            lstHolidaymaster = new List<Holidaymaster>();
            try
            {
                returnCode = arDAL.EditManageSchedule(Scheduleid, out lstTATSchedule, out lstSlotValue, out lstHolidaymaster);

                if (lstSlotValue.Count > 0)
                {
                    foreach (var tatschedule in lstTATSchedule)
                    {
                        tatschedule.SlotValue = new List<SlotValue>();
                        foreach (var slotvalue in lstSlotValue)
                        {
                            if (slotvalue.scheduleid == tatschedule.Scheduleid)
                            {
                                tatschedule.SlotValue.Add(slotvalue);
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing EditManageSchedule in AdminReports_BL", ex);
            }
            return returnCode;
        }
       
    }
}
