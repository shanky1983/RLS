using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.SqlClient;
using System.Collections.Generic;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities;
using Attune.Podium.Common;
using System.Transactions;

namespace Attune.Solution.DAL
{
    public class Schedule_DAL
    {
        ContextDetails globalContextDetails;
        public Schedule_DAL()
        {

        }
        public Schedule_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetBookings(long resourceTemplateID, int OrgID, DateTime startTime, long scheduleID,
            out int scheduleTemplateID, out List<Bookings> bookings, out List<ScheduleTemplate> stemplate)
        {
            long returnCode = -1;
            bookings = new List<Bookings>();
            stemplate = new List<ScheduleTemplate>();
            scheduleTemplateID = 0;
            SqlCommand Bookingcmd = Command.pGetBookingsCommand(resourceTemplateID, OrgID, startTime, scheduleID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();


            using (DBEngine dBEngine = new DBEngine())
            {
                dBEngine.ExecuteDataSet(Bookingcmd, out ds);
            }

            if (ds.Tables.Count > 2)
            {
                Int32.TryParse(ds.Tables[0].Rows[0]["ScheduleTemplateID"].ToString(), out scheduleTemplateID);
                Utilities.ConvertTo(ds.Tables[1], out bookings);
                Utilities.ConvertTo(ds.Tables[2], out stemplate);
            }
            return returnCode;
        }

        public long CancelBooking(long bookID, string description)
        {
            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pCancelBookingsCommand(bookID, description, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dBEngine = new DBEngine())
            {
                returnCode = dBEngine.ExecuteNonQuery(cmd);
            }
            return returnCode;
        }

        public long GetRecurrencePattern(int scheduleTemplateID, out DateTime lastOccurance, out List<RecurrenceRelative> rrelative, out List<RecurrenceAbsolute> rabsolute)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pGetRecurrenceCommand(scheduleTemplateID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            lastOccurance = DateTime.MinValue;
            rrelative = new List<RecurrenceRelative>();
            rabsolute = new List<RecurrenceAbsolute>();
            using (DBEngine dBEngine = new DBEngine())
            {
                dBEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 1)
            {
                Utilities.ConvertTo(ds.Tables[0], out rrelative);
                Utilities.ConvertTo(ds.Tables[1], out rabsolute);
            }
            returnCode = 0;
            return returnCode;
        }

        public long GetPhysicianList(int OrgID, out List<PhysicianSchedule> physicianschedule)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pGetPhysiciansCommand(OrgID, "VIS", UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            physicianschedule = new List<PhysicianSchedule>();
            using (DBEngine dBEngine = new DBEngine())
            {
                dBEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                Utilities.ConvertTo(ds.Tables[0], out physicianschedule);

            }
            returnCode = 0;
            return returnCode;

        }

        public long GetScheduleTemplates(long resourceTemplateID, int orgID, out List<int> schTemplates)
        {
            long returnCode = -1;
            DataSet ds = new DataSet();
            SqlCommand cmd = Command.pGetScheduleTemplatesCommand(resourceTemplateID, orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            schTemplates = new List<int>();
            using (DBEngine dBEngine = new DBEngine())
            {
                dBEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    int sTemplateId = 0;
                    Int32.TryParse(dr[0].ToString(), out sTemplateId);
                    schTemplates.Add(sTemplateId);
                }
            }
            return returnCode;

        }

        public long SaveBooking(Bookings book)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pInsertBookingCommand(book.ResourceTemplateID, book.ScheduleID, book.StartTime, book.EndTime, book.TokenNumber, book.Description, book.CreatedBy, book.PatientNumber, book.PhoneNumber, book.PatientName, book.CancelRemarks, book.OrgID, book.BookingOrgID, book.ReferalID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dBEngine = new DBEngine())
            {
                returnCode = dBEngine.ExecuteNonQuery(cmd);
            }
            return returnCode;
        }

        public long SaveSchedule(Schedules schs)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pInsertSchedulesCommand(schs.ResourceTemplateID, schs.NextOccurance, schs.PreviousOccurance, schs.Status, schs.CreatedBy, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dBEngine = new DBEngine())
            {
                returnCode = dBEngine.ExecuteNonQuery(cmd);
            }
            return returnCode;
        }
        public long DeleteSchedule(long resourceTemplateID)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pDeleteSchedulesCommand(resourceTemplateID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dBEngine = new DBEngine())
            {
                returnCode = dBEngine.ExecuteNonQuery(cmd);
            }
            return returnCode;
        }
        // changed dataset to datareader by Arivalagan.k
        public long GetSchedules(long resourceTemplateID, int orgID,
            out List<PhysicianSchedule> schedules,
            out List<PhysicianSpeciality> phySpeciality,
            int LocationID,
            DateTime sFromDate, DateTime sToDate)
        {
            long retCode = -1;
            int rsCount = 0;
            DataSet ds = new DataSet();
            schedules = new List<PhysicianSchedule>();
            phySpeciality = new List<PhysicianSpeciality>();
            IDataReader dataReader = null;
           
            try
            {

                SqlCommand cmd = Command.pGetPhySchedulesCommand(resourceTemplateID, orgID, LocationID, sFromDate, sToDate, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dBEngine = new DBEngine())
                {
                    dataReader = dBEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                retCode = Utilities.ConvertTo(dataReader, out schedules);
                            }
                            else if (rsCount == 1)
                            {
                                retCode = Utilities.ConvertTo(dataReader, out phySpeciality);
                            }

                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
                CLogger.LogError("Error while loading GetSchedules", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            } 
            retCode = 0;
            return retCode;
        }


        public long InsertSchedules(List<RecurrenceAbsolute> lstRAbsolute, List<RecurrenceRelative> lstRelative,
            List<ScheduleTemplate> lstScheduleTemp, List<SchedulableResource> lstResource,
            List<Schedules> lstSchedules, int stid, int rtid, int RecurrenceID)
        {
            int result = -1;
            int resultStatus = -1;
            long resultCode = -1;
            int RID = 0;
            int RCyleId = 0;
            int STempID = 0;
            long RTempID = 0;
            SqlCommand cmdRelative = null;
            if (lstRelative.Count > 0)
            {
                cmdRelative = Command.pInsertRelativeCommand(lstRelative[0].Type, lstRelative[0].Interval, out RID, out result, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            }
            SqlCommand cmdAbsolute = null;
            SqlCommand cmdScheduleTemp = null;
            SqlCommand cmdResource = null;
            SqlCommand cmdSchedules = null;

            using (TransactionScope transscope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        if (cmdRelative != null)
                        {
                            dbEngine.ExecuteTransactionalNonQuery(cmdRelative);
                            result = Convert.ToInt32(cmdRelative.Parameters["@result"].Value);
                            RID = Convert.ToInt32(cmdRelative.Parameters["@RID"].Value);
                            if (result == 0 && lstRAbsolute.Count > 0)
                            {

                                cmdAbsolute = Command.pInsertRecurrenceAbsoluteCommand(RID,
                                                                    lstRAbsolute[0].ParentRecurrenceCycleID, lstRAbsolute[0].Unit, lstRAbsolute[0].Value, out RCyleId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                                dbEngine.ExecuteTransactionalNonQuery(cmdAbsolute);
                                if (lstRAbsolute[0].Unit == TaskHelper.unit.WN.ToString())
                                {
                                    RCyleId = Convert.ToInt32(cmdAbsolute.Parameters["@RCID"].Value);
                                    cmdAbsolute = Command.pInsertRecurrenceAbsoluteCommand(RID,
                                                                        RCyleId, lstRAbsolute[1].Unit, lstRAbsolute[1].Value, out RCyleId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                                    dbEngine.ExecuteTransactionalNonQuery(cmdAbsolute);
                                }
                                else if (resultCode == 1 && lstRAbsolute[0].Unit == TaskHelper.unit.MN.ToString())
                                {
                                    RCyleId = Convert.ToInt32(cmdAbsolute.Parameters["@RCID"].Value);
                                    cmdAbsolute = Command.pInsertRecurrenceAbsoluteCommand(RID,
                                                                        RCyleId, lstRAbsolute[1].Unit, lstRAbsolute[1].Value, out RCyleId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                                    dbEngine.ExecuteTransactionalNonQuery(cmdAbsolute);
                                }
                            }
                            cmdScheduleTemp = Command.pInsertScheduleTempCommand(lstScheduleTemp[0].StartTime, lstScheduleTemp[0].EndTime,
                                                                    lstScheduleTemp[0].SlotDuration, RID, out resultStatus, out STempID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                            dbEngine.ExecuteTransactionalNonQuery(cmdScheduleTemp);
                            resultStatus = Convert.ToInt32(cmdScheduleTemp.Parameters["@result"].Value);
                            STempID = Convert.ToInt32(cmdScheduleTemp.Parameters["@TempId"].Value);
                            if (resultStatus == 0)
                            {
                                cmdResource = Command.pInsertScheduleResourceCommand(lstResource[0].ResourceID, lstResource[0].ResourceType,
                                                                        lstResource[0].OrgID, STempID, lstResource[0].CreatedBy, out RTempID, out resultStatus, lstResource[0].OrgAddressID, lstResource[0].AdditionalContextKey, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                                dbEngine.ExecuteTransactionalNonQuery(cmdResource);
                                resultStatus = Convert.ToInt32(cmdResource.Parameters["@result"].Value);
                                RTempID = Convert.ToInt64(cmdResource.Parameters["@ResTempId"].Value);
                                if (resultStatus == 0)
                                {
                                    cmdSchedules = Command.pInsertDScheduleCommand(RTempID, lstSchedules[0].NextOccurance, lstSchedules[0].PreviousOccurance,
                                                                          lstSchedules[0].Status, lstSchedules[0].CreatedBy, out resultStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                                    dbEngine.ExecuteTransactionalNonQuery(cmdSchedules);
                                    resultStatus = Convert.ToInt32(cmdScheduleTemp.Parameters["@result"].Value);
                                    resultCode = resultStatus;
                                }
                            }
                        }
                        else
                        {
                            cmdScheduleTemp = Command.pInsertScheduleTempCommand(lstScheduleTemp[0].StartTime, lstScheduleTemp[0].EndTime,
                                                                    lstScheduleTemp[0].SlotDuration, lstScheduleTemp[0].RecurrenceID, out resultStatus, out STempID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                            dbEngine.ExecuteTransactionalNonQuery(cmdScheduleTemp);
                            resultStatus = Convert.ToInt32(cmdScheduleTemp.Parameters["@result"].Value);
                            STempID = Convert.ToInt32(cmdScheduleTemp.Parameters["@TempId"].Value);

                            if (resultStatus == 0)
                            {
                                cmdResource = Command.pInsertScheduleResourceCommand(lstResource[0].ResourceID, lstResource[0].ResourceType,
                                                                        lstResource[0].OrgID, STempID, lstResource[0].CreatedBy, out RTempID, out resultStatus, lstResource[0].OrgAddressID, lstResource[0].AdditionalContextKey, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                                dbEngine.ExecuteTransactionalNonQuery(cmdResource);
                                resultStatus = Convert.ToInt32(cmdResource.Parameters["@result"].Value);
                                RTempID = Convert.ToInt64(cmdResource.Parameters["@ResTempId"].Value);
                                if (resultStatus == 0)
                                {
                                    cmdSchedules = Command.pInsertDScheduleCommand(RTempID, lstSchedules[0].NextOccurance, lstSchedules[0].PreviousOccurance,
                                                                          lstSchedules[0].Status, lstSchedules[0].CreatedBy, out resultStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                                    dbEngine.ExecuteTransactionalNonQuery(cmdSchedules);
                                    resultStatus = Convert.ToInt32(cmdScheduleTemp.Parameters["@result"].Value);
                                    resultCode = resultStatus;
                                }
                            }
                        }

                        if (resultCode == 0)
                        {
                            cmdResource = Command.pDeleteAllSchedulesCommand(stid, rtid, RecurrenceID, out resultStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                            dbEngine.ExecuteTransactionalNonQuery(cmdResource);
                            resultStatus = Convert.ToInt32(cmdResource.Parameters["@result"].Value);
                        }
                    }
                    transscope.Complete();
                }
                catch (Exception ex)
                {
                    transscope.Dispose();
                    CLogger.LogError("Error while saving InsertSchedules", ex);
                }
            }
            return resultCode;
        }

        public long GetDoctorsSchedule(int pOrgAddID, string FromDate, string ToDate, int ResourceID, string ResourceType, out List<DoctorSchedule> lstDoctorSchedule)
        {
            long returnCode = -1;
            lstDoctorSchedule = new List<DoctorSchedule>();
            SqlCommand Bookingcmd = Command.pGetListOfSchedulesCommand(pOrgAddID, FromDate, ToDate, ResourceID, ResourceType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dBEngine = new DBEngine())
            {
                dBEngine.ExecuteDataSet(Bookingcmd, out ds);
                Utilities.ConvertTo(ds.Tables[0], out lstDoctorSchedule);
            }
            return returnCode;
        }

        public long GetSchedulesForEdit(long resourceID, int orgID, out List<PhysicianSchedule> schedules,
                                        out List<PhysicianSpeciality> phySpeciality, string sType,
                                        DateTime FromDate, DateTime ToDate, int LocationID)
        {
            long retCode = -1;
            DataSet ds = new DataSet();
            schedules = new List<PhysicianSchedule>();
            phySpeciality = new List<PhysicianSpeciality>();
            SqlCommand cmd = Command.pGetPhySchedulesForEditCommand(resourceID, orgID, sType, FromDate, ToDate, LocationID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dBEngine = new DBEngine())
            {
                dBEngine.ExecuteDataSet(cmd, out ds);
            }

            if (ds.Tables.Count > 0)
            {
                Utilities.ConvertTo(ds.Tables[0], out schedules);
                if (ds.Tables.Count > 1)
                    Utilities.ConvertTo(ds.Tables[1], out phySpeciality);
            }
            retCode = 0;
            return retCode;
        }

        public long SaveExceptionSchedule(long lRTID, long lSID, DateTime dDateofChange, DateTime sStartTime, DateTime sEndTime, int iSDuration, int LID)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pInsertExceptionSchedulesCommand(lRTID, lSID, dDateofChange, sStartTime, sEndTime, iSDuration, LID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dBEngine = new DBEngine())
            {
                returnCode = dBEngine.ExecuteNonQuery(cmd);
            }
            return returnCode;
        }


        public long InsertVacation(int iVacationID, long lPhyID, DateTime sFromDate, DateTime sToDate, string sCancelledSchedules, string sStatus, int iCreatedBy)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pInsertPhyVacationCommand(iVacationID, lPhyID, sFromDate, sToDate, sCancelledSchedules, sStatus, iCreatedBy, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dBEngine = new DBEngine())
            {
                returnCode = dBEngine.ExecuteNonQuery(cmd);
            }
            return returnCode;
        }

        public long GetPhysicianVacations(long resourceID, int orgID, out List<PhysicianSchedule> schedules,
                                        out List<PhysicianSpeciality> phySpeciality, string sType, DateTime FromDate,
                                        DateTime ToDate, out List<DoctorSchedule> lstDocSchedule, out List<PhysicianVacationDetails> lstVacationDetails)
        {
            long retCode = -1;
            DataSet ds = new DataSet();
            schedules = new List<PhysicianSchedule>();
            phySpeciality = new List<PhysicianSpeciality>();
            lstDocSchedule = new List<DoctorSchedule>();
            lstVacationDetails = new List<PhysicianVacationDetails>();

            SqlCommand cmd = Command.pGetPhyVacationSchedulesCommand(resourceID, orgID, sType, FromDate, ToDate, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dBEngine = new DBEngine())
            {
                dBEngine.ExecuteDataSet(cmd, out ds);
            }

            if (ds.Tables.Count > 0)
            {
                Utilities.ConvertTo(ds.Tables[0], out schedules);
            }
            if (ds.Tables.Count > 1)
                Utilities.ConvertTo(ds.Tables[1], out lstDocSchedule);
            if (ds.Tables.Count > 2)
                Utilities.ConvertTo(ds.Tables[2], out lstVacationDetails);


            retCode = 0;
            return retCode;
        }

        public long UpdatePhysicianVacation(int iVacationID, int iCreatedBy)
        {
            long retCode = -1;
            SqlCommand cmd = Command.pUpdatePhyVacationCommand(iVacationID, iCreatedBy, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dBEngine = new DBEngine())
            {
                dBEngine.ExecuteNonQuery(cmd);
            }
            retCode = 0;
            return retCode;
        }

        public long UpdateindSchedules(int ischdeuleID)
        {
            long retCode = -1;
            SqlCommand cmd = Command.pCancelSchedulesCommand(ischdeuleID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dBEngine = new DBEngine())
            {
                dBEngine.ExecuteNonQuery(cmd);
            }
            retCode = 0;
            return retCode;
        }



        //Changes of DataSet To DataReader Made By Arivalagan.k
        public long getOrganizations(out List<Organization> lstOrganization)
        {
            long retCode = -1;
            IDataReader dataReader = null;
            lstOrganization = new List<Organization>();
            try
            {
                SqlCommand cmd = Command.pGetOrganizationCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        retCode = Utilities.ConvertTo(dataReader, out lstOrganization);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading getOrganizations", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            retCode = 0;
            return retCode;
        }

        public long getOrganizationAddress(out List<OrganizationAddress> lstOrganizationAddress)
        {
            long retCode = -1;
            SqlCommand cmd = Command.pGetOrganizationAddressCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            lstOrganizationAddress = new List<OrganizationAddress>();

            using (DBEngine dBEngine = new DBEngine())
            {
                dBEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                Utilities.ConvertTo(ds.Tables[0], out lstOrganizationAddress);
            }
            retCode = 0;
            return retCode;
        }

        public long GetSchedulesAndBookings(string resourceTemplateID, int orgID,
            out List<PhysicianSchedule> schedules,
            out List<PhysicianSpeciality> phySpeciality,
            int LocationID,
            out List<Bookings> bookings
            )
        {
            long retCode = -1;
            DataSet ds = new DataSet();
            schedules = new List<PhysicianSchedule>();
            phySpeciality = new List<PhysicianSpeciality>();
            bookings = new List<Bookings>();

            SqlCommand cmd = Command.pGetPhySchedulesANDBookingsCommand(resourceTemplateID, orgID, LocationID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dBEngine = new DBEngine())
            {
                dBEngine.ExecuteDataSet(cmd, out ds);
            }

            if (ds.Tables.Count > 0)
            {
                Utilities.ConvertTo(ds.Tables[0], out schedules);
                if (ds.Tables.Count > 1)
                    Utilities.ConvertTo(ds.Tables[1], out phySpeciality);
                Utilities.ConvertTo(ds.Tables[1], out phySpeciality);
                Utilities.ConvertTo(ds.Tables[2], out bookings);

            }
            retCode = 0;
            return retCode;
        }

        public long SaveBookingBulkSchedules(List<Bookings> book)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pInsertBookingBulkSchedulesCommand(UDT_DAL.ConvertToSchedulesDescription(book), book[0].Description, book[0].CreatedBy, book[0].PatientNumber, book[0].PhoneNumber, book[0].PatientName, book[0].CancelRemarks, book[0].OrgID, book[0].BookingOrgID, book[0].ReferalID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dBEngine = new DBEngine())
            {
                returnCode = dBEngine.ExecuteNonQuery(cmd);
            }
            return returnCode;
        }


        public long GetSchedulesForDateRange(DateTime sFromDate, int orgID, DateTime sToDate,
           out List<PhysicianSchedule> schedules)
        {
            long retCode = -1;
            DataSet ds = new DataSet();
            schedules = new List<PhysicianSchedule>();

            SqlCommand cmd = Command.pGetPhySchedulesForDateRangeCommand(sFromDate, orgID, sToDate, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dBEngine = new DBEngine())
            {
                dBEngine.ExecuteDataSet(cmd, out ds);
            }

            if (ds.Tables.Count > 0)
            {
                Utilities.ConvertTo(ds.Tables[0], out schedules);
            }
            retCode = 0;
            return retCode;
        }
        public long UpdateScedules(long ibookingid, int orgid, string premarks, string pstatus)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pUpdateScedulesCommand(ibookingid, orgid, premarks, pstatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dBEngine = new DBEngine())
            {
                returnCode = dBEngine.ExecuteNonQuery(cmd);
            }
            return returnCode;
        }


        public void DeletePhysicianSchedule(long Stid, long rtid)
        {
            SqlCommand cmd = Command.pDeletePhysicianScheduleCommand(rtid, Stid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dBEngine = new DBEngine())
            {
                dBEngine.ExecuteNonQuery(cmd);
            }
        }

        public long GetScheduleDetails(long resourceID, string ResourceType, int orgID, int OrgAddressID, out List<Bookings> bookings)
        {
            long returnCode = -1;
            bookings = new List<Bookings>();

            SqlCommand Bookingcmd = Command.pGetSchedulesAndTokensCommand(orgID, resourceID, OrgAddressID, ResourceType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();


            using (DBEngine dBEngine = new DBEngine())
            {
                dBEngine.ExecuteDataSet(Bookingcmd, out ds);
            }

            if (ds.Tables.Count > 0)
            {

                Utilities.ConvertTo(ds.Tables[0], out bookings);
            }
            return returnCode;
        }



        public long GetClientSchedules(int orgID, int customerTypeID, string Client, long ClientID, int LocationID,
         DateTime sFromDate, DateTime sToDate, out List<Schedulesinvoice> schedules, int PageSize, int startRowIndex, out int totalRows, string searchtype)
        {
            long retCode = -1;
            totalRows = -1;
            DataSet ds = new DataSet();
            schedules = new List<Schedulesinvoice>();

            SqlCommand cmd = Command.pGetClientSchedulesCommand(orgID, customerTypeID, LocationID, Client, ClientID, sFromDate, sToDate, PageSize, startRowIndex, out totalRows, searchtype, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dBEngine = new DBEngine())
            {
                dBEngine.ExecuteDataSet(cmd, out ds);
            }

            if (ds.Tables.Count > 0)
            {
                Utilities.ConvertTo(ds.Tables[0], out schedules);
                totalRows = Convert.ToInt32(ds.Tables[1].Rows[0]["totalRows"]);

            }
            return retCode;
        }



        public long GetClientList(int pOrgID, string prefixText, out List<ClientMaster> lstClientMaster)
        {
            long returnCode = -1;
            lstClientMaster = new List<ClientMaster>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetClientNameforScheduleCommand(pOrgID, prefixText, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstClientMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL InvClientMaster", ex);
            }
            return returnCode;
        }
        // changed dataset to datareader by Divya
        public long GetOrgInvestigationsGroupandPKG(int Orgid, int Locationid, string prefixText, string ItemType, out List<BillingFeeDetails> lstBillingFeeDetails)
        {
            long returnCode = -1;
            lstBillingFeeDetails = new List<BillingFeeDetails>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd;
                cmd = Command.pGetOrgInvestigationsGroupandPKGCommand(Orgid, Locationid, prefixText, ItemType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstBillingFeeDetails);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetOrgInvestigationsGroupandPKG in Schedule_DAL.cs", ex);
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

        // changed dataset to datareader by Arivalagan.k
        public long getOrganizationsWithType(int refclientID, out List<Organization> lstOrganization)
        {
            long retCode = -1;
            lstOrganization = new List<Organization>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetOrganizationWithTypeCommand(refclientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dBEngine = new DBEngine())
                {
                    dataReader = dBEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        retCode = Utilities.ConvertTo(dataReader, out lstOrganization);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing getOrganizationsWithType Schedule_DAL", e);
            }
             finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            } 
            retCode = 0;
            return retCode;
        }

        public long SaveServiceQuotationDetails(Bookings oBookings, List<OrderedInvestigations> lstOrderedInves, int OrgID, long LID, out long bookingID)
        {
            long returnCode = -1;
            DataTable dtServiceQuotation = UDT_DAL.ConvertToServiceQuotation(oBookings);
            DataTable invs = UDT_DAL.ConvertToOrderedInvestigation(lstOrderedInves);
            SqlCommand cmd = Command.pSaveServiceQuotationDetailsCommand(dtServiceQuotation, invs, OrgID, LID, out bookingID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dBEngine = new DBEngine())
            {
                returnCode = dBEngine.ExecuteNonQuery(cmd);
                bookingID = Convert.ToInt64(cmd.Parameters["@pBookingID"].Value);

            }
            return returnCode;
        }

        // changed dataset to datareader by Divya
        public long GetServiceQuotationDetails(long bookingID, int OrgID, out List<Bookings> lstBookings)
        {
            long returnCode = -1;
            lstBookings = new List<Bookings>();
            IDataReader dataReader = null;
            int rsCount = 0;
            try
            {
                SqlCommand cmd = Command.pGetServiceQuotationDetailsCommand(bookingID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);

                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstBookings);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing GetQuickBillingDetails", ex);
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

        // changed dataset to datareader by thiyagu
        public long GetHubName(int OrgID, string prefixText, out List<Localities> lstLOCAL)
        {
            long returnCode = -1;
            lstLOCAL = new List<Localities>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetHubNameCommand(OrgID, prefixText);
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstLOCAL);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetHubName DAL", ex);
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

        // changed dataset to datareader by thiyagu
        public long GetZoneName(int OrgID, string prefixText, out List<Localities> lstLOCAL)
        {
            long returnCode = -1;
            lstLOCAL = new List<Localities>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetZoneNameCommand(OrgID, prefixText);
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstLOCAL);
                        dataReader.Close();
                    } 
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetZoneName DAL", ex);
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


        //Changes of DataSet To DataReader Made By Arjun
        public long GetHubCode(int OrgID, string prefixText, out List<Localities> lstLOCAL)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstLOCAL = new List<Localities>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetHubCodeCommand(OrgID, prefixText);
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstLOCAL);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetHubCode ScheduleDAL", ex);
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

        //Changes of DataSet To DataReader Made By Arjun
        public long GetZoneCode(int OrgID, string prefixText, out List<Localities> lstLOCAL)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstLOCAL = new List<Localities>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetZoneCodeCommand(OrgID, prefixText);
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstLOCAL);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetZoneCode DAL", ex);
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
        //Changes of DataSet To DataReader Made By Arjun
        public long GetRouteCode(int OrgID, string prefixText, out List<Localities> lstLOCAL)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstLOCAL = new List<Localities>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetRouteCodeCommand(OrgID, prefixText);
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstLOCAL);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetRouteCode DAL", ex);
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

        public long GetBookingsDt(long BookingID, out List<Bookings> bookings, out List<Bookings> bookingsQuat)
        {
            long returnCode = -1;
            bookings = new List<Bookings>();
            bookingsQuat = new List<Bookings>();
            SqlCommand Bookingcmd = Command.pGetBookingDtlCommand(BookingID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
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
        public long GetOrgInvestigations(int Orgid, int Locationid, string prefixText, string ItemType, out List<BillingFeeDetails> lstBillingFeeDetails)
        {
            long returnCode = -1;
            lstBillingFeeDetails = new List<BillingFeeDetails>();
            try
            {
                SqlCommand cmd;
                cmd = Command.pGetOrgInvestigationsCommand(Orgid, Locationid, prefixText, ItemType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBillingFeeDetails);
                }


            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Library Codes", ex);
            }

            return returnCode;

        }


        public long GetWatersClientSchedules(int orgID, int customerTypeID, string Client, long ClientID, int LocationID,
         DateTime sFromDate, DateTime sToDate, out List<Schedulesinvoice> schedules, int PageSize, int startRowIndex, out int totalRows, string searchtype)
        {
            long retCode = -1;
            totalRows = -1;
            DataSet ds = new DataSet();
            schedules = new List<Schedulesinvoice>();

            SqlCommand cmd = Command.pGetWatersClientSchedulesCommand(orgID, customerTypeID, LocationID, Client, ClientID, sFromDate, sToDate, PageSize, startRowIndex, out totalRows, searchtype, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dBEngine = new DBEngine())
            {
                dBEngine.ExecuteDataSet(cmd, out ds);
            }

            if (ds.Tables.Count > 0)
            {
                Utilities.ConvertTo(ds.Tables[0], out schedules);
                totalRows = Convert.ToInt32(ds.Tables[1].Rows[0]["totalRows"]);

            }
            return retCode;
        }


    }
}
