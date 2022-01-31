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
    public class Feedback_BL
    {
        ContextDetails globalContextDetails;
        public Feedback_BL()
        {

        }

        public Feedback_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public long GetFeedbackType(out List<SystemFeedBackType> lstFeedBackType)
        {
            lstFeedBackType = new List<SystemFeedBackType>();
            long returncode = -1;
            try
            {
                Feedback_DAL ObjFeedBackDAL = new Feedback_DAL();
                lstFeedBackType = ObjFeedBackDAL.GetFeedbackType();
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetFeedbackType", ex);
            }
            return returncode;
        }

        public long InsertFeedback(int TypeID, int Priority, string Module, string PageURL, string Description, string Remarks, string Status)
        {
            long returnCode = -1;
            try
            {
                Feedback_DAL objDAL = new Feedback_DAL(globalContextDetails);
                returnCode = objDAL.InsertFeedback(TypeID, Priority, Module, PageURL, Description, Remarks, Status);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL InsertFeedback", ex);
            }
            return returnCode;
        }
        public long GetSysFBList(int TypeID,int OrgID, string Status, out List<SystemFeedBack> lstFeedBack)
        {
            lstFeedBack = new List<SystemFeedBack>();
            long returncode = -1;

            try
            {
                Feedback_DAL objFbDAL = new Feedback_DAL();
                lstFeedBack = objFbDAL.GetSysFBList(TypeID,OrgID, Status);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetSysFBList", ex);
            }
            return returncode;
        }


        public long UpdateSystemFeedBack(int OrgID, long ID, string Remarks, string Status)
        {

            long returncode = -1;

            try
            {
                Feedback_DAL objDAL = new Feedback_DAL();
                returncode = objDAL.UpdateSystemFeedBack(OrgID, ID, Remarks, Status);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetSysFBList", ex);
            }
            return returncode;
        }




    }
}
