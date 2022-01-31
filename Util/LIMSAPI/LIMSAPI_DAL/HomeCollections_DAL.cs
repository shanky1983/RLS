
using Attune.Kernel.DataAccessEngine;
using Attune.Kernel.LIMSAPI.BusinessEntities;
using Attune.Kernel.LIMSAPI.Cmd;
using Attune.Kernel.LIMSAPI.UDT; 
using Attune.Kernel.PlatForm.Utility;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.DAL
{
    public class HomeCollections_DAL
    {
        #region Constructor Part
        ContextDetails globalContextDetails;
        public HomeCollections_DAL(ContextDetails localContextDetails)
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
                SqlCommand cmd = HomeCollections_CMD.pGetServiceQuotationDetailsCommand(bookingID, OrgID, HomeCollections_UDT.ConvertToUDT_Context(globalContextDetails));
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
        public long SaveServiceQuotationDetails(Bookings oBookings, List<OrderedInvestigations> lstOrderedInves, List<OrderedInvestigations> lstPreOrder, int OrgID, long LID, out long bookingID)
        {
            long returnCode = -1;
            DataTable dtServiceQuotation = HomeCollections_UDT.ConvertToHCServiceQuotation(oBookings);
            DataTable invs = HomeCollections_UDT.ConvertToHCOrderedInvestigation(lstOrderedInves);
            DataTable PreOrdinvs = HomeCollections_UDT.ConvertToHCPreOrdered(lstPreOrder);
            SqlCommand cmd = HomeCollections_CMD.pHCSaveServiceQuotationDetailsCommand(dtServiceQuotation, invs, PreOrdinvs, OrgID, LID, out bookingID, HomeCollections_UDT.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dBEngine = new DBEngine())
            {
                returnCode = dBEngine.ExecuteNonQuery(cmd);
                bookingID = Convert.ToInt64(cmd.Parameters["@pBookingID"].Value);

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
                SqlCommand cmd = HomeCollections_CMD.pGetHCBookingDetailsCommand(CollectionTime,
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
                  HomeCollections_UDT.ConvertToUDT_Context(globalContextDetails), MobileNumber, TelePhone, pName, pageSize, startRowIndex, BookingNumber
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
        #endregion
        #region HomeCollection Booking Details
        public long UpdateHCBookingDetails(List<Bookings> lstBookings, List<OrderedInvestigations> lstOrderedInves, int OrgID, long LID, out long bookingID)
        {
            long returnCode = -1;
            // DataTable dtServiceQuotation = UDT_DAL.ConvertToServiceQuotation(oBookings);
            DataTable dtServiceQuotation = HomeCollections_UDT.ConvertToHomeBooking(lstBookings);
            DataTable invs = HomeCollections_UDT.ConvertToOrderedInvestigation(lstOrderedInves);
            SqlCommand cmd = HomeCollections_CMD.pUpdateHCBookingDetailsCommand(dtServiceQuotation, invs, OrgID, LID, out bookingID, HomeCollections_UDT.ConvertToUDT_Context(globalContextDetails));
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
            DataTable dtServiceQuotation = HomeCollections_UDT.ConvertToHomeBooking(lstBookings);
            DataTable invs = HomeCollections_UDT.ConvertToOrderedInvestigation(lstOrderedInves);
            SqlCommand cmd = HomeCollections_CMD.pUpdateHCBookingDetailsCommand(dtServiceQuotation, invs, OrgID, LID, out bookingID, HomeCollections_UDT.ConvertToUDT_Context(globalContextDetails));
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
                SqlCommand cmd = HomeCollections_CMD.pGetOrglocationMapCommand(Convert.ToInt32(OrgID), addid, chid, HomeCollections_UDT.ConvertToUDT_Context(globalContextDetails));
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
        public long GetHCMapBookingDetails(long BookingNumber, long pUserID,
                                 out List<BookingInfo> lstBooking, out List<BookingInfo> lstCollection, out List<BookingInfo> lstBookingHistory)
        {
            long returnCode = -1;
            lstBooking = new List<BookingInfo>();
            lstCollection = new List<BookingInfo>();
            lstBookingHistory = new List<BookingInfo>();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = HomeCollections_CMD.pGetHCMapBookingDetailsCommand(BookingNumber, pUserID, HomeCollections_UDT.ConvertToUDT_Context(globalContextDetails));
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
        #endregion

        #region MetaData Starts

        public long LoadMetaDataOrgMapping(List<MetaData> lstDomain, long OrgID, string LangCode, out NameValueCollection objectcollection)
        {
            long returnCode = -1;
            objectcollection = new NameValueCollection();
            try
            {
                DataTable dtMetaData = HomeCollections_UDT.ConvertToUDTMetaData(lstDomain);

                DataSet ds = new DataSet();
                SqlCommand cmd = HomeCollections_CMD.pLoadMetaDataOrgMappingCommand(dtMetaData, OrgID, LangCode, HomeCollections_UDT.ConvertToUDT_Context(globalContextDetails));
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


        public long GetBillingItems(int OrgID, string FeeType, string Description, long ClientID, string IsMappedItem, string Remarks, string Gender, out List<BillingFeeDatails> lstBillingFeeDetails)
        {
            long lresult = -1;
            DataSet ds = new DataSet();
            lstBillingFeeDetails = new List<BillingFeeDatails>();

            SqlCommand cmd = new SqlCommand();
            cmd = HomeCollections_CMD.pGetBillingItemsCommand(OrgID, FeeType, Description, ClientID, IsMappedItem, Remarks, Gender, HomeCollections_UDT.ConvertToUDT_Context1(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstBillingFeeDetails);
                }
            }

            return lresult;

        }

        public long GetHCBillingClientName(string prefixText, int OrgID, string pType, long refhospid, out List<InvClientMaster> lstInvClientMaster)
        {
            long lresult = -1;
            DataSet ds = new DataSet();
            lstInvClientMaster = new List<InvClientMaster>();

            SqlCommand cmd = new SqlCommand();
            cmd = HomeCollections_CMD.pGetBillingClientNameCommand(prefixText, OrgID, pType, refhospid, HomeCollections_UDT.ConvertToUDT_Context1(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstInvClientMaster);
                }
            }

            return lresult;

        }
        public long GetHCBillingTechnicianName(int OrgID, long RoleID, out List<Users> lstResult)
        {
            long lresult = -1;
            DataSet ds = new DataSet();
            lstResult = new List<Users>();

            SqlCommand cmd = new SqlCommand();
            cmd = HomeCollections_CMD.pGetHCBillingTechnicianNameCommand(OrgID, RoleID, HomeCollections_UDT.ConvertToUDT_Context1(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstResult);
                }
            }

            return lresult;

        }
        public long GetLocationforHomeCollectionpincode(long pincode, long LocationID, string LocationName, out List<Location> lstLocationforHomeCollection)
        {
            long lresult = -1;
            DataSet ds = new DataSet();
            lstLocationforHomeCollection = new List<Location>();

            SqlCommand cmd = new SqlCommand();
            cmd = HomeCollections_CMD.pGetLocationforHomeCollectionCommand(pincode, LocationID, LocationName, HomeCollections_UDT.ConvertToUDT_Context1(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstLocationforHomeCollection);
                }
            }

            return lresult;

        }

        public long GetCollectionCenter(int orgId, long loginID, long roleID, out List<Location> lstLocationforHomeCollection)
        {
            long lresult = -1;
            DataSet ds = new DataSet();
            lstLocationforHomeCollection = new List<Location>();

            SqlCommand cmd = new SqlCommand();
            cmd = HomeCollections_CMD.pGetLocationCommand(orgId, loginID, roleID, HomeCollections_UDT.ConvertToUDT_Context1(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstLocationforHomeCollection);
                }
            }

            return lresult;

        }
        public long GetOrganizations(long loginID, out List<Role1> lstResult)
        {
            long lresult = -1;
            DataSet ds = new DataSet();
            lstResult = new List<Role1>();

            SqlCommand cmd = new SqlCommand();
            cmd = HomeCollections_CMD.pGetUserRolesCommand(loginID, HomeCollections_UDT.ConvertToUDT_Context1(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstResult);
                }
            }

            return lresult;

        }


        public long GetSampleCollectionPersonList(int OrgID, string PrefixText, long pPinCode, out List<Users> lstResult)
        {
            long lresult = -1;
            DataSet ds = new DataSet();
            lstResult = new List<Users>();

            SqlCommand cmd = new SqlCommand();
            cmd = HomeCollections_CMD.pGetSampleCollectionPersonListCommand(OrgID, PrefixText, pPinCode, HomeCollections_UDT.ConvertToUDT_Context1(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstResult);
                }
            }

            return lresult;

        }

        public long GetWorkingDays(out List<MetaDataFormat> lstResult)
        {
            long lresult = -1;
            DataSet ds = new DataSet();
            lstResult = new List<MetaDataFormat>();

            SqlCommand cmd = new SqlCommand();
            cmd = HomeCollections_CMD.pGetWorkingDaysCommand(HomeCollections_UDT.ConvertToUDT_Context1(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstResult);
                }
            }

            return lresult;

        }

        public long GetPinCode(string PrefixText, string pMode, out List<PinCodeList> lstResult)
        {
            long lresult = -1;
            DataSet ds = new DataSet();
            lstResult = new List<PinCodeList>();

            SqlCommand cmd = new SqlCommand();
            cmd = HomeCollections_CMD.pGetPinCode(PrefixText,  pMode,  HomeCollections_UDT.ConvertToUDT_Context1(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstResult);
                }
            }

            return lresult;

        }

        public long GetHoliday(out List<HolidayList> lstResult)
        {
            long lresult = -1;
            DataSet ds = new DataSet();
            lstResult = new List<HolidayList>();

            SqlCommand cmd = new SqlCommand();
            cmd = HomeCollections_CMD.pGetHoliday(HomeCollections_UDT.ConvertToUDT_Context1(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstResult);
                }
            }

            return lresult;

        }


        public long PostSCPSchedule(string pOrgCode, string pSCPerson, string pPinCode, long pUserID, List<SCPTimeinfo> lstTime, List<SCPLeaveinfo> lstLeave, out long pOutstring)
        {
            long returnCode = -1;

            DataTable dtTime = new DataTable();
            DataTable dtLeave = new DataTable();
            DataTable dtTest = new DataTable();
            DataTable dtSamples = new DataTable();
            dtTime = HomeCollections_UDT.ConvertToSCPTimeSlot(lstTime);
            dtLeave = HomeCollections_UDT.ConvertToSCPLeaveSlot(lstLeave);


            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = HomeCollections_CMD.pPostSCPSchedule_LIMSAPICommand(pOrgCode, pSCPerson, pPinCode, pUserID, dtTime, dtLeave, out pOutstring);
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
                pOutstring = Convert.ToInt64( cmd.Parameters["@pOutResult"].Value);
            }
            return returnCode;
        }


        public long PostUpdateSCPSchedule( long pResourceTemplateID, string pPinCode, long pUserID, List<SCPTimeinfo> lstTime, List<SCPLeaveinfo> lstLeave)
        {
            long returnCode = -1;

            DataTable dtTime = new DataTable();
            DataTable dtLeave = new DataTable();
            DataTable dtTest = new DataTable();
            DataTable dtSamples = new DataTable();
            dtTime = HomeCollections_UDT.ConvertToSCPTimeSlot(lstTime);
            dtLeave = HomeCollections_UDT.ConvertToSCPLeaveSlot(lstLeave);


            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = HomeCollections_CMD.pPostUpdateSCPSchedule_LIMSAPICommand( pResourceTemplateID, pPinCode, pUserID, dtTime, dtLeave);
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
               
            }
            return returnCode;
        }

        public long GetScheduleBySCPDetails(string pOrgCode, string pSCPerson, out List<SCPTimeinfo> lstTime, out List<SCPLeaveinfo> lstLeave, out List<SCPPinCodeinfo> lstPinCode, out List<SCPTime> lstSCP)
        {
            long returnCode = -1;

            lstTime = new List<SCPTimeinfo>();
            lstLeave = new List<SCPLeaveinfo>();
            lstPinCode = new List<SCPPinCodeinfo>();
            lstSCP = new List<SCPTime>();

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = HomeCollections_CMD.pGetScheduleBySCPDetails_LIMSAPICommand(pOrgCode, pSCPerson);
            using (DBEngine dbEngine = new DBEngine(false))
            {
                returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

               

                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstTime);

                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstLeave);

                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPinCode);

                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstSCP);

                }



            }
            return returnCode;
        }


        public long GetSCPBookingslot(long pPinCode, string pSCPPerson, DateTime pCheckDate, long pUserID, int PPageCount, out List<SCPBookingslot> lstSlot, out List<SCPBookingTimeWiseSlot> lstTimeWiseSlot, out List<SCPBookingCount> lstBookingCount)
        {
            long returnCode = -1;


            lstSlot = new List<SCPBookingslot>();
            lstTimeWiseSlot = new List<SCPBookingTimeWiseSlot>();
            lstBookingCount = new List<SCPBookingCount>();

            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = HomeCollections_CMD.pGetSCPBookingslot_LIMSAPICommand(pPinCode, pSCPPerson, pCheckDate, pUserID, PPageCount);
            using (DBEngine dbEngine = new DBEngine(false))
            {
                returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstSlot);

                }

                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstTimeWiseSlot);

                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstBookingCount);

                }

            }
            return returnCode;
        }

        public long PostUpdateBookingSchedule(string pBookingID, string pTechID, string pBookingDate, string pLoginID)
        {
            long lresult = -1;
            DataSet ds = new DataSet();      

            SqlCommand cmd = new SqlCommand();
            cmd = HomeCollections_CMD.PostUpdateBookingSchedule(pBookingID, pTechID, pBookingDate, pLoginID);
            using (DBEngine dbEngine = new DBEngine())
            {
                lresult = dbEngine.ExecuteNonQuery(cmd);
            }
            return lresult;
        }
        public long CheckDuplicateBookingSlot(string pPincode, string pUserID, DateTime pCollectionTime, out long pOutstring)
        {
            long lresult = -1;
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = HomeCollections_CMD.CheckDuplicateBookingSlot(pPincode, pUserID, pCollectionTime, out pOutstring);
            using (DBEngine dbEngine = new DBEngine())
            {
                lresult = dbEngine.ExecuteDataSet(cmd, out ds);
                pOutstring = Convert.ToInt64( ds.Tables[0].Rows[0][0].ToString());
            }
            return lresult;
        }
    }
}
