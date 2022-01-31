
using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Attune.Podium.DataAccessLayer;
using Attune.Podium.BusinessEntities;
using System.Data;
using Attune.Podium.Common;
using System.Transactions;
using Attune.Podium.PerformingNextAction;
using Attune.Podium.BusinessEntities.CustomEntities;
using Attune.Podium.BusinessEntities;
using System.IO;


namespace Attune.Podium.BillingEngine
{

    public class BillingEngine
    {
        ContextDetails globalContextDetails;
        public BillingEngine()
        {

        }
        public BillingEngine(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        /// <summary> 
        /// This method would be called to create billing entry for doctor consultation 
        /// </summary>
        /// <param name="physicianID">Physician ID who will be or who have treated the patient</param>
        /// <param name="orgID"> Logged on organisation ID</param>
        /// <param name="patientID">Patient ID of the patient</param>
        /// <param name="visitID">Current visit ID</param>
        /// <param name="createdBy">The User who created this entry </param>
        /// <returns> Status of entry </returns>
        public long CreateConsultingBillingEntry(int physicianID, long orgID, long patientID, long visitID, long createdBy)
        {
            long returnCode = -1;
            try
            {
                BillingDAL billingDAL = new BillingDAL(globalContextDetails);
                returnCode = billingDAL.SaveConsultingBillingEntry(physicianID, orgID, patientID, visitID, createdBy);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Execute CreateConsultingBillingEntry in BillingEngineBL", ex);
            }
            return returnCode;
        }

        public long getBillDetailSearch(string Clientname, string Visitnumber, DateTime pFDT, DateTime pTDT, long orgID, string RdoResult, long startRowIndex, long PageSize, out long totalRows, out List<ResultSearch> search)
        {
            long returnCode = -1;
            totalRows = 0;
            search = new List<ResultSearch>();
            try
            {
                BillingDAL billingDAL = new BillingDAL(globalContextDetails);
                returnCode = billingDAL.GetBillDetailSearch(Clientname, Visitnumber, pFDT, pTDT, orgID, RdoResult, startRowIndex, PageSize, out totalRows, out search);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Execute CreateConsultingBillingEntry in BillingEngineBL", ex);
            }
            return returnCode;
        }
        //public long SaveBillDetailSearch(long orgID, List<ResultSearch> lstResultSearch)
        //{
        //    long returnCode = -1;
        //    try
        //    {
        //        BillingDAL billingDAL = new BillingDAL(globalContextDetails);
        //        returnCode = billingDAL.SaveBillDetailSearch(orgID, lstResultSearch);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error while executing SaveBillDetailSearch in BillingEngineBL", ex);
        //    }
        //    return returnCode;
        //}

        /// <summary>
        /// This method would be called to create billing entry for doctor consultation. This overloaded
        /// method is used in cases where the consulting amount is decided by the doctor and not at the hospital
        /// level.
        /// </summary>
        /// <param name="physicianID">Physician ID who will be or who have treated the patient</param>
        /// <param name="orgID"> Logged on organisation ID</param>
        /// <param name="patientID">Patient ID of the patient</param>
        /// <param name="visitID">Current visit ID</param>
        /// <param name="createdBy">The User who created this entry </param>
        /// <param name="amount"> Amount taken for the consulting service</param>
        public long CreateConsultingBillingEntry(long orgID, out long BillID, out string BillNumber, long visitID, long createdBy, List<SaveBillingDetails> lstSaveBillingDetail, int LocationID, long pBillingDetailsID)
        {
            long returnCode = -1;
            BillID = 0;
            BillNumber = "";
            try
            {
                BillingDAL billingDAL = new BillingDAL(globalContextDetails);
                returnCode = billingDAL.SaveConsultingBillingEntry(orgID, out BillID, out BillNumber, visitID, createdBy, lstSaveBillingDetail, LocationID, pBillingDetailsID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing CreateConsultingBillingEntry in BillingEngineBL", ex);
            }
            return returnCode;
        }

        /// <summary>
        /// This method would be called to create billing entry for Procedures. 
        /// </summary>
        /// <param name="physicianID">physician ID</param>
        /// <param name="orgID">Organisation ID</param>
        /// <param name="patientID">Patient ID</param>
        /// <param name="visitID">Visit ID</param>
        /// <param name="createdBy">Created By</param>
        /// <returns>returns the status of the operation</returns>
        public long CreateProcedureBillingEntry(int physicianID, long orgID, long patientID, long visitID, long createdBy)
        {
            long returnCode = -1;
            try
            {
                BillingDAL billingDAL = new BillingDAL(globalContextDetails);
                returnCode = billingDAL.SaveProcedureBillingEntry(physicianID, orgID, patientID, visitID, createdBy);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing CreateProcedureBillingEntry in BillingEngineBL", ex);
            }
            return returnCode;
        }

        /// <summary>
        /// This method would be called to create billing entry for Procedures. Overloaded method 
        /// that gets amount as well.
        /// </summary>
        /// <param name="physicianID">physician ID</param>
        /// <param name="orgID">Organisation ID</param>
        /// <param name="patientID">Patient ID</param>
        /// <param name="visitID">Visit ID</param>
        /// <param name="createdBy">Created By</param>
        /// <param name="amount">Amount to be paid for the procedure</param>
        /// <returns>returns the status of the operation</returns>
        public long CreateProcedureBillingEntry(long orgID, long visitID, out long BillID, long createdBy, List<SaveBillingDetails> lstSaveBillingDetail, int LocationID)
        {
            long returnCode = -1;
            BillID = 0;
            try
            {
                BillingDAL billingDAL = new BillingDAL(globalContextDetails);

                returnCode = billingDAL.SaveProcedureBillingEntry(orgID, out BillID, visitID, createdBy, lstSaveBillingDetail, LocationID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing CreateProcedureBillingEntry in BillingEngineBL", ex);
            }
            return returnCode;
        }


        /// <summary>
        /// This method would be called to create billing entry for Investigations
        /// </summary>
        /// <param name="investigationID">Investigation ID </param>
        /// <param name="orgID">Organisation ID</param>
        /// <param name="patientID">PatientID</param>
        /// <param name="visitID">VisitID</param>
        /// <param name="createdBy">CreatedBy</param>
        /// <returns>returns the status of the operation</returns>
        public long CreateInvestigationBillingEntry(int investigationID, long orgID, long patientID, long visitID, long createdBy)
        {
            long returnCode = -1;
            try
            {
                BillingDAL billingDAL = new BillingDAL(globalContextDetails);
                returnCode = billingDAL.SaveInvestigationBillingEntry(investigationID, orgID, patientID, visitID, createdBy);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing CreateInvestigationBillingEntry BillingEngineBL", ex);
            }
            return returnCode;
        }

        /// <summary>
        /// This method would be called to create billing entry for Investigations. Overloaded method 
        /// that gets amount as well
        /// </summary>
        /// <param name="investigationID">Investigation ID </param>
        /// <param name="orgID">Organisation ID</param>
        /// <param name="patientID">PatientID</param>
        /// <param name="visitID">VisitID</param>
        /// <param name="createdBy">CreatedBy</param>
        /// <param name="amount">Amount to be stored</param>
        /// <returns>returns the status of the operation</returns>
        public long CreateInvestigationBillingEntry(long orgID, out long BillID, long visitID, long createdBy,
            long clientID, List<SaveBillingDetails> lst, int LocationID, out string LabNo)
        {
            long returnCode = -1;
            BillID = 0;
            LabNo = "";
            try
            {
                BillingDAL billingDAL = new BillingDAL(globalContextDetails);
                returnCode = billingDAL.SaveInvestigationBillingEntry(orgID, out BillID, visitID,
                    createdBy, clientID, lst, LocationID, out LabNo);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading CreateInvestigationBillingEntry in BillingEngineBL", ex);
            }
            return returnCode;
        }

        /// <summary>
        /// This method returns the details of the dues of the patient, if at all any
        /// </summary>
        /// <param name="orgID">Organisation ID</param>
        /// <param name="patientID">Patient ID</param>
        /// <param name="visitID">Current Visit ID</param>
        /// <param name="dueDetails">Due Details</param>
        /// <returns>Status of the transaction</returns>
        public long GetDueDetails(long orgID, long patientID, long visitID, out long finalBillID, out List<FinalBill> dueDetails, out string VisitType)
        {
            long returnCode = -1;
            dueDetails = new List<FinalBill>();
            finalBillID = -1;
            VisitType = "";
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetDueDetails(orgID, patientID, visitID, out finalBillID, out dueDetails, out VisitType);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetDueDetail in BillingEngineBl", ex);
            }
            return returnCode;
        }

        public long UpdateDues(long orgID, long patientID, List<long> visitIDs)
        {
            long status = -1;
            return status;
        }

        /// <summary>
        /// This method would be called during the bill generation process. 
        /// </summary>
        /// <param name="orgID">Org ID</param>
        /// <param name="patientID">Patient ID</param>
        /// <param name="visitID">Visit ID</param>
        /// 
        /// <param name="billingDetails">Billing Detials to be returned to the caller</param>
        /// <returns>status of the call</returns>
        public long GetBillingDetails(long orgID, long patientID, long visitID,
                                        out List<BillingDetails> billingDetails,
                                        out List<StandardDeduction> lstStdDeduction,
                                        long FinalBillD)
        {
            billingDetails = new List<BillingDetails>();
            lstStdDeduction = new List<StandardDeduction>();
            long returnCode = -1;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetBillingDetails(orgID, patientID, visitID, out billingDetails, out lstStdDeduction, FinalBillD);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetBillingDetails in BillingEngineBL", ex);
            }
            return returnCode;
        }

        /// <summary>
        /// This method would be used to update the FinalBill details after the amount is 
        /// received from patient
        /// </summary>
        /// <param name="finalBill">Details of the Final Bill</param>
        /// <returns>Status of the call</returns>
        public long UpdateFinalBill(FinalBill finalBill, AmountReceivedDetails amtRD, DataTable dtAmtReceived,
            List<PatientDueChart> pPatientIndTable, List<TaxBillDetails> lstTaxDetails, decimal dserviceCharge, List<VisitClientMapping> lstVisitClientMapping, List<PatientDepositUsage> lstUsage)
        {
            long returnCode = -1;
            DataTable dtBillingDetails = new DataTable();


            try
            {
                returnCode = new BillingDAL(globalContextDetails).UpdateFinalBill(finalBill, amtRD, dtAmtReceived, pPatientIndTable, lstTaxDetails, dserviceCharge, lstVisitClientMapping);
                if (lstUsage.Count > 0)
                {
                    lstUsage[0].FinalBillID = finalBill.FinalBillID;
                    returnCode = new BillingDAL(globalContextDetails).InsertDepositUsage(lstUsage);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while updating Final Bill", ex);
            }
            return returnCode;
        }

        /// <summary>
        /// Get Physician fees details
        /// </summary>
        /// <param name="physicianID"></param>
        /// <param name="orgID"></param>
        /// <param name="lstPhysicianFees"></param>
        /// <returns></returns>
        public long GetPhysicianFeesDetails(long visitID, long physicianID, int orgID, out List<BillingFeeDetails> lstPhysicianFees)
        {
            lstPhysicianFees = new List<BillingFeeDetails>();
            long returnCode = -1;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetPhysicianFeesDetail(visitID, physicianID, orgID, out lstPhysicianFees);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetPhysicianFeesDetails", ex);
            }
            return returnCode;
        }

        public long GetProcedureFeeDetailsWithClientID(long pVisitID, long procedureID, long orgID, out List<BillingFeeDetails> lstProcedureFeeDetail, string sCheckAll, long pClientID)
        {
            lstProcedureFeeDetail = new List<BillingFeeDetails>();
            long returnCode = -1;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetProcedureFeeDetailsWithClientID(pVisitID, procedureID, orgID, out lstProcedureFeeDetail, sCheckAll, pClientID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetPhysicianFeesDetails", ex);
            }
            return returnCode;
        }

        /// <summary>
        /// Get Procedure fees details information
        /// </summary>
        /// <param name="procedureID"></param>
        /// <param name="orgID"></param>
        /// <param name="lstProcedureFeesDetails"></param>
        /// <returns></returns>
        public long GetProcedureFeesDetails(long pVisitID, long procedureID, long orgID, out List<BillingFeeDetails> lstProcedureFeesDetails, string sCheckAll)
        {
            long returnCode = -1;
            lstProcedureFeesDetails = new List<BillingFeeDetails>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetProcedureFeesDetails(pVisitID, procedureID, orgID, out lstProcedureFeesDetails, sCheckAll);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Eroor while GetProcedureFeesDetails", ex);
            }
            return returnCode;
        }

        /// <summary>
        /// Get Investigation fees details
        /// </sumGetInvestigationFeesDetailsmary>
        /// <param name="patientVisitID"></param>
        /// <param name="orgID"></param>
        /// <param name="lstInvestigationFeesDetails"></param>
        /// <returns></returns>
        public long GetInvestigationFeesDetails(long patientVisitID, long orgID, long clientID, out List<BillingFeeDetails> lstInvestigationFeesDetails)
        {
            long returnCode = -1;
            lstInvestigationFeesDetails = new List<BillingFeeDetails>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetInvestigationFeesDetails(patientVisitID, orgID, clientID, out lstInvestigationFeesDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetInvestigationFeesDetails", ex);
            }
            return returnCode;
        }

        /// <summary>
        /// Get bill printing details
        /// </summary>
        /// <param name="visitID"></param>
        /// <param name="lstBillingDetails"></param>
        /// <param name="lstFinalBill"></param>
        /// <param name="lstPatientDetail"></param>
        /// <param name="lstOrganization"></param>
        /// <returns></returns>

        public long GetBillPrintingDetails(long visitID, out List<BillingDetails> lstBillingDetails,
                                                        out List<FinalBill> lstFinalBill,
                                                        out List<Patient> lstPatientDetail,
                                                        out List<Organization> lstOrganization,
                                                        out string physicianName,
                                                        out List<DuePaidDetail> lstDuesPaid,
                                                        long FinalBillID, out List<Taxmaster> lstTax, out string splitstatus, out List<PatientQualification> lstQualification)
        {
            long returnCode = -1;
            lstBillingDetails = new List<BillingDetails>();
            lstFinalBill = new List<FinalBill>();
            lstPatientDetail = new List<Patient>();
            lstOrganization = new List<Organization>();
            lstDuesPaid = new List<DuePaidDetail>();
            lstTax = new List<Taxmaster>();
            lstQualification = new List<PatientQualification>();
            splitstatus = string.Empty;
            physicianName = string.Empty;
            try
            {
                BillingDAL billingDAL = new BillingDAL(globalContextDetails);
                returnCode = billingDAL.GetBillPrintingDetails(visitID, out lstBillingDetails, out lstFinalBill,
                                                                        out lstPatientDetail,
                                                                        out lstOrganization,
                                                                        out physicianName,
                                                                        out lstDuesPaid,
                                                                            FinalBillID, out lstTax, out splitstatus, out lstQualification);
                /*-----------------Handle VIP Data Start-------------------------*/
                List<Patient> lsttempDetails = new List<Patient>();
                lsttempDetails = lstPatientDetail.FindAll(p => p.PatientStatus == "VIP");
                lstPatientDetail.RemoveAll(p => p.PatientStatus == "VIP");
                for (int i = 0; i < lsttempDetails.Count; i++)
                {
                    /*----Decrypting----------*/
                    Utilities objUtilities = new Utilities();
                    object inputobj = new object();
                    object Decryptedobj = new object();
                    inputobj = lsttempDetails[i];
                    returnCode = objUtilities.GetDecryptedobj(inputobj, out Decryptedobj);
                    lsttempDetails[i] = (Patient)Decryptedobj;
                    /*----------------------*/
                    /*-----Masking----------*/
                    object inputobj1 = new object();
                    object Maskedobj = new object();
                    inputobj1 = lsttempDetails[i];
                    returnCode = objUtilities.GetMaskedobj(inputobj1, out Maskedobj);
                    lsttempDetails[i] = (Patient)Maskedobj;
                    lstPatientDetail.Add(lsttempDetails[i]);
                    /*----------------------*/
                }
                /*-----------------Handle VIP Data End------------------------------*/
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetBillPrintingDetails", ex);
            }
            return returnCode;
        }
        public long GetOrderedItemsForBillEdit(long visitID, out List<BillingDetails> lstBillingDetails,
                                                        out List<FinalBill> lstFinalBill,
                                                       
                                                        long FinalBillID)
        {
            long returnCode = -1;
            lstBillingDetails = new List<BillingDetails>();
            lstFinalBill = new List<FinalBill>();
            try
            {
                BillingDAL billingDAL = new BillingDAL(globalContextDetails);
                returnCode = billingDAL.GetOrderedItemsForBillEdit(visitID, out lstBillingDetails, out lstFinalBill, FinalBillID);
               
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetBillPrintingDetails", ex);
            }
            return returnCode;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="orgID"></param>
        /// <param name="patientID"></param>
        /// <param name="patientVisitID"></param>
        /// <param name="advanceAmount"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public long InsertAdvanceAmount(long orgID, long patientID, long patientVisitID, decimal advanceAmount, string type)
        {
            long returnCode = -1;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).InsertAdvanceAmount(orgID, patientID, patientVisitID, advanceAmount, type);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Insert Advance Amount", ex);
            }
            return returnCode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="patientVisitID"></param>
        /// <param name="orgID"></param>
        /// <param name="lstFeeDetails"></param>
        /// <param name="lstStdDeduction"></param>
        /// <returns></returns>
        public long GetPhysicianBeforeFeeDetail(long patientVisitID, int orgID, out List<BillingDetails> lstFeeDetails, out List<StandardDeduction> lstStdDeduction)
        {
            long returnCode = -1;
            lstFeeDetails = new List<BillingDetails>();
            lstStdDeduction = new List<StandardDeduction>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetPhysicianBeforeFeeDetail(patientVisitID, orgID, out lstFeeDetails, out lstStdDeduction);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetPhysicianBeforeFeeDetail", ex);
            }
            return returnCode;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="finalBill"></param>
        /// <param name="amount"></param>
        /// <param name="feeID"></param>
        /// <param name="feeType"></param>
        /// <param name="feeDescription"></param>
        /// <returns></returns>
        public long InsertPhysicianBeforeFeeDetail(FinalBill finalBill, List<BillingDetails> lstBillingDetail)
        {
            long returnCode = -1;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).InsertPhysicianBeforeFeeDetail(finalBill, lstBillingDetail);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while InserPhysicianBeforeFeeDetails", ex);
            }
            return returnCode;
        }

        public long GetBeforeAfterPaymentMode(long patientvisitID, out List<VisitPurpose> lstVisitPurpose)
        {
            long returnCode = -1;
            lstVisitPurpose = new List<VisitPurpose>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetBeforeAfterPaymentMode(patientvisitID, out lstVisitPurpose);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetNeforeAfterPaymentMode ", ex);
            }
            return returnCode;
        }

        public long GetFinalBillDetail(long patientVisitID, out List<FinalBill> lstFinalBill, out List<StandardDeduction> lstStdDeduction)
        {
            long returnCode = -1;
            lstFinalBill = new List<FinalBill>();
            lstStdDeduction = new List<StandardDeduction>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetFinalBillDetail(patientVisitID, out lstFinalBill, out lstStdDeduction);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetFinalBillDetail", ex);
            }
            return returnCode;
        }


        public long GetPreviousTaskDetail(long taskID, out List<Tasks> lstTasks)
        {
            long returnCode = -1;
            lstTasks = new List<Tasks>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetPreviousTaskDetail(taskID, out lstTasks);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetPreviousTaskDetail", ex);
            }
            return returnCode;
        }

        public long GetProcedureBeforeFeeDetail(long procedureID, int orgID, out List<BillingDetails> lstBillingDetail, out List<StandardDeduction> lstStdDeduction)
        {
            long returnCode = -1;
            lstBillingDetail = new List<BillingDetails>();
            lstStdDeduction = new List<StandardDeduction>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetProcedureBeforeFeeDetails(procedureID, orgID, out lstBillingDetail, out lstStdDeduction);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetProcedureBefreFeeDetails", ex);
            }
            return returnCode;
        }


        public long UpdateAndInsertDueDetail(List<DuePaidDetail> lstDuePaidDetail)
        {
            long returnCode = -1;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).UpdateAndInsertDueDetail(lstDuePaidDetail);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while UpdateAndInsertDueDetails", ex);
            }
            return returnCode;
        }


        public long UpdatePatientInvStatus(List<PatientInvestigation> lstPatientInvestigation, out int count)
        {
            long returnCode = -1;
            count = -1;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).UpdatePatientInvStatus(lstPatientInvestigation, out count);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while UpdatePatientInvStatus", ex);
            }
            return returnCode;
        }

        public long GetFinalBillID(long PatientId, long PatientVisitId, out long outStatus)
        {
            long returncode = -1;
            outStatus = 0;
            try
            {
                returncode = new BillingDAL(globalContextDetails).GetFinalBillID(PatientId, PatientVisitId, out outStatus);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing GetFinalBillID", ex);
            }
            return returncode;
        }

        public long InsertMiscellaneousBills(BillingDetails bd)
        {
            long returncode = -1;

            BillingDAL billDAL = new BillingDAL(globalContextDetails);
            billDAL.InsertMiscellaneousBills(bd);

            return returncode;
        }
        public long pGetRefundBillingDetails(long visitID, out List<BillingDetails> lstBillingDetails, out decimal amtReceived, out decimal amtRefunded, out decimal dChequeAmount, long FinalBillID, long billDetailsID)
        {
            long returnCode = -1;
            amtReceived = 0;
            amtRefunded = 0;
            dChequeAmount = 0;
            lstBillingDetails = new List<BillingDetails>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).pGetRefundBillingDetails(visitID, out lstBillingDetails, out amtReceived, out amtRefunded, out dChequeAmount, FinalBillID, billDetailsID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing.CS", ex);
            }
            return returnCode;
        }

        public long GetAmountReceivedDetails(long UserID, int OrgId, DateTime pFDT, DateTime pTDT,int locationId, out List<ReceivedAmount> lstAmountReceivedDetails,
                                            out List<ReceivedAmount> lstRefundDetails,
                                            out List<ReceivedAmount> lstPaymentDetails,
                                            out decimal dTotalAmount, out decimal dTotalRefund, out decimal dTotalCancelledAmount,
                                            out string sRcvdFromtime, out string sRcvdTotime,
                                            out string sRefundFromtime, out string sRefundTotime,
                                            out string sMinStartTime, out string sMaxEndTime,
                                            out decimal dtAmount, out decimal othersAmount,
                                            out decimal TotalIncAmount,
                                            out List<ReceivedAmount> lstINDAmtReceivedDetails,
                                            out List<ReceivedAmount> lstIPINDAmtReceivedDetails,
                                            out List<AmountReceivedDetails> lstreceivedTypes,
                                            out List<ReceivedAmount> lstSplitDetails,
                                                        out List<AmountReceivedDetails> lstIncSourcePaidDetails,
                                            out List<CurrencyOrgMapping> lstCurrencyInHand,
                                            out List<CashClosureDenomination> lstCCDeno,
                                            out decimal TotalPendingSettleAmt)
        {
            long returnCode = -1;
            sRcvdFromtime = string.Empty;
            sRcvdTotime = string.Empty;
            sRefundFromtime = string.Empty;
            sRefundTotime = string.Empty;
            sMaxEndTime = string.Empty;
            sMinStartTime = string.Empty;

            lstAmountReceivedDetails = new List<ReceivedAmount>();
            lstRefundDetails = new List<ReceivedAmount>();
            lstPaymentDetails = new List<ReceivedAmount>();
            lstINDAmtReceivedDetails = new List<ReceivedAmount>();
            lstIPINDAmtReceivedDetails = new List<ReceivedAmount>();
            lstreceivedTypes = new List<AmountReceivedDetails>();
            lstSplitDetails = new List<ReceivedAmount>();
            lstCurrencyInHand = new List<CurrencyOrgMapping>();
            lstCCDeno = new List<CashClosureDenomination>();
            lstIncSourcePaidDetails = new List<AmountReceivedDetails>();
            dTotalAmount = 0;
            dTotalRefund = 0; dTotalCancelledAmount = 0;
            dtAmount = 0;
            othersAmount = 0;
            TotalIncAmount = 0;
            TotalPendingSettleAmt = 0;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetAmountReceivedDetails(UserID, OrgId, pFDT, pTDT,locationId,
                                                                        out lstAmountReceivedDetails,
                                                                        out lstRefundDetails,
                                                                        out lstPaymentDetails,
                                                                        out dTotalAmount,
                                                                        out dTotalRefund, out dTotalCancelledAmount,
                                                                        out sRcvdFromtime,
                                                                        out sRcvdTotime,
                                                                        out sRefundFromtime,
                                                                        out sRefundTotime,
                                                                        out sMinStartTime,
                                                                        out sMaxEndTime,
                                                                        out dtAmount,
                                                                        out othersAmount,
                                                                        out TotalIncAmount,
                                                                        out lstINDAmtReceivedDetails,
                                                                        out lstIPINDAmtReceivedDetails,
                                                                        out lstreceivedTypes,
                                                                        out lstSplitDetails,
                                                                        out lstIncSourcePaidDetails,
                                                                        out lstCurrencyInHand,
                                                                        out lstCCDeno,
                                                                        out TotalPendingSettleAmt);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing.CS", ex);
            }
            return returnCode;
        }

        public long GetAmountRefundDetails(long UserID, int OrgId, out List<ReceivedAmount> lstReceivedAmount, out decimal dTotalrRefundAmount)
        {
            long returnCode = -1;
            lstReceivedAmount = new List<ReceivedAmount>();
            dTotalrRefundAmount = 0;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetAmountRefundDetails(UserID, OrgId, out lstReceivedAmount, out dTotalrRefundAmount);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing.CS", ex);
            }
            return returnCode;
        }

        public long GetListOfUsersForCollection(long OrgId, out List<Users> lstUsersDetails)
        {
            long returnCode = -1;
            lstUsersDetails = new List<Users>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetListOfUsersForCollection(OrgId, out lstUsersDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing.CS", ex);
            }
            return returnCode;
        }
        public long InsertAmountClosureDetails(decimal totalAmount, decimal amountReceived, string status,
                                                int closedBy, int closedFor, int createdBy, int createdFor,
                                                DataTable dtBillingDetails,
                                                DataTable dtAmountRefundDetails,
                                                DataTable dtAmountPaidDetails, string AllUsersSelected,
                                                decimal amountRefund, string isrefund)
        {
            long returnCode = -1;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).InsertAmountClosureDetails(totalAmount, amountReceived, status,
                                                                        closedBy, closedFor, createdBy, createdFor,
                                                                        dtBillingDetails,
                                                                        dtAmountRefundDetails,
                                                                        dtAmountPaidDetails,
                                                                        AllUsersSelected, amountRefund, isrefund);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while excecuting billing_bl", ex);
            }
            return returnCode;
        }
        public long InsertAmountClosureDetailsForAllUsers(DataTable dtClosureDetails, string status, int createdBy,
                                                          DataTable dtBillingDetails,
                                                          DataTable dtAmountRefundDetails,
                                                          DataTable dtAmountPaidDetails, string isrefund)
        {
            long returnCode = -1;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).InsertAmountClosureDetailsForAllUsers(dtClosureDetails, status, createdBy,
                                                                                    dtBillingDetails,
                                                                                    dtAmountRefundDetails,
                                                                                    dtAmountPaidDetails,
                                                                                    isrefund);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while excecuting billing_bl", ex);
            }
            return returnCode;
        }
        public long insertAmtRefundDetails(List<AmountRefundDetails> lstAmountRefundDetails, string RefFlag, out string RefundNo, int RefundStatus, long OrgId, out List<BillingDetails> lstBillingdetails, long CollectionID)
        {
            long returnCode = -1;
            lstBillingdetails = new List<BillingDetails>();

            RefundNo = "";
            try
            {

                BillingDAL bd = new BillingDAL(globalContextDetails);
                returnCode = bd.insertAmtRefundDetails(lstAmountRefundDetails, RefFlag, out RefundNo, RefundStatus, OrgId, out lstBillingdetails, CollectionID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL insertAmtRefundDetails", ex);
            }
            return returnCode;
        }

        public long GetBillSearchActions(int roleID, out List<BillSearchActions> lstBillSearchActions)
        {
            long returnCode = -1;
            lstBillSearchActions = new List<BillSearchActions>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetBillSearchActions(roleID, out lstBillSearchActions);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetVisitSearchActions BL", ex);
            }
            return returnCode;
        }



        public long GetCollectionDetails(string fromDate,
                string toDate, int orgID, out decimal totalAdditions,
                out decimal totalDeduction, out List<ServiceQtyAmount> lstInflowDtls,
                out List<ServiceQtyAmount> lstOutflowDtls)
        {
            long returnCode = -1;
            totalAdditions = 0;
            totalDeduction = 0;
            lstInflowDtls = new List<ServiceQtyAmount>();
            lstOutflowDtls = new List<ServiceQtyAmount>();

            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetCollectionDetails(fromDate, toDate, orgID, out totalAdditions, out totalDeduction, out lstInflowDtls, out lstOutflowDtls);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetCollectionDetails methof in Billing_BL", ex);
            }
            return returnCode;
        }

        public long GetCollectionDetails(long collectedBy, string fromDate,
                string toDate, int orgID, out decimal totalAdditions,
                out decimal totalDeduction, out List<ServiceQtyAmount> lstInflowDtls,
                out List<ServiceQtyAmount> lstOutflowDtls)
        {
            long returnCode = -1;
            totalAdditions = 0;
            totalDeduction = 0;
            lstInflowDtls = new List<ServiceQtyAmount>();
            lstOutflowDtls = new List<ServiceQtyAmount>();

            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetCollectionDetails(collectedBy, fromDate, toDate, orgID, out totalAdditions, out totalDeduction, out lstInflowDtls, out lstOutflowDtls);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetCollectionDetails methof in Billing_BL", ex);
            }
            return returnCode;
        }

        public StringBuilder BuildCollectionDetailTbl(List<ServiceQtyAmount> lstinflow, List<ServiceQtyAmount> lstoutflow, decimal totalAddition, decimal totalDeduction)
        {
            decimal gTotal = totalAddition - totalDeduction;
            StringBuilder sCollection = new StringBuilder();
            sCollection.Append("");

            if (lstinflow.Count > 0 || lstoutflow.Count > 0)
            {
                sCollection.Append("<Table border=1>");
                sCollection.Append("<tr>");
                sCollection.Append("<th align='center'>Service Offered</th>");
                sCollection.Append("<th align='center'>Total Nos.</th>");
                sCollection.Append("<th align='center'>Amount</th>");
                sCollection.Append("</tr>");

                if (lstinflow.Count > 0)
                {
                    foreach (ServiceQtyAmount sqain in lstinflow)
                    {
                        sCollection.Append("<tr>");
                        sCollection.Append("<td>" + sqain.Event + "</td>");
                        sCollection.Append("<td>" + sqain.Qty.ToString() + "</td>");
                        sCollection.Append("<td align='Right'>" + sqain.Amount.ToString() + "</td>");
                        sCollection.Append("</tr>");
                    }
                }
                if (lstoutflow.Count > 0)
                {
                    foreach (ServiceQtyAmount sqaout in lstoutflow)
                    {
                        sCollection.Append("<tr>");
                        sCollection.Append("<td>" + sqaout.Event + "</td>");
                        sCollection.Append("<td>" + sqaout.Qty.ToString() + "</td>");
                        sCollection.Append("<td align='Right'>" + sqaout.Amount.ToString() + "</td>");
                        sCollection.Append("</tr>");
                    }
                }
                if (lstinflow.Count > 0)
                {
                    if (totalAddition > 0)
                    {
                        if (totalDeduction > 0)
                        {
                            gTotal = totalAddition - totalDeduction;
                        }
                        else
                        {
                            totalDeduction = 0;
                            gTotal = totalAddition;
                        }
                    }
                    else
                    {
                        totalAddition = 0;
                    }
                    sCollection.Append("<tr>");
                    sCollection.Append("<td colspan='2' align='Right'>Total Additions</td>");
                    sCollection.Append("<td align='Right'>" + totalAddition.ToString() + "</td>");
                    sCollection.Append("</tr>");
                    sCollection.Append("<tr>");
                    sCollection.Append("<td colspan='2' align='Right'>Total Deductions</td>");
                    sCollection.Append("<td align='Right'>" + totalDeduction.ToString() + "</td>");
                    sCollection.Append("</tr>");
                    sCollection.Append("<tr>");
                    sCollection.Append("<td colspan='2' align='Right'>Grand Total</td>");
                    sCollection.Append("<td align='Right'>" + gTotal.ToString() + "</td>");
                    sCollection.Append("</tr>");

                }
                sCollection.Append("</Table>");
            }

            return sCollection;
        }
        public long InsertAmountReceivedDetails(DataTable dtAmtReceived, long OrgID, decimal dAmtReceived, long lReceivedBy, long lCreatedBy, long lFinallBillID, decimal dserviceCharge)
        {
            long returnCode = -1;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).InsertAmountReceivedDetails(dtAmtReceived, OrgID, dAmtReceived, lReceivedBy, lCreatedBy, lFinallBillID, dserviceCharge);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Inserting AmoutReceivedDetails", ex);
            }
            return returnCode;
        }


        public long InsertCashFlow(int iReceiverID, string sReceiverName, string sReceiverType, string sPaymentType,
                                    decimal dAmountReceived, decimal dDue, decimal dSurplus,
                                    DateTime dFromDate, DateTime dToDate, string sRemarks, string status,
                                    int Lid, int iOrgID, DataTable dtAmountReceived, decimal dServiceCharge,
                                    out string VouNo, out long OutFlowID, List<CashFlowTransactions> lstCashFlowTransactions, CashOutFlow objCashOutFlow, long pOrgAddressID)
        {
            long returnCode = -1;
            VouNo = "";
            OutFlowID = 0;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).InsertCashFlow(iReceiverID, sReceiverName, sReceiverType, sPaymentType,
                                                                dAmountReceived, dDue, dSurplus, dFromDate, dToDate,
                                                                sRemarks, status, Lid, iOrgID, dtAmountReceived, dServiceCharge,
                                                                out VouNo, out OutFlowID, lstCashFlowTransactions, objCashOutFlow, pOrgAddressID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Inserting InsertCashFlow", ex);
            }
            return returnCode;
        }

        public long GetCashFlow(long OrgID, long lPhysicianID, DateTime dFromDate,
                                DateTime dToDate, out List<CashFlowSummary> lstCashFlowSummary,
                                out decimal pTotalDue, out decimal pTotalAdvance,
                                out decimal dIPPercent, out decimal dOPPercent,
                                out decimal dIPTax, out decimal dOPTax, out List<CashOutFlow> lstOutFlow,
                                out decimal dtotGivenAmt)
        {

            long returnCode = -1;
            lstCashFlowSummary = new List<CashFlowSummary>();
            lstOutFlow = new List<CashOutFlow>();
            pTotalDue = 0;
            pTotalAdvance = 0;
            dIPPercent = 0;
            dOPPercent = 0;
            dIPTax = 0;
            dOPTax = 0;
            dtotGivenAmt = 0;

            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetCashFlow(OrgID, lPhysicianID, dFromDate, dToDate, out lstCashFlowSummary,
                                                            out pTotalDue, out pTotalAdvance,
                                                            out dIPPercent, out dOPPercent, out dIPTax,
                                                            out dOPTax, out lstOutFlow, out dtotGivenAmt);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetCashFlow", ex);
            }
            return returnCode;
        }

        public long InsertPatientDueCollections(long lPatientID, long lOrgID, long lOrgAddresID, int iVisitPurposeID, long lCreatedBy,
                                                string sFeeDescription, decimal dAmount, List<DuePaidDetail> lstDueDetail,
                                                DataTable dtAmountReceived, decimal dAmtReceived, out long lVisitID, out long lFinalID, decimal dserviceCharge)
        {
            long lResult = -1;
            lVisitID = 0;
            lFinalID = 0;
            DataTable dtDueDetail = new DataTable();
            //DataTable dtpatientDue=new DataTable();
            // dtpatientDue = GetPatientDueDetails(lstPatientDueDetails);
            lResult = new BillingDAL(globalContextDetails).InsertPatientDueCollections(lPatientID, lOrgID, lOrgAddresID, iVisitPurposeID, lCreatedBy,
                                                sFeeDescription, dAmount, lstDueDetail,
                                                dtAmountReceived, dAmtReceived, out lVisitID, out lFinalID, dserviceCharge);

            return lResult;
        }


        public long GetCorporateDiscount(int OrgID, out List<CorporateMaster> lstCorporateMaster)
        {
            long returnCode = -1;
            lstCorporateMaster = new List<CorporateMaster>();
            BillingDAL billingDAL = new BillingDAL(globalContextDetails);
            try
            {
                returnCode = billingDAL.GetCorporateDiscount(OrgID, out lstCorporateMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetCorporateDiscount in BillingEngine", ex);
            }
            return returnCode;
        }

        public long InsertFinalBillForDirect(FinalBill finalBill, AmountReceivedDetails amtRD, DataTable dtAmtReceived, List<PatientDueChart> pPatientIndTable, decimal dserviceCharge)
        {
            long returnCode = -1;

            try
            {
                returnCode = new BillingDAL(globalContextDetails).InsertFinalBillForDirect(finalBill, amtRD, dtAmtReceived, pPatientIndTable, dserviceCharge);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while updating Final Bill", ex);
            }
            return returnCode;
        }



        public long GetListOfUsers(long OrgId, out List<Users> lstUsersDetails)
        {
            long returnCode = -1;
            lstUsersDetails = new List<Users>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetListOfUsers(OrgId, out lstUsersDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing.CS", ex);
            }
            return returnCode;
        }


        public long GetPatientBabyVaccFeeDetails(long pVisitID, long pID, out List<BillingFeeDetails> lstPBV)
        {
            long returnCode = -1;
            lstPBV = new List<BillingFeeDetails>();

            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetPatientBabyVaccFeeDetails(pVisitID, pID, out lstPBV);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetPatientBabyVaccFeeDetails", ex);
            }

            return returnCode;
        }

        public long CreateImmunizationBillingEntry(long orgID, out long BillID, long visitID, long createdBy, List<SaveBillingDetails> lstSaveBillingDetail, int LocationID)
        {
            long returnCode = -1;
            BillID = 0;
            try
            {
                BillingDAL billingDAL = new BillingDAL(globalContextDetails);
                returnCode = billingDAL.SaveImmunizationBillingEntry(orgID, out BillID, visitID, createdBy, lstSaveBillingDetail, LocationID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing CreateImmunizationBillingEntry in BillingEngineBL", ex);
            }
            return returnCode;
        }

        public long GetAmountReceivedReport(int OrgId,
                                           DateTime pFDT, DateTime pTDT,
                                           out List<ReceivedAmount> lstINDAmtReceivedDetails,
                                           out List<ReceivedAmount> lstINDIPAmtReceivedDetails)
        {
            long returnCode = -1;

            lstINDAmtReceivedDetails = new List<ReceivedAmount>();
            lstINDIPAmtReceivedDetails = new List<ReceivedAmount>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetAmountReceivedReport(OrgId, pFDT, pTDT,
                                                                        out lstINDAmtReceivedDetails,
                                                                        out lstINDIPAmtReceivedDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing.CS", ex);
            }
            return returnCode;
        }

        public long GetAmountReceivedDaywiseReport(int OrgId,
                                          string pType,
                                          out List<ReceivedAmount> lstINDAmtReceivedDetails)
        {
            long returnCode = -1;

            lstINDAmtReceivedDetails = new List<ReceivedAmount>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetAmountReceivedDaywiseReport(OrgId, pType,
                                                                        out lstINDAmtReceivedDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing.CS", ex);
            }
            return returnCode;
        }

        public long GetOrderedInvestigationFeesDetails(long patientVisitID, long orgID, long clientID, out List<BillingFeeDetails> lstInvestigationFeesDetails)
        {
            long returnCode = -1;
            lstInvestigationFeesDetails = new List<BillingFeeDetails>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetOrderedInvestigationFeesDetails(patientVisitID, orgID, clientID, out lstInvestigationFeesDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetOrderedInvestigationFeesDetails", ex);
            }
            return returnCode;
        }


        public long GetInvFeeDetails(long patientVisitID, long orgID, long clientID, string UID, out List<BillingFeeDetails> lstInvestigationFeesDetails)
        {
            long returnCode = -1;
            lstInvestigationFeesDetails = new List<BillingFeeDetails>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetInvFeeDetails(patientVisitID, orgID, clientID, UID, out lstInvestigationFeesDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetInvFeeDetails", ex);
            }
            return returnCode;
        }

        public long GetTaxDetails(int orgID, out List<Taxmaster> lstTaxMaster)
        {
            long returnCode = -1;
            lstTaxMaster = new List<Taxmaster>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetTaxDetails(orgID, out lstTaxMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetTaxDetails", ex);
            }
            return returnCode;
        }

        public long CheckBilltobeCancelled(long finalBillID, out int duePaidforPreBills, out int duePaidinNextBills, out decimal amoutReceived)
        {
            long returnCode = -1;
            duePaidforPreBills = -1;
            duePaidinNextBills = -1;
            amoutReceived = -1;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).CheckBilltobeCancelled(finalBillID, out duePaidforPreBills, out duePaidinNextBills, out amoutReceived);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing BL CheckBilltobeCancelled", ex);
            }

            return returnCode;
        }
        public long UpdateBillCancelled(decimal cancelledAmt, long PatientVisitID, List<AmountRefundDetails> lstAmountRefundDetails, out int returnStatus, out long CancelNo)
        {
            long returnCode = -1;
            returnStatus = -1;
            CancelNo = -1;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).UpdateBillCancelled(cancelledAmt, PatientVisitID, lstAmountRefundDetails, out returnStatus, out CancelNo);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL UpdateBillCancelled", ex);
            }
            return returnCode;
        }
        public long InsertOPBillingDetails(
                                          int orgID,

                                          List<PatientDueChart> lstConsultationDetails,
                                          List<PatientDueChart> lstPTT,
                                          List<OrderedInvestigations> lstOrderedINV,
                                          out int retstatus,
                                          long pvisitID,
                                          long pPatientID,
                                          int pOrgAddressID,
                                          int pClientID,
                                          int pCorporateID,
                                          long pCreatedBy,
                                          out long outpVisit,
                                          string sCreateTask,
                    int pReferphysicianID,
                                            int pReferspecialityID,
                                          out List<FinalBill> lstFinal, string guid)
        {
            long returnCode = -1;

            lstFinal = new List<FinalBill>();
            retstatus = 0;
            outpVisit = 0;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).InsertOPBillingDetails(
                                           orgID,

                                          lstConsultationDetails,
                                          lstPTT,
                                          lstOrderedINV,

                                          out retstatus,
                                           pvisitID,
                                           pPatientID,
                                           pOrgAddressID,
                                           pClientID,
                                           pCorporateID,
                                           pCreatedBy,
                                          out  outpVisit,
                                           sCreateTask,
                                           pReferphysicianID,
                                           pReferspecialityID,

                                          out lstFinal, guid);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while InsertOPBilling", ex);
            }
            return returnCode;
        }
        public long GetCasualtyFees(int pOrgID, out List<BillingFeeDetails> lstPBV)
        {
            long returnCode = -1;
            lstPBV = new List<BillingFeeDetails>();

            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetCasualtyFees(pOrgID, out lstPBV);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetCasualtyFees", ex);
            }

            return returnCode;
        }
        public long CreateCasualtyBillingEntry(long orgID, out long BillID, long visitID, long createdBy, List<SaveBillingDetails> lstSaveBillingDetail, int LocationID)
        {
            long returnCode = -1;
            BillID = 0;
            try
            {
                BillingDAL billingDAL = new BillingDAL(globalContextDetails);
                returnCode = billingDAL.SaveCasualtyBillingEntry(orgID, out BillID, visitID, createdBy, lstSaveBillingDetail, LocationID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing CreateCasualtyBillingEntry in BillingEngineBL", ex);
            }
            return returnCode;
        }
        public long GetPhysicianFeeDetailsReAssigned(long visitID, long physicianID, int orgID, long bdID, out List<BillingFeeDetails> lstPhysicianFees)
        {
            lstPhysicianFees = new List<BillingFeeDetails>();
            long returnCode = -1;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetPhysicianFeeDetailsReAssigned(visitID, physicianID, orgID, bdID, out lstPhysicianFees);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while BL GetPhysicianFeeDetailsReAssigned", ex);
            }
            return returnCode;
        }
        public long UpdateBillReAssigned(long visitID, decimal amtRefunded, long billDetailsID, long pLID, long pAssignedTo, out long retCode)
        {
            long returnCode = -1;
            retCode = -1;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).UpdateBillReAssigned(visitID, amtRefunded, billDetailsID, pLID, pAssignedTo, out retCode);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing BL UpdateBillReAssigned", ex);
            }

            return returnCode;
        }



        public long GetVoucherDetails(long OutFlowID, out List<CashOutFlowDetails> lstOutFlowDetails
                   , out List<CashOutFlow> lstOutFlow, string VoucherNo, string VoucherType, out List<IncSourcePaidDetails> lstCashInFlowDetails)
        {
            long returnCode = -1;
            lstOutFlowDetails = new List<CashOutFlowDetails>();
            lstOutFlow = new List<CashOutFlow>();
            lstCashInFlowDetails = new List<IncSourcePaidDetails>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetVoucherDetails(OutFlowID, out lstOutFlowDetails, out lstOutFlow, VoucherNo, VoucherType, out lstCashInFlowDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing BL UpdateBillReAssigned", ex);
            }

            return returnCode;
        }

        public long GetReceiptDetails(long visitID, long patientID, int orgID, long bdID, string receiptno, string receiptModel, out List<BillingDetails> lstBillingDetails, out List<Patient> lstPatient)
        {
            long returnCode = -1;
            lstBillingDetails = new List<BillingDetails>();
            lstPatient = new List<Patient>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetReceiptDetails(visitID, patientID, orgID, bdID, receiptno, receiptModel, out lstBillingDetails, out lstPatient);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing BL UpdateBillReAssigned", ex);
            }

            return returnCode;
        }

        public long GetRefundReceiptDetails(long visitID, int orgid, long patientID, long interpaymentID, string receiptType, out decimal amtReceived, out decimal amtRefunded, out decimal dChequeAmount, out List<BillingDetails> lstBillingDetails)
        {
            long returnCode = -1;
            amtReceived = 0;
            amtRefunded = 0;
            dChequeAmount = 0;
            lstBillingDetails = new List<BillingDetails>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetRefundReceiptDetails(visitID, orgid, patientID, interpaymentID, receiptType, out amtReceived, out amtRefunded, out dChequeAmount, out lstBillingDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing.CS", ex);
            }
            return returnCode;
        }

        public long SearchVoucherDetails(string VoucherNo, string sVouFromDate, string VouToDate, string sRecName, int OrgID, out List<CashOutFlow> lstCashOutFlow)
        {
            long returnCode = -1;
            lstCashOutFlow = new List<CashOutFlow>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).SearchVoucherDetails(VoucherNo, sVouFromDate, VouToDate, sRecName, OrgID, out lstCashOutFlow);
                foreach (CashOutFlow bill in lstCashOutFlow)
                {
                    if (bill.ReceiverType.ToUpper() == "PHY")
                    {
                        bill.ReceiverName = "Dr." + bill.ReceiverName;
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SearchReceipt BL", ex);
            }
            return returnCode;
        }
        public long GetRefundReceiptSearch(string PatientName, string refundNo, DateTime refundFromDate, DateTime refundToDate, int OrgID, int LocationID, string PatientNo, out List<FinalBill> lstFinalBillDetail)
        {
            long returnCode = -1;
            lstFinalBillDetail = new List<FinalBill>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetRefundReceiptSearch(PatientName, refundNo, refundFromDate, refundToDate, OrgID, LocationID, PatientNo, out lstFinalBillDetail);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Inventory BL GetStockRefundDetails", ex);
            }
            return returnCode;
        }

        public long pInsUpdateClientFeeTypeRateCustomize(List<ClientFeeTypeRateCustomization> pClientFeeTypeRate, long orgID)
        {
            long returnCode = -1;
            DataTable dtClientFeeTypeRate = new DataTable();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).InsUpdateClientFeeTypeRateCustomize(pClientFeeTypeRate, orgID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Inventory BL GetStockRefundDetails", ex);
            }
            return returnCode;
        }

        public long CheckIsCreditBill(long visitID,
               out decimal PaidAmount, out decimal GrossBillAmount, out decimal DueAmount,
               out string pIsCreditBill, out List<VisitClientMapping> lstVisitClientMapping)
        {
            long returnCode = -1;

            pIsCreditBill = "";
            PaidAmount = -1;
            DueAmount = -1;
            GrossBillAmount = -1;
            lstVisitClientMapping = new List<VisitClientMapping>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).CheckIsCreditBill(visitID, out PaidAmount, out GrossBillAmount, out DueAmount, out pIsCreditBill, out lstVisitClientMapping);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing BL CheckIsCreditBill", ex);
            }

            return returnCode;
        }

        public long GetQuickBillItems(int orgID, string feeType, string searchDesc, int filter, out List<BillingFeeDetails> lstBillingFeeDetails, long RateID, string vType, long VisitID, string IsMappedItem, string billPage)
        {
            long returnCode = -1;
            lstBillingFeeDetails = new List<BillingFeeDetails>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetQuickBillItems(orgID, feeType, searchDesc, filter, out lstBillingFeeDetails, RateID, vType, VisitID, IsMappedItem, billPage);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing BL - GetQuickBillItems", ex);
            }

            return returnCode;
        }


        public long InsertQuickBill(FinalBill finalBill, AmountReceivedDetails amtRD, DataTable dtAmtReceived,
            List<PatientDueChart> pPatientIndTable, List<TaxBillDetails> lstTaxDetails, Patient pdetails, decimal dserviceCharge,
            out int returnStatus, List<PatientReferringDetails> lstPatientRefDetails, List<PatientDepositUsage> lstUsage, out long FinalBillID, out string labno)
        {
            long returnCode = -1;
            returnStatus = -1;
            labno = "-1";
            FinalBillID = 0;
            //DataTable dtBillingDetails = new DataTable();
            //DataTable dtPatientRefDetails = new DataTable();
            ////Utilities.ConvertFrom(lstPatientRefDetails, out dtPatientRefDetails);
            //dtPatientRefDetails = GetPatientReferingDataTable(lstPatientRefDetails);
            //dtBillingDetails = GetDueChartDataTable(pPatientIndTable);
            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {

                    returnCode = new BillingDAL(globalContextDetails).InsertQuickBill(finalBill, amtRD, dtAmtReceived,
                        pPatientIndTable, lstTaxDetails, pdetails, dserviceCharge, out returnStatus, lstPatientRefDetails,
                        lstUsage, out FinalBillID, out labno);
                    if (returnStatus == 0)
                    {
                        if (lstUsage.Count > 0)
                        {
                            lstUsage[0].FinalBillID = FinalBillID;
                            returnCode = new BillingDAL(globalContextDetails).InsertDepositUsage(lstUsage);
                        }

                        if (returnStatus == 0 && returnCode != -1)
                        {
                            tranScope.Complete();
                        }
                        else
                        {
                            tranScope.Dispose();
                        }
                    }
                    else
                    {
                        tranScope.Dispose();
                    }
                }

                catch (Exception ex)
                {
                    CLogger.LogError("Error while Billing BL - InsertQuickBill", ex);
                    tranScope.Dispose();
                }
            }
            return returnCode;
        }

        public long GetFeeType(int orgID, string visitType, out List<FeeTypeMaster> lstFeeTypeMaster)
        {
            long returnCode = -1;
            lstFeeTypeMaster = new List<FeeTypeMaster>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetFeeType(orgID, visitType, out lstFeeTypeMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing BL - GetFeeType", ex);
            }

            return returnCode;
        }
        public long GetBillingDetails(long FinalBillID, int OrgID, out List<AmountReceivedDetails> lAmtDetails)
        {
            long returnCode = -1;
            lAmtDetails = new List<AmountReceivedDetails>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetBillingDetails(FinalBillID, OrgID, out lAmtDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL UpdateBillReAssigned", ex);
            }

            return returnCode;
        }
        public long UpdateAmountReceivedDetails(long finalBillID, List<AmountReceivedDetails> lAmtDetails)
        {
            long returnCode = -1;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).UpdateAmountReceivedDetails(finalBillID, lAmtDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL UpdateAmountReceivedDetails", ex);
            }

            return returnCode;
        }

        public long InsertBillItemDetails1(ref long patientID, ref long VisitID, int orgID, long OrgaddressID, long ReceivedBY, long CreatedBY,
                                            FinalBill FB,
                                             DataTable dtAmtReceived, List<PatientDueChart> lstDueChart,
                                            List<TaxBillDetails> lstTaxDetails, int ClientID, int RateID, long ReferedBY,
                                            int ReferedSpeciality, out long FinalBillID)
        {
            FinalBillID = -1;
            //returnStatus = -1;, string AddtoDues
            long returnCode = 0;
            //try
            //{List<Tasks> lstTasks, pdetails,Patient pdetails,lstDueDteails,List<DuePaidDetail> lstDueDteails,, , out int returnStatusout returnStatus
            returnCode = new BillingDAL(globalContextDetails).InsertBillItemDetails1(ref  patientID, ref  VisitID, ReceivedBY, CreatedBY,
                                         FB,
                                          dtAmtReceived, lstDueChart,
                                        lstTaxDetails, ClientID, RateID, ReferedBY,
                                         ReferedSpeciality, out FinalBillID);
            //}
            //catch (Exception ex)
            //{
            //    CLogger.LogError("Error in Billing DAL UpdateAmountReceivedDetails", ex);
            //}

            return returnCode;
        }

        public long InsertWriteOffPatientDue(long lPatientID, long lOrgID, long lOrgAddresID, int iVisitPurposeID, long lCreatedBy,
                                                string sFeeDescription, decimal dAmount, List<DuePaidDetail> lstDueDetail,
                                                DataTable dtAmountReceived, decimal dAmtReceived, out long lVisitID, out long lFinalID, decimal dserviceCharge)
        {
            long lResult = -1;
            lVisitID = 0;
            lFinalID = 0;
            DataTable dtDueDetail = new DataTable();

            lResult = new BillingDAL(globalContextDetails).InsertWriteOffPatientDue(lPatientID, lOrgID, lOrgAddresID, iVisitPurposeID, lCreatedBy,
                                                sFeeDescription, dAmount, lstDueDetail,
                                                dtAmountReceived, dAmtReceived, out lVisitID, out lFinalID, dserviceCharge);

            return lResult;
        }


        public long InsertPatientAndVisit(ref long patientID, ref long VisitID, ref string pPatientNo, long ReceivedBY,
                                           List<PatientDueChart> lstDueChart, Patient pdetails,
                                           long pCreatedBy, int ReferedSpeciality, int OrgID, int OrgAddressID, int AgeValue,
                                            string AgeUnit, long pSpecialityID, string ReferralType, string picExtension, List<VisitClientMapping> lstVisitClientMapping)
        {

            long returnCode = 0;
            try
            {//List<Tasks> lstTasks, pdetails,Patient pdetails,lstDueDteails,List<DuePaidDetail> lstDueDteails,, , out int returnStatusout returnStatus
                returnCode = new BillingDAL(globalContextDetails).InsertPatientAndVisit(ref  patientID, ref  VisitID, ref pPatientNo, ReceivedBY,
                                         lstDueChart, pdetails, pCreatedBy, ReferedSpeciality, OrgID, OrgAddressID, AgeValue,
                                         AgeUnit, pSpecialityID, ReferralType, picExtension, lstVisitClientMapping);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL UpdateAmountReceivedDetails", ex);
            }

            return returnCode;
        }

        public long GetPatientBillingDetails(long PatientID, long PatientVisitID, string filterTxt, out List<PatientDueChart> lPatDuechart, out List<BillingDetails> lPatBillingDetails)
        {
            long returnCode = -1;
            lPatBillingDetails = new List<BillingDetails>();
            lPatDuechart = new List<PatientDueChart>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetPatientBillingDetails(PatientID, PatientVisitID, filterTxt, out lPatDuechart, out lPatBillingDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetPatientBillingDetails in BillingEngine", ex);
            }
            return returnCode;

        }
        public long UpdateBillingDetails(long billingDetailsID, long PatientDueChartID, long ReferingPhyID, string ReferingPhyName)
        {
            long returnCode = -1;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).UpdateBillingDetails(billingDetailsID, PatientDueChartID, ReferingPhyID, ReferingPhyName);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in UpdateBillingDetails in BillignEngine", ex);
            }
            return returnCode;
        }


        public long GetNonReimbursableItems(int orgID, string feeType, string searchDesc, out List<BillingFeeDetails> lstBillingFeeDetails)
        {
            long returnCode = -1;
            lstBillingFeeDetails = new List<BillingFeeDetails>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetNonReimbursableItems(orgID, feeType, searchDesc, out lstBillingFeeDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing BL - GetNonReimbursableItems", ex);
            }

            return returnCode;
        }

        public long InsertPatientDueChart(List<PatientDueChart> lstPatientDueChart,
           List<OrderedInvestigations> pInvestigationHL, int OrgID, string SitingTypes, long visitID,
           long patientID, long CreatedBy, string GuID, out List<OrderedInvestigations> lstOrderedInv,
           List<PatientReferringDetails> lstPatientRefDetails, out string InterimBillNo, out string labno, string IsAddServices,
         long ClientID
           )
        {

            long returncode = -1;
            InterimBillNo = "-1";
            labno = "-1";
            lstOrderedInv = new List<OrderedInvestigations>();
            try
            {

                returncode = new BillingDAL(globalContextDetails).InsertPatientDueChart(lstPatientDueChart, pInvestigationHL, OrgID, SitingTypes, visitID, patientID, CreatedBy, GuID, out lstOrderedInv, lstPatientRefDetails, out InterimBillNo, out labno, IsAddServices, ClientID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing BL - InsertPatientDueChart", ex);
            }
            return returncode;


        }

        public long InsertPatientMakePayment(FinalBill objfinalBill, DataTable dtAmountReceived, AmountReceivedDetails amtRD, List<PatientDueChart> lstPatientDueChart,
            List<OrderedInvestigations> pInvestigationHL, int OrgID, string SitingTypes, long visitID,
            long patientID, long CreatedBy, string GuID,
            out List<OrderedInvestigations> lstOrderedInv,
            out string ReceiptNo, out long IpIntermediateID, out string sPaymentType, List<PatientReferringDetails> lstPatientRefDetails,
            out string labno, long ClientID)
        {

            IpIntermediateID = 0;
            sPaymentType = "";
            ReceiptNo = "";
            long returncode = -1;
            labno = "-1";
            lstOrderedInv = new List<OrderedInvestigations>();
            try
            {
                string InterimBillNo = "";
                returncode = new BillingDAL(globalContextDetails).InsertPatientMakePayment(objfinalBill, dtAmountReceived, amtRD, lstPatientDueChart, pInvestigationHL,
                OrgID, SitingTypes, visitID, patientID, CreatedBy, GuID, out lstOrderedInv, out ReceiptNo, out IpIntermediateID,
                                                                    out sPaymentType, lstPatientRefDetails, out InterimBillNo, out labno, ClientID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing BL - InsertPatientMakePayment", ex);
            }

            return returncode;

        }
        public long GetPatientPaymentDetails(long patientVisitID, long patientID, int orgID, out List<FinalBill> lstPatientDueChart)
        {
            long returncode = -1;
            lstPatientDueChart = new List<FinalBill>();
            try
            {
                returncode = new BillingDAL(globalContextDetails).GetPatientPaymentDetails(patientVisitID, patientID, orgID,
                                                                    out lstPatientDueChart);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing BL - GetPatientPaymentDetails", ex);
            }
            return returncode;
        }
        public long InsertCashInFlow(string SourceTypeCode, string referenceID, DataTable dtAmtReceived, string Remarks
            , long CreatedBy, int OrgID, out string ReceiptNo)
        {
            long returnCode = -1;
            ReceiptNo = string.Empty;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).InsertCashInFlow(SourceTypeCode, referenceID, dtAmtReceived, Remarks, CreatedBy, OrgID, out ReceiptNo);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in InsertCashInFlow method(Billing Engine)", ex);
            }
            return returnCode;
        }

        public long GetPharmacyConsolidate(long patientVisitID, out List<BillingDetails> lstBillingDetails)
        {
            long returnCode = -1;
            lstBillingDetails = new List<BillingDetails>();


            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetPharmacyConsolidate(patientVisitID, out lstBillingDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetFinalBillDetail", ex);
            }
            return returnCode;
        }
        public long GetRefundDetailForTask(int OrgID, string ReceiptNo, long PatientiVisitID, out List<BillingDetails> lstBillingDetails, out List<FinalBill> lstAmountRefund)
        {
            long returnCode = -1;
            lstAmountRefund = new List<FinalBill>();
            lstBillingDetails = new List<BillingDetails>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetRefundDetailForTask(OrgID, ReceiptNo, PatientiVisitID, out lstBillingDetails, out lstAmountRefund);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Excuting BillingEngine - GetRefundDetailForTask", ex);
            }
            return returnCode;
        }
        public long UpdateRefundDetails(int OrgID, string RefFlag, string ReceiptNo, long RefundBy, string RefundStatus, long TaskModifiedBy, string TaskRejectionDetail, System.Data.DataTable dtSaveApprovedAmt)
        {
            long returnCode = -1;

            try
            {
                returnCode = new BillingDAL(globalContextDetails).UpdateRefundDetails(OrgID, RefFlag, ReceiptNo, RefundBy, RefundStatus, TaskModifiedBy, TaskRejectionDetail, dtSaveApprovedAmt);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing BL UpdateBillReAssigned", ex);
            }

            return returnCode;
        }
        public long GetPaymentType(long OrgID, out List<PaymentType> lstPaymentType)
        {
            long returnCode = -1;
            lstPaymentType = new List<PaymentType>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetPaymentType(OrgID, out lstPaymentType);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetPaymentType BL", ex);
            }
            return returnCode;
        }
        public long GetSourcePaidDetails(int OrgID, int cshMasterID, out List<IncSourcePaidDetails> SrcPaidDetails)
        {
            long returnCode = -1;
            SrcPaidDetails = new List<IncSourcePaidDetails>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetSourcePaidDetails(OrgID, cshMasterID, out SrcPaidDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetSourcePaidDetails(billing Engine)", ex);
            }



            return returnCode;
        }
        public long UpdateSourcePaidDetails(long paidDetID, long SourceTypeID, string referenceID, decimal ReceivedAmt, int RecCurID,
          decimal RecCurValue, int paymentTypeID, string PaymentType, string ChequeNo, string BankName, string Description
          , int BaseCurrencyID, long modifiedBy, int OrgID)
        {
            long returnCode = -1;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).UpdateSourcePaidDetails(paidDetID, SourceTypeID, referenceID, ReceivedAmt, RecCurID, RecCurValue,
                                                paymentTypeID, PaymentType, ChequeNo, BankName, Description, BaseCurrencyID, modifiedBy, OrgID);
            }
            catch (Exception ex)
            {

                CLogger.LogError("Error in UpdateSourcePaidDetails(billing Engine)", ex);
            }
            return returnCode;
        }
        public long GetPaymentMode(long FinalBillID, long VisitID, string ReceiptNo, int payingPage, out List<PaymentType> lstPaymentMode, out List<PaymentType> lstOtherCurrency, out List<PaymentType> lstDepositAmt)
        {
            long returnCode = -1;
            lstPaymentMode = new List<PaymentType>();
            lstOtherCurrency = new List<PaymentType>();
            lstDepositAmt = new List<PaymentType>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetPaymentMode(FinalBillID, VisitID, ReceiptNo, payingPage, out lstPaymentMode, out lstOtherCurrency, out lstDepositAmt);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing BillingEngine_GetPaymentMode", ex);
            }
            return returnCode;
        }
        public long GetIPBalanceForVisit(long PatientID, out List<FinalBill> lstDue)
        {
            long returnCode = -1;
            lstDue = new List<FinalBill>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetIPBalanceForVisit(PatientID, out lstDue);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing BillingEngine_GetIPBalanceForVisit", ex);
            }
            return returnCode;
        }

        public long GetQuickBillingDetails(int OrgID, string LoanguageCode, out List<Salutation> lstTitles, out List<VisitPurpose> lstVisitPurpose, out List<Country> lstNationality, out List<Country> lstCountries)
        {
            long returnCode = -1;
            lstTitles = new List<Salutation>();
            lstVisitPurpose = new List<VisitPurpose>();
            lstNationality = new List<Country>();
            lstCountries = new List<Country>();

            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetQuickBillingDetails(OrgID, LoanguageCode, out lstTitles, out lstVisitPurpose, out lstNationality, out lstCountries);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing GetQuickBillingDetails", ex);
            }
            return returnCode;
        }

        public long GetRateSubVisitTypeDetails(int OrgID, string pType, out List<RateSubTypeMapping> lstRateSubTypeMapping)
        {
            long returnCode = -1;
            lstRateSubTypeMapping = new List<RateSubTypeMapping>();

            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetRateSubVisitTypeDetails(OrgID, pType, out lstRateSubTypeMapping);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing GetRateSubVisitTypeDetails", ex);
            }
            return returnCode;
        }

        public long UpdateServiceCodeForBill(List<BillingDetails> lstBillingDetails)
        {
            long returnCode = -1;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).UpdateServiceCodeForBill(lstBillingDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while UpdateServiceCodeForBill", ex);
            }
            return returnCode;
        }


        public long GetInterimBillDetails(string patientNumber, string PatientName, string InterimBillNo, string FromDate, string ToDate, int orgID, string FeeType, out List<PatientDueChart> lstPatientDuechart)
        {
            long returnCode = -1;

            lstPatientDuechart = new List<PatientDueChart>();
            //lstPatientVisit = new List <PatientVisit>();
            //lstPatient = new List<Patient>();


            //finalBillID = -1;
            //VisitType = "";
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetInterimBillDetails(patientNumber, PatientName, InterimBillNo, FromDate, ToDate, orgID, FeeType, out lstPatientDuechart);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetDueDetail in BillingEngineBl", ex);
            }
            return returnCode;
        }
        public long PatientDepositSearch(string pPatientNo, string pPatientName, DateTime FromDate, DateTime ToDate, int OrgID, out  List<Patient> lstPatient)
        {
            long returnCode = -1;
            lstPatient = new List<Patient>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).PatientDepositSearch(pPatientNo, pPatientName, FromDate, ToDate, OrgID, out lstPatient);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetPatientDepositDetailsRpt", ex);
            }
            return returnCode;
        }

        public long pInsertDepositRefund(long pDepositID, long pPatientID, string pPatientName, string pPaymentType,
                                    decimal pAmountRefund,
                                    DateTime pDateFrom, string pRemarks, string pStatus,
                                    int pCreatedBy, int pOrgID, DataTable dtAmountReceived, decimal pServiceCharge,
                                    out string VouNo, out long OutFlowID, long pOrgAddressID)
        {
            long returnCode = -1;
            VouNo = "";
            OutFlowID = 0;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).pInsertDepositRefund(pDepositID, pPatientID, pPatientName, pPaymentType,
                                                                pAmountRefund, pDateFrom, pRemarks, pStatus, pCreatedBy,
                                                                pOrgID, dtAmountReceived, pServiceCharge,
                                                                out VouNo, out OutFlowID, pOrgAddressID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Inserting InsertCashFlow", ex);
            }
            return returnCode;
        }


        public long GetGenerateBillReceipt(long VisitID, int OrgID, out List<BillSearch> lstDetails)
        {
            long returnCode = -1;
            lstDetails = new List<BillSearch>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetGenerateBillReceipt(VisitID, OrgID, out lstDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetGenerateBillReceipt Billing.CS", ex);
            }
            return returnCode;
        }
        public long InsertINVRefundAmt(long PatientVisitID, decimal RefundAmt, int paymentType, long ChequeNumber, string BankName, string RefundReason, long CreatedBy, int OrgID, out string RefundNo, out long FinalBillID, out string PatientName)
        {
            long returnCode = -1;
            RefundNo = "-1";
            FinalBillID = -1;
            PatientName = string.Empty;
            try
            {

                BillingDAL bd = new BillingDAL(globalContextDetails);
                returnCode = bd.InsertINVRefundAmt(PatientVisitID, RefundAmt, paymentType, ChequeNumber, BankName, RefundReason, CreatedBy, OrgID, out RefundNo, out FinalBillID, out PatientName);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL insertAmtRefundDetails", ex);
            }
            return returnCode;
        }

        public long getpatientduedetails(string PatientNo, string BillNo, string PatientName, int OrgID, long PtientID, DateTime FromDate, DateTime ToDate, string pLocation, string pVisitNumber, out List<PatientDueDetails> DueDetails)
        {
            long returnCode = -1;
            DueDetails = new List<PatientDueDetails>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetPatientDueDetails(PatientNo, BillNo, PatientName, OrgID, PtientID, FromDate, ToDate, pLocation, pVisitNumber, out DueDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetPatientDueDetails Billing.CS", ex);
            }
            return returnCode;
        }
        public long GetInpatientDueDetails(long PatientID, long visitID, int OrgID, out List<PatientDueDetails> lstPatientDue)
        {
            long returnCode = -1;
            lstPatientDue = new List<PatientDueDetails>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetInpatientDueDetails(PatientID, visitID, OrgID, out lstPatientDue);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetPatientDueDetails Billing.CS", ex);
            }
            return returnCode;
        }


        public long SavePatientDueDetails(long PatientID, long lOrgID, long lOrgAddresID, int iVisitPurposeID, long lCreatedBy,
                                                          string sFeeDescription, decimal dAmount, List<DuePaidDetail> lstDueDetail,
                                                          DataTable dtAmountReceived, decimal dAmtReceived, long ReceivedBy,
                      long lVisitID, long lFinalID, decimal dserviceCharge, List<PatientDueDetails> lstPatientDueDetails,
                      List<PatientDepositUsage> lstUsage, out string Billnumber, out long PatientVID, string DiscountReason, 
            long DiscountAuthorisedBy, out List<BillingDetails> lstBillingdetails,out String ReceiptNo)
        {
            long lResult = -1;
            lstBillingdetails = new List<BillingDetails>();
            //DataTable dtDueDetail = new DataTable();
            //DataTable dtpatientDue = new DataTable();
            //dtpatientDue = GetPatientDueDetails(lstPatientDueDetails);
            //lResult = new BillingDAL(globalContextDetails).SavePatientDueDetails(PatientID, lOrgID, lOrgAddresID, iVisitPurposeID, lCreatedBy,
            //                                    sFeeDescription, dAmount, lstDueDetail,
            //                                    dtAmountReceived, dAmtReceived, lCreatedBy, lVisitID, lFinalID, dserviceCharge, dtpatientDue, out Billnumber);
            Billnumber = "-1";
            PatientVID = -1;
            ReceiptNo = "-1";
            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {

                    lResult = new BillingDAL(globalContextDetails).SavePatientDueDetails(PatientID, lOrgID, lOrgAddresID, iVisitPurposeID, lCreatedBy,
                                                sFeeDescription, dAmount, lstDueDetail,
                                                dtAmountReceived, dAmtReceived, lCreatedBy, lVisitID, lFinalID, dserviceCharge, lstPatientDueDetails, out Billnumber, out PatientVID, DiscountReason, DiscountAuthorisedBy, out lstBillingdetails, out ReceiptNo);
                    if (lResult >= 0)
                    {
                        if (lstUsage.Count > 0)
                        {
                            lstUsage[0].FinalBillID = Convert.ToInt32(Billnumber);
                            lResult = new BillingDAL(globalContextDetails).InsertDepositUsage(lstUsage);
                        }

                        if (lResult >= 0 && lResult != -1)
                        {
                            tranScope.Complete();
                        }
                        else
                        {
                            tranScope.Dispose();
                        }
                    }
                    else
                    {
                        tranScope.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    CLogger.LogError("Error while Billing BL - SavePatientDueDetails", ex);
                    tranScope.Dispose();
                }
            }

            return lResult;
        }


        public long PatientDueResult(long PatientDueID, string BillNo, out List<PatientDueDetails> lstDueDetails)
        {
            long returnCode = -1;
            lstDueDetails = new List<PatientDueDetails>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).PatientDueResult(PatientDueID, BillNo, out lstDueDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in PatientDueResult Billing.CS", ex);
            }
            return returnCode;
        }

        public long InsertOpDuedetails(List<PatientDueDetails> lstOPDueDetails)
        {
            long returnCode = -1;

            try
            {

                returnCode = new BillingDAL(globalContextDetails).InsertOpDuedetails(lstOPDueDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in InsertOpDuedetails Billing.CS", ex);
            }
            return returnCode;
        }

        public long GetDuePaymentMode(long FinalBillID, long OrgId, out List<PaymentType> lstPaymentMode, out List<PaymentType> lstOtherCurrency)
        {
            long returnCode = -1;
            lstPaymentMode = new List<PaymentType>();
            lstOtherCurrency = new List<PaymentType>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetDuePaymentMode(FinalBillID, OrgId, out lstPaymentMode, out lstOtherCurrency);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing BillingEngine_GetDuePaymentMode", ex);
            }
            return returnCode;
        }
        public long GetRefundVoucherPrint(string FinalBillID, string RefundNo, int OrgID, out List<BillingDetails> lstBillingDetails, out List<AmountRefundDetails> lstAmountRefundDetails, out List<Patient> lstPatient)
        {
            long returnCode = -1;
            lstBillingDetails = new List<BillingDetails>();
            lstAmountRefundDetails = new List<AmountRefundDetails>();
            lstPatient = new List<Patient>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetRefundVoucherPrint(FinalBillID, RefundNo, OrgID, out lstBillingDetails, out lstAmountRefundDetails, out lstPatient);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetRefundVoucherPrint Billing.CS", ex);
            }
            return returnCode;
        }
        public long GetCreditDueItem(long VisitID, long OrgID, long PatientID, string ReceiptNo, out List<DueClearanceReference> lstDueClearanceReference)
        {
            long returnCode = -1;
            lstDueClearanceReference = new List<DueClearanceReference>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetCreditDueItem(VisitID, OrgID, PatientID, ReceiptNo, out lstDueClearanceReference);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in PatientDueResult Billing.CS", ex);
            }
            return returnCode;
        }
        public long GetCoPaymentReceipt(long VisitID, int OrgID, out List<BillSearch> lstDetails)
        {
            long returnCode = -1;
            lstDetails = new List<BillSearch>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetCoPaymentReceipt(VisitID, OrgID, out lstDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetGenerateBillReceipt Billing.CS", ex);
            }
            return returnCode;
        }

        public long GetUserIDs(long OrgID, out List<Users> lstuserIDs)
        {

            long returnCode = -1;
            lstuserIDs = new List<Users>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetUserIDs(OrgID, out lstuserIDs);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing.CS", ex);
            }
            return returnCode;

        }


        //public long InsertPatientEpisodeMapping(long patientID,long patientVisitID,long EpisodeId,long LID,int OrgID,string VisitTypes)
        //{
        //    long returncode = -1;
        //    try
        //    {
        //        returncode = new BillingDAL(globalContextDetails).InsertPatientEpisodeMapping(patientID, patientVisitID, EpisodeId, LID, OrgID, VisitTypes);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error in Billing.CS", ex);
        //    }
        //    return returncode;
        //}
        public long GetCashClosureDenominationMaster(int OrgID, out List<CashClosureDenominationMaster> lstCCDeno)
        {

            long returnCode = -1;
            lstCCDeno = new List<CashClosureDenominationMaster>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetCashClosureDenominationMaster(OrgID, out lstCCDeno);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  GetCashClosureDenominationMaster BillingEngine.CS", ex);
            }
            return returnCode;

        }
        public long InsertCashClosureDenomination(int OrgID, List<CashClosureDenomination> lstCCDeno, long CreatedBy, decimal TotalCCAmt, out string ClosureID)
        {
            long returnCode = -1;
            ClosureID = "-1";
            try
            {
                returnCode = new BillingDAL(globalContextDetails).InsertCashClosureDenomination(OrgID, lstCCDeno, CreatedBy, TotalCCAmt, out ClosureID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in InsertCashClosureDenomination Billing.CS", ex);
            }
            return returnCode;
        }
        public long GetCCDenominationDetail(string ClosureID, int OrgID, long CreatedBy, out List<CashClosureDenomination> lstCCDeno)
        {

            long returnCode = -1;
            lstCCDeno = new List<CashClosureDenomination>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetCCDenominationDetail(ClosureID, OrgID, CreatedBy, out lstCCDeno);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  GetCCDenominationDetail BillingEngine.CS", ex);
            }
            return returnCode;

        }
        public long GetBillSnapShot(long PatientID, long VisitID, int OrgID, out List<FinalBill> lstBillDetails)
        {

            long returnCode = -1;
            lstBillDetails = new List<FinalBill>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetBillSnapShot(PatientID, VisitID, OrgID, out lstBillDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  GetBillSnapShot BillingEngine.CS", ex);
            }
            return returnCode;

        }
        public long GetIsAllMedicalFlagofVisit(long VisitID, out string IsAllMedical)
        {
            long returnCode = -1;
            IsAllMedical = "";
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetIsAllMedicalFlagofVisit(VisitID, out IsAllMedical);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  GetIsAllMedicalFlagofVisit BillingEngine.CS", ex);
            }
            return returnCode;

        }
        public long InsertCorporteBill(long PatientID, long VisitID, int RateID, decimal GrossValue, decimal NetValue,
            List<PatientDueChart> lstDueChart, long CreatedBy, int OrgID, long refPhyID, long refSpecialityID,
            long SpecialityID, string refPhyName, long OrgAddressID, List<PatientReferringDetails> lstPatientRefDetails, string IsCreditBill, out string labno, out int returnStatus, string IsFreeOfCost, int visitpurposeID)
        {
            long returnCode = -1;
            returnStatus = -1;
            labno = "";

            try
            {

                returnCode = new BillingDAL(globalContextDetails).InsertCorporteBill(PatientID,
                                 VisitID, RateID, GrossValue, NetValue, lstDueChart,
                                 CreatedBy, OrgID, refPhyID, refSpecialityID, SpecialityID,
                                 refPhyName, OrgAddressID, lstPatientRefDetails, IsCreditBill,
                                 out labno, out returnStatus, IsFreeOfCost, visitpurposeID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Billing BL - InsertCorporteBill", ex);

            }
            return returnCode;
        }
        public long InsertIPReferringDetails(int OrgID, long patientVisitID, long IPrefPhyID, int IPrefSpecialityID, string IPrefPhyName, string IReferralType)
        {
            long returnCode = -1;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).InsertIPReferringDetails(OrgID, patientVisitID, IPrefPhyID, IPrefSpecialityID, IPrefPhyName, IReferralType);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  InsertIPReferringDetails BillingEngine.CS", ex);
            }
            return returnCode;

        }
        public long PgetTaskDetailsforvisit(long patientVisitID, int OrgID, out List<TaskDetails> lsttaskdtails)
        {
            long returnCode = -1;
            lsttaskdtails = new List<TaskDetails>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).PgetTaskDetailsforvisit(patientVisitID, OrgID, out lsttaskdtails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  PgetTaskDetailsforvisit BillingEngine.CS", ex);
            }
            return returnCode;

        }
        public long pInsertCorporteInvBilling(string Guid, long patientID, long patientVisitID, long createdBy, int OrgID, int AOrgID, out string Labno, out int returnStatus)
        {
            long returnCode = -1;
            Labno = "";
            returnStatus = -1;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).pInsertCorporteInvBilling(Guid, patientID, patientVisitID, createdBy, OrgID, AOrgID, out Labno, out returnStatus);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  pInsertCorporteInvBilling BillingEngine.CS", ex);
            }
            return returnCode;

        }
        public long UpdatedTaskIDinBillingDetails(long PatientID, long VisitID, List<PatientDueChart> lstBillingDetails, long CreatedBy, int OrgID)
        {
            long returnCode = -1;

            try
            {

                returnCode = new BillingDAL(globalContextDetails).UpdatedTaskIDinBillingDetails(PatientID, VisitID, lstBillingDetails, CreatedBy, OrgID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Billing BL - UpdatedTaskIDinBillingDetails", ex);

            }
            return returnCode;
        }
        public long GetRefunStatus(long visitID, long OrgID, string LabNo, out List<RefundReasonMaster> RfdReasion, out List<OrderedInvestigations> OrdInvStatus)
        {
            long returnCode = -1;

            RfdReasion = new List<RefundReasonMaster>();
            OrdInvStatus = new List<OrderedInvestigations>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetRefunStatus(visitID, OrgID, LabNo, out RfdReasion, out OrdInvStatus);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing.CS", ex);
            }
            return returnCode;
        }

        public long BillingAuthorisedBy(string Name, int OrgID, string Types, out List<BillingAuthorisedBy> AuthorisedBy)
        {
            long returnCode = -1;

            AuthorisedBy = new List<BillingAuthorisedBy>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).BillingAuthorisedBy(Name, OrgID, Types, out AuthorisedBy);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing.CS", ex);
            }
            return returnCode;
        }
        public long GetTransactionByType(DateTime FDate, DateTime TDate, int OrgID, DataTable LoginIDs, string Type, out List<ReceivedAmount> lstBillingDetails)
        {
            long returnCode = -1;
            lstBillingDetails = new List<ReceivedAmount>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetTransactionByType(FDate, TDate, OrgID, LoginIDs, Type, out lstBillingDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing.CS", ex);
            }

            return returnCode;

        }
        public long GetAmountReceivedDetailsForDaily(long UserID, int OrgId, DateTime pFDT, DateTime pTDT, int CurrencyID, int locationId, out List<ReceivedAmount> lstAmountReceivedDetails, out List<ReceivedAmount> lstRefundDetails, out List<ReceivedAmount> lstPaymentDetails, out decimal dTotalAmount, out decimal dTotalRefund, out decimal dTotalCancelledAmt, out decimal dtAmount, out decimal othersAmount, out decimal TotalPendingDue, out List<ReceivedAmount> lstINDAmtReceivedDetails, out List<ReceivedAmount> lstIPINDAmtReceivedDetails, out List<DayWiseCollectionReport> lstDayWise, out List<ReceivedAmount> lstRcvdUserSplitup, DataTable dtUserIDs, out List<ReceivedAmount> lstCollections, out List<AmountReceivedDetails> lstIncSourcePaidDetails, out decimal TotalIncAmount)
        {
            long returnCode = -1;
            lstAmountReceivedDetails = new List<ReceivedAmount>();
            lstRefundDetails = new List<ReceivedAmount>();
            lstPaymentDetails = new List<ReceivedAmount>();
            lstINDAmtReceivedDetails = new List<ReceivedAmount>();
            lstIPINDAmtReceivedDetails = new List<ReceivedAmount>();
            lstDayWise = new List<DayWiseCollectionReport>();
            lstRcvdUserSplitup = new List<ReceivedAmount>();
            lstCollections = new List<ReceivedAmount>();
            lstIncSourcePaidDetails = new List<AmountReceivedDetails>();
            dTotalAmount = 0;
            dTotalRefund = 0;
            dTotalCancelledAmt = 0;
            dtAmount = 0;
            othersAmount = 0;
            TotalPendingDue = 0;
            TotalIncAmount = 0;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetAmountReceivedDetailsForDaily(UserID, OrgId, pFDT, pTDT, CurrencyID, locationId, out lstAmountReceivedDetails, out lstRefundDetails, out lstPaymentDetails, out dTotalAmount, out dTotalRefund, out dTotalCancelledAmt, out dtAmount, out othersAmount, out TotalPendingDue, out lstINDAmtReceivedDetails, out lstIPINDAmtReceivedDetails, out lstDayWise, out lstRcvdUserSplitup, dtUserIDs, out lstCollections, out lstIncSourcePaidDetails, out  TotalIncAmount);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing.CS", ex);
            }
            return returnCode;
        }

        public long GetInvoiceGeneration(long InvoiceID, long ClientID, int OrgID, int OrgAdd, DateTime FDate, DateTime TDate, int RejBills, out List<BillingDetails> lstInvoiceBill, out List<DiscountPolicy> lstVolumeDiscount, out List<CreditDebitSummary> lstCreditDebit)
        {
            long returnCode = -1;
            lstInvoiceBill = new List<BillingDetails>();
            lstVolumeDiscount = new List<DiscountPolicy>();
            lstCreditDebit = new List<CreditDebitSummary>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetInvoiceGeneration(InvoiceID, ClientID, OrgID, OrgAdd, FDate, TDate, RejBills, out lstInvoiceBill, out lstVolumeDiscount, out lstCreditDebit);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing.CS", ex);
            }

            return returnCode;

        }


        public long SaveInvoiceBill(decimal GrsAmt, string Discount, string DisReason, decimal Netamt, long CreateBy, string Tax, long ClientID, int OrgID, int OrgAdd, long FinalBillID, List<Invoice> lstInvoice, DateTime FromDate, DateTime ToDate, decimal TOD, long ScID, string Status, PageContextkey PageContextDetails, long ApporverID, long InvcID, string TaskStatus, decimal VolumeDiscountAmt, out long InvoiceID, string Type)
        {
            long returnCode = -1;
            InvoiceID = -1;
            try
            {

                BillingDAL Billing_Dal = new BillingDAL(globalContextDetails);
                returnCode = Billing_Dal.SaveInvoiceBill(GrsAmt, Discount, DisReason, Netamt, CreateBy, Tax, ClientID, OrgID, OrgAdd, FinalBillID, lstInvoice, FromDate, ToDate, TOD, ScID, Status, ApporverID, InvcID, TaskStatus, VolumeDiscountAmt, out InvoiceID, Type);
                if (returnCode >= 0)
                {

                    PageContextDetails.PatientID = InvoiceID;
                    ActionManager objActionManager = new ActionManager();
                    objActionManager.PerformingNextStep(PageContextDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL SaveInvoiceBill", ex);
            }
            return returnCode;
        }
        public long SaveInvoiceBillByService(long CreateBy, long ClientID, int OrgID, int OrgAdd, DateTime FromDate, DateTime ToDate, string AddContext, out long InvoiceID, out string InvoiceNumber)
        {
            long returnCode = -1;
            InvoiceID = -1;
            InvoiceNumber = "-1";
            try
            {

                BillingDAL Billing_Dal = new BillingDAL(globalContextDetails);
                returnCode = Billing_Dal.SaveInvoiceBillByService(CreateBy, ClientID, OrgID, OrgAdd, FromDate, ToDate, AddContext, out InvoiceID, out InvoiceNumber);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL SaveInvoiceBill", ex);
            }
            return returnCode;
        }

        public long GetInvoicePrinting(long InvoiceID, long OrgID, long OrgAdd, out List<Invoice> lstInvoice, out List<BillingDetails> lstInvoiceBill)
        {
            long returnCode = -1;
            lstInvoice = new List<Invoice>();
            lstInvoiceBill = new List<BillingDetails>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetInvoicePrinting(InvoiceID, OrgID, OrgAdd, out lstInvoice, out lstInvoiceBill);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing.CS - GetInvoicePrinting", ex);
            }

            return returnCode;


        }



        public long LoadDesignations(int OrgID, out List<DesignationMaster> lstDesignations)
        {
            long returnCode = -1;
            lstDesignations = new List<DesignationMaster>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).LoadDesignations(OrgID, out lstDesignations);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing.CS - LoadDesignations", ex);
            }

            return returnCode;


        }
        public long GetRateCardForBilling(string SearchText, long OrgID, string Type, long refhospid, out List<InvClientMaster> lstClients)
        {
            long returnCode = -1;
            lstClients = new List<InvClientMaster>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetRateCardForBilling(SearchText, OrgID, Type, refhospid, out lstClients);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetRateCardForBilling in BillingEngine.cs", ex);
            }
            return returnCode;
        }
        public long pGetCorporateRefundBillingDetails(long visitID, out List<BillingDetails> lstBillingDetails, out decimal amtReceived, out decimal amtRefunded, out decimal dChequeAmount, long FinalBillID, long billDetailsID)
        {
            long returnCode = -1;
            amtReceived = 0;
            amtRefunded = 0;
            dChequeAmount = 0;
            lstBillingDetails = new List<BillingDetails>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).pGetCorporateRefundBillingDetails(visitID, out lstBillingDetails, out amtReceived, out amtRefunded, out dChequeAmount, FinalBillID, billDetailsID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing.CS", ex);
            }
            return returnCode;
        }

        public long inserCorporatetAmtRefundDetails(long PatientVisitID, FinalBill finalBill, List<AmountRefundDetails> lstAmountRefundDetails, out int returnstatus, out string ReceiptNo, out string RefundNo, int RefundStatus)
        {
            long returnCode = -1;
            returnstatus = -1;
            ReceiptNo = "";
            RefundNo = "";
            try
            {

                BillingDAL bd = new BillingDAL(globalContextDetails);
                returnCode = bd.inserCorporatetAmtRefundDetails(PatientVisitID, finalBill, lstAmountRefundDetails, out returnstatus, out ReceiptNo, out RefundNo, RefundStatus);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL insertAmtRefundDetails", ex);
            }
            return returnCode;
        }

        public long GetLabQuickBillPatientList(string pName, string pVisitType, int pOrgID, int searchType, long PatientID, out List<Patient> lstPatientDetails)
        {
            long returnCode = -1;
            lstPatientDetails = new List<Patient>();
            BillingDAL billDAL = new BillingDAL(globalContextDetails);
            try
            {
                returnCode = billDAL.GetLabQuickBillPatientList(pName, pVisitType, pOrgID, searchType, PatientID, out lstPatientDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetLabQuickBillPatientList in Billing Engine", ex);
            }
            return returnCode;
        }
        public long GetLabQuickBillPatientList_Quantum(string pName, string pVisitType, int pOrgID, int searchType, long PatientID, string ExtVisitID, out List<Patient> lstPatientDetails)
        {
            long returnCode = -1;
            lstPatientDetails = new List<Patient>();
            BillingDAL billDAL = new BillingDAL(globalContextDetails);
            try
            {
                returnCode = billDAL.GetLabQuickBillPatientList_Quantum(pName, pVisitType, pOrgID, searchType, PatientID, ExtVisitID, out lstPatientDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetLabQuickBillPatientList in Billing Engine", ex);
            }
            return returnCode;
        }
        public long RegistrationRepush(int OrgId, out List<RegistrationRepush> lsRepush)
        {
            long returnCode = -1;
            lsRepush = new List<RegistrationRepush>();
            BillingDAL billDAL = new BillingDAL(globalContextDetails);
            try
            {
                returnCode = billDAL.RegistrationRepush(OrgId, out lsRepush);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing RegistrationRepush in Billing Engine", ex);
            }
            return returnCode;
        }


        public long getClientInvoiceDetails(long ClientID, long InvoiceNo, int OrgID, out List<Invoice> lstInvoice)
        {
            long returnCode = -1;

            lstInvoice = new List<Invoice>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).getClientInvoiceDetails(Convert.ToInt64(ClientID), Convert.ToInt64(InvoiceNo), OrgID, out lstInvoice);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing.CS", ex);
            }

            return returnCode;

        }

        public long SearchInvoice(string InvoiceNo, int OrgID, int OrgAdd, DateTime FDate, DateTime TDate, out List<Invoice> lstInvoice, int pageSize, int StartRowIndex, out int totalRows, int businessTypeID, int ClientID,string InvoiceType)
        {
            long returnCode = -1;
            totalRows = 0;
            lstInvoice = new List<Invoice>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).SearchInvoice(InvoiceNo, OrgID, OrgAdd, FDate, TDate, out lstInvoice, pageSize, StartRowIndex, out totalRows, businessTypeID, ClientID, InvoiceType);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing.CS", ex);
            }

            return returnCode;

        }

        public long GetInvoicePayments(List<Invoice> lstinvoice, int orgID,string type, out List<Invoice> lstInvoicePayments, out List<InvoiceReceipts> lstInvoicepayments)
        {
            long returnCode = -1;
            lstInvoicePayments = new List<Invoice>();
            lstInvoicepayments = new List<InvoiceReceipts>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetInvoicePayments(lstinvoice, orgID,type, out lstInvoicePayments, out lstInvoicepayments);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetInvoicePayments method", ex);
            }

            return returnCode;
        }
        public long GetPreviousVisitBilling(long PatientID, long VisitID, string Type, out List<BillingDetails> lstBillings,
             out List<PatientInvSample> lstPatientInvSample)
        {
            long returnCode = -1;
            lstBillings = new List<BillingDetails>();
            lstPatientInvSample = new List<PatientInvSample>();
            returnCode = new BillingDAL(globalContextDetails).GetPreviousVisitBilling(PatientID, VisitID, Type, out lstBillings, out lstPatientInvSample);
            return returnCode;
        }

        public long InsertInvoiceReceipts(List<InvoiceReceipts> lstInvoiceRecpts, out string ReceiptNo, out long ReceiptID)
        {
            long returnCode = -1;
            ReceiptNo = string.Empty;
            ReceiptID = -1;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).InsertInvoiceReceipts(lstInvoiceRecpts, out ReceiptNo, out ReceiptID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing BL - InsertInvoiceReceipts", ex);
            }
            return returnCode;
        }
        public long GetInVoiceReceiptDetailss(int OrgID, int OrgAddID, long ClientID, string ReceiptNumber, long ReceiptID, long InvoiceID, out List<InvoiceReceipts> lstInvoiceRecpts, out List<AmountReceivedDetails> lstAmountReceivedDetails)
        {
            long returnCode = -1;
            lstInvoiceRecpts = new List<InvoiceReceipts>();
            lstAmountReceivedDetails = new List<AmountReceivedDetails>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetInVoiceReceiptDetailss(OrgID, OrgAddID, ClientID, ReceiptNumber, ReceiptID, InvoiceID, out lstInvoiceRecpts, out lstAmountReceivedDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing BL - GetInVoiceReceiptDetailss", ex);
            }
            return returnCode;
        }
        public long GetInvoiceReportPath(int OrgID, string Type, long ClientID, long ReportTemplateID, out List<BillingDetails> lstReportPath)
        {
            long returnCode = -1;
            lstReportPath = new List<BillingDetails>();
            returnCode = new BillingDAL(globalContextDetails).GetInvoiceReportPath(OrgID, Type, ClientID, ReportTemplateID, out lstReportPath);
            return returnCode;
        }
        public long GetPatientEpisodeVisitDetails(int OrgID, long PatientID, long EpisodeID, string Type, out List<EpisodeVisitDetails> lstEpisodeVisitDetails)
        {
            long returnCode = -1;
            lstEpisodeVisitDetails = new List<EpisodeVisitDetails>();
            returnCode = new BillingDAL(globalContextDetails).GetPatientEpisodeVisitDetails(OrgID, PatientID, EpisodeID, Type, out lstEpisodeVisitDetails);
            return returnCode;
        }
        public long GetClientEpisode(int OrgID, long ClientID, string Type, out List<EpisodeVisitDetails> lstEpisodeVisitDetails)
        {
            long returnCode = -1;
            lstEpisodeVisitDetails = new List<EpisodeVisitDetails>();
            returnCode = new BillingDAL(globalContextDetails).GetClientEpisode(OrgID, ClientID, Type, out lstEpisodeVisitDetails);
            return returnCode;
        }
        public long GetClientChildDetails(int OrgID, long ClientID, string Clientname, string Type, out List<EpisodeVisitDetails> lstEpisodeVisitDetails)
        {
            long returnCode = -1;
            lstEpisodeVisitDetails = new List<EpisodeVisitDetails>();
            try
            {


                returnCode = new BillingDAL(globalContextDetails).GetClientChildDetails(OrgID, ClientID, Clientname, Type, out lstEpisodeVisitDetails);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetClientChildDetails method", ex);

            }
            return returnCode;
        }
        public long GetConsignmentNo(long EpisodeID, long SiteID, int OrgID, string pType, string ConsignmentNo, out List<EpiContainerTracking> lstEpiContainerTracking)
        {
            long returnCode = -1;
            lstEpiContainerTracking = new List<EpiContainerTracking>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetConsignmentNo(EpisodeID, SiteID, OrgID, pType, ConsignmentNo, out lstEpiContainerTracking);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetConsignmentNo method", ex);
            }
            return returnCode;
        }
        public long GetInvestigationInfo(long ID, string Type, int orgid, out  List<InvestigationValues> lstinvestigation)
        {
            long returnCode = -1;
            lstinvestigation = new List<InvestigationValues>();
            returnCode = new BillingDAL(globalContextDetails).GetInvestigationInfo(ID, Type, orgid, out lstinvestigation);
            return returnCode;
        }
        public long GetBillingItems(int OrgID, string FeeType, string Description, long ClientID, string IsMappedItem, string Remarks, string Gender, out List<BillingFeeDetails> lstBillingFeeDetails)
        {
            long returnCode = -1;
            lstBillingFeeDetails = new List<BillingFeeDetails>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetBillingItems(OrgID, FeeType, Description, ClientID, IsMappedItem, Remarks, Gender, out lstBillingFeeDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing BL - GetBillingItems", ex);
            }

            return returnCode;
        }
        public long GetBillingItemsForBillEdit(int OrgID, string FeeType, string Description, long ClientID, string IsMappedItem, string Remarks,string Gender, List<OrderedInvestigations> lstOrderedInvestigations, out List<BillingFeeDetails> lstBillingFeeDetails)
        {
            long returnCode = -1;
            lstBillingFeeDetails = new List<BillingFeeDetails>();

            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetBillingItemsForBillEdit(OrgID, FeeType, Description, ClientID, IsMappedItem, Remarks,Gender, lstOrderedInvestigations, out lstBillingFeeDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing BL - GetBillingItems", ex);
            }

            return returnCode;
        }
        public long GetBillingItemsForTemplate(int OrgID, string FeeType, string Description, long ClientID, string IsMappedItem, string Remarks, string Gender, List<OrderedInvestigations> lstOrderedInvestigations, out List<BillingFeeDetails> lstBillingFeeDetails)
        {
            long returnCode = -1;
            lstBillingFeeDetails = new List<BillingFeeDetails>();
            globalContextDetails.AdditionalInfo = "Template";
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetBillingItemsForBillEdit(OrgID, FeeType, Description, ClientID, IsMappedItem, Remarks, Gender, lstOrderedInvestigations, out lstBillingFeeDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing BL - GetBillingItemsForTemplate", ex);
            }

            return returnCode;
        }
        public long GetBillingItemsDetails(int OrgID, int FeeID, string FeeType, string Description, long ClientID, long VisitID,
              string Remarks, string IsCollected, DateTime CollectedDatetime, string locationName, long BookingID, out List<BillingFeeDetails> lstBillingFeeDetails)
        {
            long returnCode = -1;
            lstBillingFeeDetails = new List<BillingFeeDetails>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetBillingItemsDetails(OrgID, FeeID, FeeType, Description, ClientID, VisitID, 
                    Remarks, IsCollected, CollectedDatetime, locationName, BookingID,  out lstBillingFeeDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing BL - GetBillingItems", ex);
            }

            return returnCode;
        }
        public long GetBillingItemsDetails_Quantum(int OrgID, int FeeID, string FeeType, string Description, long ClientID, long VisitID, string Remarks, string IsCollected, DateTime CollectedDatetime, string locationName, List<OrderedInvestigations> lstOrderedItems, string ExtVisitNumber, string BilledDate, long BillNo, out List<BillingFeeDetails> lstBillingFeeDetails)
        {
            long returnCode = -1;
            lstBillingFeeDetails = new List<BillingFeeDetails>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetBillingItemsDetails_Quantum(OrgID, FeeID, FeeType, Description, ClientID, VisitID, Remarks, IsCollected, CollectedDatetime, locationName, lstOrderedItems, ExtVisitNumber, BilledDate, BillNo, out lstBillingFeeDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing BL - GetBillingItems", ex);
            }

            return returnCode;
        }
        public long GetHospitalBillingItemsDetails(int OrgID, int FeeID, string FeeType, string Description, long ClientID, long VisitID, string Remarks, long RateID, string VisitType, out List<BillingFeeDetails> lstBillingFeeDetails)
        {
            long returnCode = -1;
            lstBillingFeeDetails = new List<BillingFeeDetails>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetHospitalBillingItemsDetails(OrgID, FeeID, FeeType, Description, ClientID, VisitID, Remarks, RateID, VisitType, out lstBillingFeeDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing BL - GetBillingItems", ex);
            }

            return returnCode;
        }
        public long GetEpisodeVisitDetails(int OrgID, long ClientID, long EpiosdeID, int RateID, out List<EpisodeVisitDetails> lstEpisodeVisitDetails)
        {
            long returnCode = -1;
            lstEpisodeVisitDetails = new List<EpisodeVisitDetails>();
            returnCode = new BillingDAL(globalContextDetails).GetEpisodeVisitDetails(OrgID, ClientID, EpiosdeID, RateID, out lstEpisodeVisitDetails);
            return returnCode;
        }

        public long GetOrderedInvestigationStatus(long PatientID, long VisitID, long FinallBillID, int OrgID, out List<FinalBill> lstFinalBill)
        {
            long returnCode = -1;
            lstFinalBill = new List<FinalBill>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetOrderedInvestigationStatus(PatientID, VisitID, FinallBillID, OrgID, out lstFinalBill);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing BL - GetOrderedInvestigationStatus", ex);
            }

            return returnCode;
        }
        public long GetMergePhysicianPatient(string FilterText, int OrgID, string Type, string FromDate, string ToDate, string FindPosition, string ContactNumber, string MergeType, out List<DayWiseCollectionReport> lstCollections)
        {
            long returnCode = -1;
            lstCollections = new List<DayWiseCollectionReport>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetMergePhysicianPatient(FilterText, OrgID, Type, FromDate, ToDate, FindPosition, ContactNumber, MergeType, out lstCollections);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing BL - GetMergePhysicianPatient", ex);
            }
            return returnCode;
        }

        public long UpdatePatientPhysicianMerge(long ParentReferenceID, int OrgID, List<PatientReferringDetails> lstDatas, string MergeType, long ModifiedBy, string RegType)
        {
            long returnCode = -1;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).UpdatePatientPhysicianMerge(ParentReferenceID, OrgID, lstDatas, MergeType, ModifiedBy, RegType);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while update Patient Physician Merge in Billing Engine", ex);
            }
            return returnCode;
        }

        public long GetvisitBillingInvestigationandDept(long visitID, out List<BillingDetails> lstBillingDetails,
                                                       out List<FinalBill> lstFinalBill,
                                                       out List<Patient> lstPatientDetail,
                                                       out List<Organization> lstOrganization,
                                                       out List<DuePaidDetail> lstDuesPaid,
                                                       long FinalBillID, int orgid, string lstSampleIds)
        {
            long returnCode = -1;
            lstBillingDetails = new List<BillingDetails>();
            lstFinalBill = new List<FinalBill>();
            lstPatientDetail = new List<Patient>();
            lstOrganization = new List<Organization>();
            lstDuesPaid = new List<DuePaidDetail>();


            try
            {
                BillingDAL billingDAL = new BillingDAL(globalContextDetails);
                returnCode = billingDAL.GetvisitBillingInvestigationandDept(visitID, out lstBillingDetails, out lstFinalBill,
                                                                        out lstPatientDetail,
                                                                        out lstOrganization,
                                                                        out lstDuesPaid,
                                                                            FinalBillID, orgid, lstSampleIds);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetvisitBillingInvestigationandDept", ex);
            }
            return returnCode;
        }
        public long GetSurgicalFeeSplitUps(long TreatmentPlanID, out List<SOIRateDetails> lstSOIRateDetails)
        {
            long returnCode = -1;
            lstSOIRateDetails = new List<SOIRateDetails>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetSurgicalFeeSplitUps(TreatmentPlanID, out lstSOIRateDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing BL - GetSOIRateDetails", ex);
            }

            return returnCode;
        }

        public long GetBloodBags(long ProductID, out List<BloodSeparationDetails> LstBloodBags)
        {
            long returnCode = -1;
            LstBloodBags = new List<BloodSeparationDetails>();

            try
            {
                BillingDAL billingDAL = new BillingDAL(globalContextDetails);
                returnCode = billingDAL.GetBloodBags(ProductID, out LstBloodBags);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing BL - GetSOIRateDetails", ex);
            }

            return returnCode;
        }
        public long InsertPatientVisitFromEpisode(long lid, int location, long patientid, long episodeid, int orgid,
            out  long patientvistid, List<VisitClientMapping> lstVisitClientMapping)
        {
            long returncode = -1;
            patientvistid = 0;
            try
            {
                returncode = new BillingDAL(globalContextDetails).InsertPatientVisitFromEpisode(lid, location, patientid,
                                       episodeid, orgid, out patientvistid, lstVisitClientMapping);
            }

            catch (Exception ex)
            {

                CLogger.LogError("Error in Billing.CS", ex);

            }

            return returncode;

        }

        public long UpdateSettlementFinallBill(FinalBill finalBill, AmountReceivedDetails amtRD, DataTable dtAmtReceived,
         List<PatientDueChart> pPatientIndTable, List<TaxBillDetails> lstTaxDetails, decimal dserviceCharge,
         List<PatientDueDetails> lstPatientDueDetails, List<Edt_AccountsImpactDetails> lstAccountImpact,
         List<VisitClientMapping> lstVisitClientMapping,
             int lstPaymentType, string BankName, string ChekNO, decimal NewAmountRecvd)
        {
            long returnCode = -1;
            DataTable dtBillingDetails = new DataTable();

            try
            {
                returnCode = new BillingDAL(globalContextDetails).UpdateSettlementFinallBill(finalBill, amtRD, dtAmtReceived, pPatientIndTable,
                    lstTaxDetails, dserviceCharge, lstPatientDueDetails, lstAccountImpact,
                    lstVisitClientMapping, lstPaymentType, BankName, ChekNO, NewAmountRecvd);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while updating Final Bill", ex);
            }
            return returnCode;
        }


        public long GetOPBillSettlement(long visitId, int OrgID, out List<BillingDetails> lstBillingDetails, out List<FinalBill> lstFinalBill,
             out  List<FinalBill> lstFinalBillNOWise)
        {
            long returnCode = -1;

            lstBillingDetails = new List<BillingDetails>();
            lstFinalBill = new List<FinalBill>();
            lstFinalBillNOWise = new List<FinalBill>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetOPBillSettlement(visitId, OrgID, out lstBillingDetails, out lstFinalBill,
                    out lstFinalBillNOWise);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while updating Final Bill", ex);
            }
            return returnCode;
        }

        public long GetBillingDetailsByRateTypeForOP(long VisitID, long BilledRateID, decimal BilledRateCardAmount, long SelectedRateID, out decimal BilledandSelectedRateCardDifference, int OrgID, string Type, out List<BillingDetails> lstDetails)
        {
            long returnCode = -1;
            lstDetails = new List<BillingDetails>();
            BilledandSelectedRateCardDifference = -1;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetBillingDetailsByRateTypeForOP(VisitID, BilledRateID, BilledRateCardAmount, SelectedRateID, out BilledandSelectedRateCardDifference, OrgID, Type, out lstDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing GetBillingDetailsByRateTypeForOP", ex);
            }
            return returnCode;
        }


        public long GetMergeBillPrinting(long VisitID, out List<BillingDetails> lstBillingDetail, out List<FinalBill> lstFinalBillDetail, out  List<Patient> lstPatientDetails)
        {
            long returnCode = -1;
            lstBillingDetail = new List<BillingDetails>();
            lstFinalBillDetail = new List<FinalBill>();
            lstPatientDetails = new List<Patient>();

            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetMergeBillPrinting(VisitID, out lstBillingDetail, out lstFinalBillDetail, out lstPatientDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing GetBillingDetailsByRateTypeForOP", ex);
            }
            return returnCode;
        }

        public long GetBookingOrderDetails(long BookingId, int OrgId, int LocationId, out  List<Bookings> lstBookingOrder)
        {
            long returnCode = -1;

            lstBookingOrder = new List<Bookings>();
            try
            {

                returnCode = new BillingDAL(globalContextDetails).GetBookingOrderDetails(BookingId, OrgId, LocationId, out lstBookingOrder);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing GetBillingDetailsByRateTypeForOP", ex);
            }
            return returnCode;
        }
        public long GetFinalbillRefundDetails(long vid, long pFinalBillid, int pOrgid, out List<BillingDetails> lstBillingDetails, out List<FinalBill> lstFinalBill)
        {
            long returnCode = -1;
            lstFinalBill = new List<FinalBill>();
            lstBillingDetails = new List<BillingDetails>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetFinalbillRefundDetails(vid, pFinalBillid, pOrgid, out lstBillingDetails, out lstFinalBill);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing.CS", ex);
            }
            return returnCode;
        }

        public long GetBillingItemsDetailsForEdit(int OrgID, string BillNo, long VisitID, long PatientID, long ClientID, out List<BillingDetails> lstBillings1, out List<BillingDetails> lstBillings2)
        {
            long returnCode = -1;
            lstBillings1 = new List<BillingDetails>();
            lstBillings2 = new List<BillingDetails>();
            returnCode = new BillingDAL(globalContextDetails).GetBillingItemsDetailsForEdit(OrgID, BillNo, VisitID, PatientID, ClientID, out lstBillings1, out lstBillings2);
            return returnCode;
        }

        public long GetDiscountLimit(string ReferType, long ReferID, int OrgID, out List<FinalBill> lstFinalBill)
        {
            long returnCode = -1;
            lstFinalBill = new List<FinalBill>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetDiscountLimit(ReferType, ReferID, OrgID, out lstFinalBill);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing BL - GetBillingItems", ex);
            }
            return returnCode;
        }

        public long GetRateDetailForBulckRateChanges(int OrgID, int ClientId, string FDate, string ToDate, int NewRateid, List<Invoice> lstInvoice, List<RateMaster> lstRateMaster, out List<BulckRateUpdates> lstBillings)
        {
            long returnCode = -1;
            lstBillings = new List<BulckRateUpdates>();
            returnCode = new BillingDAL(globalContextDetails).GetRateDetailForBulckRateChanges(OrgID, ClientId, FDate, ToDate, NewRateid, lstInvoice, lstRateMaster, out lstBillings);
            return returnCode;
        }

        public long GetRateNameForClients(int OrgID, String FromDate, String ToDate, long ClientID, long InvoiceID, out List<RateMaster> lstRateMaster, out List<RateMaster> AlRateMaster, out List<RateMaster> lstInvoice, out List<RateMaster> lstselratename)
        {
            lstRateMaster = new List<RateMaster>();
            long returncode = -1;
            returncode = new BillingDAL(globalContextDetails).GetRateNameForClients(OrgID, FromDate, ToDate, ClientID, InvoiceID, out lstRateMaster, out AlRateMaster, out lstInvoice, out lstselratename);
            return returncode;
        }

        public long InsertBulkRateApply(int OrgID, List<BulckRateUpdates> lstBulckRateUpdates, out long BulkID)
        {

            long returncode = -1;
            returncode = new BillingDAL(globalContextDetails).InsertBulkRateApply(OrgID, lstBulckRateUpdates, out BulkID);
            return returncode;
        }

        public long GetRateAppliedRares(long BulkID, out List<BulckRateUpdates> lstBulckRateUpdates, out List<RateMaster> lstClients,
            out List<RateMaster> lstInvoice, out List<RateMaster> lstrate)
        {
            lstBulckRateUpdates = new List<BulckRateUpdates>();
            lstClients = new List<RateMaster>();
            lstInvoice = new List<RateMaster>();
            lstrate = new List<RateMaster>();
            long returncode = -1;
            returncode = new BillingDAL(globalContextDetails).GetRateAppliedRares(BulkID, out lstBulckRateUpdates, out lstClients, out lstInvoice, out lstrate);
            return returncode;
        }

        public long InsertInvoiceRatediff(int OrgID, int ClientID, string FDate, string TDate, List<Invoice> lstInvoice, List<RateMaster> lstRateMaster,
            int NewRateID, long LoginID, long BulkID)
        {

            long returncode = -1;
            returncode = new BillingDAL(globalContextDetails).InsertInvoiceRatediff(OrgID, ClientID, FDate, TDate, lstInvoice, lstRateMaster, NewRateID,
             LoginID, BulkID);
            return returncode;
        }

        public long InsertDueWriteOffApprovals(List<PatientDueDetails> lstPatientDueDetails, out long WriteOffApprovalID)
        {
            long returnCode = -1;
            WriteOffApprovalID = 0;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).InsertDueWriteOffApprovals(lstPatientDueDetails, out WriteOffApprovalID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing.CS", ex);
            }
            return returnCode;
        }
        public long GetDueWriteOffApprovals(long ApprovalID, long PatientID, long FinalbillID, out List<PatientDueDetails> lstDueWriteOffs)
        {
            long returnCode = -1;

            lstDueWriteOffs = new List<PatientDueDetails>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetDueWriteOffApprovals(ApprovalID, PatientID, FinalbillID, out lstDueWriteOffs);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing.CS GetDueWriteOffApprovals", ex);
            }
            return returnCode;
        }

        public long UpdateDueWriteOffApprovals(long ApprovalID, decimal ApprovalWriteOffAmt, int OrgID, string Status)
        {
            long returnCode = -1;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).UpdateDueWriteOffApprovals(ApprovalID, ApprovalWriteOffAmt, OrgID, Status);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing.CS UpdateDueWriteOffApprovals", ex);
            }
            return returnCode;
        }
        public long UpdateAmountReceivedDetails(long finalBillID, DataTable dt)
        {
            long returnCode = -1;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).UpdateAmountReceivedDetails(finalBillID, dt);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL UpdateAmountReceivedDetails", ex);
            }

            return returnCode;
        }

        public long GetLabQuickBillPatientListForClientBilling(string pName, string pVisitType, int pOrgID, long PatVisitID, out List<Patient> lstPatientDetails)
        {
            long returnCode = -1;
            lstPatientDetails = new List<Patient>();
            BillingDAL billDAL = new BillingDAL(globalContextDetails);
            try
            {
                returnCode = billDAL.GetLabQuickBillPatientListForClientBilling(pName, pVisitType, pOrgID, PatVisitID, out lstPatientDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetLabQuickBillPatientListForClientBilling in Billing Engine", ex);
            }
            return returnCode;
        }

        public long GetDuplicateValidationonEntry(int pOrgID, string Name, string Age, long ClientID, string registerdDate, long ID, string Type,
        out List<PatientVisit> lstPatientDetails)
        {
            long returnCode = -1;
            lstPatientDetails = new List<PatientVisit>();
            BillingDAL billDAL = new BillingDAL(globalContextDetails);
            try
            {
                returnCode = billDAL.GetDuplicateValidationonEntry(pOrgID, Name, Age, ClientID, registerdDate, ID, Type, out lstPatientDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDuplicateValidationonEntry in Billing Engine", ex);
            }
            return returnCode;
        }
        public long GetQuickPatientSearch(int searchType, string SearchText, int pOrgID, long pClientID, out List<Patient> lstPatientDetails)
        {
            long returnCode = -1;
            lstPatientDetails = new List<Patient>();
            BillingDAL billDAL = new BillingDAL(globalContextDetails);
            try
            {
                returnCode = billDAL.GetQuickPatientSearch(searchType, SearchText, pOrgID, pClientID, out lstPatientDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetQuickPatientSearch in Billing Engine", ex);
            }
            return returnCode;
        }
        public long GetQuickPatientSearchDetails(long PatientID, long PatientVisitID, int pOrgID, int SearchType, long HealthiAPIBookingID, out List<Patient> lstPatientDetails)
        {
            long returnCode = -1;
            lstPatientDetails = new List<Patient>();
            BillingDAL billDAL = new BillingDAL(globalContextDetails);
            try
            {
                returnCode = billDAL.GetQuickPatientSearchDetails(PatientID, PatientVisitID, pOrgID, SearchType, HealthiAPIBookingID, out lstPatientDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetQuickPatientSearchDetails in Billing Engine", ex);
            }
            return returnCode;
        }

        public long GetClientRefPhyHosforCode(string SearchText, int OrgID, out List<ClientCodeMapping> lstClientCodeMapping)
        {
            long returnCode = -1;
            lstClientCodeMapping = new List<ClientCodeMapping>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetClientRefPhyHosforCode(SearchText, OrgID, out lstClientCodeMapping);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetClientRefPhyHosforCode in BillingEngine.cs", ex);
            }
            return returnCode;
        }
        public long GetRateForSTAT(int OrgID, int FeeID, string FeeType, long ClientID, string BillNo, string BillstartTime, out List<BillingFeeDetails> lstGeneralBillingItems)
        {
            long returnCode = -1;
            lstGeneralBillingItems = new List<BillingFeeDetails>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetRateForSTAT(OrgID, FeeID, FeeType, ClientID, BillNo, BillstartTime, out lstGeneralBillingItems);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing BL - GetRateForSTAT", ex);
            }

            return returnCode;
        }
 //Vijayalakshmi.m 
    
        public long GetOrganisationDetails(int OrgID, out List<LabReferenceOrg> lstlabreforg)
        {
            long returnCode = -1;
            lstlabreforg = new List<LabReferenceOrg>();
            try
            {
                BillingDAL billDal = new BillingDAL();
                returnCode = billDal.GetOrganisationDetails(OrgID, out lstlabreforg);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetOrganisationDetails", ex);
            }
            return returnCode;
        }

       
        public long GetOutSourceWorksheet(DateTime fDate, DateTime tDate, long LabRefId, int OrgID, out List<OutsourcingDetail> lstoutsourcce, out List<InvRateMaster> lstrate, out List<LabRefOrgAddress> lstadd, out List<GeneralBillingItems> lstbill)
        {
            long ReturnCode = -1;
            lstoutsourcce = new List<OutsourcingDetail>();
            lstadd =new List<LabRefOrgAddress>() ;
            lstbill =new List<GeneralBillingItems> ();
            lstrate = new List<InvRateMaster>();
            try
            {
                BillingDAL billDal = new BillingDAL();
                ReturnCode = billDal.GetOutSourceWorksheet(fDate, tDate, LabRefId, OrgID, out lstoutsourcce, out lstrate,out lstadd ,out lstbill );
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetOutSourceWorksheet", ex);
            }
            return ReturnCode;
        }
        public long GetQuotationClientName(string SearchText, int pOrgID, out List<Patient> lstClientDetails)
        {
            long returnCode = -1;
            lstClientDetails = new List<Patient>();
            BillingDAL billDAL = new BillingDAL(globalContextDetails);
            try
            {
                returnCode = billDAL.GetQuotationClientName(SearchText, pOrgID, out lstClientDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetQuotationClientName in Billing Engine", ex);
            }
            return returnCode;
        }
        public long GetQuotationClientNameDetails(string ClientID, int pOrgID, out List<Patient> lstClientDetails)
        {
            long returnCode = -1;
            lstClientDetails = new List<Patient>();
            BillingDAL billDAL = new BillingDAL(globalContextDetails);
            try
            {
                returnCode = billDAL.GetQuotationClientNameDetails(ClientID, pOrgID, out lstClientDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetQuotationClientNameDetails in Billing Engine", ex);
            }
            return returnCode;
        }
        public long GetQuotationNumber(string SearchText, int pOrgID,string type ,out List<Patient> lstQuotationNo)
        {
            long returnCode = -1;
            lstQuotationNo = new List<Patient>();
            BillingDAL billDAL = new BillingDAL(globalContextDetails);
            try
            {
                returnCode = billDAL.GetQuotationNumber(SearchText, pOrgID,type,out lstQuotationNo);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetQuotationNumber in Billing Engine", ex);
            }
            return returnCode;
        }
        public long GetQuotationNumberDetails(string Quotationid, string ClientID, int Orgid, string Type, string SampleType, out List<Patient> lstClients, out List<PreQuotationInvestigations> lstTest, out List<QuotationBill> lstvalues, out  List<WatersQuotationMaster> lstWaters, out List<QuotationAddressDetails> TempAddrs)
        {
            long returnCode = -1;
            lstClients = new List<Patient>();
            lstTest = new List<PreQuotationInvestigations>();
            lstvalues = new List<QuotationBill>();
            lstWaters =new  List<WatersQuotationMaster>();
            TempAddrs = new List<QuotationAddressDetails>();

            BillingDAL billDAL = new BillingDAL(globalContextDetails);
            try
            {
                returnCode = billDAL.GetQuotationNumberDetails(Quotationid, ClientID, Orgid, Type, SampleType, out lstClients, out lstTest, out lstvalues, out lstWaters, out TempAddrs);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetQuickPatientSearchDetails in Billing Engine", ex);
            }
            return returnCode;
        }
  /*added By jagatheesh  for Test wise Analyzer report*/
        public long GetTestCodeItems(int OrgID, string Description, out List<TestWiseAnalyzerReport> lstTestCodeDetails)
        {
            long returnCode = -1;
            lstTestCodeDetails = new List<TestWiseAnalyzerReport>();
            try
            {
			         returnCode = new BillingDAL(globalContextDetails).GetTestCodeItems(OrgID, Description, out lstTestCodeDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing BL - GetTestCodeItems For Test Wise Analyzer Report", ex);
            }
            return returnCode;
        }
		 /* End Added */
		    public long GetPKGQuotationDetails(long ID, string Type, int orgid, out  List<InvestigationValues> lstinvestigation)
        {

            long returnCode = -1;
            lstinvestigation = new List<InvestigationValues>();
            try
            {
                
                
                returnCode = new BillingDAL(globalContextDetails).GetPKGQuotationDetails(ID, Type, orgid, out lstinvestigation);
            }
            catch (Exception ex)
            {

                CLogger.LogError("Error in Billing BL - GetPKGQuotationDetails For Waters", ex);
            
            }
                
            return returnCode;
        }
        public long GetPKGQuotationMasterDetails(long ID, string Type, int orgid, out  List<InvestigationValues> lstinvestigation)
        {
            long returnCode = -1;
            lstinvestigation = new List<InvestigationValues>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetPKGQuotationMasterDetails(ID, Type, orgid, out lstinvestigation);
            }
            catch (Exception ex)
            {

                CLogger.LogError("Error in Billing BL - GetPKGQuotationMasterDetails For Waters", ex);

            }
            return returnCode;
        }

        public long GetBillPrintingDetails_MRPBill(long visitID, out List<BillingDetails> lstBillingDetails,
                                                out List<FinalBill> lstFinalBill,
                                                out List<Patient> lstPatientDetail,
                                                out List<Organization> lstOrganization,
                                                out string physicianName,
                                                out List<DuePaidDetail> lstDuesPaid,
                                                long FinalBillID, out List<Taxmaster> lstTax, out string splitstatus, out List<PatientQualification> lstQualification)
        {
            long returnCode = -1;
            lstBillingDetails = new List<BillingDetails>();
            lstFinalBill = new List<FinalBill>();
            lstPatientDetail = new List<Patient>();
            lstOrganization = new List<Organization>();
            lstDuesPaid = new List<DuePaidDetail>();
            lstTax = new List<Taxmaster>();
            lstQualification = new List<PatientQualification>();
            splitstatus = string.Empty;
            physicianName = string.Empty;
            try
            {
                BillingDAL billingDAL = new BillingDAL(globalContextDetails);
                returnCode = billingDAL.GetBillPrintingDetails_MRPBill(visitID, out lstBillingDetails, out lstFinalBill,
                                                                        out lstPatientDetail,
                                                                        out lstOrganization,
                                                                        out physicianName,
                                                                        out lstDuesPaid,
                                                                            FinalBillID, out lstTax, out splitstatus, out lstQualification);
                /*-----------------Handle VIP Data Start-------------------------*/
                List<Patient> lsttempDetails = new List<Patient>();
                lsttempDetails = lstPatientDetail.FindAll(p => p.PatientStatus == "VIP");
                lstPatientDetail.RemoveAll(p => p.PatientStatus == "VIP");
                for (int i = 0; i < lsttempDetails.Count; i++)
                {
                    /*----Decrypting----------*/
                    Utilities objUtilities = new Utilities();
                    object inputobj = new object();
                    object Decryptedobj = new object();
                    inputobj = lsttempDetails[i];
                    returnCode = objUtilities.GetDecryptedobj(inputobj, out Decryptedobj);
                    lsttempDetails[i] = (Patient)Decryptedobj;
                    /*----------------------*/
                    /*-----Masking----------*/
                    object inputobj1 = new object();
                    object Maskedobj = new object();
                    inputobj1 = lsttempDetails[i];
                    returnCode = objUtilities.GetMaskedobj(inputobj1, out Maskedobj);
                    lsttempDetails[i] = (Patient)Maskedobj;
                    lstPatientDetail.Add(lsttempDetails[i]);
                    /*----------------------*/
                }
                /*-----------------Handle VIP Data End------------------------------*/
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetBillPrintingDetails_MRPBill", ex);
            }
            return returnCode;
        }
        public long GetpkgSampleDetails(long QuotationID, long InvestigationID, string Type, out  List<QuotationSampleScheduling> lstPkgSample)
        {
            long returnCode = -1;
            lstPkgSample = new List<QuotationSampleScheduling>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetpkgSampleDetails(QuotationID, InvestigationID, Type, out lstPkgSample);
            }

            catch (Exception ex)
            {

                CLogger.LogError("Error in Billing BL - GetPKGQuotationMasterDetails For Waters", ex);

            }

            return returnCode;
        }

       //Added By sree krishna for Waters

                public long GetRegistrationSampleCollect(long QuotationID, int OrgID, long VisitID ,out  List<PreQuotationInvestigations> lstinvestigation)
                {
                    long returnCode = -1;
                    lstinvestigation = new List<PreQuotationInvestigations>();
                    try
                    {
                        returnCode = new BillingDAL(globalContextDetails).GetRegistrationSampleCollect(QuotationID, OrgID, VisitID, out lstinvestigation);
                    }

                    catch (Exception ex)
                    {

                        CLogger.LogError("Error in Billing BL - GetRegistrationSampleCollect For Waters", ex);

                    }

                    return returnCode;
                }
				
				
				
        public long GetPreRegistrationDiscountRedeemDetails(long bookingID, out List<PreRegistrationDiscountRedeemDetails> lstDiscountRedeemDetails)
        {
            long returnCode = -1;
            lstDiscountRedeemDetails = new List<PreRegistrationDiscountRedeemDetails>();
            //lstPatientDetails = new List<Patient>();
            BillingDAL billDAL = new BillingDAL(globalContextDetails);

            try
            {
                returnCode = billDAL.GetPreRegistrationDiscountRedeemDetails(bookingID, out lstDiscountRedeemDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPreRegistrationDiscountRedeemDetails in Billing Engine", ex);
            }
            return returnCode;
        }

        public long GetWatersInvoiceGeneration(long InvoiceID, long ClientID, int OrgID, int OrgAdd, DateTime FDate, DateTime TDate, int RejBills, out List<BillingDetails> lstInvoiceBill, out List<DiscountPolicy> lstVolumeDiscount, out List<CreditDebitSummary> lstCreditDebit)
        {
            long returnCode = -1;
            lstInvoiceBill = new List<BillingDetails>();
            lstVolumeDiscount = new List<DiscountPolicy>();
            lstCreditDebit = new List<CreditDebitSummary>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetWatersInvoiceGeneration(InvoiceID, ClientID, OrgID, OrgAdd, FDate, TDate, RejBills, out lstInvoiceBill, out lstVolumeDiscount, out lstCreditDebit);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetWatersInvoiceGeneration Billing.CS", ex);
            }

            return returnCode;

        }

        public long ClientAttributesFieldDetails(long ReferenceID, string ReferenceType, out List<FieldAttributeDetails> lstFieldDetails)
        {
            long returnCode = -1;
            lstFieldDetails =new List<FieldAttributeDetails>();
            try
            {
                lstFieldDetails = new List<FieldAttributeDetails>();
                returnCode = new BillingDAL(globalContextDetails).ClientAttributesFieldDetails(ReferenceID, ReferenceType, out lstFieldDetails);
                
            }
            catch (Exception ex)
            {

                CLogger.LogError("Error in ClientAttributesFieldDetails BillingEngine", ex);
            }
            return returnCode;
        }
        public long InsertClientAttributesFieldDetails(long PatientVisitID,List<ClientAttributesKeyFields> lstclt )
        {
             long returnCode = -1;
            
            try
            {
                //lstclt = new List<ClientAttributesKeyFields>();
                returnCode = new BillingDAL(globalContextDetails).InsertClientAttributesFieldDetails(PatientVisitID, lstclt);
                
            }
            catch (Exception ex)
            {

                CLogger.LogError("Error in InsertClientAttributesFieldDetails BillingEngine", ex);
            }
            return returnCode;
        }
        public long InsertTestHistoryPatientFieldDetails(long PatientVisitID, List<ClientAttributesKeyFields> lstclt,string ActionType)
        {
            long returnCode = -1;

            try
            {
                //lstclt = new List<ClientAttributesKeyFields>();
                returnCode = new BillingDAL(globalContextDetails).InsertTestHistoryPatientFieldDetails(PatientVisitID, lstclt,ActionType);

            }
            catch (Exception ex)
            {

                CLogger.LogError("Error in InsertClientAttributesFieldDetails BillingEngine", ex);
            }
            return returnCode;
        }

        public long LoadSpecialSamples(string prefixText, out List<InvSampleMaster> FileList)
        {
            long returncode = -1;
            FileList = new List<InvSampleMaster>();
            //DataSet ds = new DataSet();
            BillingDAL BillDal = new BillingDAL(globalContextDetails);
            try
            {
                returncode = BillDal.LoadSpecialSamples(prefixText, out FileList);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading Device in LoadSpecialSamples", ex);
            }
            return returncode;
        }
		
        public long SaveBillEditDetails(long pOrgID, decimal pGrossBillValue, decimal pDiscountAmount, decimal pNetValue, long pVisitID, long pClientID, long pBillID, List<PatientDueChart> lstPatientDueChart)
        {

            long returnCode = -1;
       
             try
            {
                returnCode = new BillingDAL(globalContextDetails).SaveBillEditDetails(pOrgID, pGrossBillValue, pDiscountAmount, pNetValue, pVisitID, pClientID, pBillID, lstPatientDueChart);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetWatersInvoiceGeneration Billing.CS", ex);
            }

            return returnCode;
        }
        public long ClientAttributesFieldValues(long ReferenceID, string ReferenceType, long PatientVisitID, out List<ClientAttributesKeyFields> lstFieldDetails)
        {
            long returnCode = -1;
            lstFieldDetails = new List<Attune.Podium.BusinessEntities.ClientAttributesKeyFields>();
            try
            {
                lstFieldDetails = new List<Attune.Podium.BusinessEntities.ClientAttributesKeyFields>();
                returnCode = new BillingDAL(globalContextDetails).ClientAttributesFieldValues(ReferenceID, ReferenceType,PatientVisitID, out lstFieldDetails);

            }
            catch (Exception ex)
            {

                CLogger.LogError("Error in ClientAttributesFieldDetails BillingEngine", ex);
            }
            return returnCode;
        }

        public long TestHistoryFieldDetails(long ReferenceID, string ReferenceType,string TestType, out List<FieldAttributeDetails> lstFieldDetails)
        {
            long returnCode = -1;
            lstFieldDetails = new List<FieldAttributeDetails>();
            try
            {
                lstFieldDetails = new List<FieldAttributeDetails>();
                returnCode = new BillingDAL(globalContextDetails).TestHistoryFieldDetails(ReferenceID, ReferenceType,TestType, out lstFieldDetails);

            }
            catch (Exception ex)
            {

                CLogger.LogError("Error in ClientAttributesFieldDetails BillingEngine", ex);
            }
            return returnCode;
        }
		
		/// for Home Collection
		public long GetHCPayments(int OrgID, long BookingID, out List<BillingFeeDetails> lstPayments)
        {
            long returnCode = -1;
            lstPayments = new List<BillingFeeDetails>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetHCPayments(OrgID, BookingID, out lstPayments);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing BL - GetHCPayments", ex);
            }

            return returnCode;
        }

        /// for get a HC TRF file
        public long GetHCTRFfile(long BookingID, out List<BillingFeeDetails> lstTRFfiles)
        {
            long returnCode = -1;
            lstTRFfiles = new List<BillingFeeDetails>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetHCTRFfile(BookingID, out lstTRFfiles);

                //if (returnCode == 0 && lstTRFfiles.Count > 0 )
                //{
                //    for (int i = 0; i < lstTRFfiles.Count; i++)
                //    {
                //        string filePath = lstTRFfiles[i].IsTemplateText.Replace("\\\\", "/"); // filePath
                //        string fileName =  lstTRFfiles[i].Descrip; // fileName
                //        string PathwithfileName = filePath + fileName;
                //        string fileSave = @"C:\\Temp\\";

                //        if (File.Exists(filePath))
                //        {
                //            if (!System.IO.Directory.Exists(fileSave))
                //            {
                //                System.IO.Directory.CreateDirectory(fileSave);
                //            }
                //            File.Move(filePath, fileSave + fileName); 
                //        }
                //    }
                //}
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing BL - GetHCTRFfile", ex);
            }

            return returnCode;
        }

        //HealthHubID validate
        public long ValidateHealthHubID(int pOrgID, long pBookingID, string pHealthHubID, string pName, string pDOB, string pGender, string pMob, string pEmail,
                   out List<Patient> lstHealthHubId)
        {
            long returnCode = -1;
            lstHealthHubId = new List<Patient>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).ValidateHealthHubID(pOrgID, pBookingID, pHealthHubID,pName, pDOB, pGender, pMob, pEmail,
                            out lstHealthHubId);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing BL - ValidateHealthHubID", ex);
            }

            return returnCode;
        }
		  public long UpdateBillofSupplyNumberClientWise(long ClientID, int OrgID,string BillofSupplyNumber,decimal InvoiceAmount,string DateofBill)
        {
            long returnCode = -1;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).UpdateBillofSupplyNumberClientWise(ClientID,OrgID,BillofSupplyNumber,InvoiceAmount,DateofBill);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing Engine UpdateBillofSupplyNumberClientWise", ex);
            }

            return returnCode;
        }
		 public long GetRateCardForBilling_Franchisee(string SearchText, long OrgID, string Type, long refhospid, out List<InvClientMaster> lstClients)
        {
            long returnCode = -1;
            lstClients = new List<InvClientMaster>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetRateCardForBilling_Franchisee(SearchText, OrgID, Type, refhospid, out lstClients);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetRateCardForBilling in BillingEngine.cs", ex);
            }
            return returnCode;
        }
		#region POSBillsettlement
        public long InsertAmountClosureDenoDetails(decimal totalAmount, decimal amountReceived, string status,
                                               int closedBy, int closedFor, int createdBy, int createdFor,
                                               DataTable dtClosureDenoDetails,
                                               DataTable dtBillingDetails,
                                               DataTable dtAmountRefundDetails,
                                               DataTable dtAmountPaidDetails, string AllUsersSelected,
                                               decimal amountRefund, string isrefund)
        {
            long returnCode = -1;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).InsertAmountClosureDenoDetails(totalAmount, amountReceived, status,
                                                                        closedBy, closedFor, createdBy, createdFor,
                                                                        dtClosureDenoDetails,
                                                                        dtBillingDetails,
                                                                        dtAmountRefundDetails,
                                                                        dtAmountPaidDetails,
                                                                        AllUsersSelected, amountRefund, isrefund);

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while excecuting billing_bl", ex);
            }
            return returnCode;
        }
        public long InsertAmountClosureDenoDetailsForAllUsers(DataTable dtClosureDenoDetails, DataTable dtClosureDetails, string status, int createdBy,
                                                          DataTable dtBillingDetails,
                                                          DataTable dtAmountRefundDetails,
                                                          DataTable dtAmountPaidDetails, string isrefund)
        {
            long returnCode = -1;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).InsertAmountClosureDenoDetailsForAllUsers(dtClosureDenoDetails, dtClosureDetails, status, createdBy,
                                                                                    dtBillingDetails,
                                                                                    dtAmountRefundDetails,
                                                                                    dtAmountPaidDetails,
                                                                                    isrefund);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while excecuting billing_bl", ex);
            }
            return returnCode;
        }

        public long GetCurrencyForOrgMappingCashClosureDeno(int OrgID, out List<CurrencyMaster> lstCurrencyMaster)
        {
            long returnCode = -1;
            lstCurrencyMaster = new List<CurrencyMaster>();
            try
            {

                BillingDAL masterDAL = new BillingDAL(globalContextDetails);
                returnCode = masterDAL.GetCurrencyForOrgMappingCashClosureDeno(OrgID, out lstCurrencyMaster);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetCurrencyForOrgMapping in BillinEngine", e);
            }
            return returnCode;
        }
        #endregion

        public long GetAmountReceivedDenoDetails(long UserID, int OrgId, DateTime pFDT, DateTime pTDT, int locationId, out List<ReceivedAmount> lstAmountReceivedDetails, out List<CashClosureDenominationDetail> lstCCDenoDetails,
                                         out List<ReceivedAmount> lstRefundDetails,
                                         out List<ReceivedAmount> lstPaymentDetails,
                                         out decimal dTotalAmount, out decimal dTotalRefund, out decimal dTotalCancelledAmount,
                                         out string sRcvdFromtime, out string sRcvdTotime,
                                         out string sRefundFromtime, out string sRefundTotime,
                                         out string sMinStartTime, out string sMaxEndTime,
                                         out decimal dtAmount, out decimal othersAmount,
                                         out decimal TotalIncAmount,
                                         out List<ReceivedAmount> lstINDAmtReceivedDetails,
                                         out List<ReceivedAmount> lstIPINDAmtReceivedDetails,
                                         out List<AmountReceivedDetails> lstreceivedTypes,
                                         out List<ReceivedAmount> lstSplitDetails,
                                                     out List<AmountReceivedDetails> lstIncSourcePaidDetails,
                                         out List<CurrencyOrgMapping> lstCurrencyInHand,
                                         out List<CashClosureDenomination> lstCCDeno,
                                         out decimal TotalPendingSettleAmt)
        {
            long returnCode = -1;
            sRcvdFromtime = string.Empty;
            sRcvdTotime = string.Empty;
            sRefundFromtime = string.Empty;
            sRefundTotime = string.Empty;
            sMaxEndTime = string.Empty;
            sMinStartTime = string.Empty;

            lstAmountReceivedDetails = new List<ReceivedAmount>();
            lstRefundDetails = new List<ReceivedAmount>();
            lstPaymentDetails = new List<ReceivedAmount>();
            lstINDAmtReceivedDetails = new List<ReceivedAmount>();
            lstIPINDAmtReceivedDetails = new List<ReceivedAmount>();
            lstreceivedTypes = new List<AmountReceivedDetails>();
            lstSplitDetails = new List<ReceivedAmount>();
            lstCurrencyInHand = new List<CurrencyOrgMapping>();
            lstCCDeno = new List<CashClosureDenomination>();
            lstCCDenoDetails = new List<CashClosureDenominationDetail>();
            lstIncSourcePaidDetails = new List<AmountReceivedDetails>();
            dTotalAmount = 0;
            dTotalRefund = 0; dTotalCancelledAmount = 0;
            dtAmount = 0;
            othersAmount = 0;
            TotalIncAmount = 0;
            TotalPendingSettleAmt = 0;
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetAmountReceivedDenoDetails(UserID, OrgId, pFDT, pTDT, locationId,
                                                                        out lstAmountReceivedDetails,
                                                                        out lstCCDenoDetails,
                                                                        out lstRefundDetails,
                                                                        out lstPaymentDetails,
                                                                        out dTotalAmount,
                                                                        out dTotalRefund, out dTotalCancelledAmount,
                                                                        out sRcvdFromtime,
                                                                        out sRcvdTotime,
                                                                        out sRefundFromtime,
                                                                        out sRefundTotime,
                                                                        out sMinStartTime,
                                                                        out sMaxEndTime,
                                                                        out dtAmount,
                                                                        out othersAmount,
                                                                        out TotalIncAmount,
                                                                        out lstINDAmtReceivedDetails,
                                                                        out lstIPINDAmtReceivedDetails,
                                                                        out lstreceivedTypes,
                                                                        out lstSplitDetails,
                                                                        out lstIncSourcePaidDetails,
                                                                        out lstCurrencyInHand,
                                                                        out lstCCDeno,
                                                                        out TotalPendingSettleAmt);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BillinEngine.cs", ex);
            }
            return returnCode;
        }

        public long GetListOfUsersForCollectionDeno(long OrgId, out List<Users> lstUsersDetails)
        {
            long returnCode = -1;
            lstUsersDetails = new List<Users>();
            try
            {
                returnCode = new BillingDAL(globalContextDetails).GetListOfUsersForCollectionDeno(OrgId, out lstUsersDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BillinEngine.cs", ex);
            }
            return returnCode;
        }
    }
}
