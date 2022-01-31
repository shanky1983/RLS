using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Attune.Podium.BusinessEntities;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.Common;
using System.Collections.Specialized;
using HomeCollectionsDAL;
using Attune.Solution.DAL;
using Attune.Podium.BusinessEntities.CustomEntities;

namespace HomeCollectionsDAL
{
    public class HomeCollections_DL
    {
        #region Constructor Part
        ContextDetails globalContextDetails;
        public HomeCollections_DL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        #endregion

        #region ScheduleDAL Methods Stars
        public long GetServiceQuotationDetails(long bookingID, int OrgID, out List<Bookings> lstBookings)
        {
            long returnCode = -1;
            lstBookings = new List<Bookings>();
            DataSet ds = new DataSet();

            try
            {
                SqlCommand cmd = Command.pGetServiceQuotationDetailsCommand(bookingID, OrgID, HomeUDT.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine db = new DBEngine())
                {
                    returnCode = db.ExecuteDataSet(cmd, out ds);
                }
                if (ds != null)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBookings);
                    }
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing GetQuickBillingDetails", ex);
            }
            return returnCode;
        }
        //public long SaveServiceQuotationDetailscbak(Bookings oBookings, List<OrderedInvestigations> lstOrderedInves, int OrgID,long bookingID)
        //{
        //    long returnCode = -1;
        //    DataTable dtServiceQuotation = HomeUDT.ConvertToHCServiceQuotation(oBookings);
        //    DataTable invs = HomeUDT.ConvertToHCOrderedInvestigation(lstOrderedInves);
        //    SqlCommand cmd = Command.pHCSaveServiceQuotationDetails_cbkCommand(dtServiceQuotation, invs, OrgID, bookingID, HomeUDT.ConvertToUDT_Context(globalContextDetails));

        //    using (DBEngine dBEngine = new DBEngine())
        //    {
        //        returnCode = dBEngine.ExecuteNonQuery(cmd);
        //        //bookingID = Convert.ToInt64(cmd.Parameters["@pBookingID"].Value);

        //    }
        //    return returnCode;
        //}

        public long SaveServiceQuotationDetails(Bookings oBookings, List<OrderedInvestigations> lstOrderedInves, List<OrderedInvestigations> lstPreOrder, int OrgID, long LID, out long bookingID)
        {
            long returnCode = -1;
            DataTable dtServiceQuotation = HomeUDT.ConvertToHCServiceQuotation(oBookings);
            DataTable invs = HomeUDT.ConvertToHCOrderedInvestigation(lstOrderedInves);
            DataTable PreOrdinvs = HomeUDT.ConvertToHCPreOrdered(lstPreOrder);
            SqlCommand cmd = Command.pHCSaveServiceQuotationDetailsCommand(dtServiceQuotation, invs, PreOrdinvs, OrgID, LID, out bookingID, HomeUDT.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dBEngine = new DBEngine())
            {
                returnCode = dBEngine.ExecuteNonQuery(cmd);
                bookingID = Convert.ToInt64(cmd.Parameters["@pBookingID"].Value);

            }
            return returnCode;
        }
        #endregion
        /* added by Jagatheesh */
        //public long InsertServiceQuotationDetails(string Priority, string Patient, string Sex, string pAge, string CollectedDt, string Add2, string Pincode, string BillDescription, string State, int OrgID, out long bookingID)
        //{
        //    long returnCode = -1;           
        //    SqlCommand cmd = Command.pUpdateServiceQuotationDetailsCommand(Priority, Patient, Sex, pAge, CollectedDt, Add2, Pincode, BillDescription, State, OrgID, out bookingID, HomeUDT.ConvertToUDT_Context(globalContextDetails));

        //    using (DBEngine dBEngine = new DBEngine())
        //    {
        //        returnCode = dBEngine.ExecuteNonQuery(cmd);
        //        bookingID = Convert.ToInt64(cmd.Parameters["@pBookingID"].Value);

        //    }
        //    return returnCode;
        //}
        ///* ended */
        #region Nurse DAL Starts
        public long GetActionsIsTrusterdOrg(long roleID, int searchTypeID, out List<ActionMaster> lstActionMaster)
        {
            long returnCode = -1;
            lstActionMaster = new List<ActionMaster>();
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pGetActionsIsTrusterdOrgCommand(roleID, searchTypeID, HomeUDT.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstActionMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetActionsIsTrusterdOrg", ex);
            }

            return returnCode;
        }

        public long GetActions(long roleID, int searchTypeID, out List<ActionMaster> lstActionMaster)
        {
            long returnCode = -1;
            lstActionMaster = new List<ActionMaster>();
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pGetActionsCommand(roleID, searchTypeID, HomeUDT.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstActionMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetActions", ex);
            }

            return returnCode;
        }
        public long GetBookingsDt(long BookingID, out List<Bookings> bookings, out List<Bookings> bookingsQuat)
        {
            long returnCode = -1;
            bookings = new List<Bookings>();
            bookingsQuat = new List<Bookings>();
            SqlCommand Bookingcmd = Command.pGetBookingDtlCommand(BookingID, HomeUDT.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();

            using (DBEngine dBEngine = new DBEngine())
            {
                dBEngine.ExecuteDataSet(Bookingcmd, out ds);
            }

            if (ds.Tables.Count > 1)
            {
                Utilities.ConvertTo(ds.Tables[0], out bookings);
                Utilities.ConvertTo(ds.Tables[1], out bookingsQuat);
            }
            return returnCode;
        }
        #endregion

        #region MetaData Starts

        public long LoadMetaDataOrgMapping(List<MetaData> lstDomain, long OrgID, string LangCode, out NameValueCollection objectcollection)
        {
            long returnCode = -1;
            objectcollection = new NameValueCollection();
            try
            {
                DataTable dtMetaData = HomeUDT.ConvertToUDTMetaData(lstDomain);

                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pLoadMetaDataOrgMappingCommand(dtMetaData, OrgID, LangCode, HomeUDT.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    IDataReader dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out objectcollection);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While loading MetadataOrg Mapping", ex);
            }
            return returnCode;

        }
        #endregion

        #region DALGateway Methods Starts
        public long GetConfigDetails(out StringDictionary objDictionary)
        {
            long returnCode = -1;
            objDictionary = new StringDictionary();
            try
            {
                SqlCommand cmd = Command.pGetConfigDataForAllOrgCommand(HomeUDT.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    IDataReader dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out objDictionary);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading get config details", ex);
            }

            return returnCode;
        }

        public long GetConfigDetails(string configkey, int orgID, out List<Config> lstConfig)
        {
            long returnCode = -1;
            lstConfig = new List<Config>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetConfigDetailsCommand(configkey, orgID, HomeUDT.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
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
        #endregion

        #region Investigation_DL Methods Starts
        public long GetHomeCollectionDetails(long PatientID, DateTime Fromdate, DateTime Todate, long RoleID,
                          long UserID, int CollecOrgID, long CollecOrgAddrID, int LoginOrgID, DateTime BookedFrom, DateTime BookedTo, string Status,
                          string Task, out List<Bookings> lstHomeCollectionDetails,
                          string MobileNumber, string TelePhone, string pName, int PageSize, int currentPageNo, long BookingNumber, out int totalRows)
        {
            long returnCode = -1;
            totalRows = 0;
            lstHomeCollectionDetails = new List<Bookings>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetHomeCollectionDetailsCommand(PatientID, Fromdate, Todate, RoleID, UserID,
                    CollecOrgID, CollecOrgAddrID, LoginOrgID, BookedFrom, BookedTo, Status,
                    Task, HomeUDT.ConvertToUDT_Context(globalContextDetails), MobileNumber, TelePhone, pName, PageSize, currentPageNo, BookingNumber, out totalRows);
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstHomeCollectionDetails);
                        totalRows = Convert.ToInt32(ds.Tables[1].Rows[0]["totalRows"]);
                    }
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Save HomeCollection Details ", ex);
            }
            return returnCode;
        }
        public long GetLocationforHomeCollection(long Pincode, long LocationID, string LocationName, out List<Location> lstLocationforHomeCollection)
        {
            long returnCode = -1;
            lstLocationforHomeCollection = new List<Location>();
            SqlCommand cmd = Command.pGetLocationforHomeCollectionCommand(Pincode, LocationID, LocationName, HomeUDT.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstLocationforHomeCollection);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing LocationName in Inventory_DAL", ex);
            }
            return returnCode;
        }
	public long GetCollectiontimeValidation(long userid, DateTime Collectiontime, out List<Bookings> lstHomeCollectionDetails)
        {
            long returnCode = -1;
            lstHomeCollectionDetails = new List<Bookings>();
           SqlCommand cmd = Command.pGetCollectiontimeValidationCommand(userid,Collectiontime);
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstHomeCollectionDetails);
                    long pid = lstHomeCollectionDetails[0].PatientID;
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing LocationName in Inventory_DAL", ex);
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
        long returnCode = -1;

        lstHomeCollectionDetails = new List<Bookings>();
        try
        {
            DataSet ds = new DataSet();
            SqlCommand cmd = Command.Pgethomecollectiondetails_bakCommand(CollectFromdate, CollectTodate,  UserID,CollecOrgID,Location,Pincode, LoginOrgID, Fromdate, Todate, Status,
                Task, HomeUDT.ConvertToUDT_Context(globalContextDetails), MobileNumber, TelePhone, pName, PageSize, currentPageNo, BookingNumber);
            using (DBEngine dbEngine = new DBEngine(false))
            {
                returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstHomeCollectionDetails);

                }
            }

        }
        catch (Exception ex)
        {
            CLogger.LogError("Error while Save HomeCollection Details ", ex);
        }
        return returnCode;
    }


        public long MobileHCGetPatientListforBookings(string pName, int pOrgID,int flag, out List<Patient> lstPatientDetails)
        {
            long returnCode = -1;
            lstPatientDetails = new List<Patient>();
            SqlCommand cmd = Command.PMobile_HCGetPatientListforBookingsCommand(pName, pOrgID, HomeUDT.ConvertToUDT_Context(globalContextDetails),flag);
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetProductList in HomeCollection_DAL", ex);
            }
            return returnCode;
        }

        public long pMobile_HCisAlreadyPicked(string BookingID, out string IsAlreadyPicked)
        {
            long returncode=-1;
            SqlCommand sqlcmd = Command.pMobile_HCisAlreadyPickedCommand(BookingID, out IsAlreadyPicked);
        
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(sqlcmd);
                    IsAlreadyPicked = Convert.ToString(sqlcmd.Parameters["@IsAlreadyPicked"].Value);
                }
            }
            catch (Exception ex)
            {
                
             CLogger.LogError("Error while executing HCisAlreadyPicked in HomeCollection_DAL", ex);
            }
            return returncode;
        }

        public long GetPreviousVisitBilling_HC(long ID,  string Type, out List<Bookings> lstBookings)
        {
            long returnCode = -1;
            lstBookings = new List<Bookings>();



            SqlCommand cmd = Command.pGetPreviousVisitBilling_HCCommand(ID,  Type, HomeUDT.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine db = new DBEngine())
            {
                db.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBookings);

            }

            return returnCode;
        }
        #region HomeCollection Booking Details
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
                out List<OrderedInvestigations> lstOrdInvDetails,
                    out List<OrderedInvestigations> lstPreOrdInvDetails, out List<Bookings> lstHomeCollectionDetails)
        {
            long returnCode = -1;

            lstHomeCollectionDetails = new List<Bookings>();
            lstPreOrdInvDetails = new List<OrderedInvestigations>();

            lstOrdInvDetails = new List<OrderedInvestigations>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetHCBookingDetailsCommand(CollectionTime,
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
                  HomeUDT.ConvertToUDT_Context(globalContextDetails), MobileNumber, TelePhone, pName, pageSize, startRowIndex, BookingNumber
                   );
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstOrdInvDetails);

                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPreOrdInvDetails);

                    }
                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[2], out lstHomeCollectionDetails);
                        // totalRows = Convert.ToInt32(ds.Tables[3].Rows[0]["totalRows"]);
                    }

                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Save HomeCollection Details ", ex);
            }
            return returnCode;
        }
        public long UpdateHCBookingDetails(List<Bookings> lstBookings, List<OrderedInvestigations> lstOrderedInves, int OrgID, long LID, out long bookingID)
        {
            long returnCode = -1;
           // DataTable dtServiceQuotation = UDT_DAL.ConvertToServiceQuotation(oBookings);
            DataTable dtServiceQuotation = HomeUDT.ConvertToHomeBooking(lstBookings);
            DataTable invs = UDT_DAL.ConvertToOrderedInvestigation(lstOrderedInves);
            SqlCommand cmd = Command.pUpdateHCBookingDetailsCommand(dtServiceQuotation, invs, OrgID, LID, out bookingID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
         //   cmd.Parameters.Add("@pCount", SqlDbType.Int);
          //  cmd.Parameters["@pCount"].Direction = ParameterDirection.ReturnValue;
            using (DBEngine dBEngine = new DBEngine())
            {
                returnCode = dBEngine.ExecuteNonQuery(cmd);
                bookingID = Convert.ToInt64(cmd.Parameters["@pBookingID"].Value);
               // count = Convert.ToInt32(cmd.Parameters["@pCount"].Value);

            }
            return returnCode;
        }
        public long UpdateHCBulkBookingDetails(List<Bookings> lstBookings, List<OrderedInvestigations> lstOrderedInves, int OrgID, long LID, out long bookingID, out int count)
        {
            long returnCode = -1;
            DataTable dtServiceQuotation = HomeUDT.ConvertToHomeBooking(lstBookings);
            DataTable invs = UDT_DAL.ConvertToOrderedInvestigation(lstOrderedInves);
            SqlCommand cmd = Command.pUpdateHCBookingDetailsCommand(dtServiceQuotation, invs, OrgID, LID, out bookingID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@pCount", SqlDbType.Int);
            cmd.Parameters["@pCount"].Direction = ParameterDirection.ReturnValue;
            using (DBEngine dBEngine = new DBEngine())
            {
                returnCode = dBEngine.ExecuteNonQuery(cmd);
                bookingID = Convert.ToInt64(cmd.Parameters["@pBookingID"].Value);
                count = Convert.ToInt32(cmd.Parameters["@pCount"].Value);

            }
            return returnCode;
        }
        public long GetOrglocationMap(long OrgID, long addid, int chid, out List<OrgAddressGoogleMap> lstOrgLocation)
        {
            long returnCode = -1;
            lstOrgLocation = new List<OrgAddressGoogleMap>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetOrglocationMapCommand(Convert.ToInt32(OrgID), addid, chid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstOrgLocation);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPhysicianWiseCollectionSummary in AdminReports_DAL.", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returnCode;
        }

        public long GetHCSampleBookingDetails(
              long UserID,
              
              string Task,

              long BookingNumber,
             out List<OrderedInvestigations> lstOrdInvDetails,
                 out List<OrderedInvestigations> lstPreOrdInvDetails, out List<Bookings> lstHomeCollectionDetails, out int totalRows)
        {
            long returnCode = -1;
            totalRows = 0;
            lstHomeCollectionDetails = new List<Bookings>();
            lstPreOrdInvDetails = new List<OrderedInvestigations>();

            lstOrdInvDetails = new List<OrderedInvestigations>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetHCSampleBookingDetailsCommand(
                  UserID,

                  Task,
                  HomeUDT.ConvertToUDT_Context(globalContextDetails), BookingNumber,out totalRows);
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstOrdInvDetails);

                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPreOrdInvDetails);

                    }
                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[2], out lstHomeCollectionDetails);
                        totalRows = Convert.ToInt32(ds.Tables[3].Rows[0]["totalRows"]);
                    }
                    if (ds.Tables[3].Rows.Count > 0)
                    {
                       
                        totalRows = Convert.ToInt32(ds.Tables[3].Rows[0]["totalRows"]);
                    }

                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Save HomeCollection Details ", ex);
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
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pGetHCMapBookingDetailsCommand(BookingNumber,pUserID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
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
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstBookingHistory);
                }
            }
            return returnCode;
        }
        #endregion
		
		#region GetBookingsdetailsforBulkReg
        public long GetBookingsdetailsforBulkReg(DateTime pFromdt, DateTime pTodt, long pOrgID, long pOrgAddressID, out List<Bookingsdata> lstBookingsdata)
        {
            long returnCode = -1;
            lstBookingsdata = new List<Bookingsdata>();
            DataSet ds = new DataSet();

            try
            {
                SqlCommand cmd = Command.pGetBookingdetailsforBulkRegCommand(pFromdt,pTodt, pOrgID, pOrgAddressID, HomeUDT.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine db = new DBEngine())
                {
                    returnCode = db.ExecuteDataSet(cmd, out ds);
                }
                if (ds != null)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBookingsdata);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing GetBookingsdetailsforBulkReg in HomeCollection_DL", ex);
            }
            return returnCode;
        }
        public long GetHCBookingsdetailsforBulkReg(DateTime pFromdt, DateTime pTodt, long pOrgID, long pOrgAddressID, out List<Bookingsdata> lstBookingsdata)
        {
            long returnCode = -1;
            lstBookingsdata = new List<Bookingsdata>();
            DataSet ds = new DataSet();

            try
            {
                SqlCommand cmd = Command.pGetHCBookingdetailsforBulkRegCommand(pFromdt, pTodt, pOrgID, pOrgAddressID, HomeUDT.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine db = new DBEngine())
                {
                    returnCode = db.ExecuteDataSet(cmd, out ds);
                }
                if (ds != null)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBookingsdata);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing GetBookingsdetailsforBulkReg in HomeCollection_DL", ex);
            }
            return returnCode;
        }
        public long ValidateBulkBookingDetails(List<HCBookingData> BulkReg, out List<HCBookingData> lstCamp, out List<HCTestDetails> lstTestDetails)
        {
            lstCamp = new List<HCBookingData>();
            lstTestDetails = new List<HCTestDetails>();
            long returncode = -1;
            int rsCount = 0;
          //  IDataReader dataReader = null;
            DataTable dtBulkReg = HomeUDT.ConvertToUDTHCBookingData(BulkReg);
            
            DataSet ds = new DataSet();
           //   SqlCommand cmd = Command.pValidateBulkBookingDetailsCommand(dtBulkReg, HomeUDT.ConvertToUDT_Context(globalContextDetails));

              try
              {
                  SqlCommand cmd = Command.pValidateBulkBookingDetailsCommand(dtBulkReg, HomeUDT.ConvertToUDT_Context(globalContextDetails));
                  using (DBEngine db = new DBEngine())
                  {
                      returncode = db.ExecuteDataSet(cmd, out ds);
                  }
                  if (ds != null)
                  {
                      if (ds.Tables[0].Rows.Count > 0)
                      {
                          returncode = Utilities.ConvertTo(ds.Tables[0], out lstCamp);
                      }
                      if (ds.Tables[1].Rows.Count > 0)
                      {
                          returncode = Utilities.ConvertTo(ds.Tables[1], out lstTestDetails);
                      }
                  }
              }
              catch (Exception ex)
              {
                  CLogger.LogError("Error while Executing GetBookingsdetailsforBulkReg in HomeCollection_DL", ex);
              }

              //using (DBEngine dbEngine = new DBEngine())
              //{
              //    dataReader = dbEngine.ExecuteReader(cmd);
              //    if (dataReader != null)
              //    {
              //        do
              //        {
              //            if (rsCount == 0)
              //            {
              //                returncode = Utilities.ConvertTo(dataReader, out lstCamp);
              //            }
              //            else if (rsCount == 1)
              //            {
              //                returncode = Utilities.ConvertTo(dataReader, out lstTestDetails);
              //            }
              //            rsCount = rsCount + 1;
              //        } while (dataReader.NextResult());
              //        dataReader.Close();
              //    }
              //}
            return returncode;

        }
        public long SaveBookingDetails(List<HCBookingData> lstBookings,out List<HCBookingData> lstresult)
        {
            long returnCode = -1;
        //    DataTable objHCBookingData;

            IDataReader dataReader = null;
            lstresult = new List<HCBookingData>();
            DataTable BookData = HomeUDT.ConvertToSaveUDTHCBookingData(lstBookings);

            SqlCommand cmd = Command.pInsertBulkBookingCommand(BookData, UDT_DAL.ConvertToUDT_Context(globalContextDetails), out returnCode);
         //   SqlCommand cmd = Command.pInsertBulkBookingCommand(objStockReceived, UDT_DAL.ConvertToUDT_Context(globalContextDetails), out returnCode);
            using (DBEngine dbEngine = new DBEngine())
            {
                dataReader = dbEngine.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    Utilities.ConvertTo(dataReader, out lstresult);
                    dataReader.Close();
                }


                //dbEngine.ExecuteTransactionalNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@returnStatus"].Value);
            }
            return returnCode;
        }
        #endregion
    }
}
