using System;
using System.Collections.Generic;
using Attune.KernelV2.CacheEngine;
using Attune.KernelV2.DAL;
using Attune.KernelV2.Entities;
using Attune.KernelV2.Utilities;
using System.Collections;
using System.Linq;

namespace Attune.KernelV2.BL
{
    public class Task_BL : IDisposable
    {
        UI_ContextDetails globalContextDetails;

        public Task_BL(UI_ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public List<UI_TaskActions> GetTaskActionID(long orgID, long visitPutposeID, long otherID)
        {
            Utility objUtilities = new Utility();
            string KeyValue;
            objUtilities.GetApplicationValue("TaskAction", out KeyValue);
            List<UI_TaskActions> lstTaskAction;

            if (KeyValue.ToUpper() == "Y")
            {
                CacheProvider _cp = new CacheProvider(1);
                string pKey = _cp.GetKey(CacheKey.TaskAction, globalContextDetails.OrgID);
                if (_cp.IsInCache(pKey))
                {
                    lstTaskAction = _cp.Get<List<UI_TaskActions>>(pKey);
                }
                else
                {
                    using (Task_DAL DAL = new Task_DAL(globalContextDetails))
                    {
                        lstTaskAction = DAL.GetTaskActionID(orgID, 0, 0);
                    }
                    if (lstTaskAction != null)
                    {
                        _cp.Set(pKey, lstTaskAction);
                    }
                }
                if (lstTaskAction != null)
                    return lstTaskAction.FindAll(p => p.OtherID == otherID && p.VisitPurposeID == visitPutposeID);

            }
            else
            {
                using (Task_DAL DAL = new Task_DAL(globalContextDetails))
                {
                    return DAL.GetTaskActionID(orgID, visitPutposeID, otherID);
                }
            }
            return lstTaskAction;
        }

        public UI_TaskActions GetTaskDispTextAndURL(int TaskActionID)
        {

            Utility objUtilities = new Utility();
            string KeyValue;
            objUtilities.GetApplicationValue("TaskDescURL", out KeyValue);
            List<UI_TaskActions> lstTask;

            UI_TaskActions objTaskActions = null;

            if (KeyValue.ToUpper() == "Y")
            {
                CacheProvider _cp = new CacheProvider(0);
                string pKey = _cp.GetKey(CacheKey.TaskDescURL, 0);
                if (_cp.IsInCache(pKey))
                {
                    lstTask = _cp.Get<List<UI_TaskActions>>(pKey);

                }
                else
                {
                    using (Task_DAL DAL = new Task_DAL(globalContextDetails))
                    {
                        lstTask = DAL.GetTaskDispTextAndURL(0);
                    }
                    if (lstTask != null)
                    {
                        _cp.Set(pKey, lstTask);
                    }
                }
                if (lstTask != null)
                {
                    var pobj = lstTask.Find(p => p.TaskActionID == TaskActionID && p.LanguageCode == globalContextDetails.LanguageCode);
                    objTaskActions = new UI_TaskActions()
                    {
                        DisplayTextTemplate = pobj.DisplayTextTemplate,
                        RedirectURL = pobj.RedirectURL

                    };


                }




            }
            else
            {
                using (Task_DAL DAL = new Task_DAL(globalContextDetails))
                {
                    lstTask = DAL.GetTaskDispTextAndURL(TaskActionID);
                    objTaskActions = lstTask.SingleOrDefault(p => p.TaskActionID == TaskActionID);
                }
            }
            return objTaskActions;
        }

        public UI_Tasks InsertTask(UI_Tasks oTasks)
        {
            UI_Tasks objTask = null;
            UI_TaskActions oTaskActions = GetTaskDispTextAndURL(oTasks.TaskActionID);

            if (oTaskActions != null)
            {
                foreach (string key in oTasks.URLFiller.Keys)
                {
                    if (oTaskActions.RedirectURL.Contains("{" + key + "}"))
                    {
                        oTaskActions.RedirectURL = oTaskActions.RedirectURL.Replace("{" + key + "}", oTasks.URLFiller[key].ToString());
                    }
                }

                foreach (string key in oTasks.DispTextFiller.Keys)
                {
                    if (oTaskActions.DisplayTextTemplate.Contains("{" + key + "}"))
                    {
                        oTaskActions.DisplayTextTemplate = oTaskActions.DisplayTextTemplate.Replace("{" + key + "}", oTasks.DispTextFiller[key].ToString());
                    }
                }
                oTasks.RedirectURL = oTaskActions.RedirectURL;
                oTasks.TaskDescription = oTaskActions.DisplayTextTemplate;


                using (Task_DAL DAL = new Task_DAL(globalContextDetails))
                {
                    objTask = DAL.InsertTask(oTasks.TaskActionID, oTasks.TaskDescription, oTasks.RedirectURL, oTasks.PatientID, oTasks.AssignedTo, oTasks.OrgID,
                        oTasks.ParentID, oTasks.PatientVisitID, oTasks.HighlightColor ?? "",
                        oTasks.CreatedBy, oTasks.SpecialityID, oTasks.TaskID, oTasks.LocationID, oTasks.RefernceID);
                }
            }
            return objTask;
        }

        public UI_Tasks CreateTaskAllowDuplicate(UI_Tasks task)
        {
            UI_Tasks Task;
            UI_TaskActions oTaskActions = GetTaskDispTextAndURL(task.TaskActionID);
            if (oTaskActions != null)
            {
                foreach (string key in task.URLFiller.Keys)
                {
                    if (oTaskActions.RedirectURL.Contains("{" + key + "}"))
                    {
                        oTaskActions.RedirectURL = oTaskActions.RedirectURL.Replace("{" + key + "}", task.URLFiller[key].ToString());
                    }
                }

                foreach (string key in task.DispTextFiller.Keys)
                {
                    if (oTaskActions.DisplayTextTemplate.Contains("{" + key + "}"))
                    {
                        oTaskActions.DisplayTextTemplate = oTaskActions.DisplayTextTemplate.Replace("{" + key + "}", task.DispTextFiller[key].ToString());
                    }
                }
                task.RedirectURL = oTaskActions.RedirectURL;
                task.TaskDescription = oTaskActions.DisplayTextTemplate;
                using (Task_DAL DAL = new Task_DAL(globalContextDetails))
                {
                    Task = DAL.CreateTaskAllowDuplicate(task);
                }
            }
            return task;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
