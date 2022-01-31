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
    public class AdminReports_DAL
    {
        ContextDetails globalContextDetails;
        public AdminReports_DAL()
        {

        }
        public AdminReports_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetVisitPurposeForReports(int OrgID, out List<AdminReports> lstVisitPurpose)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pGetVisitPurposeForReportsCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstVisitPurpose = new List<AdminReports>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstVisitPurpose);
            }
            return returnCode;
        }

        //Changes of DataSet To DataReader Made By Arivalagan k
        public long GetInvestigationRates(int OrgID, int iValue, long pRateID, long RateRefID, long ParentRefID, string Code,
            out List<AdminInvestigationRate> lstRates, out List<AdminInvestigationRate> lstgridRates, int PageIndex, int PageSize, string pName, out int PageCount, string Rate, string InvDeptID)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            PageCount = 0;
            int rsCount = 0;
            SqlCommand cmd = Command.pGetAllInvRateCommand(OrgID, iValue, pRateID, RateRefID, ParentRefID, Code, PageIndex, PageSize, pName, out PageCount, UDT_DAL.ConvertToUDT_Context(globalContextDetails), Rate, InvDeptID);
            lstRates = new List<AdminInvestigationRate>();
            lstgridRates = new List<AdminInvestigationRate>();
            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstRates);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstgridRates);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                    Int32.TryParse(cmd.Parameters["@PageCount"].Value.ToString(), out PageCount);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetInvestigationRates in ADminReportDal", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returnCode;
        }

        public long GetVisitSubType(out List<VisitSubType> lstVisitSubType)
        {
            long returnCode = -1;
            lstVisitSubType = new List<VisitSubType>();
            SqlCommand cmd = Command.pGetVisitSubTypeCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstVisitSubType);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetProductCategories in AdminReports_DAL", ex);
            }
            return returnCode;
        }

        public long GetVisitSubTypeID(int OrgID, int rateid, out List<RateSubTypeMapping> lstRateSubTypeMapping)
        {
            long returnCode = -1;
            lstRateSubTypeMapping = new List<RateSubTypeMapping>();
            try
            {
                SqlCommand cmd = Command.pGetVisitSubTypeIDCommand(OrgID, rateid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstRateSubTypeMapping);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in AdminReport_DAL GetUserNameWithLoginID", ex);
            }
            return returnCode;
        }

        public long SearchInvestigationRates(int OrgID, int DdlID, int iClientId, string pName, out List<AdminInvestigationRate> lstInvRate)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pSearchAllInvRateCommand(OrgID, DdlID, iClientId, pName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstInvRate = new List<AdminInvestigationRate>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvRate);
            }
            return returnCode;
        }



        public long SaveRateSubTypeMapping(int OrgID, List<RateSubTypeMapping> lstRateSubTypeMapping)
        {
            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
            DataTable DtRateSubType = UDT_DAL.ConvertToRateSubTypeMapping(lstRateSubTypeMapping);
            cmd = Command.pInsertRateSubTypeMappingCommand(OrgID, DtRateSubType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));


            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
            }
            return returnCode;
        }

        public long SaveInvestigationRate(List<AdminInvestigationRate> lstAdminRate,
            List<FeeSplitSeriveDetails> lstSplitDetails,
            int dlValue, int dClientId, long Lid, int OrgID, long RateRefID, long ParentID, string Code, string Reason)
        {
            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
            DataTable dtAdminRate = UDT_DAL.ConvertToInvestigationAdminRate(lstAdminRate);
            DataTable DtSplitRate = UDT_DAL.ConvertToFeeSplitSeriveDetails(lstSplitDetails);
            cmd = Command.pUpdateAllInvRateCommand(dtAdminRate, DtSplitRate, dlValue, dClientId, out returnCode, Lid, OrgID, RateRefID, ParentID, Code, UDT_DAL.ConvertToUDT_Context(globalContextDetails), Reason);
            using (DBEngine dBEngine = new DBEngine(false))
            {
                dBEngine.ExecuteNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@returnStatus"].Value);
            }
            return returnCode;
        }
        public long SaveReferenceRange(List<AdminInvestigationRate> lstInvestigation, int orgID)
        {
            long returnCode = -1;
            int retValue = -1;
            SqlCommand cmd = new SqlCommand();
            DataTable dtInvestigations = UDT_DAL.ConvertToInvestigationAdminRate(lstInvestigation);
            cmd = Command.pUpdateReferenceRangeCommand(dtInvestigations, orgID, out retValue, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dBEngine = new DBEngine(false))
            {                //dBEngine.ExecuteTransactionalNonQuery(cmd);
                dBEngine.ExecuteNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@returnStatus"].Value);
            }
            return returnCode;
        }
        public long GetUserstoManage(int pOrgID, string pName, int chkValue, int pageSize, int startRowIndex, string pCategory, out int totalRows, out List<Users> lstUsers, out List<Users> lstUsersForExcel)
        {
            long returnCode = -1;
            lstUsers = new List<Users>();
            lstUsersForExcel = new List<Users>();

            SqlCommand cmd = new SqlCommand();
            cmd = Command.pGetUserstoManageCommand(pOrgID, pName, chkValue, pageSize, startRowIndex, pCategory, out totalRows, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstUsers);
            }
            if (ds.Tables[2].Rows.Count > 0)
            {
                totalRows = Convert.ToInt32(ds.Tables[2].Rows[0]["totalRows"]);
                returnCode = Utilities.ConvertTo(ds.Tables[2], out lstUsersForExcel);
            }
            return returnCode;
        }
        public long GetUserDetailtoManage(long pLogID, string pRName, long pAddID, int pOrgId, out List<Login> lstLogin, out List<Role> lstRole, out List<OrgUsers> lstOrgUsers, out List<Physician> lstPhySpeciality)
        {
            long returnCode = -1;
            lstLogin = new List<Login>();
            lstRole = new List<Role>();
            lstOrgUsers = new List<OrgUsers>();
            lstPhySpeciality = new List<Physician>();
            IDataReader dataReader = null;
            int rsCount = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetUserDetailtoManageCommand(pLogID, pRName, pAddID, pOrgId,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstRole);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstOrgUsers);
                            }
                            else if (rsCount == 2)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstPhySpeciality);
                            }
                            else if (rsCount == 3)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstLogin);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetUserDetailtoManage", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            } 
            return returnCode;
        }

        public long UpdateUserDetails(OrgUsers e, long ModifiedBy)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pUpdateUserDetailCommand(e.LoginID, e.OrgUID, e.RoleName, int.Parse(e.TitleCode), e.Name, e.SEX, e.Email, e.DOB, e.Relegion, e.WeddingDt, e.Qualification, e.MaritalStatus, e.Add1, e.Add2, e.Add3, e.City, Convert.ToInt16(e.CountryID), Convert.ToInt16(e.StateID), e.PostalCode, e.MobileNumber, e.LandLineNumber, ModifiedBy, e.OtherCountryName, e.OtherStateName, e.Loginstatus, e.CountryCode, e.StateCode, e.CityCode, e.AddLevel1, e.AddLevel2, e.PrinterPath, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL UpdateUserDetails", ex);
            }
            return returnCode;
        }

        public long DeleteUserDetail(long pLoginId, long pOrgUserId, string rName, long pRoleId, long ModifiedBy)
        {
            long returnCode = -1;

            try
            {
                SqlCommand cmd = Command.pDeleteUserDetailCommand(pLoginId, pOrgUserId, rName, pRoleId, ModifiedBy, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dBEngine = new DBEngine())
                {
                    returnCode = dBEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL DeleteUserDetail", ex);
            }
            return returnCode;
        }
        public long UpdateUserDetail(long pLoginId, long pOrgUserId, string rName, long pRoleId, long ModifiedBy, string PhyType)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pUpdateUserCommand(pLoginId, pOrgUserId, rName, pRoleId, ModifiedBy, PhyType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dBEngine = new DBEngine())
                {
                    returnCode = dBEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL UpdateUserDetail", ex);
            }
            return returnCode;
        }
        public long pInsertMedicalIndentMaster(int pOrgID, string pName, int pCreatedBy, int pMedicalIdentID)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pInsertMedicalIndentMasterCommand(pOrgID, pName, pCreatedBy, pMedicalIdentID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dBEngine = new DBEngine())
                {
                    returnCode = dBEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL UpdateMedicalIndent", ex);
            }
            return returnCode;
        }
        public long pDeleteMedicalIndent(int pOrgID, int pID)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pDeleteMedicalIndentCommand(pOrgID, pID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dBEngine = new DBEngine())
                {
                    returnCode = dBEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL DeleteMedicalIndent", ex);
            }
            return returnCode;
        }


        //public long GetUserNames(string pNames, int pOrgId, out List<OrgUsers> lstOrgUsers)
        //{
        //    long returnCode = -1;
        //    lstOrgUsers = new List<OrgUsers>();
        //    try
        //    {
        //        SqlCommand cmd = Command.pGetUserNamesCommand(pNames, pOrgId,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
        //        DataSet ds = new DataSet();
        //        using (DBEngine dbEngine = new DBEngine())
        //        {
        //            dbEngine.ExecuteDataSet(cmd, out ds);
        //        }
        //        if (ds.Tables[0].Rows.Count > 0)
        //        {
        //            returnCode = Utilities.ConvertTo(ds.Tables[0], out lstOrgUsers);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error in DAL GetUserNames", ex);
        //    }
        //    return returnCode;
        //}
        public long GetUserNames(string pNames, int pOrgId, string pCategory, string pStatus, out List<OrgUsers> lstOrgUsers)
        {
            long returnCode = -1;
            lstOrgUsers = new List<OrgUsers>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetUserNamesLisCommand(pNames, pOrgId, pCategory, pStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstOrgUsers);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetUserNames", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            } 
            return returnCode;
        }

        public long CountifUserDataExists(long pLogId, long pRoleID, string pRoleName, out int pCount, out int pCountRole)
        {
            pCount = -1;
            pCountRole = -1;
            long returnCode = -1;
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pCountifUserDataExistsCommand(pLogId, pRoleID, pRoleName, out pCount, out pCountRole, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        dataReader.Close();
                    }
                    pCount = Convert.ToInt32(cmd.Parameters["@pCount"].Value);
                    pCountRole = Convert.ToInt32(cmd.Parameters["@pCountRole"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL CountifUserDataExists", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            } 
            return returnCode;
        }
        public long GetPhysicianSpecialityList(long pLoginID, out List<Physician> lstPhysicianSpeciality)
        {
            long returnCode = -1;

            lstPhysicianSpeciality = new List<Physician>();
            try
            {
                SqlCommand cmd = Command.pGetPhysicianListLisCommand(pLoginID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPhysicianSpeciality);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetPhysicianList", ex);
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
                SqlCommand cmd = Command.pGetPVDetailOnSecCodeCommand(pOrgID, pSecCode, out pCount, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    pCount = Convert.ToInt32(cmd.Parameters["@pCount"].Value);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatient);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetPVDetailOnSecCode", ex);
            }
            return returnCode;
        }
        public long UpdateRatesFromClientToClient(int typeID, long fromClientID, long toClientID, decimal addReduceValue, string addReduceType, long LID, int OrgID, long FromRateRefID, long FromParentID, long ToRateRefID, long ToParentID, String IsAction, string Rate, int FromOrgID)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pUpdateRatesFromClientToClientCommand(typeID, fromClientID, toClientID, addReduceValue, addReduceType, LID, OrgID, FromRateRefID, FromParentID, ToRateRefID, ToParentID,UDT_DAL.ConvertToUDT_Context(globalContextDetails), FromOrgID, IsAction, Rate);
                cmd.Parameters.Add("@Return", SqlDbType.Int);
                cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
                using (DBEngine dBEngine = new DBEngine())
                {
                    dBEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateRatesFromClientToClient in AdminReports_DAL.", ex);
            }
            return returnCode;
        }
        public long GetPhysicianWiseCollectionSummary(long OrgID, long PhysicianID, DateTime dFromDate, DateTime dToDate, string isCreditBill, out List<CashFlowSummary> lstCashFlowSummary, out List<CashFlowSummary> lstCashFlowSummarySubTotal)
        {
            long returnCode = -1;
            lstCashFlowSummary = new List<CashFlowSummary>();
            lstCashFlowSummarySubTotal = new List<CashFlowSummary>();
            try
            {
                SqlCommand cmd = Command.pGetPhysicianWiseCollectionSummaryCommand(PhysicianID, dFromDate, dToDate, OrgID, isCreditBill, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstCashFlowSummary);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstCashFlowSummarySubTotal);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPhysicianWiseCollectionSummary in AdminReports_DAL.", ex);
            }
            return returnCode;
        }

        public long GetPhysicianWiseCollectionDetail(long OrgID, long PhysicianID, DateTime dFromDate, DateTime dToDate, string type, string feeType, string isCreditBill, out List<CashFlowSummary> lstCashFlowSummary)
        {
            long returnCode = -1;
            lstCashFlowSummary = new List<CashFlowSummary>();
            try
            {
                SqlCommand cmd = Command.pGetPhysicianWiseCollectionDetailCommand(PhysicianID, dFromDate, dToDate, OrgID, type, feeType, isCreditBill, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstCashFlowSummary);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPhysicianWiseCollectionDetail in AdminReports_DAL.", ex);
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
            DataSet ds = new DataSet();
            cashBillList = new List<DailyReport>();
            creditBillList = new List<DailyReport>();
            dueReceivedBillList = new List<DailyReport>();
            cancelledBillList = new List<DailyReport>();
            try
            {
                SqlCommand cmd = Command.pSearchDailyBillCommand(fromDate, toDate, loginID, orgID, out cashAmount, out creditAmount, out dueReceivedAmount, out pendingDueAmount, out discountAmount, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine db = new DBEngine())
                {
                    db.ExecuteDataSet(cmd, out ds);
                    cashAmount = Convert.ToDecimal(cmd.Parameters["@cashAmount"].Value);
                    creditAmount = Convert.ToDecimal(cmd.Parameters["@creditAmount"].Value);
                    dueReceivedAmount = Convert.ToDecimal(cmd.Parameters["@dueReceivedAmount"].Value);
                    pendingDueAmount = Convert.ToDecimal(cmd.Parameters["@pendingDueAmount"].Value);
                    discountAmount = Convert.ToDecimal(cmd.Parameters["@discountAmount"].Value);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out cashBillList);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[1], out creditBillList);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[2], out dueReceivedBillList);
                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[3], out cancelledBillList);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetDailyReports in AdminReports_DAL", ex);
            }

            return returnCode;

        }
        public long SearchDueBills(DateTime strBillFromDate, DateTime strBillToDate, int OrgID, string pType, out List<DailyReport> dueSearch)
        {
            long returnCode = -1;

            System.Data.SqlClient.SqlCommand cmd;
            cmd = Command.pSearchDueBillsCommand(strBillFromDate, strBillToDate, OrgID, pType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            dueSearch = new List<DailyReport>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }


            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out dueSearch);
            }

            return returnCode;
        }
        public long GetSamplesReport(int hospitalID, int physicianID, DateTime fromDate, DateTime toDate, int OrgID, out List<PatientVisit> lstSamplesReport)
        {
            long returnCode = -1;
            lstSamplesReport = new List<PatientVisit>();
            SqlCommand cmd = Command.pSearchSampleListCommand(hospitalID, physicianID, fromDate, toDate, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd,
                out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                Utilities.ConvertTo(ds.Tables[0], out lstSamplesReport);
            }
            return returnCode;
        }
        public long GetPhysicianWiseWardVisit(DateTime dFromDate, DateTime dToDate, long PhysicianID, int orgAddressID, out List<Patient> lstPatient)
        {
            long returnCode = -1;
            lstPatient = new List<Patient>();
            try
            {
                SqlCommand cmd = Command.pGetConsultantWiseWardVisitCommand(dFromDate, dToDate, PhysicianID, orgAddressID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
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
                CLogger.LogError("Error while executing GetPhysicianWiseWardVisit in AdminReports_DAL.", ex);
            }
            return returnCode;
        }
        public long GetIPBilledVsActuals(int OrgID, DateTime dFromDate, DateTime dToDate, string serviceType, out List<FinalBill> lstFinalBill)
        {
            long returnCode = -1;
            lstFinalBill = new List<FinalBill>();
            try
            {
                SqlCommand cmd = Command.pGetIPBilledVsActualsCommand(OrgID, dFromDate, dToDate, serviceType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstFinalBill);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetIPBilledVsActuals in AdminReports_DAL.", ex);
            }
            return returnCode;
        }
        public long pGetRateTypeMaster(int pOrgID, string OrgType, out List<RateMaster> lstInvRate)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pGetRateTypeMasterCommand(pOrgID, OrgType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstInvRate = new List<RateMaster>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvRate);
            }
            return returnCode;
        }


        public long pGetRateMaster(int pOrgID, out List<RateTypeMaster> lstInvRate)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pGetRateTypeCommand(pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstInvRate = new List<RateTypeMaster>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvRate);
            }
            return returnCode;
        }


        public long pInsertRateType(int pOrgID, string pName, long pModifiedBy, long PolicyID, string VendorType, string VendorSubType, string Comments, out long returnCode)
        {
            returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pInsertRateTypeMasterCommand(pOrgID, pName, pModifiedBy, PolicyID, VendorType, VendorSubType, Comments, out returnCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dBEngine = new DBEngine())
                {
                    returnCode = dBEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL UpdateMedicalIndent", ex);
            }
            return returnCode;
        }



        public long pDeleteRateType(int pOrgID, string pName, int pID)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pDeleteRateTypeMasterCommand(pOrgID, pName, pID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dBEngine = new DBEngine())
                {
                    returnCode = dBEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL DeleteMedicalIndent", ex);
            }
            return returnCode;
        }

        public long UpdateRateType(int pOrgID, string pName, int pID, long pModifiedBy, long PolicyID, string VendorType, string VendorSubType, string Comments)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pUpdateRateTypeMasterCommand(pOrgID, pName, pID, pModifiedBy, PolicyID, VendorType, VendorSubType, Comments, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dBEngine = new DBEngine())
                {
                    returnCode = dBEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL UpdateUserDetail", ex);
            }
            return returnCode;
        }


        public long GetMedicalIndentMaster(int pOrgID, out List<MedicalIndentMaster> Mdi)
        {
            long returnCode = -1;
            Mdi = new List<MedicalIndentMaster>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetMedicalIndentMasterCommand(pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                Mdi = new List<MedicalIndentMaster>();

                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out Mdi);

                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetGeneralBillingItemsRateDetails", ex);
            }
            return returnCode;
        }
        public long pGetClaimAmountLogic(int pOrgID, out List<ClaimAmountLogic> lstClaim)
        {
            long returnCode = -1;
			IDataReader dataReader = null;
            lstClaim = new List<ClaimAmountLogic>();
            
            try
            {
            SqlCommand cmd = Command.pGetClaimAmountLogicCommand(pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

               
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstClaim);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in AdminReports_DAL pGetClaimAmountLogic", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returnCode;
        }
        public long GetPhysicianReports(DateTime dFromDate, DateTime dToDate, long OrgID, string PhysicianID, out List<DayWiseCollectionReport> lstphySummary)
        {
            long returnCode = -1;
            lstphySummary = new List<DayWiseCollectionReport>();

            try
            {
                SqlCommand cmd = Command.pGetPhysicianReportReviewCommand(dFromDate, dToDate, OrgID, PhysicianID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstphySummary);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPhysicianWiseCollectionSummary in AdminReports_DAL.", ex);
            }
            return returnCode;
        }
        public long InsertVisitStateChanged(string BillNumber, int OrgID, long ApprovedBy, string Reason, long CreatedBy, string isDayCare)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pInsertVisitStateChangedCommand(BillNumber, OrgID, ApprovedBy, Reason, CreatedBy, isDayCare, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dBEngine = new DBEngine())
                {
                    returnCode = dBEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in AdminReports_DAL InsertVisitStateChanged", ex);
            }
            return returnCode;
        }
        // changed dataset to datareader by Arivalagan.k
        public long GetUserNameWithLoginID(string pNames, int pOrgId, string pAuthTypeName,out List<OrgUsers> lstOrgUsers)
        {
            long returnCode = -1;
            IDataReader dataReader = null;
            lstOrgUsers = new List<OrgUsers>();
            try
            {
                SqlCommand cmd = Command.pGetUserNameWithLoginIDLisCommand(pNames, pOrgId, pAuthTypeName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstOrgUsers);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in AdminReport_DAL GetUserNameWithLoginID", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            } 
            return returnCode;
        }
        public long GetBillNoDetails(string BillNumber, int OrgID, out List<Patient> lstPatientBillDetails)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pGetBillNoDetailsCommand(BillNumber, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstPatientBillDetails = new List<Patient>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientBillDetails);
            }
            return returnCode;
        }
        public long pGetOrgLoction(out List<Organization> lstOrg)
        {
            long returnCode = -1;
            lstOrg = new List<Organization>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetOrganizationCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstOrg);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetOrgLoction in AdminReports_DAL.", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returnCode;
        }
        // changed dataset to datareader by Arivalagan.k
        public long pGetOrganizationLocation(long OrgID, long addid, int chid, out List<OrganizationAddress> lstOrgLocation)
        {
            long returnCode = -1;
            lstOrgLocation = new List<OrganizationAddress>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetOrglocationCommand(Convert.ToInt32(OrgID), addid, chid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstOrgLocation);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPhysicianWiseCollectionSummary in AdminReports_DAL.", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            } 
            return returnCode;
        }
        public long GetOrganizationLocationClient(long OrgID, out List<ClientMaster> lstOrgLocationClient)
        {
            long returnCode = -1;
            lstOrgLocationClient = new List<ClientMaster>();

            try
            {
                SqlCommand cmd = Command.pGetOrganizationLocationClientCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstOrgLocationClient);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetOrganizationLocationClient in AdminReports_DAL.", ex);
            }
            return returnCode;
        }
        public long GetMappedAndDefaultClient(long OrgID, long OrgAddID, out List<ClientMaster> lstdefLocationClient)
        {
            long returnCode = -1;
            lstdefLocationClient = new List<ClientMaster>();

            try
            {
                SqlCommand cmd = Command.pGetMappedAndDefaultClientCommand(OrgID, OrgAddID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstdefLocationClient);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetMappedAndDefaultClient in AdminReports_DAL.", ex);
            }
            return returnCode;
        }
        public long IDUOrgLocation(long OrgID, UserAddress useAddress, string location, string type, long id, string LocationCode, string CenterTypeCode, string isdefault, string ismappedclients, string status, string DefaultClientID,byte[] Logo, List<InvClientMaster> lstClient, List<InvClientMaster> lstRemoveClient,int IsScanInScanOut, out List<OrganizationAddress> lstOrgLocation)
        {
            long returnCode = -1;
            lstOrgLocation = new List<OrganizationAddress>();

            try
            {
                DataTable DtlstClient = UDT_DAL.ConvertToInvClientMaster(lstClient);
                DataTable DtlstRemoveClient = UDT_DAL.ConvertToInvClientMaster(lstRemoveClient);
                SqlCommand cmd = Command.pIDUOrgLocationCommand(OrgID, useAddress.Add2, useAddress.Add1, useAddress.Add3, useAddress.PostalCode, useAddress.CountryID, useAddress.City,
                                                        useAddress.StateID, useAddress.MobileNumber, useAddress.LandLineNumber, useAddress.OtherCountryName, useAddress.OtherStateName, location, type, id, LocationCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails),
                                                        CenterTypeCode, isdefault, ismappedclients, status, DefaultClientID, DtlstClient, DtlstRemoveClient, useAddress.CutOffTimeValue, useAddress.CutOffTimeType, Logo, IsScanInScanOut);

                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmd);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing IDUOrgLocation in AdminReports_DAL.", ex);
            }
            return returnCode;
        }



        public long SaveMappedItems(List<AdminInvestigationRate> lstMappedRates, int iValue, long ClientId, long TPAId, long RateId, long LID, int OrgID)
        {
            long returnCode = -1;
            AdminReports_DAL arDAL = new AdminReports_DAL();
            SqlCommand cmd = new SqlCommand();
            DataTable DtInvRate = UDT_DAL.ConvertToInvestigationAdminRate(lstMappedRates);
            cmd = Command.pSaveMappedItemsCommand(DtInvRate, iValue, ClientId, TPAId, RateId, out returnCode, LID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dBEngine = new DBEngine(false))
            {
                dBEngine.ExecuteNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@returnStatus"].Value);
            }
            return returnCode;
        }

        public long GetSpkgContentRate(long PackageID, int OrgID, long ClientID, out List<SurgeryPackageFeeTypeRateMaster> lSurgeryPkgMaster)
        {
            long returnCode = -1;
            lSurgeryPkgMaster = new List<SurgeryPackageFeeTypeRateMaster>();
            try
            {

                SqlCommand cmd = Command.pGetSurgeryPkgContentRateCommand(PackageID, OrgID, ClientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lSurgeryPkgMaster);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSpkgContentRate in AdminReports_DAL.", ex);
            }
            return returnCode;

        }

        public long SaveSurgerypacakageContentRate(List<SurgeryPackageFeeTypeRateMaster> lstRatesspkg)
        {
            long returnCode = -1;
            try
            {
                DataTable DtRatesspkg = UDT_DAL.ConvertToUDTSurgeryPackageFeeTypeRateMaster(lstRatesspkg);
                SqlCommand cmd = Command.pSaveSurgerypacakageContentRateCommand(DtRatesspkg, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dBEngine = new DBEngine())
                {
                    returnCode = dBEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in AdminReports_DAL SaveSurgerypacakageContentRate", ex);
            }
            return returnCode;
        }
        // changed dataset to datareader by Arivalagan.k
        public long GetRateOrgMapping(int OrgID, int pageSize, string RateCardName, int StartRowIndex, out int totalRows, out List<RateRefOrgMapping> lstRateRefOrgMapping)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            totalRows = 0;
            lstRateRefOrgMapping = new List<RateRefOrgMapping>();
            try
            {
                SqlCommand cmd = Command.pGetRateOrgMappingCommand(OrgID, pageSize, RateCardName, StartRowIndex, out
				totalRows, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstRateRefOrgMapping);
                        dataReader.Close();
                    }
                }
                Int32.TryParse(cmd.Parameters["@totalRows"].Value.ToString(), out totalRows);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in AdminReports_DAL while execute GetRateOrgMapping().", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returnCode;
        }
        public long SaveRateOrgMap(string RateName, int RateID, int TrustedOrgID, int LoggedinOrgID, long PolicyID, string QueryType, long CreatedBy)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pSaveRateOrgMappingCommand(RateName, RateID, TrustedOrgID, LoggedinOrgID, PolicyID, QueryType, CreatedBy, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dBEngine = new DBEngine())
                {
                    returnCode = dBEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in AdminReports_DAL while execute SaveRateOrgMap().", ex);
            }
            return returnCode;
        }
        // changed dataset to datareader by Arivalagan.k
        public long GetSharingOrganizations(int orgID, out List<Organization> lstorgn)
        {
            long returnCode = -1;
            IDataReader dataReader = null;
            lstorgn = new List<Organization>();
            try
            {
                SqlCommand objCommand = Command.pGetSharingOrganizationsCommand(orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                     dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstorgn);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetSharingOrganizations in AdminReports_DAL", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            } 
            return returnCode;
        }
        //Changes of DataSet To DataReader Made By Arivalagan.k
        public long pGetRateTypeMasters(int pOrgID, out List<PageContextkey> lstInvRate)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstInvRate = new List<PageContextkey>();
            try
            {
                SqlCommand cmd = Command.pGetRateTypeMastersCommand(pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvRate);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading pGetRateTypeMasters in AdminReportDal", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returnCode;
        }
        public long GetSampleContainer(int pOrgID, out  List<InvSampleMaster> lstInvSampleMaster, out List<InvestigationSampleContainer> lstInvSampleContainer)
        {
            long returnCode = -1;
            lstInvSampleMaster = new List<InvSampleMaster>();
            lstInvSampleContainer = new List<InvestigationSampleContainer>();
            IDataReader dataReader = null;
            try
            {
            SqlCommand cmd = Command.pGetSampleContainerCommand(pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(false))
            {
                    int rsCount = 0;
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInvSampleMaster);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstInvSampleContainer);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetSampleContainer in AdminReport_DAL", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returnCode;
        }
        public long SaveSampleContainer(int OrgID, string SampleName, string SampleCode, string SampleDesc, long SampleID, string SampleType, string Status)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pSaveSampleContainerCommand(OrgID, SampleName, SampleCode, SampleDesc, SampleID, SampleType, Status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@ret", SqlDbType.Int);
            cmd.Parameters["@ret"].Direction = ParameterDirection.ReturnValue;
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@ret"].Value);
            }
            return returnCode;
        }
          public long SaveAnalyzerDetails(int OrgID, int LocationID, List<InvInstrumentMaster> lstInvInstrumentMaster, out long InstrumentID)
        {
            long returnCode = -1;
            InstrumentID = 0;
            DataTable DtInvInstrumentMaster = UDT_DAL.ConvertToInvInstrumentMaster(lstInvInstrumentMaster);

            SqlCommand cmd = new SqlCommand();
            cmd = Command.pInsertAnalyzerDetailsCommand(OrgID, LocationID, DtInvInstrumentMaster, out InstrumentID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                InstrumentID = Convert.ToInt64(cmd.Parameters["@InstrumentID"].Value);
            }
            return returnCode;
        }
        public long GetTrustedOrganizationAddress(int orgid, out List<Organization> lstorg)
        {
            long returnCode = -1;
            lstorg = new List<Organization>();
            SqlCommand cmd = Command.pGetTrustedOrganizationAddressCommand(orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstorg);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL AdminReports_DAL GetTrustedOrganizationAddress", ex);
            }
            return returnCode;

        }

        //Change Dataset to DataReader by Arivalagan.k
        public long GetUserNameWithID(string pNames, int pOrgId, out List<OrgUsers> lstOrgUsers)
        {
            long returnCode = -1;
            lstOrgUsers = new List<OrgUsers>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetUserNamewithIDCommand(pNames, pOrgId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstOrgUsers);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in AdminReport_DAL GetUserNameWithID", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returnCode;
        }
        // changed dataset to datareader by Arivalagan.k
        public long GetRateTypeMasterNew(int pOrgID, string OrgType, string RateNAme, int pageSize, int StartRowIndex, out int totalRows, out List<RateMaster> lstInvRate)
        {
            lstInvRate = new List<RateMaster>();
            IDataReader dataReader = null;
            long returnCode = -1;
            totalRows = 0;
            try
            {
                SqlCommand cmd = Command.pGetRateTypeMastersNewCommand(pOrgID, OrgType, RateNAme, pageSize, StartRowIndex, out totalRows, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvRate);
                        dataReader.Close();
                    }
                }
                Int32.TryParse(cmd.Parameters["@totalRows"].Value.ToString(), out totalRows);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetRateTypeMasterNew in AdminReportDAL", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returnCode;
        }
        public long SaveratesDetails(DataTable dtpratetest, long pRateID)
        {

            long returnCode = -1;

            try
            {

                SqlCommand cmd = Command.pUpdateRateMasterCommand(dtpratetest, pRateID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL DiscountMaster", ex);
            }
            return returnCode;
        }
        #region ManageRates IsMapped Added
        public long RemoveInvestigationRate(List<AdminInvestigationRate> lstAdminRate,
          List<FeeSplitSeriveDetails> lstSplitDetails,
          int dlValue, int dClientId, int OrgID)
        {
            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
            DataTable dtAdminRate = UDT_DAL.ConvertToInvestigationAdminRate(lstAdminRate);
            DataTable DtSplitRate = UDT_DAL.ConvertToFeeSplitSeriveDetails(lstSplitDetails);
            cmd = Command.pRemoveAllInvRateCommand(dtAdminRate, DtSplitRate, dlValue, dClientId, out returnCode, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dBEngine = new DBEngine(false))
            {
                dBEngine.ExecuteNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@returnStatus"].Value);
            }
            return returnCode;
        }
        #endregion
        #region Newinstance creation
        public long pgetmyloc(int insid, out List<NewInstanceWaitingCustomers> lstloc)
        {
            long returncode = -1;
            lstloc = new List<NewInstanceWaitingCustomers>();
            try
            {
                SqlCommand cmd = Command.pGetMyLocCommand(insid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstloc);
                }
            }

            catch (Exception ex)
            {
                CLogger.LogError("Error while executing loc", ex);
            }
            return returncode;
        }
        #endregion

        public long SearchDoctorPayout(int PhysicianID, DateTime strBillFromDate, DateTime strBillToDate, byte Mode, List<DoctorPayoutDetails> lstFinalbillid, List<DoctorPayoutDetails> lstDocPayout, out List<DoctorPayoutDetails> lstDoctorpayout)
        {
            long returnCode = -1;

            System.Data.SqlClient.SqlCommand cmd;
            DataTable DtDocPayout = UDT_DAL.ConvertToUDTDocPayout(lstDocPayout);
            DataTable DtFinalbillid = UDT_DAL.ConvertToUDTFinalbillid(lstFinalbillid);
            cmd = Command.pGenerateDocpayoutCommand(PhysicianID, strBillFromDate, strBillToDate, Mode, DtFinalbillid, DtDocPayout, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstDoctorpayout = new List<DoctorPayoutDetails>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }


            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDoctorpayout);
            }

            return returnCode;
        }
        
        public long GetHolidayMaster(int pOrgID, out List<Holidaymaster> lstHolidaymaster)
        {
            long lresult = -1;
            lstHolidaymaster = new List<Holidaymaster>();
            IDataReader dataReader = null;
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.pGetholidaymasterCommand(pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        lresult = Utilities.ConvertTo(dataReader, out lstHolidaymaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetHolidayMaster AdminReports_DAL" + cmd.CommandText, ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return lresult;
        }
        public long GetScheduleDay(int OrgID, out List<CodingScheme> lstScheduleday)
        {
            long lresult = -1;
            lstScheduleday = new List<CodingScheme>();
            IDataReader dataReader = null;
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.pGetscheduledayCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        lresult = Utilities.ConvertTo(dataReader, out lstScheduleday);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetScheduleDay AdminReports_DAL" + cmd.CommandText, ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return lresult;
        }
        public long SaveManageSchedule(List<TATSchedule> lstTATSchedule, List<Holidaymaster> lstHolidaymaster, out string strOutMessage)
        {
            strOutMessage = string.Empty;
            long lstresult = -1;
            IDataReader dataReader = null;
            DataTable SaveTAT = UDT_DAL.ConvertToUDTTATRANDOMBATCHSCHEDULE(lstTATSchedule);
            DataTable SaveHoliday = UDT_DAL.ConvertToUDTHolidayMaster(lstHolidaymaster);
            try
            {
                SqlCommand cmd = Command.pSavemanagescheduleCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails), SaveTAT, SaveHoliday, out strOutMessage);
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    strOutMessage = Convert.ToString(cmd.Parameters["@outMessage"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL SaveManageSchedule", ex);
            }
            return lstresult;
        }
        public long GetManageSchedule(int pagesize, int pageindex, string search, out List<TATSchedule> lstTATSchedule, out List<SlotValue> lstSlotValue, out List<Holidaymaster> lstHolidaymaster)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstTATSchedule = new List<TATSchedule>();
            lstSlotValue = new List<SlotValue>();
            lstHolidaymaster = new List<Holidaymaster>();
            int rsCount = 0;
            try
            {
                SqlCommand cmd = Command.pGetmanagescheduleCommand(pagesize, pageindex, search, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstTATSchedule);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstSlotValue);
                            }
                            else if (rsCount == 2)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstHolidaymaster);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetManageSchedule in AdminReport_DAL", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returnCode;
        }
        public long EditManageSchedule(int Scheduleid, out List<TATSchedule> lstTATSchedule, out  List<SlotValue> lstSlotValue, out List<Holidaymaster> lstHolidaymaster)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstTATSchedule = new List<TATSchedule>();
            lstSlotValue = new List<SlotValue>();
            lstHolidaymaster = new List<Holidaymaster>();
            int rsCount = 0;
            try
            {
                SqlCommand cmd = Command.pEditmanagescheduleCommand(Scheduleid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstTATSchedule);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstSlotValue);
                            }
                            else if (rsCount == 2)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstHolidaymaster);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading EditManageSchedule in AdminReport_DAL", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returnCode;
        }
    }

}
