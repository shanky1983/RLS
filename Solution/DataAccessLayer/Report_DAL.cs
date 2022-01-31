using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.SqlClient;
using System.Collections.Generic;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities;
using Attune.Podium.Common;
using Attune.Podium.BusinessEntities.CustomEntities;
using System.IO;


namespace Attune.Solution.DAL
{
    public class Report_DAL
    {
        ContextDetails globalContextDetails;
        public Report_DAL()
        {

        }
        public Report_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        // changed dataset to datareader by Arivalagan.k
        public long GetReportItems(long roleID, long orgID, out List<GetReportDetails> lstGroupItems, out List<GetReportDetails> lstReportItems)
        {
            long returnCode = -1;
            int rsCount = 0;
            SqlCommand cmd = new SqlCommand();
            lstGroupItems = new List<GetReportDetails>();
            lstReportItems = new List<GetReportDetails>();
            IDataReader dataReader = null;
            try
            {
                cmd = Command.pGetListOfReportsForOrganisationCommand(orgID, roleID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstGroupItems);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstReportItems);
                            }

                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetReportItems Report_DAL", e);
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


        public long GetReportPath(long ReportID, out List<ReportMaster> ReportName)
        {
            long returnCode = -1;

            SqlCommand cmd = new SqlCommand();
            cmd = Command.pGetReportPathCommand(ReportID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            ReportName = new List<ReportMaster>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out ReportName);
            }
            return returnCode;
        }
        public long GetCommunicableDiseasesICD(int OrgID, out List<CommunicableDiseaseMaster> CDS)
        {
            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pGetCommunicableDiseasesCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            CDS = new List<CommunicableDiseaseMaster>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out CDS);
            }
            return returnCode;
        }
        public long GetCommunicableDiseasesReport(int OrgID, DateTime fromdate, DateTime todate, string ICDCode, out List<PatientVisit> patientVisit)
        {
            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pGetCommunicableDiseasesReportCommand(OrgID, fromdate, todate, ICDCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            patientVisit = new List<PatientVisit>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out patientVisit);

            }
            return returnCode;

        }
        // changed dataset to datareader by Arivalagan.k
        public long GetUserwiseAuthorisedBy(long orgID, out List<Users> Users, out List<OrgUsers> OrgUsers)
        {
            long returnCode = -1;
            int rsCount = 0;
            Users = new List<Users>();
            OrgUsers = new List<OrgUsers>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetUserwiseAuthorisedByCommand(orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out Users);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out OrgUsers);
                            }

                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Userwise and Authorized by details using pGetUserwiseAuthorisedBy sp", ex);
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
        public long GetInvestigationCollectionReport(List<OrderedInvestigations> OrderedInves, DateTime strBillFromDate, DateTime strBillToDate, int OrgID, string Type, out List<BillLineItems> resultItems)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            DataTable dtObj = UDT_DAL.ConvertToOrderedInvestigation(OrderedInves);
            SqlCommand cmd = new SqlCommand();
            resultItems = new List<BillLineItems>();
            try
            {
                cmd = Command.pGetInvestigationCollectionReportCommand(strBillFromDate, strBillToDate, OrgID, Type, dtObj, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out resultItems);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetInvestigationCollectionReport Report_DAL", e);
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
        public long GetScheduleDrugsReport(DateTime pFromDate, DateTime pToDate, int pOrgID, int OrgAddressID, out List<BillingDetails> lBillingDetails)
        {
            long returnCode = -1;
            lBillingDetails = new List<BillingDetails>();
            SqlCommand cmd = Command.pGetScheduleDrugsCommand(pFromDate, pToDate, pOrgID, OrgAddressID,0, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lBillingDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetStockReport in Report_DAL", ex);
            }
            return returnCode;
        }
        // Add Try,Catch,Finally by Arivalagan.k
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
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetCollectionReportOPIPCommand(pFromDate, pToDate, pOrgID, pLID, pVisitType, CurrencyID, out pTotalBillAmt, out pTotalPreDueReceived, out pTotalDiscount, out pTotalNetValue, out pTotalReceivedAmt, out pTotalDue, out pTax, out pServiceCharge, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstDayWiseReport);
                        dataReader.Close();
                        Decimal.TryParse(cmd.Parameters["@pTotalBillAmt"].Value.ToString(), out pTotalBillAmt);
                        Decimal.TryParse(cmd.Parameters["@pTotalPreDueReceived"].Value.ToString(), out pTotalPreDueReceived);
                        Decimal.TryParse(cmd.Parameters["@pTotalDiscount"].Value.ToString(), out pTotalDiscount);
                        Decimal.TryParse(cmd.Parameters["@pTotalNetValue"].Value.ToString(), out pTotalNetValue);
                        Decimal.TryParse(cmd.Parameters["@pTotalReceivedAmt"].Value.ToString(), out pTotalReceivedAmt);
                        Decimal.TryParse(cmd.Parameters["@pTotalDue"].Value.ToString(), out pTotalDue);
                        Decimal.TryParse(cmd.Parameters["@pTaxAmount"].Value.ToString(), out pTax);
                        Decimal.TryParse(cmd.Parameters["@pServiceCharge"].Value.ToString(), out pServiceCharge);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetCollectionReportOPIP", ex);
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
                SqlCommand cmd = Command.pGetBillWiseReportOPIPCommand(pFromDate, pToDate, pOrgID, pLID, pVisitType, CurrencyID, out pTotalBillAmt, out pTotalPreDueReceived, out pTotalDiscount, out pTotalNetValue, out pTotalReceivedAmt, out pTotalDue, out pTax, out pServiceCharge, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    Decimal.TryParse(cmd.Parameters["@pTotalBillAmt"].Value.ToString(), out pTotalBillAmt);
                    Decimal.TryParse(cmd.Parameters["@pTotalPreDueReceived"].Value.ToString(), out pTotalPreDueReceived);
                    Decimal.TryParse(cmd.Parameters["@pTotalDiscount"].Value.ToString(), out pTotalDiscount);
                    Decimal.TryParse(cmd.Parameters["@pTotalNetValue"].Value.ToString(), out pTotalNetValue);
                    Decimal.TryParse(cmd.Parameters["@pTotalReceivedAmt"].Value.ToString(), out pTotalReceivedAmt);
                    Decimal.TryParse(cmd.Parameters["@pTotalDue"].Value.ToString(), out pTotalDue);
                    Decimal.TryParse(cmd.Parameters["@pTaxAmount"].Value.ToString(), out pTax);
                    Decimal.TryParse(cmd.Parameters["@pServiceCharge"].Value.ToString(), out pServiceCharge);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDayWiseReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetCollectionReportOPIP", ex);
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
                SqlCommand cmd = Command.pGetRoomCollectionReportCommand(pOrgID, pFromDate, pToDate, out pTotal, pOrgAddId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    pTotal = Convert.ToDecimal(cmd.Parameters["@pTotal"].Value);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDayWiseReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetRoomCollectionReportIP", ex);
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
                SqlCommand cmd = Command.pGetCollectionReportDeptWiseCommand(pFromDate, pToDate, pOrgID, pLID, pVisitType, out pTotalBillAmt, out pTotalPreDueReceived, out pTotalDiscount, out pTotalNetValue, out pTotalReceivedAmt, out pTotalDue, out pTax, out pServiceCharge, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    Decimal.TryParse(cmd.Parameters["@pTotalBillAmt"].Value.ToString(), out pTotalBillAmt);
                    Decimal.TryParse(cmd.Parameters["@pTotalPreDueReceived"].Value.ToString(), out pTotalPreDueReceived);
                    Decimal.TryParse(cmd.Parameters["@pTotalDiscount"].Value.ToString(), out pTotalDiscount);
                    Decimal.TryParse(cmd.Parameters["@pTotalNetValue"].Value.ToString(), out pTotalNetValue);
                    Decimal.TryParse(cmd.Parameters["@pTotalReceivedAmt"].Value.ToString(), out pTotalReceivedAmt);
                    Decimal.TryParse(cmd.Parameters["@pTotalDue"].Value.ToString(), out pTotalDue);
                    Decimal.TryParse(cmd.Parameters["@pTaxAmount"].Value.ToString(), out pTax);
                    Decimal.TryParse(cmd.Parameters["@pServiceCharge"].Value.ToString(), out pServiceCharge);

                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDeptWiseReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetCollectionReportDeptWise", ex);
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
                SqlCommand cmd = Command.pGetCollectionRptDptWiseOPIPCommand(pFromDate, pToDate, pOrgID, pLID, pVisitType, out pTotalItemAmt, out pTotalDiscount, out pTotalReceivedAmt, out pTotalDue, out pTax, out pServiceCharge, reportType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    Decimal.TryParse(cmd.Parameters["@pTotalItemAmt"].Value.ToString(), out pTotalItemAmt);
                    Decimal.TryParse(cmd.Parameters["@pTotalDiscount"].Value.ToString(), out pTotalDiscount);
                    Decimal.TryParse(cmd.Parameters["@pTotalReceivedAmt"].Value.ToString(), out pTotalReceivedAmt);
                    Decimal.TryParse(cmd.Parameters["@pTotalDue"].Value.ToString(), out pTotalDue);
                    Decimal.TryParse(cmd.Parameters["@pServiceCharge"].Value.ToString(), out pServiceCharge);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDeptWiseReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetCollectionRptDptWiseOPIP", ex);
            }
            return returnCode;
        }
        public long GetDepartmentWiseDetailReportPopUp(DateTime pFromDate, DateTime pToDate, int pOrgID, int pVisitType, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                SqlCommand cmd = Command.pGetDepartmentWiseDetailReportPopUpCommand(pFromDate, pToDate, pOrgID, pVisitType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDeptWiseReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetDepartmentWiseDetailReportPopUp", ex);
            }
            return returnCode;
        }
        public long GetCollectionRptIndDeptOPIP(DateTime pFDate, DateTime pTDate, int pOrgID, int pVisitType, string feeType, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                SqlCommand cmd = Command.pGetCollectionRptIndDeptOPIPCommand(pFDate, pTDate, pOrgID, pVisitType, feeType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDeptWiseReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetCollectionRptIndDeptOPIP", ex);
            }
            return returnCode;
        }

        // changed dataset to datareader by Arivalagan.k
        public long GetCreditCardStmt(DateTime pFromDate, DateTime pToDate, int pOrgID, int pVisitType, int pLocation, int pReportType, string Receivedby, string PatientName, out List<DayWiseCollectionReport> lstDeptWiseReport, out decimal pTotalCardAmt, out decimal pTotalServiceCharge, int PaymentTypeID)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            pTotalCardAmt = -1;
            pTotalServiceCharge = -1;
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetCreditCardStmtCommand(pFromDate, pToDate, pOrgID, pVisitType, pLocation, pReportType, Receivedby, PatientName, out pTotalCardAmt, out pTotalServiceCharge, PaymentTypeID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstDeptWiseReport);
                        dataReader.Close();
                    }
                    Decimal.TryParse(cmd.Parameters["@pTotalCardAmt"].Value.ToString(), out pTotalCardAmt);
                    Decimal.TryParse(cmd.Parameters["@pTotalServiceChrg"].Value.ToString(), out pTotalServiceCharge);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetCreditCardStmt", ex);
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

        public long GetDueandDiscount(DateTime pFromDate, DateTime pToDate, int pOrgID, int pVisitType, string pRequestType, string PName, string PNo, out List<DayWiseCollectionReport> lstDeptWiseReport, out decimal pTotalDiscount)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            pTotalDiscount = -1;
            try
            {
                SqlCommand cmd = Command.pGetDueandDiscountCommand(pFromDate, pToDate, pOrgID, pVisitType, pRequestType, PName, PNo, out pTotalDiscount, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    Decimal.TryParse(cmd.Parameters["@pTotalDiscount"].Value.ToString(), out pTotalDiscount);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDeptWiseReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetDueandDiscount", ex);
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
                DataTable dtSpecialityIDs = UDT_DAL.ConvertToGetOrgIDs(lstSpecialityIDs);
                DataTable dtPhysicianIDs = UDT_DAL.ConvertToUDTIdsforReport(lstPhysicianIDs);
                SqlCommand cmd = Command.pGetPatientReportCommand(pFromDate, pToDate, pOrgID, pVisitType, pRequestType, pSpecialityID, phyID, dtSpecialityIDs, dtPhysicianIDs, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDeptWiseReport);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPhysician);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetPatientReport", ex);
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
                SqlCommand cmd = Command.pGetSurgeryTeamWiseReportCommand(dt, pFromDate, pToDate, pOrgID, pSurgenID, pAnesthetistID, pTreatmentName, pSearchType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstSurgeryBillingMaster);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstSurgeon);

                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstAnesthetist);
                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstTreatmentName);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetSurgeryTeamWiseReport", ex);
            }
            return returnCode;
        }

        public long GetVacantRoomReport(DateTime fDate, DateTime tDate, int pOrgID, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                SqlCommand cmd = Command.pGetVacantRoomReportCommand(fDate, tDate, pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDeptWiseReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetVacantRoomReport", ex);
            }
            return returnCode;
        }

        public long GetBirthStatisticsReport(DateTime fDate, DateTime tDate, int pOrgID, long pLoginID, int pProType, int pDeliveryType, string psex, out List<Patient> lstBirthStat)
        {
            long returnCode = -1;
            lstBirthStat = new List<Patient>();
            try
            {
                SqlCommand cmd = Command.pGetBirthStatisticsReportCommand(fDate, tDate, pOrgID, pLoginID, pProType, pDeliveryType, psex, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBirthStat);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetBirthStatisticsReport", ex);
            }
            return returnCode;
        }

        public long GetLabStatisticsReport(DateTime fDate, DateTime tDate, int pOrgID, int pVisitType, string pHeaderName, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                SqlCommand cmd = Command.pGetLabStatisticsReportCommand(fDate, tDate, pOrgID, pVisitType, pHeaderName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDeptWiseReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetLabStatisticsReport", ex);
            }
            return returnCode;
        }
        public long GetLabStatisticsReportSummary(DateTime fDate, DateTime tDate, int pOrgID, int pVisitType, string pHeaderName, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                SqlCommand cmd = Command.pGetLabStatisticsReportSummaryCommand(fDate, tDate, pOrgID, pVisitType, pHeaderName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDeptWiseReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetLabStatisticsReport", ex);
            }
            return returnCode;
        }
        public long GetLabStatSplitReport(DateTime pDate, string pDept, int pVisitType, int pOrgID, string pHeaderName, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                SqlCommand cmd = Command.pGetLabStatSplitReportCommand(pDate, pDept, pVisitType, pOrgID, pHeaderName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDeptWiseReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetLabStatSplitReport", ex);
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
                DataTable dtSpecialityIDs = UDT_DAL.ConvertToGetOrgIDs(lstSpecialityIDs);
                DataTable dtPhysicianIDs = UDT_DAL.ConvertToUDTIdsforReport(lstPhysicianIDs);
                SqlCommand cmd = Command.pGetDoctorsStatisticsReportCommand(fDate, tDate, pOrgID, pVisitType, pSpecialityID, phyID, dtSpecialityIDs, dtPhysicianIDs, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDeptWiseReport);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPhysician);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetDoctorsStatisticsReport", ex);
            }
            return returnCode;
        }

        public long CountPatientReport(DateTime pFromDate, DateTime pToDate, int pOrgID, string pRequestType, List<DayWiseCollectionReport> lstSpecialityIDs, List<DayWiseCollectionReport> lstPhysicianIDs, out List<DayWiseCollectionReport> lstPhysician)
        {
            long returnCode = -1;
            lstPhysician = new List<DayWiseCollectionReport>();
            try
            {
                DataTable dtSpecialityIDs = UDT_DAL.ConvertToGetOrgIDs(lstSpecialityIDs);
                DataTable dtPhysicianIDs = UDT_DAL.ConvertToUDTIdsforReport(lstPhysicianIDs);
                SqlCommand cmd = Command.pCountPatientReportCommand(pFromDate, pToDate, pOrgID, pRequestType, dtSpecialityIDs, dtPhysicianIDs, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPhysician);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL CountPatientReport", ex);
            }
            return returnCode;
        }
        public long GetAdmCancelledReport(DateTime pFromDate, DateTime pToDate, int pOrgID, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                SqlCommand cmd = Command.pGetAdmCancelledReportCommand(pFromDate, pToDate, pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDeptWiseReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetAdmCancelledReport", ex);
            }
            return returnCode;
        }
        public long GetDeathStatReport(DateTime pFromDate, DateTime pToDate, int pOrgID, string txt, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                SqlCommand cmd = Command.pGetDeathStatReportCommand(pFromDate.ToString(), pToDate.ToString(), pOrgID, txt, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDeptWiseReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetDeathStatReport", ex);
            }
            return returnCode;
        }

        public long GetWardOccupancyReport(DateTime pFromDate, DateTime pToDate, int pOrgID, int pageSize, int startRowIndex, out int totalRows, out List<WardOccupancy> lstwardReport)
        {
            long returnCode = -1;
            lstwardReport = new List<WardOccupancy>();
            totalRows = -1;
            try
            {
                SqlCommand cmd = Command.pGetwardoccupancyCommand(pOrgID, pFromDate, pToDate, pageSize, startRowIndex, out totalRows, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstwardReport);
                    totalRows = Convert.ToInt32(cmd.Parameters["@totalRows"].Value);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetDeathStatReport", ex);
            }
            return returnCode;
        }
        public long GetLabTestStatReport(DateTime fDate, DateTime tDate, int pOrgID, int pVisitType, string pHeaderName, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                SqlCommand cmd = Command.pGetLabTestStatReportCommand(fDate, tDate, pOrgID, pVisitType, pHeaderName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDeptWiseReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetLabTestStatReport", ex);
            }
            return returnCode;
        }
        public long GetLabTestStatReportSummary(DateTime fDate, DateTime tDate, int pOrgID, int pVisitType, string pHeaderName, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                SqlCommand cmd = Command.pGetLabTestStatReportSummaryCommand(fDate, tDate, pOrgID, pVisitType, pHeaderName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDeptWiseReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetLabTestStatReport", ex);
            }
            return returnCode;
        }
        public long GetDischargeAnalysisReport(DateTime pFromDate, DateTime pToDate, int pOrgID, int pVisitType, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                SqlCommand cmd = Command.pGetDischargeAnalysisReportCommand(pFromDate, pToDate, pOrgID, pVisitType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDeptWiseReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetDischargeAnalysisReport", ex);
            }
            return returnCode;
        }
        public long GetColRptIndDeptSummaryOPIP(DateTime pFDate, DateTime pTDate, int pOrgID, int pVisitType, string feeType, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                SqlCommand cmd = Command.pGetColRptIndDeptSummaryOPIPCommand(pFDate, pTDate, pOrgID, pVisitType, feeType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDeptWiseReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetColRptIndDeptSummaryOPIP", ex);
            }
            return returnCode;
        }

        //Changes of DataSet To DataReader Made By Arivalagan.k
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
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetMRDSnapShotViewCommand(pOrgID, pFromDate, pToDate, out pActiveIPList, out pTodaysOPList, out pTodaysSurgery, out pBirthCounts, out pImagingCountsOP, out pImagingCountsIP, out pImagingCountsOPIP, out pLabCountsOP, out pLabCountsIP, out pLabCountsOPIP, out pDischargeCounts, out pInfectiousDisease, out pNotifiableDiseases, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        dataReader.Close();
                    }
                    Int32.TryParse(cmd.Parameters["@pActiveIPList"].Value.ToString(), out pActiveIPList);
                    Int32.TryParse(cmd.Parameters["@pTodaysOPList"].Value.ToString(), out pTodaysOPList);
                    Int32.TryParse(cmd.Parameters["@pTodaysSurgery"].Value.ToString(), out pTodaysSurgery);
                    Int32.TryParse(cmd.Parameters["@pLabCountsOP"].Value.ToString(), out pLabCountsOP);
                    Int32.TryParse(cmd.Parameters["@pLabCountsIP"].Value.ToString(), out pLabCountsIP);
                    Int32.TryParse(cmd.Parameters["@pLabCountsOPIP"].Value.ToString(), out pLabCountsOPIP);
                    Int32.TryParse(cmd.Parameters["@pImagingCountsOP"].Value.ToString(), out pImagingCountsOP);
                    Int32.TryParse(cmd.Parameters["@pImagingCountsIP"].Value.ToString(), out pImagingCountsIP);
                    Int32.TryParse(cmd.Parameters["@pImagingCountsOPIP"].Value.ToString(), out pImagingCountsOPIP);
                    Int32.TryParse(cmd.Parameters["@pBirthCounts"].Value.ToString(), out pBirthCounts);
                    Int32.TryParse(cmd.Parameters["@pDischargeCounts"].Value.ToString(), out pDischargeCounts);
                    Int32.TryParse(cmd.Parameters["@pInfectiousDisease"].Value.ToString(), out pInfectiousDisease);
                    Int32.TryParse(cmd.Parameters["@pNotifiableDiseases"].Value.ToString(), out pNotifiableDiseases);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetMRDSnapShotView DAL", ex);
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

        public long InsertMRDDischargeAnalysis(int pOrgID, List<MRDDischargeAnalysis> lstMRDDA, out long retCode)
        {
            long returnCode = -1;
            retCode = -1;

            try
            {

                DataTable dtMRDDa = UDT_DAL.ConvertToUDTMRDDischargeAnalysis(lstMRDDA);
                SqlCommand cmd = Command.pInsertMRDDischargeAnalysisCommand(pOrgID, dtMRDDa, out retCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    retCode = Convert.ToInt64(cmd.Parameters["@pRetStatus"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL InsertMRDDischargeAnalysis", ex);
            }


            return returnCode;
        }

        public long GetMRDDischargeAnalysis(int pOrgID, out List<MRDDischargeAnalysis> lstMRDDA)
        {
            long returnCode = -1;
            lstMRDDA = new List<MRDDischargeAnalysis>();

            try
            {
                SqlCommand cmd = Command.pGetMRDDischargeAnalysisCommand(pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstMRDDA);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetMRDDischargeAnalysis", ex);
            }

            return returnCode;
        }

        public long GetProcedureStatisticsReport(DateTime fDate, DateTime tDate, int pOrgID, int pVisitType, string pHeaderName, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                SqlCommand cmd = Command.pGetProcedureStatisticsReportCommand(fDate, tDate, pOrgID, pVisitType, pHeaderName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDeptWiseReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetProcedureStatisticsReport", ex);
            }
            return returnCode;
        }

        public long GetProStatisticsReportSummary(DateTime fDate, DateTime tDate, int pOrgID, int pVisitType, string pHeaderName, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                SqlCommand cmd = Command.pGetProStatisticsReportSummaryCommand(fDate, tDate, pOrgID, pVisitType, pHeaderName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDeptWiseReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetProStatisticsReportSummary", ex);
            }
            return returnCode;
        }


        public long GetICDReport(int OrgID, string ReportView, DateTime fDate, DateTime tDate, List<PatientComplaint> lstPatientComplaint, out List<Patient> lstPatientICDSummary, out List<Patient> lstPatientICDDetail)
        {
            long returnCode = -1;
            lstPatientICDDetail = new List<Patient>();
            lstPatientICDSummary = new List<Patient>();
            DataTable dtPatientComplaint = UDT_DAL.ConvertToPendingICD(lstPatientComplaint);
            try
            {
                SqlCommand cmd = Command.pGetICDReportCommand(OrgID, ReportView, fDate, tDate, dtPatientComplaint, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientICDSummary);
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPatientICDDetail);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetICDReport", ex);
            }
            return returnCode;
        }
        public long GetDiseaseBurdenReport(int OrgID, string ReportView, DateTime fDate, DateTime tDate, List<PatientComplaint> lstPatientComplaint,
            out List<Patient> lstPatientICDSummary, out List<Patient> lstPatientICDDetail, bool Icdcode)
        {
            long returnCode = -1;
            lstPatientICDDetail = new List<Patient>();
            lstPatientICDSummary = new List<Patient>();
            DataTable dtPatientComplaint = UDT_DAL.ConvertToPendingICD(lstPatientComplaint);
            try
            {
                SqlCommand cmd = Command.pGetDiseaseBurdenReportCommand(OrgID, ReportView, fDate, tDate, dtPatientComplaint, Icdcode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0 || ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientICDSummary);
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPatientICDDetail);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetICDReport", ex);
            }
            return returnCode;
        }

        public long GetBillWiseDeptCollectionReport(DateTime pFromDate, DateTime pToDate, int pOrgID, long pLID, int pVisitType, int CurrencyID,
            out List<DayWiseCollectionReport> lstDeptWiseReport, out decimal pTotalItemAmt, out decimal pTotalDiscount, out decimal pTotalReceivedAmt,
            out decimal pTotalDue, out decimal pTax, out decimal pServiceCharge, string reportType)
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
                SqlCommand cmd = Command.pGetBillWiseDeptCollectionReportCommand(pFromDate, pToDate, pOrgID, pLID, pVisitType, CurrencyID, out pTotalItemAmt, out pTotalDiscount, out pTotalReceivedAmt, out pTotalDue, out pTax, out pServiceCharge, reportType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    Decimal.TryParse(cmd.Parameters["@pTotalItemAmt"].Value.ToString(), out pTotalItemAmt);
                    Decimal.TryParse(cmd.Parameters["@pTotalDiscount"].Value.ToString(), out pTotalDiscount);
                    Decimal.TryParse(cmd.Parameters["@pTotalReceivedAmt"].Value.ToString(), out pTotalReceivedAmt);
                    Decimal.TryParse(cmd.Parameters["@pTotalDue"].Value.ToString(), out pTotalDue);
                    Decimal.TryParse(cmd.Parameters["@pServiceCharge"].Value.ToString(), out pServiceCharge);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDeptWiseReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetBillWiseDeptCollectionReport", ex);
            }
            return returnCode;
        }


        public long GetBillWiseDeptWiseCollection(DateTime pFromDate, DateTime pToDate, int pOrgID, long pLID, int pVisitType,
            out List<DayWiseCollectionReport> lstDeptWiseReport, out decimal pTotalItemAmt, out decimal pTotalDiscount,
            out decimal pTotalReceivedAmt, out decimal pTotalDue, out decimal pTax, out decimal pServiceCharge, string reportType)
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
                SqlCommand cmd = Command.pGetBillWiseDeptWiseCollectionCommand(pFromDate, pToDate, pOrgID, pLID, pVisitType, out pTotalItemAmt,
                                                        out pTotalDiscount, out pTotalReceivedAmt, out pTotalDue, out pTax, out pServiceCharge, reportType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    Decimal.TryParse(cmd.Parameters["@pTotalItemAmt"].Value.ToString(), out pTotalItemAmt);
                    Decimal.TryParse(cmd.Parameters["@pTotalDiscount"].Value.ToString(), out pTotalDiscount);
                    Decimal.TryParse(cmd.Parameters["@pTotalReceivedAmt"].Value.ToString(), out pTotalReceivedAmt);
                    Decimal.TryParse(cmd.Parameters["@pTotalDue"].Value.ToString(), out pTotalDue);
                    Decimal.TryParse(cmd.Parameters["@pServiceCharge"].Value.ToString(), out pServiceCharge);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDeptWiseReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetBillWiseDeptWiseCollection", ex);
            }
            return returnCode;
        }


        public long CustomerTrackerTVC(DateTime fdate, DateTime tdate, out List<CusTrackerReport> FrToVisitCount)
        {
            long returnCode = -1;
            FrToVisitCount = new List<CusTrackerReport>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pCustomerTrackerTVCCommand(fdate, tdate, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out FrToVisitCount);
                }

            }
            catch (Exception ex)
            {

                CLogger.LogError("Error in Report DAL CustomerTrackerTVC", ex);

            }
            return returnCode;
        }

        public long CustomerTrackerDetRpt(DateTime fdate, DateTime tdate, int orgid, int orgaddrid, out List<CusTrackerReport> DetailedOPRpt,
            out List<CusTrackerReport> DetailedIPRpt, out List<CusTrackerReport> DischDtlrpt, out int DischargeSummaryCount, out int PatientsDischarged)
        {
            long returnCode = -1;
            DetailedOPRpt = new List<CusTrackerReport>();
            DetailedIPRpt = new List<CusTrackerReport>();
            DischDtlrpt = new List<CusTrackerReport>();
            DischargeSummaryCount = -1;
            PatientsDischarged = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pCustomerTrackerDeptOPIPRptCommand(fdate, tdate, orgid, orgaddrid, out DischargeSummaryCount, out PatientsDischarged, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    DischargeSummaryCount = Convert.ToInt32(cmd.Parameters["@pDischargeSummaryCount"].Value);
                    PatientsDischarged = Convert.ToInt32(cmd.Parameters["@pPatientsDischarged"].Value);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out DetailedOPRpt);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out DetailedIPRpt);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out DischDtlrpt);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL CustomerTrackerDRpt", ex);
            }
            return returnCode;
        }
        public long GetCollectionRptDptWiseOPIPDetalis(DateTime pFromDate, DateTime pToDate, int pOrgID, long pLID, int pVisitType,
            out List<DayWiseCollectionReport> lstDeptWiseReport, out decimal pTotalItemAmt, out decimal pTotalDiscount,
            out decimal pTotalReceivedAmt, out decimal pTotalDue, out decimal pTax, out decimal pServiceCharge, string reportType)
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
                SqlCommand cmd = Command.pGetCollectionRptDptWiseOPIPDetalisCommand(pFromDate, pToDate, pOrgID, pLID, pVisitType,
                                                        out pTotalItemAmt, out pTotalDiscount, out pTotalReceivedAmt, out pTotalDue, out pTax, out pServiceCharge, reportType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    Decimal.TryParse(cmd.Parameters["@pTotalItemAmt"].Value.ToString(), out pTotalItemAmt);
                    Decimal.TryParse(cmd.Parameters["@pTotalDiscount"].Value.ToString(), out pTotalDiscount);
                    Decimal.TryParse(cmd.Parameters["@pTotalReceivedAmt"].Value.ToString(), out pTotalReceivedAmt);
                    Decimal.TryParse(cmd.Parameters["@pTotalDue"].Value.ToString(), out pTotalDue);
                    Decimal.TryParse(cmd.Parameters["@pServiceCharge"].Value.ToString(), out pServiceCharge);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDeptWiseReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetCollectionRptDptWiseOPIP", ex);
            }
            return returnCode;
        }

        public long GetDptWiseRevenueReport(DateTime pFromDate, DateTime pToDate, int pOrgID, long pLID, int pVisitType,
            out List<DayWiseCollectionReport> lstDeptWiseReport, out decimal pTotalItemAmt, out decimal pTotalDiscount,
            out decimal pTotalReceivedAmt, out decimal pTotalDue, out decimal pTax, out decimal pServiceCharge, string reportType)
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
                SqlCommand cmd = Command.pGetDptWiseRevenueCommand(pFromDate, pToDate, pOrgID, pLID, pVisitType, out pTotalItemAmt,
                                                        out pTotalDiscount, out pTotalReceivedAmt, out pTotalDue, out pTax, out pServiceCharge, reportType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    Decimal.TryParse(cmd.Parameters["@pTotalItemAmt"].Value.ToString(), out pTotalItemAmt);
                    Decimal.TryParse(cmd.Parameters["@pTotalDiscount"].Value.ToString(), out pTotalDiscount);
                    Decimal.TryParse(cmd.Parameters["@pTotalReceivedAmt"].Value.ToString(), out pTotalReceivedAmt);
                    Decimal.TryParse(cmd.Parameters["@pTotalDue"].Value.ToString(), out pTotalDue);
                    Decimal.TryParse(cmd.Parameters["@pServiceCharge"].Value.ToString(), out pServiceCharge);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDeptWiseReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetDptWiseRevenueReport", ex);
            }
            return returnCode;
        }

        public long GetReportProfile(int pOrgID, long pReportID, out List<ReportProfile> lstReportProfile)
        {
            long returnCode = -1;
            lstReportProfile = new List<ReportProfile>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetReportProfileCommand(pOrgID, pReportID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstReportProfile);
                }

            }
            catch (Exception ex)
            {

                CLogger.LogError("Error in Report DAL GetReportProfile", ex);

            }
            return returnCode;
        }

        public long SaveReportProfile(int pOrgId, long pReportID, string pCurrentConfigValue, string pFlag)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pInsertReportProfileCommand(pOrgId, pReportID, pCurrentConfigValue, pFlag, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@ret", SqlDbType.Int);
            cmd.Parameters["@ret"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@ret"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveReportProfile in Report_DAL", ex);
            }
            return returnCode;
        }

        public long GetDuePaidDetailsReport(DateTime FromDate, DateTime ToDate, int OrgID, int CurrencyID, int pLocationID, string PaymentMode,
            out List<DuePaidDetail> lstDuePaidDetail)
        {
            long returnCode = -1;
            lstDuePaidDetail = new List<DuePaidDetail>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetDuePaidDetailsReportCommand(FromDate, ToDate, OrgID, CurrencyID, pLocationID, PaymentMode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstDuePaidDetail);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetDuePaidDetailsReport", ex);
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

        public long GetmidniteReport(DateTime FromDate, int OrgID, out List<MidNitesensexreport> lstDuePaidDetail)
        {
            long returnCode = -1;
            lstDuePaidDetail = new List<MidNitesensexreport>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetmidnitesensexrptCommand(FromDate, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDuePaidDetail);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetDuePaidDetailsReport", ex);
            }
            return returnCode;
        }






        public long SaveNonReimbursableItems(int pOrgId, long pLid, List<NonReimbursableItems> lstNonReimbursableItems)
        {
            long returnCode = -1;
            DataTable dtNRIItems = new DataTable();
            dtNRIItems = UDT_DAL.ConvertToNonReimbursableItems(lstNonReimbursableItems);
            SqlCommand cmd = Command.pSaveNonReimbursableItemsCommand(pOrgId, pLid, dtNRIItems, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveNonReimbursableItems in Report_DAL", ex);
            }
            return returnCode;
        }
        public long GetNonReimbursableForUpdate(int pOrgID, long TPAID, string TPAType, out List<NonReimbursableItems> lstNonReimbursableItems)
        {
            long returnCode = -1;
            lstNonReimbursableItems = new List<NonReimbursableItems>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetNonReimbursableForUpdateCommand(pOrgID, TPAID, TPAType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstNonReimbursableItems);
                }

            }
            catch (Exception ex)
            {

                CLogger.LogError("Error in Report DAL GetNonReimbursableForUpdate", ex);

            }
            return returnCode;
        }




        public long GetDailyExpensesReportForDynamic(DateTime fromdate, DateTime todate, int OrgID, string ReceiverType, int locationId, out DataTable lstCashOutFlow, out List<CashOutFlow> lstHead, DataTable dtusersIDs, out decimal pTotalExpenseAmt)
        {
            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
            pTotalExpenseAmt = 0;
            cmd = Command.pGetDailyExpensesReportCommand(fromdate, todate, OrgID, ReceiverType, locationId, dtusersIDs, out pTotalExpenseAmt, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstCashOutFlow = new DataTable();
            lstHead = new List<CashOutFlow>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstHead);
                lstCashOutFlow = ds.Tables[0];
                Decimal.TryParse(cmd.Parameters["@pTotalExpesnses"].Value.ToString(), out pTotalExpenseAmt);
            }
            return returnCode;
        }
        public long GetIncomeSourceReport(DateTime fromdate, DateTime todate, int OrgID, long LoginID, int CurrencyID, out List<IncSourcePaidDetails> IncSourceDetails)
        {
            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pGetIncomeSourecReportCommand(fromdate, todate, OrgID, LoginID, CurrencyID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            IncSourceDetails = new List<IncSourcePaidDetails>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out IncSourceDetails);
            }
            return returnCode;
        }

        public long GetPatientDepositDetailsRpt(DateTime FromDate, DateTime ToDate, int OrgID, string PName, string flag, out  List<Patient> lstPatient)
        {
            long returnCode = -1;
            lstPatient = new List<Patient>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetPatientDepositDetailsRptCommand(FromDate, ToDate, OrgID, PName, flag, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
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

                CLogger.LogError("Error in Report DAL GetPatientDepositDetailsRpt", ex);

            }
            return returnCode;
        }
        public long GetOPIPNewAndRevisitSummary(int OrgID, DateTime fDate, DateTime tDate, out  List<PatientVisitDetails> lstDetails)
        {
            long returnCode = -1;
            lstDetails = new List<PatientVisitDetails>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetOPIPNewAndRevisitSummaryCommand(OrgID, fDate, tDate, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetOPIPNewAndRevisitSummary in Report_DAL", ex);
            }
            return returnCode;
        }
        public long GetPatientWiseCombinedReport(DateTime fromDate, DateTime toDate, int OrgID, long PhyID, out  List<PatientWiseCombinedReport> lstPatientWiseCombinedReport)
        {
            long returnCode = -1;
            lstPatientWiseCombinedReport = new List<PatientWiseCombinedReport>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetPatientWiseCombinedReportCommand(fromDate, toDate, OrgID, PhyID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientWiseCombinedReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetPatientWiseCombinedReport in Report_DAL", ex);
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
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetDepartmentWiseCollectionReportCommand(fromDate, toDate, OrgID, vType, out pTotalDiscount, out pTotalRefund, out pTotalDue, out pTotalGrossAmount, out pTotalAdvance, out pCashDiscount, out pCreditDiscount, out pTotalDeposit, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    Decimal.TryParse(cmd.Parameters["@pTotalDiscount"].Value.ToString(), out pTotalDiscount);
                    Decimal.TryParse(cmd.Parameters["@pTotalRefund"].Value.ToString(), out pTotalRefund);
                    Decimal.TryParse(cmd.Parameters["@pTotalDue"].Value.ToString(), out pTotalDue);
                    Decimal.TryParse(cmd.Parameters["@pTotalGrossAmount"].Value.ToString(), out pTotalGrossAmount);
                    Decimal.TryParse(cmd.Parameters["@pTotalAdvance"].Value.ToString(), out pTotalAdvance);
                    Decimal.TryParse(cmd.Parameters["@pCashDiscount"].Value.ToString(), out pCashDiscount);
                    Decimal.TryParse(cmd.Parameters["@pCreditDiscount"].Value.ToString(), out pCreditDiscount);
                    Decimal.TryParse(cmd.Parameters["@pTotalDeposit"].Value.ToString(), out pTotalDeposit);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstCash);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstCredit);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstTotal);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetDepartmentWiseCollectionReport in Report_DAL", ex);
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
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetDepartmentWiseDetailReportCommand(fromDate, toDate, OrgID, vType, out pTotalDiscount, out pTotalRefund, out pTotalDue, out pTotalGrossAmount, out pTotalAdvance, out pCashDiscount, out pCreditDiscount, out pTotalDeposit, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    Decimal.TryParse(cmd.Parameters["@pTotalDiscount"].Value.ToString(), out pTotalDiscount);
                    Decimal.TryParse(cmd.Parameters["@pTotalRefund"].Value.ToString(), out pTotalRefund);
                    Decimal.TryParse(cmd.Parameters["@pTotalDue"].Value.ToString(), out pTotalDue);
                    Decimal.TryParse(cmd.Parameters["@pTotalGrossAmount"].Value.ToString(), out pTotalGrossAmount);
                    Decimal.TryParse(cmd.Parameters["@pTotalAdvance"].Value.ToString(), out pTotalAdvance);
                    Decimal.TryParse(cmd.Parameters["@pCashDiscount"].Value.ToString(), out pCashDiscount);
                    Decimal.TryParse(cmd.Parameters["@pCreditDiscount"].Value.ToString(), out pCreditDiscount);
                    Decimal.TryParse(cmd.Parameters["@pTotalDeposit"].Value.ToString(), out pTotalDeposit);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstCash);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstCredit);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstTotal);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetDepartmentWiseCollectionReport in Report_DAL", ex);
            }
            return returnCode;
        }
        public long GetDayWiseDisChargrgeReport(DateTime FromDate, DateTime ToDate, int OrgID, out List<DayWiseCollectionReport> lstDayWiseDischargeReport, int pVisitType, long pLoginID, int pCurrencyID)
        {
            long returnCode = -1;
            lstDayWiseDischargeReport = new List<DayWiseCollectionReport>();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetDaywiseDischargeReportIPCommand(FromDate, ToDate, OrgID, pLoginID, pVisitType, pCurrencyID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {

                    dbEngine.ExecuteDataSet(cmd, out ds);

                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDayWiseDischargeReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetDayWiseDischargeReport in Report_DAL", ex);
            }

            return returnCode;
        }

        public long GetMonthWiseDischargeReport(DateTime FromDate, DateTime ToDate, int OrgID, out List<DayWiseCollectionReport> lstMonthwiseDischargeReport)
        {
            long returnCode = -1;
            lstMonthwiseDischargeReport = new List<DayWiseCollectionReport>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetMonthwiseDischargeReportIPCommand(FromDate, ToDate, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {

                    dbEngine.ExecuteDataSet(cmd, out ds);

                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstMonthwiseDischargeReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetDayWiseDischargeReport in Report_DAL", ex);
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
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetPatientWiseDepositDetailsCommand(OrgID, PatientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatient);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPatientDepHis);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPatientDepUsage);
                }
            }
            catch (Exception ex)
            {

                CLogger.LogError("Error in Report DAL GetPatientDepositDetailsRpt", ex);

            }
            return returnCode;
        }
        public long GetRoomListRpt(int OrgID, int OrgAddID, out List<RoomBookingDetails> lstRoomDetails)
        {
            long returnCode = -1;
            lstRoomDetails = new List<RoomBookingDetails>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetRoomListRptCommand(OrgID, OrgAddID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {

                    dbEngine.ExecuteDataSet(cmd, out ds);

                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstRoomDetails);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetRoomListRpt in Report_BL", ex);
            }
            return returnCode;
        }
        public long GetDayWiseAdmissionDischargeRpt(DateTime FromDate, DateTime ToDate, int OrgID, string Status, out List<DayWiseCollectionReport> lstDWADR)
        {
            long returnCode = -1;
            lstDWADR = new List<DayWiseCollectionReport>();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetDaywiseAdmissionDischargeRPTCommand(FromDate, ToDate, OrgID, Status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {

                    dbEngine.ExecuteDataSet(cmd, out ds);

                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDWADR);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetDayWiseAdmissionDischarge in Report_DAL", ex);
            }

            return returnCode;
        }
        // Add Try,Catch,Finally by Arivalagan.k
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
            int rsCount = 0;
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetCollectionReportOPIPWithFilterCommand(pFromDate, pToDate, pOrgID, pLID, pVisitType, CurrencyID, advFilter, btFilter, out pTotalBillAmt, out pTotalPreDueReceived, out pTotalDiscount, out pTotalNetValue, out pTotalReceivedAmt, out pTotalDue, out pTax, out pServiceCharge, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstDayWiseReport);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstDescription);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                        Decimal.TryParse(cmd.Parameters["@pTotalBillAmt"].Value.ToString(), out pTotalBillAmt);
                        Decimal.TryParse(cmd.Parameters["@pTotalPreDueReceived"].Value.ToString(), out pTotalPreDueReceived);
                        Decimal.TryParse(cmd.Parameters["@pTotalDiscount"].Value.ToString(), out pTotalDiscount);
                        Decimal.TryParse(cmd.Parameters["@pTotalNetValue"].Value.ToString(), out pTotalNetValue);
                        Decimal.TryParse(cmd.Parameters["@pTotalReceivedAmt"].Value.ToString(), out pTotalReceivedAmt);
                        Decimal.TryParse(cmd.Parameters["@pTotalDue"].Value.ToString(), out pTotalDue);
                        Decimal.TryParse(cmd.Parameters["@pTaxAmount"].Value.ToString(), out pTax);
                        Decimal.TryParse(cmd.Parameters["@pServiceCharge"].Value.ToString(), out pServiceCharge);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetCollectionReportOPIP", ex);
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
        // Add Try,Catch,Finally by Arivalagan.k
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
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetCollectionReportOPIPSummaryCommand(pFromDate, pToDate, pOrgID, pLID, pVisitType, CurrencyID, out pTotalBillAmt, out pTotalPreDueReceived, out pTotalDiscount, out pTotalNetValue, out pTotalReceivedAmt, out pTotalDue, out pTax, out pServiceCharge, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstDayWiseReport);
                        dataReader.Close();
                        Decimal.TryParse(cmd.Parameters["@pTotalBillAmt"].Value.ToString(), out pTotalBillAmt);
                        Decimal.TryParse(cmd.Parameters["@pTotalPreDueReceived"].Value.ToString(), out pTotalPreDueReceived);
                        Decimal.TryParse(cmd.Parameters["@pTotalDiscount"].Value.ToString(), out pTotalDiscount);
                        Decimal.TryParse(cmd.Parameters["@pTotalNetValue"].Value.ToString(), out pTotalNetValue);
                        Decimal.TryParse(cmd.Parameters["@pTotalReceivedAmt"].Value.ToString(), out pTotalReceivedAmt);
                        Decimal.TryParse(cmd.Parameters["@pTotalDue"].Value.ToString(), out pTotalDue);
                        Decimal.TryParse(cmd.Parameters["@pTaxAmount"].Value.ToString(), out pTax);
                        Decimal.TryParse(cmd.Parameters["@pServiceCharge"].Value.ToString(), out pServiceCharge);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetCollectionReportOPIP", ex);
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
        public long GetTPACORPoutstandingreport(DateTime FromDate, DateTime ToDate, int OrgID, int VisitType, out List<Patient> lstResult)
        {
            long returnCode = -1;
            lstResult = new List<Patient>();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetTPACORPoutstandingreportCommand(FromDate, ToDate, OrgID, VisitType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {

                    dbEngine.ExecuteDataSet(cmd, out ds);

                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstResult);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetTPACORPoutstandingreport in Report_DAL", ex);
            }

            return returnCode;
        }
        public long GetInpatientDueReport(DateTime pFromDate, DateTime pToDate, int pOrgID, int pVisitType, string pIsCreditBill, int pageSize, int startRowIndex, out int totalRows, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            totalRows = -1;
            try
            {
                SqlCommand cmd = Command.pGetInpatientDueReportCommand(pFromDate, pToDate, pOrgID, pVisitType, pIsCreditBill, pageSize, startRowIndex, out totalRows, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    totalRows = Convert.ToInt32(cmd.Parameters["@totalRows"].Value);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDeptWiseReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetInpatientDueReport", ex);
            }
            return returnCode;
        }
        public long GetPatientLedgerReport(string PatientNumber, string FromDate, string ToDate, int OrgID, int VisitType, out List<DayWiseCollectionReport> lstDWADR)
        {
            long returnCode = -1;
            lstDWADR = new List<DayWiseCollectionReport>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetPatientLedgerReportCommand(PatientNumber, FromDate, ToDate, OrgID, VisitType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {

                    dbEngine.ExecuteDataSet(cmd, out ds);

                }
                if (ds != null)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDWADR);
                    }

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetPatientLedgerReport in Report_DAL", ex);
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
                SqlCommand cmd = Command.pGetCheckDDStmtCommand(pFromDate, pToDate, pOrgID, pVisitType, out pTotalCardAmt, out pTotalServiceCharge, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    Decimal.TryParse(cmd.Parameters["@pTotalCardAmt"].Value.ToString(), out pTotalCardAmt);
                    Decimal.TryParse(cmd.Parameters["@pTotalServiceChrg"].Value.ToString(), out pTotalServiceCharge);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDeptWiseReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL Get cheque dd stmt", ex);
            }
            return returnCode;
        }
        public long SaveMappedReports(int RoleID, int OrgID, DataTable DtRptList)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pInsertMappedReportsCommand(RoleID, OrgID, DtRptList, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetInpatientDueReport", ex);
            }
            return returnCode;
        }
        public long GetCreditLimitReport(string pFromDate, string pToDate, int pOrgID, string pVisitType, out List<Patient> lstFinalBill)
        {
            long returnCode = -1;
            lstFinalBill = new List<Patient>();

            try
            {
                SqlCommand cmd = Command.pGetCreditLimitReportCommand(pFromDate, pToDate, pOrgID, pVisitType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstFinalBill);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetCreditLimitReport", ex);
            }
            return returnCode;
        }

        public long GetTATReport(DateTime pFromDate, DateTime pToDate, int pOrgID, long LocationID, long DeptID,out List<LabTestTATReport> lstTATReport)
        {
            long returnCode = -1;
            lstTATReport = new List<LabTestTATReport>();

            try
            {
                SqlCommand cmd = Command.pGetTATReportCommand(pFromDate, pToDate, pOrgID, LocationID, DeptID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstTATReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetCreditLimitReport", ex);
            }
            return returnCode;
        }
        public long GetPharmacyDueReport(DateTime pFromDate, DateTime pToDate, int pOrgID, int OrgAddID, string IsCreditBill, int visitType, string FeeType, out List<DayWiseCollectionReport> lstReport)
        {
            long returnCode = -1;
            lstReport = new List<DayWiseCollectionReport>();

            try
            {
                SqlCommand cmd = Command.pGetPharmacyDueReportCommand(pFromDate, pToDate, pOrgID, OrgAddID, IsCreditBill, visitType, FeeType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetPharmacyDueReport", ex);
            }
            return returnCode;
        }
        public long SaveReportSnapshot(DataTable pReportData, DataTable pInvoiceData, Int64 pVisitID, Int32 pOrgID, Int64 pOrgAddressID, Int64 pCreatedBy)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pSaveReportSnapshotCommand(pReportData, pInvoiceData, pVisitID, pOrgID, pOrgAddressID, pCreatedBy, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmd);
                }
                returnCode = 0;
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL SaveReportSnapshot", ex);
            }
            return returnCode;
        }
        public long GetReportPathByVisitID(DataTable dt, out List<ApprovedReports> lstReportSnapshot)
        {
            long returnCode = -1;
            lstReportSnapshot = new List<ApprovedReports>();
            try
            {
                SqlCommand cmd = Command.pGetReportPathByVisitIDCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails), dt);
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstReportSnapshot);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetReportSnapshot", ex);
            }
            return returnCode;
        }
        public long GetReportSnapshot(Int32 pOrgID, Int64 pOrgAddressID, Int64 pVisitID, bool pUpdateStatus, string ReportType, out List<ReportSnapshot> lstReportSnapshot)
        {
            long returnCode = -1;
            lstReportSnapshot = new List<ReportSnapshot>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetReportSnapshotCommand(pOrgID, pOrgAddressID, pVisitID, pUpdateStatus, ReportType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstReportSnapshot);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetReportSnapshot", ex);
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
        public long GetBedBookedReport(DateTime pFromDate, DateTime pToDate, int pOrgID, int pageSize, int startRowIndex, out int totalRows, out List<WardOccupancy> lstwardReport)
        {
            long returnCode = -1;
            lstwardReport = new List<WardOccupancy>();
            totalRows = -1;
            try
            {
                SqlCommand cmd = Command.pGetBedBookedReportCommand(pOrgID, pFromDate, pToDate, pageSize, startRowIndex, out totalRows, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstwardReport);
                    totalRows = Convert.ToInt32(cmd.Parameters["@totalRows"].Value);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetBedBookedReport", ex);
            }
            return returnCode;
        }
        public long GetPhysicianTDSReport(DateTime pFromDate, DateTime pToDate, int pOrgID, long physicianid, string vtype, out List<CashFlowSummary> lstcashoutflowsummarys)
        {
            long returnCode = -1;
            lstcashoutflowsummarys = new List<CashFlowSummary>();
            try
            {
                SqlCommand cmd = Command.pGetPhysicianTDSReportsCommand(pFromDate, pToDate, pOrgID, physicianid, vtype, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstcashoutflowsummarys);

                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetPhysicianTDSReport", ex);
            }
            return returnCode;
        }
        public long SavePrintedReport(DataTable pReportData, Int64 pVisitID, Int32 pOrgID, Int64 pRoleID, Int64 pOrgAddressID, Int64 pCreatedBy, String pType, String pRecipient, string Category)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pInsertReportPrintHistoryCommand(pReportData, pVisitID, pOrgID, pRoleID, pOrgAddressID, pCreatedBy, pType, pRecipient, Category, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmd);
                }
                returnCode = 0;
            }
            catch (Exception ex)
            {
                returnCode = -1;
                CLogger.LogError("Error in Report DAL SavePrintedReport", ex);
            }
            return returnCode;
        }

        public long GetOPCollectionReportLIMS(DateTime fDate, DateTime tDate, int pOrgID, long LID, int retreiveDataBaseOnVtype, int currencyID, int OrgDet, string pReportType, long ClientID, int OrgAddressID, string strObj, int ClientTypeID, int RefPhyID, int RefHospitalID, out List<DayWiseCollectionReport> lstDayWiseReport)
        {
            long returnCode = -1;
            lstDayWiseReport = new List<DayWiseCollectionReport>();
            int rsCount = 0;
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetOPCollectionReportLIMSCommand(fDate, tDate, pOrgID, LID, retreiveDataBaseOnVtype, currencyID, OrgDet, pReportType, ClientID, OrgAddressID, strObj, RefPhyID, RefHospitalID, ClientTypeID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstDayWiseReport);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetOPCollectionReportLIMS", ex);
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
        public long GetInvoiceCollectionReportLIMS(DateTime fDate, DateTime tDate, int pOrgID, long LID, string pReportType, long ClientID, int OrgAddressID,
            out List<InvoiceCollectionReport> lstDayWiseReport, out List<InvoiceCollectionReport> lstDayWiseReport1,
            out List<InvoiceCollectionReport> lstDayWiseReport2, out List<InvoiceCollectionReport> lstDayWiseReport3)
        {
            long returnCode = -1;
            lstDayWiseReport = new List<InvoiceCollectionReport>();
            lstDayWiseReport1 = new List<InvoiceCollectionReport>();
            lstDayWiseReport2 = new List<InvoiceCollectionReport>();
            lstDayWiseReport3 = new List<InvoiceCollectionReport>();
            int rsCount = 0;
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetInvoiceCollectionReportLIMSCommand(fDate, tDate, pOrgID, LID, pReportType, ClientID, OrgAddressID,  UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstDayWiseReport);
                            }
                            if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstDayWiseReport1);
                            }
                            if (rsCount == 2)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstDayWiseReport2);
                            }
                            if (rsCount == 3)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstDayWiseReport3);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetInvoiceCollectionReportLIMS", ex);
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
        public long GetDailyTransactionDetails(DateTime fDate, DateTime tDate, int pOrgID, int OrgAddressID, string PatientName, string UserName, string ClientName, out List<DayWiseCollectionReport> lstDailyTransReport, out decimal pTotalAmt)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            pTotalAmt = -1;
            lstDailyTransReport = new List<DayWiseCollectionReport>();
            try
            {
                SqlCommand cmd = Command.pGetDailyTransactionDetailsCommand(fDate, tDate, pOrgID, OrgAddressID, PatientName, UserName, ClientName, out pTotalAmt, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstDailyTransReport);
                        dataReader.Close();
                    }
                    Decimal.TryParse(cmd.Parameters["@pTotalAmt"].Value.ToString(), out pTotalAmt);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetDailyTransactionDetails", ex);
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
        public long GetCreditCardStmtLims(DateTime pFromDate, DateTime pToDate, int pOrgID, int pVisitType, out List<DayWiseCollectionReport> lstDeptWiseReport, out decimal pTotalCardAmt, out decimal pTotalServiceCharge, int PaymentTypeID)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            pTotalCardAmt = -1;
            pTotalServiceCharge = -1;
            try
            {
                SqlCommand cmd = Command.pGetCreditCardStmtLimsCommand(pFromDate, pToDate, pOrgID, pVisitType, out pTotalCardAmt, out pTotalServiceCharge, PaymentTypeID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    Decimal.TryParse(cmd.Parameters["@pTotalCardAmt"].Value.ToString(), out pTotalCardAmt);
                    Decimal.TryParse(cmd.Parameters["@pTotalServiceChrg"].Value.ToString(), out pTotalServiceCharge);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDeptWiseReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetCreditCardStmt", ex);
            }
            return returnCode;
        }
        public long GetDueandDiscountLims(DateTime pFromDate, DateTime pToDate, int pOrgID, string userwise, string authorizedBy, int pVisitType, int preporttype, string pRequestType, string PName, string PNo, int pLocationID, int ClientTypeID, long ClientID, out List<DayWiseCollectionReport> lstDeptWiseReport, out decimal pTotalDiscount)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            pTotalDiscount = -1;
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetDueandDiscountLimsCommand(pFromDate, pToDate, pOrgID, userwise, authorizedBy, pVisitType, preporttype, pRequestType, PName, PNo, pLocationID, ClientID, ClientTypeID, out pTotalDiscount, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstDeptWiseReport);
                        dataReader.Close();
                    }
                    Decimal.TryParse(cmd.Parameters["@pTotalDiscount"].Value.ToString(), out pTotalDiscount);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetDueandDiscount", ex);
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
        public long GetBillWiseDeptCollectionReportLims(DateTime pFromDate, DateTime pToDate, int pOrgID, long pLID, int pVisitType, int CurrencyID, out List<DayWiseCollectionReport> lstDeptWiseReport, out decimal pTotalItemAmt, out decimal pTotalDiscount, out decimal pTotalReceivedAmt, out decimal pTotalDue, out decimal pTax, out decimal pServiceCharge, string reportType)
        {
            IDataReader dataReader = null;
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
                SqlCommand cmd = Command.pGetBillWiseDeptCollectionReportLimsCommand(pFromDate, pToDate, pOrgID, pLID, pVisitType, CurrencyID, out pTotalItemAmt, out pTotalDiscount, out pTotalReceivedAmt, out pTotalDue, out pTax, out pServiceCharge, reportType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstDeptWiseReport);
                        dataReader.Close();
                    }
                    Decimal.TryParse(cmd.Parameters["@pTotalItemAmt"].Value.ToString(), out pTotalItemAmt);
                    Decimal.TryParse(cmd.Parameters["@pTotalDiscount"].Value.ToString(), out pTotalDiscount);
                    Decimal.TryParse(cmd.Parameters["@pTotalReceivedAmt"].Value.ToString(), out pTotalReceivedAmt);
                    Decimal.TryParse(cmd.Parameters["@pTotalDue"].Value.ToString(), out pTotalDue);
                    Decimal.TryParse(cmd.Parameters["@pServiceCharge"].Value.ToString(), out pServiceCharge);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetBillWiseDeptCollectionReportLims in ReportDAL", ex);
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
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetDepartmentWiseCollectionReportLimsCommand(fromDate, toDate, OrgID, vType, out pTotalDiscount, out pTotalRefund, out pTotalDue, out pTotalGrossAmount, out pTotalAdvance, out pCashDiscount, out pCreditDiscount, out pTotalDeposit, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    Decimal.TryParse(cmd.Parameters["@pTotalDiscount"].Value.ToString(), out pTotalDiscount);
                    Decimal.TryParse(cmd.Parameters["@pTotalRefund"].Value.ToString(), out pTotalRefund);
                    Decimal.TryParse(cmd.Parameters["@pTotalDue"].Value.ToString(), out pTotalDue);
                    Decimal.TryParse(cmd.Parameters["@pTotalGrossAmount"].Value.ToString(), out pTotalGrossAmount);
                    Decimal.TryParse(cmd.Parameters["@pTotalAdvance"].Value.ToString(), out pTotalAdvance);
                    Decimal.TryParse(cmd.Parameters["@pCashDiscount"].Value.ToString(), out pCashDiscount);
                    Decimal.TryParse(cmd.Parameters["@pCreditDiscount"].Value.ToString(), out pCreditDiscount);
                    Decimal.TryParse(cmd.Parameters["@pTotalDeposit"].Value.ToString(), out pTotalDeposit);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstCash);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstCredit);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstTotal);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetDepartmentWiseCollectionReport in Report_DAL", ex);
            }
            return returnCode;
        }
        public long GetDepartmentWiseDetailReportLims(DateTime fromDate, DateTime toDate, int OrgID, int vType, out  List<DayWiseCollectionReport> lstCash, out  List<DayWiseCollectionReport> lstCredit, out  List<DayWiseCollectionReport> lstTotal, out decimal pTotalDiscount, out decimal pTotalRefund, out decimal pTotalDue, out decimal pTotalGrossAmount, out decimal pTotalAdvance, out decimal pCashDiscount, out decimal pCreditDiscount, out decimal pTotalDeposit)
        {
            IDataReader dataReader = null;
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
            int rsCount = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetDepartmentWiseDetailReportLimsCommand(fromDate, toDate, OrgID, vType, out pTotalDiscount, out pTotalRefund, out pTotalDue, out pTotalGrossAmount, out pTotalAdvance, out pCashDiscount, out pCreditDiscount, out pTotalDeposit, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstCash);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstCredit);
                            }
                            else if (rsCount == 2)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstTotal);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                    Decimal.TryParse(cmd.Parameters["@pTotalDiscount"].Value.ToString(), out pTotalDiscount);
                    Decimal.TryParse(cmd.Parameters["@pTotalRefund"].Value.ToString(), out pTotalRefund);
                    Decimal.TryParse(cmd.Parameters["@pTotalDue"].Value.ToString(), out pTotalDue);
                    Decimal.TryParse(cmd.Parameters["@pTotalGrossAmount"].Value.ToString(), out pTotalGrossAmount);
                    Decimal.TryParse(cmd.Parameters["@pTotalAdvance"].Value.ToString(), out pTotalAdvance);
                    Decimal.TryParse(cmd.Parameters["@pCashDiscount"].Value.ToString(), out pCashDiscount);
                    Decimal.TryParse(cmd.Parameters["@pCreditDiscount"].Value.ToString(), out pCreditDiscount);
                    Decimal.TryParse(cmd.Parameters["@pTotalDeposit"].Value.ToString(), out pTotalDeposit);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetDepartmentWiseDetailReportLims in Report_DAL", ex);
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
        public long GetLabTestStatReportSummaryLims(DateTime fDate, DateTime tDate, int pOrgID, int pVisitType, string pHeaderName, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                SqlCommand cmd = Command.pGetLabTestStatReportSummaryLimsCommand(fDate, tDate, pOrgID, pVisitType, pHeaderName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDeptWiseReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetLabTestStatReport", ex);
            }
            return returnCode;
        }
        public long GetLabStatisticsReportLIMS(DateTime pFromDate, DateTime pToDate, int pOrgID, int pOrgDet, int pDeptID, int SampleID, long ClientID, out List<InvLimsReport> lstInvLimsReport, int OrgAddID, string TestType, int RefHospitalID, int RefPhysicianID, int ClientTypeID)
        {
            long returnCode = -1;
            lstInvLimsReport = new List<InvLimsReport>();
            try
            {
                SqlCommand cmd = Command.pGetLabStatisticsReportLIMSCommand(pFromDate, pToDate, pOrgID, pOrgDet, pDeptID, SampleID, ClientID, OrgAddID, TestType, RefHospitalID, RefPhysicianID, ClientTypeID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvLimsReport);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetLabStatisticsReportLIMS", ex);
            }
            return returnCode;
        }
        public long GetLabStatisticsReportLim(DateTime fDate, DateTime tDate, int pOrgID, int pVisitType, string pHeaderName, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                SqlCommand cmd = Command.pGetLabStatisticsReportLimCommand(fDate, tDate, pOrgID, pVisitType, pHeaderName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDeptWiseReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetLabStatisticsReport", ex);
            }
            return returnCode;
        }
        public long GetLabTestStatReportLims(DateTime fDate, DateTime tDate, int pOrgID, int pVisitType, string pHeaderName, out List<DayWiseCollectionReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionReport>();
            try
            {
                SqlCommand cmd = Command.pGetLabTestStatReportLimsCommand(fDate, tDate, pOrgID, pVisitType, pHeaderName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDeptWiseReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetLabTestStatReport", ex);
            }
            return returnCode;
        }

        public long GetReportPrintHistory(Int32 pOrgID, Int64 pVisitID, String pType, out List<ReportPrintHistory> lstReportPrintHistory)
        {
            long returnCode = -1;
            lstReportPrintHistory = new List<ReportPrintHistory>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetReportPrintHistoryCommand(pOrgID, pVisitID, pType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstReportPrintHistory);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetReportPrintHistory", ex);
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

        public long GetSMSAlertReport(DateTime pFromDate, DateTime pToDate, int pOrgID, out List<PatientPrescription> lstPatientPrescription)
        {
            long returnCode = -1;
            lstPatientPrescription = new List<PatientPrescription>();

            try
            {
                SqlCommand cmd = Command.pGetSendSmsReportCommand(0, pFromDate, pToDate, pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientPrescription);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetSMSAlertReport", ex);
            }
            return returnCode;
        }

        public long GetEMITrackingReport(DateTime pFromDate, DateTime pToDate, string BankName, out List<AmountReceivedDetails> lstAmountReceivedDetails)
        {
            long returnCode = -1;
            lstAmountReceivedDetails = new List<AmountReceivedDetails>();

            try
            {
                SqlCommand cmd = Command.PgetEMITrackingReportCommand(pFromDate, pToDate, BankName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstAmountReceivedDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetEMITrackingReport", ex);
            }
            return returnCode;
        }

        public long GetEstimationVsConsumtionReport(DateTime pFromDate, DateTime pToDate, string SearchItem, out List<BillofMaterialDetails> lstBillofMaterialDetails)
        {
            long returnCode = -1;
            lstBillofMaterialDetails = new List<BillofMaterialDetails>();

            try
            {
                SqlCommand cmd = Command.pGetEstimatedVsConsumptionReportCommand(pFromDate, pToDate, SearchItem, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBillofMaterialDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetEMITrackingReport", ex);
            }
            return returnCode;
        }


        public long GetLabTestCountReportDetail(DateTime fromDate, DateTime toDate, int OrgID, long OrgAddID, string testName,
            List<InvDeptMaster> lstInvDeptMaster, string reportType, int ClientType, int ClientID, string TestCategory, int RefPhysicianID, int RefHospitalID, int AnalyzerID, int PageSize, int currentPageNo, out int totalRows, out List<InvestigationStatusReport> lstPatientInvestigationStatus)
        {
            long returnCode = -1;
            totalRows = -1;
            lstPatientInvestigationStatus = new List<InvestigationStatusReport>();
            IDataReader dataReader = null;

            try
            {
                DataTable dtLabTestCountReport = UDT_DAL.ConvertToInvDeptMaster(lstInvDeptMaster);
                SqlCommand cmd = Command.pGetLabTestCountReportCommand(fromDate, toDate, OrgID, OrgAddID, testName, reportType, dtLabTestCountReport, UDT_DAL.ConvertToUDT_Context(globalContextDetails), ClientType, ClientID, TestCategory, RefPhysicianID, RefHospitalID, AnalyzerID, PageSize, currentPageNo, out totalRows);
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstPatientInvestigationStatus);
                        dataReader.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetLabTestCountReport ", ex);
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


        public long GetWriteOffReportDetail(DateTime fromDate, DateTime toDate, int OrgID, int ILocationID, long WriteOffID, string WriteOffType, int ClientTypeID, out List<PatientDueDetails> lstWriteOffDetail)
        {
            long returnCode = -1;
            lstWriteOffDetail = new List<PatientDueDetails>();
            try
            {
                SqlCommand cmd = Command.pGetWriteoffDetailsCommand(fromDate, toDate, OrgID, ILocationID, WriteOffID, WriteOffType, ClientTypeID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstWriteOffDetail);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetLabTestCountReport ", ex);
            }
            return returnCode;
        }


        public long GetCourierDetailsReport(long OrgID, int ILocationID, string Status, int RefOrgID, int RefPhyID, DateTime fromDate, DateTime toDate, long ClientID, int ClientTypeId, int CourierBoyID, string DispatchTypeid, long DispatchModeid, out List<DayWiseCollectionReport> lstCourierDetailsReport, out List<OrderedInvestigations> lstordered, int pagesize, int startrowindex, out int totalrows)
        {
            long returnCode = -1;
            totalrows = -1;
            lstCourierDetailsReport = new List<DayWiseCollectionReport>();
            lstordered = new List<OrderedInvestigations>();
            try
            {
                SqlCommand cmd = Command.pGetCourierDetailsReportCommand(OrgID, ILocationID, Status, RefOrgID, RefPhyID, fromDate, toDate, ClientID, ClientTypeId, CourierBoyID, DispatchTypeid, DispatchModeid, UDT_DAL.ConvertToUDT_Context(globalContextDetails), pagesize, startrowindex, out totalrows);
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstCourierDetailsReport);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstordered);
                    totalrows = Convert.ToInt32(ds.Tables[1].Rows[0]["totalRows"]);
                }
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
            int rsCount = 0;
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetOrgwiseCollectionReportCommand(fDate, tDate, pOrgID, LID, retreiveDataBaseOnVtype, currencyID, OrgDet, pReportType, ClientID, OrgAddressID, strObj, RefPhyID, RefHospitalID, ClientTypeID, dtUserIDs, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstDayWiseReport);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL pGetOrgwiseCollectionReport", ex);
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
        public long AmtDeptDetailsReport(DateTime pFromDate, DateTime pToDate, int pOrgID, out List<AmountDebtClosureDetails> lstACD)
        {
            long returnCode = -1;
            lstACD = new List<AmountDebtClosureDetails>();
            try
            {
                SqlCommand cmd = Command.pAmtDepitDetailsReportCommand(pFromDate, pToDate, pOrgID);
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstACD);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetAdmCancelledReport", ex);
            }
            return returnCode;
        }
        public long GetApprovedReport(int OrgID, string approvedtime, string service, out List<ApprovedReports> lstDayWiseReport)
        {

            long returnCode = -1;
            lstDayWiseReport = new List<ApprovedReports>();
            int rsCount = 0;
            try
            {
                SqlCommand cmd = Command.PGetApprovedReportCommand(OrgID, approvedtime, service,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDayWiseReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL pGetOrgwiseCollectionReport", ex);
            }
            return returnCode;
        }
        public long SavepdfReport(DataTable Visitids, Int64 Roleid, Int32 orgid, String despatchdate, String Method)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.psaveDispatchInvestigationStatusCommand(Visitids, Roleid, orgid, despatchdate, Method, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmd);
                }
                returnCode = 0;
            }
            catch (Exception ex)
            {
                returnCode = -1;
                CLogger.LogError("Error in Report DAL SavePrintedReport", ex);
            }
            return returnCode;
        }

        public long SaveActionDetails(DataTable Dt)
        {
            long returnCode = -1;
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pInsertNotificationsLisCommand(Dt, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = 0;
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while SaveActionDetails", ex);
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

        public long GetCheckDueAmount(long PatientID, long VisitID, long OrgID, long OrgAddressId, string Type, out string IsDuePending)
        {
            long returnCode = -1;
            IDataReader dataReader = null;
            IsDuePending = string.Empty;
            try
            {
                SqlCommand cmd = Command.pCheckDueAmountCommand(PatientID, VisitID, OrgID, OrgAddressId, Type, out IsDuePending);
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    IsDuePending = Convert.ToString(cmd.Parameters["@isDuePending"].Value);
                    dataReader.Close();
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetVitekDeviceIntegrationResult Integration_DAL", e);
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

        public long UpdateNotification(DataTable pReportData, DataTable pInvoicedata)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pUpdateNotificationsCommand(pReportData, pInvoicedata, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmd);
                }
                returnCode = 0;
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL SaveReportSnapshot", ex);
            }
            return returnCode;
        }

        public long GetPath(int OrgID, long VisitID, string category, out List<ReportSnapshot> ReportPath)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            ReportPath = new List<ReportSnapshot>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetPathCommand(OrgID, VisitID, category, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out ReportPath);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetPath ReportDAl", ex);
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

        public long SaveReportBarcodeDetails(long pVisitID, int pOrgID, byte[] pBarcode, string BarcodeType)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pSaveReportBarcodeDetailsCommand(pVisitID, pOrgID, pBarcode, BarcodeType);
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmd);
                }
                returnCode = 0;
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL SaveReportBarcodeDetails", ex);
            }
            return returnCode;
        }

        public long SaveInvoiceNotificationDetails(int orgID, int customerTypeID, string Client, long ClientID, int LocationID, DateTime sFromDate, DateTime sToDate, int PageSize, int startRowIndex, int totalRows, string searchtype)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.PInsertInvoiceNotificationsCommand(orgID, customerTypeID, LocationID, Client, ClientID, sFromDate, sToDate, PageSize, startRowIndex, totalRows, searchtype, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmd);
                }
                returnCode = 0;
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while SaveInvoiceNotificationDetails", ex);
            }
            return returnCode;
        }
        public long InsertNotificationManual(long OrgId, long Locationid, long Visitid, string Type, String Emailaddress)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pInsertNotificationManualCommand(OrgId, Locationid, Visitid, Type, Emailaddress, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmd);
                }
                returnCode = 0;
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL InsertNotificationPrint", ex);
            }
            return returnCode;
        }

        public long GetHomeCollectionCancelledReport(long loginID, string status, DateTime FromDate, DateTime ToDate, out List<HomeCollectionCancel> lstHomeCollectionCancel)
        {
            long returnCode = -1;
            lstHomeCollectionCancel = new List<HomeCollectionCancel>();
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pGetHomeCollectionCancelledReportCommand(loginID, status, FromDate, ToDate, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstHomeCollectionCancel);
                }


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in NewReports_DAL GetAntibiotics Stats Report", ex);
            }
            return returnCode;
        }
        public long GetExpence(int ReportType, DateTime fromdate, DateTime todate, int OrgID, string UserName, out List<ExpenseReport> ExpenseDetails)
        {
            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
            cmd = Command.PGetExpenceCommand(ReportType, fromdate, todate, OrgID, UserName);
            ExpenseDetails = new List<ExpenseReport>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out ExpenseDetails);
            }
            return returnCode;
        }
 /*Added By Jagatheesh For MIS Test Wise Analyzer Report*/
        public long GetTestWiseAnalyzerReportLims(int ReportType, DateTime fDate, DateTime tDate, int IntOrgID, string AnalyzerName, int ClientLocation, int TestId, out List<TestWiseAnalyzerReport> lstdata)
        {
            long returnCode = -1;
            lstdata = new List<TestWiseAnalyzerReport>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.PgetAnalyzerReportCommand(ReportType, fDate, tDate, IntOrgID, AnalyzerName, ClientLocation, TestId);
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstdata);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetTestWiseAnalyzerReportLims", ex);
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
        /* End Added */
		  public long getClientIncome_Report(DateTime FromDate, DateTime ToDate, int OrgID, long ClientID, string ClientName, out DataSet ds, out int RowCount)
        {
            long returnCode = -1;
            ds = new DataSet();
            RowCount = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetClientIncomeReportCommand(FromDate, ToDate, OrgID, ClientID, ClientName, out RowCount, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                Int32.TryParse(cmd.Parameters["@pRowCount"].Value.ToString(), out RowCount);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetTPACORPoutstandingreport in Report_DAL", ex);
            }

            return returnCode;
        }
        public long getClientStatics_Report(DateTime FromDate, DateTime ToDate, int OrgID, string ClientName, int reporttype, out DataSet DsResult)
        {
            long returnCode = -1;
            DsResult = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetClientStaticsReportCommand(FromDate, ToDate, OrgID, ClientName, reporttype, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DsResult = ds;
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetTPACORPoutstandingreport in Report_DAL", ex);
            }

            return returnCode;
        }

        public long SaveWatersReportBarcodeDetails(string pVisitNumber, int pOrgID, byte[] pBarcode, string BarcodeType)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pSaveWatersReportBarcodeDetailsCommand(pVisitNumber, pOrgID, pBarcode, BarcodeType);
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmd);
                }
                returnCode = 0;
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL SaveReportBarcodeDetails", ex);
            }
            return returnCode;
        }

        public long GetAttachmentName(long visitID, out List<Notifications> lstnotifications)
        {
            lstnotifications = new List<Notifications>();
            long returnCode = -1;
            IDataReader dataReader = null;

           
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.PGetAttachmentNameCommand(visitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstnotifications);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetAttachementName in Report_DAL", ex);
            }

            return returnCode;
        }
 public long GetKPITATReport(DateTime fromdate, DateTime todate, string VisitNo, string HistoNo, string Specimen, string Status, string TatDelay, out List<HistopathologyTATReport> lsthisto)
        {
            long returnCode = -1;
            lsthisto = new List<HistopathologyTATReport>();
            SqlCommand cmd = Command.PGetKPITATReportCommand(fromdate, todate, VisitNo,HistoNo,Specimen,Status,TatDelay, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lsthisto);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetKPITATReport", ex);
            }
            return returnCode;
        }

        public long GetHistoDetailedReport(DateTime fromdate, DateTime todate, string PatientNo, string PatientName, string VisitNo, string HistoNo, string Specimen, long TestID, string Impression,string Malignant,string WHOClassification,string Staging,string Grading , out List<HistopathexaminationReport> lsthisto)
        {
            long returnCode = -1;
            lsthisto = new List<HistopathexaminationReport>();
            SqlCommand cmd = Command.PGetHistopathExaminationReportCommand(fromdate, todate, PatientNo, PatientName, VisitNo, HistoNo, Specimen, TestID, Impression,Malignant,WHOClassification,Staging,Grading, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lsthisto);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetHistoDetailedReport", ex);
            }
            return returnCode;
        }

        public long PgetCashOutFlowPaymentReport(long LocationID, string PayableType, string FromDate, string ToDate, out DataTable dt)
        {
            long returnCode = -1;
            DataSet ds = new DataSet();
          dt = new DataTable();
          SqlCommand cmd = Command.PgetCashOutFlowPaymentReport_MISCommand(LocationID, PayableType, FromDate, ToDate, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
              {
                  dt = ds.Tables[0];
              }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing PgetCashOutFlowPaymentReport Report DAL", ex);
            }
            return returnCode;
        }
		
		/// <summary>
        ///  Get Report details in Delivery Queue
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
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetReportSnapshotNotificationsCommand(pOrgID, @pNotificationId, pOrgAddressID, pVisitID, pUpdateStatus, ReportType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstReportSnapshot);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetReportSnapshot", ex);
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


        public void pssrsReportDisplayMode(long VisitID, Int32 OrgID, string InvID, out string ReportType)
        {
            ReportType = string.Empty;
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pssrsReportDisplayModeCommand(VisitID, OrgID, InvID);
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ReportType = ds.Tables[0].Rows[0]["ReportDeliveryMode"].ToString();
                }
                //ReportType = cmd.Parameters["@ReportDeliveryMode"].Value.ToString();
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in pssrsReportDisplayMode in Report_DAL", ex);
            }
        }

        // Start | Kiosk Printing Service | Velmurugan D | 30-Nov-2018

        public long GetPatientDetailsVisitNumber(string visitNumber, out List<ReportPrinting> lstReportPrinting)
        {
            long returnCode = -1;
            lstReportPrinting = new List<ReportPrinting>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetPatientDetailsVisitNumberCommand(visitNumber, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstReportPrinting);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while get patient details passing visit number", ex);
            }

            return returnCode;
        }

        public long GetpatientReportPrintDetails(long visitID, int OrgID, out List<ReportPrinting> lstReportPrinting)
        {
            long returnCode = -1;
            lstReportPrinting = new List<ReportPrinting>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.PGetpatientReportPrintDetailsCommand(visitID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstReportPrinting);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while get patient details passing visit number", ex);
            }

            return returnCode;
        }

        public long GetpatientinvestigationforvisitNumber(long visitID, int OrgID, string Guid, out List<ReportPrinting> lstReportPrinting)
        {
            long returnCode = -1;
            lstReportPrinting = new List<ReportPrinting>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.PgetpatientinvestigationforvisitNumberCommand(visitID, OrgID, Guid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstReportPrinting);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while get patient details passing visit number", ex);
            }

            return returnCode;
        }

        public long GetPatientReportPrintingStatus(long visitID, out List<ReportPrinting> lstReportPrinting)
        {
            long returnCode = -1;
            lstReportPrinting = new List<ReportPrinting>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetPatientReportPrintingStatusCommand(visitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstReportPrinting);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while get patient details passing visit number", ex);
            }

            return returnCode;
        }
        public SmartReport GetSmartReportNotification(long NotificationID, out string Paths)
        {
            long returnCode = -1;
            Paths = "";
            long PatientVisitID = 0;
            string notificationID = string.Empty;
            long OrgD = 0;
            string personName = "";
            string visitOn ="";
            string gender = "";
            string VisitNo = "";
            string VisitType = "";
            string age = "";
            string ReferingPhysicianName = "";
            string PatientID = "";
            string ConstultantName = "";
            string collectedOn = "";
            string reportedOn = "" ;
            DateTime PrintedOn = DateTime.MinValue; ;
            string ContactNo = "";
            string ClientName = "";
            string dob = "" ;
            string Name = "";
            string mrn = "";
            string Address = "";
            string PostalCode = "";

            string PatientAddress = "";

            string PatientPostalcode = "";

            string AttachmentName = "";
            string entityName = string.Empty;
            string entityLocationCode = string.Empty, externalEntityId=string.Empty;
            string Pdfreportpath="";
            SmartReport lstSmartReport = new SmartReport();
            try
            {

                SqlCommand cmd = Command.PgetSmartReport_APICommand(NotificationID);
                IDataReader dataReader = null;

                List<personDetails> pds = new List<personDetails>();
                personDetails pp = new personDetails();
                List<trends> trendss = new List<trends>();
                
              //  List<summaryNormal> summaryNormals = new List<summaryNormal>();
               // List<summaryAbnormal> summaryAbNormals = new List<summaryAbnormal>();
                List<personInvResults> labRes = new List<personInvResults>(); 
                List<personResults> lstresults = new List<personResults>();
                documentAttachments objdocument = new documentAttachments();
                List<documentAttachments> lstdocument = new List<documentAttachments>();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    Utilities.ConvertTo(dataReader, out pds);
                    foreach (personDetails P in pds)
                    {

                        personName = P.personName;
                        visitOn = P.visitOn;
                        gender = P.gender;
                        VisitNo = P.visitNo;
                        VisitType = P.visitType;
                        age = P.age;
                        ReferingPhysicianName = P.referingPhysicianName;
                        //PatientID = P.PatientID;
                        //ConstultantName = P.ConstultantName;
                        collectedOn = P.collectedOn;
                        reportedOn = P.reportedOn;
                        //PrintedOn = P.PrintedOn;
                        ContactNo = P.mobile;
                        ClientName = P.subClientName;
                        dob = P.dob;
                       // Name = P.Name;
                        mrn = P.mrn;
                       // Address = P.Address;
                        PostalCode = P.postalCode;
                        PatientAddress = P.address;
                        PatientPostalcode = P.postalCode;
                        PatientVisitID = P.PatientVisitId;

                    }
                    pp.personName = personName;
                    pp.visitOn = visitOn;
                    pp.gender = gender;
                    pp.visitNo = VisitNo;
                    pp.visitType = VisitType;
                    pp.age = age;
                    pp.referingPhysicianName = ReferingPhysicianName;
                    //pp.PatientID = PatientID;
                   // pp.ConstultantName = ConstultantName;
                    pp.collectedOn = collectedOn;
                    pp.reportedOn = reportedOn;
                   // pp.PrintedOn = PrintedOn;
                    pp.mobile = ContactNo;
                    pp.subClientName = ClientName;
                    pp.dob = dob;
                    //pp.Name = Name;
                    pp.mrn = mrn;
                    //pp.Address = Address;
                    //pp.PostalCode = PostalCode;
                    pp.address = PatientAddress;
                    pp.postalCode = PatientPostalcode;
                    pp.PatientVisitId = PatientVisitID;
                    pp.reportPath = "";
                    //pp.PatientVisitID = 0;

                    //pp.transactionId = NotificationID;
                    //pp.entityId = 0;
                    pp.fileName = "";

                    lstSmartReport.personDetailsVO = pp;
                    if (dataReader.NextResult())
                    {
                        Utilities.ConvertTo(dataReader, out trendss);
                        //objresult.trendsList = trendss;
                    }
                   /* if (dataReader.NextResult())
                    {
                        Utilities.ConvertTo(dataReader, out summaryNormals);

                        lstSmartReport.summaryNormal = summaryNormals;
                    }
                    if (dataReader.NextResult())
                    {
                        Utilities.ConvertTo(dataReader, out summaryAbNormals);

                        lstSmartReport.summaryAbnormal = summaryAbNormals;
                    }*/
                    if (dataReader.NextResult())
                    {

                        Utilities.ConvertTo(dataReader, out labRes);
                         
                         
                    }
                    if (dataReader.NextResult())
                    {

                        string PathwithfileName = "";// Pdfreportpath.Replace("/", "\\");
                        byte[] filepathByte = null;

                      
                        while (dataReader.Read())
                        {
                            PathwithfileName = Convert.ToString(dataReader["PdfReportpath"]).Replace("/", "\\");
                            if (File.Exists(PathwithfileName))
                            {
                                filepathByte = File.ReadAllBytes(PathwithfileName);
                                objdocument.fileBytesContent = filepathByte;
                            }
                            objdocument.externalURL = "";
                            objdocument.fileName = Convert.ToString(dataReader["AttachmentName"]);
                            objdocument.fileSize = 0;
                            objdocument.fileMimeType = Convert.ToString(dataReader["fileMimeType"]);
                            lstdocument.Add(objdocument);
                        }
                    }
                    if (dataReader.NextResult())
                    {

                        while (dataReader.Read())
                        {
                            Paths = Convert.ToString(dataReader["Path"]);
                            notificationID = Convert.ToString(dataReader["NotificationID"]);
                            OrgD = Convert.ToInt64(dataReader["OrgID"]);
                            PatientVisitID = Convert.ToInt64(dataReader["PatientVisitID"]);
                            AttachmentName = Convert.ToString(dataReader["AttachmentName"]);
                            entityName = Convert.ToString(dataReader["entityName"]);
                            entityLocationCode = Convert.ToString(dataReader["entityLocationCode"]);
                            externalEntityId = Convert.ToString(dataReader["externalEntityId"]);
                        }

                    }

                    foreach(personInvResults objre in  labRes)
                    {
                        personResults objresult = new personResults();
                        objresult.investigationID = objre.investigationID;
                        objresult.investigationName =objre.investigationName;
                        objresult.sampleName = objre.sampleName;
                        objresult.result =objre.result;
                        objresult.resultStatus = objre.resultStatus;
                        objresult.units =objre.units;
                        objresult.approvedBy = objre.approvedBy;
                        objresult.approverName =objre.approverName;
                        objresult.interpretationNotes = objre.interpretationNotes;
                        objresult.medicalRemarks =objre.medicalRemarks;
                        objresult.profileId = objre.profileId;
                        objresult.profileName =objre.profileName;
                        objresult.subGroupId = objre.subGroupId;
                        objresult.referenceRange =objre.referenceRange;
                        objresult.trendsVOList = trendss.FindAll(p => p.investigationID == objre.investigationID);
                        lstresults.Add(objresult);
                        
                    }
                    lstSmartReport.personResultsVOList = lstresults;
                    lstSmartReport.personDetailsVO.reportPath = Paths;
                    //lstSmartReport.pd.PatientVisitID = PatientVisitID;
                    lstSmartReport.transactionId = notificationID;
                    lstSmartReport.entityId = OrgD;
                    lstSmartReport.externalEntityId = externalEntityId;
                    lstSmartReport.personDetailsVO.fileName = AttachmentName;
                    lstSmartReport.entityName = entityName;
                    lstSmartReport.externalCustomData = "";
                    lstSmartReport.entityLocationCode = entityLocationCode;
                    lstSmartReport.title = "";
                   
                    lstSmartReport.documentAttachmentsVO = lstdocument;
 
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetSmartReportNotification", ex);
            }
            return lstSmartReport;
        }

        public long UpdateSmartReportNotificationAPI(long NotificationID, long PatientVisitid, long OrgID, string Status)
        {
            long returnCode = -1;

            try
            {

                SqlCommand cmd = Command.PUpdateNotificationSamrtReportStatus_APICommand(NotificationID, PatientVisitid, OrgID, Status);

                using (DBEngine dbEngine = new DBEngine())
                {

                    dbEngine.ExecuteNonQuery(cmd);
                    returnCode = 0;

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetSmartReportNotification", ex);
            }
            return returnCode;
        }
        public long GetSmartReportMailNotification(long PatientVisitid, int OrgID, out List<ApprovedReports> lstReport)
        {
            long returnCode = -1;
            lstReport = new List<ApprovedReports>();
            try
            {

                SqlCommand cmd = Command.pgetapprovedsmartreportCommand(OrgID,PatientVisitid);
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetSmartReportNotification", ex);
            }
            return returnCode;
        }

        // END | Kiosk Printing Service | Velmurugan D | 30-Nov-2018
		
		   public long GetCustomizedReportList(long OrgID, out List<ReportMaster> lstReport)
        {
            long returnCode = -1;

            SqlCommand cmd = new SqlCommand();
            cmd = Command.pGetCustomisedSPListCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstReport = new List<ReportMaster>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }   
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstReport);
            }
            return returnCode;
        }
        public DataSet CustomizedReport(long ReportID, DateTime Fdate, DateTime Tdate, long ClientID, int VisitType, string TestDetail, int DeptID)
        {
            long num = -1L;
            DataSet dataSet = new DataSet();
            DataSet set2 = new DataSet();
            try
            {
                SqlCommand sqlCommand = Command.PGetCustomizedREportDetailsCommand(ReportID, Fdate, Tdate, ClientID, VisitType,TestDetail,DeptID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine engine = new DBEngine())
                {
                    num = engine.ExecuteDataSet(sqlCommand, out dataSet);
                    set2 = dataSet;
                }
            }
            catch (Exception exception)
            {
                CLogger.LogError("Error in Report_BL - CustomizedReport", exception);
            }
            return set2;
        }

        public long GetDaywiseCollectionRevenueReport(DateTime pFromDate, DateTime pToDate, int pOrgID, long LocationID, long ClientID,
            out List<DayWiseCollectionRevenueReport> lstDeptWiseReport)
        {
            long returnCode = -1;
            lstDeptWiseReport = new List<DayWiseCollectionRevenueReport>();
           
            try
            {
                SqlCommand cmd = Command.pGetDayWiseCollectionRevenueReportV2Command(pOrgID, LocationID, pFromDate, pToDate, ClientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDeptWiseReport);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report DAL GetDaywiseCollectionRevenueReport", ex);
            }
            return returnCode;
        }
    }
}
