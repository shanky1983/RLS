using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using Attune.KernelV2.Cmd;
using Attune.KernelV2.DataAccessEngine;
using Attune.KernelV2.Entities;
using Attune.KernelV2.UDT;
using Attune.KernelV2.Utilities;

namespace Attune.KernelV2.DAL
{
    public class Task_DAL : IDisposable
    {
        UI_ContextDetails globalContextDetails;

        public Task_DAL(UI_ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public List<UI_TaskActions> GetTaskActionID(long OrgID, long VisitPurposeID, long OtherID)
        {
            List<UI_TaskActions> lstTaskAction = null;
            using (DbHelper gateWay = new DbHelper())
            {

                var cmd = KernelV2_Command.pGetTaskActionID_V2Command(OrgID, VisitPurposeID, OtherID, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    lstTaskAction = Utility.Tolist<UI_TaskActions>(dataReader).ToList();
                }
            }
            return lstTaskAction;
        }

        public List<UI_TaskActions> GetTaskDispTextAndURL(int TaskActionID)
        {
            List<UI_TaskActions> lstTask = null;
            using (DbHelper gateWay = new DbHelper())
            {

                var cmd = KernelV2_Command.pGetTaskDispTextAndURL_V2Command(TaskActionID, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    lstTask = Utility.Tolist<UI_TaskActions>(dataReader).ToList();
                }
            }
            return lstTask;
        }

        public UI_Tasks InsertTask(int TaskActionID, string TaskDescription, string RedirectURL, long PatientID, long AssignedTo, int OrgID,
            long ParentID, long PatientVisitID, string HighlightColor, long CreatedBy, int SpecialityID, long TaskID, int LocationID, string RefernceID)
        {
            UI_Tasks objTask = null;
            using (DbHelper gateWay = new DbHelper())
            {

                var cmd = KernelV2_Command.pInsertTask_V2Command(TaskActionID, TaskDescription, RedirectURL, PatientID, AssignedTo, OrgID, ParentID, PatientVisitID, HighlightColor,
                    CreatedBy, SpecialityID, TaskID, LocationID, RefernceID, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));
                DbDataReader dataReader = gateWay.ExecuteReader(cmd);
                if (dataReader != null)
                {
                    objTask = Utility.ToObject<UI_Tasks>(dataReader);
                }
            }
            return objTask;
        }

        public UI_Tasks CreateTaskAllowDuplicate(UI_Tasks task)
        {
            long returnCode = -1;
            long taskID = -1;
            var cmd = KernelV2_Command.pInsertTaskAllowDuplicateCommand(task.TaskActionID, task.TaskDescription, task.RedirectURL, task.PatientID,
                                    task.AssignedTo, task.OrgID, task.ParentID, task.PatientVisitID,
                                    !string.IsNullOrEmpty(task.HighlightColor) ? task.HighlightColor : "", task.CreatedBy, task.SpecialityID, task.RefernceID,
                                    !string.IsNullOrEmpty(task.Type) ? task.Type : "", out taskID,
                                    task.IsStat, KernelV2_UDT.ConvertToUDT_Context(globalContextDetails));

            using (DbHelper gateWay = new DbHelper())
            {
                returnCode = gateWay.ExecuteNonQuery(cmd);
                task.TaskID = Convert.ToInt64(cmd.Parameters["@pTaskID"].Value);
            }

            return task;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
