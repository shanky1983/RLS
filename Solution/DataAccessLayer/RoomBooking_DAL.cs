#region Namespace
using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities;
using System.Collections.Generic;
using Attune.Podium.Common;
using System.Data.Common;
using System.Transactions;
#endregion

namespace Attune.Solution.DAL
{
    public class RoomBooking_DAL
    {
        ContextDetails globalContextDetails;
        public RoomBooking_DAL()
        {
            
        }
        public RoomBooking_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetRoomBook(int pOrgID, int pOrgAddID, DateTime FromDate, string rType, out List<FloorMaster> lstFloor,
             out List<BedMaster> lstBed, out List<RoomBookingDetails> lstRooms)
        {
            long lresult = -1;
            DataSet ds = new DataSet();
            lstFloor = new List<FloorMaster>();
            lstBed = new List<BedMaster>();
            lstRooms = new List<RoomBookingDetails>();
            SqlCommand cmd = Command.pGetRoomBookingCommand(pOrgID, pOrgAddID, Convert.ToString(FromDate), rType,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstFloor);
                    lresult = Utilities.ConvertTo(ds.Tables[1], out lstBed);
                    lresult = Utilities.ConvertTo(ds.Tables[2], out lstRooms);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing getInvestigationId" + cmd.CommandText, ex);
            }
            return lresult;
        }

        public long GetBookingDetails(int pOrgID, int pOrgAddID,int BedID,out List<RoomBookingDetails> lstRooms)
        {
            long lresult = -1;
            DataSet ds = new DataSet();
            lstRooms = new List<RoomBookingDetails>();
            SqlCommand cmd = Command.pGetBookingDetailsCommand(pOrgID, pOrgAddID,BedID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstRooms);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing getInvestigationId" + cmd.CommandText, ex);
            }
            return lresult;
        }
        public long GetBedBookedDetails(int pOrgID, int pOrgAddID, int BedID, string FromDate, string ToDate, out List<RoomBookingDetails> lstBedBookingDetail)
        {
            long lresult = -1;
            DataSet ds = new DataSet();
            lstBedBookingDetail = new List<RoomBookingDetails>();
            SqlCommand cmd = Command.pGetBedBookedDetailsCommand(pOrgID, pOrgAddID, BedID, FromDate, ToDate,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstBedBookingDetail);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing getInvestigationId" + cmd.CommandText, ex);
            }
            return lresult;
        }
        public long GetAvailableBedsByTime(int pOrgID, int pOrgAddID, string FromDate, string ToDate,int BedID, out List<RoomBookingDetails> lstAvailableBedsByTime)
        {
            long lresult = -1;
            DataSet ds = new DataSet();
            lstAvailableBedsByTime = new List<RoomBookingDetails>();
            SqlCommand cmd = Command.pGetAvailableBedsByTimeCommand(pOrgID, pOrgAddID, FromDate, ToDate, BedID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstAvailableBedsByTime);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing getInvestigationId" + cmd.CommandText, ex);
            }
            return lresult;
        }

        public long GetRoomsList(int pOrgAddID, out List<RoomBookingDetails> lstFloor, string sFromDate, string sTodate)
        {
            long lresult = -1;
            DataSet ds = new DataSet();
            lstFloor = new List<RoomBookingDetails>();
            SqlCommand cmd = Command.pGetListOfRoomsCommand(pOrgAddID, sFromDate, sTodate,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstFloor);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing getInvestigationId" + cmd.CommandText, ex);
            }
            return lresult;
        }
      
        public long SaveBedbooking(BedBookingDetails bedBooking, long pCreatedBy)
        {
            long lresult = -1;
            SqlCommand cmd = Command.pInsertBedBookingCommand(bedBooking.BookingID, bedBooking.VisitID, bedBooking.BedID, bedBooking.FromDate.ToString(),
									bedBooking.ToDate.ToString(), bedBooking.Status, bedBooking.PatientID, bedBooking.Description, bedBooking.OrgAddID,bedBooking.OrgID,
									                bedBooking.PatientName,bedBooking.TreatmentPlanID, pCreatedBy,bedBooking.ClientID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                    lresult = dbEngine.ExecuteNonQuery(cmd);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SavePatientInvestigation in Investigation DAL" + cmd.CommandText, ex);
            }
            return lresult;
        }

        public long GetRoomsListSchedule(int pOrgAddID, out List<RoomBookingDetails> lstFloor, string sFromDate, string sTodate, int iBedID)
        {
            long lresult = -1;
            DataSet ds = new DataSet();
            lstFloor = new List<RoomBookingDetails>();
            SqlCommand cmd = Command.pGetListOfRoomScheduleCommand(iBedID, pOrgAddID, sFromDate, sTodate,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstFloor);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing getInvestigationId" + cmd.CommandText, ex);
            }
            return lresult;
        }
        public long SaveRoomTransferDetails(InPatientLocationTransferDetails RoomtransferDetails, string sPatientName, string sDescription, DateTime sTodate)
        {
            long lresult = -1;
            SqlCommand cmd = Command.pInsertInPatientLocationTransferDetailsCommand(RoomtransferDetails.TransferLocationID, RoomtransferDetails.PatientID,
									RoomtransferDetails.VisitID, RoomtransferDetails.FromBedID, RoomtransferDetails.ToBedID, RoomtransferDetails.DateOfTransfer,
									RoomtransferDetails.ConditionOnTransfer, RoomtransferDetails.TransferInitiatedType, RoomtransferDetails.TransferInitiatedBy,
									RoomtransferDetails.TransferPerformedBy, RoomtransferDetails.ReasonForTransfer, RoomtransferDetails.AttendeesAccompanying1,
									RoomtransferDetails.AttendeesAccompanying1Phone, RoomtransferDetails.AttendeesAccompanying2, RoomtransferDetails.AttendeesAccompanying2Phone,
									                RoomtransferDetails.OrgID, RoomtransferDetails.CreatedBy, sPatientName, sDescription, sTodate,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                    lresult = dbEngine.ExecuteNonQuery(cmd);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SavePatientInvestigation in Investigation DAL" + cmd.CommandText, ex);
            }
            return lresult;
        }

        public long GetRoomsListByVisitID(int pOrgAddID, long iVisitID, out List<RoomBookingDetails> lstFloor, out string roomStatus)
        {
            long lresult = -1;
            DataSet ds = new DataSet();
            lstFloor = new List<RoomBookingDetails>();
            SqlCommand cmd = Command.pGetListOfRoomsOccupiedByPatientCommand(pOrgAddID, iVisitID, out roomStatus,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out ds);
                    roomStatus = cmd.Parameters["@pStatus"].Value.ToString();
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstFloor);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetRoomsListByVisitID " + cmd.CommandText, ex);
            }
            return lresult;
        }

        public long GetRoomTypeList(int pOrgID, int pOrgAddID, int RoomTypeID, string RtName, out List<RoomType> lstRoomType)
        {
            long lresult = -1;
            DataSet ds = new DataSet();
            lstRoomType = new List<RoomType>();
            SqlCommand cmd = Command.pGetRoomzTypeListCommand(pOrgID, pOrgAddID, RoomTypeID, RtName,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out ds);

                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstRoomType);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetRoomTypeList " + cmd.CommandText, ex);
            }
            return lresult;
        }
        public long GetRoomFeesTypeList(int pOrgID, int pOrgAddressID, out List<RoomDetails> lstFeesDetails, out List<RoomDetails> lstFees)
        {
            long lresult = -1;
            DataSet ds = new DataSet();
            lstFees = new List<RoomDetails>();
            lstFeesDetails = new List<RoomDetails>();
            SqlCommand cmd = Command.pGetRoomFeeTypeListCommand(pOrgID, pOrgAddressID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out ds);

                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstFeesDetails);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[1], out lstFees);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetRoomFeesTypeList " + cmd.CommandText, ex);
            }
            return lresult;
        }
        public long GetFloorMasterList(int pOrgID, int pOrgAddID, out List<FloorMaster> lstFloor)
        {
            long lresult = -1;
            DataSet ds = new DataSet();
            lstFloor = new List<FloorMaster>();
            SqlCommand cmd = Command.pGetFloorListCommand(pOrgID, pOrgAddID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out ds);

                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstFloor);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetRoomTypeList " + cmd.CommandText, ex);
            }
            return lresult;
        }
        public long GetBedMasterList(int pOrgID, int pOrgAddID, out List<BedMaster> lstBed)
        {
            long lresult = -1;
            DataSet ds = new DataSet();
            lstBed = new List<BedMaster>();
            SqlCommand cmd = Command.pGetBedListCommand(pOrgID, pOrgAddID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out ds);

                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstBed);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetRoomTypeList " + cmd.CommandText, ex);
            }
            return lresult;
        }
        public long GetRoomList(int pOrgID, int pOrgAddID, out List<RoomMaster> lstRoom)
        {
            long lresult = -1;
            DataSet ds = new DataSet();
            lstRoom = new List<RoomMaster>();
            SqlCommand cmd = Command.pGetRoomListCommand(pOrgID, pOrgAddID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out ds);

                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstRoom);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetRoomList " + cmd.CommandText, ex);
            }
            return lresult;
        }

        public long SaveRoomDetails(List<RoomDetails> RoomDtls)
        {
            long lresult = -1;
            DataTable RoomDt = UDT_DAL.ConvertToRoomDetails(RoomDtls);
            SqlCommand cmd = Command.pInsertRoomMasterCommand(RoomDt, string.Empty, 0, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                    lresult = dbEngine.ExecuteNonQuery(cmd);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing Save Room Details in RoomBooking DAL" + cmd.CommandText, ex);
            }
            return lresult;
        }
        public long SaveRoomDetails(RoomMaster Roommaster, List<BedMaster> Bedmaster, string BedDeleted)
        {
            long lresult = -1;
            DataTable dtAb = UDT_DAL .ConvertToBedMaster (Bedmaster);
            SqlCommand cmd = Command.PInsUpdRoomMasterCommand(Roommaster.RoomID, Roommaster.RoomName, Roommaster.FloorID, Roommaster.WardID, Roommaster.RoomTypeID, dtAb, BedDeleted,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                    lresult = dbEngine.ExecuteNonQuery(cmd);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SavePatientInvestigation in Investigation DAL" + cmd.CommandText, ex);
            }
            return lresult;
        }
        public long DeleteRoomDetails(string RoomIds)
        {
            long lresult = -1;
            SqlCommand cmd = Command.PDelRoomMasterCommand(RoomIds,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                    lresult = dbEngine.ExecuteNonQuery(cmd);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing RoomDetils DAL" + cmd.CommandText, ex);
            }
            return lresult;
        }
        public long DeleteMasterDetails(string tableName,string IDCol,long IdVal)
        {
            long lresult = -1;
            SqlCommand cmd = Command.PDelMastersCommand(tableName,IDCol,IdVal,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                    lresult = dbEngine.ExecuteNonQuery(cmd);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing RoomDetils DAL" + cmd.CommandText, ex);
            }
            return lresult;
        }
        public long SaveRoomMasterData(string pType, int OrgId, int OrgAddID, List<RoomDetails> lstRoomDetails,string IsSlotable,string IsAnOT)
        {
            long lresult = -1;
            
            DataTable Dt =UDT_DAL .ConvertToRoomDetails (lstRoomDetails);
            SqlCommand cmd = Command.PInsUpdRoomMasterDataCommand(pType, OrgAddID, OrgId, Dt, IsSlotable, IsAnOT,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {

                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing RoomDetils DAL" + cmd.CommandText, ex);
            }
            return lresult;
        }

      


        public long GetWard(int pOrgID, int pOrgAddID, out List<WardMaster> lstWard)
        {
            long lresult = -1;
            DataSet ds = new DataSet();
            lstWard = new List<WardMaster>();
            SqlCommand cmd = Command.pGetWardCommand(pOrgID, pOrgAddID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out ds);

                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstWard);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetWardList " + cmd.CommandText, ex);
            }
            return lresult;
        }
     
        public long GetBuilding(int pOrgID, int pOrgAddID, out List<BuildingMaster> lstBuild)
        {
            long lresult = -1;
            DataSet ds = new DataSet();
            lstBuild = new List<BuildingMaster>();
            SqlCommand cmd = Command.pGetBuildingCommand(pOrgID, pOrgAddID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out ds);

                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstBuild);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetBuildingList " + cmd.CommandText, ex);
            }
            return lresult;
        }
        public long GetMaster(string tableName,string IDcol,long IDval,string REFcol,string REFtable,string ref_OrgID,int ref_Orgval,long REFval,string TXTcol,string TXTval, int pOrgID, out DataSet Ds)
        {
            long lresult = -1;
             Ds = new DataSet();
            string OrgCol="";
            if (tableName != "FloorMaster" || tableName != "WardMaster")
            {
                OrgCol = "OrgID";
            }
            SqlCommand cmd = Command.pGetMasterCommand(tableName, IDcol, IDval, REFcol, REFtable,ref_OrgID,ref_Orgval,REFval, TXTcol, TXTval, OrgCol, pOrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out Ds);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetMasterList " + cmd.CommandText, ex);
            }
            return lresult;
        }

        public long GetConsultantName(string FilterText, int OrgID, out List<Physician> lstPhysician)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetConsultantNameCommand(FilterText, OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstPhysician = new List<Physician>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPhysician);
            }
            return returnCode;
        }

        public long GetBedPatientName(string FilterText, int OrgID, out List<Patient> lstPatient)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetBedPatientNameCommand(FilterText, OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstPatient = new List<Patient>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatient);
            }
            return returnCode;
        }
        public long LoadRoomMasterDetails(string pType, int pOrgID, int pOrgAddID,int pBuildingID, out List<RoomDetails> lstDatas)
        {
            long returnCode = -1;
            lstDatas = new List<RoomDetails>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetRoomMasterDetailsCommand(pType, pOrgID, pOrgAddID, pBuildingID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstDatas);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in RoomBooking_DAL LoadRoomMasterDetails", ex);
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
       

       

        public long GetRoomDetails(int pOrgID, int pOrgAddID, out List<RoomDetails> lstBuildingDatas
            , out List<RoomDetails> lstFloorDatas
            , out List<RoomDetails> lstWardDatas
            , out List<RoomDetails> lstRoomTypeDatas
            )
        {
            long returnCode = -1;
            lstBuildingDatas = new List<RoomDetails>();
            lstFloorDatas = new List<RoomDetails>();
            lstWardDatas = new List<RoomDetails>();
            lstRoomTypeDatas = new List<RoomDetails>();
            
            SqlCommand objCommand = Command.pGetRoomMastersCommand(pOrgID, pOrgAddID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBuildingDatas);
            }
            if (ds.Tables[1].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstFloorDatas);
            }
            if (ds.Tables[2].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[2], out lstWardDatas);
                
            }
            if (ds.Tables[3].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[3], out lstRoomTypeDatas);
            }
           
            return returnCode;

        }
       


        public long UpdateBookedDetails(int pOrgID, int pOrgAddressID, long BookingID, string tempstatus, int IPTreatmentPlanID,long VID,long LID)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pUpdateBookedDetailsCommand(pOrgID, pOrgAddressID, BookingID, tempstatus, IPTreatmentPlanID, VID,LID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing RoomDetils DAL" + cmd.CommandText, ex);
            }
            return returnCode;

        }
        public long GetPatientRoomhistory(long PatientVisitID, int pOrgID, out List<BedBooking> lstBedBooking)
        {
            long returnCode = -1;

            SqlCommand objCommand = Command.pGetPatientRoomhistoryCommand(PatientVisitID, pOrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstBedBooking = new List<BedBooking>();

            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }

            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBedBooking);
            }

            return returnCode;

        }

        public long GetRoomMaster(int OrgID, int OrgAddresID, out List<RoomDetails> lstRoomMaster,out List<RoomBookingDetails> lstCountBooking)
        {
            long returnCode = -1;

            SqlCommand objCommand = Command.pGetRoomMasterCommand(OrgID, OrgAddresID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstRoomMaster = new List<RoomDetails>();
            lstCountBooking = new List<RoomBookingDetails>();
 
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstRoomMaster);
            }
            if (ds.Tables[1].Rows. Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstCountBooking);
            }

            return returnCode;

        }

        public long GetRoomBookings(int OrgID,int OrgAddressId,string FromDate,string IsOT,int BulidingID,
            int RoomTypeID, int WardID, string Status, out List<RoomBookingDetails> lstBedBooking, out List<RoomBookingDetails> lstCountBooking)
        {
            
            long returnCode = -1;

            SqlCommand objCommand = Command.pGetRoomBedBookingCommand(OrgID,OrgAddressId,FromDate,IsOT,BulidingID,
                RoomTypeID, WardID, Status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstBedBooking = new List<RoomBookingDetails>();
            lstCountBooking = new List<RoomBookingDetails>();

            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }

            if (ds.Tables[0].Rows.Count   > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBedBooking);
            }
            if (ds.Tables[1].Rows . Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstCountBooking);
            }

            return returnCode;

        }
        #region For SampleArchieval in sampleWorkflow
        public long GetRoomsDetails(int pOrgID, int pOrgAddressID, int pBuildingID, int pWardID, int pFloorID, int pRoomTypeID, string pStorageUnit, string pTrayType, out List<RoomDetails> lstroomDatas)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetRoomsDetailsCommand(pOrgID, pOrgAddressID, pBuildingID, pWardID, pFloorID, pRoomTypeID, pStorageUnit, pTrayType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstroomDatas = new List<RoomDetails>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstroomDatas);
            }
            return returnCode;

        }
        #endregion

    }


}
