using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities;
using System.Collections.Generic;
using Attune.Podium.Common;
using System.Data.Common;
using System.Transactions;

namespace Attune.Solution.DAL
{
    public class ANC_DAL
    {
        ContextDetails globalContextDetails;
        public ANC_DAL()
        {

        }
        public ANC_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetPregnancyComplication(int SpecialityID, out List<Complication> lstComplication)
        {
            long lresult = -1;
            lstComplication = new List<Complication>();
            SqlCommand cmd = Command.pGetPregnancyComplicationCommand(SpecialityID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {

                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        lresult = Utilities.ConvertTo(ds.Tables[0], out lstComplication);
                    }
                }
            }

            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPregnancyComplication DAL" + cmd.CommandText, ex);
            }
            return lresult;
        }

        public long GetPriorVaccination(out List<Vaccination> lstVaccination)
        {
            long lresult = -1;
            lstVaccination = new List<Vaccination>();
            SqlCommand cmd = Command.pGetPriorVaccinationCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {

                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        lresult = Utilities.ConvertTo(ds.Tables[0], out lstVaccination);
                    }
                }
            }

            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPriorVaccination DAL" + cmd.CommandText, ex);
            }
            return lresult;
        }

        public long GetModeOfDelivery(out List<ModeOfDelivery> lstMOd)
        {
            long lresult = -1;
            lstMOd = new List<ModeOfDelivery>();
            SqlCommand cmd = Command.pGetModeOfDeliveryCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {

                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        lresult = Utilities.ConvertTo(ds.Tables[0], out lstMOd);
                    }
                }
            }

            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetModeOfDelivery DAL" + cmd.CommandText, ex);
            }
            return lresult;
        }
        public long GetBirthMaturity(out List<BirthMaturity> lstBirthMaturity)
        {
            long lresult = -1;
            lstBirthMaturity = new List<BirthMaturity>();
            SqlCommand cmd = Command.pGetBirthMaturityCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {

                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        lresult = Utilities.ConvertTo(ds.Tables[0], out lstBirthMaturity);
                    }
                }
            }

            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetBirthMaturity DAL" + cmd.CommandText, ex);
            }
            return lresult;
        }

        public long GetPlacentalPositions(out List<PlacentalPositions> lstPlacentalPositions)
        {
            long lresult = -1;
            lstPlacentalPositions = new List<PlacentalPositions>();
            SqlCommand cmd = Command.pGetPlacentalPositionCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {

                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        lresult = Utilities.ConvertTo(ds.Tables[0], out lstPlacentalPositions);
                    }
                }
            }

            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPlacentalPositions DAL" + cmd.CommandText, ex);
            }
            return lresult;
        }


        public long GetANCComplaint(int SpecialityID, out List<Complaint> lstComplaint)
        {
            long lresult = -1;
            lstComplaint = new List<Complaint>();
            SqlCommand cmd = Command.pGetANCComplaintCommand(SpecialityID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {

                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        lresult = Utilities.ConvertTo(ds.Tables[0], out lstComplaint);
                    }
                }
            }

            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetANCComplaint DAL" + cmd.CommandText, ex);
            }
            return lresult;
        }

        public long GetAllComplication(string ComplicationName, out List<Complication> lstComplication)
        {
            long lresult = -1;
            lstComplication = new List<Complication>();
            SqlCommand cmd = Command.pGetAllComplicationCommand(ComplicationName,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();

            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstComplication);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetAllComplication in DAL" + cmd.CommandText, ex);
            }

            return lresult;

        }

        public long GetANCInvestigation(int pComplaintID, out List<InvestigationMaster> lstInvestigationMaster)
        {
            long returnCode = -1;

            lstInvestigationMaster = new List<InvestigationMaster>();

            try
            {
                SqlCommand cmd = Command.pGetANCInvestigationCommand(pComplaintID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvestigationMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetANCInvestigation", ex);
            }



            return returnCode;
        }


        public long SaveANC(long patientID, long patientVisitID, ANCPatientDetails pANCPatientDetails,
            List<BackgroundProblem> pBackgroundProblem,
            List<GPALDetails> pGPALDetails,
            PatientUltraSoundData pUSData,
            List<PatientPastComplication> pComplication,
            List<PatientPastVaccinationHistory> pVaccination,
            List<PatientVitals> lstPatientVitals,
            List<OrderedInvestigations> PatientInvestigationHL, string flag,
            List<PatientTreatmentProcedure> lstPPRO, long orgID, string guid, out int pOrderedInvCnt,
            ANCPatientObservation objANCPatientObservation)
        {
            long returnCode = -1;
            int ret = -1;
            int returnStatus = -1;
            pOrderedInvCnt = 0;


            DataTable COMP = new DataTable();
            COMP = UDT_DAL.ConvertToANCPatientComplication(pComplication);
            DataTable VACC = new DataTable();
            VACC = UDT_DAL.ConvertToANCVaccincation(pVaccination);
            DataTable dtVitals = new DataTable();


            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete = Command.pDeleteANCPatientDetailsNurseCommand(patientID, patientVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            DataTable dtPatientVitals = UDT_DAL.ConvertToPatientVitals(lstPatientVitals);
            SqlCommand cmdPatVitals = new SqlCommand();
            cmdPatVitals = Command.pInsPatientVitalsByPhysicianCommand(orgID, dtPatientVitals,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            DataTable complaint = UDT_DAL.ConvertToANCComplaints(pBackgroundProblem);
            SqlCommand cmdANCComplaint = new SqlCommand();
            cmdANCComplaint = Command.pInsertANCComplaintCommand(complaint,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            DataTable GPAL = UDT_DAL.ConvertToANCGPALDetails(pGPALDetails);
            SqlCommand cmdGPALDetails = new SqlCommand();
            cmdGPALDetails = Command.pInsertANCGPALDetailsBulkCommand(GPAL,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            SqlCommand cmdANCPatientDetails = new SqlCommand();
            cmdANCPatientDetails = Command.pInsertANCPatientDetailsCommand(pANCPatientDetails.PatientID, pANCPatientDetails.PatientVisitID, pANCPatientDetails.LMPDate, pANCPatientDetails.EDD, pANCPatientDetails.Gravida, pANCPatientDetails.Para, pANCPatientDetails.Live, pANCPatientDetails.Abortus, pANCPatientDetails.PregnancyStatus, pANCPatientDetails.IsPrimipara, pANCPatientDetails.IsBadObstretic, pANCPatientDetails.MultipleGestation, pANCPatientDetails.CreatedBy, pANCPatientDetails.GPLAOthers, pANCPatientDetails.BloodGroup,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            SqlCommand cmdUSData = new SqlCommand();
            cmdUSData = Command.pInsertANCUltraSoundDataCommand(pUSData.PatientID, pUSData.PatientVisitID, pUSData.GestationalWeek, pUSData.GestationalDays, pUSData.PlacentalPositionID, pUSData.PlacentalPositionName, pUSData.DateOfUltraSound, pUSData.MultipleGestation, pUSData.CreatedBy,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            SqlCommand cmdComplication = new SqlCommand();
            cmdComplication = Command.pInsertANCPatientPastComplicationCommand(COMP,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            SqlCommand cmdVaccination = new SqlCommand();
            cmdVaccination = Command.pInsertPastANCVaccincationCommand(VACC,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            DataTable invs = UDT_DAL.ConvertToOrderedInvestigation(PatientInvestigationHL);
            SqlCommand cmdInvestigation = new SqlCommand();
            cmdInvestigation = Command.pInsertANCOrderedInvestigationHosCommand(invs, orgID, patientVisitID, out pOrderedInvCnt, out ret, guid,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            DataTable dtPPRO = UDT_DAL.ConvertTopatientPRO(lstPPRO);
            SqlCommand cmdPhy = new SqlCommand();
            cmdPhy = Command.pInsertPatientTreatmentProcedureCommand(dtPPRO, Convert.ToInt32(orgID), out returnStatus,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            SqlCommand cmdAncObservation = new SqlCommand();
            cmdAncObservation = Command.pSaveANCPpatientObservationCommand(patientID, patientVisitID, orgID, Convert.ToInt32(objANCPatientObservation.OrgAddressID), objANCPatientObservation.Observation, objANCPatientObservation.CreatedBy, flag,UDT_DAL.ConvertToUDT_Context(globalContextDetails));


            cmdDelete.Parameters.Add("@Return", SqlDbType.Int);
            cmdDelete.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            cmdPatVitals.Parameters.Add("@Return", SqlDbType.Int);
            cmdPatVitals.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            cmdANCComplaint.Parameters.Add("@Return", SqlDbType.Int);
            cmdANCComplaint.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            cmdGPALDetails.Parameters.Add("@Return", SqlDbType.Int);
            cmdGPALDetails.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            cmdANCPatientDetails.Parameters.Add("@Return", SqlDbType.Int);
            cmdANCPatientDetails.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            cmdUSData.Parameters.Add("@Return", SqlDbType.Int);
            cmdUSData.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            cmdComplication.Parameters.Add("@Return", SqlDbType.Int);
            cmdComplication.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            cmdVaccination.Parameters.Add("@Return", SqlDbType.Int);
            cmdVaccination.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            cmdInvestigation.Parameters.Add("@Return", SqlDbType.Int);
            cmdInvestigation.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            cmdPhy.Parameters.Add("@Return", SqlDbType.Int);
            cmdPhy.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            cmdAncObservation.Parameters.Add("@Return", SqlDbType.Int);
            cmdAncObservation.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteTransactionalNonQuery(cmdDelete);
                        returnCode = Convert.ToInt64(cmdDelete.Parameters["@Return"].Value);
                        if (returnCode == 0)
                        {
                            dbEngine.ExecuteTransactionalNonQuery(cmdANCPatientDetails);
                            returnCode = Convert.ToInt64(cmdANCPatientDetails.Parameters["@Return"].Value);
                            if (returnCode == 0)
                            {
                                if (dtPatientVitals.Rows.Count > 0)
                                {
                                    dbEngine.ExecuteTransactionalNonQuery(cmdPatVitals);
                                    returnCode = Convert.ToInt64(cmdPatVitals.Parameters["@Return"].Value);
                                }
                                if (returnCode == 0)
                                {
                                    dbEngine.ExecuteTransactionalNonQuery(cmdANCComplaint);
                                    returnCode = Convert.ToInt64(cmdANCComplaint.Parameters["@Return"].Value);
                                    if (returnCode == 0)
                                    {
                                        dbEngine.ExecuteTransactionalNonQuery(cmdGPALDetails);
                                        returnCode = Convert.ToInt64(cmdGPALDetails.Parameters["@Return"].Value);
                                        if (returnCode == 0)
                                        {
                                            dbEngine.ExecuteTransactionalNonQuery(cmdUSData);
                                            returnCode = Convert.ToInt64(cmdUSData.Parameters["@Return"].Value);
                                            if (returnCode == 0)
                                            {
                                                dbEngine.ExecuteTransactionalNonQuery(cmdComplication);
                                                returnCode = Convert.ToInt64(cmdComplication.Parameters["@Return"].Value);
                                                if (returnCode == 0)
                                                {
                                                    dbEngine.ExecuteTransactionalNonQuery(cmdVaccination);
                                                    returnCode = Convert.ToInt64(cmdVaccination.Parameters["@Return"].Value);
                                                    if (returnCode == 0)
                                                    {
                                                        dbEngine.ExecuteTransactionalNonQuery(cmdInvestigation);
                                                        returnCode = Convert.ToInt64(cmdInvestigation.Parameters["@Return"].Value);
                                                        pOrderedInvCnt = Convert.ToInt32(cmdInvestigation.Parameters["@pOrderedInvCnt"].Value);
                                                        if (returnCode == 0)
                                                        {
                                                            dbEngine.ExecuteTransactionalNonQuery(cmdAncObservation);
                                                            returnCode = Convert.ToInt64(cmdAncObservation.Parameters["@Return"].Value);
                                                            if (returnCode == 0)
                                                            {
                                                                if (flag == "Y")
                                                                {
                                                                    dbEngine.ExecuteTransactionalNonQuery(cmdPhy);
                                                                    returnCode = Convert.ToInt64(cmdPhy.Parameters["@Return"].Value);
                                                                }
                                                                else
                                                                {
                                                                    returnCode = 0;
                                                                }
                                                                if (returnCode == 0)
                                                                {
                                                                    tranScope.Complete();
                                                                }
                                                                else
                                                                {
                                                                    tranScope.Dispose();
                                                                }
                                                            }
                                                            else
                                                            {
                                                                tranScope.Dispose();
                                                            }
                                                        }
                                                        else
                                                        {
                                                            tranScope.Dispose();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        tranScope.Dispose();
                                                    }
                                                }
                                                else
                                                {
                                                    tranScope.Dispose();
                                                }


                                            }
                                            else
                                            {
                                                tranScope.Dispose();
                                            }
                                        }
                                        else
                                        {
                                            tranScope.Dispose();
                                        }
                                    }
                                    else
                                    {
                                        tranScope.Dispose();
                                    }
                                }
                                else
                                {
                                    tranScope.Dispose();
                                }
                            }
                        }
                        else
                        {
                            tranScope.Dispose();
                        }
                    }
                }
                catch (Exception ex)
                {
                    CLogger.LogError("Exception while saving ANC data.", ex);
                    tranScope.Dispose();
                }

            }
            return returnCode;
        }

        public long GetANCSpecialityID(long VisitID, out int specilaityID, out int pFollowup)
        {
            long returnCode = -1;
            specilaityID = 0;
            pFollowup = 0;
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetANCSpecialityIDCommand(VisitID, out specilaityID, out pFollowup, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                     dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        dataReader.Close();
                    }
                    specilaityID = Convert.ToInt32(objCommand.Parameters["@pSpecilaityID"].Value);
                    pFollowup = Convert.ToInt32(objCommand.Parameters["@pFollowUp"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetANCSpecialityID ANC_DAL", e);
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

        public long GetANCDetailsbyPVIDCommand(long patientID, long pPatientVisitID, int pComplaintID, out List<ANCPatientDetails> lstANCPatientDetails, out List<BackgroundProblem> lstBackgroundProblem, out List<GPALDetails> lstGPALDetails, out List<PatientUltraSoundData> lstPatientUltraSoundData, out List<PatientPastComplication> lstPatientPastComplication, out List<PatientPastVaccinationHistory> lstPatientPastVaccinationHistory, out List<OrderedInvestigations> lstPatientInvestigationHL, out string proName, out List<ANCPatientObservation> lstANCPatientObservation)
        {
            long returnCode = -1;

            lstANCPatientDetails = new List<ANCPatientDetails>();
            lstBackgroundProblem = new List<BackgroundProblem>();
            lstGPALDetails = new List<GPALDetails>();
            lstPatientUltraSoundData = new List<PatientUltraSoundData>();
            lstPatientPastComplication = new List<PatientPastComplication>();
            lstPatientPastVaccinationHistory = new List<PatientPastVaccinationHistory>();
            lstPatientInvestigationHL = new List<OrderedInvestigations>();
            lstANCPatientObservation = new List<ANCPatientObservation>();

            SqlCommand cmd = Command.pGetANCDetailsbyPVIDCommand(patientID, pPatientVisitID, pComplaintID, out proName,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    proName = cmd.Parameters["@pProName"].Value.ToString();

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstANCPatientDetails);
                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[1], out lstBackgroundProblem);
                    }
                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[2], out lstGPALDetails);
                    }
                    if (ds.Tables[3].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[3], out lstPatientUltraSoundData);
                    }
                    if (ds.Tables[4].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[4], out lstPatientPastComplication);
                    }
                    if (ds.Tables[5].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[5], out lstPatientPastVaccinationHistory);
                    }
                    if (ds.Tables[6].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[6], out lstPatientInvestigationHL);
                    }
                    if (ds.Tables[7].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[7], out lstANCPatientObservation);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetANCDetailsbyPVIDCommand", ex);
            }

            return returnCode;
        }

        public long GetANCDetailsbyPIDCommand(long patientID, out List<ANCPatientDetails> lstANCPatientDetails, out List<BackgroundProblem> lstBackgroundProblem, out List<GPALDetails> lstGPALDetails, out List<PatientUltraSoundData> lstPatientUltraSoundData, out List<PatientPastComplication> lstPatientPastComplication, out List<PatientPastVaccinationHistory> lstPatientPastVaccinationHistory)
        {
            long returnCode = -1;

            lstANCPatientDetails = new List<ANCPatientDetails>();
            lstBackgroundProblem = new List<BackgroundProblem>();
            lstGPALDetails = new List<GPALDetails>();
            lstPatientUltraSoundData = new List<PatientUltraSoundData>();
            lstPatientPastComplication = new List<PatientPastComplication>();
            lstPatientPastVaccinationHistory = new List<PatientPastVaccinationHistory>();

            SqlCommand cmd = Command.pGetANCDetailsbyPIDCommand(patientID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstANCPatientDetails);
                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[1], out lstBackgroundProblem);
                    }
                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[2], out lstGPALDetails);
                    }
                    if (ds.Tables[3].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[3], out lstPatientUltraSoundData);
                    }
                    if (ds.Tables[4].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[4], out lstPatientPastComplication);
                    }
                    if (ds.Tables[5].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[5], out lstPatientPastVaccinationHistory);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetANCDetailsbyPIDCommand", ex);
            }

            return returnCode;
        }

        public long saveANCFollowupData(List<PatientVaccinationHistory> pVaccination,
            PatientUltraSoundData pUSData,
            List<PatientVitals> lstPatientVitals, long orgID)
        {
            long returncode = -1;

            DataTable VACC = new DataTable();
            VACC = UDT_DAL.ConvertToANCVaccincation(pVaccination);


            SqlCommand cmdVaccination = new SqlCommand();
            SqlCommand cmdUSData = new SqlCommand();
            SqlCommand cmdPatVitals = new SqlCommand();


            cmdVaccination = Command.pInsertANCVaccincationCommand(VACC,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdUSData = Command.pInsertANCUltraSoundDataCommand(pUSData.PatientID,
									pUSData.PatientVisitID, pUSData.GestationalWeek, pUSData.GestationalDays,
									pUSData.PlacentalPositionID, pUSData.PlacentalPositionName, pUSData.DateOfUltraSound,
									                pUSData.MultipleGestation, pUSData.CreatedBy,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataTable dtVitals = UDT_DAL.ConvertToPatientVitals(lstPatientVitals);
            cmdPatVitals = Command.pInsPatientVitalsByPhysicianCommand(orgID, dtVitals,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            cmdVaccination.Parameters.Add("@Return", SqlDbType.Int);
            cmdVaccination.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            cmdUSData.Parameters.Add("@Return", SqlDbType.Int);
            cmdUSData.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            cmdPatVitals.Parameters.Add("@Return", SqlDbType.Int);
            cmdPatVitals.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbengine = new DBEngine(true))
                    {
                        dbengine.ExecuteTransactionalNonQuery(cmdVaccination);
                        returncode = Convert.ToInt64(cmdVaccination.Parameters["@Return"].Value);
                        if (returncode == 0)
                        {
                            dbengine.ExecuteTransactionalNonQuery(cmdUSData);
                            returncode = Convert.ToInt64(cmdUSData.Parameters["@Return"].Value);
                            if (returncode == 0)
                            {
                                if (dtVitals.Rows.Count > 0)
                                {
                                    dbengine.ExecuteTransactionalNonQuery(cmdPatVitals);
                                    returncode = Convert.ToInt64(cmdPatVitals.Parameters["@Return"].Value);
                                }
                                if (returncode == 0)
                                {
                                    tranScope.Complete();
                                }
                                else
                                {
                                    tranScope.Dispose();
                                }
                            }
                            else
                            {
                                tranScope.Dispose();
                            }
                        }
                        else
                        {
                            tranScope.Dispose();
                        }
                    }
                }
                catch (Exception ex)
                {
                    CLogger.LogError("Error in DAL saveANCFollowupData", ex);
                }
            }

            return returncode;
        }



        public long GetANCCaseSheetDetails(long pPatinetVisitID, long pPatientID, out List<PatientHistory> lstPatientHistory,
                                                                                  out List<PatientExamination> lstPatientExamination,
                                                                                  out List<PatientComplaint> lstPatientComplaint,
                                                                                  out List<Patient> lstPatient,
                                                                                  out List<PatientAdvice> lstPatientAdvice,
                                                                                  out List<ANCAdvice> lstANCAdvice,
                                                                                  out List<PatientPrescription> lstPatientPrescription,
                                                                                  out List<PatientInvestigation> lstPatientInvestigation,
                                                                                  out List<PatientFetalFindings> lstPatientFetalFindings,
                                                                                  out List<ANCPatientDetails> lstANCPatientDetails,
                                                                                  out List<BackgroundProblem> lstBackgroundProblem,
                                                                                  out List<ANCAlerts> lstANCAlerts,
                                                                                  out List<PatienttoScanforANC> lstANCScan,
                                                                                  out List<PatientComplication> lstPatientComplication,
                                                                                  out int pVisitCount)
        {
            long returnCode = -1;
            pVisitCount = -1;

            lstPatientHistory = new List<PatientHistory>();
            lstPatientExamination = new List<PatientExamination>();
            lstPatientComplaint = new List<PatientComplaint>();
            lstPatient = new List<Patient>();
            lstPatientAdvice = new List<PatientAdvice>();
            lstANCAdvice = new List<ANCAdvice>();
            lstPatientPrescription = new List<PatientPrescription>();
            lstPatientInvestigation = new List<PatientInvestigation>();
            lstPatientFetalFindings = new List<PatientFetalFindings>();
            lstANCPatientDetails = new List<ANCPatientDetails>();
            lstBackgroundProblem = new List<BackgroundProblem>();
            lstANCAlerts = new List<ANCAlerts>();
            lstANCScan = new List<PatienttoScanforANC>();
            lstPatientComplication = new List<PatientComplication>();

            try
            {
                SqlCommand cmd = Command.pGetANCCaseSheetDetailsCommand(pPatinetVisitID, pPatientID, out pVisitCount,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                DataSet ds = new DataSet();

                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    pVisitCount = Convert.ToInt32(cmd.Parameters["@pVisitCount"].Value);
                }
                if (ds.Tables[0].Rows.Count > 0)    // PatinetHistory
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientHistory);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPatientExamination);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPatientComplaint);
                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstPatient);
                }
                if (ds.Tables[4].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[4], out lstPatientAdvice);
                }
                if (ds.Tables[5].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[5], out lstANCAdvice);
                }
                if (ds.Tables[6].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[6], out lstPatientPrescription);
                }
                if (ds.Tables[7].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[7], out lstPatientInvestigation);
                }
                if (ds.Tables[8].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[8], out lstPatientFetalFindings);
                }
                if (ds.Tables[9].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[9], out lstANCPatientDetails);
                }
                if (ds.Tables[10].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[10], out lstBackgroundProblem);
                }
                if (ds.Tables[11].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[11], out lstANCAlerts);
                }
                if (ds.Tables[12].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[12], out lstANCScan);
                }
                if (ds.Tables[13].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[13], out lstPatientComplication);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetANCCaseSheetDetails", ex);
            }
            return returnCode;
        }

        public long GetANCCountforNurse(long pPatientVisitID, out int pCount)
        {
            long returnCode = -1;

            SqlCommand cmd = Command.pGetANCCountforNurseCommand(pPatientVisitID, out pCount,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();

            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    pCount = Convert.ToInt32(cmd.Parameters["@pCount"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetANCCountforNurse", ex);
            }

            return returnCode;
        }

        public long GetANCPatientVisitDetailsByVID(int pComplaintId, long patientID, long patientVisitID, out List<OrderedInvestigations> lstPatientInvestigationHL, out List<DrugDetails> lstPatientDrugs, out List<PatientAdvice> lstPatientAdvice, out List<ANCPatientObservation> lstANCPatientObservation)
        {
            long returnCode = -1;

            lstPatientInvestigationHL = new List<OrderedInvestigations>();
            lstPatientDrugs = new List<DrugDetails>();
            lstPatientAdvice = new List<PatientAdvice>();
            lstANCPatientObservation = new List<ANCPatientObservation>();


            try
            {
                SqlCommand cmd = Command.pGetANCPatientVisitDetailsByVIDCommand(pComplaintId, patientID, patientVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                DataSet ds = new DataSet();

                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientInvestigationHL);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPatientDrugs);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPatientAdvice);
                }

                if (ds.Tables[3].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstANCPatientObservation);
                }



            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetANCPatientVisitDetailsByVID", ex);
            }

            return returnCode;
        }

        public long GetANCPatientDiagnoseEdit(long pPatientVisitID, long pPatientID, long pCreatedBy, int pComplaintID, out string pScanStatus, out string pNextReviewDate,
                                                                                    out List<PatientComplaint> lstPatientComplaint,
                                                                                    out List<PatientHistory> lstPatientHistory,
                                                                                    out List<PatientExamination> lstPatientExamination,
                                                                                    out List<PatientComplication> lstPatientComplication,
                                                                                    out List<PatientFetalFindings> lstPatientFetalFindings,
                                                                                    out List<PatientAdvice> lstPatientAdvice,
                                                                                    out List<DrugDetails> lstPatientDrugs,
                                                                                    out List<PatientVaccinationHistory> lstPatientVaccinationHistory,
                                                                                    out List<ANCPatientDetails> lstANCPatientDetails,
                                                                                    out List<PatientInvestigation> lstPatientInvestigation,
                                                                                    out List<ANCPatientObservation> lstANCPatientObservation)
        {
            long returnCode = -1;

            lstPatientComplaint = new List<PatientComplaint>();
            lstPatientHistory = new List<PatientHistory>();
            lstPatientExamination = new List<PatientExamination>();
            lstPatientComplication = new List<PatientComplication>();
            lstPatientFetalFindings = new List<PatientFetalFindings>();
            lstPatientAdvice = new List<PatientAdvice>();
            lstPatientDrugs = new List<DrugDetails>();
            lstPatientVaccinationHistory = new List<PatientVaccinationHistory>();
            lstANCPatientDetails = new List<ANCPatientDetails>();
            lstPatientInvestigation = new List<PatientInvestigation>();
            lstANCPatientObservation = new List<ANCPatientObservation>();
            pScanStatus = string.Empty;
            pNextReviewDate = string.Empty;

            try
            {

                SqlCommand cmd = Command.pGetANCPatientDiagnoseEditCommand(pPatientVisitID, pPatientID, pCreatedBy, pComplaintID, out pScanStatus, out pNextReviewDate,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                DataSet ds = new DataSet();

                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    pScanStatus = cmd.Parameters["@pScanStatus"].Value.ToString();
                    pNextReviewDate = cmd.Parameters["@pNextReviewDate"].Value.ToString();
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientComplaint);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPatientHistory);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPatientExamination);
                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstPatientComplication);
                }
                if (ds.Tables[4].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[4], out lstPatientFetalFindings);
                }
                if (ds.Tables[5].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[5], out lstPatientAdvice);
                }
                if (ds.Tables[6].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[6], out lstPatientDrugs);
                }
                if (ds.Tables[7].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[7], out lstPatientVaccinationHistory);
                }
                if (ds.Tables[8].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[8], out lstANCPatientDetails);
                }
                if (ds.Tables[9].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[9], out lstPatientInvestigation);
                }

                if (ds.Tables[10].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[10], out lstANCPatientObservation);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetANCPatientDiagnoseEdit", ex);
            }
            return returnCode;
        }

        public long CheckANCNurseTaskStatus(long patientVisitId, int specialityId, long roleId, out int pStatus, out int pLabStatus)
        {
            long returnCode = -1;

            pStatus = -1;
            pLabStatus = -1;

            try
            {
                SqlCommand cmd = Command.pCheckANCNurseTaskStatusCommand(patientVisitId, specialityId, roleId, out pStatus, out pLabStatus,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();

                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    pStatus = Convert.ToInt32(cmd.Parameters["@pStatus"].Value.ToString());
                    pLabStatus = Convert.ToInt32(cmd.Parameters["@pLabStatus"].Value.ToString());
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL CheckANCNurseTaskStatus", ex);
            }

            return returnCode;
        }

        public long GetPhysiotheraphyID(long pVisitID, string proDesc, long pOrgId, out List<ProcedureFee> lstProcedureFee)
        {
            long returnCode = -1;
            lstProcedureFee = new List<ProcedureFee>();
            try
            {
                SqlCommand cmd = Command.pGetPhysiotheraphyIDCommand(pVisitID, proDesc, pOrgId,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstProcedureFee);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetPhysiotheraphyID", ex);
            }

            return returnCode;
        }

        public long GetANCSnapShotView(long patientVisitID, int pOrgID, out DataSet ds, out List<PatientFetalFindings> lstPFF, out List<ANCPatientObservation> lstANCPatientObservation)
        {
            long returnCode = -1;
            ds = new DataSet();
            lstPFF = new List<PatientFetalFindings>();
            lstANCPatientObservation = new List<ANCPatientObservation>();
            try
            {
                SqlCommand cmd = Command.pGetANCSnapShotViewCommand(patientVisitID, pOrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPFF);
                }

                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstANCPatientObservation);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in GetANCSnapShotView", ex);
            }

            return returnCode;
        }
    }
}
