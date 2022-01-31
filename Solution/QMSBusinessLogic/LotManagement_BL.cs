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
    public class LotManagement_BL
    {
         ContextDetails globalContextDetails;
      
        public LotManagement_BL() { 
        }
        public LotManagement_BL(ContextDetails _globalContextDetails)
        {
            globalContextDetails = _globalContextDetails;
        }
        LotManagement_DAL obj_DAL;
        public long LotVendorMaster_BL(List<LotVendorMaster> Lotvendormaster,string City)
        {
            long returncode = -1;
            try
            {
                obj_DAL = new LotManagement_DAL(globalContextDetails);
                returncode = obj_DAL.LotVendorMaster_DAL(Lotvendormaster,City);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing LotVendorMaster_BL", e);
            }
            return returncode;
        }
        public long QMS_pGetLotVendormaster_BL(out DataTable FileList)
        {
            long returncode = -1;
            obj_DAL = new LotManagement_DAL(globalContextDetails);
            FileList = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                returncode = obj_DAL.QMS_pGetLotVendormasterCommand_DAl(out FileList);
                //Utilities.ConvertTo(ds.Tables[0], out clientList);

            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing QMS_PgetAnalyzerMappingDetails_BL ", excp);
            }
            return returncode;

        }
        public long QMS_DeletelotVendormasterDetails_BL(string Activationstatus, int VendorID)
        {
            long returncode = -1;
            obj_DAL = new LotManagement_DAL(globalContextDetails);
            
            try
            {
                returncode = obj_DAL.QMS_DeletelotVendormasterDetails_DAl(Activationstatus, VendorID);
                //Utilities.ConvertTo(ds.Tables[0], out clientList);

            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing QMS_PgetAnalyzerMappingDetails_BL ", excp);
            }
            return returncode;
        }
        public long QMS_UpdateLotVendorMaster_BL(int VendorID,List<LotVendorMaster> Lotvendormaster,string city)
        {
            long returncode = -1;
            try
            {
                obj_DAL = new LotManagement_DAL(globalContextDetails);
                returncode = obj_DAL.QMS_UpdatelotVendormasterDetails_DAl(VendorID,Lotvendormaster,city);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing QMS_UpdateLotVendorMaster_BL", e);
            }
            return returncode;
        }
        public long LotManufacturerMaster_BL(List<DeviceManufacturer> LotManufacturermaster)
        {
            long returncode = -1;
            try
            {
                obj_DAL = new LotManagement_DAL(globalContextDetails);
                returncode = obj_DAL.LotManufacturerMaster_DAL(LotManufacturermaster);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing LotManufacturerMaster_BL", e);
            }
            return returncode;
        }
        public long QMS_pGetLotManufacturermaster_BL(out DataTable FileList)
        {
            long returncode = -1;
            obj_DAL = new LotManagement_DAL(globalContextDetails);
            FileList = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                returncode = obj_DAL.QMS_pGetLotManufacturermaster_DAl(out FileList);
                //Utilities.ConvertTo(ds.Tables[0], out clientList);

            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing QMS_pGetLotManufacturermaster_BL ", excp);
            }
            return returncode;

        }
        public long QMS_DeletelotManufacturermasterDetails_BL(string Activationstatus, int MacID)
        {
            long returncode = -1;
            obj_DAL = new LotManagement_DAL(globalContextDetails);

            try
            {
                returncode = obj_DAL.QMS_DeletelotManufacturermasterDetails_DAl(Activationstatus, MacID);
                //Utilities.ConvertTo(ds.Tables[0], out clientList);

            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing QMS_DeletelotManufacturermasterDetails_BL ", excp);
            }
            return returncode;
        }
        public long QMS_UpdatelotManufacturermasterDetails_BL(int MacID, List<DeviceManufacturer> Machinemanufacturer)
        {
            long returncode = -1;
            try
            {
                obj_DAL = new LotManagement_DAL(globalContextDetails);
                returncode = obj_DAL.QMS_UpdatelotManufacturermasterDetails_DAl(MacID, Machinemanufacturer);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing QMS_UpdatelotManufacturermasterDetails_BL", e);
            }
            return returncode;
        }
        public long QMS_LoadDevicesManufacturer_BL(string Status, out List<DeviceManufacturer> FileList)
        {
            long returncode = -1;
            FileList = new List<DeviceManufacturer>();
            //DataSet ds = new DataSet();
            obj_DAL = new LotManagement_DAL(globalContextDetails);
            try
            {
                returncode = obj_DAL.QMS_LoadManufacturer_DAL(Status, out FileList);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading Device in QMS_LoadDevicesManufacturer_BL", ex);
            }
            return returncode;
        }
        public long QMS_LoadVendorMaster_BL(string Status, out List<LotVendorMaster> FileList)
        {
            long returncode = -1;
            FileList = new List<LotVendorMaster>();
            //DataSet ds = new DataSet();
            obj_DAL = new LotManagement_DAL(globalContextDetails);
            try
            {
                returncode = obj_DAL.QMS_LoadVendorMaster_DAL(Status, out FileList);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading Device in QMS_LoadVendorMaster_BL", ex);
            }
            return returncode;
        }
        public long QMS_LoadAnalyteMaster_BL(string Status, out List<InvInstrumentMaster> FileList)
        {
            long returncode = -1;
            FileList = new List<InvInstrumentMaster>();
            //DataSet ds = new DataSet();
            obj_DAL = new LotManagement_DAL(globalContextDetails);
            try
            {
                returncode = obj_DAL.QMS_LoadAnalyteMaster_DAL(Status, out FileList);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading Device in QMS_LoadAnalyteMaster_BL", ex);
            }
            return returncode;
        }
        public long SaveLotManagement_BL(List<LotMaster> lotmaster, int[] InvestigationID, string[] DisplayText, string LevelID)
        {
            long returncode = -1;
            obj_DAL = new LotManagement_DAL(globalContextDetails);
            try
            {

                returncode = obj_DAL.SaveLotManagement_DAL(lotmaster, InvestigationID, DisplayText, LevelID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading Device in QMS_LoadAnalyteMaster_BL", ex);
            }
            return returncode;
        }
        public long QMS_pGetLoadLotdetailsCommand_BL(out DataTable FileList)
        {
            long returncode = -1;
            obj_DAL = new LotManagement_DAL(globalContextDetails);
            FileList = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                returncode = obj_DAL.QMS_pGetLoadLotdetailsCommand_DAl(out FileList);
                //Utilities.ConvertTo(ds.Tables[0], out clientList);

            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing QMS_pGetLoadLotdetailsCommand_BL ", excp);
            }
            return returncode;

        }
        public long UpdateLotManagement_BL(List<LotMaster> lotmaster, int[] InvestigationID, string[] DisplayText,string LevelID)
        {
            long returncode = -1;
            obj_DAL = new LotManagement_DAL(globalContextDetails);
            try
            {

                returncode = obj_DAL.UpdateLotManagement_DAL(lotmaster, InvestigationID, DisplayText,LevelID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading Device in UpdateLotManagement_BL", ex);
            }
            return returncode;
        }
        public long QMS_Deletelotmaster_BL( int LotID)
        {
            long returncode = -1;
            obj_DAL = new LotManagement_DAL(globalContextDetails);

            try
            {
                returncode = obj_DAL.QMS_DeletelotmasterDetails_DAl(LotID);
                //Utilities.ConvertTo(ds.Tables[0], out clientList);

            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing QMS_Deletelotmaster_BL ", excp);
            }
            return returncode;
        }
    }
}
