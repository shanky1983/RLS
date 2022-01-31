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
        public long GetBookings(long resourceTemplateID, int OrgID, DateTime startTime, long scheduleID, out int scheduleTemplateID, out List<Bookings> bookings, out List<ScheduleTemplate> stemplate)
        {
            long returnCode = -1;
            bookings = new List<Bookings>();
            stemplate = new List<ScheduleTemplate>();
            scheduleTemplateID = 0;
            SqlCommand Bookingcmd = Command.pGetBookingsCommand(resourceTemplateID, OrgID, startTime, scheduleID);
            DataSet ds = new DataSet();


            using (DBEngine dBEngine = new DBEngine())
            {
                dBEngine.ExecuteDataSet(Bookingcmd, out ds);
            }

            if (ds.Tables.Count > 2)
            {
                //Get booked schedules
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
            cmd = Command.pCancelBookingsCommand(bookID, description);

            using (DBEngine dBEngine = new DBEngine())
            {
                returnCode = dBEngine.ExecuteNonQuery(cmd);
            }
            return returnCode;
        }

        public long GetRecurrencePattern(int scheduleTemplateID, out DateTime lastOccurance, out List<RecurrenceRelative> rrelative, out List<RecurrenceAbsolute> rabsolute)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pGetRecurrenceCommand(scheduleTemplateID);
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
                //DateTime.TryParse(ds.Tables[2].Rows[0][0].ToString(), out lastOccurance);
                Utilities.ConvertTo(ds.Tables[0], out rrelative);
                Utilities.ConvertTo(ds.Tables[1], out rabsolute);
            }
            returnCode = 0;
            return returnCode;
        }

        public long GetPhysicianList(int OrgID,out List<PhysicianSchedule> physicianschedule)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pGetPhysiciansCommand(OrgID,"VIS");
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
            SqlCommand cmd = Command.pGetScheduleTemplatesCommand(resourceTemplateID, orgID);
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
            SqlCommand cmd = Command.pInsertBookingCommand(book.ResourceTemplateID, book.ScheduleID, book.StartTime, book.EndTime, book.TokenNumber, book.Description, book.CreatedBy, book.PatientNumber, book.PhoneNumber, book.PatientName, book.CancelRemarks, book.OrgID, book.BookingOrgID,book.ReferalID);

            using (DBEngine dBEngine = new DBEngine())
            {
                returnCode = dBEngine.ExecuteNonQuery(cmd);
            }
            return returnCode;
        }

        public long SaveSchedule(Schedules schs)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pInsertSchedulesCommand(schs.ResourceTemplateID, schs.NextOccurance, schs.PreviousOccurance, schs.Status, schs.CreatedBy);

            using (DBEngine dBEngine = new DBEngine())
            {
                returnCode = dBEngine.ExecuteNonQuery(cmd);
            }
            return returnCode;
        }
        public long DeleteSchedule(long resourceTemplateID)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pDeleteSchedulesCommand(resourceTemplateID);

            using (DBEngine dBEngine = new DBEngine())
            {
                returnCode = dBEngine.ExecuteNonQuery(cmd);
            }
            return returnCode;
        }

        public long GetSchedules(long resourceTemplateID, int orgID, 
            out List<PhysicianSchedule> schedules, 
            out List<PhysicianSpeciality> phySpeciality, 
            int LocationID,
            DateTime sFromDate, DateTime sToDate)
        {
            long retCode = -1;
            DataSet ds = new DataSet();
            schedules = new List<PhysicianSchedule>();
            phySpeciality = new List<PhysicianSpeciality>();
            SqlCommand cmd = Command.pGetPhySchedulesCommand(resourceTemplateID, orgID, LocationID, sFromDate,sToDate);
            
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


        public long InsertSchedules(List<RecurrenceAbsolute> lstRAbsolute, List<RecurrenceRelative> lstRelative,
            List<ScheduleTemplate> lstScheduleTemp,List<SchedulableResource> lstResource,
            List<Schedules> lstSchedules,int stid,int rtid,int RecurrenceID)
        {
            int result = -1;
            int resultStatus = -1;
            long resultCode=-1;
            int RID = 0;
            int RCyleId=0;
            int STempID=0;
            long RTempID = 0;
            SqlCommand cmdRelative=null;
            if (lstRelative.Count > 0)
            {
                cmdRelative = Command.pInsertRelativeCommand(lstRelative[0].Type, lstRelative[0].Interval,out RID, out result);
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
                                lstRAbsolute[0].ParentRecurrenceCycleID, lstRAbsolute[0].Unit, lstRAbsolute[0].Value, out RCyleId);
                                dbEngine.ExecuteTransactionalNonQuery(cmdAbsolute);
                                if (lstRAbsolute[0].Unit == TaskHelper.unit.WN.ToString())
                                {
                                    RCyleId = Convert.ToInt32(cmdAbsolute.Parameters["@RCID"].Value);
                                    cmdAbsolute = Command.pInsertRecurrenceAbsoluteCommand(RID,
                                    RCyleId, lstRAbsolute[1].Unit, lstRAbsolute[1].Value, out RCyleId);
                                    dbEngine.ExecuteTransactionalNonQuery(cmdAbsolute);
                                }
                                else if (resultCode == 1 && lstRAbsolute[0].Unit == TaskHelper.unit.MN.ToString())
                                {
                                    RCyleId = Convert.ToInt32(cmdAbsolute.Parameters["@RCID"].Value);
                                    cmdAbsolute = Command.pInsertRecurrenceAbsoluteCommand(RID,
                                    RCyleId, lstRAbsolute[1].Unit, lstRAbsolute[1].Value, out RCyleId);
                                    dbEngine.ExecuteTransactionalNonQuery(cmdAbsolute);
                                }
                            }
                            cmdScheduleTemp = Command.pInsertScheduleTempCommand(lstScheduleTemp[0].StartTime, lstScheduleTemp[0].EndTime,
                                lstScheduleTemp[0].SlotDuration, RID, out resultStatus, out STempID);
                            dbEngine.ExecuteTransactionalNonQuery(cmdScheduleTemp);
                            resultStatus = Convert.ToInt32(cmdScheduleTemp.Parameters["@result"].Value);
                            STempID = Convert.ToInt32(cmdScheduleTemp.Parameters["@TempId"].Value);
                            if (resultStatus == 0)
                            {
                                cmdResource = Command.pInsertScheduleResourceCommand(lstResource[0].ResourceID, lstResource[0].ResourceType,
                                    lstResource[0].OrgID, STempID, lstResource[0].CreatedBy, out RTempID, out resultStatus,lstResource[0].OrgAddressID);
                                dbEngine.ExecuteTransactionalNonQuery(cmdResource);
                                resultStatus = Convert.ToInt32(cmdResource.Parameters["@result"].Value);
                                RTempID = Convert.ToInt64(cmdResource.Parameters["@ResTempId"].Value);
                                if (resultStatus == 0)
                                {
                                    cmdSchedules = Command.pInsertDScheduleCommand(RTempID, lstSchedules[0].NextOccurance, lstSchedules[0].PreviousOccurance,
                                      lstSchedules[0].Status, lstSchedules[0].CreatedBy, out resultStatus);
                                    dbEngine.ExecuteTransactionalNonQuery(cmdSchedules);
                                    resultStatus = Convert.ToInt32(cmdScheduleTemp.Parameters["@result"].Value);
                                    resultCode = resultStatus;
                                }
                            }
                        }
                        else
                        {
                            cmdScheduleTemp = Command.pInsertScheduleTempCommand(lstScheduleTemp[0].StartTime, lstScheduleTemp[0].EndTime,
                                lstScheduleTemp[0].SlotDuration, lstScheduleTemp[0].RecurrenceID, out resultStatus, out STempID);
                            dbEngine.ExecuteTransactionalNonQuery(cmdScheduleTemp);
                            resultStatus = Convert.ToInt32(cmdScheduleTemp.Parameters["@result"].Value);
                            STempID = Convert.ToInt32(cmdScheduleTemp.Parameters["@TempId"].Value);

                            if (resultStatus == 0)
                            {
                                cmdResource = Command.pInsertScheduleResourceCommand(lstResource[0].ResourceID, lstResource[0].ResourceType,
                                    lstResource[0].OrgID, STempID, lstResource[0].CreatedBy, out RTempID, out resultStatus,lstResource[0].OrgAddressID);
                                dbEngine.ExecuteTransactionalNonQuery(cmdResource);
                                resultStatus = Convert.ToInt32(cmdResource.Parameters["@result"].Value);
                                RTempID = Convert.ToInt64(cmdResource.Parameters["@ResTempId"].Value);
                                if (resultStatus == 0)
                                {
                                    cmdSchedules = Command.pInsertDScheduleCommand(RTempID, lstSchedules[0].NextOccurance, lstSchedules[0].PreviousOccurance,
                                      lstSchedules[0].Status, lstSchedules[0].CreatedBy, out resultStatus);
                                    dbEngine.ExecuteTransactionalNonQuery(cmdSchedules);
                                    resultStatus = Convert.ToInt32(cmdScheduleTemp.Parameters["@result"].Value);
                                    resultCode = resultStatus;
                                }
                            }
                        }

                        if (resultCode == 0)
                        {
                            cmdResource = Command.pDeleteAllSchedulesCommand(stid, rtid, RecurrenceID, out resultStatus);
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
            SqlCommand Bookingcmd = Command.pGetListOfSchedulesCommand(pOrgAddID, FromDate, ToDate, ResourceID, ResourceType);
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
                                        DateTime FromDate,DateTime ToDate,int LocationID)
        {
            long retCode = -1;
            DataSet ds = new DataSet();
            schedules = new List<PhysicianSchedule>();
            phySpeciality = new List<PhysicianSpeciality>();
            SqlCommand cmd = Command.pGetPhySchedulesForEditCommand(resourceID, orgID,sType,FromDate,ToDate,LocationID);

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

        public long SaveExceptionSchedule(long lRTID,long lSID,DateTime dDateofChange,DateTime sStartTime,DateTime sEndTime,int iSDuration,int LID)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pInsertExceptionSchedulesCommand(lRTID, lSID, dDateofChange, sStartTime, sEndTime, iSDuration, LID);

            using (DBEngine dBEngine = new DBEngine())
            {
                returnCode = dBEngine.ExecuteNonQuery(cmd);
            }
            return returnCode;
        }


        public long InsertVacation(int iVacationID,long lPhyID,DateTime sFromDate,DateTime sToDate,string sCancelledSchedules,string sStatus,int iCreatedBy)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pInsertPhyVacationCommand(iVacationID, lPhyID, sFromDate, sToDate, sCancelledSchedules, sStatus, iCreatedBy);

            using (DBEngine dBEngine = new DBEngine())
            {
                returnCode = dBEngine.ExecuteNonQuery(cmd);
            }
            return returnCode;
        }

        public long GetPhysicianVacations(long resourceID, int orgID, out List<PhysicianSchedule> schedules,
                                        out List<PhysicianSpeciality> phySpeciality, string sType, DateTime FromDate, 
                                        DateTime ToDate,out List<DoctorSchedule> lstDocSchedule,out List<PhysicianVacationDetails> lstVacationDetails)
        {
            long retCode = -1;
            DataSet ds = new DataSet();
            schedules = new List<PhysicianSchedule>();
            phySpeciality = new List<PhysicianSpeciality>();
            lstDocSchedule =new List<DoctorSchedule>();
            lstVacationDetails = new List<PhysicianVacationDetails>();

            SqlCommand cmd = Command.pGetPhyVacationSchedulesCommand(resourceID, orgID, sType, FromDate, ToDate);

            using (DBEngine dBEngine = new DBEngine())
            {
                dBEngine.ExecuteDataSet(cmd, out ds);
            }

            if (ds.Tables.Count > 0)
            {
                Utilities.ConvertTo(ds.Tables[0], out schedules);
            }
            if (ds.Tables.Count > 1)
                //Utilities.ConvertTo(ds.Tables[1], out phySpeciality);
                Utilities.ConvertTo(ds.Tables[1], out lstDocSchedule);
            if (ds.Tables.Count > 2)
                //Utilities.ConvertTo(ds.Tables[1], out phySpeciality);
                Utilities.ConvertTo(ds.Tables[2], out lstVacationDetails);
          

            retCode = 0;
            return retCode;
        }

        public long UpdatePhysicianVacation(int iVacationID, int iCreatedBy )
        {
            long retCode = -1;
            SqlCommand cmd = Command.pUpdatePhyVacationCommand(iVacationID, iCreatedBy);

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
            SqlCommand cmd = Command.pCancelSchedulesCommand(ischdeuleID);

            using (DBEngine dBEngine = new DBEngine())
            {
                dBEngine.ExecuteNonQuery(cmd);
            }
            retCode = 0;
            return retCode;
        }

        //public long getTrustedOrgs(int iOrgID,out List<TrustedOrgs> lsttrust)
        //{
        //    long retCode = -1;
        //    lsttrust = new List<TrustedOrgs>();
        //    SqlCommand cmd = Command.pGetTrustedOrgsCommand(iOrgID);
        //    DataSet ds = new DataSet();

        //    using (DBEngine dBEngine = new DBEngine())
        //    {
        //        dBEngine.ExecuteDataSet(cmd, out ds);
        //    }
        //    if (ds.Tables.Count > 0)
        //    {
        //        Utilities.ConvertTo(ds.Tables[0], out lsttrust);
        //    }
        //    retCode = 0;
        //    return retCode;
        //}

        public long getOrganizations(out List<OrganizationAddress> lstOrganization)
        {
            long retCode = -1;
            SqlCommand cmd = Command.pGetOrganizationAddressCommand();
            DataSet ds = new DataSet();
            lstOrganization = new List<OrganizationAddress>();

            using (DBEngine dBEngine = new DBEngine())
            {
                dBEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                Utilities.ConvertTo(ds.Tables[0], out lstOrganization);
            }
            retCode = 0;
            return retCode;
        }

        public long getOrganizationAddress(out List<OrganizationAddress> lstOrganizationAddress)
        {
            long retCode = -1;
            SqlCommand cmd = Command.pGetOrganizationAddressCommand();
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

    }
}
