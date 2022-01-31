using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.Cmd
{
    public class LIMSAPI_CMD
    {
        #region //Srini
        public static System.Data.SqlClient.SqlCommand pGetTestStatusByVisitNumber_LIMSAPICommand(int pOrgId, string pVisitNumber, string pExternalVisitID)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetTestStatusByVisitNumber_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgId = new System.Data.SqlClient.SqlParameter();
            _pOrgId.ParameterName = "@pOrgId";
            _pOrgId.Size = -1;
            _pOrgId.Value = pOrgId;
            cmd.Parameters.Add(_pOrgId);
            System.Data.SqlClient.SqlParameter _pVisitNumber = new System.Data.SqlClient.SqlParameter();
            _pVisitNumber.ParameterName = "@pVisitNumber";
            _pVisitNumber.Size = 50;
            _pVisitNumber.Value = pVisitNumber;
            cmd.Parameters.Add(_pVisitNumber);
            System.Data.SqlClient.SqlParameter _pExternalVisitID = new System.Data.SqlClient.SqlParameter();
            _pExternalVisitID.ParameterName = "@pExternalVisitID";
            _pExternalVisitID.Size = 50;
            _pExternalVisitID.Value = pExternalVisitID;
            cmd.Parameters.Add(_pExternalVisitID);
            return cmd;
        }
		
		public static System.Data.SqlClient.SqlCommand pGetValidateUser_LIMSAPICommand(string pUserName, string pPassword)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetValidateUser_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pUserName = new System.Data.SqlClient.SqlParameter();
            _pUserName.ParameterName = "@pUserName";
            _pUserName.Size = 255;
            _pUserName.Value = pUserName;
            _pUserName.Precision = 0;
            _pUserName.Scale = 0;
            cmd.Parameters.Add(_pUserName);
            System.Data.SqlClient.SqlParameter _pPassword = new System.Data.SqlClient.SqlParameter();
            _pPassword.ParameterName = "@pPassword";
            _pPassword.Size = 255;
            _pPassword.Value = pPassword;
            _pPassword.Precision = 0;
            _pPassword.Scale = 0;
            cmd.Parameters.Add(_pPassword);
            return cmd;
        }

        public static System.Data.SqlClient.SqlCommand pGetRoleLocation_LIMSAPICommand(int pOrgID, long pLID, long pRID)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetRoleLocation_LIMSAPI";
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
            return cmd;
        }

        #endregion

        #region //Jazz
        //API  START
        public static System.Data.SqlClient.SqlCommand pGetTestMasterInfo__LIMSAPICommand(string pOrgCode, string pType, string TestCode, int Page, int Size)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetTestMasterInfo__LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            _pOrgCode.Precision = 0;
            _pOrgCode.Scale = 0;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _pType = new System.Data.SqlClient.SqlParameter();
            _pType.ParameterName = "@pType";
            _pType.Size = 255;
            _pType.Value = pType;
            _pType.Precision = 0;
            _pType.Scale = 0;
            cmd.Parameters.Add(_pType);
            System.Data.SqlClient.SqlParameter _TestCode = new System.Data.SqlClient.SqlParameter();
            _TestCode.ParameterName = "@TestCode";
            _TestCode.Size = 100;
            _TestCode.Value = TestCode;
            _TestCode.Precision = 0;
            _TestCode.Scale = 0;
            cmd.Parameters.Add(_TestCode);
            System.Data.SqlClient.SqlParameter _Page = new System.Data.SqlClient.SqlParameter();
            _Page.ParameterName = "@Page";
            _Page.Size = -1;
            _Page.Value = Page;
            _Page.Precision = 10;
            _Page.Scale = 0;
            cmd.Parameters.Add(_Page);
            System.Data.SqlClient.SqlParameter _Size = new System.Data.SqlClient.SqlParameter();
            _Size.ParameterName = "@Size";
            _Size.Size = -1;
            _Size.Value = Size;
            _Size.Precision = 10;
            _Size.Scale = 0;
            cmd.Parameters.Add(_Size);
            return cmd;

        }



    public static System.Data.SqlClient.SqlCommand pGetSampleCollectionPerson__LIMSAPICommand(string pOrgCode, string pRoleName, int Page, int Size)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetSampleCollectionPerson__LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            _pOrgCode.Precision = 0;
            _pOrgCode.Scale = 0;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _pRoleName = new System.Data.SqlClient.SqlParameter();
            _pRoleName.ParameterName = "@pRoleName";
            _pRoleName.Size = 100;
            _pRoleName.Value = pRoleName;
            _pRoleName.Precision = 0;
            _pRoleName.Scale = 0;
            cmd.Parameters.Add(_pRoleName);
            System.Data.SqlClient.SqlParameter _Page = new System.Data.SqlClient.SqlParameter();
            _Page.ParameterName = "@Page";
            _Page.Size = -1;
            _Page.Value = Page;
            _Page.Precision = 10;
            _Page.Scale = 0;
            cmd.Parameters.Add(_Page);
            System.Data.SqlClient.SqlParameter _Size = new System.Data.SqlClient.SqlParameter();
            _Size.ParameterName = "@Size";
            _Size.Size = -1;
            _Size.Value = Size;
            _Size.Precision = 10;
            _Size.Scale = 0;
            cmd.Parameters.Add(_Size);
            return cmd;
        }

        public static System.Data.SqlClient.SqlCommand pGetInfectionTestResult_LIMSAPICommand(string pOrgCode, System.DateTime pDateRange, string pPatientNumber, string pVisitNumber, int Page, int Size)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetInfectionTestResult_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            _pOrgCode.Precision = 0;
            _pOrgCode.Scale = 0;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _pDateRange = new System.Data.SqlClient.SqlParameter();
            _pDateRange.ParameterName = "@pDateRange";
            _pDateRange.Size = -1;
            _pDateRange.Value = pDateRange;
            _pDateRange.Precision = 0;
            _pDateRange.Scale = 0;
            cmd.Parameters.Add(_pDateRange);
            System.Data.SqlClient.SqlParameter _pPatientNumber = new System.Data.SqlClient.SqlParameter();
            _pPatientNumber.ParameterName = "@pPatientNumber";
            _pPatientNumber.Size = 50;
            _pPatientNumber.Value = pPatientNumber;
            _pPatientNumber.Precision = 0;
            _pPatientNumber.Scale = 0;
            cmd.Parameters.Add(_pPatientNumber);
            System.Data.SqlClient.SqlParameter _pVisitNumber = new System.Data.SqlClient.SqlParameter();
            _pVisitNumber.ParameterName = "@pVisitNumber";
            _pVisitNumber.Size = 50;
            _pVisitNumber.Value = pVisitNumber;
            _pVisitNumber.Precision = 0;
            _pVisitNumber.Scale = 0;
            cmd.Parameters.Add(_pVisitNumber);
            System.Data.SqlClient.SqlParameter _Page = new System.Data.SqlClient.SqlParameter();
            _Page.ParameterName = "@Page";
            _Page.Size = -1;
            _Page.Value = Page;
            _Page.Precision = 10;
            _Page.Scale = 0;
            cmd.Parameters.Add(_Page);
            System.Data.SqlClient.SqlParameter _Size = new System.Data.SqlClient.SqlParameter();
            _Size.ParameterName = "@Size";
            _Size.Size = -1;
            _Size.Value = Size;
            _Size.Precision = 10;
            _Size.Scale = 0;
            cmd.Parameters.Add(_Size);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetClientName_LIMSAPICommand(string pOrgCode, int Page, int Size)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetClientName_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            _pOrgCode.Precision = 0;
            _pOrgCode.Scale = 0;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _Page = new System.Data.SqlClient.SqlParameter();
            _Page.ParameterName = "@Page";
            _Page.Size = -1;
            _Page.Value = Page;
            _Page.Precision = 10;
            _Page.Scale = 0;
            cmd.Parameters.Add(_Page);
            System.Data.SqlClient.SqlParameter _Size = new System.Data.SqlClient.SqlParameter();
            _Size.ParameterName = "@Size";
            _Size.Size = -1;
            _Size.Value = Size;
            _Size.Precision = 10;
            _Size.Scale = 0;
            cmd.Parameters.Add(_Size);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetPatientInfo__LIMSAPICommand(string pOrgCode, string pPatientNumber, DateTime pRegistereddate, int Page, int Size)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetPatientInfo__LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            _pOrgCode.Precision = 0;
            _pOrgCode.Scale = 0;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _pPatientNumber = new System.Data.SqlClient.SqlParameter();
            _pPatientNumber.ParameterName = "@pPatientNumber";
            _pPatientNumber.Size = 100;
            _pPatientNumber.Value = pPatientNumber;
            _pPatientNumber.Precision = 0;
            _pPatientNumber.Scale = 0;
            cmd.Parameters.Add(_pPatientNumber);
            System.Data.SqlClient.SqlParameter _pRegistereddate = new System.Data.SqlClient.SqlParameter();
            _pRegistereddate.ParameterName = "@pRegistereddate";
            _pRegistereddate.Size = -1;
            _pRegistereddate.Value = pRegistereddate;
            _pRegistereddate.Precision = 0;
            _pRegistereddate.Scale = 0;
            cmd.Parameters.Add(_pRegistereddate);
            System.Data.SqlClient.SqlParameter _Page = new System.Data.SqlClient.SqlParameter();
            _Page.ParameterName = "@Page";
            _Page.Size = -1;
            _Page.Value = Page;
            _Page.Precision = 10;
            _Page.Scale = 0;
            cmd.Parameters.Add(_Page);
            System.Data.SqlClient.SqlParameter _Size = new System.Data.SqlClient.SqlParameter();
            _Size.ParameterName = "@Size";
            _Size.Size = -1;
            _Size.Value = Size;
            _Size.Precision = 10;
            _Size.Scale = 0;
            cmd.Parameters.Add(_Size);
            return cmd;
        }

        public static System.Data.SqlClient.SqlCommand pInsertBookingInfo_LIMSAPICommand(string pOrgCode, string pType, System.Data.DataTable BookingStatus, System.Data.DataTable Payment, System.Data.DataTable TestInfo, out string pOutResult)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pInsertBookingInfo_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 150;
            _pOrgCode.Value = pOrgCode;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _pType = new System.Data.SqlClient.SqlParameter();
            _pType.ParameterName = "@pType";
            _pType.Size = 150;
            _pType.Value = pType;
            cmd.Parameters.Add(_pType);
            System.Data.SqlClient.SqlParameter _BookingStatus = new System.Data.SqlClient.SqlParameter();
            _BookingStatus.ParameterName = "@BookingStatus";
            _BookingStatus.Size = -1;
            _BookingStatus.Value = BookingStatus;
            cmd.Parameters.Add(_BookingStatus);
            System.Data.SqlClient.SqlParameter _Payment = new System.Data.SqlClient.SqlParameter();
            _Payment.ParameterName = "@Payment";
            _Payment.Size = -1;
            _Payment.Value = Payment;
            cmd.Parameters.Add(_Payment);
            System.Data.SqlClient.SqlParameter _TestInfo = new System.Data.SqlClient.SqlParameter();
            _TestInfo.ParameterName = "@TestInfo";
            _TestInfo.Size = -1;
            _TestInfo.Value = TestInfo;
            cmd.Parameters.Add(_TestInfo);
            pOutResult = null;
            System.Data.SqlClient.SqlParameter _pOutResult = new System.Data.SqlClient.SqlParameter();
            _pOutResult.ParameterName = "@pOutResult";
            _pOutResult.Size = 250;
            _pOutResult.Value = pOutResult;
            cmd.Parameters.Add(_pOutResult);
            _pOutResult.Direction = ParameterDirection.Output;
            pOutResult = ((string)(_pOutResult.Value));
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pInsertInfectionTestResultInfo_LIMSAPICommand(string pOrgCode, string pType, System.Data.DataTable pInfectionTestResultInfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pInsertInfectionTestResultInfo_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 150;
            _pOrgCode.Value = pOrgCode;
            _pOrgCode.Precision = 0;
            _pOrgCode.Scale = 0;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _pType = new System.Data.SqlClient.SqlParameter();
            _pType.ParameterName = "@pType";
            _pType.Size = 150;
            _pType.Value = pType;
            _pType.Precision = 0;
            _pType.Scale = 0;
            cmd.Parameters.Add(_pType);
            System.Data.SqlClient.SqlParameter _pInfectionTestResultInfo = new System.Data.SqlClient.SqlParameter();
            _pInfectionTestResultInfo.ParameterName = "@pInfectionTestResultInfo";
            _pInfectionTestResultInfo.Size = -1;
            _pInfectionTestResultInfo.Value = pInfectionTestResultInfo;
            _pInfectionTestResultInfo.Precision = 0;
            _pInfectionTestResultInfo.Scale = 0;
            cmd.Parameters.Add(_pInfectionTestResultInfo);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pInsertPatientRegOrder_LIMSAPICommand(string pOrgCode, string pType, System.Data.DataTable pPatientRegOrderInfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pInsertPatientRegOrder_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 150;
            _pOrgCode.Value = pOrgCode;
            _pOrgCode.Precision = 0;
            _pOrgCode.Scale = 0;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _pType = new System.Data.SqlClient.SqlParameter();
            _pType.ParameterName = "@pType";
            _pType.Size = 150;
            _pType.Value = pType;
            _pType.Precision = 0;
            _pType.Scale = 0;
            cmd.Parameters.Add(_pType);
            System.Data.SqlClient.SqlParameter _pPatientRegOrderInfo = new System.Data.SqlClient.SqlParameter();
            _pPatientRegOrderInfo.ParameterName = "@pPatientRegOrderInfo";
            _pPatientRegOrderInfo.Size = -1;
            _pPatientRegOrderInfo.Value = pPatientRegOrderInfo;
            _pPatientRegOrderInfo.Precision = 0;
            _pPatientRegOrderInfo.Scale = 0;
            cmd.Parameters.Add(_pPatientRegOrderInfo);
            return cmd;
        }
        //API END
        #endregion

        #region //Pirama
        public static System.Data.SqlClient.SqlCommand pGetLocality_LIMSAPICommand(string pOrgCode, string pCategoryCode, string pText, int Page, int Size)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetLocality_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _pCategoryCode = new System.Data.SqlClient.SqlParameter();
            _pCategoryCode.ParameterName = "@pCategoryCode";
            _pCategoryCode.Size = 100;
            _pCategoryCode.Value = pCategoryCode;
            cmd.Parameters.Add(_pCategoryCode);
            System.Data.SqlClient.SqlParameter _pText = new System.Data.SqlClient.SqlParameter();
            _pText.ParameterName = "@pText";
            _pText.Size = 50;
            _pText.Value = pText;
            cmd.Parameters.Add(_pText);
            System.Data.SqlClient.SqlParameter _Page = new System.Data.SqlClient.SqlParameter();
            _Page.ParameterName = "@Page";
            _Page.Size = -1;
            _Page.Value = Page;
            cmd.Parameters.Add(_Page);
            System.Data.SqlClient.SqlParameter _Size = new System.Data.SqlClient.SqlParameter();
            _Size.ParameterName = "@Size";
            _Size.Size = -1;
            _Size.Value = Size;
            cmd.Parameters.Add(_Size);
            return cmd;
        }

        public static System.Data.SqlClient.SqlCommand pGetNewBookingDetails_LIMSAPICommand(long pUserID, System.DateTime pDateRange, string pOrgCode)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetNewBookingDetails_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pUserID = new System.Data.SqlClient.SqlParameter();
            _pUserID.ParameterName = "@pUserID";
            _pUserID.Size = -1;
            _pUserID.Value = pUserID;
            cmd.Parameters.Add(_pUserID);
            System.Data.SqlClient.SqlParameter _pDateRange = new System.Data.SqlClient.SqlParameter();
            _pDateRange.ParameterName = "@pDateRange";
            _pDateRange.Size = -1;
            _pDateRange.Value = pDateRange;
            cmd.Parameters.Add(_pDateRange);
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            cmd.Parameters.Add(_pOrgCode);
            return cmd;
        }

        public static System.Data.SqlClient.SqlCommand pGetVisitstatus_LIMSAPICommand(string pOrgCode, int pBookingID, string pVisitNumber)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetVisitstatus_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _pBookingID = new System.Data.SqlClient.SqlParameter();
            _pBookingID.ParameterName = "@pBookingID";
            _pBookingID.Size = -1;
            _pBookingID.Value = pBookingID;
            cmd.Parameters.Add(_pBookingID);
            System.Data.SqlClient.SqlParameter _pVisitNumber = new System.Data.SqlClient.SqlParameter();
            _pVisitNumber.ParameterName = "@pVisitNumber";
            _pVisitNumber.Size = 100;
            _pVisitNumber.Value = pVisitNumber;
            cmd.Parameters.Add(_pVisitNumber);
            return cmd;
        }

        public static System.Data.SqlClient.SqlCommand pInsertPatientInBound_LIMSAPICommand(string pOrgCode, string pType, System.Data.DataTable pPatientInBound)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pInsertPatientInBound_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _pType = new System.Data.SqlClient.SqlParameter();
            _pType.ParameterName = "@pType";
            _pType.Size = 150;
            _pType.Value = pType;
            cmd.Parameters.Add(_pType);
            System.Data.SqlClient.SqlParameter _pPatientInBound = new System.Data.SqlClient.SqlParameter();
            _pPatientInBound.ParameterName = "@pPatientInBound";
            _pPatientInBound.Size = -1;
            _pPatientInBound.Value = pPatientInBound;
            cmd.Parameters.Add(_pPatientInBound);
            return cmd;
        }

        public static System.Data.SqlClient.SqlCommand pUpdateBookings_LIMSAPICommand(string pOrgCode, string pType, System.Data.DataTable BookingStatus, System.Data.DataTable Payment, System.Data.DataTable TestInfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pUpdateBookings_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _pType = new System.Data.SqlClient.SqlParameter();
            _pType.ParameterName = "@pType";
            _pType.Size = 150;
            _pType.Value = pType;
            cmd.Parameters.Add(_pType);
            System.Data.SqlClient.SqlParameter _BookingStatus = new System.Data.SqlClient.SqlParameter();
            _BookingStatus.ParameterName = "@BookingStatus";
            _BookingStatus.Size = -1;
            _BookingStatus.Value = BookingStatus;
            cmd.Parameters.Add(_BookingStatus);
            System.Data.SqlClient.SqlParameter _Payment = new System.Data.SqlClient.SqlParameter();
            _Payment.ParameterName = "@Payment";
            _Payment.Size = -1;
            _Payment.Value = Payment;
            cmd.Parameters.Add(_Payment);
            System.Data.SqlClient.SqlParameter _TestInfo = new System.Data.SqlClient.SqlParameter();
            _TestInfo.ParameterName = "@TestInfo";
            _TestInfo.Size = -1;
            _TestInfo.Value = TestInfo;
            cmd.Parameters.Add(_TestInfo);
            return cmd;
        }

        public static System.Data.SqlClient.SqlCommand pInsertLiveLocation_LIMSAPICommand(string pOrgCode, string pType, System.Data.DataTable pHCLiveLocation)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pInsertLiveLocation_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _pType = new System.Data.SqlClient.SqlParameter();
            _pType.ParameterName = "@pType";
            _pType.Size = 150;
            _pType.Value = pType;
            cmd.Parameters.Add(_pType);
            System.Data.SqlClient.SqlParameter _pHCLiveLocation = new System.Data.SqlClient.SqlParameter();
            _pHCLiveLocation.ParameterName = "@pHCLiveLocation";
            _pHCLiveLocation.Size = -1;
            _pHCLiveLocation.Value = pHCLiveLocation;
            cmd.Parameters.Add(_pHCLiveLocation);
            return cmd;
        }

        public static System.Data.SqlClient.SqlCommand pGetOrgLocation_LIMSAPICommand(string pOrgCode, string pCategoryCode)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetOrgLocation_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _pCategoryCode = new System.Data.SqlClient.SqlParameter();
            _pCategoryCode.ParameterName = "@pCategoryCode";
            _pCategoryCode.Size = 100;
            _pCategoryCode.Value = pCategoryCode;
            cmd.Parameters.Add(_pCategoryCode);
            return cmd;
        }

        public static System.Data.SqlClient.SqlCommand pGetAttachmentName_LIMSAPICommand(string pOrgCode, long pBookingID, string pVisitNumber)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetAttachmentName_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _pBookingID = new System.Data.SqlClient.SqlParameter();
            _pBookingID.ParameterName = "@pBookingID";
            _pBookingID.Size = -1;
            _pBookingID.Value = pBookingID;
            cmd.Parameters.Add(_pBookingID);
            System.Data.SqlClient.SqlParameter _pVisitNumber = new System.Data.SqlClient.SqlParameter();
            _pVisitNumber.ParameterName = "@pVisitNumber";
            _pVisitNumber.Size = 50;
            _pVisitNumber.Value = pVisitNumber;
            cmd.Parameters.Add(_pVisitNumber);
            return cmd;
        }
        #endregion

        #region //Abhishek
        public static System.Data.SqlClient.SqlCommand PGetPhysicianName_LIMSAPICommand(string pOrgCode, int Page, int Size)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "PGetPhysicianName_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _Page = new System.Data.SqlClient.SqlParameter();
            _Page.ParameterName = "@Page";
            _Page.Size = -1;
            _Page.Value = Page;
            cmd.Parameters.Add(_Page);
            System.Data.SqlClient.SqlParameter _Size = new System.Data.SqlClient.SqlParameter();
            _Size.ParameterName = "@Size";
            _Size.Size = -1;
            _Size.Value = Size;
            cmd.Parameters.Add(_Size);
            return cmd;
        }

        public static System.Data.SqlClient.SqlCommand pGetOrderInformation_LIMSAPICommand(string pOrgCode, System.DateTime pDateRange, string pPatientNumber, string pVisitNumber, int Page, int Size)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetOrderInformation_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _pDateRange = new System.Data.SqlClient.SqlParameter();
            _pDateRange.ParameterName = "@pDateRange";
            _pDateRange.Size = -1;
            _pDateRange.Value = pDateRange;
            cmd.Parameters.Add(_pDateRange);
            System.Data.SqlClient.SqlParameter _pPatientNumber = new System.Data.SqlClient.SqlParameter();
            _pPatientNumber.ParameterName = "@pPatientNumber";
            _pPatientNumber.Size = 50;
            _pPatientNumber.Value = pPatientNumber;
            cmd.Parameters.Add(_pPatientNumber);
            System.Data.SqlClient.SqlParameter _pVisitNumber = new System.Data.SqlClient.SqlParameter();
            _pVisitNumber.ParameterName = "@pVisitNumber";
            _pVisitNumber.Size = 50;
            _pVisitNumber.Value = pVisitNumber;
            cmd.Parameters.Add(_pVisitNumber);
            System.Data.SqlClient.SqlParameter _Page = new System.Data.SqlClient.SqlParameter();
            _Page.ParameterName = "@Page";
            _Page.Size = -1;
            _Page.Value = Page;
            cmd.Parameters.Add(_Page);
            System.Data.SqlClient.SqlParameter _Size = new System.Data.SqlClient.SqlParameter();
            _Size.ParameterName = "@Size";
            _Size.Size = -1;
            _Size.Value = Size;
            cmd.Parameters.Add(_Size);
            return cmd;
        }

        public static System.Data.SqlClient.SqlCommand pGetVisitInformation_LIMSAPICommand(string pOrgCode, int pBookingID)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetVisitInformation_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _pBookingID = new System.Data.SqlClient.SqlParameter();
            _pBookingID.ParameterName = "@pBookingID";
            _pBookingID.Size = -1;
            _pBookingID.Value = pBookingID;
            cmd.Parameters.Add(_pBookingID);
            return cmd;
        }

        public static System.Data.SqlClient.SqlCommand pGetPatientResult_LIMSAPICommand(string pOrgCode, int pBookingID, string pVisitNumber)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetPatientResult_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _pBookingID = new System.Data.SqlClient.SqlParameter();
            _pBookingID.ParameterName = "@pBookingID";
            _pBookingID.Size = -1;
            _pBookingID.Value = pBookingID;
            cmd.Parameters.Add(_pBookingID);
            System.Data.SqlClient.SqlParameter _pVisitNumber = new System.Data.SqlClient.SqlParameter();
            _pVisitNumber.ParameterName = "@pVisitNumber";
            _pVisitNumber.Size = 100;
            _pVisitNumber.Value = pVisitNumber;
            cmd.Parameters.Add(_pVisitNumber);
            return cmd;
        }

        public static System.Data.SqlClient.SqlCommand pUpdateTripStatus_LIMSAPICommand(string pOrgCode, string pType, System.Data.DataTable pTripStatusInfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pUpdateTripStatus_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 150;
            _pOrgCode.Value = pOrgCode;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _pType = new System.Data.SqlClient.SqlParameter();
            _pType.ParameterName = "@pType";
            _pType.Size = 150;
            _pType.Value = pType;
            cmd.Parameters.Add(_pType);
            System.Data.SqlClient.SqlParameter _pTripStatusInfo = new System.Data.SqlClient.SqlParameter();
            _pTripStatusInfo.ParameterName = "@pTripStatusInfo";
            _pTripStatusInfo.Size = -1;
            _pTripStatusInfo.Value = pTripStatusInfo;
            cmd.Parameters.Add(_pTripStatusInfo);
            return cmd;
        }

        #endregion

        public static System.Data.SqlClient.SqlCommand pInsertTRFHCDetailsCommand(string pOrgCode, string FileName, long BookingID, string ExternalRefNo, long IdentifyingID, string IdentifyingType, string SourceType, string FilePath)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pInsertTRFHCDetails";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            _pOrgCode.Precision = 0;
            _pOrgCode.Scale = 0;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _FileName = new System.Data.SqlClient.SqlParameter();
            _FileName.ParameterName = "@FileName";
            _FileName.Size = 300;
            _FileName.Value = FileName;
            _FileName.Precision = 0;
            _FileName.Scale = 0;
            cmd.Parameters.Add(_FileName);
            System.Data.SqlClient.SqlParameter _BookingID = new System.Data.SqlClient.SqlParameter();
            _BookingID.ParameterName = "@BookingID";
            _BookingID.Size = -1;
            _BookingID.Value = BookingID;
            _BookingID.Precision = 19;
            _BookingID.Scale = 0;
            cmd.Parameters.Add(_BookingID);
            System.Data.SqlClient.SqlParameter _ExternalRefNo = new System.Data.SqlClient.SqlParameter();
            _ExternalRefNo.ParameterName = "@ExternalRefNo";
            _ExternalRefNo.Size = 300;
            _ExternalRefNo.Value = ExternalRefNo;
            _ExternalRefNo.Precision = 0;
            _ExternalRefNo.Scale = 0;
            cmd.Parameters.Add(_ExternalRefNo);
            System.Data.SqlClient.SqlParameter _IdentifyingID = new System.Data.SqlClient.SqlParameter();
            _IdentifyingID.ParameterName = "@IdentifyingID";
            _IdentifyingID.Size = -1;
            _IdentifyingID.Value = IdentifyingID;
            _IdentifyingID.Precision = 19;
            _IdentifyingID.Scale = 0;
            cmd.Parameters.Add(_IdentifyingID);
            System.Data.SqlClient.SqlParameter _IdentifyingType = new System.Data.SqlClient.SqlParameter();
            _IdentifyingType.ParameterName = "@IdentifyingType";
            _IdentifyingType.Size = 250;
            _IdentifyingType.Value = IdentifyingType;
            _IdentifyingType.Precision = 0;
            _IdentifyingType.Scale = 0;
            cmd.Parameters.Add(_IdentifyingType);
            System.Data.SqlClient.SqlParameter _SourceType = new System.Data.SqlClient.SqlParameter();
            _SourceType.ParameterName = "@SourceType";
            _SourceType.Size = 250;
            _SourceType.Value = SourceType;
            _SourceType.Precision = 0;
            _SourceType.Scale = 0;
            cmd.Parameters.Add(_SourceType);
            System.Data.SqlClient.SqlParameter _FilePath = new System.Data.SqlClient.SqlParameter();
            _FilePath.ParameterName = "@FilePath";
            _FilePath.Size = -1;
            _FilePath.Value = FilePath;
            _FilePath.Precision = 0;
            _FilePath.Scale = 0;
            cmd.Parameters.Add(_FilePath);
            return cmd;
        }

        public static System.Data.SqlClient.SqlCommand pGetConfigHCDetailsCommand(string pOrgCode, string pConfigKey)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetConfigHCDetails";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            _pOrgCode.Precision = 0;
            _pOrgCode.Scale = 0;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _pConfigKey = new System.Data.SqlClient.SqlParameter();
            _pConfigKey.ParameterName = "@pConfigKey";
            _pConfigKey.Size = 50;
            _pConfigKey.Value = pConfigKey;
            _pConfigKey.Precision = 0;
            _pConfigKey.Scale = 0;
            cmd.Parameters.Add(_pConfigKey);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pInsertRegisterOrder_LIMSAPICommand(string pOrgCode, string pType, System.Data.DataTable pRegisterOrderInfo, System.Data.DataTable Payment, System.Data.DataTable TestInfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pInsertRegisterOrder_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 150;
            _pOrgCode.Value = pOrgCode;
            _pOrgCode.Precision = 0;
            _pOrgCode.Scale = 0;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _pType = new System.Data.SqlClient.SqlParameter();
            _pType.ParameterName = "@pType";
            _pType.Size = 150;
            _pType.Value = pType;
            _pType.Precision = 0;
            _pType.Scale = 0;
            cmd.Parameters.Add(_pType);
            System.Data.SqlClient.SqlParameter _pRegisterOrderInfo = new System.Data.SqlClient.SqlParameter();
            _pRegisterOrderInfo.ParameterName = "@pRegisterOrderInfo";
            _pRegisterOrderInfo.Size = -1;
            _pRegisterOrderInfo.Value = pRegisterOrderInfo;
            _pRegisterOrderInfo.Precision = 0;
            _pRegisterOrderInfo.Scale = 0;
            cmd.Parameters.Add(_pRegisterOrderInfo);
            System.Data.SqlClient.SqlParameter _Payment = new System.Data.SqlClient.SqlParameter();
            _Payment.ParameterName = "@Payment";
            _Payment.Size = -1;
            _Payment.Value = Payment;
            _Payment.Precision = 0;
            _Payment.Scale = 0;
            cmd.Parameters.Add(_Payment);
            System.Data.SqlClient.SqlParameter _TestInfo = new System.Data.SqlClient.SqlParameter();
            _TestInfo.ParameterName = "@TestInfo";
            _TestInfo.Size = -1;
            _TestInfo.Value = TestInfo;
            _TestInfo.Precision = 0;
            _TestInfo.Scale = 0;
            cmd.Parameters.Add(_TestInfo);
            return cmd;
        }

        #region //Seetha
		
 public static System.Data.SqlClient.SqlCommand PSaveClientMaster_LIMSAPICommand(System.Data.DataTable pClientDetails, System.Data.DataTable pAddressDetails, string pOrgCode, string pJsonValue)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "PSaveClientMaster_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pClientDetails = new System.Data.SqlClient.SqlParameter();
            _pClientDetails.ParameterName = "@pClientDetails";
            _pClientDetails.Size = -1;
            _pClientDetails.Value = pClientDetails;
            cmd.Parameters.Add(_pClientDetails);
            System.Data.SqlClient.SqlParameter _pAddressDetails = new System.Data.SqlClient.SqlParameter();
            _pAddressDetails.ParameterName = "@pAddressDetails";
            _pAddressDetails.Size = -1;
            _pAddressDetails.Value = pAddressDetails;
            cmd.Parameters.Add(_pAddressDetails);
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _pJsonValue = new System.Data.SqlClient.SqlParameter();
            _pJsonValue.ParameterName = "@pJsonValue";
            _pJsonValue.Size = -1;
            _pJsonValue.Value = pJsonValue;
            cmd.Parameters.Add(_pJsonValue);
            return cmd;
        }
   public static System.Data.SqlClient.SqlCommand pGetRateCardDetails__LIMSAPICommand(string pOrgCode, int Page, int Size)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetRateCardDetails__LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _Page = new System.Data.SqlClient.SqlParameter();
            _Page.ParameterName = "@Page";
            _Page.Size = -1;
            _Page.Value = Page;
            cmd.Parameters.Add(_Page);
            System.Data.SqlClient.SqlParameter _Size = new System.Data.SqlClient.SqlParameter();
            _Size.ParameterName = "@Size";
            _Size.Size = -1;
            _Size.Value = Size;
            cmd.Parameters.Add(_Size);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand PUpdateTestStatus_LIMSAPICommand(string OrderId, string pOrgCode, System.Data.DataTable pOrdersDetails, string pJsonValue)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "PUpdateTestStatus_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _OrderId = new System.Data.SqlClient.SqlParameter();
            _OrderId.ParameterName = "@OrderId";
            _OrderId.Size = 100;
            _OrderId.Value = OrderId;
            cmd.Parameters.Add(_OrderId);
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _pOrdersDetails = new System.Data.SqlClient.SqlParameter();
            _pOrdersDetails.ParameterName = "@pOrdersDetails";
            _pOrdersDetails.Size = -1;
            _pOrdersDetails.Value = pOrdersDetails;
            cmd.Parameters.Add(_pOrdersDetails);
            System.Data.SqlClient.SqlParameter _pJsonValue = new System.Data.SqlClient.SqlParameter();
            _pJsonValue.ParameterName = "@pJsonValue";
            _pJsonValue.Size = -1;
            _pJsonValue.Value = pJsonValue;
            cmd.Parameters.Add(_pJsonValue);
            return cmd;
        }

        #endregion
        public static System.Data.SqlClient.SqlCommand pGetPhleboBookingDetails_LIMSAPICommand(long pBookingID, long pUserID, string pOrgCode)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetPhleboBookingDetails_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pBookingID = new System.Data.SqlClient.SqlParameter();
            _pBookingID.ParameterName = "@pBookingID";
            _pBookingID.Size = -1;
            _pBookingID.Value = pBookingID;
            _pBookingID.Precision = 19;
            _pBookingID.Scale = 0;
            cmd.Parameters.Add(_pBookingID);
            System.Data.SqlClient.SqlParameter _pUserID = new System.Data.SqlClient.SqlParameter();
            _pUserID.ParameterName = "@pUserID";
            _pUserID.Size = -1;
            _pUserID.Value = pUserID;
            _pUserID.Precision = 19;
            _pUserID.Scale = 0;
            cmd.Parameters.Add(_pUserID);
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            _pOrgCode.Precision = 0;
            _pOrgCode.Scale = 0;
            cmd.Parameters.Add(_pOrgCode);
            return cmd;
        }
		public static System.Data.SqlClient.SqlCommand pGetPatientOrderDetails_LIMSAPICommand(string MessageType, string OrgCode)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetPatientOrderDetails_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _MessageType = new System.Data.SqlClient.SqlParameter();
            _MessageType.ParameterName = "@MessageType";
            _MessageType.Size = 20;
            _MessageType.Value = MessageType;
            cmd.Parameters.Add(_MessageType);
            System.Data.SqlClient.SqlParameter _OrgCode = new System.Data.SqlClient.SqlParameter();
            _OrgCode.ParameterName = "@OrgCode";
            _OrgCode.Size = 100;
            _OrgCode.Value = OrgCode;
            cmd.Parameters.Add(_OrgCode);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetPatientResultDetails_LIMSAPICommand(string pOrgCode)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetPatientResultDetails_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            cmd.Parameters.Add(_pOrgCode);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetPackageMasterDetails_LIMSAPICommand(string pOrgCode, string TestCode, int Page, int Size)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetPackageMasterDetails_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _TestCode = new System.Data.SqlClient.SqlParameter();
            _TestCode.ParameterName = "@TestCode";
            _TestCode.Size = 100;
            _TestCode.Value = TestCode;
            cmd.Parameters.Add(_TestCode);
            System.Data.SqlClient.SqlParameter _Page = new System.Data.SqlClient.SqlParameter();
            _Page.ParameterName = "@Page";
            _Page.Size = -1;
            _Page.Value = Page;
            cmd.Parameters.Add(_Page);
            System.Data.SqlClient.SqlParameter _Size = new System.Data.SqlClient.SqlParameter();
            _Size.ParameterName = "@Size";
            _Size.Size = -1;
            _Size.Value = Size;
            cmd.Parameters.Add(_Size);
            return cmd;
        }
		
		 public static System.Data.SqlClient.SqlCommand pGetPatientOrderStatusDetails_LIMSAPICommand(string pOrgCode)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetPatientOrderStatusDetails_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            cmd.Parameters.Add(_pOrgCode);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetPatientOrderSampleStatusDetails_LIMSAPICommand(string pOrgCode)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetPatientOrderSampleStatusDetails_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            cmd.Parameters.Add(_pOrgCode);
            return cmd;
        }
        #region StockManagemant

        public static System.Data.SqlClient.SqlCommand pInsertStockReceived_LIMSAPICommand(string OrgCode, long ReceiptID, System.DateTime ReceiptDate, string FromLocationCode, string ToLocationCode, out string outSRDNo, System.Data.DataTable pInventoryItemsMappingType)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pInsertStockReceived_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _OrgCode = new System.Data.SqlClient.SqlParameter();
            _OrgCode.ParameterName = "@OrgCode";
            _OrgCode.Size = 50;
            _OrgCode.Value = OrgCode;
            cmd.Parameters.Add(_OrgCode);
            System.Data.SqlClient.SqlParameter _ReceiptID = new System.Data.SqlClient.SqlParameter();
            _ReceiptID.ParameterName = "@ReceiptID";
            _ReceiptID.Size = -1;
            _ReceiptID.Value = ReceiptID;
            cmd.Parameters.Add(_ReceiptID);
            System.Data.SqlClient.SqlParameter _ReceiptDate = new System.Data.SqlClient.SqlParameter();
            _ReceiptDate.ParameterName = "@ReceiptDate";
            _ReceiptDate.Size = -1;
            _ReceiptDate.Value = ReceiptDate;
            cmd.Parameters.Add(_ReceiptDate);
            System.Data.SqlClient.SqlParameter _FromLocationCode = new System.Data.SqlClient.SqlParameter();
            _FromLocationCode.ParameterName = "@FromLocationCode";
            _FromLocationCode.Size = 50;
            _FromLocationCode.Value = FromLocationCode;
            cmd.Parameters.Add(_FromLocationCode);
            System.Data.SqlClient.SqlParameter _ToLocationCode = new System.Data.SqlClient.SqlParameter();
            _ToLocationCode.ParameterName = "@ToLocationCode";
            _ToLocationCode.Size = 50;
            _ToLocationCode.Value = ToLocationCode;
            cmd.Parameters.Add(_ToLocationCode);
            outSRDNo = null;
            System.Data.SqlClient.SqlParameter _outSRDNo = new System.Data.SqlClient.SqlParameter();
            _outSRDNo.ParameterName = "@outSRDNo";
            _outSRDNo.Size = 50;
            _outSRDNo.Value = outSRDNo;
            cmd.Parameters.Add(_outSRDNo);
            _outSRDNo.Direction = ParameterDirection.Output;
            System.Data.SqlClient.SqlParameter _pInventoryItemsMappingType = new System.Data.SqlClient.SqlParameter();
            _pInventoryItemsMappingType.ParameterName = "@pInventoryItemsMappingType";
            _pInventoryItemsMappingType.Size = -1;
            _pInventoryItemsMappingType.Value = pInventoryItemsMappingType;
            cmd.Parameters.Add(_pInventoryItemsMappingType);
            outSRDNo = ((string)(_outSRDNo.Value));
            return cmd;
        }

        public static System.Data.SqlClient.SqlCommand pGetStockOutProductIntegaration_LIMSCommand(string OrgCode)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetStockOutProductIntegaration_LIMS";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _OrgCode = new System.Data.SqlClient.SqlParameter();
            _OrgCode.ParameterName = "@OrgCode";
            _OrgCode.Size = 100;
            _OrgCode.Value = OrgCode;
            cmd.Parameters.Add(_OrgCode);
            return cmd;
        }

        public static System.Data.SqlClient.SqlCommand pGetProductIntegarationItems_LIMSCommand(string OrgCode)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetProductIntegarationItems_LIMS";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _OrgCode = new System.Data.SqlClient.SqlParameter();
            _OrgCode.ParameterName = "@OrgCode";
            _OrgCode.Size = 100;
            _OrgCode.Value = OrgCode;
            cmd.Parameters.Add(_OrgCode);
            return cmd;
        }

        public static System.Data.SqlClient.SqlCommand PGetConsumptionProductMappingItems_LIMSCommand(string OrgCode)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "PGetConsumptionProductMappingItems_LIMS";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _OrgCode = new System.Data.SqlClient.SqlParameter();
            _OrgCode.ParameterName = "@OrgCode";
            _OrgCode.Size = 100;
            _OrgCode.Value = OrgCode;
            cmd.Parameters.Add(_OrgCode);
            return cmd;
        }

        public static System.Data.SqlClient.SqlCommand pGetConsumptionReport_LIMSCommand(string LocationCode, string OrgCode)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetConsumptionReport_LIMS";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _LocationCode = new System.Data.SqlClient.SqlParameter();
            _LocationCode.ParameterName = "@LocationCode";
            _LocationCode.Size = 50;
            _LocationCode.Value = LocationCode;
            cmd.Parameters.Add(_LocationCode);
            System.Data.SqlClient.SqlParameter _OrgCode = new System.Data.SqlClient.SqlParameter();
            _OrgCode.ParameterName = "@OrgCode";
            _OrgCode.Size = 100;
            _OrgCode.Value = OrgCode;
            cmd.Parameters.Add(_OrgCode);
            return cmd;
        }
		public static System.Data.SqlClient.SqlCommand pGetLocations_LIMSCommand(string OrgCode)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetLocations_LIMS";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _OrgCode = new System.Data.SqlClient.SqlParameter();
            _OrgCode.ParameterName = "@OrgCode";
            _OrgCode.Size = 100;
            _OrgCode.Value = OrgCode;
            cmd.Parameters.Add(_OrgCode);
            return cmd;
        }
        #endregion
public static System.Data.SqlClient.SqlCommand pGetTestMasterDetails_LIMSAPICommand(string pOrgCode, string TestCode, int Page, int Size)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetTestMasterDetails_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _TestCode = new System.Data.SqlClient.SqlParameter();
            _TestCode.ParameterName = "@TestCode";
            _TestCode.Size = 100;
            _TestCode.Value = TestCode;
            cmd.Parameters.Add(_TestCode);
            System.Data.SqlClient.SqlParameter _Page = new System.Data.SqlClient.SqlParameter();
            _Page.ParameterName = "@Page";
            _Page.Size = -1;
            _Page.Value = Page;
            cmd.Parameters.Add(_Page);
            System.Data.SqlClient.SqlParameter _Size = new System.Data.SqlClient.SqlParameter();
            _Size.ParameterName = "@Size";
            _Size.Size = -1;
            _Size.Value = Size;
            cmd.Parameters.Add(_Size);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetGroupMasterDetails_LIMSAPICommand(string pOrgCode, string TestCode, int Page, int Size)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetGroupMasterDetails_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _TestCode = new System.Data.SqlClient.SqlParameter();
            _TestCode.ParameterName = "@TestCode";
            _TestCode.Size = 100;
            _TestCode.Value = TestCode;
            cmd.Parameters.Add(_TestCode);
            System.Data.SqlClient.SqlParameter _Page = new System.Data.SqlClient.SqlParameter();
            _Page.ParameterName = "@Page";
            _Page.Size = -1;
            _Page.Value = Page;
            cmd.Parameters.Add(_Page);
            System.Data.SqlClient.SqlParameter _Size = new System.Data.SqlClient.SqlParameter();
            _Size.ParameterName = "@Size";
            _Size.Size = -1;
            _Size.Value = Size;
            cmd.Parameters.Add(_Size);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetAttachmentPatientLoginPDF_LIMSAPICommand(string OrgCode, string Type, string LoginName, string Password, string ReferenceNumber)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetAttachmentPatientLoginPDF_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _OrgCode = new System.Data.SqlClient.SqlParameter();
            _OrgCode.ParameterName = "@OrgCode";
            _OrgCode.Size = 50;
            _OrgCode.Value = OrgCode;
            _OrgCode.Precision = 0;
            _OrgCode.Scale = 0;
            cmd.Parameters.Add(_OrgCode);
            System.Data.SqlClient.SqlParameter _Type = new System.Data.SqlClient.SqlParameter();
            _Type.ParameterName = "@Type";
            _Type.Size = 50;
            _Type.Value = Type;
            _Type.Precision = 0;
            _Type.Scale = 0;
            cmd.Parameters.Add(_Type);
            System.Data.SqlClient.SqlParameter _LoginName = new System.Data.SqlClient.SqlParameter();
            _LoginName.ParameterName = "@LoginName";
            _LoginName.Size = 50;
            _LoginName.Value = LoginName;
            _LoginName.Precision = 0;
            _LoginName.Scale = 0;
            cmd.Parameters.Add(_LoginName);
            System.Data.SqlClient.SqlParameter _Password = new System.Data.SqlClient.SqlParameter();
            _Password.ParameterName = "@Password";
            _Password.Size = 50;
            _Password.Value = Password;
            _Password.Precision = 0;
            _Password.Scale = 0;
            cmd.Parameters.Add(_Password);
            System.Data.SqlClient.SqlParameter _ReferenceNumber = new System.Data.SqlClient.SqlParameter();
            _ReferenceNumber.ParameterName = "@ReferenceNumber";
            _ReferenceNumber.Size = 50;
            _ReferenceNumber.Value = ReferenceNumber;
            _ReferenceNumber.Precision = 0;
            _ReferenceNumber.Scale = 0;
            cmd.Parameters.Add(_ReferenceNumber);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand GetPatientLoginPDFOrgAWSfileInfo_LIMSAPICommand(string OrgCode, string Type, string ReferenceNumber)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetPatientLoginPDFOrgAWSfileInfo_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _OrgCode = new System.Data.SqlClient.SqlParameter();
            _OrgCode.ParameterName = "@OrgCode";
            _OrgCode.Size = 50;
            _OrgCode.Value = OrgCode;
            _OrgCode.Precision = 0;
            _OrgCode.Scale = 0;
            cmd.Parameters.Add(_OrgCode);
            System.Data.SqlClient.SqlParameter _Type = new System.Data.SqlClient.SqlParameter();
            _Type.ParameterName = "@Type";
            _Type.Size = 50;
            _Type.Value = Type;
            _Type.Precision = 0;
            _Type.Scale = 0;
            cmd.Parameters.Add(_Type);

            System.Data.SqlClient.SqlParameter _ReferenceNumber = new System.Data.SqlClient.SqlParameter();
            _ReferenceNumber.ParameterName = "@ReferenceNumber";
            _ReferenceNumber.Size = 50;
            _ReferenceNumber.Value = ReferenceNumber;
            _ReferenceNumber.Precision = 0;
            _ReferenceNumber.Scale = 0;
            cmd.Parameters.Add(_ReferenceNumber);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetPatientByDateRange_LIMSAPICommand(string pOrgCode, System.DateTime pFDate, System.DateTime pTDate, string pType)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetPatientByDateRange_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            _pOrgCode.Precision = 0;
            _pOrgCode.Scale = 0;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _pFDate = new System.Data.SqlClient.SqlParameter();
            _pFDate.ParameterName = "@pFDate";
            _pFDate.Size = -1;
            _pFDate.Value = pFDate;
            _pFDate.Precision = 0;
            _pFDate.Scale = 0;
            cmd.Parameters.Add(_pFDate);
            System.Data.SqlClient.SqlParameter _pTDate = new System.Data.SqlClient.SqlParameter();
            _pTDate.ParameterName = "@pTDate";
            _pTDate.Size = -1;
            _pTDate.Value = pTDate;
            _pTDate.Precision = 0;
            _pTDate.Scale = 0;
            cmd.Parameters.Add(_pTDate);
            System.Data.SqlClient.SqlParameter _pType = new System.Data.SqlClient.SqlParameter();
            _pType.ParameterName = "@pType";
            _pType.Size = 150;
            _pType.Value = pType;
            _pType.Precision = 0;
            _pType.Scale = 0;
            cmd.Parameters.Add(_pType);
            return cmd;
        }
        #region //Aaru
        public static System.Data.SqlClient.SqlCommand pOrgBookingStatus_LIMSAPICommand(int OrgID)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetOrgWiseBookingStatus_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _Orgid = new System.Data.SqlClient.SqlParameter();
            _Orgid.ParameterName = "@OrgID";
            _Orgid.Size = 8;
            _Orgid.Value = OrgID;
            cmd.Parameters.Add(_Orgid);

            return cmd;
        }

        #endregion
    
    public static System.Data.SqlClient.SqlCommand pGetClientwiseRevenue_LIMSAPICommand(string pOrgCode, System.DateTime pFDate, System.DateTime pTDate)
    {
        System.Data.SqlClient.SqlCommand cmd;
        cmd = new System.Data.SqlClient.SqlCommand();
        cmd.CommandText = "pGetClientwiseRevenue_LIMSAPI";
        cmd.CommandTimeout = 180;
        cmd.CommandType = CommandType.StoredProcedure;
        System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
        _pOrgCode.ParameterName = "@pOrgCode";
        _pOrgCode.Size = 100;
        _pOrgCode.Value = pOrgCode;
        _pOrgCode.Precision = 0;
        _pOrgCode.Scale = 0;
        cmd.Parameters.Add(_pOrgCode);
        System.Data.SqlClient.SqlParameter _pFDate = new System.Data.SqlClient.SqlParameter();
        _pFDate.ParameterName = "@pFDate";
        _pFDate.Size = -1;
        _pFDate.Value = pFDate;
        _pFDate.Precision = 0;
        _pFDate.Scale = 0;
        cmd.Parameters.Add(_pFDate);
        System.Data.SqlClient.SqlParameter _pTDate = new System.Data.SqlClient.SqlParameter();
        _pTDate.ParameterName = "@pTDate";
        _pTDate.Size = -1;
        _pTDate.Value = pTDate;
        _pTDate.Precision = 0;
        _pTDate.Scale = 0;
        cmd.Parameters.Add(_pTDate);
        return cmd;
    }
    public static System.Data.SqlClient.SqlCommand pGetTestwiseRevenue_LIMSAPICommand(string pOrgCode, System.DateTime pFDate, System.DateTime pTDate)
    {
        System.Data.SqlClient.SqlCommand cmd;
        cmd = new System.Data.SqlClient.SqlCommand();
        cmd.CommandText = "pGetTestwiseRevenue_LIMSAPI";
        cmd.CommandTimeout = 180;
        cmd.CommandType = CommandType.StoredProcedure;
        System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
        _pOrgCode.ParameterName = "@pOrgCode";
        _pOrgCode.Size = 100;
        _pOrgCode.Value = pOrgCode;
        _pOrgCode.Precision = 0;
        _pOrgCode.Scale = 0;
        cmd.Parameters.Add(_pOrgCode);
        System.Data.SqlClient.SqlParameter _pFDate = new System.Data.SqlClient.SqlParameter();
        _pFDate.ParameterName = "@pFDate";
        _pFDate.Size = -1;
        _pFDate.Value = pFDate;
        _pFDate.Precision = 0;
        _pFDate.Scale = 0;
        cmd.Parameters.Add(_pFDate);
        System.Data.SqlClient.SqlParameter _pTDate = new System.Data.SqlClient.SqlParameter();
        _pTDate.ParameterName = "@pTDate";
        _pTDate.Size = -1;
        _pTDate.Value = pTDate;
        _pTDate.Precision = 0;
        _pTDate.Scale = 0;
        cmd.Parameters.Add(_pTDate);
        return cmd;
    }
        public static System.Data.SqlClient.SqlCommand pGetOperationBookingStatus_LIMSAPICommand(string pOrgCode, System.DateTime pFDate, System.DateTime pTDate, string pType)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetOperationBookingStatus_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            _pOrgCode.Precision = 0;
            _pOrgCode.Scale = 0;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _pFDate = new System.Data.SqlClient.SqlParameter();
            _pFDate.ParameterName = "@pFDate";
            _pFDate.Size = -1;
            _pFDate.Value = pFDate;
            _pFDate.Precision = 0;
            _pFDate.Scale = 0;
            cmd.Parameters.Add(_pFDate);
            System.Data.SqlClient.SqlParameter _pTDate = new System.Data.SqlClient.SqlParameter();
            _pTDate.ParameterName = "@pTDate";
            _pTDate.Size = -1;
            _pTDate.Value = pTDate;
            _pTDate.Precision = 0;
            _pTDate.Scale = 0;
            cmd.Parameters.Add(_pTDate);
            System.Data.SqlClient.SqlParameter _pType = new System.Data.SqlClient.SqlParameter();
            _pType.ParameterName = "@pType";
            _pType.Size = 150;
            _pType.Value = pType;
            _pType.Precision = 0;
            _pType.Scale = 0;
            cmd.Parameters.Add(_pType);

            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetPatientPDFbyVisitNo_LIMSAPICommand(string OrgCode, string Type, string ReferenceNumber)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetPatientPDFbyVisitNo_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _OrgCode = new System.Data.SqlClient.SqlParameter();
            _OrgCode.ParameterName = "@OrgCode";
            _OrgCode.Size = 50;
            _OrgCode.Value = OrgCode;
            cmd.Parameters.Add(_OrgCode);
            System.Data.SqlClient.SqlParameter _Type = new System.Data.SqlClient.SqlParameter();
            _Type.ParameterName = "@Type";
            _Type.Size = 50;
            _Type.Value = Type;
            cmd.Parameters.Add(_Type);
            System.Data.SqlClient.SqlParameter _ReferenceNumber = new System.Data.SqlClient.SqlParameter();
            _ReferenceNumber.ParameterName = "@ReferenceNumber";
            _ReferenceNumber.Size = 50;
            _ReferenceNumber.Value = ReferenceNumber;
            cmd.Parameters.Add(_ReferenceNumber);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetTestMasterWithSample_LIMSAPICommand(string pOrgCode, string pType, string TestCode, int Page, int Size)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetTestMasterWithSample_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _pType = new System.Data.SqlClient.SqlParameter();
            _pType.ParameterName = "@pType";
            _pType.Size = 255;
            _pType.Value = pType;
            cmd.Parameters.Add(_pType);
            System.Data.SqlClient.SqlParameter _TestCode = new System.Data.SqlClient.SqlParameter();
            _TestCode.ParameterName = "@TestCode";
            _TestCode.Size = 100;
            _TestCode.Value = TestCode;
            cmd.Parameters.Add(_TestCode);
            System.Data.SqlClient.SqlParameter _Page = new System.Data.SqlClient.SqlParameter();
            _Page.ParameterName = "@Page";
            _Page.Size = -1;
            _Page.Value = Page;
            cmd.Parameters.Add(_Page);
            System.Data.SqlClient.SqlParameter _Size = new System.Data.SqlClient.SqlParameter();
            _Size.ParameterName = "@Size";
            _Size.Size = -1;
            _Size.Value = Size;
            cmd.Parameters.Add(_Size);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pUpdatePatientOrderInvestigation_LIMSAPICommand(string OrgCode, string VisitNumber, string Status)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pUpdatePatientOrderInvestigation_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _OrgCode = new System.Data.SqlClient.SqlParameter();
            _OrgCode.ParameterName = "@OrgCode";
            _OrgCode.Size = 100;
            _OrgCode.Value = OrgCode;
            cmd.Parameters.Add(_OrgCode);
            System.Data.SqlClient.SqlParameter _VisitNumber = new System.Data.SqlClient.SqlParameter();
            _VisitNumber.ParameterName = "@VisitNumber";
            _VisitNumber.Size = 200;
            _VisitNumber.Value = VisitNumber;
            cmd.Parameters.Add(_VisitNumber);
            System.Data.SqlClient.SqlParameter _Status = new System.Data.SqlClient.SqlParameter();
            _Status.ParameterName = "@Status";
            _Status.Size = 100;
            _Status.Value = Status;
            cmd.Parameters.Add(_Status);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetPatientwiseVisitDetails_LIMSAPICommand(string pOrgCode, string pPatientNo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetPatientwiseVisitDetails_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _pPatientNo = new System.Data.SqlClient.SqlParameter();
            _pPatientNo.ParameterName = "@pPatientNo";
            _pPatientNo.Size = 30;
            _pPatientNo.Value = pPatientNo;
            cmd.Parameters.Add(_pPatientNo);
            return cmd;
        }
			public static System.Data.SqlClient.SqlCommand pGetBookingsDatawithSample_LIMSAPICommand(long pUserID, System.DateTime pDateRange, string pOrgCode)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetBookingsDatawithSample_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pUserID = new System.Data.SqlClient.SqlParameter();
            _pUserID.ParameterName = "@pUserID";
            _pUserID.Size = -1;
            _pUserID.Value = pUserID;
            cmd.Parameters.Add(_pUserID);
            System.Data.SqlClient.SqlParameter _pDateRange = new System.Data.SqlClient.SqlParameter();
            _pDateRange.ParameterName = "@pDateRange";
            _pDateRange.Size = -1;
            _pDateRange.Value = pDateRange;
            cmd.Parameters.Add(_pDateRange);
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            cmd.Parameters.Add(_pOrgCode);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetPatientInfoCommunicationCommand(System.DateTime Fromdate, System.DateTime Todate, int OrgID, string LabNo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetPatientInfoCommunication";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _Fromdate = new System.Data.SqlClient.SqlParameter();
            _Fromdate.ParameterName = "@Fromdate";
            _Fromdate.Size = -1;
            _Fromdate.Value = Fromdate;
            cmd.Parameters.Add(_Fromdate);
            System.Data.SqlClient.SqlParameter _Todate = new System.Data.SqlClient.SqlParameter();
            _Todate.ParameterName = "@Todate";
            _Todate.Size = -1;
            _Todate.Value = Todate;
            cmd.Parameters.Add(_Todate);
            System.Data.SqlClient.SqlParameter _OrgID = new System.Data.SqlClient.SqlParameter();
            _OrgID.ParameterName = "@OrgID";
            _OrgID.Size = -1;
            _OrgID.Value = OrgID;
            cmd.Parameters.Add(_OrgID);
            System.Data.SqlClient.SqlParameter _LabNo = new System.Data.SqlClient.SqlParameter();
            _LabNo.ParameterName = "@LabNo";
            _LabNo.Size = 200;
            _LabNo.Value = LabNo;
            _LabNo.Precision = 0;
            _LabNo.Scale = 0;
            cmd.Parameters.Add(_LabNo);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetReportSnapshotwithvisitnumberCommand(int pOrgID, long pOrgAddressID, string pVisitID, bool pUpdateStatus)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetReportSnapshotwithvisitnumber";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgID = new System.Data.SqlClient.SqlParameter();
            _pOrgID.ParameterName = "@pOrgID";
            _pOrgID.Size = -1;
            _pOrgID.Value = pOrgID;
            cmd.Parameters.Add(_pOrgID);
            System.Data.SqlClient.SqlParameter _pOrgAddressID = new System.Data.SqlClient.SqlParameter();
            _pOrgAddressID.ParameterName = "@pOrgAddressID";
            _pOrgAddressID.Size = -1;
            _pOrgAddressID.Value = pOrgAddressID;
            cmd.Parameters.Add(_pOrgAddressID);
            System.Data.SqlClient.SqlParameter _pVisitID = new System.Data.SqlClient.SqlParameter();
            _pVisitID.ParameterName = "@pVisitID";
            _pVisitID.Size = 500;
            _pVisitID.Value = pVisitID;
            cmd.Parameters.Add(_pVisitID);
            System.Data.SqlClient.SqlParameter _pUpdateStatus = new System.Data.SqlClient.SqlParameter();
            _pUpdateStatus.ParameterName = "@pUpdateStatus";
            _pUpdateStatus.Size = -1;
            _pUpdateStatus.Value = pUpdateStatus;
            cmd.Parameters.Add(_pUpdateStatus);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetPatientResultDetailsbyVisitNo_LIMSAPICommand(string pOrgCode, string visitnumber)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetPatientResultDetailsbyVisitNo_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _visitnumber = new System.Data.SqlClient.SqlParameter();
            _visitnumber.ParameterName = "@visitnumber";
            _visitnumber.Size = 200;
            _visitnumber.Value = visitnumber;
            cmd.Parameters.Add(_visitnumber);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetPatientResultDetailsVisitNo_LIMSAPICommand(string pOrgCode, string visitnumber)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetPatientResultDetailsVisitNo_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _visitnumber = new System.Data.SqlClient.SqlParameter();
            _visitnumber.ParameterName = "@visitnumber";
            _visitnumber.Size = 200;
            _visitnumber.Value = visitnumber;
            cmd.Parameters.Add(_visitnumber);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pUpdateBookingsWithSample_LIMSAPICommand(string pOrgCode, string pType, System.Data.DataTable BookingStatus, System.Data.DataTable Payment, System.Data.DataTable TestInfo, System.Data.DataTable TestSampleInfo)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pUpdateBookingsWithSample_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _pType = new System.Data.SqlClient.SqlParameter();
            _pType.ParameterName = "@pType";
            _pType.Size = 150;
            _pType.Value = pType;
            cmd.Parameters.Add(_pType);
            System.Data.SqlClient.SqlParameter _BookingStatus = new System.Data.SqlClient.SqlParameter();
            _BookingStatus.ParameterName = "@BookingStatus";
            _BookingStatus.Size = -1;
            _BookingStatus.Value = BookingStatus;
            cmd.Parameters.Add(_BookingStatus);
            System.Data.SqlClient.SqlParameter _Payment = new System.Data.SqlClient.SqlParameter();
            _Payment.ParameterName = "@Payment";
            _Payment.Size = -1;
            _Payment.Value = Payment;
            cmd.Parameters.Add(_Payment);
            System.Data.SqlClient.SqlParameter _TestInfo = new System.Data.SqlClient.SqlParameter();
            _TestInfo.ParameterName = "@TestInfo";
            _TestInfo.Size = -1;
            _TestInfo.Value = TestInfo;
            cmd.Parameters.Add(_TestInfo);
            System.Data.SqlClient.SqlParameter _TestSampleInfo = new System.Data.SqlClient.SqlParameter();
            _TestSampleInfo.ParameterName = "@TestSampleInfo";
            _TestSampleInfo.Size = -1;
            _TestSampleInfo.Value = TestSampleInfo;
            cmd.Parameters.Add(_TestSampleInfo);
            return cmd;
        }

        public static System.Data.SqlClient.SqlCommand pInsertBookingwithSample_LIMSAPICommand(string pOrgCode, string pType, System.Data.DataTable BookingStatus, System.Data.DataTable Payment, System.Data.DataTable TestInfo, System.Data.DataTable Samples, out string pOutResult)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pInsertBookingwithSample_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 150;
            _pOrgCode.Value = pOrgCode;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _pType = new System.Data.SqlClient.SqlParameter();
            _pType.ParameterName = "@pType";
            _pType.Size = 150;
            _pType.Value = pType;
            cmd.Parameters.Add(_pType);
            System.Data.SqlClient.SqlParameter _BookingStatus = new System.Data.SqlClient.SqlParameter();
            _BookingStatus.ParameterName = "@BookingStatus";
            _BookingStatus.Size = -1;
            _BookingStatus.Value = BookingStatus;
            cmd.Parameters.Add(_BookingStatus);
            System.Data.SqlClient.SqlParameter _Payment = new System.Data.SqlClient.SqlParameter();
            _Payment.ParameterName = "@Payment";
            _Payment.Size = -1;
            _Payment.Value = Payment;
            cmd.Parameters.Add(_Payment);
            System.Data.SqlClient.SqlParameter _TestInfo = new System.Data.SqlClient.SqlParameter();
            _TestInfo.ParameterName = "@TestInfo";
            _TestInfo.Size = -1;
            _TestInfo.Value = TestInfo;
            cmd.Parameters.Add(_TestInfo);
            System.Data.SqlClient.SqlParameter _Samples = new System.Data.SqlClient.SqlParameter();
            _Samples.ParameterName = "@Samples";
            _Samples.Size = -1;
            _Samples.Value = Samples;
            cmd.Parameters.Add(_Samples);
            pOutResult = null;
            System.Data.SqlClient.SqlParameter _pOutResult = new System.Data.SqlClient.SqlParameter();
            _pOutResult.ParameterName = "@pOutResult";
            _pOutResult.Size = 250;
            _pOutResult.Value = pOutResult;
            cmd.Parameters.Add(_pOutResult);
            _pOutResult.Direction = ParameterDirection.Output;
            pOutResult = ((string)(_pOutResult.Value));
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetMasterData_LIMSAPICommand(string pOrgCode, string pType, int Page, int Size)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetMasterData_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            _pOrgCode.Precision = 0;
            _pOrgCode.Scale = 0;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _pType = new System.Data.SqlClient.SqlParameter();
            _pType.ParameterName = "@pType";
            _pType.Size = 50;
            _pType.Value = pType;
            _pType.Precision = 0;
            _pType.Scale = 0;
            cmd.Parameters.Add(_pType);
            System.Data.SqlClient.SqlParameter _Page = new System.Data.SqlClient.SqlParameter();
            _Page.ParameterName = "@Page";
            _Page.Size = -1;
            _Page.Value = Page;
            _Page.Precision = 10;
            _Page.Scale = 0;
            cmd.Parameters.Add(_Page);
            System.Data.SqlClient.SqlParameter _Size = new System.Data.SqlClient.SqlParameter();
            _Size.ParameterName = "@Size";
            _Size.Size = -1;
            _Size.Value = Size;
            _Size.Precision = 10;
            _Size.Scale = 0;
            cmd.Parameters.Add(_Size);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetPatientPDFReceipt_LIMSAPICommand(string OrgCode, string Type, string ReferenceNumber)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetPatientPDFReceipt_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _OrgCode = new System.Data.SqlClient.SqlParameter();
            _OrgCode.ParameterName = "@OrgCode";
            _OrgCode.Size = 50;
            _OrgCode.Value = OrgCode;
            cmd.Parameters.Add(_OrgCode);
            System.Data.SqlClient.SqlParameter _Type = new System.Data.SqlClient.SqlParameter();
            _Type.ParameterName = "@Type";
            _Type.Size = 50;
            _Type.Value = Type;
            cmd.Parameters.Add(_Type);
            System.Data.SqlClient.SqlParameter _ReferenceNumber = new System.Data.SqlClient.SqlParameter();
            _ReferenceNumber.ParameterName = "@ReferenceNumber";
            _ReferenceNumber.Size = 50;
            _ReferenceNumber.Value = ReferenceNumber;
            cmd.Parameters.Add(_ReferenceNumber);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand GetPatientRegistrationInfo__LIMSAPICommand(string pOrgCode, string pMobileNumber, int Page, int Size)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "GetPatientRegistrationInfo__LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
            _pOrgCode.ParameterName = "@pOrgCode";
            _pOrgCode.Size = 100;
            _pOrgCode.Value = pOrgCode;
            _pOrgCode.Precision = 0;
            _pOrgCode.Scale = 0;
            cmd.Parameters.Add(_pOrgCode);
            System.Data.SqlClient.SqlParameter _pMobileNumber = new System.Data.SqlClient.SqlParameter();
            _pMobileNumber.ParameterName = "@pMobileNumber";
            _pMobileNumber.Size = 100;
            _pMobileNumber.Value = pMobileNumber;
            _pMobileNumber.Precision = 0;
            _pMobileNumber.Scale = 0;
            cmd.Parameters.Add(_pMobileNumber);
           
            System.Data.SqlClient.SqlParameter _Page = new System.Data.SqlClient.SqlParameter();
            _Page.ParameterName = "@Page";
            _Page.Size = -1;
            _Page.Value = Page;
            _Page.Precision = 10;
            _Page.Scale = 0;
            cmd.Parameters.Add(_Page);
            System.Data.SqlClient.SqlParameter _Size = new System.Data.SqlClient.SqlParameter();
            _Size.ParameterName = "@Size";
            _Size.Size = -1;
            _Size.Value = Size;
            _Size.Precision = 10;
            _Size.Scale = 0;
            cmd.Parameters.Add(_Size);
            return cmd;
        }
        public static System.Data.SqlClient.SqlCommand pGetUserList_LIMSAPICommand(string pPWUrl, string pOrgCode, string pRoleName) {
            
                System.Data.SqlClient.SqlCommand cmd;
                cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandText = "pGetUserList_LIMSAPI";
                cmd.CommandTimeout = 180;
                cmd.CommandType = CommandType.StoredProcedure;
                System.Data.SqlClient.SqlParameter _pPWUrl = new System.Data.SqlClient.SqlParameter();
                _pPWUrl.ParameterName = "@pPWUrl";
                _pPWUrl.Size = 300;
                _pPWUrl.Value = pPWUrl;
                cmd.Parameters.Add(_pPWUrl);
                System.Data.SqlClient.SqlParameter _pOrgCode = new System.Data.SqlClient.SqlParameter();
                _pOrgCode.ParameterName = "@pOrgCode";
                _pOrgCode.Size = 100;
                _pOrgCode.Value = pOrgCode;
                cmd.Parameters.Add(_pOrgCode);
                System.Data.SqlClient.SqlParameter _pRoleName = new System.Data.SqlClient.SqlParameter();
                _pRoleName.ParameterName = "@pRoleName";
                _pRoleName.Size = 100;
                _pRoleName.Value = pRoleName;
                cmd.Parameters.Add(_pRoleName);
                return cmd;
            }

        public static System.Data.SqlClient.SqlCommand pHCUserProcess_LIMSAPICommand(System.Data.DataTable UsersList)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pHCUserProcess_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;
            System.Data.SqlClient.SqlParameter _UsersList = new System.Data.SqlClient.SqlParameter();
            _UsersList.ParameterName = "@UsersList";
            _UsersList.Size = -1;
            _UsersList.Value = UsersList;
            cmd.Parameters.Add(_UsersList);
            return cmd;
        }
 public static System.Data.SqlClient.SqlCommand pGetOrderResultDetailsbyVisitNo_LIMSAPICommand(string visitnumber)
        {
            System.Data.SqlClient.SqlCommand cmd;
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "pGetOrderResultDetailsbyVisitNo_LIMSAPI";
            cmd.CommandTimeout = 180;
            cmd.CommandType = CommandType.StoredProcedure;           
            System.Data.SqlClient.SqlParameter _visitnumber = new System.Data.SqlClient.SqlParameter();
            _visitnumber.ParameterName = "@pVisitNumber";
            _visitnumber.Size = 200;
            _visitnumber.Value = visitnumber;
            cmd.Parameters.Add(_visitnumber);
            return cmd;
        }
    }

}
