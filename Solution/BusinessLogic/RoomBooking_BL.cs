using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Attune.Podium.BusinessEntities;
using Attune.Solution.DAL;
using Attune.Podium.Common;

namespace Attune.Solution.BusinessComponent
{
    public class RoomBooking_BL
    {
          ContextDetails globalContextDetails;
        public RoomBooking_BL()
        {

        }
        public RoomBooking_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public long GetRoomBook(int pOrgID, int pOrgAddID, DateTime FromDate, string rType, out List<FloorMaster> lstFloor,
              out List<BedMaster> lstBed, out List<RoomBookingDetails> lstRooms)
        //, out List<RoomMaster> lstRoom, , out List<BedBooking> lstBooking)
        {
            long lresult = -1;

            lstFloor = new List<FloorMaster>();
            //lstRoom = new List<RoomMaster>();
            lstBed = new List<BedMaster>();
            //lstBooking = new List<BedBooking>();
            lstRooms = new List<RoomBookingDetails>();

            RoomBooking_DAL roomBookingDAL = new RoomBooking_DAL(globalContextDetails);
            roomBookingDAL.GetRoomBook(pOrgID, pOrgAddID, FromDate, rType, out lstFloor, out lstBed, out lstRooms);
            //, out lstRoom, out lstBed, out lstBooking);
            return lresult;

        }
        public long GetBookingDetails(int pOrgID, int pOrgAddID,int BedID, out List<RoomBookingDetails> lstRooms)
        {
            long lresult = -1;
            lstRooms = new List<RoomBookingDetails>();

            RoomBooking_DAL roomBookingDAL = new RoomBooking_DAL(globalContextDetails);
            roomBookingDAL.GetBookingDetails(pOrgID, pOrgAddID, BedID, out lstRooms);
            return lresult;
        }

        public long GetAvailableBedsByTime(int pOrgID, int pOrgAddID, string FromDate, string ToDate,int BedID, out List<RoomBookingDetails> lstAvailableBedsByTime)
        {
            long lresult = -1;
            lstAvailableBedsByTime = new List<RoomBookingDetails>();

            RoomBooking_DAL roomBookingDAL = new RoomBooking_DAL(globalContextDetails);
            roomBookingDAL.GetAvailableBedsByTime(pOrgID, pOrgAddID, FromDate, ToDate,BedID, out lstAvailableBedsByTime);
            return lresult;
        }
        public long GetBedBookedDetails(int pOrgID, int pOrgAddID, int BedID, string FromDate, string ToDate, out List<RoomBookingDetails> lstBedBookingDetail)
        {
            long lresult = -1;
            lstBedBookingDetail = new List<RoomBookingDetails>();

            RoomBooking_DAL roomBookingDAL = new RoomBooking_DAL(globalContextDetails);
            roomBookingDAL.GetBedBookedDetails(pOrgID, pOrgAddID, BedID, FromDate, ToDate, out lstBedBookingDetail);
            return lresult;
        }
        

        public long GetRoomsList(int pOrgAddID, out List<RoomBookingDetails> lstDatas, string sFromDate, string sToDate)
        {
            long lresult = -1;
            lstDatas = new List<RoomBookingDetails>();
            RoomBooking_DAL roomBookingDAL = new RoomBooking_DAL(globalContextDetails);
            roomBookingDAL.GetRoomsList(pOrgAddID, out lstDatas, sFromDate, sToDate);
            return lresult;

        }
        public long GetRoomsType(int pOrgID, int pOrgAddID, int RoomTypeID, string RtName, out List<RoomType> lstDatas)
        {
            long lresult = -1;
            lstDatas = new List<RoomType>();
            RoomBooking_DAL roomTypeDAL = new RoomBooking_DAL(globalContextDetails);
            roomTypeDAL.GetRoomTypeList(pOrgID, pOrgAddID, RoomTypeID, RtName, out lstDatas);
            return lresult;

        }

        public long GetRoomsFeesType(int pOrgID, int pOrgAddressID, out List<RoomDetails> lstDetails, out List<RoomDetails> lstDatas)
        {
            long lresult = -1;
            lstDatas = new List<RoomDetails>();
            lstDetails = new List<RoomDetails>();
            RoomBooking_DAL roomTypeDAL = new RoomBooking_DAL(globalContextDetails);
            roomTypeDAL.GetRoomFeesTypeList(pOrgID, pOrgAddressID, out lstDetails, out lstDatas);
            return lresult;

        }


        public long SaveBedbooking(BedBookingDetails bedBooking, long pCreatedBy)
        {
            long result = -1;
            RoomBooking_DAL bed = new RoomBooking_DAL(globalContextDetails);
            bed.SaveBedbooking(bedBooking, pCreatedBy);
            return result;
        }
        public long GetRoomsListSchedule(int pOrgAddID, out List<RoomBookingDetails> lstDatas, string sFromDate, string sToDate, int iBedID)
        {
            long lresult = -1;
            lstDatas = new List<RoomBookingDetails>();
            RoomBooking_DAL roomBookingDAL = new RoomBooking_DAL(globalContextDetails);
            roomBookingDAL.GetRoomsListSchedule(pOrgAddID, out lstDatas, sFromDate, sToDate, iBedID);
            return lresult;

        }
        public long SaveRoomTransferDetails(InPatientLocationTransferDetails RoomtransferDetails, string sPatientName, string sDescription, DateTime sTodate)
        {
            long result = -1;
            RoomBooking_DAL bed = new RoomBooking_DAL(globalContextDetails);
            result = bed.SaveRoomTransferDetails(RoomtransferDetails, sPatientName, sDescription, sTodate);
            return result;
        }

        public long GetRoomsListByVisitID(int pOrgAddID, long iVisitID, out List<RoomBookingDetails> lstFloor, out string roomStatus)
        {
            long lresult = -1;
            lstFloor = new List<RoomBookingDetails>();
            RoomBooking_DAL roomBookingDAL = new RoomBooking_DAL(globalContextDetails);
            lresult = roomBookingDAL.GetRoomsListByVisitID(pOrgAddID, iVisitID, out lstFloor, out roomStatus);
            return lresult;

        }
        public long GetFloorMaster(int pOrgID, int pOrgAddID, out List<FloorMaster> lstDatas)
        {
            long lresult = -1;
            lstDatas = new List<FloorMaster>();
            RoomBooking_DAL roomTypeDAL = new RoomBooking_DAL(globalContextDetails);
            roomTypeDAL.GetFloorMasterList(pOrgID, pOrgAddID, out lstDatas);
            return lresult;
        }
        public long GetBedMaster(int pOrgID, int pOrgAddID, out List<BedMaster> lstDatas)
        {
            long lresult = -1;
            lstDatas = new List<BedMaster>();
            RoomBooking_DAL roomTypeDAL = new RoomBooking_DAL(globalContextDetails);
            roomTypeDAL.GetBedMasterList(pOrgID, pOrgAddID, out lstDatas);
            return lresult;

        }
        public long GetRoomList(int pOrgID, int pOrgAddID, out List<RoomMaster> lstDatas)
        {
            long lresult = -1;
            lstDatas = new List<RoomMaster>();
            RoomBooking_DAL roomTypeDAL = new RoomBooking_DAL(globalContextDetails);
            roomTypeDAL.GetRoomList(pOrgID, pOrgAddID, out lstDatas);
            return lresult;

        }

        public long SaveRoomDetails(RoomMaster RoomMas, List<BedMaster> bedmaster, string BedDeleted)
        {
            long result = -1;
            try
            {

                RoomBooking_DAL RoomMaster = new RoomBooking_DAL(globalContextDetails);
                result = RoomMaster.SaveRoomDetails(RoomMas, bedmaster, BedDeleted);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing  BL", ex);
            }
            return result;
        }
        
        public long SaveRoomMasterData(string pType, int OrgId, int OrgAddID, List<RoomDetails> lstRoomDetails, string IsSlotable, string IsAnOT)
        {
            long result = -1;
            try
            {
                RoomBooking_DAL RoomMaster = new RoomBooking_DAL(globalContextDetails);
                result = RoomMaster.SaveRoomMasterData(pType, OrgId, OrgAddID, lstRoomDetails, IsSlotable, IsAnOT);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing  BL", ex);
            }
            return result;
        }
        public long DeleteRoomDetails(string RoomIds)
        {
            long result = -1;
            try
            {

                RoomBooking_DAL RoomMaster = new RoomBooking_DAL(globalContextDetails);
                result = RoomMaster.DeleteRoomDetails(RoomIds);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing  BL", ex);
            }
            return result;
        }
        public long DeleteRoomDetails(string tableName, string IDCol, long IdVal)
        {
            long result = -1;
            try
            {

                RoomBooking_DAL RoomMaster = new RoomBooking_DAL(globalContextDetails);
                result = RoomMaster.DeleteMasterDetails(tableName, IDCol, IdVal);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing  BL", ex);
            }
            return result;
        }
        public long GetWard(int pOrgID, int pOrgAddID, out List<WardMaster> lstDatas)
        {
            long lresult = -1;
            lstDatas = new List<WardMaster>();
            RoomBooking_DAL roomTypeDAL = new RoomBooking_DAL(globalContextDetails);
            roomTypeDAL.GetWard(pOrgID, pOrgAddID, out lstDatas);
            return lresult;

        }
        public long GetBuilding(int pOrgID, int pOrgAddID, out List<BuildingMaster> lstDatas)
        {
            long lresult = -1;
            lstDatas = new List<BuildingMaster>();
            RoomBooking_DAL roomTypeDAL = new RoomBooking_DAL(globalContextDetails);
            roomTypeDAL.GetBuilding(pOrgID, pOrgAddID, out lstDatas);
            return lresult;

        }
        public long GetMaster(string tableName, string IDcol, long IDval, string REFcol, string REFtable, string ref_OrgID, int ref_Orgval, long REFval, string TXTcol, string TXTval, int pOrgID, out DataSet Ds)
        {
            long lresult = -1;
            Ds = new DataSet();
            RoomBooking_DAL roomTypeDAL = new RoomBooking_DAL(globalContextDetails);
            roomTypeDAL.GetMaster(tableName, IDcol, IDval, REFcol, REFtable, ref_OrgID, ref_Orgval, REFval, TXTcol, TXTval, pOrgID, out Ds);
            return lresult;
        }

        public long GetConsultantName(string FilterText, int OrgID, out List<Physician> lstPhysician)
        {
            long returnCode = -1;
            lstPhysician = new List<Physician>();
            try
            {

                RoomBooking_DAL roomFilterDAL = new RoomBooking_DAL(globalContextDetails);
                returnCode = roomFilterDAL.GetConsultantName(FilterText, OrgID, out lstPhysician);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetConsultantName RoomBooking_BL", e);
            }
            return returnCode;
        }

        public long GetBedPatientName(string FilterText, int OrgID, out List<Patient> lstPatient)
        {
            long returnCode = -1;
            lstPatient = new List<Patient>();
            try
            {

                RoomBooking_DAL roomFilterDAL = new RoomBooking_DAL(globalContextDetails);
                returnCode = roomFilterDAL.GetBedPatientName(FilterText, OrgID, out lstPatient);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetBedPatientName RoomBooking_BL", e);
            }
            return returnCode;
        }

        public long LoadRoomMasterDetails(string pType, int pOrgID, int pOrgAddID, int pBuildingID, out List<RoomDetails> lstDatas)
        {
            long returnCode = -1;
            lstDatas = new List<RoomDetails>();
            try
            {
                RoomBooking_DAL roomTypeDAL = new RoomBooking_DAL(globalContextDetails);
                returnCode = roomTypeDAL.LoadRoomMasterDetails(pType, pOrgID, pOrgAddID, pBuildingID, out lstDatas);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing LoadRoomMasterDetails RoomBooking_BL", e);
            }
            return returnCode;

        }
        public long GetRoomDetails(int pOrgID, int pOrgAddID, out List<RoomDetails> lstBuildingDatas
            , out List<RoomDetails> lstFloorDatas
            , out List<RoomDetails> lstWardDatas
            , out List<RoomDetails> lstRoomTypeDatas)
        {
            long returnCode = -1;
            lstBuildingDatas = new List<RoomDetails>();
            lstFloorDatas = new List<RoomDetails>();
            lstWardDatas = new List<RoomDetails>();
            lstRoomTypeDatas = new List<RoomDetails>();
            try
            {
                RoomBooking_DAL roomTypeDAL = new RoomBooking_DAL(globalContextDetails);
                returnCode = roomTypeDAL.GetRoomDetails(pOrgID, pOrgAddID, out lstBuildingDatas, out lstFloorDatas, out lstWardDatas, out lstRoomTypeDatas);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetRoomDetails RoomBooking_BL", e);
            }
            return returnCode;

        }
        ////nala
        //public long GetRoomsDetails(int pOrgID, int pOrgAddressID, int pBuildingID, int pWardID, int pFloorID, int pRoomTypeID, out List<RoomDetails> lstroomDatas)
        //{
        //    long returnCode = -1;
        //    lstroomDatas = new List<RoomDetails>();
        //    try
        //    {
        //        RoomBooking_DAL roomTypeDAL = new RoomBooking_DAL(globalContextDetails);
        //        returnCode = roomTypeDAL.GetRoomsDetails(pOrgID, pOrgAddressID, pBuildingID, pWardID, pFloorID, pRoomTypeID, out lstroomDatas);
        //    }
        //    catch (Exception e)
        //    {
        //        CLogger.LogError("Error while executing GetRoomMasterDetails RoomBooking_BL", e);
        //    }
        //    return returnCode;

        //}

        //public long GetFloorDetails(string pType, int pOrgID, int pOrgAddressID, int pBuildingID, int pFloorID, out List<RoomDetails> lstFloorDetails)
        //{
        //    long returnCode = -1;
        //    lstFloorDetails = new List<RoomDetails>();
        //    try
        //    {
        //        RoomBooking_DAL roomTypeDAL=new RoomBooking_DAL(globalContextDetails);
        //        returnCode = roomTypeDAL.GetFloorDetails(pType, pOrgID, pOrgAddressID, pBuildingID, pFloorID, out lstFloorDetails);
        //    }
        //     catch (Exception e)
        //    {
        //        CLogger.LogError("Error while executing GetFloorDetails RoomBooking_BL", e);
        //    }
        //    return returnCode;
        //}
        public long UpdateBookedDetails(int pOrgID, int pOrgAddressID,long BookingID,string tempstatus,int IPTreatmentPlanID,long VID,long LID)
        {
            long returnCode = -1;
            try
            {
                RoomBooking_DAL roomTypeDAL = new RoomBooking_DAL(globalContextDetails);
                returnCode = roomTypeDAL.UpdateBookedDetails(pOrgID, pOrgAddressID,BookingID, tempstatus, IPTreatmentPlanID,VID,LID);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing UpdateBookedDetails RoomBooking_BL", e);
            }
            return returnCode;

        }

        public long GetPatientRoomhistory(long PatientVisitID,int pOrgID,  out List<BedBooking> lstBedBooking)
        {
            long returnCode = -1;
            lstBedBooking = new List<BedBooking>();
            try
            {
                RoomBooking_DAL roomTypeDAL = new RoomBooking_DAL(globalContextDetails);
                returnCode = roomTypeDAL.GetPatientRoomhistory(PatientVisitID, pOrgID, out lstBedBooking);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetPatientRoomhistory RoomBooking_BL", e);
            }
            return returnCode;

        }


        public long GetRoomMaster(int OrgID, int OrgAddresID, out List<RoomDetails> lstRoomMaster, out List<RoomBookingDetails> lstCountBooking)
        {
            long returnCode = -1;
            lstRoomMaster = new List<RoomDetails>();
            lstCountBooking = new List<RoomBookingDetails>();
            try
            {
                RoomBooking_DAL roomTypeDAL = new RoomBooking_DAL(globalContextDetails);
                returnCode = roomTypeDAL.GetRoomMaster(OrgID, OrgAddresID, out lstRoomMaster, out lstCountBooking);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetPatientRoomhistory RoomBooking_BL", e);
            }
            return returnCode;

        }

        public long GetRoomBookings(int OrgID, int OrgAddressId, string FromDate, string IsOT, int BulidingID,
            int RoomTypeID, int WardID, string Status, out List<RoomBookingDetails> lstBedBooking, out List<RoomBookingDetails> lstCountBooking)
        {
            long returnCode = -1;
            lstBedBooking = new List<RoomBookingDetails>();
            lstCountBooking = new List<RoomBookingDetails>();
            try
            {
                RoomBooking_DAL roomTypeDAL = new RoomBooking_DAL(globalContextDetails);
                returnCode = roomTypeDAL.GetRoomBookings(OrgID, OrgAddressId, FromDate, IsOT, BulidingID,
                RoomTypeID, WardID, Status, out lstBedBooking, out lstCountBooking);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetPatientRoomhistory RoomBooking_BL", e);
            }
            return returnCode;

        }
        #region For SampleArchieval in SampleWorkflow
        public long GetRoomsDetails(int pOrgID, int pOrgAddressID, int pBuildingID, int pWardID, int pFloorID, int pRoomTypeID, string pStorageUnit, string pTrayType, out List<RoomDetails> lstroomDatas)
        {
            long returnCode = -1;
            lstroomDatas = new List<RoomDetails>();
            try
            {
                RoomBooking_DAL roomTypeDAL = new RoomBooking_DAL(globalContextDetails);
                returnCode = roomTypeDAL.GetRoomsDetails(pOrgID, pOrgAddressID, pBuildingID, pWardID, pFloorID, pRoomTypeID, pStorageUnit, pTrayType, out lstroomDatas);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetRoomMasterDetails RoomBooking_BL", e);
            }
            return returnCode;

        }
        #endregion


    }
}