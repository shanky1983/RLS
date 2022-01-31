using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using Attune.KernelV2.Cmd;
using Attune.KernelV2.DataAccessEngine;
using Attune.KernelV2.Entities;
using Attune.KernelV2.UDT;
using Attune.KernelV2.Utilities;

namespace Attune.KernelV2.DAL
{
    public class Billing_DAL : IDisposable
    {
        UI_ContextDetails globalContextDetails;

        public Billing_DAL(UI_ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public List<UI_PatientBanner> GetPatientBilling(string PrefixText, int OrgID)
        {
            List<UI_PatientBanner> lstPatient = null;
            using (DbHelper gateWay = new DbHelper())
            {

                var cmd = KernelV2_Command.pGetPatientforBilling_V2Command(PrefixText, OrgID, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    lstPatient = Utility.Tolist<UI_PatientBanner>(dataReader).ToList();
                }
            }
            return lstPatient;
        }

        public UI_BillingPatientContext GetPatientDetailsBilling(long PatientID, int OrgID)
        {
            UI_BillingPatientContext objPatientContext = null;
            using (DbHelper gateWay = new DbHelper())
            {

                var cmd = KernelV2_Command.pGetPatientDetailsforBilling_V2Command(PatientID, OrgID, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    objPatientContext = Utility.Tolist<UI_BillingPatientContext>(dataReader).ToList().FirstOrDefault();
                }
            }
            return objPatientContext;
        }

        public UI_BillingPatientVisitContext GetPatientVisitDetailsBilling(long VisitID, int OrgID)
        {
            UI_BillingPatientVisitContext objPatientVisitContext = null;
            using (DbHelper gateWay = new DbHelper())
            {

                var cmd = KernelV2_Command.pGetPatientVisitDetailsforBilling_V2Command(VisitID, OrgID, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    objPatientVisitContext = Utility.Tolist<UI_BillingPatientVisitContext>(dataReader).ToList().FirstOrDefault();
                    if (dataReader.NextResult() && objPatientVisitContext!=null)
                    {
                        objPatientVisitContext.DisPatch = Utility.Tolist<UI_DisPatch>(dataReader).ToList();
                    }
                }
            }

            return objPatientVisitContext;
        }

        public List<UI_PreviousVisitBilling> GetPreviousVisitBilling(long PatientID, long VisitID, int OrgID)
        {
            List<UI_PreviousVisitBilling> lstPreviousVisitBilling = null;
            using (DbHelper gateWay = new DbHelper())
            {

                var cmd = KernelV2_Command.pGetPreviousVisitBilling_V2Command(PatientID, VisitID, OrgID, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    lstPreviousVisitBilling = Utility.Tolist<UI_PreviousVisitBilling>(dataReader).ToList();
                }
            }
            return lstPreviousVisitBilling;
        }

        public List<UI_BillingItems> GetBillingItems(string Description, string FeeType, int OrgID, int OrgAddress, string Gender, long ClientID, long RateID, string IsMapped)
        {
            List<UI_BillingItems> lstBillingItems = null;
            using (DbHelper gateWay = new DbHelper())
            {

                var cmd = KernelV2_Command.pGetBillingItems_V2Command(Description, FeeType, OrgID, OrgAddress, Gender, ClientID, RateID, IsMapped, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    lstBillingItems = Utility.Tolist<UI_BillingItems>(dataReader).ToList();
                }
            }
            return lstBillingItems;
        }

        public UI_BillingItemsDetails GetBillingItemsDetails(int OrgID, int FeeID, string FeeType, long ClientID, long VisitID, string IsCollected, DateTime CollectedDatetime)
        {
            UI_BillingItemsDetails objBillingDetailsItems = null;
            using (DbHelper gateWay = new DbHelper())
            {

                var cmd = KernelV2_Command.pGetBillingItemsDetails_V2Command(OrgID, FeeID, FeeType, ClientID, VisitID, IsCollected, CollectedDatetime, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    objBillingDetailsItems = Utility.Tolist<UI_BillingItemsDetails>(dataReader).ToList().FirstOrDefault(); ;
                }
            }
            return objBillingDetailsItems;
        }

        public List<UI_Patient> GetPatientAdvanceSearch(string FirstName, string MiddleName, string LastName, string PatientNo, string PhoneNo, string BookingNo, long ClientID,
            string ClientCode, int OrgID)
        {
            List<UI_Patient> lstPatient = null;
            using (DbHelper gateWay = new DbHelper())
            {

                var cmd = KernelV2_Command.pGetQuickPatientAdvanceSearch_V2Command(FirstName, MiddleName, LastName, PatientNo, PhoneNo, BookingNo, ClientID, ClientCode, OrgID,
                    KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    lstPatient = Utility.Tolist<UI_Patient>(dataReader).ToList();
                }
            }
            return lstPatient;
        }

        public List<UI_OrderedInvestigations> GetHealthPackageDataSearch(int OrgID, string GroupName, int PkgID)
        {
            List<UI_OrderedInvestigations> lstOrderedInvestigations = null;
            using (DbHelper gateWay = new DbHelper())
            {

                var cmd = KernelV2_Command.pGetHealthPackageDataSearch_V2Command(OrgID, GroupName, PkgID, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    lstOrderedInvestigations = Utility.Tolist<UI_OrderedInvestigations>(dataReader).ToList();
                }
            }
            return lstOrderedInvestigations;
        }

        public long SaveDocument(List<UI_TRFFileUpload> lstTRFFileUpload)
        {

            long returnstatus = -1;
            DataTable dtFileUpload;
            dtFileUpload = UDT_DAL.ConvertToTRFfilemanager(lstTRFFileUpload);

            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pInsertTRFDetails_V2Command(dtFileUpload, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
               returnstatus= gateWay.ExecuteNonQuery(cmd);
                
            }

            return returnstatus;
        }


        public void SaveHistoryQuickBilling(long PatientID, long VisitID, int pOrgID,long pLoginID, List<UI_HistoryAttributes> lstHistoryAttributes)
        {
            DataTable dtHistory = UDT_DAL.ConvertToInvHistoryAttributes(lstHistoryAttributes);
            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pSaveHistoryCommand(dtHistory, pOrgID, pLoginID, VisitID, PatientID, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                gateWay.ExecuteNonQuery(cmd);
            }
           
        }


        public UI_BillingPart InsertPatientBilling(UI_Patient Patient,   List<UI_MetaValues> DispatchMode, UI_ClientMaster ClientReference,
        UI_BillingPatientAdditionalDetails AdditionalDetails, List<UI_PatientDueChart> PatientDueChart, List<UI_AmountReceivedDetails> AmountReceivedDetails,
        List<UI_OrderedInvestigations> OrderedInvestigations, List<UI_OrderedInvestigations> UnOrderedInvestigations, List<UI_ControlMappingDetails> ControlMappingDetails,
        List<UI_VisitClientMapping> VisitClientMapping, List<UI_PatientRedemDetails> PatientRedemDetails, UI_URNTypes URN, UI_FinalBillDetails FinalBillDetails, long NationalityID,
        long CountryID, long StateID, UI_City City)
        {
            UI_BillingPart BillingPart = null;
            DataTable dtPatientDueChart = UDT_DAL.ConvertToUDTPatientDueChart(PatientDueChart);
            DataTable dtAmountReceivedDetails = UDT_DAL.ConvertToUDTAmountReceivedDetails(AmountReceivedDetails);
            DataTable dtOrderedInvestigations = UDT_DAL.ConvertToUDTOrderedInvestigation(OrderedInvestigations);
            DataTable dtControlMappingDetails = UDT_DAL.ConvertToUDTControlMappingDetails(ControlMappingDetails);
            DataTable dtVisitClientMapping = UDT_DAL.ConvertToUDTVisitClientMapping(VisitClientMapping);
            DataTable dtDiscount = UDT_DAL.ConvertToUDTPatientDiscount(FinalBillDetails.BillDiscount == null ? new UI_PatientDiscount() : FinalBillDetails.BillDiscount);
            DataTable dtDespatchMode = UDT_DAL.ConvertToUDTClientDespatchmode(DispatchMode);
            DataTable dtPatientRedemDetails = UDT_DAL.ConvertToPatientRedemDetails(PatientRedemDetails);
            DataTable dtUnOrderedInvestigations = UDT_DAL.ConvertToUDTOrderedInvestigation(UnOrderedInvestigations);
            
            DataTable dtContextInfo = KernelV2_UDT.ConvertToUDT_Context(globalContextDetails);
            using (DbHelper gateWay = new DbHelper())
            {
                Patient.DOB = Convert.ToDateTime(Patient.DOB1);

                var cmd = KernelV2_Command.pInsertPatientBilling_V2Command(
                Patient.PatientID <= 0 ? -1 : Patient.PatientID, Patient.OrgID, Patient.OrgAddressID,
                globalContextDetails.LoginID, Patient.PatientName, Patient.Salutation.TitleID, Patient.Gender.Code ?? "M", Patient.Age ?? "0 Year(s)", Patient.PatientNumber ?? "",
                Patient.Add1 ?? "", Patient.Add2 ?? "", Patient.Add3 ?? "", City.CityName ?? "", Patient.LandLineNumber ?? "", Patient.MobileNumber ?? "",
                Patient.MartialStatus ?? "", Patient.DOB, Patient.PatientName, NationalityID, StateID, CountryID, Patient.PostalCode ?? "", Patient.EMail ?? "",
                AdditionalDetails.IsNotifyType, URN.URN ?? "", URN.URNofId, URN.URNTypeId, AdditionalDetails.PatientHistory ?? "", AdditionalDetails.PatientType ?? "",
                Patient.PatientStatus ?? "", Patient.VisitPurposeID, AdditionalDetails.SecuredCode ?? "", AdditionalDetails.PriorityID, Patient.IsExternelPatient,
                ClientReference.WardNo ?? "", AdditionalDetails.EpisodeID, AdditionalDetails.EpisodeVisitID, Patient.PatientVisitID,
                ClientReference.ReferringPhysician != null ? ClientReference.ReferringPhysician.ReferringPhysicianID : 0, ClientReference.ReferringPhysician != null ? ClientReference.ReferringPhysician.ReferringPhysicianName : "",
                ClientReference.ReferringHospital != null ? ClientReference.ReferringHospital.ReferringHospitalID : 0, ClientReference.ReferringHospital != null ? ClientReference.ReferringHospital.ReferringHospitalName : "",
                AdditionalDetails.ReferedSpecialityID, AdditionalDetails.SpecialtyID, AdditionalDetails.ReferralType ?? "", FinalBillDetails.GrossBillValue, FinalBillDetails.DiscountAmount,
                FinalBillDetails.DiscountReason ?? "", AdditionalDetails.DiscountApprovedBy, FinalBillDetails.TaxAmount, FinalBillDetails.ServiceCharge, FinalBillDetails.RoundOff,
                FinalBillDetails.NetValue, FinalBillDetails.Due, dtPatientDueChart, ClientReference.IsCreditBill ?? "N", dtAmountReceivedDetails, dtOrderedInvestigations,
                AdditionalDetails.EpisodeTrackID, AdditionalDetails.SiteID, Patient.SamplePickupDate, AdditionalDetails.ConsignmentNo ?? "", dtControlMappingDetails,
                AdditionalDetails.RegistrationRemarks ?? "", Patient.ExternalPatientNumber ?? "", dtDespatchMode, AdditionalDetails.IsEditMode ?? "N", AdditionalDetails.VisitTypeID,
                AdditionalDetails.PatientStausID, dtContextInfo, dtVisitClientMapping, globalContextDetails.LocationID, AdditionalDetails.VisitID, AdditionalDetails.PhleboID,
                AdditionalDetails.LogisticsID, AdditionalDetails.RoundNo ?? "", AdditionalDetails.ExAutoAuthorization ?? "N", AdditionalDetails.Confidential ?? "",
                AdditionalDetails.ParentPatientID, AdditionalDetails.ExternalVisitID ?? "", AdditionalDetails.ApprovalNo ?? "", AdditionalDetails.NewPassword ?? "",
                AdditionalDetails.ZoneId, AdditionalDetails.UnknownFlag, AdditionalDetails.DiscountID, AdditionalDetails.IsCopay ?? "N", dtDiscount, AdditionalDetails.IsFoc ?? "",
                AdditionalDetails.MyCardActiveDays ?? "", AdditionalDetails.MemebershipcardType ?? "", AdditionalDetails.HealthCardType ?? "", AdditionalDetails.OTP ?? "",
                AdditionalDetails.MembershipCardMappingID, AdditionalDetails.CreditRedeemType ?? "", AdditionalDetails.HasHealthCard ?? "",
                AdditionalDetails.RedemPoints, AdditionalDetails.RedemValue, AdditionalDetails.ExternalVisitType, AdditionalDetails.OrderedID ?? "",
                AdditionalDetails.MigratedvisitNumber ?? "", AdditionalDetails.MigratedRequestNumber ?? "", dtPatientRedemDetails, dtUnOrderedInvestigations,
                AdditionalDetails.ClientFlag ?? "", AdditionalDetails.CollectionID, AdditionalDetails.EmailCCAddress ?? "", AdditionalDetails.Value ?? "",
                AdditionalDetails.VisitNumber ?? "", AdditionalDetails.ClinicCode ?? "", Patient.FirstName ?? "", Patient.MiddleName ?? "",
                Patient.LastName ?? "", AdditionalDetails.SpeciesID, City.CityId, AdditionalDetails.SuburbID, AdditionalDetails.RefdoctorId ?? "",
                AdditionalDetails.RefPhysicianPNo ?? "", AdditionalDetails.ReportMode ?? "", AdditionalDetails.SpeciesName ?? "");

                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    BillingPart = Utility.ToObject<UI_BillingPart>(dataReader);
                }
            }
            return BillingPart;
        }

        public List<UI_OrderedInvestigations> GetPaymentMode(long FinalBillID, long VisitID, string ReceiptNo, int payingPage)
        {
            List<UI_OrderedInvestigations> lstOrderedInvestigations = null;
            using (DbHelper gateWay = new DbHelper())
            {

                var cmd = KernelV2_Command.pGetPaymentMode_V2Command(FinalBillID, VisitID, ReceiptNo, payingPage, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    lstOrderedInvestigations = Utility.Tolist<UI_OrderedInvestigations>(dataReader).ToList();
                }
            }
            return lstOrderedInvestigations;
        }

        public UI_BillPrint GetBillPrinting(long VisitID, string PhysicianName, long BillID, string SplitStatus)
        {
            UI_BillPrint objBillPrint = null;
            using (DbHelper gateWay = new DbHelper())
            {
                var cmd = KernelV2_Command.pGetBillPrinting_V2Command(VisitID, PhysicianName, BillID, SplitStatus, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    objBillPrint = new UI_BillPrint();
                    objBillPrint.lstBillingDetails = Utility.Tolist<UI_PrintBillingDetails>(dataReader).ToList();
                    if (dataReader.NextResult())
                    {
                        objBillPrint.lstFinalBillDetails = Utility.Tolist<UI_PrintFinalBill>(dataReader).ToList();
                    }
                    if (dataReader.NextResult())
                    {
                        objBillPrint.objPatient = Utility.ToObject<UI_PrintPatient>(dataReader);
                    }
                }
            }
            return objBillPrint;
        }
       
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
