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
    public class Communication_DAL
    {
        ContextDetails globalContextDetails;
        public Communication_DAL()
        {
        }
        public Communication_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public long SaveCommunicationMasterEntry(List<NBCommunicationDetails> lstCommDetails, NBCommunicationMaster cm, string Flag, string visitNumber, out long CommID, out string CommCode)
        {
            long returnCode = -1;
            CommID = 0;
            CommCode = "";
            try
            {
                DataTable dt = new DataTable();
                dt = UDT_DAL.ConvertToCommunicationDetails(lstCommDetails);
                SqlCommand cmd = Command.pInsertCommunicationMasterCommand(dt, cm.OrgID, cm.CommContent, cm.CommType, cm.Validity, cm.AckRequired, cm.Subject, cm.BroadcastedBy, cm.SendSMS, cm.CommCategoryID, cm.PriorityLevel, cm.RefCommID, cm.ParentCommID, cm.CreatedBy, cm.RoleID, Flag, visitNumber, out CommID, out CommCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    CommID = Convert.ToInt64(cmd.Parameters["@CommID"].Value);
                    CommCode = Convert.ToString(cmd.Parameters["@CommCode"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL SaveCommunicationMasterEntry", ex);
            }
            return returnCode;
        }

        public long UpdateNBCommunicationDetail(long CommID, int OrgID, long LoginID, string ACKRequired, int RoleID, string Remarks)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pUpdateNBDetailWithACKCommand(CommID, OrgID, LoginID, ACKRequired, RoleID, Remarks);
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL UpdateNBCommunicationDetail", ex);
            }
            return returnCode;
        }

        public List<CommTypeMaster> GetCommType()
        {
            List<CommTypeMaster> CommType = null;
            //long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pGetCommTypeCommand();
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out CommType);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetCommType", ex);
            }
            return CommType;
        }

        public List<NBCommunicationMaster> ViewCommunication(long CommID, int OrgID, long RoleID, long LoginID)
        {
            List<NBCommunicationMaster> CommType = null;
            //long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pViewCommunicationCommand(CommID, OrgID, RoleID, LoginID);
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out CommType);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL ViewCommunication", ex);
            }
            return CommType;
        }

        public List<NBCommunicationMaster> ViewMasterCommunication(long RoleID, string Initiator, long LoginID)
        {
            List<NBCommunicationMaster> CommType = null;
            //long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pViewMasterCommunicationCommand(RoleID, Initiator, LoginID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out CommType);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL ViewMasterCommunication", ex);
            }
            return CommType;
        }

        public List<NBCommunicationMaster> GetNBCommunication(long CommID, int OrgID)
        {
            List<NBCommunicationMaster> communicationList = null;
            //long returnCode = -1;
            //CommID = "";
            try
            {
                SqlCommand cmd = Command.pGetCommunicationForUsersInDetailCommand(CommID, OrgID);
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out communicationList);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetNBCommunication", ex);
            }
            return communicationList;
        }

        public List<Users> RetrieveManager(int OrgID, int RoleID)
        {
            List<Users> communicationList = null;
            //long returnCode = -1;            
            try
            {
                SqlCommand cmd = Command.pGetCommunicationUserslistCommand(OrgID, RoleID);
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out communicationList);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL RetrieveManager", ex);
            }
            return communicationList;
        }

        // changed dataset to datareader by Arivalagan.k
        public long RetrieveNBCommunication(int OrgID, long RoleID, long LoginID, out List<NBCommunicationMaster> NewcommunicationList, out List<NBCommunicationMaster> NBcommunicationList)
        {
            NewcommunicationList = new List<NBCommunicationMaster>();
            NBcommunicationList = new List<NBCommunicationMaster>();
            long lResult = -1;
            int rsCount = 0;
			IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetCommunicationForUsersCommand(OrgID, RoleID, LoginID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                lResult = Utilities.ConvertTo(dataReader, out NewcommunicationList);
                            }
                            else if (rsCount == 1)
                            {
                                lResult = Utilities.ConvertTo(dataReader, out NBcommunicationList);
                            }
                          
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
               
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL RetrieveCommunication", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            } 
            return lResult;
        }
        public List<ClientMaster> GetClientForCommunication(int OrgID)
        {
            List<ClientMaster> lstClientComm = null;
            //long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pGetClientForCommunicationCommand(OrgID);
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstClientComm);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetClientForCommunication", ex);
            }
            return lstClientComm;
        }

        public List<CommVisitNumberDetails> PGetVisitNumber(string visitNumber)
        {
            List<CommVisitNumberDetails> lstClientComm = null;
            DataTable dt = UDT_DAL.ConvertToUDT_Context(globalContextDetails);
            //long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.PVerifyVisitNumberCommand(visitNumber, Convert.ToInt32(dt.Rows[0]["OrgID"].ToString()));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstClientComm);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetClientForCommunication", ex);
            }
            return lstClientComm;
        }

        //Changes of DataSet To DataReader Made By Arivalagan.k
        public long GetCommuicationvisitDetails(string ExternalVisitID, string ExternalBarcode, int Orgid, out List<NBCommunicationMaster> listCommunication)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            listCommunication = new List<NBCommunicationMaster>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.PGetCommuicationvisitDetailsCommand(ExternalVisitID, ExternalBarcode, Orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out listCommunication);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While GetCommuicationvisitDetails in Communication_DAL", ex);
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
    }
}
