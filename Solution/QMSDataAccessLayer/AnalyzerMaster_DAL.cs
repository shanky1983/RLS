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
    public class AnalyzerMaster_DAL
    {
        ContextDetails globalContextDetails;

        public AnalyzerMaster_DAL()
        {
        }
        public AnalyzerMaster_DAL(ContextDetails _globalContextDetails)
        {
            globalContextDetails = _globalContextDetails;
        }
        public long InvInstrumentMaster_DAL(int roleID, int orgID, List<InvInstrumentMaster> SaveAnalyzer, string MaintenanceDoneDate, string MaintenanceDueDate, string CalibrationDoneDate, string CalibrationDueDate, string[] deptID, out int InstrumentID)
        {
            long returncode = -1;
            DataTable dt = UDT_DAL.ConvertToAnalyzerMaster(SaveAnalyzer);
            SqlCommand cmd = Command.pSaveInvInstrumentMasterCommand(orgID, roleID, dt, UDT_DAL.ConvertToUDT_Context(globalContextDetails), MaintenanceDoneDate, MaintenanceDueDate, CalibrationDoneDate, CalibrationDueDate, UDT_DAL.ConvertToDeptID(deptID), out InstrumentID);
                
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                    
                }
                InstrumentID = Convert.ToInt32(cmd.Parameters["@InstrumentID"].Value);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while inserting in InvInstrumentMaster_DAL", ex);
            }

            return returncode;
        }
        public long UpdateFilepath(long instrumentid, string Filepath)
        {
            long returncode = -1;
            try
            {
                SqlCommand cmd = Command.pUpdateFilepathCommand(instrumentid, Filepath, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
             
                using (DBEngine db = new DBEngine())
                {
                    returncode = db.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while updating Filepath", ex);
            }
            return returncode;
        }
        public long QMS_DeleteInstrumentMaster_DAL(int ID)
        {
            long returncode = -1;
            try
            {
                SqlCommand cmd = Command.pUpdateInvInstrumentMasterCommand(ID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while deleting in QMS_DeleteInstrumentMaster_DAL ", ex);
            }
            return returncode;
        }
        public long QMS_EditInstrumentMaster_DAL(int roleID, int orgID, List<InvInstrumentMaster> SaveAnalyzer, string MaintenanceDoneDate, string MaintenanceDueDate, string CalibrationDoneDate, string CalibrationDueDate, string[] deptID)
        {
            long returncode = -1;
            try
            {
                DataTable dt = UDT_DAL.ConvertToAnalyzerMaster(SaveAnalyzer);
                SqlCommand cmd = Command.pEditInstrumentMasterCommand(orgID, roleID, dt, UDT_DAL.ConvertToUDT_Context(globalContextDetails), MaintenanceDoneDate, MaintenanceDueDate, CalibrationDoneDate, CalibrationDueDate, UDT_DAL.ConvertToDeptID(deptID));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while deleting in QMS_DeleteInstrumentMaster_DAL ", ex);
            }
            return returncode;
        }
        public long LoadAnalyzerMaster(out DataTable FileList)
        {
            FileList = new DataTable();
            DataSet ds = new DataSet();
            long returncode = -1;

            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.pLoadAnalyzerCommandCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));

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
        public long LoadInvPrincipleMaster_DAL(out List<InvPrincipleMaster> PrincipleList, out List<InvestigationMethod> lstinvmethod, out List<InvDeptMaster> lstinvdept, out List<OrganizationAddress> lstOrgAddress, out List<DeviceManufacturer> lstdevmanufacture, out List<LotVendorMaster> lstvendor)
        {
            PrincipleList = new List<InvPrincipleMaster>();
            lstOrgAddress = new List<OrganizationAddress>();
            lstdevmanufacture = new List<DeviceManufacturer>();
            lstinvmethod = new List<InvestigationMethod>();
            lstinvdept = new List<InvDeptMaster>();
            lstvendor = new List<LotVendorMaster>();
            DataSet ds = new DataSet();
            long returncode = -1;
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.PloadddlprinciplemasterCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    // System.Data.IDataReader IdR = dbEngine.ExecuteReader(cmd);
                    // returncode = Attune.Podium.Common.Utilities.ConvertTo<InvPrincipleMaster>(IdR, out PrincipleList);
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out PrincipleList);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[1], out lstinvmethod);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[2], out lstinvdept);
                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[3], out lstOrgAddress);
                }
                if (ds.Tables[4].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[4], out lstdevmanufacture);
                }
                if (ds.Tables[5].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[5], out lstvendor);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while loading in LoadInvPrincipleMaster_DAL", e);
            }
            return returncode;
        }
        
        public long CheckDeviceID_DAL( string DeviceID, out string status)
        {
            long returnCode = -1;
            status = string.Empty;

            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.pCheckDeviceCodeCommand(DeviceID, out status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dBEngine = new DBEngine(false))
                {
                    returnCode = dBEngine.ExecuteNonQuery(cmd);
                    status = cmd.Parameters["@pStatus"].Value.ToString();
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing in CheckDeviceID_DAL ", e);
            }

            return returnCode;
        }
       

    }
}
