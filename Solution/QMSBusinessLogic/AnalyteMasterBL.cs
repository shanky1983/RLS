using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;

using Attune.Solution.QMSDataAccessLayer;
using System.Data;
using Attune.Podium.Common;
using Attune.Solution.QMSBusinessEntities; 


namespace Attune.Solution.QMSBusinessLogic
{
    public class AnalyteMasterBL
    {
        ContextDetails globalContextDetails;
        public AnalyteMasterBL()
        {

        }
        public AnalyteMasterBL(ContextDetails _globalContextDetails)
        {
            globalContextDetails = _globalContextDetails;
        }
        /// <summary>
        /// DAL Global Declaration
        /// </summary>
        AnalyteMasterDAL _AnalyteMasterDAL;
        public long SaveAnalyteMasterDetails(int  orgID, String CommandFlag,List<AnalyteMaster> lstAnalyteMaster)
        {
            long returnCode = -1;
            //List<AnalyteMaster> lstAnalyteMaster = new List<AnalyteMaster>();
            AnalyteMasterDAL objAnalyteMaster = new AnalyteMasterDAL(globalContextDetails); 
            try
            {

                //objAnalyteMaster = AnalyteMaster;
                //AnalyteMasterDAL = new AnalyteMasterDAL(globalContextDetails);
                returnCode = objAnalyteMaster.SaveAnalyteMasterDetails(orgID, CommandFlag, lstAnalyteMaster);
                
            }
            catch (Exception excp)
            {
                CLogger.LogError("Error SaveAnalyteMasterDetails BL", excp);
            }

            return returnCode;
        }
        public long pGetAnalyteMasterDetails(int pOrgID,int InvID, out DataTable FileList)
        {
            long returncode = -1;
            AnalyteMasterDAL Obj_DAL = new AnalyteMasterDAL(globalContextDetails);
            FileList = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                returncode = Obj_DAL.pGetAnalyteMasterDetails(pOrgID,InvID,out FileList);
                //Utilities.ConvertTo(ds.Tables[0], out clientList);

            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing CreateNewClient BL", excp);
            }
            return returncode;

        }

        //public long pDeleteAnalyteMasterDetails(int PID)
        //{
        //    long returnCode = -1;
             
        //    AnalyteMasterDAL objAnalyteMaster = new AnalyteMasterDAL(globalContextDetails);
        //    try
        //    {

        //        returnCode = objAnalyteMaster.pDeleteAnalyteMasterDetails(PID); 

        //    }
        //    catch (Exception excp)
        //    {
        //        CLogger.LogError("Error while executing CreateNewClient BL", excp);
        //    }

        //    return returnCode;
        //}

        public long pUpdateAnalyteMasterDetails(long pOrgID, string pAnalyteName, long pDepatmentID, long pContatinerID,
            string pResultValueType, long pSampleID, string pDecimalPlaces, long pMethodID, long pPrincipleID, string pClassfication, int pCutOffTimeValue,
            string pCutOffTimeType, string pIsActive, string pIsNABL, long InvestigationID)
        {
            long returnCode = 1;
            AnalyteMasterDAL objAnalyteMaster = new AnalyteMasterDAL(globalContextDetails);
            try
            {
                returnCode = objAnalyteMaster.pUpdateAnalyteMasterDetails(pOrgID, pAnalyteName, pDepatmentID, pContatinerID, pResultValueType, pSampleID, pDecimalPlaces,
                    pMethodID, pPrincipleID, pClassfication, pCutOffTimeValue, pCutOffTimeType, pIsActive, pIsNABL, InvestigationID);
            }
            catch(Exception excp)
            {
                CLogger.LogError("Error UpdateAnalyteMasterDetails BL", excp); 
            }
            return returnCode; 
        }
    }
}
