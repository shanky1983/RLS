using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Attune.Solution.QMSBusinessEntities;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.Common;

namespace Attune.Solution.QMSDataAccessLayer
{
    public class DeviceQMS_DL
    {
        ContextDetails globalContextDetails;
        
        public DeviceQMS_DL() 
        { 

        }

        public DeviceQMS_DL(ContextDetails _globalContextDetails)
        {
            globalContextDetails = _globalContextDetails;
        }

        public long GetQCResultSearchValues(Int32 pOrgID, String pType, String pSearchText, out List<CodingScheme> lstCodingScheme)
        {
            long returnCode = -1;
            lstCodingScheme = new List<CodingScheme>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetQCResultSearchValuesCommand(pOrgID, pType, pSearchText, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstCodingScheme);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetQCResultSearchValues", ex);
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

        public long GetQCResultDetails(Int32 pOrgID, Int64 pInstrumentID, Int64 InvestigationID, Int64 pLotID, DateTime pFromDate, DateTime pToDate, out DataTable FileList)
        {
            long returnCode = -1;
            FileList = new DataTable();

            DataSet ds = new DataSet();
            try
            {
                System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetQCResultDetailsCommand(pOrgID, pInstrumentID, InvestigationID, pLotID, pFromDate, pToDate, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables.Count > 0)
                {
                    FileList = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetQCResultDetails", ex);
            }
            
            return returnCode;
        }

        public long GetQCLabMeanDetails(Int32 pOrgID, Int64 pInstrumentID, Int64 InvestigationID, Int64 pLotID, out DataTable FileList)
        {
            long returnCode = -1;
            FileList = new DataTable();

            DataSet ds = new DataSet();
            try
            {
                System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetQCLabMeanDetailsCommand(pOrgID, pInstrumentID, InvestigationID, pLotID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables.Count > 0)
                {
                    FileList = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetQCLabMeanDetails", ex);
            }

            return returnCode;
        }

        public long GetFloatingMeanDetails(Int32 pOrgID, Int64 pInstrumentID, Int64 InvestigationID, Int64 pLotID,DateTime pFromDate,DateTime pToDate,int pFMOption, out DataTable FileList)
        {
            long returnCode = -1;
            FileList = new DataTable();

            DataSet ds = new DataSet();
            try
            {
                System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetFloatingMeanDetailsCommand(pOrgID, pInstrumentID, InvestigationID, pLotID, pFromDate, pToDate, pFMOption, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables.Count > 0)
                {
                    FileList = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetQCLabMeanDetails", ex);
            }

            return returnCode;
        }

        public long SaveQCEvaluvationsDetails(List<QCEvaluvationsDetails> lstQCEvaluvationsDetails)
        {
            long returnCode = -1;
            DataTable dtQCEvaluvationsDetails = UDT_DAL.ConvertToUDTQCEvaluvationsDetails(lstQCEvaluvationsDetails);
            try
            {
                SqlCommand cmd = Command.pSaveQCEvaluvationsDetailsCommand(dtQCEvaluvationsDetails, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine db = new DBEngine())
                {
                    returnCode = db.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL SaveQCEvaluvationsDetails", ex);
            }

            return returnCode;
        }

    }
}
