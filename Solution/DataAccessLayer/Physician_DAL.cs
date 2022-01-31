using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities;
using Attune.Podium.Common;
using System.Transactions;




namespace Attune.Solution.DAL
{
    public class Physician_DAL
    {
        ContextDetails globalContextDetails;
        public Physician_DAL()
        {

        }
        public Physician_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        public long GetPhysicianOP(long lOrgID, int iPhysicianID, out List<PhysicianOPIP> lstPhysicianOPIP)
        {
            long returnCode = -1;


            SqlCommand objCommand=null;
            lstPhysicianOPIP = new List<PhysicianOPIP>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }

            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPhysicianOPIP);
            }

            return returnCode;
        }
        public long GetPhysicianList(int orgID, out List<Physician> lstPhysician)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.PGetPhysiciannameCommand(orgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstPhysician = new List<Physician>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPhysician);
            }
            return returnCode;
        }

        # region Case Sheet

        public long GetCaseSheetData(long patientID, long patientVisitID, out List<Patient> lstP, out List<Complaint> lstC, out List<Investigation> lstI, out List<Examination> lstE, out List<History> lstH)
        {
            long returnCode = -1;

            lstP = new List<Patient>();
            returnCode = GetCaseSheetPatient(patientID, out lstP);

            lstE = new List<Examination>();
            returnCode = GetCaseSheetExamination(patientVisitID, out lstE);

            lstI = new List<Investigation>();
            returnCode = GetCaseSheetInvestigation(patientVisitID, out lstI);

            lstC = new List<Complaint>();
            returnCode = GetCaseSheetComplaint(patientVisitID, out lstC);

            lstH = new List<History>();
            returnCode = GetCaseSheetHistory(patientVisitID, out lstH);

            return returnCode;
        }
 
        private long GetCaseSheetPatient(long patientID, out List<Patient> lstPatient)
        {
            long returnCode = -1;

            SqlCommand objCommand = Command.pGetCaseSheetPatientCommand(patientID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstPatient = new List<Patient>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }

            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatient);
            }

            return returnCode;
        }

        private long GetCaseSheetComplaint(long patientVisitID, out List<Complaint> lstComplaint)
        {
            long returnCode = -1;

            SqlCommand objCommand = Command.pGetCaseSheetComplaintCommand(patientVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstComplaint = new List<Complaint>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }

            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstComplaint);
            }
            return returnCode;
        }

        private long GetCaseSheetExamination(long patientVisitID, out List<Examination> lstExamination)
        {
            long returnCode = -1;

            SqlCommand objCommand = Command.pGetCaseSheetExaminationCommand(patientVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstExamination = new List<Examination>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }

            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstExamination);
            }

            return returnCode;
        }

        private long GetCaseSheetInvestigation(long patientVisitID, out List<Investigation> lstInvestigation)
        {
            long returnCode = -1;

            SqlCommand objCommand = Command.pGetCaseSheetInvestigationCommand(patientVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstInvestigation = new List<Investigation>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }


            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvestigation);
            }

            return returnCode;
        }

        private long GetCaseSheetHistory(long patientVisitID, out List<History> lstHistory)
        {
            long returnCode = -1;

            SqlCommand objCommand = Command.pGetCaseSheetHistoryCommand(patientVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstHistory = new List<History>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }


            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstHistory);
            }

            return returnCode;
        }

        public long GetPatientPrescription(long iPatientVisitID, out List<DrugDetails> lstDrugDetails)
        {
            long returnCode = -1;

            SqlCommand objCommand = Command.pGetPatientPrescriptionCommand(iPatientVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstDrugDetails = new List<DrugDetails>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }

            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDrugDetails);
            }

            return returnCode;
        }

        public long GetPhysicianListByOrg(int orgID, out List<Physician> lstPhysician, int ivisitID)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetPhysicianListByOrgCommand(orgID,ivisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            
            lstPhysician = new List<Physician>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }

            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPhysician);
            }

            return returnCode;
        }
        #endregion

        #region Registration
        public long GetPhysicians(int OrgID,string phyType,out List<PhysicianSchedule> phySchedules)
        {
            long returnCode = -1;
            DataSet ds = new DataSet();
            phySchedules = new List<PhysicianSchedule>();
            SqlCommand cmd = Command.pGetPhysiciansCommand(OrgID, phyType,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dBengine = new DBEngine())           
            {dBengine.ExecuteDataSet(cmd,out ds);}
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out phySchedules);
            }
            return returnCode;
        }
        #endregion

        public long SavePhysicians(Physician Physicians, List<AdminInvestigationRate> lstAdminRate)
        {
            long lresult = -1;
            int addressCount = Physicians.Address.Count;
            SqlCommand[] cmdInsertAddress = new SqlCommand[addressCount];
            long addressID = 0;
            int PhysicianID = 0;
            int i;
            DataTable DtInvRate = UDT_DAL.ConvertToInvestigationAdminRate(lstAdminRate);
            SqlCommand cmdInsertPhysician = Command.pInsertPhysicianCommand(Physicians.PhysicianName, Physicians.Email, Physicians.CreatedBy, Physicians.Sex, Physicians.LoginID, Physicians.WeddingDt, Physicians.TitleCode, Physicians.DOB, Physicians.Relegion, Physicians.MaritalStatus, Physicians.Qualification, Physicians.OrgID,Physicians.PhysicianType,Physicians.RegNumber, DtInvRate, out PhysicianID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdInsertPhysician.Parameters.Add("@Return", SqlDbType.Int);
            cmdInsertPhysician.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            for (i = 0; i < addressCount; i++)
            {
                cmdInsertAddress[i] = Command.pInsertPhysicianAddressCommand(PhysicianID, Physicians.Address[i].AddressType, Physicians.Address[i].Add1, Physicians.Address[i].Add2, Physicians.Address[i].Add3, Physicians.Address[i].PostalCode, Physicians.Address[i].CountryID, Physicians.Address[i].City, Physicians.Address[i].StateID, Physicians.Address[i].MobileNumber,
                                                    Physicians.Address[i].LandLineNumber, Physicians.Address[i].CreatedBy, Physicians.Address[i].OtherCountryName, Physicians.Address[i].OtherStateName, out addressID, UDT_DAL.ConvertToUDT_Context(globalContextDetails), Physicians.Address[i].CountryCode, Physicians.Address[i].StateCode, Physicians.Address[i].CityCode, Physicians.Address[i].AddLevel1, Physicians.Address[i].AddLevel2);
            }

            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteTransactionalNonQuery(cmdInsertPhysician);
                        lresult = Convert.ToInt64(cmdInsertPhysician.Parameters["@Return"].Value);
                        if (lresult == 0)
                        {
                            PhysicianID = Convert.ToInt32(cmdInsertPhysician.Parameters["@pPhysicianID"].Value);
                            Physicians.PhysicianID = PhysicianID;
                            for (i = 0; i < addressCount; i++)
                            {
                                cmdInsertAddress[i].Parameters["@pPhysicianID"].Value = PhysicianID;
                                dbEngine.ExecuteTransactionalNonQuery(cmdInsertAddress[i]);
                            }
                        }
                    }

                    tranScope.Complete();
                }
                catch (Exception ex)
                {
                    CLogger.LogError("Error while saving . Query: " + cmdInsertPhysician.CommandText, ex);

                    tranScope.Dispose();
                }
            }
            return lresult;


        }

        public long SavePhysicianSpeciality(PhysicianSpeciality PhySpeciality)
        {
            long lresult = -1;
            SqlCommand cmd = Command.pInsertPhysicianSpecialityCommand(PhySpeciality.PhysicianID, PhySpeciality.SpecialityID, PhySpeciality.CreatedBy, PhySpeciality.ModifiedBy, PhySpeciality.PhysicianSpecialityID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing savePhysicianSpeciality" + cmd.CommandText, ex);
            }

            return lresult;

        }
        //Changes of DataSet To DataReader Made By Arivalagan.k
        public long GetCashExpenseByOrg(int orgID, out List<CashExpenseMaster> lstCashExpense)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstCashExpense = new List<CashExpenseMaster>();
            try
            {
                SqlCommand cmd = Command.pGetCashExpenseListByOrgCommand(orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstCashExpense);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetPerformingAction", ex);
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

        public long GetAllPhysicianSchedules(int iorgID, int iResourceID,string iResourceType, out List<AllPhysicianSchedules> lstPhysicianSchedules)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetAllPhysicianSchedulesCommand(iorgID,iResourceID,iResourceType,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstPhysicianSchedules = new List<AllPhysicianSchedules>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPhysicianSchedules);
            }
            return returnCode;
        }

        public long UpdatePhysicianSpeciality(int phID, List<Speciality> PhySpeciality)
        {
            long lresult = -1;
            DataTable dtSpl = new DataTable();
            dtSpl = UDT_DAL.ConvertToGetOrgIDs(PhySpeciality);
            SqlCommand cmd = Command.pUpdatePhysicianSpecialityCommand(phID, dtSpl,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdatePhysicianSpeciality" + cmd.CommandText, ex);
            }

            return lresult;

        }

        
        public long PerfomingPhysician(string perphyname, string phyQuly, long lOrgID)
        {
            long lresult = -1;
            DataTable dtSpl = new DataTable();
            SqlCommand cmd = Command.pIDAUPerformingPhysicianCommand(0,perphyname, phyQuly, lOrgID,"Insert",UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing insertPerfomingPhysician" + cmd.CommandText, ex);
            }

            return lresult;

        }
        public long Getperformingphysician(int OrgID, out List<PerformingPhysician> lstperphysician)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pGetPerformingPhysicianCommand(OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                lstperphysician = new List<PerformingPhysician>();
                DataSet ds = new DataSet();

                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstperphysician);
                }
            return returnCode;

        }
        public long Deleteperformingphysician(int physicianid, string perphyname, int OrgID)
        {
            long returnCode = -1;

            try
            {
                SqlCommand cmd = Command.pIDAUPerformingPhysicianCommand(physicianid, perphyname,"", OrgID,"Delete",UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dBEngine = new DBEngine())
                {
                    returnCode = dBEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL Deleteperformingphysician", ex);
            }
            return returnCode;
        }
        public long Activeperformingphysician(int physicianid, string perphyname, int OrgID)
        {
            long returnCode = -1;

            try
            {
                SqlCommand cmd = Command.pIDAUPerformingPhysicianCommand(physicianid, perphyname,"", OrgID,"Active",UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dBEngine = new DBEngine())
                {
                    returnCode = dBEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL Activeperformingphysician", ex);
            }
            return returnCode;
        }
        public long GetReferingphysician(int OrgID, out List<ReferingPhysician> lstRefphysician)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pGetReferphysicianCommand(OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstRefphysician = new List<ReferingPhysician>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstRefphysician);
            }
            return returnCode;
        }
        public long Updateperformingphysician(int physicianid, string perphyname,string Qulification,int OrgID)
        {
            long returnCode = -1;

            try
            {
                SqlCommand cmd = Command.pIDAUPerformingPhysicianCommand(physicianid, perphyname, Qulification, OrgID,"Update",UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dBEngine = new DBEngine())
                {
                    returnCode = dBEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL Activeperformingphysician", ex);
            }
            return returnCode;
        }
        public long SaveRefPhyRateMapping(List<PCClientMapping> lstphyMap, List<PCClientMapping> lstDeletedphyMap)
        {
            long lresult = -1;
            DataTable DtphyMap = UDT_DAL.ConvertToUDTPCClientMapping(lstphyMap);
            DataTable DttDeletedphyMap = UDT_DAL.ConvertToUDTPCClientMapping(lstDeletedphyMap);
            SqlCommand cmd = Command.pSaveRefPhyRateMappingCommand(DtphyMap, DttDeletedphyMap,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    lresult = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Saving RefPhyRateMapping" + cmd.CommandText, ex);
            }

            return lresult;

        }

        public long GetPhysicianNameByOrg(int orgID,string prefixtext, out List<Physician> lstPhysician, int ivisitID)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetPhysicianNameByOrgCommand(orgID,prefixtext,ivisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstPhysician = new List<Physician>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }

            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPhysician);
            }

            return returnCode;
        }

        // changed dataset to datareader by Arivalagan.k
        public long GetInvestigationHistoryDetail(long pPatientID, long pVisitId, long InvID, int OrgID, string TypeValue, out List<InvMedicalDetailsMapping> lstInvMedicalDetailsMapping, out List<InvMedicalDetailsMapping> lstInvestigationMappingList)
        {
            long returnCode = -1;
            int rsCount=0;
            lstInvMedicalDetailsMapping = new List<InvMedicalDetailsMapping>();
            lstInvestigationMappingList = new List<InvMedicalDetailsMapping>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetEMRInvestigationHistoryCommand(pPatientID, pVisitId, InvID, TypeValue, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                     dataReader = dbEngine.ExecuteReader(cmd);
                     if (dataReader != null)
                     {
                         do
                         {
                             if (rsCount == 0)
                             {
                                 returnCode = Utilities.ConvertTo(dataReader, out lstInvMedicalDetailsMapping);
                             }
                             else if (rsCount == 1)
                             {
                                 returnCode = Utilities.ConvertTo(dataReader, out lstInvestigationMappingList);
                             }

                             rsCount = rsCount + 1;
                         } while (dataReader.NextResult());
                         dataReader.Close();
                     }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  Physician_DAL GetInvestigationHistoryDetail ", ex);
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
        // changed dataset to datareader by Arivalagan.k
        public long GetInvestigationHistoryMapping(int orgID, long VisitID, long PatientID, long InvID, string InvestigationList, out List<InvHistoryAttributes> lstInvHistoryAttributes)
        {
            long returnCode = -1;
            lstInvHistoryAttributes = new List<InvHistoryAttributes>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetInvestigationHistoryMappingCommand(orgID, VisitID, PatientID, InvID, InvestigationList,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvHistoryAttributes);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  lstInvMedicalDetailsMapping DAL", ex);
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

        public long Inserthubname(Localities pLOCAL)
        {

            long returnCode = -1;
            SqlCommand cmd = Command.pInserthubnameCommand(pLOCAL.OrgID, pLOCAL.Locality_ID, pLOCAL.Locality_Code, pLOCAL.Locality_Value, pLOCAL.Type);
            cmd.Parameters.Add("@RET", SqlDbType.Int);
            cmd.Parameters["@RET"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@RET"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Saving Inserthubname" + cmd.CommandText, ex);
            }

            return returnCode;

        }

        //Changes of DataSet To DataReader Made By Arivalagagan.k
        public long GetLocalitiesHub(int orgid, out List<Localities> LOC)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            LOC = new List<Localities>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetLocalitiesHubCommand(orgid);
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out LOC);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetLocalities in PhysicianDAL", ex);
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

        // changed dataset to datareader by Arivalagan.k
        public long GetsearchHub(int Orgid, string hubcode, out List<Localities> local)
        {
            long returnCode = -1;
            local = new List<Localities>();
             IDataReader dataReader = null;
             SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.pGetsearchHubCommand(Orgid,hubcode);
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out local);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetsearchHub", ex);
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

        public long Insertzonename(string maphubvalue, Localities LOCAL)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pInsertzonenameCommand(LOCAL.OrgID, maphubvalue, LOCAL.Locality_ID, LOCAL.Locality_Code, LOCAL.Locality_Value, LOCAL.Type, LOCAL.ParentID);
            cmd.Parameters.Add("@RET", SqlDbType.Int);
            cmd.Parameters["@RET"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@RET"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Saving zonename" + cmd.CommandText, ex);
            }

            return returnCode;

        }

        //Changes of DataSet To DataReader Made By Arivalagan.k
        public long GetLocalitiesZone(int orgid, out List<Localities> LOC)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            LOC = new List<Localities>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetLocalitiesDetailCommand(orgid);
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out LOC);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetLocalities", ex);
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


        public long Insertroutename(string mapzonevalue, Localities LOCAL)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pInsertroutenameCommand(LOCAL.OrgID, mapzonevalue, LOCAL.Locality_ID, LOCAL.Locality_Code, LOCAL.Locality_Value, LOCAL.Type, LOCAL.ParentID);
            cmd.Parameters.Add("@RET", SqlDbType.Int);
            cmd.Parameters["@RET"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@RET"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Saving routename" + cmd.CommandText, ex);
            }

            return returnCode;

        }

        //Changes of DataSet To DataReader Made By Arivalagan.k
        public long GetLocalitiesRoute(int OrgID, out List<Localities> LOC)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            LOC = new List<Localities>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetLocalitiesRouteCommand(OrgID);
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out LOC);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetLocalitiesRoute", ex);
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
        // changed dataset to datareader by Arivalagan.k
        public long Getsearchzone(int Orgid, string zonecode, out List<Localities> local)
        {
            long returnCode = -1;
            local = new List<Localities>();
            SqlCommand cmd = new SqlCommand();
            IDataReader dataReader = null;
            try
            {
               cmd = Command.pGetsearchzoneCommand(Orgid,zonecode);
               using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out local);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL Getsearchzone", ex);
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
        // changed dataset to datareader by Arivalagan.k
        public long Getsearchroute(int Orgid, string routecode, out List<Localities> local)
        {
            long returnCode = -1;
            local = new List<Localities>();
            SqlCommand cmd = new SqlCommand();
            IDataReader dataReader = null;
            try
            {
                cmd = Command.pGetsearchrouteCommand(Orgid, routecode);
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out local);
                        dataReader.Close();
                    }
                }
           }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Physician_DAL Getsearchroute", ex);
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

    }
}
