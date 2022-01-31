using System;
using System.Data;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities;
using System.Configuration;
using System.Web;
using System.Collections;
using System.Collections.Generic;
using Attune.Podium.Common;
using System.Transactions;

namespace Attune.Solution.DAL
{
    public class SurgeryPackage_DAL
    {
        ContextDetails globalContextDetails;
        public SurgeryPackage_DAL()
        {
            
        }
        public SurgeryPackage_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetSurgeryPackage(int orgID, long pVisitID, out List<SurgeryPackageItems> lstSurgeryPackageItems, out List<SurgeryPackageItems> lstSelectedSurgeryPKG)
        {
            long returnCode = -1;
            lstSurgeryPackageItems = new List<SurgeryPackageItems>();
            lstSelectedSurgeryPKG = new List<SurgeryPackageItems>();
            try
            {
                SqlCommand cmd = Command.pGetSurgeryPackageCommand(orgID, pVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstSurgeryPackageItems);
                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[1], out lstSelectedSurgeryPKG);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while get procedure name, GetSurgeryPackage sp", ex);

            }
            return returnCode;
        }


        public long GetOrderedSurgeryPkg(long PackageID, long pVisitID, out List<SurgeryPackageItems> lstSurgeryPackageItems, out List<SurgeryPackageItems> lstSelectedSurgeryPKG)
        {
            long returnCode = -1;
            lstSurgeryPackageItems = new List<SurgeryPackageItems>();
            lstSelectedSurgeryPKG = new List<SurgeryPackageItems>();
            try
            {
                SqlCommand cmd = Command.pGetOrderedSurgeryPkgCommand(PackageID, pVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstSurgeryPackageItems);
                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[1], out lstSelectedSurgeryPKG);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while get procedure name, GetSurgeryPackage sp", ex);

            }
            return returnCode;
        }

        public long UpdateSurgerypkgDate(long VisitID, long PackageID, DateTime FromDate, DateTime Todate)
        {


            
            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pUpdateSurgerypkgDateCommand(VisitID, PackageID, FromDate, Todate,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteTransactionalNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);

            }

            return returnCode;
        }





        public long SaveSurgeryPkgInTracker(long VisitID, long PatientID,
            long LID, int ILocationID, SurgeryPackageItems objSPI, 
            string @pType,OrderedInvestigations objInvest, string gUID)
        {


            DataTable dtOrderinv = UDT_DAL.ConvertToOrderedInvestigation (objInvest);
            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pSaveSurgeryPkgInTrackerCommand(objSPI.PackageDetailsID, objSPI.PackageID,
									VisitID, PatientID, ILocationID,
									objSPI.DrugID, objSPI.Quantity, objSPI.BatchNumber,
									objSPI.ExpiryDate, objSPI.OrderedDate, LID,
									                                                          @pType, objSPI.Feetype, dtOrderinv, gUID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteTransactionalNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);

            }

            return returnCode;
        }
     


        public long GetSurgeryPkgItemDetail(long VisitID, long PkgDetailID, long PkgID, out List<SurgeryPackageItems> lstSurgeryPackageItems)
        {
            long returnCode = -1;
            lstSurgeryPackageItems = new List<SurgeryPackageItems>();
          
            try
            {
                SqlCommand cmd = Command.pGetSurgeryPkgItemDetailCommand(VisitID, PkgDetailID, PkgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstSurgeryPackageItems);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while get procedure name, GetSurgeryPkgItemDetail sp", ex);

            }
            return returnCode;
        }


        public long UpdateSurgeryPkgTrackerQty(long TrackerID, long VisitID, decimal UpdateQty, DateTime OrderedDate)
        {           
            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pUpdateSurgeryPkgTrackerQtyCommand(TrackerID, VisitID, UpdateQty, OrderedDate,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteTransactionalNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);

            }

            return returnCode;
        }


        public long SaveSurgeryMaster(List<SurgeryPackageMaster> lstpackage)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pInsertSurgeryPackageCommand(lstpackage[0].PackageID, lstpackage[0].PackageName, lstpackage[0].Amount,
									                    lstpackage[0].OrgID, lstpackage[0].PackageDays, lstpackage[0].NoFreeConsBefore, lstpackage[0].NoFreeConsAfter, lstpackage[0].FreeConsValidity, lstpackage[0].CreatedBy,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while save surgeryMaster DAL", ex);
            }
            return returnCode;
        }

        public long GetSurgeryMaster(int pOrgID, out List<SurgeryPackageMaster> lstpackage)
        {

            long lresult = -1;
            lstpackage = new List<SurgeryPackageMaster>();
            SqlCommand cmd = Command.pGetSurgeryMasterCommand(pOrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        lresult = Utilities.ConvertTo(ds.Tables[0], out lstpackage);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing Load Surgery Master DAL" + cmd.CommandText, ex);
            }
            return lresult;
        }

        public long GetSurgeryDetails(int pOrgID, out List<SurgeryPackageMaster> lstSurgery, out List<SurgeryPackageDetails> lstSurgeryMapping, out List<SurgeryPackageDetails> lstSurgeryDtls)
        {

            long lresult = -1;
            lstSurgery = new List<SurgeryPackageMaster>();
            lstSurgeryMapping = new List<SurgeryPackageDetails>();
            lstSurgeryDtls = new List<SurgeryPackageDetails>();
            SqlCommand cmd = Command.pGetSurgeryPackageDataCommand(pOrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        lresult = Utilities.ConvertTo(ds.Tables[0], out lstSurgery);
                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        lresult = Utilities.ConvertTo(ds.Tables[1], out lstSurgeryMapping);
                    }
                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        lresult = Utilities.ConvertTo(ds.Tables[2], out lstSurgeryDtls);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing Load Surgery Master DAL" + cmd.CommandText, ex);
            }
            return lresult;

        }
        public long GetDataList(int pOrgID, out List<AdminInvestigationRate> lstMedicalIndent, out List<Speciality> lstSpeciality, out List<Ambulancedetails> lstambulance, out List<ProcedureMaster> lstprocedure, out List<RoomType> lstroomtype, out List<IPTreatmentPlanMaster> lstIPTPM)
        {

            long lresult = -1;
            lstMedicalIndent = new List<AdminInvestigationRate>();
            lstSpeciality = new List<Speciality>();
            lstambulance = new List<Ambulancedetails>();
            lstprocedure = new List<ProcedureMaster>();
            lstroomtype = new List<RoomType>();
            lstIPTPM = new List<IPTreatmentPlanMaster>();
            SqlCommand cmd = Command.pGetListDataCommand(pOrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        lresult = Utilities.ConvertTo(ds.Tables[0], out lstMedicalIndent);
                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        lresult = Utilities.ConvertTo(ds.Tables[1], out lstSpeciality);
                    }
                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        lresult = Utilities.ConvertTo(ds.Tables[2], out lstambulance);
                    }
                    if (ds.Tables[3].Rows.Count > 0)
                    {
                        lresult = Utilities.ConvertTo(ds.Tables[3], out lstprocedure);
                    }
                    if (ds.Tables[4].Rows.Count > 0)
                    {
                        lresult = Utilities.ConvertTo(ds.Tables[4], out lstroomtype);
                    }
                    if (ds.Tables[5].Rows.Count > 0)
                    {
                        lresult = Utilities.ConvertTo(ds.Tables[5], out lstIPTPM);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing Load Surgery Master DAL" + cmd.CommandText, ex);
            }
            return lresult;

        }
        public long DeleteSurgeryMaster(long packageid, int orgid)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd = Command.pDeleteSurgeryMasterCommand(packageid, orgid,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Deleting surgeryMaster DAL", ex);
            }
            return returnCode;
        }

        public long UpdatePackageContent(List<SurgeryPackageDetails> lstInvPackageMapping, List<SurgeryPackageDetails> lstDeletedPackageMapping, int OrgID, long createdBY)
        {
            long retCode = -1;
          
            DataTable invPMDT = UDT_DAL .ConvertToUDTSurgeryPackageMapping (lstInvPackageMapping);
            DataTable inv = UDT_DAL .ConvertToUDTSurgeryPackageDeleting (lstDeletedPackageMapping);
            SqlCommand cmdInvestigation = new SqlCommand();
            cmdInvestigation = Command.pUpdateSurgeryPackageCommand(invPMDT, inv, OrgID, createdBY, out retCode,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmdInvestigation);
                    retCode = Convert.ToInt32(cmdInvestigation.Parameters["@returnstatus"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing UpdatePackageContent in Surgery_DAL", e);
            }
            return retCode;
        }

        public long GetSurgeryList(int pOrgID,out List<IPTreatmentPlanMaster> lstSurgery)
        {

            long lresult = -1;
            lstSurgery = new List<IPTreatmentPlanMaster>();

            SqlCommand cmd = Command.pGetSurgeryListCommand(pOrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        lresult = Utilities.ConvertTo(ds.Tables[0], out lstSurgery);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing Load Surgery Master(GetSurgeryMaster) DAL" + cmd.CommandText, ex);
            }
            return lresult;

        }


      

        public long SaveSurgeryMaster(List<IPTreatmentPlanMaster> lstIPTreatPlan)
        {
            long returnCode = -1;
            int retValue = -1;

            DataTable dtSurgery = UDT_DAL .ConvertToUDTIPTreatmentPlanMaster (lstIPTreatPlan);
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pInsertSurgeryMasterCommand(dtSurgery, out retValue,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dBEngine = new DBEngine(false))
                {

                    dBEngine.ExecuteTransactionalNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@returnStatus"].Value);
                }
            }
            catch (Exception er)
            {
                CLogger.LogError("Error while executing SaveSurgeryMaster SurgeryPackage_DAL", er);
            }
            return returnCode;
        }



    }


}
