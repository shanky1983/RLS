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
using Attune.Podium.ClientEntity;
using Attune.Podium.BusinessEntities.CustomEntities;
namespace Attune.Solution.DAL
{
    public static class UDT_DAL
    {
        public static System.Data.DataTable ConvertToInvestigationAdminRate(List<AdminInvestigationRate> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ID", typeof(System.Int64));
            _datatable.Columns.Add("Amount", typeof(System.Decimal));
            _datatable.Columns.Add("Refrange", typeof(System.String));
            _datatable.Columns.Add("DisplayTxt", typeof(System.String));
            _datatable.Columns.Add("IPAmount", typeof(System.Decimal));
            _datatable.Columns.Add("OPPercent", typeof(System.Decimal));
            _datatable.Columns.Add("IPPercent", typeof(System.Decimal));
            _datatable.Columns.Add("SourceID", typeof(System.Int64));
            _datatable.Columns.Add("UOMCode", typeof(System.String));
            _datatable.Columns.Add("UOMID", typeof(System.Int32));
            _datatable.Columns.Add("TYPE", typeof(System.String));
            _datatable.Columns.Add("MinAdvanceAmt", typeof(System.Decimal));
            _datatable.Columns.Add("LabAmount", typeof(System.Decimal));
            _datatable.Columns.Add("FranchiseeAmount", typeof(System.Decimal));
            DataRow _datarow;

            foreach (AdminInvestigationRate _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ID"] = _list.ID;
                _datarow["Amount"] = _list.Amount;
                _datarow["Refrange"] = _list.ReferenceRange;
                _datarow["DisplayTxt"] = _list.DescriptionName;
                _datarow["IPAmount"] = _list.IPAmount;
                _datarow["OPPercent"] = _list.OPPercent;
                _datarow["IPPercent"] = _list.IPPercent;
                _datarow["SourceID"] = _list.SourceID;
                _datarow["UOMCode"] = _list.UOMCode;
                _datarow["UOMID"] = _list.UOMID;
                _datarow["TYPE"] = _list.Type;
                _datarow["MinAdvanceAmt"] = _list.MinAdvanceAmt;
                _datarow["LabAmount"] = _list.LabAmount;
                _datarow["FranchiseeAmount"] = _list.FranchiseeAmount;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToFeeSplitSeriveDetails(List<FeeSplitSeriveDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("SpecID", typeof(System.Int64));
            _datatable.Columns.Add("ID", typeof(System.Int64));
            _datatable.Columns.Add("RateId", typeof(System.Int64));
            _datatable.Columns.Add("FeeID", typeof(System.Int64));
            _datatable.Columns.Add("SplitOrgID", typeof(System.Int32));
            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("FeeTypeAttributesID", typeof(System.Int32));
            _datatable.Columns.Add("SplitAmount", typeof(System.Decimal));

            DataRow _datarow;

            foreach (FeeSplitSeriveDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["SpecID"] = _list.SpecID;
                _datarow["ID"] = _list.ID;
                _datarow["RateId"] = _list.RateId;
                _datarow["FeeID"] = _list.FeeID;
                _datarow["SplitOrgID"] = _list.OrgID;
                _datarow["Type"] = _list.Type;
                _datarow["FeeTypeAttributesID"] = _list.FeeTypeAttributesID;
                _datarow["SplitAmount"] = _list.Amount;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToRateSubTypeMapping(List<RateSubTypeMapping> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("RateID", typeof(System.Int32));
            _datatable.Columns.Add("RateSubTypeID", typeof(System.Int32));
            _datatable.Columns.Add("TypeOfSubType", typeof(System.String));
            _datatable.Columns.Add("VisitSubTypeID", typeof(System.Int32));

            DataRow _datarow;

            foreach (RateSubTypeMapping _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["Description"] = _list.Description;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["RateID"] = _list.RateID;
                _datarow["RateSubTypeID"] = _list.RateSubTypeID;
                _datarow["TypeOfSubType"] = _list.TypeOfSubType;
                _datarow["VisitSubTypeID"] = _list.VisitSubTypeID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTSurgeryPackageFeeTypeRateMaster(List<SurgeryPackageFeeTypeRateMaster> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("FeeTypeRateMasterID", typeof(System.Int64));
            _datatable.Columns.Add("PackageID", typeof(System.Int64));
            _datatable.Columns.Add("Feetype", typeof(System.String));
            _datatable.Columns.Add("RateID", typeof(System.Int64));
            _datatable.Columns.Add("SpecialtyID", typeof(System.Int32));
            _datatable.Columns.Add("MaxAmountAllowed", typeof(System.Decimal));
            _datatable.Columns.Add("Createdby", typeof(System.String));
            _datatable.Columns.Add("CreatedAt", typeof(System.String));

            DataRow _datarow;

            foreach (SurgeryPackageFeeTypeRateMaster _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["FeeTypeRateMasterID"] = _list.FeeTypeRateMasterID;
                _datarow["PackageID"] = _list.PackageID;
                _datarow["Feetype"] = _list.Feetype;
                _datarow["RateID"] = _list.RateID;
                _datarow["SpecialtyID"] = _list.SpecialtyID;
                _datarow["MaxAmountAllowed"] = _list.MaxAmountAllowed;
                _datarow["Createdby"] = _list.Createdby;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }


        public static System.Data.DataTable ConvertToUDTPatientDueChart(List<PatientInvestigation> invs,
                                                   List<PatientDueChart> pPatientProcedure,
                                                   List<DHEBAdder> pPatientIndents)
        {
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("FeeType", typeof(System.String));
            _datatable.Columns.Add("FeeID", typeof(System.Int64));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("Comments", typeof(System.String));
            _datatable.Columns.Add("FromDate", typeof(System.DateTime));
            _datatable.Columns.Add("ToDate", typeof(System.DateTime));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("unit", typeof(System.Decimal));
            _datatable.Columns.Add("Amount", typeof(System.Decimal));
            _datatable.Columns.Add("DetailsID", typeof(System.Int64));
            _datatable.Columns.Add("PackageID", typeof(System.Int64));
            _datatable.Columns.Add("SpecialityID", typeof(System.Int32));
            _datatable.Columns.Add("UserID", typeof(System.Int64));
            _datatable.Columns.Add("DiscountAmount", typeof(System.Decimal));
            _datatable.Columns.Add("IsReimbursable", typeof(System.String));
            _datatable.Columns.Add("IsTaxable", typeof(System.String));
            _datatable.Columns.Add("ServiceCode", typeof(System.String));
            _datatable.Columns.Add("DiscountPercent", typeof(System.Decimal));
            _datatable.Columns.Add("DiscOrEnhanceType", typeof(System.String));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            _datatable.Columns.Add("ReimbursableAmount", typeof(System.Decimal));
            _datatable.Columns.Add("NonReimbursableAmount", typeof(System.Decimal));
            _datatable.Columns.Add("ActualAmount", typeof(System.Decimal));
            _datatable.Columns.Add("RateID", typeof(System.Int64));
            _datatable.Columns.Add("IsDiscountable", typeof(System.String));
            _datatable.Columns.Add("IsSTAT", typeof(System.String));
            _datatable.Columns.Add("IsOutSource", typeof(System.String));
            _datatable.Columns.Add("IsNABL", typeof(System.String));

            DataRow _datarow;

            foreach (PatientInvestigation _list in invs)
            {
                _datarow = _datatable.NewRow();
                if (_list.GroupID == 0)
                {
                    _datarow["FeeType"] = "INV";
                    _datarow["FeeID"] = _list.InvestigationID;          //_list.GroupID;
                    _datarow["Description"] = _list.InvestigationName;  //_list.GroupName;
                }
                else
                {
                    _datarow["FeeType"] = "GRP";
                    _datarow["FeeID"] = _list.GroupID;
                    _datarow["Description"] = _list.GroupName;
                }
                _datarow["Comments"] = "";
                _datarow["FromDate"] = DateTime.Now;
                _datarow["ToDate"] = DateTime.Now;
                _datarow["Status"] = "Ordered";
                _datarow["unit"] = 1;
                _datarow["Amount"] = 0;
                _datarow["DetailsID"] = 0;
                _datarow["PackageID"] = 0;
                _datarow["SpecialityID"] = 0;
                _datarow["UserID"] = 0;
                _datarow["DiscountAmount"] = 0;
                _datarow["IsReimbursable"] = "";
                _datarow["IsTaxable"] = "";
                _datarow["ServiceCode"] = "";
                _datarow["DiscountPercent"] = 0;
                _datarow["DiscOrEnhanceType"] = "";
                _datarow["Remarks"] = "";
                _datarow["ReimbursableAmount"] = 0;
                _datarow["NonReimbursableAmount"] = 0;
                _datarow["ActualAmount"] = 0;
                _datarow["RateID"] = 0;
                _datarow["IsDiscountable"] = "N";
                _datarow["IsSTAT"] = "N";
                _datarow["IsOutSource"] = "N";
                _datarow["IsNABL"] = "N";
                _datatable.Rows.Add(_datarow);
            }

            foreach (PatientDueChart _list in pPatientProcedure)
            {
                _datarow = _datatable.NewRow();
                _datarow["FeeType"] = _list.FeeType;
                _datarow["FeeID"] = _list.FeeID;          //_list.GroupID;
                _datarow["Description"] = _list.Description;  //_list.GroupName;
                _datarow["Comments"] = _list.Comments;
                _datarow["FromDate"] = _list.FromDate;
                _datarow["ToDate"] = _list.ToDate;
                _datarow["Status"] = "Ordered";
                _datarow["unit"] = _list.Unit;
                _datarow["Amount"] = 0;
                _datarow["DetailsID"] = 0;
                _datarow["PackageID"] = 0;
                _datarow["SpecialityID"] = 0;
                _datarow["UserID"] = 0;
                _datarow["DiscountAmount"] = 0;
                _datarow["IsReimbursable"] = _list.IsReimbursable;
                _datarow["IsTaxable"] = "";
                _datarow["ServiceCode"] = "";
                _datarow["DiscountPercent"] = _list.DiscountPercent;
                _datarow["DiscOrEnhanceType"] = _list.DiscOrEnhanceType;
                _datarow["Remarks"] = _list.Remarks;
                _datarow["ReimbursableAmount"] = _list.ReimbursableAmount;
                _datarow["NonReimbursableAmount"] = _list.NonReimbursableAmount;
                _datarow["ActualAmount"] = _list.ActualAmount;
                _datarow["RateID"] = _list.RateID;
                _datarow["IsDiscountable"] = _list.IsDiscountable;
                _datarow["IsSTAT"] = _list.IsSTAT;
                _datarow["IsOutSource"] = _list.IsOutSource;
                _datarow["IsNABL"] = _list.IsNABL;

                _datatable.Rows.Add(_datarow);
            }
            foreach (DHEBAdder _list in pPatientIndents)
            {
                _datarow = _datatable.NewRow();
                _list.Comments = _list.Comments == "" ? "0" : _list.Comments;
                _datarow["FeeType"] = "OTH";
                _datarow["FeeID"] = -1;          //_list.GroupID;
                _datarow["Description"] = _list.Description;  //_list.GroupName;
                _datarow["Comments"] = "";
                _datarow["FromDate"] = DateTime.Now;
                _datarow["ToDate"] = DateTime.Now;
                _datarow["Status"] = "Ordered";
                _datarow["unit"] = 1;
                _datarow["Amount"] = Convert.ToDecimal(_list.Comments);
                _datarow["DetailsID"] = 0;
                _datarow["PackageID"] = 0;
                _datarow["SpecialityID"] = 0;
                _datarow["UserID"] = 0;
                _datarow["DiscountAmount"] = 0;
                _datarow["IsReimbursable"] = "";
                _datarow["IsTaxable"] = "";
                _datarow["ServiceCode"] = "";
                _datarow["DiscountPercent"] = 0;
                _datarow["DiscOrEnhanceType"] = "";
                _datarow["Remarks"] = "";
                _datarow["ReimbursableAmount"] = 0;
                _datarow["NonReimbursableAmount"] = 0;
                _datarow["ActualAmount"] = 0;
                _datarow["RateID"] = 0;
                _datarow["IsDiscountable"] = "N";
                _datarow["IsSTAT"] = "N";
                _datarow["IsOutSource"] = "N";
                _datarow["IsNABL"] = "N";
                _datatable.Rows.Add(_datarow);
            }

            return _datatable;
        }

        public static System.Data.DataTable ConvertToUDTPatientDepositHistory(List<PatientDepositHistory> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("DepositID", typeof(System.Int64));
            _datatable.Columns.Add("PatientID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("ReceiptNo", typeof(System.Int64));
            _datatable.Columns.Add("AmountDeposited", typeof(System.Decimal));
            _datatable.Columns.Add("PaymentTypeID", typeof(System.Int32));
            _datatable.Columns.Add("ChequeorCardNumber", typeof(System.String));
            _datatable.Columns.Add("BankNameorCardType", typeof(System.String));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            _datatable.Columns.Add("ServiceCharge", typeof(System.Decimal));
            _datatable.Columns.Add("BaseCurrencyID", typeof(System.Int32));
            _datatable.Columns.Add("PaidCurrencyID", typeof(System.Int32));
            _datatable.Columns.Add("ConversionRate", typeof(System.Decimal));
            _datatable.Columns.Add("PaidCurrencyAmount", typeof(System.Decimal));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CardHolderName", typeof(System.String));
            _datatable.Columns.Add("CashGiven", typeof(System.Decimal));
            _datatable.Columns.Add("BalanceGiven", typeof(System.Decimal));

            DataRow _datarow;

            foreach (PatientDepositHistory _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["DepositID"] = _list.DepositID;
                _datarow["PatientID"] = _list.PatientID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["ReceiptNo"] = _list.ReceiptNo;
                _datarow["AmountDeposited"] = _list.AmountDeposited;
                _datarow["PaymentTypeID"] = _list.PaymentTypeID;
                _datarow["ChequeorCardNumber"] = _list.ChequeorCardNumber;
                _datarow["BankNameorCardType"] = _list.BankNameorCardType;
                _datarow["Remarks"] = _list.Remarks;
                _datarow["ServiceCharge"] = _list.ServiceCharge;
                _datarow["BaseCurrencyID"] = _list.BaseCurrencyID;
                _datarow["PaidCurrencyID"] = _list.PaidCurrencyID;
                _datarow["ConversionRate"] = _list.ConversionRate;
                _datarow["PaidCurrencyAmount"] = _list.PaidCurrencyAmount;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CardHolderName"] = _list.CardHolderName;
                _datarow["CashGiven"] = _list.CashGiven;
                _datarow["BalanceGiven"] = _list.BalanceGiven;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToInvInstrumentMaster(List<InvInstrumentMaster> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("InstrumentID", typeof(System.Int64));
            _datatable.Columns.Add("InstrumentName", typeof(System.String));
            _datatable.Columns.Add("InstrumentType", typeof(System.Int32));
            _datatable.Columns.Add("ProductCode", typeof(System.String));
            _datatable.Columns.Add("Model", typeof(System.String));
            _datatable.Columns.Add("Manufacturer", typeof(System.String));
            _datatable.Columns.Add("Method", typeof(System.String));
            _datatable.Columns.Add("Principle", typeof(System.String));
            _datatable.Columns.Add("ProcessingMode", typeof(System.String));
            _datatable.Columns.Add("SampleVolume", typeof(System.String));
            _datatable.Columns.Add("DataStorage", typeof(System.String));
            _datatable.Columns.Add("ThroughPut", typeof(System.String));
            _datatable.Columns.Add("Direction", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("LocationID", typeof(System.Int32));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("QCData", typeof(System.String));
            _datatable.Columns.Add("ImagePath", typeof(System.String));
            _datatable.Columns.Add("Department", typeof(System.String));
            _datatable.Columns.Add("DeptID", typeof(System.Int32));

            DataRow _datarow;

            foreach (InvInstrumentMaster _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["InstrumentID"] = _list.InstrumentID;
                _datarow["InstrumentName"] = _list.InstrumentName;
                _datarow["InstrumentType"] = _list.InstrumentType;
                _datarow["ProductCode"] = _list.ProductCode;
                _datarow["Model"] = _list.Model;
                _datarow["Manufacturer"] = _list.Manufacturer;
                _datarow["Method"] = _list.Method;
                _datarow["Principle"] = _list.Principle;
                _datarow["ProcessingMode"] = _list.ProcessingMode;
                _datarow["SampleVolume"] = _list.SampleVolume;
                _datarow["DataStorage"] = _list.DataStorage;
                _datarow["ThroughPut"] = _list.ThroughPut;
                _datarow["Direction"] = _list.Direction;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["LocationID"] = _list.LocationID;
                _datarow["Status"] = _list.Status;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["QCData"] = _list.QCData;
                _datarow["ImagePath"] = _list.ImagePath;
                _datarow["Department"] = _list.Department;
                _datarow["DeptID"] = _list.DeptID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }


        public static System.Data.DataTable ConvertToANCComplaints(List<BackgroundProblem> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientID", typeof(System.Int64));
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("ComplaintID", typeof(System.Int32));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("Name", typeof(System.String));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("Priority", typeof(System.Int16));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));

            DataRow _datarow;

            foreach (BackgroundProblem _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientID"] = _list.PatientID;
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["ComplaintID"] = _list.ComplaintID;
                _datarow["Description"] = _list.Description;
                _datarow["Name"] = _list.ComplaintName;
                _datarow["Status"] = _list.Status;
                _datarow["Priority"] = _list.Priority;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToAuditTransactionDetails(List<AuditTransactionDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("AttributeID", typeof(System.Int64));
            _datatable.Columns.Add("AttributeName", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));

            DataRow _datarow;

            foreach (AuditTransactionDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["AttributeID"] = _list.AttributeID;
                _datarow["AttributeName"] = _list.AttributeName;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTBloodRequest(List<BloodRequistionDetails> _lstCollection)
        {

            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("BloodComponent", typeof(System.Int64));
            _datatable.Columns.Add("NoOfUnits", typeof(System.Int64));

            _datatable.Columns.Add("ProductID", typeof(System.Int32));
            _datatable.Columns.Add("ProductName", typeof(System.String));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));

            DataRow _datarow;

            foreach (BloodRequistionDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["BloodComponent"] = _list.BloodComponent;
                _datarow["NoOfUnits"] = _list.NoOfUnits;
                _datarow["ProductID"] = _list.ProductID;
                _datarow["ProductName"] = _list.ProductName;
                _datarow["CreatedAt"] = Convert.ToDateTime(DateTime.Now.ToString());
                _datarow["CreatedBy"] = _list.CreatedBy;

                _datatable.Rows.Add(_datarow);
            }
            return _datatable;

        }
        public static System.Data.DataTable ConvertToUDTBloodCollect(List<BloodCollectionDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("BagNumber", typeof(System.String));
            _datatable.Columns.Add("BagType", typeof(System.String));
            _datatable.Columns.Add("BloodCapacity", typeof(System.String));
            _datatable.Columns.Add("TubeID", typeof(System.String));
            _datatable.Columns.Add("AntiCoagulants", typeof(System.String));
            _datatable.Columns.Add("BloodComponent", typeof(System.String));
            _datatable.Columns.Add("BloodGroup", typeof(System.String));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("CollectedDate", typeof(System.DateTime));
            _datatable.Columns.Add("SeperatedDate", typeof(System.DateTime));
            _datatable.Columns.Add("ReconstitutedDate", typeof(System.DateTime));
            _datatable.Columns.Add("ExpiryDate", typeof(System.DateTime));
            _datatable.Columns.Add("StorageSlot", typeof(System.String));
            _datatable.Columns.Add("BatchNo", typeof(System.String));

            DataRow _datarow;

            foreach (BloodCollectionDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["BagNumber"] = _list.BagNumber;
                _datarow["BagType"] = _list.BagType;
                _datarow["BloodCapacity"] = _list.BagCapacity;
                _datarow["TubeID"] = _list.TubeID;
                _datarow["AntiCoagulants"] = _list.AntiCoagulants;
                _datarow["BloodComponent"] = _list.BloodComponent;
                _datarow["BloodGroup"] = _list.BloodGroup;
                _datarow["Status"] = _list.Status;
                _datarow["CollectedDate"] = _list.CollectedDate;
                _datarow["SeperatedDate"] = _list.SeperatedDate;
                _datarow["ReconstitutedDate"] = _list.ReconstitutedDate;
                _datarow["ExpiryDate"] = _list.ExpiryDate;
                _datarow["StorageSlot"] = _list.StorageSlot;
                _datarow["BatchNo"] = _list.BatchNo;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTBloodCapture(List<BloodCapturedDetials> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("CapturedTime", typeof(System.DateTime));
            _datatable.Columns.Add("HeartRate", typeof(System.String));
            _datatable.Columns.Add("BloodPressure", typeof(System.String));
            _datatable.Columns.Add("Saturation", typeof(System.Int64));
            _datatable.Columns.Add("Volume", typeof(System.Int64));
            _datatable.Columns.Add("Condition", typeof(System.String));

            DataRow _datarow;

            foreach (BloodCapturedDetials _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["CapturedTime"] = _list.CapturedTime;
                _datarow["HeartRate"] = _list.HeartRate;
                _datarow["BloodPressure"] = _list.BloodPressure;
                _datarow["Saturation"] = _list.Saturation;
                _datarow["Volume"] = _list.Volume;
                _datarow["Condition"] = _list.Condition;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTEpisode(List<Episode> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("EpisodeID", typeof(System.Int64));
            _datatable.Columns.Add("EpisodeName", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("NoofSitting", typeof(System.Int32));
            _datatable.Columns.Add("ClientID", typeof(System.Int64));
            _datatable.Columns.Add("StudyTypeID", typeof(System.Int32));
            _datatable.Columns.Add("EpisodeNumber", typeof(System.String));
            _datatable.Columns.Add("StartDate", typeof(System.String));
            _datatable.Columns.Add("EndDate", typeof(System.String));
            _datatable.Columns.Add("Attributes", typeof(System.String));
            _datatable.Columns.Add("NoOfPatient", typeof(System.Int32));
            _datatable.Columns.Add("ISAdhoc", typeof(System.String));
            _datatable.Columns.Add("OrgLocationID", typeof(System.Int32));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ClientSiteAttribute", typeof(System.String));
            _datatable.Columns.Add("SiteWiseSubjectAllocation", typeof(System.Int32));
            _datatable.Columns.Add("VisitWiseSubjectAllocation", typeof(System.Int32));
            _datatable.Columns.Add("StudyPhaseID", typeof(System.Int32));
            _datatable.Columns.Add("StudySource", typeof(System.String));
            _datatable.Columns.Add("StudyDesign", typeof(System.String));
            _datatable.Columns.Add("ReferenceLab", typeof(System.String));
            _datatable.Columns.Add("ScreeningSubjects", typeof(System.Int32));
            _datatable.Columns.Add("NoOfSites", typeof(System.Int32));
            _datatable.Columns.Add("IsUndefinedScreening", typeof(System.String));
            _datatable.Columns.Add("TherapeuticVlaue", typeof(System.String));

            DataRow _datarow;

            foreach (Episode _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["EpisodeID"] = _list.EpisodeID;
                _datarow["EpisodeName"] = _list.EpisodeName;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["NoofSitting"] = _list.NoofSitting;
                _datarow["ClientID"] = _list.ClientID;
                _datarow["StudyTypeID"] = _list.StudyTypeID;
                _datarow["EpisodeNumber"] = _list.EpisodeNumber;
                _datarow["StartDate"] = _list.StartDate;
                _datarow["EndDate"] = _list.EndDate;
                _datarow["Attributes"] = _list.Attributes;
                _datarow["NoOfPatient"] = _list.NoOfPatient;
                _datarow["ISAdhoc"] = _list.ISAdhoc;
                _datarow["OrgLocationID"] = _list.OrgLocationID;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["ClientSiteAttribute"] = _list.ClientSiteAttribute;
                _datarow["SiteWiseSubjectAllocation"] = _list.SiteWiseSubjectAllocation;
                _datarow["VisitWiseSubjectAllocation"] = _list.VisitWiseSubjectAllocation;
                _datarow["StudyPhaseID"] = _list.StudyPhaseID;
                _datarow["StudySource"] = _list.StudySource;
                _datarow["StudyDesign"] = _list.StudyDesign;
                _datarow["ReferenceLab"] = _list.ReferenceLab;
                _datarow["ScreeningSubjects"] = _list.ScreeningSubjects;
                _datarow["NoOfSites"] = _list.NoOfSites;
                _datarow["IsUndefinedScreening"] = _list.IsUndefinedScreening;
                _datarow["TherapeuticVlaue"] = _list.TherapeuticVlaue;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToUDTEpisode(Episode _list)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("EpisodeID", typeof(System.Int64));
            _datatable.Columns.Add("EpisodeName", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("NoofSitting", typeof(System.Int32));
            _datatable.Columns.Add("ClientID", typeof(System.Int64));
            _datatable.Columns.Add("StudyTypeID", typeof(System.Int32));
            _datatable.Columns.Add("EpisodeNumber", typeof(System.String));
            _datatable.Columns.Add("StartDate", typeof(System.String));
            _datatable.Columns.Add("EndDate", typeof(System.String));
            _datatable.Columns.Add("Attributes", typeof(System.String));
            _datatable.Columns.Add("NoOfPatient", typeof(System.Int32));
            _datatable.Columns.Add("ISAdhoc", typeof(System.String));
            _datatable.Columns.Add("OrgLocationID", typeof(System.Int32));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ClientSiteAttribute", typeof(System.String));
            _datatable.Columns.Add("SiteWiseSubjectAllocation", typeof(System.Int32));
            _datatable.Columns.Add("VisitWiseSubjectAllocation", typeof(System.Int32));
            _datatable.Columns.Add("StudyPhaseID", typeof(System.Int32));
            _datatable.Columns.Add("StudySource", typeof(System.String));
            _datatable.Columns.Add("StudyDesign", typeof(System.String));
            _datatable.Columns.Add("ReferenceLab", typeof(System.String));
            _datatable.Columns.Add("ScreeningSubjects", typeof(System.Int32));
            _datatable.Columns.Add("NoOfSites", typeof(System.Int32));
            _datatable.Columns.Add("IsUndefinedScreening", typeof(System.String));
            _datatable.Columns.Add("TherapeuticVlaue", typeof(System.String));

            DataRow _datarow;


            _datarow = _datatable.NewRow();
            _datarow["EpisodeID"] = _list.EpisodeID;
            _datarow["EpisodeName"] = _list.EpisodeName;
            _datarow["OrgID"] = _list.OrgID;
            _datarow["NoofSitting"] = _list.NoofSitting;
            _datarow["ClientID"] = _list.ClientID;
            _datarow["StudyTypeID"] = _list.StudyTypeID;
            _datarow["EpisodeNumber"] = _list.EpisodeNumber;
            _datarow["StartDate"] = _list.StartDate;
            _datarow["EndDate"] = _list.EndDate;
            _datarow["Attributes"] = _list.Attributes;
            _datarow["NoOfPatient"] = _list.NoOfPatient;
            _datarow["ISAdhoc"] = _list.ISAdhoc;
            _datarow["OrgLocationID"] = _list.OrgLocationID;
            _datarow["CreatedBy"] = _list.CreatedBy;
            _datarow["CreatedAt"] = _list.CreatedAt;
            _datarow["ModifiedBy"] = _list.ModifiedBy;
            _datarow["ModifiedAt"] = _list.ModifiedAt;
            _datarow["ClientSiteAttribute"] = _list.ClientSiteAttribute;
            _datarow["SiteWiseSubjectAllocation"] = _list.SiteWiseSubjectAllocation;
            _datarow["VisitWiseSubjectAllocation"] = _list.VisitWiseSubjectAllocation;
            _datarow["StudyPhaseID"] = _list.StudyPhaseID;
            _datarow["StudySource"] = _list.StudySource;
            _datarow["StudyDesign"] = _list.StudyDesign;
            _datarow["ReferenceLab"] = _list.ReferenceLab;
            _datarow["ScreeningSubjects"] = _list.ScreeningSubjects;
            _datarow["NoOfSites"] = _list.NoOfSites;
            _datarow["IsUndefinedScreening"] = _list.IsUndefinedScreening;
            _datarow["TherapeuticVlaue"] = _list.TherapeuticVlaue;
            _datatable.Rows.Add(_datarow);

            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTEpisodeVisitDetails(List<EpisodeVisitDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("EpisodeVisitDetailID", typeof(System.Int64));
            _datatable.Columns.Add("EpisodeID", typeof(System.Int64));
            _datatable.Columns.Add("EpisodeVisitName", typeof(System.String));
            _datatable.Columns.Add("FeeID", typeof(System.Int64));
            _datatable.Columns.Add("FeeType", typeof(System.String));
            _datatable.Columns.Add("TimedType", typeof(System.String));
            _datatable.Columns.Add("TimedNo", typeof(System.Int32));
            _datatable.Columns.Add("EpisodeVisitNumber", typeof(System.Int32));
            _datatable.Columns.Add("IsMandatory", typeof(System.String));
            _datatable.Columns.Add("PackageDetails", typeof(System.String));
            _datatable.Columns.Add("SiteDetails", typeof(System.String));
            _datatable.Columns.Add("VisitType", typeof(System.Int32));
            _datatable.Columns.Add("Guid", typeof(System.String));

            DataRow _datarow;

            foreach (EpisodeVisitDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["EpisodeVisitDetailID"] = _list.EpisodeVisitId;
                _datarow["EpisodeID"] = _list.EpisodeID;
                _datarow["EpisodeVisitName"] = _list.EpisodeVisitName;
                _datarow["FeeID"] = _list.FeeID;
                _datarow["FeeType"] = _list.FeeType;
                _datarow["TimedType"] = _list.TimedType;
                _datarow["TimedNo"] = _list.TimedNo;
                _datarow["EpisodeVisitNumber"] = _list.EpisodeVisitNumber;
                _datarow["IsMandatory"] = _list.IsMandatory;
                _datarow["PackageDetails"] = _list.PackageDetails;
                _datarow["SiteDetails"] = _list.SiteDetails;
                _datarow["VisitType"] = _list.VisitType;
                _datarow["Guid"] = _list.Guid;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToSiteEpisodeVisitMapping(List<SiteEpisodeVisitMapping> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("SiteVisitMapID", typeof(System.Int64));
            _datatable.Columns.Add("EpisodeVisitId", typeof(System.Int64));
            _datatable.Columns.Add("SiteID", typeof(System.Int64));
            _datatable.Columns.Add("NoOfSubjects", typeof(System.Int32));
            _datatable.Columns.Add("Guid", typeof(System.String));

            DataRow _datarow;

            foreach (SiteEpisodeVisitMapping _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["SiteVisitMapID"] = _list.SiteVisitMapID;
                _datarow["EpisodeVisitId"] = _list.EpisodeVisitId;
                _datarow["SiteID"] = _list.SiteID;
                _datarow["NoOfSubjects"] = _list.NoOfSubjects;
                _datarow["Guid"] = _list.Guid;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToProductEpisodeVisitMapping(List<ProductEpisodeVisitMapping> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ProductVisitMapID", typeof(System.Int64));
            _datatable.Columns.Add("EpisodeVisitId", typeof(System.Int64));
            _datatable.Columns.Add("ProductID", typeof(System.Int64));
            _datatable.Columns.Add("ProductType", typeof(System.String));
            _datatable.Columns.Add("Value", typeof(System.Int32));
            _datatable.Columns.Add("Guid", typeof(System.String));

            DataRow _datarow;

            foreach (ProductEpisodeVisitMapping _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ProductVisitMapID"] = _list.ProductVisitMapID;
                _datarow["EpisodeVisitId"] = _list.EpisodeVisitId;
                _datarow["ProductID"] = _list.ProductID;
                _datarow["ProductType"] = _list.ProductType;
                _datarow["Value"] = _list.Value;
                _datarow["Guid"] = _list.Guid;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToVisittemplate(List<VisitTemplate> _visittemplate)
        {
            System.Data.DataTable _datatable = new System.Data.DataTable();
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("FeeID", typeof(System.Int64));
            _datatable.Columns.Add("FeeType", typeof(System.String));
            _datatable.Columns.Add("TemplateID", typeof(System.Int64));
            _datatable.Columns.Add("TemplateData", typeof(System.String));
            _datatable.Columns.Add("FinalBillID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            DataRow _datarow;
            foreach (VisitTemplate _list in _visittemplate)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["FeeID"] = _list.FeeID;
                _datarow["FeeType"] = _list.FeeType;
                _datarow["TemplateID"] = _list.TemplateID;
                _datarow["TemplateData"] = _list.TemplateData;
                _datarow["FinalBillID"] = _list.FinalBillID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;


        }
        public static System.Data.DataTable ConvertToOrderedInvestigation(List<OrderedInvestigations> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("Name", typeof(System.String));
            _datatable.Columns.Add("ID", typeof(System.Int64));
            _datatable.Columns.Add("VisitID", typeof(System.Int64));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("StudyInstanceUId", typeof(System.String));
            _datatable.Columns.Add("ComplaintId", typeof(System.Int32));
            _datatable.Columns.Add("ReferedToOrgID", typeof(System.Int32));
            _datatable.Columns.Add("ReferedToLocation", typeof(System.Int32));
            _datatable.Columns.Add("InvestigationsType", typeof(System.String));
            _datatable.Columns.Add("ReferralID", typeof(System.Int64));
            _datatable.Columns.Add("UID", typeof(System.String));
            _datatable.Columns.Add("ReferenceType", typeof(System.String));
            _datatable.Columns.Add("RefPhyName", typeof(System.String));
            _datatable.Columns.Add("RefPhysicianID", typeof(System.Int64));
            _datatable.Columns.Add("SequenceNo", typeof(System.Int32));
            _datatable.Columns.Add("ReportDateTime", typeof(System.DateTime));
            _datatable.Columns.Add("TatDateTime", typeof(System.DateTime));
            _datatable.Columns.Add("IsStat", typeof(System.String));
            _datatable.Columns.Add("SampleID", typeof(System.String));
            _datatable.Columns.Add("TestSequenceOrder", typeof(System.Int32));
            ////*************Added By Arivalagan.kk*************//
            DataRow _datarow;

            foreach (OrderedInvestigations _list in _lstCollection)
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
            //Test
        }
        public static System.Data.DataTable ConvertTopatientPRO(List<PatientTreatmentProcedure> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("ProcedureID", typeof(System.Int64));
            _datatable.Columns.Add("ProcedureFID", typeof(System.Int64));
            _datatable.Columns.Add("ProcedureDesc", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));

            DataRow _datarow;

            foreach (PatientTreatmentProcedure _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["ProcedureID"] = _list.ProcedureID;
                _datarow["ProcedureFID"] = _list.ProcedureFID;
                _datarow["ProcedureDesc"] = _list.ProcedureDesc;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToPatientVitals(List<PatientVitals> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientVitalsID", typeof(System.Int64));
            _datatable.Columns.Add("PatientID", typeof(System.Int64));
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("VitalsID", typeof(System.Int32));
            _datatable.Columns.Add("VitalsValue", typeof(System.Decimal));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("UOMID", typeof(System.Int32));
            _datatable.Columns.Add("ConditionID", typeof(System.Int32));
            _datatable.Columns.Add("NurseNotes", typeof(System.String));
            _datatable.Columns.Add("VitalsName", typeof(System.String));
            _datatable.Columns.Add("VitalsDescription", typeof(System.String));
            _datatable.Columns.Add("UOMCode", typeof(System.String));
            _datatable.Columns.Add("UOMDescription", typeof(System.String));
            _datatable.Columns.Add("VitalsSetID", typeof(System.Int32));
            _datatable.Columns.Add("VitalsType", typeof(System.String));
            _datatable.Columns.Add("VitalsTypeID", typeof(System.Int64));
            _datatable.Columns.Add("EntryDate", typeof(System.DateTime));

            DataRow _datarow;

            foreach (PatientVitals _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientVitalsID"] = _list.PatientVitalsID;
                _datarow["PatientID"] = _list.PatientID;
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["VitalsID"] = _list.VitalsID;
                _datarow["VitalsValue"] = _list.VitalsValue;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["UOMID"] = _list.UOMID;
                _datarow["ConditionID"] = _list.ConditionID;
                _datarow["NurseNotes"] = _list.NurseNotes;
                _datarow["VitalsName"] = _list.VitalsName;
                _datarow["VitalsDescription"] = _list.VitalsDescription;
                _datarow["UOMCode"] = _list.UOMCode;
                _datarow["UOMDescription"] = _list.UOMDescription;
                _datarow["VitalsSetID"] = _list.VitalsSetID;
                _datarow["VitalsType"] = _list.VitalsType;
                _datarow["VitalsTypeID"] = _list.VitalsTypeID;
                _datarow["EntryDate"] = _list.EnterDate;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTPasswordPolicy(List<PasswordPolicy> pwdplcy)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("PasswordLength", typeof(System.Int32));
            _datatable.Columns.Add("Splcharlen", typeof(System.Int32));
            _datatable.Columns.Add("Numcharlen", typeof(System.Int32));
            _datatable.Columns.Add("ValidityPeriodType", typeof(System.String));
            _datatable.Columns.Add("ValidityPeriod", typeof(System.Int32));
            _datatable.Columns.Add("PreviousPwdcount", typeof(System.Int32));
            _datatable.Columns.Add("OrgID", typeof(System.Int64));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("Id", typeof(System.Int64));

            DataRow _datarow;

            foreach (PasswordPolicy _list in pwdplcy)
            {
                _datarow = _datatable.NewRow();
                _datarow["Type"] = _list.Type;
                _datarow["PasswordLength"] = _list.PasswordLength;
                _datarow["Splcharlen"] = _list.Splcharlen;
                _datarow["Numcharlen"] = _list.Numcharlen;
                _datarow["ValidityPeriodType"] = _list.ValidityPeriodType;
                _datarow["ValidityPeriod"] = _list.ValidityPeriod;
                _datarow["PreviousPwdcount"] = _list.PreviousPwdcount;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["Id"] = _list.Id;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToUDTInventoryLocations(List<Locations> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("LocationID", typeof(System.Int32));
            _datatable.Columns.Add("LocationName", typeof(System.String));
            _datatable.Columns.Add("LocationTypeID", typeof(System.Int32));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("LID", typeof(System.Int32));
            _datatable.Columns.Add("OrgAddressID", typeof(System.Int32));
            _datatable.Columns.Add("ProductTypeID", typeof(System.String));
            _datatable.Columns.Add("IsActive", typeof(System.String));
            _datatable.Columns.Add("ParentLocationID", typeof(System.Int32));
            _datatable.Columns.Add("DLNO", typeof(System.String));
            _datatable.Columns.Add("TINNO", typeof(System.String));

            DataRow _datarow;

            foreach (Locations _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["LocationID"] = _list.LocationID;
                _datarow["LocationName"] = _list.LocationName;
                _datarow["LocationTypeID"] = _list.LocationTypeID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["LID"] = _list.CreatedBy;
                _datarow["OrgAddressID"] = _list.OrgAddressID;
                _datarow["ProductTypeID"] = _list.ProductTypeID;
                _datarow["IsActive"] = _list.IsActive;
                _datarow["ParentLocationID"] = _list.ParentLocationID;
                _datarow["DLNO"] = _list.DLNO;
                _datarow["TINNO"] = _list.TINNO;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }



        public static System.Data.DataTable ConvertToHIDECType(List<BackgroundProblem> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("HIDECID", typeof(System.Int32));
            _datatable.Columns.Add("Name", typeof(System.String));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ComplaintID", typeof(System.Int32));

            DataRow _datarow;

            foreach (BackgroundProblem _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["HIDECID"] = _list.PatientVisitID;
                _datarow["Name"] = _list.ComplaintName;
                _datarow["Description"] = _list.Description;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ComplaintID"] = _list.ComplaintID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToPrescriptionDrugType(List<DrugDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PrescriptionID", typeof(System.Int64));
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("DrugName", typeof(System.String));
            _datatable.Columns.Add("DrugFormulation", typeof(System.String));
            _datatable.Columns.Add("DrugFrequency", typeof(System.String));
            _datatable.Columns.Add("ROA", typeof(System.String));
            _datatable.Columns.Add("Dose", typeof(System.String));
            _datatable.Columns.Add("Duration", typeof(System.String));
            _datatable.Columns.Add("Instruction", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ComplaintID", typeof(System.Int32));
            _datatable.Columns.Add("AdministeredAtFrom", typeof(System.DateTime));
            _datatable.Columns.Add("AdministeredAtTo", typeof(System.DateTime));
            _datatable.Columns.Add("DrugStatus", typeof(System.String));

            DataRow _datarow;

            foreach (DrugDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PrescriptionID"] = _list.PrescriptionID;
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["DrugName"] = _list.DrugName;
                _datarow["DrugFormulation"] = _list.DrugFormulation;
                _datarow["DrugFrequency"] = _list.DrugFrequency;
                _datarow["ROA"] = _list.ROA;
                _datarow["Dose"] = _list.Dose;
                _datarow["Duration"] = _list.Duration;
                _datarow["Instruction"] = _list.Instruction;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ComplaintID"] = _list.ComplaintId;
                _datarow["AdministeredAtFrom"] = _list.AdministeredAtFrom;
                _datarow["AdministeredAtTo"] = _list.AdministeredAtTo;
                _datarow["DrugStatus"] = _list.DrugStatus;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTSurgeryPackageMapping(List<SurgeryPackageDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PackageID", typeof(System.Int32));
            _datatable.Columns.Add("FeeID", typeof(System.Int64));
            _datatable.Columns.Add("FeeType", typeof(System.String));
            _datatable.Columns.Add("DrugGenericID", typeof(System.Int64));
            _datatable.Columns.Add("SpecialtyID", typeof(System.Int32));
            _datatable.Columns.Add("PkgQuantity", typeof(System.Decimal));
            _datatable.Columns.Add("ItemName", typeof(System.String));

            DataRow _datarow;

            foreach (SurgeryPackageDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PackageID"] = _list.PackageID;
                _datarow["FeeID"] = _list.FeeID;
                _datarow["FeeType"] = _list.Feetype;
                _datarow["DrugGenericID"] = _list.DrugGenericID;
                _datarow["SpecialtyID"] = _list.SpecialtyID;
                _datarow["PkgQuantity"] = _list.PkgQuantity;
                _datarow["ItemName"] = _list.ItemName;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTSurgeryPackageDeleting(List<SurgeryPackageDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PackageID", typeof(System.Int32));
            _datatable.Columns.Add("FeeID", typeof(System.Int64));
            _datatable.Columns.Add("FeeType", typeof(System.String));
            _datatable.Columns.Add("DrugGenericID", typeof(System.Int64));
            _datatable.Columns.Add("SpecialtyID", typeof(System.Int32));
            _datatable.Columns.Add("PkgQuantity", typeof(System.Decimal));
            _datatable.Columns.Add("ItemName", typeof(System.String));

            DataRow _datarow;

            foreach (SurgeryPackageDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PackageID"] = _list.PackageID;
                _datarow["FeeID"] = _list.FeeID;
                _datarow["FeeType"] = _list.Feetype;
                _datarow["DrugGenericID"] = _list.DrugGenericID;
                _datarow["SpecialtyID"] = _list.SpecialtyID;
                _datarow["PkgQuantity"] = _list.PkgQuantity;
                _datarow["ItemName"] = _list.ItemName;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToUDTIPTreatmentPlanMaster(List<IPTreatmentPlanMaster> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("IPTreatmentPlanID", typeof(System.Int32));
            _datatable.Columns.Add("IPTreatmentPlanName", typeof(System.String));
            _datatable.Columns.Add("IPTreatmentPlanParentID", typeof(System.Int32));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));

            DataRow _datarow;

            foreach (IPTreatmentPlanMaster _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["IPTreatmentPlanID"] = _list.TreatmentPlanID;
                _datarow["IPTreatmentPlanName"] = _list.IPTreatmentPlanName;
                _datarow["IPTreatmentPlanParentID"] = _list.IPTreatmentPlanParentID;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["OrgID"] = _list.OrgID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToLabourAndDeliveryNotes(List<LabourAndDeliveryNotes> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientID", typeof(System.Int64));
            _datatable.Columns.Add("VisitID", typeof(System.Int64));
            _datatable.Columns.Add("HusbandName", typeof(System.String));
            _datatable.Columns.Add("TypeOfLabour", typeof(System.Int32));
            _datatable.Columns.Add("ModeOfDelivery", typeof(System.Int32));
            _datatable.Columns.Add("DeliveryAssistance", typeof(System.Int32));
            _datatable.Columns.Add("ProcedureTypeID", typeof(System.Int32));
            _datatable.Columns.Add("GenerationType", typeof(System.Int32));
            _datatable.Columns.Add("LabourTmax", typeof(System.String));
            _datatable.Columns.Add("ROMLength", typeof(System.String));
            _datatable.Columns.Add("DeliveryTerm", typeof(System.String));
            _datatable.Columns.Add("DeliveringObstreticianID", typeof(System.Int64));
            _datatable.Columns.Add("NeonatologistID", typeof(System.Int64));
            _datatable.Columns.Add("DeliveryNotes", typeof(System.String));
            _datatable.Columns.Add("BirthRegID", typeof(System.Int64));
            _datatable.Columns.Add("AnesthesiaTypeID", typeof(System.Int32));
            _datatable.Columns.Add("TypeiD", typeof(System.Int32));

            DataRow _datarow;

            foreach (LabourAndDeliveryNotes _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientID"] = _list.PatientID;
                _datarow["VisitID"] = _list.VisitID;
                _datarow["HusbandName"] = _list.HusbandName;
                _datarow["TypeOfLabour"] = _list.TypeOfLabour;
                _datarow["ModeOfDelivery"] = _list.ModeOfDelivery;
                _datarow["DeliveryAssistance"] = _list.DeliveryAssistance;
                _datarow["ProcedureTypeID"] = _list.ProcedureTypeID;
                _datarow["GenerationType"] = _list.GenerationType;
                _datarow["LabourTmax"] = _list.LabourTmax;
                _datarow["ROMLength"] = _list.ROMLength;
                _datarow["DeliveryTerm"] = _list.DeliveryTerm;
                _datarow["DeliveringObstreticianID"] = _list.DeliveringObstreticianID;
                _datarow["NeonatologistID"] = _list.NeonatologistID;
                _datarow["DeliveryNotes"] = _list.DeliveryNotes;
                _datarow["BirthRegID"] = _list.BirthRegID;
                _datarow["AnesthesiaTypeID"] = _list.AnesthesiaTypeID;
                _datarow["TypeiD"] = _list.Typeid;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToPatientComplication(List<PatientComplication> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ComplicationID", typeof(System.Int32));
            _datatable.Columns.Add("ComplicationName", typeof(System.String));
            _datatable.Columns.Add("ComplicationType", typeof(System.String));
            _datatable.Columns.Add("ICDCode", typeof(System.String));
            _datatable.Columns.Add("ICDDescription", typeof(System.String));
            _datatable.Columns.Add("ComplaintID", typeof(System.Int32));
            _datatable.Columns.Add("ICDCodeStatus", typeof(System.String));

            DataRow _datarow;

            foreach (PatientComplication _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ComplicationID"] = _list.ComplicationID;
                _datarow["ComplicationName"] = _list.ComplicationName;
                _datarow["ComplicationType"] = _list.ComplicationType;
                _datarow["ICDCode"] = _list.ICDCode;
                _datarow["ICDDescription"] = _list.ICDDescription;
                _datarow["ComplaintID"] = _list.ComplaintID;
                _datarow["ICDCodeStatus"] = _list.ICDCodeStatus;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToTaskActionOrgMapping(List<TaskActionOrgMapping> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("TaskActionID", typeof(System.Int32));
            _datatable.Columns.Add("RoleID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));

            DataRow _datarow;

            foreach (TaskActionOrgMapping _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["TaskActionID"] = _list.TaskActionID;
                _datarow["RoleID"] = _list.RoleID;
                _datarow["OrgID"] = _list.OrgID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTMetaData(List<MetaData> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("MetaDataID", typeof(System.Int32));
            _datatable.Columns.Add("Domain", typeof(System.String));
            _datatable.Columns.Add("Code", typeof(System.String));
            _datatable.Columns.Add("DisplayText", typeof(System.String));
            _datatable.Columns.Add("LangCode", typeof(System.String));

            DataRow _datarow;

            foreach (MetaData _list in _lstCollection)
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
            //Test
        }

        public static System.Data.DataTable ConvertToBirthInstructions(List<BirthInstructions> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("InstructionID", typeof(System.Int64));
            _datatable.Columns.Add("Instructions", typeof(System.String));

            DataRow _datarow;

            foreach (BirthInstructions _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["InstructionID"] = _list.InstructionID;
                _datarow["Instructions"] = _list.Instructions;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToBackgroundProblem(List<BackgroundProblem> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("ComplaintID", typeof(System.Int32));
            _datatable.Columns.Add("ComplaintName", typeof(System.String));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ICDCode", typeof(System.String));
            _datatable.Columns.Add("ICDDescription", typeof(System.String));
            _datatable.Columns.Add("PreparedAt", typeof(System.String));
            _datatable.Columns.Add("ICDCodeStatus", typeof(System.String));

            DataRow _datarow;

            foreach (BackgroundProblem _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["ComplaintID"] = _list.ComplaintID;
                _datarow["ComplaintName"] = _list.ComplaintName;
                _datarow["Description"] = _list.Description;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ICDCode"] = _list.ICDCode;
                _datarow["ICDDescription"] = _list.ICDDescription;
                _datarow["PreparedAt"] = _list.PreparedAt;
                _datarow["ICDCodeStatus"] = _list.ICDCodeStatus;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToPrescriptionType(List<DrugDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("DrugName", typeof(System.String));
            _datatable.Columns.Add("DrugFormulation", typeof(System.String));
            _datatable.Columns.Add("DrugFrequency", typeof(System.String));
            _datatable.Columns.Add("ROA", typeof(System.String));
            _datatable.Columns.Add("Dose", typeof(System.String));
            _datatable.Columns.Add("Duration", typeof(System.String));
            _datatable.Columns.Add("Instruction", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ComplaintID", typeof(System.Int32));
            _datatable.Columns.Add("DrugStatus", typeof(System.String));
            _datatable.Columns.Add("PrescriptionType", typeof(System.String));
            _datatable.Columns.Add("DrugSource", typeof(System.String));
            _datatable.Columns.Add("DrugID", typeof(System.Int64));
            _datatable.Columns.Add("PrescriptionNumber", typeof(System.String));
            _datatable.Columns.Add("PhysicianID", typeof(System.Int64));
            _datatable.Columns.Add("PrescribeDrugExpiryDate", typeof(System.DateTime));
            _datatable.Columns.Add("TaskID", typeof(System.Int64));
            _datatable.Columns.Add("PrescriptionID", typeof(System.Int64));
            _datatable.Columns.Add("Direction", typeof(System.String));
            _datatable.Columns.Add("Qty", typeof(System.Decimal));

            DataRow _datarow;

            foreach (DrugDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["DrugName"] = _list.DrugName;
                _datarow["DrugFormulation"] = _list.DrugFormulation;
                _datarow["DrugFrequency"] = _list.DrugFrequency;
                _datarow["ROA"] = _list.ROA;
                _datarow["Dose"] = _list.Dose;
                _datarow["Duration"] = _list.Duration;
                _datarow["Instruction"] = _list.Instruction;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ComplaintID"] = _list.ComplaintId;
                _datarow["DrugStatus"] = _list.DrugStatus;
                _datarow["PrescriptionType"] = _list.PrescriptionType;
                _datarow["DrugSource"] = _list.DrugSource;
                _datarow["DrugID"] = _list.DrugID;
                _datarow["PrescriptionNumber"] = _list.PrescriptionNumber;
                _datarow["PhysicianID"] = _list.PhysicianID;
                _datarow["PrescribeDrugExpiryDate"] = _list.PrescribeDrugExpiryDate;
                _datarow["TaskID"] = _list.TaskID;
                _datarow["PrescriptionID"] = _list.PrescriptionID;
                _datarow["Direction"] = _list.Direction;
                _datarow["Qty"] = _list.Qty;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToPrescriptionType(List<DrugDetails> _lstCollection, int pComplaintId)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("DrugName", typeof(System.String));
            _datatable.Columns.Add("DrugFormulation", typeof(System.String));
            _datatable.Columns.Add("DrugFrequency", typeof(System.String));
            _datatable.Columns.Add("ROA", typeof(System.String));
            _datatable.Columns.Add("Dose", typeof(System.String));
            _datatable.Columns.Add("Duration", typeof(System.String));
            _datatable.Columns.Add("Instruction", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ComplaintID", typeof(System.Int32));
            _datatable.Columns.Add("DrugStatus", typeof(System.String));
            _datatable.Columns.Add("PrescriptionType", typeof(System.String));
            _datatable.Columns.Add("DrugSource", typeof(System.String));
            _datatable.Columns.Add("DrugID", typeof(System.Int64));
            _datatable.Columns.Add("PrescriptionNumber", typeof(System.String));
            _datatable.Columns.Add("PhysicianID", typeof(System.Int64));
            _datatable.Columns.Add("PrescribeDrugExpiryDate", typeof(System.DateTime));
            _datatable.Columns.Add("TaskID", typeof(System.Int64));
            _datatable.Columns.Add("PrescriptionID", typeof(System.Int64));
            _datatable.Columns.Add("Direction", typeof(System.String));
            _datatable.Columns.Add("Qty", typeof(System.Decimal));

            DataRow _datarow;

            foreach (DrugDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["DrugName"] = _list.DrugName;
                _datarow["DrugFormulation"] = _list.DrugFormulation;
                _datarow["DrugFrequency"] = _list.DrugFrequency;
                _datarow["ROA"] = _list.ROA;
                _datarow["Dose"] = _list.Dose;
                _datarow["Duration"] = _list.Duration;
                _datarow["Instruction"] = _list.Instruction;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ComplaintID"] = pComplaintId;
                _datarow["DrugStatus"] = _list.DrugStatus;
                _datarow["PrescriptionType"] = _list.PrescriptionType;
                _datarow["DrugSource"] = _list.DrugSource;
                _datarow["DrugID"] = _list.DrugID;
                _datarow["PrescriptionNumber"] = _list.PrescriptionNumber;
                _datarow["PhysicianID"] = _list.PhysicianID;
                _datarow["PrescribeDrugExpiryDate"] = _list.PrescribeDrugExpiryDate;
                _datarow["TaskID"] = _list.TaskID;
                _datarow["PrescriptionID"] = _list.PrescriptionID;
                _datarow["Direction"] = _list.Direction;
                _datarow["Qty"] = _list.Qty;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }


        public static System.Data.DataTable ConvertToImmunization(List<PatientBabyVaccination> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("PatientID", typeof(System.Int64));
            _datatable.Columns.Add("VaccinationID", typeof(System.Int32));
            _datatable.Columns.Add("VaccinationName", typeof(System.String));
            _datatable.Columns.Add("ImmunizedPeriod", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("Paymentstatus", typeof(System.String));

            DataRow _datarow;

            foreach (PatientBabyVaccination _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["PatientID"] = _list.PatientID;
                _datarow["VaccinationID"] = _list.VaccinationID;
                _datarow["VaccinationName"] = _list.VaccinationName;
                _datarow["ImmunizedPeriod"] = _list.ImmunizedPeriod;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["Paymentstatus"] = _list.Paymentstatus;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }


        public static System.Data.DataTable ConvertToUDTVisitPurpose(List<VisitPurpose> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("VisitPurposeID", typeof(System.Int32));
            _datatable.Columns.Add("VisitPurposeName", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("OrgAddressID", typeof(System.Int64));
            _datatable.Columns.Add("VisitType", typeof(System.String));

            DataRow _datarow;

            foreach (VisitPurpose _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["VisitPurposeID"] = _list.VisitPurposeID;
                _datarow["VisitPurposeName"] = _list.VisitPurposeName;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["OrgAddressID"] = _list.OrgAddressID;
                _datarow["VisitType"] = _list.VisitType;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToGetOrgIDs(List<TrustedOrgDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("OrgID", typeof(System.Int32));

            DataRow _datarow;

            foreach (TrustedOrgDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["OrgID"] = _list.SharingOrgID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToANCGPALDetails(List<GPALDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientID", typeof(System.Int64));
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("SexOfChild", typeof(System.String));
            _datatable.Columns.Add("Age", typeof(System.String));
            _datatable.Columns.Add("ModeOfDeliveryID", typeof(System.Int32));
            _datatable.Columns.Add("BirthMaturityID", typeof(System.Int32));
            _datatable.Columns.Add("BirthWeight", typeof(System.Decimal));
            _datatable.Columns.Add("IsGrowthNormal", typeof(System.String));
            _datatable.Columns.Add("GrowthRate", typeof(System.Int32));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));

            DataRow _datarow;

            foreach (GPALDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientID"] = _list.PatientID;
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["SexOfChild"] = _list.SexOfChild;
                _datarow["Age"] = _list.Age;
                _datarow["ModeOfDeliveryID"] = _list.ModeOfDeliveryID;
                _datarow["BirthMaturityID"] = _list.BirthMaturityID;
                _datarow["BirthWeight"] = _list.BirthWeight;
                _datarow["IsGrowthNormal"] = _list.IsGrowthNormal;
                _datarow["GrowthRate"] = _list.GrowthRate;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToHIDECType(List<PatientExamination> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("HIDECID", typeof(System.Int32));
            _datatable.Columns.Add("Name", typeof(System.String));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ComplaintID", typeof(System.Int32));

            DataRow _datarow;

            foreach (PatientExamination _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["HIDECID"] = _list.ExaminationID;
                _datarow["Name"] = _list.ExaminationName;
                _datarow["Description"] = _list.Description;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ComplaintID"] = _list.ComplaintId;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToANCPatientComplication(List<PatientComplication> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ComplicationID", typeof(System.Int64));
            _datatable.Columns.Add("ComplicationName", typeof(System.String));
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("PatientID", typeof(System.Int64));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ANCStatus", typeof(System.String));

            DataRow _datarow;

            foreach (PatientComplication _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ComplicationID"] = _list.ComplicationID;
                _datarow["ComplicationName"] = _list.ComplicationName;
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["PatientID"] = _list.PatientID;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ANCStatus"] = _list.ANCStatus;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToANCPatientFetalFindings(List<PatientFetalFindings> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientID", typeof(System.Int64));
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("FetalNumber", typeof(System.Int32));
            _datatable.Columns.Add("FetalPresentationDesc", typeof(System.String));
            _datatable.Columns.Add("FetalPositionDesc", typeof(System.String));
            _datatable.Columns.Add("FetalMovementsDesc", typeof(System.String));
            _datatable.Columns.Add("FetalFHSDesc", typeof(System.String));
            _datatable.Columns.Add("FetalOthers", typeof(System.String));
            _datatable.Columns.Add("isNormalFinding", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));

            DataRow _datarow;

            foreach (PatientFetalFindings _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientID"] = _list.PatientID;
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["FetalNumber"] = _list.FetalNumber;
                _datarow["FetalPresentationDesc"] = _list.FetalPresentationDesc;
                _datarow["FetalPositionDesc"] = _list.FetalPositionDesc;
                _datarow["FetalMovementsDesc"] = _list.FetalMovementsDesc;
                _datarow["FetalFHSDesc"] = _list.FetalFHSDesc;
                _datarow["FetalOthers"] = _list.FetalOthers;
                _datarow["isNormalFinding"] = _list.IsNormalFinding;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertTouddInsertGeneralAdvice(List<PatientAdvice> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));

            DataRow _datarow;

            foreach (PatientAdvice _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["Description"] = _list.Description;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToSchedulesDescription(List<Bookings> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("pResourceTemplateID", typeof(System.Int64));
            _datatable.Columns.Add("pScheduleID", typeof(System.Int64));
            _datatable.Columns.Add("pStart", typeof(System.DateTime));
            _datatable.Columns.Add("pEnd", typeof(System.DateTime));
            _datatable.Columns.Add("pTokenNumber", typeof(System.Int32));

            DataRow _datarow;

            foreach (Bookings _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["pResourceTemplateID"] = _list.ResourceTemplateID;
                _datarow["pScheduleID"] = _list.ScheduleID;
                _datarow["pStart"] = _list.StartTime;
                _datarow["pEnd"] = _list.EndTime;
                _datarow["pTokenNumber"] = _list.TokenNumber;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToBedMaster(List<BedMaster> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("BedID", typeof(System.Int32));
            _datatable.Columns.Add("BedName", typeof(System.String));
            _datatable.Columns.Add("RoomID", typeof(System.Int32));

            DataRow _datarow;

            foreach (BedMaster _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["BedID"] = _list.BedID;
                _datarow["BedName"] = _list.BedName;
                _datarow["RoomID"] = _list.RoomID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToRoomDetails(List<RoomMaster> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("RoomID", typeof(System.Int32));
            _datatable.Columns.Add("RoomName", typeof(System.String));
            _datatable.Columns.Add("FloorID", typeof(System.Int32));
            _datatable.Columns.Add("FloorName", typeof(System.String));
            _datatable.Columns.Add("WardID", typeof(System.Int32));
            _datatable.Columns.Add("WardName", typeof(System.String));
            _datatable.Columns.Add("RoomTypeID", typeof(System.Int32));
            _datatable.Columns.Add("RoomTypeName", typeof(System.String));
            _datatable.Columns.Add("NoBeds", typeof(System.Int32));
            _datatable.Columns.Add("BedName", typeof(System.String));
            _datatable.Columns.Add("BuildingID", typeof(System.Int32));
            _datatable.Columns.Add("BuildingName", typeof(System.String));
            _datatable.Columns.Add("ID", typeof(System.Int32));
            _datatable.Columns.Add("Name", typeof(System.String));
            _datatable.Columns.Add("Amount", typeof(System.Decimal));
            _datatable.Columns.Add("ISVariable", typeof(System.String));
            _datatable.Columns.Add("ISOptional", typeof(System.String));
            _datatable.Columns.Add("FeeID", typeof(System.Int32));
            _datatable.Columns.Add("RateID", typeof(System.Int32));
            _datatable.Columns.Add("FeelogicID", typeof(System.String));
            _datatable.Columns.Add("AllowSlotBooking", typeof(System.String));
            _datatable.Columns.Add("IsAnOT", typeof(System.String));

            DataRow _datarow;

            foreach (RoomMaster _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["RoomID"] = _list.RoomID;
                _datarow["RoomName"] = _list.RoomName;
                _datarow["FloorID"] = _list.FloorID;
                _datarow["FloorName"] = "";
                _datarow["WardID"] = _list.WardID;
                _datarow["WardName"] = "";
                _datarow["RoomTypeID"] = _list.RoomTypeID;
                _datarow["RoomTypeName"] = "";
                _datarow["NoBeds"] = _list.NoBeds;
                _datarow["BedName"] = "";
                _datarow["BuildingID"] = 0;
                _datarow["BuildingName"] = "";
                _datarow["ID"] = 0;
                _datarow["Name"] = "";
                _datarow["Amount"] = 0;
                _datarow["ISVariable"] = "";
                _datarow["ISOptional"] = "";
                _datarow["FeeID"] = 0;
                _datarow["RateID"] = 0;
                _datarow["FeelogicID"] = 0;
                _datarow["AllowSlotBooking"] = "";
                _datarow["IsAnOT"] = "";
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToRoomDetails(List<RoomDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("RoomID", typeof(System.Int32));
            _datatable.Columns.Add("RoomName", typeof(System.String));
            _datatable.Columns.Add("FloorID", typeof(System.Int32));
            _datatable.Columns.Add("FloorName", typeof(System.String));
            _datatable.Columns.Add("WardID", typeof(System.Int32));
            _datatable.Columns.Add("WardName", typeof(System.String));
            _datatable.Columns.Add("RoomTypeID", typeof(System.Int32));
            _datatable.Columns.Add("RoomTypeName", typeof(System.String));
            _datatable.Columns.Add("NoBeds", typeof(System.Int32));
            _datatable.Columns.Add("BedName", typeof(System.String));
            _datatable.Columns.Add("BuildingID", typeof(System.Int32));
            _datatable.Columns.Add("BuildingName", typeof(System.String));
            _datatable.Columns.Add("ID", typeof(System.Int32));
            _datatable.Columns.Add("Name", typeof(System.String));
            _datatable.Columns.Add("Amount", typeof(System.Decimal));
            _datatable.Columns.Add("ISVariable", typeof(System.String));
            _datatable.Columns.Add("ISOptional", typeof(System.String));
            _datatable.Columns.Add("FeeID", typeof(System.Int32));
            _datatable.Columns.Add("RateID", typeof(System.Int32));
            _datatable.Columns.Add("FeelogicID", typeof(System.String));
            _datatable.Columns.Add("AllowSlotBooking", typeof(System.String));
            _datatable.Columns.Add("IsAnOT", typeof(System.String));
            _datatable.Columns.Add("NoRows", typeof(System.Int32));
            _datatable.Columns.Add("NoColumns", typeof(System.Int32));
            _datatable.Columns.Add("SampleGroupID", typeof(System.Int64));
            _datatable.Columns.Add("SampleCode", typeof(System.Int64));

            DataRow _datarow;

            foreach (RoomDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["RoomID"] = _list.RoomID;
                _datarow["RoomName"] = _list.RoomName;
                _datarow["FloorID"] = _list.FloorID;
                _datarow["FloorName"] = _list.FloorName;
                _datarow["WardID"] = _list.WardID;
                _datarow["WardName"] = _list.WardName;
                _datarow["RoomTypeID"] = _list.RoomTypeID;
                _datarow["RoomTypeName"] = _list.RoomTypeName;
                _datarow["NoBeds"] = _list.NoBeds;
                _datarow["BedName"] = _list.BedName;
                _datarow["BuildingID"] = _list.BuildingID;
                _datarow["BuildingName"] = _list.BuildingName;
                _datarow["ID"] = _list.ID;
                _datarow["Name"] = _list.Name;
                _datarow["Amount"] = _list.Amount;
                _datarow["ISVariable"] = _list.ISVariable;
                _datarow["ISOptional"] = _list.ISOptional;
                _datarow["FeeID"] = _list.FeeID;
                _datarow["RateID"] = _list.RateID;
                _datarow["FeelogicID"] = _list.FeelogicID;
                _datarow["AllowSlotBooking"] = _list.AllowSlotBooking;
                _datarow["IsAnOT"] = _list.IsAnOT;
                _datarow["NoRows"] = _list.NoRows;
                _datarow["NoColumns"] = _list.NoColumns;
                _datarow["SampleGroupID"] = _list.SampleGroupID;
                _datarow["SampleCode"] = _list.SampleCode;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToReferrals(List<Referral> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ReferralID", typeof(System.Int64));
            _datatable.Columns.Add("ReferralDetailsID", typeof(System.Int64));
            _datatable.Columns.Add("ReferedByOrgID", typeof(System.Int32));
            _datatable.Columns.Add("ReferedByVisitID", typeof(System.Int64));
            _datatable.Columns.Add("ReferedToOrgID", typeof(System.Int32));
            _datatable.Columns.Add("ReferralVisitPurposeID", typeof(System.Int32));
            _datatable.Columns.Add("ReferralSpecialityID", typeof(System.Int32));
            _datatable.Columns.Add("ReferedToPhysicianID", typeof(System.Int32));
            _datatable.Columns.Add("ReferralStatus", typeof(System.String));
            _datatable.Columns.Add("ReferralNotes", typeof(System.String));
            _datatable.Columns.Add("ReferedToLocation", typeof(System.Int64));
            _datatable.Columns.Add("ReferedByLocation", typeof(System.Int64));
            _datatable.Columns.Add("AllowCaseSheet", typeof(System.String));
            _datatable.Columns.Add("ReferedToPhysicianName", typeof(System.String));
            _datatable.Columns.Add("ReferralSpecialityName", typeof(System.String));
            _datatable.Columns.Add("ResultID", typeof(System.Int32));
            _datatable.Columns.Add("ResultName", typeof(System.String));
            _datatable.Columns.Add("ResultTemplateType", typeof(System.String));
            _datatable.Columns.Add("ReferedToOrgName", typeof(System.String));
            _datatable.Columns.Add("ReferedByPhysicianID", typeof(System.Int32));
            _datatable.Columns.Add("ReferedByPhysicianName", typeof(System.String));

            DataRow _datarow;

            foreach (Referral _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ReferralID"] = _list.ReferralID;
                _datarow["ReferralDetailsID"] = _list.ReferralDetailsID;
                _datarow["ReferedByOrgID"] = _list.ReferedByOrgID;
                _datarow["ReferedByVisitID"] = _list.ReferedByVisitID;
                _datarow["ReferedToOrgID"] = _list.ReferedToOrgID;
                _datarow["ReferralVisitPurposeID"] = _list.ReferralVisitPurposeID;
                _datarow["ReferralSpecialityID"] = _list.ReferralSpecialityID;
                _datarow["ReferedToPhysicianID"] = _list.ReferedToPhysicianID;
                _datarow["ReferralStatus"] = _list.ReferralStatus;
                _datarow["ReferralNotes"] = _list.ReferralNotes;
                _datarow["ReferedToLocation"] = _list.ReferedToLocation;
                _datarow["ReferedByLocation"] = _list.ReferedByLocation;
                _datarow["AllowCaseSheet"] = _list.AllowCaseSheet;
                _datarow["ReferedToPhysicianName"] = _list.ReferedToPhysicianName;
                _datarow["ReferralSpecialityName"] = _list.ReferralSpecialityName;
                _datarow["ResultID"] = _list.ResultID;
                _datarow["ResultName"] = _list.ResultName;
                _datarow["ResultTemplateType"] = _list.ResultTemplateType;
                _datarow["ReferedToOrgName"] = _list.ReferedToOrgName;
                _datarow["ReferedByPhysicianID"] = _list.ReferedByPhysicianID;
                _datarow["ReferedByPhysicianName"] = _list.ReferedByPhysicianName;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTPCClientMapping(List<PCClientMapping> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("RefPhyID", typeof(System.Int32));
            _datatable.Columns.Add("RefOrgID", typeof(System.Int64));
            _datatable.Columns.Add("PayerID", typeof(System.Int32));
            _datatable.Columns.Add("RateID", typeof(System.Int32));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));

            DataRow _datarow;

            foreach (PCClientMapping _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["RefPhyID"] = _list.RefPhyID;
                _datarow["RefOrgID"] = _list.RefOrgID;
                _datarow["PayerID"] = _list.PayerID;
                _datarow["RateID"] = _list.RateID;
                _datarow["OrgID"] = _list.OrgID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToGetOrgIDs(List<Speciality> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("OrgID", typeof(System.Int32));

            DataRow _datarow;

            foreach (Speciality _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["OrgID"] = _list.SpecialityID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToUDTRoleMenuInfo(List<RoleMenuInfo> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("UserMenuID", typeof(System.Int64));
            _datatable.Columns.Add("MenuID", typeof(System.Int32));
            _datatable.Columns.Add("RoleID", typeof(System.Int64));
            _datatable.Columns.Add("RoleName", typeof(System.String));
            _datatable.Columns.Add("ParentID", typeof(System.Int64));
            _datatable.Columns.Add("DisplayText", typeof(System.String));
            _datatable.Columns.Add("MenuHeader", typeof(System.String));
            _datatable.Columns.Add("IsMapped", typeof(System.String));
            _datatable.Columns.Add("HasAction", typeof(System.String));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("OrgAddressID", typeof(System.Int32));

            DataRow _datarow;

            foreach (RoleMenuInfo _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["UserMenuID"] = _list.UserMenuID;
                _datarow["MenuID"] = _list.MenuID;
                _datarow["RoleID"] = _list.RoleID;
                _datarow["RoleName"] = _list.RoleName;
                _datarow["ParentID"] = _list.ParentID;
                _datarow["DisplayText"] = _list.DisplayText;
                _datarow["MenuHeader"] = _list.MenuHeader;
                _datarow["IsMapped"] = _list.IsMapped;
                _datarow["HasAction"] = _list.HasAction;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["Description"] = _list.Description;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["OrgAddressID"] = _list.OrgAddressID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToUDTRole(List<RoleDeptMap> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("RoleID", typeof(System.Int64));
            _datatable.Columns.Add("RoleName", typeof(System.String));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("OrgAddressID", typeof(System.Int64));
            _datatable.Columns.Add("DeptID", typeof(System.Int64));

            DataRow _datarow;

            foreach (RoleDeptMap _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["RoleID"] = _list.RoleID;
                _datarow["RoleName"] = string.Empty;
                _datarow["Description"] = string.Empty;
                _datarow["OrgID"] = 0;
                _datarow["OrgAddressID"] = -1;
                _datarow["DeptID"] = _list.DeptID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }


        public static System.Data.DataTable ConvertToUDTDynamicColumnMapping(List<DynamicColumnMapping> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("DynamicColumnMappingID", typeof(System.Int32));
            _datatable.Columns.Add("SearchTypeID", typeof(System.Int32));
            _datatable.Columns.Add("SearchColumnID", typeof(System.Int32));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("OrgAddID", typeof(System.Int32));
            _datatable.Columns.Add("Deleted", typeof(System.String));
            _datatable.Columns.Add("Visible", typeof(System.String));

            DataRow _datarow;

            foreach (DynamicColumnMapping _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["DynamicColumnMappingID"] = _list.DynamicColumnMappingID;
                _datarow["SearchTypeID"] = _list.SearchTypeID;
                _datarow["SearchColumnID"] = _list.SearchColumnID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["OrgAddID"] = _list.OrgAddID;
                _datarow["Deleted"] = _list.Deleted;
                _datarow["Visible"] = _list.Visible;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }



        public static System.Data.DataTable ConvertToUDTPatientDueChartForIP(List<PatientDueChart> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("FeeType", typeof(System.String));
            _datatable.Columns.Add("FeeID", typeof(System.Int64));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("Comments", typeof(System.String));
            _datatable.Columns.Add("FromDate", typeof(System.DateTime));
            _datatable.Columns.Add("ToDate", typeof(System.DateTime));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("unit", typeof(System.Decimal));
            _datatable.Columns.Add("Amount", typeof(System.Decimal));
            _datatable.Columns.Add("DetailsID", typeof(System.Int64));
            _datatable.Columns.Add("PackageID", typeof(System.Int64));
            _datatable.Columns.Add("FromTable", typeof(System.String));
            _datatable.Columns.Add("DiscountAmount", typeof(System.Decimal));
            _datatable.Columns.Add("IsReimbursable", typeof(System.String));
            _datatable.Columns.Add("IsTaxable", typeof(System.String));
            _datatable.Columns.Add("ServiceCode", typeof(System.String));
            _datatable.Columns.Add("DiscountPercent", typeof(System.Decimal));
            _datatable.Columns.Add("DiscOrEnhanceType", typeof(System.String));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            _datatable.Columns.Add("ReimbursableAmount", typeof(System.Decimal));
            _datatable.Columns.Add("NonReimbursableAmount", typeof(System.Decimal));
            _datatable.Columns.Add("ActualAmount", typeof(System.Decimal));
            _datatable.Columns.Add("RateID", typeof(System.Int64));
            _datatable.Columns.Add("IsDiscountable", typeof(System.String));
            _datatable.Columns.Add("IsSTAT", typeof(System.String));
            _datatable.Columns.Add("IsOutSource", typeof(System.String));
            _datatable.Columns.Add("IsNABL", typeof(System.String));


            DataRow _datarow;

            foreach (PatientDueChart _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["FeeType"] = _list.FeeType;
                _datarow["FeeID"] = _list.FeeID;
                _datarow["Description"] = _list.Description;
                _datarow["Comments"] = _list.Comments;
                _datarow["FromDate"] = _list.FromDate;
                _datarow["ToDate"] = _list.ToDate;
                _datarow["Status"] = _list.Status;
                _datarow["unit"] = _list.Unit;
                _datarow["Amount"] = _list.Amount;
                _datarow["DetailsID"] = _list.DetailsID;
                _datarow["PackageID"] = _list.PackageID;
                _datarow["FromTable"] = _list.FromTable;
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
                _datarow["IsOutSource"] = _list.IsOutSource;
                _datarow["IsNABL"] = _list.IsNABL;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDPatientAllergies(List<AllergyMaster> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientID", typeof(System.Int64));
            _datatable.Columns.Add("AllergyID", typeof(System.Int32));
            _datatable.Columns.Add("AllergyName", typeof(System.String));
            _datatable.Columns.Add("AllergyType", typeof(System.String));

            DataRow _datarow;

            foreach (AllergyMaster _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientID"] = 0;
                _datarow["AllergyID"] = _list.AllergyId;
                _datarow["AllergyName"] = _list.AllergyName;
                _datarow["AllergyType"] = _list.AllergyType;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToPatientComplaintHealth(List<PatientComplaint> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("ComplaintID", typeof(System.Int32));
            _datatable.Columns.Add("ComplaintName", typeof(System.String));

            DataRow _datarow;

            foreach (PatientComplaint _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["ComplaintID"] = _list.ComplaintID;
                _datarow["ComplaintName"] = _list.ComplaintName;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToPatientComplaintAttribute(List<PatientComplaintAttribute> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientComplaintAttributeID", typeof(System.Int64));
            _datatable.Columns.Add("ComplaintID", typeof(System.Int64));
            _datatable.Columns.Add("PatientVisitId", typeof(System.Int64));
            _datatable.Columns.Add("SeqID", typeof(System.Int64));
            _datatable.Columns.Add("AttributeID", typeof(System.Int64));
            _datatable.Columns.Add("AttributevalueID", typeof(System.Int64));
            _datatable.Columns.Add("AttributeValueName", typeof(System.String));

            DataRow _datarow;

            foreach (PatientComplaintAttribute _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientComplaintAttributeID"] = _list.PatientComplaintAttributeID;
                _datarow["ComplaintID"] = _list.ComplaintID;
                _datarow["PatientVisitId"] = _list.PatientVisitId;
                _datarow["SeqID"] = _list.SeqID;
                _datarow["AttributeID"] = _list.AttributeID;
                _datarow["AttributevalueID"] = _list.AttributevalueID;
                _datarow["AttributeValueName"] = _list.AttributeValueName;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToSurgicalDetail(List<SurgicalDetail> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("SurgeryID", typeof(System.Int32));
            _datatable.Columns.Add("SurgeryName", typeof(System.String));
            _datatable.Columns.Add("ParentID", typeof(System.Int32));
            _datatable.Columns.Add("ParentName", typeof(System.String));
            _datatable.Columns.Add("TreatmentPlanDate", typeof(System.DateTime));
            _datatable.Columns.Add("HospitalName", typeof(System.String));

            DataRow _datarow;

            foreach (SurgicalDetail _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["SurgeryID"] = _list.SurgeryID;
                _datarow["SurgeryName"] = _list.SurgeryName;
                _datarow["ParentID"] = _list.ParentID;
                _datarow["ParentName"] = _list.ParentName;
                _datarow["TreatmentPlanDate"] = _list.TreatmentPlanDate;
                _datarow["HospitalName"] = _list.HospitalName;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToHistoryPKGAttribute(List<PatientHistoryAttribute> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("HID", typeof(System.Int64));
            _datatable.Columns.Add("AttributeID", typeof(System.Int64));
            _datatable.Columns.Add("AttributevalueID", typeof(System.Int64));
            _datatable.Columns.Add("AttributeName", typeof(System.String));
            _datatable.Columns.Add("AttributeValueName", typeof(System.String));
            _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
            DataRow _datarow;

            foreach (PatientHistoryAttribute _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["HID"] = _list.HistoryID;
                _datarow["AttributeID"] = _list.AttributeID;
                _datarow["AttributevalueID"] = _list.AttributevalueID;
                _datarow["AttributeName"] = _list.AttributeName;
                _datarow["AttributeValueName"] = _list.AttributeValueName;
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToANCVaccincation(List<PatientPastVaccinationHistory> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientID", typeof(System.Int64));
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("VaccinationID", typeof(System.Int32));
            _datatable.Columns.Add("VaccinationName", typeof(System.String));
            _datatable.Columns.Add("MonthOfVaccination", typeof(System.Int32));
            _datatable.Columns.Add("YearOfVaccination", typeof(System.Int32));
            _datatable.Columns.Add("VaccinationDose", typeof(System.String));
            _datatable.Columns.Add("IsBooster", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));

            DataRow _datarow;

            foreach (PatientPastVaccinationHistory _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientID"] = _list.PatientID;
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["VaccinationID"] = _list.VaccinationID;
                _datarow["VaccinationName"] = _list.VaccinationName;
                _datarow["MonthOfVaccination"] = _list.MonthOfVaccination;
                _datarow["YearOfVaccination"] = _list.YearOfVaccination;
                _datarow["VaccinationDose"] = _list.VaccinationDose;
                _datarow["IsBooster"] = _list.IsBooster;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToCommunicableDiseaseMaster(List<CommunicableDiseaseMaster> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ComplaintID", typeof(System.Int32));
            _datatable.Columns.Add("ComplaintName", typeof(System.String));
            _datatable.Columns.Add("ICDCode", typeof(System.String));
            _datatable.Columns.Add("ICDName", typeof(System.String));

            DataRow _datarow;

            foreach (CommunicableDiseaseMaster _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ComplaintID"] = _list.ComplaintId;
                _datarow["ComplaintName"] = _list.ComplaintName;
                _datarow["ICDCode"] = _list.ICDCode;
                _datarow["ICDName"] = _list.ICDName;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToNotificationAudits(List<NotificationAudit> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ReceiverType", typeof(System.String));
            _datatable.Columns.Add("Id", typeof(System.Int64));
            _datatable.Columns.Add("NotificationTypes", typeof(System.String));
            _datatable.Columns.Add("ContactInfo", typeof(System.String));
            _datatable.Columns.Add("Message", typeof(System.String));

            DataRow _datarow;

            foreach (NotificationAudit _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ReceiverType"] = _list.ReceiverType;
                _datarow["Id"] = _list.Id;
                _datarow["NotificationTypes"] = _list.NotificationTypes;
                _datarow["ContactInfo"] = _list.ContactInfo;
                _datarow["Message"] = _list.Message;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToCustomers(List<Customers> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("CustomerID", typeof(System.Int32));
            _datatable.Columns.Add("CustomerName", typeof(System.String));
            _datatable.Columns.Add("ContactPerson", typeof(System.String));
            _datatable.Columns.Add("Address1", typeof(System.String));
            _datatable.Columns.Add("Address2", typeof(System.String));
            _datatable.Columns.Add("City", typeof(System.String));
            _datatable.Columns.Add("EmailID", typeof(System.String));
            _datatable.Columns.Add("Phone", typeof(System.String));
            _datatable.Columns.Add("Mobile", typeof(System.String));
            _datatable.Columns.Add("FaxNumber", typeof(System.String));
            _datatable.Columns.Add("PANNumber", typeof(System.String));
            _datatable.Columns.Add("TINNo", typeof(System.String));
            _datatable.Columns.Add("CSTNo", typeof(System.String));
            _datatable.Columns.Add("DrugLicenceNo", typeof(System.String));
            _datatable.Columns.Add("ServiceTaxNo", typeof(System.String));
            _datatable.Columns.Add("CustomerTypeID", typeof(System.Int32));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("IsDeleted", typeof(System.String));
            _datatable.Columns.Add("TermsConditions", typeof(System.String));
            _datatable.Columns.Add("OrgAddressID", typeof(System.Int32));

            DataRow _datarow;

            foreach (Customers _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["CustomerID"] = _list.CustomerID;
                _datarow["CustomerName"] = _list.CustomerName;
                _datarow["ContactPerson"] = _list.ContactPerson;
                _datarow["Address1"] = _list.Address1;
                _datarow["Address2"] = _list.Address2;
                _datarow["City"] = _list.City;
                _datarow["EmailID"] = _list.EmailID;
                _datarow["Phone"] = _list.Phone;
                _datarow["Mobile"] = _list.Mobile;
                _datarow["FaxNumber"] = _list.FaxNumber;
                _datarow["PANNumber"] = _list.PANNumber;
                _datarow["TINNo"] = _list.TINNo;
                _datarow["CSTNo"] = _list.CSTNo;
                _datarow["DrugLicenceNo"] = _list.DrugLicenceNo;
                _datarow["ServiceTaxNo"] = _list.ServiceTaxNo;
                _datarow["CustomerTypeID"] = _list.CustomerTypeID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["IsDeleted"] = _list.IsDeleted;
                _datarow["TermsConditions"] = _list.TermsConditions;
                _datarow["OrgAddressID"] = _list.OrgAddressID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }


        public static System.Data.DataTable ConvertToCustomerLocations(List<CustomerLocations> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("LocationID", typeof(System.Int32));
            _datatable.Columns.Add("CustomerID", typeof(System.Int32));
            _datatable.Columns.Add("CustomerName", typeof(System.String));
            _datatable.Columns.Add("Address", typeof(System.String));
            _datatable.Columns.Add("City", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("OrgAddressID", typeof(System.Int32));
            _datatable.Columns.Add("LocationName", typeof(System.String));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("Phone", typeof(System.String));
            _datatable.Columns.Add("FaxNumber", typeof(System.String));

            DataRow _datarow;

            foreach (CustomerLocations _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["LocationID"] = _list.LocationID;
                _datarow["CustomerID"] = _list.CustomerID;
                _datarow["CustomerName"] = _list.CustomerName;
                _datarow["Address"] = _list.Address;
                _datarow["City"] = _list.City;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["OrgAddressID"] = _list.OrgAddressID;
                _datarow["LocationName"] = _list.LocationName;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["Phone"] = _list.Phone;
                _datarow["FaxNumber"] = _list.FaxNumber;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }


        public static System.Data.DataTable ConvertToSalesItemsMapping(List<SalesItemBasket> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("CategoryID", typeof(System.Int32));
            _datatable.Columns.Add("ProductID", typeof(System.Int64));
            _datatable.Columns.Add("CategoryName", typeof(System.String));
            _datatable.Columns.Add("ProductName", typeof(System.String));
            _datatable.Columns.Add("Quantity", typeof(System.Decimal));
            _datatable.Columns.Add("ComplimentQTY", typeof(System.Decimal));
            _datatable.Columns.Add("Tax", typeof(System.Decimal));
            _datatable.Columns.Add("Discount", typeof(System.Decimal));
            _datatable.Columns.Add("Rate", typeof(System.Decimal));
            _datatable.Columns.Add("UOMID", typeof(System.Int32));
            _datatable.Columns.Add("Unit", typeof(System.String));
            _datatable.Columns.Add("UnitPrice", typeof(System.Decimal));
            _datatable.Columns.Add("LSUnit", typeof(System.String));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("ExpiryDate", typeof(System.DateTime));
            _datatable.Columns.Add("Manufacture", typeof(System.DateTime));
            _datatable.Columns.Add("BatchNo", typeof(System.String));
            _datatable.Columns.Add("Providedby", typeof(System.Int64));
            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("Amount", typeof(System.Decimal));
            _datatable.Columns.Add("ID", typeof(System.Int64));
            _datatable.Columns.Add("POQuantity", typeof(System.Decimal));
            _datatable.Columns.Add("POUnit", typeof(System.String));
            _datatable.Columns.Add("RECQuantity", typeof(System.Decimal));
            _datatable.Columns.Add("RECUnit", typeof(System.String));
            _datatable.Columns.Add("SellingUnit", typeof(System.String));
            _datatable.Columns.Add("InvoiceQty", typeof(System.Decimal));
            _datatable.Columns.Add("RcvdLSUQty", typeof(System.Decimal));
            _datatable.Columns.Add("AttributeDetail", typeof(System.String));
            _datatable.Columns.Add("HasExpiryDate", typeof(System.String));
            _datatable.Columns.Add("HasBatchNo", typeof(System.String));
            _datatable.Columns.Add("HasUsage", typeof(System.String));
            _datatable.Columns.Add("UsageCount", typeof(System.Int32));
            _datatable.Columns.Add("RakNo", typeof(System.String));
            _datatable.Columns.Add("MRP", typeof(System.Decimal));
            _datatable.Columns.Add("InHandQuantity", typeof(System.Decimal));
            _datatable.Columns.Add("ExciseTax", typeof(System.Decimal));
            _datatable.Columns.Add("DiscOrEnhancePercent", typeof(System.Decimal));
            _datatable.Columns.Add("DiscOrEnhanceType", typeof(System.String));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            _datatable.Columns.Add("ProductKey", typeof(System.String));
            _datatable.Columns.Add("UnitSellingPrice", typeof(System.Decimal));
            _datatable.Columns.Add("UnitCostPrice", typeof(System.Decimal));
            _datatable.Columns.Add("ReceivedOrgID", typeof(System.Int32));
            _datatable.Columns.Add("ParentProductID", typeof(System.Int64));
            _datatable.Columns.Add("ReceivedOrgAddID", typeof(System.Int32));
            _datatable.Columns.Add("ParentProductKey", typeof(System.String));
            _datatable.Columns.Add("PrescriptionNO", typeof(System.String));
            _datatable.Columns.Add("SalesOrderID", typeof(System.Int64));
            _datatable.Columns.Add("CustomerID", typeof(System.Int32));
            _datatable.Columns.Add("StockOutFlowID", typeof(System.Int64));
            _datatable.Columns.Add("StockReceivedID", typeof(System.Int64));
            _datatable.Columns.Add("InvoiceNo", typeof(System.String));
            _datatable.Columns.Add("DCNo", typeof(System.String));
            _datatable.Columns.Add("StockInHandID", typeof(System.Int64));
            _datatable.Columns.Add("DiscountAmount", typeof(System.Decimal));
            _datatable.Columns.Add("CstTax", typeof(System.Decimal));
            _datatable.Columns.Add("CsTaxAmount", typeof(System.Decimal));
            _datatable.Columns.Add("CustomerLocationID", typeof(System.Int32));

            DataRow _datarow;

            foreach (SalesItemBasket _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["CategoryID"] = _list.CategoryID;
                _datarow["ProductID"] = _list.ProductID;
                _datarow["CategoryName"] = _list.CategoryName;
                _datarow["ProductName"] = _list.ProductName;
                _datarow["Quantity"] = _list.Quantity;
                _datarow["ComplimentQTY"] = _list.ComplimentQTY;
                _datarow["Tax"] = _list.Tax;
                _datarow["Discount"] = _list.Discount;
                _datarow["Rate"] = _list.Rate;
                _datarow["UOMID"] = _list.UOMID;
                _datarow["Unit"] = _list.Unit;
                _datarow["UnitPrice"] = _list.UnitPrice;
                _datarow["LSUnit"] = _list.LSUnit;
                _datarow["Description"] = _list.Description;
                _datarow["ExpiryDate"] = _list.ExpiryDate;
                _datarow["Manufacture"] = _list.Manufacture;
                _datarow["BatchNo"] = _list.BatchNo;
                _datarow["Providedby"] = _list.Providedby;
                _datarow["Type"] = _list.Type;
                _datarow["Amount"] = _list.Amount;
                _datarow["ID"] = _list.ID;
                _datarow["POQuantity"] = _list.POQuantity;
                _datarow["POUnit"] = _list.POUnit;
                _datarow["RECQuantity"] = _list.RECQuantity;
                _datarow["RECUnit"] = _list.RECUnit;
                _datarow["SellingUnit"] = _list.SellingUnit;
                _datarow["InvoiceQty"] = _list.InvoiceQty;
                _datarow["RcvdLSUQty"] = _list.RcvdLSUQty;
                _datarow["AttributeDetail"] = _list.AttributeDetail;
                _datarow["HasExpiryDate"] = _list.HasExpiryDate;
                _datarow["HasBatchNo"] = _list.HasBatchNo;
                _datarow["HasUsage"] = _list.HasUsage;
                _datarow["UsageCount"] = _list.UsageCount;
                _datarow["RakNo"] = _list.RakNo;
                _datarow["MRP"] = _list.MRP;
                _datarow["InHandQuantity"] = _list.InHandQuantity;
                _datarow["ExciseTax"] = _list.ExciseTax;
                _datarow["DiscOrEnhancePercent"] = _list.DiscOrEnhancePercent;
                _datarow["DiscOrEnhanceType"] = _list.DiscOrEnhanceType;
                _datarow["Remarks"] = _list.Remarks;
                _datarow["ProductKey"] = _list.ProductKey;
                _datarow["UnitSellingPrice"] = _list.UnitSellingPrice;
                _datarow["UnitCostPrice"] = _list.UnitCostPrice;
                _datarow["ReceivedOrgID"] = _list.ReceivedOrgID;
                _datarow["ParentProductID"] = _list.ParentProductID;
                _datarow["ReceivedOrgAddID"] = _list.ReceivedOrgAddID;
                _datarow["ParentProductKey"] = _list.ParentProductKey;
                _datarow["PrescriptionNO"] = _list.PrescriptionNO;
                _datarow["SalesOrderID"] = _list.SalesOrderID;
                _datarow["CustomerID"] = _list.CustomerID;
                _datarow["StockOutFlowID"] = _list.StockOutFlowID;
                _datarow["StockReceivedID"] = _list.StockReceivedID;
                _datarow["InvoiceNo"] = _list.InvoiceNo;
                _datarow["DCNo"] = _list.DCNo;
                _datarow["StockInHandID"] = _list.StockInHandID;
                _datarow["DiscountAmount"] = _list.DiscountAmount;
                _datarow["CstTax"] = _list.CstTax;
                _datarow["CsTaxAmount"] = _list.CsTaxAmount;
                _datarow["CustomerLocationID"] = _list.CustomerLocationID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }


        public static System.Data.DataTable ConvertToHIDECType(List<PatientHistory> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("HIDECID", typeof(System.Int32));
            _datatable.Columns.Add("Name", typeof(System.String));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ComplaintID", typeof(System.Int32));

            DataRow _datarow;

            foreach (PatientHistory _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["HIDECID"] = _list.HistoryID;
                _datarow["Name"] = _list.HistoryName;
                _datarow["Description"] = _list.Description;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ComplaintID"] = _list.ComplaintId;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToHIDECType(List<PatientDisChkLstDtl> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("HIDECID", typeof(System.Int32));
            _datatable.Columns.Add("Name", typeof(System.String));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ComplaintID", typeof(System.Int32));

            DataRow _datarow;

            foreach (PatientDisChkLstDtl _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientVisitID"] = _list.PatientVisitId;
                _datarow["HIDECID"] = _list.ChkLstID;
                _datarow["Name"] = "";
                _datarow["Description"] = _list.Comments;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ComplaintID"] = 0;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }



        public static System.Data.DataTable ConvertToUDTPatientComplaintIP(List<PatientComplaint> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("ComplaintID", typeof(System.Int32));
            _datatable.Columns.Add("ComplaintName", typeof(System.String));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("Query", typeof(System.String));
            _datatable.Columns.Add("ComplaintType", typeof(System.String));
            _datatable.Columns.Add("ICDCode", typeof(System.String));
            _datatable.Columns.Add("ICDDescription", typeof(System.String));
            _datatable.Columns.Add("ICDCodeStatus", typeof(System.String));
            _datatable.Columns.Add("OnBehalf", typeof(System.Int64));
            _datatable.Columns.Add("IsPrimarydiagnosed", typeof(System.String));

            DataRow _datarow;

            foreach (PatientComplaint _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["ComplaintID"] = _list.ComplaintID;
                _datarow["ComplaintName"] = _list.ComplaintName;
                _datarow["Description"] = _list.Description;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["Query"] = _list.Query;
                _datarow["ComplaintType"] = _list.ComplaintType;
                _datarow["ICDCode"] = _list.ICDCode;
                _datarow["ICDDescription"] = _list.ICDDescription;
                _datarow["ICDCodeStatus"] = _list.ICDCodeStatus;
                _datarow["OnBehalf"] = _list.OnBehalf;
                _datarow["IsPrimarydiagnosed"] = _list.IsPrimaryDiagnosis;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }


        public static System.Data.DataTable ConvertToIPTreatmentPlan(List<IPTreatmentPlan> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientID", typeof(System.Int64));
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("IPTreatmentPlanID", typeof(System.Int32));
            _datatable.Columns.Add("IPTreatmentPlanName", typeof(System.String));
            _datatable.Columns.Add("Prosthesis", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("OperationID", typeof(System.Int64));
            _datatable.Columns.Add("ParentID", typeof(System.Int32));
            _datatable.Columns.Add("ParentName", typeof(System.String));
            _datatable.Columns.Add("TreatmentPlanDate", typeof(System.DateTime));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("StagePlanned", typeof(System.String));
            _datatable.Columns.Add("TreatmentPlanID", typeof(System.Int32));

            DataRow _datarow;

            foreach (IPTreatmentPlan _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientID"] = _list.PatientID;
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["IPTreatmentPlanID"] = _list.IPTreatmentPlanID;
                _datarow["IPTreatmentPlanName"] = _list.IPTreatmentPlanName;
                _datarow["Prosthesis"] = _list.Prosthesis;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["OperationID"] = _list.OperationID;
                _datarow["ParentID"] = _list.ParentID;
                _datarow["ParentName"] = _list.ParentName;
                _datarow["TreatmentPlanDate"] = _list.TreatmentPlanDate;
                _datarow["Status"] = _list.Status;
                _datarow["StagePlanned"] = _list.StagePlanned;
                _datarow["TreatmentPlanID"] = _list.TreatmentPlanID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }


        public static System.Data.DataTable ConvertToOperationNotes(List<OperationNotes> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("OperationID", typeof(System.Int64));
            _datatable.Columns.Add("PatientID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("PatientVistID", typeof(System.Int64));
            _datatable.Columns.Add("FromTime", typeof(System.DateTime));
            _datatable.Columns.Add("ToTime", typeof(System.DateTime));
            _datatable.Columns.Add("SurgeryTypeID", typeof(System.Int32));
            _datatable.Columns.Add("AnesthesiaTypeID", typeof(System.Int32));
            _datatable.Columns.Add("OperationTypeID", typeof(System.Int32));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));

            DataRow _datarow;

            foreach (OperationNotes _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["OperationID"] = _list.OperationID;
                _datarow["PatientID"] = _list.PatientID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["PatientVistID"] = _list.PatientVistID;
                _datarow["FromTime"] = _list.FromTime;
                _datarow["ToTime"] = _list.ToTime;
                _datarow["SurgeryTypeID"] = _list.SurgeryTypeID;
                _datarow["AnesthesiaTypeID"] = _list.AnesthesiaTypeID;
                _datarow["OperationTypeID"] = _list.OperationTypeID;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToOperationStaff(List<OperationStaff> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("OperationStaffID", typeof(System.Int64));
            _datatable.Columns.Add("OperationID", typeof(System.Int64));
            _datatable.Columns.Add("StaffType", typeof(System.String));
            _datatable.Columns.Add("StaffID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("PatientVistID", typeof(System.Int64));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));

            DataRow _datarow;

            foreach (OperationStaff _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["OperationStaffID"] = _list.OperationStaffID;
                _datarow["OperationID"] = _list.OperationID;
                _datarow["StaffType"] = _list.StaffType;
                _datarow["StaffID"] = _list.StaffID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["PatientVistID"] = _list.PatientVistID;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToOperationFinding(List<OperationFinding> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("OperationFindingID", typeof(System.Int64));
            _datatable.Columns.Add("OperationID", typeof(System.Int64));
            _datatable.Columns.Add("OperationFindings", typeof(System.String));
            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("PatientVistID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));

            DataRow _datarow;

            foreach (OperationFinding _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["OperationFindingID"] = _list.OperationFindingID;
                _datarow["OperationID"] = _list.OperationID;
                _datarow["OperationFindings"] = _list.OperationFindings;
                _datarow["Type"] = _list.Type;
                _datarow["PatientVistID"] = _list.PatientVistID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToOperationComplication(List<OperationComplication> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("OperationComplicationID", typeof(System.Int64));
            _datatable.Columns.Add("OperationID", typeof(System.Int64));
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("ComplicationName", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ICDCode", typeof(System.String));
            _datatable.Columns.Add("ICDDescription", typeof(System.String));
            _datatable.Columns.Add("ComplaintID", typeof(System.Int32));
            _datatable.Columns.Add("ICDCodeStatus", typeof(System.String));

            DataRow _datarow;

            foreach (OperationComplication _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["OperationComplicationID"] = _list.OperationComplicationID;
                _datarow["OperationID"] = _list.OperationID;
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["ComplicationName"] = _list.ComplicationName;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["ICDCode"] = _list.ICDCode;
                _datarow["ICDDescription"] = _list.ICDDescription;
                _datarow["ComplaintID"] = _list.ComplaintID;
                _datarow["ICDCodeStatus"] = _list.ICDCodeStatus;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }


        public static System.Data.DataTable ConvertToDischargeSummary(List<DischargeSummary> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("DischargeSummaryID", typeof(System.Int64));
            _datatable.Columns.Add("PatientVistID", typeof(System.Int64));
            _datatable.Columns.Add("PatientID", typeof(System.Int64));
            _datatable.Columns.Add("DateOfDischarge", typeof(System.DateTime));
            _datatable.Columns.Add("TypeOfDischarge", typeof(System.Int32));
            _datatable.Columns.Add("ConditionOnDischarge", typeof(System.String));
            _datatable.Columns.Add("HospitalCourse", typeof(System.String));
            _datatable.Columns.Add("NextReviewAfter", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));

            DataRow _datarow;

            foreach (DischargeSummary _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["DischargeSummaryID"] = _list.DischargeSummaryID;
                _datarow["PatientVistID"] = _list.PatientVistID;
                _datarow["PatientID"] = _list.PatientID;
                _datarow["DateOfDischarge"] = _list.DateOfDischarge;
                _datarow["TypeOfDischarge"] = _list.TypeOfDischarge;
                _datarow["ConditionOnDischarge"] = _list.ConditionOnDischarge;
                _datarow["HospitalCourse"] = _list.HospitalCourse;
                _datarow["NextReviewAfter"] = _list.NextReviewAfter;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToDischargeInvNotes(List<DischargeInvNotes> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("DischargeInvNotesID", typeof(System.Int64));
            _datatable.Columns.Add("InvestigationDetails", typeof(System.String));
            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("HistoryDetails", typeof(System.String));
            _datatable.Columns.Add("VisitID", typeof(System.Int64));
            _datatable.Columns.Add("TestSequenceOrder", typeof(System.Int32));
            DataRow _datarow;

            foreach (DischargeInvNotes _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["DischargeInvNotesID"] = _list.DischargeInvNotesID;
                _datarow["InvestigationDetails"] = _list.InvestigationDetails;
                _datarow["Type"] = _list.Type;
                _datarow["HistoryDetails"] = _list.HistoryDetails;
                _datarow["VisitID"] = _list.VisitID;
                _datarow["TestSequenceOrder"] = _list.TestSequenceOrder;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToPatientInvestigation(List<PatientInvestigation> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("InvestigationName", typeof(System.String));
            _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
            _datatable.Columns.Add("GroupID", typeof(System.Int32));
            _datatable.Columns.Add("GroupName", typeof(System.String));
            _datatable.Columns.Add("GroupComment", typeof(System.String));
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CollectedDateTime", typeof(System.DateTime));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("ComplaintID", typeof(System.Int32));
            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("InvestigationMethodID", typeof(System.Int64));
            _datatable.Columns.Add("MethodName", typeof(System.String));
            _datatable.Columns.Add("KitID", typeof(System.Int64));
            _datatable.Columns.Add("KitName", typeof(System.String));
            _datatable.Columns.Add("InstrumentID", typeof(System.Int64));
            _datatable.Columns.Add("InstrumentName", typeof(System.String));
            _datatable.Columns.Add("Interpretation", typeof(System.String));
            _datatable.Columns.Add("PrincipleID", typeof(System.Int64));
            _datatable.Columns.Add("PrincipleName", typeof(System.String));
            _datatable.Columns.Add("QCData", typeof(System.String));
            _datatable.Columns.Add("InvestigationSampleContainerID", typeof(System.Int32));
            _datatable.Columns.Add("PackageID", typeof(System.Int32));
            _datatable.Columns.Add("PackageName", typeof(System.String));
            _datatable.Columns.Add("Reason", typeof(System.String));
            _datatable.Columns.Add("ReportStatus", typeof(System.String));
            _datatable.Columns.Add("ReferenceRange", typeof(System.String));
            _datatable.Columns.Add("PerformingPhysicainName", typeof(System.String));
            _datatable.Columns.Add("ApprovedBy", typeof(System.Int64));
            _datatable.Columns.Add("GUID", typeof(System.String));
            _datatable.Columns.Add("IsAbnormal", typeof(System.String));
            _datatable.Columns.Add("AccessionNumber", typeof(System.Int64));
            _datatable.Columns.Add("AutoApproveLoginID", typeof(System.Int64));
            _datatable.Columns.Add("ValidatedBy", typeof(System.Int64));
            _datatable.Columns.Add("RemarksID", typeof(System.Int64));
            _datatable.Columns.Add("MedicalRemarks", typeof(System.String));
            _datatable.Columns.Add("GroupMedicalRemarks", typeof(System.String));
            _datatable.Columns.Add("InvSampleStatusID", typeof(System.Int32));
            _datatable.Columns.Add("AuthorizedBy", typeof(System.Int64));
            _datatable.Columns.Add("ConvReferenceRange", typeof(System.String));
            _datatable.Columns.Add("ManualAbnormal", typeof(System.String));
            _datatable.Columns.Add("IsAutoAuthorize", typeof(System.String));
            _datatable.Columns.Add("PrintableRange", typeof(System.String));
            _datatable.Columns.Add("IsAutoValidate", typeof(System.String));
            _datatable.Columns.Add("InvStatusReasonID", typeof(System.Int64));
            _datatable.Columns.Add("IsSensitive", typeof(System.String));
			/* BEGIN | NA | Sabari | 20181202 | Created | HOLD */
            _datatable.Columns.Add("IsReportable", typeof(System.Boolean));
            DataRow _datarow;

            foreach (PatientInvestigation _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["InvestigationName"] = _list.InvestigationName;
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datarow["GroupID"] = _list.GroupID;
                _datarow["GroupName"] = _list.GroupName;
                _datarow["GroupComment"] = _list.GroupComment;
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["CreatedBy"] = _list.CreatedBy;
                if (_list.CollectedDateTime != null && _list.CollectedDateTime.CompareTo(DateTime.MinValue) == 0)
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
				/* END | NA | Sabari | 20181202 | Created | HOLD */
                _datarow["IsReportable"] = _list.IsReportable;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTPatientInvestigation(List<PatientInvestigation> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
            _datatable.Columns.Add("InvestigationName", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("InvestigationMethodID", typeof(System.Int64));
            _datatable.Columns.Add("InvestigationSampleContainerID", typeof(System.Int32));
            _datatable.Columns.Add("SampleID", typeof(System.Int32));
            _datatable.Columns.Add("InvestigationSiteID", typeof(System.Int32));
            _datatable.Columns.Add("IsCompleted", typeof(System.String));
            _datatable.Columns.Add("CollectedDateTime", typeof(System.DateTime));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("ComplaintID", typeof(System.Int32));
            _datatable.Columns.Add("GroupID", typeof(System.Int32));
            _datatable.Columns.Add("GroupName", typeof(System.String));
            _datatable.Columns.Add("Reason", typeof(System.String));
            _datatable.Columns.Add("ReportStatus", typeof(System.String));
            _datatable.Columns.Add("ReferenceRange", typeof(System.String));
            _datatable.Columns.Add("MethodName", typeof(System.String));
            _datatable.Columns.Add("IPInvSampleCollectionMasterID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("WorklistDeletedStatus", typeof(System.String));
            _datatable.Columns.Add("PerformingPhysicainName", typeof(System.String));
            _datatable.Columns.Add("KitID", typeof(System.Int64));
            _datatable.Columns.Add("KitName", typeof(System.String));
            _datatable.Columns.Add("InstrumentID", typeof(System.Int64));
            _datatable.Columns.Add("InstrumentName", typeof(System.String));
            _datatable.Columns.Add("Interpretation", typeof(System.String));
            _datatable.Columns.Add("PrincipleID", typeof(System.Int64));
            _datatable.Columns.Add("WorkListID", typeof(System.Int64));
            _datatable.Columns.Add("DeviceID", typeof(System.String));
            _datatable.Columns.Add("PatientInvID", typeof(System.Int64));
            DataRow _datarow;
            foreach (PatientInvestigation _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datarow["InvestigationName"] = _list.InvestigationName;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["InvestigationMethodID"] = _list.InvestigationMethodID;
                _datarow["InvestigationSampleContainerID"] = _list.InvestigationSampleContainerID;
                _datarow["SampleID"] = _list.SampleID;
                _datarow["InvestigationSiteID"] = _list.InvestigationSiteID;
                _datarow["IsCompleted"] = _list.IsCompleted;
                if (_list.CollectedDateTime != null && _list.CollectedDateTime.CompareTo(DateTime.MinValue) == 0)
                {
                    _datarow["CollectedDateTime"] = DateTime.Now;
                }
                else
                {
                    _datarow["CollectedDateTime"] = _list.CollectedDateTime;
                }
                _datarow["Status"] = _list.Status;
                _datarow["ComplaintID"] = _list.ComplaintId;
                _datarow["GroupID"] = _list.GroupID;
                _datarow["GroupName"] = _list.GroupName;
                _datarow["Reason"] = _list.Reason;
                _datarow["ReportStatus"] = _list.ReportStatus;
                _datarow["ReferenceRange"] = _list.ReferenceRange;
                _datarow["MethodName"] = _list.MethodName;
                _datarow["IPInvSampleCollectionMasterID"] = _list.IPInvSampleCollectionMasterID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["WorklistDeletedStatus"] = _list.WorklistDeletedStatus;
                _datarow["PerformingPhysicainName"] = _list.PerformingPhysicainName;
                _datarow["KitID"] = _list.KitID;
                _datarow["KitName"] = _list.KitName;
                _datarow["InstrumentID"] = _list.InstrumentID;
                _datarow["InstrumentName"] = _list.InstrumentName;
                _datarow["Interpretation"] = _list.Interpretation;
                _datarow["PrincipleID"] = _list.PrincipleID;
                _datarow["WorkListID"] = _list.WorkListID;
                _datarow["DeviceID"] = _list.DeviceID;
                _datarow["PatientInvID"] = _list.PatientInvID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }
        public static System.Data.DataTable ConvertToUDTTPAPayment(List<PatientDueChart> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("VisitID", typeof(System.Int64));
            _datatable.Columns.Add("TypeID", typeof(System.Int32));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("Comments", typeof(System.String));
            _datatable.Columns.Add("FromDate", typeof(System.DateTime));
            _datatable.Columns.Add("ToDate", typeof(System.DateTime));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("unit", typeof(System.Decimal));
            _datatable.Columns.Add("Amount", typeof(System.Decimal));
            _datatable.Columns.Add("DetailsID", typeof(System.Int64));
            _datatable.Columns.Add("RightOff", typeof(System.Decimal));
            _datatable.Columns.Add("TDS", typeof(System.Decimal));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("BankNameorCardType", typeof(System.String));
            _datatable.Columns.Add("ChequeorCardNumber", typeof(System.String));
            _datatable.Columns.Add("TPADiscountAmt", typeof(System.Decimal));
            _datatable.Columns.Add("TPASettledAmt", typeof(System.Decimal));
            _datatable.Columns.Add("TPADisallowedAmt", typeof(System.Decimal));
            _datatable.Columns.Add("TPARemarks", typeof(System.String));
            _datatable.Columns.Add("TPAApproverID", typeof(System.Int64));
            _datatable.Columns.Add("TPAApproverName", typeof(System.String));
            _datatable.Columns.Add("TPAApprovedDate", typeof(System.DateTime));
            _datatable.Columns.Add("TPAWriteOffApprover", typeof(System.Int64));

            DataRow _datarow;

            foreach (PatientDueChart _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["VisitID"] = _list.VisitID;
                _datarow["TypeID"] = _list.TypeID;
                _datarow["Description"] = _list.Description;
                _datarow["Comments"] = _list.Comments;
                _datarow["FromDate"] = _list.FromDate;
                _datarow["ToDate"] = _list.ToDate;
                _datarow["Status"] = _list.Status;
                _datarow["unit"] = _list.Unit;
                _datarow["Amount"] = _list.Amount;
                _datarow["DetailsID"] = _list.DetailsID;
                _datarow["RightOff"] = _list.RightOff;
                _datarow["TDS"] = _list.TDS;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["BankNameorCardType"] = _list.BankNameorCardType;
                _datarow["ChequeorCardNumber"] = _list.ChequeorCardNumber;
                _datarow["TPADiscountAmt"] = _list.TPADiscountAmt;
                _datarow["TPASettledAmt"] = _list.TPASettledAmt;
                _datarow["TPADisallowedAmt"] = _list.TPADisallowedAmt;
                _datarow["TPARemarks"] = _list.TPARemarks;
                _datarow["TPAApproverID"] = _list.TPAApproverID;
                _datarow["TPAApproverName"] = _list.TPAApproverName;
                _datarow["TPAApprovedDate"] = _list.TPAApprovedDate;
                _datarow["TPAWriteOffApprover"] = _list.TPAWriteOffApprover;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToCauseOfDeath(List<CauseOfDeath> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("CauseOfDeathID", typeof(System.Int64));
            _datatable.Columns.Add("CauseOfDeathTypeID", typeof(System.Int64));
            _datatable.Columns.Add("CauseOfDeathType", typeof(System.String));
            _datatable.Columns.Add("ComplaintID", typeof(System.Int32));
            _datatable.Columns.Add("ComplaintName", typeof(System.String));
            _datatable.Columns.Add("ICDCode", typeof(System.String));
            _datatable.Columns.Add("ICDDescription", typeof(System.String));
            _datatable.Columns.Add("ICDCodeStatus", typeof(System.String));

            DataRow _datarow;

            foreach (CauseOfDeath _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["CauseOfDeathID"] = _list.CauseOfDeathID;
                _datarow["CauseOfDeathTypeID"] = _list.CauseOfDeathTypeID;
                _datarow["CauseOfDeathType"] = _list.CauseOfDeathType;
                _datarow["ComplaintID"] = _list.ComplaintID;
                _datarow["ComplaintName"] = _list.ComplaintName;
                _datarow["ICDCode"] = _list.ICDCode;
                _datarow["ICDDescription"] = _list.ICDDescription;
                _datarow["ICDCodeStatus"] = _list.ICDCodeStatus;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToHistoryPKGType(List<PatientHistory> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("HID", typeof(System.Int64));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("HistoryName", typeof(System.String));
            _datatable.Columns.Add("ComplaintId", typeof(System.Int32));

            DataRow _datarow;

            foreach (PatientHistory _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["HID"] = _list.HistoryID;
                _datarow["Description"] = _list.Description;
                _datarow["HistoryName"] = _list.HistoryName;
                _datarow["ComplaintId"] = _list.ComplaintId;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertTopatientOrganDonation(List<OrganRegWithMapping> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientID", typeof(System.Int64));
            _datatable.Columns.Add("OrganID", typeof(System.Int16));
            _datatable.Columns.Add("OrganRegWith", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));

            DataRow _datarow;

            foreach (OrganRegWithMapping _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientID"] = _list.PatientID;
                _datarow["OrganID"] = _list.OrganID;
                _datarow["OrganRegWith"] = _list.OrganRegWith;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTOrthoPatientDetails(List<OrthoPatientDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("SpecialityPartsName", typeof(System.String));
            _datatable.Columns.Add("Status", typeof(System.String));

            DataRow _datarow;

            foreach (OrthoPatientDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["SpecialityPartsName"] = _list.SpecialityPartsName;
                _datarow["Status"] = _list.Status;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToUDTPatientBodyPartDetails(List<PatientBodyPartDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("BodyPartsID", typeof(System.Int64));
            _datatable.Columns.Add("Position", typeof(System.String));
            _datatable.Columns.Add("ChildItemID", typeof(System.Int64));
            _datatable.Columns.Add("ChildItemDescription", typeof(System.String));
            _datatable.Columns.Add("Status", typeof(System.String));

            DataRow _datarow;

            foreach (PatientBodyPartDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["BodyPartsID"] = _list.BodyPartsID;
                _datarow["Position"] = _list.Position;
                _datarow["ChildItemID"] = _list.ChildItemID;
                _datarow["ChildItemDescription"] = _list.ChildItemDescription;
                _datarow["Status"] = _list.Status;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }



        public static System.Data.DataTable ConvertToUDTPatientOpenWound(List<PatientOpenWound> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("Size", typeof(System.String));
            _datatable.Columns.Add("Units", typeof(System.String));
            _datatable.Columns.Add("Location", typeof(System.String));
            _datatable.Columns.Add("Description", typeof(System.String));

            DataRow _datarow;

            foreach (PatientOpenWound _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["Size"] = _list.Size;
                _datarow["Units"] = _list.Units;
                _datarow["Location"] = _list.Location;
                _datarow["Description"] = _list.Description;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }



        public static System.Data.DataTable ConvertToUDTPatientVascularDetails(List<PatientVascularDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("VascularDeficitID", typeof(System.Int64));

            DataRow _datarow;

            foreach (PatientVascularDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["VascularDeficitID"] = _list.VascularDeficitID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }


        public static System.Data.DataTable ConvertToUDTPatientNeurologicalDetails(List<PatientNeurologicalDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("NeurologicalType", typeof(System.String));
            _datatable.Columns.Add("ItemID", typeof(System.Int64));

            DataRow _datarow;

            foreach (PatientNeurologicalDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["NeurologicalType"] = _list.NeurologicalType;
                _datarow["ItemID"] = _list.ItemID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }


        public static System.Data.DataTable ConvertToUDTPatientReflexes(List<PatientReflexes> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ReflexesTypeID", typeof(System.Int64));
            _datatable.Columns.Add("Position", typeof(System.String));
            _datatable.Columns.Add("Status", typeof(System.String));

            DataRow _datarow;

            foreach (PatientReflexes _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ReflexesTypeID"] = _list.ReflexesTypeID;
                _datarow["Position"] = _list.Position;
                _datarow["Status"] = _list.Status;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }


        public static System.Data.DataTable ConvertToUDTPatientMuscleDetail(List<PatientMuscleDetail> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("MuscleID", typeof(System.Int64));
            _datatable.Columns.Add("MusclePower", typeof(System.String));
            _datatable.Columns.Add("MuscleTone", typeof(System.String));

            DataRow _datarow;

            foreach (PatientMuscleDetail _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["MuscleID"] = _list.MuscleID;
                _datarow["MusclePower"] = _list.MusclePower;
                _datarow["MuscleTone"] = _list.MuscleTone;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }


        public static System.Data.DataTable ConvertToUDTPatientMuscleWasting(List<PatientMuscleWasting> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("ItemID", typeof(System.Int64));

            DataRow _datarow;

            foreach (PatientMuscleWasting _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["Status"] = _list.Status;
                _datarow["ItemID"] = _list.ItemID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToUDTPatientDueChart(List<PatientInvestigation> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("FeeType", typeof(System.String));
            _datatable.Columns.Add("FeeID", typeof(System.Int64));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("Comments", typeof(System.String));
            _datatable.Columns.Add("FromDate", typeof(System.DateTime));
            _datatable.Columns.Add("ToDate", typeof(System.DateTime));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("unit", typeof(System.Decimal));
            _datatable.Columns.Add("Amount", typeof(System.Decimal));
            _datatable.Columns.Add("DetailsID", typeof(System.Int64));
            _datatable.Columns.Add("PackageID", typeof(System.Int64));
            _datatable.Columns.Add("SpecialityID", typeof(System.Int32));
            _datatable.Columns.Add("UserID", typeof(System.Int64));
            _datatable.Columns.Add("DiscountAmount", typeof(System.Decimal));
            _datatable.Columns.Add("IsReimbursable", typeof(System.String));
            _datatable.Columns.Add("IsTaxable", typeof(System.String));
            _datatable.Columns.Add("ServiceCode", typeof(System.String));
            _datatable.Columns.Add("DiscountPercent", typeof(System.Decimal));
            _datatable.Columns.Add("DiscOrEnhanceType", typeof(System.String));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            _datatable.Columns.Add("ReimbursableAmount", typeof(System.Decimal));
            _datatable.Columns.Add("NonReimbursableAmount", typeof(System.Decimal));
            _datatable.Columns.Add("ActualAmount", typeof(System.Decimal));
            _datatable.Columns.Add("RateID", typeof(System.Int64));
            _datatable.Columns.Add("IsDiscountable", typeof(System.String));
            _datatable.Columns.Add("IsSTAT", typeof(System.String));
            _datatable.Columns.Add("IsOutSource", typeof(System.String));
            _datatable.Columns.Add("IsNABL", typeof(System.String));

            DataRow _datarow;

            foreach (PatientInvestigation _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                if (_list.GroupID == 0)
                {
                    _datarow["FeeType"] = "INV";
                    _datarow["FeeID"] = _list.InvestigationID;          //_list.GroupID;
                    _datarow["Description"] = _list.InvestigationName;  //_list.GroupName;
                }
                else
                {
                    _datarow["FeeType"] = "GRP";
                    _datarow["FeeID"] = _list.GroupID;
                    _datarow["Description"] = _list.GroupName;
                }
                _datarow["Comments"] = "";
                _datarow["FromDate"] = DateTime.Now;
                _datarow["ToDate"] = DateTime.Now;
                _datarow["Status"] = "Pending";
                _datarow["unit"] = 1;
                _datarow["Amount"] = 0;
                _datarow["DetailsID"] = 0;
                _datarow["PackageID"] = 0;
                _datarow["SpecialityID"] = 0;
                _datarow["UserID"] = 0;
                _datarow["DiscountAmount"] = 0;
                _datarow["IsReimbursable"] = "";
                _datarow["IsTaxable"] = "";
                _datarow["ServiceCode"] = "";
                _datarow["DiscountPercent"] = 0;
                _datarow["DiscOrEnhanceType"] = "";
                _datarow["Remarks"] = "";
                _datarow["ReimbursableAmount"] = 0;
                _datarow["NonReimbursableAmount"] = 0;
                _datarow["ActualAmount"] = 0;
                _datarow["RateID"] = 0;
                _datarow["IsDiscountable"] = "N";
                _datarow["IsSTAT"] = "N";
                _datarow["IsOutSource"] = "N";
                _datarow["IsNABL"] = "N";
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToPatientBillingDetails(List<Patient> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("VisitID", typeof(System.Int64));
            _datatable.Columns.Add("PatientID", typeof(System.Int64));
            _datatable.Columns.Add("PhysicianID", typeof(System.Int64));
            _datatable.Columns.Add("ConsultationDate", typeof(System.DateTime));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int32));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("Description", typeof(System.String));

            DataRow _datarow;

            foreach (Patient _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["VisitID"] = _list.PatientVisitID;
                _datarow["PatientID"] = _list.PatientID;
                _datarow["PhysicianID"] = 0;
                _datarow["ConsultationDate"] = System.DateTime.Now;
                _datarow["Status"] = _list.Status;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["Description"] = _list.Comments;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;

            //Test
        }
        public static System.Data.DataTable ConvertToGetOrgIDs(List<DayWiseCollectionReport> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("OrgID", typeof(System.Int32));

            DataRow _datarow;

            foreach (DayWiseCollectionReport _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["OrgID"] = _list.PhysicianID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTIdsforReport(List<DayWiseCollectionReport> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("IDs", typeof(System.Int32));

            DataRow _datarow;

            foreach (DayWiseCollectionReport _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["IDs"] = _list.PhysicianID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTMRDDischargeAnalysis(List<MRDDischargeAnalysis> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientID", typeof(System.Int64));
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("CaseSheetRcvdStatus", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));

            DataRow _datarow;

            foreach (MRDDischargeAnalysis _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientID"] = _list.PatientID;
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["CaseSheetRcvdStatus"] = _list.CaseSheetRcvdStatus;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToNonReimbursableItems(List<NonReimbursableItems> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("FeeType", typeof(System.String));
            _datatable.Columns.Add("FeeID", typeof(System.Int64));
            _datatable.Columns.Add("FeeDesc", typeof(System.String));
            _datatable.Columns.Add("FeeTypeDesc", typeof(System.String));
            _datatable.Columns.Add("TPAID", typeof(System.Int64));
            _datatable.Columns.Add("TPAType", typeof(System.String));
            _datatable.Columns.Add("IsActive", typeof(System.String));

            DataRow _datarow;

            foreach (NonReimbursableItems _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["FeeType"] = _list.FeeType;
                _datarow["FeeID"] = _list.FeeID;
                _datarow["FeeDesc"] = _list.FeeDesc;
                _datarow["FeeTypeDesc"] = _list.FeeTypeDesc;
                _datarow["TPAID"] = _list.ClientID;
                _datarow["TPAType"] = _list.TPAType;
                _datarow["IsActive"] = _list.IsActive;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToPendingICD(List<PatientComplaint> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ComplaintID", typeof(System.Int32));
            _datatable.Columns.Add("ComplaintName", typeof(System.String));
            _datatable.Columns.Add("ComplaintType", typeof(System.String));
            _datatable.Columns.Add("ICDCode", typeof(System.String));
            _datatable.Columns.Add("ICDDescription", typeof(System.String));
            _datatable.Columns.Add("ICDCodeStatus", typeof(System.String));

            DataRow _datarow;

            foreach (PatientComplaint _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ComplaintID"] = _list.ComplaintID;
                _datarow["ComplaintName"] = _list.ComplaintName;
                _datarow["ComplaintType"] = _list.ComplaintType;
                _datarow["ICDCode"] = _list.ICDCode;
                _datarow["ICDDescription"] = _list.ICDDescription;
                _datarow["ICDCodeStatus"] = _list.ICDCodeStatus;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToPendingICD(List<BackgroundProblem> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ComplaintID", typeof(System.Int32));
            _datatable.Columns.Add("ComplaintName", typeof(System.String));
            _datatable.Columns.Add("ComplaintType", typeof(System.String));
            _datatable.Columns.Add("ICDCode", typeof(System.String));
            _datatable.Columns.Add("ICDDescription", typeof(System.String));
            _datatable.Columns.Add("ICDCodeStatus", typeof(System.String));

            DataRow _datarow;

            foreach (BackgroundProblem _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ComplaintID"] = _list.ComplaintID;
                _datarow["ComplaintName"] = _list.ComplaintName;
                _datarow["ComplaintType"] = _list.Description;
                _datarow["ICDCode"] = _list.ICDCode;
                _datarow["ICDDescription"] = _list.ICDDescription;
                _datarow["ICDCodeStatus"] = _list.ICDCodeStatus;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToInvDeptMaster(List<InvDeptMaster> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("DeptID", typeof(System.Int32));
            _datatable.Columns.Add("DeptName", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("Display", typeof(System.String));
            _datatable.Columns.Add("SequenceNo", typeof(System.Int32));
            _datatable.Columns.Add("Code", typeof(System.String));

            DataRow _datarow;

            foreach (InvDeptMaster _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["DeptID"] = _list.DeptID;
                _datarow["DeptName"] = _list.DeptName;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["Display"] = _list.Display;
                _datarow["SequenceNo"] = _list.SequenceNo;
                _datarow["Code"] = _list.Code;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToOrderedInvestigation(OrderedInvestigations _list)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("Name", typeof(System.String));
            _datatable.Columns.Add("ID", typeof(System.Int64));
            _datatable.Columns.Add("VisitID", typeof(System.Int64));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("StudyInstanceUId", typeof(System.String));
            _datatable.Columns.Add("ComplaintId", typeof(System.Int32));
            _datatable.Columns.Add("ReferedToOrgID", typeof(System.Int32));
            _datatable.Columns.Add("ReferedToLocation", typeof(System.Int32));
            _datatable.Columns.Add("InvestigationsType", typeof(System.String));
            _datatable.Columns.Add("ReferralID", typeof(System.Int64));
            _datatable.Columns.Add("UID", typeof(System.String));
            _datatable.Columns.Add("ReferenceType", typeof(System.String));
            _datatable.Columns.Add("RefPhyName", typeof(System.String));
            _datatable.Columns.Add("RefPhysicianID", typeof(System.Int64));

            DataRow _datarow;


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
            _datatable.Rows.Add(_datarow);

            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTReAssignedTask(List<Tasks> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("TaskID", typeof(System.Int64));
            _datatable.Columns.Add("AssignedTo", typeof(System.Int64));
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));

            DataRow _datarow;

            foreach (Tasks _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["TaskID"] = _list.TaskID;
                _datarow["AssignedTo"] = _list.AssignedTo;
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToTrustedOrgActions(List<TrustedOrgActions> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("LoggedOrgID", typeof(System.Int32));
            _datatable.Columns.Add("SharingOrgID", typeof(System.Int32));
            _datatable.Columns.Add("IdentifyingType", typeof(System.String));
            _datatable.Columns.Add("IdentifyingActionID", typeof(System.Int64));
            _datatable.Columns.Add("RoleID", typeof(System.Int64));
            _datatable.Columns.Add("DummyString", typeof(System.String));

            DataRow _datarow;

            foreach (TrustedOrgActions _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["LoggedOrgID"] = _list.LoggedOrgID;
                _datarow["SharingOrgID"] = _list.SharingOrgID;
                _datarow["IdentifyingType"] = _list.IdentifyingType;
                _datarow["IdentifyingActionID"] = _list.IdentifyingActionID;
                _datarow["RoleID"] = _list.RoleID;
                _datarow["DummyString"] = _list.DummyString;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToTrustedOrgActions(TrustedOrgActions _list)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("LoggedOrgID", typeof(System.Int32));
            _datatable.Columns.Add("SharingOrgID", typeof(System.Int32));
            _datatable.Columns.Add("IdentifyingType", typeof(System.String));
            _datatable.Columns.Add("IdentifyingActionID", typeof(System.Int64));
            _datatable.Columns.Add("RoleID", typeof(System.Int64));
            _datatable.Columns.Add("DummyString", typeof(System.String));

            DataRow _datarow;


            _datarow = _datatable.NewRow();
            _datarow["LoggedOrgID"] = _list.LoggedOrgID;
            _datarow["SharingOrgID"] = _list.SharingOrgID;
            _datarow["IdentifyingType"] = _list.IdentifyingType;
            _datarow["IdentifyingActionID"] = _list.IdentifyingActionID;
            _datarow["RoleID"] = _list.RoleID;
            _datarow["DummyString"] = _list.DummyString;
            _datatable.Rows.Add(_datarow);

            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToLoginDetail(LoginDetail _list)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("LoginID", typeof(System.Int64));
            _datatable.Columns.Add("RoleID", typeof(System.Int64));
            _datatable.Columns.Add("Orgid", typeof(System.Int32));
            _datatable.Columns.Add("DummyString", typeof(System.String));

            DataRow _datarow;


            _datarow = _datatable.NewRow();
            _datarow["LoginID"] = _list.LoginID;
            _datarow["RoleID"] = _list.RoleID;
            _datarow["Orgid"] = _list.Orgid;
            _datarow["DummyString"] = _list.DummyString;
            _datatable.Rows.Add(_datarow);

            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTBanks(List<PaymentBanks> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("BankName", typeof(System.String));

            DataRow _datarow;

            foreach (PaymentBanks _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["BankName"] = _list.BankName;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTPatientDueChart(List<PatientDueChart> lstSurgergicalPkg, List<OrderedInvestigations> invs,
                                                     List<PatientDueChart> pPatientConsultation,
                                                     List<PatientDueChart> pPatientProcedure,
                                                     List<PatientDueChart> pPatientIndents,
                                                     List<DHEBAdder> pDHEBPatientIndents)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("FeeType", typeof(System.String));
            _datatable.Columns.Add("FeeID", typeof(System.Int64));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("Comments", typeof(System.String));
            _datatable.Columns.Add("FromDate", typeof(System.DateTime));
            _datatable.Columns.Add("ToDate", typeof(System.DateTime));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("unit", typeof(System.Decimal));
            _datatable.Columns.Add("Amount", typeof(System.Decimal));
            _datatable.Columns.Add("DetailsID", typeof(System.Int64));
            _datatable.Columns.Add("PackageID", typeof(System.Int64));
            _datatable.Columns.Add("FromTable", typeof(System.String));
            _datatable.Columns.Add("DiscountAmount", typeof(System.Decimal));
            _datatable.Columns.Add("IsReimbursable", typeof(System.String));
            _datatable.Columns.Add("IsTaxable", typeof(System.String));
            _datatable.Columns.Add("ServiceCode", typeof(System.String));
            _datatable.Columns.Add("DiscountPercent", typeof(System.Decimal));
            _datatable.Columns.Add("DiscOrEnhanceType", typeof(System.String));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            _datatable.Columns.Add("ReimbursableAmount", typeof(System.Decimal));
            _datatable.Columns.Add("NonReimbursableAmount", typeof(System.Decimal));
            _datatable.Columns.Add("ActualAmount", typeof(System.Decimal));
            _datatable.Columns.Add("RateID", typeof(System.Int64));
            _datatable.Columns.Add("IsDiscountable", typeof(System.String));
            _datatable.Columns.Add("IsSTAT", typeof(System.String));
            _datatable.Columns.Add("IsOutSource", typeof(System.String));
            _datatable.Columns.Add("IsNABL", typeof(System.String));

            DataRow _datarow;

            foreach (OrderedInvestigations inv in invs)
            {
                _datarow = _datatable.NewRow();
                _datarow["FeeType"] = inv.Type;
                _datarow["FeeID"] = inv.ID;
                _datarow["Description"] = inv.Name;
                _datarow["Comments"] = "";
                _datarow["FromDate"] = DateTime.Now;
                _datarow["ToDate"] = DateTime.Now;
                _datarow["Status"] = "Pending";
                _datarow["unit"] = 1;
                _datarow["Amount"] = 0;
                _datarow["DetailsID"] = 0;
                _datarow["PackageID"] = 0;
                _datarow["SpecialityID"] = 0;
                _datarow["UserID"] = 0;
                _datarow["DiscountAmount"] = 0;
                _datarow["IsReimbursable"] = "";
                _datarow["IsTaxable"] = "";
                _datarow["ServiceCode"] = "";
                _datarow["DiscountPercent"] = 0;
                _datarow["DiscOrEnhanceType"] = "";
                _datarow["Remarks"] = "";
                _datarow["ReimbursableAmount"] = 0;
                _datarow["NonReimbursableAmount"] = 0;
                _datarow["ActualAmount"] = 0;
                _datarow["RateID"] = 0;
                _datarow["IsDiscountable"] = "N";
                _datarow["IsSTAT"] = "N";
                _datarow["IsOutSource"] = "N";
                _datarow["IsNABL"] = "N";
                _datatable.Rows.Add(_datarow);
            }

            foreach (PatientDueChart pConsultation in pPatientConsultation)
            {
                _datarow = _datatable.NewRow();
                _datarow["FeeType"] = pConsultation.FeeType;
                _datarow["FeeID"] = pConsultation.FeeID;          //inv.GroupID;
                _datarow["Description"] = pConsultation.Description;  //inv.GroupName;
                _datarow["Comments"] = pConsultation.Comments;
                _datarow["FromDate"] = pConsultation.FromDate;
                _datarow["ToDate"] = pConsultation.ToDate;
                _datarow["Status"] = "Pending";
                _datarow["unit"] = pConsultation.Unit;
                _datarow["Amount"] = pConsultation.Amount;
                _datarow["DetailsID"] = 0;
                _datarow["PackageID"] = 0;
                _datarow["SpecialityID"] = 0;
                _datarow["UserID"] = 0;
                _datarow["DiscountAmount"] = 0;
                _datarow["IsReimbursable"] = pConsultation.IsReimbursable;
                _datarow["IsTaxable"] = "";
                _datarow["ServiceCode"] = "";
                _datarow["DiscountPercent"] = pConsultation.DiscountPercent;
                _datarow["DiscOrEnhanceType"] = pConsultation.DiscOrEnhanceType;
                _datarow["Remarks"] = pConsultation.Remarks;
                _datarow["ReimbursableAmount"] = pConsultation.ReimbursableAmount;
                _datarow["NonReimbursableAmount"] = pConsultation.NonReimbursableAmount;
                _datarow["ActualAmount"] = pConsultation.ActualAmount;
                _datarow["RateID"] = pConsultation.RateID;
                _datarow["IsDiscountable"] = pConsultation.IsDiscountable;
                _datarow["IsSTAT"] = pConsultation.IsSTAT;
                _datarow["IsOutSource"] = pConsultation.IsOutSource;
                _datarow["IsNABL"] = pConsultation.IsNABL;
                _datatable.Rows.Add(_datarow);
            }

            foreach (PatientDueChart pProcedure in pPatientProcedure)
            {
                _datarow = _datatable.NewRow();
                _datarow["FeeType"] = pProcedure.FeeType;
                _datarow["FeeID"] = pProcedure.FeeID;          //inv.GroupID;
                _datarow["Description"] = pProcedure.Description;  //inv.GroupName;
                _datarow["Comments"] = pProcedure.Comments;
                _datarow["FromDate"] = pProcedure.FromDate;
                _datarow["ToDate"] = pProcedure.ToDate;
                _datarow["Status"] = "Pending";
                _datarow["unit"] = pProcedure.Unit;
                _datarow["Amount"] = pProcedure.Amount;
                _datarow["DetailsID"] = 0;
                _datarow["PackageID"] = 0;
                _datarow["SpecialityID"] = 0;
                _datarow["UserID"] = 0;
                _datarow["DiscountAmount"] = 0;
                _datarow["IsReimbursable"] = pProcedure.IsReimbursable;
                _datarow["IsTaxable"] = "";
                _datarow["ServiceCode"] = "";
                _datarow["DiscountPercent"] = pProcedure.DiscountPercent;
                _datarow["DiscOrEnhanceType"] = pProcedure.DiscOrEnhanceType;
                _datarow["Remarks"] = pProcedure.Remarks;
                _datarow["ReimbursableAmount"] = pProcedure.ReimbursableAmount;
                _datarow["NonReimbursableAmount"] = pProcedure.NonReimbursableAmount;
                _datarow["ActualAmount"] = pProcedure.ActualAmount;
                _datarow["RateID"] = pProcedure.RateID;
                _datarow["IsDiscountable"] = pProcedure.IsDiscountable;
                _datarow["IsSTAT"] = pProcedure.IsSTAT;
                _datarow["IsOutSource"] = pProcedure.IsOutSource;
                _datarow["IsNABL"] = pProcedure.IsNABL;
                _datatable.Rows.Add(_datarow);
            }

            foreach (PatientDueChart _list in pPatientIndents)
            {
                _datarow = _datatable.NewRow();
                _datarow["FeeType"] = _list.FeeType;
                _datarow["FeeID"] = _list.FeeID;          //inv.GroupID;
                _datarow["Description"] = _list.Description;  //inv.GroupName;
                _datarow["Comments"] = _list.Comments;
                _datarow["FromDate"] = _list.FromDate;
                _datarow["ToDate"] = _list.ToDate;
                _datarow["Status"] = "Pending";
                _datarow["unit"] = _list.Unit;
                _datarow["Amount"] = 0;
                _datarow["DetailsID"] = 0;
                _datarow["PackageID"] = 0;
                _datarow["SpecialityID"] = 0;
                _datarow["UserID"] = 0;
                _datarow["DiscountAmount"] = 0;
                _datarow["IsReimbursable"] = _list.IsReimbursable;
                _datarow["IsTaxable"] = "";
                _datarow["ServiceCode"] = "";
                _datarow["DiscountPercent"] = _list.DiscountPercent;
                _datarow["DiscOrEnhanceType"] = _list.DiscOrEnhanceType;
                _datarow["Remarks"] = _list.Remarks;
                _datarow["ReimbursableAmount"] = _list.ReimbursableAmount;
                _datarow["NonReimbursableAmount"] = _list.NonReimbursableAmount;
                _datarow["ActualAmount"] = _list.ActualAmount;
                _datarow["RateID"] = _list.RateID;
                _datarow["IsDiscountable"] = _list.IsDiscountable;
                _datarow["IsSTAT"] = _list.IsSTAT;
                _datarow["IsOutSource"] = _list.IsOutSource;
                _datarow["IsNABL"] = _list.IsNABL;
                _datatable.Rows.Add(_datarow);
            }

            foreach (DHEBAdder _list in pDHEBPatientIndents)
            {
                _datarow = _datatable.NewRow();
                _list.Comments = _list.Comments == "" ? "0" : _list.Comments;
                _datarow["FeeType"] = "OTH";
                _datarow["FeeID"] = -1;          //inv.GroupID;
                _datarow["Description"] = _list.Description;  //inv.GroupName;
                _datarow["Comments"] = "";
                _datarow["FromDate"] = DateTime.Now;
                _datarow["ToDate"] = DateTime.Now;
                _datarow["Status"] = "Pending";
                _datarow["unit"] = 1;
                _datarow["Amount"] = Convert.ToDecimal(_list.Comments);
                _datarow["DetailsID"] = 0;
                _datarow["PackageID"] = 0;
                _datarow["SpecialityID"] = 0;
                _datarow["UserID"] = 0;
                _datarow["DiscountAmount"] = 0;
                _datarow["IsReimbursable"] = "";
                _datarow["IsTaxable"] = "";
                _datarow["ServiceCode"] = "";
                _datarow["DiscountPercent"] = 0;
                _datarow["DiscOrEnhanceType"] = "";
                _datarow["Remarks"] = "";
                _datarow["ReimbursableAmount"] = 0;
                _datarow["NonReimbursableAmount"] = 0;
                _datarow["ActualAmount"] = 0;
                _datarow["RateID"] = 0;
                _datarow["IsDiscountable"] = "N";
                _datarow["IsSTAT"] = "N";
                _datarow["IsOutSource"] = "N";
                _datarow["IsNABL"] = "N";
                _datatable.Rows.Add(_datarow);
            }

            foreach (PatientDueChart pSPI in lstSurgergicalPkg)
            {
                _datarow = _datatable.NewRow();
                _datarow["FeeType"] = pSPI.FeeType;
                _datarow["FeeID"] = pSPI.FeeID;          //inv.GroupID;
                _datarow["Description"] = pSPI.Description;  //inv.GroupName;
                _datarow["Comments"] = "";
                _datarow["FromDate"] = pSPI.FromDate;
                _datarow["ToDate"] = pSPI.ToDate;
                _datarow["Status"] = pSPI.Status;
                _datarow["unit"] = pSPI.Unit;
                _datarow["Amount"] = pSPI.Amount;
                _datarow["DetailsID"] = 0;
                _datarow["PackageID"] = pSPI.PackageID;
                _datarow["SpecialityID"] = 0;
                _datarow["UserID"] = 0;
                _datarow["DiscountAmount"] = 0;
                _datarow["IsReimbursable"] = pSPI.IsReimbursable;
                _datarow["IsTaxable"] = "";
                _datarow["ServiceCode"] = "";
                _datarow["DiscountPercent"] = pSPI.DiscountPercent;
                _datarow["DiscOrEnhanceType"] = pSPI.DiscOrEnhanceType;
                _datarow["Remarks"] = pSPI.Remarks;
                _datarow["ReimbursableAmount"] = pSPI.ReimbursableAmount;
                _datarow["NonReimbursableAmount"] = pSPI.NonReimbursableAmount;
                _datarow["ActualAmount"] = pSPI.ActualAmount;
                _datarow["RateID"] = pSPI.RateID;
                _datarow["IsDiscountable"] = pSPI.IsDiscountable;
                _datarow["IsSTAT"] = pSPI.IsSTAT;
                _datarow["IsOutSource"] = pSPI.IsOutSource;
                _datarow["IsNABL"] = pSPI.IsNABL;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTPatientDueChart(List<PatientDueChart> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("FeeType", typeof(System.String));
            _datatable.Columns.Add("FeeID", typeof(System.Int64));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("Comments", typeof(System.String));
            _datatable.Columns.Add("FromDate", typeof(System.DateTime));
            _datatable.Columns.Add("ToDate", typeof(System.DateTime));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("unit", typeof(System.Decimal));
            _datatable.Columns.Add("Amount", typeof(System.Decimal));
            _datatable.Columns.Add("DetailsID", typeof(System.Int64));
            _datatable.Columns.Add("PackageID", typeof(System.Int64));
            _datatable.Columns.Add("SpecialityID", typeof(System.Int32));
            _datatable.Columns.Add("UserID", typeof(System.Int64));
            _datatable.Columns.Add("DiscountAmount", typeof(System.Decimal));
            _datatable.Columns.Add("IsReimbursable", typeof(System.String));
            _datatable.Columns.Add("IsTaxable", typeof(System.String));
            _datatable.Columns.Add("ServiceCode", typeof(System.String));
            _datatable.Columns.Add("DiscountPercent", typeof(System.Decimal));
            _datatable.Columns.Add("DiscOrEnhanceType", typeof(System.String));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            _datatable.Columns.Add("ReimbursableAmount", typeof(System.Decimal));
            _datatable.Columns.Add("NonReimbursableAmount", typeof(System.Decimal));
            _datatable.Columns.Add("ActualAmount", typeof(System.Decimal));
            _datatable.Columns.Add("RateID", typeof(System.Int64));
            _datatable.Columns.Add("IsDiscountable", typeof(System.String));
            _datatable.Columns.Add("IsSTAT", typeof(System.String));
            _datatable.Columns.Add("IsOutSource", typeof(System.String));
            _datatable.Columns.Add("IsNABL", typeof(System.String));
             _datatable.Columns.Add("TatDate", typeof(System.DateTime));
            //_datatable.Columns.Add("ReportDate", typeof(System.DateTime));
            _datatable.Columns.Add("BaseRateID", typeof(System.Int64));
            _datatable.Columns.Add("DiscountPolicyID", typeof(System.Int64));
            _datatable.Columns.Add("DiscountCategoryCode", typeof(System.String));
            _datatable.Columns.Add("ReportDeliveryDate", typeof(System.DateTime));
            _datatable.Columns.Add("MaxTestDisPercentage", typeof(System.Decimal));
            _datatable.Columns.Add("MaxTestDisAmount", typeof(System.Decimal));
            _datatable.Columns.Add("BaseTestcalculationAmount", typeof(System.Decimal));
            _datatable.Columns.Add("IsRedeem", typeof(System.String));
            _datatable.Columns.Add("RedeemAmount", typeof(System.Decimal));
            _datatable.Columns.Add("RedeemPoints", typeof(System.Decimal));
            _datatable.Columns.Add("ClientFeeTypeRateCustID", typeof(System.Int64));
            _datatable.Columns.Add("DiscOrEnhanceRemarks", typeof(System.String));
            _datatable.Columns.Add("DiscOrEnhancePercent", typeof(System.Decimal));           
            _datatable.Columns.Add("ReferralID", typeof(System.Int32));
            _datatable.Columns.Add("ReferralType", typeof(System.String));
			_datatable.Columns.Add("ItemCurrencyId", typeof(System.Int64));
            _datatable.Columns.Add("Tatreferencedatetime", typeof(System.DateTime));
            _datatable.Columns.Add("Tatreferencedatebase", typeof(System.Int32));
            _datatable.Columns.Add("Tatsamplereceiptdatetime", typeof(System.DateTime));
            _datatable.Columns.Add("Tatprocessstartdatetime", typeof(System.DateTime));
            _datatable.Columns.Add("Logistictimeinmins", typeof(System.Int16));
            _datatable.Columns.Add("Processingtimeinmins", typeof(System.Int32));
            _datatable.Columns.Add("Labendtime", typeof(System.String));
            _datatable.Columns.Add("Earlyreporttime", typeof(System.String));
_datatable.Columns.Add("EligibleAmount", typeof(System.Decimal));
            _datatable.Columns.Add("CoSharing", typeof(System.Decimal));
            _datatable.Columns.Add("Performertype", typeof(System.String));
            _datatable.Columns.Add("CoPayValue", typeof(System.Decimal));
 

            DataRow _datarow;

            foreach (PatientDueChart _list in _lstCollection)
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
                _datarow["unit"] = _list.Unit;
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
                _datarow["IsOutSource"] = _list.IsOutSource;
                _datarow["IsNABL"] = _list.IsNABL;
                _datarow["TatDate"] = _list.TatDate;
                //_datarow["ReportDate"] = _list.TatDate;
                _datarow["BaseRateID"] = _list.BaseRateID;
                _datarow["DiscountPolicyID"] = _list.DiscountPolicyID;
                _datarow["DiscountCategoryCode"] = _list.DiscountCategoryCode;
                _datarow["ReportDeliveryDate"] = _list.ReportDeliveryDate;
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
               _datarow["EligibleAmount"] = _list.EligibleAmount;
                _datarow["CoSharing"] = _list.CoSharing;
                _datarow["Performertype"] = _list.Performertype;
                _datarow["CoPayValue"] = _list.CoPayValue;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }




        public static System.Data.DataTable ConvertToANCPatientComplication(List<PatientPastComplication> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ComplicationID", typeof(System.Int64));
            _datatable.Columns.Add("ComplicationName", typeof(System.String));
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("PatientID", typeof(System.Int64));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ANCStatus", typeof(System.String));

            DataRow _datarow;

            foreach (PatientPastComplication _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ComplicationID"] = _list.ComplicationID;
                _datarow["ComplicationName"] = _list.ComplicationName;
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["PatientID"] = _list.PatientID;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ANCStatus"] = _list.ANCStatus;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToANCVaccincation(List<PatientVaccinationHistory> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientID", typeof(System.Int64));
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("VaccinationID", typeof(System.Int32));
            _datatable.Columns.Add("VaccinationName", typeof(System.String));
            _datatable.Columns.Add("MonthOfVaccination", typeof(System.Int32));
            _datatable.Columns.Add("YearOfVaccination", typeof(System.Int32));
            _datatable.Columns.Add("VaccinationDose", typeof(System.String));
            _datatable.Columns.Add("IsBooster", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));

            DataRow _datarow;

            foreach (PatientVaccinationHistory _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientID"] = _list.PatientID;
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["VaccinationID"] = _list.VaccinationID;
                _datarow["VaccinationName"] = _list.VaccinationName;
                _datarow["MonthOfVaccination"] = _list.MonthOfVaccination;
                _datarow["YearOfVaccination"] = _list.YearOfVaccination;
                _datarow["VaccinationDose"] = _list.VaccinationDose;
                _datarow["IsBooster"] = _list.IsBooster;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }


        public static System.Data.DataTable ConvertToUDTRole(List<Role> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("RoleID", typeof(System.Int64));
            _datatable.Columns.Add("RoleName", typeof(System.String));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("OrgAddressID", typeof(System.Int64));
            _datatable.Columns.Add("DeptID", typeof(System.Int64));

            DataRow _datarow;

            foreach (Role _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["RoleID"] = _list.RoleID;
                _datarow["RoleName"] = _list.RoleName;
                _datarow["Description"] = _list.Description;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["OrgAddressID"] = _list.OrgAddressID;
                _datarow["DeptID"] = _list.ParentID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToInventoryItemsMapping(List<InventoryItemsBasket> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("CategoryID", typeof(System.Int32));
            _datatable.Columns.Add("ProductID", typeof(System.Int64));
            _datatable.Columns.Add("CategoryName", typeof(System.String));
            _datatable.Columns.Add("ProductName", typeof(System.String));
            _datatable.Columns.Add("Quantity", typeof(System.Decimal));
            _datatable.Columns.Add("ComplimentQTY", typeof(System.Decimal));
            _datatable.Columns.Add("Tax", typeof(System.Decimal));
            _datatable.Columns.Add("Discount", typeof(System.Decimal));
            _datatable.Columns.Add("Rate", typeof(System.Decimal));
            _datatable.Columns.Add("UOMID", typeof(System.Int32));
            _datatable.Columns.Add("Unit", typeof(System.String));
            _datatable.Columns.Add("UnitPrice", typeof(System.Decimal));
            _datatable.Columns.Add("LSUnit", typeof(System.String));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("ExpiryDate", typeof(System.DateTime));
            _datatable.Columns.Add("Manufacture", typeof(System.DateTime));
            _datatable.Columns.Add("BatchNo", typeof(System.String));
            _datatable.Columns.Add("Providedby", typeof(System.Int64));
            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("Amount", typeof(System.Decimal));
            _datatable.Columns.Add("ID", typeof(System.Int64));
            _datatable.Columns.Add("POQuantity", typeof(System.Decimal));
            _datatable.Columns.Add("POUnit", typeof(System.String));
            _datatable.Columns.Add("RECQuantity", typeof(System.Decimal));
            _datatable.Columns.Add("RECUnit", typeof(System.String));
            _datatable.Columns.Add("SellingUnit", typeof(System.String));
            _datatable.Columns.Add("InvoiceQty", typeof(System.Decimal));
            _datatable.Columns.Add("RcvdLSUQty", typeof(System.Decimal));
            _datatable.Columns.Add("AttributeDetail", typeof(System.String));
            _datatable.Columns.Add("HasExpiryDate", typeof(System.String));
            _datatable.Columns.Add("HasBatchNo", typeof(System.String));
            _datatable.Columns.Add("HasUsage", typeof(System.String));
            _datatable.Columns.Add("UsageCount", typeof(System.Int32));
            _datatable.Columns.Add("RakNo", typeof(System.String));
            _datatable.Columns.Add("MRP", typeof(System.Decimal));
            _datatable.Columns.Add("InHandQuantity", typeof(System.Decimal));
            _datatable.Columns.Add("ExciseTax", typeof(System.Decimal));
            _datatable.Columns.Add("DiscOrEnhancePercent", typeof(System.Decimal));
            _datatable.Columns.Add("DiscOrEnhanceType", typeof(System.String));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            _datatable.Columns.Add("ProductKey", typeof(System.String));
            _datatable.Columns.Add("UnitSellingPrice", typeof(System.Decimal));
            _datatable.Columns.Add("UnitCostPrice", typeof(System.Decimal));
            _datatable.Columns.Add("ReceivedOrgID", typeof(System.Int32));
            _datatable.Columns.Add("ParentProductID", typeof(System.Int64));
            _datatable.Columns.Add("ReceivedOrgAddID", typeof(System.Int32));
            _datatable.Columns.Add("ParentProductKey", typeof(System.String));
            _datatable.Columns.Add("PrescriptionNO", typeof(System.String));
            _datatable.Columns.Add("ActualPrice", typeof(System.Decimal));

            DataRow _datarow;

            foreach (InventoryItemsBasket _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["CategoryID"] = _list.CategoryID;
                _datarow["ProductID"] = _list.ProductID;
                _datarow["CategoryName"] = _list.CategoryName;
                _datarow["ProductName"] = _list.ProductName;
                _datarow["Quantity"] = _list.Quantity;
                _datarow["ComplimentQTY"] = _list.ComplimentQTY;
                _datarow["Tax"] = _list.Tax;
                _datarow["Discount"] = _list.Discount;
                _datarow["Rate"] = _list.Rate;
                _datarow["UOMID"] = _list.UOMID;
                _datarow["Unit"] = _list.Unit;
                _datarow["UnitPrice"] = _list.UnitPrice;
                _datarow["LSUnit"] = _list.LSUnit;
                _datarow["Description"] = _list.Description;
                _datarow["ExpiryDate"] = _list.ExpiryDate;
                _datarow["Manufacture"] = _list.Manufacture;
                _datarow["BatchNo"] = _list.BatchNo;
                _datarow["Providedby"] = _list.Providedby;
                _datarow["Type"] = _list.Type;
                _datarow["Amount"] = _list.Amount;
                _datarow["ID"] = _list.ID;
                _datarow["POQuantity"] = _list.POQuantity;
                _datarow["POUnit"] = _list.POUnit;
                _datarow["RECQuantity"] = _list.RECQuantity;
                _datarow["RECUnit"] = _list.RECUnit;
                _datarow["SellingUnit"] = _list.SellingUnit;
                _datarow["InvoiceQty"] = _list.InvoiceQty;
                _datarow["RcvdLSUQty"] = _list.RcvdLSUQty;
                _datarow["AttributeDetail"] = _list.AttributeDetail;
                _datarow["HasExpiryDate"] = _list.HasExpiryDate;
                _datarow["HasBatchNo"] = _list.HasBatchNo;
                _datarow["HasUsage"] = _list.HasUsage;
                _datarow["UsageCount"] = _list.UsageCount;
                _datarow["RakNo"] = _list.RakNo;
                _datarow["MRP"] = _list.MRP;
                _datarow["InHandQuantity"] = _list.InHandQuantity;
                _datarow["ExciseTax"] = _list.ExciseTax;
                _datarow["DiscOrEnhancePercent"] = _list.DiscOrEnhancePercent;
                _datarow["DiscOrEnhanceType"] = _list.DiscOrEnhanceType;
                _datarow["Remarks"] = _list.Remarks;
                _datarow["ProductKey"] = _list.ProductKey;
                _datarow["UnitSellingPrice"] = _list.UnitSellingPrice;
                _datarow["UnitCostPrice"] = _list.UnitCostPrice;
                _datarow["ReceivedOrgID"] = _list.ReceivedOrgID;
                _datarow["ParentProductID"] = _list.ParentProductID;
                _datarow["ReceivedOrgAddID"] = _list.ReceivedOrgAddID;
                _datarow["ParentProductKey"] = _list.ParentProductKey;
                _datarow["PrescriptionNO"] = _list.PrescriptionNO;
                _datarow["ActualPrice"] = _list.ActualAmount;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTIntegrationDetails(List<IntegrationHistory> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("Value", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("ExternalID", typeof(System.String));
            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("XMLType", typeof(System.String));

            DataRow _datarow;

            foreach (IntegrationHistory _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["Value"] = _list.IntegrationValue;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["ExternalID"] = _list.ExternalID;
                _datarow["Type"] = _list.Type;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["XMLType"] = _list.XMLType;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTInvestigationMaster(List<InvestigationMaster> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
            _datatable.Columns.Add("InvestigationName", typeof(System.String));
            _datatable.Columns.Add("UOMID", typeof(System.Int32));
            _datatable.Columns.Add("Display", typeof(System.String));
            _datatable.Columns.Add("TestCode", typeof(System.String));

            DataRow _datarow;

            foreach (InvestigationMaster _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datarow["InvestigationName"] = _list.InvestigationName;
                _datarow["UOMID"] = _list.UOMID;
                _datarow["Display"] = _list.Display;
                _datarow["TestCode"] = _list.TestCode;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToInvestigationResults(List<List<InvestigationValues>> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("Name", typeof(System.String));
            _datatable.Columns.Add("Value", typeof(System.String));
            _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
            _datatable.Columns.Add("GroupID", typeof(System.Int32));
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("UOMID", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("UOMCode", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("GroupName", typeof(System.String));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("PackageID", typeof(System.Int32));
            _datatable.Columns.Add("PackageName", typeof(System.String));
            _datatable.Columns.Add("SequenceNo", typeof(System.Int32));
            _datatable.Columns.Add("Dilution", typeof(System.String));
            _datatable.Columns.Add("RefferalID", typeof(System.Int64));
            _datatable.Columns.Add("DeviceID", typeof(System.String));
            _datatable.Columns.Add("DeviceValue", typeof(System.String));
            _datatable.Columns.Add("Precision", typeof(System.String));
            _datatable.Columns.Add("GUID", typeof(System.String));
            _datatable.Columns.Add("DeviceActualValue", typeof(System.String));
            _datatable.Columns.Add("ConvValue", typeof(System.String));
            _datatable.Columns.Add("ConvUOMCode", typeof(System.String));
            _datatable.Columns.Add("DeviceErrorCode", typeof(System.String));
            _datatable.Columns.Add("IsAbnormal", typeof(System.String));
            DataRow _datarow;
            foreach (List<InvestigationValues> _tlist in _lstCollection)
            {

                foreach (InvestigationValues _list in _tlist)
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
                    _datarow["GUID"] = _list.UID;
                    _datarow["DeviceActualValue"] = _list.DeviceActualValue;
                    _datarow["ConvValue"] = _list.ConvValue;
                    _datarow["ConvUOMCode"] = _list.ConvUOMCode;
                    _datarow["DeviceErrorCode"] = _list.DeviceErrorCode;
                    _datarow["IsAbnormal"] = _list.IsAbnormal;
                    _datatable.Rows.Add(_datarow);
                }
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTDeviceImportData(List<DeviceImportData> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("BarCode", typeof(System.String));
            _datatable.Columns.Add("TestCode", typeof(System.String));
            _datatable.Columns.Add("DeviceSampleDesc", typeof(System.String));
            _datatable.Columns.Add("PatientName", typeof(System.String));
            _datatable.Columns.Add("PatientNumber", typeof(System.String));
            _datatable.Columns.Add("ExternalVisitID", typeof(System.String));
            _datatable.Columns.Add("PatientAge", typeof(System.String));
            _datatable.Columns.Add("PatientSex", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));

            DataRow _datarow;

            foreach (DeviceImportData _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["BarCode"] = _list.BarCode;
                _datarow["TestCode"] = _list.TestCode;
                _datarow["DeviceSampleDesc"] = _list.DeviceSampleDesc;
                _datarow["PatientName"] = _list.PatientName;
                _datarow["PatientNumber"] = _list.PatientNumber;
                _datarow["ExternalVisitID"] = _list.ExternalVisitID;
                _datarow["PatientAge"] = _list.PatientAge;
                _datarow["PatientSex"] = _list.PatientSex;
                _datarow["OrgID"] = _list.OrgID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToInvestigationDetail(List<InvestigationDetail> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ID", typeof(System.String));
            _datatable.Columns.Add("Name", typeof(System.String));
            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("HistoryDetails", typeof(System.String));
            _datatable.Columns.Add("VisitID", typeof(System.Int64));
            _datatable.Columns.Add("TestSequenceOrder", typeof(System.Int32));

            DataRow _datarow;

            foreach (InvestigationDetail _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ID"] = _list.ID;
                _datarow["Name"] = _list.Name;
                _datarow["Type"] = _list.Type;
                _datarow["HistoryDetails"] = _list.HistoryDetails;
                _datarow["VisitID"] = _list.VisitID;
                _datarow["TestSequenceOrder"] = _list.TestSequenceOrder;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToFamilytree(List<Familytree> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ExternalName", typeof(System.String));
            _datatable.Columns.Add("ExternalPatientID", typeof(System.Int64));
            _datatable.Columns.Add("ExternalNoumber", typeof(System.String));
            _datatable.Columns.Add("DependentsName", typeof(System.String));
            _datatable.Columns.Add("DependentsPatientID", typeof(System.Int64));
            _datatable.Columns.Add("DependentsNoumber", typeof(System.String));
            _datatable.Columns.Add("DependentsType", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));

            DataRow _datarow;

            foreach (Familytree _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ExternalName"] = _list.ExternalName;
                _datarow["ExternalPatientID"] = _list.ExternalPatientID;
                _datarow["ExternalNoumber"] = _list.ExternalNoumber;
                _datarow["DependentsName"] = _list.DependentsName;
                _datarow["DependentsPatientID"] = _list.DependentsPatientID;
                _datarow["DependentsNoumber"] = _list.DependentsNoumber;
                _datarow["DependentsType"] = _list.DependentsType;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToInvClientMaster(List<InvClientMaster> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ClientID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int64));
            _datatable.Columns.Add("ClientName", typeof(System.String));
            _datatable.Columns.Add("ClientTypeID", typeof(System.Int32));
            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("ActiveYN", typeof(System.String));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("RateTypeId", typeof(System.Int32));
            _datatable.Columns.Add("RateId", typeof(System.Int32));
            _datatable.Columns.Add("ClientAttributes", typeof(System.String));
            _datatable.Columns.Add("IsAllMedical", typeof(System.String));
            _datatable.Columns.Add("ValidFrom", typeof(System.DateTime));
            _datatable.Columns.Add("ValidTo", typeof(System.DateTime));
            _datatable.Columns.Add("Interval", typeof(System.Int32));
            _datatable.Columns.Add("ClientMappingDetailsID", typeof(System.Int64));
            _datatable.Columns.Add("ValidFromTime", typeof(System.TimeSpan));
            _datatable.Columns.Add("ValidToTime", typeof(System.TimeSpan));
            _datatable.Columns.Add("TransferRate", typeof(System.String));
            _datatable.Columns.Add("BaseRate", typeof(System.String));
            DataRow _datarow;

            foreach (InvClientMaster _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ClientID"] = _list.ClientID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["ClientName"] = _list.ClientName;
                _datarow["ClientTypeID"] = _list.ClientTypeID;
                _datarow["Type"] = _list.Type;
                _datarow["ActiveYN"] = _list.ActiveYN;
                _datarow["Status"] = _list.Status;
                _datarow["RateTypeId"] = _list.RateTypeId;
                _datarow["RateId"] = _list.RateId;
                _datarow["ClientAttributes"] = _list.ClientAttributes;
                _datarow["IsAllMedical"] = _list.IsAllMedical;
                _datarow["ValidFrom"] = _list.ValidFrom;
                _datarow["ValidTo"] = _list.ValidTo;
                _datarow["Interval"] = _list.Interval;
                _datarow["ClientMappingDetailsID"] = _list.ClientMappingDetailsID;
                _datarow["ValidFromTime"] = _list.ValidFromTime;
                _datarow["ValidToTime"] = _list.ValidToTime;
                _datarow["TransferRate"] = _list.TransferRate;
                _datarow["BaseRate"] = _list.BaseRate;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToPrimaryConsultant(List<PrimaryConsultant> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PrimaryConsultantID", typeof(System.Int64));
            _datatable.Columns.Add("PhysicianName", typeof(System.String));

            DataRow _datarow;

            foreach (PrimaryConsultant _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PrimaryConsultantID"] = _list.PrimaryConsultantID;
                _datarow["PhysicianName"] = _list.PhysicianName;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToPhysicianOrgMappingUDT(List<PhysicianOrgMapping> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("MappingID", typeof(System.Int64));
            _datatable.Columns.Add("PhysicianID", typeof(System.Int64));
            _datatable.Columns.Add("HospitalID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));

            DataRow _datarow;

            foreach (PhysicianOrgMapping _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["MappingID"] = _list.MappingID;
                _datarow["PhysicianID"] = _list.PhysicianID;
                _datarow["HospitalID"] = _list.HospitalID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToVisitKnowledgeMapping(List<VisitKnowledgeMapping> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("VisitKnowledgeMappingID", typeof(System.Int64));
            _datatable.Columns.Add("KnowledgeOfServiceID", typeof(System.Int16));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("AttributeID", typeof(System.Int64));

            DataRow _datarow;

            foreach (VisitKnowledgeMapping _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["VisitKnowledgeMappingID"] = _list.VisitKnowledgeMappingID;
                _datarow["KnowledgeOfServiceID"] = _list.KnowledgeOfServiceID;
                _datarow["Description"] = _list.Description;
                _datarow["AttributeID"] = _list.AttributeID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToOrderedPhysiotherapy(List<OrderedPhysiotherapy> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ProcedureID", typeof(System.Int64));
            _datatable.Columns.Add("ProcedureName", typeof(System.String));
            _datatable.Columns.Add("OdreredQty", typeof(System.Decimal));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("PaymentStatus", typeof(System.String));
            _datatable.Columns.Add("PhysicianComments", typeof(System.String));

            DataRow _datarow;

            foreach (OrderedPhysiotherapy _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ProcedureID"] = _list.ProcedureID;
                _datarow["ProcedureName"] = _list.ProcedureName;
                _datarow["OdreredQty"] = _list.OdreredQty;
                _datarow["Status"] = _list.Status;
                _datarow["PaymentStatus"] = _list.PaymentStatus;
                _datarow["PhysicianComments"] = _list.PhysicianComments;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToPhysioCompliant(List<PhysioCompliant> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientPhysioDtlID", typeof(System.Int64));
            _datatable.Columns.Add("ComplaintID", typeof(System.Int64));
            _datatable.Columns.Add("ComplaintName", typeof(System.String));
            _datatable.Columns.Add("ICDCode", typeof(System.String));
            _datatable.Columns.Add("ICDDescription", typeof(System.String));
            _datatable.Columns.Add("ICDCodeStatus", typeof(System.String));

            DataRow _datarow;

            foreach (PhysioCompliant _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientPhysioDtlID"] = _list.PatientPhysioDtlID;
                _datarow["ComplaintID"] = _list.ComplaintID;
                _datarow["ComplaintName"] = _list.ComplaintName;
                _datarow["ICDCode"] = _list.ICDCode;
                _datarow["ICDDescription"] = _list.ICDDescription;
                _datarow["ICDCodeStatus"] = _list.ICDCodeStatus;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToPatientPhysioDetails(List<PatientPhysioDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("RowID", typeof(System.Int64));
            _datatable.Columns.Add("ProcedureID", typeof(System.Int64));
            _datatable.Columns.Add("ProcedureName", typeof(System.String));
            _datatable.Columns.Add("AdvisedNoOfSitting", typeof(System.Int32));
            _datatable.Columns.Add("CurrentNoOfSitting", typeof(System.Int32));
            _datatable.Columns.Add("DurationValue", typeof(System.Decimal));
            _datatable.Columns.Add("DurationUnits", typeof(System.String));
            _datatable.Columns.Add("ScoreCardValue", typeof(System.Decimal));
            _datatable.Columns.Add("ScoreCardUnit", typeof(System.String));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("HasPending", typeof(System.String));
            _datatable.Columns.Add("NextReview", typeof(System.String));
            _datatable.Columns.Add("PatientPhysioDtlID", typeof(System.Int64));
            _datatable.Columns.Add("PhysicianComments", typeof(System.String));
            _datatable.Columns.Add("Symptoms", typeof(System.String));
            _datatable.Columns.Add("VisitType", typeof(System.String));

            DataRow _datarow;

            foreach (PatientPhysioDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["RowID"] = _list.RowID;
                _datarow["ProcedureID"] = _list.ProcedureID;
                _datarow["ProcedureName"] = _list.ProcedureName;
                _datarow["AdvisedNoOfSitting"] = _list.AdvisedNoOfSitting;
                _datarow["CurrentNoOfSitting"] = _list.CurrentNoOfSitting;
                _datarow["DurationValue"] = _list.DurationValue;
                _datarow["DurationUnits"] = _list.DurationUnits;
                _datarow["ScoreCardValue"] = _list.ScoreCardValue;
                _datarow["ScoreCardUnit"] = _list.ScoreCardUnit;
                _datarow["Remarks"] = _list.Remarks;
                _datarow["Status"] = _list.Status;
                _datarow["HasPending"] = _list.HasPending;
                _datarow["NextReview"] = _list.NextReview;
                _datarow["PatientPhysioDtlID"] = _list.PatientPhysioDtlID;
                _datarow["PhysicianComments"] = _list.PhysicianComments;
                _datarow["Symptoms"] = _list.Symptoms;
                _datarow["VisitType"] = _list.VisitType;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToControlMappingDetails(List<ControlMappingDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ControlTypeID", typeof(System.Int32));
            _datatable.Columns.Add("ControlName", typeof(System.String));
            _datatable.Columns.Add("ControlCode", typeof(System.String));
            _datatable.Columns.Add("ControlMappingID", typeof(System.Int64));
            _datatable.Columns.Add("DisplayText", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("ReferenceID", typeof(System.Int64));
            _datatable.Columns.Add("ReferenceType", typeof(System.String));
            _datatable.Columns.Add("SequenceNo", typeof(System.Int32));
            _datatable.Columns.Add("ControlValueID", typeof(System.Int64));
            _datatable.Columns.Add("ControlValue", typeof(System.String));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("ID", typeof(System.Int64));

            DataRow _datarow;

            foreach (ControlMappingDetails _list in _lstCollection)
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
            //Test
        }


        public static System.Data.DataTable ConvertToUDTaxBillDetails(List<TaxBillDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("TaxID", typeof(System.Int32));
            _datatable.Columns.Add("TaxPercent", typeof(System.Decimal));
            _datatable.Columns.Add("TaxAmount", typeof(System.Decimal));

            DataRow _datarow;

            foreach (TaxBillDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["TaxID"] = _list.TaxID;
                _datarow["TaxPercent"] = _list.TaxPercent;
                _datarow["TaxAmount"] = _list.TaxAmount;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }


        public static System.Data.DataTable ConvertToPatientAmbulancedetails(List<PatientAmbulancedetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("AmbulancedetailsID", typeof(System.Int64));
            _datatable.Columns.Add("AmbulanceID", typeof(System.Int64));
            _datatable.Columns.Add("FinalBillID", typeof(System.Int64));
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("DriverID", typeof(System.Int64));
            _datatable.Columns.Add("LocationID", typeof(System.Int64));
            _datatable.Columns.Add("Createdby", typeof(System.Int64));
            _datatable.Columns.Add("Createdat", typeof(System.DateTime));
            _datatable.Columns.Add("Modifiedby", typeof(System.Int64));
            _datatable.Columns.Add("Modifiedat", typeof(System.DateTime));
            _datatable.Columns.Add("AmbulancearrivalFromdate", typeof(System.DateTime));
            _datatable.Columns.Add("AmbulancearrivalTodate", typeof(System.DateTime));
            _datatable.Columns.Add("Distancekgm", typeof(System.Int64));
            _datatable.Columns.Add("Duration", typeof(System.Int64));

            DataRow _datarow;

            foreach (PatientAmbulancedetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["AmbulancedetailsID"] = _list.AmbulancedetailsID;
                _datarow["AmbulanceID"] = _list.AmbulanceID;
                _datarow["FinalBillID"] = _list.FinalBillID;
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["DriverID"] = _list.DriverID;
                _datarow["LocationID"] = _list.LocationID;
                _datarow["Createdby"] = _list.Createdby;

                if (_list.Createdat != DateTime.MinValue)
                {
                    _datarow["Createdat"] = _list.Createdat;
                }
                else
                {
                    _datarow["Createdat"] = DateTime.Now;
                }

                if (_list.Modifiedat != DateTime.MinValue)
                {
                    _datarow["Modifiedat"] = _list.Modifiedat;
                }
                else
                {
                    _datarow["Modifiedat"] = DateTime.Now;
                }


                if (_list.AmbulancearrivalFromdate != DateTime.MinValue)
                {
                    _datarow["AmbulancearrivalFromdate"] = _list.AmbulancearrivalFromdate;
                }
                else
                {
                    _datarow["AmbulancearrivalFromdate"] = DateTime.Now;
                }

                if (_list.AmbulancearrivalTodate != DateTime.MinValue)
                {
                    _datarow["AmbulancearrivalTodate"] = _list.AmbulancearrivalTodate;
                }
                else
                {
                    _datarow["AmbulancearrivalTodate"] = DateTime.Now;
                }

                _datarow["Modifiedby"] = _list.Modifiedby;
                _datarow["Distancekgm"] = _list.Distancekgm;
                _datarow["Duration"] = _list.Duration;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToConfigValue(List<ConfigOrgMaster> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ConfigID", typeof(System.Int64));
            _datatable.Columns.Add("ConfigKeyID", typeof(System.Int64));
            _datatable.Columns.Add("ConfigValue", typeof(System.String));
            _datatable.Columns.Add("ConfigType", typeof(System.String));
            _datatable.Columns.Add("OrgAddressId", typeof(System.Int64));
            _datatable.Columns.Add("ConfigKey", typeof(System.String));

            DataRow _datarow;

            foreach (ConfigOrgMaster _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ConfigID"] = _list.ConfigID;
                _datarow["ConfigKeyID"] = _list.ConfigKeyID;
                _datarow["ConfigValue"] = _list.ConfigValue;
                _datarow["ConfigType"] = _list.ConfigType;
                _datarow["OrgAddressId"] = _list.OrgAddressId;
                _datarow["ConfigKey"] = _list.ConfigKey;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTPatientDueChart(List<SurgeryBillingMaster> _lstCollection, long SurgeryFeeId, decimal pTotalAmount)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("FeeType", typeof(System.String));
            _datatable.Columns.Add("FeeID", typeof(System.Int64));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("Comments", typeof(System.String));
            _datatable.Columns.Add("FromDate", typeof(System.DateTime));
            _datatable.Columns.Add("ToDate", typeof(System.DateTime));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("unit", typeof(System.Decimal));
            _datatable.Columns.Add("Amount", typeof(System.Decimal));
            _datatable.Columns.Add("DetailsID", typeof(System.Int64));
            _datatable.Columns.Add("PackageID", typeof(System.Int64));
            _datatable.Columns.Add("SpecialityID", typeof(System.Int32));
            _datatable.Columns.Add("UserID", typeof(System.Int64));
            _datatable.Columns.Add("DiscountAmount", typeof(System.Decimal));
            _datatable.Columns.Add("IsReimbursable", typeof(System.String));
            _datatable.Columns.Add("IsTaxable", typeof(System.String));
            _datatable.Columns.Add("ServiceCode", typeof(System.String));
            _datatable.Columns.Add("DiscountPercent", typeof(System.Decimal));
            _datatable.Columns.Add("DiscOrEnhanceType", typeof(System.String));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            _datatable.Columns.Add("ReimbursableAmount", typeof(System.Decimal));
            _datatable.Columns.Add("NonReimbursableAmount", typeof(System.Decimal));
            _datatable.Columns.Add("ActualAmount", typeof(System.Decimal));
            _datatable.Columns.Add("RateID", typeof(System.Int64));
            _datatable.Columns.Add("IsDiscountable", typeof(System.String));
            _datatable.Columns.Add("IsSTAT", typeof(System.String));
            _datatable.Columns.Add("IsOutSource", typeof(System.String));
            _datatable.Columns.Add("IsNABL", typeof(System.String));

            DataRow _datarow;
            if (SurgeryFeeId != -1)
            {

                foreach (SurgeryBillingMaster _list in _lstCollection)
                {
                    _datarow = _datatable.NewRow();

                    _datarow["FeeType"] = "SOI";
                    _datarow["FeeID"] = SurgeryFeeId; ;
                    _datarow["Description"] = _list.TreatmentName;
                    _datarow["Comments"] = "";
                    _datarow["FromDate"] = _list.CreatedAt;
                    _datarow["ToDate"] = _list.CreatedAt;
                    _datarow["Status"] = "Pending";
                    _datarow["unit"] = 1;
                    _datarow["Amount"] = pTotalAmount;
                    _datarow["DetailsID"] = 0;
                    _datarow["PackageID"] = 0;
                    _datarow["SpecialityID"] = 0;
                    _datarow["UserID"] = 0;
                    _datarow["DiscountAmount"] = 0;
                    _datarow["IsReimbursable"] = "";
                    _datarow["IsTaxable"] = "";
                    _datarow["ServiceCode"] = "";
                    _datarow["DiscountPercent"] = _list.DiscountPercent;
                    _datarow["DiscOrEnhanceType"] = _list.DiscOrEnhanceType;
                    _datarow["Remarks"] = _list.Remarks;
                    _datarow["ReimbursableAmount"] = 0;
                    _datarow["NonReimbursableAmount"] = 0;
                    _datarow["ActualAmount"] = 0;
                    _datarow["RateID"] = 0;
                    _datarow["IsDiscountable"] = "N";
                    _datarow["IsSTAT"] = "N";
                    _datarow["IsOutSource"] = "N";
                    _datarow["IsNABL"] = "N";

                    _datatable.Rows.Add(_datarow);
                }
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToSurgeryBillingMaster(List<SurgeryBillingMaster> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("SurgeryBillingID", typeof(System.Int64));
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("PatientID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("SurgeryID", typeof(System.Int64));
            _datatable.Columns.Add("TreatmentName", typeof(System.String));
            _datatable.Columns.Add("SurgicalFee", typeof(System.Decimal));
            _datatable.Columns.Add("ChiefSurgeonID", typeof(System.Int64));
            _datatable.Columns.Add("ChiefSurgeonName", typeof(System.String));
            _datatable.Columns.Add("ChiefSurgeonFee", typeof(System.Decimal));
            _datatable.Columns.Add("OTCharges", typeof(System.Decimal));
            _datatable.Columns.Add("RoomCharges", typeof(System.Decimal));
            _datatable.Columns.Add("Consumables", typeof(System.Decimal));
            _datatable.Columns.Add("ProsthesisFee", typeof(System.Decimal));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));

            DataRow _datarow;

            foreach (SurgeryBillingMaster _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["SurgeryBillingID"] = _list.SurgeryBillingID;
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["PatientID"] = _list.PatientID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["SurgeryID"] = _list.SurgeryID;
                _datarow["TreatmentName"] = _list.TreatmentName;
                _datarow["SurgicalFee"] = _list.SurgicalFee;
                _datarow["ChiefSurgeonID"] = _list.ChiefSurgeonID;
                _datarow["ChiefSurgeonName"] = _list.ChiefSurgeonName;
                _datarow["ChiefSurgeonFee"] = _list.ChiefSurgeonFee;
                _datarow["OTCharges"] = _list.OTCharges;
                _datarow["RoomCharges"] = _list.RoomCharges;
                _datarow["Consumables"] = _list.Consumables;
                _datarow["ProsthesisFee"] = _list.ProsthesisFee;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToSurgeryBillingDetails(List<SurgeryBillingDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("SurgeryBillingDetailsID", typeof(System.Int64));
            _datatable.Columns.Add("SurgeryBillingID", typeof(System.Int64));
            _datatable.Columns.Add("PhysicianID", typeof(System.Int64));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("Value", typeof(System.Decimal));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));

            DataRow _datarow;

            foreach (SurgeryBillingDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["SurgeryBillingDetailsID"] = _list.SurgeryBillingDetailsID;
                _datarow["SurgeryBillingID"] = _list.SurgeryBillingID;
                _datarow["PhysicianID"] = _list.PhysicianID;
                _datarow["Description"] = _list.Description;
                _datarow["Type"] = _list.Type;
                _datarow["Value"] = _list.Value;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToIPTreatmentPlanDetails(List<IPTreatmentPlanDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientID", typeof(System.Int64));
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("IPTreatmentPlanID", typeof(System.Int32));
            _datatable.Columns.Add("ScrubTeam", typeof(System.String));
            _datatable.Columns.Add("SurgeonID", typeof(System.Int64));
            _datatable.Columns.Add("AnesthesiastID", typeof(System.Int64));
            _datatable.Columns.Add("IsProvisional", typeof(System.String));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("IPTreatmentPlanName", typeof(System.String));
            _datatable.Columns.Add("Prosthesis", typeof(System.String));
            _datatable.Columns.Add("ParentID", typeof(System.Int32));
            _datatable.Columns.Add("ParentName", typeof(System.String));
            _datatable.Columns.Add("TreatmentPlanDate", typeof(System.DateTime));
            _datatable.Columns.Add("StagePlanned", typeof(System.String));
            _datatable.Columns.Add("SurgeonName", typeof(System.String));
            _datatable.Columns.Add("AnesthesiastName", typeof(System.String));
            _datatable.Columns.Add("SiteOfOperation", typeof(System.String));

            DataRow _datarow;

            foreach (IPTreatmentPlanDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientID"] = _list.PatientID;
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["IPTreatmentPlanID"] = _list.IPTreatmentPlanID;
                _datarow["ScrubTeam"] = _list.ScrubTeam;
                _datarow["SurgeonID"] = _list.SurgeonID;
                _datarow["AnesthesiastID"] = _list.AnesthesiastID;
                _datarow["IsProvisional"] = _list.IsProvisional;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["IPTreatmentPlanName"] = _list.IPTreatmentPlanName;
                _datarow["Prosthesis"] = _list.Prosthesis;
                _datarow["ParentID"] = _list.ParentID;
                _datarow["ParentName"] = _list.ParentName;
                _datarow["TreatmentPlanDate"] = _list.TreatmentPlanDate;
                _datarow["StagePlanned"] = _list.StagePlanned;
                _datarow["SurgeonName"] = _list.SurgeonName;
                _datarow["AnesthesiastName"] = _list.AnesthesiastName;
                _datarow["SiteOfOperation"] = _list.SiteOfOperation;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToPrescriptionType(List<PatientPrescription> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("DrugName", typeof(System.String));
            _datatable.Columns.Add("DrugFormulation", typeof(System.String));
            _datatable.Columns.Add("DrugFrequency", typeof(System.String));
            _datatable.Columns.Add("ROA", typeof(System.String));
            _datatable.Columns.Add("Dose", typeof(System.String));
            _datatable.Columns.Add("Duration", typeof(System.String));
            _datatable.Columns.Add("Instruction", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ComplaintID", typeof(System.Int32));
            _datatable.Columns.Add("DrugStatus", typeof(System.String));
            _datatable.Columns.Add("PrescriptionType", typeof(System.String));
            _datatable.Columns.Add("DrugSource", typeof(System.String));
            _datatable.Columns.Add("DrugID", typeof(System.Int64));
            _datatable.Columns.Add("PrescriptionNumber", typeof(System.String));
            _datatable.Columns.Add("PhysicianID", typeof(System.Int64));
            _datatable.Columns.Add("PrescribeDrugExpiryDate", typeof(System.DateTime));
            _datatable.Columns.Add("TaskID", typeof(System.Int64));
            _datatable.Columns.Add("PrescriptionID", typeof(System.Int64));
            _datatable.Columns.Add("Direction", typeof(System.String));
            _datatable.Columns.Add("Qty", typeof(System.Decimal));

            DataRow _datarow;

            foreach (PatientPrescription _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["DrugName"] = _list.BrandName;
                _datarow["DrugFormulation"] = _list.Formulation;
                _datarow["DrugFrequency"] = _list.DrugFrequency;
                _datarow["ROA"] = _list.ROA;
                _datarow["Dose"] = _list.Dose;
                _datarow["Duration"] = _list.Duration;
                _datarow["Instruction"] = _list.Instruction;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ComplaintID"] = _list.ComplaintId;
                _datarow["DrugStatus"] = _list.DrugStatus;
                _datarow["PrescriptionType"] = _list.PrescriptionType;
                _datarow["DrugSource"] = _list.DrugSource;
                _datarow["DrugID"] = _list.DrugID;
                _datarow["PrescriptionNumber"] = _list.PrescriptionNumber;
                _datarow["PhysicianID"] = _list.PhysicianID;
                _datarow["PrescribeDrugExpiryDate"] = _list.PrescriptionValidityDate;
                _datarow["TaskID"] = _list.TaskID;
                _datarow["PrescriptionID"] = _list.PrescriptionID;
                _datarow["Direction"] = _list.Direction;
                _datarow["Qty"] = _list.TotalQty;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToHIDECType(List<PatientComplication> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("HIDECID", typeof(System.Int32));
            _datatable.Columns.Add("Name", typeof(System.String));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ComplaintID", typeof(System.Int32));

            DataRow _datarow;

            foreach (PatientComplication _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["HIDECID"] = _list.ComplicationID;
                _datarow["Name"] = string.Empty;
                _datarow["Description"] = string.Empty;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ComplaintID"] = _list.ComplaintID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToPatientVitalsType(List<DialysisOnFlowDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("VitalsID", typeof(System.Int32));
            _datatable.Columns.Add("VitalsValue", typeof(System.String));
            _datatable.Columns.Add("SessionType", typeof(System.Byte));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));

            DataRow _datarow;

            foreach (DialysisOnFlowDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["VitalsID"] = _list.VitalsID;
                _datarow["VitalsValue"] = _list.VitalsValue;
                _datarow["SessionType"] = "";
                _datarow["CreatedBy"] = -1;
                _datarow["ModifiedBy"] = -1;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUPDTPatientPrescription(List<PatientPrescription> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PrescriptionID", typeof(System.Int64));
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("DrugName", typeof(System.String));
            _datatable.Columns.Add("DrugFormulation", typeof(System.String));
            _datatable.Columns.Add("DrugFrequency", typeof(System.String));
            _datatable.Columns.Add("ROA", typeof(System.String));
            _datatable.Columns.Add("Dose", typeof(System.String));
            _datatable.Columns.Add("Duration", typeof(System.String));
            _datatable.Columns.Add("Instruction", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ComplaintID", typeof(System.Int32));
            _datatable.Columns.Add("DrugStatus", typeof(System.String));
            _datatable.Columns.Add("Direction", typeof(System.String));

            DataRow _datarow;

            foreach (PatientPrescription _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PrescriptionID"] = _list.PrescriptionID;
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["DrugName"] = _list.BrandName;
                _datarow["DrugFormulation"] = "";
                _datarow["DrugFrequency"] = _list.DrugFrequency;
                _datarow["ROA"] = _list.ROA;
                _datarow["Dose"] = _list.Dose;
                _datarow["Duration"] = _list.Duration;
                _datarow["Instruction"] = _list.Instruction;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ComplaintID"] = _list.ComplaintId;
                _datarow["DrugStatus"] = _list.DrugStatus;
                _datarow["Direction"] = _list.Direction;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTPharmacyBillingDetails(List<BillingDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("BillingDetailsID", typeof(System.Int64));
            _datatable.Columns.Add("FromTable", typeof(System.String));

            DataRow _datarow;

            foreach (BillingDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["BillingDetailsID"] = _list.BillingDetailsID;
                _datarow["FromTable"] = _list.FromTable;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTPharmacyDueChart(List<PatientDueChart> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("DetailsID", typeof(System.Int64));
            _datatable.Columns.Add("FromTable", typeof(System.String));

            DataRow _datarow;

            foreach (PatientDueChart _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["DetailsID"] = _list.DetailsID;
                _datarow["FromTable"] = _list.FromTable;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }



        public static System.Data.DataTable ConvertToUDTPharmacyDueReference(List<DueClearance> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("FeeType", typeof(System.String));
            _datatable.Columns.Add("FeeID", typeof(System.Int64));
            _datatable.Columns.Add("ItemName", typeof(System.String));
            _datatable.Columns.Add("Quantity", typeof(System.Decimal));
            _datatable.Columns.Add("Amount", typeof(System.Decimal));

            DataRow _datarow;

            foreach (DueClearance _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["FeeType"] = _list.FeeType;
                _datarow["FeeID"] = _list.FeeID;
                _datarow["ItemName"] = _list.ItemName;
                _datarow["Quantity"] = _list.Quantity;
                _datarow["Amount"] = _list.Amount;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToQuotationMaster(List<QuotationMaster> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("QuotationID", typeof(System.Int64));
            _datatable.Columns.Add("QuotationNo", typeof(System.String));
            _datatable.Columns.Add("ValidFrom", typeof(System.DateTime));
            _datatable.Columns.Add("ValidTo", typeof(System.DateTime));
            _datatable.Columns.Add("Comments", typeof(System.String));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("SupplierID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int64));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("IsActive", typeof(System.String));

            DataRow _datarow;

            foreach (QuotationMaster _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["QuotationID"] = _list.QuotationID;
                _datarow["QuotationNo"] = _list.QuotationNo;
                _datarow["ValidFrom"] = _list.ValidFrom;
                _datarow["ValidTo"] = _list.ValidTo;
                _datarow["Comments"] = _list.Comments;
                _datarow["Status"] = _list.Status;
                _datarow["SupplierID"] = _list.SupplierID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["IsActive"] = _list.IsActive;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToRaisePO(List<InventoryItemsBasket> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ProductID", typeof(System.Int64));
            _datatable.Columns.Add("SupplierID", typeof(System.Int32));
            _datatable.Columns.Add("Quantity", typeof(System.Decimal));
            _datatable.Columns.Add("Rate", typeof(System.Decimal));
            _datatable.Columns.Add("UOMID", typeof(System.Int32));
            _datatable.Columns.Add("Unit", typeof(System.String));

            DataRow _datarow;

            foreach (InventoryItemsBasket _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ProductID"] = _list.ProductID;
                _datarow["SupplierID"] = _list.ID;
                _datarow["Quantity"] = _list.Quantity;
                _datarow["Rate"] = _list.Rate;
                _datarow["UOMID"] = _list.UOMID;
                _datarow["Unit"] = _list.Unit;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToUDTAmtRefundDetails(List<AmountRefundDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("FinalBillID", typeof(System.Int64));
            _datatable.Columns.Add("BillingDetailsID", typeof(System.Int64));
            _datatable.Columns.Add("AmtRefund", typeof(System.Decimal));
            _datatable.Columns.Add("RefundBy", typeof(System.Int64));
            _datatable.Columns.Add("RefundStatus", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ReasonforRefund", typeof(System.String));
            _datatable.Columns.Add("Quantity", typeof(System.Decimal));
            _datatable.Columns.Add("RefundType", typeof(System.String));
            _datatable.Columns.Add("ApprovedBy", typeof(System.Int64));
            _datatable.Columns.Add("TranCurrencyID", typeof(System.Int32));
            _datatable.Columns.Add("BaseCurrencyID", typeof(System.Int32));
            _datatable.Columns.Add("TranCurrencyAmount", typeof(System.Decimal));
            _datatable.Columns.Add("PaymentTypeID", typeof(System.Int32));
            _datatable.Columns.Add("PaymentDetail", typeof(System.String));
            _datatable.Columns.Add("ChequeNo", typeof(System.Int64));
            _datatable.Columns.Add("BankName", typeof(System.String));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            _datatable.Columns.Add("AuthorisedBy", typeof(System.Int32));
            _datatable.Columns.Add("ServiceType", typeof(System.String));
            _datatable.Columns.Add("Comments", typeof(System.String));
            _datatable.Columns.Add("CancelAmount", typeof(System.Decimal));

            DataRow _datarow;

            foreach (AmountRefundDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["FinalBillID"] = _list.FinalBillID;
                _datarow["BillingDetailsID"] = _list.BillingDetailsID;
                _datarow["AmtRefund"] = _list.AmtRefund;
                _datarow["RefundBy"] = _list.RefundBy;
                _datarow["RefundStatus"] = _list.RefundStatus;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ReasonforRefund"] = _list.ReasonforRefund;
                _datarow["Quantity"] = _list.Quantity;
                _datarow["RefundType"] = _list.RefundType;
                _datarow["ApprovedBy"] = _list.ApprovedBy;
                _datarow["TranCurrencyID"] = _list.TranCurrencyID;
                _datarow["BaseCurrencyID"] = _list.BaseCurrencyID;
                _datarow["TranCurrencyAmount"] = _list.TranCurrencyAmount;
                _datarow["PaymentTypeID"] = _list.PaymentTypeID;
                _datarow["PaymentDetail"] = _list.PaymentDetail;
                _datarow["ChequeNo"] = _list.ChequeNo;
                _datarow["BankName"] = _list.BankName;
                _datarow["Remarks"] = _list.Remarks;
                _datarow["AuthorisedBy"] = _list.AuthorisedBy;
                _datarow["ServiceType"] = _list.ServiceType;
                _datarow["Comments"] = _list.Comments;
                _datarow["CancelAmount"] = _list.CancelAmount;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToPOMappingLocation(List<PurchaseOrderMappingLocation> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("supplierid", typeof(System.Int64));
            _datatable.Columns.Add("POID", typeof(System.Int64));
            _datatable.Columns.Add("PODetailsID", typeof(System.Int64));
            _datatable.Columns.Add("Productid", typeof(System.Int64));
            _datatable.Columns.Add("Quantity", typeof(System.Decimal));
            _datatable.Columns.Add("Units", typeof(System.String));
            _datatable.Columns.Add("LocationID", typeof(System.Int64));
            _datatable.Columns.Add("DeliveryDate", typeof(System.DateTime));
            _datatable.Columns.Add("ToLocationID", typeof(System.Int32));
            _datatable.Columns.Add("TrustedOrgID", typeof(System.Int32));
            _datatable.Columns.Add("CompQty", typeof(System.Decimal));
            _datatable.Columns.Add("Discount", typeof(System.Decimal));
            _datatable.Columns.Add("Vat", typeof(System.Decimal));
            _datatable.Columns.Add("Amount", typeof(System.Decimal));
            _datatable.Columns.Add("POMappingID", typeof(System.Int64));
            _datatable.Columns.Add("Rate", typeof(System.Decimal));

            DataRow _datarow;

            foreach (PurchaseOrderMappingLocation _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["supplierid"] = _list.SupplierId;
                _datarow["POID"] = _list.POID;
                _datarow["PODetailsID"] = _list.PODetailsID;
                _datarow["Productid"] = _list.ProductID;
                _datarow["Quantity"] = _list.Quantity;
                _datarow["Units"] = _list.Units;
                _datarow["LocationID"] = _list.LocationId;
                _datarow["DeliveryDate"] = _list.DeliveryDate;
                _datarow["ToLocationID"] = _list.ToLocationID;
                _datarow["TrustedOrgID"] = _list.TrustedOrgID;
                _datarow["CompQty"] = _list.CompQty;
                _datarow["Discount"] = _list.Discount;
                _datarow["Vat"] = _list.Vat;
                _datarow["Amount"] = _list.Amount;
                _datarow["POMappingID"] = _list.POMappingID;
                _datarow["Rate"] = _list.Rate;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTKitStudyDetails(List<KitStudyDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("KitID", typeof(System.String));
            _datatable.Columns.Add("KitBacthNo", typeof(System.String));
            _datatable.Columns.Add("StudyID", typeof(System.Int64));
            _datatable.Columns.Add("SiteID", typeof(System.Int64));
            _datatable.Columns.Add("EpisodeVisitId", typeof(System.Int64));
            _datatable.Columns.Add("IndentID", typeof(System.Int64));
            _datatable.Columns.Add("ActualRaiseQty", typeof(System.Int32));
            _datatable.Columns.Add("RaisedQty", typeof(System.Int32));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("OrgAddID", typeof(System.Int32));
            _datatable.Columns.Add("LocationID", typeof(System.Int32));
            _datatable.Columns.Add("ToLocationID", typeof(System.Int32));
            _datatable.Columns.Add("Status", typeof(System.String));

            DataRow _datarow;

            foreach (KitStudyDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["KitID"] = _list.KitID;
                _datarow["KitBacthNo"] = _list.KitBacthNo;
                _datarow["StudyID"] = _list.StudyID;
                _datarow["SiteID"] = _list.SiteID;
                _datarow["EpisodeVisitId"] = _list.EpisodeVisitId;
                _datarow["IndentID"] = _list.IndentID;
                _datarow["ActualRaiseQty"] = _list.ActualRaiseQty;
                _datarow["RaisedQty"] = _list.RaisedQty;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["OrgAddID"] = _list.OrgAddID;
                _datarow["LocationID"] = _list.LocationID;
                _datarow["ToLocationID"] = _list.ToLocationID;
                _datarow["Status"] = _list.Status;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTStockReturnAmount(List<InventoryItemsBasket> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("StockReturnId", typeof(System.Int64));
            _datatable.Columns.Add("SupplierId", typeof(System.Int32));
            _datatable.Columns.Add("ReferenceNo", typeof(System.String));
            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("Amount", typeof(System.Decimal));
            _datatable.Columns.Add("BatchNo", typeof(System.String));

            DataRow _datarow;

            foreach (InventoryItemsBasket _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["StockReturnId"] = _list.ID;
                _datarow["SupplierId"] = _list.SupplierId;
                _datarow["ReferenceNo"] = _list.ReferenceNo;
                _datarow["Type"] = _list.Type;
                _datarow["Amount"] = _list.Amount;
                _datarow["BatchNo"] = _list.BatchNo;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }


        public static System.Data.DataTable ConvertToInvestigationDeleteOrgMapping(List<InvestigationOrgMapping> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
            _datatable.Columns.Add("InvestigationName", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("DeptID", typeof(System.Int32));
            _datatable.Columns.Add("HeaderID", typeof(System.Int64));
            _datatable.Columns.Add("Display", typeof(System.String));
            _datatable.Columns.Add("DisplayText", typeof(System.String));
            _datatable.Columns.Add("ReferenceRange", typeof(System.String));
            _datatable.Columns.Add("SequenceNo", typeof(System.Int32));
            _datatable.Columns.Add("SampleCode", typeof(System.Int32));
            _datatable.Columns.Add("MethodID", typeof(System.Int64));
            _datatable.Columns.Add("PrincipleID", typeof(System.Int64));
            _datatable.Columns.Add("KitID", typeof(System.Int64));
            _datatable.Columns.Add("InstrumentID", typeof(System.Int64));
            _datatable.Columns.Add("QCData", typeof(System.String));
            _datatable.Columns.Add("Interpretation", typeof(System.String));
            _datatable.Columns.Add("SampleContainerID", typeof(System.Int32));
            _datatable.Columns.Add("UOMID", typeof(System.Int32));
            _datatable.Columns.Add("UOMCode", typeof(System.String));

            DataRow _datarow;

            foreach (InvestigationOrgMapping _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datarow["InvestigationName"] = _list.InvestigationName;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["DeptID"] = _list.DeptID;
                _datarow["HeaderID"] = _list.HeaderID;
                _datarow["Display"] = _list.Display;
                _datarow["DisplayText"] = _list.DisplayText;
                _datarow["ReferenceRange"] = _list.ReferenceRange;
                _datarow["SequenceNo"] = _list.SequenceNo;
                _datarow["SampleCode"] = _list.SampleCode;
                _datarow["MethodID"] = _list.MethodID;
                _datarow["PrincipleID"] = _list.PrincipleID;
                _datarow["KitID"] = _list.KitID;
                _datarow["InstrumentID"] = _list.InstrumentID;
                _datarow["QCData"] = _list.QCData;
                _datarow["Interpretation"] = _list.Interpretation;
                _datarow["SampleContainerID"] = _list.SampleContainerID;
                _datarow["UOMID"] = _list.UOMID;
                _datarow["UOMCode"] = _list.UOMCode;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTInvQualitativeResultMaster(List<InvestigationBulkData> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ResultID", typeof(System.Int64));
            _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
            _datatable.Columns.Add("Name", typeof(System.String));
            _datatable.Columns.Add("Value", typeof(System.String));
            _datatable.Columns.Add("InvestigationMethodID", typeof(System.Int64));

            DataRow _datarow;

            foreach (InvestigationBulkData _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ResultID"] = _list.ResultID;
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datarow["Name"] = _list.Name;
                _datarow["Value"] = _list.Value;
                _datarow["InvestigationMethodID"] = _list.InvestigationMethodID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToPatientInvSampleMapping(List<PatientInvSampleMapping> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("VisitID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("SampleID", typeof(System.Int32));
            _datatable.Columns.Add("ID", typeof(System.Int64));
            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("Barcode", typeof(System.String));
            _datatable.Columns.Add("UniqueID", typeof(System.String));
            _datatable.Columns.Add("ExternalBarcode", typeof(System.String));

            DataRow _datarow;

            foreach (PatientInvSampleMapping _list in _lstCollection)
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
                _datarow["ExternalBarcode"] = _list.ExternalBarcode;
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToPatientInvestigationFiles(List<PatientInvestigationFiles> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
            _datatable.Columns.Add("FilePath", typeof(System.String));
            _datatable.Columns.Add("ImageSource", typeof(System.Byte[]));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("ImageID", typeof(System.Int64));
            _datatable.Columns.Add("Description", typeof(System.String));

            DataRow _datarow;

            foreach (PatientInvestigationFiles _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datarow["FilePath"] = _list.FilePath;
                _datarow["ImageSource"] = _list.ImageSource;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["ImageID"] = _list.ImageID;
                _datarow["Description"] = _list.Description;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToInvestigationResults(List<InvestigationValues> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("Name", typeof(System.String));
            _datatable.Columns.Add("Value", typeof(System.String));
            _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
            _datatable.Columns.Add("GroupID", typeof(System.Int32));
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("UOMID", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("UOMCode", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("GroupName", typeof(System.String));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("PackageID", typeof(System.Int32));
            _datatable.Columns.Add("PackageName", typeof(System.String));
            _datatable.Columns.Add("SequenceNo", typeof(System.Int32));
            _datatable.Columns.Add("Dilution", typeof(System.String));
            _datatable.Columns.Add("RefferalID", typeof(System.Int64));
            _datatable.Columns.Add("DeviceID", typeof(System.String));
            _datatable.Columns.Add("DeviceValue", typeof(System.String));
            _datatable.Columns.Add("Precision", typeof(System.String));
            _datatable.Columns.Add("GUID", typeof(System.String));
            _datatable.Columns.Add("DeviceActualValue", typeof(System.String));
            _datatable.Columns.Add("ConvValue", typeof(System.String));
            _datatable.Columns.Add("ConvUOMCode", typeof(System.String));
            _datatable.Columns.Add("DeviceErrorCode", typeof(System.String));
            _datatable.Columns.Add("IsAbnormal", typeof(System.String));
            DataRow _datarow;


            foreach (InvestigationValues _list in _lstCollection)
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
            //Test
        }
        public static System.Data.DataTable ConvertToUDTinvSampleResults(List<PatientInvSampleResults> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("VisitID", typeof(System.Int64));
            _datatable.Columns.Add("SampleCode", typeof(System.Int32));
            _datatable.Columns.Add("AttributesID", typeof(System.Int32));
            _datatable.Columns.Add("SampleValues", typeof(System.String));
            _datatable.Columns.Add("SampleDesc", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int32));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));

            DataRow _datarow;

            foreach (PatientInvSampleResults _list in _lstCollection)
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
            //Test
        }
        public static System.Data.DataTable ConvertToUDTInvReportTemplateMaster(List<InvReportMaster> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("TemplateID", typeof(System.Int32));
            _datatable.Columns.Add("ReportTemplateName", typeof(System.String));
            _datatable.Columns.Add("IsDefault", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("IsActive", typeof(System.String));

            DataRow _datarow;

            foreach (InvReportMaster _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["TemplateID"] = _list.TemplateID;
                _datarow["ReportTemplateName"] = _list.ReportTemplateName;
                _datarow["IsDefault"] = _list.IsDefault;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["IsActive"] = _list.IsActive;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToIPPatInvestigation(List<PatientInvestigation> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("InvestigationName", typeof(System.String));
            _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
            _datatable.Columns.Add("GroupID", typeof(System.Int32));
            _datatable.Columns.Add("GroupName", typeof(System.String));
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CollectedDateTime", typeof(System.DateTime));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("ComplaintID", typeof(System.Int32));
            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("IPInvSampleCollectionMasterID", typeof(System.Int64));

            DataRow _datarow;

            foreach (PatientInvestigation _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["InvestigationName"] = _list.InvestigationName;
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datarow["GroupID"] = _list.UID;
                _datarow["GroupName"] = _list.GroupName;
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CollectedDateTime"] = _list.CollectedDateTime;
                _datarow["Status"] = _list.Status;
                _datarow["ComplaintID"] = _list.ComplaintId;
                _datarow["Type"] = _list.Type;
                _datarow["IPInvSampleCollectionMasterID"] = _list.IPInvSampleCollectionMasterID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToIPInvSamples(List<PatientInvSample> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("BarcodeNumber", typeof(System.String));
            _datatable.Columns.Add("SampleCode", typeof(System.Int32));
            _datatable.Columns.Add("SampleDesc", typeof(System.String));
            _datatable.Columns.Add("IPInvSampleCollectionMasterID", typeof(System.Int64));

            DataRow _datarow;

            foreach (PatientInvSample _list in _lstCollection)
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
            //Test
        }
        public static System.Data.DataTable ConvertToPatientRecommendationDetails(List<PatientRecommendationDtls> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PRecoDtlsID", typeof(System.Int64));
            _datatable.Columns.Add("RecoID", typeof(System.Int64));
            _datatable.Columns.Add("ResultID", typeof(System.Int32));
            _datatable.Columns.Add("ResultValues", typeof(System.String));
            _datatable.Columns.Add("SequenceNo", typeof(System.Int32));

            DataRow _datarow;

            foreach (PatientRecommendationDtls _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PRecoDtlsID"] = _list.PRecoDtlsID;
                _datarow["RecoID"] = _list.RecoID;
                _datarow["ResultID"] = _list.ResultID;
                _datarow["ResultValues"] = _list.ResultValues;
                _datarow["SequenceNo"] = _list.SequenceNO;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToInvProductMapping(List<InventoryProductMapping> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("InvestigationId", typeof(System.Int64));
            _datatable.Columns.Add("ProductId", typeof(System.Int64));
            _datatable.Columns.Add("EstimateQty", typeof(System.Decimal));
            _datatable.Columns.Add("Eunits", typeof(System.String));
            _datatable.Columns.Add("BufferQty", typeof(System.Decimal));
            _datatable.Columns.Add("Bunits", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));

            DataRow _datarow;

            foreach (InventoryProductMapping _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["InvestigationId"] = _list.InvestigationId;
                _datarow["ProductId"] = _list.ProductId;
                _datarow["EstimateQty"] = _list.EstimateQty;
                _datarow["Eunits"] = _list.Eunits;
                _datarow["BufferQty"] = _list.BufferQty;
                _datarow["Bunits"] = _list.Bunits;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["OrgID"] = _list.OrgId;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTPatientDueChart(List<OrderedInvestigations> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("FeeType", typeof(System.String));
            _datatable.Columns.Add("FeeID", typeof(System.Int64));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("Comments", typeof(System.String));
            _datatable.Columns.Add("FromDate", typeof(System.DateTime));
            _datatable.Columns.Add("ToDate", typeof(System.DateTime));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("unit", typeof(System.Decimal));
            _datatable.Columns.Add("Amount", typeof(System.Decimal));
            _datatable.Columns.Add("DetailsID", typeof(System.Int64));
            _datatable.Columns.Add("PackageID", typeof(System.Int64));
            _datatable.Columns.Add("SpecialityID", typeof(System.Int32));
            _datatable.Columns.Add("UserID", typeof(System.Int64));
            _datatable.Columns.Add("DiscountAmount", typeof(System.Decimal));
            _datatable.Columns.Add("IsReimbursable", typeof(System.String));
            _datatable.Columns.Add("IsTaxable", typeof(System.String));
            _datatable.Columns.Add("ServiceCode", typeof(System.String));
            _datatable.Columns.Add("DiscountPercent", typeof(System.Decimal));
            _datatable.Columns.Add("DiscOrEnhanceType", typeof(System.String));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            _datatable.Columns.Add("ReimbursableAmount", typeof(System.Decimal));
            _datatable.Columns.Add("NonReimbursableAmount", typeof(System.Decimal));
            _datatable.Columns.Add("ActualAmount", typeof(System.Decimal));
            _datatable.Columns.Add("RateID", typeof(System.Int64));
            _datatable.Columns.Add("IsDiscountable", typeof(System.String));
            _datatable.Columns.Add("IsSTAT", typeof(System.String));
            _datatable.Columns.Add("IsOutSource", typeof(System.String));
            _datatable.Columns.Add("IsNABL", typeof(System.String));

            DataRow _datarow;

            foreach (OrderedInvestigations _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["FeeType"] = _list.Type;
                _datarow["FeeID"] = _list.ID;
                _datarow["Description"] = _list.Name;
                _datarow["Comments"] = "";
                if (_list.CreatedAt == DateTime.MinValue)
                {
                    _datarow["FromDate"] = DBNull.Value;
                    _datarow["ToDate"] = DBNull.Value;
                }
                else
                {
                    _datarow["FromDate"] = _list.CreatedAt;
                    _datarow["ToDate"] = _list.CreatedAt;
                }

                _datarow["Status"] = "Pending";
                _datarow["unit"] = 1;
                _datarow["Amount"] = 0;
                _datarow["DetailsID"] = 0;
                _datarow["PackageID"] = 0;
                _datarow["SpecialityID"] = 0;
                _datarow["UserID"] = 0;
                _datarow["DiscountAmount"] = 0;
                _datarow["IsReimbursable"] = "";
                _datarow["IsTaxable"] = "";
                _datarow["ServiceCode"] = "";
                _datarow["DiscountPercent"] = 0;
                _datarow["DiscOrEnhanceType"] = "";
                _datarow["Remarks"] = "";
                _datarow["ReimbursableAmount"] = 0;
                _datarow["NonReimbursableAmount"] = 0;
                _datarow["ActualAmount"] = 0;
                _datarow["RateID"] = 0;
                _datarow["IsDiscountable"] = "N";
                _datarow["IsSTAT"] = "N";
                _datarow["IsOutSource"] = "";
                _datarow["IsNABL"] = "";
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTPatientDueChart(List<PatientDueChart> lstSurgergicalPkg, List<OrderedInvestigations> invs,
                                                     List<PatientDueChart> pPatientConsultation,
                                                     List<PatientDueChart> pPatientProcedure,
                                                     List<PatientDueChart> pPatientIndents,
                                                     List<DHEBAdder> pDHEBPatientIndents, DateTime dtInvDate, string LabNo)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("FeeType", typeof(System.String));
            _datatable.Columns.Add("FeeID", typeof(System.Int64));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("Comments", typeof(System.String));
            _datatable.Columns.Add("FromDate", typeof(System.DateTime));
            _datatable.Columns.Add("ToDate", typeof(System.DateTime));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("unit", typeof(System.Decimal));
            _datatable.Columns.Add("Amount", typeof(System.Decimal));
            _datatable.Columns.Add("DetailsID", typeof(System.Int64));
            _datatable.Columns.Add("PackageID", typeof(System.Int64));
            _datatable.Columns.Add("FromTable", typeof(System.String));
            _datatable.Columns.Add("DiscountAmount", typeof(System.Decimal));
            _datatable.Columns.Add("IsReimbursable", typeof(System.String));
            _datatable.Columns.Add("IsTaxable", typeof(System.String));
            _datatable.Columns.Add("ServiceCode", typeof(System.String));
            _datatable.Columns.Add("DiscountPercent", typeof(System.Decimal));
            _datatable.Columns.Add("DiscOrEnhanceType", typeof(System.String));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            _datatable.Columns.Add("ReimbursableAmount", typeof(System.Decimal));
            _datatable.Columns.Add("NonReimbursableAmount", typeof(System.Decimal));
            _datatable.Columns.Add("ActualAmount", typeof(System.Decimal));
            _datatable.Columns.Add("RateID", typeof(System.Int64));
            _datatable.Columns.Add("IsDiscountable", typeof(System.String));
            _datatable.Columns.Add("IsSTAT", typeof(System.String));
            _datatable.Columns.Add("IsOutSource", typeof(System.String));
            _datatable.Columns.Add("IsNABL", typeof(System.String));

            DataRow _datarow;

            foreach (OrderedInvestigations inv in invs)
            {
                _datarow = _datatable.NewRow();
                _datarow["FeeType"] = inv.Type;
                _datarow["FeeID"] = inv.ID;
                _datarow["Description"] = inv.Name;
                _datarow["Comments"] = "";
                _datarow["FromDate"] = dtInvDate;
                _datarow["ToDate"] = dtInvDate;
                _datarow["Status"] = "Pending";
                _datarow["unit"] = 1;
                _datarow["Amount"] = 0;
                _datarow["DetailsID"] = 0;
                _datarow["PackageID"] = LabNo;
                _datarow["SpecialityID"] = 0;
                _datarow["UserID"] = 0;
                _datarow["DiscountAmount"] = 0;
                _datarow["IsReimbursable"] = "";
                _datarow["IsTaxable"] = "";
                _datarow["ServiceCode"] = "";
                _datarow["DiscountPercent"] = 0;
                _datarow["DiscOrEnhanceType"] = "";
                _datarow["Remarks"] = "";
                _datarow["ReimbursableAmount"] = 0;
                _datarow["NonReimbursableAmount"] = 0;
                _datarow["ActualAmount"] = 0;
                _datarow["RateID"] = 0;
                _datarow["IsDiscountable"] = "N";
                _datarow["IsSTAT"] = "N";
                _datarow["IsOutSource"] = "";
                _datarow["IsNABL"] = "";
                _datatable.Rows.Add(_datarow);
            }

            foreach (PatientDueChart pConsultation in pPatientConsultation)
            {
                _datarow = _datatable.NewRow();
                _datarow["FeeType"] = pConsultation.FeeType;
                _datarow["FeeID"] = pConsultation.FeeID;          //inv.GroupID;
                _datarow["Description"] = pConsultation.Description;  //inv.GroupName;
                _datarow["Comments"] = pConsultation.Comments;
                _datarow["FromDate"] = pConsultation.FromDate;
                _datarow["ToDate"] = pConsultation.ToDate;
                _datarow["Status"] = "Pending";
                _datarow["unit"] = pConsultation.Unit;
                _datarow["Amount"] = pConsultation.Amount;
                _datarow["DetailsID"] = 0;
                _datarow["PackageID"] = 0;
                _datarow["SpecialityID"] = 0;
                _datarow["UserID"] = 0;
                _datarow["DiscountAmount"] = 0;
                _datarow["IsReimbursable"] = pConsultation.IsReimbursable;
                _datarow["IsTaxable"] = "";
                _datarow["ServiceCode"] = "";
                _datarow["DiscountPercent"] = pConsultation.DiscountPercent;
                _datarow["DiscOrEnhanceType"] = pConsultation.DiscOrEnhanceType;
                _datarow["Remarks"] = pConsultation.Remarks;
                _datarow["ReimbursableAmount"] = pConsultation.ReimbursableAmount;
                _datarow["NonReimbursableAmount"] = pConsultation.NonReimbursableAmount;
                _datarow["ActualAmount"] = 0;
                _datarow["RateID"] = 0;
                _datarow["IsDiscountable"] = "N";
                _datarow["IsSTAT"] = "N";
                _datarow["IsOutSource"] = "";
                _datarow["IsNABL"] = "";
                _datatable.Rows.Add(_datarow);
            }
            foreach (PatientDueChart pProcedure in pPatientProcedure)
            {
                _datarow = _datatable.NewRow();
                _datarow["FeeType"] = pProcedure.FeeType;
                _datarow["FeeID"] = pProcedure.FeeID;          //inv.GroupID;
                _datarow["Description"] = pProcedure.Description;  //inv.GroupName;
                _datarow["Comments"] = pProcedure.Comments;
                _datarow["FromDate"] = pProcedure.FromDate;
                _datarow["ToDate"] = pProcedure.ToDate;
                _datarow["Status"] = "Pending";
                _datarow["unit"] = pProcedure.Unit;
                _datarow["Amount"] = pProcedure.Amount;
                _datarow["DetailsID"] = 0;
                _datarow["PackageID"] = 0;
                _datarow["SpecialityID"] = 0;
                _datarow["UserID"] = 0;
                _datarow["DiscountAmount"] = 0;
                _datarow["IsReimbursable"] = pProcedure.IsReimbursable;
                _datarow["IsTaxable"] = "";
                _datarow["ServiceCode"] = "";
                _datarow["DiscountPercent"] = pProcedure.DiscountPercent;
                _datarow["DiscOrEnhanceType"] = pProcedure.DiscOrEnhanceType;
                _datarow["Remarks"] = pProcedure.Remarks;
                _datarow["ReimbursableAmount"] = pProcedure.ReimbursableAmount;
                _datarow["NonReimbursableAmount"] = pProcedure.NonReimbursableAmount;
                _datatable.Rows.Add(_datarow);
            }
            foreach (PatientDueChart pIndents in pPatientIndents)
            {
                _datarow = _datatable.NewRow();
                _datarow["FeeType"] = pIndents.FeeType;
                _datarow["FeeID"] = pIndents.FeeID;          //inv.GroupID;
                _datarow["Description"] = pIndents.Description;  //inv.GroupName;
                _datarow["Comments"] = pIndents.Comments;
                _datarow["FromDate"] = pIndents.FromDate;
                _datarow["ToDate"] = pIndents.ToDate;
                _datarow["Status"] = "Pending";
                _datarow["unit"] = pIndents.Unit;
                _datarow["Amount"] = 0;
                _datarow["DetailsID"] = 0;
                _datarow["PackageID"] = 0;
                _datarow["SpecialityID"] = 0;
                _datarow["UserID"] = 0;
                _datarow["DiscountAmount"] = 0;
                _datarow["IsReimbursable"] = pIndents.IsReimbursable;
                _datarow["IsTaxable"] = "";
                _datarow["ServiceCode"] = "";
                _datarow["DiscountPercent"] = pIndents.DiscountPercent;
                _datarow["DiscOrEnhanceType"] = pIndents.DiscOrEnhanceType;
                _datarow["Remarks"] = pIndents.Remarks;
                _datarow["ReimbursableAmount"] = pIndents.ReimbursableAmount;
                _datarow["NonReimbursableAmount"] = pIndents.NonReimbursableAmount;
                _datatable.Rows.Add(_datarow);
            }

            foreach (DHEBAdder pIndents in pDHEBPatientIndents)
            {
                _datarow = _datatable.NewRow();
                pIndents.Comments = pIndents.Comments == "" ? "0" : pIndents.Comments;
                _datarow["FeeType"] = "OTH";
                _datarow["FeeID"] = -1;          //inv.GroupID;
                _datarow["Description"] = pIndents.Description;  //inv.GroupName;
                _datarow["Comments"] = "";
                _datarow["FromDate"] = DateTime.Now;
                _datarow["ToDate"] = DateTime.Now;
                _datarow["Status"] = "Pending";
                _datarow["unit"] = 1;
                _datarow["Amount"] = Convert.ToDecimal(pIndents.Comments);
                _datarow["DetailsID"] = 0;
                _datarow["PackageID"] = 0;
                _datarow["SpecialityID"] = 0;
                _datarow["UserID"] = 0;
                _datarow["DiscountAmount"] = 0;
                _datarow["IsReimbursable"] = "";
                _datarow["IsTaxable"] = "";
                _datarow["ServiceCode"] = "";
                _datarow["DiscountPercent"] = 0;
                _datarow["DiscOrEnhanceType"] = "";
                _datarow["Remarks"] = "";
                _datarow["ReimbursableAmount"] = 0;
                _datarow["NonReimbursableAmount"] = 0;

                _datatable.Rows.Add(_datarow);
            }

            foreach (PatientDueChart pSPI in lstSurgergicalPkg)
            {
                _datarow = _datatable.NewRow();
                _datarow["FeeType"] = pSPI.FeeType;
                _datarow["FeeID"] = pSPI.FeeID;          //inv.GroupID;
                _datarow["Description"] = pSPI.Description;  //inv.GroupName;
                _datarow["Comments"] = "";
                _datarow["FromDate"] = pSPI.FromDate;
                _datarow["ToDate"] = pSPI.ToDate;
                _datarow["Status"] = pSPI.Status;
                _datarow["unit"] = pSPI.Unit;
                _datarow["Amount"] = pSPI.Amount;
                _datarow["DetailsID"] = 0;
                _datarow["PackageID"] = pSPI.PackageID;
                _datarow["SpecialityID"] = 0;
                _datarow["UserID"] = 0;
                _datarow["DiscountAmount"] = 0;
                _datarow["IsReimbursable"] = pSPI.IsReimbursable;
                _datarow["IsTaxable"] = "";
                _datarow["ServiceCode"] = "";
                _datarow["DiscountPercent"] = 0;
                _datarow["DiscOrEnhanceType"] = "";
                _datarow["Remarks"] = "";
                _datarow["ReimbursableAmount"] = pSPI.ReimbursableAmount;
                _datarow["NonReimbursableAmount"] = pSPI.NonReimbursableAmount;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToUDTInvestigationLocationMapping(string ColCentreList, long InvestigationID)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("LocationID", typeof(System.Int32));
            _datatable.Columns.Add("ProcessingOrgID", typeof(System.Int64));
            _datatable.Columns.Add("ProcessingAddressID", typeof(System.Int32));
            _datatable.Columns.Add("Type", typeof(System.String));

            DataRow _datarow;

            string[] str1 = ColCentreList.Split('^');
            for (int i = 0; i < str1.Length; i++)
            {
                string[] str2 = str1[i].Split('|');
                for (int j = 0; j < str2.Length; j++)
                {
                    string[] str3 = str2[j].Split('~');
                    if (str3.Length > 1)
                    {
                        _datarow = _datatable.NewRow();
                        _datarow["InvestigationID"] = InvestigationID;
                        _datarow["OrgID"] = str3[1];
                        _datarow["LocationID"] = str3[0];
                        _datarow["ProcessingOrgID"] = 0;
                        _datarow["ProcessingAddressID"] = 0;
                        _datarow["Type"] = str2[1];
                        _datatable.Rows.Add(_datarow);
                    }
                }
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToInvestigationOrgMapping(List<InvestigationOrgMapping> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
            _datatable.Columns.Add("InvestigationName", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("DeptID", typeof(System.Int32));
            _datatable.Columns.Add("HeaderID", typeof(System.Int64));
            _datatable.Columns.Add("Display", typeof(System.String));
            _datatable.Columns.Add("DisplayText", typeof(System.String));
            _datatable.Columns.Add("ReferenceRange", typeof(System.String));
            _datatable.Columns.Add("SequenceNo", typeof(System.Int32));
            _datatable.Columns.Add("SampleCode", typeof(System.Int32));
            _datatable.Columns.Add("MethodID", typeof(System.Int64));
            _datatable.Columns.Add("PrincipleID", typeof(System.Int64));
            _datatable.Columns.Add("KitID", typeof(System.Int64));
            _datatable.Columns.Add("InstrumentID", typeof(System.Int64));
            _datatable.Columns.Add("QCData", typeof(System.String));
            _datatable.Columns.Add("Interpretation", typeof(System.String));
            _datatable.Columns.Add("SampleContainerID", typeof(System.Int32));
            _datatable.Columns.Add("UOMID", typeof(System.Int32));
            _datatable.Columns.Add("UOMCode", typeof(System.String));
            _datatable.Columns.Add("LoginID", typeof(System.Int64));
            _datatable.Columns.Add("PanicRange", typeof(System.String));
            _datatable.Columns.Add("AutoApproveLoginID", typeof(System.Int64));
            _datatable.Columns.Add("ReferenceRangeString", typeof(System.String));
            _datatable.Columns.Add("PrintSeparately", typeof(System.String));

            DataRow _datarow;

            foreach (InvestigationOrgMapping _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datarow["InvestigationName"] = _list.InvestigationName;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["DeptID"] = _list.DeptID;
                _datarow["HeaderID"] = _list.HeaderID;
                _datarow["Display"] = _list.Display;
                _datarow["DisplayText"] = _list.DisplayText;
                _datarow["ReferenceRange"] = _list.ReferenceRange;
                _datarow["SequenceNo"] = _list.SequenceNo;
                _datarow["SampleCode"] = _list.SampleCode;
                _datarow["MethodID"] = _list.MethodID;
                _datarow["PrincipleID"] = _list.PrincipleID;
                _datarow["KitID"] = _list.KitID;
                _datarow["InstrumentID"] = _list.InstrumentID;
                _datarow["QCData"] = _list.QCData;
                _datarow["Interpretation"] = _list.Interpretation;
                _datarow["SampleContainerID"] = _list.SampleContainerID;
                _datarow["UOMID"] = _list.UOMID;
                _datarow["UOMCode"] = _list.UOMCode;
                _datarow["LoginID"] = _list.LoginID;
                _datarow["PanicRange"] = _list.PanicRange;
                _datarow["AutoApproveLoginID"] = _list.AutoApproveLoginID;
                _datarow["ReferenceRangeString"] = _list.ReferenceRangeString;
                _datarow["PrintSeparately"] = _list.PrintSeparately;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToUDTClientDespatchmode(List<DespatchMode> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ActionTypeID", typeof(System.Int64));
            _datatable.Columns.Add("Despatch", typeof(System.String));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("ClientID", typeof(System.Int64));

            DataRow _datarow;

            foreach (DespatchMode _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ActionTypeID"] = _list.ActionTypeID;
                _datarow["Despatch"] = _list.Despatch;
                _datarow["Description"] = _list.Description;
                _datarow["ClientID"] = _list.ClientID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTClientAttributes(List<ClientAttributesDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("AttributesID", typeof(System.Int64));
            _datatable.Columns.Add("value", typeof(System.String));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("ClientID", typeof(System.Int64));

            DataRow _datarow;

            foreach (ClientAttributesDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["AttributesID"] = _list.AttributesID;
                _datarow["value"] = _list.Value;
                _datarow["Description"] = _list.Description;
                _datarow["ClientID"] = _list.ClientID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToUDTAddressDetails(List<AddressDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("AddressID", typeof(System.Int64));
            _datatable.Columns.Add("AddressTypeID", typeof(System.Int32));
            _datatable.Columns.Add("ReferenceID", typeof(System.Int64));
            _datatable.Columns.Add("ReferenceType", typeof(System.String));
            _datatable.Columns.Add("Address1", typeof(System.String));
            _datatable.Columns.Add("City", typeof(System.String));
            _datatable.Columns.Add("CountryID", typeof(System.Int32));
            _datatable.Columns.Add("StateID", typeof(System.Int32));
            _datatable.Columns.Add("EmailID", typeof(System.String));
            _datatable.Columns.Add("Phone", typeof(System.String));
            _datatable.Columns.Add("Mobile", typeof(System.String));
            _datatable.Columns.Add("FaxNumber", typeof(System.String));
            _datatable.Columns.Add("IsCommunication", typeof(System.String));
            _datatable.Columns.Add("ISDCode", typeof(System.Int32));
            _datatable.Columns.Add("Name", typeof(System.String));
            _datatable.Columns.Add("ContactType", typeof(System.String));
            _datatable.Columns.Add("EmpID", typeof(System.Int64));
            _datatable.Columns.Add("SubUrban", typeof(System.String));
            _datatable.Columns.Add("Address2", typeof(System.String));
            _datatable.Columns.Add("ZipCode", typeof(System.String));
            _datatable.Columns.Add("InvoiceEmail", typeof(System.String));

            DataRow _datarow;

            foreach (AddressDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["AddressID"] = _list.AddressID;
                _datarow["AddressTypeID"] = _list.AddressTypeID;
                _datarow["ReferenceID"] = _list.ReferenceID;
                _datarow["ReferenceType"] = _list.ReferenceType;
                _datarow["Address1"] = _list.Address1;
                _datarow["City"] = _list.City;
                _datarow["CountryID"] = _list.CountryID;
                _datarow["StateID"] = _list.StateID;
                _datarow["EmailID"] = _list.EmailID;
                _datarow["Phone"] = _list.Phone;
                _datarow["Mobile"] = _list.Mobile;
                _datarow["FaxNumber"] = _list.FaxNumber;
                _datarow["IsCommunication"] = _list.IsCommunication;
                _datarow["ISDCode"] = _list.ISDCode;
                _datarow["Name"] = _list.Name;
                _datarow["ContactType"] = _list.ContactType;
                _datarow["EmpID"] = _list.EmpID;
                _datarow["SubUrban"] = _list.SubUrban;
                _datarow["Address2"] = _list.Address2;
                _datarow["ZipCode"] = _list.PostalCode;
                _datarow["InvoiceEmail"] = _list.InvoiceEmail;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToRateCardDiscount(List<DiscountPolicyMapping> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PolicyID", typeof(System.Int64));
            _datatable.Columns.Add("FeeType", typeof(System.String));
            _datatable.Columns.Add("CategoryCode", typeof(System.String));
            _datatable.Columns.Add("DiscountPercentage", typeof(System.Decimal));
            _datatable.Columns.Add("DiscountType", typeof(System.String));

            DataRow _datarow;

            foreach (DiscountPolicyMapping _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PolicyID"] = _list.PolicyID;
                _datarow["FeeType"] = _list.FeeType;
                _datarow["CategoryCode"] = _list.CategoryCode;
                _datarow["DiscountPercentage"] = _list.DiscountPercentage;
                _datarow["DiscountType"] = _list.DiscountType;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTResourceConsumption(List<ResourceConsumption> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientID", typeof(System.Int64));
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("ServiceName", typeof(System.String));
            _datatable.Columns.Add("ServiceID", typeof(System.Int64));
            _datatable.Columns.Add("ResourceName", typeof(System.String));
            _datatable.Columns.Add("ResourceID", typeof(System.Int64));
            _datatable.Columns.Add("ConsumptionValue", typeof(System.String));
            _datatable.Columns.Add("ConsumptionDate", typeof(System.DateTime));
            _datatable.Columns.Add("Comments", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ServiceType", typeof(System.String));

            DataRow _datarow;

            foreach (ResourceConsumption _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientID"] = _list.PatientID;
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["ServiceName"] = _list.ServiceName;
                _datarow["ServiceID"] = _list.ServiceID;
                _datarow["ResourceName"] = _list.ResourceName;
                _datarow["ResourceID"] = _list.ResourceID;
                _datarow["ConsumptionValue"] = _list.ConsumptionValue;
                _datarow["ConsumptionDate"] = _list.ConsumptionDate;
                _datarow["Comments"] = _list.Comments;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAT;
                _datarow["ModifiedBy"] = _list.MOdifiedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ServiceType"] = _list.Descriptions;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToBannerMaster(List<BannerRoleMapping> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("LoginID", typeof(System.Int64));
            _datatable.Columns.Add("RoleID", typeof(System.Int64));
            _datatable.Columns.Add("BannerID", typeof(System.Int64));
            _datatable.Columns.Add("BannerStartDate", typeof(System.DateTime));
            _datatable.Columns.Add("BannerEndDate", typeof(System.DateTime));

            DataRow _datarow;

            foreach (BannerRoleMapping _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["LoginID"] = _list.LoginID;
                _datarow["RoleID"] = _list.RoleID;
                _datarow["BannerID"] = _list.BannerID;
                _datarow["BannerStartDate"] = _list.BannerStartDate;
                _datarow["BannerEndDate"] = _list.BannerEndDate;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTICDCode(List<ICDCodes> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ICDCode", typeof(System.String));
            _datatable.Columns.Add("ICDCategory", typeof(System.Int32));
            _datatable.Columns.Add("ICDDescription", typeof(System.String));
            _datatable.Columns.Add("IsUserDefined", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("CreatedBY", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ComplaintName", typeof(System.String));

            DataRow _datarow;

            foreach (ICDCodes _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ICDCode"] = _list.ICDCode;
                _datarow["ICDCategory"] = _list.ICDCategory;
                _datarow["ICDDescription"] = _list.ICDDescription;
                _datarow["IsUserDefined"] = _list.IsUserDefined;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["CreatedBY"] = _list.CreatedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ComplaintName"] = _list.ComplaintName;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToDiscountPolicyUDT(List<DiscountPolicy> _lstCollection)
        {
            //MODIFIED BY PREM DISCOUNT POLICY TABLE STRUCTURE CHANGED
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("TODID", typeof(System.Int32));
            _datatable.Columns.Add("Code", typeof(System.String));
            _datatable.Columns.Add("BasedOn", typeof(System.String));
            _datatable.Columns.Add("RangeFrom", typeof(System.Int64));
            _datatable.Columns.Add("RangeTo", typeof(System.Int64));
            _datatable.Columns.Add("Value", typeof(System.Decimal));
            _datatable.Columns.Add("FeeID", typeof(System.Int64));
            _datatable.Columns.Add("FeeType", typeof(System.String));
            _datatable.Columns.Add("Name", typeof(System.String));
            _datatable.Columns.Add("IsActive", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));


            DataRow _datarow;

            foreach (DiscountPolicy _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["TODID"] = _list.TODID;
                _datarow["Code"] = _list.Code;
                _datarow["BasedOn"] = _list.BasedOn;
                _datarow["RangeFrom"] = _list.RangeFrom;
                _datarow["RangeTo"] = _list.RangeTo;
                _datarow["Value"] = _list.Value;
                _datarow["FeeID"] = _list.FeeID;
                _datarow["FeeType"] = _list.FeeType;
                _datarow["Name"] = _list.Name;
                _datarow["IsActive"] = _list.IsActive;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTCurrencyOrgMapping(List<CurrencyOrgMapping> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("CurrencyID", typeof(System.Int32));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("ConversionRate", typeof(System.Decimal));
            _datatable.Columns.Add("IsBaseCurrency", typeof(System.String));
            _datatable.Columns.Add("CurrencyCode", typeof(System.String));
            _datatable.Columns.Add("CurrencyName", typeof(System.String));
            _datatable.Columns.Add("RemoveCurrency", typeof(System.String));

            DataRow _datarow;

            foreach (CurrencyOrgMapping _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["CurrencyID"] = _list.CurrencyID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["ConversionRate"] = _list.ConversionRate;
                _datarow["IsBaseCurrency"] = _list.IsBaseCurrency;
                _datarow["CurrencyCode"] = _list.CurrencyCode;
                _datarow["CurrencyName"] = _list.CurrencyName;
                _datarow["RemoveCurrency"] = _list.RemoveCurrency;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTCategoriesAndPatterns(List<MasterCategories> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("CategoryId", typeof(System.Int32));
            _datatable.Columns.Add("CategoryName", typeof(System.String));
            _datatable.Columns.Add("PatternValue", typeof(System.String));
            _datatable.Columns.Add("IsReset", typeof(System.String));
            _datatable.Columns.Add("CreatedDate", typeof(System.DateTime));
            _datatable.Columns.Add("ResetNumber", typeof(System.Int64));
            _datatable.Columns.Add("ResetOption", typeof(System.String));
            _datatable.Columns.Add("ResetBy", typeof(System.String));
            _datatable.Columns.Add("Pattern", typeof(System.String));

            DataRow _datarow;

            foreach (MasterCategories _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["CategoryId"] = _list.CategoryId;
                _datarow["CategoryName"] = _list.CategoryName;
                _datarow["PatternValue"] = _list.PatternValue;
                _datarow["IsReset"] = _list.IsReset;
                _datarow["CreatedDate"] = _list.CreatedDate;
                _datarow["ResetNumber"] = _list.ResetNumber;
                _datarow["ResetOption"] = _list.ResetOption;
                _datarow["ResetBy"] = _list.ResetBy;
                _datarow["Pattern"] = _list.Pattern;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTEmployeeRegMaster(List<EmployeeRegMaster> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("EmployeeNumber", typeof(System.String));
            _datatable.Columns.Add("Name", typeof(System.String));
            _datatable.Columns.Add("DOJ", typeof(System.DateTime));
            _datatable.Columns.Add("EmployerID", typeof(System.Int64));
            _datatable.Columns.Add("DeptID", typeof(System.Int64));
            _datatable.Columns.Add("DesignationID", typeof(System.Int64));
            _datatable.Columns.Add("EmployementTypeID", typeof(System.Int64));
            _datatable.Columns.Add("Qualification", typeof(System.String));
            _datatable.Columns.Add("EmployerLocationID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int64));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ZoneID", typeof(System.Int64));
            _datatable.Columns.Add("MobileNo", typeof(System.String));
            _datatable.Columns.Add("LandlineNo", typeof(System.String));
            _datatable.Columns.Add("EMail", typeof(System.String));
            _datatable.Columns.Add("DiscountLimit", typeof(System.Decimal));
            _datatable.Columns.Add("DiscountPeriod", typeof(System.String));
            _datatable.Columns.Add("DiscountValidFrom", typeof(System.DateTime));
            _datatable.Columns.Add("DiscountValidTo", typeof(System.DateTime));
            DataRow _datarow;

            foreach (EmployeeRegMaster _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["EmployeeNumber"] = _list.EmployeeNumber;
                _datarow["Name"] = _list.Name;
                _datarow["DOJ"] = _list.DOJ;
                _datarow["EmployerID"] = _list.EmployerID;
                _datarow["DeptID"] = _list.DeptID;
                _datarow["DesignationID"] = _list.DesignationID;
                _datarow["EmployementTypeID"] = _list.EmployementTypeID;
                _datarow["Qualification"] = _list.Qualification;
                _datarow["EmployerLocationID"] = _list.EmployerLocationID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ZoneID"] = _list.ZoneID;
                _datarow["MobileNo"] = _list.MobileNo;
                _datarow["LandlineNo"] = _list.LandlineNo;
                _datarow["EMail"] = _list.EMail;
                _datarow["DiscountLimit"] = _list.DiscountLimit;
                _datarow["DiscountPeriod"] = _list.DiscountPeriod;
                _datarow["DiscountValidFrom"] = _list.DiscountValidFrom;
                _datarow["DiscountValidTo"] = _list.DiscountValidTo;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToSpecialRateMaster(List<RateMaster> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("InvID", typeof(System.Int64));
            _datatable.Columns.Add("InvType", typeof(System.String));
            _datatable.Columns.Add("OpAmount", typeof(System.Decimal));
            _datatable.Columns.Add("IpAmount", typeof(System.Decimal));
            _datatable.Columns.Add("ClientID", typeof(System.Int64));
            _datatable.Columns.Add("ReferenceType", typeof(System.String));
            _datatable.Columns.Add("ServiceID", typeof(System.Int64));
            _datatable.Columns.Add("SCode", typeof(System.String));

            DataRow _datarow;

            foreach (RateMaster _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["InvID"] = _list.InvestigationID;
                _datarow["InvType"] = _list.InvestigationType;
                _datarow["OpAmount"] = _list.OpAmount;
                _datarow["IpAmount"] = _list.IpAmount;
                _datarow["ClientID"] = _list.ClientID;
                _datarow["ReferenceType"] = _list.ReferenceType;
                _datarow["ServiceID"] = _list.ServiceID;
                _datarow["SCode"] = _list.SCode;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTCouponMaster(List<CouponMaster> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("CouponID", typeof(System.Int64));
            _datatable.Columns.Add("Code", typeof(System.String));
            _datatable.Columns.Add("Name", typeof(System.String));
            _datatable.Columns.Add("Status", typeof(System.String));

            DataRow _datarow;

            foreach (CouponMaster _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["CouponID"] = _list.CouponID;
                _datarow["Code"] = _list.Code;
                _datarow["Name"] = _list.Name;
                _datarow["Status"] = _list.Status;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTCouponDetails(List<CouponDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("CouponDetailID", typeof(System.Int64));
            _datatable.Columns.Add("CouponID", typeof(System.Int64));
            _datatable.Columns.Add("StartSerialNo", typeof(System.String));
            _datatable.Columns.Add("EndSerialNo", typeof(System.String));
            _datatable.Columns.Add("BatchNo", typeof(System.String));
            _datatable.Columns.Add("OrderedUnits", typeof(System.Int64));
            _datatable.Columns.Add("CouponValue", typeof(System.Decimal));
            _datatable.Columns.Add("ExpiryDate", typeof(System.String));
            _datatable.Columns.Add("ConsumedUnits", typeof(System.Int64));
            _datatable.Columns.Add("Code", typeof(System.String));

            DataRow _datarow;

            foreach (CouponDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["CouponDetailID"] = _list.CouponDetailID;
                _datarow["CouponID"] = _list.CouponID;
                _datarow["StartSerialNo"] = _list.StartSerialNo;
                _datarow["EndSerialNo"] = _list.EndSerialNo;
                _datarow["BatchNo"] = _list.BatchNo;
                _datarow["OrderedUnits"] = _list.OrderedUnits;
                _datarow["CouponValue"] = _list.CouponValue;
                _datarow["ExpiryDate"] = _list.ExpiryDate;
                _datarow["ConsumedUnits"] = _list.ConsumedUnits;
                _datarow["Code"] = _list.Code;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTBillOfMaterials(List<BillOfMaterials> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ResourceServiceTypeID", typeof(System.Int32));
            _datatable.Columns.Add("ServiceName", typeof(System.String));
            _datatable.Columns.Add("FeeType", typeof(System.String));
            _datatable.Columns.Add("FeeTypeID", typeof(System.Int32));
            _datatable.Columns.Add("ResourceType", typeof(System.String));
            _datatable.Columns.Add("ResourceName", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("SeviceID", typeof(System.Int64));
            _datatable.Columns.Add("ServiceType", typeof(System.String));

            DataRow _datarow;

            foreach (BillOfMaterials _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ResourceServiceTypeID"] = _list.BillofMaterialID;
                _datarow["ServiceName"] = _list.ServiceName;
                _datarow["FeeType"] = _list.FeeType;
                _datarow["FeeTypeID"] = _list.FeeTypeID;
                _datarow["ResourceType"] = _list.ResourceType;
                _datarow["ResourceName"] = _list.ResourceName;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["SeviceID"] = _list.SeviceID;
                _datarow["ServiceType"] = _list.ServiceType;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToUDTBillOfMaterialDetails(List<BillofMaterialDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("BillofMaterialID", typeof(System.Int32));
            _datatable.Columns.Add("ProductID", typeof(System.Int64));
            _datatable.Columns.Add("EstimatedQty", typeof(System.Decimal));
            _datatable.Columns.Add("EstimatedUnit", typeof(System.String));
            _datatable.Columns.Add("BufferQty", typeof(System.Decimal));
            _datatable.Columns.Add("BufferUnit", typeof(System.String));
            _datatable.Columns.Add("EstimatedDuration", typeof(System.String));
            _datatable.Columns.Add("CeilingLimit", typeof(System.String));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int64));
            _datatable.Columns.Add("ParentProductID", typeof(System.Int64));
            _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
            _datatable.Columns.Add("LocationID", typeof(System.Int32));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("RecurrentUsage", typeof(System.String));

            DataRow _datarow;

            foreach (BillofMaterialDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["BillofMaterialID"] = _list.BillofMaterialID;
                _datarow["ProductID"] = _list.ProductID;
                _datarow["EstimatedQty"] = _list.EstimatedQty;
                _datarow["EstimatedUnit"] = _list.EstimatedUnit;
                _datarow["BufferQty"] = _list.BufferQty;
                _datarow["BufferUnit"] = _list.BufferUnit;
                _datarow["EstimatedDuration"] = _list.EstimatedDuration;
                _datarow["CeilingLimit"] = _list.CeilingLimit;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["ParentProductID"] = _list.ParentProductID;
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datarow["LocationID"] = _list.LocationID;
                _datarow["Description"] = _list.Description;
                _datarow["RecurrentUsage"] = _list.RecurrentUsage;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToPrintPolicy(PrintPolicyMaster _list)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ID", typeof(System.Int32));
            _datatable.Columns.Add("OrgAddressID", typeof(System.Int64));
            _datatable.Columns.Add("RoleID", typeof(System.Int64));
            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("Value", typeof(System.String));
            _datatable.Columns.Add("IsActive", typeof(System.Boolean));

            DataRow _datarow;


            _datarow = _datatable.NewRow();
            _datarow["ID"] = _list.ID;
            _datarow["OrgAddressID"] = _list.OrgAddressID;
            _datarow["RoleID"] = _list.RoleID;
            _datarow["Type"] = _list.Type;
            _datarow["Value"] = _list.Value;
            _datarow["IsActive"] = _list.IsActive;
            _datatable.Rows.Add(_datarow);

            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToWorkListInvestigations(List<PatientInvestigation> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("InvestigationName", typeof(System.String));
            _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
            _datatable.Columns.Add("GroupID", typeof(System.Int32));
            _datatable.Columns.Add("GroupName", typeof(System.String));
            _datatable.Columns.Add("GroupComment", typeof(System.String));
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CollectedDateTime", typeof(System.DateTime));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("ComplaintID", typeof(System.Int32));
            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("InvestigationMethodID", typeof(System.Int64));
            _datatable.Columns.Add("MethodName", typeof(System.String));
            _datatable.Columns.Add("KitID", typeof(System.Int64));
            _datatable.Columns.Add("KitName", typeof(System.String));
            _datatable.Columns.Add("InstrumentID", typeof(System.Int64));
            _datatable.Columns.Add("InstrumentName", typeof(System.String));
            _datatable.Columns.Add("Interpretation", typeof(System.String));
            _datatable.Columns.Add("PrincipleID", typeof(System.Int64));
            _datatable.Columns.Add("PrincipleName", typeof(System.String));
            _datatable.Columns.Add("QCData", typeof(System.String));
            _datatable.Columns.Add("InvestigationSampleContainerID", typeof(System.Int32));
            _datatable.Columns.Add("PackageID", typeof(System.Int32));
            _datatable.Columns.Add("PackageName", typeof(System.String));
            _datatable.Columns.Add("UID", typeof(System.String));

            DataRow _datarow;

            foreach (PatientInvestigation _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["InvestigationName"] = _list.InvestigationName;
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datarow["GroupID"] = _list.GroupID;
                _datarow["GroupName"] = _list.GroupName;
                _datarow["GroupComment"] = _list.GroupComment;
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CollectedDateTime"] = _list.CollectedDateTime;
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
                _datarow["UID"] = _list.UID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToInvestigationAdminRate(List<InvestigationOrgMapping> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ID", typeof(System.Int64));
            _datatable.Columns.Add("Amount", typeof(System.Decimal));
            _datatable.Columns.Add("Refrange", typeof(System.String));
            _datatable.Columns.Add("DisplayTxt", typeof(System.String));
            _datatable.Columns.Add("IPAmount", typeof(System.Decimal));
            _datatable.Columns.Add("OPPercent", typeof(System.Decimal));
            _datatable.Columns.Add("IPPercent", typeof(System.Decimal));
            _datatable.Columns.Add("SourceID", typeof(System.Int64));
            _datatable.Columns.Add("UOMCode", typeof(System.String));
            _datatable.Columns.Add("UOMID", typeof(System.Int32));
            _datatable.Columns.Add("TYPE", typeof(System.String));
            _datatable.Columns.Add("MinAdvanceAmt", typeof(System.Decimal));
            _datatable.Columns.Add("LabAmount", typeof(System.Decimal));
            _datatable.Columns.Add("FranchiseeAmount", typeof(System.Decimal));

            DataRow _datarow;

            foreach (InvestigationOrgMapping _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ID"] = _list.InvestigationID;
                _datarow["Amount"] = 0;
                _datarow["Refrange"] = _list.ReferenceRange;
                _datarow["DisplayTxt"] = _list.DisplayText;
                _datarow["TYPE"] = _list.Display;
                _datarow["UOMID"] = _list.OrgID;
                _datarow["UOMCode"] = _list.Interpretation;
                _datarow["LabAmount"] = Decimal.Zero;
                _datarow["FranchiseeAmount"] = Decimal.Zero;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToGroupOrgMapping(List<InvOrgGroup> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("GroupID", typeof(System.Int64));
            _datatable.Columns.Add("GroupName", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("Display", typeof(System.String));
            _datatable.Columns.Add("DisplayText", typeof(System.String));
            _datatable.Columns.Add("SequenceNo", typeof(System.Int32));

            DataRow _datarow;

            foreach (InvOrgGroup _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["GroupID"] = _list.AttGroupID;
                _datarow["GroupName"] = _list.GroupName;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["Display"] = _list.OrgID;
                _datarow["DisplayText"] = _list.DisplayText;
                _datarow["SequenceNo"] = _list.SequenceNo;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTInvPackageMapping(List<InvPackageMapping> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PackageID", typeof(System.Int32));
            _datatable.Columns.Add("ID", typeof(System.Int64));
            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("active", typeof(System.String));

            DataRow _datarow;

            foreach (InvPackageMapping _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PackageID"] = _list.PackageID;
                _datarow["ID"] = _list.ID;
                _datarow["Type"] = _list.Type;
                _datarow["active"] = _list.Active;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTInvPackageDeleting(List<InvPackageMapping> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PackageID", typeof(System.Int32));
            _datatable.Columns.Add("ID", typeof(System.Int64));
            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("active", typeof(System.String));
            DataRow _datarow;

            foreach (InvPackageMapping _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PackageID"] = _list.PackageID;
                _datarow["ID"] = _list.ID;
                _datarow["Type"] = _list.Type;
                _datarow["active"] = _list.Active;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTPCCustomPriceMapping(List<PCCustomPriceMapping> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ID", typeof(System.Int64));
            _datatable.Columns.Add("Name", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("RefOrgID", typeof(System.Int64));
            _datatable.Columns.Add("RefPhyID", typeof(System.Int32));
            _datatable.Columns.Add("Rate", typeof(System.Decimal));

            DataRow _datarow;

            foreach (PCCustomPriceMapping _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ID"] = _list.ID;
                _datarow["Name"] = _list.Name;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["Type"] = _list.Type;
                _datarow["RefOrgID"] = _list.RefOrgID;
                _datarow["RefPhyID"] = _list.RefPhyID;
                _datarow["Rate"] = _list.Rate;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTSampleTracker(List<SampleTracker> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("SampleTrackerID", typeof(System.Int32));
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("SampleID", typeof(System.Int32));
            _datatable.Columns.Add("InvSampleStatusID", typeof(System.Int32));
            _datatable.Columns.Add("CurrentOrgID", typeof(System.Int32));
            _datatable.Columns.Add("DeptID", typeof(System.Int32));
            _datatable.Columns.Add("Reason", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("IPInvSampleCollectionMasterID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("SampleDesc", typeof(System.String));
            _datatable.Columns.Add("InvSampleStatusDesc", typeof(System.String));

            DataRow _datarow;

            foreach (SampleTracker _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["SampleTrackerID"] = _list.SampleTrackerID;
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["SampleID"] = _list.SampleID;
                _datarow["InvSampleStatusID"] = _list.InvSampleStatusID;
                _datarow["CurrentOrgID"] = _list.CurrentOrgID;
                _datarow["DeptID"] = _list.DeptID;
                _datarow["Reason"] = _list.Reason;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["IPInvSampleCollectionMasterID"] = _list.IPInvSampleCollectionMasterID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["SampleDesc"] = _list.SampleDesc;
                _datarow["InvSampleStatusDesc"] = _list.InvSampleStatusDesc;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToPatternMapping(List<PatternMapping> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatternID", typeof(System.Int64));
            _datatable.Columns.Add("InvestigationID", typeof(System.Int64));

            DataRow _datarow;

            foreach (PatternMapping _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatternID"] = _list.PatternID;
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTInvReportMapping(List<InvReportMapping> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
            _datatable.Columns.Add("TemplateID", typeof(System.Int32));

            DataRow _datarow;

            foreach (InvReportMapping _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datarow["TemplateID"] = _list.TemplateID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDDinsertSampleTrack(List<SampleTracker> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("SampleID", typeof(System.Int32));
            _datatable.Columns.Add("InvSampleStatusID", typeof(System.Int32));
            _datatable.Columns.Add("CurrentOrgID", typeof(System.Int32));
            _datatable.Columns.Add("DeptID", typeof(System.Int32));
            _datatable.Columns.Add("Reason", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int32));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int32));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("CollectedIn", typeof(System.Int32));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            _datatable.Columns.Add("SampleVolume", typeof(System.Int32));
            _datatable.Columns.Add("SampleUnit", typeof(System.String));
            _datatable.Columns.Add("ReasonID", typeof(System.Int32));

            DataRow _datarow;

            foreach (SampleTracker _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["SampleID"] = _list.SampleID;
                _datarow["InvSampleStatusID"] = _list.InvSampleStatusID;
                _datarow["CurrentOrgID"] = _list.CurrentOrgID;
                _datarow["DeptID"] = _list.DeptID;
                _datarow["Reason"] = _list.Reason;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["CollectedIn"] = _list.CollectedIn;
                _datarow["Remarks"] = _list.Remarks;
                _datarow["SampleVolume"] = _list.SampleVolume;
                _datarow["SampleUnit"] = _list.SampleUnit;
                _datarow["ReasonID"] = _list.ReasonID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToBillItemsMapping(List<BillLineItems> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ItemName", typeof(System.String));
            _datatable.Columns.Add("ItemID", typeof(System.Int64));
            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("Quantity", typeof(System.Decimal));
            _datatable.Columns.Add("Rate", typeof(System.Decimal));
            _datatable.Columns.Add("Amount", typeof(System.Decimal));

            DataRow _datarow;

            foreach (BillLineItems _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ItemName"] = _list.ItemName;
                _datarow["ItemID"] = _list.ItemID;
                _datarow["Type"] = _list.ItemType;
                _datarow["Quantity"] = _list.Quantity;
                _datarow["Rate"] = _list.Rate;
                _datarow["Amount"] = _list.Amount;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTBarcodeCategoriesAndPatterns(List<BarcodeOrgMapping> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("BarcodeCategoryId", typeof(System.Int64));
            _datatable.Columns.Add("BarcodeMainAttributeId", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int64));
            _datatable.Columns.Add("Value", typeof(System.String));
            _datatable.Columns.Add("Id", typeof(System.Int64));
            _datatable.Columns.Add("DisplayText", typeof(System.String));

            DataRow _datarow;

            foreach (BarcodeOrgMapping _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["BarcodeCategoryId"] = _list.BarcodeCategoryId;
                _datarow["BarcodeMainAttributeId"] = _list.BarcodeMainAttributeId;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["Value"] = _list.Value;
                _datarow["Id"] = _list.Id;
                _datarow["DisplayText"] = _list.DisplayText;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToPatientVitalsType(List<DialysisPatientVitals> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("VitalsID", typeof(System.Int32));
            _datatable.Columns.Add("VitalsValue", typeof(System.String));
            _datatable.Columns.Add("SessionType", typeof(System.Byte));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));

            DataRow _datarow;

            foreach (DialysisPatientVitals _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["VitalsID"] = _list.VitalsID;
                _datarow["VitalsValue"] = _list.VitalsValue;
                _datarow["SessionType"] = _list.SessionType;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDDInvDeptSamples(List<InvDeptSamples> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("DeptID", typeof(System.Int32));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));

            DataRow _datarow;

            foreach (InvDeptSamples _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["DeptID"] = _list.DeptID;
                _datarow["OrgID"] = _list.OrgID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToTestMaster(TestMaster _list)
        {
            System.Data.DataTable _datatable = new System.Data.DataTable();
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
            _datatable.Columns.Add("InvestigationName", typeof(System.String));
            _datatable.Columns.Add("DisplayText", typeof(System.String));
            _datatable.Columns.Add("BillingName", typeof(System.String));
            _datatable.Columns.Add("DeptID", typeof(System.Int32));
            _datatable.Columns.Add("SampleCode", typeof(System.Int32));
            _datatable.Columns.Add("MethodID", typeof(System.Int64));
            _datatable.Columns.Add("PrincipleID", typeof(System.Int64));
            _datatable.Columns.Add("Interpretation", typeof(System.String));
            _datatable.Columns.Add("SampleContainerID", typeof(System.Int32));
            _datatable.Columns.Add("ProcessingAddressID", typeof(System.Int32));
            _datatable.Columns.Add("AutoApproveLoginID", typeof(System.Int64));
            _datatable.Columns.Add("ResultValueType", typeof(System.String));
            _datatable.Columns.Add("CPT", typeof(System.Decimal));
            _datatable.Columns.Add("CPRT", typeof(System.Decimal));
            _datatable.Columns.Add("DecimalPlaces", typeof(System.String));
            _datatable.Columns.Add("CutOffTimeValue", typeof(System.Int32));
            _datatable.Columns.Add("CutOffTimeType", typeof(System.String));
            _datatable.Columns.Add("Classification", typeof(System.String));
            _datatable.Columns.Add("SubCategory", typeof(System.String));
            _datatable.Columns.Add("IsOrderable", typeof(System.String));
            _datatable.Columns.Add("QCData", typeof(System.String));
            _datatable.Columns.Add("IsInterfaced", typeof(System.String));
            _datatable.Columns.Add("IsSMS", typeof(System.String));
            _datatable.Columns.Add("IsServiceTax", typeof(System.String));
            _datatable.Columns.Add("IsNABL", typeof(System.String));
            _datatable.Columns.Add("IsCAP", typeof(System.String));
            _datatable.Columns.Add("IsDiscountable", typeof(System.String));
            _datatable.Columns.Add("IsRepeatable", typeof(System.String));
            _datatable.Columns.Add("IsSTAT", typeof(System.String));
            _datatable.Columns.Add("IsActive", typeof(System.String));
            _datatable.Columns.Add("Category", typeof(System.String));
            _datatable.Columns.Add("Gender", typeof(System.String));
            _datatable.Columns.Add("IsNonReportable", typeof(System.String));
            _datatable.Columns.Add("PrintSeparately", typeof(System.String));
            _datatable.Columns.Add("HeaderID", typeof(System.Int64));
            _datatable.Columns.Add("GetWorkList", typeof(System.String));
            _datatable.Columns.Add("IsTATrandom", typeof(System.Int16));
            _datatable.Columns.Add("ProtocalGroupID", typeof(System.Int32));
            _datatable.Columns.Add("ReferenceRangeString", typeof(System.String));
            _datatable.Columns.Add("IsSynoptic", typeof(System.String));
			_datatable.Columns.Add("IsFieldTest", typeof(System.String));
			            _datatable.Columns.Add("PreAnalyticalConditionId", typeof(System.Int16));
            _datatable.Columns.Add("PostAnalyticalConditionId", typeof(System.Int16));
            _datatable.Columns.Add("IsSensitiveTest", typeof(System.String));
			_datatable.Columns.Add("OutputGroupingCode", typeof(System.String));
            _datatable.Columns.Add("IsAutoCertification", typeof(System.String));
            _datatable.Columns.Add("ShowGroupInstruction", typeof(System.Boolean));
            DataRow _datarow;


            _datarow = _datatable.NewRow();
            _datarow["OrgID"] = _list.OrgID;
            _datarow["InvestigationID"] = _list.InvestigationID;
            _datarow["InvestigationName"] = _list.InvestigationName;
            _datarow["DisplayText"] = _list.DisplayText;
            _datarow["BillingName"] = _list.BillingName;
            _datarow["DeptID"] = _list.DeptID;
            _datarow["SampleCode"] = _list.SampleCode;
            _datarow["MethodID"] = _list.MethodID;
            _datarow["PrincipleID"] = _list.PrincipleID;
            _datarow["Interpretation"] = _list.Interpretation;
            _datarow["SampleContainerID"] = _list.SampleContainerID;
            _datarow["ProcessingAddressID"] = _list.ProcessingAddressID;
            _datarow["AutoApproveLoginID"] = _list.AutoApproveLoginID;
            _datarow["ResultValueType"] = _list.ResultValueType;
            _datarow["CPT"] = _list.CPT;
            _datarow["CPRT"] = _list.CPRT;
            _datarow["DecimalPlaces"] = _list.DecimalPlaces;
            _datarow["CutOffTimeValue"] = _list.CutOffTimeValue;
            _datarow["CutOffTimeType"] = _list.CutOffTimeType;
            _datarow["Classification"] = _list.Classification;
            _datarow["SubCategory"] = _list.SubCategory;
            _datarow["IsOrderable"] = _list.IsOrderable;
            _datarow["QCData"] = _list.QCData;
            _datarow["IsInterfaced"] = _list.IsInterfaced;
            _datarow["IsSMS"] = _list.IsSMS;
            _datarow["IsServiceTax"] = _list.IsServiceTax;
            _datarow["IsNABL"] = _list.IsNABL;
            _datarow["IsCAP"] = _list.IsCAP;
            _datarow["IsDiscountable"] = _list.IsDiscountable;
            _datarow["IsRepeatable"] = _list.IsRepeatable;
            _datarow["IsSTAT"] = _list.IsSTAT;
            _datarow["IsActive"] = _list.IsActive;
            _datarow["Category"] = _list.Category;
            _datarow["Gender"] = _list.Gender;
            _datarow["IsNonReportable"] = _list.IsNonReportable;
            _datarow["PrintSeparately"] = _list.PrintSeparately;
            _datarow["HeaderID"] = _list.HeaderID;
            _datarow["GetWorkList"] = _list.GetWorkList;
            _datarow["IsTATrandom"] = _list.IsTATrandom;
            _datarow["ProtocalGroupID"] = _list.ProtocalGroupID;
            _datarow["ReferenceRangeString"] = _list.ReferenceRangeString;
            _datarow["IsSynoptic"] = _list.IsSynoptic;
			_datarow["IsFieldTest"] = _list.IsFieldTest;
			 _datarow["PreAnalyticalConditionId"] = _list.PreSampleConditionID;
            _datarow["PostAnalyticalConditionId"] = _list.PostSampleConditionID;
            _datarow["IsSensitiveTest"] = _list.IsSensitiveTest;
			_datarow["OutputGroupingCode"] = _list.OutputGroupingCode;
            _datarow["IsAutoCertification"] = _list.IsAutoCertification;
            _datarow["ShowGroupInstruction"] = _list.ShowGroupInstruction;
            _datatable.Rows.Add(_datarow);
            return _datatable;
        }
        public static System.Data.DataTable ConvertToInvRemarks(List<InvRemarks> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("RemarksID", typeof(System.Int64));
            _datatable.Columns.Add("RoleID", typeof(System.Int64));

            DataRow _datarow;

            foreach (InvRemarks _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["RemarksID"] = _list.RemarksID;
                _datarow["RoleID"] = _list.RoleID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToInvOrgReferenceMapping(List<InvOrgReferenceMapping> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ID", typeof(System.Int64));
            _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("InstrumentID", typeof(System.Int64));
            _datatable.Columns.Add("KitID", typeof(System.Int64));
            _datatable.Columns.Add("UOMID", typeof(System.Int32));
            _datatable.Columns.Add("UOMCode", typeof(System.String));
            _datatable.Columns.Add("ReferenceRange", typeof(System.String));
            _datatable.Columns.Add("IsPrimary", typeof(System.String));
            _datatable.Columns.Add("IsActive", typeof(System.String));
            _datatable.Columns.Add("ClientID", typeof(System.Int32));
            _datatable.Columns.Add("TestCode", typeof(System.String));
            _datatable.Columns.Add("InstrumentCode", typeof(System.String));
            _datatable.Columns.Add("ReasonCode", typeof(System.String));
            _datatable.Columns.Add("DeviceMappingID", typeof(System.Int64));
            _datatable.Columns.Add("CONV_UOMID", typeof(System.Int32));
            _datatable.Columns.Add("CONV_UOMCode", typeof(System.String));
            _datatable.Columns.Add("CONV_Factor", typeof(System.Decimal));
            _datatable.Columns.Add("ConvFac_DecimalPoint", typeof(System.Int32));


            DataRow _datarow;

            foreach (InvOrgReferenceMapping _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ID"] = _list.ID;
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["InstrumentID"] = _list.InstrumentID;
                _datarow["KitID"] = _list.KitID;
                _datarow["UOMID"] = _list.UOMID;
                _datarow["UOMCode"] = _list.UOMCode;
                _datarow["ReferenceRange"] = _list.ReferenceRange;
                _datarow["IsPrimary"] = _list.IsPrimary;
                _datarow["IsActive"] = _list.IsActive;
                _datarow["ClientID"] = _list.ClientID;
                _datarow["TestCode"] = _list.TestCode;
                _datarow["InstrumentCode"] = _list.InstrumentCode;
                _datarow["ReasonCode"] = _list.ReasonCode;
                _datarow["DeviceMappingID"] = _list.DeviceMappingID;
                _datarow["CONV_UOMID"] = _list.CONV_UOMID;
                _datarow["CONV_UOMCode"] = _list.CONV_UOMCode;
                _datarow["CONV_Factor"] = _list.CONV_Factor;
                _datarow["ConvFac_DecimalPoint"] = _list.ConvFac_DecimalPoint;

                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTInvestigationLocationMapping(InvestigationLocationMapping _list)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("LocationID", typeof(System.Int32));
            _datatable.Columns.Add("ProcessingOrgID", typeof(System.Int64));
            _datatable.Columns.Add("ProcessingAddressID", typeof(System.Int32));
            _datatable.Columns.Add("Type", typeof(System.String));

            DataRow _datarow;


            _datarow = _datatable.NewRow();
            _datarow["InvestigationID"] = _list.InvestigationID;
            _datarow["OrgID"] = _list.OrgID;
            _datarow["LocationID"] = _list.LocationID;
            _datarow["ProcessingOrgID"] = _list.ProcessingOrgID;
            _datarow["ProcessingAddressID"] = _list.ProcessingAddressID;
            _datarow["Type"] = _list.Type;
            _datatable.Rows.Add(_datarow);

            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToPatientOldNotesFileMapping(List<PatientOldNotesFileMapping> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("FileID", typeof(System.Int64));
            _datatable.Columns.Add("PatienOldNotesID", typeof(System.Int64));

            DataRow _datarow;

            foreach (PatientOldNotesFileMapping _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["FileID"] = _list.FileID;
                _datarow["PatienOldNotesID"] = _list.PatienOldNotesID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToBelongDetails(List<BelongingsHandoverDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("BelongingDescription", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));

            DataRow _datarow;

            foreach (BelongingsHandoverDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["BelongingDescription"] = _list.BelongingDescription;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToBillingDetailTablesWFT(List<SaveBillingDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ID", typeof(System.Int64));
            _datatable.Columns.Add("Amount", typeof(System.Decimal));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("IsGroup", typeof(System.String));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("Quantity", typeof(System.Decimal));
            _datatable.Columns.Add("Rate", typeof(System.Decimal));
            _datatable.Columns.Add("FeeType", typeof(System.String));
            _datatable.Columns.Add("IsReimbursable", typeof(System.String));
            _datatable.Columns.Add("IsTaxable", typeof(System.String));
            _datatable.Columns.Add("ServiceCode", typeof(System.String));

            DataRow _datarow;

            foreach (SaveBillingDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ID"] = _list.ID;
                _datarow["Amount"] = _list.Amount;
                _datarow["Description"] = _list.Description;
                _datarow["IsGroup"] = _list.IsGroup;
                _datarow["Status"] = _list.Status;
                _datarow["Quantity"] = _list.Quantity;
                _datarow["Rate"] = _list.Rate;
                _datarow["FeeType"] = _list.FeeType;
                _datarow["IsReimbursable"] = _list.IsReimbursable;
                _datarow["IsTaxable"] = _list.IsTaxable;
                _datarow["ServiceCode"] = _list.ServiceCode;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToMultiplePageContextkey(List<PageContextkey> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PageID", typeof(System.Int64));
            _datatable.Columns.Add("ButtonName", typeof(System.String));
            _datatable.Columns.Add("RoleID", typeof(System.Int64));
            _datatable.Columns.Add("PatientID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("RedirectURL", typeof(System.String));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("ActionType", typeof(System.String));
            _datatable.Columns.Add("ID", typeof(System.Int64));
            _datatable.Columns.Add("ContextType", typeof(System.String));
            _datatable.Columns.Add("ButtonValue", typeof(System.String));

            DataRow _datarow;

            foreach (PageContextkey _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PageID"] = _list.PageID;
                _datarow["ButtonName"] = _list.ButtonName;
                _datarow["RoleID"] = _list.RoleID;
                _datarow["PatientID"] = _list.PatientID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["RedirectURL"] = _list.RedirectURL;
                _datarow["Description"] = _list.Description;
                _datarow["ActionType"] = _list.ActionType;
                _datarow["ID"] = _list.ID;
                _datarow["ContextType"] = _list.ContextType;
                _datarow["ButtonValue"] = _list.ButtonValue;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToCashFlowDetails(List<CashFlowTransactions> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("CashFlowTransactionID", typeof(System.Int64));
            _datatable.Columns.Add("CashFlowID", typeof(System.Int64));
            _datatable.Columns.Add("ReferenceID", typeof(System.Int64));
            _datatable.Columns.Add("ReferenceType", typeof(System.String));
            _datatable.Columns.Add("InvoiceNo", typeof(System.String));
            _datatable.Columns.Add("AmountPaid", typeof(System.Decimal));

            DataRow _datarow;

            foreach (CashFlowTransactions _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["CashFlowTransactionID"] = _list.CashFlowTransactionID;
                _datarow["CashFlowID"] = _list.CashFlowID;
                _datarow["ReferenceID"] = _list.ReferenceID;
                _datarow["ReferenceType"] = _list.ReferenceType;
                _datarow["InvoiceNo"] = _list.InvoiceNo;
                _datarow["AmountPaid"] = _list.AmountPaid;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToPatientReferring(List<PatientReferringDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("RefPhysicianID", typeof(System.Int64));
            _datatable.Columns.Add("RefPhyName", typeof(System.String));
            _datatable.Columns.Add("ReferenceType", typeof(System.String));
            _datatable.Columns.Add("FeeType", typeof(System.String));
            _datatable.Columns.Add("FeeID", typeof(System.Int64));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("Comments", typeof(System.String));
            _datatable.Columns.Add("PerphyID", typeof(System.Int64));
            _datatable.Columns.Add("Perphyname", typeof(System.String));

            DataRow _datarow;

            foreach (PatientReferringDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["RefPhysicianID"] = _list.RefPhysicianID;
                _datarow["RefPhyName"] = _list.RefPhyName;
                _datarow["ReferenceType"] = _list.ReferenceType;
                _datarow["FeeType"] = _list.FeeType;
                _datarow["FeeID"] = _list.FeeID;
                _datarow["Description"] = _list.Description;
                _datarow["Status"] = _list.Status;
                _datarow["Comments"] = _list.Comments;
                _datarow["PerphyID"] = _list.PerphyID;
                _datarow["Perphyname"] = _list.Perphyname;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTPatientDueDetails(List<PatientDueDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientDueID", typeof(System.Int64));
            _datatable.Columns.Add("PatientID", typeof(System.Int64));
            _datatable.Columns.Add("VisitID", typeof(System.Int64));
            _datatable.Columns.Add("FinalBillID", typeof(System.Int64));
            _datatable.Columns.Add("PatientNumber", typeof(System.String));
            _datatable.Columns.Add("PatientName", typeof(System.String));
            _datatable.Columns.Add("DueAmount", typeof(System.Decimal));
            _datatable.Columns.Add("DuePaidAmt", typeof(System.Decimal));
            _datatable.Columns.Add("ExistingDueAmt", typeof(System.Decimal));
            _datatable.Columns.Add("Discount", typeof(System.Decimal));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("ReceiptNo", typeof(System.String));
            _datatable.Columns.Add("IsCreditBill", typeof(System.String));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("WriteOffAmt", typeof(System.Decimal));

            DataRow _datarow;

            foreach (PatientDueDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientDueID"] = _list.PatientDueID;
                _datarow["PatientID"] = _list.PatientID;
                _datarow["VisitID"] = _list.VisitID;
                _datarow["FinalBillID"] = _list.FinalBillID;
                _datarow["PatientNumber"] = _list.PatientNumber;
                _datarow["PatientName"] = _list.PatientName;
                _datarow["DueAmount"] = _list.DueAmount;
                _datarow["DuePaidAmt"] = _list.DuePaidAmt;
                _datarow["ExistingDueAmt"] = _list.ExistingDue;
                _datarow["Discount"] = _list.DiscountAmt;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["ReceiptNo"] = _list.BillNo;
                _datarow["IsCreditBill"] = _list.IsCreditBill;
                _datarow["Status"] = _list.Status;
                _datarow["WriteOffAmt"] = _list.WriteOffAmt;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTPatientDueChartForIP(List<ClientFeeTypeRateCustomization> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("FeeType", typeof(System.String));
            _datatable.Columns.Add("FeeID", typeof(System.Int64));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("Comments", typeof(System.String));
            _datatable.Columns.Add("FromDate", typeof(System.DateTime));
            _datatable.Columns.Add("ToDate", typeof(System.DateTime));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("unit", typeof(System.Decimal));
            _datatable.Columns.Add("Amount", typeof(System.Decimal));
            _datatable.Columns.Add("DetailsID", typeof(System.Int64));
            _datatable.Columns.Add("PackageID", typeof(System.Int64));
            _datatable.Columns.Add("FromTable", typeof(System.String));
            _datatable.Columns.Add("DiscountAmount", typeof(System.Decimal));
            _datatable.Columns.Add("IsReimbursable", typeof(System.String));
            _datatable.Columns.Add("IsTaxable", typeof(System.String));
            _datatable.Columns.Add("ServiceCode", typeof(System.String));
            _datatable.Columns.Add("DiscountPercent", typeof(System.Decimal));
            _datatable.Columns.Add("DiscOrEnhanceType", typeof(System.String));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            _datatable.Columns.Add("ReimbursableAmount", typeof(System.Decimal));
            _datatable.Columns.Add("NonReimbursableAmount", typeof(System.Decimal));
            _datatable.Columns.Add("ActualAmount", typeof(System.Decimal));
            _datatable.Columns.Add("RateID", typeof(System.Int64));
            _datatable.Columns.Add("IsDiscountable", typeof(System.String));
            _datatable.Columns.Add("IsSTAT", typeof(System.String));
            _datatable.Columns.Add("IsOutSource", typeof(System.String));
            _datatable.Columns.Add("IsNABL", typeof(System.String));

            DataRow _datarow;

            foreach (ClientFeeTypeRateCustomization _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["FeeType"] = _list.FeeType;
                _datarow["FeeID"] = _list.FeeTypeId;
                _datarow["Description"] = _list.RoomType;
                _datarow["Comments"] = "";
                _datarow["FromDate"] = DateTime.Now;
                _datarow["ToDate"] = DateTime.Now;
                _datarow["Status"] = _list.ClientType;
                _datarow["unit"] = 1;
                _datarow["Amount"] = 0;
                _datarow["DetailsID"] = _list.ClientID;
                _datarow["PackageID"] = 0;
                _datarow["SpecialityID"] = _list.RoomTypeID;
                _datarow["UserID"] = 0;
                _datarow["DiscountAmount"] = 0;
                _datarow["IsReimbursable"] = "";
                _datarow["IsTaxable"] = "";
                _datarow["ServiceCode"] = _list.ClientName;
                _datarow["DiscountPercent"] = _list.DiscOrEnhancePercent;
                _datarow["DiscOrEnhanceType"] = _list.DiscOrEnhanceType;
                _datarow["Remarks"] = _list.Applyby;
                _datarow["ReimbursableAmount"] = 0;
                _datarow["NonReimbursableAmount"] = 0;
                _datarow["ActualAmount"] = 0;
                _datarow["RateID"] = 0;
                _datarow["IsDiscountable"] = "N";
                _datarow["IsSTAT"] = "N";
                _datarow["IsOutSource"] = "N";
                _datarow["IsNABL"] = "N";
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTPatientDueChart(List<ClientFeeTypeRateCustomization> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("FeeType", typeof(System.String));
            _datatable.Columns.Add("FeeID", typeof(System.Int64));
            _datatable.Columns.Add("Description", typeof(System.String));
            _datatable.Columns.Add("Comments", typeof(System.String));
            _datatable.Columns.Add("FromDate", typeof(System.DateTime));
            _datatable.Columns.Add("ToDate", typeof(System.DateTime));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("unit", typeof(System.Decimal));
            _datatable.Columns.Add("Amount", typeof(System.Decimal));
            _datatable.Columns.Add("DetailsID", typeof(System.Int64));
            _datatable.Columns.Add("PackageID", typeof(System.Int64));
            _datatable.Columns.Add("SpecialityID", typeof(System.Int32));
            _datatable.Columns.Add("UserID", typeof(System.Int64));
            _datatable.Columns.Add("DiscountAmount", typeof(System.Decimal));
            _datatable.Columns.Add("IsReimbursable", typeof(System.String));
            _datatable.Columns.Add("IsTaxable", typeof(System.String));
            _datatable.Columns.Add("ServiceCode", typeof(System.String));
            _datatable.Columns.Add("DiscountPercent", typeof(System.Decimal));
            _datatable.Columns.Add("DiscOrEnhanceType", typeof(System.String));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            _datatable.Columns.Add("ReimbursableAmount", typeof(System.Decimal));
            _datatable.Columns.Add("NonReimbursableAmount", typeof(System.Decimal));
            _datatable.Columns.Add("ActualAmount", typeof(System.Decimal));
            _datatable.Columns.Add("RateID", typeof(System.Int64));
            _datatable.Columns.Add("IsDiscountable", typeof(System.String));
            _datatable.Columns.Add("IsSTAT", typeof(System.String));
            _datatable.Columns.Add("IsOutSource", typeof(System.String));
            _datatable.Columns.Add("IsNABL", typeof(System.String));

            DataRow _datarow;

            foreach (ClientFeeTypeRateCustomization _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["FeeType"] = _list.FeeType;
                _datarow["FeeID"] = _list.FeeTypeId;
                _datarow["Description"] = _list.RoomType;
                _datarow["Comments"] = "";
                _datarow["FromDate"] = DateTime.Now;
                _datarow["ToDate"] = DateTime.Now;
                _datarow["Status"] = _list.ClientType;
                _datarow["unit"] = 1;
                _datarow["Amount"] = 0;
                _datarow["DetailsID"] = _list.ClientID;
                _datarow["PackageID"] = 0;
                _datarow["SpecialityID"] = _list.RoomTypeID;
                _datarow["UserID"] = 0;
                _datarow["DiscountAmount"] = 0;
                _datarow["IsReimbursable"] = "";
                _datarow["IsTaxable"] = "";
                _datarow["ServiceCode"] = _list.ClientName;
                _datarow["DiscountPercent"] = _list.DiscOrEnhancePercent;
                _datarow["DiscOrEnhanceType"] = _list.DiscOrEnhanceType;
                _datarow["Remarks"] = _list.Applyby;
                _datarow["ReimbursableAmount"] = 0;
                _datarow["NonReimbursableAmount"] = 0;
                _datarow["ActualAmount"] = 0;
                _datarow["RateID"] = 0;
                _datarow["IsDiscountable"] = "N";
                _datarow["IsSTAT"] = "N";
                _datarow["IsOutSource"] = "N";
                _datarow["IsNABL"] = "N";


                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTAmtRecDetailsUpdate(List<AmountReceivedDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("AmtReceivedID", typeof(System.Int64));
            _datatable.Columns.Add("AmtReceived", typeof(System.Decimal));
            _datatable.Columns.Add("TypeID", typeof(System.Int32));
            _datatable.Columns.Add("ChequeorCardNumber", typeof(System.String));
            _datatable.Columns.Add("BankNameorCardType", typeof(System.String));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            _datatable.Columns.Add("ServiceCharge", typeof(System.Decimal));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ChequeValidDate", typeof(System.DateTime));
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

            DataRow _datarow;

            foreach (AmountReceivedDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["AmtReceivedID"] = _list.AmtReceivedID;
                _datarow["AmtReceived"] = _list.AmtReceived;
                _datarow["TypeID"] = _list.TypeID;
                _datarow["ChequeorCardNumber"] = _list.ChequeorCardNumber;
                _datarow["BankNameorCardType"] = _list.BankNameorCardType;
                _datarow["Remarks"] = _list.Remarks;
                _datarow["ServiceCharge"] = _list.ServiceCharge;
                _datarow["ModifiedBy"] = _list.ModifiedBy;

                _datarow["ChequeValidDate"] = _list.ChequeValidDate;
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


                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTTasks(List<Tasks> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("TaskActionID", typeof(System.Int32));
            _datatable.Columns.Add("TaskDescription", typeof(System.String));
            _datatable.Columns.Add("RedirectURL", typeof(System.String));
            _datatable.Columns.Add("PatientID", typeof(System.Int64));
            _datatable.Columns.Add("AssignedTo", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("ParentID", typeof(System.Int64));
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("HighlightColor", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("SpecialityID", typeof(System.Int32));
            _datatable.Columns.Add("AllowDuplicate", typeof(System.String));

            DataRow _datarow;

            foreach (Tasks _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["TaskActionID"] = _list.TaskActionID;
                _datarow["TaskDescription"] = _list.TaskDescription;
                _datarow["RedirectURL"] = _list.RedirectURL;
                _datarow["PatientID"] = _list.PatientID;
                _datarow["AssignedTo"] = _list.AssignedTo;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["ParentID"] = _list.ParentID;
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["HighlightColor"] = _list.HighlightColor;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["SpecialityID"] = _list.SpecialityID;
                _datarow["AllowDuplicate"] = _list.AllowDuplicate;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTServiceCode(List<BillingDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("FinalBillID", typeof(System.Int64));
            _datatable.Columns.Add("BillingDetailsID", typeof(System.Int64));
            _datatable.Columns.Add("ServiceCode", typeof(System.String));
            _datatable.Columns.Add("DisplayText", typeof(System.String));
            _datatable.Columns.Add("ClientID", typeof(System.Int64));
            _datatable.Columns.Add("DummyString", typeof(System.String));

            DataRow _datarow;

            foreach (BillingDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["FinalBillID"] = _list.FinalBillID;
                _datarow["BillingDetailsID"] = _list.BillingDetailsID;
                _datarow["ServiceCode"] = _list.ServiceCode;
                _datarow["DisplayText"] = _list.FeeDescription;
                _datarow["ClientID"] = _list.ClientID;
                _datarow["DummyString"] = _list.FORENAME;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTInvoice(List<Invoice> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("FinalBillID", typeof(System.Int64));
            _datatable.Columns.Add("ClientID", typeof(System.Int64));
            _datatable.Columns.Add("InvoiceID", typeof(System.Int64));
            _datatable.Columns.Add("InvoiceNo", typeof(System.String));
            _datatable.Columns.Add("RefID", typeof(System.Int64));
            _datatable.Columns.Add("RefType", typeof(System.String));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("Reason", typeof(System.String));

            DataRow _datarow;

            foreach (Invoice _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["FinalBillID"] = _list.FinalBillID;
                _datarow["ClientID"] = _list.ClientID;
                _datarow["InvoiceID"] = _list.InvoiceID;
                _datarow["InvoiceNo"] = _list.InvoiceNumber;
                _datarow["RefID"] = _list.RefID;
                _datarow["RefType"] = _list.RefType;
                _datarow["Status"] = _list.Status;
                _datarow["Reason"] = _list.Reason;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTInvoiceReceipts(List<InvoiceReceipts> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("InvoiceID", typeof(System.Int64));
            _datatable.Columns.Add("InvoiceAmount", typeof(System.Decimal));
            _datatable.Columns.Add("ReceivedAmount", typeof(System.Decimal));
            _datatable.Columns.Add("PaymentTypeID", typeof(System.Int32));
            _datatable.Columns.Add("ChequeorCardNumber", typeof(System.String));
            _datatable.Columns.Add("BankNameorCardType", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("OrgAddID", typeof(System.Int32));
            _datatable.Columns.Add("WriteOffAmt", typeof(System.Decimal));
            _datatable.Columns.Add("RoundOffAmt", typeof(System.Decimal));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("WriteOffReason", typeof(System.String));
            _datatable.Columns.Add("CreditAmount", typeof(System.Decimal));
            _datatable.Columns.Add("ChequeDate", typeof(System.DateTime));
            _datatable.Columns.Add("ChequeImage", typeof(System.String));
            _datatable.Columns.Add("DiscountAmount", typeof(System.Decimal));
            _datatable.Columns.Add("TDSAmount", typeof(System.Decimal));


            DataRow _datarow;

            foreach (InvoiceReceipts _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["InvoiceID"] = _list.InvoiceID;
                _datarow["InvoiceAmount"] = _list.InvoiceAmount;
                _datarow["ReceivedAmount"] = _list.ReceivedAmount;
                _datarow["PaymentTypeID"] = _list.PaymentTypeID;
                _datarow["ChequeorCardNumber"] = _list.ChequeorCardNumber;
                _datarow["BankNameorCardType"] = _list.BankNameorCardType;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["OrgAddID"] = _list.OrgAddID;
                _datarow["WriteOffAmt"] = _list.WriteOffAmt;
                _datarow["RoundOffAmt"] = _list.RoundOffAmt;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["Status"] = _list.Status;
                _datarow["WriteOffReason"] = _list.WriteOffReason;
                _datarow["CreditAmount"] = _list.CreditAmount;
                _datarow["ChequeDate"] = _list.ChequeDate;
                _datarow["ChequeImage"] = _list.ChequeImage;
                _datarow["DiscountAmount"] = _list.DiscountAmount;
                _datarow["TDSAmount"] = _list.TDSAmount;

                

                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTCashClosureDenomination(List<CashClosureDenomination> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("DenominationID", typeof(System.Int64));
            _datatable.Columns.Add("Unit", typeof(System.Decimal));
            _datatable.Columns.Add("Amount", typeof(System.Decimal));
            _datatable.Columns.Add("LoginID", typeof(System.Int64));

            DataRow _datarow;

            foreach (CashClosureDenomination _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["DenominationID"] = _list.DenominationID;
                _datarow["Unit"] = _list.Unit;
                _datarow["Amount"] = _list.Amount;
                _datarow["LoginID"] = _list.LoginID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUpdateAndInsertDueTable(List<DuePaidDetail> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("DueBillNo", typeof(System.Int64));
            _datatable.Columns.Add("BillAmount", typeof(System.Decimal));
            _datatable.Columns.Add("PaidAmount", typeof(System.Decimal));
            _datatable.Columns.Add("PaidBillNo", typeof(System.Int64));
            _datatable.Columns.Add("PaidDate", typeof(System.DateTime));
            _datatable.Columns.Add("CollectedBy", typeof(System.Int64));
            _datatable.Columns.Add("DisCountAmt", typeof(System.Decimal));

            DataRow _datarow;

            foreach (DuePaidDetail _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["DueBillNo"] = _list.DueBillNo;
                _datarow["BillAmount"] = _list.BillAmount;
                _datarow["PaidAmount"] = _list.PaidAmount;
                _datarow["PaidBillNo"] = _list.PaidBillNo;
                _datarow["PaidDate"] = _list.PaidDate;
                _datarow["CollectedBy"] = _list.DueCollectedBy;
                _datarow["DisCountAmt"] = _list.DiscountAmt;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToInvSummaryReport(InvSummaryReport _list)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ResultSummary", typeof(System.String));
            _datatable.Columns.Add("ClinicalInterpretation", typeof(System.String));
            _datatable.Columns.Add("Suggestions", typeof(System.String));
            _datatable.Columns.Add("Comments", typeof(System.String));
            _datatable.Columns.Add("ShowTRF", typeof(System.Boolean));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("VisitID", typeof(System.Int64));

            DataRow _datarow;


            _datarow = _datatable.NewRow();
            _datarow["ResultSummary"] = _list.ResultSummary;
            _datarow["ClinicalInterpretation"] = _list.ClinicalInterpretation;
            _datarow["Suggestions"] = _list.Suggestions;
            _datarow["Comments"] = _list.Comments;
            _datarow["ShowTRF"] = _list.ShowTRF;
            _datarow["OrgID"] = _list.OrgID;
            _datarow["VisitID"] = _list.VisitID;
            _datatable.Rows.Add(_datarow);

            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToInvSummaryTrend(List<InvSummaryTrend> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("TrendInvId", typeof(System.String));
            _datatable.Columns.Add("Content", typeof(System.Byte[]));

            DataRow _datarow;

            foreach (InvSummaryTrend _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["TrendInvId"] = _list.TrendInvId;
                _datarow["Content"] = _list.Content;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToUDTDisPatchMode(List<PatientDisPatchDetails> _lstCollection)
        {
            System.Data.DataTable _dataTable = new System.Data.DataTable();
            _dataTable.Columns.Add("DispatchType", typeof(System.String));
            _dataTable.Columns.Add("DispatchValue", typeof(System.String));
            DataRow _dataRow;
            foreach (PatientDisPatchDetails _list in _lstCollection)
            {
                _dataRow = _dataTable.NewRow();
                _dataRow["DispatchType"] = _list.DispatchType;
                _dataRow["DispatchValue"] = _list.DispatchValue;
                _dataTable.Rows.Add(_dataRow);
            }
            return _dataTable;
        }
        public static System.Data.DataTable ConvertToInvHistoryAttributes(List<InvHistoryAttributes> _lstCollection)
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

            foreach (InvHistoryAttributes _list in _lstCollection)
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
        public static System.Data.DataTable ConvertToUDT_Conxt(List<ResultSearch> search)
        {
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("OrgID", typeof(System.Int64));
            _datatable.Columns.Add("VisitNumber", typeof(System.String));
            _datatable.Columns.Add("ClientName", typeof(System.String));
            _datatable.Columns.Add("FromDate", typeof(System.DateTime));
            _datatable.Columns.Add("ToDate", typeof(System.DateTime));

            _datatable.Columns.Add("VisitDate", typeof(System.DateTime));
            _datatable.Columns.Add("Name", typeof(System.String));
            _datatable.Columns.Add("FeeDescription", typeof(System.String));
            _datatable.Columns.Add("FeeType", typeof(System.String));
            _datatable.Columns.Add("Amount", typeof(System.Decimal));


            _datatable.Columns.Add("MAmount", typeof(System.Decimal));
            _datatable.Columns.Add("RateCard", typeof(System.String));
            _datatable.Columns.Add("MRatecard", typeof(System.String));
            _datatable.Columns.Add("BaseAmount", typeof(System.Decimal));
            _datatable.Columns.Add("MBaseAmount", typeof(System.Decimal));

            _datatable.Columns.Add("BaseRateCard", typeof(System.String));
            _datatable.Columns.Add("MBaseRatecard", typeof(System.String));
            _datatable.Columns.Add("DiscounCategory", typeof(System.String));
            _datatable.Columns.Add("MDiscounCategory", typeof(System.String));
            _datatable.Columns.Add("DiscountPolicy", typeof(System.String));

            _datatable.Columns.Add("MDiscountPolicy", typeof(System.String));
            _datatable.Columns.Add("FinalBillID", typeof(System.Int64));
            _datatable.Columns.Add("RateID", typeof(System.Int64));
            _datatable.Columns.Add("MRateID", typeof(System.Int64));
            _datatable.Columns.Add("BaseRateID", typeof(System.Int64));

            _datatable.Columns.Add("MBaseRateID", typeof(System.Int64));
            _datatable.Columns.Add("DiscountPolicyID", typeof(System.Int64));
            _datatable.Columns.Add("MDiscountPolicyID", typeof(System.Int64));
            _datatable.Columns.Add("DiscountPercentage", typeof(System.Int64));
            _datatable.Columns.Add("BillingDetailsID", typeof(System.Int64));

            DataRow _datarow;

            foreach (ResultSearch _list in search)
            {
                _datarow = _datatable.NewRow();
                _datarow["FromDate"] = _list.FromDate;
                _datarow["ToDate"] = _list.ToDate;
                _datarow["OrgID"] = _list.OrgId;
                _datarow["ClientName"] = _list.Name;
                _datarow["VisitNumber"] = _list.VisitNumber;


                _datarow["VisitDate"] = _list.VisitDate;
                _datarow["Name"] = _list.Name;
                _datarow["FeeDescription"] = _list.FeeDescription;
                _datarow["FeeType"] = _list.FeeType;
                _datarow["Amount"] = _list.Amount;

                _datarow["MAmount"] = _list.MAmount;
                _datarow["RateCard"] = _list.RateCard;
                _datarow["MRatecard"] = _list.MRatecard;
                _datarow["BaseAmount"] = _list.BaseAmount;
                _datarow["MBaseAmount"] = _list.MBaseAmount;

                _datarow["BaseRateCard"] = _list.BaseRateCard;
                _datarow["MBaseRatecard"] = _list.MBaseRatecard;
                _datarow["DiscounCategory"] = _list.DiscounCategory;
                _datarow["MDiscounCategory"] = _list.MDiscounCategory;
                _datarow["DiscountPolicy"] = _list.DiscountPolicy;

                _datarow["MDiscountPolicy"] = _list.MDiscountPolicy;
                _datarow["BillingDetailsID"] = _list.BillingDetailsID;
                _datarow["FinalBillID"] = _list.FinalBillID;
                _datarow["RateID"] = _list.RateID;
                _datarow["MRateID"] = _list.MRateID;

                _datarow["BaseRateID"] = _list.BaseRateID;
                _datarow["MBaseRateID"] = _list.MBaseRateID;
                _datarow["DiscountPolicyID"] = _list.DiscountPolicyID;
                _datarow["MDiscountPolicyID"] = _list.MDiscountPolicyID;
                _datarow["DiscountPercentage"] = _list.DiscountPercentage;




                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }

        public static System.Data.DataTable ConvertToUDT_Context(ContextDetails _Context)
        {
            System.Data.DataTable _datatable = new System.Data.DataTable();
            //
            _datatable.Columns.Add("OrgID", typeof(System.Int64));
            _datatable.Columns.Add("OrgName", typeof(System.String));
            _datatable.Columns.Add("LogoPath", typeof(System.String));
            _datatable.Columns.Add("OrgAddressID", typeof(System.Int64));
            _datatable.Columns.Add("RoleID", typeof(System.Int64));
            _datatable.Columns.Add("RoleName", typeof(System.String));
            _datatable.Columns.Add("UserID", typeof(System.Int64));
            _datatable.Columns.Add("LoginID", typeof(System.Int64));
            _datatable.Columns.Add("LoginName", typeof(System.String));
            _datatable.Columns.Add("Age", typeof(System.String));
            _datatable.Columns.Add("LocationID", typeof(System.Int64));
            _datatable.Columns.Add("PharmacyLocationID", typeof(System.Int64));
            _datatable.Columns.Add("IsTrustedOrg", typeof(System.String));
            _datatable.Columns.Add("BaseCurrency", typeof(System.String));
            _datatable.Columns.Add("CurrencyFormat", typeof(System.String));
            _datatable.Columns.Add("ThemeID", typeof(System.Int64));
            _datatable.Columns.Add("CountryID", typeof(System.Int16));
            _datatable.Columns.Add("StateID", typeof(System.Int16));
            _datatable.Columns.Add("LanguageCode", typeof(System.String));
            _datatable.Columns.Add("PageID", typeof(System.Int64));
            _datatable.Columns.Add("SessionID", typeof(System.String));
            _datatable.Columns.Add("DepartmentName", typeof(System.String));
            _datatable.Columns.Add("AdditionalInfo", typeof(System.String));
            _datatable.Columns.Add("DepartmentCode", typeof(System.String));
            //
            DataRow _datarow;
            _datarow = _datatable.NewRow();
            _datarow["OrgID"] = (_Context != null) ? _Context.OrgID : -1;
            _datarow["OrgName"] = (_Context != null) ? _Context.OrgName : String.Empty;
            _datarow["LogoPath"] = String.Empty;
            _datarow["OrgAddressID"] = (_Context != null) ? _Context.LocationID : -1;
            _datarow["RoleID"] = (_Context != null) ? _Context.RoleID : -1;
            _datarow["RoleName"] = (_Context != null) ? _Context.RoleName : String.Empty;
            _datarow["UserID"] = (_Context != null) ? _Context.UserID : -1;
            _datarow["LoginID"] = (_Context != null) ? _Context.LoginID : -1;
            _datarow["LoginName"] = (_Context != null) ? _Context.LoginName : String.Empty;
            _datarow["Age"] = String.Empty;
            _datarow["LocationID"] = (_Context != null) ? _Context.LocationID : -1;
            _datarow["PharmacyLocationID"] = (_Context != null) ? _Context.InventoryLocationID : -1;
            _datarow["IsTrustedOrg"] = String.Empty;
            _datarow["BaseCurrency"] = (_Context != null) ? _Context.OrgCurrency : String.Empty;
            _datarow["CurrencyFormat"] = (_Context != null) ? _Context.OrgCurrencyFormat : String.Empty;
            _datarow["ThemeID"] = (_Context != null) ? _Context.ThemeID : -1;
            _datarow["CountryID"] = (_Context != null) ? _Context.CountryID : -1;
            _datarow["StateID"] = (_Context != null) ? _Context.StateID : -1;
            _datarow["LanguageCode"] = (_Context != null) ? _Context.LanguageCode : String.Empty;
            _datarow["PageID"] = (_Context != null) ? _Context.PageID : -1;
            _datarow["SessionID"] = (_Context != null) ? _Context.SessionID : string.Empty;
            _datarow["DepartmentName"] = (_Context != null) ? _Context.DepartmentName : string.Empty;
            _datarow["AdditionalInfo"] = (_Context != null) ? _Context.AdditionalInfo : string.Empty;
            _datarow["DepartmentCode"] = (_Context != null) ? _Context.DepartmentCode : string.Empty;
            _datatable.Rows.Add(_datarow);
            return _datatable;
        }
        public static System.Data.DataTable ConvertToUDTpatientQualification(List<PatientQualification> _Qualification)
        {

            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientID", typeof(System.Int64));
            _datatable.Columns.Add("MetaTypeID", typeof(System.String));
            _datatable.Columns.Add("MetaValueID", typeof(System.String));

            DataRow _datarow;
            foreach (PatientQualification _list in _Qualification)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientID"] = _list.PatientID;
                _datarow["MetaTypeID"] = _list.MetaTypeID;
                _datarow["MetaValueID"] = _list.MetaValueID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }
        public static System.Data.DataTable ConvertToVisitClientMapping(List<VisitClientMapping> _lstCollection)
        {
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("VisitClientMappingID", typeof(System.Int64));
            _datatable.Columns.Add("VisitID", typeof(System.Int64));
            _datatable.Columns.Add("ClientID", typeof(System.Int64));
            _datatable.Columns.Add("FinalBillID", typeof(System.Int64));
            _datatable.Columns.Add("RateID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("PreAuthAmount", typeof(System.Decimal));
            _datatable.Columns.Add("PreAuthApprovalNumber", typeof(System.String));
            _datatable.Columns.Add("ClaimAmount", typeof(System.Decimal));
            _datatable.Columns.Add("ClaimLogic", typeof(System.Int32));
            _datatable.Columns.Add("CoPayment", typeof(System.Decimal));
            _datatable.Columns.Add("CopaymentPercent", typeof(System.Decimal));
            _datatable.Columns.Add("CoPaymentLogic", typeof(System.Int32));
            _datatable.Columns.Add("NonMedicalAmount", typeof(System.Decimal));
            _datatable.Columns.Add("ClientAttributes", typeof(System.String));
            _datatable.Columns.Add("IsAllMedical", typeof(System.String));
            _datatable.Columns.Add("PaymentStatus", typeof(System.String));
            _datatable.Columns.Add("ClientName", typeof(System.String));
            _datatable.Columns.Add("RateName", typeof(System.String));
            _datatable.Columns.Add("AsCreditBill", typeof(System.String));
            _datatable.Columns.Add("PolicyNo", typeof(System.String));
            _datatable.Columns.Add("PolicyStartDate", typeof(System.DateTime));
            _datatable.Columns.Add("PolicyEndDate", typeof(System.DateTime));

            DataRow _datarow;

            foreach (VisitClientMapping _list in _lstCollection)
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

        //Blood Separation
        public static System.Data.DataTable ConvertToUDTBloodSeparation(List<BloodSeparationDetails> _lstSeparationDetails)
        {

            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ParentbagNumber", typeof(System.String));
            _datatable.Columns.Add("BagNumber", typeof(System.String));
            _datatable.Columns.Add("ProductID", typeof(Int32));
            _datatable.Columns.Add("ProductName", typeof(System.String));
            _datatable.Columns.Add("Volume", typeof(System.String));
            _datatable.Columns.Add("BloodGroupName", typeof(System.String));
            _datatable.Columns.Add("ExpiryDate", typeof(System.DateTime));
            _datatable.Columns.Add("OrgID", typeof(Int64));
            _datatable.Columns.Add("CreatedBy", typeof(Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));

            DataRow _datarow;

            foreach (BloodSeparationDetails _list in _lstSeparationDetails)
            {
                _datarow = _datatable.NewRow();
                _datarow["ParentbagNumber"] = _list.ParentbagNumber;
                _datarow["BagNumber"] = _list.BagNumber;
                _datarow["ProductID"] = _list.ProductID;
                _datarow["ProductName"] = _list.ProductName;
                _datarow["Volume"] = _list.Volume;
                _datarow["BloodGroupName"] = _list.BloodGroupName;
                _datarow["ExpiryDate"] = _list.ExpiryDate;

                _datarow["OrgID"] = _list.OrgID;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;

        }

        public static System.Data.DataTable ConvertToPatientDietPlanMaster(List<Diet_PatientDietPlanMaster> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("VisitID", typeof(System.Int64));
            _datatable.Columns.Add("FoodMenuID", typeof(System.Int64));
            _datatable.Columns.Add("StartDate", typeof(System.DateTime));
            _datatable.Columns.Add("Enddate", typeof(System.DateTime));
            _datatable.Columns.Add("FoodSessionID", typeof(System.Int64));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("PlanedBy", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int64));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("FoodID", typeof(System.Int64));
            _datatable.Columns.Add("PatientID", typeof(System.Int64));
            _datatable.Columns.Add("refType", typeof(System.String));

            DataRow _datarow;

            foreach (Diet_PatientDietPlanMaster _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["VisitID"] = _list.VisitID;
                _datarow["FoodMenuID"] = _list.FoodMenuID;
                _datarow["StartDate"] = _list.StartDate;
                _datarow["Enddate"] = _list.Enddate;
                _datarow["FoodSessionID"] = _list.FoodSessionID;
                _datarow["Status"] = _list.Status;
                _datarow["PlanedBy"] = _list.PlanedBy;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["FoodID"] = _list.FoodID;
                _datarow["PatientID"] = _list.PatientID;
                _datarow["refType"] = _list.RefType;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToFoodOrderedDetails(List<FoodOrderedDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("FoodID", typeof(System.Int64));
            _datatable.Columns.Add("FoodOrderDate", typeof(System.DateTime));
            _datatable.Columns.Add("OrderBy", typeof(System.Int64));
            _datatable.Columns.Add("WardBy", typeof(System.Int64));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("UOM", typeof(System.String));
            _datatable.Columns.Add("Quantity", typeof(System.Decimal));
            _datatable.Columns.Add("PatientDietPlanID", typeof(System.Decimal));

            DataRow _datarow;

            foreach (FoodOrderedDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["FoodID"] = _list.FoodID;
                _datarow["FoodOrderDate"] = _list.FoodOrderDate;
                _datarow["OrderBy"] = _list.OrderBy;
                _datarow["WardBy"] = _list.WardID;
                _datarow["Status"] = _list.Status;
                _datarow["UOM"] = _list.UOM;
                _datarow["Quantity"] = _list.Quantity;
                _datarow["PatientDietPlanID"] = _list.PatientDietPlanID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToFoodDeliveredDetails(List<Diet_FoodOrderMaster> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("FoodOrderID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int64));

            DataRow _datarow;

            foreach (Diet_FoodOrderMaster _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["FoodOrderID"] = _list.FoodOrderID;
                _datarow["OrgID"] = _list.OrgID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToDiet_FoodIngredientsMapping(List<Diet_FoodIngredientsMapping> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("FoodIngredientMappingID", typeof(System.Int64));
            _datatable.Columns.Add("FoodID", typeof(System.Int64));
            _datatable.Columns.Add("FoodIngredientID", typeof(System.Int64));
            _datatable.Columns.Add("Quantity", typeof(System.Decimal));
            _datatable.Columns.Add("UOM", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));

            DataRow _datarow;

            foreach (Diet_FoodIngredientsMapping _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["FoodIngredientMappingID"] = _list.FoodIngredientMappingID;
                _datarow["FoodID"] = _list.FoodID;
                _datarow["FoodIngredientID"] = _list.FoodIngredientID;
                _datarow["Quantity"] = _list.Quantity;
                _datarow["UOM"] = _list.UOM;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToUATAccountsImpactDetails(List<Edt_AccountsImpactDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("EdtMasterBillID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("GrossBillValue", typeof(System.Decimal));
            _datatable.Columns.Add("Discount", typeof(System.Decimal));
            _datatable.Columns.Add("DiscountPercentage", typeof(System.Decimal));
            _datatable.Columns.Add("DiscountReason", typeof(System.String));
            _datatable.Columns.Add("Tax", typeof(System.Decimal));
            _datatable.Columns.Add("ServiceCharge", typeof(System.Decimal));
            _datatable.Columns.Add("RoundOffAmount", typeof(System.Decimal));
            _datatable.Columns.Add("NetValue", typeof(System.Decimal));
            _datatable.Columns.Add("PreviousReceivedAmount", typeof(System.Decimal));
            _datatable.Columns.Add("ReceivedAmount", typeof(System.Decimal));
            _datatable.Columns.Add("PreviousRefundAmount", typeof(System.Decimal));
            _datatable.Columns.Add("RefundAmount", typeof(System.Decimal));
            _datatable.Columns.Add("Due", typeof(System.Decimal));
            _datatable.Columns.Add("MedicalAmount", typeof(System.Decimal));
            _datatable.Columns.Add("NonMedicalAmount", typeof(System.Decimal));
            _datatable.Columns.Add("EdtDate", typeof(System.DateTime));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("RoleID", typeof(System.Int32));
            _datatable.Columns.Add("DeptID", typeof(System.Int32));

            DataRow _datarow;

            foreach (Edt_AccountsImpactDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["EdtMasterBillID"] = _list.EdtMasterBillID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["GrossBillValue"] = _list.GrossBillValue;
                _datarow["Discount"] = _list.Discount;
                _datarow["DiscountPercentage"] = _list.DiscountPercentage;
                _datarow["DiscountReason"] = _list.DiscountReason;
                _datarow["Tax"] = _list.Tax;
                _datarow["ServiceCharge"] = _list.ServiceCharge;
                _datarow["RoundOffAmount"] = _list.RoundOffAmount;
                _datarow["NetValue"] = _list.NetValue;
                _datarow["PreviousReceivedAmount"] = _list.PreviousReceivedAmount;
                _datarow["ReceivedAmount"] = _list.ReceivedAmount;
                _datarow["PreviousRefundAmount"] = _list.PreviousRefundAmount;
                _datarow["RefundAmount"] = _list.RefundAmount;
                _datarow["Due"] = _list.Due;
                _datarow["MedicalAmount"] = _list.MedicalAmount;
                _datarow["NonMedicalAmount"] = _list.NonMedicalAmount;
                _datarow["EdtDate"] = _list.EdtDate;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["RoleID"] = _list.RoleID;
                _datarow["DeptID"] = _list.DeptID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToTransferInvsample(List<PatientInvSample> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("SampleID", typeof(System.Int32));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("RecSampleLocID", typeof(System.Int32));
            _datatable.Columns.Add("UID", typeof(System.String));
            _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));

            DataRow _datarow;

            foreach (PatientInvSample _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["SampleID"] = _list.SampleID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["RecSampleLocID"] = _list.RecSampleLocID;
                _datarow["UID"] = _list.Reason;
                _datarow["InvestigationID"] = _list.INVID;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToServiceQuotation(Bookings _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("TokenNumber", typeof(System.Int32));
            _datatable.Columns.Add("TITLECode", typeof(System.Byte));
            _datatable.Columns.Add("PatientName", typeof(System.String));
            _datatable.Columns.Add("Sex", typeof(System.String));
            _datatable.Columns.Add("DOB", typeof(System.DateTime));
            _datatable.Columns.Add("Age", typeof(System.String));
            _datatable.Columns.Add("LandLineNumber", typeof(System.String));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("PhoneNumber", typeof(System.String));
            _datatable.Columns.Add("EMail", typeof(System.String));
            _datatable.Columns.Add("ClientID", typeof(System.Int32));
            _datatable.Columns.Add("FeeType", typeof(System.String));
            _datatable.Columns.Add("SourceType", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("PatientID", typeof(System.Int64));
            _datatable.Columns.Add("OrgAddressID", typeof(System.Int64));
            _datatable.Columns.Add("OtherOrgID", typeof(System.Int32));
            _datatable.Columns.Add("CollectionAddress", typeof(System.String));
            _datatable.Columns.Add("RoleID", typeof(System.Int64));
            _datatable.Columns.Add("UserID", typeof(System.Int64));
            _datatable.Columns.Add("CollectionTime", typeof(System.DateTime));
            _datatable.Columns.Add("BookingOrgID", typeof(System.Int32));
            _datatable.Columns.Add("BookingStatus", typeof(System.String));
            _datatable.Columns.Add("CollectionAddress2", typeof(System.String));
            _datatable.Columns.Add("City", typeof(System.String));
            _datatable.Columns.Add("PatientNumber", typeof(System.String));
            _datatable.Columns.Add("BookingID", typeof(System.Int64));
            _datatable.Columns.Add("BillDescription", typeof(System.String));
             _datatable.Columns.Add("Priority", typeof(System.String));
             _datatable.Columns.Add("Comments", typeof(System.String));
	         _datatable.Columns.Add("State", typeof(System.String));
	         _datatable.Columns.Add("Pincode", typeof(System.String));
	         _datatable.Columns.Add("StateID", typeof(System.Int64));
             _datatable.Columns.Add("CityID", typeof(System.Int64));
             _datatable.Columns.Add("URNTypeID", typeof(System.Int64));
	         _datatable.Columns.Add("URNO", typeof(System.String));
            _datatable.Columns.Add("DispatchValue", typeof(System.String));
            _datatable.Columns.Add("ReferalID", typeof(System.Int64));
            _datatable.Columns.Add("TokenID", typeof(System.String));
            _datatable.Columns.Add("RefPhysicianName", typeof(System.String));
            _datatable.Columns.Add("NRICNumber", typeof(System.String));
            _datatable.Columns.Add("NRICType", typeof(System.String));
            _datatable.Columns.Add("ExterNalPatNo", typeof(System.String));

            DataRow _datarow;

            _datarow = _datatable.NewRow();
            _datarow["TokenNumber"] = _lstCollection.TokenNumber;
            _datarow["TITLECode"] = _lstCollection.TITLECode;
            _datarow["PatientName"] = _lstCollection.PatientName;
            _datarow["Sex"] = _lstCollection.SEX;
            _datarow["DOB"] = _lstCollection.DOB;
            _datarow["Age"] = _lstCollection.Age;
            _datarow["LandLineNumber"] = _lstCollection.LandLineNumber;
            _datarow["CreatedAt"] = _lstCollection.CreatedAt;
            _datarow["PhoneNumber"] = _lstCollection.PhoneNumber;
            _datarow["EMail"] = _lstCollection.EMail;
            _datarow["ClientID"] = _lstCollection.ClientID;
            _datarow["FeeType"] = _lstCollection.FeeType;
            _datarow["SourceType"] = _lstCollection.SourceType;
            _datarow["OrgID"] = _lstCollection.OrgID;
            _datarow["CreatedBy"] = _lstCollection.CreatedBy;

            _datarow["PatientID"] = _lstCollection.PatientID;
            _datarow["OrgAddressID"] = _lstCollection.OrgAddressID;
            _datarow["OtherOrgID"] = _lstCollection.OtherOrgID;
            _datarow["CollectionAddress"] = _lstCollection.CollectionAddress;
            _datarow["RoleID"] = _lstCollection.RoleID;
            _datarow["UserID"] = _lstCollection.UserID;
            _datarow["CollectionTime"] = _lstCollection.CollectionTime;
            _datarow["BookingOrgID"] = _lstCollection.BookingOrgID;
            _datarow["BookingStatus"] = _lstCollection.BookingStatus;
            _datarow["CollectionAddress2"] = _lstCollection.CollectionAddress2;
            _datarow["City"] = _lstCollection.City;
            _datarow["PatientNumber"] = _lstCollection.PatientNumber;
            _datarow["BookingID"] = _lstCollection.BookingID;
            _datarow["BillDescription"] = _lstCollection.BillDescription;
            _datarow["Priority"] = _lstCollection.Priority;
            _datarow["Comments"] = _lstCollection.Comments;
            _datarow["State"] = _lstCollection.State;
            _datarow["Pincode"] = _lstCollection.Pincode;
            _datarow["StateID"] = _lstCollection.StateID;
            _datarow["CityID"] = _lstCollection.CityID;
            _datarow["URNTypeID"] = _lstCollection.URNTypeID;
            _datarow["URNO"] = _lstCollection.URNO;
            _datarow["DispatchValue"] = _lstCollection.DispatchValue;
            _datarow["ReferalID"] = _lstCollection.ReferalID;
            _datarow["TokenID"] = _lstCollection.TokenID;
            _datarow["RefPhysicianName"] = _lstCollection.RefPhysicianName;
            _datarow["NRICNumber"] = _lstCollection.NRICNumber;
            _datarow["NRICType"] = _lstCollection.NRICType;
            _datarow["ExterNalPatNo"] = _lstCollection.ExternalPatientNo;

            _datatable.Rows.Add(_datarow);
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToBarcodePrintDetails(List<PrintBarcode> _lstPrintBarcode)
        {
            System.Data.DataTable _datatable = new System.Data.DataTable();
            try
            {
                _datatable.Columns.Add("ID", typeof(System.Int64));
                _datatable.Columns.Add("VisitID", typeof(System.Int64));
                _datatable.Columns.Add("SampleID", typeof(System.Int32));
                _datatable.Columns.Add("BarcodeNumber", typeof(System.String));
                _datatable.Columns.Add("MachineID", typeof(System.String));
                _datatable.Columns.Add("HeaderLine1", typeof(System.String));
                _datatable.Columns.Add("HeaderLine2", typeof(System.String));
                _datatable.Columns.Add("FooterLine1", typeof(System.String));
                _datatable.Columns.Add("FooterLine2", typeof(System.String));
                _datatable.Columns.Add("RightHeaderLine1", typeof(System.String));
                _datatable.Columns.Add("RightHeaderLine2", typeof(System.String));
                _datatable.Columns.Add("RightHeaderLine3", typeof(System.String));
                _datatable.Columns.Add("RightHeaderLine4", typeof(System.String));
                _datatable.Columns.Add("RightHeaderLine5", typeof(System.String));
                _datatable.Columns.Add("RightHeaderLine6", typeof(System.String));
                _datatable.Columns.Add("RightHeaderLine7", typeof(System.String));
                _datatable.Columns.Add("PrinterName", typeof(System.String));
                _datatable.Columns.Add("Status", typeof(System.String));
                DataRow _datarow;

                foreach (PrintBarcode _list in _lstPrintBarcode)
                {
                    _datarow = _datatable.NewRow();
                    _datarow["ID"] = 0;
                    _datarow["VisitID"] = _list.VisitID;
                    _datarow["SampleID"] = _list.SampleID;
                    _datarow["BarcodeNumber"] = _list.BarcodeNumber;
                    _datarow["MachineID"] = _list.MachineID;
                    _datarow["HeaderLine1"] = _list.HeaderLine1;
                    _datarow["HeaderLine2"] = _list.HeaderLine2;
                    _datarow["FooterLine1"] = _list.FooterLine1;
                    _datarow["FooterLine2"] = _list.FooterLine2;
                    _datarow["RightHeaderLine1"] = _list.RightHeaderLine1;
                    _datarow["RightHeaderLine2"] = _list.RightHeaderLine2;
                    _datarow["RightHeaderLine3"] = _list.RightHeaderLine3;
                    _datarow["RightHeaderLine4"] = _list.RightHeaderLine4;
                    _datarow["RightHeaderLine5"] = _list.RightHeaderLine5;
                    _datarow["RightHeaderLine6"] = _list.RightHeaderLine6;
                    _datarow["RightHeaderLine7"] = _list.RightHeaderLine7;
                    _datarow["PrinterName"] = _list.PrinterName;
                    _datarow["Status"] = _list.Status;
                    _datatable.Rows.Add(_datarow);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in ConvertToBarcodePrintDetails", ex);
            }
            return _datatable;
        }

        public static System.Data.DataTable ConvertToBarcodePrintAttributesDetails(List<BarcodeAttributes> _lstBarcodeAttributes)
        {
            System.Data.DataTable _datatable = new System.Data.DataTable();
            try
            {
                _datatable.Columns.Add("VisitID", typeof(System.Int64));
                _datatable.Columns.Add("SampleID", typeof(System.Int32));
                _datatable.Columns.Add("UID", typeof(System.String));
                _datatable.Columns.Add("MachineID", typeof(System.String));
                _datatable.Columns.Add("MachineName", typeof(System.String));

                DataRow _datarow;

                foreach (BarcodeAttributes _list in _lstBarcodeAttributes)
                {
                    _datarow = _datatable.NewRow();
                    _datarow["VisitID"] = _list.VisitID;
                    _datarow["SampleID"] = _list.SampleID;
                    _datatable.Rows.Add(_datarow);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in ConvertToBarcodePrintAttributesDetails", ex);
            }
            return _datatable;
        }

        public static System.Data.DataTable ConvertToUDTCodingSchemeMaster(List<CodingSchemeMaster> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("CodeTypeID", typeof(System.Int32));
            _datatable.Columns.Add("CodingSchemaName", typeof(System.String));
            _datatable.Columns.Add("VersionNo", typeof(System.String));

            DataRow _datarow;

            foreach (CodingSchemeMaster _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["CodeTypeID"] = _list.CodeTypeID;
                _datarow["CodingSchemaName"] = _list.CodingSchemaName;
                _datarow["VersionNo"] = _list.VersionNo;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTCodingSchemeOrgMapping(List<CodingSchemeOrgMapping> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("CodingSchemeOrgID", typeof(System.Int32));
            _datatable.Columns.Add("CodeTypeID", typeof(System.Int32));
            _datatable.Columns.Add("RootOrgID", typeof(System.Int64));
            _datatable.Columns.Add("ParentOrgID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int64));
            _datatable.Columns.Add("IsPrimary", typeof(System.String));

            DataRow _datarow;

            foreach (CodingSchemeOrgMapping _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["CodingSchemeOrgID"] = _list.CodingSchemeOrgID;
                _datarow["CodeTypeID"] = _list.CodeTypeID;
                _datarow["RootOrgID"] = _list.RootOrgID;
                _datarow["ParentOrgID"] = _list.ParentOrgID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["IsPrimary"] = _list.IsPrimary;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToUDTClientDepositHistory(List<CollectionsHistory> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("DepositID", typeof(System.Int64));
            _datatable.Columns.Add("ClientID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("ReceiptNo", typeof(System.Int64));
            _datatable.Columns.Add("AmountDeposited", typeof(System.Decimal));
            _datatable.Columns.Add("PaymentTypeID", typeof(System.Int32));
            _datatable.Columns.Add("ChequeorCardNumber", typeof(System.String));
            _datatable.Columns.Add("BankNameorCardType", typeof(System.String));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            _datatable.Columns.Add("ServiceCharge", typeof(System.Decimal));
            _datatable.Columns.Add("BaseCurrencyID", typeof(System.Int32));
            _datatable.Columns.Add("PaidCurrencyID", typeof(System.Int32));
            _datatable.Columns.Add("ConversionRate", typeof(System.Decimal));
            _datatable.Columns.Add("PaidCurrencyAmount", typeof(System.Decimal));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CardHolderName", typeof(System.String));
            _datatable.Columns.Add("CashGiven", typeof(System.Decimal));
            _datatable.Columns.Add("BalanceGiven", typeof(System.Decimal));

            DataRow _datarow;

            foreach (CollectionsHistory _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["DepositID"] = _list.CollectionID;
                _datarow["ClientID"] = _list.Identificationid;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["ReceiptNo"] = _list.ReceiptNo;
                _datarow["AmountDeposited"] = _list.AmountDeposited;
                _datarow["PaymentTypeID"] = _list.PaymentTypeID;
                _datarow["ChequeorCardNumber"] = _list.ChequeorCardNumber;
                _datarow["BankNameorCardType"] = _list.BankNameorCardType;
                _datarow["Remarks"] = _list.Remarks;
                _datarow["ServiceCharge"] = _list.ServiceCharge;
                _datarow["BaseCurrencyID"] = _list.BaseCurrencyID;
                _datarow["PaidCurrencyID"] = _list.PaidCurrencyID;
                _datarow["ConversionRate"] = _list.ConversionRate;
                _datarow["PaidCurrencyAmount"] = _list.PaidCurrencyAmount;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CardHolderName"] = _list.CardHolderName;
                _datarow["CashGiven"] = _list.CashGiven;
                _datarow["BalanceGiven"] = _list.BalanceGiven;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        //AB Code
        public static System.Data.DataTable ConvertToUDTClientRefundHistory(List<CollectionsHistory> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("DepositID", typeof(System.Int64));
            _datatable.Columns.Add("ClientID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("RefundAmount", typeof(System.Decimal));
            _datatable.Columns.Add("PaymentTypeID", typeof(System.Int32));
            _datatable.Columns.Add("ChequeorCardNumber", typeof(System.String));
            _datatable.Columns.Add("BankNameorCardType", typeof(System.String));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            _datatable.Columns.Add("ServiceCharge", typeof(System.Decimal));
            _datatable.Columns.Add("BaseCurrencyID", typeof(System.Int32));
            _datatable.Columns.Add("PaidCurrencyID", typeof(System.Int32));
            //_datatable.Columns.Add("ConversionRate", typeof(System.Decimal));
            //_datatable.Columns.Add("PaidCurrencyAmount", typeof(System.Decimal));
            //_datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            //_datatable.Columns.Add("CardHolderName", typeof(System.String));
            //_datatable.Columns.Add("CashGiven", typeof(System.Decimal));
            //_datatable.Columns.Add("BalanceGiven", typeof(System.Decimal));

            DataRow _datarow;

            foreach (CollectionsHistory _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["DepositID"] = _list.CollectionID;
                _datarow["ClientID"] = _list.Identificationid;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["RefundAmount"] = _list.AmountDeposited;
                _datarow["PaymentTypeID"] = _list.PaymentTypeID;
                _datarow["ChequeorCardNumber"] = _list.ChequeorCardNumber;
                _datarow["BankNameorCardType"] = _list.BankNameorCardType;
                _datarow["Remarks"] = _list.Remarks;
                _datarow["ServiceCharge"] = _list.ServiceCharge;
                _datarow["BaseCurrencyID"] = _list.BaseCurrencyID;
                _datarow["PaidCurrencyID"] = _list.PaidCurrencyID;
                //_datarow["ConversionRate"] = _list.ConversionRate;
                //_datarow["PaidCurrencyAmount"] = _list.PaidCurrencyAmount;
                //_datarow["CreatedBy"] = _list.CreatedBy;
                //_datarow["CardHolderName"] = _list.CardHolderName;
                //_datarow["CashGiven"] = _list.CashGiven;
                //_datarow["BalanceGiven"] = _list.BalanceGiven;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTcodeschemelblmaster(List<CodeMaster> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("CodeLabel", typeof(System.Int32));
            _datatable.Columns.Add("CodeTextbox", typeof(System.String));
            _datatable.Columns.Add("CodeMasterID", typeof(System.Int32));

            DataRow _datarow;

            foreach (CodeMaster _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["CodeLabel"] = _list.CodeLabel;
                _datarow["CodeTextbox"] = _list.CodeTextbox;
                _datarow["CodeMasterID"] = _list.CodeMasterID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToUDTDeviceSampleStatus(List<DeviceImportData> _lstCollection)
        {

            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ExternalVisitID", typeof(System.String));
            _datatable.Columns.Add("VisitID", typeof(System.Int64));
            _datatable.Columns.Add("BarCode", typeof(System.String));
            _datatable.Columns.Add("TestCode", typeof(System.String));
            _datatable.Columns.Add("DeviceID", typeof(System.String));

            DataRow _datarow;

            foreach (DeviceImportData _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ExternalVisitID"] = _list.ExternalVisitID;
                _datarow["VisitID"] = _list.VisitID;
                _datarow["BarCode"] = _list.BarCode;
                _datarow["TestCode"] = _list.TestCode;
                _datarow["DeviceID"] = _list.DeviceID;

                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }
        public static System.Data.DataTable ConverttoInvValueRangeMaster(List<InvValueRangeMaster> lstInvValueRangeMaster)
        {
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("InvestigationID", typeof(System.String));
            _datatable.Columns.Add("ValueRange", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.String));
            _datatable.Columns.Add("ReflexInvestigationID", typeof(System.String));
            _datatable.Columns.Add("IsReportable", typeof(System.String));
            _datatable.Columns.Add("IsChargeable", typeof(System.String));
            _datatable.Columns.Add("ReflexSampleType", typeof(System.String));
            _datatable.Columns.Add("Type", typeof(System.String));

            DataRow _datarow;

            foreach (InvValueRangeMaster _list in lstInvValueRangeMaster)
            {
                _datarow = _datatable.NewRow();
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datarow["ValueRange"] = _list.ValueRange;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["ReflexInvestigationID"] = _list.ReflexInvestigationID;
                _datarow["IsReportable"] = _list.IsReportable;
                _datarow["IsChargeable"] = _list.IsChargeable;
                _datarow["ReflexSampleType"] = _list.ReflexSampleType;
                _datarow["Type"] = _list.Type;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;

        }


        public static System.Data.DataTable ConvertToUDTInvOrgNotifications(List<InvOrgNotifications> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("InvestigationID", typeof(System.Int32));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("ActionType", typeof(System.String));
            _datatable.Columns.Add("ActionTemplateID", typeof(System.Int32));
            _datatable.Columns.Add("NotifiedTo", typeof(System.String));

            DataRow _datarow;

            foreach (InvOrgNotifications _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["Type"] = _list.Type;
                _datarow["ActionType"] = _list.ActionType;
                _datarow["ActionTemplateID"] = _list.ActionTemplateID;
                _datarow["NotifiedTo"] = _list.NotifiedTo;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToInvCoAuth(List<InvOrgAuthorization> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ID", typeof(System.Int64));
            _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("RoleID", typeof(System.Int32));
            _datatable.Columns.Add("DeptID", typeof(System.Int32));
            _datatable.Columns.Add("UserID", typeof(System.Int32));
            _datatable.Columns.Add("IsPrimary", typeof(System.String));
            DataRow _datarow;

            foreach (InvOrgAuthorization _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ID"] = _list.ID;
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["Type"] = _list.Type;
                _datarow["RoleID"] = _list.RoleID;
                _datarow["DeptID"] = _list.DeptID;
                _datarow["UserID"] = _list.UserID;
                _datarow["IsPrimary"] = _list.IsPrimary;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }


        public static System.Data.DataTable ConvertToCreditDebitSummary(List<CreditDebitSummary> _lstCrdrSummary)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ReceiptNo", typeof(System.Int64));
            _datatable.Columns.Add("ID", typeof(System.Int32));
            _datatable.Columns.Add("Date", typeof(System.DateTime));
            _datatable.Columns.Add("CrDrType", typeof(System.String));
            _datatable.Columns.Add("ClientId", typeof(System.Int64));
            _datatable.Columns.Add("ClientType", typeof(System.String));
            _datatable.Columns.Add("ItemType", typeof(System.String));
            _datatable.Columns.Add("Authorizedby", typeof(System.Int64));
            _datatable.Columns.Add("ReferenceType", typeof(System.String));
            _datatable.Columns.Add("ReferenceID", typeof(System.Int64));
            _datatable.Columns.Add("Amount", typeof(System.Decimal));
            _datatable.Columns.Add("Reason", typeof(System.Int64));
            _datatable.Columns.Add("Remarks", typeof(System.String));



            DataRow _datarow;

            foreach (CreditDebitSummary _list in _lstCrdrSummary)
            {

                _datarow = _datatable.NewRow();
                _datarow["ReceiptNo"] = _list.ReceiptNo;
                _datarow["ID"] = _list.ID;
                _datarow["Date"] = _list.CrDrDate;
                _datarow["CrDrType"] = _list.Crdrtype;
                _datarow["ClientType"] = _list.ClientType;
                _datarow["ClientId"] = _list.ClientId;
                _datarow["ItemType"] = _list.ItemType;
                _datarow["Authorizedby"] = _list.Authorizedby;
                _datarow["ReferenceType"] = _list.ReferenceType;
                _datarow["ReferenceID"] = _list.ReferenceID;
                _datarow["Amount"] = _list.Amount;
                _datarow["Reason"] = _list.Reasonid;
                _datarow["Remarks"] = _list.Remarks;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test

        }



        public static System.Data.DataTable ConvertToPatientPreferences(List<PatientPreferences> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientID", typeof(System.Int64));
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("PatientPreference", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));

            DataRow _datarow;

            foreach (PatientPreferences _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientID"] = _list.PatientID;
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["PatientPreference"] = _list.PatientPreference;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }


        public static System.Data.DataTable ConvertToBulkRateApp1y(List<BulckRateUpdates> _lstBulckRateUpdates)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();
            _datatable.Columns.Add("FinalbillID", typeof(System.Int64));
            _datatable.Columns.Add("ClientID", typeof(System.Int64));
            _datatable.Columns.Add("OldRateID", typeof(System.Int64));
            _datatable.Columns.Add("OldAmount", typeof(System.Decimal));
            _datatable.Columns.Add("NewRateID", typeof(System.Int64));
            _datatable.Columns.Add("NewAmount", typeof(System.Decimal));
            _datatable.Columns.Add("BillFromDate", typeof(System.DateTime));
            _datatable.Columns.Add("BillToDate", typeof(System.DateTime));
            _datatable.Columns.Add("InvoiceID", typeof(System.Int64));
            _datatable.Columns.Add("PreTotBilledAmount", typeof(System.Decimal));

            DataRow _datarow;

            foreach (BulckRateUpdates _list in _lstBulckRateUpdates)
            {

                _datarow = _datatable.NewRow();
                _datarow["FinalbillID"] = _list.FinalbillID;
                _datarow["ClientID"] = _list.ClientID;
                _datarow["OldRateID"] = _list.OldRateID;
                _datarow["OldAmount"] = _list.OldAmount;
                _datarow["NewRateID"] = _list.NewRateID;
                _datarow["NewAmount"] = _list.NewAmount;
                _datarow["BillFromDate"] = _list.BillFromDate;
                _datarow["BillToDate"] = _list.BillToDate;
                _datarow["InvoiceID"] = _list.InvoiceID;
                _datarow["PreTotBilledAmount"] = _list.TotBillAmt;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test

        }



        public static System.Data.DataTable ConvertToInvoiceForBulkrate(List<Invoice> _lstInvoice)
        {
            System.Data.DataTable _datatable = new System.Data.DataTable();
            _datatable.Columns.Add("InvoiceID", typeof(System.Int64));
            DataRow _datarow;

            foreach (Invoice _list in _lstInvoice)
            {
                _datarow = _datatable.NewRow();
                _datarow["InvoiceID"] = _list.InvoiceID;
                _datatable.Rows.Add(_datarow);
            }

            return _datatable;


        }

        public static System.Data.DataTable ConvertToRateForBulkrate(List<RateMaster> _lstRateMaster)
        {
            System.Data.DataTable _datatable = new System.Data.DataTable();
            _datatable.Columns.Add("RateId", typeof(System.Int64));
            DataRow _datarow;

            foreach (RateMaster _list in _lstRateMaster)
            {
                _datarow = _datatable.NewRow();
                _datarow["RateId"] = _list.RateId;
                _datatable.Rows.Add(_datarow);
            }

            return _datatable;


        }

        public static System.Data.DataTable ConvertToUDTDisPatchDetails(List<PatientDisPatchDetails> _lstCollection)
        {
            System.Data.DataTable _dataTable = new System.Data.DataTable();
            _dataTable.Columns.Add("VisitID", typeof(System.String));
            _dataTable.Columns.Add("PatientID", typeof(System.String));
            _dataTable.Columns.Add("DispatchType", typeof(System.String));
            _dataTable.Columns.Add("DispatchValue", typeof(System.String));
            _dataTable.Columns.Add("OrgID", typeof(System.String));
            DataRow _dataRow;
            foreach (PatientDisPatchDetails _list in _lstCollection)
            {
                _dataRow = _dataTable.NewRow();
                _dataRow["VisitID"] = _list.VisitID;
                _dataRow["PatientID"] = _list.PatientID;
                _dataRow["DispatchType"] = _list.DispatchType;
                _dataRow["DispatchValue"] = _list.DispatchValue;
                _dataRow["OrgID"] = _list.OrgID;
                _dataTable.Rows.Add(_dataRow);
            }
            return _dataTable;
        }

        public static System.Data.DataTable ConvertToUDTOutSourcingDetails(List<OutsourcingDetail> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("SampleTrackerID", typeof(System.Int64));
            _datatable.Columns.Add("SampleID", typeof(System.Int64));
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("OrgId", typeof(System.Int32));
            _datatable.Columns.Add("UID", typeof(System.String));
            _datatable.Columns.Add("OutsourcedDate", typeof(System.DateTime));
            _datatable.Columns.Add("ReceivedDate", typeof(System.DateTime));
            _datatable.Columns.Add("CourierDetails", typeof(System.String));
            _datatable.Columns.Add("Acknowledgement", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("Absolute", typeof(System.Boolean));
            _datatable.Columns.Add("ReachedDate", typeof(System.DateTime));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("AccessionNumber", typeof(System.Int64));
            _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
            _datatable.Columns.Add("OutSourcingLocationID", typeof(System.Int64));
            _datatable.Columns.Add("RefID", typeof(System.String));

            DataRow _datarow;

            foreach (OutsourcingDetail _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["SampleTrackerID"] = _list.SampleTrackerID;
                _datarow["SampleID"] = _list.SampleID;
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["OrgId"] = _list.OrgId;
                _datarow["UID"] = _list.UID;
                _datarow["OutsourcedDate"] = _list.OutsourcedDate;
                _datarow["ReceivedDate"] = _list.ReceivedDate;
                _datarow["CourierDetails"] = _list.CourierDetails;
                _datarow["Acknowledgement"] = _list.Acknowledgement;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["Absolute"] = _list.Absolute;
                _datarow["ReachedDate"] = _list.ReachedDate;
                _datarow["Status"] = _list.Status;
                _datarow["AccessionNumber"] = _list.AccessionNumber;
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datarow["OutSourcingLocationID"] = _list.OutSourcingLocationID;
                _datarow["RefID"] = _list.RefID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToUDTVitekDeviceIntegrationResult(List<VitekDeviceIntegrationResult> _lstCollection)
        {
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("VisitID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("GroupID", typeof(System.Int32));
            _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
            _datatable.Columns.Add("DeviceCode", typeof(System.String));
            _datatable.Columns.Add("Barcode", typeof(System.String));
            _datatable.Columns.Add("OrganismCode", typeof(System.String));
            _datatable.Columns.Add("OrganismName", typeof(System.String));
            _datatable.Columns.Add("DrugCode", typeof(System.String));
            _datatable.Columns.Add("DrugName", typeof(System.String));
            _datatable.Columns.Add("Sensitivity", typeof(System.String));
            _datatable.Columns.Add("MicValue", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));

            DataRow _datarow;

            foreach (VitekDeviceIntegrationResult _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["VisitID"] = _list.VisitID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["GroupID"] = _list.GroupID;
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datarow["DeviceCode"] = _list.DeviceCode;
                _datarow["Barcode"] = _list.Barcode;
                _datarow["OrganismCode"] = _list.OrganismCode;
                _datarow["OrganismName"] = _list.OrganismName;
                _datarow["DrugCode"] = _list.DrugCode;
                _datarow["DrugName"] = _list.DrugName;
                _datarow["Sensitivity"] = _list.Sensitivity;
                _datarow["MicValue"] = _list.MicValue;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }
        public static System.Data.DataTable ConvertToBidirectionalBarcodes(List<BidirectionalBarcodes> _lstBidirectionalBarcodesDetails)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientName", typeof(System.String));
            _datatable.Columns.Add("PatientAge", typeof(System.String));
            _datatable.Columns.Add("PatientSex", typeof(System.String));
            _datatable.Columns.Add("TestCode", typeof(System.String));
            _datatable.Columns.Add("Barcode", typeof(System.String));
            //_datatable.Columns.Add("[UID]", typeof(System.String));
            _datatable.Columns.Add("PatientVisitId", typeof(System.Int64));
            _datatable.Columns.Add("rowid", typeof(System.Int32));
            _datatable.Columns.Add("PatientInvId", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("DeviceID", typeof(System.String));
            DataRow _datarow;
            foreach (BidirectionalBarcodes _lstBidirectionalBarcodes in _lstBidirectionalBarcodesDetails)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientName"] = _lstBidirectionalBarcodes.PatientName;
                _datarow["PatientAge"] = _lstBidirectionalBarcodes.PatientAge;
                _datarow["PatientSex"] = _lstBidirectionalBarcodes.PatientSex;
                _datarow["TestCode"] = _lstBidirectionalBarcodes.TestCode;
                _datarow["Barcode"] = _lstBidirectionalBarcodes.BarCode;
                _datarow["PatientVisitId"] = _lstBidirectionalBarcodes.PatientVisitId;
                _datarow["rowid"] = _lstBidirectionalBarcodes.rowid;
                _datarow["PatientInvId"] = _lstBidirectionalBarcodes.PatientInvID;
                _datarow["OrgID"] = _lstBidirectionalBarcodes.OrgID;
                _datarow["DeviceID"] = _lstBidirectionalBarcodes.DeviceID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }
        public static System.Data.DataTable ConvertToTRFfilemanager(List<TRFfilemanager> _lstTRF)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("FileID", typeof(System.Int64));
            _datatable.Columns.Add("FileUrl", typeof(System.String));
            _datatable.Columns.Add("PatientID", typeof(System.Int64));
            _datatable.Columns.Add("VisitID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("IdentifyingID", typeof(System.Int64));
            _datatable.Columns.Add("IdentifyingType", typeof(System.String));
            _datatable.Columns.Add("FileName", typeof(System.String));
            _datatable.Columns.Add("FilePath", typeof(System.String));
            _datatable.Columns.Add("Createdby", typeof(System.Int64));
            _datatable.Columns.Add("Createdat", typeof(System.DateTime));
            _datatable.Columns.Add("Isactive", typeof(System.String));
            DataRow _datarow;
            foreach (TRFfilemanager _lst in _lstTRF)
            {
                _datarow = _datatable.NewRow();
                _datarow["FileID"] = _lst.FileID;
                _datarow["FileUrl"] = _lst.FileUrl;
                _datarow["PatientID"] = _lst.PatientID;
                _datarow["VisitID"] = _lst.VisitID;
                _datarow["OrgID"] = _lst.OrgID;
                _datarow["IdentifyingID"] = _lst.IdentifyingID;
                _datarow["IdentifyingType"] = _lst.IdentifyingType;
                _datarow["FileName"] = _lst.FileName;
                _datarow["FilePath"] = _lst.FilePath;
                _datarow["Createdby"] = _lst.Createdby;
                _datarow["Createdat"] = _lst.Createdat;
                _datarow["Isactive"] = _lst.Isactive;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }
        public static System.Data.DataTable ConvertToTRFFilecollection(List<TRFfilemanager> _lstTRF)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("FileID", typeof(System.Int64));
            _datatable.Columns.Add("FileUrl", typeof(System.String));
            _datatable.Columns.Add("PatientID", typeof(System.Int64));
            _datatable.Columns.Add("VisitID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("IdentifyingID", typeof(System.Int64));
            _datatable.Columns.Add("IdentifyingType", typeof(System.String));
            DataRow _datarow;
            foreach (TRFfilemanager _lst in _lstTRF)
            {
                _datarow = _datatable.NewRow();
                _datarow["FileID"] = _lst.FileID;
                _datarow["FileUrl"] = _lst.FileUrl;
                _datarow["PatientID"] = _lst.PatientID;
                _datarow["VisitID"] = _lst.VisitID;
                _datarow["OrgID"] = _lst.OrgID;
                _datarow["IdentifyingID"] = _lst.IdentifyingID;
                _datarow["IdentifyingType"] = _lst.IdentifyingType;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }
        /* ----------------Prasanna.S - Batch sheet-----------------------*/
        public static System.Data.DataTable ConvertToGetPatientInvDataTable(List<PatientInvSample> lstPatSample)
        {
            System.Data.DataTable dt = new DataTable();
            DataColumn dbCol1 = new DataColumn("PatientVisitID");
            DataColumn dbCol2 = new DataColumn("SampleID");
            DataColumn dbCol3 = new DataColumn("BarcodeNumber");
            DataColumn dbCol4 = new DataColumn("SampleCode");
            DataColumn dbCol5 = new DataColumn("CreatedBy");
            DataColumn dbCol6 = new DataColumn("ModifiedBy");
            DataColumn dbCol7 = new DataColumn("OrgID");

            dt.Columns.Add(dbCol1);
            dt.Columns.Add(dbCol2);
            dt.Columns.Add(dbCol3);
            dt.Columns.Add(dbCol4);
            dt.Columns.Add(dbCol5);
            dt.Columns.Add(dbCol6);
            dt.Columns.Add(dbCol7);
            DataRow dr;

            foreach (PatientInvSample PatinvSample in lstPatSample)
            {
                dr = dt.NewRow();
                dr["PatientVisitID"] = PatinvSample.PatientVisitID;
                dr["SampleID"] = PatinvSample.SampleID;
                dr["BarcodeNumber"] = PatinvSample.BarcodeNumber;
                dr["SampleCode"] = PatinvSample.SampleCode;
                dr["CreatedBy"] = PatinvSample.CreatedBy;
                dr["ModifiedBy"] = PatinvSample.ModifiedBy;
                dr["OrgID"] = PatinvSample.OrgID;
                dt.Rows.Add(dr);
            }
            return dt;
        }
        /* ----------------Prasanna.S - Batch sheet-----------------------*/

        public static System.Data.DataTable ConvertToSampleBatchTrackerDetails(List<SampleBatchTrackerDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("BatchID", typeof(System.Int64));
            _datatable.Columns.Add("BatchNo", typeof(System.String));
            _datatable.Columns.Add("SampleID", typeof(System.Int32));
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("BarcodeNumber", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("BatchStatus", typeof(System.String));
            _datatable.Columns.Add("SampleContainerID", typeof(System.Int32));

            DataRow _datarow;

            foreach (SampleBatchTrackerDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["BatchID"] = _list.BatchID;
                _datarow["BatchNo"] = _list.BatchNo;
                _datarow["SampleID"] = _list.SampleID;
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["BarcodeNumber"] = _list.BarcodeNumber;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["BatchStatus"] = _list.BatchStatus;
                _datarow["SampleContainerID"] = _list.SampleContainerID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToSampleBatchConflictDetails(List<SampleBatchTrackerConflictDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("BatchID", typeof(System.Int64));
            _datatable.Columns.Add("BatchNo", typeof(System.String));
            _datatable.Columns.Add("SampleID", typeof(System.Int32));
            _datatable.Columns.Add("BarcodeNumber", typeof(System.String));

            DataRow _datarow;

            foreach (SampleBatchTrackerConflictDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["BatchID"] = _list.BatchID;
                _datarow["BatchNo"] = _list.BatchNo;
                _datarow["SampleID"] = _list.SampleID;
                _datarow["BarcodeNumber"] = _list.BarcodeNumber;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToInvestigationQueue(List<InvestigationQueue> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("VisitID", typeof(System.Int64));
            _datatable.Columns.Add("UID", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("AccessionNumber", typeof(System.Int64));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("IsReportable", typeof(System.String));
            _datatable.Columns.Add("IsBillable", typeof(System.String));
            _datatable.Columns.Add("ParentName", typeof(System.String));
            _datatable.Columns.Add("ParentInvId", typeof(System.Int32));

            DataRow _datarow;

            foreach (InvestigationQueue _list in _lstCollection)
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
            //Test
        }

        public static System.Data.DataTable ConvertToBatchWisePatientInvestigation(List<PatientInvestigation> _lstCollection)
        {
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
            _datatable.Columns.Add("GroupID", typeof(System.Int32));
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("GUID", typeof(System.String));
            _datatable.Columns.Add("AccessionNumber", typeof(System.Int64));
            DataRow _datarow;

            foreach (PatientInvestigation _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datarow["GroupID"] = _list.GroupID;
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["GUID"] = _list.UID;
                _datarow["AccessionNumber"] = _list.AccessionNumber;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }
        public static System.Data.DataTable ConvertToPatientInvSampleCollected(List<PatientInvSample> lstPatientInvSample)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("SampleID", typeof(System.Int32));
            _datatable.Columns.Add("BarcodeNumber", typeof(System.String));
            _datatable.Columns.Add("SampleCode", typeof(System.Int32));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("InvSampleStatusID", typeof(System.Int32));
            _datatable.Columns.Add("DeptID", typeof(System.Int32));
            _datatable.Columns.Add("Reason", typeof(System.String));
            _datatable.Columns.Add("SampleContainerID", typeof(System.Int32));
            _datatable.Columns.Add("UID", typeof(System.String));
            _datatable.Columns.Add("CollectedLocID", typeof(System.Int32));
            _datatable.Columns.Add("RecSampleLocID", typeof(System.Int32));
            _datatable.Columns.Add("SampleRelationshipID", typeof(System.Int32));
            _datatable.Columns.Add("CollectedDateTime", typeof(System.DateTime));
            _datatable.Columns.Add("VmValue", typeof(System.Int32));
            _datatable.Columns.Add("VmUnitID", typeof(System.Int32));
            _datatable.Columns.Add("SampleConditionID", typeof(System.Int32));
            _datatable.Columns.Add("ConsignmentNo", typeof(System.String));
            _datatable.Columns.Add("ExternalBarcode", typeof(System.String));
            _datatable.Columns.Add("BarcodeCount", typeof(System.String));
            DataRow _datarow;

            foreach (PatientInvSample _list in lstPatientInvSample)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["SampleID"] = _list.SampleID;
                _datarow["BarcodeNumber"] = _list.BarcodeNumber;
                _datarow["SampleCode"] = _list.SampleCode;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["InvSampleStatusID"] = _list.InvSampleStatusID;
                _datarow["DeptID"] = 0;
                _datarow["Reason"] = _list.Reason;
                _datarow["SampleContainerID"] = _list.SampleContainerID;
                _datarow["UID"] = _list.UID;
                _datarow["CollectedLocID"] = _list.CollectedLocID;
                _datarow["RecSampleLocID"] = _list.RecSampleLocID;
                _datarow["SampleRelationshipID"] = _list.SampleRelationshipID;
                _datarow["CollectedDateTime"] = _list.CollectedDateTime;
                _datarow["VmValue"] = _list.VmValue;
                _datarow["VmUnitID"] = _list.VmUnitID;
                _datarow["SampleConditionID"] = _list.SampleConditionID;
                _datarow["ConsignmentNo"] = _list.ConsignmentNo;
                _datarow["ExternalBarcode"] = _list.ExternalBarcode;
                _datarow["BarcodeCount"] = _list.BarcodeCount;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTClientTaxMaster(List<ClientTaxMaster> lstClientTaxMaster)
        {
            System.Data.DataTable _datatable = new System.Data.DataTable();
            //_datatable.Columns.Add("ID", typeof(System.Int64));
            _datatable.Columns.Add("ClientID", typeof(System.Int64));
            _datatable.Columns.Add("TaxID", typeof(System.Int32));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("IsActive", typeof(System.String));
            _datatable.Columns.Add("SequenceNo", typeof(System.Int32));
            DataRow _datarow;

            foreach (ClientTaxMaster _list in lstClientTaxMaster)
            {
                _datarow = _datatable.NewRow();
                //_datarow["ID"] = _list.ID;
                _datarow["ClientID"] = _list.ClientID;
                _datarow["TaxID"] = _list.TaxID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["IsActive"] = _list.IsActive;
                _datarow["SequenceNo"] = _list.SequenceNo;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;

        }
        public static System.Data.DataTable ConvertToUDTPatientDiscount(List<PatientDiscount> lstPatientDiscount)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("DiscountID", typeof(System.Int64));
            _datatable.Columns.Add("DiscountCode", typeof(System.String));
            _datatable.Columns.Add("DiscountName", typeof(System.String));
            _datatable.Columns.Add("DiscountType", typeof(System.String));
            _datatable.Columns.Add("DiscountCeilingValue", typeof(System.Decimal));
            _datatable.Columns.Add("UserDiscountValue", typeof(System.Decimal));
            _datatable.Columns.Add("SlabCeilingValue", typeof(System.Decimal));
            _datatable.Columns.Add("SlabPercentage", typeof(System.Decimal));

            DataRow _datarow;

            foreach (PatientDiscount _list in lstPatientDiscount)
            {
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
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToUDTPatientHistoryDetails(List<PatientHistoryExt> lstpatientHistory)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("HistoryExtID", typeof(System.Int64));
            _datatable.Columns.Add("DetailHistory", typeof(System.String));
            _datatable.Columns.Add("PatientVisitId", typeof(System.Int64));
            _datatable.Columns.Add("PatientID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("Remarks", typeof(System.String));

            DataRow _datarow;

            foreach (PatientHistoryExt _list in lstpatientHistory)
            {
                _datarow = _datatable.NewRow();

                _datarow["HistoryExtID"] = _list.HistoryExtID;
                _datarow["DetailHistory"] = _list.DetailHistory;
                _datarow["PatientVisitId"] = _list.PatientVisitId;
                _datarow["PatientID"] = _list.PatientID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["Status"] = _list.Status;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["Remarks"] = _list.Remarks;

                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTInterpretationNotes(List<InvOrgInterpretationMapping> lstInterpretationNotesCount)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();
            _datatable.Columns.Add("ID", typeof(System.Int64));
            _datatable.Columns.Add("GENDER", typeof(System.String));
            _datatable.Columns.Add("AGEFROM", typeof(System.Int32));
            _datatable.Columns.Add("AGETO", typeof(System.Int32));
            _datatable.Columns.Add("AGEOPERATOR", typeof(System.String));
            _datatable.Columns.Add("CLIENTID", typeof(System.Int32));
            _datatable.Columns.Add("INTERPRETATION", typeof(System.String));

            DataRow _datarow;

            foreach (InvOrgInterpretationMapping _list in lstInterpretationNotesCount)
            {
                _datarow = _datatable.NewRow();
                _datarow["ID"] = _list.ID;
                _datarow["GENDER"] = _list.GenderCode;
                _datarow["AGEFROM"] = 0;
                _datarow["AGETO"] = 0;
                _datarow["AGEOPERATOR"] = "";
                _datarow["CLIENTID"] = 0;
                _datarow["INTERPRETATION"] = _list.Interpretation;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToCommunicationDetails(List<NBCommunicationDetails> _lstCommunicationDetails)
        {
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("DetailID", typeof(System.Int64));
            _datatable.Columns.Add("CommID", typeof(System.Int64));
            _datatable.Columns.Add("CommCode", typeof(System.String));
            _datatable.Columns.Add("CommType", typeof(System.Int32));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("LoginID", typeof(System.Int64));
            _datatable.Columns.Add("RoleID", typeof(System.Int32));
            _datatable.Columns.Add("ACKRequired", typeof(System.String));
            _datatable.Columns.Add("ACKStatus", typeof(System.Int16));
            _datatable.Columns.Add("PriorityLevel", typeof(System.String));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));

            DataRow _datarow;
            foreach (NBCommunicationDetails _list in _lstCommunicationDetails)
            {
                _datarow = _datatable.NewRow();
                _datarow["DetailID"] = _list.DetailID;
                _datarow["CommID"] = _list.CommID;
                _datarow["CommCode"] = _list.CommCode;
                _datarow["CommType"] = _list.CommType;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["LoginID"] = _list.LoginID;
                _datarow["RoleID"] = _list.RoleID;
                _datarow["ACKRequired"] = _list.ACKRequired;
                _datarow["ACKStatus"] = _list.ACKStatus;
                _datarow["PriorityLevel"] = _list.PriorityLevel;
                _datarow["Remarks"] = _list.Remarks;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }
        public static System.Data.DataTable ConvertToPatientRedemDetails(List<PatientRedemDetails> _lstPatientRedemDetails)
        {
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("MembershipCardMappingID", typeof(System.Int32));
            _datatable.Columns.Add("PatientID", typeof(System.Int64));
            _datatable.Columns.Add("VisitID", typeof(System.Int64));
            _datatable.Columns.Add("RedemPoints", typeof(System.Decimal));
            _datatable.Columns.Add("RedemValue", typeof(System.Decimal));
            _datatable.Columns.Add("Finalbillid", typeof(System.Int64));


            DataRow _datarow;
            foreach (PatientRedemDetails _list in _lstPatientRedemDetails)
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
        public static System.Data.DataTable ConvertToUDT_HSTtoINST(List<HistoryMappingmaster> lsthstMap, int OrgID)
        {
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("InvID", typeof(System.Int32));
            _datatable.Columns.Add("MedicalDetailID", typeof(System.Int32));
            _datatable.Columns.Add("MeanTime", typeof(System.Decimal));
            _datatable.Columns.Add("IsInternal", typeof(System.String));
            _datatable.Columns.Add("IsMandatory", typeof(System.String));
            _datatable.Columns.Add("InvType", typeof(System.String));

            DataRow _datarow;

            foreach (HistoryMappingmaster _list in lsthstMap)
            {
                _datarow = _datatable.NewRow();
                _datarow["InvID"] = _list.IdentifyingID;
                _datarow["MedicalDetailID"] = _list.HistoryID;
                _datarow["MeanTime"] = _list.MeanTime;
                _datarow["IsInternal"] = _list.IsInternal;
                _datarow["IsMandatory"] = _list.IsMandatory;
                _datarow["InvType"] = _list.IdentifyingType;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }
        public static System.Data.DataTable ConvertToSampleArchivalMasterDetails(List<SampleArchival> _lstCollection)
        {
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ID", typeof(System.Int32));
            _datatable.Columns.Add("StorageRackID", typeof(System.Int32));
            _datatable.Columns.Add("RowNo", typeof(System.Int16));
            _datatable.Columns.Add("ColumnNo", typeof(System.Int16));
            _datatable.Columns.Add("BarcodeNo", typeof(System.String));
            _datatable.Columns.Add("DeptID", typeof(System.Int32));
            _datatable.Columns.Add("InstrumentID", typeof(System.Int32));
            _datatable.Columns.Add("Active", typeof(System.Boolean));
            _datatable.Columns.Add("Status", typeof(System.String));

            DataRow _datarow;

            foreach (SampleArchival _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ID"] = _list.ID;
                _datarow["StorageRackID"] = _list.StorageRackID;
                _datarow["RowNo"] = _list.RowNo;
                _datarow["ColumnNo"] = _list.ColumnNo;
                _datarow["BarcodeNo"] = _list.BarcodeNo;
                _datarow["DeptID"] = _list.DeptID;
                _datarow["InstrumentID"] = _list.InstrumentID;
                _datarow["Status"] = _list.Status;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }

        public static System.Data.DataTable ConvertToUDDPatientInvSampleTransfer(List<PatientInvSample> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("SampleID", typeof(System.Int32));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("RecSampleLocID", typeof(System.Int32));
            _datatable.Columns.Add("UID", typeof(System.String));
            _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("Type", typeof(System.String));

            DataRow _datarow;

            foreach (PatientInvSample _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["SampleID"] = _list.SampleID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["RecSampleLocID"] = _list.RecSampleLocID;
                _datarow["UID"] = _list.UID;
                _datarow["InvestigationID"] = _list.INVID;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["Type"] = _list.Type;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTInvestigationLocationMappingList(List<InvestigationLocationMapping> listInvLocation)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();
            _datatable.Columns.Add("Id", typeof(System.Int64));
            _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("LocationID", typeof(System.Int32));
            _datatable.Columns.Add("ProcessingOrgID", typeof(System.Int64));
            _datatable.Columns.Add("ProcessingAddressID", typeof(System.Int32));
            _datatable.Columns.Add("Type", typeof(System.String));

            DataRow _datarow;
            foreach (InvestigationLocationMapping _list in listInvLocation)
            {
                _datarow = _datatable.NewRow();
                _datarow["Id"] = _list.Id;
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["LocationID"] = _list.LocationID;
                _datarow["ProcessingOrgID"] = _list.ProcessingOrgID;
                _datarow["ProcessingAddressID"] = _list.ProcessingAddressID;
                _datarow["Type"] = _list.Type;
                _datatable.Rows.Add(_datarow);

            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTInvDeltacheckList(InvDeltaCheck _list)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();
            _datatable.Columns.Add("InvDeltaCheckId", typeof(System.Int64));
            _datatable.Columns.Add("InvestigationId", typeof(System.Int64));
            _datatable.Columns.Add("DeltaCalculationType", typeof(System.String));
            _datatable.Columns.Add("DeltaUnit", typeof(System.Decimal));
            _datatable.Columns.Add("TimeFrame", typeof(System.Int32));
            _datatable.Columns.Add("TimeUnit", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            DataRow _datarow;

            _datarow = _datatable.NewRow();
            _datarow["InvDeltaCheckId"] = _list.InvDeltaCheckId;
            _datarow["InvestigationId"] = _list.InvestigationId;
            _datarow["DeltaCalculationType"] = _list.DeltaCalculationType;
            _datarow["DeltaUnit"] = _list.DeltaUnit;
            _datarow["TimeFrame"] = _list.TimeFrame;
            _datarow["TimeUnit"] = _list.TimeUnit;
            _datarow["OrgID"] = _list.Orgid;
            _datatable.Rows.Add(_datarow);

            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToUDTInvBulkRate(List<RateCardMaster> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("SNO", typeof(System.Int32));
            _datatable.Columns.Add("RateTypeID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("TestCode", typeof(System.String));
            _datatable.Columns.Add("TestType", typeof(System.String));
            _datatable.Columns.Add("TestName", typeof(System.String));
            _datatable.Columns.Add("RateName", typeof(System.String));
            _datatable.Columns.Add("Rate", typeof(System.Decimal));
            _datatable.Columns.Add("LabShareAmount", typeof(System.Decimal));
            _datatable.Columns.Add("FranchiseeShareAmount", typeof(System.Decimal));

            DataRow _datarow;

            foreach (RateCardMaster _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["SNo"] = _list.SNo;
                _datarow["RateTypeID"] = _list.RateTypeID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["TestCode"] = _list.TestCode;
                _datarow["TestType"] = _list.TestType;
                _datarow["TestName"] = _list.TestName;
                _datarow["RateName"] = _list.RateName;
                _datarow["Rate"] = _list.Rate;
                _datarow["LabShareAmount"] = _list.LabShareAmount;
                _datarow["FranchiseeShareAmount"] = _list.FranchiseeShareAmount;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToRateCardBulkUdate(List<RateCardMaster> listInvRateMaster)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();
            _datatable.Columns.Add("SNo", typeof(System.Int32));
            _datatable.Columns.Add("RateTypeID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("TestCode", typeof(System.String));
            _datatable.Columns.Add("TestType", typeof(System.String));
            _datatable.Columns.Add("TestName", typeof(System.String));
            _datatable.Columns.Add("RateName", typeof(System.String));
            _datatable.Columns.Add("Rate", typeof(System.Decimal));
            _datatable.Columns.Add("LabShareAmount", typeof(System.Decimal));
            _datatable.Columns.Add("FranchiseeShareAmount", typeof(System.Decimal));

            DataRow _datarow;
            foreach (RateCardMaster _list in listInvRateMaster)
            {

                _datarow = _datatable.NewRow();
                _datarow["SNo"] = _list.SNo;
                _datarow["RateTypeID"] = _list.RateTypeID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["TestCode"] = _list.TestCode;
                _datarow["TestType"] = _list.TestType;
                _datarow["TestName"] = _list.TestName;
                _datarow["RateName"] = _list.RateName;
                _datarow["Rate"] = _list.Rate;
                _datarow["LabShareAmount"] = Decimal.Zero;
                _datarow["FranchiseeShareAmount"] = Decimal.Zero;
                _datatable.Rows.Add(_datarow);

            }
            return _datatable;

        }
        #region for NewWorkList
        public static System.Data.DataTable ConvertToUDTGenerateWorklist(List<NewWorkList> _lstworklist)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();


            _datatable.Columns.Add("ExternalVisitID", typeof(System.String));
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("AccessionNumber", typeof(System.Int64));
            _datatable.Columns.Add("SeqNo", typeof(System.Int32));

            DataRow _datarow;

            foreach (NewWorkList _list in _lstworklist)
            {
                _datarow = _datatable.NewRow();
                _datarow["externalVisitId"] = _list.ExternalVisitId;
                _datarow["patientVisitId"] = _list.PatientVisitId;
                _datarow["accessionNumber"] = _list.AccessionNumber;
                _datarow["seqNo"] = _list.SeqNo;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        #endregion
        public static System.Data.DataTable ConvertToUDTInvBulkDataValues(List<InvestigationBulkData> lstInvBulkValues)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();
            _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
            _datatable.Columns.Add("Name", typeof(System.String));
            _datatable.Columns.Add("Value", typeof(System.String));
            DataRow _datarow;

            foreach (InvestigationBulkData _list in lstInvBulkValues)
            {
                _datarow = _datatable.NewRow();
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datarow["Name"] = _list.Name;
                _datarow["Value"] = _list.Value;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTAdditionalTubeMapping(List<AdditionalTubeMapping> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ID", typeof(System.Int32));
            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("SampleCode", typeof(System.Int64));
            _datatable.Columns.Add("IsActive", typeof(System.String));

            DataRow _datarow;

            foreach (AdditionalTubeMapping _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ID"] = _list.ID;
                _datarow["Type"] = _list.Type;
                _datarow["SampleCode"] = _list.SampleCode;
                _datarow["IsActive"] = _list.IsActive;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToCouponValueMaster(List<CouponValueMaster> _lstCouponValueMaster)
        {
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("CouponId", typeof(System.Int32));
            _datatable.Columns.Add("CouponName", typeof(System.String));
            _datatable.Columns.Add("CouponBarcode", typeof(System.String));
            _datatable.Columns.Add("CouponValue", typeof(System.Decimal));
            _datatable.Columns.Add("ValidFrom", typeof(System.DateTime));
            _datatable.Columns.Add("ValidTo", typeof(System.DateTime));
            _datatable.Columns.Add("PhysicianId", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("AddressId", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("IsDelete", typeof(System.String));

            DataRow _datarow;
            foreach (CouponValueMaster _list in _lstCouponValueMaster)
            {
                _datarow = _datatable.NewRow();
                _datarow["CouponId"] = _list.CouponId;
                _datarow["CouponName"] = _list.CouponName;
                _datarow["CouponBarcode"] = _list.CouponBarcode;
                _datarow["CouponValue"] = _list.CouponValue;
                _datarow["ValidFrom"] = _list.ValidFrom;
                _datarow["ValidTo"] = _list.ValidTo;
                _datarow["PhysicianId"] = _list.PhysicianId;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["AddressId"] = _list.AddressId;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["Status"] = _list.Status;
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datarow["Type"] = _list.Type;
                _datarow["IsDelete"] = _list.IsDelete;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }
        public static System.Data.DataTable ConvertToRoundMasterAttributes(List<RoundMasterAttributes> _lstRoundAttributes)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ID", typeof(System.Int32));
            _datatable.Columns.Add("RoundID", typeof(System.Int64));
            _datatable.Columns.Add("ClinicID", typeof(System.Int32));
            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("SequenceNo", typeof(System.Int32));
            _datatable.Columns.Add("EstimatedTime", typeof(System.String));
            DataRow _datarow;
            foreach (RoundMasterAttributes _list in _lstRoundAttributes)
            {

                _datarow = _datatable.NewRow();
                _datarow["ID"] = _list.ID;
                _datarow["RoundID"] = _list.RoundID;
                _datarow["ClinicID"] = _list.ClinicID;
                _datarow["Type"] = _list.Type;
                _datarow["SequenceNo"] = _list.SequenceNo;
                _datarow["EstimatedTime"] = _list.EstimatedTime;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }
        #region For SetDefault Search
        public static System.Data.DataTable ConvertToUDTTaskDefaultSearch(List<TaskDefaultSearch> _lists)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("LoginID", typeof(System.Int64));
            _datatable.Columns.Add("RoleID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int64));
            _datatable.Columns.Add("OrgAddressID", typeof(System.Int64));
            _datatable.Columns.Add("LocationID", typeof(System.Int32));
            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("TypeID", typeof(System.Int32));
            _datatable.Columns.Add("Value", typeof(System.String));

            DataRow _datarow;

            foreach (TaskDefaultSearch _list in _lists)
            {
                _datarow = _datatable.NewRow();
                _datarow["LoginID"] = _list.LoginID;
                _datarow["RoleID"] = _list.RoleID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["OrgAddressID"] = _list.OrgAddressID;
                _datarow["LocationID"] = _list.LocationID;
                _datarow["Type"] = _list.Type;
                _datarow["TypeID"] = _list.TypeID;
                _datarow["Value"] = _list.Value;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        #endregion

        public static System.Data.DataTable ConvertToBulkCollectSample(List<PatientInvestigation> lstpatinv)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();
            _datatable.Columns.Add("AccessionNumber", typeof(System.Int64));
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("SampleID", typeof(System.Int32));
            _datatable.Columns.Add("UID", typeof(System.String));
            _datatable.Columns.Add("InvSampleStatusID", typeof(System.Int64));
            _datatable.Columns.Add("TaskID", typeof(System.String));
            _datatable.Columns.Add("CollectedDateTime", typeof(System.String));
            _datatable.Columns.Add("PatientName", typeof(System.String));
            _datatable.Columns.Add("PackageName", typeof(System.String));
            _datatable.Columns.Add("BarcodeNumber", typeof(System.String));

            DataRow _datarow;

            foreach (PatientInvestigation _list in lstpatinv)
            {
                _datarow = _datatable.NewRow();
                _datarow["AccessionNumber"] = _list.AccessionNumber;
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["SampleID"] = _list.SampleID;
                _datarow["UID"] = _list.UID;
                _datarow["InvSampleStatusID"] = _list.InvSampleStatusID;
                _datarow["TaskID"] = _list.KitName;
                _datarow["CollectedDateTime"] = _list.CollectedDateTime;
                _datarow["PatientName"] = _list.Name;
                _datarow["PackageName"] = _list.PackageName;
                _datarow["BarcodeNumber"] = _list.BarcodeNumber;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTReferralPolicy(List<ManageReferralPolicy> _lstCollection)
        {
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("Categoryid", typeof(System.Int32));
            _datatable.Columns.Add("CategoryName", typeof(System.String));
            _datatable.Columns.Add("Createdby", typeof(System.Int32));
            _datatable.Columns.Add("Modifiedby", typeof(System.Int32));
            _datatable.Columns.Add("Fromrange", typeof(System.Int64));
            _datatable.Columns.Add("Torange", typeof(System.Int64));
            _datatable.Columns.Add("Payout", typeof(System.Int64));
            _datatable.Columns.Add("Payon", typeof(System.Int32));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));

            DataRow _datarow;

            foreach (ManageReferralPolicy _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["Categoryid"] = _list.Categoryid;
                _datarow["CategoryName"] = _list.CategoryName;
                _datarow["Createdby"] = _list.Createdby;
                _datarow["Modifiedby"] = _list.Modifiedby;
                _datarow["Fromrange"] = _list.Fromrange;
                _datarow["Torange"] = _list.Torange;
                _datarow["Payout"] = _list.Payout;
                _datarow["Payon"] = _list.Payon;
                _datarow["OrgID"] = _list.OrgID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToFileUploadUDT(List<FileUploadDetails> _lstFileUploadDetails)
        {
            DataTable _datatable = new DataTable();
            _datatable.Columns.Add("DocFileIDs", typeof(Int64));
            _datatable.Columns.Add("DocFileName", typeof(String));
            _datatable.Columns.Add("DocFileUrl", typeof(String));
            _datatable.Columns.Add("IdentifyingType", typeof(String));
            _datatable.Columns.Add("IdentifyingID", typeof(String));
            _datatable.Columns.Add("DocType", typeof(String));
            _datatable.Columns.Add("DocDate", typeof(DateTime));

            DataRow _datarow;
            foreach (FileUploadDetails _list in _lstFileUploadDetails)
            {
                _datarow = _datatable.NewRow();
                _datarow["DocFileIDs"] = _list.DocFileID;
                _datarow["DocFileName"] = _list.DocFileName;
                _datarow["DocFileUrl"] = _list.DocFileUrl;
                _datarow["IdentifyingType"] = _list.IdentifyingType;
                _datarow["IdentifyingID"] = _list.IdentifyingID;
                _datarow["DocType"] = _list.Type;
                _datarow["DocDate"] = _list.DocDate;
                _datatable.Rows.Add(_datarow);

            }

            return _datatable;
        }

        public static System.Data.DataTable ConvertToStage2_MHL_T_01_TESTMASTER(List<Stage2_MHL_T_01_TESTMASTER> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("LAB", typeof(System.String));
            _datatable.Columns.Add("TCODE", typeof(System.String));
            _datatable.Columns.Add("EDOSCode", typeof(System.String));
            _datatable.Columns.Add("TestName", typeof(System.String));
            _datatable.Columns.Add("TEST_ABBREVATION", typeof(System.String));
            _datatable.Columns.Add("DISPLAY_NAME", typeof(System.String));
            _datatable.Columns.Add("DeptName", typeof(System.String));
            _datatable.Columns.Add("SECTION_NAME", typeof(System.String));
            _datatable.Columns.Add("TEST_GROUP", typeof(System.String));
            _datatable.Columns.Add("TEST_PARENT", typeof(System.String));
            _datatable.Columns.Add("Values_Type", typeof(System.String));
            _datatable.Columns.Add("Orderable", typeof(System.String));
            _datatable.Columns.Add("SEQUENCE_No", typeof(System.String));
            _datatable.Columns.Add("INPUT_FORMAT", typeof(System.String));
            _datatable.Columns.Add("Sample_Type", typeof(System.String));
            _datatable.Columns.Add("Method", typeof(System.String));
            _datatable.Columns.Add("Container", typeof(System.String));
            _datatable.Columns.Add("Units", typeof(System.String));
            _datatable.Columns.Add("SubCategory", typeof(System.String));
            _datatable.Columns.Add("PROCESSING_LOCATION", typeof(System.String));
            _datatable.Columns.Add("Decimal_Places", typeof(System.String));
            _datatable.Columns.Add("Classification", typeof(System.String));
            _datatable.Columns.Add("IS_MACHINE_INTERFACED", typeof(System.String));
            _datatable.Columns.Add("REPEATABLE", typeof(System.String));
            _datatable.Columns.Add("TEST_GENDER", typeof(System.String));
            _datatable.Columns.Add("IS_NABL", typeof(System.String));
            _datatable.Columns.Add("IS_CAP", typeof(System.String));
            _datatable.Columns.Add("IS_STAT", typeof(System.String));
            _datatable.Columns.Add("IS_SMS", typeof(System.String));
            _datatable.Columns.Add("IS_STATISTICAL", typeof(System.String));
            _datatable.Columns.Add("AUTORIZATION", typeof(System.String));
            _datatable.Columns.Add("CO_AUTHORIZATION", typeof(System.String));
            _datatable.Columns.Add("TAT_POLICY", typeof(System.String));
            _datatable.Columns.Add("REFERENCE_RANGE", typeof(System.String));
            _datatable.Columns.Add("CRITICAL_RANGE", typeof(System.String));
            _datatable.Columns.Add("IS_CRITICAL_ALERT", typeof(System.String));
            _datatable.Columns.Add("PANIC_RANGE", typeof(System.String));
            _datatable.Columns.Add("AUTO_AUTHORIZATION_RANGE", typeof(System.String));
            _datatable.Columns.Add("ACCEPTABLE_RANGE", typeof(System.String));
            _datatable.Columns.Add("TEST_EMERGENCY_STAGE", typeof(System.String));
            _datatable.Columns.Add("IS_TEST_HISTORY", typeof(System.String));
            _datatable.Columns.Add("InvestigationID", typeof(System.String));
            _datatable.Columns.Add("DISCOUNT_CATEGORY", typeof(System.String));
            _datatable.Columns.Add("TFORMAT", typeof(System.String));
            _datatable.Columns.Add("SPLFORMAT", typeof(System.String));
            _datatable.Columns.Add("TESTTYPE", typeof(System.String));
            _datatable.Columns.Add("CHILDOF", typeof(System.String));
            _datatable.Columns.Add("LOD", typeof(System.String));
            _datatable.Columns.Add("NOOFSAMPLES", typeof(System.String));
            _datatable.Columns.Add("OUTPUT_FORMAT", typeof(System.String));
            _datatable.Columns.Add("PCTS", typeof(System.String));
            _datatable.Columns.Add("AttType", typeof(System.String));
            _datatable.Columns.Add("CutOffTimeValue", typeof(System.String));
            _datatable.Columns.Add("CutOffTimeType", typeof(System.String));
            _datatable.Columns.Add("IsActive", typeof(System.String));
            _datatable.Columns.Add("IsNonReportable", typeof(System.String));
            _datatable.Columns.Add("PrintSeparately", typeof(System.String));
            _datatable.Columns.Add("IsParameter", typeof(System.String));
            _datatable.Columns.Add("Interpretation", typeof(System.String));
            _datatable.Columns.Add("DeptID", typeof(System.String));
            _datatable.Columns.Add("SampleCode", typeof(System.String));
            _datatable.Columns.Add("MethodID", typeof(System.String));
            _datatable.Columns.Add("SampleContainerID", typeof(System.String));
            _datatable.Columns.Add("HeaderId", typeof(System.String));
            _datatable.Columns.Add("AutoAuthorizationId", typeof(System.String));
            _datatable.Columns.Add("UOMID", typeof(System.String));
            _datatable.Columns.Add("Processing_AddressID", typeof(System.String));
            _datatable.Columns.Add("ProtocolGroup", typeof(System.String));
            _datatable.Columns.Add("ProtocolGroupID", typeof(System.Int32));
            _datatable.Columns.Add("I_Tcode", typeof(System.String));
            _datatable.Columns.Add("Billing_Name", typeof(System.String));
            _datatable.Columns.Add("flag", typeof(System.String));

            DataRow _datarow;

            foreach (Stage2_MHL_T_01_TESTMASTER _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["LAB"] = _list.LAB;
                _datarow["TCODE"] = _list.TCODE;
                _datarow["EDOSCode"] = _list.EDOSCode;
                _datarow["TestName"] = _list.TestName;
                _datarow["TEST_ABBREVATION"] = _list.TEST_ABBREVATION;
                _datarow["DISPLAY_NAME"] = _list.DISPLAY_NAME;
                _datarow["DeptName"] = _list.DeptName;
                _datarow["SECTION_NAME"] = _list.SECTION_NAME;
                _datarow["TEST_GROUP"] = _list.TEST_GROUP;
                _datarow["TEST_PARENT"] = _list.TEST_PARENT;
                _datarow["Values_Type"] = _list.Values_Type;
                _datarow["Orderable"] = _list.Orderable;
                _datarow["SEQUENCE_No"] = _list.SEQUENCE_No;
                _datarow["INPUT_FORMAT"] = _list.INPUT_FORMAT;
                _datarow["Sample_Type"] = _list.Sample_Type;
                _datarow["Method"] = _list.Method;
                _datarow["Container"] = _list.Container;
                _datarow["Units"] = _list.Units;
                _datarow["SubCategory"] = _list.SubCategory;
                _datarow["PROCESSING_LOCATION"] = _list.PROCESSING_LOCATION;
                _datarow["Decimal_Places"] = _list.Decimal_Places;
                _datarow["Classification"] = _list.Classification;
                _datarow["IS_MACHINE_INTERFACED"] = _list.IS_MACHINE_INTERFACED;
                _datarow["REPEATABLE"] = _list.REPEATABLE;
                _datarow["TEST_GENDER"] = _list.TEST_GENDER;
                _datarow["IS_NABL"] = _list.IS_NABL;
                _datarow["IS_CAP"] = _list.IS_CAP;
                _datarow["IS_STAT"] = _list.IS_STAT;
                _datarow["IS_SMS"] = _list.IS_SMS;
                _datarow["IS_STATISTICAL"] = _list.IS_STATISTICAL;
                _datarow["AUTORIZATION"] = _list.AUTORIZATION;
                _datarow["CO_AUTHORIZATION"] = _list.CO_AUTHORIZATION;
                _datarow["TAT_POLICY"] = _list.TAT_POLICY;
                _datarow["REFERENCE_RANGE"] = _list.REFERENCE_RANGE;
                _datarow["CRITICAL_RANGE"] = _list.CRITICAL_RANGE;
                _datarow["IS_CRITICAL_ALERT"] = _list.IS_CRITICAL_ALERT;
                _datarow["PANIC_RANGE"] = _list.PANIC_RANGE;
                _datarow["AUTO_AUTHORIZATION_RANGE"] = _list.AUTO_AUTHORIZATION_RANGE;
                _datarow["ACCEPTABLE_RANGE"] = _list.ACCEPTABLE_RANGE;
                _datarow["TEST_EMERGENCY_STAGE"] = _list.TEST_EMERGENCY_STAGE;
                _datarow["IS_TEST_HISTORY"] = _list.IS_TEST_HISTORY;
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datarow["DISCOUNT_CATEGORY"] = _list.DISCOUNT_CATEGORY;
                _datarow["TFORMAT"] = _list.TFORMAT;
                _datarow["SPLFORMAT"] = _list.SPLFORMAT;
                _datarow["TESTTYPE"] = _list.TESTTYPE;
                _datarow["CHILDOF"] = _list.CHILDOF;
                _datarow["LOD"] = _list.LOD;
                _datarow["NOOFSAMPLES"] = _list.NOOFSAMPLES;
                _datarow["OUTPUT_FORMAT"] = _list.OUTPUT_FORMAT;
                _datarow["PCTS"] = _list.PCTS;
                _datarow["AttType"] = _list.AttType;
                _datarow["CutOffTimeValue"] = _list.CutOffTimeValue;
                _datarow["CutOffTimeType"] = _list.CutOffTimeType;
                _datarow["IsActive"] = _list.IsActive;
                _datarow["IsNonReportable"] = _list.IsNonReportable;
                _datarow["PrintSeparately"] = _list.PrintSeparately;
                _datarow["IsParameter"] = _list.IsParameter;
                _datarow["Interpretation"] = _list.Interpretation;
                _datarow["DeptID"] = _list.DeptID;
                _datarow["SampleCode"] = _list.SampleCode;
                _datarow["MethodID"] = _list.MethodID;
                _datarow["SampleContainerID"] = _list.SampleContainerID;
                _datarow["HeaderId"] = _list.HeaderId;
                _datarow["AutoAuthorizationId"] = _list.AutoAuthorizationId;
                _datarow["UOMID"] = _list.UOMID;
                _datarow["Processing_AddressID"] = _list.Processing_AddressID;
                _datarow["ProtocolGroup"] = _list.ProtocolGroup;
                _datarow["ProtocolGroupID"] = _list.ProtocolGroupID;
                _datarow["I_Tcode"] = _list.I_Tcode;
                _datarow["Billing_Name"] = _list.Billing_Name;
                _datarow["flag"] = _list.Flag;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }


        public static System.Data.DataTable ConvertToStage2_MHL_T_02_GROUP_MASTER(List<Stage2_MHL_T_02_GROUP_MASTER> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("LAB", typeof(System.String));
            _datatable.Columns.Add("GROUPNAME", typeof(System.String));
            _datatable.Columns.Add("METRO_COMBINE_CODE", typeof(System.String));
            _datatable.Columns.Add("EDOSCODE", typeof(System.String));
            _datatable.Columns.Add("DISPLAY_NAME", typeof(System.String));
            _datatable.Columns.Add("ABBREVATION", typeof(System.String));
            _datatable.Columns.Add("IS_ORDERABLE", typeof(System.String));
            _datatable.Columns.Add("CLASSIFICATION", typeof(System.String));
            _datatable.Columns.Add("IS_NABL", typeof(System.String));
            _datatable.Columns.Add("IS_CAP", typeof(System.String));
            _datatable.Columns.Add("IS_STAT", typeof(System.String));
            _datatable.Columns.Add("TAT_POLICY", typeof(System.String));
            _datatable.Columns.Add("OrgGroupID", typeof(System.String));
            _datatable.Columns.Add("ValidationText", typeof(System.String));
            _datatable.Columns.Add("ValidationRule", typeof(System.String));
            _datatable.Columns.Add("IsDiscountable", typeof(System.String));
            _datatable.Columns.Add("IsServicetaxable", typeof(System.String));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("CutOffTimeValue", typeof(System.String));
            _datatable.Columns.Add("CutOffTimeType", typeof(System.String));
            _datatable.Columns.Add("SubCategory", typeof(System.String));
            _datatable.Columns.Add("HasHistory", typeof(System.String));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            _datatable.Columns.Add("PrintSeparately", typeof(System.String));
            _datatable.Columns.Add("Gender", typeof(System.String));
            _datatable.Columns.Add("groupinterpretation", typeof(System.String));
            _datatable.Columns.Add("Issummaryworklist", typeof(System.String));
            _datatable.Columns.Add("IsSpecialFormat", typeof(System.String));
            _datatable.Columns.Add("Groupid", typeof(System.String));
            _datatable.Columns.Add("ProtocolGroup", typeof(System.String));
            _datatable.Columns.Add("ProtocolGroupID", typeof(System.Int32));
            _datatable.Columns.Add("I_Tcode", typeof(System.String));
            _datatable.Columns.Add("Billing_Name", typeof(System.String));
            _datatable.Columns.Add("flag", typeof(System.String));

            DataRow _datarow;

            foreach (Stage2_MHL_T_02_GROUP_MASTER _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["LAB"] = _list.LAB;
                _datarow["GROUPNAME"] = _list.GROUPNAME;
                _datarow["METRO_COMBINE_CODE"] = _list.METRO_COMBINE_CODE;
                _datarow["EDOSCODE"] = _list.EDOSCODE;
                _datarow["DISPLAY_NAME"] = _list.DISPLAY_NAME;
                _datarow["ABBREVATION"] = _list.ABBREVATION;
                _datarow["IS_ORDERABLE"] = _list.IS_ORDERABLE;
                _datarow["CLASSIFICATION"] = _list.CLASSIFICATION;
                _datarow["IS_NABL"] = _list.IS_NABL;
                _datarow["IS_CAP"] = _list.IS_CAP;
                _datarow["IS_STAT"] = _list.IS_STAT;
                _datarow["TAT_POLICY"] = _list.TAT_POLICY;
                _datarow["OrgGroupID"] = _list.OrgGroupID;
                _datarow["ValidationText"] = _list.ValidationText;
                _datarow["ValidationRule"] = _list.ValidationRule;
                _datarow["IsDiscountable"] = _list.IsDiscountable;
                _datarow["IsServicetaxable"] = _list.IsServicetaxable;
                _datarow["Status"] = _list.Status;
                _datarow["CutOffTimeValue"] = _list.CutOffTimeValue;
                _datarow["CutOffTimeType"] = _list.CutOffTimeType;
                _datarow["SubCategory"] = _list.SubCategory;
                _datarow["HasHistory"] = _list.HasHistory;
                _datarow["Remarks"] = _list.Remarks;
                _datarow["PrintSeparately"] = _list.PrintSeparately;
                _datarow["Gender"] = _list.Gender;
                _datarow["groupinterpretation"] = _list.Groupinterpretation;
                _datarow["Issummaryworklist"] = _list.Issummaryworklist;
                _datarow["IsSpecialFormat"] = _list.IsSpecialFormat;
                _datarow["Groupid"] = _list.Groupid;
                _datarow["ProtocolGroup"] = _list.ProtocolGroup;
                _datarow["ProtocolGroupID"] = _list.ProtocolGroupID;
                _datarow["I_Tcode"] = _list.I_Tcode;
                _datarow["Billing_Name"] = _list.Billing_Name;
                _datarow["flag"] = _list.Flag;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }


        public static System.Data.DataTable ConvertToStage2_MHL_T_03_Package_Master(List<Stage2_MHL_T_03_Package_Master> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("LAB", typeof(System.String));
            _datatable.Columns.Add("PACKAGE_NAME", typeof(System.String));
            _datatable.Columns.Add("METROLAB_PROFILECODE", typeof(System.String));
            _datatable.Columns.Add("DOSCODE", typeof(System.String));
            _datatable.Columns.Add("OrgGroupID", typeof(System.String));
            _datatable.Columns.Add("InvestigationID", typeof(System.String));
            _datatable.Columns.Add("TestName", typeof(System.String));
            _datatable.Columns.Add("TEST_SEQUENCE_NO", typeof(System.String));
            _datatable.Columns.Add("Test_Name", typeof(System.String));
            _datatable.Columns.Add("DISPLAY_NAME", typeof(System.String));
            _datatable.Columns.Add("TAT_POLICY", typeof(System.String));
            _datatable.Columns.Add("IS_ORDERABLE", typeof(System.String));
            _datatable.Columns.Add("CLASSIFICATION", typeof(System.String));
            _datatable.Columns.Add("IS_NABL", typeof(System.String));
            _datatable.Columns.Add("IS_CAP", typeof(System.String));
            _datatable.Columns.Add("IS_STAT", typeof(System.String));
            _datatable.Columns.Add("ValidationText", typeof(System.String));
            _datatable.Columns.Add("ValidationRule", typeof(System.String));
            _datatable.Columns.Add("IsDiscountable", typeof(System.String));
            _datatable.Columns.Add("IsServicetaxable", typeof(System.String));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("CutOffTimeValue", typeof(System.String));
            _datatable.Columns.Add("CutOffTimeType", typeof(System.String));
            _datatable.Columns.Add("SubCategory", typeof(System.String));
            _datatable.Columns.Add("HasHistory", typeof(System.String));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            _datatable.Columns.Add("PrintSeparately", typeof(System.String));
            _datatable.Columns.Add("Gender", typeof(System.String));
            _datatable.Columns.Add("groupinterpretation", typeof(System.String));
            _datatable.Columns.Add("Issummaryworklist", typeof(System.String));
            _datatable.Columns.Add("IsSpecialFormat", typeof(System.String));
            _datatable.Columns.Add("ABBREVATION", typeof(System.String));
            _datatable.Columns.Add("Groupid", typeof(System.String));
            _datatable.Columns.Add("ProtocolGroup", typeof(System.String));
            _datatable.Columns.Add("ProtocolGroupID", typeof(System.Int32));
            _datatable.Columns.Add("I_Tcode", typeof(System.String));
            _datatable.Columns.Add("Billing_Name", typeof(System.String));
            _datatable.Columns.Add("Flag", typeof(System.String));

            DataRow _datarow;

            foreach (Stage2_MHL_T_03_Package_Master _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["LAB"] = _list.LAB;
                _datarow["PACKAGE_NAME"] = _list.PACKAGE_NAME;
                _datarow["METROLAB_PROFILECODE"] = _list.METROLAB_PROFILECODE;
                _datarow["DOSCODE"] = _list.DOSCODE;
                _datarow["OrgGroupID"] = _list.OrgGroupID;
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datarow["TestName"] = _list.Test;
                _datarow["TEST_SEQUENCE_NO"] = _list.TEST_SEQUENCE_NO;
                _datarow["Test_Name"] = _list.Test_Name;
                _datarow["DISPLAY_NAME"] = _list.DISPLAY_NAME;
                _datarow["TAT_POLICY"] = _list.TAT_POLICY;
                _datarow["IS_ORDERABLE"] = _list.IS_ORDERABLE;
                _datarow["CLASSIFICATION"] = _list.CLASSIFICATION;
                _datarow["IS_NABL"] = _list.IS_NABL;
                _datarow["IS_CAP"] = _list.IS_CAP;
                _datarow["IS_STAT"] = _list.IS_STAT;
                _datarow["ValidationText"] = _list.ValidationText;
                _datarow["ValidationRule"] = _list.ValidationRule;
                _datarow["IsDiscountable"] = _list.IsDiscountable;
                _datarow["IsServicetaxable"] = _list.IsServicetaxable;
                _datarow["Status"] = _list.Status;
                _datarow["CutOffTimeValue"] = _list.CutOffTimeValue;
                _datarow["CutOffTimeType"] = _list.CutOffTimeType;
                _datarow["SubCategory"] = _list.SubCategory;
                _datarow["HasHistory"] = _list.HasHistory;
                _datarow["Remarks"] = _list.Remarks;
                _datarow["PrintSeparately"] = _list.PrintSeparately;
                _datarow["Gender"] = _list.Gender;
                _datarow["groupinterpretation"] = _list.Groupinterpretation;
                _datarow["Issummaryworklist"] = _list.Issummaryworklist;
                _datarow["IsSpecialFormat"] = _list.IsSpecialFormat;
                _datarow["ABBREVATION"] = _list.ABBREVATION;
                _datarow["Groupid"] = _list.Groupid;
                _datarow["ProtocolGroup"] = _list.ProtocolGroup;
                _datarow["ProtocolGroupID"] = _list.ProtocolGroupID;
                _datarow["I_Tcode"] = _list.I_Tcode;
                _datarow["Billing_Name"] = _list.Billing_Name;
                _datarow["Flag"] = _list.Flag;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToStage2_MHL_T_04_GROUP_TESTS(List<Stage2_MHL_T_04_GROUP_TESTS> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("LAB", typeof(System.String));
            _datatable.Columns.Add("GROUP_CODE", typeof(System.String));
            _datatable.Columns.Add("TEST_CODE", typeof(System.String));
            _datatable.Columns.Add("TEST_NAME", typeof(System.String));
            _datatable.Columns.Add("TEST_SEQUENCE_NO", typeof(System.Double));
            _datatable.Columns.Add("InvestigationID", typeof(System.String));
            _datatable.Columns.Add("OrgGroupID", typeof(System.String));
            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("ID", typeof(System.Int32));
            _datatable.Columns.Add("flag", typeof(System.String));

            DataRow _datarow;

            foreach (Stage2_MHL_T_04_GROUP_TESTS _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["LAB"] = _list.LAB;
                _datarow["GROUP_CODE"] = _list.GROUP_CODE;
                _datarow["TEST_CODE"] = _list.TEST_CODE;
                _datarow["TEST_NAME"] = _list.TEST_NAME;
                _datarow["TEST_SEQUENCE_NO"] = _list.TEST_SEQUENCE_NO;
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datarow["OrgGroupID"] = _list.OrgGroupID;
                _datarow["Type"] = _list.Type;
                _datarow["ID"] = _list.ID;
                _datarow["flag"] = _list.Flag;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToStage2_MHL_T_05_PACKAGE_TESTS(List<Stage2_MHL_T_05_PACKAGE_TESTS> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("LAB", typeof(System.String));
            _datatable.Columns.Add("PACKAGE_CODE", typeof(System.String));
            _datatable.Columns.Add("TEST_CODE", typeof(System.String));
            _datatable.Columns.Add("TEST_NAME", typeof(System.String));
            _datatable.Columns.Add("TEST_SEQUENCE_NO", typeof(System.Double));
            _datatable.Columns.Add("InvestigationID", typeof(System.String));
            _datatable.Columns.Add("OrgGroupID", typeof(System.String));
            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("ID", typeof(System.String));
            _datatable.Columns.Add("Flag", typeof(System.String));

            DataRow _datarow;

            foreach (Stage2_MHL_T_05_PACKAGE_TESTS _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["LAB"] = _list.LAB;
                _datarow["PACKAGE_CODE"] = _list.PACKAGE_CODE;
                _datarow["TEST_CODE"] = _list.TEST_CODE;
                _datarow["TEST_NAME"] = _list.TEST_NAME;
                _datarow["TEST_SEQUENCE_NO"] = _list.TEST_SEQUENCE_NO;
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datarow["OrgGroupID"] = _list.OrgGroupID;
                _datarow["Type"] = _list.Type;
                _datarow["ID"] = _list.ID;
                _datarow["Flag"] = _list.Flag;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToStage_DeviceMap_Template(List<DeviceTestOrgMapping> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();
            _datatable.Columns.Add("SNo", typeof(System.Int32));
            _datatable.Columns.Add("DeviceID", typeof(System.String));
            _datatable.Columns.Add("TestCode", typeof(System.String));
            _datatable.Columns.Add("InvestigationName", typeof(System.String));
            _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
            _datatable.Columns.Add("Formula", typeof(System.String));
            _datatable.Columns.Add("Abnormal", typeof(System.String));
            _datatable.Columns.Add("IsActive", typeof(System.String));
            _datatable.Columns.Add("IsUpload", typeof(System.String));
            _datatable.Columns.Add("IsDownload", typeof(System.String));
            _datatable.Columns.Add("LocationID", typeof(System.Int32));
            _datatable.Columns.Add("OrgID", typeof(System.Int64));
            _datatable.Columns.Add("Flag", typeof(System.String));

            DataRow _datarow;
            foreach (DeviceTestOrgMapping _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["SNo"] = _list.SNo;
                _datarow["DeviceID"] = _list.DeviceID;
                _datarow["TestCode"] = _list.TestCode;
                _datarow["InvestigationName"] = _list.InvestigationName;
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datarow["Formula"] = _list.Formula;
                _datarow["Abnormal"] = _list.Abnormal;
                _datarow["IsActive"] = _list.IsActive;
                _datarow["IsUpload"] = _list.IsUpload;
                _datarow["IsDownload"] = _list.IsDownload;
                _datarow["LocationID"] = _list.LocationID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["Flag"] = _list.Flag;
                _datatable.Rows.Add(_datarow);
            }

            return _datatable;
            //Device
        }

        public static System.Data.DataTable ConvertToStage_User_Template(List<Stage_User_Template> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("LoginName", typeof(System.String));
            _datatable.Columns.Add("UserName", typeof(System.String));
            _datatable.Columns.Add("SurName", typeof(System.String));
            _datatable.Columns.Add("DOB", typeof(System.DateTime));
            _datatable.Columns.Add("Sex", typeof(System.String));
            _datatable.Columns.Add("Email", typeof(System.String));
            _datatable.Columns.Add("Salutation", typeof(System.String));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("MaritalStatus", typeof(System.String));
            _datatable.Columns.Add("Qualification", typeof(System.String));
            _datatable.Columns.Add("Role", typeof(System.String));
            DataRow _datarow;

            foreach (Stage_User_Template _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["LoginName"] = _list.LoginName;
                _datarow["UserName"] = _list.UserName;
                _datarow["SurName"] = _list.SurName;
                _datarow["DOB"] = _list.DOB;
                _datarow["Sex"] = _list.Sex;
                _datarow["Email"] = _list.Email;
                _datarow["Salutation"] = _list.Salutation;
                _datarow["Status"] = _list.Status;
                _datarow["MaritalStatus"] = _list.MaritalStatus;
                _datarow["Qualification"] = _list.Qualification;
                _datarow["Role"] = _list.Role;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTClientBasicDetails(List<ClientBasicDetails> _lstCollection)
        {

            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ClientCode", typeof(System.String));
            _datatable.Columns.Add("ClientType", typeof(System.Int32));
            _datatable.Columns.Add("RegistrationType", typeof(System.String));
            _datatable.Columns.Add("HasParent", typeof(System.Boolean));
            _datatable.Columns.Add("txtHasparent", typeof(System.Int64));
            _datatable.Columns.Add("CCLabReport", typeof(System.String));
            _datatable.Columns.Add("SplPrivileges", typeof(System.Int32));
            _datatable.Columns.Add("OrderableLocation", typeof(System.String));
            _datatable.Columns.Add("PrintLocation", typeof(System.Int64));
            _datatable.Columns.Add("NoofPrintCopies", typeof(System.Int32));
            _datatable.Columns.Add("Location", typeof(System.Int64));
            _datatable.Columns.Add("Hub", typeof(System.Int64));
            _datatable.Columns.Add("Zone", typeof(System.Int64));
            _datatable.Columns.Add("Route", typeof(System.Int64));
            _datatable.Columns.Add("TransitTime", typeof(System.Int32));
            _datatable.Columns.Add("ddlTransitTime", typeof(System.String));
            _datatable.Columns.Add("ExAutoAuthorization", typeof(System.String));
            DataRow _datarow;

            foreach (ClientBasicDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ClientCode"] = _list.ClientCode;
                _datarow["ClientType"] = _list.ClientType;
                _datarow["RegistrationType"] = _list.RegistrationType;
                _datarow["HasParent"] = _list.HasParent;
                _datarow["txtHasparent"] = _list.txtHasparent;
                _datarow["CCLabReport"] = _list.CCLabReport;
                _datarow["SplPrivileges"] = _list.SplPrivileges;
                _datarow["OrderableLocation"] = _list.OrderableLocation;
                _datarow["PrintLocation"] = _list.PrintLocation;
                _datarow["NoofPrintCopies"] = _list.NoofPrintCopies;
                _datarow["Location"] = _list.Location;
                _datarow["Hub"] = _list.Hub;
                _datarow["Zone"] = _list.Zone;
                _datarow["Route"] = _list.Route;
                _datarow["TransitTime"] = _list.TransitTime;
                _datarow["ddlTransitTime"] = _list.ddlTransitTime;
                _datarow["ExAutoAuthorization"] = _list.ExAutoAuthorization;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;

        }
        public static System.Data.DataTable ConvertToUDTClientCommunication(List<ClientCommunication> _lstCollection)
        {
            System.Data.DataTable _datatable = new System.Data.DataTable();
            _datatable.Columns.Add("ClientId", typeof(System.Int32));
            _datatable.Columns.Add("ComMode", typeof(System.String));
            _datatable.Columns.Add("NotifyType", typeof(System.String));
            _datatable.Columns.Add("ComDetails", typeof(System.String));
            _datatable.Columns.Add("BlockNotify", typeof(System.Boolean));

            DataRow _datarow;

            foreach (ClientCommunication _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ClientId"] = _list.ClientId;
                _datarow["ComMode"] = _list.ComMode;
                _datarow["NotifyType"] = _list.NotifyType;
                _datarow["ComDetails"] = _list.ComDetails;
                _datarow["BlockNotify"] = _list.BlockNotify;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;

        }
        public static System.Data.DataTable ConvertToUDTClientCreditDetails(List<ClientCreditDetails> _lstCollection)
        {

            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("BusinessType", typeof(System.Int64));
            _datatable.Columns.Add("CSTNo", typeof(System.String));
            _datatable.Columns.Add("ServiceTaxNo", typeof(System.String));
            _datatable.Columns.Add("PANNo", typeof(System.String));
            _datatable.Columns.Add("SAPCode", typeof(System.String));
            _datatable.Columns.Add("CurrencyType", typeof(System.Int32));
            _datatable.Columns.Add("PaymentCategory", typeof(System.String));
            _datatable.Columns.Add("AllowServiceMapping", typeof(System.String));
            _datatable.Columns.Add("InvoiceCycle", typeof(System.String));
            _datatable.Columns.Add("CouponSystem", typeof(System.String));
            _datatable.Columns.Add("InvoiceApprovalRequired", typeof(System.String));
            _datatable.Columns.Add("AllowBillingDiscount", typeof(System.String));
            _datatable.Columns.Add("ClientStatus", typeof(System.String));
            _datatable.Columns.Add("Reason", typeof(System.String));
            _datatable.Columns.Add("Action", typeof(System.String));
            _datatable.Columns.Add("FromDate", typeof(System.DateTime));
            _datatable.Columns.Add("ToDate", typeof(System.DateTime));
            _datatable.Columns.Add("CreditLimit", typeof(System.Decimal));
            _datatable.Columns.Add("CreditDays", typeof(System.Int64));
            _datatable.Columns.Add("GraceLimit", typeof(System.Decimal));
            _datatable.Columns.Add("GraceDays", typeof(System.Int64));
            _datatable.Columns.Add("AdvanceThreshold", typeof(System.String));
            _datatable.Columns.Add("Value", typeof(System.Decimal));
            _datatable.Columns.Add("MinimumDeposite", typeof(System.Decimal));

            DataRow _datarow;

            foreach (ClientCreditDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["BusinessType"] = _list.BusinessType;
                _datarow["CSTNo"] = _list.CSTNo;
                _datarow["ServiceTaxNo"] = _list.ServiceTaxNo;
                _datarow["PANNo"] = _list.PANNo;
                _datarow["SAPCode"] = _list.SAPCode;
                _datarow["CurrencyType"] = _list.CurrencyType;
                _datarow["PaymentCategory"] = _list.PaymentCategory;
                _datarow["AllowServiceMapping"] = _list.AllowServiceMapping;
                _datarow["InvoiceCycle"] = _list.InvoiceCycle;
                _datarow["CouponSystem"] = _list.CouponSystem;
                _datarow["InvoiceApprovalRequired"] = _list.InvoiceApprovalRequired;
                _datarow["AllowBillingDiscount"] = _list.AllowBillingDiscount;
                _datarow["ClientStatus"] = _list.ClientStatus;
                _datarow["Reason"] = _list.Reason;
                _datarow["Action"] = _list.Action;
                _datarow["FromDate"] = Convert.ToDateTime(_list.FromDate.ToString("dd/MM/yyyy"));
                _datarow["ToDate"] = Convert.ToDateTime(_list.ToDate.ToString("dd/MM/yyyy"));
                _datarow["CreditLimit"] = _list.CreditLimit;
                _datarow["CreditDays"] = _list.CreditDays;
                _datarow["GraceLimit"] = _list.GraceLimit;
                _datarow["GraceDays"] = _list.GraceDays;
                _datarow["AdvanceThreshold"] = _list.AdvanceThreshold;
                _datarow["Value"] = _list.Value;
                _datarow["MinimumDeposite"] = _list.MinimumDeposite;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;

        }
        public static System.Data.DataTable ConvertToUDTClientDiscountPolicyMapping(List<ClientDiscountPolicyMapping> _lstCollection)
        {

            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ClientId", typeof(System.Int32));
            _datatable.Columns.Add("PolicyType", typeof(System.String));
            _datatable.Columns.Add("PolicyID", typeof(System.Int64));
            _datatable.Columns.Add("ValidFrom", typeof(System.DateTime));
            _datatable.Columns.Add("ValidTo", typeof(System.DateTime));
            _datatable.Columns.Add("IsActive", typeof(System.Boolean));

            DataRow _datarow;
            foreach (ClientDiscountPolicyMapping _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ClientId"] = _list.ClientID;
                _datarow["PolicyType"] = _list.PolicyType;
                _datarow["PolicyID"] = _list.PolicyID;
                _datarow["ValidFrom"] = Convert.ToDateTime(_list.ValidFrom);
                _datarow["ValidTo"] = Convert.ToDateTime(_list.ValidTo);
                _datarow["IsActive"] = _list.IsActive;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;

        }
        public static System.Data.DataTable ConvertToClientServiceExclusivityUDT(List<ClientServiceExclusivity> _lstCSExclusivityDetails)
        {
            DataTable _datatable = new DataTable();
            _datatable.Columns.Add("ClientId", typeof(Int64));
            _datatable.Columns.Add("FeeID", typeof(Int64));
            _datatable.Columns.Add("FeeType", typeof(String));
            _datatable.Columns.Add("ReferenceType", typeof(String));
            _datatable.Columns.Add("OrgID", typeof(Int32));
            _datatable.Columns.Add("SCode", typeof(String));
            _datatable.Columns.Add("IsExclusive", typeof(bool));

            DataRow _datarow;
            foreach (ClientServiceExclusivity _list in _lstCSExclusivityDetails)
            {
                _datarow = _datatable.NewRow();
                _datarow["ClientId"] = _list.ClientId;
                _datarow["FeeID"] = _list.FeeID;
                _datarow["FeeType"] = _list.FeeType;
                _datarow["ReferenceType"] = _list.ReferenceType;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["SCode"] = _list.SCode;
                _datarow["IsExclusive"] = _list.IsExclusive;
                _datatable.Rows.Add(_datarow);

            }

            return _datatable;
        }

       #region  DHANA R(30-04-2015)

       //MANAGE INVESTIGATION AND GROUP MODULE

       public static System.Data.DataTable ConvertToInvGroupMapMaster(List<InvOrgGroup> _lstCollection)
       {
           //lan
           System.Data.DataTable _datatable = new System.Data.DataTable();

           _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
           _datatable.Columns.Add("InvestigationName", typeof(System.String));
           _datatable.Columns.Add("SequenceNo", typeof(System.Int32));
           _datatable.Columns.Add("Type", typeof(System.String));
           _datatable.Columns.Add("OrgID", typeof(System.Int32));

           DataRow _datarow;

           foreach (InvOrgGroup _list in _lstCollection)
           {
               _datarow = _datatable.NewRow();
               _datarow["InvestigationID"] = _list.InvestigationID;
               _datarow["InvestigationName"] = _list.InvestigationName;
               _datarow["SequenceNo"] = _list.SequenceNo;
               _datarow["Type"] = _list.Type;
               _datarow["OrgID"] = _list.OrgID;
               _datatable.Rows.Add(_datarow);
           }
           return _datatable;
           //Test
       }

       public static System.Data.DataTable ConvertInvGroupMapMasterPackage(List<InvOrgGroup> _lstCollection)
       {
           //lan
           System.Data.DataTable _datatable = new System.Data.DataTable();

           _datatable.Columns.Add("PType", typeof(System.String));
           _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
           _datatable.Columns.Add("InvestigationName", typeof(System.String));
           _datatable.Columns.Add("SequenceNo", typeof(System.Int32));
           _datatable.Columns.Add("Type", typeof(System.String));
           _datatable.Columns.Add("PackageId", typeof(System.Int32));
           _datatable.Columns.Add("IsReflex", typeof(System.String));
           _datatable.Columns.Add("IsRePortable", typeof(System.String));
           _datatable.Columns.Add("OrgID", typeof(System.Int32));

           DataRow _datarow;

           foreach (InvOrgGroup _list in _lstCollection)
           {
               _datarow = _datatable.NewRow();
               _datarow["PType"] = "";
               _datarow["InvestigationID"] = _list.InvestigationID;
               _datarow["InvestigationName"] = _list.InvestigationName;
               _datarow["SequenceNo"] = _list.SequenceNo;
               _datarow["Type"] = _list.Type;
               _datarow["PackageId"] = _list.PackageID;
               _datarow["IsReflex"] = _list.IsReflex;
               _datarow["IsRePortable"] = _list.IsReportable;
               _datarow["OrgID"] = _list.OrgID;
               _datatable.Rows.Add(_datarow);
           }
           return _datatable;
           
       }

        //                               END                                      //

       #endregion
       public static System.Data.DataTable ConvertToUDTDocPayout(List<DoctorPayoutDetails> _lstCollection)
       {
           //lan
           System.Data.DataTable _datatable = new System.Data.DataTable();

           _datatable.Columns.Add("ReferingPhysicianID", typeof(System.Int32));
           _datatable.Columns.Add("OutStanding", typeof(System.Decimal));
           _datatable.Columns.Add("BillAmount", typeof(System.Decimal));
           _datatable.Columns.Add("DisCount", typeof(System.Decimal));
           _datatable.Columns.Add("NetAmount", typeof(System.Decimal));
           _datatable.Columns.Add("PayableAmount", typeof(System.Decimal));
           _datatable.Columns.Add("Paidamount", typeof(System.Decimal));
           _datatable.Columns.Add("Status", typeof(System.String));



           DataRow _datarow;
           foreach (DoctorPayoutDetails _list in _lstCollection)
           {
               _datarow = _datatable.NewRow();

               _datarow["ReferingPhysicianID"] = _list.ReferingPhysicianID;
               _datarow["OutStanding"] = _list.OutStanding;
               _datarow["BillAmount"] = _list.BillAmount;
               _datarow["DisCount"] = _list.DisCount;
               _datarow["NetAmount"] = _list.NetAmount;
               _datarow["PayableAmount"] = _list.PayableAmount;
               _datarow["Paidamount"] = _list.Paidamount;
               _datarow["Status"] = _list.Status;
               _datatable.Rows.Add(_datarow);
           }
           return _datatable;
           //Test
       }
       public static System.Data.DataTable ConvertToUDTFinalbillid(List<DoctorPayoutDetails> _lstCollection)
       {
           //lan
           System.Data.DataTable _datatable = new System.Data.DataTable();
           _datatable.Columns.Add("Finalbillid", typeof(System.Int64));
           _datatable.Columns.Add("ReferingPhysicianID", typeof(System.Int32));
           _datatable.Columns.Add("Remarks", typeof(System.String));

           DataRow _datarow;
           foreach (DoctorPayoutDetails _list in _lstCollection)
           {
               _datarow = _datatable.NewRow();
               _datarow["Finalbillid"] = _list.Finalbillid;
               _datarow["ReferingPhysicianID"] = _list.ReferingPhysicianID;
               _datarow["Remarks"] = _list.Remarks;
               _datatable.Rows.Add(_datarow);
           }
           return _datatable;
           //Test
       }
       public static System.Data.DataTable ConvertToInvRR(List<BulkReferenceRange> _lstCollection)
       {
           //lan
           System.Data.DataTable _datatable = new System.Data.DataTable();

           _datatable.Columns.Add("TestCode", typeof(System.String));
           _datatable.Columns.Add("RangeType", typeof(System.String));
           _datatable.Columns.Add("GenderValue", typeof(System.String));
           _datatable.Columns.Add("SubCategoryType", typeof(System.String));
           _datatable.Columns.Add("ResultType", typeof(System.String));
           _datatable.Columns.Add("TypeMode", typeof(System.String));
           _datatable.Columns.Add("AgeRangeType", typeof(System.String));
           _datatable.Columns.Add("AgeRange", typeof(System.String));
           _datatable.Columns.Add("ReferenceName", typeof(System.String));
           _datatable.Columns.Add("ValueTypeMode", typeof(System.String));
           _datatable.Columns.Add("Value", typeof(System.String));
           _datatable.Columns.Add("IsNormal", typeof(System.String));
           _datatable.Columns.Add("IsSourceText", typeof(System.String));
           _datatable.Columns.Add("ReferenceRange", typeof(System.String));
           _datatable.Columns.Add("Interpretation", typeof(System.String));
           _datatable.Columns.Add("Device", typeof(System.String));
           _datatable.Columns.Add("Status", typeof(System.Boolean));
           _datatable.Columns.Add("OrgID", typeof(System.Int32));
           _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
           _datatable.Columns.Add("InvestigationName", typeof(System.String));

           DataRow _datarow;
           foreach (BulkReferenceRange _list in _lstCollection)
           {
               _datarow = _datatable.NewRow();
               _datarow["TestCode"] = _list.TestCode;
               _datarow["RangeType"] = _list.RangeType;
               _datarow["GenderValue"] = _list.GenderValue;
               _datarow["SubCategoryType"] = _list.SubCategoryType;
               _datarow["ResultType"] = _list.ResultType;
               _datarow["TypeMode"] = _list.TypeMode;
               _datarow["AgeRangeType"] = _list.AgeRangeType;
               _datarow["AgeRange"] = _list.AgeRange;
               _datarow["ReferenceName"] = _list.ReferenceName;
               _datarow["ValueTypeMode"] = _list.ValueTypeMode;
               _datarow["Value"] = _list.Value;
               _datarow["IsNormal"] = _list.IsNormal;
               _datarow["IsSourceText"] = _list.IsSourceText;
               _datarow["ReferenceRange"] = _list.ReferenceRange;
               _datarow["Interpretation"] = _list.Interpretation;
               _datarow["Device"] = _list.Device;
               _datarow["Status"] = _list.Status;
               _datarow["OrgID"] = _list.OrgID;
               _datarow["InvestigationID"] = _list.InvestigationID;
               _datarow["InvestigationName"] = _list.InvestigationName;
               _datatable.Rows.Add(_datarow);
           }
           return _datatable;
       }
       public static System.Data.DataTable ConvertToStage_LocationMaster(List<Stage_LocationMaster> _lstCollection)
       {
           //lan
           System.Data.DataTable _datatable = new System.Data.DataTable();

           _datatable.Columns.Add("OrgName", typeof(System.String));
           _datatable.Columns.Add("LocationName", typeof(System.String));
           _datatable.Columns.Add("LocationCode", typeof(System.String));
           _datatable.Columns.Add("Address1", typeof(System.String));
           _datatable.Columns.Add("Address2", typeof(System.String));
           _datatable.Columns.Add("City", typeof(System.String));
           _datatable.Columns.Add("State", typeof(System.String));
           _datatable.Columns.Add("Country", typeof(System.String));
           _datatable.Columns.Add("PostalCode", typeof(System.String));
           _datatable.Columns.Add("TransitTime", typeof(System.Int32));
           _datatable.Columns.Add("Mobile", typeof(System.String));
           _datatable.Columns.Add("LandLine", typeof(System.String));
           _datatable.Columns.Add("LocationType", typeof(System.String));
           _datatable.Columns.Add("Status", typeof(System.String));
           _datatable.Columns.Add("IsMappedClients", typeof(System.String));
           _datatable.Columns.Add("ClientCode", typeof(System.String));
           _datatable.Columns.Add("ClientName", typeof(System.String));
           _datatable.Columns.Add("IsDefault", typeof(System.String));
           _datatable.Columns.Add("Flag", typeof(System.String));

           DataRow _datarow;

           foreach (Stage_LocationMaster _list in _lstCollection)
           {
               _datarow = _datatable.NewRow();
               _datarow["OrgName"] = _list.OrgName;
               _datarow["LocationName"] = _list.LocationName;
               _datarow["LocationCode"] = _list.LocationCode;
               _datarow["Address1"] = _list.Address1;
               _datarow["Address2"] = _list.Address2;
               _datarow["City"] = _list.City;
               _datarow["State"] = _list.State;
               _datarow["Country"] = _list.Country;
               _datarow["PostalCode"] = _list.PostalCode;
               _datarow["TransitTime"] = _list.TransitTime;
               _datarow["Mobile"] = _list.Mobile;
               _datarow["LandLine"] = _list.LandLine;
               _datarow["LocationType"] = _list.LocationType;
               _datarow["Status"] = _list.Status;
               _datarow["IsMappedClients"] = _list.IsMappedClients;
               _datarow["ClientCode"] = _list.ClientCode;
               _datarow["ClientName"] = _list.ClientName;
               _datarow["IsDefault"] = _list.IsDefault;
               _datarow["Flag"] = _list.Flag;
               _datatable.Rows.Add(_datarow);
           }
           return _datatable;
           //Test
       }

       public static System.Data.DataTable ConvertToStage_Physician(List<PStage_Physician> _lstCollection)
       {
           //lan
           System.Data.DataTable _datatable = new System.Data.DataTable();

           _datatable.Columns.Add("SNO", typeof(System.Int64));
           _datatable.Columns.Add("PhysicianName", typeof(System.String));
           _datatable.Columns.Add("PhysicianCode", typeof(System.String));
           _datatable.Columns.Add("DOB", typeof(System.DateTime));
           _datatable.Columns.Add("Age", typeof(System.String));
           _datatable.Columns.Add("Sex", typeof(System.String));
           _datatable.Columns.Add("Qualification", typeof(System.String));
           _datatable.Columns.Add("Designation", typeof(System.String));
           _datatable.Columns.Add("Address1", typeof(System.String));
           _datatable.Columns.Add("Address2", typeof(System.String));
           _datatable.Columns.Add("City", typeof(System.String));
           _datatable.Columns.Add("State", typeof(System.String));
           _datatable.Columns.Add("Country", typeof(System.String));
           _datatable.Columns.Add("MobileNumber", typeof(System.String));
           _datatable.Columns.Add("Emailid", typeof(System.String));
           _datatable.Columns.Add("LandLineNo", typeof(System.String));
           _datatable.Columns.Add("FaxNo", typeof(System.String));
           _datatable.Columns.Add("ISCLIENT", typeof(System.String));
           _datatable.Columns.Add("DiscountLimit", typeof(System.Decimal));
           _datatable.Columns.Add("DiscountValidFrom", typeof(System.DateTime));
           _datatable.Columns.Add("DiscountValidTo", typeof(System.DateTime));
           _datatable.Columns.Add("HasReportingSms", typeof(System.String));
           _datatable.Columns.Add("HasReportingEmail", typeof(System.String));
           _datatable.Columns.Add("ReferalHospitalName", typeof(System.String));
           _datatable.Columns.Add("ReferalHospitalCode", typeof(System.String));
           _datatable.Columns.Add("Flag", typeof(System.String));


           DataRow _datarow;

           foreach (PStage_Physician _list in _lstCollection)
           {
               _datarow = _datatable.NewRow();
               _datarow["SNO"] = _list.SNO;
               _datarow["PhysicianName"] = _list.PhysicianName;
               _datarow["PhysicianCode"] = _list.PhysicianCode;
               _datarow["DOB"] = _list.DOB;
               _datarow["AGE"] = _list.AGE;
               _datarow["Sex"] = _list.Sex;
               _datarow["Qualification"] = _list.Qualification;
               _datarow["Designation"] = _list.Designation;
               _datarow["Address1"] = _list.Address1;
               _datarow["Address2"] = _list.Address2;
               _datarow["City"] = _list.City;
               _datarow["State"] = _list.State;
               _datarow["Country"] = _list.Country;
               _datarow["MobileNumber"] = _list.MobileNumber;
               _datarow["Emailid"] = _list.Emailid;
               _datarow["LandLineNo"] = _list.LandLineNo;
               _datarow["FaxNo"] = _list.FaxNo;
               _datarow["ISCLIENT"] = _list.ISCLIENT;
               _datarow["DiscountLimit"] = _list.DiscountLimit;
               _datarow["DiscountValidFrom"] = _list.DiscountValidFrom;
               _datarow["DiscountValidTo"] = _list.DiscountValidTo;
               _datarow["HasReportingSms"] = _list.HasReportingSms;
               _datarow["HasReportingEmail"] = _list.HasReportingEmail;
               _datarow["ReferalHospitalName"] = _list.ReferalHospitalName;
               _datarow["ReferalHospitalCode"] = _list.ReferalHospitalCode;
               _datarow["Flag"] = _list.Flag;

               _datatable.Rows.Add(_datarow);
           }
           return _datatable;
           //Test
       }
       public static System.Data.DataTable ConvertToClientDetails(List<ClientDetails_Integration> _lstClientDetails)
       {
           //lan
           System.Data.DataTable _datatable = new System.Data.DataTable();

           _datatable.Columns.Add("ClientCode", typeof(System.String));
           _datatable.Columns.Add("ClientName", typeof(System.String));
           _datatable.Columns.Add("OrgId", typeof(System.Int32));
           _datatable.Columns.Add("ClientType", typeof(System.Int32));
           _datatable.Columns.Add("CustomerType", typeof(System.Int64));
           _datatable.Columns.Add("CountryCode", typeof(System.String));
           _datatable.Columns.Add("StateCode", typeof(System.String));
           _datatable.Columns.Add("EmailID", typeof(System.String));
           _datatable.Columns.Add("PhoneNo", typeof(System.String));
           _datatable.Columns.Add("MobileNo", typeof(System.String));
           _datatable.Columns.Add("AddressDetails", typeof(System.String));
           _datatable.Columns.Add("City", typeof(System.String));
           _datatable.Columns.Add("ISCash", typeof(System.String));

           DataRow _datarow;

           foreach (ClientDetails_Integration _list in _lstClientDetails)
           {
               _datarow = _datatable.NewRow();
               _datarow["ClientCode"] = _list.ClientCode;
               _datarow["ClientName"] = _list.ClientName;
               _datarow["OrgId"] = _list.OrgId;
               _datarow["ClientType"] = _list.ClientType;
               _datarow["CustomerType"] = _list.CustomerType;
               _datarow["EmailID"] = _list.EmailID;
               _datarow["PhoneNo"] = _list.PhoneNo;
               _datarow["MobileNo"] = _list.MobileNo;
               _datarow["AddressDetails"] = _list.AddressDetails;
               _datarow["City"] = _list.City;
               _datarow["ISCash"] = _list.ISCash;
               _datatable.Rows.Add(_datarow);
           }
           return _datatable;
           //Test
       }
	   public static System.Data.DataTable ConvertToPreQuotationInvestigations(List<PreQuotationInvestigationsCustom> _Prelist)
       {
           //lan
           System.Data.DataTable _datatable = new System.Data.DataTable();

           _datatable.Columns.Add("ID", typeof(System.Int64));
           _datatable.Columns.Add("Name", typeof(System.String));
           _datatable.Columns.Add("Type", typeof(System.String));
           _datatable.Columns.Add("SampleType", typeof(System.String));
           _datatable.Columns.Add("SampleCount", typeof(System.Int32));
           _datatable.Columns.Add("DiscountType", typeof(System.String));
           _datatable.Columns.Add("DiscountValue", typeof(System.Decimal));
           _datatable.Columns.Add("Amount", typeof(System.Decimal));
           _datatable.Columns.Add("Status", typeof(System.String));
           _datatable.Columns.Add("PkgID", typeof(System.Int64));
           _datatable.Columns.Add("PkgName", typeof(System.String));
           _datatable.Columns.Add("AccessionNumber", typeof(System.Int64));
           _datatable.Columns.Add("PkgAmt", typeof(System.Decimal));

           DataRow _datarow;

           foreach (PreQuotationInvestigationsCustom _list in _Prelist)
           {
               _datarow = _datatable.NewRow();
               _datarow["ID"] = _list.ID;
               _datarow["Name"] = _list.Name;
               _datarow["Type"] = _list.Type;
               _datarow["SampleType"] = _list.SampleType;
               _datarow["SampleCount"] = _list.SampleCount;
               _datarow["DiscountType"] = _list.DiscountType;
               _datarow["DiscountValue"] = _list.DiscountValue;
               _datarow["Amount"] = _list.Amount;
               _datarow["Status"] = _list.Status;
               _datarow["PkgID"] = _list.PkgID;
               _datarow["PkgName"] = _list.PkgName;
               _datarow["AccessionNumber"] = _list.AccessionNumber;
               _datarow["PkgAmt"] = _list.PkgAmt;
               _datatable.Rows.Add(_datarow);
           }
           return _datatable;
           //Test
       }
       public static System.Data.DataTable ConvertToSampleSchedule_Sample(List<SampleSchedule> _lstCollection)
       {
           //lan
           System.Data.DataTable _datatable = new System.Data.DataTable();



           _datatable.Columns.Add("RowID", typeof(System.Int64));
           _datatable.Columns.Add("SampleID", typeof(System.String));
           _datatable.Columns.Add("ScheduledTime", typeof(System.DateTime));
           _datatable.Columns.Add("TestingAddress", typeof(System.String));
           _datatable.Columns.Add("CollectedBy", typeof(System.Int32));
           _datatable.Columns.Add("QuotationNO", typeof(System.String));
           _datatable.Columns.Add("SampleStatus", typeof(System.String));


           DataRow _datarow;

           foreach (SampleSchedule _list in _lstCollection)
           {
               _datarow = _datatable.NewRow();
               _datarow["RowID"] = _list.RowID;
               _datarow["SampleID"] = _list.SampleID;
               _datarow["ScheduledTime"] = _list.ScheduledTime;
               _datarow["TestingAddress"] = _list.TestingAddress;
               _datarow["CollectedBy"] = _list.CollectedBy;
               _datarow["QuotationNO"] = _list.QuotationNO;
               _datarow["SampleStatus"] = _list.Status;

               _datatable.Rows.Add(_datarow);
           }
           return _datatable;
           //Test
       }

	   
	    public static System.Data.DataTable ConvertToVisitGenerateListUpdate(List<VisitSheetDetailsQuotation> _VisitGen)
        {

            System.Data.DataTable _datatable = new System.Data.DataTable();
            _datatable.Columns.Add("SampleID", typeof(System.String));
            _datatable.Columns.Add("Temperature", typeof(System.String));
            _datatable.Columns.Add("Location", typeof(System.String));
   
            _datatable.Columns.Add("SampleDescrip", typeof(System.String));
            _datatable.Columns.Add("Vendor", typeof(System.String));
            _datatable.Columns.Add("Quality", typeof(System.String));

           

            DataRow _datarow;
            foreach (VisitSheetDetailsQuotation _list in _VisitGen)
            {
                _datarow = _datatable.NewRow();
                _datarow["SampleID"] = _list.SampleID;
                _datarow["Temperature"] = _list.Temperature;
                _datarow["Location"] = _list.Location;
               
                _datarow["SampleDescrip"] = _list.SampleDescrip;
                _datarow["Vendor"] = _list.Vendor;
                _datarow["Quality"] = _list.Quality;
               
                _datatable.Rows.Add(_datarow);
            }


            return _datatable;

        }
		
		//------------------Capture patient history UDT DAL start------------------------------------------//

       public static System.Data.DataTable ConvertToCapturePatientHistory(List<CapturePatientHistory> _lstCollection)
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
           _datatable.Columns.Add("HasAttribute", typeof(System.String));
           _datatable.Columns.Add("Description", typeof(System.String));
           _datatable.Columns.Add("Type", typeof(System.String));

           _datatable.Columns.Add("PatientHistoryAttributeID", typeof(System.Int64));
           _datatable.Columns.Add("SeqID", typeof(System.Int64));
           _datatable.Columns.Add("ActionType", typeof(System.String));


           DataRow _datarow;

           foreach (CapturePatientHistory _list in _lstCollection)
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
               _datarow["HasAttribute"] = _list.HasAttribute;
               _datarow["Description"] = _list.Description;
               _datarow["Type"] = _list.Type;

               _datarow["PatientHistoryAttributeID"] = _list.PatientHistoryAttributeID;
               _datarow["SeqID"] = _list.SeqID;
               _datarow["ActionType"] = _list.ActionType;



               _datatable.Rows.Add(_datarow);
           }
           return _datatable;
           //Test
       }


        //------------------Capture patient history UDT DAL end------------------------------------------//
        //////  -------------------   Refering Physician Details Coverts in UDT DAL Start -------------- ///////////////
       public static System.Data.DataTable ConverttoRefeingphysiciandetails(List<ReferingPhysicianDetails> _lstCollection)
       {

           System.Data.DataTable _datatable = new System.Data.DataTable();

           _datatable.Columns.Add("ReferingPhysicianID", typeof(System.Int32));
           _datatable.Columns.Add("PhysicianName", typeof(System.String));
           _datatable.Columns.Add("Qualification", typeof(System.String));
           _datatable.Columns.Add("OrganizationName", typeof(System.String));
           _datatable.Columns.Add("OrgID", typeof(System.Int32));
           _datatable.Columns.Add("Status", typeof(System.String));
           _datatable.Columns.Add("Salutation", typeof(System.Int32));
           _datatable.Columns.Add("LoginID", typeof(System.Int64));
           _datatable.Columns.Add("PhysicianCode", typeof(System.String));
           _datatable.Columns.Add("IsClient", typeof(System.String));
           _datatable.Columns.Add("IsActive", typeof(System.String));
           _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
           _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
           _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
           _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
           _datatable.Columns.Add("Gender", typeof(System.String));
           _datatable.Columns.Add("DOB", typeof(System.String));
           _datatable.Columns.Add("Age", typeof(System.String));
           _datatable.Columns.Add("RegistrationType", typeof(System.String));
           _datatable.Columns.Add("ParentReferingPhysicianID", typeof(System.Int32));
           _datatable.Columns.Add("IsMerged", typeof(System.String));
           _datatable.Columns.Add("DiscountLimit", typeof(System.Decimal));
           _datatable.Columns.Add("DiscountPeriod", typeof(System.String));
           _datatable.Columns.Add("DiscountValidFrom", typeof(System.DateTime));
           _datatable.Columns.Add("DiscountValidTo", typeof(System.DateTime));
           _datatable.Columns.Add("RefFeeCategoryid", typeof(System.Int64));
           _datatable.Columns.Add("HasReportingEmail", typeof(System.Boolean));
           _datatable.Columns.Add("HasReportingSms", typeof(System.Boolean));
           _datatable.Columns.Add("DesignationID", typeof(System.Int64));
           _datatable.Columns.Add("LoginName", typeof(System.String));
           _datatable.Columns.Add("Password", typeof(System.String));
           _datatable.Columns.Add("AddressTypeID", typeof(System.Int32));
           _datatable.Columns.Add("Address1", typeof(System.String));
           _datatable.Columns.Add("City", typeof(System.String));
           _datatable.Columns.Add("CountryID", typeof(System.Int32));
           _datatable.Columns.Add("StateID", typeof(System.Int32));
           _datatable.Columns.Add("EmailID", typeof(System.String));
           _datatable.Columns.Add("Phone", typeof(System.String));
           _datatable.Columns.Add("Mobile", typeof(System.String));
           _datatable.Columns.Add("IsCommunication", typeof(System.String));
           _datatable.Columns.Add("FaxNumber", typeof(System.String));
           _datatable.Columns.Add("ISDCode", typeof(System.Int32));

           DataRow _datarow;

           foreach (ReferingPhysicianDetails _list in _lstCollection)
           {
               _datarow = _datatable.NewRow();
               _datarow["ReferingPhysicianID"] = _list.ReferingPhysicianID;
               _datarow["PhysicianName"] = _list.PhysicianName;
               _datarow["Qualification"] = _list.Qualification;
               _datarow["OrganizationName"] = _list.OrganizationName;
               _datarow["OrgID"] = _list.OrgID;
               _datarow["Status"] = _list.Status;
               _datarow["Salutation"] = _list.Salutation;
               _datarow["LoginID"] = _list.LoginID;
               _datarow["PhysicianCode"] = _list.PhysicianCode;
               _datarow["IsClient"] = _list.IsClient;
               _datarow["IsActive"] = _list.IsActive;
               _datarow["CreatedBy"] = _list.CreatedBy;
               _datarow["CreatedAt"] = _list.CreatedAt;
               _datarow["ModifiedBy"] = _list.ModifiedBy;
               _datarow["ModifiedAt"] = _list.ModifiedAt;
               _datarow["Gender"] = _list.Gender;
               _datarow["DOB"] = _list.DOB;
               _datarow["Age"] = _list.Age;
               _datarow["RegistrationType"] = _list.RegistrationType;
               _datarow["ParentReferingPhysicianID"] = _list.ParentReferingPhysicianID;
               _datarow["IsMerged"] = _list.IsMerged;
               _datarow["DiscountLimit"] = _list.DiscountLimit;
               _datarow["DiscountPeriod"] = _list.DiscountPeriod;
               _datarow["DiscountValidFrom"] = _list.DiscountValidFrom;
               _datarow["DiscountValidTo"] = _list.DiscountValidTo;
               _datarow["RefFeeCategoryid"] = _list.RefFeeCategoryid;
               _datarow["HasReportingEmail"] = _list.HasReportingEmail;
               _datarow["HasReportingSms"] = _list.HasReportingSms;
               _datarow["DesignationID"] = _list.DesignationID;
               _datarow["LoginName"] = _list.LoginName;
               _datarow["Password"] = _list.Password;
               _datarow["AddressTypeID"] = _list.AddressTypeID;
               _datarow["Address1"] = _list.Address1;
               _datarow["City"] = _list.City;
               _datarow["CountryID"] = _list.CountryID;
               _datarow["StateID"] = _list.StateID;
               _datarow["EmailID"] = _list.EmailID;
               _datarow["Phone"] = _list.Phone;
               _datarow["Mobile"] = _list.Mobile;
               _datarow["IsCommunication"] = _list.IsCommunication;
               _datarow["FaxNumber"] = _list.FaxNumber;
               _datarow["ISDCode"] = _list.ISDCode;
               


               _datatable.Rows.Add(_datarow);
           }
           return _datatable;

       }
       public static System.Data.DataTable ConvertToUDT_TT_UDTCampDetail(List<CampDetails> lstCampDetails)
       {
           System.Data.DataTable _datatable = new System.Data.DataTable();
           _datatable.Columns.Add("Id", typeof(System.Int32));
           _datatable.Columns.Add("OrgName", typeof(System.String));
           _datatable.Columns.Add("SlNo", typeof(System.Int32));
           _datatable.Columns.Add("PDate", typeof(System.DateTime));
           _datatable.Columns.Add("SDate", typeof(System.DateTime));
           _datatable.Columns.Add("SCollectedBy", typeof(System.String));
           _datatable.Columns.Add("PatID", typeof(System.String));
           _datatable.Columns.Add("Title", typeof(System.String));
           _datatable.Columns.Add("Name", typeof(System.String));
           _datatable.Columns.Add("Age", typeof(System.String));
           _datatable.Columns.Add("AgeType", typeof(System.String));
           _datatable.Columns.Add("Sex", typeof(System.String));
           _datatable.Columns.Add("Location", typeof(System.String));
           _datatable.Columns.Add("Doctor", typeof(System.String));
           _datatable.Columns.Add("RefHospital", typeof(System.String));
           _datatable.Columns.Add("Priority", typeof(System.String));
           _datatable.Columns.Add("DispatchMode", typeof(System.String));
           _datatable.Columns.Add("TestRequested", typeof(System.String));
           _datatable.Columns.Add("Charged", typeof(System.Decimal));
           _datatable.Columns.Add("AmountPaid", typeof(System.Decimal));
           _datatable.Columns.Add("AmountDisocunt", typeof(System.Decimal));
           _datatable.Columns.Add("DisocuntReason", typeof(System.String));
           _datatable.Columns.Add("DiscountAuthorisedBy", typeof(System.String));
           _datatable.Columns.Add("History", typeof(System.String));
           _datatable.Columns.Add("Remarks", typeof(System.String));
           _datatable.Columns.Add("MobileNo", typeof(System.String));
           _datatable.Columns.Add("CreatedBy", typeof(System.String));
           _datatable.Columns.Add("ClientCode", typeof(System.String));
           _datatable.Columns.Add("EmailID", typeof(System.String));

           _datatable.Columns.Add("ErrorStatus", typeof(System.Boolean));
           _datatable.Columns.Add("ErrorDesc", typeof(System.String));
           _datatable.Columns.Add("ValidateData", typeof(System.String));
           _datatable.Columns.Add("ClientID", typeof(System.Int64));
           _datatable.Columns.Add("LocationID", typeof(System.Int64));
           _datatable.Columns.Add("TitleID", typeof(System.Int64));
           _datatable.Columns.Add("DoctorID", typeof(System.Int64));
           _datatable.Columns.Add("RefHospitalID", typeof(System.Int64));
           _datatable.Columns.Add("TestCode", typeof(System.String));
           _datatable.Columns.Add("SCollectedByID", typeof(System.Int64));
           _datatable.Columns.Add("PriorityID", typeof(System.Int32));
           _datatable.Columns.Add("IsClientPatient", typeof(System.String));
           _datatable.Columns.Add("CreatedbyId", typeof(System.Int64));
           _datatable.Columns.Add("RateId", typeof(System.Int64));
           _datatable.Columns.Add("TestType", typeof(System.String));
           _datatable.Columns.Add("FeeId", typeof(System.String));
           _datatable.Columns.Add("IsDiscountable", typeof(System.String));
           _datatable.Columns.Add("DueAmount", typeof(System.Decimal));
           _datatable.Columns.Add("OrgId", typeof(System.Int32));
           _datatable.Columns.Add("DiscountAuthorisedByID", typeof(System.Int64));
           _datatable.Columns.Add("HasHealthCoupon", typeof(System.String));
           _datatable.Columns.Add("MyCardActiveDays", typeof(System.String));
           _datatable.Columns.Add("IsCreditBill", typeof(System.String));
           _datatable.Columns.Add("CampId", typeof(System.Int32));
           _datatable.Columns.Add("PatientNumber", typeof(System.String));
           _datatable.Columns.Add("DOB", typeof(System.DateTime));
           _datatable.Columns.Add("HealthHubID", typeof(System.String));
           _datatable.Columns.Add("EmployeeID", typeof(System.String));
           _datatable.Columns.Add("SourceType", typeof(System.String));
           _datatable.Columns.Add("BookingID", typeof(System.String));
           _datatable.Columns.Add("ExternalRefNo", typeof(System.String));
           _datatable.Columns.Add("SampleNumber", typeof(System.String));
_datatable.Columns.Add("SRFID", typeof(System.String));
           _datatable.Columns.Add("TRFID", typeof(System.String));           
           _datatable.Columns.Add("PassportNo", typeof(System.String));
DataRow _datarow;
           int i = 1;
           foreach (CampDetails _list in lstCampDetails)
           {
               _datarow = _datatable.NewRow();
               _datarow["Id"] = _list.Id;
               _datarow["OrgName"] = _list.OrgName;
               _datarow["SlNo"] = _list.SlNo;
               _datarow["PDate"] = Convert.ToDateTime(_list.PDate);
               _datarow["SDate"] = Convert.ToDateTime(_list.SDate);
               _datarow["SCollectedBy"] = _list.SCollectedBy;
               _datarow["PatID"] = _list.PatId;
               _datarow["Title"] = _list.Title;
               _datarow["Name"] = _list.Name;
               _datarow["Age"] = _list.Age;
               _datarow["AgeType"] = _list.AgeType;
               _datarow["Sex"] = _list.Sex;
               _datarow["Location"] = _list.Location;
               _datarow["Doctor"] = _list.Doctor;
               _datarow["RefHospital"] = _list.RefHospital;
               _datarow["Priority"] = _list.Priority;
               _datarow["DispatchMode"] = _list.DispatchMode;
               _datarow["TestRequested"] = _list.TestRequested;
               _datarow["Charged"] = _list.Charged;
               _datarow["AmountPaid"] = _list.AmountPaid;
               _datarow["AmountDisocunt"] = _list.AmountDiscount;
               _datarow["DisocuntReason"] = _list.DiscountReason;
               _datarow["DiscountAuthorisedBy"] = _list.DiscountAuthorisedBy;
               _datarow["History"] = _list.History;
               _datarow["Remarks"] = _list.Remarks;
               _datarow["MobileNo"] = _list.MobileNo;
               _datarow["CreatedBy"] = _list.CreatedBy;
               _datarow["ClientCode"] = _list.ClientCode;
               _datarow["EmailID"] = _list.EmailId;

               _datarow["ErrorStatus"] = _list.ErrorStatus;
               _datarow["ErrorDesc"] = _list.ErrorDesc;
               _datarow["ValidateData"] = _list.ValidateData;
               _datarow["ClientID"] = _list.ClientID;
               _datarow["LocationID"] = _list.LocationID;
               _datarow["TitleID"] = _list.TitleID;
               _datarow["DoctorID"] = _list.DoctorID;
               _datarow["RefHospitalID"] = _list.RefHospitalID;
               _datarow["TestCode"] = _list.TestCode;
               _datarow["SCollectedByID"] = _list.SCollectedByID;
               _datarow["PriorityID"] = _list.PriorityID;
               _datarow["IsClientPatient"] = _list.IsClientPatient;
               _datarow["CreatedbyId"] = _list.CreatedbyId;
               _datarow["RateId"] = _list.RateId;
               _datarow["TestType"] = _list.TestType;
               _datarow["FeeId"] = _list.FeeId;
               _datarow["IsDiscountable"] = _list.IsDiscountable;
               _datarow["DueAmount"] = _list.DueAmount;
               _datarow["OrgId"] = _list.OrgId;
               _datarow["DiscountAuthorisedByID"] = _list.DiscountAuthorisedByID;
               _datarow["HasHealthCoupon"] = _list.HasHealthCoupon;
               _datarow["MyCardActiveDays"] = _list.MyCardActiveDays;
               _datarow["IsCreditBill"] = _list.IsCreditBill;
               _datarow["CampId"] = _list.CampId;
               _datarow["PatientNumber"] = _list.PatientNumber;
               _datarow["DOB"] = Convert.ToDateTime(_list.DOB);
               _datarow["HealthHubID"] = _list.HealthHubID;
               _datarow["EmployeeID"] = _list.EmployeeID;
               _datarow["SourceType"] = _list.SourceType;
               _datarow["BookingID"] = _list.BookingID;
               _datarow["ExternalRefNo"] = _list.ExternalRefNo;
               _datarow["SampleNumber"] = _list.SampleNumber;
_datarow["SRFID"] = _list.SRFID;
               _datarow["TRFID"] = _list.TRFID;               
               _datarow["PassportNo"] = _list.PassportNo; 
_datatable.Rows.Add(_datarow);
               i = i + 1;
           }
           return _datatable;
       }
       public static System.Data.DataTable Convertwidgetroleanduserdetail(List<WidgetRoleMapping_Custom> _lstCollection)
       {

           System.Data.DataTable _datatable = new System.Data.DataTable();

           _datatable.Columns.Add("RoleID", typeof(System.Int64));
           _datatable.Columns.Add("LoginID", typeof(System.Int64));
           _datatable.Columns.Add("OrgID", typeof(System.Int64));
           _datatable.Columns.Add("WID", typeof(System.Int64));
           _datatable.Columns.Add("DetailedID", typeof(System.Int64));
           _datatable.Columns.Add("WCode", typeof(System.String));
           _datatable.Columns.Add("WGCode", typeof(System.String));
           _datatable.Columns.Add("Active", typeof(System.String));

           DataRow _datarow;

           foreach (WidgetRoleMapping_Custom _list in _lstCollection)
           {
               _datarow = _datatable.NewRow();
               _datarow["RoleID"] = _list.RoleID;
               _datarow["LoginID"] = _list.LoginID;
               _datarow["OrgID"] = _list.OrgID;
               _datarow["WID"] = _list.WID;
               _datarow["DetailedID"] = _list.DetailedID;
               _datarow["WCode"] = _list.WCode;
               _datarow["WGCode"] = _list.WGCode;
               _datarow["Active"] = _list.Active;
               _datatable.Rows.Add(_datarow);
           }
           return _datatable;

       }
	   
       public static System.Data.DataTable ConvertToPatientAttributesField(List<ClientAttributesKeyFields> _lstClt)
       {

           System.Data.DataTable _datatable = new System.Data.DataTable();
           
           _datatable.Columns.Add("FieldKey", typeof(System.String));
           _datatable.Columns.Add("FieldValue", typeof(System.String));

           _datatable.Columns.Add("ReferenceID", typeof(System.String));
           _datatable.Columns.Add("ReferenceType", typeof(System.String));
           _datatable.Columns.Add("TestType", typeof(System.String));



           DataRow _datarow;
           foreach (ClientAttributesKeyFields _list in _lstClt)
           {
               _datarow = _datatable.NewRow();
               _datarow["FieldKey"] = _list.Key;
               _datarow["FieldValue"] = _list.Valuedata;
               _datarow["ReferenceID"] = _list.ReferenceID;

               _datarow["ReferenceType"] = _list.ReferenceType;
               _datarow["TestType"] = _list.TestType;

               _datatable.Rows.Add(_datarow);
           }


           return _datatable;

       }
       public static System.Data.DataTable ConvertToUDTTATRANDOMBATCHSCHEDULE(List<TATSchedule> _lstCollection)
       {
           //lan
           System.Data.DataTable _datatable = new System.Data.DataTable();

           _datatable.Columns.Add("Scheduleid", typeof(System.Int32));
           _datatable.Columns.Add("Schedulecode", typeof(System.String));
           _datatable.Columns.Add("Schedulename", typeof(System.String));
           _datatable.Columns.Add("Reportedon", typeof(System.String));
           _datatable.Columns.Add("Processinghours", typeof(System.Int16));
           _datatable.Columns.Add("Processingmins", typeof(System.Int16));
           _datatable.Columns.Add("Earlyreporttime", typeof(System.String));
           _datatable.Columns.Add("Tatprocesstype", typeof(System.Byte));
           _datatable.Columns.Add("Scheduleday", typeof(System.String));
           _datatable.Columns.Add("Tatmode", typeof(System.Byte));
           _datatable.Columns.Add("Tatcalculationbase", typeof(System.Byte));
           _datatable.Columns.Add("Randombatchid", typeof(System.Int32));
           _datatable.Columns.Add("Batchstarttime", typeof(System.String));
           _datatable.Columns.Add("Cutofftime", typeof(System.String));
           _datatable.Columns.Add("Orgid", typeof(System.Int32));
           _datatable.Columns.Add("Flag", typeof(System.Int32));
           DataRow _datarow;

           foreach (TATSchedule _list in _lstCollection)
           {
               _datarow = _datatable.NewRow();
               _datarow["Scheduleid"] = _list.Scheduleid;
               _datarow["Schedulecode"] = _list.Schedulecode;
               _datarow["Schedulename"] = _list.Schedulename;
               _datarow["Reportedon"] = _list.Reportedon;
               _datarow["Processinghours"] = _list.Processinghours;
               _datarow["Processingmins"] = _list.Processingmins;
               _datarow["Earlyreporttime"] = _list.Earlyreporttime;
               _datarow["Tatprocesstype"] = _list.Tatprocesstype;
               _datarow["Scheduleday"] = _list.Scheduleday;
               _datarow["Tatmode"] = _list.Tatmode;
               _datarow["Tatcalculationbase"] = _list.Tatcalculationbase;
               _datarow["Randombatchid"] = _list.Randombatchid;
               _datarow["Batchstarttime"] = _list.Batchstarttime;
               _datarow["Cutofftime"] = _list.Cutofftime;
               _datarow["Orgid"] = _list.Orgid;
               _datarow["Flag"] = _list.Flag;
               _datatable.Rows.Add(_datarow);
           }
           return _datatable;
           //Test
       }


       public static System.Data.DataTable ConvertToUDTHolidayMaster(List<Holidaymaster> _lstCollection)
       {
           //lan
           System.Data.DataTable _datatable = new System.Data.DataTable();

           _datatable.Columns.Add("Scheduleid", typeof(System.Int32));
           _datatable.Columns.Add("Holidayid", typeof(System.Int32));
           _datatable.Columns.Add("Holidayname", typeof(System.String));

           DataRow _datarow;

           foreach (Holidaymaster _list in _lstCollection)
           {
               _datarow = _datatable.NewRow();
               _datarow["Scheduleid"] = _list.Scheduleid;
               _datarow["Holidayid"] = _list.Holidayid;
               _datarow["Holidayname"] = _list.Holidayname;
               _datatable.Rows.Add(_datarow);
           }
           return _datatable;
           //Test
       }
       public static System.Data.DataTable ConvertToUDTTatschedulemapping(List<Tatschedulemapping> _lstCollection)
       {
           //lan
           System.Data.DataTable _datatable = new System.Data.DataTable();

           _datatable.Columns.Add("Schedulemappingid", typeof(System.Int32));
           _datatable.Columns.Add("Scheduleid", typeof(System.Int32));
           _datatable.Columns.Add("Testid", typeof(System.Int64));
           _datatable.Columns.Add("Testtype", typeof(System.String));
           _datatable.Columns.Add("Clientid", typeof(System.Int64));
           _datatable.Columns.Add("Orgid", typeof(System.Int32));
           _datatable.Columns.Add("Createdby", typeof(System.Int64));
           _datatable.Columns.Add("Createdat", typeof(System.DateTime));
           _datatable.Columns.Add("IsActive", typeof(System.Boolean));
           _datatable.Columns.Add("Modifiedby", typeof(System.Int64));
           _datatable.Columns.Add("Modifiedat", typeof(System.DateTime));
           _datatable.Columns.Add("CategoryType", typeof(System.String));
           _datatable.Columns.Add("CategoryID", typeof(System.Int64));

           DataRow _datarow;

           foreach (Tatschedulemapping _list in _lstCollection)
           {
               _datarow = _datatable.NewRow();
               _datarow["Schedulemappingid"] = _list.Schedulemappingid;
               _datarow["Scheduleid"] = _list.Scheduleid;
               _datarow["Testid"] = _list.Testid;
               _datarow["Testtype"] = _list.Testtype;
               _datarow["Clientid"] = _list.Clientid;
               _datarow["Orgid"] = _list.OrgID;
               _datarow["Createdby"] = _list.CreatedBy;
               _datarow["Createdat"] = _list.CreatedAt;
               _datarow["IsActive"] = _list.IsActive;
               _datarow["Modifiedby"] = _list.ModifiedBy;
               _datarow["Modifiedat"] = _list.ModifiedAt;
               _datarow["CategoryType"] = _list.CategoryType;
               _datarow["CategoryID"] = _list.CategoryID;
               _datatable.Rows.Add(_datarow);
           }
           return _datatable;
           //Test
       }

       //END || 154 || shabi || TAT Configuration

       //BUGID:154 TAT MANAGE LOGISTICS DETAILS

       public static System.Data.DataTable ConvertToUDTTatlogisticdetails(List<Tatlogisticdetails> _lstCollection)
       {
           //lan
           System.Data.DataTable _datatable = new System.Data.DataTable();

           _datatable.Columns.Add("Logisticdetailsid", typeof(System.Int32));
           _datatable.Columns.Add("Fromorgid", typeof(System.Int32));
           _datatable.Columns.Add("Fromorgaddressid", typeof(System.Int64));
           _datatable.Columns.Add("Toorgid", typeof(System.Int32));
           _datatable.Columns.Add("Toorgaddressid", typeof(System.Int64));
           _datatable.Columns.Add("Transittimevalue", typeof(System.Int16));
           _datatable.Columns.Add("Transittimetype", typeof(System.String));
           _datatable.Columns.Add("TransittimeName", typeof(System.String));
           _datatable.Columns.Add("IsActive", typeof(System.Boolean));
           _datatable.Columns.Add("Createdby", typeof(System.Int64));
           _datatable.Columns.Add("Createdat", typeof(System.DateTime));
           _datatable.Columns.Add("Modifiedby", typeof(System.Int64));
           _datatable.Columns.Add("Modifiedat", typeof(System.DateTime));
           _datatable.Columns.Add("Fromorgname", typeof(System.String));
           _datatable.Columns.Add("Fromlocationname", typeof(System.String));
           _datatable.Columns.Add("Toorgname", typeof(System.String));
           _datatable.Columns.Add("Tolocationname", typeof(System.String));

           DataRow _datarow;

           foreach (Tatlogisticdetails _list in _lstCollection)
           {
               _datarow = _datatable.NewRow();
               _datarow["Logisticdetailsid"] = _list.Logisticdetailsid;
               _datarow["Fromorgid"] = _list.Fromorgid;
               _datarow["Fromorgaddressid"] = _list.Fromorgaddressid;
               _datarow["Toorgid"] = _list.Toorgid;
               _datarow["Toorgaddressid"] = _list.Toorgaddressid;
               _datarow["Transittimevalue"] = _list.Transittimevalue;
               _datarow["Transittimetype"] = _list.Transittimetype;
               _datarow["TransittimeName"] = _list.TransittimeName;
               _datarow["IsActive"] = _list.IsActive;
               _datarow["Createdby"] = _list.CreatedBy;
               _datarow["Createdat"] = _list.CreatedAt;
               _datarow["Modifiedby"] = _list.ModifiedBy;
               _datarow["Modifiedat"] = _list.ModifiedAt;
               _datarow["Fromorgname"] = _list.Fromorgname;
               _datarow["Fromlocationname"] = _list.Fromlocationname;
               _datarow["Toorgname"] = _list.Toorgname;
               _datarow["Tolocationname"] = _list.Tolocationname;
               _datatable.Rows.Add(_datarow);
           }
           return _datatable;
           //Test
       }
	   public static System.Data.DataTable ConvertToUDTHLMessageHeaderDetails(List<HLMessageHeaderDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("MHEvent_Type", typeof(System.String));
            _datatable.Columns.Add("Encoding_Characters", typeof(System.String));
            _datatable.Columns.Add("Sending_Application", typeof(System.String));
            _datatable.Columns.Add("Sending_Facility", typeof(System.String));
            _datatable.Columns.Add("SFNamespace_ID", typeof(System.String));
            _datatable.Columns.Add("SFUniversal_ID", typeof(System.String));
            _datatable.Columns.Add("Message_Date_Time", typeof(System.DateTime));
            _datatable.Columns.Add("MessageSecurity", typeof(System.String));
            _datatable.Columns.Add("Receiving_Application", typeof(System.String));
            _datatable.Columns.Add("Receiving_Facility", typeof(System.String));
            _datatable.Columns.Add("Sequence_number", typeof(System.String));
            _datatable.Columns.Add("Message_control_id", typeof(System.String));
            _datatable.Columns.Add("Message_Type", typeof(System.String));
            _datatable.Columns.Add("Message_Code", typeof(System.String));
            _datatable.Columns.Add("Trigger_Event", typeof(System.String));
            _datatable.Columns.Add("Message_Structure", typeof(System.String));
            _datatable.Columns.Add("Continuation_pointer", typeof(System.String));
            _datatable.Columns.Add("Processing_ID", typeof(System.String));
            _datatable.Columns.Add("Version_ID", typeof(System.String));
            _datatable.Columns.Add("Application_Acknowledgment_type", typeof(System.String));
            _datatable.Columns.Add("MHCountry_Code", typeof(System.String));
            _datatable.Columns.Add("Character_Set", typeof(System.String));
            _datatable.Columns.Add("Principal_Language_Of_Message", typeof(System.String));
            _datatable.Columns.Add("MHIdentifier", typeof(System.String));
            _datatable.Columns.Add("Alternate_Character_Set_Handling_Scheme", typeof(System.String));
            _datatable.Columns.Add("Message_Profile_Identifier", typeof(System.String));
            _datatable.Columns.Add("Entity_Identifier", typeof(System.String));
            _datatable.Columns.Add("Sending_Responsible_Organization", typeof(System.String));
            _datatable.Columns.Add("SROrganization_Name", typeof(System.String));
            _datatable.Columns.Add("Receiving_Responsible_Organization", typeof(System.String));
            _datatable.Columns.Add("RROrganization_Name", typeof(System.String));
            _datatable.Columns.Add("Sending_Network_Address", typeof(System.String));
            _datatable.Columns.Add("SNNamespace_ID", typeof(System.String));
            _datatable.Columns.Add("Receiving_Network_Address", typeof(System.String));
            _datatable.Columns.Add("RNNamespace_ID", typeof(System.String));
            _datatable.Columns.Add("HLMessageID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int64));
            _datatable.Columns.Add("LocationID", typeof(System.Int64));
            _datatable.Columns.Add("ParentID", typeof(System.Int64));
           _datatable.Columns.Add("HLMessageHeaderContent", typeof(System.String));

            DataRow _datarow;

            foreach (HLMessageHeaderDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["MHEvent_Type"] = _list.MHEvent_Type;
                _datarow["Encoding_Characters"] = _list.Encoding_Characters;
                _datarow["Sending_Application"] = _list.Sending_Application;
                _datarow["Sending_Facility"] = _list.Sending_Facility;
                _datarow["SFNamespace_ID"] = _list.SFNamespace_ID;
                _datarow["SFUniversal_ID"] = _list.SFUniversal_ID;
                _datarow["Message_Date_Time"] = _list.Message_Date_Time;
                _datarow["MessageSecurity"] = _list.MessageSecurity;
                _datarow["Receiving_Application"] = _list.Receiving_Application;
                _datarow["Receiving_Facility"] = _list.Receiving_Facility;
                _datarow["Sequence_number"] = _list.Sequence_number;
                _datarow["Message_control_id"] = _list.Message_control_id;
                _datarow["Message_Type"] = _list.Message_Type;
                _datarow["Message_Code"] = _list.Message_Code;
                _datarow["Trigger_Event"] = _list.Trigger_Event;
                _datarow["Message_Structure"] = _list.Message_Structure;
                _datarow["Continuation_pointer"] = _list.Continuation_pointer;
                _datarow["Processing_ID"] = _list.Processing_ID;
                _datarow["Version_ID"] = _list.Version_ID;
                _datarow["Application_Acknowledgment_type"] = _list.Application_Acknowledgment_type;
                _datarow["MHCountry_Code"] = _list.MHCountry_Code;
                _datarow["Character_Set"] = _list.Character_Set;
                _datarow["Principal_Language_Of_Message"] = _list.Principal_Language_Of_Message;
                _datarow["MHIdentifier"] = _list.MHIdentifier;
                _datarow["Alternate_Character_Set_Handling_Scheme"] = _list.Alternate_Character_Set_Handling_Scheme;
                _datarow["Message_Profile_Identifier"] = _list.Message_Profile_Identifier;
                _datarow["Entity_Identifier"] = _list.Entity_Identifier;
                _datarow["Sending_Responsible_Organization"] = _list.Sending_Responsible_Organization;
                _datarow["SROrganization_Name"] = _list.SROrganization_Name;
                _datarow["Receiving_Responsible_Organization"] = _list.Receiving_Responsible_Organization;
                _datarow["RROrganization_Name"] = _list.RROrganization_Name;
                _datarow["Sending_Network_Address"] = _list.Sending_Network_Address;
                _datarow["SNNamespace_ID"] = _list.SNNamespace_ID;
                _datarow["Receiving_Network_Address"] = _list.Receiving_Network_Address;
                _datarow["RNNamespace_ID"] = _list.RNNamespace_ID;
                _datarow["HLMessageID"] = _list.HLMessageID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["LocationID"] = _list.LocationID;
                _datarow["ParentID"] = _list.ParentID;
               _datarow["HLMessageHeaderContent"] = _list.HLMessageHeaderContent;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
		public static System.Data.DataTable ConvertToUDTHLMessageOBRDetails(List<HLMessageOBRDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("OBREvent_Type", typeof(System.String));
            _datatable.Columns.Add("Set_ID_OBR", typeof(System.String));
            _datatable.Columns.Add("Placer_Order_Number", typeof(System.String));
            _datatable.Columns.Add("OBRFiller_Order_Number", typeof(System.String));
            _datatable.Columns.Add("Universal_Service_Identifier", typeof(System.String));
            _datatable.Columns.Add("OBRIdentifier", typeof(System.String));
            _datatable.Columns.Add("OBRText", typeof(System.String));
            _datatable.Columns.Add("Name_Of_Coding_System", typeof(System.String));
            _datatable.Columns.Add("OBRPriority", typeof(System.String));
           _datatable.Columns.Add("Requested_Date_Time", typeof(System.DateTime));
           _datatable.Columns.Add("Observation_Date_Time", typeof(System.DateTime));
           _datatable.Columns.Add("Observation_End_Date_Time", typeof(System.DateTime));
            _datatable.Columns.Add("Collection_Volume", typeof(System.String));
            _datatable.Columns.Add("Collector_Identifier", typeof(System.String));
            _datatable.Columns.Add("Spicemen_Action_Code", typeof(System.String));
            _datatable.Columns.Add("Danger_Code", typeof(System.String));
            _datatable.Columns.Add("Relevant_Clinical_Information", typeof(System.String));
           _datatable.Columns.Add("Specimen_Received_Date_Time", typeof(System.DateTime));
            _datatable.Columns.Add("Specimen_Source", typeof(System.String));
            _datatable.Columns.Add("OBROrdering_Provider", typeof(System.String));
            _datatable.Columns.Add("Person_Identifier", typeof(System.String));
            _datatable.Columns.Add("OBRFamily_Name", typeof(System.String));
            _datatable.Columns.Add("Given_Name", typeof(System.String));
            _datatable.Columns.Add("Second_and_Further_Given_Names_or_Initials_There_of", typeof(System.String));
            _datatable.Columns.Add("OBRSuffix", typeof(System.String));
            _datatable.Columns.Add("OBRPrefix", typeof(System.String));
            _datatable.Columns.Add("OBRDegree", typeof(System.String));
            _datatable.Columns.Add("Order_Callback_Phone_Number", typeof(System.String));
            _datatable.Columns.Add("Placer_Field1", typeof(System.String));
            _datatable.Columns.Add("Placer_Field2", typeof(System.String));
            _datatable.Columns.Add("Filler_Field1", typeof(System.String));
            _datatable.Columns.Add("Filler_Field2", typeof(System.String));
           _datatable.Columns.Add("Results_Rpt_Status_Chng_DateTime", typeof(System.DateTime));
            _datatable.Columns.Add("Change_to_Practice", typeof(System.String));
            _datatable.Columns.Add("Diagnostic_Serv_Sect_ID", typeof(System.String));
            _datatable.Columns.Add("Result_Status", typeof(System.String));
            _datatable.Columns.Add("Parent_Status", typeof(System.String));
            _datatable.Columns.Add("OBRQuantity_Timing", typeof(System.String));
            _datatable.Columns.Add("Result_Copies_To", typeof(System.String));
            _datatable.Columns.Add("Parent_Result_Observation_Identifier", typeof(System.String));
            _datatable.Columns.Add("Transporation_Mode", typeof(System.String));
            _datatable.Columns.Add("Reason_For_Study", typeof(System.String));
            _datatable.Columns.Add("Principal_Result_Interpreter", typeof(System.String));
            _datatable.Columns.Add("Assistant_Result_Interpreter", typeof(System.String));
            _datatable.Columns.Add("Technician", typeof(System.String));
            _datatable.Columns.Add("Transcriptionist", typeof(System.String));
           _datatable.Columns.Add("Scheduled_Date_Time", typeof(System.DateTime));
            _datatable.Columns.Add("Number_Of_Sample_Containers", typeof(System.String));
            _datatable.Columns.Add("Transport_Logistics_Of_Collected_Samlpe", typeof(System.String));
            _datatable.Columns.Add("Collectors_Comment", typeof(System.String));
            _datatable.Columns.Add("Transport_Arrangement_Responsibility", typeof(System.String));
            _datatable.Columns.Add("Transport_Arranged", typeof(System.String));
            _datatable.Columns.Add("Escort_Required", typeof(System.String));
            _datatable.Columns.Add("Planned_Patient_Transport_Comment", typeof(System.String));
            _datatable.Columns.Add("Procedure_Code", typeof(System.String));
            _datatable.Columns.Add("Procedure_Code_Modifier", typeof(System.String));
            _datatable.Columns.Add("Placer_Supplemental_Service_Information", typeof(System.String));
            _datatable.Columns.Add("Filler_Supplemental_Service_Information", typeof(System.String));
            _datatable.Columns.Add("Medically_Necessary_Duplicate_Procedure_Reason", typeof(System.String));
            _datatable.Columns.Add("Result_Handling", typeof(System.String));
            _datatable.Columns.Add("Parent_Universal_Service_Identifier", typeof(System.String));
            _datatable.Columns.Add("HLMessageID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int64));
            _datatable.Columns.Add("LocationID", typeof(System.Int64));
            _datatable.Columns.Add("Tasks_Line_Discount", typeof(System.Decimal));
            _datatable.Columns.Add("Tasks_Line_Amount", typeof(System.Decimal));
            _datatable.Columns.Add("Tasks_Sales_Price", typeof(System.Decimal));
            _datatable.Columns.Add("Tasks_Sales_ID", typeof(System.String));
            _datatable.Columns.Add("Login_Create_DateTime", typeof(System.DateTime));
            _datatable.Columns.Add("Login_Priority", typeof(System.String));
           _datatable.Columns.Add("HLMessageOBRContent", typeof(System.String));
           _datatable.Columns.Add("LocationSource", typeof(System.String));
           _datatable.Columns.Add("OBRQuantity_TimingQuantity", typeof(System.Int32));
           _datatable.Columns.Add("OBRQuantity_TimingInterval", typeof(System.Int32));
           _datatable.Columns.Add("OBRQuantity_TimingDuration", typeof(System.Int32));
           _datatable.Columns.Add("OBRQuantity_TimingStartDate", typeof(System.DateTime));
           _datatable.Columns.Add("OBRQuantity_TimingEndDate", typeof(System.DateTime));
           _datatable.Columns.Add("OBRQuantity_TimingPriority", typeof(System.String));
            DataRow _datarow;

            foreach (HLMessageOBRDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["OBREvent_Type"] = _list.OBREvent_Type;
                _datarow["Set_ID_OBR"] = _list.Set_ID_OBR;
                _datarow["Placer_Order_Number"] = _list.Placer_Order_Number;
                _datarow["OBRFiller_Order_Number"] = _list.OBRFiller_Order_Number;
                _datarow["Universal_Service_Identifier"] = _list.Universal_Service_Identifier;
                _datarow["OBRIdentifier"] = _list.OBRIdentifier;
                _datarow["OBRText"] = _list.OBRText;
                _datarow["Name_Of_Coding_System"] = _list.Name_Of_Coding_System;
                _datarow["OBRPriority"] = _list.OBRPriority;
                _datarow["Requested_Date_Time"] = _list.Requested_Date_Time;
                _datarow["Observation_Date_Time"] = _list.Observation_Date_Time;
                _datarow["Observation_End_Date_Time"] = _list.Observation_End_Date_Time;
                _datarow["Collection_Volume"] = _list.Collection_Volume;
                _datarow["Collector_Identifier"] = _list.Collector_Identifier;
                _datarow["Spicemen_Action_Code"] = _list.Spicemen_Action_Code;
                _datarow["Danger_Code"] = _list.Danger_Code;
                _datarow["Relevant_Clinical_Information"] = _list.Relevant_Clinical_Information;
                _datarow["Specimen_Received_Date_Time"] = _list.Specimen_Received_Date_Time;
                _datarow["Specimen_Source"] = _list.Specimen_Source;
                _datarow["OBROrdering_Provider"] = _list.OBROrdering_Provider;
                _datarow["Person_Identifier"] = _list.Person_Identifier;
                _datarow["OBRFamily_Name"] = _list.OBRFamily_Name;
                _datarow["Given_Name"] = _list.Given_Name;
                _datarow["Second_and_Further_Given_Names_or_Initials_There_of"] = _list.Second_and_Further_Given_Names_or_Initials_There_of;
                _datarow["OBRSuffix"] = _list.OBRSuffix;
                _datarow["OBRPrefix"] = _list.OBRPrefix;
                _datarow["OBRDegree"] = _list.OBRDegree;
                _datarow["Order_Callback_Phone_Number"] = _list.Order_Callback_Phone_Number;
                _datarow["Placer_Field1"] = _list.Placer_Field1;
                _datarow["Placer_Field2"] = _list.Placer_Field2;
                _datarow["Filler_Field1"] = _list.Filler_Field1;
                _datarow["Filler_Field2"] = _list.Filler_Field2;
                _datarow["Results_Rpt_Status_Chng_DateTime"] = _list.Results_Rpt_Status_Chng_DateTime;
                _datarow["Change_to_Practice"] = _list.Change_to_Practice;
                _datarow["Diagnostic_Serv_Sect_ID"] = _list.Diagnostic_Serv_Sect_ID;
                _datarow["Result_Status"] = _list.Result_Status;
                _datarow["Parent_Status"] = _list.Parent_Status;
                _datarow["OBRQuantity_Timing"] = _list.OBRQuantity_Timing;
                _datarow["Result_Copies_To"] = _list.Result_Copies_To;
                _datarow["Parent_Result_Observation_Identifier"] = _list.Parent_Result_Observation_Identifier;
                _datarow["Transporation_Mode"] = _list.Transporation_Mode;
                _datarow["Reason_For_Study"] = _list.Reason_For_Study;
                _datarow["Principal_Result_Interpreter"] = _list.Principal_Result_Interpreter;
                _datarow["Assistant_Result_Interpreter"] = _list.Assistant_Result_Interpreter;
                _datarow["Technician"] = _list.Technician;
                _datarow["Transcriptionist"] = _list.Transcriptionist;
                _datarow["Scheduled_Date_Time"] = _list.Scheduled_Date_Time;
                _datarow["Number_Of_Sample_Containers"] = _list.Number_Of_Sample_Containers;
                _datarow["Transport_Logistics_Of_Collected_Samlpe"] = _list.Transport_Logistics_Of_Collected_Samlpe;
                _datarow["Collectors_Comment"] = _list.Collectors_Comment;
                _datarow["Transport_Arrangement_Responsibility"] = _list.Transport_Arrangement_Responsibility;
                _datarow["Transport_Arranged"] = _list.Transport_Arranged;
                _datarow["Escort_Required"] = _list.Escort_Required;
                _datarow["Planned_Patient_Transport_Comment"] = _list.Planned_Patient_Transport_Comment;
                _datarow["Procedure_Code"] = _list.Procedure_Code;
                _datarow["Procedure_Code_Modifier"] = _list.Procedure_Code_Modifier;
                _datarow["Placer_Supplemental_Service_Information"] = _list.Placer_Supplemental_Service_Information;
                _datarow["Filler_Supplemental_Service_Information"] = _list.Filler_Supplemental_Service_Information;
                _datarow["Medically_Necessary_Duplicate_Procedure_Reason"] = _list.Medically_Necessary_Duplicate_Procedure_Reason;
                _datarow["Result_Handling"] = _list.Result_Handling;
                _datarow["Parent_Universal_Service_Identifier"] = _list.Parent_Universal_Service_Identifier;
                _datarow["HLMessageID"] = _list.HLMessageID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["LocationID"] = _list.LocationID;
                _datarow["LocationID"] = _list.LocationID;
                _datarow["Tasks_Line_Discount"] = _list.Tasks_Line_Discount;
                _datarow["Tasks_Line_Amount"] = _list.Tasks_Line_Amount;
                _datarow["Tasks_Sales_Price"] = _list.Tasks_Sales_Price;
                _datarow["Tasks_Sales_ID"] = _list.Tasks_Sales_ID;
                _datarow["Login_Create_DateTime"] = _list.Login_Create_DateTime;
                _datarow["Login_Priority"] = _list.Login_Priority;
               _datarow["HLMessageOBRContent"] = _list.HLMessageOBRContent;
               _datarow["LocationSource"] = _list.LocationSource;
               _datarow["OBRQuantity_TimingQuantity"]=_list.OBRQuantity_TimingQuantity;
               _datarow["OBRQuantity_TimingInterval"]=_list.OBRQuantity_TimingInterval;
               _datarow["OBRQuantity_TimingDuration"]=_list.OBRQuantity_TimingDuration;
               _datarow["OBRQuantity_TimingStartDate"]=_list.OBRQuantity_TimingStartDate;
               _datarow["OBRQuantity_TimingEndDate"]=_list.OBRQuantity_TimingEndDate;
               _datarow["OBRQuantity_TimingPriority"] = _list.OBRQuantity_TimingPriority;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
		public static System.Data.DataTable ConvertToUDTHLMessageORCDetails(List<HLMessageORCDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ORCEvent_Type", typeof(System.String));
            _datatable.Columns.Add("Order_Control", typeof(System.String));
            _datatable.Columns.Add("Place_Order_Number", typeof(System.String));
            _datatable.Columns.Add("ORCPlEntity_Identifier", typeof(System.String));
            _datatable.Columns.Add("ORCFiller_Order_Number", typeof(System.String));
            _datatable.Columns.Add("ORCFEntity_Identifier", typeof(System.String));
            _datatable.Columns.Add("Placer_Group_Number", typeof(System.String));
            _datatable.Columns.Add("ORCPrEntity_Identifier", typeof(System.String));
            _datatable.Columns.Add("Order_Status", typeof(System.String));
            _datatable.Columns.Add("Response_Flag", typeof(System.String));
            _datatable.Columns.Add("ORCQuantity_Timing", typeof(System.String));
            _datatable.Columns.Add("Quantity", typeof(System.String));
            _datatable.Columns.Add("Interval", typeof(System.String));
            _datatable.Columns.Add("Duration", typeof(System.String));
           _datatable.Columns.Add("Start_Date_Time", typeof(System.DateTime));
           _datatable.Columns.Add("End_Date_Time", typeof(System.DateTime));
            _datatable.Columns.Add("ORCPriority", typeof(System.String));
            _datatable.Columns.Add("Parent_Order", typeof(System.String));
            _datatable.Columns.Add("Placer_Assigned_Identifier", typeof(System.String));
           _datatable.Columns.Add("Date_Time_Of_Transaction", typeof(System.DateTime));
            _datatable.Columns.Add("Entered_By", typeof(System.String));
            _datatable.Columns.Add("EnterPerson_Identifier", typeof(System.String));
            _datatable.Columns.Add("EnterFamily_Name", typeof(System.String));
            _datatable.Columns.Add("EnterGiven_Name", typeof(System.String));
            _datatable.Columns.Add("EnterSecond_and_Further_Given_Names_or_Initials_Thereof", typeof(System.String));
            _datatable.Columns.Add("Verified_By", typeof(System.String));
            _datatable.Columns.Add("ORCOrdering_Provider", typeof(System.String));
            _datatable.Columns.Add("OrderingPerson_Identifier", typeof(System.String));
            _datatable.Columns.Add("OrderingFamily_Name", typeof(System.String));
            _datatable.Columns.Add("OrderingGiven_Name", typeof(System.String));
            _datatable.Columns.Add("OrderingSecond_and_Further_Given_Names_or_Initials_Thereof", typeof(System.String));
            _datatable.Columns.Add("ORCSuffix", typeof(System.String));
            _datatable.Columns.Add("ORCPrefix", typeof(System.String));
            _datatable.Columns.Add("ORCDegree", typeof(System.String));
            _datatable.Columns.Add("Enterer_Location", typeof(System.String));
            _datatable.Columns.Add("Point_of_Care", typeof(System.String));
            _datatable.Columns.Add("Room", typeof(System.String));
            _datatable.Columns.Add("Bed", typeof(System.String));
            _datatable.Columns.Add("Facility", typeof(System.String));
            _datatable.Columns.Add("Call_Back_Phone_Number", typeof(System.String));
            _datatable.Columns.Add("ORCTelephone_number", typeof(System.String));
           _datatable.Columns.Add("Order_Effective_Date_Time", typeof(System.DateTime));
            _datatable.Columns.Add("Order_Control_Code_Reason", typeof(System.String));
            _datatable.Columns.Add("Entering_Organization", typeof(System.String));
            _datatable.Columns.Add("Entering_Device", typeof(System.String));
            _datatable.Columns.Add("Action_By", typeof(System.String));
            _datatable.Columns.Add("Advanced_Beneficiary_Notice_Code", typeof(System.String));
            _datatable.Columns.Add("Ordering_Facility_Name", typeof(System.String));
            _datatable.Columns.Add("Ordering_Facility_Address", typeof(System.String));
            _datatable.Columns.Add("Ordering_Facility_Phone_Number", typeof(System.String));
            _datatable.Columns.Add("Ordering_Provider_Address", typeof(System.String));
            _datatable.Columns.Add("Order_Status_Modifier", typeof(System.String));
            _datatable.Columns.Add("Advanced_Beneficiary_Notice_Override_Reason", typeof(System.String));
           _datatable.Columns.Add("Filler_Expected_Availability_Date_time", typeof(System.DateTime));
            _datatable.Columns.Add("Confidentially_Code", typeof(System.String));
            _datatable.Columns.Add("Order_Type", typeof(System.String));
            _datatable.Columns.Add("Enterer_Authorization_Mode", typeof(System.String));
            _datatable.Columns.Add("ORCParent_Universal_Service_Identifier", typeof(System.String));
            _datatable.Columns.Add("HLMessageID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int64));
            _datatable.Columns.Add("LocationID", typeof(System.Int64));
           _datatable.Columns.Add("HLMessageORCContent", typeof(System.String));


            DataRow _datarow;

            foreach (HLMessageORCDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ORCEvent_Type"] = _list.ORCEvent_Type;
                _datarow["Order_Control"] = _list.Order_Control;
                _datarow["Place_Order_Number"] = _list.Place_Order_Number;
                _datarow["ORCPlEntity_Identifier"] = _list.ORCPlEntity_Identifier;
                _datarow["ORCFiller_Order_Number"] = _list.ORCFiller_Order_Number;
                _datarow["ORCFEntity_Identifier"] = _list.ORCFEntity_Identifier;
                _datarow["Placer_Group_Number"] = _list.Placer_Group_Number;
                _datarow["ORCPrEntity_Identifier"] = _list.ORCPrEntity_Identifier;
                _datarow["Order_Status"] = _list.Order_Status;
                _datarow["Response_Flag"] = _list.Response_Flag;
                _datarow["ORCQuantity_Timing"] = _list.ORCQuantity_Timing;
                _datarow["Quantity"] = _list.Quantity;
                _datarow["Interval"] = _list.Interval;
                _datarow["Duration"] = _list.Duration;
                _datarow["Start_Date_Time"] = _list.Start_Date_Time;
                _datarow["End_Date_Time"] = _list.End_Date_Time;
                _datarow["ORCPriority"] = _list.ORCPriority;
                _datarow["Parent_Order"] = _list.Parent_Order;
                _datarow["Placer_Assigned_Identifier"] = _list.Placer_Assigned_Identifier;
                _datarow["Date_Time_Of_Transaction"] = _list.Date_Time_Of_Transaction;
                _datarow["Entered_By"] = _list.Entered_By;
                _datarow["EnterPerson_Identifier"] = _list.EnterPerson_Identifier;
                _datarow["EnterFamily_Name"] = _list.EnterFamily_Name;
                _datarow["EnterGiven_Name"] = _list.EnterGiven_Name;
                _datarow["EnterSecond_and_Further_Given_Names_or_Initials_Thereof"] = _list.EnterSecond_and_Further_Given_Names_or_Initials_Thereof;
                _datarow["Verified_By"] = _list.Verified_By;
                _datarow["ORCOrdering_Provider"] = _list.ORCOrdering_Provider;
                _datarow["OrderingPerson_Identifier"] = _list.OrderingPerson_Identifier;
                _datarow["OrderingFamily_Name"] = _list.OrderingFamily_Name;
                _datarow["OrderingGiven_Name"] = _list.OrderingGiven_Name;
                _datarow["OrderingSecond_and_Further_Given_Names_or_Initials_Thereof"] = _list.OrderingSecond_and_Further_Given_Names_or_Initials_Thereof;
               _datarow["ORCSuffix"] = _list.ORCSuffix;
               _datarow["ORCPrefix"] = _list.ORCPrefix;
               _datarow["ORCDegree"] = _list.ORCDegree;
                _datarow["Enterer_Location"] = _list.Enterer_Location;
                _datarow["Point_of_Care"] = _list.Point_of_Care;
                _datarow["Room"] = _list.Room;
                _datarow["Bed"] = _list.Bed;
                _datarow["Facility"] = _list.Facility;
                _datarow["Call_Back_Phone_Number"] = _list.Call_Back_Phone_Number;
                _datarow["ORCTelephone_number"] = _list.ORCTelephone_number;
                _datarow["Order_Effective_Date_Time"] = _list.Order_Effective_Date_Time;
                _datarow["Order_Control_Code_Reason"] = _list.Order_Control_Code_Reason;
                _datarow["Entering_Organization"] = _list.Entering_Organization;
                _datarow["Entering_Device"] = _list.Entering_Device;
                _datarow["Action_By"] = _list.Action_By;
                _datarow["Advanced_Beneficiary_Notice_Code"] = _list.Advanced_Beneficiary_Notice_Code;
                _datarow["Ordering_Facility_Name"] = _list.Ordering_Facility_Name;
                _datarow["Ordering_Facility_Address"] = _list.Ordering_Facility_Address;
                _datarow["Ordering_Facility_Phone_Number"] = _list.Ordering_Facility_Phone_Number;
                _datarow["Ordering_Provider_Address"] = _list.Ordering_Provider_Address;
                _datarow["Order_Status_Modifier"] = _list.Order_Status_Modifier;
                _datarow["Advanced_Beneficiary_Notice_Override_Reason"] = _list.Advanced_Beneficiary_Notice_Override_Reason;
                _datarow["Filler_Expected_Availability_Date_time"] = _list.Filler_Expected_Availability_Date_time;
                _datarow["Confidentially_Code"] = _list.Confidentially_Code;
                _datarow["Order_Type"] = _list.Order_Type;
                _datarow["Enterer_Authorization_Mode"] = _list.Enterer_Authorization_Mode;
                _datarow["ORCParent_Universal_Service_Identifier"] = _list.ORCParent_Universal_Service_Identifier;
                _datarow["HLMessageID"] = _list.HLMessageID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["LocationID"] = _list.LocationID;
               _datarow["HLMessageORCContent"] = _list.HLMessageORCContent;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
		public static System.Data.DataTable ConvertToUDTHLMessagePatientIDDetails(List<HLMessagePatientIDDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();
            _datatable.Columns.Add("PIDEvent_Type",typeof(System.String));
            _datatable.Columns.Add("Set_ID_PID",typeof(System.String));
            _datatable.Columns.Add("Patient_ID",typeof(System.String));
            _datatable.Columns.Add("Patient_Identifier_List",typeof(System.String));
            _datatable.Columns.Add("ID_Number",typeof(System.String));
            _datatable.Columns.Add("Identifier_Check_Digit",typeof(System.String));
            _datatable.Columns.Add("Check_Digit_Scheme",typeof(System.String));
            _datatable.Columns.Add("Alteration_Patient_ID_PID",typeof(System.String));
            _datatable.Columns.Add("Patient_Name",typeof(System.String));
            _datatable.Columns.Add("PIDFamily_Name",typeof(System.String));
            _datatable.Columns.Add("Given_Name",typeof(System.String));
            _datatable.Columns.Add("Second_and_further_given_Names_or_Initials_Thereof",typeof(System.String));
            _datatable.Columns.Add("PIDSuffix",typeof(System.String));
            _datatable.Columns.Add("PIDPrefix",typeof(System.String));
            _datatable.Columns.Add("PIDDegree",typeof(System.String));
            _datatable.Columns.Add("Mother_Maiden_Name",typeof(System.String));
           _datatable.Columns.Add("Date_time_Of_Birth", typeof(System.DateTime));
            _datatable.Columns.Add("Date_Administrative_Sex",typeof(System.String));
            _datatable.Columns.Add("Patient_Alies",typeof(System.String));
            _datatable.Columns.Add("Race",typeof(System.String));
            _datatable.Columns.Add("Patient_Address",typeof(System.String));
            _datatable.Columns.Add("Street_Mailing_Address",typeof(System.String));
            _datatable.Columns.Add("Other_Designation",typeof(System.String));
            _datatable.Columns.Add("City",typeof(System.String));
            _datatable.Columns.Add("State_Of_Province",typeof(System.String));
            _datatable.Columns.Add("Zip_Or_Postal_Code",typeof(System.String));
            _datatable.Columns.Add("Country",typeof(System.String));
            _datatable.Columns.Add("PIDCountry_Code",typeof(System.String));
            _datatable.Columns.Add("Phone_Number_home",typeof(System.String));
            _datatable.Columns.Add("HTelephone_Number",typeof(System.String));
            _datatable.Columns.Add("HPhone_Number_Business",typeof(System.String));
            _datatable.Columns.Add("HBTelephone_Number",typeof(System.String));
           _datatable.Columns.Add("PIDAssigning_Authority", typeof(System.String));
           _datatable.Columns.Add("PIDIdentifier_Type_Code", typeof(System.String));
            _datatable.Columns.Add("Telecommunication_use_code",typeof(System.String));
            _datatable.Columns.Add("Telecommunication_Equipment_Type",typeof(System.String));
            _datatable.Columns.Add("Communication_Address", typeof(System.String));
            _datatable.Columns.Add("Phone_Number_Business",typeof(System.String));
            _datatable.Columns.Add("PIDTelephone_Number",typeof(System.String));
            _datatable.Columns.Add("Primary_Language",typeof(System.String));
            _datatable.Columns.Add("Marital_Status",typeof(System.String));
            _datatable.Columns.Add("Religion",typeof(System.String));
            _datatable.Columns.Add("Patient_Account_Number",typeof(System.String));
            _datatable.Columns.Add("ACID_Number",typeof(System.String));
            _datatable.Columns.Add("SSN_Number_Patient",typeof(System.String));
            _datatable.Columns.Add("Driver_License_Number_Patient",typeof(System.String));
            _datatable.Columns.Add("Mother_Identifier",typeof(System.String));
            _datatable.Columns.Add("MID_Number",typeof(System.String));
            _datatable.Columns.Add("Ethnic_Group",typeof(System.String));
            _datatable.Columns.Add("EGIdentifier",typeof(System.String));
            _datatable.Columns.Add("Birth_Place",typeof(System.String));
            _datatable.Columns.Add("Multiple_Birth_Indicator",typeof(System.String));
            _datatable.Columns.Add("Birth_Order",typeof(System.String));
            _datatable.Columns.Add("Citizenship",typeof(System.String));
            _datatable.Columns.Add("Veterans_Military_Status",typeof(System.String));
            _datatable.Columns.Add("Nationality",typeof(System.String));
           _datatable.Columns.Add("Patient_Death_Date_and_Time", typeof(System.DateTime));
            _datatable.Columns.Add("Patient_Death_Indicator",typeof(System.String));
            _datatable.Columns.Add("Identity_Unknown_Indicator",typeof(System.String));
            _datatable.Columns.Add("Identity_reliability_Code",typeof(System.String));
           _datatable.Columns.Add("Last_Updated_DateTime", typeof(System.DateTime));
            _datatable.Columns.Add("Last_Update_Facility",typeof(System.String));
            _datatable.Columns.Add("NamespaceID",typeof(System.String));
            _datatable.Columns.Add("Species_Code",typeof(System.String));
            _datatable.Columns.Add("Breed_Code",typeof(System.String));
            _datatable.Columns.Add("Strain",typeof(System.String));
            _datatable.Columns.Add("Production_Class_Code",typeof(System.String));
            _datatable.Columns.Add("Tribal_Citizenship",typeof(System.String));
            _datatable.Columns.Add("PIDIdentifier",typeof(System.String));
            _datatable.Columns.Add("Ward_Code",typeof(System.String));
            _datatable.Columns.Add("HLMessageID",typeof(System.Int64));
            _datatable.Columns.Add("OrgID",typeof(System.Int64));
            _datatable.Columns.Add("LocationID", typeof(System.Int64));
           _datatable.Columns.Add("HLMessagePatientIDContent", typeof(System.String));
           _datatable.Columns.Add("HTelecommunication_use_code", typeof(System.String));
           _datatable.Columns.Add("HTelecommunication_Equipment_Type", typeof(System.String));
           _datatable.Columns.Add("HCommunication_Address", typeof(System.String));

            DataRow _datarow;

            foreach (HLMessagePatientIDDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PIDEvent_Type"] = _list.PIDEvent_Type;
                _datarow["Set_ID_PID"] = _list.Set_ID_PID;
                _datarow["Patient_ID"] = _list.Patient_ID;
                _datarow["Patient_Identifier_List"] = _list.Patient_Identifier_List;
                _datarow["ID_Number"] = _list.ID_Number;
                _datarow["Identifier_Check_Digit"] = _list.Identifier_Check_Digit;
                _datarow["Check_Digit_Scheme"] = _list.Check_Digit_Scheme;
                _datarow["Alteration_Patient_ID_PID"] = _list.Alteration_Patient_ID_PID;
                _datarow["Patient_Name"] = _list.Patient_Name;
                _datarow["PIDFamily_Name"] = _list.PIDFamily_Name;
                _datarow["Given_Name"] = _list.Given_Name;
                _datarow["Second_and_further_given_Names_or_Initials_Thereof"] = _list.Second_and_further_given_Names_or_Initials_Thereof;
                _datarow["PIDSuffix"] = _list.PIDSuffix;
                _datarow["PIDPrefix"] = _list.PIDPrefix;
                _datarow["PIDDegree"] = _list.PIDDegree;
                _datarow["Mother_Maiden_Name"] = _list.Mother_Maiden_Name;
                _datarow["Date_time_Of_Birth"] = _list.Date_time_Of_Birth;
                _datarow["Date_Administrative_Sex"] = _list.Date_Administrative_Sex;
                _datarow["Patient_Alies"] = _list.Patient_Alies;
                _datarow["Race"] = _list.Race;
                _datarow["Patient_Address"] = _list.Patient_Address;
                _datarow["Street_Mailing_Address"] = _list.Street_Mailing_Address;
                _datarow["Other_Designation"] = _list.Other_Designation;
                _datarow["City"] = _list.City;
                _datarow["State_Of_Province"] = _list.State_Of_Province;
                _datarow["Zip_Or_Postal_Code"] = _list.Zip_Or_Postal_Code;
                _datarow["Country"] = _list.Country;
                _datarow["PIDCountry_Code"] = _list.PIDCountry_Code;
                _datarow["Phone_Number_home"] = _list.Phone_Number_home;
                _datarow["HTelephone_Number"] = _list.HTelephone_Number;
                _datarow["HPhone_Number_Business"] = _list.HPhone_Number_Business;
                _datarow["HBTelephone_Number"] = _list.HBTelephone_Number;
               _datarow["PIDAssigning_Authority"] = _list.PIDAssigning_Authority;
               _datarow["PIDIdentifier_Type_Code"] = _list.PIDIdentifier_Type_Code;
                _datarow["Telecommunication_use_code"] = _list.Telecommunication_use_code;
                _datarow["Telecommunication_Equipment_Type"] = _list.Telecommunication_Equipment_Type;
                _datarow["Communication_Address"] = _list.Communication_Address;
                _datarow["Phone_Number_Business"] = _list.Phone_Number_Business;
                _datarow["PIDTelephone_Number"] = _list.PIDTelephone_Number;
                _datarow["Primary_Language"] = _list.Primary_Language;
                _datarow["Marital_Status"] = _list.Marital_Status;
                _datarow["Religion"] = _list.Religion;
                _datarow["Patient_Account_Number"] = _list.Patient_Account_Number;
                _datarow["ACID_Number"] = _list.ACID_Number;
                _datarow["SSN_Number_Patient"] = _list.SSN_Number_Patient;
                _datarow["Driver_License_Number_Patient"] = _list.Driver_License_Number_Patient;
                _datarow["Mother_Identifier"] = _list.Mother_Identifier;
                _datarow["MID_Number"] = _list.MID_Number;
                _datarow["Ethnic_Group"] = _list.Ethnic_Group;
                _datarow["EGIdentifier"] = _list.EGIdentifier;
                _datarow["Birth_Place"] = _list.Birth_Place;
                _datarow["Multiple_Birth_Indicator"] = _list.Multiple_Birth_Indicator;
                _datarow["Birth_Order"] = _list.Birth_Order;
                _datarow["Citizenship"] = _list.Citizenship;
                _datarow["Veterans_Military_Status"] = _list.Veterans_Military_Status;
                _datarow["Nationality"] = _list.Nationality;
                _datarow["Patient_Death_Date_and_Time"] = _list.Patient_Death_Date_and_Time;
                _datarow["Patient_Death_Indicator"] = _list.Patient_Death_Indicator;
                _datarow["Identity_Unknown_Indicator"] = _list.Identity_Unknown_Indicator;
                _datarow["Identity_reliability_Code"] = _list.Identity_reliability_Code;
                _datarow["Last_Updated_DateTime"] = _list.Last_Updated_DateTime;
                _datarow["Last_Update_Facility"] = _list.Last_Update_Facility;
                _datarow["NamespaceID"] = _list.NamespaceID;
                _datarow["Species_Code"] = _list.Species_Code;
                _datarow["Breed_Code"] = _list.Breed_Code;
                _datarow["Strain"] = _list.Strain;
                _datarow["Production_Class_Code"] = _list.Production_Class_Code;
                _datarow["Tribal_Citizenship"] = _list.Tribal_Citizenship;
                _datarow["PIDIdentifier"] = _list.PIDIdentifier;
                _datarow["Ward_Code"] = _list.Ward_Code;
                _datarow["HLMessageID"] = _list.HLMessageID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["LocationID"] = _list.LocationID;
               _datarow["HLMessagePatientIDContent"] = _list.HLMessagePatientIDContent;
               _datarow["HTelecommunication_use_code"] = _list.HTelecommunication_use_code;
               _datarow["HTelecommunication_Equipment_Type"] = _list.HTelecommunication_Equipment_Type;
               _datarow["HCommunication_Address"] = _list.HCommunication_Address;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
		public static System.Data.DataTable ConvertToUDTHLMessageErrorDetails(List<HLMessageErrorDetails> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();
            _datatable.Columns.Add("HLMessageError", typeof(System.String));
            _datatable.Columns.Add("HLMessageID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int64));
            _datatable.Columns.Add("LocationID", typeof(System.Int64));
            _datatable.Columns.Add("HLMessageColumns", typeof(System.String));
            _datatable.Columns.Add("HLMessageTable", typeof(System.String));
            _datatable.Columns.Add("FileNames", typeof(System.String));
            _datatable.Columns.Add("Locations", typeof(System.String));
            DataRow _datarow;
            foreach (HLMessageErrorDetails _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["HLMessageError"] = _list.HLMessageError;
                _datarow["HLMessageID"] = _list.HLMessageID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["LocationID"] = _list.LocationID;
                _datarow["HLMessageColumns"] = _list.HLMessageColumns;
                _datarow["HLMessageTable"] = _list.HLMessageTable;
                _datarow["FileNames"] = _list.FileNames;
                _datarow["Locations"] = _list.Locations;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
		public static System.Data.DataTable ConvertToUDTHLMessages(List<HLMessages> _lstCollection)
        {
            System.Data.DataTable _datatable = new System.Data.DataTable();
            _datatable.Columns.Add("HLMessagesID", typeof(System.Int32));
            _datatable.Columns.Add("MsgControlId", typeof(System.String));
            _datatable.Columns.Add("ParentControlId", typeof(System.String));
            _datatable.Columns.Add("OrgId", typeof(System.Int32));
            _datatable.Columns.Add("MsgType", typeof(System.String));
            _datatable.Columns.Add("Sending_App", typeof(System.String));
            _datatable.Columns.Add("Sending_Facility", typeof(System.String));
            _datatable.Columns.Add("Rec_App", typeof(System.String));
            _datatable.Columns.Add("Rec_Facility", typeof(System.String));
            _datatable.Columns.Add("TransferDatetime", typeof(System.DateTime));
            _datatable.Columns.Add("msg_Content", typeof(System.String));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("ErrorList", typeof(System.String));
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("HL7Message", typeof(System.String));
            _datatable.Columns.Add("PatientIdentifier", typeof(System.String));
            _datatable.Columns.Add("StatusOfInbound", typeof(System.String));
            _datatable.Columns.Add("XMLERROR", typeof(System.String));
            _datatable.Columns.Add("OrderedId", typeof(System.String));
            _datatable.Columns.Add("ControlType", typeof(System.String));
            _datatable.Columns.Add("TaskDate", typeof(System.DateTime));
            _datatable.Columns.Add("PickedAt", typeof(System.DateTime));
            _datatable.Columns.Add("CompletedAt", typeof(System.DateTime));
            _datatable.Columns.Add("MessageStatus", typeof(System.String));
            _datatable.Columns.Add("ErrorDescription", typeof(System.String));
            _datatable.Columns.Add("Futuredate", typeof(System.DateTime));
            _datatable.Columns.Add("ParentHLMessagesID", typeof(System.Int64));
            _datatable.Columns.Add("FileNames", typeof(System.String));
            _datatable.Columns.Add("FileCreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("FileModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("LocationID", typeof(System.Int64));
            _datatable.Columns.Add("Locations", typeof(System.String));
            DataRow _datarow;
            foreach (HLMessages _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["HLMessagesID"] = _list.HLMessagesID;
                _datarow["MsgControlId"] = _list.MsgControlId;
                _datarow["ParentControlId"] = _list.ParentControlId;
                _datarow["OrgId"] = _list.OrgId;
                _datarow["MsgType"] = _list.MsgType;
                _datarow["Sending_App"] = _list.Sending_App;
                _datarow["Sending_Facility"] = _list.Sending_Facility;
                _datarow["Rec_App"] = _list.Rec_App;
                _datarow["Rec_Facility"] = _list.Rec_Facility;
                _datarow["TransferDatetime"] = _list.TransferDatetime;
                _datarow["msg_Content"] = _list.Msg_Content;
                _datarow["Status"] = _list.Status;
                _datarow["ErrorList"] = _list.ErrorList;
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["HL7Message"] = _list.HL7Message;
                _datarow["PatientIdentifier"] = _list.PatientIdentifier;
                _datarow["StatusOfInbound"] = _list.StatusOfInbound;
                _datarow["XMLERROR"] = _list.XMLERROR;
                _datarow["OrderedId"] = _list.OrderedId;
                _datarow["ControlType"] = _list.ControlType;
                _datarow["TaskDate"] = _list.TaskDate;
                _datarow["PickedAt"] = _list.PickedAt;
                _datarow["CompletedAt"] = _list.CompletedAt;
                _datarow["MessageStatus"] = _list.MessageStatus;
                _datarow["ErrorDescription"] = _list.ErrorDescription;
                _datarow["Futuredate"] = _list.Futuredate;
                _datarow["ParentHLMessagesID"] = _list.ParentHLMessagesID;
                _datarow["FileNames"] = _list.FileNames;
                _datarow["FileCreatedAt"] = _list.FileCreatedAt;
                _datarow["FileModifiedAt"] = _list.FileModifiedAt;
                _datarow["LocationID"] = _list.LocationID;
                _datarow["Locations"] = _list.Locations;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;

        }
	   public static System.Data.DataTable ConvertHistoStatus(List<PatientHistoStatusDetails> _lstPatientHistoStatusDetails)
       {
           System.Data.DataTable _datatable = new System.Data.DataTable();

           _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
           _datatable.Columns.Add("BarcodeNumber", typeof(System.String));
           _datatable.Columns.Add("CompletionTime", typeof(System.DateTime));
           _datatable.Columns.Add("Status", typeof(System.String));
          

           DataRow _datarow;

           foreach (PatientHistoStatusDetails _list in _lstPatientHistoStatusDetails)
           {
               _datarow = _datatable.NewRow();
               _datarow["PatientVisitID"] = _list.PatientVisitID;
               _datarow["BarcodeNumber"] = _list.BarcodeNumber;
               _datarow["CompletionTime"] = _list.CompletionTime;
               _datarow["Status"] = _list.Status;              
               _datatable.Rows.Add(_datarow);
           }
           return _datatable;
       }
	   
	     public static System.Data.DataTable ConvertToUDTHistoSpecimenDetails(List<HistoSpecimenDetails> _lstSpec)
       {

           System.Data.DataTable _datatable = new System.Data.DataTable();

           _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
           _datatable.Columns.Add("ID", typeof(System.Int64));
           _datatable.Columns.Add("Type", typeof(System.String));
           _datatable.Columns.Add("SampleID", typeof(System.Int32));
           _datatable.Columns.Add("SampleName", typeof(System.String));
           _datatable.Columns.Add("SampleCount", typeof(System.Int32));
           _datatable.Columns.Add("ClinicalNotes", typeof(System.String));
           _datatable.Columns.Add("ClinicalDiagnosis", typeof(System.String));

           DataRow _datarow;
           foreach (HistoSpecimenDetails _list in _lstSpec)
           {
               _datarow = _datatable.NewRow();
               _datarow["PatientVisitID"] = _list.PatientVisitID;
               _datarow["ID"] = _list.ID;
               _datarow["Type"] = _list.Type;
               _datarow["SampleID"] = _list.SampleID;
               _datarow["SampleName"] = _list.SampleName;
               _datarow["SampleCount"] = _list.SampleCount;
               _datarow["ClinicalNotes"] = _list.ClinicalNotes;
               _datarow["ClinicalDiagnosis"] = _list.ClinicalDiagnosis;
               _datatable.Rows.Add(_datarow);
           }
           return _datatable;
       }
	   
	     public static System.Data.DataTable ConvertToErrorMappingInfo(List<DeviceErrorFlags> _lstErrorFlagMapping)
       {
           //lan
           System.Data.DataTable _datatable = new System.Data.DataTable();

           _datatable.Columns.Add("InstrumentId", typeof(System.Int64));
           _datatable.Columns.Add("ProductCode", typeof(System.String));
           _datatable.Columns.Add("InstrumentName", typeof(System.String));
           _datatable.Columns.Add("OrgID", typeof(System.Int32));
           _datatable.Columns.Add("OrgAddressID", typeof(System.Int32));

           _datatable.Columns.Add("ErrorFlagCode", typeof(System.String));
           _datatable.Columns.Add("ErrorDesc", typeof(System.String));
           _datatable.Columns.Add("ErrorFlagResult", typeof(System.String));
           _datatable.Columns.Add("OperationType", typeof(System.String));
           _datatable.Columns.Add("IsActive", typeof(System.Int16));

           DataRow _datarow;
           foreach (DeviceErrorFlags _list in _lstErrorFlagMapping)
           {
               _datarow = _datatable.NewRow();
               _datarow["InstrumentId"] = _list.InstrumentID;
               _datarow["ProductCode"] = _list.DeviceCode;
               _datarow["InstrumentName"] = _list.ProductName;
               _datarow["OrgID"] = _list.OrgID;
               _datarow["OrgAddressID"] = _list.OrgAddressID;

               _datarow["ErrorFlagCode"] = _list.ErrorCode;
               _datarow["ErrorDesc"] = _list.ErrorDescription;
               _datarow["ErrorFlagResult"] = _list.ResultValue;

               _datarow["OperationType"] = _list.operationType.ToString();
               _datarow["OperationType"] = _list.operationType.ToString();
               _datarow["IsActive"] = _list.IsActive;
               _datatable.Rows.Add(_datarow);
           }
           return _datatable;
           //Test
       }
//Added by Jegan/Parthi - Product merge start

         public static System.Data.DataTable ConvertToClinicalHistoryMaster(List<History> _lstClinicalHistoryMstr)
         {
             //lan
             System.Data.DataTable _datatable = new System.Data.DataTable();

             _datatable.Columns.Add("HistoryID", typeof(System.Int16));
             _datatable.Columns.Add("HistoryName", typeof(System.String));
             _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
             _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
             _datatable.Columns.Add("HistoryCode", typeof(System.String));

             _datatable.Columns.Add("ControlType", typeof(System.String));
             _datatable.Columns.Add("IsActive", typeof(System.String));
             _datatable.Columns.Add("OperationType", typeof(System.String));
             _datatable.Columns.Add("OrgId", typeof(System.Int16));

             DataRow _datarow;
             foreach (History _list in _lstClinicalHistoryMstr)
             {
                 _datarow = _datatable.NewRow();
                 _datarow["HistoryID"] = _list.HistoryID;
                 _datarow["HistoryName"] = _list.HistoryName;
                 _datarow["CreatedAt"] = _list.CreatedAt;
                 _datarow["ModifiedAt"] = _list.ModifiedAt;
                 _datarow["HistoryCode"] = _list.HistoryCode;

                 _datarow["ControlType"] = _list.ControlType;
                 _datarow["IsActive"] = _list.IsActive;
                 _datarow["OperationType"] = _list.OperationType.ToString();
                 _datarow["OrgId"] = _list.OrgID;

                 _datatable.Rows.Add(_datarow);
             }
             return _datatable;
             //Test
         }
 public static System.Data.DataTable ConvertToClinicalHistoryMapping(List<InvMedicalDetailsMapping> _lstClinicalHistoryMapping)
         {
             //lan
             System.Data.DataTable _datatable = new System.Data.DataTable();

             _datatable.Columns.Add("InvMedMappingID", typeof(System.Int64));
             _datatable.Columns.Add("InvID", typeof(System.Int64));
             _datatable.Columns.Add("MedicalDetailID", typeof(System.Int16));
             _datatable.Columns.Add("MedicalDetailType", typeof(System.String));
             _datatable.Columns.Add("MeanTime", typeof(System.Decimal));

             _datatable.Columns.Add("IsInternal", typeof(System.String));
             _datatable.Columns.Add("IsMandatory", typeof(System.String));
             _datatable.Columns.Add("InvType", typeof(System.String));
             _datatable.Columns.Add("IsActive", typeof(System.String));
             _datatable.Columns.Add("HistorySequence", typeof(System.Int16));
             _datatable.Columns.Add("OperationType", typeof(System.String));
             _datatable.Columns.Add("OrgId", typeof(System.Int16));

             DataRow _datarow;
             foreach (InvMedicalDetailsMapping obj in _lstClinicalHistoryMapping)
             {
                 _datarow = _datatable.NewRow();
                 _datarow["InvMedMappingID"] = obj.InvMedMappingID;
                 _datarow["InvID"] = obj.InvID;
                 _datarow["MedicalDetailID"] = obj.MedicalDetailID;
                 _datarow["MedicalDetailType"] = obj.MedicalDetailType;
                 _datarow["MeanTime"] = obj.MeanTime;

                 _datarow["IsInternal"] = obj.IsInternal;
                 _datarow["IsMandatory"] = obj.IsMandatory;
                 _datarow["InvType"] = obj.InvType;
                 _datarow["IsActive"] = obj.IsActive;
                 _datarow["HistorySequence"] = obj.HistorySequence;
                 _datarow["OperationType"] = obj.OperationType;
                 _datarow["OrgId"] = obj.OrgId;

                 _datatable.Rows.Add(_datarow);
             }
             return _datatable;
             //Test
         }
 public static System.Data.DataTable ConvertToUDDPatientoneInvSampleTransfer(List<PatientInvSample> _lstCollection)
 {
     //lan
     System.Data.DataTable _datatable = new System.Data.DataTable();

     _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
     _datatable.Columns.Add("SampleID", typeof(System.Int32));
     _datatable.Columns.Add("OrgID", typeof(System.Int32));
     _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
     _datatable.Columns.Add("RecSampleLocID", typeof(System.Int32));
     _datatable.Columns.Add("UID", typeof(System.String));
     _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
     _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
     _datatable.Columns.Add("Type", typeof(System.String));
     _datatable.Columns.Add("IsIntegrationTest", typeof(System.Int16));

     DataRow _datarow;

     foreach (PatientInvSample _list in _lstCollection)
     {
         _datarow = _datatable.NewRow();
         _datarow["PatientVisitID"] = _list.PatientVisitID;
         _datarow["SampleID"] = _list.SampleID;
         _datarow["OrgID"] = _list.OrgID;
         _datarow["ModifiedBy"] = _list.ModifiedBy;
         _datarow["RecSampleLocID"] = _list.RecSampleLocID;
         _datarow["UID"] = _list.UID;
         _datarow["InvestigationID"] = _list.INVID;
         _datarow["CreatedAt"] = _list.CreatedAt;
         _datarow["Type"] = _list.Type;
         _datarow["IsIntegrationTest"] = _list.isinte;
         _datatable.Rows.Add(_datarow);
     }
     return _datatable;
     //Test
 }
 public static System.Data.DataTable ConvertToNotificationUpdate(List<Notifications> _lstNotication)
 {
     //lan
     System.Data.DataTable _datatable = new System.Data.DataTable();

     _datatable.Columns.Add("NotificationID", typeof(System.Int64));
     _datatable.Columns.Add("Status", typeof(System.String));

     DataRow _datarow;

     foreach (Notifications _list in _lstNotication)
     {
         _datarow = _datatable.NewRow();
         _datarow["NotificationID"] = _list.NotificationID;
         _datarow["Status"] = _list.Status;
         _datatable.Rows.Add(_datarow);
     }
     return _datatable;

 }
        /* BEGIN | sabari | 20181129 | Dev | Culture Report */
        public static System.Data.DataTable ConvertToUDTDrugLevelMapping(List<DrugLevelMapping> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("LevelID", typeof(System.Int64));
            _datatable.Columns.Add("LevelName", typeof(System.String));
            _datatable.Columns.Add("DrugID", typeof(System.Int64));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("IsActive", typeof(System.Boolean));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));

            DataRow _datarow;

            foreach (DrugLevelMapping _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["LevelID"] = _list.LevelID;
                _datarow["LevelName"] = _list.LevelName;
                _datarow["DrugID"] = _list.DrugID;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["IsActive"] = _list.IsActive;
                _datarow["OrgID"] = _list.OrgID;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        /* END | sabari | 20181129 | Dev | Culture Report */

	/*START || JAYARAMANAN L || Dev || 05112019 || Organism Range */
        public static System.Data.DataTable ConvertToUDTInvOrganismDrugMapping(List<InvOrganismDrugMapping> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("DrugName", typeof(System.String));
            _datatable.Columns.Add("DrugID", typeof(System.Int64));
            _datatable.Columns.Add("DrugCode", typeof(System.String));
            _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
            _datatable.Columns.Add("InvestigationName", typeof(System.String));
            _datatable.Columns.Add("OrganismID", typeof(System.Int64));
            _datatable.Columns.Add("OrganismName", typeof(System.String));
            _datatable.Columns.Add("OrganismCode", typeof(System.String));
            _datatable.Columns.Add("Intermediate", typeof(System.String));
            _datatable.Columns.Add("Resistant", typeof(System.String));
            _datatable.Columns.Add("Susceptibility", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime)); 
            _datatable.Columns.Add("SequenceNo", typeof(System.Int32));
            _datatable.Columns.Add("IsActive", typeof(System.Boolean));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));

            DataRow _datarow;

            foreach (InvOrganismDrugMapping _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["DrugName"] = _list.DrugName;
                _datarow["DrugID"] = _list.DrugID;
                _datarow["DrugCode"] = _list.DrugCode;
                _datarow["InvestigationID"] = _list.InvestigationID;
                _datarow["InvestigationName"] = _list.InvestigationName;
                _datarow["OrganismID"] = _list.OrganismID;
                _datarow["OrganismName"] = _list.OrganismName;
                _datarow["OrganismCode"] = _list.OrganismCode;
                _datarow["Intermediate"] = _list.Intermediate;
                _datarow["Resistant"] = _list.Resistant;
                _datarow["Susceptibility"] = _list.Susceptibility;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["SequenceNo"] = _list.SequenceNo;
                _datarow["IsActive"] = _list.IsActive;
                _datarow["OrgID"] = _list.OrgID; 
                _datatable.Rows.Add(_datarow);
            }
            return _datatable; 
        }
        /*END || JAYARAMANAN L || Dev || 05112019 || Organism Range */

        public static System.Data.DataTable ConvertToInvIntegrationQCResultValue(List<InvIntegrationQCResultValue> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("TestCode", typeof(System.String));
            _datatable.Columns.Add("ResultValue", typeof(System.String));
            _datatable.Columns.Add("ResultUOM", typeof(System.String));
            _datatable.Columns.Add("DeviceID", typeof(System.String));
            _datatable.Columns.Add("OrganismName", typeof(System.String));
            _datatable.Columns.Add("OrganismCode", typeof(System.String));
            _datatable.Columns.Add("DrugCode", typeof(System.String));
            _datatable.Columns.Add("DrugName", typeof(System.String));
            _datatable.Columns.Add("Sensitivity", typeof(System.String));
            _datatable.Columns.Add("MicValue", typeof(System.String));
            _datatable.Columns.Add("DeviceErrorCode", typeof(System.String));
            _datatable.Columns.Add("QCLevel", typeof(System.String));
            _datatable.Columns.Add("LotName", typeof(System.String));
            _datatable.Columns.Add("AddInfo", typeof(System.String));
            _datatable.Columns.Add("AddInfoValue", typeof(System.String));
            _datatable.Columns.Add("QCStatus", typeof(System.String));
            _datatable.Columns.Add("QCRange", typeof(System.String));
            _datatable.Columns.Add("QCFailedRule", typeof(System.String));
            _datatable.Columns.Add("ProcessedAt", typeof(System.String));
            DataRow _datarow;

            foreach (InvIntegrationQCResultValue _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["TestCode"] = _list.TestCode;
                _datarow["ResultValue"] = _list.ResultValue;
                _datarow["ResultUOM"] = _list.ResultUOM;
                _datarow["DeviceID"] = _list.DeviceID;
                _datarow["OrganismName"] = _list.OrganismName;
                _datarow["OrganismCode"] = _list.OrganismCode;
                _datarow["DrugCode"] = _list.DrugCode;
                _datarow["DrugName"] = _list.DrugName;
                _datarow["Sensitivity"] = _list.Sensitivity;
                _datarow["MicValue"] = _list.MicValue;
                _datarow["DeviceErrorCode"] = _list.DeviceErrorCode;
                _datarow["QCLevel"] = _list.QCLevel;
                _datarow["LotName"] = _list.LotName;
                _datarow["AddInfo"] = _list.AddInfo;
                _datarow["AddInfoValue"] = _list.AddInfoValue;
                _datarow["QCStatus"] = _list.QCStatus;
                _datarow["QCRange"] = _list.QCRange;
                _datarow["QCFailedRule"] = _list.QCFiledRule;
                _datarow["ProcessedAt"] = _list.ProcessedAt;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToUDTClientLanguage(List<ClientLanguage> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ClientID", typeof(System.Int64));
            _datatable.Columns.Add("ReportLanguage", typeof(System.String));
            _datatable.Columns.Add("NoofCopies", typeof(System.Int32));
            _datatable.Columns.Add("isActive", typeof(System.String));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));

            DataRow _datarow;

            foreach (ClientLanguage _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ClientID"] = _list.ClientID;
                _datarow["ReportLanguage"] = _list.ReportLanguage;
                _datarow["NoofCopies"] = _list.NoofCopies;
                _datarow["isActive"] = _list.IsActive;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToUDTPatientVisitLanguage(List<PatientVisitLanguage> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();
             
            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("ReportLanguage", typeof(System.String));
            _datatable.Columns.Add("IsActive", typeof(System.String));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));

            DataRow _datarow;

            foreach (PatientVisitLanguage _list in _lstCollection)
            {
                _datarow = _datatable.NewRow(); 
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["ReportLanguage"] = _list.ReportLanguage;
                _datarow["IsActive"] = _list.IsActive;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static DataTable ConvertToBidirectionalBarcodesDetails(List<BidirectionalBarcodesDetails> lstBarCode)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientName", typeof(System.String));
            _datatable.Columns.Add("PatientAge", typeof(System.String));
            _datatable.Columns.Add("PatientSex", typeof(System.String));
            _datatable.Columns.Add("TestCode", typeof(System.String));
            _datatable.Columns.Add("Barcode", typeof(System.String));
            _datatable.Columns.Add("PatientInvId", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("DeviceID", typeof(System.String));
            _datatable.Columns.Add("DeviceDate", typeof(System.DateTime));
            _datatable.Columns.Add("DOB", typeof(System.DateTime));
            _datatable.Columns.Add("SampleName", typeof(System.String));
            _datatable.Columns.Add("PhysicianName", typeof(System.String));
            _datatable.Columns.Add("ClientName", typeof(System.String));
            _datatable.Columns.Add("VisitNumber", typeof(System.String));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            _datatable.Columns.Add("rowid", typeof(System.Int64));
            _datatable.Columns.Add("PatientVisitId", typeof(System.Int64));
            _datatable.Columns.Add("AccessionNumber", typeof(System.Int64));
            _datatable.Columns.Add("AttFlag", typeof(System.Char));
            _datatable.Columns.Add("IsProcessed", typeof(System.Char));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("String1", typeof(System.String));
            _datatable.Columns.Add("String2", typeof(System.String));
            _datatable.Columns.Add("Int1", typeof(System.Int32));
            _datatable.Columns.Add("Int2", typeof(System.Int32));
            _datatable.Columns.Add("Long1", typeof(System.Int64));
            DataRow _datarow;
            foreach (BidirectionalBarcodesDetails _lstBidirectionalBarcodes in lstBarCode)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientName"] = _lstBidirectionalBarcodes.PatientName;
                _datarow["PatientAge"] = _lstBidirectionalBarcodes.PatientAge;
                _datarow["PatientSex"] = _lstBidirectionalBarcodes.PatientSex;
                _datarow["TestCode"] = _lstBidirectionalBarcodes.TestCode;
                _datarow["Barcode"] = _lstBidirectionalBarcodes.BarCode;
                _datarow["PatientInvId"] = _lstBidirectionalBarcodes.PatientInvID;
                _datarow["OrgID"] = _lstBidirectionalBarcodes.OrgID;
                _datarow["DeviceID"] = _lstBidirectionalBarcodes.DeviceID;
                _datarow["DeviceDate"] = _lstBidirectionalBarcodes.DeviceDate;
                _datarow["DOB"] = _lstBidirectionalBarcodes.DOB;
                _datarow["SampleName"] = _lstBidirectionalBarcodes.SampleName;
                _datarow["PhysicianName"] = _lstBidirectionalBarcodes.PhysicianName;
                _datarow["ClientName"] = _lstBidirectionalBarcodes.ClientName;
                _datarow["VisitNumber"] = _lstBidirectionalBarcodes.VisitNumber;
                _datarow["Remarks"] = _lstBidirectionalBarcodes.Remarks;
                _datarow["rowid"] = _lstBidirectionalBarcodes.rowid;
                _datarow["PatientVisitId"] = _lstBidirectionalBarcodes.PatientVisitId;
                _datarow["AttFlag"] = _lstBidirectionalBarcodes.AttFlag;
                _datarow["IsProcessed"] = _lstBidirectionalBarcodes.IsProcessed;
                _datarow["CreatedAt"] = _lstBidirectionalBarcodes.CreatedAt;
                _datarow["String1"] = _lstBidirectionalBarcodes.String1;
                _datarow["String2"] = _lstBidirectionalBarcodes.String2;
                _datarow["Int1"] = _lstBidirectionalBarcodes.Int1;
                _datarow["Int2"] = _lstBidirectionalBarcodes.Int2;
                _datarow["Long1"] = _lstBidirectionalBarcodes.Long1;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }


        public static DataTable ConvertToDeviceTranData(List<DeviceInvestigationData> _lstDeviceTransData)
        {
            DataTable table = new DataTable();
            table.Columns.Add("UID", typeof(int));
            table.Columns.Add("DeviceID", typeof(string));
            table.Columns.Add("GroupID", typeof(long));
            table.Columns.Add("MessageID", typeof(string));
            table.Columns.Add("PatientID", typeof(long));
            table.Columns.Add("SampleID", typeof(string));
            table.Columns.Add("ContainerNo", typeof(string));
            table.Columns.Add("OrderedDTTM", typeof(DateTime));
            table.Columns.Add("SpecimenCollectionDTTM", typeof(DateTime));
            table.Columns.Add("TestCode", typeof(string));
            table.Columns.Add("Value", typeof(string));
            table.Columns.Add("ValueUOM", typeof(string));
            table.Columns.Add("ReferenceRange", typeof(string));
            table.Columns.Add("AbnormalFlag", typeof(string));
            table.Columns.Add("ResultType", typeof(string));
            table.Columns.Add("ResultCompletedDTTM", typeof(DateTime));
            table.Columns.Add("CreatedAt", typeof(DateTime));
            table.Columns.Add("RawDataLogID", typeof(int));
            table.Columns.Add("IsProcessed", typeof(char));
            table.Columns.Add("OrgName", typeof(string));
            table.Columns.Add("ProcessedAt", typeof(DateTime));
            foreach (DeviceInvestigationData data in _lstDeviceTransData)
            {
                DataRow row = table.NewRow();
                row["UID"] = data.UID;
                row["DeviceID"] = data.DeviceID;
                row["GroupID"] = data.GroupID;
                row["MessageID"] = data.MessageID;
                row["PatientID"] = data.PatientID;
                row["SampleID"] = data.SampleID;
                row["ContainerNo"] = data.ContainerNo;
                row["OrderedDTTM"] = data.OrderedDTTM;
                row["SpecimenCollectionDTTM"] = data.SpecimenCollectionDTTM;
                row["TestCode"] = data.TestCode;
                row["Value"] = data.Value;
                row["ValueUOM"] = data.ValueUOM;
                row["ReferenceRange"] = data.ReferenceRange;
                row["AbnormalFlag"] = data.AbnormalFlag;
                row["ResultType"] = data.ResultType;
                row["ResultCompletedDTTM"] = data.ResultCompletedDTTM;
                row["CreatedAt"] = data.CreatedAt;
                row["RawDataLogID"] = data.RawDataLogID;
                row["IsProcessed"] = data.IsProcessed;
                row["OrgName"] = data.OrgName;
                row["ProcessedAt"] = data.ProcessedAt;
                table.Rows.Add(row);
            }
            return table;
        }
		 public static System.Data.DataTable ConvertToUDTBulkRegIntegrationNotifications(List<BulkRegIntegration> lstbulkreg)
             {
                 //lan
                 System.Data.DataTable _datatable = new System.Data.DataTable();

                 _datatable.Columns.Add("NotificationID", typeof(System.Int64));
                 _datatable.Columns.Add("ErrorDescription", typeof(System.String));
                 _datatable.Columns.Add("Status", typeof(System.String));

                 DataRow _datarow;

                 foreach (BulkRegIntegration _list in lstbulkreg)
                 {
                     _datarow = _datatable.NewRow();
                     _datarow["NotificationID"] = _list.NotificationID;
                     _datarow["ErrorDescription"] = _list.ErrorDescription;
                     _datarow["Status"] = _list.Status;
                     _datatable.Rows.Add(_datarow);
                 }
                 return _datatable;
                 //Test
             }
			 public static System.Data.DataTable ConvertToPatientInvAttr(List<PatientInvestigationAttributes> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientVisitID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int64));
            _datatable.Columns.Add("PatientInvID", typeof(System.Int64));
            _datatable.Columns.Add("AccessionNumber", typeof(System.Int64));
            _datatable.Columns.Add("MedicalRemarksID", typeof(System.Int64));
            _datatable.Columns.Add("InvestigationID", typeof(System.Int64));

            DataRow _datarow;

            foreach (PatientInvestigationAttributes _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientVisitID"] = _list.PatientVisitID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["PatientInvID"] = _list.PatientInvID;
                _datarow["AccessionNumber"] = _list.AccessionNumber;
                _datarow["MedicalRemarksID"] = _list.MedicalRemarksID;
                _datarow["InvestigationID"] = _list.InvestigationID;
               
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }
			 public static System.Data.DataTable ConvertToUDTInvAutoCertifyValidation(List<InvAutoCertifyValidation> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("InvestigationId", typeof(System.Int64));
            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("Orgid", typeof(System.Int32));
            _datatable.Columns.Add("Isautocertify", typeof(System.Boolean));
            _datatable.Columns.Add("IsDeviceError", typeof(System.Boolean));
            _datatable.Columns.Add("IsQCstatus", typeof(System.Boolean));
            _datatable.Columns.Add("IsCriticalValue", typeof(System.Boolean));
            _datatable.Columns.Add("IsDeltavalue", typeof(System.Boolean));
            _datatable.Columns.Add("IsAutoauthorizationrange", typeof(System.Boolean));
            _datatable.Columns.Add("IsGroupDependencies", typeof(System.Boolean));
            _datatable.Columns.Add("IsCrossParameterCheck", typeof(System.Boolean));
            _datatable.Columns.Add("IsTechnicianVerificationNeeded", typeof(System.Boolean));

            DataRow _datarow;

            foreach (InvAutoCertifyValidation _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["InvestigationId"] = _list.InvestigationId;
                _datarow["Type"] = _list.Type;
                _datarow["Orgid"] = _list.Orgid;
                _datarow["Isautocertify"] = _list.Isautocertify;
                _datarow["IsDeviceError"] = _list.IsDeviceError;
                _datarow["IsQCstatus"] = _list.IsQCstatus;
                _datarow["IsCriticalValue"] = _list.IsCriticalValue;
                _datarow["IsDeltavalue"] = _list.IsDeltavalue;
                _datarow["IsAutoauthorizationrange"] = _list.IsAutoauthorizationrange;
                _datarow["IsGroupDependencies"] = _list.IsGroupDependencies;
                _datarow["IsCrossParameterCheck"] = _list.IsCrossParameterCheck;
                _datarow["IsTechnicianVerificationNeeded"] = _list.IsTechnicianVerificationNeeded;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

             public static System.Data.DataTable ConvertToInvRuleMaster(List<InvRuleMaster> lstInvRuleMaster)
             {
                 //lan
                 System.Data.DataTable _datatable = new System.Data.DataTable();

                 _datatable.Columns.Add("RuleMasterId", typeof(System.Int32));
                 _datatable.Columns.Add("RuleTypeID", typeof(System.Int32));
                 _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
                 _datatable.Columns.Add("InvestigationName", typeof(System.String));
                 _datatable.Columns.Add("PostTriggerFunctionId", typeof(System.Int32));
                 _datatable.Columns.Add("PostTriggerFunction", typeof(System.String));
                 _datatable.Columns.Add("InvRemarksValue", typeof(System.String));
                 _datatable.Columns.Add("OrgId", typeof(System.Int32));
                 _datatable.Columns.Add("InvType", typeof(System.String));

                 DataRow _datarow;

                 foreach (InvRuleMaster _list in lstInvRuleMaster)
                 {
                     _datarow = _datatable.NewRow();
                     _datarow["RuleMasterId"] = _list.RuleMasterId;
                     _datarow["RuleTypeID"] = _list.RuleTypeID;
                     _datarow["InvestigationID"] = _list.InvestigationID;
                     _datarow["InvestigationName"] = _list.InvestigationName;
                     _datarow["PostTriggerFunctionId"] = _list.PostTriggerFunctionId;
                     _datarow["PostTriggerFunction"] = _list.PostTriggerFunction;
                     _datarow["InvRemarksValue"] = _list.InvRemarksValue;
                     _datarow["OrgId"] = _list.OrgId;
                     _datarow["InvType"] = _list.InvType;
                     _datatable.Rows.Add(_datarow);
                 }
                 return _datatable;
                 //Test
             }
             public static System.Data.DataTable ConvertToPatientAgeGenderRule(List<PatientAgeGenderRule> lstPatientAgeGenderRule)
             {
                 //lan
                 System.Data.DataTable _datatable = new System.Data.DataTable();

                 _datatable.Columns.Add("PatientAgeGenderRuleId", typeof(System.Int32));
                 _datatable.Columns.Add("RuleMasterId", typeof(System.Int32));
                 _datatable.Columns.Add("ComponentName", typeof(System.String));
                 _datatable.Columns.Add("Gender", typeof(System.String));
                 _datatable.Columns.Add("SubCategory", typeof(System.String));
                 _datatable.Columns.Add("AgeType", typeof(System.String));
                 _datatable.Columns.Add("AgeOptr", typeof(System.String));
                 _datatable.Columns.Add("AgeValue1", typeof(System.Int32));
                 _datatable.Columns.Add("Agevalue2", typeof(System.Int32));
                 _datatable.Columns.Add("LogicalOperator", typeof(System.String));
                 _datatable.Columns.Add("RemarksId", typeof(System.Int32));


                 DataRow _datarow;

                 foreach (PatientAgeGenderRule _list in lstPatientAgeGenderRule)
                 {
                     _datarow = _datatable.NewRow();
                     _datarow["PatientAgeGenderRuleId"] = _list.PatientAgeGenderRuleId;
                     _datarow["RuleMasterId"] = _list.RuleMasterId;
                     _datarow["ComponentName"] = _list.ComponentName;
                     _datarow["Gender"] = _list.Gender;
                     _datarow["SubCategory"] = _list.SubCategory;
                     _datarow["AgeType"] = _list.AgeType;
                     _datarow["AgeOptr"] = _list.AgeOptr;
                     _datarow["AgeValue1"] = _list.AgeValue1;
                     _datarow["Agevalue2"] = _list.Agevalue2;
                     _datarow["LogicalOperator"] = _list.LogicalOperator;
                     _datarow["RemarksId"] = _list.RemarksId;
                     _datatable.Rows.Add(_datarow);
                 }
                 return _datatable;
                 //Test
             }

             public static System.Data.DataTable ConvertToTestResultsRule(List<TestResultsRule> lstTestResultsRule)
             {
                 //lan
                 System.Data.DataTable _datatable = new System.Data.DataTable();

                 _datatable.Columns.Add("TestResultsRuleId", typeof(System.Int32));
                 _datatable.Columns.Add("RuleMasterId", typeof(System.Int32));
                 _datatable.Columns.Add("ComponentName", typeof(System.String));
                 _datatable.Columns.Add("ResultInvestigationID", typeof(System.Int64));
                 _datatable.Columns.Add("ResultInvestigation", typeof(System.String));
                 _datatable.Columns.Add("ResultType", typeof(System.String));
                 _datatable.Columns.Add("ResultOptr", typeof(System.String));
                 _datatable.Columns.Add("ResultValue1", typeof(System.String));
                 _datatable.Columns.Add("Resultvalue2", typeof(System.String));
                 _datatable.Columns.Add("LogicalOperator", typeof(System.String));
                 _datatable.Columns.Add("RemarksId", typeof(System.Int32));

                 DataRow _datarow;

                 foreach (TestResultsRule _list in lstTestResultsRule)
                 {
                     _datarow = _datatable.NewRow();
                     _datarow["TestResultsRuleId"] = _list.TestResultsRuleId;
                     _datarow["RuleMasterId"] = _list.RuleMasterId;
                     _datarow["ComponentName"] = _list.ComponentName;
                     _datarow["ResultInvestigationID"] = _list.ResultInvestigationID;
                     _datarow["ResultInvestigation"] = _list.ResultInvestigation;
                     _datarow["ResultType"] = _list.ResultType;
                     _datarow["ResultOptr"] = _list.ResultOptr;
                     _datarow["ResultValue1"] = _list.ResultValue1;
                     _datarow["Resultvalue2"] = _list.Resultvalue2;
                     _datarow["LogicalOperator"] = _list.LogicalOperator;
                     _datarow["RemarksId"] = _list.RemarksId;
                     _datatable.Rows.Add(_datarow);
                 }
                 return _datatable;
                 //Test
             }

             public static System.Data.DataTable ConvertToMachineErrorRule(List<MachineErrorRule> lstMachineErrorRule)
             {
                 //lan
                 System.Data.DataTable _datatable = new System.Data.DataTable();

                 _datatable.Columns.Add("MachineErrorRuleId", typeof(System.Int32));
                 _datatable.Columns.Add("RuleMasterId", typeof(System.Int32));
                 _datatable.Columns.Add("ComponentName", typeof(System.String));
                 _datatable.Columns.Add("ErrorCode", typeof(System.String));
                 _datatable.Columns.Add("LogicalOperator", typeof(System.String));

                 DataRow _datarow;

                 foreach (MachineErrorRule _list in lstMachineErrorRule)
                 {
                     _datarow = _datatable.NewRow();
                     _datarow["MachineErrorRuleId"] = _list.MachineErrorRuleId;
                     _datarow["RuleMasterId"] = _list.RuleMasterId;
                     _datarow["ComponentName"] = _list.ComponentName;
                     _datarow["ErrorCode"] = _list.ErrorCode;
                     _datarow["LogicalOperator"] = _list.LogicalOperator;
                     _datatable.Rows.Add(_datarow);
                 }
                 return _datatable;
                 //Test
             }

             public static System.Data.DataTable ConvertToCovidReport(List<InvValuesforCovidReport> lstInvValuesCovidReport)
             {
                 //lan
                 System.Data.DataTable _datatable = new System.Data.DataTable();

                 _datatable.Columns.Add("VisitID", typeof(System.Int64));
                 _datatable.Columns.Add("PatientInvID", typeof(System.Int64));
                 _datatable.Columns.Add("AccessionNumber", typeof(System.Int64));
                 _datatable.Columns.Add("MedicalRemarksID", typeof(System.String));
                 _datatable.Columns.Add("InvestigationID", typeof(System.Int64));
                 _datatable.Columns.Add("InvestigationValueID", typeof(System.Int64));
                  _datatable.Columns.Add("Value", typeof(System.String));
                 _datatable.Columns.Add("OrgID", typeof(System.Int32));

                 DataRow _datarow;

                 foreach (InvValuesforCovidReport _list in lstInvValuesCovidReport)
                 {
                     _datarow = _datatable.NewRow();
                     _datarow["VisitID"] = _list.VisitID;
                     _datarow["PatientInvID"] = _list.PatientInvID;

                     _datarow["AccessionNumber"] = _list.AccessionNumber;
                     _datarow["MedicalRemarksID"] = _list.MedicalRemarks;
                     _datarow["InvestigationID"] = _list.InvestigationID;
                     _datarow["InvestigationValueID"] = _list.InvestigationValueID;

                     _datarow["Value"] = _list.InvValue;

                     _datarow["OrgID"] = _list.OrgID;
                     _datatable.Rows.Add(_datarow);
                 }
                 return _datatable;
                 //Test
             }
             public static System.Data.DataTable ConvertToStage_billSupply(List<Stage_InvoiceBillSupplyNo_Template> _lstCollection)
             {
                 //lan
                 System.Data.DataTable _datatable = new System.Data.DataTable();

                 _datatable.Columns.Add("ClientCode", typeof(System.String));
                 _datatable.Columns.Add("OrgID", typeof(System.Int32));
                 _datatable.Columns.Add("BillofSupplyNumber", typeof(System.String));
                 _datatable.Columns.Add("InvoiceAmount", typeof(System.Decimal));
                 _datatable.Columns.Add("SONo", typeof(System.String));
                 _datatable.Columns.Add("DateofBill", typeof(System.String));
                 _datatable.Columns.Add("AttuneInvNo", typeof(System.String));
                 


                 DataRow _datarow;

                 foreach (Stage_InvoiceBillSupplyNo_Template _list in _lstCollection)
                 {
                     _datarow = _datatable.NewRow();
                     _datarow["ClientCode"] = _list.ClientCode;
                     _datarow["OrgID"] = _list.OrgID;
                     _datarow["BillofSupplyNumber"] = _list.BillofSupplyNo;
                     _datarow["InvoiceAmount"] = _list.Value;
                     _datarow["SONo"] = _list.SONo;
                     _datarow["DateofBill"] = _list.Date;
                     _datarow["AttuneInvNo"] = _list.AttuneInvoiceNo;
                     

                     _datatable.Rows.Add(_datarow);
                 }
                 return _datatable;
                 //Test
             }
			 
			//arun changes- credit note value insert/update/get 
             public static System.Data.DataTable ConvertToCreditnoteDetails(List<CreditNotesDetails> _lstCollection)
             {                 
                 System.Data.DataTable _datatable = new System.Data.DataTable();

                 _datatable.Columns.Add("FinalbillId", typeof(System.Int64));
                 _datatable.Columns.Add("BillingDetailsId", typeof(System.Int64));
                 _datatable.Columns.Add("OrgId", typeof(System.Int64));
                 _datatable.Columns.Add("PatientVisitId", typeof(System.Int64));
                 _datatable.Columns.Add("ServiceId", typeof(System.Int64));
                 _datatable.Columns.Add("ClientId", typeof(System.Int64));
                 _datatable.Columns.Add("ClientCode", typeof(System.String));
                 _datatable.Columns.Add("ClientName", typeof(System.String));                 
                 _datatable.Columns.Add("VisitNumber", typeof(System.String));
                 _datatable.Columns.Add("CancelledDate", typeof(System.DateTime));
                 _datatable.Columns.Add("BillSupplyNumber", typeof(System.String));
                 _datatable.Columns.Add("AmountCharged", typeof(System.Decimal));
                 _datatable.Columns.Add("TestCode", typeof(System.String));
                 _datatable.Columns.Add("TestName", typeof(System.String));
                 _datatable.Columns.Add("CreditNote", typeof(System.String));                                                                    
                 _datatable.Columns.Add("NetAmount", typeof(System.Decimal));
                 _datatable.Columns.Add("GrossAmount", typeof(System.Decimal));
                 _datatable.Columns.Add("InvoiceAmount", typeof(System.Decimal));
                 _datatable.Columns.Add("InvoioceDate", typeof(System.DateTime));
                 _datatable.Columns.Add("InvoicegenBy", typeof(System.String));
                 _datatable.Columns.Add("ExtraNote", typeof(System.String));
                 _datatable.Columns.Add("Command", typeof(System.String));
                 DataRow _datarow;

                 foreach (CreditNotesDetails _list in _lstCollection)
                 {
                     _datarow = _datatable.NewRow();
                     _datarow["FinalbillId"] = _list.FinalbillId;
                     _datarow["BillingDetailsId"] = _list.BillingDetailsId;
                     _datarow["OrgId"] = _list.OrgId;
                     _datarow["PatientVisitId"] = _list.PatientVisitId;
                     _datarow["ServiceId"] = _list.ServiceId;
                     _datarow["ClientId"] = _list.ClientId;
                     _datarow["ClientCode"] = _list.ClientCode;
                     _datarow["ClientName"] = _list.ClientName;
                     _datarow["VisitNumber"] = _list.VisitNumber;
                     _datarow["CancelledDate"] = _list.CancelledDate;
                     _datarow["BillSupplyNumber"] = _list.BillSupplyNumber;
                     _datarow["AmountCharged"] = _list.AmountCharged;
                     _datarow["TestCode"] = _list.TestCode;
                     _datarow["TestName"] = _list.TestName;
                     _datarow["CreditNote"] = _list.CreditNote;                                          
                     _datarow["NetAmount"] = Decimal.Zero;
                     _datarow["GrossAmount"] = Decimal.Zero;
                     _datarow["InvoiceAmount"] = Decimal.Zero;
                     _datarow["InvoioceDate"] = DateTime.Now;
                     _datarow["InvoicegenBy"] = String.Empty;
                     _datarow["ExtraNote"] = String.Empty;
                     _datarow["Command"] = String.Empty;
                     _datatable.Rows.Add(_datarow);
                 }
                 return _datatable;                 
             }
        //
    }
}