using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Attune.Kernel.LIMSAPI.BusinessEntities;


namespace Attune.Kernel.LIMSAPI.UDT
{
    public class LIMSAPI_UDT
    {
        public static System.Data.DataTable ConvertToTableBookings(List<BookingInfo> _lstBookingInfo)
        {
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("BookingID", typeof(System.Int64));
            _datatable.Columns.Add("FirstName", typeof(System.String));
            _datatable.Columns.Add("MiddleName", typeof(System.String));
            _datatable.Columns.Add("LastName", typeof(System.String));
            _datatable.Columns.Add("Salutation", typeof(System.String));
            _datatable.Columns.Add("Age", typeof(System.String));
            _datatable.Columns.Add("Gender", typeof(System.String));
            _datatable.Columns.Add("DateofBirth", typeof(System.DateTime));
            _datatable.Columns.Add("Address", typeof(System.String));
            _datatable.Columns.Add("MobileNumber", typeof(System.String));
            _datatable.Columns.Add("Email", typeof(System.String));
            _datatable.Columns.Add("City", typeof(System.String));
            _datatable.Columns.Add("State", typeof(System.String));
            _datatable.Columns.Add("Country", typeof(System.String));
            _datatable.Columns.Add("PostalCode", typeof(System.String));
            _datatable.Columns.Add("ClientCode", typeof(System.String));
            _datatable.Columns.Add("URNType", typeof(System.String));
            _datatable.Columns.Add("URNNo", typeof(System.String));
            _datatable.Columns.Add("TRFFile", typeof(System.String));
            _datatable.Columns.Add("DispatchType", typeof(System.String));
            _datatable.Columns.Add("BookingDTTM", typeof(System.DateTime));
            _datatable.Columns.Add("SampleID", typeof(System.String));
            _datatable.Columns.Add("SampleName", typeof(System.String));
            _datatable.Columns.Add("ContainerID", typeof(System.String));
            _datatable.Columns.Add("ContainerName", typeof(System.String));
            _datatable.Columns.Add("SampleContainerColour", typeof(System.String));
            _datatable.Columns.Add("SampleCollectionTime", typeof(System.DateTime));
            _datatable.Columns.Add("SampleStatus", typeof(System.String));
            _datatable.Columns.Add("Reason", typeof(System.String));
            _datatable.Columns.Add("FollowUpTest", typeof(System.String));
            _datatable.Columns.Add("FollowUpDTTM", typeof(System.DateTime));
            _datatable.Columns.Add("TestCode", typeof(System.String));
            _datatable.Columns.Add("TestName", typeof(System.String));
            _datatable.Columns.Add("Price", typeof(System.Decimal));
            _datatable.Columns.Add("TotalGrossAmount", typeof(System.Decimal));
            _datatable.Columns.Add("DiscountAmount", typeof(System.Decimal));
            _datatable.Columns.Add("NetAmount", typeof(System.Decimal));
            _datatable.Columns.Add("ReceivedAmount", typeof(System.Decimal));
            _datatable.Columns.Add("DueAmount", typeof(System.Decimal));
            _datatable.Columns.Add("PaymentStatus", typeof(System.String));
            _datatable.Columns.Add("PaymentMode", typeof(System.String));
            _datatable.Columns.Add("CardDetails", typeof(System.String));
            _datatable.Columns.Add("ReferenceNo", typeof(System.String));
            _datatable.Columns.Add("InventoryCount", typeof(System.Int64));
            _datatable.Columns.Add("InventoryDetails", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("LocationID", typeof(System.Int32));
            _datatable.Columns.Add("UserID", typeof(System.String));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("ClientID", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.String));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.String));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ISProcessed", typeof(System.String));
            _datatable.Columns.Add("Error", typeof(System.String));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            _datatable.Columns.Add("Name", typeof(System.String));
            _datatable.Columns.Add("PatientID", typeof(System.Int64));
            _datatable.Columns.Add("ExternalPatientNumber", typeof(System.String));
            _datatable.Columns.Add("CollectionTime", typeof(System.DateTime));
            _datatable.Columns.Add("OrderedFrom", typeof(System.String));
            _datatable.Columns.Add("CardNumber", typeof(System.Int64));
            _datatable.Columns.Add("CurrencyType", typeof(System.String));
            _datatable.Columns.Add("JsonValue", typeof(System.String));
            _datatable.Columns.Add("CityID", typeof(System.Int64));
            _datatable.Columns.Add("StateID", typeof(System.Int64));
            _datatable.Columns.Add("CountryID", typeof(System.Int64));
            _datatable.Columns.Add("LoginID", typeof(System.Int64));
            _datatable.Columns.Add("AddressType", typeof(System.String));
            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("DiscountID", typeof(System.Int64));
            _datatable.Columns.Add("ExternalRefNo", typeof(System.String));
            _datatable.Columns.Add("SourceType", typeof(System.String));
            _datatable.Columns.Add("ExternalPatientRefNo", typeof(System.String));
            _datatable.Columns.Add("BarcodeNo", typeof(System.String));
            _datatable.Columns.Add("OrgCode", typeof(System.String));
            _datatable.Columns.Add("LocationCode", typeof(System.String));
            _datatable.Columns.Add("EmployeeID", typeof(System.String));
            _datatable.Columns.Add("BookingRemarks", typeof(System.String));
            _datatable.Columns.Add("Location", typeof(System.String));
            _datatable.Columns.Add("ERPPatientNumber", typeof(System.String));
            DataRow _datarow;

            foreach (BookingInfo _list in _lstBookingInfo)
            {
                _datarow = _datatable.NewRow();
                _datarow["BookingID"] = _list.BookingID;
                _datarow["FirstName"] = _list.FirstName;
                _datarow["MiddleName"] = _list.MiddleName;
                _datarow["LastName"] = _list.LastName;
                _datarow["Salutation"] = _list.Salutation;
                _datarow["Age"] = _list.Age;
                _datarow["Gender"] = _list.Gender;
                _datarow["DateofBirth"] = _list.DateofBirth;
                _datarow["Address"] = _list.Address;
                _datarow["MobileNumber"] = _list.MobileNumber;
                _datarow["Email"] = _list.Email;
                _datarow["City"] = _list.City;
                _datarow["State"] = _list.State;
                _datarow["Country"] = _list.Country;
                _datarow["PostalCode"] = _list.PostalCode;
                _datarow["ClientCode"] = _list.ClientCode;
                _datarow["URNType"] = _list.URNType;
                _datarow["URNNo"] = _list.URNNo;
                _datarow["TRFFile"] = _list.TRFFile;
                _datarow["DispatchType"] = _list.DispatchType;
                _datarow["BookingDTTM"] = _list.BookingDTTM;
                _datarow["SampleID"] = _list.SampleID;
                _datarow["SampleName"] = _list.SampleName;
                _datarow["ContainerID"] = _list.ContainerID;
                _datarow["ContainerName"] = _list.ContainerName;
                _datarow["SampleContainerColour"] = _list.SampleContainerColour;
                _datarow["SampleCollectionTime"] = _list.SampleCollectionTime;
                _datarow["SampleStatus"] = _list.SampleStatus;
                _datarow["Reason"] = _list.Reason;
                _datarow["FollowUpTest"] = _list.FollowUpTest;
                _datarow["FollowUpDTTM"] = _list.FollowUpDTTM;
                _datarow["TestCode"] = _list.TestCode;
                _datarow["TestName"] = _list.TestName;
                _datarow["Price"] = _list.Price;
                _datarow["TotalGrossAmount"] = _list.TotalGrossAmount;
                _datarow["DiscountAmount"] = _list.DiscountAmount;
                _datarow["NetAmount"] = _list.NetAmount;
                _datarow["ReceivedAmount"] = _list.ReceivedAmount;
                _datarow["DueAmount"] = _list.DueAmount;
                _datarow["PaymentStatus"] = _list.PaymentStatus;
                _datarow["PaymentMode"] = _list.PaymentMode;
                _datarow["CardDetails"] = _list.CardDetails;
                _datarow["ReferenceNo"] = _list.ReferenceNo;
                _datarow["InventoryCount"] = _list.InventoryCount;
                _datarow["InventoryDetails"] = _list.InventoryDetails;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["LocationID"] = _list.LocationID;
                _datarow["UserID"] = _list.UserID;
                _datarow["Status"] = _list.Status;
                _datarow["ClientID"] = _list.ClientID;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["ISProcessed"] = _list.ISProcessed;
                _datarow["Error"] = _list.Error;
                _datarow["Remarks"] = _list.Remarks;
                _datarow["Name"] = _list.Name;
                _datarow["PatientID"] = _list.PatientID;
                _datarow["ExternalPatientNumber"] = _list.ExternalPatientNumber;
                _datarow["CollectionTime"] = _list.CollectionTime;
                _datarow["OrderedFrom"] = _list.OrderedFrom;
                _datarow["CardNumber"] = _list.CardNumber;
                _datarow["CurrencyType"] = _list.CurrencyType;
                _datarow["JsonValue"] = _list.JsonValue;
                _datarow["CityID"] = _list.CityID;
                _datarow["StateID"] = _list.StateID;
                _datarow["CountryID"] = _list.CountryID;
                _datarow["LoginID"] = _list.LoginID;
                _datarow["AddressType"] = _list.AddressType;
                _datarow["Type"] = _list.Type;
                _datarow["DiscountID"] = _list.DiscountID;
                _datarow["ExternalRefNo"] = _list.ExternalRefNo;
                _datarow["SourceType"] = _list.SourceType;
                _datarow["ExternalPatientRefNo"] = _list.ExternalPatientRefNo;
                _datarow["BarcodeNo"] = _list.BarcodeNo;
                _datarow["OrgCode"] = _list.OrgCode;
                _datarow["LocationCode"] = _list.LocationCode;
                _datarow["EmployeeID"] = _list.EmployeeID;
                _datarow["BookingRemarks"] = _list.BookingRemarks;
                _datarow["Location"] = _list.Location;
                _datarow["ERPPatientNumber"] = _list.ERPPatientNumber;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }

        public static System.Data.DataTable ConvertToTablePayment(List<Paymentdetail> _lstPaymentInfo)
        {
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("BookingID", typeof(System.Int64));
            _datatable.Columns.Add("FinalBillID", typeof(System.Int64));
            _datatable.Columns.Add("ReceivedAmount", typeof(System.Decimal));
            _datatable.Columns.Add("ClosureStatus", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int64));
            _datatable.Columns.Add("TypeID", typeof(System.Int64));
            _datatable.Columns.Add("ChequeorCardNumber", typeof(System.String));
            _datatable.Columns.Add("BaseCurrencyID", typeof(System.Int64));
            _datatable.Columns.Add("PaidCurrencyID", typeof(System.Int64));
            _datatable.Columns.Add("OtherCurrencyAmount", typeof(System.Decimal));
            _datatable.Columns.Add("RoleID", typeof(System.Int64));
            _datatable.Columns.Add("ReferenceID", typeof(System.Int64));
            _datatable.Columns.Add("ReferenceType", typeof(System.String));
            _datatable.Columns.Add("Units", typeof(System.Int64));
            _datatable.Columns.Add("ExternalRefNo", typeof(System.String));
            _datatable.Columns.Add("PaymentMode", typeof(System.String));
            _datatable.Columns.Add("CurrencyType", typeof(System.String));
            _datatable.Columns.Add("TransactionID", typeof(System.String));
            _datatable.Columns.Add("CardHolderName", typeof(System.String));
            _datatable.Columns.Add("CashGiven", typeof(System.Decimal));
            _datatable.Columns.Add("BalanceGiven", typeof(System.Decimal));
            _datatable.Columns.Add("RoundOffAmount", typeof(System.Decimal));
            _datatable.Columns.Add("ChequeValidDate", typeof(System.DateTime));
            _datatable.Columns.Add("AuthorisationCode", typeof(System.String));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.String));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.String));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            DataRow _datarow;

            foreach (Paymentdetail _list in _lstPaymentInfo)
            {
                _datarow = _datatable.NewRow();
                _datarow["BookingID"] = _list.BookingID;
                _datarow["FinalBillID"] = _list.FinalBillID;
                _datarow["ReceivedAmount"] = _list.ReceivedAmount;
                _datarow["ClosureStatus"] = _list.ClosureStatus;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["TypeID"] = _list.TypeID;
                _datarow["ChequeorCardNumber"] = _list.ChequeorCardNumber;
                _datarow["BaseCurrencyID"] = _list.BaseCurrencyID;
                _datarow["PaidCurrencyID"] = _list.PaidCurrencyID;
                _datarow["OtherCurrencyAmount"] = _list.OtherCurrencyAmount;
                _datarow["RoleID"] = _list.RoleID;
                _datarow["ReferenceID"] = _list.ReferenceID;
                _datarow["ReferenceType"] = _list.ReferenceType;
                _datarow["Units"] = _list.Units;
                _datarow["ExternalRefNo"] = _list.ExternalRefNo;
                _datarow["PaymentMode"] = _list.PaymentMode;
                _datarow["CurrencyType"] = _list.CurrencyType;
                _datarow["TransactionID"] = _list.TransactionID;
                _datarow["CardHolderName"] = _list.CardHolderName;
                _datarow["CashGiven"] = _list.CashGiven;
                _datarow["BalanceGiven"] = _list.BalanceGiven;
                _datarow["RoundOffAmount"] = _list.RoundOffAmount;
                _datarow["ChequeValidDate"] = _list.ChequeValidDate;
                _datarow["AuthorisationCode"] = _list.AuthorisationCode;
                _datarow["Remarks"] = _list.Remarks;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }

        public static System.Data.DataTable ConvertToPatientRegOrderInfo(List<PatientRegOrderCreation> _lstPatientRegInfo)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatRegOrderID", typeof(System.Int64));
            _datatable.Columns.Add("BookingID", typeof(System.Int64));
            _datatable.Columns.Add("UserID", typeof(System.String));
            _datatable.Columns.Add("TitleName", typeof(System.String));
            _datatable.Columns.Add("PatientName", typeof(System.String));
            _datatable.Columns.Add("FirstName", typeof(System.String));
            _datatable.Columns.Add("MiddleName", typeof(System.String));
            _datatable.Columns.Add("LastName", typeof(System.String));
            _datatable.Columns.Add("Age", typeof(System.String));
            _datatable.Columns.Add("Gender", typeof(System.String));
            _datatable.Columns.Add("Address", typeof(System.String));
            _datatable.Columns.Add("MobileNumber", typeof(System.String));
            _datatable.Columns.Add("DateofBrith", typeof(System.DateTime));
            _datatable.Columns.Add("EmailID", typeof(System.String));
            _datatable.Columns.Add("City", typeof(System.String));
            _datatable.Columns.Add("Country", typeof(System.String));
            _datatable.Columns.Add("State", typeof(System.String));
            _datatable.Columns.Add("PostalCode", typeof(System.String));
            _datatable.Columns.Add("TRFFile", typeof(System.String));
            _datatable.Columns.Add("URNType", typeof(System.String));
            _datatable.Columns.Add("URNNo", typeof(System.String));
            _datatable.Columns.Add("DateOfRegistration", typeof(System.DateTime));
            _datatable.Columns.Add("ClientCode", typeof(System.String));
            _datatable.Columns.Add("DispatchType", typeof(System.String));
            _datatable.Columns.Add("SampleID", typeof(System.String));
            _datatable.Columns.Add("SampleName", typeof(System.String));
            _datatable.Columns.Add("ContainerID", typeof(System.String));
            _datatable.Columns.Add("ContainerName", typeof(System.String));
            _datatable.Columns.Add("SampleContainerColour", typeof(System.String));
            _datatable.Columns.Add("SampleCollectionTime", typeof(System.DateTime));
            _datatable.Columns.Add("SampleStatus", typeof(System.String));
            _datatable.Columns.Add("ReasonSampleCollected", typeof(System.String));
            _datatable.Columns.Add("TestName", typeof(System.String));
            _datatable.Columns.Add("Price", typeof(System.Decimal));
            _datatable.Columns.Add("TotalGrossAmount", typeof(System.Decimal));
            _datatable.Columns.Add("DiscountAmount", typeof(System.Decimal));
            _datatable.Columns.Add("NetAmount", typeof(System.Decimal));
            _datatable.Columns.Add("ReceivedAmount", typeof(System.Decimal));
            _datatable.Columns.Add("DueAmount", typeof(System.Decimal));
            _datatable.Columns.Add("PaymentStatus", typeof(System.String));
            _datatable.Columns.Add("PaymentMode", typeof(System.String));
            _datatable.Columns.Add("CardDetails", typeof(System.String));
            _datatable.Columns.Add("PaymentReferenceNo", typeof(System.String));
            _datatable.Columns.Add("ExternalVisitID", typeof(System.String));
            _datatable.Columns.Add("PatientID", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.String));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.String));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("IsProcessYN", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int64));
            _datatable.Columns.Add("LocationID", typeof(System.Int32));
            _datatable.Columns.Add("Source", typeof(System.String));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("ClientID", typeof(System.String));
            _datatable.Columns.Add("Error", typeof(System.String));
            _datatable.Columns.Add("Remarks", typeof(System.String));

            DataRow _datarow;

            foreach (PatientRegOrderCreation _list in _lstPatientRegInfo)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatRegOrderID"] = _list.PatRegOrderID;
                _datarow["BookingID"] = _list.BookingID;
                _datarow["UserID"] = _list.UserID;
                _datarow["TitleName"] = _list.TitleName;
                _datarow["PatientName"] = _list.PatientName;
                _datarow["FirstName"] = _list.FirstName;
                _datarow["MiddleName"] = _list.MiddleName;
                _datarow["LastName"] = _list.LastName;
                _datarow["Age"] = _list.Age;
                _datarow["Gender"] = _list.Gender;
                _datarow["Address"] = _list.Address;
                _datarow["MobileNumber"] = _list.MobileNumber;
                _datarow["DateofBrith"] = _list.DateofBrith;
                _datarow["EmailID"] = _list.EmailID;
                _datarow["City"] = _list.City;
                _datarow["Country"] = _list.Country;
                _datarow["State"] = _list.State;
                _datarow["PostalCode"] = _list.PostalCode;
                _datarow["TRFFile"] = _list.TRFFile;
                _datarow["URNType"] = _list.URNType;
                _datarow["URNNo"] = _list.URNNo;
                _datarow["DateOfRegistration"] = _list.DateOfRegistration;
                _datarow["ClientCode"] = _list.ClientCode;
                _datarow["DispatchType"] = _list.DispatchType;
                _datarow["SampleID"] = _list.SampleID;
                _datarow["SampleName"] = _list.SampleName;
                _datarow["ContainerID"] = _list.ContainerID;
                _datarow["ContainerName"] = _list.ContainerName;
                _datarow["SampleContainerColour"] = _list.SampleContainerColour;
                _datarow["SampleCollectionTime"] = _list.SampleCollectionTime;
                _datarow["SampleStatus"] = _list.SampleStatus;
                _datarow["ReasonSampleCollected"] = _list.ReasonSampleCollected;
                _datarow["TestName"] = _list.TestName;
                _datarow["Price"] = _list.Price;
                _datarow["TotalGrossAmount"] = _list.TotalGrossAmount;
                _datarow["DiscountAmount"] = _list.DiscountAmount;
                _datarow["NetAmount"] = _list.NetAmount;
                _datarow["ReceivedAmount"] = _list.ReceivedAmount;
                _datarow["DueAmount"] = _list.DueAmount;
                _datarow["PaymentStatus"] = _list.PaymentStatus;
                _datarow["PaymentMode"] = _list.PaymentMode;
                _datarow["CardDetails"] = _list.CardDetails;
                _datarow["PaymentReferenceNo"] = _list.PaymentReferenceNo;
                _datarow["ExternalVisitID"] = _list.ExternalVisitID;
                _datarow["PatientID"] = _list.PatientID;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["IsProcessYN"] = _list.IsProcessYN;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["LocationID"] = _list.LocationID;
                _datarow["Source"] = _list.Source;
                _datarow["Status"] = _list.Status;
                _datarow["ClientID"] = _list.ClientID;
                _datarow["Error"] = _list.Error;
                _datarow["Remarks"] = _list.Remarks;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToInfectionTestResultInfo(List<InfectionTestResultInfo> _lstInfectionTestResult)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("InfTestResultID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("LocationID", typeof(System.Int32));
            _datatable.Columns.Add("ClientID", typeof(System.String));
            _datatable.Columns.Add("PatientID", typeof(System.String));
            _datatable.Columns.Add("TitleName", typeof(System.String));
            _datatable.Columns.Add("Name", typeof(System.String));
            _datatable.Columns.Add("FirstName", typeof(System.String));
            _datatable.Columns.Add("MiddleName", typeof(System.String));
            _datatable.Columns.Add("LastName", typeof(System.String));
            _datatable.Columns.Add("Gender", typeof(System.String));
            _datatable.Columns.Add("DateofBrith", typeof(System.DateTime));
            _datatable.Columns.Add("Age", typeof(System.String));
            _datatable.Columns.Add("MobileNumber", typeof(System.String));
            _datatable.Columns.Add("EMailID", typeof(System.String));
            _datatable.Columns.Add("Address", typeof(System.String));
            _datatable.Columns.Add("City", typeof(System.String));
            _datatable.Columns.Add("State", typeof(System.String));
            _datatable.Columns.Add("Country", typeof(System.String));
            _datatable.Columns.Add("PostalCode", typeof(System.String));
            _datatable.Columns.Add("ClientName", typeof(System.String));
            _datatable.Columns.Add("ClientCode", typeof(System.String));
            _datatable.Columns.Add("PhysicianCode", typeof(System.String));
            _datatable.Columns.Add("PhysicianName", typeof(System.String));
            _datatable.Columns.Add("Hospitalname", typeof(System.String));
            _datatable.Columns.Add("HospitalCode", typeof(System.String));
            _datatable.Columns.Add("ExternalPatientNumber", typeof(System.String));
            _datatable.Columns.Add("Patientcategory", typeof(System.String));
            _datatable.Columns.Add("VisitType", typeof(System.String));
            _datatable.Columns.Add("BedWardInfo", typeof(System.String));
            _datatable.Columns.Add("URNType", typeof(System.String));
            _datatable.Columns.Add("URNNo", typeof(System.String));
            _datatable.Columns.Add("TestCode", typeof(System.String));
            _datatable.Columns.Add("TestName", typeof(System.String));
            _datatable.Columns.Add("ParameterCode", typeof(System.String));
            _datatable.Columns.Add("ParameterName", typeof(System.String));
            _datatable.Columns.Add("ResultType", typeof(System.String));
            _datatable.Columns.Add("ResultValue", typeof(System.String));
            _datatable.Columns.Add("ReferenceRange", typeof(System.String));
            _datatable.Columns.Add("IsAbnormal", typeof(System.String));
            _datatable.Columns.Add("IsCritical", typeof(System.String));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("ApprovedBy", typeof(System.String));
            _datatable.Columns.Add("ApprovedDate", typeof(System.DateTime));
            _datatable.Columns.Add("CreatedBy", typeof(System.String));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.String));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ISProcessed", typeof(System.String));
            _datatable.Columns.Add("Error", typeof(System.String));
            _datatable.Columns.Add("Remarks", typeof(System.String));

            DataRow _datarow;

            foreach (InfectionTestResultInfo _list in _lstInfectionTestResult)
            {
                _datarow = _datatable.NewRow();
                _datarow["InfTestResultID"] = _list.InfTestResultID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["LocationID"] = _list.LocationID;
                _datarow["ClientID"] = _list.ClientID;
                _datarow["PatientID"] = _list.PatientID;
                _datarow["TitleName"] = _list.TitleName;
                _datarow["Name"] = _list.Name;
                _datarow["FirstName"] = _list.FirstName;
                _datarow["MiddleName"] = _list.MiddleName;
                _datarow["LastName"] = _list.LastName;
                _datarow["Gender"] = _list.Gender;
                _datarow["DateofBrith"] = _list.DateofBrith;
                _datarow["Age"] = _list.Age;
                _datarow["MobileNumber"] = _list.MobileNumber;
                _datarow["EMailID"] = _list.EMailID;
                _datarow["Address"] = _list.Address;
                _datarow["City"] = _list.City;
                _datarow["State"] = _list.State;
                _datarow["Country"] = _list.Country;
                _datarow["PostalCode"] = _list.PostalCode;
                _datarow["ClientName"] = _list.ClientName;
                _datarow["ClientCode"] = _list.ClientCode;
                _datarow["PhysicianCode"] = _list.PhysicianCode;
                _datarow["PhysicianName"] = _list.PhysicianName;
                _datarow["Hospitalname"] = _list.Hospitalname;
                _datarow["HospitalCode"] = _list.HospitalCode;
                _datarow["ExternalPatientNumber"] = _list.ExternalPatientNumber;
                _datarow["Patientcategory"] = _list.Patientcategory;
                _datarow["VisitType"] = _list.VisitType;
                _datarow["BedWardInfo"] = _list.BedWardInfo;
                _datarow["URNType"] = _list.URNType;
                _datarow["URNNo"] = _list.URNNo;
                _datarow["TestCode"] = _list.TestCode;
                _datarow["TestName"] = _list.TestName;
                _datarow["ParameterCode"] = _list.ParameterCode;
                _datarow["ParameterName"] = _list.ParameterName;
                _datarow["ResultType"] = _list.ResultType;
                _datarow["ResultValue"] = _list.ResultValue;
                _datarow["ReferenceRange"] = _list.ReferenceRange;
                _datarow["IsAbnormal"] = _list.IsAbnormal;
                _datarow["IsCritical"] = _list.IsCritical;
                _datarow["Status"] = _list.Status;
                _datarow["ApprovedBy"] = _list.ApprovedBy;
                _datarow["ApprovedDate"] = _list.ApprovedDate;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["ISProcessed"] = _list.ISProcessed;
                _datarow["Error"] = _list.Error;
                _datarow["Remarks"] = _list.Remarks;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToRegisterOrderInfo(List<RegisterOrderInfo> _lstRegisterOrderInfo)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatRegOrderID", typeof(System.String));
            _datatable.Columns.Add("BookingID", typeof(System.Int64));
            _datatable.Columns.Add("UserID", typeof(System.String));
            _datatable.Columns.Add("TitleName", typeof(System.String));
            _datatable.Columns.Add("PatientName", typeof(System.String));
            _datatable.Columns.Add("FirstName", typeof(System.String));
            _datatable.Columns.Add("MiddleName", typeof(System.String));
            _datatable.Columns.Add("LastName", typeof(System.String));
            _datatable.Columns.Add("Age", typeof(System.String));
            _datatable.Columns.Add("Gender", typeof(System.String));
            _datatable.Columns.Add("Address", typeof(System.String));
            _datatable.Columns.Add("MobileNumber", typeof(System.String));
           
            _datatable.Columns.Add("EmailID", typeof(System.String));
            _datatable.Columns.Add("City", typeof(System.String));
            _datatable.Columns.Add("Country", typeof(System.String));
            _datatable.Columns.Add("State", typeof(System.String));
            _datatable.Columns.Add("PostalCode", typeof(System.String));
            _datatable.Columns.Add("TRFFile", typeof(System.String));
            _datatable.Columns.Add("URNType", typeof(System.String));
            _datatable.Columns.Add("URNNo", typeof(System.String));
      //      _datatable.Columns.Add("DateOfRegistration", typeof(System.DateTime));
            _datatable.Columns.Add("ClientCode", typeof(System.String));
            _datatable.Columns.Add("DispatchType", typeof(System.String));
            _datatable.Columns.Add("SampleID", typeof(System.String));
            _datatable.Columns.Add("SampleName", typeof(System.String));
            _datatable.Columns.Add("ContainerID", typeof(System.String));
            _datatable.Columns.Add("ContainerName", typeof(System.String));
            _datatable.Columns.Add("SampleContainerColour", typeof(System.String));
      ///      _datatable.Columns.Add("SampleCollectionTime", typeof(System.DateTime));
            _datatable.Columns.Add("SampleStatus", typeof(System.String));
            _datatable.Columns.Add("ReasonSampleCollected", typeof(System.String));
            _datatable.Columns.Add("TestName", typeof(System.String));
            _datatable.Columns.Add("Price", typeof(System.Decimal));
            _datatable.Columns.Add("TotalGrossAmount", typeof(System.Decimal));
            _datatable.Columns.Add("DiscountAmount", typeof(System.Decimal));
            _datatable.Columns.Add("NetAmount", typeof(System.Decimal));
            _datatable.Columns.Add("ReceivedAmount", typeof(System.Decimal));
            _datatable.Columns.Add("DueAmount", typeof(System.Decimal));
            _datatable.Columns.Add("PaymentStatus", typeof(System.String));
            _datatable.Columns.Add("PaymentMode", typeof(System.String));
            _datatable.Columns.Add("CardDetails", typeof(System.String));
            _datatable.Columns.Add("PaymentReferenceNo", typeof(System.String));
            _datatable.Columns.Add("ExternalVisitID", typeof(System.String));
            _datatable.Columns.Add("PatientID", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.String));
     //       _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.String));
     //       _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("IsProcessYN", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int64));
            _datatable.Columns.Add("LocationID", typeof(System.Int32));
            _datatable.Columns.Add("Source", typeof(System.String));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("ClientID", typeof(System.String));
            _datatable.Columns.Add("Error", typeof(System.String));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            _datatable.Columns.Add("JsonValue", typeof(System.String));    
	 _datatable.Columns.Add("JsonString", typeof(System.String));      
	 _datatable.Columns.Add("PatientVisitId", typeof(System.String));      
	 _datatable.Columns.Add("ExternalVisitNumber", typeof(System.String));       
	 _datatable.Columns.Add("VisitType", typeof(System.String));       
	 _datatable.Columns.Add("ClientName", typeof(System.String));      
	 _datatable.Columns.Add("ReferingDoctorCode", typeof(System.String));      
	 _datatable.Columns.Add("ReferingDoctorName", typeof(System.String));       
	 _datatable.Columns.Add("ReferingDoctorMobileNumber", typeof(System.String));
            _datatable.Columns.Add("HospitalName", typeof(System.String));
            _datatable.Columns.Add("VisitHistory", typeof(System.String));
            _datatable.Columns.Add("VisitRemarks", typeof(System.String));
            _datatable.Columns.Add("HospitalNameCode", typeof(System.String));
            _datatable.Columns.Add("AddressType", typeof(System.String));
            _datatable.Columns.Add("StateID", typeof(System.String));
            _datatable.Columns.Add("CountryID", typeof(System.String));
            _datatable.Columns.Add("TestCode", typeof(System.String));
            _datatable.Columns.Add("IsStat", typeof(System.String));
            _datatable.Columns.Add("TestClinicalHistory", typeof(System.String));
            _datatable.Columns.Add("Instructions", typeof(System.String));
            _datatable.Columns.Add("MessageType", typeof(System.String));
            _datatable.Columns.Add("DateofBirth", typeof(System.DateTime));

            DataRow _datarow;

            foreach (RegisterOrderInfo _list in _lstRegisterOrderInfo)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatRegOrderID"] = _list.PatRegOrderID;
                _datarow["BookingID"] = _list.BookingID;
                _datarow["UserID"] = _list.UserID;
                _datarow["TitleName"] = _list.SalutationCode;
                _datarow["PatientName"] = _list.PatientName;
                _datarow["FirstName"] = _list.FirstName;
                _datarow["MiddleName"] = _list.MiddleName;
                _datarow["LastName"] = _list.LastName;
                _datarow["Age"] = _list.Age;
                _datarow["Gender"] = _list.Gender;
                _datarow["Address"] = _list.Address;
                _datarow["MobileNumber"] = _list.MobileNumber;
              
                _datarow["EmailID"] = _list.Email;
                _datarow["City"] = _list.City;
                _datarow["Country"] = _list.Country;
                _datarow["State"] = _list.State;
                _datarow["PostalCode"] = _list.PostalCode;
                _datarow["TRFFile"] = _list.TRFFile;
                _datarow["URNType"] = _list.URNType;
                _datarow["URNNo"] = _list.URNNo;
            //    _datarow["DateOfRegistration"] = _list.DateOfRegistration;
                _datarow["ClientCode"] = _list.ClientCode;
                _datarow["DispatchType"] = _list.DispatchType;
                _datarow["SampleID"] = _list.SampleID;
                _datarow["SampleName"] = _list.SampleName;
                _datarow["ContainerID"] = _list.ContainerID;
                _datarow["ContainerName"] = _list.ContainerName;
                _datarow["SampleContainerColour"] = _list.SampleContainerColour;
            //    _datarow["SampleCollectionTime"] = _list.SampleCollectionTime;
                _datarow["SampleStatus"] = _list.SampleStatus;
                _datarow["ReasonSampleCollected"] = _list.ReasonSampleCollected;
                _datarow["TestName"] = _list.TestName;
                _datarow["Price"] = _list.Price;
                _datarow["TotalGrossAmount"] = _list.TotalGrossAmount;
                _datarow["DiscountAmount"] = _list.DiscountAmount;
                _datarow["NetAmount"] = _list.NetAmount;
                _datarow["ReceivedAmount"] = _list.ReceivedAmount;
                _datarow["DueAmount"] = _list.DueAmount;
                _datarow["PaymentStatus"] = _list.PaymentStatus;
                _datarow["PaymentMode"] = _list.PaymentMode;
                _datarow["CardDetails"] = _list.CardDetails;
                _datarow["PaymentReferenceNo"] = _list.PaymentReferenceNo;
                _datarow["ExternalVisitID"] = _list.ExternalVisitID;
                _datarow["PatientID"] = _list.PatientID;
                _datarow["CreatedBy"] = _list.CreatedBy;
            //    _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
             //   _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["IsProcessYN"] = _list.IsProcessYN;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["LocationID"] = _list.LocationID;
                _datarow["Source"] = _list.Source;
                _datarow["Status"] = _list.Status;
                _datarow["ClientID"] = _list.ClientID;
                _datarow["Error"] = _list.Error;
                _datarow["Remarks"] = _list.Remarks;
                _datarow["JsonValue"] = _list.JsonValue;
                _datarow["JsonString"] = _list.JsonString;
                _datarow["PatientVisitId"] = _list.PatientVisitId;
                _datarow["ExternalVisitNumber"] = _list.ExternalVisitNumber;
                _datarow["VisitType"] = _list.VisitType;
                _datarow["ClientName"] = _list.ClientName;
                _datarow["ReferingDoctorCode"] = _list.ReferingDoctorCode;
                _datarow["ReferingDoctorName"] = _list.ReferingDoctorName;
                _datarow["ReferingDoctorMobileNumber"] = _list.ReferingDoctorMobileNumber;
                _datarow["HospitalName"] = _list.HospitalName;
                _datarow["VisitHistory"] = _list.VisitHistory;
                _datarow["VisitRemarks"] = _list.VisitRemarks;
                _datarow["HospitalNameCode"] = _list.HospitalNameCode;
                _datarow["AddressType"] = _list.AddressType;
                _datarow["StateID"] = _list.StateID;
                _datarow["CountryID"] = _list.CountryID;
                _datarow["TestCode"] = _list.TestCode;
                _datarow["IsStat"] = _list.IsStat;
                _datarow["TestClinicalHistory"] = _list.TestClinicalHistory;
                _datarow["Instructions"] = _list.Instructions;
                _datarow["MessageType"] = _list.MessageType;
                _datarow["DateofBirth"] = _list.DateofBirth;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToTableRegisterOrderPaymentInfo(List<Paymentdetail> _lstPaymentInfo)
        {
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("BookingID", typeof(System.Int64));
            _datatable.Columns.Add("FinalBillID", typeof(System.Int64));
            _datatable.Columns.Add("ReceivedAmount", typeof(System.Decimal));
            _datatable.Columns.Add("ClosureStatus", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int64));
            _datatable.Columns.Add("TypeID", typeof(System.Int64));
            _datatable.Columns.Add("ChequeorCardNumber", typeof(System.String));
            _datatable.Columns.Add("BaseCurrencyID", typeof(System.Int64));
            _datatable.Columns.Add("PaidCurrencyID", typeof(System.Int64));
            _datatable.Columns.Add("OtherCurrencyAmount", typeof(System.Decimal));
            _datatable.Columns.Add("RoleID", typeof(System.Int64));
            _datatable.Columns.Add("ReferenceID", typeof(System.Int64));
            _datatable.Columns.Add("ReferenceType", typeof(System.String));
            _datatable.Columns.Add("Units", typeof(System.Int64));
            _datatable.Columns.Add("ExternalRefNo", typeof(System.Int64));
            _datatable.Columns.Add("PaymentMode", typeof(System.String));
            _datatable.Columns.Add("CurrencyType", typeof(System.String));
            _datatable.Columns.Add("TransactionID", typeof(System.String));
            _datatable.Columns.Add("CardHolderName", typeof(System.String));
            _datatable.Columns.Add("CashGiven", typeof(System.Decimal));
            _datatable.Columns.Add("BalanceGiven", typeof(System.Decimal));
            _datatable.Columns.Add("RoundOffAmount", typeof(System.Decimal));
            _datatable.Columns.Add("ChequeValidDate", typeof(System.DateTime));
            _datatable.Columns.Add("AuthorisationCode", typeof(System.String));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.String));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.String));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            DataRow _datarow;

            foreach (Paymentdetail _list in _lstPaymentInfo)
            {
                _datarow = _datatable.NewRow();
                _datarow["BookingID"] = _list.BookingID;
                _datarow["FinalBillID"] = _list.FinalBillID;
                _datarow["ReceivedAmount"] = _list.ReceivedAmount;
                _datarow["ClosureStatus"] = _list.ClosureStatus;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["TypeID"] = _list.TypeID;
                _datarow["ChequeorCardNumber"] = _list.ChequeorCardNumber;
                _datarow["BaseCurrencyID"] = _list.BaseCurrencyID;
                _datarow["PaidCurrencyID"] = _list.PaidCurrencyID;
                _datarow["OtherCurrencyAmount"] = _list.OtherCurrencyAmount;
                _datarow["RoleID"] = _list.RoleID;
                _datarow["ReferenceID"] = _list.ReferenceID;
                _datarow["ReferenceType"] = _list.ReferenceType;
                _datarow["Units"] = _list.Units;
                _datarow["ExternalRefNo"] = _list.ExternalRefNo;
                _datarow["PaymentMode"] = _list.PaymentMode;
                _datarow["CurrencyType"] = _list.CurrencyType;
                _datarow["TransactionID"] = _list.TransactionID;
                _datarow["CardHolderName"] = _list.CardHolderName;
                _datarow["CashGiven"] = _list.CashGiven;
                _datarow["BalanceGiven"] = _list.BalanceGiven;
                _datarow["RoundOffAmount"] = _list.RoundOffAmount;
                _datarow["ChequeValidDate"] = _list.ChequeValidDate;
                _datarow["AuthorisationCode"] = _list.AuthorisationCode;
                _datarow["Remarks"] = _list.Remarks;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }

        #region //Pirama
        public static System.Data.DataTable ConvertToTablePatientReg(List<PatientRegistrationInfo> lstPatientRegdetails)
        {
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("PatientID", typeof(System.Int64));
            _datatable.Columns.Add("Age", typeof(System.String));
            _datatable.Columns.Add("FirstName", typeof(System.String));
            _datatable.Columns.Add("MiddleName", typeof(System.String));
            _datatable.Columns.Add("LastName", typeof(System.String));
            _datatable.Columns.Add("Gender", typeof(System.String));
            _datatable.Columns.Add("DateofBirth", typeof(System.DateTime));
            _datatable.Columns.Add("Email", typeof(System.String));
            _datatable.Columns.Add("Salutation", typeof(System.String));
            _datatable.Columns.Add("Address", typeof(System.String));
            _datatable.Columns.Add("City", typeof(System.String));
            _datatable.Columns.Add("State", typeof(System.String));
            _datatable.Columns.Add("Country", typeof(System.String));
            _datatable.Columns.Add("PostalCode", typeof(System.String));
            _datatable.Columns.Add("MobileNumber", typeof(System.String));
            _datatable.Columns.Add("URNType", typeof(System.String));
            _datatable.Columns.Add("URNNo", typeof(System.String));
            _datatable.Columns.Add("DateOfRegistration", typeof(System.DateTime));
            _datatable.Columns.Add("OrgID", typeof(System.Int64));
            _datatable.Columns.Add("LocationID", typeof(System.Int64));
            _datatable.Columns.Add("Source", typeof(System.String));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("ClientID", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ISProcessed", typeof(System.String));
            _datatable.Columns.Add("Error", typeof(System.String));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            _datatable.Columns.Add("PatientName", typeof(System.String));
            _datatable.Columns.Add("Type", typeof(System.String));
            DataRow _datarow;

            foreach (PatientRegistrationInfo _list in lstPatientRegdetails)
            {
                _datarow = _datatable.NewRow();
                _datarow["PatientID"] = _list.PatientID;
                _datarow["Age"] = _list.Age;
                _datarow["FirstName"] = _list.FirstName;
                _datarow["MiddleName"] = _list.MiddleName;
                _datarow["LastName"] = _list.LastName;
                _datarow["Gender"] = _list.Gender;
                _datarow["DateofBirth"] = _list.DateofBirth;
                _datarow["Email"] = _list.Email;
                _datarow["Salutation"] = _list.Salutation;
                _datarow["Address"] = _list.Address;
                _datarow["City"] = _list.City;
                _datarow["State"] = _list.State;
                _datarow["Country"] = _list.Country;
                _datarow["PostalCode"] = _list.PostalCode;
                _datarow["MobileNumber"] = _list.MobileNumber;
                _datarow["URNType"] = _list.URNType;
                _datarow["URNNo"] = _list.URNNo;
                _datarow["DateOfRegistration"] = _list.DateOfRegistration;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["LocationID"] = _list.LocationID;
                _datarow["Source"] = _list.Source;
                _datarow["Status"] = _list.Status;
                _datarow["ClientID"] = _list.ClientID;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["ISProcessed"] = _list.ISProcessed;
                _datarow["Error"] = _list.Error;
                _datarow["Remarks"] = _list.Remarks;
                _datarow["PatientName"] = _list.PatientName;
                _datarow["Type"] = _list.Type;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }

     

        public static System.Data.DataTable ConvertToTableLiveLocation(List<LiveLocationInfo> lstLiveLocation)
        {
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("LoginID", typeof(System.Int64));
            _datatable.Columns.Add("TransactionDate", typeof(System.DateTime));
            _datatable.Columns.Add("Latitude", typeof(float));
            _datatable.Columns.Add("Longitude", typeof(float));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("CreatedBy", typeof(System.Int64));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.Int64));
            _datatable.Columns.Add("ISProcessed", typeof(System.String));
            _datatable.Columns.Add("Error", typeof(System.String));
            _datatable.Columns.Add("Remarks", typeof(System.String));
            DataRow _datarow;

            foreach (LiveLocationInfo _list in lstLiveLocation)
            {
                _datarow = _datatable.NewRow();
                _datarow["LoginID"] = _list.LoginID;
                _datarow["TransactionDate"] = _list.TransactionDate;
                _datarow["Latitude"] = _list.Latitude;
                _datarow["Longitude"] = _list.Longitude;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ISProcessed"] = _list.ISProcessed;
                _datarow["Error"] = _list.Error;
                _datarow["Remarks"] = _list.Remarks;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }
        #endregion

        #region //Abhishek

        public static System.Data.DataTable ConvertToTripStatusInfo(List<TripStatusInfo> _lstTripStatusInfo)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("BookingID", typeof(System.Int64));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("LocationID", typeof(System.Int32));
            _datatable.Columns.Add("LoginID", typeof(System.String));
            _datatable.Columns.Add("TripStatus", typeof(System.String));
            _datatable.Columns.Add("TripReason", typeof(System.String));
            _datatable.Columns.Add("ModifiedBy", typeof(System.String));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));

            DataRow _datarow;

            foreach (TripStatusInfo _list in _lstTripStatusInfo)
            {
                _datarow = _datatable.NewRow();
                _datarow["BookingID"] = _list.BookingID;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["LocationID"] = _list.LocationID;
                _datarow["LoginID"] = _list.LoginID;
                _datarow["TripStatus"] = _list.TripStatus;
                _datarow["TripReason"] = _list.TripReason;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        
    }

    #endregion

        #region // Seetha
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

        public static System.Data.DataTable ConvertToUDTClientDetailsLIMSAPI(List<ClientDetailsLIMSAPI> _lstCollection)

        {
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ClientCode", typeof(System.String));
            _datatable.Columns.Add("ClientName", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("ClientType", typeof(System.String));
            _datatable.Columns.Add("CustomerType", typeof(System.String));
            _datatable.Columns.Add("BusinessType", typeof(System.String));
            _datatable.Columns.Add("CountryCode", typeof(System.String));
            _datatable.Columns.Add("StateCode", typeof(System.String));
            _datatable.Columns.Add("EmailID", typeof(System.String));
            _datatable.Columns.Add("PhoneNo", typeof(System.String));
            _datatable.Columns.Add("MobileNo", typeof(System.String));
            _datatable.Columns.Add("AddressDetails", typeof(System.String));
            _datatable.Columns.Add("City", typeof(System.String));
            _datatable.Columns.Add("ISCash", typeof(System.String));
            _datatable.Columns.Add("CompanyID", typeof(System.String));
            _datatable.Columns.Add("Status", typeof(System.String));

            DataRow _datarow;

            foreach (ClientDetailsLIMSAPI _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ClientCode"] = _list.ClientCode;
                _datarow["ClientName"] = _list.ClientName;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["ClientType"] = _list.ClientType;
                _datarow["CustomerType"] = _list.CustomerType;
                _datarow["BusinessType"] = _list.BusinessType;
                _datarow["CountryCode"] = _list.CountryCode;
                _datarow["StateCode"] = _list.StateCode;
                _datarow["EmailID"] = _list.EmailID;
                _datarow["PhoneNo"] = _list.PhoneNo;
                _datarow["MobileNo"] = _list.MobileNo;
                _datarow["AddressDetails"] = _list.AddressDetails;
                _datarow["City"] = _list.City;
                _datarow["ISCash"] = _list.ISCash;
                _datarow["CompanyID"] = _list.CompanyID;
                _datarow["Status"] = _list.Status;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }
        public static System.Data.DataTable ConvertToUDTClientDetails(List<ClientDetailsLIMSAPI> _lstCollection)

        {
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ClientCode", typeof(System.String));
            _datatable.Columns.Add("ClientName", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("ClientType", typeof(System.Int32));
            _datatable.Columns.Add("CustormerType", typeof(System.Int64));
            _datatable.Columns.Add("CountryCode", typeof(System.String));
            _datatable.Columns.Add("StateCode", typeof(System.String));
            _datatable.Columns.Add("EmailID", typeof(System.String));
            _datatable.Columns.Add("PhoneNo", typeof(System.String));
            _datatable.Columns.Add("MobileNo", typeof(System.String));
            _datatable.Columns.Add("AddressDetails", typeof(System.String));
            _datatable.Columns.Add("City", typeof(System.String));
            _datatable.Columns.Add("ISCash", typeof(System.String));
            _datatable.Columns.Add("CompanyID", typeof(System.String));

            DataRow _datarow;

            foreach (ClientDetailsLIMSAPI _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ClientCode"] = _list.ClientCode;
                _datarow["ClientName"] = _list.ClientName;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["ClientType"] = _list.ClientType;
                _datarow["CustormerType"] = _list.CustomerType;
                _datarow["CountryCode"] = _list.CountryCode;
                _datarow["StateCode"] = _list.StateCode;
                _datarow["EmailID"] = _list.EmailID;
                _datarow["PhoneNo"] = _list.PhoneNo;
                _datarow["MobileNo"] = _list.MobileNo;
                _datarow["AddressDetails"] = _list.AddressDetails;
                _datarow["City"] = _list.City;
                _datarow["ISCash"] = _list.ISCash;
                _datarow["CompanyID"] = _list.CompanyID; 
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }
        public static System.Data.DataTable ConvertToUDTOrderStatusDetails(List<OrderInformation> _lstCollection)

        {
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("TestID", typeof(System.String));
            _datatable.Columns.Add("TestCode", typeof(System.String));
            _datatable.Columns.Add("TestName", typeof(System.String));

            _datatable.Columns.Add("TestStatus", typeof(System.String));
            _datatable.Columns.Add("ResultCapturedAt", typeof(System.String));

            DataRow _datarow;

            foreach (OrderInformation _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();

                _datarow["TestID"] = _list.TestID;
                _datarow["TestCode"] = _list.TestCode;
                _datarow["TestName"] = _list.TestName;
                _datarow["TestStatus"] = _list.TestStatus;
                _datarow["ResultCapturedAt"] = _list.ResultCapturedAt;

                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }
        #endregion

        #region StockManagementUDT

        public static System.Data.DataTable ConvertToInventoryItemsMapping(List<InventoryItemsBasket> _lstCollection)
        {

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
            _datatable.Columns.Add("EligibleAmount", typeof(System.Decimal));
            _datatable.Columns.Add("ClientFeeTypeRateCustID", typeof(System.Int64));
            _datatable.Columns.Add("InvoiceDate", typeof(System.DateTime));
            _datatable.Columns.Add("StockStatus", typeof(System.Int32));
            _datatable.Columns.Add("DefectiveQty", typeof(System.Decimal));
            _datatable.Columns.Add("Comments", typeof(System.String));
            _datatable.Columns.Add("Shortage", typeof(System.Decimal));
            _datatable.Columns.Add("Damage", typeof(System.Decimal));
            _datatable.Columns.Add("Rejected", typeof(System.Decimal));
            _datatable.Columns.Add("PrepareCharges", typeof(System.Decimal));
            _datatable.Columns.Add("ProductCode", typeof(System.String));
            _datatable.Columns.Add("CopayValue", typeof(System.Decimal));
            _datatable.Columns.Add("CopayType", typeof(System.String));
            _datatable.Columns.Add("GenericName", typeof(System.String));
            _datatable.Columns.Add("ProductReceivedDetailsID", typeof(System.Int64));
            _datatable.Columns.Add("PurchaseTax", typeof(System.Decimal));
            _datatable.Columns.Add("HandlingCharges", typeof(System.Decimal));
            _datatable.Columns.Add("ReceivedUniqueNumber", typeof(System.Int64));
            _datatable.Columns.Add("ReceivedBatchNo", typeof(System.String));
            _datatable.Columns.Add("StockReceivedBarcodeDetailsID", typeof(System.Int64));
            _datatable.Columns.Add("StockReceivedBarcodeID", typeof(System.Int64));
            _datatable.Columns.Add("BarcodeNo", typeof(System.String));
            _datatable.Columns.Add("IsUniqueBarcode", typeof(System.String));
            _datatable.Columns.Add("TaxAmount", typeof(System.Decimal));
            _datatable.Columns.Add("IsSmsNeeded", typeof(System.String));
            _datatable.Columns.Add("SchemeType", typeof(System.String));
            _datatable.Columns.Add("SchemeDisc", typeof(System.Decimal));
            _datatable.Columns.Add("DiscountType", typeof(System.String));
            _datatable.Columns.Add("TotalSchemeDisc", typeof(System.Decimal));
            _datatable.Columns.Add("TotalNormalDisc", typeof(System.Decimal));
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
                if (_list.ExpiryDate < DateTime.Parse("1753-01-01"))
                    _datarow["ExpiryDate"] = DateTime.Parse("1753-01-01");
                else
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
                _datarow["ActualPrice"] = _list.ActualPrice;
                _datarow["EligibleAmount"] = _list.EligibleAmount;
                _datarow["ClientFeeTypeRateCustID"] = _list.ClientFeeTypeRateCustID;
                _datarow["InvoiceDate"] = _list.InvoiceDate;
                _datarow["StockStatus"] = _list.StockStatus;
                _datarow["DefectiveQty"] = _list.DefectiveQty;
                _datarow["Comments"] = _list.Comments;
                _datarow["Shortage"] = _list.Shortage;
                _datarow["Damage"] = _list.Damage;
                _datarow["Rejected"] = _list.Rejected;
                _datarow["PrepareCharges"] = _list.PrepareCharges;
                _datarow["ProductCode"] = _list.ProductCode;
                _datarow["CopayValue"] = _list.CopayValue;
                _datarow["CopayType"] = _list.CopayType;
                _datarow["GenericName"] = _list.GenericName;
                _datarow["ProductReceivedDetailsID"] = _list.ProductReceivedDetailsID;
                _datarow["PurchaseTax"] = _list.PurchaseTax;
                _datarow["HandlingCharges"] = _list.HandlingCharges;
                _datarow["ReceivedUniqueNumber"] = _list.ReceivedUniqueNumber;
                _datarow["ReceivedBatchNo"] = _list.ReceivedBatchNo;
                _datarow["StockReceivedBarcodeDetailsID"] = _list.StockReceivedBarcodeDetailsID;
                _datarow["StockReceivedBarcodeID"] = _list.StockReceivedBarcodeID;
                _datarow["BarcodeNo"] = _list.BarcodeNo;
                _datarow["IsUniqueBarcode"] = _list.IsUniqueBarcode;
                _datarow["TaxAmount"] = _list.TaxAmount;
                _datarow["IsSmsNeeded"] = _list.IsSmsNeeded;
                _datarow["SchemeType"] = _list.SchemeType;
                _datarow["SchemeDisc"] = _list.SchemeDisc;
                _datarow["DiscountType"] = _list.DiscountType;
                _datarow["TotalSchemeDisc"] = _list.TotalSchemeDisc;
                _datarow["TotalNormalDisc"] = _list.TotalNormalDisc;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;

        }
        #endregion


        public static System.Data.DataTable ConvertToClientDetailsMasterLIMSAPI(List<ClientDetailsLIMSAPI> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("ClientCode", typeof(System.String));
            _datatable.Columns.Add("ClientName", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("ClientType", typeof(System.String));
            _datatable.Columns.Add("CustomerType", typeof(System.String));
            _datatable.Columns.Add("BusinessType", typeof(System.String));
            _datatable.Columns.Add("CountryCode", typeof(System.String));
            _datatable.Columns.Add("StateCode", typeof(System.String));
            _datatable.Columns.Add("EmailID", typeof(System.String));
            _datatable.Columns.Add("PhoneNo", typeof(System.String));
            _datatable.Columns.Add("MobileNo", typeof(System.String));
            _datatable.Columns.Add("AddressDetails", typeof(System.String));
            _datatable.Columns.Add("City", typeof(System.String));
            _datatable.Columns.Add("ISCash", typeof(System.String));
            _datatable.Columns.Add("CompanyID", typeof(System.String));
            _datatable.Columns.Add("Status", typeof(System.String));

            DataRow _datarow;

            foreach (ClientDetailsLIMSAPI _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["ClientCode"] = _list.ClientCode;
                _datarow["ClientName"] = _list.ClientName;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["ClientType"] = _list.ClientType;
                _datarow["CustomerType"] = _list.CustomerType;
                _datarow["BusinessType"] = _list.BusinessType;
                _datarow["CountryCode"] = _list.CountryCode;
                _datarow["StateCode"] = _list.StateCode;
                _datarow["EmailID"] = _list.EmailID;
                _datarow["PhoneNo"] = _list.PhoneNo;
                _datarow["MobileNo"] = _list.MobileNo;
                _datarow["AddressDetails"] = _list.AddressDetails;
                _datarow["City"] = _list.City;
                _datarow["ISCash"] = _list.ISCash;
                _datarow["CompanyID"] = _list.CompanyID;
                _datarow["Status"] = _list.Status;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToTableUsers(List<UsersInfo> _lstUsers)
        {
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("UserID", typeof(System.Int64));
            _datatable.Columns.Add("Name", typeof(System.String));
            _datatable.Columns.Add("MobileNumber", typeof(System.String));
            _datatable.Columns.Add("LoginID", typeof(System.String));
            _datatable.Columns.Add("LoginName", typeof(System.String));
            _datatable.Columns.Add("Password", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("ServerName", typeof(System.String));
            _datatable.Columns.Add("URL", typeof(System.String));
            _datatable.Columns.Add("CreatedBy", typeof(System.String));
            _datatable.Columns.Add("CreatedAt", typeof(System.DateTime));
            _datatable.Columns.Add("ModifiedBy", typeof(System.String));
            _datatable.Columns.Add("ModifiedAt", typeof(System.DateTime));
            DataRow _datarow;

            foreach (UsersInfo _list in _lstUsers)
            {
                _datarow = _datatable.NewRow();
                _datarow["UserID"] = _list.UserID;
                _datarow["Name"] = _list.Name;
                _datarow["MobileNumber"] = _list.MobileNumber;
                _datarow["LoginID"] = _list.LoginID;
                _datarow["LoginName"] = _list.LoginName;
                _datarow["Password"] = _list.Password;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["ServerName"] = _list.ServerName;
                _datarow["URL"] = _list.URL;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["ModifiedBy"] = _list.ModifiedBy;
                _datarow["ModifiedAt"] = _list.ModifiedAt;
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
        }
    }
}
