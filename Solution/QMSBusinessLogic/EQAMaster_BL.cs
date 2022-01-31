using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Attune.Solution.QMSDataAccessLayer;
using Attune.Podium.Common;
using System.Data;
using Attune.Solution.QMSBusinessEntities;

namespace Attune.Solution.QMSBusinessLogic
{
    public class EQAMaster_BL
    {
        ContextDetails globalContextDetails;

        public EQAMaster_BL()
        {
        }
        public EQAMaster_BL(ContextDetails _globalContextDetails)
        {
            globalContextDetails = _globalContextDetails;
        }

        EQAMaster_DAL Obj_DAL;
        //public long SaveEQAMaster(List<ExternalQualityAssuranceMaster> EQAMaster)
        //{
        //    long returncode = -1;
           
        //    try
        //    {
        //        Obj_DAL = new EQAMaster_DAL(globalContextDetails);
        //        returncode = Obj_DAL.SaveEQAMAster(EQAMaster);
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error while inserting in InvInstrumentMaster_BL", ex);
        //    }
        //    return returncode;
        //}

        public long LoadDeptInvestigation(int departmentid, string Type, int VendorID, DateTime ProcessingDateTime, out DataSet FileList)
        {
            long returncode = -1;
            EQAMaster_DAL Obj_DAL = new EQAMaster_DAL(globalContextDetails);
            FileList = new DataSet();
            DataSet ds = new DataSet();
            try
            {
                returncode = Obj_DAL.LoadDeptInvestigation(departmentid, Type, VendorID, ProcessingDateTime, out FileList);
                //Utilities.ConvertTo(ds.Tables[0], out clientList);

            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing LoadDeptInvestigation BL", excp);
            }
            return returncode;

        }
        public long SaveInternalExternalQualityValues(List<InternalExternalQuality> UDTInternalExternal, List<EQAMaster> SaveEQAMaster,out long QAID)
        {
            long returncode = -1;
            QAID = -1;
            try
            {
                EQAMaster_DAL Obj_DAL = new EQAMaster_DAL(globalContextDetails);
                returncode = Obj_DAL.SaveInternalExternalQualityValues(UDTInternalExternal, SaveEQAMaster,out QAID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Save in SaveInternalExternalQualityValues BL", ex);
            }
            return returncode;
        }
        public long DeleteInternalExternalQualityValue(long ValId)
        {
            long returncode = -1;
            try
            {
                EQAMaster_DAL Obj_DAL = new EQAMaster_DAL(globalContextDetails);
                returncode = Obj_DAL.DeleteInternalExternalQualityValue(ValId);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Save in SaveInternalExternalQualityValues BL", ex);
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
        //            long OrgId)
        //{
        //    long returncode = -1;
        //    try
        //    {
        //        EQAMaster_DAL Obj_DAL = new EQAMaster_DAL(globalContextDetails);
        //        returncode = Obj_DAL.InsertInternalExternalQualityMaster(ExValueId, ExValueId, VendorID, CycleIdentification, DateOfProcessing, Interpretation, HasFile, FileType, FilePath, EQMID, InvestigationID, ResultValue, InternalResultValue, ExternalResultValue, Deviation, Correction, Zscore, Status, RootCause, CorrectiveAction, PreventiveAction, OrgId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
        //    }
        //    catch (Exception ex)
        //    {
        //        CLogger.LogError("Error while inserting in InsertInternalExternalQualityMaster BL", ex);
        //    }

        //    return returncode;

        //}
    }
}
