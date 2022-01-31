using System;
using System.Collections.Generic;
using Attune.Kernel.PlatForm.Utility;
using Attune.Kernel.LIMSAPI.BusinessEntities;
using Attune.Kernel.LIMSAPI.DAL;
 

namespace Attune.Kernel.LIMSAPI.BL
{
    public class LIMSAPI_BL
    {
        #region //Srini
        public long GetTestStatusByVisitNumber(int pOrgID, string pVisitNumber, string pExternalVisitID, out List<PatientBaseInfo> lstPatientBaseInfo, out List<OrderDetailsInfo> lstOrderDetailsInfo)
        {
            long returnCode = -1;
            lstPatientBaseInfo = new List<PatientBaseInfo>();
            lstOrderDetailsInfo = new List<OrderDetailsInfo>();
            try
            {
                returnCode = new LIMSAPI_DAL().GetTestStatusByVisitNumber(pOrgID, pVisitNumber, pExternalVisitID, out lstPatientBaseInfo, out lstOrderDetailsInfo);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetTestStatusByVisitNumber in LISAPI_BL", ex);
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
                returnCode = new LIMSAPI_DAL().AuthenticateUser(UserName, Pasword, out LoginInfo, out RoleInfoList);
            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while executing AuthenticateUser in LISAPI_BL", ex);
            }
            return returnCode;
        }

        public long GetRoleLocation(int pOrgID, long pLID, long pRID, out List<LoginLocation> lstLoginlocation)
        {
            long returnCode = -1;
            lstLoginlocation = new List<LoginLocation>();

            try
            {
                returnCode = new LIMSAPI_DAL().GetRoleLocation(pOrgID, pLID, pRID, out lstLoginlocation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetRoleLocation in LISAPI_BL", ex);
            }
            return returnCode;
        }
		
        #endregion

        #region //Jazz

        public long GetTestMasterInfo__LIMSAPI(string pOrgCode, string pType, string TestCode, int Page, int Size, out List<TestMasterDetInfo> lstTestMaster,out List<Paging> lstPages)
        {
            long returnCode = -1;
            lstTestMaster = new List<TestMasterDetInfo>();
            lstPages = new List<Paging>();
            try
            {
                returnCode = new LIMSAPI_DAL().GetTestMasterInfo__LIMSAPI(pOrgCode, pType,  TestCode,  Page, Size, out lstTestMaster,out lstPages);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetTestMasterInfo in LISAPI_BL", ex);
            }
            return returnCode;
        }
        public long GetSampleCollectionPerson__LIMSAPI(string pOrgCode, string pRoleName, int pPage, int pSize, out List<SampleCollectionpersonInfo> lstSampleCollectionperson,out List<RoleLogin> lstRoleInfo, out List<RoleDeptIn> lstRoleDept, out List<RoleLocationIn> lstRoleLoc, out List<Paging> lstPages)
        {
           long returnCode = -1;
            lstSampleCollectionperson = new List<SampleCollectionpersonInfo>();
            lstRoleInfo = new List<RoleLogin>();
            lstPages = new List<Paging>();
            lstRoleDept = new List<RoleDeptIn>();
            lstRoleLoc = new List<RoleLocationIn>();
            try
            {
                returnCode = new LIMSAPI_DAL().GetSampleCollectionPerson__LIMSAPI(pOrgCode, pRoleName, pPage, pSize, out lstSampleCollectionperson,out lstRoleInfo, out lstRoleDept, out lstRoleLoc, out lstPages);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SampleCollectionperson in LISAPI_BL", ex);
            }
            return returnCode;
        }
        public long GetInfectionTestResult__LIMSAPI(string pOrgCode, DateTime pDateRange, string pPatientNumber, string pVisitNumber, int pPage, int pSize, out List<InfectTestResultInfo> lstInfectionTestResult, out List<Investigation> lstOrderInfo,out List<Paging> lstPages)
        {
            long returnCode = -1;
            lstInfectionTestResult = new List<InfectTestResultInfo>();
          lstOrderInfo = new List<Investigation>();
            lstPages = new List<Paging>();
            try
            {
                returnCode = new LIMSAPI_DAL().GetInfectionTestResult__LIMSAPI(pOrgCode, pDateRange, pPatientNumber, pVisitNumber, pPage, pSize, out lstInfectionTestResult, out  lstOrderInfo, out lstPages);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InfectionTestResultin LISAPI_BL", ex);
            }
            return returnCode;
        }
		 public long GetClientName__LIMSAPI(string pOrgCode,int Page, int Size, out List<ClientNameInfo> lstClientNameInfo, out List<Paging> lstPages)
        {
           long returnCode = -1;
            lstClientNameInfo = new List<ClientNameInfo>();
            lstPages = new List<Paging>();
            try
            {
                returnCode = new LIMSAPI_DAL().GetClientName_LIMSAPI(pOrgCode, Page,  Size, out  lstClientNameInfo, out  lstPages);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing lstClientNameInfo in LISAPI_BL", ex);
            }
            return returnCode;
        }
		 public long GetPatientInfo__LIMSAPI(string pOrgCode, string pPatientNumber, DateTime pRegistereddate, int Page, int Size, out List<PatientRegistrationInfo> lstPatientRegistrationInfo, out List<Paging> lstPages)
        {
           long returnCode = -1;
            lstPatientRegistrationInfo = new List<PatientRegistrationInfo>();
            lstPages = new List<Paging>();
            try
            {
                returnCode = new LIMSAPI_DAL().GetPatientInfo__LIMSAPI(pOrgCode,  pPatientNumber,  pRegistereddate,  Page,  Size, out lstPatientRegistrationInfo, out lstPages);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientInfo in LISAPI_BL", ex);
            }
            return returnCode;
        }
		
	    public long InsertBookingInfo(string pOrgCode,string pType, List<BookingInfo> lstBookings, List<Paymentdetail> lstPayment, 
                                              List<BookingInfo> lstOrder, out string pOutResult)
        {
            pOutResult = string.Empty;
            long returnCode = -1;
            try
            {
                returnCode = new LIMSAPI_DAL().InsertBookingInfo(pOrgCode, pType, lstBookings, lstPayment, lstOrder, out pOutResult);
            }
            catch (Exception ex)
            {
                returnCode = -1;
                CLogger.LogError("Error while executing BookingInfo in LIMSAPI_BL", ex);
            }
            return returnCode;
        }

        public long InsertPatientRegOrder(string pOrgCode, string pType, List<PatientRegOrderCreation> lstpatientRegInfo)
        {
            long returnCode = -1;
        //    lstpatientRegInfo = new List<PatientRegOrderCreation>();
            try
            {
                returnCode = new LIMSAPI_DAL().InsertPatientRegOrder(pOrgCode, pType, lstpatientRegInfo);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing PatientRegOrderCreation in LIMSAPI_BL", ex);
            }
            return returnCode;




        }
        public long InsertRegisterOrder(string pOrgCode, string pType, List<RegisterOrderInfo> lstRegisterOrderInfo, List<Paymentdetail> lstPayment, List<RegisterOrderInfo> lstOrder)
        {
            long returnCode = -1;
            try
            {
                returnCode = new LIMSAPI_DAL().InsertRegisterOrder(pOrgCode, pType, lstRegisterOrderInfo, lstPayment, lstOrder);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing BookingInfo in LIMSAPI_BL", ex);
            }
            return returnCode;




        }
        public long InsertInfectionTestResult(string pOrgCode, string pType, List<InfectionTestResultInfo> lstInfectionTestResultInfo)
        {
            long returnCode = -1;
        //    lstInfectionTestResultInfo = new List<InfectionTestResultInfo>();
            try
            {
                returnCode = new LIMSAPI_DAL().InsertInfectionTestResult(pOrgCode, pType, lstInfectionTestResultInfo);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InfectionTestResultInfo in LIMSAPI_BL", ex);
            }
            return returnCode;




        }
        #endregion

        #region // Pirama
        public long GetLocality(string pOrgIDCode, string pLocalityCategory, string pType, int pPage, int pSize,
                                out List<LocalityInfo> lstLocality, out List<Paging> lstPages)
        {
            long returnCode = -1;
            lstLocality = new List<LocalityInfo>();
            lstPages = new List<Paging>();

            try
            {
                returnCode = new LIMSAPI_DAL().GetLocality(pOrgIDCode, pLocalityCategory, pType, pPage, pSize, out lstLocality, out lstPages);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetLocality in LISAPI_BL", ex);
            }
            return returnCode;
        }

        public long GetBookingDetails(int pUserID, DateTime pDateRange, string pOrgCode,
                                       out List<BookingInfo> lstBooking, out List<BookingInfo> lstCollection)
        {
            long returnCode = -1;
            lstBooking = new List<BookingInfo>();
            lstCollection = new List<BookingInfo>();

            try
            {
                returnCode = new LIMSAPI_DAL().GetBookingDetails(pUserID, pDateRange, pOrgCode, out lstBooking, out lstCollection);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetBookingDetails in LISAPI_BL", ex);
            }
            return returnCode;
        }

        public long GetVisitStatus(string pOrgCode, int pBookingID, string pVisitNumber, out List<VisitstatusInfo> patientInfo)
        {
            long returnCode = -1;
            patientInfo = new List<VisitstatusInfo>();

            try
            {
                returnCode = new LIMSAPI_DAL().GetVisitStatus(pOrgCode, pBookingID, pVisitNumber, out patientInfo);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetVisitStatus in LISAPI_BL", ex);
            }
            return returnCode;
        }

        public long InsertPatientRegInformation(string pOrgCode, string pType, List<PatientRegistrationInfo> patientRegInfo)
        {
            long returnCode = -1;

            try
            {
                returnCode = new LIMSAPI_DAL().InsertPatientInBound(pOrgCode, pType, patientRegInfo);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InsertPatientRegInformation in LISAPI_BL", ex);
            }
            return returnCode;
        }

        public long UpdateBookings(string pOrgCode, string pType, List<BookingInfo> lstBookings, List<Paymentdetail> lstPayments, List<BookingInfo> lstTests)
        {
            long returnCode = -1;

            try
            {
                returnCode = new LIMSAPI_DAL().UpdateBookingInformation(pOrgCode, pType, lstBookings, lstPayments, lstTests);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateBookings in LISAPI_BL", ex);
            }
            return returnCode;
        }

        public long InsertLiveLocation(string pOrgCode, string pType, List<LiveLocationInfo> lstLiveLocation)
        {
            long returnCode = -1;

            try
            {
                returnCode = new LIMSAPI_DAL().InsertLiveLocation(pOrgCode, pType, lstLiveLocation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InsertLiveLocation in LISAPI_BL", ex);
            }
            return returnCode;
        }

        public long GetOrglocations(string pOrgCode, string pCategoryCode, out List<OrganizationInfo> lstOrglocation)
        {
            long returnCode = -1;
            lstOrglocation = new List<OrganizationInfo>();

            try
            {
                returnCode = new LIMSAPI_DAL().GetOrglocationdetails(pOrgCode, pCategoryCode, out lstOrglocation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetOrglocations in LISAPI_BL", ex);
            }
            return returnCode;
        }
		
		public long GetPatientPDFfile(string pOrgCode, int pBookingID, string pVisitNumber, out List<PatientResultPDF> lstpatientfile)
        {
            long returnCode = -1;
            lstpatientfile = new List<PatientResultPDF>();

            try
            {
                returnCode = new LIMSAPI_DAL().GetPatientfile(pOrgCode, pBookingID, pVisitNumber, out lstpatientfile);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientPDFfile in LIMSAPI_BL", ex);
            }
            return returnCode;
        }
        #endregion

        #region //Abhishek
        public long GetUserList(string pOrgCode, string pRoleName, int Page, int Size, out List<UsersListInfo> UserInfo, out List<RoleLogin> RoleInfo, out List<RoleDeptIn> lstRoleDept, out List<RoleLocationIn> lstRoleLoc, out List<Paging> lstPages)
        {
            long returnCode = -1;
            UserInfo = new List<UsersListInfo>();
            RoleInfo = new List<RoleLogin>();
            lstPages = new List<Paging>();
            lstRoleDept = new List<RoleDeptIn>();
            lstRoleLoc = new List<RoleLocationIn>();

            try
            {
                returnCode = new LIMSAPI_DAL().GetUserList(pOrgCode, pRoleName, Page, Size, out UserInfo, out RoleInfo, out lstRoleDept, out lstRoleLoc, out lstPages);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetUserList in LIMSAPI_BL", ex);
            }
            return returnCode;
        }

        public long GetPhysicianName(string pOrgCode, int Page, int Size, out List<PhysicianInfo> lstPhysician , out List<Paging> lstPages)
        {
            long returnCode = -1;
            lstPhysician = new List<PhysicianInfo>();
            lstPages = new List<Paging>();
            try
            {
                returnCode = new LIMSAPI_DAL().GetPhysicianName(pOrgCode, Page, Size, out lstPhysician, out lstPages);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPhysicianName in LIMSAPI_BL", ex);
            }
            return returnCode;
        }

        public long GetOrderInformation(string pOrgCode, DateTime pDateRange, string pPatientNumber, string pVisitNumber, int Page, int Size, out List<LISOrderInfo> lstOrderinfo, out List<PaymentIn> lstPaymentinfo, out List<Paging> lstPages)
        {
            long returnCode = -1;
            lstOrderinfo = new List<LISOrderInfo>();
            lstPaymentinfo = new List<PaymentIn>();
            lstPages = new List<Paging>();
            try
            {
                returnCode = new LIMSAPI_DAL().GetOrderInformation(pOrgCode, pDateRange, pPatientNumber, pVisitNumber, Page, Size, out lstOrderinfo, out lstPaymentinfo, out lstPages);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetUserList in LISAPI_BL", ex);
            }
            return returnCode;
        }

        public long GetVisitInformation(string pOrgCode, int pBookingID, out List<VisitInfo> lstVisitInfo)
        {
            long returnCode = -1;
            lstVisitInfo = new List<VisitInfo>();
            try
            {
                returnCode = new LIMSAPI_DAL().GetVisitInformation(pOrgCode, pBookingID, out lstVisitInfo);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetVisitInformation in LIMSAPI_BL", ex);
            }
            return returnCode;
        }

        public long GetPatientResult(string pOrgCode, int pBookingID, string pVisitNumber, out List<PatientResultInfo> lstPatientResult)
        {
            long returnCode = -1;
            lstPatientResult = new List<PatientResultInfo>();
            try
            {
                returnCode = new LIMSAPI_DAL().GetPatientResult(pOrgCode, pBookingID, pVisitNumber, out lstPatientResult);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientResult in LIMSAPI_BL", ex);
            }
            return returnCode;
        }

        public long UpdateTripStatus(string pOrgCode, string pType, List<TripStatusInfo> lstTripStatusInfo)
        {
            long returnCode = -1;

            try
            {
                returnCode = new LIMSAPI_DAL().UpdateTripStatus(pOrgCode, pType, lstTripStatusInfo);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateTripStatus in LIMSAPI_BL", ex);
            }
            return returnCode;
        }

        #endregion
        public long SaveTRFHCDetails(string pOrgCode, string FileName, long BookingID,string ExternalRefNo, long IdentifyingID, string IdentifyingType,string SourceType, string FilePath)
        {
            long returnCode = -1;
            try
            {
               
                returnCode= new LIMSAPI_DAL().SaveTRFHCDetails(pOrgCode,FileName, BookingID, ExternalRefNo, IdentifyingID, IdentifyingType,SourceType, FilePath);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveEpisodeTRFDetails in ClinicalTrail_BL", ex);
            }
            return returnCode;
        }
        public long GetConfigHCDetails(string pOrgCode, string configkey, out List<Config> lstConfig)
        {
            long returnCode = -1;
            lstConfig = new List<Config>();

            try
            {
                returnCode = new LIMSAPI_DAL().GetConfigHCDetails(pOrgCode, configkey, out lstConfig);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetConfigfile in LIMSAPI_BL", ex);
            }
            return returnCode;
        }
  #region // Seetha
  
   public long InsertClientMaster(string pOrgCode,List<ClientDetailsLIMSAPI> lstclientdetails, List<AddressDetails> lstaddressdetails, string JsonValue)
        {
            long returnCode = -1;
            
            try
            {
                returnCode = new LIMSAPI_DAL().InsertClientMaster(pOrgCode, lstclientdetails, lstaddressdetails, JsonValue);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing BookingInfo in LIMSAPI_BL", ex);
            }
            return returnCode;




        }

 public long GetRateCardDetails(string pOrgCode,int Page,int Size, out List<ClientRateInfo> rateInfo,out List<Paging> lstpages)
        {
            long returnCode = -1;
            rateInfo = new List<ClientRateInfo>();
            lstpages = new List<Paging>();

            try
            {
                returnCode = new LIMSAPI_DAL().GetRateCardDetails(pOrgCode,Page,Size, out rateInfo,out lstpages);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetRateCardDetails in LISAPI_BL", ex);
            }
            return returnCode;
        }

        public long UpdateOrderStatus(string pOrgCode, string OrderID, List<OrderInformation> lstOrderInformation, string pJsonValue)
        {
            long returnCode = -1;

            try
            {
                returnCode = new LIMSAPI_DAL().UpdateOrderStatus(pOrgCode, OrderID, lstOrderInformation, pJsonValue);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateOrderStatus in LIMSAPI_BL", ex);
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

            try
            {
                returnCode = new LIMSAPI_DAL().GetPhleboBookingDetails(pBookingID,pUserID,  pOrgCode, out lstBooking, out lstCollection);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPhleboBookingDetails in LISAPI_BL", ex);
            }
            return returnCode;
        }
		  public long GetPatientOrderDetails(string messageType, string OrgCode, out List<PatientDetail> lstpatient, out List<PatientVisitDetail> lstPatVisit, out List<PatientBillingDetails> lstTestDetails, out List<PaymentDetails> lstpayment)
        {
            long returnCode = -1;
            lstpatient = new List<PatientDetail>();
            lstPatVisit = new List<PatientVisitDetail>();
            lstTestDetails = new List<PatientBillingDetails>();
            lstpayment = new List<PaymentDetails>();

            try
            {
                returnCode = new LIMSAPI_DAL().GetPatientOrderDetails(messageType, OrgCode, out lstpatient, out lstPatVisit, out lstTestDetails, out lstpayment);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientOrderDetails in LIMSAPI_BL", ex);
            }
            return returnCode;
        }
        public long GetPatientResultDetails(string OrgCode, out List<PatientDetail> lstpatient, out List<TestOrderVisitDetails> lstPatVisitOrder, out List<TestOrderVisitDetails> lstPatOrderDetails, out List<ResPatientVisitDetails> lstpatientvisitdetails, out string VisitNumber)
        {
            long returnCode = -1;
            lstPatOrderDetails = new List<TestOrderVisitDetails>();
            lstPatVisitOrder = new List<TestOrderVisitDetails>();
            lstpatient = new List<PatientDetail>();
            lstpatientvisitdetails = new List<ResPatientVisitDetails>();
            VisitNumber = string.Empty;
            try
            {
                returnCode = new LIMSAPI_DAL().GetPatientResultDetails(OrgCode, out lstpatient, out lstPatVisitOrder, out lstPatOrderDetails, out lstpatientvisitdetails, out VisitNumber);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while fetching Patient result Details", ex);
            }
            return returnCode;
        }
        public long GetPackageMasterDetails(string OrgCode, string TestCode, int Page, int Size, out List<PackageDetail> lstPKGMaster, out List<PackageDetail> lstPKGDetails,out List<Paging> lstPages)
        {
            long returnCode = -1;
            lstPKGMaster = new List<PackageDetail>();
            lstPKGDetails = new List<PackageDetail>();
            lstPages = new List<Paging>();
            try
            {
                returnCode = new LIMSAPI_DAL().GetPackageMasterDetails(OrgCode, TestCode, Page,Size, out lstPKGMaster, out lstPKGDetails,out lstPages);
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
            lstPatOrderDetails = new List<TestOrderVisitDetails>();
            lstPatVisitOrder = new List<TestOrderVisitDetails>();
            lstpatient = new List<PatientDetail>();
            lstpatientvisitdetails = new List<ResPatientVisitDetails>();
            VisitNumber = string.Empty;
            try
            {
                returnCode = new LIMSAPI_DAL().GetPatientOrderDetails(OrgCode, out lstpatient, out lstPatVisitOrder, out lstPatOrderDetails, out lstpatientvisitdetails, out VisitNumber);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while fetching Patient ORder Details", ex);
            }
            return returnCode;
        }
        public long GetPatientSampleOrderDetails(string OrgCode, out List<PatientDetail> lstpatient, out List<TestOrderSampleVisitDetails> lstPatVisitOrder, out List<TestOrderSampleVisitDetails> lstPatOrderDetails, out List<ResPatientVisitDetails> lstpatientvisitdetails, out string VisitNumber)
        {
            long returnCode = -1;
            lstPatOrderDetails = new List<TestOrderSampleVisitDetails>();
            lstPatVisitOrder = new List<TestOrderSampleVisitDetails>();
            lstpatient = new List<PatientDetail>();
            lstpatientvisitdetails = new List<ResPatientVisitDetails>();
            VisitNumber = string.Empty;
            try
            {
                returnCode = new LIMSAPI_DAL().GetPatientSampleOrderDetails(OrgCode, out lstpatient, out lstPatVisitOrder, out lstPatOrderDetails, out lstpatientvisitdetails, out VisitNumber);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while fetching Patient ORder Details", ex);
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
                returnCode = new LIMSAPI_DAL().GetGroupMasterDetails(OrgCode, TestCode, Page, Size, out lstPKGMaster, out lstPKGDetails, out lstPages);
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
                returnCode = new LIMSAPI_DAL().GetTestMasterDetails(OrgCode, TestCode, Page, Size, out lstPKGMaster, out lstPages);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while fetching test master Details", ex);
            }
            return returnCode;
        }
		 public long GetPatientLoginPDFfile(string OrgCode, string Type, string LoginName, string Password, string ReferenceNumber, out List<PatientResultPDF> lstfileInfo)
        {
            long returnCode = -1;
            lstfileInfo = new List<PatientResultPDF>();

            try
            {
                returnCode = new LIMSAPI_DAL().GetPatientLoginPDFfile(OrgCode, Type, LoginName, Password, ReferenceNumber, out lstfileInfo);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientLoginPDFfile in LIMSAPI_BL", ex);
            }
            return returnCode;
        }
        public long GetPatientLoginPDFAWSfileInfo(string OrgCode, string Type, string LoginName, string Password, string ReferenceNumber, out List<PatientResultPDF> lstfileInfo)
        {
            long returnCode = -1;
            lstfileInfo = new List<PatientResultPDF>();

            try
            {
                returnCode = new LIMSAPI_DAL().GetPatientLoginPDFAWSfileInfo(OrgCode, Type, LoginName, Password, ReferenceNumber, out lstfileInfo);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientLoginPDFfile in LIMSAPI_BL", ex);
            }
            return returnCode;
        }
        
              public long GetPatientLoginPDFOrgAWSfileInfo(string OrgCode, string Type, string ReferenceNumber, out List<PatientResultPDF> lstfileInfo)
        {
            long returnCode = -1;
            lstfileInfo = new List<PatientResultPDF>();

            try
            {
                returnCode = new LIMSAPI_DAL().GetPatientLoginPDFOrgAWSfileInfo(OrgCode, Type,  ReferenceNumber, out lstfileInfo);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientLoginPDFfile in LIMSAPI_BL", ex);
            }
            return returnCode;
        }
        public long GetPatientDashBoardByDateRange(string OrgCode, DateTime FromDate, DateTime ToDate, string Type, out List<PatientBio> lstPatientBio)
        {
            long returnCode = -1;
            lstPatientBio = null;
            try
            {

                returnCode = new LIMSAPI_DAL().GetPatientDashBoardByDateRange(OrgCode, FromDate, ToDate, Type, out lstPatientBio);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetDashBoardDetails in Patient_BL", excp);
            }

            return returnCode;
        }



        public long GetOrgBookingStatus(int OrgID, out List<OrgDetails> lstOrgDetails)
        {
            long returnCode = -1;
            lstOrgDetails = new List<OrgDetails>();
            try
            {
                returnCode = new LIMSAPI_DAL().GetOrgBookingStatus(OrgID, out lstOrgDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetOrgBookingStatus in LIMSAPI_BL", ex);
            }
            return returnCode;
        }

        public long GetClientWiseRevenue(string OrgCode, DateTime FromDate, DateTime ToDate, out List<ClientRevenue> lstClientRevenue)
        {
            long returnCode = -1;
            lstClientRevenue = null;
            try
            {

                returnCode = new LIMSAPI_DAL().GetClientWiseRevenue(OrgCode, FromDate, ToDate, out lstClientRevenue);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetClientWiseRevenue in Patient_BL", excp);
            }

            return returnCode;
        }

        public long GetTestWiseRevenue(string OrgCode, DateTime FromDate, DateTime ToDate, out List<TestRevenue> lstTestRevenue)
        {
            long returnCode = -1;
            lstTestRevenue = null;
            try
            {

                returnCode = new LIMSAPI_DAL().GetTestWiseRevenue(OrgCode, FromDate, ToDate, out lstTestRevenue);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetTestWiseRevenue in Patient_BL", excp);
            }

            return returnCode;
        }
        public long GetBookingStatusCount(string OrgCode, DateTime FromDate, DateTime ToDate, string Type, out List<BookingStatusCount> lstBookingStatusCount)
        {
            long returnCode = -1;
            lstBookingStatusCount = null;
            try
            {

                returnCode = new LIMSAPI_DAL().GetBookingStatusCount(OrgCode, FromDate, ToDate, Type, out lstBookingStatusCount);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetTestWiseRevenue in Patient_BL", excp);
            }

            return returnCode;
        }
        public long GetPatientPDFbyVisitNo(string OrgCode, string Type, string ReferenceNumber, out List<PatientResultPDF> lstfileInfo)
        {
            long returnCode = -1;
            lstfileInfo = new List<PatientResultPDF>();

            try
            {
                returnCode = new LIMSAPI_DAL().GetPatientPDFbyVisitNo(OrgCode, Type, ReferenceNumber, out lstfileInfo);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientPDFbyVisitNo in LIMSAPI_BL", ex);
            }
            return returnCode;
        }
        public long GetTestMasterWithSample(string OrgCode, string Type, string Testcode, int page, int size, out List<TestAllResultdetails> lstresult, out List<TestAllSampledetails> lstsample, out List<Paging> lstPages)
        {
            long returncode = -1;
            lstresult = new List<TestAllResultdetails>();
            lstPages = new List<Paging>();
            lstsample = new List<TestAllSampledetails>();
            try
            {
                returncode = new LIMSAPI_DAL().GetTestMasterWithSample(OrgCode, Type, Testcode, page, size, out lstresult, out lstsample, out lstPages);
            }
            catch (Exception ex)
            { }
            return returncode;
        }
        public long UpdatePatientOrderInvestigation(string OrgCode, string Visitnumber, string Status)
        {
            long returncode = -1;
            try
            {
                returncode = new LIMSAPI_DAL().UpdatePatientOrderInvestigation(OrgCode, Visitnumber, Status);
            }
            catch (Exception ex)
            { }
            return returncode;
        }
        public long GetPatientVisitDetailsInfo(string pOrgCode, string pPatientNumber, out List<PatientVisitInfo> patientInfo)
        {
            long returnCode = -1;
            patientInfo = new List<PatientVisitInfo>();

            try
            {
                returnCode = new LIMSAPI_DAL().GetPatientVisitDetailsInfo(pOrgCode, pPatientNumber, out patientInfo);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetVisitStatus in LISAPI_BL", ex);
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

            try
            {
                returnCode = new LIMSAPI_DAL().GetBookingsData(pUserID, pDateRange, pOrgCode, out lstBooking, out lstOrders, out lstSamples);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetBookingsData in LIMSAPI_BL", ex);
            }
            return returnCode;
        }
        public long GetPatientInfoCommunication(DateTime FromDate, DateTime Todate, int orgid, string LabNo, out List<PatientSampleDetails> lstrptpatientinfo)
        {
            long returnCode = -1;
            lstrptpatientinfo = new List<PatientSampleDetails>();
            try
            {

                returnCode = new LIMSAPI_DAL().GetPatientInfoCommunication(FromDate, Todate, orgid, LabNo, out lstrptpatientinfo);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Report BL GetReportSnapshot", ex);
            }
            return returnCode;
        }


        public long GetReportSnapshotwithvisitnumber(int pOrgID, long pOrgAddressID, string pVisitID, bool pUpdateStatus, out List<ReportSnapshot> lstreportsnapshot)
        {

            long returnCode = -1;
            lstreportsnapshot = new List<ReportSnapshot>();
            try
            {
                returnCode = new LIMSAPI_DAL().GetReportSnapshotwithvisitnumber(pOrgID, pOrgAddressID, pVisitID, pUpdateStatus, out lstreportsnapshot);

            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing AutheticateUser", excp);
            }

            return returnCode;
        }
        public long GetPatientResultDetailsbyVisitNo(string OrgCode, string VisitNumber, out List<PatientDetail> lstpatient, out List<TestOrderVisitDetails> lstPatVisitOrder, out List<TestOrderVisitDetails> lstPatOrderDetails, out List<ResPatientVisitDetails> lstpatientvisitdetails)
        {
            long returnCode = -1;
            lstPatOrderDetails = new List<TestOrderVisitDetails>();
            lstPatVisitOrder = new List<TestOrderVisitDetails>();
            lstpatient = new List<PatientDetail>();
            lstpatientvisitdetails = new List<ResPatientVisitDetails>(); 
            try
            {
                returnCode = new LIMSAPI_DAL().GetPatientResultDetailsbyVisitNo(OrgCode, VisitNumber, out lstpatient, out lstPatVisitOrder, out lstPatOrderDetails, out lstpatientvisitdetails);
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
            lstPatOrderDetails = new List<TestOrderSampleVisitDetails>();
            lstPatVisitOrder = new List<TestOrderSampleVisitDetails>();
            lstpatient = new List<PatientDetail>();
            lstpatientvisitdetails = new List<ResPatientVisitDetails>();
            try
            {
                returnCode = new LIMSAPI_DAL().GetPatientResultDetailsVisitNo(OrgCode, VisitNumber, out lstpatient, out lstPatVisitOrder, out lstPatOrderDetails, out lstpatientvisitdetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while fetching Patient result Details by visit no", ex);
            }
            return returnCode;
        }

        public long UpdateBookingwithSample(string pOrgCode, string pType, List<BookingInfo> lstBookings, List<Paymentdetail> lstPayments, List<BookingInfo> lstTests, List<BookingInfo> lstSamples)
        {
            long returnCode = -1;

            try
            {
                returnCode = new LIMSAPI_DAL().UpdateBookingwithSampleInfo(pOrgCode, pType, lstBookings, lstPayments, lstTests, lstSamples);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateBookingwithSamples in LIMSAPI_BL", ex);
            }
            return returnCode;
        }

        public long InsertBookingwithSample(string pOrgCode, string pType, List<BookingInfo> lstBookings, List<Paymentdetail> lstPayment,
                                              List<BookingInfo> lstOrder, List<BookingInfo> lstSamples, out string pOutResult)
        {
            pOutResult = string.Empty;
            long returnCode = -1;
            try
            {
                returnCode = new LIMSAPI_DAL().InsertBookingwithSample(pOrgCode, pType, lstBookings, lstPayment, lstOrder, lstSamples, out pOutResult);
            }
            catch (Exception ex)
            {
                returnCode = -1;
                CLogger.LogError("Error while executing InsertBookingwithSample in LIMSAPI_BL", ex);
            }
            return returnCode;
        }
        public long GetMasterData(string OrgCode, string Type, int Page, int Size, out List<GenderData> lstGenderData,
         out List<CountryData> lstCountryData, out List<StateData> lstStateData,
         out List<SalutationData> lstSalutationData, out List<URNTypesData> lstURNTypesData,
         out List<LocationData> lstLocationData, out List<Paging> lstPages)
        {
            lstGenderData = new List<GenderData>();
            lstCountryData = new List<CountryData>();
            lstStateData = new List<StateData>();
            lstSalutationData = new List<SalutationData>();
            lstURNTypesData = new List<URNTypesData>();
            lstLocationData = new List<LocationData>();
            lstPages = new List<Paging>();

            long returnCode = -1;
            try
            {
                returnCode = new LIMSAPI_DAL().GetMasterData(OrgCode, Type, Page, Size, out lstGenderData,
         out lstCountryData, out lstStateData,
         out lstSalutationData, out lstURNTypesData,
         out lstLocationData, out lstPages);
            }
            catch (Exception ex)
            {
                returnCode = -1;
                CLogger.LogError("Error while executing GetMasterData in LIMSAPI_BL", ex);
            }
            return returnCode;
        }
        public long GetPatientPDFReceipt(string OrgCode, string Type, string ReferenceNumber, out List<PatientResultPDF> lstfileInfo)
        {
            long returnCode = -1;
            lstfileInfo = new List<PatientResultPDF>();

            try
            {
                returnCode = new LIMSAPI_DAL().GetPatientPDFReceipt(OrgCode, Type, ReferenceNumber, out lstfileInfo);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientPDFbyVisitNo in LIMSAPI_BL", ex);
            }
            return returnCode;
        }
        public long GetPatientRegistrationInfo__LIMSAPI(string pOrgCode, string pMobileNumber,  int Page, int Size, out List<PatientRegistrationInfo> lstPatientRegistrationInfo, out List<Paging> lstPages)
        {
            long returnCode = -1;
            lstPatientRegistrationInfo = new List<PatientRegistrationInfo>();
            lstPages = new List<Paging>();
            try
            {
                returnCode = new LIMSAPI_DAL().GetPatientRegistrationInfo__LIMSAPI(pOrgCode, pMobileNumber,  Page, Size, out lstPatientRegistrationInfo, out lstPages);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientRegistrationInfo in LISAPI_BL", ex);
            }
            return returnCode;
        }
public long GetUsers(string pPWUrl, string pOrgCode, string pRoleName, out List<UsersListInfo> UserInfo)
        {
            long returnCode = -1;
            UserInfo = new List<UsersListInfo>();

            try
            {
                returnCode = new LIMSAPI_DAL().GetUsers(pPWUrl, pOrgCode, pRoleName, out UserInfo);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetUsers in LIMSAPI_BL", ex);
            }
            return returnCode;
        }

        public long InsertUsersList(List<UsersInfo> pUsersInfo)
        {
            long returnCode = -1;

            try
            {
                returnCode = new LIMSAPI_DAL().InsertUsersList(pUsersInfo);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing InsertUsersList in LISAPI_BL", ex);
            }
            return returnCode;
        }
		public long GetOrderResultDetailsbyVisitNo( string VisitNumber, out List<VNPatientDetails> lstpatient, out List<VNPatientVisitDetails> lstPatVisitOrder, out List<VNTestOrder> lstPatOrderDetails, out string OrgCode)
        {
            long returnCode = -1;
            lstpatient = new List<VNPatientDetails>();
            lstPatVisitOrder = new List<VNPatientVisitDetails>();
            lstPatOrderDetails = new List<VNTestOrder>();
            OrgCode = string.Empty;
            try
            {
                returnCode = new LIMSAPI_DAL().GetOrderResultDetailsbyVisitNo(VisitNumber, out lstpatient, out lstPatVisitOrder, out lstPatOrderDetails, out OrgCode);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while fetching Patient result Details by visit no", ex);
            }
            return returnCode;
        }

    }
}
