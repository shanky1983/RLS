using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Attune.Kernel.DataAccessEngine;
using Attune.Kernel.PlatForm.Utility;
using Attune.Kernel.LIMSAPI.Cmd;
using Attune.Kernel.LIMSAPI.BusinessEntities;
using Attune.Kernel.LIMSAPI.UDT; 

namespace Attune.Kernel.LIMSAPI.DAL
{
    public class LIMSAPI_DAL
    {
        #region //Srini
        public long GetTestStatusByVisitNumber(int pOrgID, string pVisitNumber, string pExternalVisitID, out List<PatientBaseInfo> lstPatientBaseInfo, out List<OrderDetailsInfo> lstOrderDetailsInfo)
        {
            long returnCode = -1;
            lstPatientBaseInfo = new List<PatientBaseInfo>();
            lstOrderDetailsInfo = new List<OrderDetailsInfo>();

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd =  LIMSAPI_CMD.pGetTestStatusByVisitNumber_LIMSAPICommand(pOrgID, pVisitNumber, pExternalVisitID);
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientBaseInfo);
                    if (ds.Tables.Count > 1)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[1], out lstOrderDetailsInfo);
                    }
                }
            }
            return returnCode;
        }
		
		public long AuthenticateUser(string UserName, string Pasword, out Login LoginInfo, out List<LoginOrgRoles> RoleInfoList)
        {
            long returnCode = -1;

            LoginInfo = new Login();
            RoleInfoList = new List<LoginOrgRoles>();
            try
            {
                SqlCommand sqlCommand = LIMSAPI_CMD.pGetValidateUser_LIMSAPICommand(UserName, Pasword);
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(sqlCommand, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out LoginInfo);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out RoleInfoList);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL AuthenticateUser in LIMSAPI_DAL", ex);
            }

            return returnCode;
        }

        public long GetRoleLocation(int pOrgID, long pLID, long pRID, out List<LoginLocation> lstLoginlocation)
        {
            long returnCode = -1;
            lstLoginlocation = new List<LoginLocation>();

            try
            {
                SqlCommand sqlCommand = LIMSAPI_CMD.pGetRoleLocation_LIMSAPICommand(pOrgID, pLID, pRID);
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(sqlCommand, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstLoginlocation);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetRoleLocation in LIMSAPI_DAL", ex);
            }
            return returnCode;
        }


        #endregion

        #region //Jazz


        public long GetTestMasterInfo__LIMSAPI(string pOrgCode, string pType, string TestCode, int Page, int Size,out List<TestMasterDetInfo> lstTestMaster, out List<Paging>  lstPages )
        {
            long returnCode = -1;
            lstTestMaster = new List<TestMasterDetInfo>();
            lstPages = new List<Paging>();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.pGetTestMasterInfo__LIMSAPICommand(pOrgCode, pType,  TestCode,  Page, Size);
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstTestMaster);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPages);
                }
            }

            return returnCode;
        }
           
        
      public long GetSampleCollectionPerson__LIMSAPI(string pOrgCode, string pRoleName, int pPage, int pSize, out List<SampleCollectionpersonInfo> lstSampleCollectionperson, out List<RoleLogin> lstRolesInfo, out List<RoleDeptIn> lstRoleDept, out List<RoleLocationIn> lstRoleLoc,out List<Paging> lstPages)
       {
            long returnCode = -1;
          lstSampleCollectionperson = new List<SampleCollectionpersonInfo>();
            lstRolesInfo = new List<RoleLogin>();
            lstPages = new List<Paging>();
            lstRoleDept = new List<RoleDeptIn>();
            lstRoleLoc = new List<RoleLocationIn>();

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
           cmd = LIMSAPI_CMD.pGetSampleCollectionPerson__LIMSAPICommand(pOrgCode,pRoleName, pPage, pSize);
           using (DBEngine dbEngine = new DBEngine())
           {
               dbEngine.ExecuteDataSet(cmd, out ds);
             if (ds.Tables.Count > 0)
                {
                 returnCode = Utilities.ConvertTo(ds.Tables[0], out lstSampleCollectionperson);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstRolesInfo);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstRoleDept);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstRoleLoc);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[4], out lstPages);
                }
            }
           return returnCode;
        }
        public long GetInfectionTestResult__LIMSAPI(string pOrgCode, DateTime pDateRange, string pPatientNumber, string pVisitNumber, int Page, int Size, out List<InfectTestResultInfo> lstInfectionTestResult, out List<Investigation> lstOrderInfo, out List<Paging> lstPages)
        {
            long returnCode = -1;
            lstInfectionTestResult = new List<InfectTestResultInfo>();
            lstOrderInfo = new List<Investigation>();
            lstPages = new List<Paging>();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.pGetInfectionTestResult_LIMSAPICommand(pOrgCode, pDateRange,  pPatientNumber,  pVisitNumber, Page, Size);
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInfectionTestResult);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstOrderInfo);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPages);
                }
            }
           return returnCode;
        }
		 public long GetClientName_LIMSAPI(string pOrgCode,int Page,int Size, out List<ClientNameInfo> lstClientNameInfo, out List<Paging> lstPages)
       {
            long returnCode = -1;
          lstClientNameInfo = new List<ClientNameInfo>();
            lstPages = new List<Paging>();
           DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
           cmd = LIMSAPI_CMD.pGetClientName_LIMSAPICommand(pOrgCode,Page,Size);
           using (DBEngine dbEngine = new DBEngine())
           {
               dbEngine.ExecuteDataSet(cmd, out ds);
             if (ds.Tables.Count > 0)
                {
                 returnCode = Utilities.ConvertTo(ds.Tables[0], out lstClientNameInfo);
                }

                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPages);
                }
            }
           return returnCode;
        }
		 public long GetPatientInfo__LIMSAPI(string pOrgCode, string pPatientNumber, DateTime pRegistereddate, int Page, int Size,out List<PatientRegistrationInfo> lstPatientRegistrationInfo, out List<Paging> lstPages)
       {
            long returnCode = -1;
          lstPatientRegistrationInfo = new List<PatientRegistrationInfo>();
            lstPages = new List<Paging>();
           DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
           cmd = LIMSAPI_CMD.pGetPatientInfo__LIMSAPICommand(pOrgCode, pPatientNumber,  pRegistereddate,  Page,  Size);
           using (DBEngine dbEngine = new DBEngine())
           {
               dbEngine.ExecuteDataSet(cmd, out ds);
             if (ds.Tables.Count > 0)
                {
                 returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientRegistrationInfo);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPages);
                }
            }
           return returnCode;
        }

        public long InsertBookingInfo(string pOrgCode, string pType, List<BookingInfo> lstBookingInfo, 
                                       List<Paymentdetail> lstPayment, List<BookingInfo> lstOrder, out string pOutResult)
        {
            long returnCode = -1;

            DataTable dtBookingInfo = new DataTable();
            DataTable dtPayment = new DataTable();
            DataTable dtTest = new DataTable();
            dtBookingInfo = LIMSAPI_UDT.ConvertToTableBookings(lstBookingInfo);
            dtPayment = LIMSAPI_UDT.ConvertToTablePayment(lstPayment);
            dtTest = LIMSAPI_UDT.ConvertToTableBookings(lstOrder);
            
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.pInsertBookingInfo_LIMSAPICommand(pOrgCode, pType, dtBookingInfo, dtPayment, dtTest, out pOutResult);
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
                pOutResult = Convert.ToString(cmd.Parameters["@pOutResult"].Value);
            }
            return returnCode;
        }

        public long InsertPatientRegOrder(string pOrgCode, string pType, List<PatientRegOrderCreation> lstpatientRegInfo)
        {
            long returnCode = -1;

            DataTable dtPatientRegistrationInfo = new DataTable();
            dtPatientRegistrationInfo = LIMSAPI_UDT.ConvertToPatientRegOrderInfo(lstpatientRegInfo);

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.pInsertPatientRegOrder_LIMSAPICommand(pOrgCode, pType, dtPatientRegistrationInfo);
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
            }
            return returnCode;
        }
        public long InsertRegisterOrder(string pOrgCode, string pType, List<RegisterOrderInfo> lstRegisterOrderInfo, List<Paymentdetail> lstPayment, List<RegisterOrderInfo> lstOrder)
        {
            long returnCode = -1;

            DataTable dtRegisterOrderInfo = new DataTable();
            DataTable dtPaymentInfo = new DataTable();
            DataTable dtTestInfo = new DataTable();
            dtRegisterOrderInfo = LIMSAPI_UDT.ConvertToRegisterOrderInfo(lstRegisterOrderInfo);
            dtPaymentInfo = LIMSAPI_UDT.ConvertToTableRegisterOrderPaymentInfo(lstPayment);
            dtTestInfo = LIMSAPI_UDT.ConvertToRegisterOrderInfo(lstOrder);

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.pInsertRegisterOrder_LIMSAPICommand(pOrgCode, pType, dtRegisterOrderInfo, dtPaymentInfo, dtTestInfo);
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
            }
            return returnCode;
        }

        public long InsertInfectionTestResult(string pOrgCode, string pType, List<InfectionTestResultInfo> lstInfectionTestResultInfo)
        {
            long returnCode = -1;

            DataTable dtInfectionTestResultInfo = new DataTable();
            dtInfectionTestResultInfo = LIMSAPI_UDT.ConvertToInfectionTestResultInfo(lstInfectionTestResultInfo);

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.pInsertInfectionTestResultInfo_LIMSAPICommand(pOrgCode, pType, dtInfectionTestResultInfo);
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
            }
            return returnCode;
        }
        #endregion

        #region //Pirama
        public long GetLocality(string pOrgCode, string pLocalityCategory, string pType, int pPage, int pSize,
                                out List<LocalityInfo> lstLocality, out List<Paging> lstPages)
        {
            long returnCode = -1;
            lstLocality = new List<LocalityInfo>();
            lstPages = new List<Paging>();

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.pGetLocality_LIMSAPICommand(pOrgCode, pLocalityCategory, pType, pPage, pSize);
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstLocality);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPages);
                }
            }
            return returnCode;
        }
        public long GetOrglocationdetails(string pOrgCode, string pCategoryCode, out List<OrganizationInfo> lstOrgInfo)
        {
            long returnCode = -1;
            lstOrgInfo = new List<OrganizationInfo>();

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.pGetOrgLocation_LIMSAPICommand(pOrgCode, pCategoryCode);
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstOrgInfo);
                }
            }
            return returnCode;
        }
        public long GetBookingDetails(int pUserID, DateTime pDateRange, string pOrgCode,
                                     out List<BookingInfo> lstBooking, out List<BookingInfo> lstCollection)
        {
            long returnCode = -1;
            lstBooking = new List<BookingInfo>();
            lstCollection = new List<BookingInfo>();

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.pGetNewBookingDetails_LIMSAPICommand(pUserID, pDateRange, pOrgCode);
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBooking);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstCollection);
                }
            }
            return returnCode;
        }
        public long GetVisitStatus(string pOrgCode, int pBookingID, string pVisitNumber,
                                    out List<VisitstatusInfo> lstPatientInfo)
        {
            long returnCode = -1;
            lstPatientInfo = new List<VisitstatusInfo>();

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.pGetVisitstatus_LIMSAPICommand(pOrgCode, pBookingID, pVisitNumber);
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientInfo);
                }
            }
            return returnCode;
        }

        public long InsertLiveLocation(string pOrgCode, string pType, List<LiveLocationInfo> lstLivelocationInfo)
        {
            long returnCode = -1;

            DataTable dtlivelocation = new DataTable();
            dtlivelocation = LIMSAPI_UDT.ConvertToTableLiveLocation(lstLivelocationInfo);

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.pInsertLiveLocation_LIMSAPICommand(pOrgCode, pType, dtlivelocation);
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
            }
            return returnCode;
        }
        public long UpdateBookingInformation(string pOrgCode, string pType, List<BookingInfo> lstBookingInfo, List<Paymentdetail> lstPaymentInfo, List<BookingInfo> lstTest)
        {
            long returnCode = -1;

            DataTable dtBooking = new DataTable();
            DataTable dtPayments = new DataTable();
            DataTable dtTest = new DataTable();
            dtBooking = LIMSAPI_UDT.ConvertToTableBookings(lstBookingInfo);
            dtPayments= LIMSAPI_UDT.ConvertToTablePayment(lstPaymentInfo);
            dtTest = LIMSAPI_UDT.ConvertToTableBookings(lstTest);

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.pUpdateBookings_LIMSAPICommand(pOrgCode, pType, dtBooking,dtPayments, dtTest);
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
            }
            return returnCode;
        }
        public long InsertPatientInBound(string pOrgCode, string pType, List<PatientRegistrationInfo> lstpatientRegInfo)
        {
            long returnCode = -1;

            DataTable dtPatientRegistrationInfo = new DataTable();
            dtPatientRegistrationInfo = LIMSAPI_UDT.ConvertToTablePatientReg(lstpatientRegInfo);

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.pInsertPatientInBound_LIMSAPICommand(pOrgCode, pType, dtPatientRegistrationInfo);
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
            }
            return returnCode;
        }
		
		public long GetPatientfile(string pOrgCode, int pBookingID,  string pVisitNumber, out List<PatientResultPDF> lstfileInfo)
        {
            long returnCode = -1;
            lstfileInfo = new List<PatientResultPDF>();

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.pGetAttachmentName_LIMSAPICommand(pOrgCode, pBookingID, pVisitNumber);
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstfileInfo);
                }
            }
            return returnCode;
        }
        #endregion

        #region //Abhishek
        public long GetUserList(string pOrgCode, string pRoleName, int Page, int Size, out List<UsersListInfo> UserInfo, out List<RoleLogin> RoleInfo,  out List<RoleDeptIn> lstRoleDept, out List<RoleLocationIn> lstRoleLoc,out List<Paging> lstPages)
        {
            long returnCode = -1;
            UserInfo = new List<UsersListInfo>();
            RoleInfo = new List<RoleLogin>();
            lstPages = new List<Paging>();
            lstRoleDept = new List<RoleDeptIn>();
            lstRoleLoc = new List<RoleLocationIn>();
          

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.pGetSampleCollectionPerson__LIMSAPICommand(pOrgCode, pRoleName, Page, Size);
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out UserInfo);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out RoleInfo);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstRoleDept);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstRoleLoc);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[4], out lstPages);
                }
            }
            return returnCode;
        }

        public long GetPhysicianName(string pOrgCode, int Page, int Size, out List<PhysicianInfo> lstPhysician, out List<Paging> lstPages)
        {
            long returnCode = -1;
            lstPhysician = new List<PhysicianInfo>();
            lstPages = new List<Paging>();

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.PGetPhysicianName_LIMSAPICommand(pOrgCode, Page, Size);
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPhysician);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPages);
                }
            }
            return returnCode;
        }

        public long GetOrderInformation(string pOrgCode, DateTime pDateRange, string pPatientNumber, string pVisitNumber, int Page, int Size, out List<LISOrderInfo> lstOrderinfo, out List<PaymentIn> lstPaymentinfo, out List<Paging> lstPages)
        {
            long returnCode = -1;
            lstOrderinfo = new List<LISOrderInfo>();
            lstPaymentinfo = new List<PaymentIn>();
            lstPages = new List<Paging>();

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.pGetOrderInformation_LIMSAPICommand(pOrgCode, pDateRange, pPatientNumber, pVisitNumber, Page, Size);
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstOrderinfo);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPaymentinfo);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPages);
                }
            }
            return returnCode;
        }

        public long GetVisitInformation(string pOrgCode, int pBookingID, out List<VisitInfo> lstVisitInfo)
        {
            long returnCode = -1;
            lstVisitInfo = new List<VisitInfo>();

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.pGetVisitInformation_LIMSAPICommand(pOrgCode, pBookingID);
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstVisitInfo);
                }
            }
            return returnCode;
        }

        public long GetPatientResult(string pOrgCode, int pBookingID, string pVisitNumber, out List<PatientResultInfo> lstPatientResult)
        {
            long returnCode = -1;
            lstPatientResult = new List<PatientResultInfo>();

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.pGetPatientResult_LIMSAPICommand(pOrgCode, pBookingID, pVisitNumber);
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientResult);
                }
            }
            return returnCode;
        }

        public long UpdateTripStatus(string pOrgCode, string pType, List<TripStatusInfo> lstTripStatusInfo)
        {
            long returnCode = -1;

            DataTable dtTripStatus = new DataTable();
            dtTripStatus = LIMSAPI_UDT.ConvertToTripStatusInfo(lstTripStatusInfo);

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.pUpdateTripStatus_LIMSAPICommand(pOrgCode, pType, dtTripStatus);
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
            }
            return returnCode;
        }

        #endregion


        public long SaveTRFHCDetails(string pOrgCode, string FileName, long BookingID, string ExternalRefNo,long IdentifyingID, string IdentifyingType, string SourceType, string FilePath)
        {
            long returncode = -1;
            SqlCommand objCommand = LIMSAPI_CMD.pInsertTRFHCDetailsCommand(pOrgCode,FileName, BookingID, ExternalRefNo, IdentifyingID, IdentifyingType, SourceType,FilePath);
         //   objCommand.Parameters.Add("@Return", SqlDbType.Int);
         //   objCommand.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(objCommand);
                }
                //using (DBEngine dbEngine = new DBEngine(true))
                //{
                //    dbEngine.ExecuteNonQuery(objCommand);

                //    returncode = Convert.ToInt64(objCommand.Parameters["@Return"].Value);
                //}
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing SaveTRFdetails Patient_DAL", excep);
            }
            return returncode;

        }
        public long GetConfigHCDetails(string pOrgCode, string configkey, out List<Config> lstConfig)
        {
            long returnCode = -1;
            lstConfig = new List<Config>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = LIMSAPI_CMD.pGetConfigHCDetailsCommand(pOrgCode, configkey);
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstConfig);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetConfigDetails()", ex);
            }

            return returnCode;
        }
 #region //Seetha

  public long InsertClientMaster(string pOrgCode, List<ClientDetailsLIMSAPI> lstclientdetails, List<AddressDetails> lstaddressdetails, string pJsonValue)
        {
            long returnCode = -1;

            DataTable dtaddressdetails = new DataTable();
            dtaddressdetails = LIMSAPI_UDT.ConvertToUDTAddressDetails(lstaddressdetails);
            DataTable dtclientdetails = new DataTable();
            dtclientdetails = LIMSAPI_UDT.ConvertToUDTClientDetailsLIMSAPI(lstclientdetails);

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.PSaveClientMaster_LIMSAPICommand(dtclientdetails, dtaddressdetails, pOrgCode, pJsonValue);
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
            }
            return returnCode;
        }
		
		 public long GetRateCardDetails(string pOrgCode, int Page,int Size, out List<ClientRateInfo> lstRateInfo, out List<Paging> lstPages)
        {
            long returnCode = -1;
            lstRateInfo = new List<ClientRateInfo>();
            lstPages = new List<Paging>();

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.pGetRateCardDetails__LIMSAPICommand(pOrgCode,Page,Size);
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstRateInfo);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPages);
                }

            }
            return returnCode;
        }
        public long UpdateOrderStatus(string pOrgCode, string OrderID, List<OrderInformation> lstOrderInformation, string pJsonValue)
        {
            long returnCode = -1;

            DataTable dtOrderstatusDetails = new DataTable();
            dtOrderstatusDetails = LIMSAPI_UDT.ConvertToUDTOrderStatusDetails(lstOrderInformation);


            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.PUpdateTestStatus_LIMSAPICommand(OrderID, pOrgCode, dtOrderstatusDetails, pJsonValue);
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
            }
            return returnCode;
        }

        #endregion
        public long GetPhleboBookingDetails(int pBookingID,int pUserID,  string pOrgCode,
                                      out List<BookingInfo> lstBooking, out List<BookingInfo> lstCollection)
        {
            long returnCode = -1;
            lstBooking = new List<BookingInfo>();
            lstCollection = new List<BookingInfo>();

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.pGetPhleboBookingDetails_LIMSAPICommand(pBookingID,pUserID,  pOrgCode);
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBooking);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstCollection);
                }
            }
            return returnCode;
        }
		 public long GetPatientOrderDetails(string messageType, string OrgCode,out List<PatientDetail> lstpatient,out List<PatientVisitDetail> lstPatVisit,out List<PatientBillingDetails> lstTestDetails,out List<PaymentDetails> lstpayment)
        {
            long returnCode = -1;
            lstpatient = new List<PatientDetail>();
            lstPatVisit = new List<PatientVisitDetail>(); 
            lstTestDetails = new List<PatientBillingDetails>();
            lstpayment = new List<PaymentDetails>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = LIMSAPI_CMD.pGetPatientOrderDetails_LIMSAPICommand(messageType, OrgCode);
                using (DBEngine db = new DBEngine())
                {
                    returnCode = db.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[0], out lstpatient);
                        }
                        if (ds.Tables[1].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPatVisit);
                        }
                        if (ds.Tables[2].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[2], out lstTestDetails);
                        }
                        if (ds.Tables[3].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[3], out lstpayment);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while fetching Patient order Details", ex);
            }
            return returnCode;
        }
        public long GetPatientResultDetails(string OrgCode, out List<PatientDetail> lstpatient, out List<TestOrderVisitDetails> lstPatVisitOrder, out List<TestOrderVisitDetails> lstPatOrderDetails, out List<ResPatientVisitDetails> lstpatientvisitdetails, out string VisitNumber)
        {
            long returnCode = -1;
            lstpatient = new List<PatientDetail>();
            lstPatOrderDetails = new List<TestOrderVisitDetails>();
            lstPatVisitOrder = new List<TestOrderVisitDetails>();
            lstpatientvisitdetails = new List<ResPatientVisitDetails>();
            VisitNumber = string.Empty;
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = LIMSAPI_CMD.pGetPatientResultDetails_LIMSAPICommand( OrgCode);
                using (DBEngine db = new DBEngine())
                {
                    returnCode = db.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[0], out lstpatient);
                        }
                        if (ds.Tables[1].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[1], out lstpatientvisitdetails);
                        }
                        if (ds.Tables[2].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPatVisitOrder);
                        }
                        if (ds.Tables[3].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[3], out lstPatOrderDetails);
                        }
                        if (ds.Tables[4].Rows.Count > 0)
                        {
                            VisitNumber = ds.Tables[4].Rows[0]["VisitNumber"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while fetching Patient result Details", ex);
            }
            return returnCode;
        }
        public long GetPackageMasterDetails(string OrgCode, string TestCode, int Page,int Size, out List<PackageDetail> lstPKGMaster, out List<PackageDetail> lstPKGDetails,out List<Paging> lstPages)
        {
            long returnCode = -1;
            lstPKGMaster = new List<PackageDetail>();
            lstPKGDetails = new List<PackageDetail>();
            lstPages = new List<Paging>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = LIMSAPI_CMD.pGetPackageMasterDetails_LIMSAPICommand(OrgCode, TestCode, Page, Size);
                using (DBEngine db = new DBEngine())
                {
                    returnCode = db.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPKGMaster);
                        }
                        if (ds.Tables[1].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPKGDetails);
                        }
                        if (ds.Tables[2].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPages);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while fetching package master Details", ex);
            }
            return returnCode;
        }
		
		   public long GetPatientOrderDetails(string OrgCode, out List<PatientDetail> lstpatient, out List<TestOrderVisitDetails> lstPatVisitOrder, out List<TestOrderVisitDetails> lstPatOrderDetails, out List<ResPatientVisitDetails> lstpatientvisitdetails, out string VisitNumber)
        {
            long returnCode = -1;
            lstpatient = new List<PatientDetail>();
            lstPatOrderDetails = new List<TestOrderVisitDetails>();
            lstPatVisitOrder = new List<TestOrderVisitDetails>();
            lstpatientvisitdetails = new List<ResPatientVisitDetails>();
            VisitNumber = string.Empty;
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = LIMSAPI_CMD.pGetPatientOrderStatusDetails_LIMSAPICommand(OrgCode);
                using (DBEngine db = new DBEngine())
                {
                    returnCode = db.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[0], out lstpatient);
                        }
                        if (ds.Tables[1].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[1], out lstpatientvisitdetails);
                        }
                        if (ds.Tables[2].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPatVisitOrder);
                        }
                        if (ds.Tables[3].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[3], out lstPatOrderDetails);
                        }
                        if (ds.Tables[4].Rows.Count > 0)
                        {
                            VisitNumber = ds.Tables[4].Rows[0]["VisitNumber"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while fetching Patient Order Details", ex);
            }
            return returnCode;
        }
        public long GetPatientSampleOrderDetails(string OrgCode, out List<PatientDetail> lstpatient, out List<TestOrderSampleVisitDetails> lstPatVisitOrder, out List<TestOrderSampleVisitDetails> lstPatOrderDetails, out List<ResPatientVisitDetails> lstpatientvisitdetails, out string VisitNumber)
        {
            long returnCode = -1;
            lstpatient = new List<PatientDetail>();
            lstPatOrderDetails = new List<TestOrderSampleVisitDetails>();
            lstPatVisitOrder = new List<TestOrderSampleVisitDetails>();
            lstpatientvisitdetails = new List<ResPatientVisitDetails>();
            VisitNumber = string.Empty;
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = LIMSAPI_CMD.pGetPatientOrderSampleStatusDetails_LIMSAPICommand(OrgCode);
                using (DBEngine db = new DBEngine())
                {
                    returnCode = db.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[0], out lstpatient);
                        }
                        if (ds.Tables[1].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[1], out lstpatientvisitdetails);
                        }
                        if (ds.Tables[2].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPatVisitOrder);
                        }
                        if (ds.Tables[3].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[3], out lstPatOrderDetails);
                        }
                        if (ds.Tables[4].Rows.Count > 0)
                        {
                            VisitNumber = ds.Tables[4].Rows[0]["VisitNumber"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while fetching Patient Order Details", ex);
            }
            return returnCode;
        }
        public long GetGroupMasterDetails(string OrgCode, string TestCode, int Page, int Size, out List<PackageDetail> lstPKGMaster, out List<PackageDetail> lstPKGDetails, out List<Paging> lstPages)
        {
            long returnCode = -1;
            lstPKGMaster = new List<PackageDetail>();
            lstPKGDetails = new List<PackageDetail>();
            lstPages = new List<Paging>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = LIMSAPI_CMD.pGetGroupMasterDetails_LIMSAPICommand(OrgCode, TestCode, Page, Size);
                using (DBEngine db = new DBEngine())
                {
                    returnCode = db.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPKGMaster);
                        }
                        if (ds.Tables[1].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPKGDetails);
                        }
                        if (ds.Tables[2].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPages);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while fetching group master Details", ex);
            }
            return returnCode;
        }
        public long GetTestMasterDetails(string OrgCode, string TestCode, int Page, int Size, out List<PackageDetail> lstPKGMaster, out List<Paging> lstPages)
        {
            long returnCode = -1;
            lstPKGMaster = new List<PackageDetail>(); 
            lstPages = new List<Paging>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = LIMSAPI_CMD.pGetTestMasterDetails_LIMSAPICommand(OrgCode, TestCode, Page, Size);
                using (DBEngine db = new DBEngine())
                {
                    returnCode = db.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPKGMaster);
                        } 
                        if (ds.Tables[1].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPages);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while fetching test master Details", ex);
            }
            return returnCode;
        }
		    public long GetPatientLoginPDFfile(string OrgCode,string Type,string LoginName, string Password, string ReferenceNumber, out List<PatientResultPDF> lstfileInfo)
        {
            long returnCode = -1;
            lstfileInfo = new List<PatientResultPDF>();

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.pGetAttachmentPatientLoginPDF_LIMSAPICommand(OrgCode, Type,LoginName,Password,ReferenceNumber);
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstfileInfo);
                }
            }
            return returnCode;
        }
        public long GetPatientLoginPDFAWSfileInfo(string OrgCode, string Type, string LoginName, string Password, string ReferenceNumber, out List<PatientResultPDF> lstfileInfo)
        {
            long returnCode = -1;
            lstfileInfo = new List<PatientResultPDF>();

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.pGetAttachmentPatientLoginPDF_LIMSAPICommand(OrgCode, Type, LoginName, Password, ReferenceNumber);
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstfileInfo);
                }
            }
            return returnCode;
        }
        public long GetPatientLoginPDFOrgAWSfileInfo(string OrgCode, string Type, string ReferenceNumber, out List<PatientResultPDF> lstfileInfo)
        {
            long returnCode = -1;
            lstfileInfo = new List<PatientResultPDF>();

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.GetPatientLoginPDFOrgAWSfileInfo_LIMSAPICommand(OrgCode, Type,  ReferenceNumber);
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstfileInfo);
                }
            }
            return returnCode;
        }
        public long GetOrgBookingStatus(int OrgID, out List<OrgDetails> lstOrgDetails)
        {
            long returnCode = -1;

            lstOrgDetails = new List<OrgDetails>();

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.pOrgBookingStatus_LIMSAPICommand(OrgID);
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstOrgDetails);
                }
            }
            return returnCode;
        }

        public long GetPatientDashBoardByDateRange(string OrgCode, DateTime FromDate, DateTime ToDate, string Type, out List<PatientBio> lstPatientBio)
        {
            long lresult = -1;
            DataSet ds = new DataSet();
            lstPatientBio = new List<PatientBio>();

            List<PatientPlayer> lstPlayerwiseDistribution = new List<PatientPlayer>();
            List<PatientAge> lstAgewiseDistribution = new List<PatientAge>();
            List<PatientGender> lstGenderwiseDistribution = new List<PatientGender>();

            PatientBio dba = new PatientBio();



            if (Type == "FootBall")
            {
                SqlCommand cmd = LIMSAPI_CMD.pGetPatientByDateRange_LIMSAPICommand(OrgCode, FromDate, ToDate, Type);
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                lresult = Utilities.ConvertTo(ds.Tables[0], out lstPlayerwiseDistribution);
                dba.PlayerwiseDistribution = lstPlayerwiseDistribution;
            }

            if (Type == "Age")
            {
                SqlCommand cmd = LIMSAPI_CMD.pGetPatientByDateRange_LIMSAPICommand(OrgCode, FromDate, ToDate, Type);
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                lresult = Utilities.ConvertTo(ds.Tables[0], out lstAgewiseDistribution);
                dba.AgewiseDistribution = lstAgewiseDistribution;
            }

            if (Type == "Gender")
            {
                SqlCommand cmd = LIMSAPI_CMD.pGetPatientByDateRange_LIMSAPICommand(OrgCode, FromDate, ToDate, Type);
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                lresult = Utilities.ConvertTo(ds.Tables[0], out lstGenderwiseDistribution);
                dba.GenderwiseDistribution = lstGenderwiseDistribution;
            }
            lstPatientBio.Add(dba);

            return lresult;

        }
        public long GetClientWiseRevenue(string OrgCode, DateTime FromDate, DateTime ToDate, out List<ClientRevenue> lstClientRevenue)
        {
            long lresult = -1;
            DataSet ds = new DataSet();
            lstClientRevenue = new List<ClientRevenue>();

            List<ClientRevenueDetails> lstClientRevenueDetails = new List<ClientRevenueDetails>();

            ClientRevenue dba = new ClientRevenue();




            SqlCommand cmd = LIMSAPI_CMD.pGetClientwiseRevenue_LIMSAPICommand(OrgCode, FromDate, ToDate);
            using (DBEngine dbEngine = new DBEngine())
            {
                lresult = dbEngine.ExecuteDataSet(cmd, out ds);
            }
            lresult = Utilities.ConvertTo(ds.Tables[0], out lstClientRevenueDetails);
            dba.ClientRevenueDetails = lstClientRevenueDetails;


            lstClientRevenue.Add(dba);

            return lresult;

        }


        public long GetTestWiseRevenue(string OrgCode, DateTime FromDate, DateTime ToDate, out List<TestRevenue> lstTestRevenue)
        {
            long lresult = -1;
            DataSet ds = new DataSet();
            lstTestRevenue = new List<TestRevenue>();

            List<TestRevenueDetails> lstTestRevenueDetails = new List<TestRevenueDetails>();

            TestRevenue dba = new TestRevenue();

            SqlCommand cmd = LIMSAPI_CMD.pGetTestwiseRevenue_LIMSAPICommand(OrgCode, FromDate, ToDate);
            using (DBEngine dbEngine = new DBEngine())
            {
                lresult = dbEngine.ExecuteDataSet(cmd, out ds);
            }

            lresult = Utilities.ConvertTo(ds.Tables[0], out lstTestRevenueDetails);
            dba.TestRevenueDetails = lstTestRevenueDetails;

            lstTestRevenue.Add(dba);

            return lresult;

        }
        public long GetBookingStatusCount(string OrgCode, DateTime FromDate, DateTime ToDate, string Type, out List<BookingStatusCount> lstBookingStatusCount)
        {
            long lresult = -1;
            DataSet ds = new DataSet();
            lstBookingStatusCount = new List<BookingStatusCount>();

            List<BookingStatusCountDetails> lstBookingStatusCountDetails = new List<BookingStatusCountDetails>();

            BookingStatusCount dba = new BookingStatusCount();

            SqlCommand cmd = LIMSAPI_CMD.pGetOperationBookingStatus_LIMSAPICommand(OrgCode, FromDate, ToDate, Type);
            using (DBEngine dbEngine = new DBEngine())
            {
                lresult = dbEngine.ExecuteDataSet(cmd, out ds);
            }

            lresult = Utilities.ConvertTo(ds.Tables[0], out lstBookingStatusCountDetails);
            dba.BookingStatusCountDetails = lstBookingStatusCountDetails;

            lstBookingStatusCount.Add(dba);

            return lresult;

        }
        public long GetPatientPDFbyVisitNo(string OrgCode, string Type, string ReferenceNumber, out List<PatientResultPDF> lstfileInfo)
        {
            long returnCode = -1;
            lstfileInfo = new List<PatientResultPDF>();

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.pGetPatientPDFbyVisitNo_LIMSAPICommand(OrgCode, Type,ReferenceNumber);
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstfileInfo);
                }
            }
            return returnCode;
        }

        public long GetTestMasterWithSample(string OrgCode, string Type, string Testcode,int page,int size ,out List<TestAllResultdetails> lstresult ,out List<TestAllSampledetails> lstsample, out List<Paging> lstPages)
        {
            long returncode = -1;
            lstresult = new List<TestAllResultdetails>();
            lstPages = new List<Paging>();
            lstsample = new List<TestAllSampledetails>();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.pGetTestMasterWithSample_LIMSAPICommand(OrgCode, Type, Testcode, page, size);
            using (DBEngine de = new DBEngine())
            {
                de.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returncode = Utilities.ConvertTo(ds.Tables[0],out lstresult);
                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        returncode = Utilities.ConvertTo(ds.Tables[1], out lstsample);
                    }
                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        returncode = Utilities.ConvertTo(ds.Tables[2], out lstPages);
                    }
                }
            }
                return returncode;
        }
        public long UpdatePatientOrderInvestigation(string OrgCode, string Visitnumber, string Status)
        {
            long returncode = -1; 
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.pUpdatePatientOrderInvestigation_LIMSAPICommand(OrgCode, Visitnumber, Status);
            using (DBEngine de = new DBEngine())
            {
                returncode=de.ExecuteNonQuery(cmd); 
            }
            return returncode;
        }
        public long GetPatientVisitDetailsInfo(string pOrgCode, string pPatientNumber,
                                out List<PatientVisitInfo> lstPatientInfo)
        {
            long returnCode = -1;
            lstPatientInfo = new List<PatientVisitInfo>();

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.pGetPatientwiseVisitDetails_LIMSAPICommand(pOrgCode, pPatientNumber);
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientInfo);
                }
            }
            return returnCode;
        }
public long GetBookingsData(int pUserID, DateTime pDateRange, string pOrgCode,
                                     out List<BookingInfo> lstBooking, out List<SampleDataInfo> lstOrders, out List<SampleDataInfo> lstSamples)
        {
            long returnCode = -1;
            lstBooking = new List<BookingInfo>();
            lstOrders = new List<SampleDataInfo>();
            lstSamples = new List<SampleDataInfo>();

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.pGetBookingsDatawithSample_LIMSAPICommand(pUserID, pDateRange, pOrgCode);
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBooking);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstOrders);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstSamples);
                }
            }
            return returnCode;
        }
        public long GetPatientInfoCommunication(DateTime FromDate, DateTime Todate, int orgid, string LabNo, out List<PatientSampleDetails> lstrptpatientinfo)
        {
            long returnCode = -1;
            lstrptpatientinfo = new List<PatientSampleDetails>();


            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.pGetPatientInfoCommunicationCommand(FromDate, Todate, orgid, LabNo);
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstrptpatientinfo);
                }
            }

            return returnCode;
        }

        public long GetReportSnapshotwithvisitnumber(int pOrgID, long pOrgAddressID, string pVisitID, bool pUpdateStatus, out List<ReportSnapshot> lstreportsnapshot)
        {

            long returnCode = -1;
            lstreportsnapshot = new List<ReportSnapshot>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd = LIMSAPI_CMD.pGetReportSnapshotwithvisitnumberCommand(pOrgID, pOrgAddressID, pVisitID, pUpdateStatus);
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstreportsnapshot);
                    }
                }


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL  GetReportSnapshotwithvisitnumber", ex);
            }

            return returnCode;
        }
        public long GetPatientResultDetailsbyVisitNo(string OrgCode,string VisitNumber, out List<PatientDetail> lstpatient, out List<TestOrderVisitDetails> lstPatVisitOrder, out List<TestOrderVisitDetails> lstPatOrderDetails, out List<ResPatientVisitDetails> lstpatientvisitdetails)
        {
            long returnCode = -1;
            lstpatient = new List<PatientDetail>();
            lstPatOrderDetails = new List<TestOrderVisitDetails>();
            lstPatVisitOrder = new List<TestOrderVisitDetails>();
            lstpatientvisitdetails = new List<ResPatientVisitDetails>(); 
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = LIMSAPI_CMD.pGetPatientResultDetailsbyVisitNo_LIMSAPICommand(OrgCode,VisitNumber);
                using (DBEngine db = new DBEngine())
                {
                    returnCode = db.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[0], out lstpatient);
                        }
                        if (ds.Tables[1].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[1], out lstpatientvisitdetails);
                        }
                        if (ds.Tables[2].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPatVisitOrder);
                        }
                        if (ds.Tables[3].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[3], out lstPatOrderDetails);
                        } 
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while fetching Patient result Details by visit no", ex);
            }
            return returnCode;
        }
        public long GetPatientResultDetailsVisitNo(string OrgCode, string VisitNumber, out List<PatientDetail> lstpatient, out List<TestOrderSampleVisitDetails> lstPatVisitOrder, out List<TestOrderSampleVisitDetails> lstPatOrderDetails, out List<ResPatientVisitDetails> lstpatientvisitdetails)
        {
            long returnCode = -1;
            lstpatient = new List<PatientDetail>();
            lstPatOrderDetails = new List<TestOrderSampleVisitDetails>();
            lstPatVisitOrder = new List<TestOrderSampleVisitDetails>();
            lstpatientvisitdetails = new List<ResPatientVisitDetails>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = LIMSAPI_CMD.pGetPatientResultDetailsVisitNo_LIMSAPICommand(OrgCode, VisitNumber);
                using (DBEngine db = new DBEngine())
                {
                    returnCode = db.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[0], out lstpatient);
                        }
                        if (ds.Tables[1].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[1], out lstpatientvisitdetails);
                        }
                        if (ds.Tables[2].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPatVisitOrder);
                        }
                        if (ds.Tables[3].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[3], out lstPatOrderDetails);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while fetching Patient result Details by visit no", ex);
            }
            return returnCode;
        }

        public long UpdateBookingwithSampleInfo(string pOrgCode, string pType, List<BookingInfo> lstBookingInfo, List<Paymentdetail> lstPaymentInfo, List<BookingInfo> lstTest, List<BookingInfo> lstSample)
        {
            long returnCode = -1;

            DataTable dtBooking = new DataTable();
            DataTable dtPayments = new DataTable();
            DataTable dtTest = new DataTable();
            DataTable dtSamples = new DataTable();
            dtBooking = LIMSAPI_UDT.ConvertToTableBookings(lstBookingInfo);
            dtPayments = LIMSAPI_UDT.ConvertToTablePayment(lstPaymentInfo);
            dtTest = LIMSAPI_UDT.ConvertToTableBookings(lstTest);
            dtSamples = LIMSAPI_UDT.ConvertToTableBookings(lstSample);

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.pUpdateBookingsWithSample_LIMSAPICommand(pOrgCode, pType, dtBooking, dtPayments, dtTest, dtSamples);
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
            }
            return returnCode;
        }

        public long InsertBookingwithSample(string pOrgCode, string pType, List<BookingInfo> lstBookingInfo,
                                       List<Paymentdetail> lstPayment, List<BookingInfo> lstOrder, List<BookingInfo> lstSamples, out string pOutResult)
        {
            long returnCode = -1;

            DataTable dtBookingInfo = new DataTable();
            DataTable dtPayment = new DataTable();
            DataTable dtTest = new DataTable();
            DataTable dtTestSamples = new DataTable();
            dtBookingInfo = LIMSAPI_UDT.ConvertToTableBookings(lstBookingInfo);
            dtPayment = LIMSAPI_UDT.ConvertToTablePayment(lstPayment);
            dtTest = LIMSAPI_UDT.ConvertToTableBookings(lstOrder);
            dtTestSamples = LIMSAPI_UDT.ConvertToTableBookings(lstSamples);

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.pInsertBookingwithSample_LIMSAPICommand(pOrgCode, pType, dtBookingInfo, dtPayment, dtTest, dtTestSamples, out pOutResult);
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
                pOutResult = Convert.ToString(cmd.Parameters["@pOutResult"].Value);
            }
            return returnCode;
        }
        public long GetMasterData(string OrgCode, string Type, int Page, int Size,  out List<GenderData> lstGenderData, 
            out List<CountryData> lstCountryData, out List<StateData> lstStateData, 
            out List<SalutationData> lstSalutationData, out List<URNTypesData>  lstURNTypesData , 
            out List<LocationData>  lstLocationData, out List<Paging> lstPages)
        {
            
            long returnCode = -1;
            lstGenderData = new List<GenderData>();
            lstCountryData = new List<CountryData>();
            lstStateData = new List<StateData>();
            lstSalutationData = new List<SalutationData>();
            lstURNTypesData = new List<URNTypesData>();
            lstLocationData = new List<LocationData>();
            lstPages = new List<Paging>();
          
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();

                if (Type == "Gender")
                {

                    cmd = LIMSAPI_CMD.pGetMasterData_LIMSAPICommand(OrgCode, Type, Page, Size);
                    using (DBEngine db = new DBEngine())
                    {
                        returnCode = db.ExecuteDataSet(cmd, out ds);
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstGenderData);
                            }
                            if (ds.Tables[1].Rows.Count > 0)
                            {
                                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPages);
                            }
                        }
                    }
                }
                else if (Type == "Country")
                {
                    cmd = LIMSAPI_CMD.pGetMasterData_LIMSAPICommand(OrgCode, Type, Page, Size);
                    using (DBEngine db = new DBEngine())
                    {
                        returnCode = db.ExecuteDataSet(cmd, out ds);
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstCountryData);

                            }
                            if (ds.Tables[1].Rows.Count > 0)
                            {
                                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPages);
                            }
                        }
                    }

                }
                else if (Type == "State")
                {
                    cmd = LIMSAPI_CMD.pGetMasterData_LIMSAPICommand(OrgCode, Type, Page, Size);
                    using (DBEngine db = new DBEngine())
                    {
                        returnCode = db.ExecuteDataSet(cmd, out ds);
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstStateData);
                            }
                            if (ds.Tables[1].Rows.Count > 0)
                            {
                                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPages);
                            }
                        }
                    }
                }
                else if (Type == "Salutation")
                {
                    cmd = LIMSAPI_CMD.pGetMasterData_LIMSAPICommand(OrgCode, Type, Page, Size);
                    using (DBEngine db = new DBEngine())
                    {
                        returnCode = db.ExecuteDataSet(cmd, out ds);
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstSalutationData);
                            }
                            if (ds.Tables[1].Rows.Count > 0)
                            {
                                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPages);
                            }
                        }
                    }

                }
                else if (Type == "URNTypes")
                {
                    cmd = LIMSAPI_CMD.pGetMasterData_LIMSAPICommand(OrgCode, Type, Page, Size);
                    using (DBEngine db = new DBEngine())
                    {
                        returnCode = db.ExecuteDataSet(cmd, out ds);
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstURNTypesData);
                            }
                            if (ds.Tables[1].Rows.Count > 0)
                            {
                                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPages);
                            }
                        }
                    }
                }
                else if (Type == "Location")
                {
                    cmd = LIMSAPI_CMD.pGetMasterData_LIMSAPICommand(OrgCode, Type, Page, Size);
                    using (DBEngine db = new DBEngine())
                    {
                        returnCode = db.ExecuteDataSet(cmd, out ds);
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstLocationData);
                            }
                            if (ds.Tables[1].Rows.Count > 0)
                            {
                                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPages);
                            }
                        }
                    }

                }
                else
                {
                    cmd = LIMSAPI_CMD.pGetMasterData_LIMSAPICommand(OrgCode, Type, Page, Size);
                    using (DBEngine db = new DBEngine())
                    {
                        returnCode = db.ExecuteDataSet(cmd, out ds);
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstCountryData);
                            }
                            if (ds.Tables[1].Rows.Count > 0)
                            {
                                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstStateData);
                            }
                            if (ds.Tables[2].Rows.Count > 0)
                            {
                                returnCode = Utilities.ConvertTo(ds.Tables[2], out lstURNTypesData);
                            }
                            if (ds.Tables[3].Rows.Count > 0)
                            {
                                returnCode = Utilities.ConvertTo(ds.Tables[3], out lstGenderData);
                            }
                            if (ds.Tables[4].Rows.Count > 0)
                            {
                                returnCode = Utilities.ConvertTo(ds.Tables[4], out lstSalutationData);
                            }
                            if (ds.Tables[5].Rows.Count > 0)
                            {
                                returnCode = Utilities.ConvertTo(ds.Tables[5], out lstLocationData);

                            }
                            if (ds.Tables[6].Rows.Count > 0)
                            {
                                returnCode = Utilities.ConvertTo(ds.Tables[6], out lstPages);
                            }
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while fetching Patient result Details", ex);
            }
            return returnCode;
        }
        public long GetPatientPDFReceipt(string OrgCode, string Type, string ReferenceNumber, out List<PatientResultPDF> lstfileInfo)
        {
            long returnCode = -1;
            lstfileInfo = new List<PatientResultPDF>();

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.pGetPatientPDFReceipt_LIMSAPICommand(OrgCode, Type, ReferenceNumber);
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstfileInfo);
                }
            }
            return returnCode;
        }
        public long GetPatientRegistrationInfo__LIMSAPI(string pOrgCode, string pMobileNumber,  int Page, int Size, out List<PatientRegistrationInfo> lstPatientRegistrationInfo, out List<Paging> lstPages)
        {
            long returnCode = -1;
            lstPatientRegistrationInfo = new List<PatientRegistrationInfo>();
            lstPages = new List<Paging>();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.GetPatientRegistrationInfo__LIMSAPICommand(pOrgCode, pMobileNumber,  Page, Size);
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientRegistrationInfo);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPages);
                }
            }
            return returnCode;
        }
public long GetUsers(string pPWUrl, string pOrgCode, string pRoleName, out List<UsersListInfo> UserInfo)
        {
            long returnCode = -1;
            UserInfo = new List<UsersListInfo>();

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.pGetUserList_LIMSAPICommand(pPWUrl, pOrgCode, pRoleName);

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out UserInfo);
                }
            }
            return returnCode;
        }

        public long InsertUsersList(List<UsersInfo> lstUsers)
        {
            long returnCode = -1;

            DataTable dtUsers = new DataTable();
            dtUsers = LIMSAPI_UDT.ConvertToTableUsers(lstUsers);

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = LIMSAPI_CMD.pHCUserProcess_LIMSAPICommand(dtUsers);
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
            }
            return returnCode;
        }
		
		 public long GetOrderResultDetailsbyVisitNo(string VisitNumber, out List<VNPatientDetails> lstpatient, out List<VNPatientVisitDetails> lstPatVisitOrder, out List<VNTestOrder> lstPatOrderDetails, out string OrgCode)
        {
            long returnCode = -1;
            lstpatient = new List<VNPatientDetails>();
            lstPatVisitOrder = new List<VNPatientVisitDetails>();
            lstPatOrderDetails = new List<VNTestOrder>();
            OrgCode = string.Empty;
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = LIMSAPI_CMD.pGetOrderResultDetailsbyVisitNo_LIMSAPICommand(VisitNumber);
                using (DBEngine db = new DBEngine())
                {
                    returnCode = db.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[0], out lstpatient);
                        }
                        if (ds.Tables[1].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPatVisitOrder);
                        }
                        if (ds.Tables[2].Rows.Count > 0)
                        {
                            returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPatOrderDetails);
                        }
                        if (ds.Tables[3].Rows.Count > 0)
                        {
                            OrgCode = ds.Tables[3].Rows[0]["OrgCode"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while fetching Patient result Details by visit no", ex);
            }
            return returnCode;
        }
    }
}
