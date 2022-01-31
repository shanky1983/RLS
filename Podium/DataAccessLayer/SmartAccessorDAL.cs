using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.Common;
using Attune.Podium.BusinessEntities;
using Attune.Solution.DAL;

namespace Attune.Podium.DataAccessLayer
{
    public class SmartAccessorDAL
    {
         ContextDetails globalContextDetails;
        public SmartAccessorDAL()
        {

        }
        public SmartAccessorDAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetExamAttributeValues(long pAttId, out List<ExaminationAttributeValues> lstExamAttValues)
        {
            long returnCode = -1;
            lstExamAttValues = new List<ExaminationAttributeValues>();
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pGetExamAttributeValuesCommand(pAttId,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstExamAttValues);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in URL DAL GetExamAttributeValues SmartAccessorDAL", ex);
            }

            return returnCode;
        }

        public long InsertExaminationPKG(DataTable dtPatExam, DataTable dtPatExamAtt, DataTable dtPatientVitals, long visitID, long patientID, long createdBy, int OrgID)
        {
            long returnCode = -1;

            try
            {
                SqlCommand cmd = Command.pInsertExaminationPKGCommand(dtPatExam, dtPatExamAtt, dtPatientVitals, visitID, patientID, createdBy, OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in InsertExaminationPKG SmartAccessorDAL", ex);
            }

            return returnCode;
        }


        public long GetPatientExamPackage(long pVisitId, int OrgID, out List<PatientExaminationAttribute> lstPatExamAttribute, out List<VitalsUOMJoin> lstVitalsUOMJoin, out List<PatientExaminationAttribute> lstPatExam, out List<PatientExaminationAttribute> lstPatAttribute)
        {
            long returnCode = -1;
            int rsCount = 0;
            lstPatExamAttribute = new List<PatientExaminationAttribute>();
            lstPatExam = new List<PatientExaminationAttribute>();
            lstPatAttribute = new List<PatientExaminationAttribute>();
            lstVitalsUOMJoin = new List<VitalsUOMJoin>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetPatientExamPackageCommand(pVisitId, OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
             
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstPatExamAttribute);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstPatExam);
                            }
                            else if (rsCount == 2)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstPatAttribute);
                            }
                            else if (rsCount == 2)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstVitalsUOMJoin);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    } 
                }
              
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in SmartAccessor DAL", ex);
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

        public long GetEMRPackgeDetails(int pkgID, int pOrgID, out List<InvPackageMapping> lstIPM)
        {
            long returnCode = -1;
            lstIPM = new List<InvPackageMapping>();
            try
            {
                SqlCommand cmd = Command.pGetEMRPackgeDetailsCommand(pkgID, pOrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstIPM);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetEMRPackgeDetails", ex);
            }

            return returnCode;
        }


        public long GetPatientHistoryPKGEdit(long visitID, out List<PatientHistoryAttribute> lstPHA, out List<DrugDetails> lstDrugDetails, out List<GPALDetails> lstGPALDetails, out List<ANCPatientDetails> lstANCPatientDetails, out List<PatientPastVaccinationHistory> lstPPVH, out List<PatientComplaintAttribute> lstPCA, out List<SurgicalDetail> lstSurgicalDetails, out List<PatientComplaintAttribute> lsthisPCA, out List<PatientHistoryAttribute> lsthisPHA)
        {
            long returnCode = -1;
            int rsCount = 0;
            lstPHA = new List<PatientHistoryAttribute>();
            lstDrugDetails = new List<DrugDetails>();
            lstGPALDetails = new List<GPALDetails>();
            lstANCPatientDetails = new List<ANCPatientDetails>();
            lstPPVH = new List<PatientPastVaccinationHistory>();
            lstPCA = new List<PatientComplaintAttribute>();
            lstSurgicalDetails = new List<SurgicalDetail>();
            lsthisPHA = new List<PatientHistoryAttribute>();
            lsthisPCA = new List<PatientComplaintAttribute>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetPatientHistoryPKGEditCommand(visitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstPHA);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstDrugDetails);
                            }
                            else if (rsCount == 2)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstGPALDetails);
                            }
                            else if (rsCount == 3)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstANCPatientDetails);
                            }
                            else if (rsCount == 4)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstPPVH);
                            }
                            else if (rsCount == 5)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstPCA);
                            }
                            else if (rsCount == 6)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstSurgicalDetails);
                            }

                            else if (rsCount == 7)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lsthisPHA);
                            }
                            else if (rsCount == 8)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lsthisPCA);
                            } 
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
               
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetPatientHistoryPKGEdit", ex);
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

        public long GetAllergyHistory(string strDesc, string strPre, out List<PatientHistoryAttribute> lstPHA)
        {
            long returnCode = -1;
            lstPHA = new List<PatientHistoryAttribute>();
            SqlCommand cmd = Command.pGetHistoryDetCommand(strDesc, strPre,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPHA);
            }
            return returnCode;

        }
        public long GetAllergyHistoryDet(long lngHistoryID, out List<PatientHistoryAttribute> lstPHA)
        {
            long returnCode = -1;
            lstPHA = new List<PatientHistoryAttribute>();
            SqlCommand cmd = Command.pGetAllergyHistoryDetCommand(lngHistoryID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPHA);
            }
            return returnCode;

        }

        public long GetDiagnosticsAttributeValues(long pAttId, string IsParentAttID, out List<DiagnosticsAttributeValues> lstDiagnosticsAttValues)
        {
            long returnCode = -1;
            lstDiagnosticsAttValues = new List<DiagnosticsAttributeValues>();
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pGetDiagnosticsAttributeValuesCommand(pAttId, IsParentAttID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDiagnosticsAttValues);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in URL DAL GetDiagnosticsAttributeValues SmartAccessorDAL", ex);
            }

            return returnCode;
        }


        public long InsertDiagnosticsPKG(DataTable dtGetPatDiagnostics, DataTable dtGetPatDiagnosticsAtt, long visitID, long patientID, long createdBy, int OrgID)
        {
            long returnCode = -1;

            try
            {
                SqlCommand cmd = Command.pInsertDiagnosticsPKGCommand(dtGetPatDiagnostics, dtGetPatDiagnosticsAtt, visitID, patientID, createdBy, OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in InsertDiagnosticsPKG SmartAccessorDAL", ex);
            }
            return returnCode;
        }


        public long GetPatientDiagnosticsPackage(long pVisitId, int OrgID, out List<PatientDiagnosticsAttribute> lstPatientDiagnosticsAttribute, out List<PatientDiagnosticsAttribute> lstPatientDiagnostics)
        {
            long returnCode = -1;
            lstPatientDiagnosticsAttribute = new List<PatientDiagnosticsAttribute>();
            lstPatientDiagnostics = new List<PatientDiagnosticsAttribute>();            
            try
            {
                SqlCommand cmd = Command.pGetPatientDiagnosticsPackageCommand(pVisitId, OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientDiagnosticsAttribute);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPatientDiagnostics);
                }
               
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in SmartAccessor DAL", ex);
            }
            return returnCode;
        }


      

    }
}
