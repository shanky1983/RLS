using Attune.Kernel.LIMSAPI.BusinessEntities; 
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.UDT
{
    public class HomeCollections_UDT
    {
        public static System.Data.DataTable ConvertToHCServiceQuotation(Bookings _lstCollection)
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

            /*added By Jaga for HC*/
            _datatable.Columns.Add("ReferalID", typeof(System.Int64));
            _datatable.Columns.Add("TokenID", typeof(System.String));
            _datatable.Columns.Add("RefPhysicianName", typeof(System.String));
            _datatable.Columns.Add("NRICNumber", typeof(System.String));
            _datatable.Columns.Add("NRICType", typeof(System.String));
            _datatable.Columns.Add("ExterNalPatNo", typeof(System.String));
            /* end Added */
            DataRow _datarow;

            _datarow = _datatable.NewRow();
            _datarow["TokenNumber"] = _lstCollection.TokenNumber;
            _datarow["TITLECode"] = _lstCollection.TITLECode;
            _datarow["PatientName"] = _lstCollection.PatientName;
            _datarow["Sex"] = _lstCollection.Sex;
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
            /*Added By Jaga for HC */
            _datarow["ReferalID"] = _lstCollection.ReferalID;
            _datarow["TokenID"] = _lstCollection.TokenID;
            _datarow["RefPhysicianName"] = _lstCollection.RefPhysicianName;
            _datarow["NRICNumber"] = _lstCollection.NRICNumber;
            _datarow["NRICType"] = _lstCollection.NRICType;
            _datarow["ExterNalPatNo"] = _lstCollection.ExternalPatientNo;
            /* end Added */
            _datatable.Rows.Add(_datarow);
            return _datatable;
            //Test
        }
        public static System.Data.DataTable ConvertToHCOrderedInvestigation(List<OrderedInvestigations> _lstCollection)
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
        public static System.Data.DataTable ConvertToHCPreOrdered(List<OrderedInvestigations> _lstPreCollection)
        {

            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("Name", typeof(System.String));
            _datatable.Columns.Add("ID", typeof(System.Int64));
            _datatable.Columns.Add("VisitID", typeof(System.Int64));
            _datatable.Columns.Add("Status", typeof(System.String));
            _datatable.Columns.Add("Type", typeof(System.String));
            _datatable.Columns.Add("OrgID", typeof(System.Int32));
            _datatable.Columns.Add("Rate", typeof(Decimal));
            _datatable.Columns.Add("ActualAmount", typeof(Decimal));
            _datatable.Columns.Add("DiscountAmount", typeof(Decimal));
            _datatable.Columns.Add("SalesAmount", typeof(Decimal));
            _datatable.Columns.Add("PkgName", typeof(System.String));
            _datatable.Columns.Add("PkgID", typeof(System.Int64));
            DataRow _datarow;

            foreach (OrderedInvestigations _list in _lstPreCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["Name"] = _list.Name;
                _datarow["ID"] = _list.ID;
                _datarow["VisitID"] = _list.VisitID;
                _datarow["Status"] = _list.Status;
                _datarow["Type"] = _list.Type;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["Rate"] = _list.Rate;
                _datarow["ActualAmount"] = _list.ActualAmount;
                _datarow["DiscountAmount"] = _list.DiscountAmount;
                _datarow["SalesAmount"] = _list.SalesAmount;
                _datarow["PkgName"] = _list.PkgName;
                _datarow["PkgID"] = _list.PkgID;
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
            _datatable.Columns.Add("strvar", typeof(System.String));
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
            _datarow["strvar"] = (_Context != null) ? _Context.AdditionalInfo : string.Empty;

            _datatable.Rows.Add(_datarow);
            return _datatable;
        }
        public static System.Data.DataTable ConvertToHomeBooking(List<Bookings> _lstCollection)
        {
            //lan
            System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("TokenNumber", typeof(System.Int32));
            _datatable.Columns.Add("TITLECode", typeof(System.Byte));
            _datatable.Columns.Add("PatientName", typeof(System.String));
            _datatable.Columns.Add("SEX", typeof(System.String));
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

            foreach (Bookings _list in _lstCollection)
            {
                _datarow = _datatable.NewRow();
                _datarow["TokenNumber"] = _list.TokenNumber;
                _datarow["TITLECode"] = _list.TITLECode;
                _datarow["PatientName"] = _list.PatientName;
                _datarow["SEX"] = _list.Sex;
                _datarow["DOB"] = _list.DOB;
                _datarow["Age"] = _list.Age;
                _datarow["LandLineNumber"] = _list.LandLineNumber;
                _datarow["CreatedAt"] = _list.CreatedAt;
                _datarow["PhoneNumber"] = _list.PhoneNumber;
                _datarow["EMail"] = _list.EMail;
                _datarow["ClientID"] = _list.ClientID;
                _datarow["FeeType"] = _list.FeeType;
                _datarow["SourceType"] = _list.SourceType;
                _datarow["OrgID"] = _list.OrgID;
                _datarow["CreatedBy"] = _list.CreatedBy;
                _datarow["PatientID"] = _list.PatientID;
                _datarow["OrgAddressID"] = _list.OrgAddressID;
                _datarow["OtherOrgID"] = _list.OtherOrgID;
                _datarow["CollectionAddress"] = _list.CollectionAddress;
                _datarow["RoleID"] = _list.RoleID;
                _datarow["UserID"] = _list.UserID;
                _datarow["CollectionTime"] = _list.CollectionTime;
                _datarow["BookingOrgID"] = _list.BookingOrgID;
                _datarow["BookingStatus"] = _list.BookingStatus;
                _datarow["CollectionAddress2"] = _list.CollectionAddress2;
                _datarow["City"] = _list.City;
                _datarow["PatientNumber"] = _list.PatientNumber;
                _datarow["BookingID"] = _list.BookingID;
                _datarow["BillDescription"] = _list.BillDescription;
                _datarow["Priority"] = _list.Priority;
                _datarow["Comments"] = _list.Comments;
                _datarow["State"] = _list.State;
                _datarow["Pincode"] = _list.Pincode;
                _datarow["StateID"] = _list.StateID;
                _datarow["CityID"] = _list.CityID;
                _datarow["URNTypeID"] = _list.URNTypeID;
                _datarow["URNO"] = _list.URNO;
                _datarow["DispatchValue"] = _list.DispatchValue;
                _datarow["ReferalID"] = _list.ReferalID;
                _datarow["TokenID"] = _list.TokenID;
                _datarow["RefPhysicianName"] = _list.RefPhysicianName;
                _datarow["NRICNumber"] = _list.NRICNumber;
                _datarow["NRICType"] = _list.NRICType;
                _datarow["ExterNalPatNo"] = _list.ExternalPatientNo;//.ExterNalPatNo;
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

        public static System.Data.DataTable ConvertToUDT_Context1(ContextDetails _Context)
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


         public static System.Data.DataTable ConvertToSCPTimeSlot(List<SCPTimeinfo> _lstTime)
        {
      

        System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("WorkingDays", typeof(System.String));
            _datatable.Columns.Add("StartTime", typeof(System.TimeSpan));
            _datatable.Columns.Add("EndTime", typeof(System.TimeSpan));
            _datatable.Columns.Add("SlotDuration", typeof(System.TimeSpan));
           
            DataRow _datarow;

            foreach (SCPTimeinfo _list in _lstTime)
            {
                _datarow = _datatable.NewRow();
                _datarow["WorkingDays"] = _list.WorkingDays;
                _datarow["StartTime"] = _list.StartTime;
                _datarow["EndTime"] = _list.EndTime;
                _datarow["SlotDuration"] = _list.SlotDuration;               
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

        public static System.Data.DataTable ConvertToSCPLeaveSlot(List<SCPLeaveinfo> _lstLeave)
        {

          System.Data.DataTable _datatable = new System.Data.DataTable();

            _datatable.Columns.Add("StartDate", typeof(System.DateTime));
            _datatable.Columns.Add("EndDate", typeof(System.DateTime));
            _datatable.Columns.Add("Holidays", typeof(System.DateTime));
           
            DataRow _datarow;

            foreach (SCPLeaveinfo _list in _lstLeave)
            {
                _datarow = _datatable.NewRow();
                _datarow["StartDate"] = _list.StartDate;
                _datarow["EndDate"] = _list.EndDate;
                _datarow["Holidays"] = _list.Holidays;               
                _datatable.Rows.Add(_datarow);
            }
            return _datatable;
            //Test
        }

    }
}
