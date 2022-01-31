using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Data;
using System.Data.SqlClient;
using Attune.Podium.Common;
using Attune.Podium.DataAccessEngine;
using Attune.Solution.QMSDataAccessLayer;
using Attune.Solution.QMSBusinessEntities;

namespace Attune.Solution.QMSDataAccessLayer
{
    public class AnalyteMasterDAL
    {
        ContextDetails globalContextDetails;
      
        public AnalyteMasterDAL() 
        { 

        }
        public AnalyteMasterDAL(ContextDetails _globalContextDetails)
        {
            globalContextDetails = _globalContextDetails;
        }
        public long SaveAnalyteMasterDetails(int orgID,String CommandFlag,List<AnalyteMaster> AnalyteMaster )
        {
            long returnCode = -1;
            try
            {
                DataTable dtAnalyteMaster = UDT_DAL.ConvertToAnalyteMaster(AnalyteMaster);
                SqlCommand cmd = new SqlCommand(); 
                cmd = Command.pSaveAnalyteMasterDetailsCommand(orgID, CommandFlag, dtAnalyteMaster, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error SaveAnalyteMasterDetailsCommand", ex);
            }
            return returnCode;
        }
        public long pGetAnalyteMasterDetails(int pOrgID,int InvID, out DataTable FileList)
        {
            FileList = new DataTable();

            DataSet ds = new DataSet();
            long returncode = -1;

            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.pGetAnalyteMasterDetailsCommand(pOrgID, InvID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {

                    returncode = dbEngine.ExecuteDataSet(cmd, out ds);
                    
                }

                if (ds.Tables.Count > 0)
                {
                    FileList = ds.Tables[0];
                }

                
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Getting Files", ex);
            }
            return returncode;
        }
        

        //public long pDeleteAnalyteMasterDetails(int PID)
        //{
        //    long returnCode = -1;
        //    try
        //    {
        //        //DataTable dtAnalyteMaster = UDT_DAL.ConvertToUDT_Context(AnalyteMaster);
        //        SqlCommand cmd;
        //        cmd = Command.pDeleteAnalyteMasrerCommand(PID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
        //        using (DBEngine dbEngine = new DBEngine())
        //        {
        //            dbEngine.ExecuteNonQuery(cmd);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error while Validate Excell sheet", ex);
        //    }
        //    return returnCode;
        //}

        public long pUpdateAnalyteMasterDetails(long pOrgID, string pAnalyteName, long pDepatmentID, long pContatinerID,
            string pResultValueType, long pSampleID, string pDecimalPlaces, long pMethodID, long pPrincipleID, string pClassfication, int pCutOffTimeValue,
            string pCutOffTimeType, string pIsActive, string pIsNABL, long InvestigationID)
        {
            long returnCode = -1;
            try
            {
                
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pUpdateAnalyteMasterDetailsCommand(pOrgID, pAnalyteName, pDepatmentID, pContatinerID, pResultValueType, pSampleID, pDecimalPlaces,
                    pMethodID, pPrincipleID, pClassfication, pCutOffTimeValue, pCutOffTimeType, pIsActive, pIsNABL,InvestigationID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                    using (DBEngine dbEngine = new DBEngine())
                    {
                    dbEngine.ExecuteNonQuery(cmd);  
                    }
            }
            catch (Exception ex)
            {
            CLogger.LogError("Error SaveAnalyteMasterDetailsCommand",ex);  
            }
            return returnCode;
        }
        
        

    }
}