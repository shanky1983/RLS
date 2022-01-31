using System;
using System.Collections.Generic;
using Attune.Podium.BusinessEntities;
using Attune.Solution.DAL;
using Attune.Podium.Common;


namespace Attune.Solution.BusinessComponent
{
   public class Reminder_BL
    {
        ContextDetails globalContextDetails;
        public Reminder_BL()
        {

        }
        public Reminder_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

       public long SaveReminderTemplate(ReminderTemplate reminderTemplate)
       {
           long returnCode = -1;
           try
           {
               Reminder_DAL reminderDAL = new Reminder_DAL(globalContextDetails);
               returnCode = reminderDAL.SaveReminderTemplate(reminderTemplate);
           }
           catch (Exception ex)
           {
               CLogger.LogError("Error while save reminder template", ex);
           }
           return returnCode;
       }

       public long getReminderTemplate(long userID, int roleID, out List<ReminderTemplate> lstReminderTemplate)
       {
           long returnCode = -1;
           lstReminderTemplate = new List<ReminderTemplate>();
           try
           {
               Reminder_DAL reminderDAL = new Reminder_DAL(globalContextDetails);
               returnCode = reminderDAL.GetReminderTemplate(userID, roleID, out lstReminderTemplate);
           }
           catch (Exception ex)
           {
               CLogger.LogError("Error while get reminder template detail", ex);
           }
           return returnCode;
       }

       public long UpdatereminderTemplate(ReminderTemplate reminderTemplate)
       {
           long returnCode = -1;
           Reminder_DAL reminderDAL = new Reminder_DAL(globalContextDetails);
           try
           {
               returnCode = reminderDAL.UpdatereminderTemplate(reminderTemplate);
           }
           catch (Exception ex)
           {
               CLogger.LogError("Error while update reminder template", ex);
           }
           return returnCode;
       }

       public long DeleteReminderTemplate(long reminderTemplateID)
       {
           long returnCode = -1;
           Reminder_DAL reminderDAL = new Reminder_DAL(globalContextDetails);
           try
           {
               returnCode = reminderDAL.DeleteReminderTemplate(reminderTemplateID);
           }
           catch (Exception ex)
           {
               CLogger.LogError("Error while delete reminder template", ex);
           }
           return returnCode;
       }

       public long GetReminderDetail(long userID, long roleID, out List<Reminder> lstReminder)
       {
           long returnCode = -1;
           lstReminder = new List<Reminder>();
           try
           {
               Reminder_DAL reminderDAL = new Reminder_DAL(globalContextDetails);
               returnCode = reminderDAL.GetReminderDetails(userID, roleID, out lstReminder);
           }
           catch (Exception ex)
           {
               CLogger.LogError("Error while loading get Reminder Details", ex);
           }
           return returnCode;

       }

       public long UpdateReminderStatus(long reminterID)
       {
           long returnCode = -1;
           Reminder_DAL reminderDAL = new Reminder_DAL(globalContextDetails);
           try
           {
               returnCode = reminderDAL.UpdateReminderStatus(reminterID);
           }
           catch (Exception ex)
           {
               CLogger.LogError("Error while loading update reminder status", ex);
           }
           return returnCode;
       }

       public long UpdateReminderDeferDate(long reminderID, DateTime deferDate)
       {
           long returnCode = -1;
           try
           {
               Reminder_DAL reminderDAL = new Reminder_DAL(globalContextDetails);
               returnCode = reminderDAL.UpdateReminderDeferDate(reminderID, deferDate);
           }
           catch (Exception ex)
           {
               CLogger.LogError("Error while laoding update reminder defer date", ex);
           }
           return returnCode;

       }



    }
}
