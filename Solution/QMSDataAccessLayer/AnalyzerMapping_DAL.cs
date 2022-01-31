using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Attune.Podium.Common;
using System.Data;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Solution.QMSBusinessEntities;
namespace Attune.Solution.QMSDataAccessLayer
{

    public class AnalyzerMapping_DAL
    {
        ContextDetails globalContextDetails;

        public AnalyzerMapping_DAL()
        {
        }
        public AnalyzerMapping_DAL(ContextDetails _globalContextDetails)
        {
            globalContextDetails = _globalContextDetails;
        }


        public long QMS_LoadDevices_DAL(string Status, out List<InvInstrumentMaster> InstrumentList)
        {
            InstrumentList = new List<InvInstrumentMaster>();
            long returncode = -1;
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.PgetdeviceinstrumentnameCommand(Status,"a" ,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    System.Data.IDataReader IdR = dbEngine.ExecuteReader(cmd);
                    returncode = Attune.Podium.Common.Utilities.ConvertTo<InvInstrumentMaster>(IdR, out InstrumentList);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while loading in QMS_LoadDevices_DAL", e);
            }
            return returncode;
        }
        public long QMS_LoadAnalyte_DAL(string Status, string username, out List<InvestigationOrgMapping> InstrumentList)
        {
            InstrumentList = new List<InvestigationOrgMapping>();
            long returncode = -1;
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.PgetdeviceinstrumentnameCommand(Status, username, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    System.Data.IDataReader IdR = dbEngine.ExecuteReader(cmd);
                    returncode = Attune.Podium.Common.Utilities.ConvertTo<InvestigationOrgMapping>(IdR, out InstrumentList);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while loading in QMS_LoadAnalyte_DAL", e);
            }
            return returncode;
        }
        public long QMS_DeviceDetails_DAL(int instrumentID, out List<InvInstrumentMaster> Devicelist)
        {
            Devicelist = new List<InvInstrumentMaster>();
            long returncode = -1;
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.pLoadDeviceDetailsCommand(instrumentID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    System.Data.IDataReader IdR = dbEngine.ExecuteReader(cmd);
                    returncode = Attune.Podium.Common.Utilities.ConvertTo<InvInstrumentMaster>(IdR, out Devicelist);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing in QMS_DeciveDetails_DAL", e);
            }
            return returncode;
        }
        public long QMS_SaveAnalyzermappingDetails_DAL(List<QC_AnalyzerMapping> Analyzer)
        {
            long returncode = -1;
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.PsaveanalyzermappingdetailsCommand(UDT_DAL.AnalyzermappingDetails(Analyzer), UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executig in QMS_SaveAnalyzermappingDetails_DAL", e); 
            }
            return returncode;
        }
        public long QMS_UpdateAnalyzermappingDetails_DAL(List<QC_AnalyzerMapping> Analyzer,string frequencyday,string frequencytime)
        {
            long returncode = -1;
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.PupdatedevicemappingdetailsCommand(UDT_DAL.AnalyzermappingDetails(Analyzer), frequencyday, frequencytime, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executig in QMS_SaveAnalyzermappingDetails_DAL", e);
            }
            return returncode;
        }
        public long PdeleteAnalyzermappingDetailsCommand_DAL(String DeviceID, string Testcode, string Activationstatus)
        {
            long returncode = -1;
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.PdeleteAnalyzermappingDetailsCommand(DeviceID, Testcode, Activationstatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executig in QMS_SaveAnalyzermappingDetails_DAL", e);
            }
            return returncode;
        }
        public long QMS_PgetAnalyzerMappingDetails_DAl(out DataTable FileList)
        {
            long returncode = -1;
            FileList = new DataTable();
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            DataSet _ds = new DataSet();
            try
            {
                cmd = Command.PgetAnalyzerMappingDetailsCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {

                    returncode = dbEngine.ExecuteDataSet(cmd, out _ds);
                }
                if (_ds.Tables.Count > 0)
                {
                    FileList = _ds.Tables[0];
                }
            }
            catch (Exception e)
            {
            }
            return returncode;
        }
        public long QMS_SaveQcValues_DAL(List<QcValueDetails> Analyzer)
        {
            long returncode = -1;
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.pSaveQcValuesCommand(UDT_DAL.AnalyteQcValueDetails(Analyzer), UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executig in QMS_SaveAnalyzermappingDetails_DAL", e);
            }
            return returncode;
        }

        public long QMS_LoadAnalyteForAnalyzer_DAL(long InstrumentID, DateTime dTime, long Level, out List<QcValueDetails> InstrumentList)
        {
            InstrumentList = new List<QcValueDetails>();
            long returncode = -1;
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.PgetAnalyteForAnalyzerCommand(InstrumentID, dTime, Level, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    System.Data.IDataReader IdR = dbEngine.ExecuteReader(cmd);
                    returncode = Attune.Podium.Common.Utilities.ConvertTo<QcValueDetails>(IdR, out InstrumentList);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while loading in QMS_LoadAnalyte_DAL", e);
            }
            return returncode;
        }
        public long CheckTestcode_DAL(string DeviceID, string Testcode, out string status)
        {
            long returnCode = -1;
            status = string.Empty;

            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.pCheckTestCodeCommand(Testcode, DeviceID, out status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dBEngine = new DBEngine(false))
                {
                    returnCode = dBEngine.ExecuteNonQuery(cmd);
                    status = Convert.ToString(cmd.Parameters["@pStatus"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing in CheckTestcode_DAL ", e);
            }

            return returnCode;
        }

        public long QMS_LoadDevicesAutoComplete_DAL(string Status, string prefix, out List<InvInstrumentMaster> InstrumentList)
        {
            InstrumentList = new List<InvInstrumentMaster>();
            long returncode = -1;
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.PgetDeviceInstrumentnameAutocompleteCommand(Status, prefix, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    System.Data.IDataReader IdR = dbEngine.ExecuteReader(cmd);
                    returncode = Attune.Podium.Common.Utilities.ConvertTo<InvInstrumentMaster>(IdR, out InstrumentList);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while loading in QMS_LoadDevices_DAL", e);
            }
            return returncode;
        }
    }
}
