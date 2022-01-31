using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Attune.Podium.BusinessEntities;
using Attune.Podium.Common;
using System.Collections.Specialized;
using System.Web;
using System.IO;
using System.Web.Caching;
using HomeCollectionsDAL;
using Attune.Podium.BusinessEntities.CustomEntities;


namespace HomeCollectionsBL
{
    public class HomeCollections_BL
    {

        ContextDetails globalContextDetails;
        public HomeCollections_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        #region Schedule_BL Methods Starts
        public long GetServiceQuotationDetails(long bookingID, int OrgID, out List<Bookings> lstBookings)
        {
            long returnCode = -1;
            lstBookings = new List<Bookings>();
            try
            {
                HomeCollections_DL scheduleDAL = new HomeCollections_DL(globalContextDetails);
                returnCode = scheduleDAL.GetServiceQuotationDetails(bookingID, OrgID, out lstBookings);
            }
            catch (Exception ex)
            {
                returnCode = -1;
                CLogger.LogError("Error in GetServiceQuotationDetails", ex);
                throw ex;
            }

            return returnCode;
        }
        //public long SaveServiceQuotationDetailscbak(Bookings oBookings, List<OrderedInvestigations> lstOrderedInves, int OrgID, long bookingID)
        //{
        //    long returnCode = -1;
        //    try
        //    {
        //        oBookings = new Bookings();
        //        lstOrderedInves = new List<OrderedInvestigations>();
        //        HomeCollections_DL scheduleDAL = new HomeCollections_DL(globalContextDetails);
        //        returnCode = scheduleDAL.SaveServiceQuotationDetailscbak(oBookings,  lstOrderedInves,  OrgID, bookingID);
        //    }
        //    catch (Exception ex)
        //    {
        //        returnCode = -1;
        //        CLogger.LogError("Error in SaveServiceQuotationDetails", ex);
        //        throw ex;
        //    }

        //    return returnCode;
        //}

        public long SaveServiceQuotationDetails(Bookings oBookings, List<OrderedInvestigations> lstOrderedInves, List<OrderedInvestigations> lstPreOrder, int OrgID, long LID, out long bookingID)
        {
            long returnCode = -1;
            try
            {
                HomeCollections_DL scheduleDAL = new HomeCollections_DL(globalContextDetails);
                returnCode = scheduleDAL.SaveServiceQuotationDetails(oBookings, lstOrderedInves,lstPreOrder, OrgID, LID, out bookingID);
            }
            catch (Exception ex)
            {
                returnCode = -1;
                CLogger.LogError("Error in SaveServiceQuotationDetails", ex);
                throw ex;
            }

            return returnCode;
        }

        public long GetBookingsDt(long BookingID, out List<Bookings> bookings, out List<Bookings> bookingsQuat)
        {
            long returnCode = -1;
            bookings = null;
            bookingsQuat = null;
            try
            {
                HomeCollections_DL scheduleDAL = new HomeCollections_DL(globalContextDetails);
                bookings = new List<Bookings>();
                bookingsQuat = new List<Bookings>();
                returnCode = scheduleDAL.GetBookingsDt(BookingID, out bookings, out bookingsQuat);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetBookings", excp);
            }

            return returnCode;
        }
        #endregion

        #region Nurse_BL Methods Starts
        public long GetActionsIsTrusterdOrg(long roleID, int searchTypeID, out List<ActionMaster> lstActionMaster)
        {
            long returnCode = -1;
            lstActionMaster = new List<ActionMaster>();
            try
            {
                returnCode = new HomeCollections_DL(globalContextDetails).GetActionsIsTrusterdOrg(roleID, searchTypeID, out lstActionMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetActionsIsTrusterdOrg", ex);
            }

            return returnCode;
        }
        public long GetActions(long roleID, int searchTypeID, out List<ActionMaster> lstActionMaster)
        {
            long returnCode = -1;
            lstActionMaster = new List<ActionMaster>();
            try
            {
                returnCode = new HomeCollections_DL(globalContextDetails).GetActions(roleID, searchTypeID, out lstActionMaster);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetActions", ex);
            }
            return returnCode;
        }

        #endregion

        #region MetaData Starts
        public long LoadMetaDataOrgMapping(List<MetaData> lstDomain, long OrgID, string LangCode, out List<MetaData> lstMetaData)
        {
            long returnCode = -1;
            lstMetaData = new List<MetaData>();
            string Code = string.Empty;
            string Domain = "";
            LangCode = "";
            NameValueCollection objectcollection = new NameValueCollection();

            string MetaDataValue = string.Empty;
            try
            {
                returnCode = new HomeCollections_DL(globalContextDetails).LoadMetaDataOrgMapping(lstDomain, OrgID, LangCode, out objectcollection);

                if (objectcollection.HasKeys())
                {
                    //foreach (k key in objcollection.AllKeys) // 
                    //{
                    //    var temp = objcollection.AllKeys;
                    //  Console.WriteLine(key);"Gender_en-GB"
                    for (int j = 0; j <= objectcollection.AllKeys.Length - 1; j++)
                    {
                        string[] s = objectcollection.AllKeys[j].Split('~');

                        Domain = s[0].ToString();
                        //// sKey +=Code.ToString()+'_';
                        LangCode = s[1].ToString();
                        var skey = Domain.ToString() + '~';
                        skey += LangCode.ToString();
                        MetaDataValue = objectcollection[skey];

                        string[] items = MetaDataValue.Split(',');
                        for (int count = 0; count <= items.Length - 1; count++)
                        {
                            MetaData ObjMetaData = new MetaData();
                            string[] values = items[count].Split('~');

                            ObjMetaData.Code = values[0].ToString();
                            ObjMetaData.DisplayText = values[1].ToString();
                            ObjMetaData.Domain = Domain.ToString();
                            ObjMetaData.LangCode = LangCode.ToString();
                            lstMetaData.Add(ObjMetaData);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading metadataorgmapping", ex);
            }
            return returnCode;
        }
        #endregion

        #region Gateway Methods Starts
        public long GetConfigDetails(string configkey, int orgID, out List<Config> lstConfig)
        {
            long returnCode = -1;
            lstConfig = new List<Config>();
            Config objConfig = new Config();
            StringDictionary objDictionary = new StringDictionary();
            string configValue = string.Empty;
            try
            {
                //----
                Utilities objUtilities = new Utilities();
                string KeyValue = string.Empty;
                objUtilities.GetApplicationValue("ConfigCache", out KeyValue);
                //----
                if (KeyValue.ToUpper() == "Y" && KeyValue != null)
                {
                    if (HttpContext.Current.Cache["ConfigData"] != null)
                    {
                        objDictionary = (StringDictionary)HttpContext.Current.Cache["ConfigData"];
                    }
                    else
                    {
                        returnCode = new HomeCollections_DL(globalContextDetails).GetConfigDetails(out objDictionary);
                        string fileName = HttpContext.Current.Request.PhysicalApplicationPath + "App_Data\\CacheFile.Txt";
                        if (!File.Exists(fileName))
                        {
                            StreamWriter writer = File.CreateText(fileName);
                            writer.WriteLine(".LOG");
                            writer.Close();
                        }
                        HttpContext.Current.Cache.Insert("ConfigData", objDictionary, new CacheDependency(fileName));
                    }
                    if (objDictionary != null)
                    {
                        configValue = objDictionary[orgID + "_" + configkey];
                        if (configValue != null && configValue != string.Empty)
                        {
                            objConfig.ConfigValue = configValue;
                            lstConfig.Add(objConfig);
                        }
                    }
                }
                else
                {
                    returnCode = new HomeCollections_DL(globalContextDetails).GetConfigDetails(configkey, orgID, out lstConfig);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetConfigDetails BL", ex);
            }
            return returnCode;
        }
        #endregion

        #region Investigation_BL Methods Starts
        public long GetHomeCollectionDetails(long PatientID, DateTime Fromdate, DateTime Todate, long RoleID,
         long UserID, int CollecOrgID, long CollecOrgAddrID, int LoginOrgID, DateTime BookedFrom, DateTime BookedTo, string Status, string Task,
         out List<Bookings> lstHomeCollectionDetails, string MobileNumber, string TelePhone,
         string pName, int PageSize, int currentPageNo, long BookingNumber, out int totalRows)
        {
            lstHomeCollectionDetails = new List<Bookings>();
            long returnCode = -1;
            totalRows = 0;
            try
            {
                returnCode = new HomeCollections_DL(globalContextDetails).GetHomeCollectionDetails(PatientID, Fromdate, Todate,
                    RoleID, UserID, CollecOrgID, CollecOrgAddrID, LoginOrgID, BookedFrom, BookedTo, Status, Task,
                    out lstHomeCollectionDetails, MobileNumber, TelePhone, pName, PageSize, currentPageNo, BookingNumber, out totalRows);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Get HomeCollection Details ", ex);
            }
            return returnCode;
        }
        public long GetLocationforHomeCollection(long Pincode, long LocationID, string LocationName, out List<Location> lstLocationforHomeCollection)
        {
            long returnCode = -1;
            lstLocationforHomeCollection = new List<Location>();
            HomeCollections_DL location = new HomeCollections_DL(globalContextDetails);
            try
            {
                returnCode = location.GetLocationforHomeCollection(Pincode, LocationID, LocationName, out lstLocationforHomeCollection);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing Location in Inventory_BL", ex);
            }
            return returnCode;
        }
        public long GetCollectiontimeValidation(long userid, DateTime Collectiontime, out List<Bookings> lstHomeCollectionDetails)
        {
            long returnCode = -1;
            lstHomeCollectionDetails = new List<Bookings>();
            HomeCollections_DL location = new HomeCollections_DL(globalContextDetails);
            try
            {
                returnCode = location.GetCollectiontimeValidation(userid, Collectiontime, out lstHomeCollectionDetails);
                long pid = lstHomeCollectionDetails[0].PatientID;
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing Location in Inventory_BL", ex);
            }
            return returnCode;
        }
        #endregion
        public long NewGetHomeCollectionDetails(DateTime CollectFromdate, DateTime CollectTodate, DateTime Fromdate, DateTime Todate,
         int CollecOrgID, int LoginOrgID, string Status, string Task, string Location,
                      string Pincode, long UserID,
        out List<Bookings> lstHomeCollectionDetails, string MobileNumber, string TelePhone,
        string pName, int PageSize, int currentPageNo, long BookingNumber)
        {
            lstHomeCollectionDetails = new List<Bookings>();
            long returnCode = -1;
       
            try
            {
                returnCode = new HomeCollections_DL(globalContextDetails).NewGetHomeCollectionDetails(CollectFromdate, CollectTodate, Fromdate, Todate,
                 CollecOrgID,  LoginOrgID, Status, Task,Location,Pincode,UserID,
                    out lstHomeCollectionDetails, MobileNumber, TelePhone, pName, PageSize, currentPageNo, BookingNumber);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Get HomeCollection Details ", ex);
            }
            return returnCode;
        }
        public long MobileHCGetPatientListforBookings(string pName, int pOrgID,int flag, out List<Patient> lstPatientDetails)
        {
            long returnCode = -1;
            lstPatientDetails = new List<Patient>();
            try
            {
                returnCode = new HomeCollections_DL(globalContextDetails).MobileHCGetPatientListforBookings(pName, pOrgID,flag, out lstPatientDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientList in HomeCollection_BL", ex);
            }
            return returnCode;
        }


        public long pMobile_HCisAlreadyPicked(string BookingID, out string IsAlreadyPicked)
        {
            long returnCode = -1;
             IsAlreadyPicked="";
            try
            {
                returnCode = new HomeCollections_DL(globalContextDetails).pMobile_HCisAlreadyPicked(BookingID, out IsAlreadyPicked);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pMobile_HCisAlreadyPicked in HomeCollection_BL", ex);
            }
            return returnCode;
        }
        public long GetPreviousVisitBilling_HC(long ID,  string Type, out List<Bookings> lstBookings)
        {
            long returnCode = -1;
            lstBookings = new List<Bookings>();

            returnCode = new HomeCollections_DL(globalContextDetails).GetPreviousVisitBilling_HC(ID,  Type, out lstBookings);
            return returnCode;
        }
        #region HomeCollection
        public long GetHCBookingDetails(DateTime CollectionTime,
                 DateTime toTime,
                 long UserID,
                 int CollecOrgID,
                 string Location,
                 string Pincode,
                 int LoginOrgID,
                 DateTime BookedFrom,
                 DateTime BookedTo,
                 string Status,
                 string Task,
            //   DataTable ContextInfo,
                 string MobileNumber,
                 string TelePhone,
                 string pName,
                 int pageSize,
                 int startRowIndex,
                 long BookingNumber,
            out List<OrderedInvestigations> lstOrdInvDetails, out List<OrderedInvestigations> lstPreOrdInvDetails, out List<Bookings> lstHomeCollectionDetails)
        {
            lstHomeCollectionDetails = new List<Bookings>();
            lstOrdInvDetails = new List<OrderedInvestigations>();
            lstPreOrdInvDetails = new List<OrderedInvestigations>();
            //  totalRows = 0;
            long returnCode = -1;

            try
            {
                returnCode = new HomeCollections_DL(globalContextDetails).GetHCBookingDetails(CollectionTime,
                  toTime,
                  UserID,
                 CollecOrgID,
                  Location,
                  Pincode,
                 LoginOrgID,
                  BookedFrom,
                  BookedTo,
                 Status,
                  Task,
                    //   DataTable ContextInfo,
                  MobileNumber,
                TelePhone,
                  pName,
                  pageSize,
                  startRowIndex,
                  BookingNumber,
                out  lstOrdInvDetails, out lstPreOrdInvDetails, out lstHomeCollectionDetails);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Get HomeCollection Details ", ex);
            }
            return returnCode;
        }
        public long UpdateHCBookingDetails(List<Bookings> lstBookings, List<OrderedInvestigations> lstOrderedInves, int OrgID, long LID, out long bookingID)
        {
            long returnCode = -1;
            try
            {
                HomeCollections_DL HomeCollectionsDAL = new HomeCollections_DL(globalContextDetails);
                returnCode = HomeCollectionsDAL.UpdateHCBookingDetails(lstBookings, lstOrderedInves, OrgID, LID, out bookingID);
            }
            catch (Exception ex)
            {
                returnCode = -1;
                CLogger.LogError("Error in SaveServiceQuotationDetails", ex);
                throw ex;
            }

            return returnCode;
        }
        public long UpdateHCBulkBookingDetails(List<Bookings> lstBookings, List<OrderedInvestigations> lstOrderedInves, int OrgID, long LID, out long bookingID, out int count)
        {
            count = 0;
            long returnCode = -1;
            try
            {
                HomeCollections_DL HomeCollectionsDAL = new HomeCollections_DL(globalContextDetails);
                returnCode = HomeCollectionsDAL.UpdateHCBulkBookingDetails(lstBookings, lstOrderedInves, OrgID, LID, out bookingID, out count);
            }
            catch (Exception ex)
            {
                returnCode = -1;
                CLogger.LogError("Error in SaveServiceQuotationDetails", ex);
                throw ex;
            }

            return returnCode;
        }
        public long GetOrglocationMap(long OrgID, long addid, int chid, out List<OrgAddressGoogleMap> lstOrgLocation)
        {
            long returnCode = -1;
            HomeCollections_DL arDAL = new HomeCollections_DL(globalContextDetails);
            lstOrgLocation = new List<OrgAddressGoogleMap>();

            try
            {
                returnCode = arDAL.GetOrglocationMap(OrgID, addid, chid, out lstOrgLocation);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetOrganizationLocation in AdminReports_BL", ex);
            }
            return returnCode;
        }
        public long GetHCSampleBookingDetails(
              long UserID,
            
              string Task,
           
              long BookingNumber,
         out List<OrderedInvestigations> lstOrdInvDetails, out List<OrderedInvestigations> lstPreOrdInvDetails, out List<Bookings> lstHomeCollectionDetails,out int totalRows)
        {
            lstHomeCollectionDetails = new List<Bookings>();
            lstOrdInvDetails = new List<OrderedInvestigations>();
            lstPreOrdInvDetails = new List<OrderedInvestigations>();
              totalRows = 0;
            long returnCode = -1;

            try
            {
                returnCode = new HomeCollections_DL(globalContextDetails).GetHCSampleBookingDetails(
                  UserID,      
                  Task,                 
                  BookingNumber,
                out  lstOrdInvDetails, out lstPreOrdInvDetails, out lstHomeCollectionDetails,out totalRows);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Get HomeCollection Details ", ex);
            }
            return returnCode;
        }
        public long GetHCMapBookingDetails(long BookingNumber, long pUserID,
                                  out List<BookingInfo> lstBooking, out List<BookingInfo> lstCollection, out List<BookingInfo> lstBookingHistory)
        {
            long returnCode = -1;
            lstBooking = new List<BookingInfo>();
            lstCollection = new List<BookingInfo>();
            lstBookingHistory = new List<BookingInfo>();
            try
            {
                  returnCode = new HomeCollections_DL(globalContextDetails).GetHCMapBookingDetails(BookingNumber,pUserID, out lstBooking, out lstCollection, out lstBookingHistory);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetBookingDetails in LISAPI_BL", ex);
            }
            return returnCode;
        }
        #endregion
		
		public long GetBookingsdetailsforBulkReg(DateTime pFromdt, DateTime pTodt, long pOrgID, long pOrgAddressID, out List<Bookingsdata> lstBookingsdata)
        {
            long returnCode = -1;
            lstBookingsdata = new List<Bookingsdata>();
            
            try
            {
                returnCode = new HomeCollections_DL(globalContextDetails).GetBookingsdetailsforBulkReg(pFromdt, pTodt, pOrgID, pOrgAddressID, out lstBookingsdata);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetBookingsdetailsforBulkReg in HomeCollection_BL", ex);
            }
            return returnCode;
        }
        public long GetHCBookingsdetailsforBulkReg(DateTime pFromdt, DateTime pTodt, long pOrgID, long pOrgAddressID, out List<Bookingsdata> lstBookingsdata)
        {
            long returnCode = -1;
            lstBookingsdata = new List<Bookingsdata>();

            try
            {
                returnCode = new HomeCollections_DL(globalContextDetails).GetHCBookingsdetailsforBulkReg(pFromdt, pTodt, pOrgID, pOrgAddressID, out lstBookingsdata);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetHCBookingsdetailsforBulkReg in HomeCollection_BL", ex);
            }
            return returnCode;
        }
        public long ValidateBulkBookingDetails(List<HCBookingData> BulkReg, out List<HCBookingData> lstCamp)
        {
            long returnCode = -1;
            lstCamp = new List<HCBookingData>();


            List<HCTestDetails> lstTestDetails = new List<HCTestDetails>();
            try
            {
                returnCode = new HomeCollections_DL(globalContextDetails).ValidateBulkBookingDetails(BulkReg, out lstCamp, out lstTestDetails);
                if (lstTestDetails.Count > 0)
                {
                    foreach (var campdetails in lstCamp)
                    {
                        campdetails.TestInformation = new List<HCTestDetails>();
                        foreach (var testdetails in lstTestDetails)
                        {
                            if (testdetails.Id == campdetails.Id)
                            {
                                campdetails.TestInformation.Add(testdetails);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error reading ValidateBulkBookingDetails ", ex);
            }
            return returnCode;
        }
        public long SaveBookingDetails(List<HCBookingData> lstCampDetails, out List<HCBookingData> lstresult)
        {
            long returnCode = -1;
            lstresult = new List<HCBookingData>();
            try
            {
                returnCode = new HomeCollections_DL(globalContextDetails).SaveBookingDetails(lstCampDetails, out lstresult);
            }
            catch (Exception ex)
            {

                CLogger.LogError("Error reading SavePatientDetails ", ex);
            }
            return returnCode;
        }
    }
}
