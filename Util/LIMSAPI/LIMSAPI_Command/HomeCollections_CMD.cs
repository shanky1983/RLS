using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.Cmd
{
    public class HomeCollections_CMD
    {
        #region HomeCollection
        public static System.Data.SqlClient.SqlCommand pGetServiceQuotationDetailsCommand(long pBookingID, int pOrgID, System.Data.DataTable ContextInfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetServiceQuotationDetails";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pBookingID = new System.Data.SqlClient.SqlParameter();
            _pBookingID.ParameterName = "@pBookingID";
            _pBookingID.Size = -1;
            _pBookingID.Value = pBookingID;
            cmd.Parameters.Add(_pBookingID);
            System.Data.SqlClient.SqlParameter _pOrgID = new System.Data.SqlClient.SqlParameter();
            _pOrgID.ParameterName = "@pOrgID";
            _pOrgID.Size = -1;
            _pOrgID.Value = pOrgID;
            cmd.Parameters.Add(_pOrgID);
            System.Data.SqlClient.SqlParameter _ContextInfo = new System.Data.SqlClient.SqlParameter();
            _ContextInfo.ParameterName = "@ContextInfo";
            _ContextInfo.Size = -1;
            _ContextInfo.Value = ContextInfo;
            cmd.Parameters.Add(_ContextInfo);
            return cmd;
        }

        public static System.Data.SqlClient.SqlCommand pHCSaveServiceQuotationDetailsCommand(System.Data.DataTable pServiceQuotation, System.Data.DataTable pOrderedInvTable, System.Data.DataTable pPreOrdered, int pOrgID, long pLID, out long pBookingID, System.Data.DataTable ContextInfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pHCSaveServiceQuotationDetails";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pServiceQuotation = new System.Data.SqlClient.SqlParameter();
            _pServiceQuotation.ParameterName = "@pServiceQuotation";
            _pServiceQuotation.Size = -1;
            _pServiceQuotation.Value = pServiceQuotation;
            cmd.Parameters.Add(_pServiceQuotation);
            System.Data.SqlClient.SqlParameter _pOrderedInvTable = new System.Data.SqlClient.SqlParameter();
            _pOrderedInvTable.ParameterName = "@pOrderedInvTable";
            _pOrderedInvTable.Size = -1;
            _pOrderedInvTable.Value = pOrderedInvTable;
            cmd.Parameters.Add(_pOrderedInvTable);
            System.Data.SqlClient.SqlParameter _pPreOrdered = new System.Data.SqlClient.SqlParameter();
            _pPreOrdered.ParameterName = "@pPreOrdered";
            _pPreOrdered.Size = -1;
            _pPreOrdered.Value = pPreOrdered;
            cmd.Parameters.Add(_pPreOrdered);
            System.Data.SqlClient.SqlParameter _pOrgID = new System.Data.SqlClient.SqlParameter();
            _pOrgID.ParameterName = "@pOrgID";
            _pOrgID.Size = -1;
            _pOrgID.Value = pOrgID;
            cmd.Parameters.Add(_pOrgID);
            System.Data.SqlClient.SqlParameter _pLID = new System.Data.SqlClient.SqlParameter();
            _pLID.ParameterName = "@pLID";
            _pLID.Size = -1;
            _pLID.Value = pLID;
            cmd.Parameters.Add(_pLID);
            pBookingID = -1;
            System.Data.SqlClient.SqlParameter _pBookingID = new System.Data.SqlClient.SqlParameter();
            _pBookingID.ParameterName = "@pBookingID";
            _pBookingID.Size = -1;
            _pBookingID.Value = pBookingID;
            cmd.Parameters.Add(_pBookingID);
            _pBookingID.Direction = ParameterDirection.Output;
            System.Data.SqlClient.SqlParameter _ContextInfo = new System.Data.SqlClient.SqlParameter();
            _ContextInfo.ParameterName = "@ContextInfo";
            _ContextInfo.Size = -1;
            _ContextInfo.Value = ContextInfo;
            cmd.Parameters.Add(_ContextInfo);
            pBookingID = ((long)(_pBookingID.Value));
            return cmd;
        }

        public static System.Data.SqlClient.SqlCommand pGetHCBookingDetailsCommand(
             System.DateTime CollectionTime,
             System.DateTime toTime,
             long UserID,
             int CollecOrgID,
             string Location,
             string Pincode,
             int LoginOrgID,
             System.DateTime BookedFrom,
             System.DateTime BookedTo,
             string Status,
             string Task,
             System.Data.DataTable ContextInfo,
             string MobileNumber,
             string TelePhone,
             string pName,
             int pageSize,
             int startRowIndex,
             long BookingNumber)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetHCBookingDetails";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _CollectionTime = new System.Data.SqlClient.SqlParameter();
            _CollectionTime.ParameterName = "@CollectionTime";
            _CollectionTime.Size = -1;
            _CollectionTime.Value = CollectionTime;
            _CollectionTime.Precision = 0;
            _CollectionTime.Scale = 0;
            cmd.Parameters.Add(_CollectionTime);
            System.Data.SqlClient.SqlParameter _toTime = new System.Data.SqlClient.SqlParameter();
            _toTime.ParameterName = "@toTime";
            _toTime.Size = -1;
            _toTime.Value = toTime;
            _toTime.Precision = 0;
            _toTime.Scale = 0;
            cmd.Parameters.Add(_toTime);
            System.Data.SqlClient.SqlParameter _UserID = new System.Data.SqlClient.SqlParameter();
            _UserID.ParameterName = "@UserID";
            _UserID.Size = -1;
            _UserID.Value = UserID;
            _UserID.Precision = 19;
            _UserID.Scale = 0;
            cmd.Parameters.Add(_UserID);
            System.Data.SqlClient.SqlParameter _CollecOrgID = new System.Data.SqlClient.SqlParameter();
            _CollecOrgID.ParameterName = "@CollecOrgID";
            _CollecOrgID.Size = -1;
            _CollecOrgID.Value = CollecOrgID;
            _CollecOrgID.Precision = 10;
            _CollecOrgID.Scale = 0;
            cmd.Parameters.Add(_CollecOrgID);
            System.Data.SqlClient.SqlParameter _Location = new System.Data.SqlClient.SqlParameter();
            _Location.ParameterName = "@Location";
            _Location.Size = 200;
            _Location.Value = Location;
            _Location.Precision = 0;
            _Location.Scale = 0;
            cmd.Parameters.Add(_Location);
            System.Data.SqlClient.SqlParameter _Pincode = new System.Data.SqlClient.SqlParameter();
            _Pincode.ParameterName = "@Pincode";
            _Pincode.Size = 20;
            _Pincode.Value = Pincode;
            _Pincode.Precision = 0;
            _Pincode.Scale = 0;
            cmd.Parameters.Add(_Pincode);
            System.Data.SqlClient.SqlParameter _LoginOrgID = new System.Data.SqlClient.SqlParameter();
            _LoginOrgID.ParameterName = "@LoginOrgID";
            _LoginOrgID.Size = -1;
            _LoginOrgID.Value = LoginOrgID;
            _LoginOrgID.Precision = 10;
            _LoginOrgID.Scale = 0;
            cmd.Parameters.Add(_LoginOrgID);
            System.Data.SqlClient.SqlParameter _BookedFrom = new System.Data.SqlClient.SqlParameter();
            _BookedFrom.ParameterName = "@BookedFrom";
            _BookedFrom.Size = -1;
            _BookedFrom.Value = BookedFrom;
            _BookedFrom.Precision = 0;
            _BookedFrom.Scale = 0;
            cmd.Parameters.Add(_BookedFrom);
            System.Data.SqlClient.SqlParameter _BookedTo = new System.Data.SqlClient.SqlParameter();
            _BookedTo.ParameterName = "@BookedTo";
            _BookedTo.Size = -1;
            _BookedTo.Value = BookedTo;
            _BookedTo.Precision = 0;
            _BookedTo.Scale = 0;
            cmd.Parameters.Add(_BookedTo);
            System.Data.SqlClient.SqlParameter _Status = new System.Data.SqlClient.SqlParameter();
            _Status.ParameterName = "@Status";
            _Status.Size = 20;
            _Status.Value = Status;
            _Status.Precision = 0;
            _Status.Scale = 0;
            cmd.Parameters.Add(_Status);
            System.Data.SqlClient.SqlParameter _Task = new System.Data.SqlClient.SqlParameter();
            _Task.ParameterName = "@Task";
            _Task.Size = 10;
            _Task.Value = Task;
            _Task.Precision = 0;
            _Task.Scale = 0;
            cmd.Parameters.Add(_Task);
            System.Data.SqlClient.SqlParameter _ContextInfo = new System.Data.SqlClient.SqlParameter();
            _ContextInfo.ParameterName = "@ContextInfo";
            _ContextInfo.Size = -1;
            _ContextInfo.Value = ContextInfo;
            _ContextInfo.Precision = 0;
            _ContextInfo.Scale = 0;
            cmd.Parameters.Add(_ContextInfo);
            System.Data.SqlClient.SqlParameter _MobileNumber = new System.Data.SqlClient.SqlParameter();
            _MobileNumber.ParameterName = "@MobileNumber";
            _MobileNumber.Size = 20;
            _MobileNumber.Value = MobileNumber;
            _MobileNumber.Precision = 0;
            _MobileNumber.Scale = 0;
            cmd.Parameters.Add(_MobileNumber);
            System.Data.SqlClient.SqlParameter _TelePhone = new System.Data.SqlClient.SqlParameter();
            _TelePhone.ParameterName = "@TelePhone";
            _TelePhone.Size = 20;
            _TelePhone.Value = TelePhone;
            _TelePhone.Precision = 0;
            _TelePhone.Scale = 0;
            cmd.Parameters.Add(_TelePhone);
            System.Data.SqlClient.SqlParameter _pName = new System.Data.SqlClient.SqlParameter();
            _pName.ParameterName = "@pName";
            _pName.Size = 200;
            _pName.Value = pName;
            _pName.Precision = 0;
            _pName.Scale = 0;
            cmd.Parameters.Add(_pName);
            System.Data.SqlClient.SqlParameter _pageSize = new System.Data.SqlClient.SqlParameter();
            _pageSize.ParameterName = "@pageSize";
            _pageSize.Size = -1;
            _pageSize.Value = pageSize;
            _pageSize.Precision = 10;
            _pageSize.Scale = 0;
            cmd.Parameters.Add(_pageSize);
            System.Data.SqlClient.SqlParameter _startRowIndex = new System.Data.SqlClient.SqlParameter();
            _startRowIndex.ParameterName = "@startRowIndex";
            _startRowIndex.Size = -1;
            _startRowIndex.Value = startRowIndex;
            _startRowIndex.Precision = 10;
            _startRowIndex.Scale = 0;
            cmd.Parameters.Add(_startRowIndex);
            System.Data.SqlClient.SqlParameter _BookingNumber = new System.Data.SqlClient.SqlParameter();
            _BookingNumber.ParameterName = "@BookingNumber";
            _BookingNumber.Size = -1;
            _BookingNumber.Value = BookingNumber;
            _BookingNumber.Precision = 19;
            _BookingNumber.Scale = 0;
            cmd.Parameters.Add(_BookingNumber);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pUpdateHCBookingDetailsCommand(System.Data.DataTable pServiceQuotation, System.Data.DataTable pOrderedInvTable, int pOrgID, long pLID, out long pBookingID, System.Data.DataTable ContextInfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pUpdateHCBookingDetails";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pServiceQuotation = new System.Data.SqlClient.SqlParameter();
            _pServiceQuotation.ParameterName = "@pServiceQuotation";
            _pServiceQuotation.Size = -1;
            _pServiceQuotation.Value = pServiceQuotation;
            _pServiceQuotation.Precision = 0;
            _pServiceQuotation.Scale = 0;
            cmd.Parameters.Add(_pServiceQuotation);
            System.Data.SqlClient.SqlParameter _pOrderedInvTable = new System.Data.SqlClient.SqlParameter();
            _pOrderedInvTable.ParameterName = "@pOrderedInvTable";
            _pOrderedInvTable.Size = -1;
            _pOrderedInvTable.Value = pOrderedInvTable;
            _pOrderedInvTable.Precision = 0;
            _pOrderedInvTable.Scale = 0;
            cmd.Parameters.Add(_pOrderedInvTable);
            System.Data.SqlClient.SqlParameter _pOrgID = new System.Data.SqlClient.SqlParameter();
            _pOrgID.ParameterName = "@pOrgID";
            _pOrgID.Size = -1;
            _pOrgID.Value = pOrgID;
            _pOrgID.Precision = 10;
            _pOrgID.Scale = 0;
            cmd.Parameters.Add(_pOrgID);
            System.Data.SqlClient.SqlParameter _pLID = new System.Data.SqlClient.SqlParameter();
            _pLID.ParameterName = "@pLID";
            _pLID.Size = -1;
            _pLID.Value = pLID;
            _pLID.Precision = 19;
            _pLID.Scale = 0;
            cmd.Parameters.Add(_pLID);
            pBookingID = -1;
            System.Data.SqlClient.SqlParameter _pBookingID = new System.Data.SqlClient.SqlParameter();
            _pBookingID.ParameterName = "@pBookingID";
            _pBookingID.Size = -1;
            _pBookingID.Value = pBookingID;
            _pBookingID.Precision = 19;
            _pBookingID.Scale = 0;
            cmd.Parameters.Add(_pBookingID);
            _pBookingID.Direction = ParameterDirection.Output;
            System.Data.SqlClient.SqlParameter _ContextInfo = new System.Data.SqlClient.SqlParameter();
            _ContextInfo.ParameterName = "@ContextInfo";
            _ContextInfo.Size = -1;
            _ContextInfo.Value = ContextInfo;
            _ContextInfo.Precision = 0;
            _ContextInfo.Scale = 0;
            cmd.Parameters.Add(_ContextInfo);
            pBookingID = ((long)(_pBookingID.Value));
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetHCMapBookingDetailsCommand(long BookingNumber, long pUserID, System.Data.DataTable ContextInfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetHCMapBookingDetails";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _BookingNumber = new System.Data.SqlClient.SqlParameter();
            _BookingNumber.ParameterName = "@BookingNumber";
            _BookingNumber.Size = -1;
            _BookingNumber.Value = BookingNumber;
            _BookingNumber.Precision = 19;
            _BookingNumber.Scale = 0;
            cmd.Parameters.Add(_BookingNumber);
            System.Data.SqlClient.SqlParameter _pUserID = new System.Data.SqlClient.SqlParameter();
            _pUserID.ParameterName = "@pUserID";
            _pUserID.Size = -1;
            _pUserID.Value = pUserID;
            _pUserID.Precision = 19;
            _pUserID.Scale = 0;
            cmd.Parameters.Add(_pUserID);
            System.Data.SqlClient.SqlParameter _ContextInfo = new System.Data.SqlClient.SqlParameter();
            _ContextInfo.ParameterName = "@ContextInfo";
            _ContextInfo.Size = -1;
            _ContextInfo.Value = ContextInfo;
            _ContextInfo.Precision = 0;
            _ContextInfo.Scale = 0;
            cmd.Parameters.Add(_ContextInfo);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetOrglocationMapCommand(int OrgID, long AddId, int ChkId, System.Data.DataTable ContextInfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetOrglocationMap";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _OrgID = new System.Data.SqlClient.SqlParameter();
            _OrgID.ParameterName = "@OrgID";
            _OrgID.Size = -1;
            _OrgID.Value = OrgID;
            _OrgID.Precision = 10;
            _OrgID.Scale = 0;
            cmd.Parameters.Add(_OrgID);
            System.Data.SqlClient.SqlParameter _AddId = new System.Data.SqlClient.SqlParameter();
            _AddId.ParameterName = "@AddId";
            _AddId.Size = -1;
            _AddId.Value = AddId;
            _AddId.Precision = 19;
            _AddId.Scale = 0;
            cmd.Parameters.Add(_AddId);
            System.Data.SqlClient.SqlParameter _ChkId = new System.Data.SqlClient.SqlParameter();
            _ChkId.ParameterName = "@ChkId";
            _ChkId.Size = -1;
            _ChkId.Value = ChkId;
            _ChkId.Precision = 10;
            _ChkId.Scale = 0;
            cmd.Parameters.Add(_ChkId);
            System.Data.SqlClient.SqlParameter _ContextInfo = new System.Data.SqlClient.SqlParameter();
            _ContextInfo.ParameterName = "@ContextInfo";
            _ContextInfo.Size = -1;
            _ContextInfo.Value = ContextInfo;
            _ContextInfo.Precision = 0;
            _ContextInfo.Scale = 0;
            cmd.Parameters.Add(_ContextInfo);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pLoadMetaDataOrgMappingCommand(System.Data.DataTable pDomain, long pOrgID, string pLangCode, System.Data.DataTable ContextInfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pLoadMetaDataOrgMapping";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pDomain = new System.Data.SqlClient.SqlParameter();
            _pDomain.ParameterName = "@pDomain";
            _pDomain.Size = -1;
            _pDomain.Value = pDomain;
            cmd.Parameters.Add(_pDomain);
            System.Data.SqlClient.SqlParameter _pOrgID = new System.Data.SqlClient.SqlParameter();
            _pOrgID.ParameterName = "@pOrgID";
            _pOrgID.Size = -1;
            _pOrgID.Value = pOrgID;
            cmd.Parameters.Add(_pOrgID);
            System.Data.SqlClient.SqlParameter _pLangCode = new System.Data.SqlClient.SqlParameter();
            _pLangCode.ParameterName = "@pLangCode";
            _pLangCode.Size = 10;
            _pLangCode.Value = pLangCode;
            cmd.Parameters.Add(_pLangCode);
            System.Data.SqlClient.SqlParameter _ContextInfo = new System.Data.SqlClient.SqlParameter();
            _ContextInfo.ParameterName = "@ContextInfo";
            _ContextInfo.Size = -1;
            _ContextInfo.Value = ContextInfo;
            cmd.Parameters.Add(_ContextInfo);
            return cmd;
        }
        #endregion
        public static System.Data.SqlClient.SqlCommand pGetBillingItemsCommand(int pOrgID, string pFeeType, string pDescription, long pClientID, string pIS2ped, string pRemarks, string pGender, System.Data.DataTable ContextInfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetBillingItems";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgID = new System.Data.SqlClient.SqlParameter();
            _pOrgID.ParameterName = "@pOrgID";
            _pOrgID.Size = -1;
            _pOrgID.Value = pOrgID;
            cmd.Parameters.Add(_pOrgID);
            System.Data.SqlClient.SqlParameter _pFeeType = new System.Data.SqlClient.SqlParameter();
            _pFeeType.ParameterName = "@pFeeType";
            _pFeeType.Size = 20;
            _pFeeType.Value = pFeeType;
            cmd.Parameters.Add(_pFeeType);
            System.Data.SqlClient.SqlParameter _pDescription = new System.Data.SqlClient.SqlParameter();
            _pDescription.ParameterName = "@pDescription";
            _pDescription.Size = 100;
            _pDescription.Value = pDescription;
            cmd.Parameters.Add(_pDescription);
            System.Data.SqlClient.SqlParameter _pClientID = new System.Data.SqlClient.SqlParameter();
            _pClientID.ParameterName = "@pClientID";
            _pClientID.Size = -1;
            _pClientID.Value = pClientID;
            cmd.Parameters.Add(_pClientID);
            System.Data.SqlClient.SqlParameter _pIS2ped = new System.Data.SqlClient.SqlParameter();
            _pIS2ped.ParameterName = "@pIS2ped";
            _pIS2ped.Size = 20;
            _pIS2ped.Value = pIS2ped;
            cmd.Parameters.Add(_pIS2ped);
            System.Data.SqlClient.SqlParameter _pRemarks = new System.Data.SqlClient.SqlParameter();
            _pRemarks.ParameterName = "@pRemarks";
            _pRemarks.Size = 255;
            _pRemarks.Value = pRemarks;
            cmd.Parameters.Add(_pRemarks);
            System.Data.SqlClient.SqlParameter _pGender = new System.Data.SqlClient.SqlParameter();
            _pGender.ParameterName = "@pGender";
            _pGender.Size = 1;
            _pGender.Value = pGender;
            cmd.Parameters.Add(_pGender);
            System.Data.SqlClient.SqlParameter _ContextInfo = new System.Data.SqlClient.SqlParameter();
            _ContextInfo.ParameterName = "@ContextInfo";
            _ContextInfo.Size = -1;
            _ContextInfo.Value = ContextInfo;
            cmd.Parameters.Add(_ContextInfo);
            return cmd;
        }



        public static System.Data.SqlClient.SqlCommand pGetBillingClientNameCommand(string prefixText, int pOrgId, string pType, long prefhospid, System.Data.DataTable ContextInfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetRateCardForBilling";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _prefixText = new System.Data.SqlClient.SqlParameter();
            _prefixText.ParameterName = "@prefixText";
            _prefixText.Size = 30;
            _prefixText.Value = prefixText;
            cmd.Parameters.Add(_prefixText);
            System.Data.SqlClient.SqlParameter _pOrgId = new System.Data.SqlClient.SqlParameter();
            _pOrgId.ParameterName = "@pOrgId";
            _pOrgId.Size = -1;
            _pOrgId.Value = pOrgId;
            cmd.Parameters.Add(_pOrgId);
            System.Data.SqlClient.SqlParameter _pType = new System.Data.SqlClient.SqlParameter();
            _pType.ParameterName = "@pType";
            _pType.Size = 10;
            _pType.Value = pType;
            cmd.Parameters.Add(_pType);
            System.Data.SqlClient.SqlParameter _prefhospid = new System.Data.SqlClient.SqlParameter();
            _prefhospid.ParameterName = "@prefhospid";
            _prefhospid.Size = -1;
            _prefhospid.Value = prefhospid;
            cmd.Parameters.Add(_prefhospid);
            System.Data.SqlClient.SqlParameter _ContextInfo = new System.Data.SqlClient.SqlParameter();
            _ContextInfo.ParameterName = "@ContextInfo";
            _ContextInfo.Size = -1;
            _ContextInfo.Value = ContextInfo;
            cmd.Parameters.Add(_ContextInfo);
            return cmd;
        }


        public static System.Data.SqlClient.SqlCommand pGetHCBillingTechnicianNameCommand(int pOrgID, long pRoleID, System.Data.DataTable ContextInfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetUserName";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgID = new System.Data.SqlClient.SqlParameter();
            _pOrgID.ParameterName = "@pOrgID";
            _pOrgID.Size = -1;
            _pOrgID.Value = pOrgID;
            cmd.Parameters.Add(_pOrgID);
            System.Data.SqlClient.SqlParameter _pRoleID = new System.Data.SqlClient.SqlParameter();
            _pRoleID.ParameterName = "@pRoleID";
            _pRoleID.Size = -1;
            _pRoleID.Value = pRoleID;
            cmd.Parameters.Add(_pRoleID);
            System.Data.SqlClient.SqlParameter _ContextInfo = new System.Data.SqlClient.SqlParameter();
            _ContextInfo.ParameterName = "@ContextInfo";
            _ContextInfo.Size = -1;
            _ContextInfo.Value = ContextInfo;
            cmd.Parameters.Add(_ContextInfo);
            return cmd;
        }


        public static System.Data.SqlClient.SqlCommand pGetLocationforHomeCollectionCommand(long Pincode, long LocationID, string LocationName, System.Data.DataTable ContextInfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetLocationforHomeCollection";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _Pincode = new System.Data.SqlClient.SqlParameter();
            _Pincode.ParameterName = "@Pincode";
            _Pincode.Size = -1;
            _Pincode.Value = Pincode;
            cmd.Parameters.Add(_Pincode);
            System.Data.SqlClient.SqlParameter _LocationID = new System.Data.SqlClient.SqlParameter();
            _LocationID.ParameterName = "@LocationID";
            _LocationID.Size = -1;
            _LocationID.Value = LocationID;
            cmd.Parameters.Add(_LocationID);
            System.Data.SqlClient.SqlParameter _LocationName = new System.Data.SqlClient.SqlParameter();
            _LocationName.ParameterName = "@LocationName";
            _LocationName.Size = 50;
            _LocationName.Value = LocationName;
            cmd.Parameters.Add(_LocationName);
            System.Data.SqlClient.SqlParameter _ContextInfo = new System.Data.SqlClient.SqlParameter();
            _ContextInfo.ParameterName = "@ContextInfo";
            _ContextInfo.Size = -1;
            _ContextInfo.Value = ContextInfo;
            cmd.Parameters.Add(_ContextInfo);
            return cmd;
        }

        public static System.Data.SqlClient.SqlCommand pGetLocationCommand(int pOrgID, long pLID, long pRID, System.Data.DataTable ContextInfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetLocation";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgID = new System.Data.SqlClient.SqlParameter();
            _pOrgID.ParameterName = "@pOrgID";
            _pOrgID.Size = -1;
            _pOrgID.Value = pOrgID;
            cmd.Parameters.Add(_pOrgID);
            System.Data.SqlClient.SqlParameter _pLID = new System.Data.SqlClient.SqlParameter();
            _pLID.ParameterName = "@pLID";
            _pLID.Size = -1;
            _pLID.Value = pLID;
            cmd.Parameters.Add(_pLID);
            System.Data.SqlClient.SqlParameter _pRID = new System.Data.SqlClient.SqlParameter();
            _pRID.ParameterName = "@pRID";
            _pRID.Size = -1;
            _pRID.Value = pRID;
            cmd.Parameters.Add(_pRID);
            System.Data.SqlClient.SqlParameter _ContextInfo = new System.Data.SqlClient.SqlParameter();
            _ContextInfo.ParameterName = "@ContextInfo";
            _ContextInfo.Size = -1;
            _ContextInfo.Value = ContextInfo;
            cmd.Parameters.Add(_ContextInfo);
            return cmd;
        }

        public static System.Data.SqlClient.SqlCommand pGetUserRolesCommand(long pLoginID, System.Data.DataTable ContextInfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetUserRoles";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pLoginID = new System.Data.SqlClient.SqlParameter();
            _pLoginID.ParameterName = "@pLoginID";
            _pLoginID.Size = -1;
            _pLoginID.Value = pLoginID;
            cmd.Parameters.Add(_pLoginID);
            System.Data.SqlClient.SqlParameter _ContextInfo = new System.Data.SqlClient.SqlParameter();
            _ContextInfo.ParameterName = "@ContextInfo";
            _ContextInfo.Size = -1;
            _ContextInfo.Value = ContextInfo;
            cmd.Parameters.Add(_ContextInfo);
            return cmd;
        }


        public static System.Data.SqlClient.SqlCommand pGetSampleCollectionPersonListCommand(int pOrgID, string PrefixText, long pPinCode, System.Data.DataTable ContextInfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetSampleCollectionPersonList_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgID = new System.Data.SqlClient.SqlParameter();
            _pOrgID.ParameterName = "@pOrgID";
            _pOrgID.Size = -1;
            _pOrgID.Value = pOrgID;
            cmd.Parameters.Add(_pOrgID);
            System.Data.SqlClient.SqlParameter _PrefixText = new System.Data.SqlClient.SqlParameter();
            _PrefixText.ParameterName = "@PrefixText";
            _PrefixText.Size = 10;
            _PrefixText.Value = PrefixText;
            cmd.Parameters.Add(_PrefixText);
            System.Data.SqlClient.SqlParameter _pPinCode = new System.Data.SqlClient.SqlParameter();
            _pPinCode.ParameterName = "@pPinCode";
            _pPinCode.Size = -1;
            _pPinCode.Value = pPinCode;
            cmd.Parameters.Add(_pPinCode);        
            System.Data.SqlClient.SqlParameter _ContextInfo = new System.Data.SqlClient.SqlParameter();
            _ContextInfo.ParameterName = "@ContextInfo";
            _ContextInfo.Size = -1;
            _ContextInfo.Value = ContextInfo;
            cmd.Parameters.Add(_ContextInfo);
            return cmd;
        }


        public static System.Data.SqlClient.SqlCommand pGetWorkingDaysCommand(System.Data.DataTable ContextInfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetMetaDataMaster_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _ContextInfo = new System.Data.SqlClient.SqlParameter();
            _ContextInfo.ParameterName = "@ContextInfo";
            _ContextInfo.Size = -1;
            _ContextInfo.Value = ContextInfo;
            cmd.Parameters.Add(_ContextInfo);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetPinCode(string PrefixText, string pMode, System.Data.DataTable ContextInfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetPincode_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _PrefixText = new System.Data.SqlClient.SqlParameter();
            _PrefixText.ParameterName = "@PrefixText";
            _PrefixText.Size = 10;
            _PrefixText.Value = PrefixText;
            cmd.Parameters.Add(_PrefixText);
            System.Data.SqlClient.SqlParameter _pMode = new System.Data.SqlClient.SqlParameter();
            _pMode.ParameterName = "@pMode";
            _pMode.Size = 10;
            _pMode.Value = pMode;
            cmd.Parameters.Add(_pMode);
            System.Data.SqlClient.SqlParameter _ContextInfo = new System.Data.SqlClient.SqlParameter();
            _ContextInfo.ParameterName = "@ContextInfo";
            _ContextInfo.Size = -1;
            _ContextInfo.Value = ContextInfo;
            cmd.Parameters.Add(_ContextInfo);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetHoliday(System.Data.DataTable ContextInfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetHolidayList_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;            
            System.Data.SqlClient.SqlParameter _ContextInfo = new System.Data.SqlClient.SqlParameter();
            _ContextInfo.ParameterName = "@ContextInfo";
            _ContextInfo.Size = -1;
            _ContextInfo.Value = ContextInfo;
            cmd.Parameters.Add(_ContextInfo);
            return cmd;
        }

        public static System.Data.SqlClient.SqlCommand pPostSCPSchedule_LIMSAPICommand(string pOrgCode, string pSCPerson, string pPinCode, long pUserID, System.Data.DataTable dtTime, System.Data.DataTable dtLeave, out long pOutResult)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pInsertSCPSchedule_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _pSCPerson = new System.Data.SqlClient.SqlParameter();
            _pSCPerson.ParameterName = "@pSCPerson";
            _pSCPerson.Size = 100;
            _pSCPerson.Value = pSCPerson;
            cmd.Parameters.Add(_pSCPerson);
            System.Data.SqlClient.SqlParameter _pPinCode = new System.Data.SqlClient.SqlParameter();
            _pPinCode.ParameterName = "@pPinCode";
            _pPinCode.Size = 1000;
            _pPinCode.Value = pPinCode;
            cmd.Parameters.Add(_pPinCode);
            System.Data.SqlClient.SqlParameter _pUserID = new System.Data.SqlClient.SqlParameter();
            _pUserID.ParameterName = "@pUserID";
            _pUserID.Size = -1;
            _pUserID.Value = pUserID;
            cmd.Parameters.Add(_pUserID);
            System.Data.SqlClient.SqlParameter _dtTime = new System.Data.SqlClient.SqlParameter();
            _dtTime.ParameterName = "@Timeslot";
            _dtTime.Size = -1;
            _dtTime.Value = dtTime;
            cmd.Parameters.Add(_dtTime);
            System.Data.SqlClient.SqlParameter _Leaveslot = new System.Data.SqlClient.SqlParameter();
            _Leaveslot.ParameterName = "@Leaveslot";
            _Leaveslot.Size = -1;
            _Leaveslot.Value = dtLeave;
            cmd.Parameters.Add(_Leaveslot);
             pOutResult = 0;
            System.Data.SqlClient.SqlParameter _pOutResult = new System.Data.SqlClient.SqlParameter();
            _pOutResult.ParameterName = "@pOutResult";
            _pOutResult.Size = 250;
            _pOutResult.Value = pOutResult;
            cmd.Parameters.Add(_pOutResult);
            _pOutResult.Direction = ParameterDirection.Output;
            pOutResult = (long)(_pOutResult.Value);
            return cmd;
        }

        public static System.Data.SqlClient.SqlCommand pPostUpdateSCPSchedule_LIMSAPICommand(long pResourceTemplateID, string pPinCode, long pUserID, System.Data.DataTable dtTime, System.Data.DataTable dtLeave)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pUPdateSCPSchedule_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;            
            System.Data.SqlClient.SqlParameter _pSCPerson = new System.Data.SqlClient.SqlParameter();
            _pSCPerson.ParameterName = "@pResourceTemplateID";
            _pSCPerson.Size = 100;
            _pSCPerson.Value = pResourceTemplateID;
            cmd.Parameters.Add(_pSCPerson);
            System.Data.SqlClient.SqlParameter _pPinCode = new System.Data.SqlClient.SqlParameter();
            _pPinCode.ParameterName = "@pPinCode";
            _pPinCode.Size = 1000;
            _pPinCode.Value = pPinCode;
            cmd.Parameters.Add(_pPinCode);
            System.Data.SqlClient.SqlParameter _pUserID = new System.Data.SqlClient.SqlParameter();
            _pUserID.ParameterName = "@pUserID";
            _pUserID.Size = -1;
            _pUserID.Value = pUserID;
            cmd.Parameters.Add(_pUserID);
            System.Data.SqlClient.SqlParameter _dtTime = new System.Data.SqlClient.SqlParameter();
            _dtTime.ParameterName = "@Timeslot";
            _dtTime.Size = -1;
            _dtTime.Value = dtTime;
            cmd.Parameters.Add(_dtTime);
            System.Data.SqlClient.SqlParameter _Leaveslot = new System.Data.SqlClient.SqlParameter();
            _Leaveslot.ParameterName = "@Leaveslot";
            _Leaveslot.Size = -1;
            _Leaveslot.Value = dtLeave;
            cmd.Parameters.Add(_Leaveslot);

            return cmd;
        }

        public static System.Data.SqlClient.SqlCommand pGetScheduleBySCPDetails_LIMSAPICommand(string pOrgCode, string pSCPerson)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetScheduleBySCP_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _pSCPerson = new System.Data.SqlClient.SqlParameter();
            _pSCPerson.ParameterName = "@pSCPerson";
            _pSCPerson.Size = 100;
            _pSCPerson.Value = pSCPerson;
            cmd.Parameters.Add(_pSCPerson);
            return cmd;
        }

        public static System.Data.SqlClient.SqlCommand pGetSCPBookingslot_LIMSAPICommand(long pPinCode, string pSCPPerson, DateTime pCheckDate, long pUserID, int PPageCount)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetSCPBookingslot_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pPinCode = new System.Data.SqlClient.SqlParameter();
            _pPinCode.ParameterName = "@pPinCode";
            _pPinCode.Size = -1;
            _pPinCode.Value = pPinCode;
            cmd.Parameters.Add(_pPinCode);
            System.Data.SqlClient.SqlParameter _pSCPerson = new System.Data.SqlClient.SqlParameter();
            _pSCPerson.ParameterName = "@pSCPPerson";
            _pSCPerson.Size = 100;
            _pSCPerson.Value = pSCPPerson;
            cmd.Parameters.Add(_pSCPerson);
            System.Data.SqlClient.SqlParameter _pCheckDate = new System.Data.SqlClient.SqlParameter();
            _pCheckDate.ParameterName = "@pCheckDate";
            _pCheckDate.Size = -1;
            _pCheckDate.Value = pCheckDate;
            _pCheckDate.Precision = 0;
            _pCheckDate.Scale = 0;
            cmd.Parameters.Add(_pCheckDate);
            System.Data.SqlClient.SqlParameter _pUserID = new System.Data.SqlClient.SqlParameter();
            _pUserID.ParameterName = "@pUserID";
            _pUserID.Size = -1;
            _pUserID.Value = pUserID;
            cmd.Parameters.Add(_pUserID);
            System.Data.SqlClient.SqlParameter _PPageCount = new System.Data.SqlClient.SqlParameter();
            _PPageCount.ParameterName = "@PPageCount";
            _PPageCount.Size = -1;
            _PPageCount.Value = PPageCount;
            cmd.Parameters.Add(_PPageCount);
            return cmd;
        }


        public static System.Data.SqlClient.SqlCommand PostUpdateBookingSchedule(string pBookingID, string pTechID, string pBookingDate, string pLoginID)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pUpdateBookingSchedule_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pBookingID = new System.Data.SqlClient.SqlParameter();
            _pBookingID.ParameterName = "@pBookingID";
            _pBookingID.Size = 10;
            _pBookingID.Value = pBookingID;
            cmd.Parameters.Add(_pBookingID);
            System.Data.SqlClient.SqlParameter _pTechID = new System.Data.SqlClient.SqlParameter();
            _pTechID.ParameterName = "@pTechID";
            _pTechID.Size = 10;
            _pTechID.Value = pTechID;
            cmd.Parameters.Add(_pTechID);
            System.Data.SqlClient.SqlParameter _pBookingDate = new System.Data.SqlClient.SqlParameter();
            _pBookingDate.ParameterName = "@pBookingDate";
            _pBookingDate.Size = 20;
            _pBookingDate.Value = pBookingDate;
            cmd.Parameters.Add(_pBookingDate);
            System.Data.SqlClient.SqlParameter _pLoginID = new System.Data.SqlClient.SqlParameter();
            _pLoginID.ParameterName = "@pLoginID";
            _pLoginID.Size = 10;
            _pLoginID.Value = pLoginID;
            cmd.Parameters.Add(_pLoginID);

            return cmd;
        }

        public static System.Data.SqlClient.SqlCommand CheckDuplicateBookingSlot(string pPincode, string pUserID, DateTime pCollectionTime, out long pOutResult)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pCheckDuplicateBookingSlot_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pPincode = new System.Data.SqlClient.SqlParameter();
            _pPincode.ParameterName = "@pPincode";
            _pPincode.Size = 10;
            _pPincode.Value = pPincode;
            cmd.Parameters.Add(_pPincode);
            System.Data.SqlClient.SqlParameter _pUserID = new System.Data.SqlClient.SqlParameter();
            _pUserID.ParameterName = "@pUserID";
            _pUserID.Size = 10;
            _pUserID.Value = pUserID;
            cmd.Parameters.Add(_pUserID);
            System.Data.SqlClient.SqlParameter _pCollectionTime = new System.Data.SqlClient.SqlParameter();
            _pCollectionTime.ParameterName = "@pCollectionTime";
            _pCollectionTime.Size = -1;
            _pCollectionTime.Value = pCollectionTime;
            _pCollectionTime.Precision = 0;
            _pCollectionTime.Scale = 0;         
            cmd.Parameters.Add(_pCollectionTime);
            pOutResult = -1;
            System.Data.SqlClient.SqlParameter _pOutResult = new System.Data.SqlClient.SqlParameter();
            _pOutResult.ParameterName = "@pOutResult";
            _pOutResult.Size = -1;
            _pOutResult.Value = pOutResult;
            cmd.Parameters.Add(_pOutResult);
            _pOutResult.Direction = ParameterDirection.Output;
            pOutResult = (long)(_pOutResult.Value);
            return cmd;
        }
    }
}
