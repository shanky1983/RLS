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
namespace Attune.Solution.DAL
{
    public class Tasks_DAL
    {
        ContextDetails globalContextDetails;
        public Tasks_DAL()
        {

        }
        public Tasks_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        #region Task Retrieval

        public long GetTasks(int RoleID, int OrgID, long UID, out List<Tasks> lstTasks, int LocationID, int startRowIndex, int pageSize, out int totalRows)
        {
            IDataReader dataReader = null;
            totalRows = 0;
            long returnCode = -1;
            lstTasks = new List<Tasks>();
            try
            {
                SqlCommand cmd = Command.pGetTasksCommand(RoleID, OrgID, UID, LocationID, startRowIndex, pageSize, out totalRows, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstTasks);
                        dataReader.Close();
                        totalRows = Convert.ToInt32(cmd.Parameters["@totalRows"].Value);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetTasks", ex);
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

        public long GetTasks(int RoleID, int OrgID, long UID, out List<TaskDetails> lstTasks, int LocationID, int startRowIndex, int pageSize, out int totalRows)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstTasks = new List<TaskDetails>();
            totalRows = 0;
            try
            {
                SqlCommand cmd = Command.pGetTasksCommand(RoleID, OrgID, UID, LocationID, startRowIndex, pageSize, out totalRows, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
             
                using (DBEngine dbEngine = new DBEngine())
                {
                     dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstTasks);
                        dataReader.Close();
                    }
                }
                Int32.TryParse(cmd.Parameters["@totalRows"].Value.ToString(), out totalRows);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetPerformingAction", ex);
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

        public long GetTasks(int RoleID, int OrgID, long UID, DateTime TaskDate, out List<Tasks> lstTasks)
        {
            long returnCode = -1;

            SqlCommand cmd = Command.pGetTasksByDateCommand(RoleID, OrgID, TaskDate, UID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstTasks = new List<Tasks>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }


            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstTasks);
            }

            return returnCode;

        }

        public long GetTasks(int RoleID, int OrgID, long UID, string category, out List<Tasks> lstTasks)
        {
            long returnCode = -1;

            SqlCommand cmd = Command.pGetTasksByCategoryCommand(RoleID, OrgID, category, UID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstTasks = new List<Tasks>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }


            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstTasks);
            }

            return returnCode;

        }

        public long GetTasks(int RoleID, int OrgID, long UID, DateTime TaskDate, string category, out List<Tasks> lstTasks)
        {
            long returnCode = -1;

            SqlCommand cmd = Command.pGetTasksByCategoryAndDateCommand(RoleID, OrgID, TaskDate, category, UID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstTasks = new List<Tasks>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }


            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstTasks);
            }

            return returnCode;

        }

        public long GetTaskDispTextAndURL(int taskActionID, out string dispText, out string redirectURL)
        {
            long returnCode = -1;

            dispText = "";
            redirectURL = "";

            SqlCommand cmd = Command.pGetTaskDispTextAndURLCommand(taskActionID, out dispText, out redirectURL, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
            }

            if (returnCode == 0)
            {
                dispText = cmd.Parameters["@pTaskDescription"].Value.ToString();
                redirectURL = cmd.Parameters["@pRedirectURL"].Value.ToString();
            }

            return returnCode;
        }


        public long GetTaskLocationAndSpeciality(int OrgID, long RoleID, long LoginID,string Type, out List<OrganizationAddress> lstLocation, out List<Speciality> lstSpeciality, out List<TaskActions> lstCategory, out TaskProfile taskProfile, out List<InvDeptMaster> lstDept,out List<ClientMaster> lstClient,out List<MetaData> lstProtocal)
        {
            long returnCode = -1;
            lstLocation = new List<OrganizationAddress>();
            lstSpeciality = new List<Speciality>();
            lstCategory = new List<TaskActions>();
            taskProfile = new TaskProfile();
            lstDept = new List<InvDeptMaster>();
            lstClient = new List<ClientMaster>();
            lstProtocal = new List<MetaData>();
            List<TaskProfile> lsttaskProfile = new List<TaskProfile>();
            int rsCount = 0;
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetTasksFilterCommand(OrgID, RoleID, LoginID, Type, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstLocation);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstSpeciality);
                            }
                            else if (rsCount == 2)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstCategory);
                            }
                            else if (rsCount == 3)
                            {

                                returnCode = Utilities.ConvertTo(dataReader, out lsttaskProfile);
                                foreach (TaskProfile TP in lsttaskProfile)
                                {
                                    taskProfile.LoginID = TP.LoginID;
                                    taskProfile.OrgAddressID = TP.OrgAddressID;
                                    taskProfile.Location = TP.Location;
                                    taskProfile.SpecialityID = TP.SpecialityID;
                                    taskProfile.SpecialityName = TP.SpecialityName;
                                    taskProfile.Category = TP.Category;
                                    taskProfile.TaskDate = TP.TaskDate;
                                    taskProfile.DeptID = TP.DeptID;
                                    taskProfile.DeptName = TP.DeptName;
                                    break;
                                }
                            }
                            else if (rsCount == 4)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstDept);
                            }
                            else if (rsCount == 5)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstClient);
                            }
                            else if (rsCount == 6)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstProtocal);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetTaskLocationAndSpeciality", ex);
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

        private TaskProfile ConverttoEntity(DataTable dt)
        {
            TaskProfile obj = new TaskProfile();
            try
            {
                DataRow dr = dt.Rows[0];
                obj.LoginID = Convert.ToInt64(dr["LoginID"]);
                obj.OrgAddressID = Convert.ToInt64(dr["OrgAddressID"]);
                obj.Location = Convert.ToString(dr["Location"]);
                obj.SpecialityID = Convert.ToInt32(dr["SpecialityID"]);
                obj.SpecialityName = Convert.ToString(dr["SpecialityName"]);
                obj.Category = Convert.ToString(dr["Category"]);
                obj.TaskDate = Convert.ToString(dr["TaskDate"]);
                obj.DeptID = Convert.ToInt32(dr["DeptID"]);
                obj.DeptName = Convert.ToString(dr["DeptName"]);

            }

            catch (Exception ex)
            {
                CLogger.LogError("Error in converttoentiy DAL", ex);
            }
            return obj;
        }

        public long GetAllTasks(int RoleID, int OrgID, long UID, string TaskDate, string category, long orgAddrId, int specId,
              string PatientNumber, out List<TaskDetails> lstTasks, int InvLocationID, int startRowIndex, int pageSize, out int totalRows, int DeptID, long ClientID, LoginDetail LDetail, List<TrustedOrgActions> lstTrustedOrgAction, string Preference, long ProtocalGroupID, int VisitType)
        {
            long returnCode = -1;
            totalRows = -1;

            lstTasks = new List<TaskDetails>();
            IDataReader dataReader = null;
            DataTable DtLDetail = UDT_DAL.ConvertToLoginDetail(LDetail);
            DataTable DtTrustedOrgAction = UDT_DAL.ConvertToTrustedOrgActions(lstTrustedOrgAction);
            try
            {
                SqlCommand cmd = Command.pGetTaskDetailsLisCommand(Convert.ToInt64(RoleID), OrgID, UID, category, orgAddrId, specId, DeptID, ClientID, TaskDate, PatientNumber, "", InvLocationID, startRowIndex, pageSize, out totalRows, DtLDetail, DtTrustedOrgAction, Preference, ProtocalGroupID,VisitType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));


                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstTasks);
                        dataReader.Close();

                    }
                    totalRows = Convert.ToInt32(cmd.Parameters["@totalRows"].Value);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing GetAllTasks in Task_DAL", excep);
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

        public long GetAllTaskActions(out List<TaskActions> lstAllTaskActions, Int32 OrgID)
        {
            long returnCode = -1;

            SqlCommand cmd = Command.pGetAllTaskActionsCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstAllTaskActions = new List<TaskActions>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }


            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstAllTaskActions);
            }

            return returnCode;

        }

        public long GetTasksForGivenStatus(string FromDt, string ToDt, int TaskActionID, int OrgID, out List<Tasks> lstTasks)
        {
            long returnCode = -1;

            SqlCommand cmd = Command.pGetTasksForGivenStatusCommand(FromDt, ToDt, TaskActionID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstTasks = new List<Tasks>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }


            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstTasks);
            }

            return returnCode;

        }

        #endregion

        #region TaskCreation

        public long CreateTask(Tasks task, out long taskID)
        {
            long returnCode = -1;
            taskID = -1;
            SqlCommand cmd = Command.pInsertTaskCommand(task.TaskActionID, task.TaskDescription, task.RedirectURL, task.PatientID,
                                    task.AssignedTo, task.OrgID, task.ParentID, task.PatientVisitID,
                                                                task.HighlightColor, task.CreatedBy, task.SpecialityID, out taskID, task.LocationID, task.RefernceID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                taskID = Convert.ToInt64(cmd.Parameters["@pTaskID"].Value);
            }

            return returnCode;
        }

        public long CreateGroupTask(List<Tasks> lstTasks, out long taskID)
        {
            long returnCode = -1;
            taskID = -1;
            List<SqlCommand> cmds = new List<SqlCommand>();

            foreach (Tasks task in lstTasks)
            {
                SqlCommand cmd = Command.pInsertTaskCommand(task.TaskActionID, task.TaskDescription, task.RedirectURL,
                                    task.PatientID, task.AssignedTo, task.OrgID, task.ParentID,
                                                                task.PatientVisitID, task.HighlightColor, task.CreatedBy, task.SpecialityID, out taskID, task.LocationID, task.RefernceID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                cmd.Parameters.Add("@Return", SqlDbType.Int);
                cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
                cmds.Add(cmd);
            }

            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        for (int i = 0; i < cmds.Count; i++)
                        {
                            returnCode = -1;
                            dbEngine.ExecuteTransactionalNonQuery(cmds[i]);
                            returnCode = Convert.ToInt64(cmds[i].Parameters["@Return"].Value);
                        }
                    }
                    tranScope.Complete();
                }
                catch (Exception ex)
                {
                    tranScope.Dispose();
                    CLogger.LogError("Error while executing CreateGroupTask", ex);
                }
            }

            return returnCode;
        }

        public long isExpired(long taskID, out string isExpired)
        {
            long returnCode = -1;

            SqlCommand cmd = Command.pIsExpiredCommand(taskID, out isExpired, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);

                if (returnCode == 0)
                    isExpired = Convert.ToString(cmd.Parameters["@pIsExpired"].Value);
            }

            return returnCode;
        }



        public long DeleteTaskForGivenTaskAction(int TaskActionID, int OrgID, List<Tasks> lstTasks, Int64 ModifiedBy)
        {
            long returnCode = -1;
            DataTable pDeleteTaskTable = UDT_DAL.ConvertToUDTReAssignedTask(lstTasks);

            try
            {
                SqlCommand cmd = Command.pDeleteTasksForGivenActionCommand(TaskActionID, OrgID, pDeleteTaskTable, ModifiedBy, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                cmd.Parameters.Add("@Return", SqlDbType.Int);
                cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing DeleteTaskForGivenTaskAction in Tasks_DAL", ex);
            }
            return returnCode;
        }

        #endregion

        #region TaskUpdation

        public long UpdateTask(long taskID, TaskHelper.TaskStatus updateStatus, long userID, out byte isGroupTaskComplete)
        {
            long returnCode = -1;

            SqlCommand cmd = Command.pUpdateTaskCommand(taskID, Convert.ToInt32(updateStatus), userID, out isGroupTaskComplete, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);

                if (returnCode == 0)
                    isGroupTaskComplete = Convert.ToByte(cmd.Parameters["@pIsGroupTaskCompleted"].Value);
            }

            return returnCode;
        }

        public long UpdatePendingToInProgress(long taskID, int taskStatusID, int inProgressStatusID, long userID, out string isAlreadyInProgress)
        {
            long returnCode = -1;

            SqlCommand cmd = Command.pUpdatePendingToInProgressTaskLisCommand(taskID, taskStatusID, inProgressStatusID, userID, out isAlreadyInProgress, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);

                if (returnCode == 0)
                    isAlreadyInProgress = Convert.ToString(cmd.Parameters["@pIsAlreadyInProgress"].Value);
            }

            return returnCode;
        }

        #endregion

        #region Transactional Tasks

        public long UpdateAndCreateTask(Tasks InsertTask, Tasks UpdateTask, out long taskID)
        {
            long lResult = -1;

            byte isGroupTaskComplete = 0;

            SqlCommand Updatecmd = Command.pUpdateTaskCommand(UpdateTask.TaskID, UpdateTask.TaskStatusID, UpdateTask.ModifiedBy, out isGroupTaskComplete, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            Updatecmd.Parameters.Add("@Return", SqlDbType.Int);
            Updatecmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            SqlCommand Insertcmd = Command.pInsertTaskCommand(InsertTask.TaskActionID, InsertTask.TaskDescription, InsertTask.RedirectURL, InsertTask.PatientID,
                                    InsertTask.AssignedTo, InsertTask.OrgID, InsertTask.ParentID, InsertTask.PatientVisitID,
                                                        InsertTask.HighlightColor, InsertTask.CreatedBy, InsertTask.SpecialityID, out taskID, InsertTask.LocationID, InsertTask.RefernceID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            Insertcmd.Parameters.Add("@Return", SqlDbType.Int);
            Insertcmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteTransactionalNonQuery(Updatecmd);
                        lResult = Convert.ToInt64(Updatecmd.Parameters["@Return"].Value);

                        if (lResult == 0)
                        {
                            isGroupTaskComplete = Convert.ToByte(Updatecmd.Parameters["@pIsGroupTaskCompleted"].Value);

                            if (isGroupTaskComplete == 1)
                            {
                                lResult = -1;
                                dbEngine.ExecuteTransactionalNonQuery(Insertcmd);
                                lResult = Convert.ToInt64(Insertcmd.Parameters["@Return"].Value);
                            }
                        }
                    }
                    tranScope.Complete();
                }

                catch (Exception ex)
                {
                    tranScope.Dispose();
                    CLogger.LogError("Error while executing UpdateAndCreateTask method", ex);
                }
            }

            return lResult;
        }

        public long UpdateAndCreateGroupTask(List<Tasks> InsertTasks, Tasks UpdateTask, out long taskID)
        {
            long lResult = -1;
            byte isGroupTaskComplete = 0;
            taskID = -1;
            SqlCommand Updatecmd = Command.pUpdateTaskCommand(UpdateTask.TaskID, UpdateTask.TaskStatusID, UpdateTask.ModifiedBy, out isGroupTaskComplete, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            Updatecmd.Parameters.Add("@Return", SqlDbType.Int);
            Updatecmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteTransactionalNonQuery(Updatecmd);
                        lResult = Convert.ToInt64(Updatecmd.Parameters["@Return"].Value);

                        if (lResult == 0)
                        {
                            isGroupTaskComplete = Convert.ToByte(Updatecmd.Parameters["@pIsGroupTaskCompleted"].Value);

                            if (isGroupTaskComplete == 1)
                            {
                                List<SqlCommand> cmds = new List<SqlCommand>();

                                foreach (Tasks task in InsertTasks)
                                {
                                    SqlCommand cmd = Command.pInsertTaskCommand(task.TaskActionID, task.TaskDescription, task.RedirectURL, task.PatientID,
                                    task.AssignedTo, task.OrgID, task.ParentID, task.PatientVisitID,
                                                                                    task.HighlightColor, task.CreatedBy, task.SpecialityID, out taskID, task.LocationID, task.RefernceID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                                    cmd.Parameters.Add("@Return", SqlDbType.Int);
                                    cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
                                    cmds.Add(cmd);
                                }

                                for (int i = 0; i < cmds.Count; i++)
                                {
                                    lResult = -1;
                                    dbEngine.ExecuteTransactionalNonQuery(cmds[i]);
                                    lResult = Convert.ToInt64(cmds[i].Parameters["@Return"].Value);
                                }
                            }
                        }
                    }
                    tranScope.Complete();
                }

                catch (Exception ex)
                {
                    tranScope.Dispose();
                    CLogger.LogError("Error while executing UpdateAndCreateGroupTask", ex);
                }
            }

            return lResult;
        }
        #endregion

        #region Task Escalation

        public long getTaskEscalation(long orgID, long roleID, long StartIndex, long EndIndex, out long TotalCount, out List<TaskEscalation> lstTaskEscalation)
        {
            long returnCode = -1;
            TotalCount = -1;
            lstTaskEscalation = new List<TaskEscalation>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetTaskEscalationDetailCommand(Convert.ToInt32(orgID), roleID, StartIndex, EndIndex, out TotalCount, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstTaskEscalation);
                        dataReader.Close();
                    }
                    TotalCount = Convert.ToInt64(cmd.Parameters["@pTotalCount"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing getTaskEscalation Task_DAL", e);
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

        public long GetCheckCollectionTaskStaus(long patientVisitID, out int status)
        {
            long returnCode = -1;

            SqlCommand cmd = Command.pGetChekcCollectionTaskCommand(patientVisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine(false))
            {
                returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                status = Convert.ToInt32(ds.Tables[0].Rows[0]["CountValue"]);
            }

            return returnCode;

        }

        public long InsertDefault(TaskProfile taskProfile)
        {
            long returnCode = -1;

            SqlCommand cmd = Command.pInsertSetDefaultCommand(taskProfile.LoginID, taskProfile.RoleID, Convert.ToInt32(taskProfile.OrgID), taskProfile.OrgAddressID, taskProfile.Location, taskProfile.SpecialityID, taskProfile.SpecialityName, taskProfile.Category, taskProfile.TaskDate, taskProfile.DeptID, taskProfile.DeptName, taskProfile.ClientID, taskProfile.ProtocalGroupId, taskProfile.Type,0,"",UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
            }

            return returnCode;
        }

        #endregion

        public long UpdateTaskPickedBy(long TaskID, long PatientVisitID, long LID)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pUpdateTaskPickedByCommand(TaskID, PatientVisitID, LID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateTaskPickedBy in Tasks_DAL", ex);
            }
            return returnCode;
        }

        #region Task Re Assign

        public long GetTasktobeReAssign(string pName, int pOrgID, long pRoleId, DateTime pTaskDate, DateTime pToDate, out List<Tasks> lstTasks)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstTasks = new List<Tasks>();
            try
            {
                SqlCommand cmd = Command.pGetTaskstoReAssignCommand(pName, pOrgID, pRoleId, pTaskDate, pToDate, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstTasks);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetTasktobeReAssign", ex);
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

        public long ReAssiginingTask(int pSpecialityID, long pAssignedLoginID, long pLID, int pTaskStatusID, List<Tasks> lstRATasks, Tasks task, out long taskID, out long billDetailsID)
        {
            long returnCode = -1;
            taskID = -1;
            billDetailsID = -1;
            try
            {
                DataTable dtRATasks = UDT_DAL.ConvertToUDTReAssignedTask(lstRATasks);
                SqlCommand cmdUpdateTask = Command.pUpdateReAssignedTaskCommand(pSpecialityID, pAssignedLoginID, pLID, pTaskStatusID, dtRATasks, out billDetailsID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                SqlCommand cmdInsertTask = Command.pInsertTaskCommand(task.TaskActionID, task.TaskDescription, task.RedirectURL, task.PatientID,
                                    task.AssignedTo, task.OrgID, task.ParentID, task.PatientVisitID,
                                                                task.HighlightColor, task.CreatedBy, task.SpecialityID, out taskID, task.LocationID, task.RefernceID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                cmdUpdateTask.Parameters.Add("@Return", SqlDbType.Int);
                cmdUpdateTask.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

                cmdInsertTask.Parameters.Add("@Return", SqlDbType.Int);
                cmdInsertTask.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

                using (TransactionScope tranScope = new TransactionScope())
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteTransactionalNonQuery(cmdUpdateTask);
                        returnCode = Convert.ToInt64(cmdUpdateTask.Parameters["@Return"].Value);
                        if (returnCode == 0)
                        {
                            dbEngine.ExecuteTransactionalNonQuery(cmdInsertTask);
                            returnCode = Convert.ToInt64(cmdInsertTask.Parameters["@Return"].Value);
                            if (returnCode == 0)
                            {
                                tranScope.Complete();
                                taskID = Convert.ToInt64(cmdInsertTask.Parameters["@pTaskID"].Value);
                                billDetailsID = Convert.ToInt64(cmdUpdateTask.Parameters["@pBillDetailsID"].Value);
                            }
                            else
                            {
                                tranScope.Dispose();
                            }
                        }
                        else
                        {
                            tranScope.Dispose();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL ReAssiginingTask", ex);
            }

            return returnCode;
        }

        public long ReAssiginingTask(int pSpecialityID, long pAssignedLoginID, long pLID, int pTaskStatusID, List<Tasks> lstRATasks)
        {
            long returnCode = -1;
            long billDetailsID = -1;
            try
            {
                DataTable dtRATasks = UDT_DAL.ConvertToUDTReAssignedTask(lstRATasks);
                SqlCommand cmdUpdateTask = Command.pUpdateReAssignedTaskCommand(pSpecialityID, pAssignedLoginID, pLID, pTaskStatusID, dtRATasks, out billDetailsID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmdUpdateTask);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL ReAssiginingTask", ex);
            }

            return returnCode;
        }

        public long CheckforPaymentTaskReAssigned(long assignedTo, long visitID, long billDetailsID, out decimal existingFee, out decimal newFee)
        {
            long returnCode = -1;
            existingFee = -1;
            newFee = -1;
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pCheckforPaymentTaskReAssignedCommand(assignedTo, visitID, billDetailsID, out existingFee, out newFee, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    existingFee = Convert.ToDecimal(cmd.Parameters["@pExistingFee"].Value);
                    newFee = Convert.ToDecimal(cmd.Parameters["@pNewFee"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL CheckforPaymentTaskReAssigned", ex);
            }

            return returnCode;
        }
        #endregion

        public long GetTaskActionDetail(long VisitID, long TaskID, out int SpecialityID, out string TaskActionName, out int TaskActionID)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetTaskActionDetailCommand(VisitID, TaskID, out SpecialityID, out TaskActionName, out TaskActionID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }


            SpecialityID = Convert.ToInt32(objCommand.Parameters["@pSpecialityID"].Value);
            TaskActionName = objCommand.Parameters["@pTaskActionName"].Value.ToString();
            TaskActionID = Convert.ToInt32(objCommand.Parameters["@pTaskActionID"].Value);

            return returnCode;
        }
        public long CreateTaskAllowDuplicate(Tasks task, out long taskID)
        {
            long returnCode = -1;
            taskID = -1;
            SqlCommand cmd = Command.pInsertTaskAllowDuplicateCommand(task.TaskActionID, task.TaskDescription, task.RedirectURL, task.PatientID,
                                    task.AssignedTo, task.OrgID, task.ParentID, task.PatientVisitID,
                                                                task.HighlightColor, task.CreatedBy, task.SpecialityID, task.RefernceID, task.Type, out taskID,task.IsStat, UDT_DAL.ConvertToUDT_Context(globalContextDetails));



            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
                taskID = Convert.ToInt64(cmd.Parameters["@pTaskID"].Value);
            }

            return returnCode;
        }

        public long UpdateTaskForaVisit(long pVisitID, int OrgID, long LoginID, int ModifiedTaskID)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pUpdateApprovedTaskForaVisitLisCommand(pVisitID, OrgID, LoginID, ModifiedTaskID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);

            }
            return returnCode;
        }

        public long CreatePharmacyTask(Tasks task, out long taskID, int LocationID)
        {
            long returnCode = -1;
            taskID = -1;
            SqlCommand cmd = Command.pInsertTaskCommand(task.TaskActionID, task.TaskDescription, task.RedirectURL, task.PatientID,
                                    task.AssignedTo, task.OrgID, task.ParentID, task.PatientVisitID,
                                                                task.HighlightColor, task.CreatedBy, task.SpecialityID, out taskID, task.LocationID, task.RefernceID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                taskID = Convert.ToInt64(cmd.Parameters["@pTaskID"].Value);
            }

            return returnCode;
        }
        public long UpdateCurrentTask(long taskID, TaskHelper.TaskStatus updateStatus, long userID, string Remarks)
        {
            long returnCode = -1;

            SqlCommand cmd = Command.pUpdateCurrentTaskCommand(taskID, Convert.ToInt32(updateStatus), userID, Remarks, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);

            }

            return returnCode;
        }
        public long GetTaskID(long TaskID, out List<Tasks> lstTasks)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstTasks = new List<Tasks>();
            try
            {
                SqlCommand cmd = Command.pGetTaskIDCommand(TaskID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstTasks);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetTaskID", ex);
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

        public long GetTestForApprovel(int RoleID, int OrgID, long UID, string TaskDate, string category, long orgAddrId, int specId,
           string PatientNumber, out List<TaskDetails> lstTasks, int InvLocationID, int startRowIndex, int pageSize, out int totalRows, int DeptID,long ClientId, LoginDetail LDetail, List<TrustedOrgActions> lstTrustedOrgAction, string Preference)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            totalRows = -1;
            DataTable DtLDetail = UDT_DAL.ConvertToLoginDetail(LDetail);
            DataTable DtTrustedOrgAction = UDT_DAL.ConvertToTrustedOrgActions(lstTrustedOrgAction);
            lstTasks = new List<TaskDetails>();
            try
            {
                SqlCommand cmd = Command.pGetTestForApprovelLisCommand(RoleID, OrgID, UID, category, orgAddrId, specId, DeptID, ClientId, TaskDate, PatientNumber, InvLocationID, startRowIndex, pageSize, out totalRows, DtLDetail, DtTrustedOrgAction, Preference, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstTasks);
                        dataReader.Close();
                    }
                }
                Int32.TryParse(cmd.Parameters["@totalRows"].Value.ToString(), out totalRows);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetTestForApprovel Task_dal", ex);
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
        public long GetTestForApprovel(int RoleID, int OrgID, long UID, string TaskDate, string category, long orgAddrId, int specId,
           string PatientNumber, out List<TaskDetails> lstTasks, int InvLocationID, int startRowIndex, int pageSize, out int totalRows, int DeptID, long ClientId, LoginDetail LDetail, List<TrustedOrgActions> lstTrustedOrgAction, string Preference,
            long patientID, long visitID, long tID)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            totalRows = -1;
            DataTable DtLDetail = UDT_DAL.ConvertToLoginDetail(LDetail);
            DataTable DtTrustedOrgAction = UDT_DAL.ConvertToTrustedOrgActions(lstTrustedOrgAction);
            lstTasks = new List<TaskDetails>();
            try
            {
                SqlCommand cmd = Command.pGetIsSensitiveResultTestCommand(RoleID, OrgID, UID, category, orgAddrId, specId, DeptID, ClientId, TaskDate, PatientNumber, InvLocationID, startRowIndex, pageSize, out totalRows, DtLDetail, DtTrustedOrgAction, Preference,
                    patientID, visitID, tID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstTasks);
                        dataReader.Close();
                    }
                }
                Int32.TryParse(cmd.Parameters["@totalRows"].Value.ToString(), out totalRows);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetTestForApprovel for IsSensitive Result Test", ex);
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
        public long GetAllTasksStat(int RoleID, int OrgID, long UID, string TaskDate, string category, long orgAddrId, int specId,
             string PatientNumber, out List<TaskDetails> lstTasks, int InvLocationID, int startRowIndex, int pageSize, out int totalRows, int DeptID, long ClientID,string allocated, LoginDetail LDetail, List<TrustedOrgActions> lstTrustedOrgAction, string Preference, long ProtocalGroupID, string BarcodeNumber, int VisitType)
        {
            long returnCode = -1;
            IDataReader dataReader = null;
            totalRows = -1;
            lstTasks = new List<TaskDetails>();
            try
            {
                DataTable DtLDetail = UDT_DAL.ConvertToLoginDetail(LDetail);
                DataTable DtTrustedOrgAction = UDT_DAL.ConvertToTrustedOrgActions(lstTrustedOrgAction);
                SqlCommand cmd = Command.pGetTaskStatDetailsCommand(RoleID, OrgID, UID, category, orgAddrId, specId, DeptID, ClientID,allocated, TaskDate, PatientNumber, InvLocationID, startRowIndex, pageSize, out totalRows, DtLDetail, DtTrustedOrgAction, Preference, ProtocalGroupID,BarcodeNumber,VisitType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstTasks);
                        dataReader.Close();
                    }
                }
                Int32.TryParse(cmd.Parameters["@totalRows"].Value.ToString(), out totalRows);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetPerformingAction", ex);
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
        public long GetTaskByVisit(long pVisitID, int pOrgID, int pTaskActionID, out List<Tasks> lstTasks)
        {
            long returnCode = -1;
            lstTasks = new List<Tasks>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetTaskByVisitCommand(pVisitID, pOrgID, pTaskActionID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstTasks);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting task By visit", ex);
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
       
        public long GetAllTasksStatForSavendNext(int RoleID, int OrgID, long UID, string TaskDate, string category, long orgAddrId, int specId,
            string PatientNumber, out List<TaskDetails> lstTasks, int InvLocationID, int startRowIndex, int pageSize, out int totalRows, int DeptID, LoginDetail LDetail, List<TrustedOrgActions> lstTrustedOrgAction, string Preference)
        {
            long returnCode = -1;
            totalRows = -1;
            DataTable DtLDetail = UDT_DAL.ConvertToLoginDetail(LDetail);
            DataTable DtTrustedOrgAction = UDT_DAL.ConvertToTrustedOrgActions(lstTrustedOrgAction);

            SqlCommand cmd = Command.PgettaskstatdetailsforsaveandnextCommand(RoleID, OrgID, UID, category, orgAddrId, specId, DeptID, TaskDate, PatientNumber, InvLocationID, startRowIndex, pageSize, out totalRows, DtLDetail, DtTrustedOrgAction, Preference, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstTasks = new List<TaskDetails>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }


            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstTasks);
                totalRows = Convert.ToInt32(cmd.Parameters["@totalRows"].Value);
            }

            return returnCode;

        }
        #region Set Default Search
        public long InsertTaskDefault(List<TaskDefaultSearch> lstTaskDefaultSearch)
        {
            long returnCode = -1;
            DataTable dtTaskDefaultSearch = UDT_DAL.ConvertToUDTTaskDefaultSearch(lstTaskDefaultSearch);
            SqlCommand cmd = Command.pInsertTaskDefaultSearchCommand(dtTaskDefaultSearch, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
            }

            return returnCode;
        }
        public long GetDefaultTaskFilter(int OrgID, long RoleID, long LoginID, out List<TaskDefaultSearch> lsttaskProfile)
        {
            long returnCode = -1;

            SqlCommand cmd = Command.pGetDefaultTaskFilterCommand(OrgID, RoleID, LoginID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lsttaskProfile = new List<TaskDefaultSearch>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lsttaskProfile);
            }
            return returnCode;
        }
        #endregion

    }
}
