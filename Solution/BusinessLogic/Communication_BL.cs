using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Attune.Podium.BusinessEntities;
using Attune.Solution.DAL;
using Attune.Podium.Common;
using Attune.Podium.PerformingNextAction;

namespace Attune.Solution.BusinessComponent
{
    public class Communication_BL
    {
        ContextDetails globalContextDetails;
        public Communication_BL()
        {

        }

        public Communication_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        //public long CommunicationMaster(int OrgID, string CommContent, string CommType, System.DateTime Validity, string AckRequired, string Subject, string Broadcastedby, string SendSMS, long CommCategoryID, string PriorityLevel, out string CommID, out string CommCode)
        //{
        //    long returnCode = -1;
        //    CommID = "";
        //    CommCode = "";
        //    try
        //    {
        //        Communication_DAL InvDAL = new Communication_DAL(globalContextDetails);
        //        returnCode = InvDAL.CommunicationMaster(OrgID, CommContent, CommType, Validity, AckRequired, Subject, Broadcastedby, SendSMS, CommCategoryID, PriorityLevel, out CommID, out CommCode);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error in BL CommunicationMaster", ex);
        //    }
        //    return returnCode;
        //}
        public long SaveCommunicationMasterEntry(List<NBCommunicationDetails> lstCommDetails, NBCommunicationMaster cm, string Flag, string VisitNumber, out long CommID, out string CommCode)
        {
            long returnCode = -1;
            CommID = 0;
            CommCode = "";
            try
            {
                Communication_DAL InvDAL = new Communication_DAL(globalContextDetails);
                returnCode = InvDAL.SaveCommunicationMasterEntry(lstCommDetails, cm, Flag, VisitNumber, out CommID, out CommCode);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL SaveCommunicationMasterEntry", ex);
            }
            return returnCode;
        }

        public List<Users> RetrieveManager(int OrgID, int RoleID)
        {
            List<Users> communicationList = null;
            //long returnCode = -1;            
            try
            {
                Communication_DAL InvDAL = new Communication_DAL(globalContextDetails);
                communicationList = InvDAL.RetrieveManager(OrgID, RoleID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL RetrieveManager", ex);
            }
            return communicationList;
        }

        public List<NBCommunicationMaster> GetNBCommunication(long CommID, int OrgID)
        {
            List<NBCommunicationMaster> communicationList = null;
            //long returnCode = -1;            
            try
            {
                Communication_DAL InvDAL = new Communication_DAL(globalContextDetails);
                communicationList = InvDAL.GetNBCommunication(CommID, OrgID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetNBCommunication", ex);
            }
            return communicationList;
        }

        /*public long GetNBcode(int OrgID)
        {
            long returnCode = -1;
            try
            {
                Communication_DAL InvDAL = new Communication_DAL(globalContextDetails);
                returnCode = InvDAL.GetNBcode(OrgID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetNBcode", ex);
            }
            return returnCode;
        }*/

        public List<CommTypeMaster> GetCommType()
        {
            List<CommTypeMaster> CommType = null;
            try
            {
                Communication_DAL InvDAL = new Communication_DAL(globalContextDetails);
                CommType = InvDAL.GetCommType();
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetCommType", ex);
            }
            return CommType;
        }

        public List<NBCommunicationMaster> ViewCommunication(long CommID, int OrgID, long RoleID, long LoginID)
        {
            List<NBCommunicationMaster> CommType = null;
            try
            {
                Communication_DAL InvDAL = new Communication_DAL(globalContextDetails);
                CommType = InvDAL.ViewCommunication(CommID, OrgID, RoleID, LoginID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL ViewCommunication", ex);
            }
            return CommType;
        }

        public List<NBCommunicationMaster> ViewMasterCommunication(long RoleID, string Initiator, long LoginID)
        {
            List<NBCommunicationMaster> CommType = null;
            try
            {
                Communication_DAL InvDAL = new Communication_DAL(globalContextDetails);
                CommType = InvDAL.ViewMasterCommunication(RoleID, Initiator, LoginID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL ViewMasterCommunication", ex);
            }
            return CommType;
        }

        public long UpdateNBCommunicationDetail(long CommID, int OrgID, long LoginID, string ACKRequired, int RoleID, string Remarks)
        {
            long returnCode = -1;
            //CommID = "";
            try
            {
                Communication_DAL InvDAl = new Communication_DAL(globalContextDetails);
                returnCode = InvDAl.UpdateNBCommunicationDetail(CommID, OrgID, LoginID, ACKRequired, RoleID, Remarks);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL UpdateNBCommunicationDetail", ex);
            }
            return returnCode;
        }

        /*public long CommunicationDetails(string RoleName, string CommCode, string CommID, int CommType, int OrgID, string PriorityLevel, string ACKRequired)
        {
            long returnCode = -1;
            //CommID = "";
            try
            {
                Communication_DAL InvDAl = new Communication_DAL(globalContextDetails);
                returnCode = InvDAl.CommunicationDetails(RoleName, CommCode, CommID, CommType, OrgID, PriorityLevel, ACKRequired);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL CommunicationDetails", ex);
            }
            return returnCode;
        }*/

        /*public long ClientRequest(string ClientMessage, long LoginID)
        {
            long returnCode = -1;
            try
            {
                Communication_DAL InvDAl = new Communication_DAL(globalContextDetails);
                returnCode = InvDAl.ClientRequest(ClientMessage, LoginID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL ClientRequest", ex);
            }
            return returnCode;
        }*/

        //public List<NBCommunicationMaster> RetrieveNBCommunication(int OrgID, int RoleID)
        //{
        //    List<NBCommunicationMaster> communicationList = null;
        //    //Count = 0;
        //    try
        //    {
        //        Communication_DAL InvDAl = new Communication_DAL(globalContextDetails);
        //        communicationList = InvDAl.RetrieveNBCommunication(OrgID, RoleID);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error in BL RetrieveCommunication", ex);
        //    }
        //    return communicationList;
        //}

        public long RetrieveNBCommunication(int OrgID, long RoleID, long LoginID, out List<NBCommunicationMaster> NewcommunicationList, out List<NBCommunicationMaster> NBcommunicationlist)
        {
            //List<NBCommunicationMaster> communicationList = null;
            long result = -1;
            NewcommunicationList = new List<NBCommunicationMaster>();
            NBcommunicationlist = new List<NBCommunicationMaster>();
            //Count = 0;
            try
            {
                Communication_DAL InvDAl = new Communication_DAL(globalContextDetails);
                result = InvDAl.RetrieveNBCommunication(OrgID, RoleID, LoginID, out NewcommunicationList, out NBcommunicationlist);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL RetrieveCommunication", ex);
            }
            return result;
        }

        /*public List<NBCommunicationMaster> GetClient(int OrgID)
        {
            List<NBCommunicationMaster> communicationList = null;
            long returnCode = -1;
            //CommID = "";
            try
            {
                Communication_DAL InvDAl = new Communication_DAL(globalContextDetails);
                communicationList = InvDAl.GetClient(OrgID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetClient", ex);
            }
            return communicationList;
        }*/
        public List<ClientMaster> GetClientForCommunication(int OrgID)
        {
            List<ClientMaster> lstClientComm = null;
            try
            {
                Communication_DAL commDAL = new Communication_DAL(globalContextDetails);
                lstClientComm = commDAL.GetClientForCommunication(OrgID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetClientForCommunication", ex);
            }
            return lstClientComm;
        }

        public long GetCommuicationvisitDetails(string ExternalVisitID, string ExternalBarcode, int Orgid, out List<NBCommunicationMaster> listCommunication)
        {
            listCommunication = new List<NBCommunicationMaster>();
            long returnCode = -1;
            try
            {

                returnCode = new Communication_DAL(globalContextDetails).GetCommuicationvisitDetails(ExternalVisitID, ExternalBarcode, Orgid, out listCommunication);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetNBCommunication", ex);
            }
            return returnCode;
        }
        public List<CommVisitNumberDetails> PGetVisitNumber(string VisitNumber)
        {
            List<CommVisitNumberDetails> lstClientComm = null;
            try
            {
                Communication_DAL commDAL = new Communication_DAL(globalContextDetails);
                lstClientComm = commDAL.PGetVisitNumber(VisitNumber);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetClientForCommunication", ex);
            }
            return lstClientComm;
        }
    }
}
