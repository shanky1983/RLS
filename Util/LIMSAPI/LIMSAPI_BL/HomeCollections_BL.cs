using Attune.Kernel.LIMSAPI.BusinessEntities;
using Attune.Kernel.LIMSAPI.DAL; 
using Attune.Kernel.PlatForm.Utility;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attune.Kernel.LIMSAPI.BL
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
                HomeCollections_DAL scheduleDAL = new HomeCollections_DAL(globalContextDetails);
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
        public long SaveServiceQuotationDetails(Bookings oBookings, List<OrderedInvestigations> lstOrderedInves, List<OrderedInvestigations> lstPreOrder, int OrgID, long LID, out long bookingID)
        {
            long returnCode = -1;
            try
            {
                HomeCollections_DAL scheduleDAL = new HomeCollections_DAL(globalContextDetails);
                returnCode = scheduleDAL.SaveServiceQuotationDetails(oBookings, lstOrderedInves, lstPreOrder, OrgID, LID, out bookingID);
            }
            catch (Exception ex)
            {
                returnCode = -1;
                CLogger.LogError("Error in SaveServiceQuotationDetails", ex);
                throw ex;
            }

            return returnCode;
        }
        #endregion
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
                returnCode = new HomeCollections_DAL(globalContextDetails).GetHCBookingDetails(CollectionTime,
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
                out lstOrdInvDetails, out lstPreOrdInvDetails, out lstHomeCollectionDetails);
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
                HomeCollections_DAL HomeCollectionsDAL = new HomeCollections_DAL(globalContextDetails);
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
                HomeCollections_DAL HomeCollectionsDAL = new HomeCollections_DAL(globalContextDetails);
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
            HomeCollections_DAL arDAL = new HomeCollections_DAL(globalContextDetails);
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
        public long GetHCMapBookingDetails(long BookingNumber, long pUserID,
                                out List<BookingInfo> lstBooking, out List<BookingInfo> lstCollection, out List<BookingInfo> lstBookingHistory)
        {
            long returnCode = -1;
            lstBooking = new List<BookingInfo>();
            lstCollection = new List<BookingInfo>();
            lstBookingHistory = new List<BookingInfo>();
            try
            {
                returnCode = new HomeCollections_DAL(globalContextDetails).GetHCMapBookingDetails(BookingNumber, pUserID, out lstBooking, out lstCollection, out lstBookingHistory);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetBookingDetails in LISAPI_BL", ex);
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
                returnCode = new HomeCollections_DAL(globalContextDetails).LoadMetaDataOrgMapping(lstDomain, OrgID, LangCode, out objectcollection);

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



        public long GetBillingItems(int OrgID, string FeeType, string Description, long ClientID, string IsMappedItem, string Remarks, string Gender, out List<BillingFeeDatails> lstBillingFeeDetails)
        {
            long returnCode = -1;
            lstBillingFeeDetails = null;
            try
            {

                returnCode = new HomeCollections_DAL(globalContextDetails).GetBillingItems(OrgID, FeeType, Description, ClientID, IsMappedItem, Remarks, Gender, out lstBillingFeeDetails);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing homeCollection Autocomplete text in Patient_BL", excp);
            }

            return returnCode;
        }

        public long GetHCBillingClientName(string prefixText, int OrgID, string pType, long refhospid, out List<InvClientMaster> lstInvClientMaster)
        {
            long returnCode = -1;
            lstInvClientMaster = null;
            try
            {

                returnCode = new HomeCollections_DAL(globalContextDetails).GetHCBillingClientName(prefixText, OrgID, pType, refhospid, out lstInvClientMaster);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing homeCollection Autocomplete text in Patient_BL", excp);
            }

            return returnCode;
        }

        public long GetHCBillingTechnicianName(int OrgID, long RoleID, out List<Users> lstResult)
        {
            long returnCode = -1;
            lstResult = null;
            try
            {

                returnCode = new HomeCollections_DAL(globalContextDetails).GetHCBillingTechnicianName(OrgID, RoleID, out lstResult);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing homeCollection Autocomplete text in Patient_BL", excp);
            }

            return returnCode;
        }

        public long GetLocationforHomeCollectionpincode(long pincode, long LocationID, string LocationName, out List<Location> lstLocationforHomeCollection)
        {
            long returnCode = -1;
            lstLocationforHomeCollection = null;
            try
            {

                returnCode = new HomeCollections_DAL(globalContextDetails).GetLocationforHomeCollectionpincode(pincode, LocationID, LocationName, out lstLocationforHomeCollection);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing homeCollection Autocomplete text in Patient_BL", excp);
            }

            return returnCode;
        }

        public long GetCollectionCenter(int orgId, long loginID, long roleID, out List<Location> lstLocationforHomeCollection)
        {
            long returnCode = -1;
            lstLocationforHomeCollection = null;
            try
            {

                returnCode = new HomeCollections_DAL(globalContextDetails).GetCollectionCenter(orgId, loginID, roleID, out lstLocationforHomeCollection);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing homeCollection Autocomplete text in Patient_BL", excp);
            }

            return returnCode;
        }


        public long GetOrganizations(long loginID, out List<Role1> lstResult)
        {
            long returnCode = -1;
            lstResult = null;
            try
            {

                returnCode = new HomeCollections_DAL(globalContextDetails).GetOrganizations(loginID, out lstResult);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing homeCollection Autocomplete text in Patient_BL", excp);
            }

            return returnCode;
        }


        public long GetSampleCollectionPersonList(int OrgID, string PrefixText, long pPinCode, out List<Users> lstResult)
        {
            long returnCode = -1;
            lstResult = null;
            try
            {

                returnCode = new HomeCollections_DAL(globalContextDetails).GetSampleCollectionPersonList(OrgID, PrefixText, pPinCode, out lstResult);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing homeCollection Autocomplete text in HC_BL", excp);
            }

            return returnCode;
        }


        public long GetWorkingDays(out List<MetaDataFormat> lstResult)
        {
            long returnCode = -1;
            lstResult = null;
            try
            {

                returnCode = new HomeCollections_DAL(globalContextDetails).GetWorkingDays(out lstResult);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing homeCollection Autocomplete text in HC_BL", excp);
            }

            return returnCode;
        }

        public long GetPinCode(string PrefixText, string pMode, out List<PinCodeList> lstResult)
        {
            long returnCode = -1;
            lstResult = null;
            try
            {

                returnCode = new HomeCollections_DAL(globalContextDetails).GetPinCode(PrefixText,  pMode, out lstResult);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing homeCollection Autocomplete text in HC_BL", excp);
            }

            return returnCode;
        }

        public long GetHoliday( out List<HolidayList> lstResult)
        {
            long returnCode = -1;
            lstResult = null;
            try
            {

                returnCode = new HomeCollections_DAL(globalContextDetails).GetHoliday(out lstResult);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing homeCollection holiday text in HC_BL", excp);
            }

            return returnCode;
        }


        public long PostSCPSchedule(string pOrgCode, string pSCPerson,  string pPinCode, long pUserID,  List<SCPTimeinfo> lstTime, List<SCPLeaveinfo> lstLeave, out long pOutstring)
        {
            long returnCode = -1;
            pOutstring = 0;

            try
            {
                returnCode = new HomeCollections_DAL(globalContextDetails).PostSCPSchedule(pOrgCode, pSCPerson, pPinCode, pUserID, lstTime, lstLeave, out pOutstring);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing insert scp in LIMSAPI_BL", ex);
            }
            return returnCode;
        }

        public long PostUpdateSCPSchedule(long pResourceTemplateID, string pPinCode, long pUserID, List<SCPTimeinfo> lstTime, List<SCPLeaveinfo> lstLeave)
        {
            long returnCode = -1;

            try
            {
                returnCode = new HomeCollections_DAL(globalContextDetails).PostUpdateSCPSchedule( pResourceTemplateID, pPinCode, pUserID, lstTime, lstLeave);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing insert scp in HC_BL", ex);
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

            try
            {
                returnCode = new HomeCollections_DAL(globalContextDetails).GetScheduleBySCPDetails(pOrgCode, pSCPerson, out lstTime, out lstLeave, out lstPinCode, out lstSCP);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing get scp in LIMSAPI_BL", ex);
            }

            return returnCode;
        }


        public long GetSCPBookingslot(long pPinCode, string pSCPPerson, DateTime pCheckDate, long pUserID, int PPageCount, out List<SCPBookingslot> lstSlot, out List<SCPBookingTimeWiseSlot> lstTimeWiseSlot, out List<SCPBookingCount> lstBookingCount)
        {
            long returnCode = -1;

            lstSlot = new List<SCPBookingslot>();
            lstTimeWiseSlot = new List<SCPBookingTimeWiseSlot>();
            lstBookingCount = new List<SCPBookingCount>();

            try
            {
                returnCode = new HomeCollections_DAL(globalContextDetails).GetSCPBookingslot(pPinCode, pSCPPerson, pCheckDate, pUserID, PPageCount, out lstSlot, out lstTimeWiseSlot, out lstBookingCount);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing get scp in HC_BL", ex);
            }

            return returnCode;
        }

        public long PostUpdateBookingSchedule(string pBookingID, string pTechID, string pBookingDate, string pLoginID)
        {
            long returnCode = -1;
            try
            {
                returnCode = new HomeCollections_DAL(globalContextDetails).PostUpdateBookingSchedule(pBookingID, pTechID, pBookingDate, pLoginID);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing homeCollection Autocomplete text in HC_BL", excp);
            }
            return returnCode;
        }
        public long CheckDuplicateBookingSlot(string pPincode, string pUserID, DateTime pCollectionTime, out long pOutstring)
        {
            long returnCode = -1;
            pOutstring = 0;
            try
            {
                returnCode = new HomeCollections_DAL(globalContextDetails).CheckDuplicateBookingSlot(pPincode, pUserID, pCollectionTime, out pOutstring);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing homeCollection Autocomplete text in HC_BL", excp);
            }
            return returnCode;
        }
    }
}
