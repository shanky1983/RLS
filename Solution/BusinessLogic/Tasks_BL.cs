using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using Attune.Solution.DAL;
using Attune.Podium.BusinessEntities;
using Attune.Podium.Common;
using System.Collections;


namespace Attune.Solution.BusinessComponent
{
    public class Tasks_BL
    {
        ContextDetails globalContextDetails;
        public Tasks_BL()
        {

        }
        public Tasks_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        #region TaskRetrieval

        public long GetTasks(int RoleID, int OrgID, long UID, out List<Tasks> lstTasks, int LocationID, int startRowIndex, int pageSize, out int totalRows)
        {
            long returnCode = -1;
            lstTasks = null;
            totalRows = -1;
            try
            {

                Tasks_DAL tasksDal = new Tasks_DAL(globalContextDetails);
                returnCode = tasksDal.GetTasks(RoleID, OrgID, UID, out lstTasks, LocationID, startRowIndex, pageSize, out totalRows);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetTasks BL", excp);
            }

            return returnCode;
        }

        public long GetTasks(int RoleID, int OrgID, long UID, DateTime TaskDate, out List<Tasks> lstTasks)
        {
            long returnCode = -1;
            lstTasks = null;

            try
            {

                Tasks_DAL tasksDal = new Tasks_DAL(globalContextDetails);
                returnCode = tasksDal.GetTasks(RoleID, OrgID, UID, TaskDate, out lstTasks);

            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetTasks BL(with taksdate)", excp);
            }

            return returnCode;
        }

        public long GetTasks(int RoleID, int orgID, long UID, string category, out List<Tasks> lstTasks)
        {
            long returnCode = -1;
            lstTasks = null;
            try
            {

                Tasks_DAL tasksDal = new Tasks_DAL(globalContextDetails);
                returnCode = tasksDal.GetTasks(RoleID, orgID, UID, category, out lstTasks);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetTasks BL(with category)", excp);
            }

            return returnCode;
        }

        public long GetTasks(int RoleID, int OrgID, long UID, DateTime TaskDate, string category, out List<Tasks> lstTasks)
        {
            long returnCode = -1;
            lstTasks = null;

            try
            {

                Tasks_DAL tasksDal = new Tasks_DAL(globalContextDetails);
                returnCode = tasksDal.GetTasks(RoleID, OrgID, UID, TaskDate, category, out lstTasks);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetTasks", excp);
            }

            return returnCode;
        }

        public long GetTasks(int RoleID, int OrgID, long UID, out List<TaskDetails> lstTasks, int LocationID, int startRowIndex, int pageSize, out int totalRows)
        {
            long returnCode = -1;
            lstTasks = null;
            totalRows = -1;
            try
            {

                Tasks_DAL tasksDal = new Tasks_DAL(globalContextDetails);
                returnCode = tasksDal.GetTasks(RoleID, OrgID, UID, out lstTasks, LocationID, startRowIndex, pageSize, out totalRows);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetTasks BL", excp);
            }

            return returnCode;
        }

        public long GetTaskLocationAndSpeciality(int OrgID, long RoleID, long LoginID,string Type, out List<OrganizationAddress> lstLocation, out List<Speciality> lstSpeciality, out List<TaskActions> lstCategory, out TaskProfile taskProfile, out List<InvDeptMaster> lstDept, out List<ClientMaster> lstClient, out List<MetaData> lstProtocal)
        {
            long returnCode = -1;
            lstLocation = null;
            lstSpeciality = null;
            lstCategory = null;
            taskProfile = null;
            lstDept = new List<InvDeptMaster>();
            lstClient = new List<ClientMaster>();
            lstProtocal = new List<MetaData>();
            try
            {

                Tasks_DAL tasksDal = new Tasks_DAL(globalContextDetails);
                returnCode = tasksDal.GetTaskLocationAndSpeciality(OrgID, RoleID, LoginID,Type, out lstLocation, out lstSpeciality, out lstCategory, out taskProfile, out lstDept,out lstClient,out lstProtocal);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetTasks BL", excp);
            }

            return returnCode;
        }

        public long GetAllTasks(int RoleID, int OrgID, long UID, string TaskDate, string category, long orgAddrId, int specId, string PatientNumber,
         out List<TaskDetails> lstTasks, int InvLocationID, int startRowIndex, int pageSize, out int totalRows, int DeptID, long ClientID, LoginDetail LDetail, List<TrustedOrgActions> lstTrustedOrgAction, string Preference, long ProtocalGroupID,int VisitType)
        {
            long returnCode = -1;
            lstTasks = null;
            totalRows = -1;

            try
            {


                Tasks_DAL tasksDal = new Tasks_DAL(globalContextDetails);
                returnCode = tasksDal.GetAllTasks(RoleID, OrgID, UID, TaskDate, category, orgAddrId, specId, PatientNumber, out lstTasks, InvLocationID, startRowIndex, pageSize, out totalRows, DeptID,ClientID, LDetail, lstTrustedOrgAction, Preference,ProtocalGroupID,VisitType);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetTasks BL", excp);
            }


            return returnCode;
        }







        public long GetAllTaskActions(out List<TaskActions> lstAllTaskActions, Int32 OrgID)
        {
            long returnCode = -1;
            lstAllTaskActions = null;

            try
            {

                Tasks_DAL tasksDal = new Tasks_DAL(globalContextDetails);
                returnCode = tasksDal.GetAllTaskActions(out lstAllTaskActions, OrgID);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetAllActions BL", excp);
            }

            return returnCode;
        }

        public long GetTasksForGivenStatus(string FromDt, string ToDt, int TaskActionID, int OrgID, out List<Tasks> lstTasks)
        {
            long returnCode = -1;
            lstTasks = null;

            try
            {
                Tasks_DAL tasksDal = new Tasks_DAL(globalContextDetails);
                returnCode = tasksDal.GetTasksForGivenStatus(FromDt, ToDt, TaskActionID, OrgID, out lstTasks);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetTasksForGivenStatus BL", excp);
            }

            return returnCode;
        }

        #endregion

        #region Private Methods

        public void GetTaskDispTextAndURL(int taskActionID, out string dispText, out string redirectURL)
        {
            dispText = "";
            redirectURL = "";

            Tasks_DAL tdal = new Tasks_DAL(globalContextDetails);
            tdal.GetTaskDispTextAndURL(taskActionID, out dispText, out redirectURL);
        }

        #endregion

        #region TaskCreation

        public long CreateTask(Tasks tasks, out long taskID)
        {
            long returnCode = -1;
            taskID = -1;
            string dispText = string.Empty;
            string redirectURL = string.Empty;
            try
            {
                Hashtable dispTextfiller = tasks.DispTextFiller;
                Hashtable URLFiller = tasks.URLFiller;

                //Get the display text and redirect url templates
                GetTaskDispTextAndURL(tasks.TaskActionID, out  dispText, out redirectURL);

                foreach (string key in URLFiller.Keys)
                {
                    if (redirectURL.Contains("{" + key + "}"))
                    {
                        redirectURL = redirectURL.Replace("{" + key + "}", URLFiller[key].ToString());
                    }
                }


                foreach (string key in dispTextfiller.Keys)
                {
                    if (dispText.Contains("{" + key + "}"))
                    {
                        dispText = dispText.Replace("{" + key + "}", dispTextfiller[key].ToString());
                    }
                }
                tasks.RedirectURL = redirectURL;
                tasks.TaskDescription = dispText;


                Tasks_DAL tasksDal = new Tasks_DAL(globalContextDetails);
                returnCode = tasksDal.CreateTask(tasks, out taskID);
                return returnCode;
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in create task BL Message: ", ex);
                return returnCode;
            }

        }

        public long CreateGroupTask(List<Tasks> lstTasks, out long taskID)
        {
            long returnCode = -1;
            taskID = -1;
            string dispText = string.Empty;
            string redirectURL = string.Empty;
            string stringPart = string.Empty;
            string paramPart = string.Empty;
            Hashtable dispTextfiller;
            Hashtable URLFiller;
            string[] splitter = { "~~" };

            Tasks_DAL tasksDal = new Tasks_DAL(globalContextDetails);

            try
            {

                foreach (Tasks tsk in lstTasks)
                {
                    dispTextfiller = tsk.DispTextFiller;
                    URLFiller = tsk.URLFiller;

                    //Get the Display text and Redirect URL templates
                    GetTaskDispTextAndURL(tsk.TaskActionID, out  dispText, out redirectURL);

                    foreach (string key in URLFiller.Keys)
                    {
                        if (redirectURL.Contains("{" + key + "}"))
                        {
                            redirectURL = redirectURL.Replace("{" + key + "}", URLFiller[key].ToString());
                        }
                    }
                    tsk.RedirectURL = redirectURL;

                    foreach (string key in dispTextfiller.Keys)
                    {
                        if (dispText.Contains("{" + key + "}"))
                        {
                            dispText = dispText.Replace("{" + key + "}", dispTextfiller[key].ToString());
                        }
                    }
                    tsk.TaskDescription = dispText;
                }

                returnCode = tasksDal.CreateGroupTask(lstTasks, out taskID);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing CreateGroupTask", excp);
            }

            return returnCode;
        }

        #endregion

        #region TaskUpdation

        public long UpdateTask(long taskID, TaskHelper.TaskStatus updateStatus, long userID, out byte isGroupTaskComplete)
        {
            long returnCode = -1;
            isGroupTaskComplete = 0;

            try
            {

                Tasks_DAL tasksDal = new Tasks_DAL(globalContextDetails);
                returnCode = tasksDal.UpdateTask(taskID, updateStatus, userID, out isGroupTaskComplete);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing UpdateTask", excp);
            }

            return returnCode;
        }

        public bool isTaskAlreadyPicked(long taskID, TaskHelper.TaskStatus updateStatus, TaskHelper.TaskStatus updateInprogresTask, long userID)
        {
            long returnCode = -1;
            string isAlreadyPicked = "Y";
            bool blnReturn = false;

            try
            {

                Tasks_DAL tasksDal = new Tasks_DAL(globalContextDetails);
                returnCode = tasksDal.UpdatePendingToInProgress(taskID, Convert.ToInt32(updateStatus), Convert.ToInt32(updateInprogresTask), userID, out isAlreadyPicked);

                if (returnCode == 0 && isAlreadyPicked == "Y")
                    blnReturn = true;
                else
                    blnReturn = false;
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing isTaskAlreadyPicked BL", excp);
            }

            return blnReturn;
        }

        public bool isExpired(long taskID)
        {
            long returnCode = -1;
            string isExpired;
            bool blnReturn = false;
            try
            {
                Tasks_DAL tasksDal = new Tasks_DAL(globalContextDetails);
                returnCode = tasksDal.isExpired(taskID, out isExpired);

                if (returnCode == 0 && isExpired == "Y")
                    blnReturn = true;
                else
                    blnReturn = false;
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing isExpired BL", excp);
            }

            return blnReturn;
        }

        public long UpdateTask(long taskID, TaskHelper.TaskStatus updateStatus, long userID)
        {
            long returnCode = -1;

            try
            {

                byte isGroupTaskComplete = 0;
                Tasks_DAL tasksDal = new Tasks_DAL(globalContextDetails);
                returnCode = tasksDal.UpdateTask(taskID, updateStatus, userID, out isGroupTaskComplete);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing UpdateTask BL", excp);
            }

            return returnCode;
        }

        public long pDeleteTaskForGivenTaskAction(int TaskActionID, int OrgID, List<Tasks> lstTasks, Int64 ModifiedBy)
        {
            long returnCode = -1;

            try
            {
                returnCode = new Tasks_DAL(globalContextDetails).DeleteTaskForGivenTaskAction(TaskActionID, OrgID, lstTasks, ModifiedBy);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Tasks BL pDeleteTaskForGivenTaskAction", ex);
            }
            return returnCode;
        }

        #endregion

        #region Transactional Tasks

        public long UpdateAndCreateTask(Tasks InsertTask, Tasks UpdateTask, out long taskID)
        {
            long returnCode = -1;
            taskID = -1;
            string dispText = string.Empty;
            string redirectURL = string.Empty;


            Hashtable dispTextfiller = InsertTask.DispTextFiller;
            Hashtable URLFiller = InsertTask.URLFiller;

            try
            {

                //Get the Display Text and Redirect URL Templates
                GetTaskDispTextAndURL(InsertTask.TaskActionID, out  dispText, out redirectURL);

                foreach (string key in URLFiller.Keys)
                {
                    if (redirectURL.Contains("{" + key + "}"))
                    {
                        redirectURL = redirectURL.Replace("{" + key + "}", URLFiller[key].ToString());
                    }
                }


                foreach (string key in dispTextfiller.Keys)
                {
                    if (dispText.Contains("{" + key + "}"))
                    {
                        dispText = dispText.Replace("{" + key + "}", dispTextfiller[key].ToString());
                    }
                }
                InsertTask.RedirectURL = redirectURL;
                InsertTask.TaskDescription = dispText;


                Tasks_DAL tasksDal = new Tasks_DAL(globalContextDetails);
                returnCode = tasksDal.UpdateAndCreateTask(InsertTask, UpdateTask, out taskID);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing UpdateAndCreateTask BL", excp);
            }

            return returnCode;
        }

        public long UpdateAndCreateGroupTask(List<Tasks> InsertTasks, Tasks UpdateTask, out long taskID)
        {
            long returnCode = -1;
            taskID = -1;
            string dispText = string.Empty;
            string redirectURL = string.Empty;
            string stringPart = string.Empty;
            string paramPart = string.Empty;
            Hashtable dispTextfiller;
            Hashtable URLFiller;
            string[] splitter = { "~~" };

            try
            {

                foreach (Tasks tsk in InsertTasks)
                {
                    dispTextfiller = tsk.DispTextFiller;
                    URLFiller = tsk.URLFiller;

                    //Get the Display Text and RedirectURL Templates
                    GetTaskDispTextAndURL(tsk.TaskActionID, out  dispText, out redirectURL);

                    //Form Display Text
                    if (dispText.IndexOf("~~") > 0 && dispTextfiller != null && dispTextfiller.Count > 0)
                    {
                        stringPart = dispText.Split(splitter, StringSplitOptions.None)[0];
                        paramPart = dispText.Split(splitter, StringSplitOptions.None)[1];

                        foreach (string str in paramPart.Split(','))
                        {
                            if (stringPart.Contains(str) && dispTextfiller.Contains(str))
                                stringPart = stringPart.Replace("{" + str + "}", dispTextfiller[str].ToString());
                            else
                                stringPart = "Information incomplete.Pl. contact admin";
                        }
                        dispText = stringPart;
                    }
                    tsk.TaskDescription = dispText;

                    //Form Redirect URL
                    if (redirectURL.IndexOf("~~") > 0 && URLFiller != null && URLFiller.Count > 0)
                    {
                        stringPart = redirectURL.Split(splitter, StringSplitOptions.None)[0];
                        paramPart = redirectURL.Split(splitter, StringSplitOptions.None)[1];

                        foreach (string str in paramPart.Split(','))
                        {
                            if (stringPart.Contains(str) && URLFiller.Contains(str))
                                stringPart = stringPart.Replace("{" + str + "}", URLFiller[str].ToString());
                            else
                            {
                                if (stringPart.Contains("?"))
                                    stringPart = stringPart.Remove(stringPart.IndexOf("?"), stringPart.Length);
                            }
                        }
                        redirectURL = stringPart;
                    }
                    tsk.RedirectURL = redirectURL;
                }

                Tasks_DAL tasksDal = new Tasks_DAL(globalContextDetails);
                returnCode = tasksDal.UpdateAndCreateGroupTask(InsertTasks, UpdateTask, out taskID);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing UpdateAndCreateGroupTask BL", excp);
            }

            return returnCode;
        }

        #endregion

        #region Task Escalation

        public long getTaskEscalation(long orgID, long roleID, long StartIndex, long EndIndex, out long TotalCount, out List<TaskEscalation> lstTaskEscalation)
        {

            long returnCode = -1;
            lstTaskEscalation = new List<TaskEscalation>();
            Tasks_DAL taskDAL = new Tasks_DAL(globalContextDetails);
            returnCode = taskDAL.getTaskEscalation(orgID, roleID, StartIndex, EndIndex, out TotalCount, out lstTaskEscalation);

            return returnCode;
        }

        #endregion


        public long GetCheckCollectionTaskStatus(long patientVisitID, out int status)
        {
            return new Tasks_DAL(globalContextDetails).GetCheckCollectionTaskStaus(patientVisitID, out status);
        }

        public long InsertDefault(TaskProfile taskProfile)
        {
            long returnCode = -1;


            try
            {
                Tasks_DAL tasksDal = new Tasks_DAL(globalContextDetails);
                returnCode = tasksDal.InsertDefault(taskProfile);
                return returnCode;
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in create task BL Message: ", ex);
                return returnCode;
            }

        }
        public long UpdateTaskPickedBy(long TaskID, long PatientVisitID, long LID)
        {
            long returnCode = -1;
            Tasks_DAL tasksDAL = new Tasks_DAL(globalContextDetails);
            try
            {
                returnCode = tasksDAL.UpdateTaskPickedBy(TaskID, PatientVisitID, LID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateTaskPickedBy in Tasks_BL.", ex);
            }
            return returnCode;
        }

        #region Task Re Assign

        public long GetTasktobeReAssign(string pName, int pOrgID, long pRoleId, DateTime pTaskDate, DateTime pToDate, out List<Tasks> lstTasks)
        {
            long returnCode = -1;
            lstTasks = new List<Tasks>();

            try
            {
                returnCode = new Tasks_DAL(globalContextDetails).GetTasktobeReAssign(pName, pOrgID, pRoleId, pTaskDate, pToDate, out lstTasks);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetTasktobeReAssign", ex);
            }

            return returnCode;
        }

        public long ReAssiginingTask(int pSpecialityID, long pAssignedLoginID, long pLID, int pTaskStatusID, List<Tasks> lstRATasks, Tasks tasks, out long taskID, out long billDetailID)
        {
            long returnCode = -1;
            taskID = -1;
            string dispText = string.Empty;
            string redirectURL = string.Empty;
            billDetailID = -1;
            try
            {
                Hashtable dispTextfiller = tasks.DispTextFiller;
                Hashtable URLFiller = tasks.URLFiller;

                //Get the display text and redirect url templates
                GetTaskDispTextAndURL(tasks.TaskActionID, out  dispText, out redirectURL);

                foreach (string key in URLFiller.Keys)
                {
                    if (redirectURL.Contains("{" + key + "}"))
                    {
                        redirectURL = redirectURL.Replace("{" + key + "}", URLFiller[key].ToString());
                    }
                }


                foreach (string key in dispTextfiller.Keys)
                {
                    if (dispText.Contains("{" + key + "}"))
                    {
                        dispText = dispText.Replace("{" + key + "}", dispTextfiller[key].ToString());
                    }
                }
                tasks.RedirectURL = redirectURL;
                tasks.TaskDescription = dispText;


                returnCode = new Tasks_DAL(globalContextDetails).ReAssiginingTask(pSpecialityID, pAssignedLoginID, pLID, pTaskStatusID, lstRATasks, tasks, out taskID, out billDetailID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL ReAssiginingTask", ex);
            }

            return returnCode;
        }

        public long ReAssiginingTask(int pSpecialityID, long pAssignedLoginID, long pLID, int pTaskStatusID, List<Tasks> lstRATasks)
        {
            long returnCode = -1;

            try
            {


                returnCode = new Tasks_DAL(globalContextDetails).ReAssiginingTask(pSpecialityID, pAssignedLoginID, pLID, pTaskStatusID, lstRATasks);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL ReAssiginingTask", ex);
            }

            return returnCode;
        }

        public long CheckforPaymentTaskReAssigned(long assignedTo, long visitID, long billDetailsID, out decimal existingFee, out decimal newFee)
        {
            long returnCode = -1;
            existingFee = -1;
            newFee = -1;

            try
            {
                returnCode = new Tasks_DAL(globalContextDetails).CheckforPaymentTaskReAssigned(assignedTo, visitID, billDetailsID, out existingFee, out newFee);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL CheckforPaymentTaskReAssigned", ex);
            }

            return returnCode;
        }



        #endregion



        public long GetTaskActionDetail(long VisitID, long TaskID, out int SpecialityID, out string TaskActionName, out int TaskActionID)
        {
            long returnCode = -1;
            SpecialityID = -2;
            TaskActionID = -1;
            TaskActionName = string.Empty;

            try
            {
                Tasks_DAL tasksDal = new Tasks_DAL(globalContextDetails);
                returnCode = tasksDal.GetTaskActionDetail(VisitID, TaskID, out SpecialityID, out TaskActionName, out TaskActionID);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetTaskActionDetail BL", excp);
            }

            return returnCode;
        }
        public long CreateTaskAllowDuplicate(Tasks tasks, out long taskID)
        {
            long returnCode = -1;
            taskID = -1;
            string dispText = string.Empty;
            string redirectURL = string.Empty;
            try
            {
                Hashtable dispTextfiller = tasks.DispTextFiller;
                Hashtable URLFiller = tasks.URLFiller;

                //Get the display text and redirect url templates
                GetTaskDispTextAndURL(tasks.TaskActionID, out  dispText, out redirectURL);

                foreach (string key in URLFiller.Keys)
                {
                    if (redirectURL.Contains("{" + key + "}"))
                    {
                        redirectURL = redirectURL.Replace("{" + key + "}", URLFiller[key].ToString());
                    }
                }


                foreach (string key in dispTextfiller.Keys)
                {
                    if (dispText.Contains("{" + key + "}"))
                    {
                        dispText = dispText.Replace("{" + key + "}", dispTextfiller[key].ToString());
                    }
                }
                tasks.RedirectURL = redirectURL;
                tasks.TaskDescription = dispText;


                Tasks_DAL tasksDal = new Tasks_DAL(globalContextDetails);
                returnCode = tasksDal.CreateTaskAllowDuplicate(tasks, out taskID);
                return returnCode;
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in create task BL Message: ", ex);
                return returnCode;
            }

        }
        public long UpdateTaskForaVisit(long pVisitID, int OrgID, long LoginID, int ModifiedTaskID)
        {
            long returnCode = -1;
            try
            {
                returnCode = new Tasks_DAL(globalContextDetails).UpdateTaskForaVisit(pVisitID, OrgID, LoginID, ModifiedTaskID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in UpdateTaskForaVisit method in TASK_BL", ex);
            }
            return returnCode;
        }

        public long CreatePharmacyTask(Tasks tasks, out long taskID, int LocationID)
        {
            long returnCode = -1;
            taskID = -1;
            string dispText = string.Empty;
            string redirectURL = string.Empty;
            try
            {
                Hashtable dispTextfiller = tasks.DispTextFiller;
                Hashtable URLFiller = tasks.URLFiller;

                //Get the display text and redirect url templates
                GetTaskDispTextAndURL(tasks.TaskActionID, out  dispText, out redirectURL);

                foreach (string key in URLFiller.Keys)
                {
                    if (redirectURL.Contains("{" + key + "}"))
                    {
                        redirectURL = redirectURL.Replace("{" + key + "}", URLFiller[key].ToString());
                    }
                }


                foreach (string key in dispTextfiller.Keys)
                {
                    if (dispText.Contains("{" + key + "}"))
                    {
                        dispText = dispText.Replace("{" + key + "}", dispTextfiller[key].ToString());
                    }
                }
                tasks.RedirectURL = redirectURL;
                tasks.TaskDescription = dispText;


                Tasks_DAL tasksDal = new Tasks_DAL(globalContextDetails);
                returnCode = tasksDal.CreatePharmacyTask(tasks, out taskID, LocationID);
                return returnCode;
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in create task BL Message: ", ex);
                return returnCode;
            }

        }
        public long GetTaskID(long TaskID, out List<Tasks> lstTasks)
        {
            long returnCode = -1;
            lstTasks = new List<Tasks>();
            try
            {
                returnCode = new Tasks_DAL(globalContextDetails).GetTaskID(TaskID, out lstTasks);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetTaskID method in TASK_BL", ex);
            }
            return returnCode;
        }
        public long UpdateCurrentTask(long taskID, TaskHelper.TaskStatus updateStatus, long userID, string Remarks)
        {
            long returnCode = -1;

            try
            {


                Tasks_DAL tasksDal = new Tasks_DAL(globalContextDetails);
                returnCode = tasksDal.UpdateCurrentTask(taskID, updateStatus, userID, Remarks);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing UpdateCurrentTask BL", excp);
            }

            return returnCode;
        }

        public long GetTestForApprovel(int RoleID, int OrgID, long UID, string TaskDate, string category, long orgAddrId, int specId, string PatientNumber,
     out List<TaskDetails> lstTasks, int InvLocationID, int startRowIndex, int pageSize, out int totalRows, int DeptID,long ClientId, LoginDetail LDetail, List<TrustedOrgActions> lstTrustedOrgAction, string Preference)
        {
            long returnCode = -1;
            lstTasks = null;
            totalRows = -1;

            try
            {


                Tasks_DAL tasksDal = new Tasks_DAL(globalContextDetails);
                returnCode = tasksDal.GetTestForApprovel(RoleID, OrgID, UID, TaskDate, category, orgAddrId, specId, PatientNumber, out lstTasks, InvLocationID, startRowIndex, pageSize, out totalRows, DeptID,ClientId, LDetail, lstTrustedOrgAction, Preference);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetTasks BL", excp);
            }


            return returnCode;
        }
        public long GetTestForApprovel(int RoleID, int OrgID, long UID, string TaskDate, string category, long orgAddrId, int specId, string PatientNumber,
     out List<TaskDetails> lstTasks, int InvLocationID, int startRowIndex, int pageSize, out int totalRows, int DeptID, long ClientId, LoginDetail LDetail, List<TrustedOrgActions> lstTrustedOrgAction, string Preference,
           long patientID, long visitID, long tID)
        {
            long returnCode = -1;
            lstTasks = null;
            totalRows = -1;

            try
            {


                Tasks_DAL tasksDal = new Tasks_DAL(globalContextDetails);
                returnCode = tasksDal.GetTestForApprovel(RoleID, OrgID, UID, TaskDate, category, orgAddrId, specId, PatientNumber, out lstTasks,
                    InvLocationID, startRowIndex, pageSize, out totalRows, DeptID, ClientId, LDetail, lstTrustedOrgAction, Preference,
                    patientID, visitID, tID);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetTasks BL", excp);
            }


            return returnCode;
        }

        public long GetAllTasksStat(int RoleID, int OrgID, long UID, string TaskDate, string category, long orgAddrId, int specId, string PatientNumber,
       out List<TaskDetails> lstTasks, int InvLocationID, int startRowIndex, int pageSize, out int totalRows, int DeptID, long ClientID, string allocated, LoginDetail LDetail, List<TrustedOrgActions> lstTrustedOrgAction, string Preference, long ProtocalGroupID, string BarcodeNumber, int VisitType)
        {
            long returnCode = -1;
            lstTasks = null;
            totalRows = -1;

            try
            {


                Tasks_DAL tasksDal = new Tasks_DAL(globalContextDetails);
                returnCode = tasksDal.GetAllTasksStat(RoleID, OrgID, UID, TaskDate, category, orgAddrId, specId, PatientNumber, out lstTasks, InvLocationID, startRowIndex, pageSize, out totalRows, DeptID,ClientID,allocated ,LDetail, lstTrustedOrgAction, Preference,ProtocalGroupID,BarcodeNumber,VisitType);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetTasks BL", excp);
            }


            return returnCode;
        }
        public long GetTaskByVisit(long pVisitID, int pOrgID, int pTaskActionID, out List<Tasks> lstTasks)
        {
            long returnCode = -1;
            lstTasks = new List<Tasks>();
            try
            {
                Tasks_DAL tasksDal = new Tasks_DAL(globalContextDetails);
                returnCode = tasksDal.GetTaskByVisit(pVisitID, pOrgID, pTaskActionID, out lstTasks);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting task By visit", ex);
            }
            return returnCode;
        }
        public long GetAllTasksStatForSavendNext(int RoleID, int OrgID, long UID, string TaskDate, string category, long orgAddrId, int specId, string PatientNumber,
    out List<TaskDetails> lstTasks, int InvLocationID, int startRowIndex, int pageSize, out int totalRows, int DeptID, LoginDetail LDetail, List<TrustedOrgActions> lstTrustedOrgAction, string Preference)
        {
            long returnCode = -1;
            lstTasks = null;
            totalRows = -1;

            try
            {


                Tasks_DAL tasksDal = new Tasks_DAL(globalContextDetails);
                returnCode = tasksDal.GetAllTasksStatForSavendNext(RoleID, OrgID, UID, TaskDate, category, orgAddrId, specId, PatientNumber, out lstTasks, InvLocationID, startRowIndex, pageSize, out totalRows, DeptID, LDetail, lstTrustedOrgAction, Preference);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetTasks BL", excp);
            }


            return returnCode;
        }
        #region Set Defult Search
        public long InsertTaskDefault(List<TaskDefaultSearch> lstTaskDefaultSearch)
        {
            long returnCode = -1;


            try
            {
                Tasks_DAL tasksDal = new Tasks_DAL(globalContextDetails);
                returnCode = tasksDal.InsertTaskDefault(lstTaskDefaultSearch);
                return returnCode;
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in create task BL Message: ", ex);
                return returnCode;
            }

        }
        public long GetDefaultTaskFilter(int OrgID, long RoleID, long LoginID, out List<TaskDefaultSearch> lsttaskProfile)
        {
            long returnCode = -1;
            lsttaskProfile = new List<TaskDefaultSearch>();
            try
            {

                Tasks_DAL tasksDal = new Tasks_DAL(globalContextDetails);
                returnCode = tasksDal.GetDefaultTaskFilter(OrgID, RoleID, LoginID, out lsttaskProfile);
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing GetTasks BL", excp);
            }

            return returnCode;
        }
        #endregion


    }
}
