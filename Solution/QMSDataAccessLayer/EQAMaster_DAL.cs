using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Attune.Podium.Common;
using System.Data;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Solution.QMSDataAccessLayer;
using Attune.Solution.QMSBusinessEntities;

namespace Attune.Solution.QMSDataAccessLayer
{
    public class EQAMaster_DAL
    {
        ContextDetails globalContextDetails;

        public EQAMaster_DAL()
        {
        }
        public EQAMaster_DAL(ContextDetails _globalContextDetails)
        {
            globalContextDetails = _globalContextDetails;
        }

        //public long SaveEQAMAster(List<ExternalQualityAssuranceMaster> EQAMaster) 
        //{
        //    long returncode = -1;
        //    DataTable dt = UDT_DAL.ConverttoEQAMaster(EQAMaster);
        //    SqlCommand cmd = Command.pSaveEQAMasterCommand(dt, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

        //    try
        //    {
        //        using (DBEngine dbEngine = new DBEngine())
        //        {
        //            returncode = dbEngine.ExecuteNonQuery(cmd);

        //        }
               
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error while inserting in InvInstrumentMaster_DAL", ex);
        //    }

        //    return returncode;
        //}
        public long LoadDeptInvestigation(int Departmentid, string Type, int VendorID, DateTime ProcessingDateTime, out DataSet FileList)
        {
            FileList = new DataSet();
            long returncode = -1;

            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            DataSet _ds = new DataSet();
            try
            {
                cmd = Command.PgetdepartmentinvetigationCommand(Departmentid, Type,VendorID,ProcessingDateTime, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteDataSet(cmd, out FileList);
                }
          
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while PgetDepartmentInvetigationCommand DAL", ex);
            }
            return returncode;
        }
        public long SaveInternalExternalQualityValues(List<InternalExternalQuality> UDTInternalExternal, List<EQAMaster> SaveEQAMaster, out long QAID)
        {
            long returncode = -1;

            SqlCommand cmd = Command.PsaveinternalexternalqualityvaluesCommand(UDT_DAL.InternalExternalQuality(UDTInternalExternal), UDT_DAL.ConverttoEQAMaster(SaveEQAMaster), UDT_DAL.ConvertToUDT_Context(globalContextDetails),out QAID);

            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                    string outParm = Convert.ToString(cmd.Parameters["@QAID"].Value);
                    if (outParm != "" && outParm != null)
                    {
                        QAID = Convert.ToInt32(outParm);
                    }
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Save in SaveInternalExternalQualityValues DAL", ex);
            }

            return returncode;
        }
        public long DeleteInternalExternalQualityValue(long ValId)
        {
            long returncode = -1;

            SqlCommand cmd = Command.PdeleteinternalexternalqualityvalueCommand(ValId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Execute DeleteInternalExternalQualityValue DAL", ex);
            }

            return returncode;
        }
        //public long InsertInternalExternalQualityMaster(
        //            long ExValueId,
        //            long ExAssureId,
        //            long VendorID,
        //            string CycleIdentification,
        //            System.DateTime DateOfProcessing,
        //            string Interpretation,
        //            string HasFile,
        //            string FileType,
        //            string FilePath,
        //            long EQMID,
        //            long InvestigationID,
        //            string ResultValue,
        //            string InternalResultValue,
        //            string ExternalResultValue,
        //            decimal Deviation,
        //            decimal Correction,
        //            string Zscore,
        //            string Status,
        //            string RootCause,
        //            string CorrectiveAction,
        //            string PreventiveAction,
        //            long OrgId,
        //            System.Data.DataTable ContextInfo)
        //{
        //    long returncode = -1;
        //    SqlCommand cmd = Command.PinsertinternalExternalQualityMasterCommand(ExValueId, ExValueId, VendorID, CycleIdentification, DateOfProcessing, Interpretation, HasFile, FileType, FilePath, EQMID, InvestigationID, ResultValue, InternalResultValue, ExternalResultValue, Deviation, Correction, Zscore, Status, RootCause, CorrectiveAction, PreventiveAction, OrgId, ContextInfo);

        //    try
        //    {
        //        using (DBEngine dbEngine = new DBEngine())
        //        {
        //            returncode = dbEngine.ExecuteNonQuery(cmd);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error while inserting in InsertInternalExternalQualityMaster DAL", ex);
        //    }

        //    return returncode;
        //}
    }
}
