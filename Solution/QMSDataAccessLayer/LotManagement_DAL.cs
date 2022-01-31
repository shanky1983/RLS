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
    public class LotManagement_DAL
    {
        ContextDetails globalContextDetails;

        public LotManagement_DAL()
        {
        }
        public LotManagement_DAL(ContextDetails _globalContextDetails)
        {
            globalContextDetails = _globalContextDetails;
        }
        public long LotVendorMaster_DAL(List<LotVendorMaster> lotvendormaster,string city)
        {
            long returncode = -1;
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.pInsertLotVendorBaseCommand(UDT_DAL.UDT_lotvendormaster(lotvendormaster), UDT_DAL.ConvertToUDT_Context(globalContextDetails), city);
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing LotVendorMaster_DAL", e);
            }
            return returncode;
        }
        public long QMS_pGetLotVendormasterCommand_DAl(out DataTable FileList)
        {
            long returncode = -1;
            FileList = new DataTable();
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                DataSet _ds = new DataSet();
                cmd = Command.pGetLotVendormasterCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));

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
                CLogger.LogError("Error while Executing in QMS_pGetLotVendormasterCommand_DAl ", e);
            }
            return returncode;
        }
        public long QMS_DeletelotVendormasterDetails_DAl(string Activationstatus, int VendorID)
        {
            long returncode = -1;
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.pDeleteLotVendormasterCommand(Activationstatus, VendorID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing LotVendorMaster_DAL", e);
            }
            return returncode;
        }
        public long QMS_UpdatelotVendormasterDetails_DAl(int VendorID, List<LotVendorMaster> lotvendormaster,string city)
        {
            long returncode = -1;
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.pUpdateLotVendorBaseCommand(VendorID, UDT_DAL.UDT_lotvendormaster(lotvendormaster), UDT_DAL.ConvertToUDT_Context(globalContextDetails),city);
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing QMS_UpdatelotVendormasterDetails_DAl", e);
            }
            return returncode;
        }
        public long LotManufacturerMaster_DAL(List<DeviceManufacturer> lotManufacturermaster)
        {
            long returncode = -1;
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.pInsertDeviceManufacturerCommand(UDT_DAL.UDT_lotManufacturermaster(lotManufacturermaster), UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing LotManufacturerMaster_DAL", e);
            }
            return returncode;
        }
        public long QMS_pGetLotManufacturermaster_DAl(out DataTable FileList)
        {
            long returncode = -1;
            FileList = new DataTable();
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            DataSet _ds = new DataSet();
            try
            {
                cmd = Command.pGetLoadLotManufacturerdetailsCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));

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
                CLogger.LogError("Error while Executing in QMS_pGetLotVendormasterCommand_DAl ", e);
            }
            return returncode;
        }

        public long QMS_DeletelotManufacturermasterDetails_DAl(string Activationstatus, int MacID)
        {
            long returncode = -1;
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.pDeleteLotManufacturemasterCommand(Activationstatus, MacID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing QMS_DeletelotManufacturermasterDetails_DAl", e);
            }
            return returncode;
        }
        public long QMS_UpdatelotManufacturermasterDetails_DAl(int MacID, List<DeviceManufacturer> DeviceManufacturer)
        {
            long returncode = -1;
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.pUpdateLoadLotManufacturerdetailsCommand(MacID, UDT_DAL.UDT_lotManufacturermaster(DeviceManufacturer), UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing QMS_UpdatelotManufacturermasterDetails_DAl", e);
            }
            return returncode;
        }
        public long QMS_LoadManufacturer_DAL(string Status, out List<DeviceManufacturer> InstrumentList)
        {
            InstrumentList = new List<DeviceManufacturer>();
            long returncode = -1;
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.PloadlotmanagementCommand(Status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    System.Data.IDataReader IdR = dbEngine.ExecuteReader(cmd);
                    returncode = Attune.Podium.Common.Utilities.ConvertTo<DeviceManufacturer>(IdR, out InstrumentList);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while loading in QMS_LoadManufacturer_DAL", e);
            }
            return returncode;
        }
        public long QMS_LoadVendorMaster_DAL(string Status, out List<LotVendorMaster> InstrumentList)
        {
            InstrumentList = new List<LotVendorMaster>();
            long returncode = -1;
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.PloadlotmanagementCommand(Status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    System.Data.IDataReader IdR = dbEngine.ExecuteReader(cmd);
                    returncode = Attune.Podium.Common.Utilities.ConvertTo<LotVendorMaster>(IdR, out InstrumentList);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while loading in QMS_LoadVendorMaster_DAL", e);
            }
            return returncode;
        }
        public long QMS_LoadAnalyteMaster_DAL(string Status, out List<InvInstrumentMaster> InstrumentList)
        {
            InstrumentList = new List<InvInstrumentMaster>();
            long returncode = -1;
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.PloadlotmanagementCommand(Status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    System.Data.IDataReader IdR = dbEngine.ExecuteReader(cmd);
                    returncode = Attune.Podium.Common.Utilities.ConvertTo<InvInstrumentMaster>(IdR, out InstrumentList);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while loading in QMS_LoadAnalyteMaster_DAL", e);
            }
            return returncode;
        }
        public long SaveLotManagement_DAL(List<LotMaster> lotmaster, int[] InvestigationID, string[] DisplayText, string LevelID)
        {
            long returncode = -1;
            SqlCommand cmd = Command.pSaveLotManagementCommand(UDT_DAL.SaveLotManagement_DAL(lotmaster), UDT_DAL.ConvertToInvestigationID(DisplayText, InvestigationID), UDT_DAL.ConvertToUDT_Context(globalContextDetails), LevelID);

            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);

                }
                //InstrumentID = Convert.ToInt32(cmd.Parameters["@InstrumentID"].Value);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while inserting in SaveLotManagement_DAL", ex);
            }

            return returncode;
        }
        public long QMS_pGetLoadLotdetailsCommand_DAl(out DataTable FileList)
        {
            long returncode = -1;
            FileList = new DataTable();
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            DataSet _ds = new DataSet();
            try
            {
                cmd = Command.pGetLoadLotdetailsCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));

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
                CLogger.LogError("Error while Executing in QMS_pGetLoadLotdetailsCommand_DAl ", e);
            }
            return returncode;
        }
        public long UpdateLotManagement_DAL(List<LotMaster> lotmaster, int[] InvestigationID, string[] DisplayText,string LevelID)
        {
            long returncode = -1;
            SqlCommand cmd = Command.pEditLotMasterCommand(UDT_DAL.SaveLotManagement_DAL(lotmaster), UDT_DAL.ConvertToInvestigationID(DisplayText, InvestigationID), UDT_DAL.ConvertToUDT_Context(globalContextDetails),LevelID );

            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);

                }
                //InstrumentID = Convert.ToInt32(cmd.Parameters["@InstrumentID"].Value);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while inserting in UpdateLotManagement_DAL", ex);
            }

            return returncode;
        }
        public long QMS_DeletelotmasterDetails_DAl( int LotID)
        {
            long returncode = -1;
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.pDeleteLotmasterCommand(LotID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing QMS_DeletelotManufacturermasterDetails_DAl", e);
            }
            return returncode;
        }
    }
}
