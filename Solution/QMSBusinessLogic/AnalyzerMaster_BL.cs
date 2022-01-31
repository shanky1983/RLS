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
    public class AnalyzerMaster_BL
    {
        ContextDetails globalContextDetails;
      
        public AnalyzerMaster_BL() { 
        }
        public AnalyzerMaster_BL(ContextDetails _globalContextDetails)
        {
            globalContextDetails = _globalContextDetails;
        }
        AnalyzerMaster_DAL Obj_DAL;
        public long InvInstrumentMaster_BL(int roleID,int orgID,List<InvInstrumentMaster> SaveAnalyzer,string MaintenanceDoneDate,string MaintenanceDueDate,string CalibrationDoneDate,string CalibrationDueDate,string[] DeptID,out int InstrumentID)
        {
            long returncode = -1;
            InstrumentID = -1;
            try
            {
                Obj_DAL = new Attune.Solution.QMSDataAccessLayer.AnalyzerMaster_DAL(globalContextDetails);
                returncode = Obj_DAL.InvInstrumentMaster_DAL(roleID, orgID, SaveAnalyzer, MaintenanceDoneDate, MaintenanceDueDate,CalibrationDoneDate,CalibrationDueDate,DeptID,out InstrumentID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while inserting in InvInstrumentMaster_BL", ex);
            }
            return returncode;
        }
        public long UpdateFilepath(long instrumentID, string Filepath)
        {
            long returncode = -1;
            try
            {
                Obj_DAL=new AnalyzerMaster_DAL(globalContextDetails);
                returncode=Obj_DAL.UpdateFilepath(instrumentID,Filepath);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while updating Filepath", ex);
            }
            return returncode;
        }
        public long QMS_DeleteInstrumentMaster_BL(int ID)
        {
            long returncode = -1;
            try
            {
                Obj_DAL = new AnalyzerMaster_DAL(globalContextDetails);
                returncode = Obj_DAL.QMS_DeleteInstrumentMaster_DAL(ID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while inserting in QMS_DeleteInstrumentMaster_BL ", ex);
            }
            return returncode;
        }
        public long QMS_EditInstrumentMaster_BL(int roleID, int orgID, List<InvInstrumentMaster> SaveAnalyzer, string MaintenanceDoneDate, string MaintenanceDueDate, string CalibrationDoneDate, string CalibrationDueDate, string[] DeptID)
        {
            long returncode = -1;
            try
            {
                Obj_DAL = new AnalyzerMaster_DAL(globalContextDetails);
                returncode = Obj_DAL.QMS_EditInstrumentMaster_DAL(roleID, orgID, SaveAnalyzer, MaintenanceDoneDate, MaintenanceDueDate, CalibrationDoneDate, CalibrationDueDate, DeptID);
            }
            catch(Exception ex)
            {
                CLogger.LogError("Error while inserting in QMS_EditInstrumentMaster_BL ", ex);
            }
            return returncode;
        }
        public long LoadAnalyzerMaster(out DataTable FileList)
        {
            long returncode = -1;
            AnalyzerMaster_DAL Obj_DAL = new AnalyzerMaster_DAL(globalContextDetails);
            FileList = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                returncode = Obj_DAL.LoadAnalyzerMaster(out FileList);
                //Utilities.ConvertTo(ds.Tables[0], out clientList);

            }
            catch (Exception excp)
            {
                CLogger.LogError("Error while executing CreateNewClient BL", excp);
            }
            return returncode;

        }
        public long LoadInvPrincipleMaster_BL(out List<InvPrincipleMaster> PrincipleList, out List<InvestigationMethod> lstinvmethod, out List<InvDeptMaster> lstinvdept, out List<OrganizationAddress> lstOrgAddress, out List<DeviceManufacturer> lstdevmanufacture, out List<LotVendorMaster> lstvendor)
        {
            PrincipleList = new List<InvPrincipleMaster>();
            lstOrgAddress = new List<OrganizationAddress>();
            lstdevmanufacture = new List<DeviceManufacturer>();
            lstinvdept = new List<InvDeptMaster>();
            lstinvmethod = new List<InvestigationMethod>();
            lstvendor = new List<LotVendorMaster>();
            long returncode = -1;
            try
            {
                Obj_DAL = new AnalyzerMaster_DAL(globalContextDetails);
                returncode = Obj_DAL.LoadInvPrincipleMaster_DAL(out PrincipleList, out lstinvmethod, out lstinvdept, out lstOrgAddress, out lstdevmanufacture, out lstvendor);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while Loading for LoadInvPrincipleMaster_BL", e);
            }
            return returncode;
        }
        public long CheckDeviceID( string DeviceID, out string status)
        {
            long returnCode = -1;
            status = string.Empty;
            try
            {

                Obj_DAL = new AnalyzerMaster_DAL(globalContextDetails);
                returnCode = Obj_DAL.CheckDeviceID_DAL(DeviceID, out status);
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while Checking for CheckDeviceID_BL ", e);
            }

            return returnCode;
        }
       
    }
}
