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
    public class AnalyzerMapping_BL
    {
        ContextDetails globalContextDetails;
      
        public AnalyzerMapping_BL() { 
        }
        public AnalyzerMapping_BL(ContextDetails _globalContextDetails)
        {
            globalContextDetails = _globalContextDetails;
        }
        AnalyzerMapping_DAL Obj_DAL;
        public long QMS_LoadDevices_BL(string Status,out List<InvInstrumentMaster> FileList)
        {
            long returncode = -1;
            FileList = new List<InvInstrumentMaster>();
            //DataSet ds = new DataSet();
            Obj_DAL=new AnalyzerMapping_DAL(globalContextDetails);
            try
            {
                returncode = Obj_DAL.QMS_LoadDevices_DAL(Status,out FileList);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading Device in QMS_LoadDevices_BL", ex);
            }
            return returncode;
        }
        public long QMS_LoadAnalyte_BL(string Status,string username, out List<InvestigationOrgMapping> FileList)
        {
            long returncode = -1;
            FileList = new List<InvestigationOrgMapping>();
            //DataSet ds = new DataSet();
            Obj_DAL = new AnalyzerMapping_DAL(globalContextDetails);
            try
            {
                returncode = Obj_DAL.QMS_LoadAnalyte_DAL(Status, username, out FileList);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading Device in QMS_LoadAnalyte_BL", ex);
            }
            return returncode;
        }
        public long QMS_DeviceDetails_BL(int InstrumentID,out List<InvInstrumentMaster> Devicelist)
        {
            long returncode = -1;
            Devicelist = new List<InvInstrumentMaster>();
            Obj_DAL = new AnalyzerMapping_DAL(globalContextDetails);
            try
            {
                returncode =Obj_DAL.QMS_DeviceDetails_DAL(InstrumentID,out Devicelist);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing in QMS_DeviceDetails_BL ", ex);
            }
            return returncode;
        }
        public long QMS_SaveAnalyzermappingDetails_BL(List<QC_AnalyzerMapping> Analyzer)
        {
            long returncode = -1;
            Obj_DAL = new AnalyzerMapping_DAL(globalContextDetails);
            try
            {
                returncode = Obj_DAL.QMS_SaveAnalyzermappingDetails_DAL(Analyzer);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing in QMS_SaveAnalyzermappingDetails_BL", ex);
            }
            return returncode;
        }
        public long QMS_UpdateAnalyzermappingDetails_BL(List<QC_AnalyzerMapping> Analyzer, string frequencyday, string frequencytime)
        {
            long returncode = -1;
            Obj_DAL = new AnalyzerMapping_DAL(globalContextDetails);
            try
            {
                returncode = Obj_DAL.QMS_UpdateAnalyzermappingDetails_DAL(Analyzer, frequencyday,frequencytime);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing in QMS_SaveAnalyzermappingDetails_BL", ex);
            }
            return returncode;
        }

        public long QMS_PdeleteAnalyzermappingDetailsCommand_BL(string DeviceID, string TestCode, string Activationstatus)
        {
            long returncode = -1;
            Obj_DAL = new AnalyzerMapping_DAL(globalContextDetails);
            try
            {
                returncode = Obj_DAL.PdeleteAnalyzermappingDetailsCommand_DAL(DeviceID, TestCode, Activationstatus);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing in QMS_SaveAnalyzermappingDetails_BL", ex);
            }
            return returncode;
        }
        public long QMS_PgetAnalyzerMappingDetails_BL(out DataTable FileList)
        {
            long returncode = -1;
            AnalyzerMapping_DAL Obj_DAL = new AnalyzerMapping_DAL(globalContextDetails);
            FileList = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                returncode = Obj_DAL.QMS_PgetAnalyzerMappingDetails_DAl(out FileList);
                //Utilities.ConvertTo(ds.Tables[0], out clientList);

            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing LoadAnalyzerMaster BL", excp);
            }
            return returncode;

        }
        public long QMS_SaveQcValues_BL(List<QcValueDetails> Analyzer)
        {
            long returncode = -1;
            Obj_DAL = new AnalyzerMapping_DAL(globalContextDetails);
            try
            {
                returncode = Obj_DAL.QMS_SaveQcValues_DAL(Analyzer);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing in QMS_SaveAnalyzermappingDetails_BL", ex);
            }
            return returncode;
        }

        public long QMS_LoadAnalyteForAnalyzer_BL(long IstrumentID, DateTime dTime, long Level, out List<QcValueDetails> FileList)
        {
            long returncode = -1;
            FileList = new List<QcValueDetails>();
            //DataSet ds = new DataSet();
            Obj_DAL = new AnalyzerMapping_DAL(globalContextDetails);
            try
            {
                returncode = Obj_DAL.QMS_LoadAnalyteForAnalyzer_DAL(IstrumentID, dTime, Level, out FileList);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading Device in QMS_LoadAnalyte_BL", ex);
            }
            return returncode;
        }

        public long QMS_LoadDevicesAutoComplete_BL(string Status, string Prefix, out List<InvInstrumentMaster> FileList)
        {
            long returncode = -1;
            FileList = new List<InvInstrumentMaster>();
            //DataSet ds = new DataSet();
            Obj_DAL = new AnalyzerMapping_DAL(globalContextDetails);
            try
            {
                returncode = Obj_DAL.QMS_LoadDevicesAutoComplete_DAL(Status, Prefix, out FileList);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading Device in QMS_LoadDevices_BL", ex);
            }
            return returncode;
        }
        public long CheckTestcode(string DeviceID, string Testcode, out string status)
        {
            long returnCode = -1;
            status = string.Empty;
            try
            {

                Obj_DAL = new AnalyzerMapping_DAL(globalContextDetails);
                returnCode = Obj_DAL.CheckTestcode_DAL(DeviceID, Testcode, out status);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while Checking for CheckTestcode_BL ", e);
            }

            return returnCode;
        }
    }
}
