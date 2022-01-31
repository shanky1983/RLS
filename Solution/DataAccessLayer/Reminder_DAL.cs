using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.SqlClient;
using System.Collections.Generic;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities;
using Attune.Podium.Common;

namespace Attune.Solution.DAL
{
    public class Reminder_DAL
    {
        ContextDetails globalContextDetails;
        public Reminder_DAL()
        {
            
        }
        public Reminder_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public long SaveReminderTemplate(ReminderTemplate reminderTemplate)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pInsertReminderTemplateCommand(reminderTemplate.StartDate, reminderTemplate.EndDate, reminderTemplate.Notes, reminderTemplate.UserID, reminderTemplate.RoleID, reminderTemplate.Frequency,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(false))
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
            }
            return returnCode;
        }


        public long GetReminderTemplate(long userID, int roleID, out List<ReminderTemplate> lstReminderTemplate)
        {
            long returnCode = -1;
            lstReminderTemplate = new List<ReminderTemplate>();
            DataSet ds = new DataSet();
            SqlCommand cmd = Command.pGetReminderTemplateCommand(userID, roleID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(false))
            {
                returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
            }

            if (ds.Tables[0].Rows.Count > 0)
            {

                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstReminderTemplate);
            }
            return returnCode;
        }

        public long UpdatereminderTemplate(ReminderTemplate reminderTemplate)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pUpdateReminderTemplateCommand(reminderTemplate.ReminderTemplateID, reminderTemplate.StartDate, reminderTemplate.EndDate, reminderTemplate.Notes, reminderTemplate.Frequency,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(false))
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
            }

            return returnCode;


        }

        public long DeleteReminderTemplate(long remainderTemplateID)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pDeleteReminderTemplateCommand(remainderTemplateID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(false))
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
            }

            return returnCode;
        }

        // changed dataset to datareader by Arivalagan.k
        public long GetReminderDetails(long userID, long roleID, out List<Reminder> lstReminder)
        {
            long returnCode = -1;
            DataSet ds = new DataSet();
            lstReminder = new List<Reminder>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetReminderDetailCommand(userID, roleID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstReminder);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetReminderDetails Remainder_DAL", e);
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

        public long UpdateReminderStatus(long remainderID)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pUpdateReminderStatusCommand(remainderID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
            }

            return returnCode;
        }

        public long UpdateReminderDeferDate(long remainderID, DateTime deferDate)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pUpdateReminderDeferDateCommand(remainderID, deferDate,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
            }

            return returnCode;

        }

    }
}
