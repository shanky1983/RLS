using System;
using System.Collections.Generic;
using System.Data;
using Attune.KernelV2.Entities;

namespace Attune.KernelV2.UDT
{
    public static class UDT_DAL
    {

        public static DataTable ConvertToLoginDetail(UI_LoginDetail _list)
        {

            DataTable _datatable = new DataTable();

            _datatable.Columns.Add("LoginID", typeof(Int64));
            _datatable.Columns.Add("RoleID", typeof(Int64));
            _datatable.Columns.Add("Orgid", typeof(Int32));
            _datatable.Columns.Add("DummyString", typeof(String));

            DataRow _datarow;


            _datarow = _datatable.NewRow();
            _datarow["LoginID"] = _list.LoginID;
            _datarow["RoleID"] = _list.RoleID;
            _datarow["Orgid"] = _list.Orgid;
            _datarow["DummyString"] = _list.DummyString;
            _datatable.Rows.Add(_datarow);

            return _datatable;

        }

        public static DataTable ConvertToUDTMetaData(List<UI_MetaData> _lstCollection)
        {

            DataTable _datatable = new DataTable();

            _datatable.Columns.Add("MetaDataID", typeof(Int32));
            _datatable.Columns.Add("Domain", typeof(String));
            _datatable.Columns.Add("Code", typeof(String));
            _datatable.Columns.Add("DisplayText", typeof(String));
            _datatable.Columns.Add("LangCode", typeof(String));

            DataRow _datarow;

            foreach (UI_MetaData _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["MetaDataID"] = _list.MetaDataID;
                _datarow["Domain"] = _list.Domain;
                _datarow["Code"] = _list.Code;
                _datarow["DisplayText"] = _list.DisplayText;
                _datarow["LangCode"] = _list.LangCode;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;

        }

        public static DataTable ConvertToUDTPatientDueChart(List<UI_PatientDueChart> _lstCollection)
        {
            DataTable _datatable = new DataTable();
            _datatable.Columns.Add("FeeType", typeof(String));
            _datatable.Columns.Add("FeeID", typeof(Int64));
            _datatable.Columns.Add("Description", typeof(String));
            _datatable.Columns.Add("Comments", typeof(String));
            _datatable.Columns.Add("FromDate", typeof(DateTime));
            _datatable.Columns.Add("ToDate", typeof(DateTime));
            _datatable.Columns.Add("Status", typeof(String));
            _datatable.Columns.Add("unit", typeof(Decimal));
            _datatable.Columns.Add("Amount", typeof(Decimal));
            _datatable.Columns.Add("DetailsID", typeof(Int64));
            _datatable.Columns.Add("PackageID", typeof(Int64));
            _datatable.Columns.Add("SpecialityID", typeof(Int32));
            _datatable.Columns.Add("UserID", typeof(Int64));
            _datatable.Columns.Add("DiscountAmount", typeof(Decimal));
            _datatable.Columns.Add("IsReimbursable", typeof(String));
            _datatable.Columns.Add("IsTaxable", typeof(String));
            _datatable.Columns.Add("ServiceCode", typeof(String));
            _datatable.Columns.Add("DiscountPercent", typeof(Decimal));
            _datatable.Columns.Add("DiscOrEnhanceType", typeof(String));
            _datatable.Columns.Add("Remarks", typeof(String));
            _datatable.Columns.Add("ReimbursableAmount", typeof(Decimal));
            _datatable.Columns.Add("NonReimbursableAmount", typeof(Decimal));
            _datatable.Columns.Add("ActualAmount", typeof(Decimal));
            _datatable.Columns.Add("RateID", typeof(Int64));
            _datatable.Columns.Add("IsDiscountable", typeof(String));
            _datatable.Columns.Add("IsSTAT", typeof(String));
            _datatable.Columns.Add("IsOutSource", typeof(String));
            _datatable.Columns.Add("IsNABL", typeof(String));
            _datatable.Columns.Add("TatDate", typeof(DateTime));
            //_datatable.Columns.Add("ReportDate", typeof(System.DateTime));
            _datatable.Columns.Add("BaseRateID", typeof(Int64));
            _datatable.Columns.Add("DiscountPolicyID", typeof(Int64));
            _datatable.Columns.Add("DiscountCategoryCode", typeof(String));
            _datatable.Columns.Add("ReportDeliveryDate", typeof(DateTime));
            _datatable.Columns.Add("MaxTestDisPercentage", typeof(Decimal));
            _datatable.Columns.Add("MaxTestDisAmount", typeof(Decimal));
            _datatable.Columns.Add("BaseTestcalculationAmount", typeof(Decimal));
            _datatable.Columns.Add("IsRedeem", typeof(String));
            _datatable.Columns.Add("RedeemAmount", typeof(Decimal));
            _datatable.Columns.Add("RedeemPoints", typeof(Decimal));
            _datatable.Columns.Add("ClientFeeTypeRateCustID", typeof(Int64));
            _datatable.Columns.Add("DiscOrEnhanceRemarks", typeof(String));
            _datatable.Columns.Add("DiscOrEnhancePercent", typeof(Decimal));
            _datatable.Columns.Add("ReferralID", typeof(Int32));
            _datatable.Columns.Add("ReferralType", typeof(String));
            _datatable.Columns.Add("ItemCurrencyId", typeof(System.Int64));
            _datatable.Columns.Add("Tatreferencedatetime", typeof(System.DateTime));
            _datatable.Columns.Add("Tatreferencedatebase", typeof(System.Int32));
            _datatable.Columns.Add("Tatsamplereceiptdatetime", typeof(System.DateTime));
            _datatable.Columns.Add("Tatprocessstartdatetime", typeof(System.DateTime));
            _datatable.Columns.Add("Logistictimeinmins", typeof(System.Int16));
            _datatable.Columns.Add("Processingtimeinmins", typeof(System.Int32));
            _datatable.Columns.Add("Labendtime", typeof(System.String));
            _datatable.Columns.Add("Earlyreporttime", typeof(System.String));


            DataRow _datarow;

            foreach (UI_PatientDueChart _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                if (_list.FeeType.Contains("nbsp;"))
                    _datarow["FeeType"] = "OTH";
                else
                    _datarow["FeeType"] = _list.FeeType;

                _datarow["FeeType"] = _list.FeeType;
                _datarow["FeeID"] = _list.FeeID;          //inv.GroupID;
                _datarow["Description"] = _list.Description;  //inv.GroupName;
                _datarow["Comments"] = _list.Comments;
                _datarow["FromDate"] = _list.FromDate;
                _datarow["ToDate"] = _list.ToDate;
                _datarow["Status"] = _list.Status;
                _datarow["unit"] = _list.unit;
                _datarow["Amount"] = _list.Amount;
                _datarow["DetailsID"] = _list.DetailsID;
                _datarow["PackageID"] = _list.PackageID;
                _datarow["SpecialityID"] = _list.SpecialityID;
                _datarow["UserID"] = _list.UserID;
                _datarow["DiscountAmount"] = _list.DiscountAmount;
                _datarow["IsReimbursable"] = _list.IsReimbursable;
                _datarow["IsTaxable"] = _list.IsTaxable;
                _datarow["ServiceCode"] = _list.ServiceCode;
                _datarow["DiscountPercent"] = _list.DiscountPercent;
                _datarow["DiscOrEnhanceType"] = _list.DiscOrEnhanceType;
                _datarow["Remarks"] = _list.Remarks;
                _datarow["ReimbursableAmount"] = _list.ReimbursableAmount;
                _datarow["NonReimbursableAmount"] = _list.NonReimbursableAmount;
                _datarow["ActualAmount"] = _list.ActualAmount;
                _datarow["RateID"] = _list.RateID;
                _datarow["IsDiscountable"] = _list.IsDiscountable;
                _datarow["IsSTAT"] = _list.IsSTAT;
                _datarow["IsOutSource"] = "N";
                _datarow["IsNABL"] = _list.IsNABL;
                _datarow["TatDate"] = string.IsNullOrEmpty(_list.TatDate) ? Convert.ToDateTime("01/01/1753") : Convert.ToDateTime(_list.TatDate);
                //_datarow["ReportDate"] = _list.TatDate;
                _datarow["BaseRateID"] = _list.BaseRateID;
                _datarow["DiscountPolicyID"] = _list.DiscountPolicyID;
                _datarow["DiscountCategoryCode"] = _list.DiscountCategoryCode;
                _datarow["ReportDeliveryDate"] = string.IsNullOrEmpty(_list.ReportDeliveryDate) ? Convert.ToDateTime("01/01/1753") : Convert.ToDateTime(_list.ReportDeliveryDate); ;
                _datarow["MaxTestDisPercentage"] = _list.MaxTestDisPercentage;
                _datarow["MaxTestDisAmount"] = _list.MaxTestDisAmount;
                _datarow["BaseTestcalculationAmount"] = _list.BaseTestcalculationAmount;
                _datarow["IsRedeem"] = _list.IsRedeem;
                _datarow["RedeemAmount"] = _list.RedeemAmount;
                _datarow["RedeemPoints"] = _list.RedeemPoints;
                _datarow["ClientFeeTypeRateCustID"] = _list.ClientFeeTypeRateCustID;
                _datarow["DiscOrEnhanceRemarks"] = _list.DiscOrEnhanceRemarks;
                _datarow["DiscOrEnhancePercent"] = _list.DiscOrEnhancePercent;
                _datarow["ReferralType"] = _list.ReferralType;
                _datarow["ReferralID"] = _list.ReferralID;
                _datarow["ItemCurrencyId"] = _list.ItemCurrencyID;
                _datarow["Tatreferencedatetime"] = _list.Tatreferencedatetime;
                _datarow["Tatreferencedatebase"] = _list.Tatreferencedatebase;
                _datarow["Tatsamplereceiptdatetime"] = _list.Tatsamplereceiptdatetime;
                _datarow["Tatprocessstartdatetime"] = _list.Tatprocessstartdatetime;
                _datarow["Logistictimeinmins"] = _list.Logistictimeinmins;
                _datarow["Processingtimeinmins"] = _list.Processingtimeinmins;
                _datarow["Labendtime"] = _list.Labendtime;
                _datarow["Earlyreporttime"] = _list.Earlyreporttime;

                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }

        public static DataTable ConvertToOrderedInvestigation(List<UI_OrderedInvestigations> _lstCollection)
        {

            DataTable _datatable = new DataTable();

            _datatable.Columns.Add("Name", typeof(String));
            _datatable.Columns.Add("ID", typeof(Int64));
            _datatable.Columns.Add("VisitID", typeof(Int64));
            _datatable.Columns.Add("CreatedBy", typeof(Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(Int64));
            _datatable.Columns.Add("Status", typeof(String));
            _datatable.Columns.Add("Type", typeof(String));
            _datatable.Columns.Add("OrgID", typeof(Int32));
            _datatable.Columns.Add("StudyInstanceUId", typeof(String));
            _datatable.Columns.Add("ComplaintId", typeof(Int32));
            _datatable.Columns.Add("ReferedToOrgID", typeof(Int32));
            _datatable.Columns.Add("ReferedToLocation", typeof(Int32));
            _datatable.Columns.Add("InvestigationsType", typeof(String));
            _datatable.Columns.Add("ReferralID", typeof(Int64));
            _datatable.Columns.Add("UID", typeof(String));
            _datatable.Columns.Add("ReferenceType", typeof(String));
            _datatable.Columns.Add("RefPhyName", typeof(String));
            _datatable.Columns.Add("RefPhysicianID", typeof(Int64));
            _datatable.Columns.Add("SequenceNo", typeof(Int32));
            _datatable.Columns.Add("ReportDateTime", typeof(DateTime));
            _datatable.Columns.Add("TatDateTime", typeof(DateTime));
            _datatable.Columns.Add("IsStat", typeof(String));
            _datatable.Columns.Add("SampleID", typeof(String));
            _datatable.Columns.Add("TestSequenceOrder", typeof(System.Int32));

            DataRow _datarow;

            foreach (UI_OrderedInvestigations _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["Name"] = _list.Name;
                _datarow["ID"] = _list.ID;
                _datarow["VisitID"] = _list.VisitID;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["Status"] = _list.Status;
                _datarow["Type"] = _list.Type;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["StudyInstanceUId"] = _list.StudyInstanceUId;
                _datarow["ComplaintId"] = _list.ComplaintId;
                _datarow["ReferedToOrgID"] = _list.ReferedToOrgID;
                _datarow["ReferedToLocation"] = _list.ReferedToLocation;
                _datarow["InvestigationsType"] = _list.InvestigationsType;
                _datarow["ReferralID"] = _list.ReferralID;
                _datarow["UID"] = _list.UID;
                _datarow["ReferenceType"] = _list.ReferenceType;
                _datarow["RefPhyName"] = _list.RefPhyName;
                _datarow["RefPhysicianID"] = _list.RefPhysicianID;
                _datarow["SequenceNo"] = _list.SequenceNo;
                _datarow["ReportDateTime"] = _list.ReportDateTime;
                _datarow["TatDateTime"] = _list.TatDateTime;
                _datarow["IsStat"] = _list.IsStat;
                _datarow["SampleID"] = _list.SampleID;
                _datarow["TestSequenceOrder"] = _list.TestSequenceOrder;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }

        public static DataTable ConvertToUDTAmountReceivedDetails(List<UI_AmountReceivedDetails> _lstCollection)
        {

            DataTable _datatable = new DataTable();
            _datatable.Columns.Add("AmtReceived", typeof(System.Decimal));
            _datatable.Columns.Add("TypeID", typeof(System.Int32));
            _datatable.Columns.Add("ChequeorCardNumber", typeof(System.String));
            _datatable.Columns.Add("BankNameorCardType", typeof(System.String));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            _datatable.Columns.Add("ChequeValidDate", typeof(System.DateTime));
            _datatable.Columns.Add("ServiceCharge", typeof(System.Decimal));
            _datatable.Columns.Add("BaseCurrencyID", typeof(System.Int32));
            _datatable.Columns.Add("PaidCurrencyID", typeof(System.Int32));
            _datatable.Columns.Add("OtherCurrencyAmount", typeof(System.Decimal));
            _datatable.Columns.Add("EMIOpted", typeof(System.String));
            _datatable.Columns.Add("EMIROI", typeof(System.Decimal));
            _datatable.Columns.Add("EMITenor", typeof(System.Int32));
            _datatable.Columns.Add("EMIValue", typeof(System.Decimal));
            _datatable.Columns.Add("ReferenceID", typeof(System.Int64));
            _datatable.Columns.Add("ReferenceType", typeof(System.String));
            _datatable.Columns.Add("Units", typeof(System.Int32));
            _datatable.Columns.Add("CardHolderName", typeof(System.String));
            _datatable.Columns.Add("CashGiven", typeof(System.Decimal));
            _datatable.Columns.Add("BalanceGiven", typeof(System.Decimal));
            _datatable.Columns.Add("TransactionID", typeof(System.String));
            _datatable.Columns.Add("BranchName", typeof(System.String));
            _datatable.Columns.Add("PaymentCollectedFrom", typeof(System.String));
            _datatable.Columns.Add("IsOutStation", typeof(System.String));
            _datatable.Columns.Add("AmtReceivedID", typeof(System.Int64));
            _datatable.Columns.Add("AuthorisationCode", typeof(System.String));

            DataRow _datarow;

            foreach (UI_AmountReceivedDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["AmtReceived"] = _list.AmtReceived;
                _datarow["TypeID"] = _list.TypeID;
                _datarow["ChequeorCardNumber"] = _list.ChequeorCardNumber;
                _datarow["BankNameorCardType"] = _list.BankNameorCardType;
                _datarow["Remarks"] = _list.Remarks;
                _datarow["ChequeValidDate"] = _list.ChequeValidDate;
                _datarow["ServiceCharge"] = _list.ServiceCharge;
                _datarow["BaseCurrencyID"] = _list.BaseCurrencyID;
                _datarow["PaidCurrencyID"] = _list.PaidCurrencyID;
                _datarow["OtherCurrencyAmount"] = _list.OtherCurrencyAmount;
                _datarow["EMIOpted"] = _list.EMIOpted;
                _datarow["EMIROI"] = _list.EMIROI;
                _datarow["EMITenor"] = _list.EMITenor;
                _datarow["EMIValue"] = _list.EMIValue;
                _datarow["ReferenceID"] = _list.ReferenceID;
                _datarow["ReferenceType"] = _list.ReferenceType;
                _datarow["Units"] = _list.Units;
                _datarow["CardHolderName"] = _list.CardHolderName;
                _datarow["CashGiven"] = _list.CashGiven;
                _datarow["BalanceGiven"] = _list.BalanceGiven;
                _datarow["TransactionID"] = _list.TransactionID;
                _datarow["BranchName"] = _list.BranchName;
                _datarow["PaymentCollectedFrom"] = _list.PaymentCollectedFrom;
                _datarow["IsOutStation"] = _list.IsOutStation;
                _datarow["AmtReceivedID"] = _list.AmtReceivedID;
                _datarow["AuthorisationCode"] = _list.AuthorisationCode;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }

        public static DataTable ConvertToUDTOrderedInvestigation(List<UI_OrderedInvestigations> _lstCollection)
        {

            DataTable _datatable = new DataTable();

            _datatable.Columns.Add("Name", typeof(String));
            _datatable.Columns.Add("ID", typeof(Int64));
            _datatable.Columns.Add("VisitID", typeof(Int64));
            _datatable.Columns.Add("CreatedBy", typeof(Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(Int64));
            _datatable.Columns.Add("Status", typeof(String));
            _datatable.Columns.Add("Type", typeof(String));
            _datatable.Columns.Add("OrgID", typeof(Int32));
            _datatable.Columns.Add("StudyInstanceUId", typeof(String));
            _datatable.Columns.Add("ComplaintId", typeof(Int32));
            _datatable.Columns.Add("ReferedToOrgID", typeof(Int32));
            _datatable.Columns.Add("ReferedToLocation", typeof(Int32));
            _datatable.Columns.Add("InvestigationsType", typeof(String));
            _datatable.Columns.Add("ReferralID", typeof(Int64));
            _datatable.Columns.Add("UID", typeof(String));
            _datatable.Columns.Add("ReferenceType", typeof(String));
            _datatable.Columns.Add("RefPhyName", typeof(String));
            _datatable.Columns.Add("RefPhysicianID", typeof(Int64));
            _datatable.Columns.Add("SequenceNo", typeof(Int32));
            _datatable.Columns.Add("ReportDateTime", typeof(DateTime));
            _datatable.Columns.Add("TatDateTime", typeof(DateTime));
            _datatable.Columns.Add("IsStat", typeof(String));
            _datatable.Columns.Add("SampleID", typeof(String));
            _datatable.Columns.Add("TestSequenceOrder", typeof(System.Int32));
            DataRow _datarow;

            foreach (UI_OrderedInvestigations _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["Name"] = _list.Name;
                _datarow["ID"] = _list.ID;
                _datarow["VisitID"] = _list.VisitID;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["Status"] = _list.Status;
                _datarow["Type"] = _list.Type;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["StudyInstanceUId"] = _list.StudyInstanceUId;
                _datarow["ComplaintId"] = _list.ComplaintId;
                _datarow["ReferedToOrgID"] = _list.ReferedToOrgID;
                _datarow["ReferedToLocation"] = _list.ReferedToLocation;
                _datarow["InvestigationsType"] = _list.InvestigationsType;
                _datarow["ReferralID"] = _list.ReferralID;
                _datarow["UID"] = _list.UID;
                _datarow["ReferenceType"] = _list.ReferenceType;
                _datarow["RefPhyName"] = _list.RefPhyName;
                _datarow["RefPhysicianID"] = _list.RefPhysicianID;
                _datarow["SequenceNo"] = _list.SequenceNo;
                _datarow["ReportDateTime"] = _list.ReportDateTime;
                _datarow["TatDateTime"] = _list.TatDateTime;
                _datarow["IsStat"] = _list.IsStat;
                _datarow["SampleID"] = _list.SampleID;
                _datarow["TestSequenceOrder"] = _list.TestSequenceOrder;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }

        public static DataTable ConvertToUDTControlMappingDetails(List<UI_ControlMappingDetails> _lstCollection)
        {
            DataTable _datatable = new DataTable();

            _datatable.Columns.Add("ControlTypeID", typeof(Int32));
            _datatable.Columns.Add("ControlName", typeof(String));
            _datatable.Columns.Add("ControlCode", typeof(String));
            _datatable.Columns.Add("ControlMappingID", typeof(Int64));
            _datatable.Columns.Add("DisplayText", typeof(String));
            _datatable.Columns.Add("OrgID", typeof(Int32));
            _datatable.Columns.Add("ReferenceID", typeof(Int64));
            _datatable.Columns.Add("ReferenceType", typeof(String));
            _datatable.Columns.Add("SequenceNo", typeof(Int32));
            _datatable.Columns.Add("ControlValueID", typeof(Int64));
            _datatable.Columns.Add("ControlValue", typeof(String));
            _datatable.Columns.Add("Description", typeof(String));
            _datatable.Columns.Add("ID", typeof(Int64));

            DataRow _datarow;

            foreach (UI_ControlMappingDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ControlTypeID"] = _list.ControlTypeID;
                _datarow["ControlName"] = _list.ControlName;
                _datarow["ControlCode"] = _list.ControlCode;
                _datarow["ControlMappingID"] = _list.ControlMappingID;
                _datarow["DisplayText"] = _list.DisplayText;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["ReferenceID"] = _list.ReferenceID;
                _datarow["ReferenceType"] = _list.ReferenceType;
                _datarow["SequenceNo"] = _list.SequenceNo;
                _datarow["ControlValueID"] = _list.ControlValueID;
                _datarow["ControlValue"] = _list.ControlValue;
                _datarow["Description"] = _list.Description;
                _datarow["ID"] = _list.ID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }

        public static DataTable ConvertToUDTVisitClientMapping(List<UI_VisitClientMapping> _lstCollection)
        {
            DataTable _datatable = new DataTable();

            _datatable.Columns.Add("VisitClientMappingID", typeof(Int64));
            _datatable.Columns.Add("VisitID", typeof(Int64));
            _datatable.Columns.Add("ClientID", typeof(Int64));
            _datatable.Columns.Add("FinalBillID", typeof(Int64));
            _datatable.Columns.Add("RateID", typeof(Int64));
            _datatable.Columns.Add("OrgID", typeof(Int32));
            _datatable.Columns.Add("PreAuthAmount", typeof(Decimal));
            _datatable.Columns.Add("PreAuthApprovalNumber", typeof(String));
            _datatable.Columns.Add("ClaimAmount", typeof(Decimal));
            _datatable.Columns.Add("ClaimLogic", typeof(Int32));
            _datatable.Columns.Add("CoPayment", typeof(Decimal));
            _datatable.Columns.Add("CopaymentPercent", typeof(Decimal));
            _datatable.Columns.Add("CoPaymentLogic", typeof(Int32));
            _datatable.Columns.Add("NonMedicalAmount", typeof(Decimal));
            _datatable.Columns.Add("ClientAttributes", typeof(String));
            _datatable.Columns.Add("IsAllMedical", typeof(String));
            _datatable.Columns.Add("PaymentStatus", typeof(String));
            _datatable.Columns.Add("ClientName", typeof(String));
            _datatable.Columns.Add("RateName", typeof(String));
            _datatable.Columns.Add("AsCreditBill", typeof(String));
            _datatable.Columns.Add("PolicyNo", typeof(String));
            _datatable.Columns.Add("PolicyStartDate", typeof(DateTime));
            _datatable.Columns.Add("PolicyEndDate", typeof(DateTime));

            DataRow _datarow;

            foreach (UI_VisitClientMapping _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["VisitClientMappingID"] = _list.VisitClientMappingID;
                _datarow["VisitID"] = _list.VisitID;
                _datarow["ClientID"] = _list.ClientID;
                _datarow["FinalBillID"] = _list.FinalBillID;
                _datarow["RateID"] = _list.RateID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["PreAuthAmount"] = _list.PreAuthAmount;
                _datarow["PreAuthApprovalNumber"] = _list.PreAuthApprovalNumber;
                _datarow["ClaimAmount"] = _list.ClaimAmount;
                _datarow["ClaimLogic"] = _list.ClaimLogic;
                _datarow["CoPayment"] = _list.CoPayment;
                _datarow["CopaymentPercent"] = _list.CopaymentPercent;
                _datarow["CoPaymentLogic"] = _list.CoPaymentLogic;
                _datarow["NonMedicalAmount"] = _list.NonMedicalAmount;
                _datarow["ClientAttributes"] = _list.ClientAttributes;
                _datarow["IsAllMedical"] = _list.IsAllMedical;
                _datarow["PaymentStatus"] = _list.PaymentStatus;
                _datarow["ClientName"] = _list.ClientName;
                _datarow["RateName"] = _list.RateName;
                _datarow["AsCreditBill"] = _list.AsCreditBill;
                _datarow["PolicyNo"] = _list.PolicyNo;
                _datarow["PolicyStartDate"] = _list.PolicyStartDate;
                _datarow["PolicyEndDate"] = _list.PolicyEndDate;

                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }

        public static DataTable ConvertToUDTPatientDiscount(UI_PatientDiscount _list)
        {
            DataTable _datatable = new DataTable();

            _datatable.Columns.Add("DiscountID", typeof(Int64));
            _datatable.Columns.Add("DiscountCode", typeof(String));
            _datatable.Columns.Add("DiscountName", typeof(String));
            _datatable.Columns.Add("DiscountType", typeof(String));
            _datatable.Columns.Add("DiscountCeilingValue", typeof(Decimal));
            _datatable.Columns.Add("UserDiscountValue", typeof(Decimal));
            _datatable.Columns.Add("SlabCeilingValue", typeof(Decimal));
            _datatable.Columns.Add("SlabPercentage", typeof(Decimal));

            DataRow _datarow;


            _datarow = _datatable.NewRow();

            _datarow["DiscountID"] = _list.DiscountID;
            _datarow["DiscountCode"] = _list.DiscountCode;
            _datarow["DiscountName"] = _list.DiscountName;
            _datarow["DiscountType"] = _list.DiscountType;
            _datarow["DiscountCeilingValue"] = _list.DiscountCeilingValue;
            _datarow["UserDiscountValue"] = _list.UserDiscountValue;
            _datarow["SlabCeilingValue"] = _list.SlabCeilingValue;
            _datarow["SlabPercentage"] = _list.SlabPercentage;
            _datatable.Rows.Add(_datarow);

            return _datatable;
        }

        public static DataTable ConvertToUDTClientDespatchmode(List<UI_MetaValues> _lstCollection)
        {
            DataTable _datatable = new DataTable();

            _datatable.Columns.Add("DispatchType", typeof(String));
            _datatable.Columns.Add("DispatchValue", typeof(String));

            DataRow _datarow;

            foreach (UI_MetaValues _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["DispatchType"] = _list.ActionType;
                _datarow["DispatchValue"] = _list.ActionCode;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }

        public static DataTable ConvertToPatientRedemDetails(List<UI_PatientRedemDetails> _lstPatientRedemDetails)
        {
            DataTable _datatable = new DataTable();

            _datatable.Columns.Add("MembershipCardMappingID", typeof(Int32));
            _datatable.Columns.Add("PatientID", typeof(Int64));
            _datatable.Columns.Add("VisitID", typeof(Int64));
            _datatable.Columns.Add("RedemPoints", typeof(Decimal));
            _datatable.Columns.Add("RedemValue", typeof(Decimal));
            _datatable.Columns.Add("Finalbillid", typeof(Int64));


            DataRow _datarow;
            foreach (UI_PatientRedemDetails _list in _lstPatientRedemDetails)
            {
                _datarow = _datatable.NewRow();
                _datarow["MembershipCardMappingID"] = _list.MembershipCardMappingID;
                _datarow["PatientID"] = _list.PatientID;
                _datarow["VisitID"] = _list.VisitID;
                _datarow["RedemPoints"] = _list.RedemPoints;
                _datarow["RedemValue"] = _list.RedemValue;
                _datarow["Finalbillid"] = _list.Finalbillid;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }

        public static DataTable ConvertToUDTInvPackageMapping(List<UI_InvPackageMapping> _lstCollection)
        {
            DataTable _datatable = new DataTable();

            _datatable.Columns.Add("PackageID", typeof(Int32));
            _datatable.Columns.Add("ID", typeof(Int64));
            _datatable.Columns.Add("Type", typeof(String));
            _datatable.Columns.Add("active", typeof(String));
            DataRow _datarow;

            foreach (UI_InvPackageMapping _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PackageID"] = _list.PackageID;
                _datarow["ID"] = _list.ID;
                _datarow["Type"] = _list.Type;
                _datarow["active"] = _list.Active;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }

        public static DataTable ConvertToPatInvestigation(List<UI_PatientInvestigation> _lstCollection)
        {

            DataTable _datatable = new DataTable();
            _datatable.Columns.Add("PatientVisitID", typeof(Int64));
            _datatable.Columns.Add("InvestigationID", typeof(Int64));
            _datatable.Columns.Add("CreatedBy", typeof(Int64));

            DataRow _datarow;

            foreach (UI_PatientInvestigation _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;

        }

        public static DataTable ConvertToPatInvestigation(List<UI_InvestigationIDs> _lstCollection)
        {

            DataTable _datatable = new DataTable();
            _datatable.Columns.Add("PatientVisitID", typeof(Int64));
            _datatable.Columns.Add("InvestigationID", typeof(Int64));
            _datatable.Columns.Add("CreatedBy", typeof(Int64));

            DataRow _datarow;

            foreach (UI_InvestigationIDs _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientVisitID"] = -1;
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datarow["CreatedBy"] = -1;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;

        }

        public static DataTable ConvertToInvestigationQueue(List<UI_InvestigationQueue> _lstCollection)
        {
            DataTable _datatable = new DataTable();

            _datatable.Columns.Add("VisitID", typeof(Int64));
            _datatable.Columns.Add("UID", typeof(String));
            _datatable.Columns.Add("OrgID", typeof(Int32));
            _datatable.Columns.Add("InvestigationID", typeof(Int64));
            _datatable.Columns.Add("Type", typeof(String));
            _datatable.Columns.Add("Status", typeof(String));
            _datatable.Columns.Add("AccessionNumber", typeof(Int64));
            _datatable.Columns.Add("CreatedBy", typeof(Int64));
            _datatable.Columns.Add("IsReportable", typeof(String));
            _datatable.Columns.Add("IsBillable", typeof(String));
            _datatable.Columns.Add("ParentName", typeof(String));
            _datatable.Columns.Add("ParentInvId", typeof(Int32));

            DataRow _datarow;

            foreach (UI_InvestigationQueue _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["VisitID"] = _list.VisitID;
                _datarow["UID"] = _list.UID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datarow["Type"] = _list.Type;
                _datarow["Status"] = _list.Status;
                _datarow["AccessionNumber"] = _list.AccessionNumber;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["IsReportable"] = _list.IsReportable;
                _datarow["IsBillable"] = _list.IsBillable;
                _datarow["ParentName"] = _list.ParentName;
                _datarow["ParentInvId"] = _list.ParentInvId;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }

        public static DataTable ConvertToUDTInvQualitativeResultMaster(List<UI_InvestigationBulkData> _lstCollection)
        {
            DataTable _datatable = new DataTable();

            _datatable.Columns.Add("ResultID", typeof(Int64));
            _datatable.Columns.Add("InvestigationID", typeof(Int64));
            _datatable.Columns.Add("Name", typeof(String));
            _datatable.Columns.Add("Value", typeof(String));
            _datatable.Columns.Add("InvestigationMethodID", typeof(Int64));
            _datatable.Columns.Add("GroupID", typeof(Int64));
            _datatable.Columns.Add("ResultType", typeof(String));

            DataRow _datarow;

            foreach (UI_InvestigationBulkData _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ResultID"] = _list.ResultID;
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datarow["Name"] = _list.Name;
                _datarow["Value"] = _list.Value;
                _datarow["InvestigationMethodID"] = _list.InvestigationMethodID;
                _datarow["GroupID"] = _list.GroupID;
                _datarow["ResultType"] = _list.Type;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }

        public static DataTable ConvertToPatientInvestigation(List<UI_PatientInvestigation> _lstCollection)
        {
            DataTable _datatable = new DataTable();

            _datatable.Columns.Add("InvestigationName", typeof(String));
            _datatable.Columns.Add("InvestigationID", typeof(Int64));
            _datatable.Columns.Add("GroupID", typeof(Int32));
            _datatable.Columns.Add("GroupName", typeof(String));
            _datatable.Columns.Add("GroupComment", typeof(String));
            _datatable.Columns.Add("PatientVisitID", typeof(Int64));
            _datatable.Columns.Add("CreatedBy", typeof(Int64));
            _datatable.Columns.Add("CollectedDateTime", typeof(DateTime));
            _datatable.Columns.Add("Status", typeof(String));
            _datatable.Columns.Add("ComplaintID", typeof(Int32));
            _datatable.Columns.Add("Type", typeof(String));
            _datatable.Columns.Add("OrgID", typeof(Int32));
            _datatable.Columns.Add("InvestigationMethodID", typeof(Int64));
            _datatable.Columns.Add("MethodName", typeof(String));
            _datatable.Columns.Add("KitID", typeof(Int64));
            _datatable.Columns.Add("KitName", typeof(String));
            _datatable.Columns.Add("InstrumentID", typeof(Int64));
            _datatable.Columns.Add("InstrumentName", typeof(String));
            _datatable.Columns.Add("Interpretation", typeof(String));
            _datatable.Columns.Add("PrincipleID", typeof(Int64));
            _datatable.Columns.Add("PrincipleName", typeof(String));
            _datatable.Columns.Add("QCData", typeof(String));
            _datatable.Columns.Add("InvestigationSampleContainerID", typeof(Int32));
            _datatable.Columns.Add("PackageID", typeof(Int32));
            _datatable.Columns.Add("PackageName", typeof(String));
            _datatable.Columns.Add("Reason", typeof(String));
            _datatable.Columns.Add("ReportStatus", typeof(String));
            _datatable.Columns.Add("ReferenceRange", typeof(String));
            _datatable.Columns.Add("PerformingPhysicainName", typeof(String));
            _datatable.Columns.Add("ApprovedBy", typeof(Int64));
            _datatable.Columns.Add("GUID", typeof(String));
            _datatable.Columns.Add("IsAbnormal", typeof(String));
            _datatable.Columns.Add("AccessionNumber", typeof(Int64));
            _datatable.Columns.Add("AutoApproveLoginID", typeof(Int64));
            _datatable.Columns.Add("ValidatedBy", typeof(Int64));
            _datatable.Columns.Add("RemarksID", typeof(Int64));
            _datatable.Columns.Add("MedicalRemarks", typeof(String));
            _datatable.Columns.Add("GroupMedicalRemarks", typeof(String));
            _datatable.Columns.Add("InvSampleStatusID", typeof(Int32));
            _datatable.Columns.Add("AuthorizedBy", typeof(Int64));
            _datatable.Columns.Add("ConvReferenceRange", typeof(String));
            _datatable.Columns.Add("ManualAbnormal", typeof(String));
            _datatable.Columns.Add("IsAutoAuthorize", typeof(String));
            _datatable.Columns.Add("PrintableRange", typeof(String));
            _datatable.Columns.Add("IsAutoValidate", typeof(String));
            _datatable.Columns.Add("InvStatusReasonID", typeof(Int64));
            _datatable.Columns.Add("IsSensitive", typeof(String));
            //_datatable.Columns.Add("TechnicalRemarks", typeof(String));
            DataRow _datarow;

            foreach (UI_PatientInvestigation _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["InvestigationName"] = _list.InvestigationName;
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datarow["GroupID"] = _list.GroupID;
                _datarow["GroupName"] = _list.GroupName;
                _datarow["GroupComment"] = _list.GroupComment;
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["CreatedBy"] = _list.CreatedBy;
                if (_list.CollectedDateTime.CompareTo(DateTime.MinValue) == 0)
                {
                    _datarow["CollectedDateTime"] = DateTime.Now;
                }
                else
                {
                    _datarow["CollectedDateTime"] = _list.CollectedDateTime;
                }
                _datarow["Status"] = _list.Status;
                _datarow["ComplaintID"] = _list.ComplaintId;
                _datarow["Type"] = _list.Type;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["InvestigationMethodID"] = _list.InvestigationMethodID;
                _datarow["MethodName"] = _list.MethodName;
                _datarow["KitID"] = _list.KitID;
                _datarow["KitName"] = _list.KitName;
                _datarow["InstrumentID"] = _list.InstrumentID;
                _datarow["InstrumentName"] = _list.InstrumentName;
                _datarow["Interpretation"] = _list.Interpretation;
                _datarow["PrincipleID"] = _list.PrincipleID;
                _datarow["PrincipleName"] = _list.PrincipleName;
                _datarow["QCData"] = _list.QCData;
                _datarow["InvestigationSampleContainerID"] = _list.InvestigationSampleContainerID;
                _datarow["PackageID"] = _list.PackageID;
                _datarow["PackageName"] = _list.PackageName;
                _datarow["Reason"] = _list.Reason;
                _datarow["ReportStatus"] = _list.ReportStatus;
                _datarow["ReferenceRange"] = _list.ReferenceRange;
                _datarow["PerformingPhysicainName"] = _list.PerformingPhysicainName;
                _datarow["ApprovedBy"] = _list.ApprovedBy;
                _datarow["GUID"] = _list.UID;
                _datarow["IsAbnormal"] = _list.IsAbnormal;
                _datarow["AccessionNumber"] = _list.AccessionNumber;
                _datarow["AutoApproveLoginID"] = _list.AutoApproveLoginID;
                _datarow["ValidatedBy"] = _list.ValidatedBy;
                _datarow["RemarksID"] = _list.RemarksID;
                _datarow["MedicalRemarks"] = _list.MedicalRemarks;
                _datarow["GroupMedicalRemarks"] = _list.GroupMedicalRemarks;
                _datarow["InvSampleStatusID"] = _list.InvSampleStatusID;
                _datarow["AuthorizedBy"] = _list.AuthorizedBy;
                _datarow["ConvReferenceRange"] = _list.ConvReferenceRange;
                _datarow["ManualAbnormal"] = _list.ManualAbnormal;
                _datarow["IsAutoAuthorize"] = _list.IsAutoAuthorize;
                _datarow["PrintableRange"] = _list.PrintableRange;
                _datarow["IsAutoValidate"] = _list.IsAutoValidate;
                _datarow["InvStatusReasonID"] = _list.InvStatusReasonID;
                _datarow["IsSensitive"] = _list.IsSensitive;
                //_datarow["TechnicalRemarks"] = _list.TechnicalRemarks;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }

        public static DataTable ConvertToUDTinvSampleResults(List<UI_PatientInvSampleResults> _lstCollection)
        {
            DataTable _datatable = new DataTable();

            _datatable.Columns.Add("VisitID", typeof(Int64));
            _datatable.Columns.Add("SampleCode", typeof(Int32));
            _datatable.Columns.Add("AttributesID", typeof(Int32));
            _datatable.Columns.Add("SampleValues", typeof(String));
            _datatable.Columns.Add("SampleDesc", typeof(String));
            _datatable.Columns.Add("CreatedBy", typeof(Int32));
            _datatable.Columns.Add("OrgID", typeof(Int32));

            DataRow _datarow;

            foreach (UI_PatientInvSampleResults _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["VisitID"] = _list.VisitID;
                _datarow["SampleCode"] = _list.SampleCode;
                _datarow["AttributesID"] = _list.AttributesID;
                _datarow["SampleValues"] = _list.SampleValues;
                _datarow["SampleDesc"] = _list.SampleDesc;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["OrgID"] = _list.OrgID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }

        public static DataTable ConvertToPatientInvSampleMapping(List<UI_PatientInvSampleMapping> _lstCollection)
        {
            DataTable _datatable = new DataTable();

            _datatable.Columns.Add("VisitID", typeof(Int64));
            _datatable.Columns.Add("OrgID", typeof(Int32));
            _datatable.Columns.Add("SampleID", typeof(Int32));
            _datatable.Columns.Add("ID", typeof(Int64));
            _datatable.Columns.Add("Type", typeof(String));
            _datatable.Columns.Add("Barcode", typeof(String));
            _datatable.Columns.Add("UniqueID", typeof(String));

            DataRow _datarow;

            foreach (UI_PatientInvSampleMapping _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["VisitID"] = _list.VisitID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["SampleID"] = _list.SampleID;
                _datarow["ID"] = _list.ID;
                _datarow["Type"] = _list.Type;
                _datarow["Barcode"] = _list.Barcode;
                _datarow["UniqueID"] = _list.UID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }

        public static DataTable ConvertToInvestigationResults(List<UI_InvestigationValues> _lstCollection)
        {
            DataTable _datatable = new DataTable();

            _datatable.Columns.Add("Name", typeof(String));
            _datatable.Columns.Add("Value", typeof(String));
            _datatable.Columns.Add("InvestigationID", typeof(Int64));
            _datatable.Columns.Add("GroupID", typeof(Int32));
            _datatable.Columns.Add("PatientVisitID", typeof(Int64));
            _datatable.Columns.Add("UOMID", typeof(String));
            _datatable.Columns.Add("CreatedBy", typeof(Int64));
            _datatable.Columns.Add("UOMCode", typeof(String));
            _datatable.Columns.Add("OrgID", typeof(Int32));
            _datatable.Columns.Add("GroupName", typeof(String));
            _datatable.Columns.Add("Status", typeof(String));
            _datatable.Columns.Add("ModifiedBy", typeof(Int64));
            _datatable.Columns.Add("PackageID", typeof(Int32));
            _datatable.Columns.Add("PackageName", typeof(String));
            _datatable.Columns.Add("SequenceNo", typeof(Int32));
            _datatable.Columns.Add("Dilution", typeof(String));
            _datatable.Columns.Add("RefferalID", typeof(Int64));
            _datatable.Columns.Add("DeviceID", typeof(String));
            _datatable.Columns.Add("DeviceValue", typeof(String));
            _datatable.Columns.Add("Precision", typeof(String));
            _datatable.Columns.Add("GUID", typeof(String));
            _datatable.Columns.Add("DeviceActualValue", typeof(String));
            _datatable.Columns.Add("ConvValue", typeof(String));
            _datatable.Columns.Add("ConvUOMCode", typeof(String));
            _datatable.Columns.Add("DeviceErrorCode", typeof(String));
            _datatable.Columns.Add("IsAbnormal", typeof(String));
            DataRow _datarow;


            foreach (UI_InvestigationValues _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["Name"] = _list.Name;
                _datarow["Value"] = _list.Value;
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datarow["GroupID"] = _list.GroupID;
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["UOMID"] = _list.UOMID;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["UOMCode"] = _list.UOMCode;
                _datarow["OrgID"] = _list.Orgid;
                _datarow["GroupName"] = _list.GroupName;
                _datarow["Status"] = _list.Status;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["PackageID"] = _list.PackageID;
                _datarow["PackageName"] = _list.PackageName;
                _datarow["SequenceNo"] = _list.SequenceNo;
                _datarow["Dilution"] = _list.Dilution;
                _datarow["RefferalID"] = _list.ReferralID;
                _datarow["DeviceID"] = _list.DeviceID;
                _datarow["DeviceValue"] = _list.DeviceValue;
                _datarow["Precision"] = _list.Precision;
                _datarow["GUID"] = _list.GroupID;
                _datarow["DeviceActualValue"] = _list.DeviceActualValue;
                _datarow["ConvValue"] = _list.ConvValue;
                _datarow["ConvUOMCode"] = _list.ConvUOMCode;
                _datarow["DeviceErrorCode"] = _list.DeviceErrorCode;
                _datarow["IsAbnormal"] = _list.IsAbnormal;
                _datatable.Rows.Add(_datarow);

            }
            return _datatable;
        }

        public static DataTable ConvertToFileUploadUDT(List<UI_DocumentUpload> _lstFileUploadDetails)
        {
            DataTable _datatable = new DataTable();
            _datatable.Columns.Add("DocFileIDs", typeof(Int64));
            _datatable.Columns.Add("DocFileName", typeof(String));
            _datatable.Columns.Add("DocFileUrl", typeof(String));
            _datatable.Columns.Add("IdentifyingType", typeof(String));

            DataRow _datarow;
            foreach (UI_DocumentUpload _list in _lstFileUploadDetails)
            {
                if (_list.File != null)
                {
                    _datarow = _datatable.NewRow();
                    _datarow["DocFileIDs"] = _list.FileID;
                    _datarow["DocFileName"] = _list.File.Name;
                    _datarow["DocFileUrl"] = _list.File.FilePath;
                    _datarow["IdentifyingType"] = _list.FileType.Code;
                    _datatable.Rows.Add(_datarow);
                }
            }
            return _datatable;
        }

        public static DataTable ConvertToTRFfilemanager(List<UI_TRFFileUpload> _lstTRF)
        {

            DataTable _datatable = new DataTable();

            _datatable.Columns.Add("FileID", typeof(Int64));
            _datatable.Columns.Add("FileUrl", typeof(String));
            _datatable.Columns.Add("FileName", typeof(String));
            _datatable.Columns.Add("PatientID", typeof(Int64));
            _datatable.Columns.Add("VisitID", typeof(Int64));
            _datatable.Columns.Add("OrgID", typeof(Int32));
            _datatable.Columns.Add("IdentifyingID", typeof(Int64));
            _datatable.Columns.Add("IdentifyingType", typeof(String));
            _datatable.Columns.Add("FilePath", typeof(String));
            _datatable.Columns.Add("Createdby", typeof(Int64));
            _datatable.Columns.Add("Createdat", typeof(DateTime));
            DataRow _datarow;
            foreach (UI_TRFFileUpload _lst in _lstTRF)
            {
                _datarow = _datatable.NewRow();
                _datarow["FileID"] = _lst.FileID;
                _datarow["FileUrl"] = _lst.FileUrl;
                _datarow["FileName"] = _lst.FileName;
                _datarow["PatientID"] = _lst.PatientID;
                _datarow["VisitID"] = _lst.VisitID;
                _datarow["OrgID"] = _lst.OrgID;
                _datarow["IdentifyingID"] = _lst.IdentifyingID;
                _datarow["IdentifyingType"] = _lst.IdentifyingType;
                _datarow["FilePath"] = _lst.FilePath;
                _datarow["Createdby"] = _lst.Createdby;
                _datarow["Createdat"] = _lst.Createdat;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }

        public static DataTable ConvertToIPInvSamples(List<UI_PatientInvSample> _lstCollection)
        {
            DataTable _datatable = new DataTable();

            _datatable.Columns.Add("PatientVisitID", typeof(Int64));
            _datatable.Columns.Add("BarcodeNumber", typeof(String));
            _datatable.Columns.Add("SampleCode", typeof(Int32));
            _datatable.Columns.Add("SampleDesc", typeof(String));
            _datatable.Columns.Add("IPInvSampleCollectionMasterID", typeof(Int64));

            DataRow _datarow;

            foreach (UI_PatientInvSample _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["BarcodeNumber"] = _list.BarcodeNumber;
                _datarow["SampleCode"] = _list.SampleCode;
                _datarow["SampleDesc"] = _list.SampleDesc;
                _datarow["IPInvSampleCollectionMasterID"] = _list.IPInvSampleCollectionMasterID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }

        public static System.Data.DataTable ConvertToPatientAttributesField(List<UI_ClientAttributesKeyFields> _lstClt)
        {
            System.Data.DataTable _datatable = new System.Data.DataTable();
            _datatable.Columns.Add("FieldKey", typeof(System.String));
            _datatable.Columns.Add("FieldValue", typeof(System.String));
            _datatable.Columns.Add("ReferenceID", typeof(System.String));
            _datatable.Columns.Add("ReferenceType", typeof(System.String));

            DataRow _datarow;
            foreach (UI_ClientAttributesKeyFields _list in _lstClt)
            {
                _datarow = _datatable.NewRow();
                _datarow["FieldKey"] = _list.Key;
                _datarow["FieldValue"] = _list.Valuedata;
                _datarow["ReferenceID"] = _list.ReferenceID;
                _datarow["ReferenceType"] = _list.ReferenceType;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }

        public static System.Data.DataTable ConvertToInvHistoryAttributes(List<UI_HistoryAttributes> _lstCollection)
        {

            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
            _datatable.Columns.Add("HistoryID", typeof(System.Int64));
            _datatable.Columns.Add("HistoryName", typeof(System.String));
            _datatable.Columns.Add("AttributeID", typeof(System.Int64));
            _datatable.Columns.Add("AttributeName", typeof(System.String));
            _datatable.Columns.Add("AttributevalueID", typeof(System.Int64));
            _datatable.Columns.Add("AttributeValueName", typeof(System.String));
            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("HasAttribute", typeof(System.String));
            _datatable.Columns.Add("Description", typeof(System.String));


            DataRow _datarow;

            foreach (UI_HistoryAttributes _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datarow["HistoryID"] = _list.HistoryID;
                _datarow["HistoryName"] = _list.HistoryName;
                _datarow["AttributeID"] = _list.AttributeID;
                _datarow["AttributeName"] = _list.AttributeName;
                _datarow["AttributevalueID"] = _list.AttributevalueID;
                _datarow["AttributeValueName"] = _list.AttributeValueName;
                _datarow["Type"] = _list.Type;
                _datarow["HasAttribute"] = _list.HasAttribute;
                _datarow["Description"] = _list.Description;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
    }
}
