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
    public class PatientVisit_DAL
    {
        ContextDetails globalContextDetails;
        public PatientVisit_DAL()
        {

        }
        public PatientVisit_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetVisitDetails(long visitID, out List<PatientVisitDetails> lstPatientVisit)
        {
            long returnCode = -1;
            lstPatientVisit = new List<PatientVisitDetails>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetPatientVisitDetailsCommand(visitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstPatientVisit);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetVisitDetails PatientVisit_DAL", e);
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

        public long GetVisitDetails(long visitID, out List<PatientVisit> lstPatientVisit)
        {
            long returnCode = -1;
            lstPatientVisit = new List<PatientVisit>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetPatientVisitDetailsCommand(visitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstPatientVisit);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetVisitDetails PatientVisit_DAL", e);
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
        public long InsertVisit(PatientVisit patientVisit, out long visitID, long enteredPatientID,
                                                            int iTokenNo, long lScheduleID,
                                                            long lResourcetemplateID, string sPassedTime,
                                                            out int iReturnTokenNumber, DateTime dFromTime,
                                                            DateTime dToTime, string needIPNumber, List<VisitClientMapping> lstVisitClientMapping)
        {
            long returnCode = -1;
            long selectedPatientID;
            long orgID;
            int conditionID;
            int visitType;
            int physicianID;
            int referphysicianID;
            int referspecialityID;
            byte visitPurpose;
            long createdBy;
            long orgAddressID;
            int specialityID;
            long referOrgID;
            long ClientID = 0;
            int CorporateID = 0;
            string pSecuredCode;
            string othPhyName;
            long ParentVisitId = 0; int priorityId = -1;
            iReturnTokenNumber = 0;
            string referphysicianName;
            visitID = 0;
            string accompaniedBy = string.Empty;
            long lResult = 0;
            if (patientVisit != null)
            {
                selectedPatientID = patientVisit.PatientID;
                orgID = patientVisit.OrgID;
                orgAddressID = patientVisit.OrgAddressID;
                conditionID = patientVisit.ConditionId;
                visitType = patientVisit.VisitType;
                physicianID = patientVisit.PhysicianID;
                visitPurpose = Convert.ToByte(patientVisit.VisitPurposeID);
                accompaniedBy = patientVisit.AccompaniedBy;
                createdBy = patientVisit.CreatedBy;
                specialityID = patientVisit.SpecialityID;
                referOrgID = patientVisit.ReferOrgID;

                pSecuredCode = patientVisit.SecuredCode;
                othPhyName = patientVisit.PhysicianName;
                ParentVisitId = patientVisit.ParentVisitId;
                priorityId = patientVisit.PriorityID;
                referphysicianID = patientVisit.ReferingPhysicianID;
                referphysicianName = patientVisit.ReferingPhysicianName;
                referspecialityID = patientVisit.ReferingSpecialityID;
                SqlCommand cmdInsertVisit = Command.pInsertPatientVisitCommand(selectedPatientID, orgID, orgAddressID,
                                    referOrgID, conditionID, visitType,
                                    physicianID, visitPurpose, specialityID,
                                    accompaniedBy, createdBy, out visitID,
                                    enteredPatientID, pSecuredCode, othPhyName,
                                    ParentVisitId, referphysicianID, referspecialityID, iTokenNo, lScheduleID,
                lResourcetemplateID, sPassedTime, out iReturnTokenNumber, dFromTime, dToTime, priorityId, referphysicianName, needIPNumber,
                UDT_DAL.ConvertToUDT_Context(globalContextDetails),
                 UDT_DAL.ConvertToVisitClientMapping(lstVisitClientMapping)

                );
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmdInsertVisit);
                    visitID = Convert.ToInt64(cmdInsertVisit.Parameters["@pPatientVisit"].Value);
                    if (visitID != 0)
                    {
                        patientVisit.PatientVisitId = visitID;
                        returnCode = 0;
                    }
                }
            }

            return returnCode;
        }

        public long SaveContinueSameTreatment(long currentVisitID, long previousVisitID, string nextReviewDate, long pLID)
        {
            long returnCode = -1;

            SqlCommand cmd = Command.pInsertContinueSameTreatmentCommand(currentVisitID, previousVisitID, nextReviewDate, pLID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
            }

            return returnCode;
        }

        public long GetInsertVisitPurpose(int OrgID, List<VisitPurpose> lstVisitPurpose, string ptype)
        {
            long returnCode = -1;
            DataTable DtVisitPurpose = UDT_DAL.ConvertToUDTVisitPurpose(lstVisitPurpose);
            SqlCommand cmd = Command.pGetInsertVisitPurposeCommand(OrgID, DtVisitPurpose, ptype, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing GetInsertVisitPurpose PatientVisit_DAL", ex);
            }
            return returnCode;
        }

        public long GetVisitPurposes(int OrgID, out List<VisitPurpose> lstVisitPurpose)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetVisitPurposeCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstVisitPurpose = new List<VisitPurpose>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }


            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstVisitPurpose);
            }

            return returnCode;
        }

        public long GetVisitPurpose(int OrgID, string pType, out List<VisitPurpose> lstVisitPurpose)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetVisitedPurposeCommand(OrgID, pType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstVisitPurpose = new List<VisitPurpose>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }


            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstVisitPurpose);
            }

            return returnCode;
        }



        public long GetProcedureName(long orgId, out List<ProcedureMaster> lstProcedurename)
        {
            long returnCode = -1;
            lstProcedurename = new List<ProcedureMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetProcedureNameCommand(orgId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstProcedurename);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while get procedure name, pGetProcedureName sp", ex);

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







        public long GetSpecialityAndSpecialityName(long orgID, out List<PhysicianSpeciality> lstPhySpeciality, int iRateID, out List<Speciality> lstSpeciality)
        {
            long returnCode = -1;
            lstPhySpeciality = new List<PhysicianSpeciality>();
            lstSpeciality = new List<Speciality>();
            IDataReader dataReader = null;
            int rsCount = 0;
            try
            {
                SqlCommand cmd = Command.pGetSpecialityNameCommand(orgID, iRateID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstSpeciality);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstPhySpeciality);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading Speciality name using pGetSpecialityName sp", ex);
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
        public long CorporateGetSpecialityAndSpecialityName(long orgID, out List<PhysicianSpeciality> lstPhySpeciality, int iRateID, out List<Speciality> lstSpeciality)
        {
            long returnCode = -1;
            lstSpeciality = new List<Speciality>();
            lstPhySpeciality = new List<PhysicianSpeciality>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetCorporateSpecialityNameCommand(orgID, iRateID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstSpeciality);
                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPhySpeciality);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading Speciality name using pGetSpecialityName sp", ex);
            }

            return returnCode;

        }
        public long CorporateGetSpecialityName(long orgID, int iRateID, long SID, out List<PhysicianSpeciality> lstPhySpeciality)
        {
            long returnCode = -1;
            lstPhySpeciality = new List<PhysicianSpeciality>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetCorporatePhysicanNameCommand(orgID, iRateID, SID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPhySpeciality);
                    }

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading Speciality name using pGetSpecialityName sp", ex);
            }

            return returnCode;

        }
        public long GetConsultingName(long specialityID, int orgID, out List<Physician> lstPhysician)
        {
            long returnCode = -1;
            lstPhysician = new List<Physician>();
            try
            {
                SqlCommand cmd = Command.pGetConsultingNameCommand(specialityID, orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();

                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPhysician);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading get consulting name using pGetConsultingName sp", ex);
            }

            return returnCode;

        }

        public long GetTaskActionID(long orgID, long visitPurposeID, long otherID, out List<TaskActions> lstTaskAction)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstTaskAction = new List<TaskActions>();
            try
            {
                SqlCommand cmd = Command.pGetTaskActionIDCommand(orgID, visitPurposeID, otherID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstTaskAction);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while fetching taskaction id pGetTaskActionID sp", ex);
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

        public long GetPhysicianByProcedure(long orgID, long procedureID, out List<Physician> lstPhysician)
        {
            long returnCode = -1;
            lstPhysician = new List<Physician>();

            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetPhysicianByProcCommand(procedureID, orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPhysician);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading get Physician name for procedure using pGetPhysicianByProc sp", ex);
            }

            return returnCode;
        }


        public long GetPatientVisitDetailsByvisitID(int complaintID, long visitId,
            out PatientComplaint patientComplaint,
            out List<OrderedInvestigations> lstPatientInvestigationHL, out List<PatientHistory> lstPatientHistory,
            out List<PatientExamination> lstPatientExamination, out List<DrugDetails> lstPatientDrugs,
            out List<PatientAdvice> lstPatientAdvice, out List<PatientVisit> lstPatientVisit, out string isBgP)
        {
            long returncode = 1;
            SqlCommand cmd = Command.pGetPatientVisitDetailsByVisitIDCommand(complaintID, visitId, out isBgP, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            patientComplaint = new PatientComplaint();
            List<PatientComplaint> lstPC = new List<PatientComplaint>();
            lstPatientExamination = new List<PatientExamination>();
            lstPatientHistory = new List<PatientHistory>();
            lstPatientDrugs = new List<DrugDetails>();
            lstPatientInvestigationHL = new List<OrderedInvestigations>();
            lstPatientAdvice = new List<PatientAdvice>();
            lstPatientVisit = new List<PatientVisit>();

            using (DBEngine dbEngine = new DBEngine())
            {
                returncode = dbEngine.ExecuteDataSet(cmd, out ds);
                isBgP = cmd.Parameters["@pisBgP"].Value.ToString();
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returncode = Utilities.ConvertTo(ds.Tables[0], out lstPC);
                if (lstPC.Count > 0)
                {
                    patientComplaint = lstPC[0];
                }
            }
            if (ds.Tables[1].Rows.Count > 0)
            {
                returncode = Utilities.ConvertTo(ds.Tables[1], out lstPatientInvestigationHL);
            }
            if (ds.Tables[2].Rows.Count > 0)
            {
                returncode = Utilities.ConvertTo(ds.Tables[2], out lstPatientHistory);
            }
            if (ds.Tables[3].Rows.Count > 0)
            {
                returncode = Utilities.ConvertTo(ds.Tables[3], out lstPatientExamination);
            }
            if (ds.Tables[4].Rows.Count > 0)
            {
                returncode = Utilities.ConvertTo(ds.Tables[4], out lstPatientDrugs);
            }
            if (ds.Tables[5].Rows.Count > 0)
            {
                returncode = Utilities.ConvertTo(ds.Tables[5], out lstPatientAdvice);
            }
            if (ds.Tables[6].Rows.Count > 0)
            {
                returncode = Utilities.ConvertTo(ds.Tables[6], out lstPatientVisit);
            }
            return returncode;
        }

        public long GetPatientVisitDetailsByvisitID(long visitId, out List<PatientComplaint> lstPatientComplaint,
            out List<OrderedInvestigations> lstPatientInvestigationHL, out List<PatientHistory> lstPatientHistory,
            out List<PatientExamination> lstPatientExamination, out List<DrugDetails> lstPatientDrugs,
            out List<PatientAdvice> lstPatientAdvice, out List<PatientVisit> lstPatientVisit)
        {
            long returncode = 1;
            SqlCommand cmd = Command.pGetUNFPatientVisitDtlByVisitIDCommand(visitId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            lstPatientComplaint = new List<PatientComplaint>();
            lstPatientExamination = new List<PatientExamination>();
            lstPatientHistory = new List<PatientHistory>();
            lstPatientDrugs = new List<DrugDetails>();
            lstPatientInvestigationHL = new List<OrderedInvestigations>();
            lstPatientAdvice = new List<PatientAdvice>();
            lstPatientVisit = new List<PatientVisit>();

            using (DBEngine dbEngine = new DBEngine())
            {
                returncode = dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (returncode == 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstPatientComplaint);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[1], out lstPatientInvestigationHL);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[2], out lstPatientHistory);
                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[3], out lstPatientExamination);
                }
                if (ds.Tables[4].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[4], out lstPatientDrugs);
                }
                if (ds.Tables[5].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[5], out lstPatientAdvice);
                }
                if (ds.Tables[6].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[6], out lstPatientVisit);
                }
            }
            return returncode;
        }

        public long GetPatientVisit(long patientID, int pVisitID, int pOrgID, int pVisitType, out List<PatientVisit> lstPatientVisit, out List<OrderedInvestigations> lOrderedInv, out string pPatientName, out string pPatientNo)
        {
            long returnCode = -1;
            lstPatientVisit = new List<PatientVisit>();
            lOrderedInv = new List<OrderedInvestigations>();
            pPatientName = string.Empty;
            pPatientNo = string.Empty;
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetVisitDetailsCommand(patientID, pVisitID, pOrgID, pVisitType, out pPatientName, out pPatientNo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientVisit);

                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[1], out lOrderedInv);

                    }
                    if (returnCode == 0)
                    {
                        pPatientName = cmd.Parameters["@pPatientName"].Value.ToString().Trim();
                        pPatientNo = cmd.Parameters["@pPatientNumber"].Value.ToString().Trim();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading get visit details", ex);
            }
            return returnCode;
        }



        public long GetVisitSearchDetails(long patientID, string fromDate, string toDate, int pOrgID, int pVisitType, out List<PatientVisit> lstPatientVisit)
        {
            long returnCode = -1;
            lstPatientVisit = new List<PatientVisit>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetVisitSearchDetailCommand(patientID, fromDate, toDate, pOrgID, pVisitType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientVisit);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading get patient visit search details", ex);
            }
            return returnCode;
        }

        public long GetVisitPurposeName(int orgID, long visitid, out List<VisitPurpose> lstVisitPurpose)
        {
            long returnCode = -1;
            lstVisitPurpose = new List<VisitPurpose>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetVisitPurposeNameCommand(visitid, orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstVisitPurpose);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading visit search actions", ex);
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

        public long GetDoctorsReferred(out List<ReferenceOrg> lstRefOrg)
        {
            long returnCode = -1;
            lstRefOrg = new List<ReferenceOrg>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetDoctorsReferredCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstRefOrg);
                    }
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDoctorReferred DAL", ex);
            }

            return returnCode;
        }

        public long GetCurrentDateVisitDetails(int currentOrgID, List<TrustedOrgDetails> lstTOD, long loginID, int parentID, string Description, long physicianID, string patientName, out List<PatientVisit> lstPatientVisit, out int totalCount, long LocationID)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            totalCount = 0;
            DataTable dtOrgIDs = UDT_DAL.ConvertToGetOrgIDs(lstTOD);
            lstPatientVisit = new List<PatientVisit>();
            try
            {
                SqlCommand objCommand = Command.pGetCurrentDateVisitsCommand(currentOrgID, dtOrgIDs, loginID, parentID, Description, physicianID, patientName, out totalCount, LocationID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstPatientVisit);
                        dataReader.Close();
                    }
                    totalCount = Convert.ToInt32(objCommand.Parameters["@pTotalCount"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing GetCurrentDateVisitDetails in DAL", ex);
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

        public long GetCurrentDateVisitsByName(int currentOrgID, List<TrustedOrgDetails> lstTOD, long loginID, int parentID, string strName, out List<PatientVisit> lstPatientVisit, out List<PatientVisit> lstPhysicianPV, out int totalCount)
        {
            long returnCode = -1;
            DataTable dtOrgIDs = UDT_DAL.ConvertToGetOrgIDs(lstTOD);
            SqlCommand objCommand = Command.pGetCurrentDateVisitsByNameCommand(currentOrgID, dtOrgIDs, loginID, parentID, strName, out totalCount, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstPatientVisit = new List<PatientVisit>();
            lstPhysicianPV = new List<PatientVisit>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
                totalCount = Convert.ToInt32(objCommand.Parameters["@pTotalCount"].Value.ToString());
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientVisit);
            }
            if (ds.Tables[1].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPhysicianPV);
            }

            return returnCode;
        }

        public long GetRelationship(out List<Relationship> lstRelationship)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetRelationshipCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstRelationship = new List<Relationship>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }


            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstRelationship);
            }

            return returnCode;
        }

        public long GetDoctorsForLab(int orgID, out List<Physician> lstPhysician)
        {
            long returnCode = -1;
            lstPhysician = new List<Physician>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetDoctorsForLabCommand(orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPhysician);
                    }
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDoctorsForLab DAL", ex);
            }

            return returnCode;
        }

        public long GetVisitEntryPageData(long pOrgID, string pPatientName,
                                        out List<PatientCondition> lstPatientCondition, out List<OrganizationAddress> lstLocation,
                                        out List<PhysicianSchedule> lstPhysician,
                                        out List<VisitPurpose> lstVisitPurpose,
                                        out List<Patient> lstPatient,
                                        out List<Bookings> lstBookings,
                                        out List<Complaint> lstScheduleTimes,
                                        out List<Bookings> lstFullSchedules, out List<PriorityMaster> lstPriorityMaster, int LocationID)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetVisitEntryPageDataCommand(pOrgID, pPatientName, LocationID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstPatientCondition = new List<PatientCondition>();
            lstLocation = new List<OrganizationAddress>();
            lstPhysician = new List<PhysicianSchedule>();
            lstVisitPurpose = new List<VisitPurpose>();
            lstPatient = new List<Patient>();
            lstBookings = new List<Bookings>();
            lstScheduleTimes = new List<Complaint>();
            lstFullSchedules = new List<Bookings>(); lstPriorityMaster = new List<PriorityMaster>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteDataSet(objCommand, out ds);
            }

            if (returnCode == 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstLocation);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPatientCondition);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPhysician);
                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstVisitPurpose);
                }
                if (ds.Tables[4].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[4], out lstPatient);
                }
                if (ds.Tables[5].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[5], out lstBookings);
                }
                if (ds.Tables[6].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[6], out lstScheduleTimes);
                }
                if (ds.Tables[7].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[7], out lstFullSchedules);
                }
                if (ds.Tables[8].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[8], out lstPriorityMaster);
                }
            }

            return returnCode;
        }
        public long GetDieTarySpecification(int orgiD, long patientID, long patientVisitID, out List<OrgDietTypeMapping> lstOrgDietType,
      out List<OrgDietPatternMapping> lstOrgDietPattern, out List<OrgDietPlanMapping> lstOrgDietPlan,
      out List<ModeofOxygenDelivery> lstModeofOxygenDelivery, out List<Patient> lstPatient,
      out List<PatientCondition> lstPatientCondition, out List<InPatientAdmissionDetails> lstInpatient)
        {
            long returnCode = -1;
            lstOrgDietType = new List<OrgDietTypeMapping>();
            lstOrgDietPattern = new List<OrgDietPatternMapping>();
            lstOrgDietPlan = new List<OrgDietPlanMapping>();
            lstModeofOxygenDelivery = new List<ModeofOxygenDelivery>();
            lstPatient = new List<Patient>();
            lstPatientCondition = new List<PatientCondition>();
            lstInpatient = new List<InPatientAdmissionDetails>();

            DataSet ds = new DataSet();
            SqlCommand cmd = Command.pGetDietarySpecificationsCommand(orgiD, patientID, patientVisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstOrgDietType);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstOrgDietPattern);
                }

                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstOrgDietPlan);
                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstModeofOxygenDelivery);
                }
                if (ds.Tables[4].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[4], out lstPatient);
                }

                if (ds.Tables[5].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[5], out lstPatientCondition);
                }

                if (ds.Tables[6].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[6], out lstInpatient);
                }
            }

            return returnCode;
        }


        public long SaveHISAdmissionDetail(long visitID, PatientDietSpecification patientDietSpec,
            InPatientAdmissionDetails inPatientAdmission, List<BelongingsHandoverDetails> lstBelong)
        {
            long returnCode = -1;

            DataTable dtlstBelong = UDT_DAL.ConvertToBelongDetails(lstBelong);

            SqlCommand cmd = Command.pInsertHISAdmissionDetailsCommand(visitID, patientDietSpec.OrgDietTypeMappingID,
                                    patientDietSpec.OrgDietPatternMappingID, patientDietSpec.OrgDietPlanMappingID,
                                    patientDietSpec.FluidRestriction,
                                    inPatientAdmission.OxygenRequired, inPatientAdmission.ModeOfOxygenDeliveryID,
                                    inPatientAdmission.RateOfDelivery,
                                    inPatientAdmission.OrientationProvided,
                                    inPatientAdmission.VerifyIdentification,
                                    inPatientAdmission.ConditionOnAdmissionID,
                                    patientDietSpec.CreatedBy,
                                                    dtlstBelong, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
            }

            return returnCode;

        }
        public long GetPurposeOfAdmission(int OrgID, out List<PurposeOfAdmission> lstPurposeOfAdmission)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetPurposeOfAdmissionCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstPurposeOfAdmission = new List<PurposeOfAdmission>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPurposeOfAdmission);
            }

            return returnCode;
        }

        public long GetConditionOnAdmission(out List<PatientCondition> lstConditionOnAdmission)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetConditionOnAdmissionCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstConditionOnAdmission = new List<PatientCondition>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstConditionOnAdmission);
            }
            return returnCode;
        }

        public long GetOrgan(out List<Organ> lstOrgan)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetOrganCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstOrgan = new List<Organ>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }


            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstOrgan);
            }

            return returnCode;
        }

        public long GetKnowledgeOfService(out List<KnowledgeOfService> lstKnowledgeOfService)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetKnowledgeOfServiceCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstKnowledgeOfService = new List<KnowledgeOfService>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }


            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstKnowledgeOfService);
            }

            return returnCode;
        }

        public long InsertPatientIndents(List<PatientDueChart> lstSurgergicalPkg, List<OrderedInvestigations> pPatientInvTable, List<PatientDueChart> pPatientConsultation,
                                          List<PatientDueChart> pPatientProcedure, List<PatientDueChart> pPatientIndents, List<DHEBAdder> pDHEBPatientIndents, long visitID, long CreatedBy, long PatientID, out string InterimBillNo)
        {
            long ireturnStatus = -1;
            InterimBillNo = "-1";

            DataTable dtPatientItems = null;
            dtPatientItems = UDT_DAL.ConvertToUDTPatientDueChart(lstSurgergicalPkg, pPatientInvTable, pPatientConsultation,
                                                    pPatientProcedure, pPatientIndents, pDHEBPatientIndents);

            SqlCommand cmdInsertVisit = Command.pInsertPatientItemsCommand(dtPatientItems, visitID, CreatedBy, PatientID, out InterimBillNo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(true))
            {
                dbEngine.ExecuteTransactionalNonQuery(cmdInsertVisit);
                InterimBillNo = Convert.ToString(cmdInsertVisit.Parameters["@pInterimBillNumber"].Value);
                ireturnStatus = 0;
            }
            return ireturnStatus;
        }

        public long GetMedicalItems(out List<MedicalIndents> lstMedicalIndents, int orgID)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetMedicalIndentsCommand(orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstMedicalIndents = new List<MedicalIndents>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstMedicalIndents);
            }

            return returnCode;
        }

        public long GetDueChart(out List<PatientDueChart> lstPatientDueChart, long orgID, long pVisitID, string selType, out decimal ptotalAdvance, out List<AdvancePaidDetails> lstAdvancePaidDetails)
        {
            long returnCode = -1;
            ptotalAdvance = 0;
            lstAdvancePaidDetails = new List<AdvancePaidDetails>();

            SqlCommand objCommand = Command.pgetPatientItemsCommand(pVisitID, orgID, selType, out ptotalAdvance, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstPatientDueChart = new List<PatientDueChart>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientDueChart);
                ptotalAdvance = Convert.ToDecimal(objCommand.Parameters["@pTotalAdvance"].Value);
            }
            if (ds.Tables[1].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstAdvancePaidDetails);
            }
            return returnCode;
        }

        public long InsertPatientBillItemsDetails(List<PatientDueChart> pPatientIndTable, long visitID,
                                                    long CreatedBy, long orgID, decimal pAmountReceived, decimal pRefundAmount,
                                                    decimal pDiscountAmount, decimal pDue, decimal pGrossBillValue, string isCreditBill,
                                                    decimal pnetValue, decimal pAdvanceReceived, DataTable dtAmtReceivedDetails, decimal pAmtReceived,
                                                    long pReceivedBy, string sType, int LocationID,
                                                    decimal dserviceCharge, string TPAPaymentStatus, string PayerType,
                                                    out string ReceiptNo, out long IpIntermediateID, out string sPaymentType)
        {
            long ireturnStatus = -1;
            IpIntermediateID = 0;
            sPaymentType = "";
            ReceiptNo = "";

            DataTable dtDueChart = new DataTable();
            dtDueChart = UDT_DAL.ConvertToUDTPatientDueChartForIP(pPatientIndTable);


            SqlCommand cmdInsertVisit = new SqlCommand();
            if (sType == "")
            {
                cmdInsertVisit = Command.pInsertPatientBillItemsDetailsCommand(visitID, orgID, CreatedBy, dtDueChart,
                                    pAmountReceived, pRefundAmount, pDiscountAmount,
                                                                                                                                pDue, pGrossBillValue, isCreditBill, pnetValue, pAdvanceReceived, dtAmtReceivedDetails, pAmtReceived, pReceivedBy, LocationID, dserviceCharge, TPAPaymentStatus, PayerType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            }
            else if (sType == "TaskFlow")
            {
                cmdInsertVisit = Command.pInsertPatientDueClearTaskCommand(visitID, orgID, CreatedBy, dtDueChart,
                                    pAmountReceived, pRefundAmount, pDiscountAmount,
                                                                                                                                pDue, pGrossBillValue, isCreditBill, pnetValue, pAdvanceReceived, dtAmtReceivedDetails, pAmtReceived, pReceivedBy, LocationID, dserviceCharge, TPAPaymentStatus, PayerType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            }
            else
            {
                cmdInsertVisit = Command.pUpdatePatientBillItemsDetailsCommand(visitID, orgID, CreatedBy, dtDueChart,
                                    pAmountReceived, pRefundAmount, pDiscountAmount,
                                                                                                                              pDue, pGrossBillValue, isCreditBill, pnetValue, pAdvanceReceived, dtAmtReceivedDetails, pAmtReceived, pReceivedBy, dserviceCharge, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            }

            using (DBEngine dbEngine = new DBEngine(true))
            {
                DataSet ds = new DataSet();
                ReceiptNo = "0";
                dbEngine.ExecuteDataSet(cmdInsertVisit, out ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ReceiptNo = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                    Int64.TryParse(ds.Tables[0].Rows[0].ItemArray[1].ToString(), out IpIntermediateID);
                    sPaymentType = ds.Tables[0].Rows[0].ItemArray[2].ToString();

                }
                ireturnStatus = 0;
            }
            return ireturnStatus;
        }

        public long GetInPatientVisitDetails(long patientID, out List<PatientVisit> lstPatientVisit)
        {
            long returnCode = -1;
            lstPatientVisit = new List<PatientVisit>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetInPatientVisitDetailsCommand(patientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientVisit);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading get visit details", ex);
            }
            return returnCode;
        }

        public long GetInPatientBills(long patientID, long pOrgID,
                                             long pVisitID,
                                             out List<BillingDetails> lstPatientVisit,
                                             out List<Patient> lstpatient, out decimal pAmountReceived, out decimal pGrandTotal, out decimal dServiceCharge)
        {
            long returnCode = -1;
            pAmountReceived = 0;
            pGrandTotal = 0;
            dServiceCharge = 0;

            lstPatientVisit = new List<BillingDetails>();
            lstpatient = new List<Patient>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetInPatientBillsCommand(pVisitID, pOrgID, patientID, out pAmountReceived, out pGrandTotal, out dServiceCharge, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientVisit);

                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[1], out lstpatient);
                    }
                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        Decimal.TryParse(ds.Tables[2].Rows[0].ItemArray[0].ToString(), out pAmountReceived);
                        Decimal.TryParse(ds.Tables[2].Rows[0].ItemArray[2].ToString(), out dServiceCharge);
                        Decimal.TryParse(ds.Tables[2].Rows[0].ItemArray[1].ToString(), out pGrandTotal);

                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading get visit details", ex);
            }
            return returnCode;
        }

        public long UpdatePatientBillingStatus(List<PatientDueChart> lstBillingDetails, out long lReceiptNo)
        {
            long ireturnStatus = -1;
            lReceiptNo = 0;

            DataTable dtDatas = new DataTable();
            dtDatas = UDT_DAL.ConvertToUDTPatientDueChart(lstBillingDetails);

            SqlCommand cmdInsertVisit = new SqlCommand();
            DataSet ds = new DataSet();

            cmdInsertVisit = Command.pUpdatePatientBillingStatusCommand(dtDatas, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(true))
            {
                dbEngine.ExecuteDataSet(cmdInsertVisit, out ds);
                if (ds.Tables.Count > 0)
                {
                    long.TryParse(ds.Tables[0].Rows[0].ItemArray[0].ToString(), out lReceiptNo);
                }
                ireturnStatus = 0;
            }
            return ireturnStatus;
        }

        public long GetIPPaymentTypes(long roleID, long ParentID,
                                            out List<IpPayments> lstIpPayments)
        {
            long returnCode = -1;
            lstIpPayments = new List<IpPayments>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetIPPaymentTypesCommand(roleID, ParentID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstIpPayments);
                    }

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading get visit details", ex);
            }
            return returnCode;
        }

        public long InsertAdditionalBillItems(PatientDueChart pDueChart, string pType, out string InterimBillNo)
        {
            long ireturnStatus = -1;
            SqlCommand cmdInsertVisit = new SqlCommand();
            cmdInsertVisit = Command.pInsertPatientBillIndividualCommand(pDueChart.DetailsID, pDueChart.VisitID,
                                    pDueChart.PatientID, pDueChart.FeeType, pDueChart.FeeID,
                                    pDueChart.Description, pDueChart.Comments,
                                    pDueChart.FromDate, pDueChart.ToDate, pDueChart.Status,
                                    pDueChart.Unit, pDueChart.CreatedBy,
                                                                                                                pDueChart.IsReimbursable, pType, out InterimBillNo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(true))
            {
                dbEngine.ExecuteTransactionalNonQuery(cmdInsertVisit);
                InterimBillNo = Convert.ToString(cmdInsertVisit.Parameters["@pInterimBillNumber"].Value == DBNull.Value ? "0" : cmdInsertVisit.Parameters["@pInterimBillNumber"].Value);
                ireturnStatus = 0;
            }
            return ireturnStatus;
        }


        public long GetIPBillSettlement(long pVisitID, long patientID, long orgID,
            out decimal ptotalReceived, out decimal ptotalAdvance, out decimal pTotalDue,
            out decimal pPreviousRefund, out List<PatientDueChart> lstIpPayments,
            out List<PatientDueChart> lstBedBooking, out decimal pTotSurgeryAdv, out decimal pTotSurgeryAmt,
                                                        out List<Patient> lstPatientDetail,
                                                        out List<Organization> lstOrganization,
                                                        out List<Physician> physicianName,
                                                        out List<Taxmaster> lstTaxes,
                                                        out List<FinalBill> lstFinalBill,
                                                        out decimal dPayerTotal,
                                                        out decimal pNonMedicalAmtPaid,
                                                        out decimal pCoPayment,
                                                        out decimal pExcess, out string AdmissionDate, out string MaxBillDate, out string IsVisitHaveChild, int RoomTypeID)
        {
            long returnCode = -1;
            lstIpPayments = new List<PatientDueChart>();
            lstBedBooking = new List<PatientDueChart>();
            lstOrganization = new List<Organization>();
            lstPatientDetail = new List<Patient>();
            physicianName = new List<Physician>();
            lstTaxes = new List<Taxmaster>();
            lstFinalBill = new List<FinalBill>();

            ptotalReceived = 0;
            ptotalAdvance = 0;
            pTotalDue = 0;
            pPreviousRefund = 0;
            pTotSurgeryAdv = 0;
            pTotSurgeryAmt = 0;
            dPayerTotal = 0;
            pNonMedicalAmtPaid = decimal.Zero;
            pCoPayment = decimal.Zero;
            pExcess = decimal.Zero;
            AdmissionDate = "01/01/1753";
            MaxBillDate = "01/01/1753";
            IsVisitHaveChild = string.Empty;
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetIPBillSettlementCommand(pVisitID, patientID, orgID, out ptotalReceived, out ptotalAdvance, out pTotalDue, out pPreviousRefund,
                                                                                                        out pTotSurgeryAdv, out pTotSurgeryAmt, out pNonMedicalAmtPaid, out pCoPayment, out pExcess, out  AdmissionDate, out MaxBillDate, UDT_DAL.ConvertToUDT_Context(globalContextDetails), RoomTypeID);
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstIpPayments);
                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[1], out lstBedBooking);
                    }
                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPatientDetail);
                    }
                    if (ds.Tables[3].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[3], out lstOrganization);
                    }
                    if (ds.Tables[4].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[4], out lstTaxes);
                    }
                    if (ds.Tables[5].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[5], out physicianName);
                    }
                    if (ds.Tables[6].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[6], out lstFinalBill);
                    }
                    if (ds.Tables[7].Rows.Count > 0)
                    {
                        Decimal.TryParse(ds.Tables[7].Rows[0].ItemArray[0].ToString(), out ptotalReceived);
                        Decimal.TryParse(ds.Tables[7].Rows[0].ItemArray[1].ToString(), out ptotalAdvance);
                        Decimal.TryParse(ds.Tables[7].Rows[0].ItemArray[2].ToString(), out pTotalDue);
                        Decimal.TryParse(ds.Tables[7].Rows[0].ItemArray[3].ToString(), out pPreviousRefund);
                        Decimal.TryParse(ds.Tables[7].Rows[0].ItemArray[4].ToString(), out pTotSurgeryAdv);
                        Decimal.TryParse(ds.Tables[7].Rows[0].ItemArray[5].ToString(), out pTotSurgeryAmt);
                        Decimal.TryParse(ds.Tables[7].Rows[0].ItemArray[6].ToString(), out dPayerTotal);
                        Decimal.TryParse(ds.Tables[7].Rows[0].ItemArray[7].ToString(), out pNonMedicalAmtPaid);
                        Decimal.TryParse(ds.Tables[7].Rows[0].ItemArray[8].ToString(), out pCoPayment);
                        Decimal.TryParse(ds.Tables[7].Rows[0].ItemArray[9].ToString(), out pExcess);
                        AdmissionDate = ds.Tables[7].Rows[0].ItemArray[10].ToString();
                        MaxBillDate = ds.Tables[7].Rows[0].ItemArray[11].ToString();
                        IsVisitHaveChild = ds.Tables[7].Rows[0].ItemArray[12].ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading get visit details", ex);
            }
            return returnCode;
        }

        public long GetIPBillSettlement_CreditBill(long pVisitID, long patientID, long orgID,
            out decimal ptotalReceived, out decimal ptotalAdvance, out decimal pTotalDue,
            out decimal pPreviousRefund, out List<PatientDueChart> lstIpPayments,
            out List<PatientDueChart> lstBedBooking, out decimal pTotSurgeryAdv, out decimal pTotSurgeryAmt,
                                                        out List<Patient> lstPatientDetail,
                                                        out List<Organization> lstOrganization,
                                                        out List<Physician> physicianName,
                                                        out List<Taxmaster> lstTaxes,
                                                        out List<FinalBill> lstFinalBill,
                                                        out decimal dPayerTotal,
                                                        out decimal pNonMedicalAmtPaid,
                                                        out decimal pCoPayment,
                                                        out decimal pExcess, out string AdmissionDate, out string MaxBillDate)
        {
            long returnCode = -1;
            lstIpPayments = new List<PatientDueChart>();
            lstBedBooking = new List<PatientDueChart>();
            lstOrganization = new List<Organization>();
            lstPatientDetail = new List<Patient>();
            physicianName = new List<Physician>();
            lstTaxes = new List<Taxmaster>();
            lstFinalBill = new List<FinalBill>();

            ptotalReceived = 0;
            ptotalAdvance = 0;
            pTotalDue = 0;
            pPreviousRefund = 0;
            pTotSurgeryAdv = 0;
            pTotSurgeryAmt = 0;
            dPayerTotal = 0;
            pNonMedicalAmtPaid = decimal.Zero;
            pCoPayment = decimal.Zero;
            pExcess = decimal.Zero;
            AdmissionDate = "01/01/1753";
            MaxBillDate = "01/01/1753";
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetIPBillSettlement_CreditBillCommand(pVisitID, patientID, orgID, out ptotalReceived, out ptotalAdvance, out pTotalDue, out pPreviousRefund,
                                                                                                        out pTotSurgeryAdv, out pTotSurgeryAmt, out pNonMedicalAmtPaid, out pCoPayment, out pExcess, out  AdmissionDate, out MaxBillDate, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstIpPayments);
                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[1], out lstBedBooking);
                    }
                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPatientDetail);
                    }
                    if (ds.Tables[3].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[3], out lstOrganization);
                    }
                    if (ds.Tables[4].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[4], out lstTaxes);
                    }
                    if (ds.Tables[5].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[5], out physicianName);
                    }
                    if (ds.Tables[6].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[6], out lstFinalBill);
                    }
                    if (ds.Tables[7].Rows.Count > 0)
                    {
                        Decimal.TryParse(ds.Tables[7].Rows[0].ItemArray[0].ToString(), out ptotalReceived);
                        Decimal.TryParse(ds.Tables[7].Rows[0].ItemArray[1].ToString(), out ptotalAdvance);
                        Decimal.TryParse(ds.Tables[7].Rows[0].ItemArray[2].ToString(), out pTotalDue);
                        Decimal.TryParse(ds.Tables[7].Rows[0].ItemArray[3].ToString(), out pPreviousRefund);
                        Decimal.TryParse(ds.Tables[7].Rows[0].ItemArray[4].ToString(), out pTotSurgeryAdv);
                        Decimal.TryParse(ds.Tables[7].Rows[0].ItemArray[5].ToString(), out pTotSurgeryAmt);
                        Decimal.TryParse(ds.Tables[7].Rows[0].ItemArray[6].ToString(), out dPayerTotal);
                        Decimal.TryParse(ds.Tables[7].Rows[0].ItemArray[7].ToString(), out pNonMedicalAmtPaid);
                        Decimal.TryParse(ds.Tables[7].Rows[0].ItemArray[8].ToString(), out pCoPayment);
                        Decimal.TryParse(ds.Tables[7].Rows[0].ItemArray[9].ToString(), out pExcess);
                        AdmissionDate = ds.Tables[7].Rows[0].ItemArray[10].ToString();
                        MaxBillDate = ds.Tables[7].Rows[0].ItemArray[11].ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading get visit details", ex);
            }
            return returnCode;
        }





        public long GetConsolidatedPharmacyBill(long pVisitID, out decimal AmtRcvd, out decimal GrossBill, out decimal Discount, out List<BillingDetails> lstBillingDetails, out List<BillingDetails> lstBillingRefundDetails, out List<Patient> lstPatientDetail, out List<FinalBill> lstFinalBill, out List<FinalBill> lstFinalbillDtls)
        {
            long returnCode = -1;
            lstPatientDetail = new List<Patient>();
            lstBillingDetails = new List<BillingDetails>();
            lstFinalBill = new List<FinalBill>();
            lstFinalbillDtls = new List<FinalBill>();
            lstBillingRefundDetails = new List<BillingDetails>();
            AmtRcvd = 0;
            GrossBill = 0;
            Discount = 0;

            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetConsolidatedPharmacyBillCommand(pVisitID, out AmtRcvd, out GrossBill, out Discount, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBillingDetails);
                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[1], out lstBillingRefundDetails);
                    }
                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPatientDetail);
                    }
                    if (ds.Tables[3].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[3], out lstFinalBill);
                    }
                    if (ds.Tables[4].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[4], out lstFinalbillDtls);
                    }

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading get visit details", ex);
            }
            return returnCode;
        }


        public long SaveIPFinalBill(List<PatientDueChart> pPatientIndList, long visitID,
                                                    long CreatedBy, long orgID, decimal pAmountReceived, decimal pRefundAmount, string sReasonForRefund, int payamenttype, string bankname, long checkno,
                                                    decimal pDiscountAmount, decimal pDue, decimal pGrossBillValue, string isCreditBill,
                                                    decimal pnetValue, decimal pAdvanceReceived, DataTable dtAmtReceivedDetails, decimal pAmtReceived,
                                                    long pReceivedBy, string dischargeStatus, DateTime dischargeDate,
                                                    List<TaxBillDetails> lstTaxDetails, string discountReason,
                                                    decimal dserviceCharge, string pVisitState,
                                                    decimal pNonMedicalAmtPaid, decimal pCoPayment, decimal pExcess,
                                                    out string ReceiptNo, out long sStartID, out long sEndID,
                                                    out long IPInterID, out string sType, decimal dRoundOff, int RoomTypeID, List<VisitClientMapping> lstVisitClientMapping)
        {
            long ireturnStatus = -1;
            SqlCommand cmdInsertVisit = new SqlCommand();
            DataTable dtTax = new DataTable();
            DataTable dtPatientList = new DataTable();
            DataTable dtVisitClientmapping = new DataTable();

            ReceiptNo = "";
            sStartID = 0;
            sEndID = 0;
            IPInterID = 0;
            sType = "";

            try
            {
                dtPatientList = UDT_DAL.ConvertToUDTPatientDueChartForIP(pPatientIndList);
                dtTax = UDT_DAL.ConvertToUDTaxBillDetails(lstTaxDetails);
                dtVisitClientmapping = UDT_DAL.ConvertToVisitClientMapping(lstVisitClientMapping);
                cmdInsertVisit = Command.pSaveIPFinalBillCommand(visitID, orgID, CreatedBy, dtPatientList,
                                    pAmountReceived, pRefundAmount, sReasonForRefund, payamenttype, bankname, checkno,
                                    pDiscountAmount,
                                    pDue, pGrossBillValue, isCreditBill, pnetValue,
                                    pAdvanceReceived, dtAmtReceivedDetails, pAmtReceived,
                                    CreatedBy, dischargeStatus, dischargeDate, dtTax, discountReason, dserviceCharge,
                                                                                                    pVisitState, dRoundOff, pNonMedicalAmtPaid, pCoPayment, pExcess, UDT_DAL.ConvertToUDT_Context(globalContextDetails), RoomTypeID, dtVisitClientmapping);
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    DataSet ds = new DataSet();
                    dbEngine.ExecuteDataSet(cmdInsertVisit, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        ReceiptNo = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                        Int64.TryParse(ds.Tables[0].Rows[0].ItemArray[1].ToString(), out IPInterID);
                        sType = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                        Int64.TryParse(ds.Tables[0].Rows[0].ItemArray[3].ToString(), out sStartID);
                        Int64.TryParse(ds.Tables[0].Rows[0].ItemArray[4].ToString(), out sEndID);

                    }
                    ireturnStatus = 0;
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateIPFinalBill in PatientVisit_DAL", ex);
            }
            return ireturnStatus;
        }


        public long UpdateIPFinalBill(List<PatientDueChart> pPatientIndList, long visitID,
                                                    long CreatedBy, long orgID, decimal pAmountReceived, decimal pRefundAmount, string sReasonForRefund, int payamenttype, string bankname, long checkno,
                                                    decimal pDiscountAmount, decimal pDue, decimal pGrossBillValue, string isCreditBill,
                                                    decimal pnetValue, decimal pAdvanceReceived, DataTable dtAmtReceivedDetails, decimal pAmtReceived,
                                                    long pReceivedBy, string dischargeStatus, DateTime dischargeDate,
                                                    List<TaxBillDetails> lstTaxDetails, string discountReason,
                                                    decimal dserviceCharge, string pVisitState,
                                                    decimal pNonMedicalAmtPaid, decimal pCoPayment, decimal pExcess,
                                                    out string ReceiptNo, out long sStartID, out long sEndID,
                                                    out long IPInterID, out string sType, decimal dRoundOff, string BillDate, int RoomTypeID, List<VisitClientMapping> lstVisitClientMapping)
        {
            long ireturnStatus = -1;
            SqlCommand cmdInsertVisit = new SqlCommand();
            DataTable dtTax = new DataTable();
            DataTable dtPatientList = new DataTable();
            DataTable dtVisitClientmapping = new DataTable();

            ReceiptNo = "";
            sStartID = 0;
            sEndID = 0;
            IPInterID = 0;
            sType = "";

            try
            {

                dtPatientList = UDT_DAL.ConvertToUDTPatientDueChartForIP(pPatientIndList);
                dtTax = UDT_DAL.ConvertToUDTaxBillDetails(lstTaxDetails);
                dtVisitClientmapping = UDT_DAL.ConvertToVisitClientMapping(lstVisitClientMapping);

                cmdInsertVisit = Command.pUpdateIPFinalBillCommand(visitID, orgID, CreatedBy, dtPatientList,
                                    pAmountReceived, pRefundAmount, sReasonForRefund, payamenttype, bankname, checkno,
                                    pDiscountAmount,
                                    pDue, pGrossBillValue, isCreditBill, pnetValue,
                                    pAdvanceReceived, dtAmtReceivedDetails, pAmtReceived,
                                    CreatedBy, dischargeStatus, dischargeDate, dtTax, discountReason, dserviceCharge,
                                                                                                    pVisitState, dRoundOff, pNonMedicalAmtPaid, pCoPayment, pExcess, BillDate, UDT_DAL.ConvertToUDT_Context(globalContextDetails), RoomTypeID, dtVisitClientmapping);
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    DataSet ds = new DataSet();
                    dbEngine.ExecuteDataSet(cmdInsertVisit, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        ReceiptNo = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                        Int64.TryParse(ds.Tables[0].Rows[0].ItemArray[1].ToString(), out IPInterID);
                        sType = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                        Int64.TryParse(ds.Tables[0].Rows[0].ItemArray[3].ToString(), out sStartID);
                        Int64.TryParse(ds.Tables[0].Rows[0].ItemArray[4].ToString(), out sEndID);

                    }
                    ireturnStatus = 0;
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateIPFinalBill in PatientVisit_DAL", ex);
            }
            return ireturnStatus;
        }

        public long EditIPFinalBillAfterDischarge(List<PatientDueChart> pPatientIndList, long visitID,
                                                   long CreatedBy, long orgID, decimal pAmountReceived, decimal pRefundAmount, string sReasonForRefund, int payamenttype, string bankname, long checkno,
                                                   decimal pDiscountAmount, decimal pDue, decimal pGrossBillValue, string isCreditBill,
                                                   decimal pnetValue, decimal pAdvanceReceived, DataTable dtAmtReceivedDetails, decimal pAmtReceived,
                                                   long pReceivedBy, string dischargeStatus, DateTime dischargeDate,
                                                   List<TaxBillDetails> lstTaxDetails, string discountReason,
                                                   decimal dserviceCharge, string pVisitState,
                                                   decimal pNonMedicalAmtPaid, decimal pExcess,
                                                   out string ReceiptNo, out long sStartID, out long sEndID,
                                                   out long IPInterID, out string sType, decimal dRoundOff)
        {
            long ireturnStatus = -1;
            SqlCommand cmdInsertVisit = new SqlCommand();
            DataTable dtTax = new DataTable();
            ReceiptNo = "";
            sStartID = 0;
            sEndID = 0;
            IPInterID = 0;
            sType = "";

            try
            {
                dtTax = UDT_DAL.ConvertToUDTPatientDueChartForIP(pPatientIndList);
                cmdInsertVisit = Command.pEditIPFinalBillAfterDischargeCommand(visitID, orgID, CreatedBy, dtTax,
                                    pAmountReceived, pRefundAmount, sReasonForRefund, payamenttype, bankname, checkno,
                                    pDiscountAmount,
                                    pDue, pGrossBillValue, isCreditBill, pnetValue,
                                    pAdvanceReceived, dtAmtReceivedDetails, pAmtReceived,
                                    CreatedBy, dischargeStatus, dischargeDate, dtTax, discountReason, dserviceCharge,
                                                                                                    pVisitState, dRoundOff, pNonMedicalAmtPaid, pExcess, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    DataSet ds = new DataSet();
                    dbEngine.ExecuteDataSet(cmdInsertVisit, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        ReceiptNo = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                        Int64.TryParse(ds.Tables[0].Rows[0].ItemArray[1].ToString(), out IPInterID);
                        sType = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                        Int64.TryParse(ds.Tables[0].Rows[0].ItemArray[3].ToString(), out sStartID);
                        Int64.TryParse(ds.Tables[0].Rows[0].ItemArray[4].ToString(), out sEndID);

                    }
                    ireturnStatus = 0;
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing EditIPFinalBill in PatientVisit_DAL", ex);
            }
            return ireturnStatus;
        }

        public long pGetVisitSearchDetailbyPNo(string patientNo, string pName, string phoneNo, string fromDate, string toDate,
            int currentOrgID, List<TrustedOrgDetails> lstTOD, string pSearchType, out List<PatientVisit> lstPatientVisit,
            string Labno, long Locationid, long ClientID, int VisitType, string WardNo, string status, int priority, int Deptid,
            int ReferringPhyID, long ReferringorgID, TrustedOrgActions objTrustedOrgActions, string VisitNo, long TestID,
            string TestType, long ZoneID, long CourierBoyId, List<PatientDisPatchDetails> lstDispatchDetails, int startRowIndex, int pageSize, out int totalRows, string Prefernce)
        {
            long returnCode = -1;
            totalRows = -1;
            lstPatientVisit = new List<PatientVisit>();
            IDataReader dataReader = null;

            DataTable dtDispatchDetails = UDT_DAL.ConvertToUDTDisPatchMode(lstDispatchDetails);
            DataTable dtOrgIDs = UDT_DAL.ConvertToGetOrgIDs(lstTOD);
            DataTable DtLDetail = UDT_DAL.ConvertToTrustedOrgActions(objTrustedOrgActions);
            try
            {
                SqlCommand cmd = Command.pGetVisitSearchDetailbyPNoCommand(patientNo, pName, phoneNo, fromDate, toDate, currentOrgID, dtOrgIDs, pSearchType, Labno, Locationid, ClientID, VisitType, WardNo, status, priority, Deptid, ReferringPhyID, ReferringorgID, DtLDetail, VisitNo, TestID, TestType, ZoneID, CourierBoyId, dtDispatchDetails, UDT_DAL.ConvertToUDT_Context(globalContextDetails), startRowIndex, pageSize, out totalRows, Prefernce);

                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstPatientVisit);
                        dataReader.Close();

                    }
                    Int32.TryParse(cmd.Parameters["@totalRows"].Value.ToString(), out totalRows);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading get patient visit search details by PNo", ex);
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

        public long UpdatePatientDueChart(List<PatientDueChart> lstBillingDetails)
        {
            long ireturnStatus = -1;

            DataTable dtDatas = new DataTable();
            dtDatas = UDT_DAL.ConvertToUDTPatientDueChart(lstBillingDetails);

            SqlCommand cmdInsertVisit = new SqlCommand();
            cmdInsertVisit = Command.pUpdatePatientDueChartCommand(dtDatas, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(true))
            {
                dbEngine.ExecuteTransactionalNonQuery(cmdInsertVisit);
                ireturnStatus = 0;
            }
            return ireturnStatus;
        }

        public long GetSecuredPPage(long pVisitID, long pPID, out List<Patient> lstPatient, out List<Speciality> lstSpeciality, out List<AllPhysicianSchedules> lstPhysicianSchedule)
        {
            long returnCode = -1;

            lstPatient = new List<Patient>();
            lstSpeciality = new List<Speciality>();
            lstPhysicianSchedule = new List<AllPhysicianSchedules>();
            try
            {
                SqlCommand cmd = Command.pGetSecuredPPageCommand(pVisitID, pPID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();

                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatient);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstSpeciality);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPhysicianSchedule);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in  DAL GetSecuredPPage", ex);
            }

            return returnCode;
        }
        public long GetCorporateClientByVisit(long PatientVisitID, out List<PatientVisit> lstPatientVisit)
        {
            long returnCode = -1;
            lstPatientVisit = new List<PatientVisit>();
            SqlCommand cmd = Command.pGetCorporateClientByVisitCommand(PatientVisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientVisit);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetCorporateClientByVisit in PatientVisit_DAL", ex);
            }
            return returnCode;
        }
        public long InsertOutPatientItems(List<PatientDueChart> pPatientConsultation, long visitID, long CreatedBy, long PatientID, long lFInalBillID, out long loutBillID, long lOrgID)
        {
            long ireturnStatus = -1;
            loutBillID = 0;

            DataTable dtPatientItems = UDT_DAL.ConvertToUDTPatientDueChart(pPatientConsultation);
            SqlCommand cmdInsertVisit = Command.pInsertPatientItemsForOPCommand(dtPatientItems, visitID, CreatedBy, PatientID, lFInalBillID, out loutBillID, lOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(true))
            {
                dbEngine.ExecuteTransactionalNonQuery(cmdInsertVisit);

                Int64.TryParse(cmdInsertVisit.Parameters["@pOutBillID"].Value.ToString(), out loutBillID);
                ireturnStatus = 0;
            }
            return ireturnStatus;
        }

        public long GetPatientWaitTime(DateTime pFromTime, DateTime pToDate, long lOrgID, out List<PatientWaitTime> lstWaitTime)
        {
            long returnCode = -1;
            lstWaitTime = new List<PatientWaitTime>();
            SqlCommand cmd = Command.pGetPatientWaitTimeCommand(pFromTime, pToDate, lOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstWaitTime);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientWaitTime in PatientVisit_DAL", ex);
            }
            return returnCode;
        }

        public long GetPatientLatestVisit(long pPatientID, out List<PatientVisit> lstPatientVisit, out List<OrderedInvestigations> lstOrdered)
        {
            long returnCode = -1;
            lstPatientVisit = new List<PatientVisit>();
            lstOrdered = new List<OrderedInvestigations>();

            SqlCommand cmd = Command.pGetPatientVisitbyPatientidCommand(pPatientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientVisit);
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstOrdered);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientLatestVisit in PatientVisit_DAL", ex);
            }
            return returnCode;
        }

        public long GetRecommendationDetails(int orgID, out List<PatientVisit> lstPatientVisit)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetDetailsOfPatientRecommendationCommand(orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstPatientVisit = new List<PatientVisit>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientVisit);
            }

            return returnCode;
        }
        public long GetProcedureDetailsForVisit(long patientVisitID, int OrgID, out List<PatientTreatmentProcedure> lPatProcedure)
        {
            long returncode = -1;
            lPatProcedure = new List<PatientTreatmentProcedure>();
            SqlCommand cmd = Command.pGetPatientTreatmentProcedureCommand(patientVisitID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                DataSet ds = new DataSet();
                using (DBEngine db = new DBEngine())
                {

                    db.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        Utilities.ConvertTo(ds.Tables[0], out lPatProcedure);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return returncode;
        }
        public long GetGeneralBillItems(int orgID, long visitID, out List<GeneralBillingItems> lstGBI)
        {
            long returnCode = -1;
            lstGBI = new List<GeneralBillingItems>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetGeneralBillItemsCommand(orgID, visitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstGBI);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetGeneralBillItems DAL", ex);
            }

            return returnCode;

        }

        public long GetCorpoRateGeneralBillItems(int orgID, long visitID, out List<GeneralBillingItems> lstGBI)
        {
            long returnCode = -1;
            lstGBI = new List<GeneralBillingItems>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetCorpoRateGeneralBillItemsCommand(orgID, visitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstGBI);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetGeneralBillItems DAL", ex);
            }

            return returnCode;

        }

        public long UpdateoutsourceGrid(List<OutsourcingDetail> lstOutSourcingDetails, long CreatedBy, long visitID, DateTime receivedDate, int OrgID, string Status)
        {
            long returnCode = -1;
            DataTable dtOutSourceDetails = UDT_DAL.ConvertToUDTOutSourcingDetails(lstOutSourcingDetails);
            //long identifyingtype, string filename, string filepath, long visitid, System.DateTime receiveddate, string refid, int orgid, System.Data.DataTable ContextInfo
            SqlCommand cmd = Command.pUpdateoutsourceGridCommand(dtOutSourceDetails, CreatedBy, visitID, receivedDate, OrgID, Status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@return", SqlDbType.Int);
            cmd.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            try
            {

                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt16(cmd.Parameters["@return"].Value.ToString());
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing Update Bank Payment_DAL.cs", ex);
            }
            return returnCode;
        }

        public long OutsourceGrid(long Patientvisitid,out List<OutsourcingDetail> lstOutsourcingDetail)
        {
            long returnCode = -1;

            lstOutsourcingDetail = new List<OutsourcingDetail>();
            DataSet ds = new DataSet();
              IDataReader dataReader = null;
            
            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    SqlCommand cmd = Command.pOutsourcegridCommand(Patientvisitid,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstOutsourcingDetail);
                        dataReader.Close();
                    }
                }
                
            }
            catch (Exception ex)
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
                CLogger.LogError("Error while loading GetAllVisitSearchDetailByPatient PatientVisit_DAL", ex);
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

        public long GetVisitSearchDetailByPatient(string patientNo, string pName, string pVisitType, string fromDate, string toDate, int currentOrgID, List<TrustedOrgDetails> lstTOD, string pSearchType, int PageSize, int startRowIndex, out int totalRows, out List<PatientVisit> lstPatientVisit, string DeptCode, long SpecialityID, long RefPhyId, long ZoneId, out List<PatientVisit> lsttotalPatientCount, string VisitNO, long orgaddressID, long ClientID, long LoginID, int IsTRFVerified)
        {
            long returnCode = -1;
            int rsCount = 0;
            lstPatientVisit = new List<PatientVisit>();
            lsttotalPatientCount = new List<PatientVisit>();
            IDataReader dataReader = null;
            totalRows = 0;
            try
            {
                DataTable dtOrgIDs = UDT_DAL.ConvertToGetOrgIDs(lstTOD);
                SqlCommand cmd = Command.pGetVisitSearchDetailByPatientCommand(patientNo, pName, pVisitType, fromDate, toDate, currentOrgID, dtOrgIDs, pSearchType, PageSize, startRowIndex, out totalRows, UDT_DAL.ConvertToUDT_Context(globalContextDetails), DeptCode, SpecialityID, RefPhyId, ZoneId, VisitNO, orgaddressID, ClientID, LoginID, IsTRFVerified);
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstPatientVisit);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lsttotalPatientCount);
                            }

                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                    Int32.TryParse(cmd.Parameters["@totalRows"].Value.ToString(), out totalRows);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetVisitSearchDetailByPatient", ex);
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

        public long GetAllVisitSearchDetailByPatient(string patientNo, string pName, string pVisitType, string fromDate, string toDate, int currentOrgID, List<TrustedOrgDetails> lstTOD, string pSearchType, int PageSize, int startRowIndex, out int totalRows, out List<PatientVisit> lstPatientVisit, string DeptCode, long SpecialityID, long RefPhyId, long ZoneId, out List<PatientVisit> lsttotalPatientCount, string VisitNO, long orgaddressID, long ClientID, long LoginID)
        {
            long returnCode = -1;
            totalRows = 0;
            lstPatientVisit = new List<PatientVisit>();
            lsttotalPatientCount = new List<PatientVisit>();
            DataSet ds = new DataSet();
            DataTable dtOrgIDs = UDT_DAL.ConvertToGetOrgIDs(lstTOD);
            IDataReader dataReader = null;
            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    SqlCommand cmd = Command.pGetAllVisitSearchDetailByPatientCommand(patientNo, pName, pVisitType, fromDate, toDate, currentOrgID, dtOrgIDs, pSearchType, PageSize, startRowIndex, out totalRows, UDT_DAL.ConvertToUDT_Context(globalContextDetails), DeptCode, SpecialityID, RefPhyId, ZoneId, VisitNO, orgaddressID, ClientID, LoginID);
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstPatientVisit);
                        dataReader.Close();
                    }
                }
            }
              catch (Exception ex)
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
                CLogger.LogError("Error while loading GetAllVisitSearchDetailByPatient PatientVisit_DAL", ex);
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

        public long GetVisitIDByBillID(long BillID, int OrgID, string Year, out long VisitID)
        {
            long returnCode = -1;
            SqlCommand objCommand = new SqlCommand();
            objCommand = Command.pGetVisitIDByBillIDCommand(BillID, OrgID, Year, out VisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            objCommand.Parameters.Add("@Return", SqlDbType.Int);
            objCommand.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(objCommand);
                    returnCode = Convert.ToInt64(objCommand.Parameters["@Return"].Value);
                    VisitID = Convert.ToInt32(objCommand.Parameters["@pVisitID"].Value);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing GetVisitIDByBillID in PatientVisit_DAL", excep);
            }
            return returnCode;
        }

        public long GetPatientVisitSummary(long pID, out int pOPCount, out int pIPCount, out string pPreVisitDate, out string pPreVisitType, out string pPatientNo)
        {
            long returnCode = -1;
            pOPCount = -1;
            pIPCount = -1;
            pPreVisitDate = string.Empty;
            pPreVisitType = string.Empty;
            pPatientNo = string.Empty;
            DataSet ds = new DataSet();

            try
            {
                SqlCommand cmd = Command.pGetPatientVisitSummaryCommand(pID, out pOPCount, out pIPCount, out pPreVisitDate, out pPreVisitType, out pPatientNo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    pOPCount = Convert.ToInt32(cmd.Parameters["@pOPCount"].Value);
                    pIPCount = Convert.ToInt32(cmd.Parameters["@pIPCount"].Value);
                    pPreVisitDate = cmd.Parameters["@pPreVisitDate"].Value.ToString();
                    pPreVisitType = cmd.Parameters["@pPreVisitType"].Value.ToString();
                    pPatientNo = cmd.Parameters["@pPatientNo"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetPatientVisitSummary", ex);
            }

            return returnCode;
        }
        public long GetPatientVisitForRefPhy(long patientID, int pVisitID, int pOrgID, int pVisitType, out List<PatientVisit> lstPatientVisit,
            out List<OrderedInvestigations> lOrderedInv, out string pPatientName, out string pPatientNo, long LoginID)
        {
            long returnCode = -1;
            lstPatientVisit = new List<PatientVisit>();
            lOrderedInv = new List<OrderedInvestigations>();
            pPatientName = string.Empty;
            pPatientNo = string.Empty;
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetVisitDetailsForRefPhyCommand(patientID, pVisitID, pOrgID, pVisitType, out pPatientName, out pPatientNo, LoginID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientVisit);

                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[1], out lOrderedInv);

                    }
                    if (returnCode == 0)
                    {
                        pPatientName = cmd.Parameters["@pPatientName"].Value.ToString().Trim();
                        pPatientNo = cmd.Parameters["@pPatientNumber"].Value.ToString().Trim();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading get visit details", ex);
            }
            return returnCode;
        }

        public long GetRefPhyDetails(long RefPhysicianID, int orgID, out List<ReferingPhysician> lstRefPhys)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstRefPhys = new List<ReferingPhysician>();
            try
            {
                SqlCommand cmd = Command.pGetRefPhyDetailsCommand(RefPhysicianID, orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstRefPhys);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetRefPhyDetails DAL", ex);
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
        public long SaveDynamicColumnMapping(List<DynamicColumnMapping> lstDynamicColumn)
        {
            long returnCode = -1;
            int retValue = -1;
            DataTable dtDynamicColumnData = UDT_DAL.ConvertToUDTDynamicColumnMapping(lstDynamicColumn);

            SqlCommand cmd = new SqlCommand();
            cmd = Command.pInsertDynamicColumnMappingCommand(dtDynamicColumnData, out retValue, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dBEngine = new DBEngine(false))
                {
                    dBEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@returnStatus"].Value);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SaveDynamicColumnMapping PatientVisit_DAL", e);
            }
            return returnCode;
        }

        public long GetInPatientMakeBillEntryDetails(long patientID, out List<PatientVisit> lstPatientVisit, long visitID, out decimal pPreAuthAmount, out string pIsCreditBill,
                                                     out List<PatientDueChart> lstPatientDueChart, long orgID, string selType, out decimal ptotalAdvance,
                                                     out List<AdvancePaidDetails> lstAdvancePaidDetails, out List<SurgeryPackageItems> lstSurgeryPackageItems, out List<SurgeryPackageItems> lstSelectedSurgeryPKG,
                                                     long roleID, long ParentID, out List<IpPayments> lstIpPayments,
                                                     out List<OrderedInvestigations> lstInv, out List<OrderedInvestigations> lstGrp,
                                                     int clientID, string type, out List<PatientInvestigation> lstPatGRP, out List<PatientInvestigation> lstPatInv)
        {
            long returnCode = -1;
            pPreAuthAmount = -1;
            pIsCreditBill = "";
            ptotalAdvance = 0;
            lstPatientVisit = new List<PatientVisit>();
            lstPatientDueChart = new List<PatientDueChart>();
            lstAdvancePaidDetails = new List<AdvancePaidDetails>();
            lstIpPayments = new List<IpPayments>();
            lstPatInv = new List<PatientInvestigation>();
            lstPatGRP = new List<PatientInvestigation>();
            lstInv = new List<OrderedInvestigations>();
            lstGrp = new List<OrderedInvestigations>();
            lstIpPayments = new List<IpPayments>();
            lstSurgeryPackageItems = new List<SurgeryPackageItems>();
            lstSelectedSurgeryPKG = new List<SurgeryPackageItems>();

            try
            {

                DataSet dsIpMakeBillEntry = new DataSet();
                SqlCommand cmd = Command.pGetIPMakeBillEntryCommand(patientID, visitID, out pPreAuthAmount, out pIsCreditBill, orgID, selType, out ptotalAdvance, roleID, ParentID, clientID, type, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out dsIpMakeBillEntry);
                    if (dsIpMakeBillEntry.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(dsIpMakeBillEntry.Tables[0], out lstPatientVisit);
                    }

                    pPreAuthAmount = Convert.ToDecimal(cmd.Parameters["@pPreAuthAmount"].Value.ToString());
                    pIsCreditBill = cmd.Parameters["@pIsCreditBill"].Value.ToString();

                    ptotalAdvance = Convert.ToDecimal(cmd.Parameters["@pTotalAdvance"].Value);



                    if (dsIpMakeBillEntry.Tables[1].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(dsIpMakeBillEntry.Tables[1], out lstPatientDueChart);
                    }

                    if (dsIpMakeBillEntry.Tables[2].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(dsIpMakeBillEntry.Tables[2], out lstAdvancePaidDetails);
                    }

                    if (dsIpMakeBillEntry.Tables[3].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(dsIpMakeBillEntry.Tables[3], out lstSurgeryPackageItems);
                    }
                    if (dsIpMakeBillEntry.Tables[4].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(dsIpMakeBillEntry.Tables[4], out lstSelectedSurgeryPKG);
                    }

                    if (dsIpMakeBillEntry.Tables[5].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(dsIpMakeBillEntry.Tables[5], out lstIpPayments);
                    }


                    if (dsIpMakeBillEntry.Tables[6].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(dsIpMakeBillEntry.Tables[6], out lstInv);

                    }
                    if (dsIpMakeBillEntry.Tables[7].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(dsIpMakeBillEntry.Tables[7], out lstGrp);

                    }



                    if (dsIpMakeBillEntry.Tables[8].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(dsIpMakeBillEntry.Tables[8], out lstPatGRP);
                    }


                    DataSet ds6 = new DataSet();
                    if (dsIpMakeBillEntry.Tables[9].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(dsIpMakeBillEntry.Tables[9], out lstPatInv);
                    }

                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading get IPMakeVisitEntry details DAL", ex);
            }
            return returnCode;
        }


        public long GetInternalExternalPhysician(long pOrgID,
                                        out List<Physician> lstPhysician,
                                        out List<ReferingPhysician> lstReferingPhysician)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetInternalExternalPhysicianCommand(pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstPhysician = new List<Physician>();
            lstReferingPhysician = new List<ReferingPhysician>();
            DataSet ds = new DataSet();

            try
            {

                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(objCommand, out ds);
                }

                if (returnCode == 0)
                {

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstReferingPhysician);
                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPhysician);
                    }

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading get GetInternalExternalPhysician details PatientVisit DAL", ex);
            }

            return returnCode;
        }
        public long pGetAmountReceivedDetailsForIPBILL(long VisitID, out List<AmountReceivedDetails> lstAmtReceived)
        {
            long returnCode = -1;
            lstAmtReceived = new List<AmountReceivedDetails>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetAmountReceivedDetailsForIPBILLCommand(VisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstAmtReceived);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetAmountReceivedDetailsForIPBILL_PatientVisitDAL", ex);
            }
            return returnCode;
        }
        public long GetInterimDueChart(out List<PatientDueChart> lstPatientDueChart, out List<Patient> lstPatient, long orgID, long pPatientID, long pVisitID, string interimBillno, string IsSurgeryBill)
        {
            long returnCode = -1;
            lstPatientDueChart = new List<PatientDueChart>();
            lstPatient = new List<Patient>();
            try
            {
                SqlCommand objCommand = Command.pgetPatientInterimDueListCommand(pVisitID, orgID, pPatientID, interimBillno, IsSurgeryBill, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                DataSet ds = new DataSet();

                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientDueChart);
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPatient);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pgetPatientInterimDueListCommand in PatientVisit_DAL", ex);
            }
            return returnCode;
        }
        public long GetInterimBillDueChart(out List<PatientDueChart> lstPatientDueChart, out List<Patient> lstPatient, long orgID, long pPatientID, long pVisitID, string interimBillno)
        {
            long returnCode = -1;
            lstPatientDueChart = new List<PatientDueChart>();
            lstPatient = new List<Patient>();
            try
            {
                SqlCommand objCommand = Command.pgetPatientInterimDueListCommand(pVisitID, orgID, pPatientID, interimBillno, "N", UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                DataSet ds = new DataSet();

                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientDueChart);
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPatient);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pgetPatientInterimDueListCommand in PatientVisit_DAL", ex);
            }
            return returnCode;
        }

        public long UpdateIPBill(long visitID, long patientID, int OrgID, List<InventoryItemsBasket> lstInventoryItemsBasket, out int returnstatus)
        {
            long returnCode = -1;
            DataTable dtItemsBasket = UDT_DAL.ConvertToInventoryItemsMapping(lstInventoryItemsBasket);
            returnstatus = 0;

            try
            {
                SqlCommand objCommand = Command.pUpdateIPBillCommand(visitID, patientID, OrgID, dtItemsBasket, out returnstatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                DataSet ds = new DataSet();


                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(objCommand);
                    returnstatus = Convert.ToInt32(objCommand.Parameters["@pReturnStatus"].Value);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pUpdateIPBillCommand in PatientVisit_DAL", ex);
            }

            return returnCode;
        }


        public long GetIPBillSettlement_Merge(long pVisitID, long patientID, long orgID,
             out decimal ptotalReceived, out decimal ptotalAdvance, out decimal pTotalDue,
             out decimal pPreviousRefund, out List<PatientDueChart> lstIpPayments,
             out List<PatientDueChart> lstBedBooking, out decimal pTotSurgeryAdv, out decimal pTotSurgeryAmt,
                                                         out List<Patient> lstPatientDetail,
                                                         out List<Organization> lstOrganization,
                                                         out List<Physician> physicianName,
                                                         out List<Taxmaster> lstTaxes,
                                                         out List<FinalBill> lstFinalBill,
                                                         out decimal dPayerTotal,
                                                         out decimal pNonMedicalAmtPaid,
                                                         out decimal pCoPayment,
                                                         out decimal pExcess, out string AdmissionDate, out string MaxBillDate, int RoomTypeID)
        {
            long returnCode = -1;
            lstIpPayments = new List<PatientDueChart>();
            lstBedBooking = new List<PatientDueChart>();
            lstOrganization = new List<Organization>();
            lstPatientDetail = new List<Patient>();
            physicianName = new List<Physician>();
            lstTaxes = new List<Taxmaster>();
            lstFinalBill = new List<FinalBill>();

            ptotalReceived = 0;
            ptotalAdvance = 0;
            pTotalDue = 0;
            pPreviousRefund = 0;
            pTotSurgeryAdv = 0;
            pTotSurgeryAmt = 0;
            dPayerTotal = 0;
            pNonMedicalAmtPaid = decimal.Zero;
            pCoPayment = decimal.Zero;
            pExcess = decimal.Zero;
            AdmissionDate = "01/01/1753";
            MaxBillDate = "01/01/1753";
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetIPBillSettlement_MergeCommand(pVisitID, patientID, orgID, out ptotalReceived, out ptotalAdvance, out pTotalDue, out pPreviousRefund,
                                                                                                        out pTotSurgeryAdv, out pTotSurgeryAmt, out pNonMedicalAmtPaid, out pCoPayment, out pExcess, out  AdmissionDate, out MaxBillDate, UDT_DAL.ConvertToUDT_Context(globalContextDetails), RoomTypeID);
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstIpPayments);
                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[1], out lstBedBooking);
                    }
                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPatientDetail);
                    }
                    if (ds.Tables[3].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[3], out lstOrganization);
                    }
                    if (ds.Tables[4].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[4], out lstTaxes);
                    }
                    if (ds.Tables[5].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[5], out physicianName);
                    }
                    if (ds.Tables[6].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[6], out lstFinalBill);
                    }
                    if (ds.Tables[7].Rows.Count > 0)
                    {
                        Decimal.TryParse(ds.Tables[7].Rows[0].ItemArray[0].ToString(), out ptotalReceived);
                        Decimal.TryParse(ds.Tables[7].Rows[0].ItemArray[1].ToString(), out ptotalAdvance);
                        Decimal.TryParse(ds.Tables[7].Rows[0].ItemArray[2].ToString(), out pTotalDue);
                        Decimal.TryParse(ds.Tables[7].Rows[0].ItemArray[3].ToString(), out pPreviousRefund);
                        Decimal.TryParse(ds.Tables[7].Rows[0].ItemArray[4].ToString(), out pTotSurgeryAdv);
                        Decimal.TryParse(ds.Tables[7].Rows[0].ItemArray[5].ToString(), out pTotSurgeryAmt);
                        Decimal.TryParse(ds.Tables[7].Rows[0].ItemArray[6].ToString(), out dPayerTotal);
                        Decimal.TryParse(ds.Tables[7].Rows[0].ItemArray[7].ToString(), out pNonMedicalAmtPaid);
                        Decimal.TryParse(ds.Tables[7].Rows[0].ItemArray[8].ToString(), out pCoPayment);
                        Decimal.TryParse(ds.Tables[7].Rows[0].ItemArray[9].ToString(), out pExcess);
                        AdmissionDate = ds.Tables[7].Rows[0].ItemArray[10].ToString();
                        MaxBillDate = ds.Tables[7].Rows[0].ItemArray[11].ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading get visit details", ex);
            }
            return returnCode;
        }
        public long GetEligibleRoomAmount(long visitID, long patientID, int OrgID, out decimal pEligibleRoomAmount)
        {
            long returnCode = -1;
            pEligibleRoomAmount = 0;
            try
            {
                SqlCommand objCommand = Command.pGetEligibleRoomAmountCommand(visitID, patientID, OrgID, out pEligibleRoomAmount, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(objCommand);
                    pEligibleRoomAmount = Convert.ToDecimal(objCommand.Parameters["@pEligibleRoomAmount"].Value);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pGetEligibleRoomAmountCommand in PatientVisit_DAL", ex);
            }

            return returnCode;
        }


        public long GetLocation(long orgID, long pLID, long pRID, out List<OrganizationAddress> lstLocation)
        {
            long returnCode = -1;
            lstLocation = new List<OrganizationAddress>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetLocationCommand(Convert.ToInt32(orgID), pLID, pRID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(SqlConnectionKey.SharedSecondary))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstLocation);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetLocation details using pGetLocation sp", ex);
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

        public long SaveRoleDeptLocationMap(int OrgID, List<Role> lstRoleLocation, long pLoginID)
        {
            long returnCode = -1;
            DataTable dtlstLocation = UDT_DAL.ConvertToUDTRole(lstRoleLocation);
            try
            {
                SqlCommand objCommand = Command.pSaveRoleDeptLocationMapCommand(OrgID, dtlstLocation, pLoginID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(objCommand);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pSaveRoleDeptLocationMapCommand in PatientVisit_DAL", ex);
            }

            return returnCode;
        }
        public long GetDepartment(long orgID, long pLID, long pRID, out List<InvDeptMaster> lstInvDeptMaster, out List<InvDeptMaster> lstDeptMaster)
        {
            long returnCode = -1;
            lstInvDeptMaster = new List<InvDeptMaster>();
            lstDeptMaster = new List<InvDeptMaster>();
            try
            {
                SqlCommand cmd = Command.pGetDepartmentCommand(orgID, pLID, pRID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvDeptMaster);
                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[1], out lstDeptMaster);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetLocation details using pGetLocation sp", ex);
            }

            return returnCode;

        }
        public long GetDispatchStatusReports(string fdate, string todate, string sstatus, List<TrustedOrgDetails> lstTOD, int orgid, TrustedOrgActions objTrustedOrgActions, out List<PatientVisit> lstPatientVisit, List<PatientDisPatchDetails> lstDispatchDetails, int startRowIndex, int pageSize, out int totalRows)
        {
            long returnCode = -1;
            totalRows = -1;
            lstPatientVisit = new List<PatientVisit>();
            try
            {

                DataTable dtOrgIDs = UDT_DAL.ConvertToGetOrgIDs(lstTOD);
                DataTable DtLDetail = UDT_DAL.ConvertToTrustedOrgActions(objTrustedOrgActions);
                DataTable dtDispatchDetails = UDT_DAL.ConvertToUDTDisPatchMode(lstDispatchDetails);
                DataSet ds = new DataSet();

                SqlCommand cmd = Command.pGetDispatchStatusReportsCommand(fdate, todate, sstatus, dtOrgIDs, orgid, DtLDetail, dtDispatchDetails, UDT_DAL.ConvertToUDT_Context(globalContextDetails), startRowIndex, pageSize, out totalRows);

                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientVisit);
                        totalRows = Convert.ToInt32(cmd.Parameters["@totalRows"].Value);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading get patient visit search details by PNo", ex);
            }

            return returnCode;
        }
        public long GetVisitClientMappingDetails(int OrgID, long visitId, out List<VisitClientMapping> lstVisitClient)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetVisitClientDetailsCommand(OrgID, visitId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstVisitClient = new List<VisitClientMapping>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }


            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstVisitClient);
            }


            return returnCode;
        }
        public long GetEMPLevel(int OrgID, out List<EmergencySeverityOrgMapping> lstGetLevels)
        {
            long returnCode = -1;
            lstGetLevels = new List<EmergencySeverityOrgMapping>();
            try
            {
                SqlCommand objCommand = Command.pGetEmerencyLevelListCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstGetLevels);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading EmerencyPatientLevels", ex);
            }
            return returnCode;
        }
        public long GetEMPGridList(int OrgID, out List<PatientVisitDetails> lstGetLevels)
        {
            long returnCode = -1;
            lstGetLevels = new List<PatientVisitDetails>();
            try
            {
                SqlCommand objCommand = Command.pGetEmerencyListCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstGetLevels);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading Emerency Patient List", ex);
            }
            return returnCode;
        }

        public long PSaveEmerencyPatientHistory(long EmergencyPatientTrackerId, long EmergencySeverityOrgMappingID, int pOrgID)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.PSaveEmerencyPatientHistoryCommand(EmergencyPatientTrackerId, EmergencySeverityOrgMappingID, pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine db = new DBEngine())
                {
                    returnCode = db.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Saving Emerency Patient List", ex);
            }
            return returnCode;
        }


        public long GetPatientVisitHeaderHealthScreen(long VisitID, long PatientID, int OrgID, out List<Patient> lstPatientDetail)
        {
            long returnCode = -1;
            lstPatientDetail = new List<Patient>();
            try
            {
                SqlCommand cmd = Command.pGetPatientVisitHeaderCommand(VisitID, PatientID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientDetail);
                    }

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetPatientVisitHeaderHealthScreen details using pGetPatientVisitHeaderCommand sp", ex);
            }

            return returnCode;



        }
        public long GetDoctors(int orgID, out List<InvOrgAuthorization> lstPhysician)
        {
            long returnCode = -1;
            lstPhysician = new List<InvOrgAuthorization>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetDoctorsCommand(orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstPhysician);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetDoctorsForLab DAL", ex);
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

        public long pGetDispatchReportInv(string fromDate, string toDate,
                  int currentOrgID, List<TrustedOrgDetails> lstTOD, string pSearchType, out List<PatientVisit> lstPatientVisit,
                   long Locationid, long ClientID, int VisitType, string status, int Deptid,
                  int ReferringPhyID, long ReferringorgID, TrustedOrgActions objTrustedOrgActions, string VisitNo, long TestID,
                  string TestType, long ZoneID, long CourierBoyId, List<PatientDisPatchDetails> lstDispatchDetails, int startRowIndex, int pageSize, out int totalRows, string Prefernce)
        {
            long returnCode = -1;
            totalRows = -1;
            lstPatientVisit = new List<PatientVisit>();
            try
            {
                DataSet ds = new DataSet();
                DataTable dtDispatchDetails = UDT_DAL.ConvertToUDTDisPatchMode(lstDispatchDetails);
                DataTable dtOrgIDs = UDT_DAL.ConvertToGetOrgIDs(lstTOD);
                DataTable DtLDetail = UDT_DAL.ConvertToTrustedOrgActions(objTrustedOrgActions);

                SqlCommand cmd = Command.pGetDispatchReportInvCommand(fromDate, toDate, currentOrgID, dtOrgIDs, pSearchType, Locationid, ClientID, VisitType, status, Deptid, ReferringPhyID, ReferringorgID, DtLDetail, VisitNo, TestID, TestType, ZoneID, CourierBoyId, dtDispatchDetails, UDT_DAL.ConvertToUDT_Context(globalContextDetails), startRowIndex, pageSize, out totalRows, Prefernce);

                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientVisit);
                        totalRows = Convert.ToInt32(cmd.Parameters["@totalRows"].Value);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading get patient visit search details by PNo", ex);
            }

            return returnCode;
        }
        public long pGetVisitSearchDetailbyPNoPrint(string patientNo, string pName, string phoneNo, string fromDate, string toDate,
            int currentOrgID, List<TrustedOrgDetails> lstTOD, string pSearchType, out List<PatientVisit> lstPatientVisit,
            string Labno, String Locationid, long ClientID, int VisitType, string WardNo, string status, int priority, int Deptid,
            int ReferringPhyID, long ReferringorgID, TrustedOrgActions objTrustedOrgActions, string VisitNo, long TestID,
            string TestType, String ZoneID, String HubID, long CourierBoyId, List<PatientDisPatchDetails> lstDispatchDetails, int startRowIndex,
            int pageSize, out int totalRows, string Prefernce, string IsPrintAll, long PrintLocationid, string IsColorPrint,
             string IPOPNumber, string PatientPayType, string PatientStatus, string IsPrint)
        {
            long returnCode = -1;
            totalRows = -1;
            lstPatientVisit = new List<PatientVisit>();
            try
            {
                DataSet ds = new DataSet();
                DataTable dtDispatchDetails = UDT_DAL.ConvertToUDTDisPatchMode(lstDispatchDetails);
                DataTable dtOrgIDs = UDT_DAL.ConvertToGetOrgIDs(lstTOD);
                DataTable DtLDetail = UDT_DAL.ConvertToTrustedOrgActions(objTrustedOrgActions);

                SqlCommand cmd = Command.pGetVisitSearchDetailbyPNoPrintCommand(patientNo, pName, phoneNo, fromDate, toDate, currentOrgID,
                    dtOrgIDs, pSearchType, Labno, Locationid, ClientID, VisitType, WardNo, status, priority, Deptid, ReferringPhyID,
                    ReferringorgID, DtLDetail, VisitNo, TestID, TestType, ZoneID, HubID, CourierBoyId, dtDispatchDetails,
                    UDT_DAL.ConvertToUDT_Context(globalContextDetails), startRowIndex, pageSize, out totalRows, Prefernce, IsPrintAll, PrintLocationid, IsColorPrint,
                     IPOPNumber, PatientPayType, PatientStatus, IsPrint);

                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientVisit);
                        totalRows = Convert.ToInt32(cmd.Parameters["@totalRows"].Value);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading get patient visit search details by PNo", ex);
            }

            return returnCode;
        }
       
        public long pGetVisitSearchDetailbyPNoRePrint(string patientNo, string pName, string phoneNo, string fromDate, string toDate,
            int currentOrgID, List<TrustedOrgDetails> lstTOD, string pSearchType, out List<PatientVisit> lstPatientVisit,
            string Labno, String Locationid, long ClientID, int VisitType, string WardNo, string status, int priority, int Deptid,
            int ReferringPhyID, long ReferringorgID, TrustedOrgActions objTrustedOrgActions, string VisitNo, long TestID,
            string TestType, String ZoneID, String HubID, long CourierBoyId, List<PatientDisPatchDetails> lstDispatchDetails, int startRowIndex,
            int pageSize, out int totalRows, string Prefernce, string IsPrintAll, long PrintLocationid, string IsColorPrint,
             string IPOPNumber, string PatientPayType, string PatientStatus, string IsPrint,string ReportType)
        {
            long returnCode = -1;
            totalRows = -1;
            lstPatientVisit = new List<PatientVisit>();
            try
            {
                DataSet ds = new DataSet();
                DataTable dtDispatchDetails = UDT_DAL.ConvertToUDTDisPatchMode(lstDispatchDetails);
                DataTable dtOrgIDs = UDT_DAL.ConvertToGetOrgIDs(lstTOD);
                DataTable DtLDetail = UDT_DAL.ConvertToTrustedOrgActions(objTrustedOrgActions);

                SqlCommand cmd = Command.pGetVisitSearchDetailbyPNoRePrintCommand(patientNo, pName, phoneNo, fromDate, toDate, currentOrgID,
                    dtOrgIDs, pSearchType, Labno, Locationid, ClientID, VisitType, WardNo, status, priority, Deptid, ReferringPhyID,
                    ReferringorgID, DtLDetail, VisitNo, TestID, TestType, ZoneID, HubID, CourierBoyId, dtDispatchDetails,
                    UDT_DAL.ConvertToUDT_Context(globalContextDetails), startRowIndex, pageSize, out totalRows, Prefernce, IsPrintAll, PrintLocationid, IsColorPrint,
                     IPOPNumber, PatientPayType, PatientStatus, IsPrint,ReportType);

                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientVisit);
                        totalRows = Convert.ToInt32(cmd.Parameters["@totalRows"].Value);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading get patient visit search details by Reprint Report PNo", ex);
            }

            return returnCode;
        }
        public long GetLabReport(string VisitNumber, Int64 PatientID, string PatientName, string PatientNumber, string PhoneNo, string FromDate, string ToDate, Int64 ClientID,
            Int64 ZoneID, long LocationID, Int64 RefDocID, long ReforgID, string Status, Int64 DeptID, Int64 TestID, string TestType,
        int CurrentOrgID, int visitType, out List<PatientVisit> lstPatientVisit, int startRowindex, int pageSize, out int totalRows)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            totalRows = -1;
            lstPatientVisit = new List<PatientVisit>();
            try
            {
                totalRows = -1;
                System.Data.SqlClient.SqlCommand cmd = Command.PgetLabReportbyPNoCommand(
                        VisitNumber, PatientID, PatientName, PatientNumber, PhoneNo, FromDate, ToDate,
                        ClientID, ZoneID,Convert.ToInt32(LocationID), RefDocID, ReforgID, Status, DeptID, TestID, TestType, CurrentOrgID, visitType,
                        UDT_DAL.ConvertToUDT_Context(globalContextDetails), startRowindex, pageSize, out totalRows
                    );

                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstPatientVisit);
                        dataReader.Close();
                    }
                    Int32.TryParse(cmd.Parameters["@totalRows"].Value.ToString(), out totalRows);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetLabReport in PatientVisitDal", ex);
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
