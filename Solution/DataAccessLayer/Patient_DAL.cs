using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.SqlClient;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities;
using Attune.Podium.BusinessEntities.CustomEntities;
using System.Collections.Generic;
using Attune.Podium.Common;
using System.Data.Common;
using System.Transactions;
/*--------------------------------------------------------------------------------------
 * Modified Date : 26rd Dec 2010 
 * Modified By   : Venkatesh.K
 * Description   : Modified for add referring Physician releted parameters in SavePatientEmployer and 
 *                 UpdatePatientEmployer method.
---------------------------------------------------------------------------------------*/
namespace Attune.Solution.DAL
{
    public class Patient_DAL
    {
        ContextDetails globalContextDetails;
        public Patient_DAL()
        {

        }
        public Patient_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }

        // changed dataset to datareader by Arivalagan.k
        public long SearchPatient(string iPatientNo, string PatientSmartCardNo, string strPatientName, string strDOB, string strRelation, string strLocation, string strOccupation, string strCity, string strMobile, int currOrgID, List<TrustedOrgDetails> lstTOD, int parentID, string urno, long urnTypeID, int pageSize, int StartRowIndex, out int totalRows, out List<PatientVisit> lsttotalPatientCount, out  List<Patient> lstPatient, string strNationality, string TPAID, string ClientID, string pFDate, string pTDate, string pLandLineNum, string Pstatus)
        {
            long returnCode = -1;
            IDataReader dataReader = null;
            int rsCount = 0;
            totalRows = -1;
            DataTable dtOrgIDs = UDT_DAL.ConvertToGetOrgIDs(lstTOD);
            System.Data.SqlClient.SqlCommand cmd;
            lstPatient = new List<Patient>();
            lsttotalPatientCount = new List<PatientVisit>();
            try
            {
                cmd = Command.pSearchPatientCommand(iPatientNo, PatientSmartCardNo, strPatientName, strRelation, strDOB, strLocation, strOccupation, strCity, strMobile, currOrgID, dtOrgIDs, parentID, urno, urnTypeID, pageSize, StartRowIndex, strNationality, TPAID, ClientID, pFDate, pTDate, out totalRows, pLandLineNum, UDT_DAL.ConvertToUDT_Context(globalContextDetails), Pstatus);
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstPatient);
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
            catch (Exception e)
            {
                CLogger.LogError("Error while executing SearchPatient Patient_DAL", e);
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
        //Changes of DataSet To DataReader Made By Arivalagan.k
        public long SearchColumns(int SearchTypeID, int OrgID, out List<DynamicColumnMapping> lstColumn)
        {
            long returnCode = -1;
            IDataReader dataReader = null;
            System.Data.SqlClient.SqlCommand cmd;
            lstColumn = new List<DynamicColumnMapping>();
            try
            {
                cmd = Command.pGetSearchColumnsCommand(SearchTypeID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstColumn);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading SearchColumns PatientDAL", ex);
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

        public long GetPendingPatientsForVitals(int iOrgID, out List<Patient> lstPatient)
        {
            long returnCode = -1;
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "pGetPendingVitals";

            objCommand.Parameters.Add("@OrgID", SqlDbType.Int);
            objCommand.Parameters["@OrgID"].Value = iOrgID;

            lstPatient = new List<Patient>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }


            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatient);
            }

            return returnCode;
        }


        public DataSet GetPatientSearch(Attune.Podium.BusinessEntities.Patient objPatient)
        {
            DataSet ds = new DataSet();

            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Cproc_Get_HC_PatientSearch";
            objCommand.Parameters.Add("@pPatientId", SqlDbType.Int);




            objCommand.Parameters["@pPatientId"].Value = objPatient.PatientID;



            Attune.Podium.DataAccessEngine.DBEngine objDB = new DBEngine();



            return ds;
        }

        public long SavePatientEMRDetails(List<PhysioCompliant> lstPhysioCompliant, long patientID, List<PatientPreferences> PatientPreference)
        {

            DataTable dtPhysioComplaint = UDT_DAL.ConvertToPhysioCompliant(lstPhysioCompliant);
            DataTable dtPatientPreference = UDT_DAL.ConvertToPatientPreferences(PatientPreference);
            long returnCode = -1;
            SqlCommand cmdInsertPatientEMR = new SqlCommand();

            cmdInsertPatientEMR = Command.pInsertPatientEMRDetailsCommand(dtPhysioComplaint, patientID, dtPatientPreference, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dBEngine = new DBEngine(true))
                {
                    returnCode = dBEngine.ExecuteNonQuery(cmdInsertPatientEMR);
                }
                return returnCode;
            }

            catch (Exception ex)
            {
                CLogger.LogError("Error while saving  patient EMR details", ex);
            }
            return returnCode;
        }


        public long GetPatientEMRDetails(long patientID, out List<PhysioCompliant> lstPhysioCompliant, out List<PatientPreferences> lstPatientPreference)
        {

            long returnCode = -1;
            SqlCommand cmdInsertPatientEMR = new SqlCommand();
            cmdInsertPatientEMR = Command.pGetPatientEMRDetailsCommand(patientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstPhysioCompliant = new List<PhysioCompliant>();
            lstPatientPreference = new List<PatientPreferences>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteDataSet(cmdInsertPatientEMR, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPhysioCompliant);
            }
            if (ds.Tables.Count > 1)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPatientPreference);
            }
            return returnCode;


        }


        public long SavePatient(Patient patient, DateTime pDOBConverted, int pAgeValue, string pAgeUnits, string CreateLogin, string pPicExtension, out string UName, out string Pwd, out string PatientNumber, out long patientID, List<PatientQualification> Qualification)
        {
            long lResult = -1;
            int addressCount = patient.PatientAddress.Count;
            SqlCommand cmdInsertPatient = new SqlCommand();
            SqlCommand[] cmdInsertAddress = new SqlCommand[addressCount];
            AddressDetails_DAL address = new AddressDetails_DAL(globalContextDetails);
            DataTable PQualification = UDT_DAL.ConvertToUDTpatientQualification(Qualification);
            patientID = 0;
            long addressID = 0;
            int i;
            cmdInsertPatient = Command.pInsertPatientCommand(patient.Name, patient.AliasName,
                                    patient.AlternateContact, patient.EMail, patient.TITLECode, patient.SEX, patient.DOB, patient.OCCUPATION, patient.MartialStatus,
                                    patient.Religion, patient.PersonalIdentification, patient.OrgID, patient.BloodGroup, patient.PlaceOfBirth, patient.Comments,
                                    patient.CreatedBy, out PatientNumber, patient.RegistrationFee, patient.RelationName, patient.Age, patient.CompressedName,
                                    pDOBConverted, pAgeValue, pAgeUnits, patient.URNO, patient.URNofId, patient.URNTypeId, patient.Race,
                                                   Convert.ToString(patient.Nationality), CreateLogin, out patientID, out UName, out Pwd, patient.FileNo, pPicExtension, UDT_DAL.ConvertToUDT_Context(globalContextDetails), PQualification, patient.URNEXPDate);
            cmdInsertPatient.Parameters.Add("@Return", SqlDbType.Int);
            cmdInsertPatient.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            for (i = 0; i < addressCount; i++)
            {
                cmdInsertAddress[i] = Command.pInsertPatientAddressCommand(patientID, patient.PatientAddress[i].AddressType, patient.PatientAddress[i].Add1,
                                    patient.PatientAddress[i].Add2, patient.PatientAddress[i].Add3, patient.PatientAddress[i].PostalCode, patient.PatientAddress[i].CountryID,
                                    patient.PatientAddress[i].City, patient.PatientAddress[i].StateID, patient.PatientAddress[i].MobileNumber, patient.PatientAddress[i].LandLineNumber,
                                                        patient.CreatedBy, patient.PatientAddress[i].OtherCountryName, patient.PatientAddress[i].OtherStateName, patient.PatientAddress[i].CountryCode, patient.PatientAddress[i].StateCode, patient.PatientAddress[i].CityCode, patient.PatientAddress[i].AddLevel1, patient.PatientAddress[i].AddLevel2, out addressID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            }

            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteTransactionalNonQuery(cmdInsertPatient);
                        lResult = Convert.ToInt64(cmdInsertPatient.Parameters["@Return"].Value);
                        if (lResult == 0)
                        {
                            patientID = Convert.ToInt64(cmdInsertPatient.Parameters["@PatientID"].Value);
                            PatientNumber = Convert.ToString(cmdInsertPatient.Parameters["@pPatientNumber"].Value);
                            UName = Convert.ToString(cmdInsertPatient.Parameters["@UName"].Value);
                            Pwd = Convert.ToString(cmdInsertPatient.Parameters["@Pwd"].Value);
                            patient.PatientID = patientID;
                            for (i = 0; i < addressCount; i++)
                            {
                                cmdInsertAddress[i].Parameters["@pPatientID"].Value = patientID;
                                dbEngine.ExecuteTransactionalNonQuery(cmdInsertAddress[i]);
                            }
                        }
                    }
                    tranScope.Complete();
                }

                catch (Exception ex)
                {
                    CLogger.LogError("Error while saving patient. Query: " + cmdInsertPatient.CommandText, ex);
                    tranScope.Dispose();
                }

            }
            return lResult;
        }

        public long GetPatientDemo(long patientID, out List<Patient> lstPatient)
        {
            long returnCode = -1;
            SqlCommand objCommand = new SqlCommand();
            objCommand = Command.pGetPatientDemoCommand(patientID, 0, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstPatient = new List<Patient>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }

            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatient);
            }

            return returnCode;
        }
        public long GetTableFormat(long OrgID, out List<SmartCardMaster> lstSmtcard)
        {
            long returnCode = -1;
            lstSmtcard = new List<SmartCardMaster>();
            try
            {
                SqlCommand objCommand = new SqlCommand();
                List<SmartCardMaster> pAddress = new List<SmartCardMaster>();
                objCommand = Command.pgetIDCardFormatCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();

                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstSmtcard);
                }
                return returnCode;
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error occuring in Patient_BL GetTableFormat", ex);
            }

            return returnCode;
        }
        public long GetPatientDemoandAddress(long patientID, out List<Patient> lstPatient)
        {
            long returnCode = -1;
            SqlCommand objCommand = new SqlCommand();
            List<PatientAddress> pAddress = new List<PatientAddress>();
            objCommand = Command.pGetPatientDetailandAddressCommand(patientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstPatient = new List<Patient>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 1)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatient);
                returnCode = Utilities.ConvertTo(ds.Tables[1], out pAddress);
            }
            if (lstPatient.Count > 0)
                lstPatient[0].PatientAddress = pAddress;
            return returnCode;
        }

        public long GetPatientAllergy(int patientID, out List<AllergyMaster> lstPatient)
        {
            long returnCode = -1;
            SqlCommand objCommand = new SqlCommand();
            objCommand = Command.pGetPatientAllergyCommand(patientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstPatient = new List<AllergyMaster>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatient);
            }
            return returnCode;
        }


        public long GetAdmissionPatientDemoandAddress(long patientID, long patientVisitID, string AttributeType, out List<InPatientAdmissionDetails> lstPatient
                                                         , out List<PatientEmployer> lstEmp
                                                         , out List<RTAMLCDetails> lstRTAMLCDetails
                                                         , out List<Patient> lPatient
                                                         , out List<VisitClientMapping> lstVisitClientMapping)
        {
            long returnCode = -1;
            SqlCommand objCommand = new SqlCommand();
            List<InPatientAdmissionDetails> pInPatientAdmission = new List<InPatientAdmissionDetails>();
            List<PatientEmployer> pEmp = new List<PatientEmployer>();
            objCommand = Command.pGetAdmissionPatientDetailsCommand(patientID, patientVisitID, AttributeType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstPatient = new List<InPatientAdmissionDetails>();
            lstEmp = new List<PatientEmployer>();
            lstRTAMLCDetails = new List<RTAMLCDetails>();
            lPatient = new List<Patient>();
            lstVisitClientMapping = new List<VisitClientMapping>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }

            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatient);
            }
            if (ds.Tables.Count > 1)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstEmp);
            }
            if (ds.Tables.Count > 2)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[2], out lstRTAMLCDetails);
            }
            if (ds.Tables.Count > 3)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[3], out lPatient);
            }
            if (ds.Tables.Count > 4)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[4], out lstVisitClientMapping);

            }

            return returnCode;
        }

        public long Updatepatient(Patient patient, DateTime pDOBConverted, int pAgeValue, string pAgeUnits, string CreateLogin, string pPicExtension, out string UName, out string Pwd, long ApprovedBy, List<PatientQualification> Qualification)
        {
            long lResult = -1;
            int addressCount = patient.PatientAddress.Count;
            SqlCommand cmdInsertPatient = new SqlCommand();
            SqlCommand[] cmdInsertAddress = new SqlCommand[addressCount];
            AddressDetails_DAL address = new AddressDetails_DAL(globalContextDetails);
            DataTable PQualification = UDT_DAL.ConvertToUDTpatientQualification(Qualification);
            long patientID = 0;
            int i;
            cmdInsertPatient = Command.pUpdatePatientCommand(patient.Name, patient.AliasName,
                                    patient.AlternateContact, patient.EMail, patient.TITLECode, patient.SEX, patient.DOB, patient.OCCUPATION, patient.MartialStatus,
                                    patient.Religion, patient.PersonalIdentification, patient.OrgID, patient.BloodGroup, patient.PlaceOfBirth, patient.Comments,
                                    patient.ModifiedBy, patient.RelationName, patient.Age, patient.CompressedName, patient.PatientID, pDOBConverted, pAgeValue,
                                                     pAgeUnits, patient.URNO, patient.URNofId, patient.URNTypeId, patient.Nationality, CreateLogin, out UName, out Pwd, patient.FileNo, patient.Status, pPicExtension, ApprovedBy, UDT_DAL.ConvertToUDT_Context(globalContextDetails),
                                                    PQualification, patient.URNEXPDate, patient.InactiveReason);
            cmdInsertPatient.Parameters.Add("@retCode", SqlDbType.Int);
            cmdInsertPatient.Parameters["@retCode"].Direction = ParameterDirection.ReturnValue;
            for (i = 0; i < addressCount; i++)
            {
                cmdInsertAddress[i] = Command.pUpdatePatientAddressCommand(patientID, patient.PatientAddress[i].AddressType, patient.PatientAddress[i].Add1,
                                    patient.PatientAddress[i].Add2, patient.PatientAddress[i].Add3, patient.PatientAddress[i].PostalCode, patient.PatientAddress[i].CountryID,
                                    patient.PatientAddress[i].City, patient.PatientAddress[i].StateID, patient.PatientAddress[i].MobileNumber, patient.PatientAddress[i].LandLineNumber,
                                    patient.CreatedBy, patient.PatientAddress[i].AddressID, patient.ModifiedBy, patient.PatientAddress[i].OtherCountryName, patient.PatientAddress[i].OtherStateName,
                                    patient.PatientAddress[i].CountryCode,
                                                         patient.PatientAddress[i].StateCode, patient.PatientAddress[i].CityCode, patient.PatientAddress[i].AddLevel1, patient.PatientAddress[i].AddLevel2, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                cmdInsertAddress[i].Parameters.Add("@retCode", SqlDbType.Int);
                cmdInsertAddress[i].Parameters["@retCode"].Direction = ParameterDirection.ReturnValue;

            }

            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteTransactionalNonQuery(cmdInsertPatient);
                        lResult = Convert.ToInt64(cmdInsertPatient.Parameters["@retCode"].Value);
                        UName = Convert.ToString(cmdInsertPatient.Parameters["@UName"].Value);
                        Pwd = Convert.ToString(cmdInsertPatient.Parameters["@Pwd"].Value);
                        if (lResult == 0)
                        {
                            patientID = patient.PatientID;
                            for (i = 0; i < addressCount; i++)
                            {
                                cmdInsertAddress[i].Parameters["@pPatientID"].Value = patientID;
                                dbEngine.ExecuteTransactionalNonQuery(cmdInsertAddress[i]);
                                lResult = Convert.ToInt64(cmdInsertPatient.Parameters["@retCode"].Value);
                                if (lResult != 0)
                                    tranScope.Dispose();
                            }
                        }
                    }
                    tranScope.Complete();
                }
                catch (Exception ex)
                {
                    CLogger.LogError("Error whil updating patient information. Query: " + cmdInsertPatient.CommandText, ex);
                    tranScope.Dispose();
                }

            }
            return lResult;
        }


        public long getEventChart(long patientId, long currentVisitId, string sTreatmentType, out List<EventChart> lstEventChart, out List<PatDtlsVPAction> lstPatDtlsVPAction,
            out List<PatientDrug> lstPatientDrug, out List<InvestigationPatient> lstInvestigation,
            out List<PatientExamination> lstPatientExamination, out List<PatientHistory> lstPatientHistory)
        {
            long lResult = -1;
            SqlCommand cmdEventChart = new SqlCommand();
            cmdEventChart.CommandType = CommandType.StoredProcedure;
            cmdEventChart.CommandText = "pGetEventTreatmentInvestigation";
            cmdEventChart.Parameters.Add("@pPatientId", SqlDbType.BigInt);
            cmdEventChart.Parameters["@pPatientId"].Value = patientId;
            cmdEventChart.Parameters.Add("@pCurrentVisitId", SqlDbType.BigInt);
            cmdEventChart.Parameters["@pCurrentVisitId"].Value = currentVisitId;
            cmdEventChart.Parameters.Add("@TreatmentType", SqlDbType.Text);
            cmdEventChart.Parameters["@TreatmentType"].Value = sTreatmentType;

            lstEventChart = new List<EventChart>();
            lstPatientDrug = new List<PatientDrug>();
            lstInvestigation = new List<InvestigationPatient>();
            lstPatientExamination = new List<PatientExamination>();
            lstPatientHistory = new List<PatientHistory>(); lstPatDtlsVPAction = new List<PatDtlsVPAction>();
            DataSet dataSet = new DataSet();
            using (DBEngine dbEngine = new DBEngine(false))
            {
                lResult = dbEngine.ExecuteDataSet(cmdEventChart, out dataSet);
            }
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                lResult = Utilities.ConvertTo(dataSet.Tables[0], out lstEventChart);
            }
            if (dataSet.Tables[1].Rows.Count > 0)
            {
                lResult = Utilities.ConvertTo(dataSet.Tables[1], out lstPatDtlsVPAction);
            }
            if (dataSet.Tables[2].Rows.Count > 0)
            {
                lResult = Utilities.ConvertTo(dataSet.Tables[2], out lstPatientDrug);
            }
            if (dataSet.Tables[3].Rows.Count > 0)
            {
                lResult = Utilities.ConvertTo(dataSet.Tables[3], out lstInvestigation);
            }
            if (dataSet.Tables[4].Rows.Count > 0)
            {
                lResult = Utilities.ConvertTo(dataSet.Tables[4], out lstPatientExamination);
            }
            if (dataSet.Tables[5].Rows.Count > 0)
            {
                lResult = Utilities.ConvertTo(dataSet.Tables[5], out lstPatientHistory);
            }
            return lResult;
        }


        public long GetTreatment(long patientId, long patientVisitId, out List<PatientDrug> lstPatientDrug)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetTreatmentLoadCommand(patientId, patientVisitId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstPatientDrug = new List<PatientDrug>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientDrug);
            }

            return returnCode;
        }

        public long GetInvestigation(long patientId, long patientVisitId, out List<InvestigationPatient> lstInvestigationPatient)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetInvestigationLoadCommand(patientId, patientVisitId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstInvestigationPatient = new List<InvestigationPatient>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvestigationPatient);
            }
            return returnCode;

        }

        public long GetPatientExamination(long patientId, long patientVisitId, out List<PatientExamination> lstExamination)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetPatientExaminationLoadCommand(patientId, patientVisitId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstExamination = new List<PatientExamination>();
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

        public long GetPatientHistory(long patientId, long patientVisitId, out List<PatientHistory> lstHistory)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetPatientHistoryLoadCommand(patientId, patientVisitId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstHistory = new List<PatientHistory>();
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

        public long GetEventName(int patientId, string txtEvent, out DataSet dataSet)
        {
            long lResult = 1;
            SqlCommand cmdEventName = new SqlCommand();
            cmdEventName.CommandType = CommandType.StoredProcedure;
            cmdEventName.CommandText = "pGetEventName";
            cmdEventName.Parameters.Add("@pPatientId", SqlDbType.Int);
            cmdEventName.Parameters.Add("@pEventName", SqlDbType.VarChar);
            cmdEventName.Parameters["@pPatientId"].Value = patientId;
            cmdEventName.Parameters["@pEventName"].Value = txtEvent;
            dataSet = new DataSet();
            using (DBEngine dbEngine = new DBEngine(false))
            {
                lResult = dbEngine.ExecuteDataSet(cmdEventName, out dataSet);
            }
            return lResult;
        }
        public long GetEventChartName(long patientId, string txtEventName, out List<EventChart> lstEventChart, out List<PatDtlsVPAction> lstPatDtlsVPAction)
        {
            lstEventChart = new List<EventChart>(); lstPatDtlsVPAction = new List<PatDtlsVPAction>();
            long lResult = 1;
            SqlCommand cmdEventName = new SqlCommand();
            cmdEventName.CommandType = CommandType.StoredProcedure;
            cmdEventName.CommandText = "pGetEventChartName";
            cmdEventName.Parameters.Add("@pPatientId", SqlDbType.BigInt);
            cmdEventName.Parameters.Add("@pEventName", SqlDbType.VarChar);
            cmdEventName.Parameters["@pPatientId"].Value = patientId;
            cmdEventName.Parameters["@pEventName"].Value = txtEventName;
            DataSet dataSet = new DataSet();
            using (DBEngine dbEngine = new DBEngine(false))
            {
                lResult = dbEngine.ExecuteDataSet(cmdEventName, out dataSet);
            }
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                lResult = Utilities.ConvertTo(dataSet.Tables[0], out lstEventChart);
            }
            if (dataSet.Tables[1].Rows.Count > 0)
            {
                lResult = Utilities.ConvertTo(dataSet.Tables[1], out lstPatDtlsVPAction);
            }

            return lResult;
        }

        public long GetHeaderDetails(int patientId, out List<Patient> lstHeader)
        {
            long lResult = 1;
            lstHeader = new List<Patient>();
            SqlCommand cmdHeader = new SqlCommand();
            cmdHeader.CommandType = CommandType.StoredProcedure;
            cmdHeader.CommandText = "pGetHeaderDetails";
            SqlParameter ppatientid = new SqlParameter();
            ppatientid.ParameterName = "@pPatientId";
            ppatientid.SqlDbType = SqlDbType.BigInt;
            ppatientid.Value = patientId;
            cmdHeader.Parameters.Add(ppatientid);
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine(false))
            {
                lResult = dbEngine.ExecuteDataSet(cmdHeader, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                lResult = Utilities.ConvertTo(ds.Tables[0], out lstHeader);
            }
            return lResult;
        }
        public long GetPatientDetails(string visitPurposeName, string fromDate, string toDate, out List<AdminReports> lstPatient)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pGetAdminReportsCommand(visitPurposeName, fromDate, toDate, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstPatient = new List<AdminReports>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatient);
            }

            return returnCode;
        }

        // changed dataset to datareader by Arivalagan.k
        public long GetPatientDetailsPassingVisitID(long visitID, out List<Patient> lstPatient)
        {
            long returnCode = -1;
            lstPatient = new List<Patient>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetPatientDetailsPassingVisitIDCommand(visitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstPatient);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while get patient details passing visit id", ex);
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

        public long pGetPatientAllergyDetails(long patientid, List<AllergyMaster> pInvMap)
        {
            long returnCode = -1;
            try
            {

                DataTable DtInvGp = UDT_DAL.ConvertToUDPatientAllergies(pInvMap);

                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetPatientAllergyDetailsCommand(patientid, DtInvGp, out returnCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dBEngine = new DBEngine(false))
                {
                    returnCode = dBEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt32(cmd.Parameters["@returnStatus"].Value);
                }
                return returnCode;
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while get patient details passing visit id", ex);
            }
            return returnCode;
        }

        public long getRaceDetails(out List<Racemaster> lstRace)
        {
            long returnCode = -1;
            lstRace = new List<Racemaster>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetDetailsofRaceCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstRace);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while get patient details passing visit id", ex);
            }

            return returnCode;
        }
        // changed dataset to datareader by Arivalagan.k
        public long GetPatientVitals(long patientVisitID, long patientID, int orgID, out List<Patient> proHeader, out List<VitalsUOMJoin> vitalHeader)
        {
            long vresult1 = -1;
            proHeader = new List<Patient>();
            vitalHeader = new List<VitalsUOMJoin>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmdvitals = Command.pGetVitalHeaderCommand(patientVisitID, patientID, orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmdvitals);
                    if (dataReader != null)
                    {
                        vresult1 = Utilities.ConvertTo(dataReader, out proHeader);
                    }
                    if (dataReader.NextResult())
                    {
                        vresult1 = Utilities.ConvertTo(dataReader, out vitalHeader);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientVitals in InvestigationDAL", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            } 
            return vresult1;

        }
        //Change dataset to datareader made by Arivalagan.k
        public long GetRegistrationStatus(string patientNo, int OrgID, out int count, out List<Patient> lPatientDetails)
        {
            long returnCode = -1;
            count = -1;
            IDataReader dataReader = null;
            lPatientDetails = new List<Patient>();
            try
            {
                SqlCommand cmd = Command.pGetRegistrationStatusCommand(patientNo, OrgID, out count, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        Utilities.ConvertTo(dataReader, out lPatientDetails);
                        dataReader.Close();
                    }
                    count = Convert.ToInt32(cmd.Parameters["@pCount"].Value);

                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetRegistrationStatus in Patient_DAL", e);
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


        #region DDC Code Block






        public long GetPublishingMode(out List<PublishingMode> lstPublishingMode)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetLabPublishingModeCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstPublishingMode = new List<PublishingMode>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPublishingMode);
            }
            return returnCode;
        }
        public long SaveSamplePublishingDetails(ResultPublishing resultPub, PatientAddress pAddress)
        {
            long result = -1;
            SqlCommand cmdInsertSamplePublishingDetails = new SqlCommand();
            cmdInsertSamplePublishingDetails = Command.pInsertSamplePublishingDetailsCommand(resultPub.OrgID, resultPub.PatientVisitID, resultPub.ModeID, resultPub.Value, pAddress.Add1, pAddress.Add2, pAddress.Add3, pAddress.PostalCode, pAddress.CountryID, pAddress.City, pAddress.StateID, pAddress.MobileNumber, pAddress.LandLineNumber, resultPub.CreatedBy, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdInsertSamplePublishingDetails.Parameters.Add("@Return", SqlDbType.Int);
            cmdInsertSamplePublishingDetails.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(cmdInsertSamplePublishingDetails);
                    result = Convert.ToInt64(cmdInsertSamplePublishingDetails.Parameters["@Return"].Value);
                }

            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing SaveSampleBillingDetails DAL", excep);
            }
            return result;
        }
        public long SaveBillDetails(BillMaster billMaster, List<BillLineItems> billItems, out string pBillID, DataTable dtAmountreceived, decimal dserviceCharge)
        {
            int i;
            long lResult = -1;
            DataTable dtBillItemTable = UDT_DAL.ConvertToBillItemsMapping(billItems);
            SqlCommand cmdInsertBillDetail = new SqlCommand();

            cmdInsertBillDetail = Command.pInsertBillItemsDetailsCommand(billMaster.OrgID, billMaster.VisitID, billMaster.PatientID, billMaster.ClientID,
                                    billMaster.CollectionCentreID, billMaster.Type, billMaster.GrossAmount, billMaster.Discount,
                                    billMaster.TaxPercent, billMaster.NetAmount, billMaster.AmountReceived, billMaster.AmountDue,
                                    billMaster.IsCredit, billMaster.CreatedBy, billMaster.Comments, Convert.ToString(billMaster.BillID), dtBillItemTable, out pBillID,
                                                    dtAmountreceived, dserviceCharge, UDT_DAL.ConvertToUDT_Context(globalContextDetails));//, billMaster.TPAID,;
            cmdInsertBillDetail.Parameters.Add("@Return", SqlDbType.Int);
            cmdInsertBillDetail.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteTransactionalNonQuery(cmdInsertBillDetail);
                        lResult = Convert.ToInt64(cmdInsertBillDetail.Parameters["@Return"].Value);
                        pBillID = Convert.ToString(cmdInsertBillDetail.Parameters["@pBillID"].Value);
                    }
                    tranScope.Complete();
                }
                catch (Exception ex)
                {
                    CLogger.LogError("Error while saving Billing Details ", ex);
                    tranScope.Dispose();
                }
            }
            return lResult;
        }

        public long GetBillInvestigationDetails(long pVisitID, int pClientID, out List<LabPatientInvestigation> patientInvestigation1, out List<LabPatientInvestigation> patientInvestigation2)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetBillInvestigationDetailsCommand(pVisitID, pClientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            patientInvestigation1 = new List<LabPatientInvestigation>();
            patientInvestigation2 = new List<LabPatientInvestigation>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out patientInvestigation1);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[1], out patientInvestigation2);
            }
            return returnCode;
        }
        public long SearchLabPatient(string strPatientName, string sMobile, int OrgId, long VisitID, long BillID, out List<Patient> lstPatient)
        {
            long returnCode = -1;
            System.Data.SqlClient.SqlCommand cmd;
            cmd = Command.pSearchLabPatientCommand(strPatientName, sMobile, OrgId, VisitID, BillID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstPatient = new List<Patient>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatient);
            }
            return returnCode;
        }
        //Change dataset to datareader made by Arivalagan.k
        public long GetLabPatientDemoandAddress(long patientID, out List<Patient> lstPatient)
        {
            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
            List<PatientAddress> pAddress = new List<PatientAddress>();
            lstPatient = new List<Patient>();
            IDataReader dataReader = null;

            try
            {
                cmd = Command.pGetLabPatientDetailandAddressCommand(patientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    int rsCount = 0;
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader.FieldCount > 1)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstPatient);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out pAddress);
                            }

                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }

                if (lstPatient.Count > 0)
                    lstPatient[0].PatientAddress = pAddress;
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while  GetLabPatientDetailandAddress in Patient_DAL.cs", ex);
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
        public long SearchBill(string strBillNo, string strBillFromDate, string strBillToDate, string strPatientName, string strDrName, string strHospitalName, string clientID, int OrgID, out List<BillSearch> billSearch)
        {
            long returnCode = -1;
            System.Data.SqlClient.SqlCommand cmd;
            cmd = Command.pSearchBillCommand(strBillNo, strBillFromDate, strBillToDate, strPatientName, strDrName, strHospitalName, clientID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            billSearch = new List<BillSearch>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out billSearch);
            }
            return returnCode;
        }
        //Changes of DataSet To DataReader by Arivalagna.k
        public long SearchBillOptionDetails(string strBillNo, string strBillFromDate, string strBillToDate, string strPatientName, int iPhysicianID, int OrgID, string PatientNumber, string ClientID, string VisitNumber,string BarcodeNumber, string CaseNumber, out List<BillSearch> billSearch, int pageSize, int StartRowIndex, out int totalRows, int LocationID)
        {
            long returnCode = -1;
            totalRows = 0;
            System.Data.SqlClient.SqlCommand cmd;
            billSearch = new List<BillSearch>();
            IDataReader dataReader = null;
            try
            {
                cmd = Command.pSearchBillDetailsCommand(strBillNo, strBillFromDate, strBillToDate, strPatientName, iPhysicianID, OrgID, PatientNumber, ClientID, VisitNumber, BarcodeNumber, CaseNumber, pageSize, StartRowIndex, out totalRows, LocationID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out billSearch);
                        dataReader.Close();
                    }
                    Int32.TryParse(cmd.Parameters["@totalRows"].Value.ToString(), out totalRows);
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
        public long SearchpGetCorporatePrescription(string PrescriptionNo, string strFromDate, string strToDate, string strName, int OrgID, string Number, string DepType, string IsCorp, int pageSize, int StartRowIndex, out int totalRows, out List<PatientPrescription> lstPrescription, string Status)
        {
            long returnCode = -1;
            lstPrescription = new List<PatientPrescription>();
            System.Data.SqlClient.SqlCommand cmd;
            cmd = Command.pGetCorporatePrescriptionCommand(PrescriptionNo, strFromDate, strToDate, strName, OrgID, Number, DepType, IsCorp, pageSize, StartRowIndex, out totalRows, Status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPrescription);
                totalRows = Convert.ToInt32(ds.Tables[1].Rows[0]["totalRows"]);
            }
            return returnCode;
        }
        public long SearchReceiptDetails(string strBillNo, string strReceiptFromDate, string strReceiptToDate, string strPatientName, string strPatientNo, int OrgID, int pType, string VisitID, int Page_Index, int Page_Count, out int total_rows, out List<BillSearch> billSearch)
        {
            long returnCode = -1;
            System.Data.SqlClient.SqlCommand cmd;
            cmd = Command.pSearchReceiptDetailsCommand(strBillNo, strReceiptFromDate, strReceiptToDate, strPatientName, strPatientNo, OrgID, pType, VisitID, Page_Index, Page_Count, out total_rows, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            billSearch = new List<BillSearch>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out billSearch);
                total_rows = Convert.ToInt32(ds.Tables[1].Rows[0]["totalrows"]);

            }
            return returnCode;
        }

        public long GetInvClientType(out List<InvClientType> lstInvClientType)
        {
            long returnCode = -1;
            lstInvClientType = new List<InvClientType>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetInvClientTypeCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvClientType);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetInvClientType Patient_DAL", e);
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
        public long GetPreviousDue(long pPatientID, int pOrgID, out decimal pPreviousDue)
        {
            long returnCode = -1;
            SqlCommand cmdGetPreviousDue = new SqlCommand();
            cmdGetPreviousDue = Command.pGetPreviousDueCommand(pPatientID, pOrgID, out pPreviousDue, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdGetPreviousDue.Parameters.Add("@Return", SqlDbType.Int);
            cmdGetPreviousDue.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(cmdGetPreviousDue);
                    pPreviousDue = Convert.ToDecimal(cmdGetPreviousDue.Parameters["@pPreviousDue"].Value);
                    returnCode = Convert.ToInt64(cmdGetPreviousDue.Parameters["@Return"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPreviousDue in DAL", ex);
            }
            return returnCode;
        }
        public long UpdateDueBillvisit(String ExternalVisitID, int IsDuebill, int Orgid)
        {
            long result = -1;
            SqlCommand Cmd = new SqlCommand();
            Cmd = Command.pUpdateDueBillvisitCommand(ExternalVisitID, IsDuebill, Orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(Cmd);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing Patient_DAL_pUpdateDueBillvisit", excep);
            }
            return result;
        }


        public long SaveLabVisitDetails(PatientVisit labVisit, out long pVisitID)
        {
            long result = -1;
            SqlCommand cmdInsertLabVisitDetails = new SqlCommand();
            cmdInsertLabVisitDetails = Command.pInsertLabVisitDetailsCommand(labVisit.PatientID, labVisit.OrgID, 
                labVisit.PriorityID, labVisit.ReferingPhysicianID, labVisit.ReferingPhysicianName, labVisit.HospitalID, 
                labVisit.HospitalName, labVisit.CreatedBy, labVisit.CollectionCentreID, labVisit.CollectionCentreName,
                labVisit.OrgAddressID, labVisit.ExternalVisitID, labVisit.ReferVisitID, labVisit.VisitType, labVisit.WardNo,
                labVisit.IsDueBill,labVisit.ClientID, out pVisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdInsertLabVisitDetails.Parameters.Add("@Return", SqlDbType.Int);
            cmdInsertLabVisitDetails.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;


            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(cmdInsertLabVisitDetails);
                    pVisitID = Convert.ToInt64(cmdInsertLabVisitDetails.Parameters["@pVisitID"].Value);
                    result = Convert.ToInt64(cmdInsertLabVisitDetails.Parameters["@Return"].Value);
                }

            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing SaveLabVisitDetails DAL", excep);
            }
            return result;
        }

        public long SearchBillSummary(string strBillNo, string strBillFromDate, string strBillToDate, string strPatientName, string strDrName, string strHospitalName, string clientID, string collectionCentreID, int OrgID, int flag, out List<BillSearch> billSearch)
        {
            long returnCode = -1;

            System.Data.SqlClient.SqlCommand cmd;
            cmd = Command.pSearchBillSummaryCommand(strBillNo, strBillFromDate, strBillToDate, strPatientName, strDrName, strHospitalName, clientID, collectionCentreID, OrgID, flag, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            billSearch = new List<BillSearch>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }


            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out billSearch);
            }

            return returnCode;
        }

        // changed dataset to datareader by Arivalagan.k
        public long GetLabRefOrg(int OrgID, int ClientTypeID, string Status, out List<LabReferenceOrg> lstLabRefOrg)
        {
            long returnCode = -1;
            IDataReader dataReader = null;
            lstLabRefOrg = new List<LabReferenceOrg>();
            try
            {
                SqlCommand objCommand = Command.pGetLabRefOrgCommand(OrgID, ClientTypeID, Status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstLabRefOrg);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in TrustedOrgDAL", ex);
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
        public long GetLabRefOrgAddress(long LabRefOrgID, out List<LabRefOrgAddress> lstLabRefOrgAddress)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetLabRefOrgAddressCommand(LabRefOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstLabRefOrgAddress = new List<LabRefOrgAddress>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstLabRefOrgAddress);
            }
            return returnCode;
        }
        // changed dataset to datareader by Arivalagan.k
        public long GetLabRefOrgDetailandAddress(long LabRefOrgID, out List<LabReferenceOrg> lstRefOrg, out List<LabRefOrgAddress> lstRefOrgAddress)
        {
            long returnCode = -1;

            lstRefOrgAddress = new List<LabRefOrgAddress>();
            lstRefOrg = new List<LabReferenceOrg>();
            IDataReader dataReader = null;
            int rsCount = 0;
            try
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd = Command.pGetLabDetailandAddressCommand(LabRefOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(Cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstRefOrg);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstRefOrgAddress);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in TrustedOrgDAL", ex);
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

        public long SaveLabRefOrgDetailandAddress(LabReferenceOrg LabRefOrg, LabRefOrgAddress LabRefOrgAddress)
        {
            long result = -1;
            long pLabRefOrgID = -1;
            SqlCommand cmdInsertLabRefOrg = new SqlCommand();
            SqlCommand cmdInsertLabRefOrgAddress = new SqlCommand();
            cmdInsertLabRefOrg = Command.pInsertLabRefOrgDetailsCommand(LabRefOrg.RefOrgName, LabRefOrg.OrgID, LabRefOrg.ClientTypeID, out pLabRefOrgID, LabRefOrg.Code, LabRefOrg.IsClient, LabRefOrg.ReferringType,LabRefOrg.ContactPersonID,LabRefOrg.FolderName,LabRefOrg.ContactPersonName,LabRefOrg.ContactPersonTypeID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdInsertLabRefOrg.Parameters.Add("@Return", SqlDbType.Int);
            cmdInsertLabRefOrg.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            cmdInsertLabRefOrgAddress = Command.pInsertLabRefOrgAddressCommand(LabRefOrgAddress.LabRefOrgID, LabRefOrgAddress.Add1,
                                    LabRefOrgAddress.Add2, LabRefOrgAddress.Add3, LabRefOrgAddress.City, LabRefOrgAddress.CountryID, LabRefOrgAddress.CreatedBy,
                                    LabRefOrgAddress.LandLineNumber, LabRefOrgAddress.MobileNumber, LabRefOrgAddress.PostalCode,
                                                LabRefOrgAddress.StateID, LabRefOrgAddress.AltLandLineNumber, LabRefOrgAddress.Fax, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteNonQuery(cmdInsertLabRefOrg);
                        result = Convert.ToInt64(cmdInsertLabRefOrg.Parameters["@Return"].Value);
                        if (result == 0)
                        {
                            pLabRefOrgID = Convert.ToInt64(cmdInsertLabRefOrg.Parameters["@pLabRefOrgID"].Value);
                            LabRefOrgAddress.LabRefOrgID = pLabRefOrgID;
                            cmdInsertLabRefOrgAddress.Parameters["@pLabRefOrgID"].Value = pLabRefOrgID;
                            dbEngine.ExecuteTransactionalNonQuery(cmdInsertLabRefOrgAddress);
                        }
                    }
                    tranScope.Complete();
                }
                catch (Exception excep)
                {
                    CLogger.LogError("Error while executing SaveLabRefOrgDetailandAddress DAL", excep);
                    tranScope.Dispose();
                }
                return result;
            }
        }
        public long UpdateLabRefOrgDetailandAddress(LabReferenceOrg LabRefOrg, LabRefOrgAddress LabRefOrgAddress)
        {
            long result = -1;
            long pLabRefOrgID = -1;
            SqlCommand cmdUpdateLabRefOrg = new SqlCommand();
            SqlCommand cmdUpdateLabRefOrgAddress = new SqlCommand();
            cmdUpdateLabRefOrg = Command.pUpdateLabRefOrgDetailsCommand(LabRefOrg.LabRefOrgID, LabRefOrg.RefOrgName, LabRefOrg.ClientTypeID, LabRefOrg.Status, LabRefOrg.Code, LabRefOrg.IsClient, LabRefOrg.ReferringType,Convert.ToInt64(LabRefOrg.ContactPersonID),LabRefOrg.FolderName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdUpdateLabRefOrg.Parameters.Add("@Return", SqlDbType.Int);
            cmdUpdateLabRefOrg.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            cmdUpdateLabRefOrgAddress = Command.pUpdateLabRefOrgAddressCommand(LabRefOrgAddress.AddressID, LabRefOrgAddress.LabRefOrgID, LabRefOrgAddress.Add1,
                                    LabRefOrgAddress.Add2, LabRefOrgAddress.Add3, LabRefOrgAddress.City, LabRefOrgAddress.CountryID, LabRefOrgAddress.LandLineNumber, LabRefOrgAddress.MobileNumber,
                                                LabRefOrgAddress.ModifiedBy, LabRefOrgAddress.PostalCode, LabRefOrgAddress.StateID, LabRefOrgAddress.AltLandLineNumber, LabRefOrgAddress.Fax, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteNonQuery(cmdUpdateLabRefOrg);
                        result = Convert.ToInt64(cmdUpdateLabRefOrg.Parameters["@Return"].Value);
                        if (result == 0)
                        {
                            dbEngine.ExecuteTransactionalNonQuery(cmdUpdateLabRefOrgAddress);
                        }
                    }
                    tranScope.Complete();
                }
                catch (Exception excep)
                {
                    CLogger.LogError("Error while executing UpdateLabRefOrgDetailandAddress DAL", excep);
                    tranScope.Dispose();
                }
                return result;
            }
        }
        public long getPatientCondition(out List<PatientCondition> lstPatientCondition)
        {
            long returnCode = -1;
            SqlCommand objCommand = new SqlCommand();
            lstPatientCondition = new List<PatientCondition>();
            objCommand = Command.pGetPatientConditionsCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientCondition);
            }
            return returnCode;
        }
        public long GetInPatientDischargeType(int pOrgID, out List<InPatientDischargeType> lstDischargeType)
        {
            long lresult = -1;
            DataSet ds = new DataSet();
            lstDischargeType = new List<InPatientDischargeType>();
            SqlCommand cmd = Command.pGetInPatientDischargeTypeCommand(pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    lresult = dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstDischargeType);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetRoomsListByVisitID " + cmd.CommandText, ex);
            }
            return lresult;
        }

        #endregion

        public long CheckPatientforDuplicate(string patientName, string mobileNo, string llNo, int orgID, string patientNumber, out int count)
        {
            long returnCode = -1;
            count = -1;
            DataSet ds = new DataSet();
            SqlCommand cmd = Command.pCheckPatientforDuplicateCommand(patientName, mobileNo, llNo, orgID, patientNumber, out count, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    count = Convert.ToInt32(cmd.Parameters["@pCount"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL CheckPatientforDuplicate", ex);
            }

            return returnCode;
        }

        public long RegistrationDeflag(long VisitId, long OrgId)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pUpdateDeflagRegistrationCommand(VisitId, OrgId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmd);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing RegistrationRepush in Patient_DAL", ex);
            }
            return returnCode;
        }

        public long SavePatientEmployer(PatientEmployer pEmployer,
            InPatientAdmissionDetails IPDetails,
            RTAMLCDetails objRTAMLC, List<PrimaryConsultant> lstPrimaryConsultant, int OrgID, string IsCreditBill,
              long ReferingPhysicianID, string ReferingPhysicianName, int ReferingSpecialityID,
            string PhysicianType,
            decimal CreditLimit, string CreditLimitApprover, string CreditLimitRemarks,
            int RoomTypeID, string IsSurgeryPatient, List<VisitClientMapping> lstVisitClientMapping)
        {
            long lResult = -1;
            DataTable dtPrimaryCons = UDT_DAL.ConvertToPrimaryConsultant(lstPrimaryConsultant);

            SqlCommand cmdInsertInPatient = new SqlCommand();
            SqlCommand cmdInsertAddress = new SqlCommand();
            cmdInsertInPatient = Command.pInsertInPatientCommand(IPDetails.PatientID, IPDetails.VisitID,
                                    IPDetails.PurposeOfAdmissionID, IPDetails.ConditionOnAdmissionID,
                                    IPDetails.ContactNo, IPDetails.PrimaryPhysicianID, IPDetails.ConsultingSurgeonID, IPDetails.SpecialityID, IPDetails.MedicallyInsured, IPDetails.OrganDonation, IPDetails.AccompaniedBy, IPDetails.RelationshipID, IPDetails.RelationContactNo, IPDetails.KnowledgeOfServiceID, IPDetails.ServiceProviderName,
                                    IPDetails.InformationBy, IPDetails.CreatedBy,
                                     IPDetails.AdmissionDate, IPDetails.DutyOfficerID, IsCreditBill, dtPrimaryCons, ReferingPhysicianID,
                                     ReferingPhysicianName, ReferingSpecialityID, PhysicianType,
                                       CreditLimit, CreditLimitApprover,
                                     CreditLimitRemarks, RoomTypeID, IsSurgeryPatient, UDT_DAL.ConvertToUDT_Context(globalContextDetails),
                                     IPDetails.Address, IPDetails.RelationshipName, UDT_DAL.ConvertToVisitClientMapping(lstVisitClientMapping));

            cmdInsertInPatient.Parameters.Add("@Return", SqlDbType.Int);
            cmdInsertInPatient.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            cmdInsertAddress = Command.pInsertPatientEmployerCommand(pEmployer.PatientID, pEmployer.EmployerName, pEmployer.EmployeeName, pEmployer.EmployeeNo, pEmployer.Add1, pEmployer.Add2, pEmployer.Add3, pEmployer.PostalCode, pEmployer.CountryID, pEmployer.City, pEmployer.StateID, pEmployer.MobileNumber, pEmployer.LandLineNumber, pEmployer.CreatedBy, IPDetails.VisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdInsertAddress.Parameters.Add("@Return", SqlDbType.Int);
            cmdInsertAddress.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            SqlCommand cmdPatientRTAMLCDetails = new SqlCommand();
            cmdPatientRTAMLCDetails = Command.pInsertIPRTAMLCDetailsCommand(IPDetails.PatientID, IPDetails.VisitID,
                                    objRTAMLC.AlcoholDrugInfluence, objRTAMLC.FIRNo, objRTAMLC.Location, objRTAMLC.RTAMLCDate,
                                                OrgID, IPDetails.CreatedBy, objRTAMLC.PoliceStation, objRTAMLC.MLCNo, objRTAMLC.FIRDate, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdPatientRTAMLCDetails.Parameters.Add("@Return", SqlDbType.Int);
            cmdPatientRTAMLCDetails.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteTransactionalNonQuery(cmdInsertInPatient);
                        lResult = Convert.ToInt64(cmdInsertInPatient.Parameters["@Return"].Value);
                        if (lResult == 0)
                        {
                            dbEngine.ExecuteTransactionalNonQuery(cmdInsertAddress);
                            lResult = Convert.ToInt64(cmdInsertAddress.Parameters["@Return"].Value);
                            if (lResult == 0)
                            {
                                dbEngine.ExecuteTransactionalNonQuery(cmdPatientRTAMLCDetails);
                            }

                        }
                    }
                    tranScope.Complete();
                }

                catch (Exception ex)
                {
                    CLogger.LogError("Error while executing SavePatientEmployer in Patient_DAL", ex);
                    tranScope.Dispose();
                }
            }

            return lResult;
        }


        public long UpdatePatientEmployer(PatientEmployer pEmployer, InPatientAdmissionDetails IPDetails,
                                          RTAMLCDetails objRTAMLC, List<PrimaryConsultant> lstPrimaryConsultant,
                                        int OrgID, string IsCredit, long ReferingPhysicianID,
                                        string ReferingPhysicianName, int ReferingSpecialityID, string PhysicianType
             , decimal CreditLimit, string CreditLimitApprover, string CreditLimitRemarks, int RoomTypeID, string IsSurgeryPatient,
            List<VisitClientMapping> lstVisitClientMapping)
        {
            long lResult = -1;
            DataTable dtPrimaryCons = UDT_DAL.ConvertToPrimaryConsultant(lstPrimaryConsultant);
            SqlCommand cmdUpdateInPatient = new SqlCommand();
            SqlCommand cmdUpdateAddress = new SqlCommand();

            cmdUpdateInPatient = Command.pUpdateAdmissionInPatientCommand(IPDetails.PatientID, IPDetails.VisitID,
                                    IPDetails.PurposeOfAdmissionID,
                                    IPDetails.ConditionOnAdmissionID, IPDetails.ContactNo,
                                    IPDetails.PrimaryPhysicianID, IPDetails.ConsultingSurgeonID,
                                    IPDetails.SpecialityID, IPDetails.MedicallyInsured, IPDetails.OrganDonation,
                                    IPDetails.AccompaniedBy, IPDetails.RelationshipID, IPDetails.RelationContactNo,
                                    IPDetails.KnowledgeOfServiceID, IPDetails.ServiceProviderName,
                                    IPDetails.InformationBy, IPDetails.CreatedBy,
                                      IPDetails.AdmissionDate,
                                    IPDetails.DutyOfficerID, dtPrimaryCons, IsCredit,
                                    ReferingPhysicianID, ReferingPhysicianName, ReferingSpecialityID
                                   , PhysicianType, CreditLimit, CreditLimitApprover, CreditLimitRemarks, RoomTypeID, IsSurgeryPatient,
                                 UDT_DAL.ConvertToUDT_Context(globalContextDetails), IPDetails.Address,
                                 IPDetails.RelationshipName, UDT_DAL.ConvertToVisitClientMapping(lstVisitClientMapping));
            cmdUpdateInPatient.Parameters.Add("@Return", SqlDbType.Int);
            cmdUpdateInPatient.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            cmdUpdateAddress = Command.pUpdateAdmissionPatientEmployerCommand(pEmployer.PatientID, pEmployer.EmployerName, pEmployer.EmployeeName, pEmployer.EmployeeNo, pEmployer.Add1, pEmployer.Add2, pEmployer.Add3, pEmployer.PostalCode, pEmployer.CountryID, pEmployer.City, pEmployer.StateID, pEmployer.MobileNumber, pEmployer.LandLineNumber, pEmployer.CreatedBy, IPDetails.VisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdUpdateAddress = Command.pInsertPatientEmployerCommand(pEmployer.PatientID, pEmployer.EmployerName, pEmployer.EmployeeName, pEmployer.EmployeeNo, pEmployer.Add1, pEmployer.Add2, pEmployer.Add3, pEmployer.PostalCode, pEmployer.CountryID, pEmployer.City, pEmployer.StateID, pEmployer.MobileNumber, pEmployer.LandLineNumber, pEmployer.CreatedBy, IPDetails.VisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdUpdateAddress.Parameters.Add("@Return", SqlDbType.Int);
            cmdUpdateAddress.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            SqlCommand cmdPatientRTAMLCDetails = new SqlCommand();
            cmdPatientRTAMLCDetails = Command.pInsertIPRTAMLCDetailsCommand(IPDetails.PatientID, IPDetails.VisitID,
                                    objRTAMLC.AlcoholDrugInfluence, objRTAMLC.FIRNo, objRTAMLC.Location, objRTAMLC.RTAMLCDate,
                                                OrgID, IPDetails.CreatedBy, objRTAMLC.PoliceStation, objRTAMLC.MLCNo, objRTAMLC.FIRDate, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdPatientRTAMLCDetails.Parameters.Add("@Return", SqlDbType.Int);
            cmdPatientRTAMLCDetails.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteTransactionalNonQuery(cmdUpdateInPatient);
                        lResult = Convert.ToInt64(cmdUpdateInPatient.Parameters["@Return"].Value);
                        if (lResult == 0)
                        {
                            dbEngine.ExecuteTransactionalNonQuery(cmdUpdateAddress);
                            lResult = Convert.ToInt64(cmdUpdateAddress.Parameters["@Return"].Value);
                            if (lResult == 0)
                            {
                                dbEngine.ExecuteTransactionalNonQuery(cmdPatientRTAMLCDetails);
                            }
                        }
                    }
                    tranScope.Complete();
                }
                catch (Exception ex)
                {
                    CLogger.LogError("Error while executing UpdatePatientEmployer in Patient_DAL", ex);
                    tranScope.Dispose();
                }
            }
            return lResult;
        }


        public long SavePatientOrganDonation(List<OrganRegWithMapping> orgMap, long VisitID)
        {
            int i;
            long lResult = -1;
            DataTable dtOrganTable = UDT_DAL.ConvertTopatientOrganDonation(orgMap);

            SqlCommand cmdInsertPatientOrg = new SqlCommand();


            cmdInsertPatientOrg = Command.pInsertPatientOrganDonationCommand(dtOrganTable, VisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdInsertPatientOrg.Parameters.Add("@Return", SqlDbType.Int);
            cmdInsertPatientOrg.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {


                        dbEngine.ExecuteTransactionalNonQuery(cmdInsertPatientOrg);
                        lResult = Convert.ToInt64(cmdInsertPatientOrg.Parameters["@Return"].Value);

                    }
                    tranScope.Complete();
                }

                catch (Exception ex)
                {
                    CLogger.LogError("Error while saving Patient Organ Donation ", ex);
                    tranScope.Dispose();
                }

            }
            return lResult;

        }






        public long SearchInPatient(string inPatientNo, string strSmartCardNo, string strPatientName, string roomNo, string strDOB, string strCellNo, string strPurpose, int orgID, int parentID, string ipNo, string needDischarge, string strNationality, string pTPAID, string pClientID, string pFDate, string pTDate, string pAdFDate1, string pAdTDate1, int pageSize, int StartRowIndex, int VisitPurposeID, out int totalRows, out List<Patient> lstPatient)
        {
            long returnCode = -1;
            totalRows = 0;
            System.Data.SqlClient.SqlCommand cmd;
            cmd = Command.pSearchInPatientCommand(inPatientNo, strSmartCardNo, strPatientName, roomNo, strDOB, strCellNo, strPurpose, orgID, parentID, ipNo, needDischarge, strNationality, pTPAID, pClientID, pFDate, pTDate, pAdFDate1, pAdTDate1, pageSize, StartRowIndex, VisitPurposeID, out totalRows, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstPatient = new List<Patient>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }


            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatient);
                totalRows = Convert.ToInt32(ds.Tables[1].Rows[0]["totalRows"]);
            }

            return returnCode;
        }
		// changed dataset to datareader by Arivalagan.k
        public long pCheckPatientisIPorOP(long pPatientVisitID, long pPatientID, int pOrgID, out string outStatus)
        {
            long returnCode = -1;
            outStatus = string.Empty;
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pCheckPatientisIPorOPCommand(pPatientVisitID, pPatientID, pOrgID, out outStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        dataReader.Close();
                    }
                    outStatus = cmd.Parameters["@pOutStatus"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL pCheckPatientisIPorOP", ex);
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

        //Changes of DataSet To DataReader Made By Arivalagan.k
        public long GetReportTemplate(long patientVisitID, int OrgID,string ReportLanguage, out List<InvReportMaster> lstReportMaster, out List<InvReportMaster> lstReportName, out  List<InvDeptMaster> lstDpts)
        {
            long returnCode = -1;
            lstReportMaster = new List<InvReportMaster>();
            lstReportName = new List<InvReportMaster>();
            lstDpts = new List<InvDeptMaster>();
            int rsCount = 0;
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetReportTemplateCommand(patientVisitID, OrgID, ReportLanguage, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstReportMaster);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstReportName);
                            }
                            else if (rsCount == 2)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstDpts);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
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

        public long GetInvestigationDrug(int orgID, string filterText, out List<PatientPrescription> lstPrescrition)
        {
            long returnCode = -1;
            lstPrescrition = new List<PatientPrescription>();
            SqlCommand cmd = Command.pGetInvestigationDrugsCommand(orgID, filterText, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstPrescrition);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing Load investigation drugs in Patient_DAL", ex);
            }
            return returnCode;
        }

        public long CheckURNoAvailablity(long pID, out string pURNo, out int pURNORGid)
        {
            long returnCode = -1;

            pURNo = string.Empty;
            pURNORGid = -1;
            try
            {
                SqlCommand cmd = Command.pCheckURNoAvailablityCommand(pID, out pURNo, out pURNORGid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    pURNo = cmd.Parameters["@pURNO"].Value.ToString();
                    pURNORGid = Convert.ToInt32(cmd.Parameters["@pURNORGid"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL CheckURNoAvailablity", ex);
            }

            return returnCode;
        }
        public long InsertPatientFromReferredOrg(long pID, int pOrgID, out long pRefOrgPID)
        {
            long returnCode = -1;
            pRefOrgPID = -1;
            try
            {
                SqlCommand cmd = Command.pInsertPatientFromReferredOrgCommand(pID, pOrgID, out pRefOrgPID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    pRefOrgPID = Convert.ToInt64(cmd.Parameters["@pRefOrgPID"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL InsertPatientFromReferredOrg", ex);
            }

            return returnCode;
        }

        // changed dataset to datareader by Arivalagan.k
        public long GetLabVisitDetails(long visitID, int OrgID, string UID, out List<PatientVisit> lstVisitDetails)
        {
            long returnCode = -1;
            lstVisitDetails = new List<PatientVisit>();
            SqlCommand objCommand = new SqlCommand();
            	IDataReader dataReader = null;
            try
            {
                objCommand = Command.pGetLabVisitDetailsCommand(visitID, OrgID, UID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstVisitDetails);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetLabVisitDetails in Patient_DAL", ex);
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

        public long GetReportTemplateForDept(long patientVisitID, string InvIDs, long roleID, int OrgID, string UID, out List<InvReportMaster> lstReportMaster, out List<InvReportMaster> lstReportName)
        {
            long returnCode = -1;
            lstReportMaster = new List<InvReportMaster>();
            lstReportName = new List<InvReportMaster>();
            try
            {
                SqlCommand cmd = Command.pGetReportTemplateForDeptCommand(patientVisitID, InvIDs, roleID, OrgID, UID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstReportMaster);
                }

                if (ds.Tables[1].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[1], out lstReportName);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Exececutin Patient_Dal", ex);
            }

            return returnCode;
        }
        // changed dataset to datareader by Arivalagan.k
        public long GetPriorityMaster(out List<PriorityMaster> lstPriorityMaster)
        {
            long lresult = -1;
            lstPriorityMaster = new List<PriorityMaster>();
            IDataReader dataReader = null;
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = Command.pGetPriorityMasterCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        lresult = Utilities.ConvertTo(dataReader, out lstPriorityMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPriorityMaster Patient_DAL" + cmd.CommandText, ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            } 
            return lresult;
        }
        public long GetCollectionCentre(int OrgID, out List<CollectionCentreMaster> lstCollectionCentre)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetCollectionCentreCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstCollectionCentre = new List<CollectionCentreMaster>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstCollectionCentre);
            }
            return returnCode;
        }
        // changed dataset to datareader by Arivalagan.k
        public long GetReferingPhysician(string FilterText, int OrgID, out List<ReferingPhysician> lstReferingPhysician)
        {
            long returnCode = -1;
            lstReferingPhysician = new List<ReferingPhysician>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetFilterPhysicianCommand(FilterText, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                     dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstReferingPhysician);
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
                CLogger.LogError("Error while loading GetReferingPhysician Patient_DAL", ex);
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

        public long GetSummaryReportData(int OrgID, out List<InvClientMaster> getInvClientMaster,
                                        out List<ReferingPhysician> getReferingPhysician,
                                        out  List<CollectionCentreMaster> getCollectionCentre,
                                        out List<LabReferenceOrg> RefOrg,
                                        out List<PatientInvestigation> lstInvestigation,
                                        out List<LabSummaryReportParameter> getLabSummaryReportParameter
                                        , out List<InvDeptMaster> lDeptmaster)
        {
            long returnCode = -1;
            getInvClientMaster = new List<InvClientMaster>();
            getReferingPhysician = new List<ReferingPhysician>();
            getCollectionCentre = new List<CollectionCentreMaster>();
            RefOrg = new List<LabReferenceOrg>();
            lstInvestigation = new List<PatientInvestigation>();
            getLabSummaryReportParameter = new List<LabSummaryReportParameter>();
            lDeptmaster = new List<InvDeptMaster>();

            SqlCommand cmd = Command.pGetLabSummaryreportDetailsCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbengine = new DBEngine())
            {
                dbengine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out getInvClientMaster);
            }

            if (ds.Tables[1].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[1], out getReferingPhysician);
            }
            if (ds.Tables[2].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[2], out getCollectionCentre);
            }
            if (ds.Tables[3].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[3], out RefOrg);
            }

            if (ds.Tables[4].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[4], out lstInvestigation);
            }

            if (ds.Tables[5].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[5], out getLabSummaryReportParameter);
            }
            if (ds.Tables[6].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[6], out lDeptmaster);
            }

            return returnCode;
        }
        public long GetDeptwiseReport(long UserID, long DeptId, DateTime FromDate, DateTime ToDate, int OrgID, int SplitUp, out List<DailyReport> lDailyReport, out List<DailyReport> lDeptName, out List<LabConsumables> lstLabConsumables, out decimal GrandTotal, out decimal TotalCashAmount, out decimal TotalDiscountAmount, out decimal TotalPaidAmount, out decimal TotalDuePaidAmount, out decimal CombinedDeptAmount)
        {
            long returnCode = -1;
            lDailyReport = new List<DailyReport>();
            lDeptName = new List<DailyReport>();
            lstLabConsumables = new List<LabConsumables>();
            GrandTotal = 0;
            TotalCashAmount = 0;
            TotalDiscountAmount = 0;
            TotalDuePaidAmount = 0;
            TotalPaidAmount = 0;
            CombinedDeptAmount = 0;
            try
            {
                SqlCommand cmd = Command.pGetDeptWiseReportCommand(FromDate, ToDate, DeptId, UserID, OrgID, SplitUp, out GrandTotal, out TotalCashAmount, out TotalDiscountAmount, out TotalPaidAmount, out TotalDuePaidAmount, out CombinedDeptAmount, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    GrandTotal = Convert.ToDecimal(cmd.Parameters["@GrandTotal"].Value);
                    TotalCashAmount = Convert.ToDecimal(cmd.Parameters["@TotalCashAmount"].Value);
                    TotalDiscountAmount = Convert.ToDecimal(cmd.Parameters["@TotalDiscountAmount"].Value);
                    TotalDuePaidAmount = Convert.ToDecimal(cmd.Parameters["@TotalDuePaidAmount"].Value);
                    TotalPaidAmount = Convert.ToDecimal(cmd.Parameters["@TotalPaidAmount"].Value);
                    CombinedDeptAmount = Convert.ToDecimal(cmd.Parameters["@CombinedDeptAmount"].Value);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lDailyReport);
                }

                if (ds.Tables[1].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[1], out lDeptName);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[2], out lstLabConsumables);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Exececutin Patient_Dal", ex);
            }
            return returnCode;
        }

        public long SearchBillByParameter(DateTime strBillFromDate, DateTime strBillToDate, int ReferingPhysicianID, long HospitalID, int clientID, int collectionCentreID, int InsuranceID, int OrgID, int flag, out List<DailyReport> billSearch, out List<BillLineItems> billItems, out decimal GrandTotal)
        {
            long returnCode = -1;
            GrandTotal = 0;
            System.Data.SqlClient.SqlCommand cmd;
            cmd = Command.pSearchBillByParameterCommand(strBillFromDate, strBillToDate, ReferingPhysicianID, HospitalID, clientID, collectionCentreID, InsuranceID, OrgID, flag, out GrandTotal, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            billSearch = new List<DailyReport>();
            billItems = new List<BillLineItems>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
                GrandTotal = Convert.ToInt64(cmd.Parameters["@pGrandTotal"].Value);
            }


            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out billSearch);

                returnCode = Utilities.ConvertTo(ds.Tables[1], out billItems);
            }
            return returnCode;
        }
        // changed dataset to datareader by Arivalagan.k
        public long GetReferingPhysician(int OrgID, string physicianName, string Status, out List<ReferingPhysician> lstReferingPhysician)
        {
            long returnCode = -1;
            lstReferingPhysician = new List<ReferingPhysician>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetReferingPhysicianCommand(OrgID, physicianName, Status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstReferingPhysician);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetVitekDeviceIntegrationResult Integration_DAL", e);
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
        //Changes of DataSet To DataReader Made By Arivalagan.k
        public long GetInvClientMaster(int OrgID, out List<InvClientMaster> lstInvClientMaster)
        {
            long returnCode = -1;
            lstInvClientMaster = new List<InvClientMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetInvClientMasterCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvClientMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetInvClientMaster patientDal", ex);
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
        public long UpdateLabVisitDetails(PatientVisit labVisit)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pUpdateLabVisitDetailsCommand(labVisit.PatientID, labVisit.OrgID, labVisit.PriorityID,
                                    labVisit.ReferingPhysicianID, labVisit.ReferingPhysicianName, labVisit.HospitalID,
                                    labVisit.HospitalName, labVisit.ModifiedBy,
                                                    labVisit.CollectionCentreID, labVisit.CollectionCentreName, labVisit.PatientVisitId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            objCommand.Parameters.Add("@Return", SqlDbType.Int);
            objCommand.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(objCommand);
                    returnCode = Convert.ToInt64(objCommand.Parameters["@Return"].Value);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing UpdateLabVisitDetails in Patient_DAL", excep);
            }
            return returnCode;
        }
        public long GetBillDetails(string pBillID, int OrgID, out List<BillMaster> billMaster, out List<BillLineItems> billLineItems, out List<PatientVisit> labVisitDetails)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetBillDetailsCommand(pBillID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            billLineItems = new List<BillLineItems>();
            billMaster = new List<BillMaster>();
            labVisitDetails = new List<PatientVisit>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);


            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out billMaster);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[1], out billLineItems);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[2], out labVisitDetails);
            }
            return returnCode;
        }

        public long CancelBillDetails(string pBillID, int OrgID, long LID, string comments)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pCancelBillDetailsCommand(pBillID, OrgID, LID, comments, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            objCommand.Parameters.Add("@Return", SqlDbType.Int);
            objCommand.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(objCommand);
                    returnCode = Convert.ToInt64(objCommand.Parameters["@Return"].Value);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing CancelBillDetails DAL", excep);
            }
            return returnCode;
        }

        public long WGetBillDetails(int OrgID, long PatientVisitID, out List<BillDetails> bdetils)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetBillDetailsWortixCommand(PatientVisitID,OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            bdetils = new List<BillDetails>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);


            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out bdetils);
            }
            //if (ds.Tables.Count > 0)
            //{
            //    returnCode = Utilities.ConvertTo(ds.Tables[1], out billLineItems);
            //}
            //if (ds.Tables.Count > 0)
            //{
            //    returnCode = Utilities.ConvertTo(ds.Tables[2], out labVisitDetails);
            //}
            return returnCode;
        }
        public long WUpdateNotifications(long visitID, int OrgID, String Msg)
        {
            long returnCode = -1;
            SqlCommand cmdUpdateDispatchDetails = new SqlCommand();
            cmdUpdateDispatchDetails = Command.pUpdateNotificationDetailsCommand(visitID,OrgID,Msg, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdUpdateDispatchDetails.Parameters.Add("@Return", SqlDbType.Int);
            cmdUpdateDispatchDetails.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(cmdUpdateDispatchDetails);
                    returnCode = Convert.ToInt64(cmdUpdateDispatchDetails.Parameters["@Return"].Value);
                }

            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing UpdateNotifications in Patient_DAL", excep);
            }
            return returnCode;
        }
        public long LoadUserList(int orgID, out List<Login> lstUsers)
        {
            long returnCode = -1;
            lstUsers = new List<Login>();
            try
            {
                SqlCommand cmd = Command.pGetListOfUsersCommand(orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine db = new DBEngine())
                {
                    db.ExecuteDataSet(cmd, out ds);

                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstUsers);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Excecuting load user list method in patient_dal", ex);
            }
            return returnCode;
        }
        public long UpdateDispatchDetails(long visitID, int OrgID)
        {
            long returnCode = -1;
            SqlCommand cmdUpdateDispatchDetails = new SqlCommand();
            cmdUpdateDispatchDetails = Command.pUpdateDispatchDetailsCommand(visitID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdUpdateDispatchDetails.Parameters.Add("@Return", SqlDbType.Int);
            cmdUpdateDispatchDetails.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(cmdUpdateDispatchDetails);
                    returnCode = Convert.ToInt64(cmdUpdateDispatchDetails.Parameters["@Return"].Value);
                }

            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing UpdateDispatchDetails in Patient_DAL", excep);
            }
            return returnCode;
        }
        public long ChangePriority(long VisitID, int OrgID, long LID, int PriorityID)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pUpdatePriorityCommand(VisitID, OrgID, LID, PriorityID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            objCommand.Parameters.Add("@Return", SqlDbType.Int);
            objCommand.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(objCommand);
                    returnCode = Convert.ToInt64(objCommand.Parameters["@Return"].Value);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing ChangePriority in Patient_DAL", excep);
            }
            return returnCode;
        }
        public long UpdateLabPatientDetails(Patient patient, PatientAddress pAddress)
        {
            long returnCode = -1;
            SqlCommand cmdUpdatePatientDetails = new SqlCommand();
            SqlCommand cmdUpdatePatientAddress = new SqlCommand();
            cmdUpdatePatientDetails = Command.pUpdateLabPatientDetailsCommand(patient.OrgID, patient.PatientID, patient.Name, patient.TITLECode, patient.Age, patient.DOB, patient.SEX, patient.ModifiedBy, patient.URNO, patient.URNofId, patient.URNTypeId, patient.Race, patient.Nationality, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdUpdatePatientDetails.Parameters.Add("@Return", SqlDbType.Int);
            cmdUpdatePatientDetails.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            cmdUpdatePatientAddress = Command.pUpdatePatientAddressCommand(patient.PatientID, pAddress.AddressType, pAddress.Add1,
                                    pAddress.Add2, pAddress.Add3, pAddress.PostalCode, pAddress.CountryID,
                                    pAddress.City, pAddress.StateID, pAddress.MobileNumber, pAddress.LandLineNumber,
                                                patient.CreatedBy, pAddress.AddressID, patient.ModifiedBy, pAddress.OtherCountryName, pAddress.OtherStateName, pAddress.CountryCode, pAddress.StateCode, pAddress.CityCode, pAddress.AddLevel1, pAddress.AddLevel2, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdUpdatePatientAddress.Parameters.Add("@Return", SqlDbType.Int);
            cmdUpdatePatientAddress.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteTransactionalNonQuery(cmdUpdatePatientDetails);

                        returnCode = Convert.ToInt64(cmdUpdatePatientDetails.Parameters["@Return"].Value);
                        if (returnCode == 0)
                        {
                            dbEngine.ExecuteTransactionalNonQuery(cmdUpdatePatientAddress);
                            returnCode = Convert.ToInt64(cmdUpdatePatientAddress.Parameters["@Return"].Value);
                        }
                    }
                    tranScope.Complete();
                }
                catch (Exception excep)
                {

                    CLogger.LogError("Error while executing UpdateLabPatientDetails DAL", excep);
                    tranScope.Dispose();
                }
                return returnCode;
            }
        }
        public long GetDispatchDetails(long visitID, int OrgID, out List<PatientVisit> lstVisitDetails, out List<PatientAddress> lstPatientAddress, out List<ResultPublishing> lstResultPublishing, out List<ShippingAddress> lstShippingAddress, out List<PatientInvestigation> lstPatientInvestigation1, out List<PatientInvestigation> lstPatientInvestigation2, out List<CollectedSample> lstOrderedInvSample)
        {
            long returnCode = -1;
            SqlCommand objCommand = new SqlCommand();
            objCommand = Command.pGetDispatchDetailsCommand(visitID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstVisitDetails = new List<PatientVisit>();
            lstPatientAddress = new List<PatientAddress>();
            lstResultPublishing = new List<ResultPublishing>();
            lstShippingAddress = new List<ShippingAddress>();
            lstPatientInvestigation1 = new List<PatientInvestigation>();
            lstPatientInvestigation2 = new List<PatientInvestigation>();
            lstOrderedInvSample = new List<CollectedSample>();
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstVisitDetails);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPatientAddress);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstResultPublishing);
                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstShippingAddress);
                }
                if (ds.Tables[4].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[4], out lstPatientInvestigation1);
                }
                if (ds.Tables[5].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[5], out lstPatientInvestigation2);
                }
                if (ds.Tables[6].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[6], out lstOrderedInvSample);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing GetDispatchDetails in Patient_DAL", excep);
            }
            return returnCode;
        }
        public long SaveDueCollection(BillMaster objBillMaster, BillLineItems objBillLineItems, out string pNewBillID)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pInsertDueCollectionDetailsCommand(objBillMaster.BillID, objBillMaster.OrgID, objBillMaster.VisitID, objBillMaster.PatientID,
                                    objBillMaster.ClientID, objBillMaster.CollectionCentreID, objBillMaster.Type, objBillMaster.GrossAmount,
                                    objBillMaster.Discount, objBillMaster.TaxPercent, objBillMaster.NetAmount, objBillMaster.AmountReceived,
                                    objBillMaster.AmountDue, objBillMaster.IsCredit, objBillMaster.Comments, objBillMaster.CreatedBy, objBillLineItems.ItemName, objBillLineItems.ItemType,
                                                objBillLineItems.Quantity, objBillLineItems.Rate, objBillLineItems.Amount, out pNewBillID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            objCommand.Parameters.Add("@Return", SqlDbType.Int);
            objCommand.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(objCommand);
                    pNewBillID = Convert.ToString(objCommand.Parameters["@pNewBillID"].Value);
                    returnCode = Convert.ToInt64(objCommand.Parameters["@Return"].Value);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing SaveDueCollection Patient_DAL", excep);
            }
            return returnCode;

        }


        // changed dataset to datareader by Arivalagan.k
        public long GetLabDiscount(int OrgID, out List<DiscountMaster> lstDiscountMaster)
        {
            long returnCode = -1;
            lstDiscountMaster = new List<DiscountMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetLabDiscountLisCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstDiscountMaster);
                        dataReader.Close();
                    } 
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Patient DAL GetLabDiscount", ex);
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


        public long GetPrescription(string DrugName, int Filter, int pOrgID, out List<PatientPrescription> lstPrescription, int
             OrgAddressId, int LocationId, long PatientVisitID)
        {
            long lresult = -1;
            lstPrescription = new List<PatientPrescription>();
            SqlCommand cmd = Command.pGetDrugsCommand(DrugName, Filter, pOrgID, OrgAddressId, LocationId, PatientVisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();

            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstPrescription);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPrescription in Patient_DAL" + cmd.CommandText, ex);
            }

            return lresult;

        }
        public long GetInvDepartment(long orgID, out List<InvDeptMaster> lDeptMaster)
        {
            long returnCode = -1;
            lDeptMaster = new List<InvDeptMaster>();

            try
            {
                SqlCommand cmd = Command.pGetInvDeptMasterCommand(orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEng = new DBEngine())
                {
                    dbEng.ExecuteDataSet(cmd, out ds);

                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lDeptMaster);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Load investigation Department in Patiend Dal", ex);
            }
            return returnCode;
        }


        public long UpdateReferingPhysician(ReferingPhysician objReferingPhysician, List<AddressDetails> lstRefPhyAddresDetails, List<PhysicianOrgMapping> POM, string Deleted)
        {
            long returnCode = -1;
            DataTable DtTab = UDT_DAL.ConvertToPhysicianOrgMappingUDT(POM);
            DataTable DTRefPhyAddDtls = UDT_DAL.ConvertToUDTAddressDetails(lstRefPhyAddresDetails);
            SqlCommand cmdUpdateReferingPhysician = new SqlCommand();
            cmdUpdateReferingPhysician = Command.pUpdateReferingPhysicianCommand(objReferingPhysician.ReferingPhysicianID,
                                                objReferingPhysician.OrgID, objReferingPhysician.Status, objReferingPhysician.Salutation,
                                                objReferingPhysician.PhysicianName, objReferingPhysician.PhysicianCode, objReferingPhysician.Qualification,
                                                objReferingPhysician.OrganizationName, Convert.ToInt32(objReferingPhysician.LoginID), DtTab, Deleted,
                                                objReferingPhysician.Gender, objReferingPhysician.IsClient, objReferingPhysician.IsActive,
                                                objReferingPhysician.ModifiedBy, DTRefPhyAddDtls, objReferingPhysician.DOB, objReferingPhysician.Age,
                                                UDT_DAL.ConvertToUDT_Context(globalContextDetails), objReferingPhysician.DiscountLimit, objReferingPhysician.DiscountPeriod, objReferingPhysician.DiscountValidFrom, objReferingPhysician.DiscountValidTo, objReferingPhysician.RefFeeCategoryid, objReferingPhysician.ContactPersonID);
            cmdUpdateReferingPhysician.Parameters.Add("@Return", SqlDbType.Int);
            cmdUpdateReferingPhysician.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmdUpdateReferingPhysician);
                    returnCode = Convert.ToInt64(cmdUpdateReferingPhysician.Parameters["@Return"].Value);
                }

            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing UpdateReferingPhysician in Patient_DAL", excep);
            }
            return returnCode;
        }

        public long getEventChartIsTrustedOrg(long patientId, long currentVisitId, string sTreatmentType, out List<EventChart> lstEventChart, out List<PatDtlsVPAction> lstPatDtlsVPAction,
            out List<PatientDrug> lstPatientDrug, out List<InvestigationPatient> lstInvestigation,
            out List<PatientExamination> lstPatientExamination, out List<PatientHistory> lstPatientHistory)
        {
            long lResult = -1;
            SqlCommand cmdEventChart = new SqlCommand();
            cmdEventChart.CommandType = CommandType.StoredProcedure;
            cmdEventChart.CommandText = "pGetEventTreatmentInvestigationIsTrusterdOrg";
            cmdEventChart.Parameters.Add("@pPatientId", SqlDbType.BigInt);
            cmdEventChart.Parameters["@pPatientId"].Value = patientId;
            cmdEventChart.Parameters.Add("@pCurrentVisitId", SqlDbType.BigInt);
            cmdEventChart.Parameters["@pCurrentVisitId"].Value = currentVisitId;
            cmdEventChart.Parameters.Add("@TreatmentType", SqlDbType.Text);
            cmdEventChart.Parameters["@TreatmentType"].Value = sTreatmentType;

            lstEventChart = new List<EventChart>();
            lstPatientDrug = new List<PatientDrug>();
            lstInvestigation = new List<InvestigationPatient>();
            lstPatientExamination = new List<PatientExamination>();
            lstPatientHistory = new List<PatientHistory>(); lstPatDtlsVPAction = new List<PatDtlsVPAction>();
            DataSet dataSet = new DataSet();
            using (DBEngine dbEngine = new DBEngine(false))
            {
                lResult = dbEngine.ExecuteDataSet(cmdEventChart, out dataSet);
            }
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                lResult = Utilities.ConvertTo(dataSet.Tables[0], out lstEventChart);
            }
            if (dataSet.Tables[1].Rows.Count > 0)
            {
                lResult = Utilities.ConvertTo(dataSet.Tables[1], out lstPatDtlsVPAction);
            }
            if (dataSet.Tables[1].Rows.Count > 0)
            {
                lResult = Utilities.ConvertTo(dataSet.Tables[1], out lstPatientDrug);
            }
            if (dataSet.Tables[2].Rows.Count > 0)
            {
                lResult = Utilities.ConvertTo(dataSet.Tables[2], out lstInvestigation);
            }
            if (dataSet.Tables[3].Rows.Count > 0)
            {
                lResult = Utilities.ConvertTo(dataSet.Tables[3], out lstPatientExamination);
            }
            if (dataSet.Tables[4].Rows.Count > 0)
            {
                lResult = Utilities.ConvertTo(dataSet.Tables[4], out lstPatientHistory);
            }
            return lResult;
        }
        public long GetPatientLoginDetails(long patientID, out List<Login> lstLoginDetails)
        {
            long returnCode = -1;
            lstLoginDetails = new List<Login>();
            SqlCommand cmd = Command.pGetPatientLoginDetailsCommand(patientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Utilities.ConvertTo(ds.Tables[0], out lstLoginDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing Load GetPatientLoginDetails in Patient_DAL", ex);
            }
            return returnCode;
        }

        public long GetPatientRegDetails(long patientID, long pID, out List<Patient> lstPatient, out List<PatientAddress> lstPatientAddress, out List<PatientAllergies> lstPatientAllergies)
        {
            long returnCode = -1;
            SqlCommand objCommand = new SqlCommand();
            objCommand = Command.pGetPatientRegDetailCommand(patientID, pID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstPatient = new List<Patient>();
            lstPatientAddress = new List<PatientAddress>();
            lstPatientAllergies = new List<PatientAllergies>();

            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }


            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatient);

            }
            if (ds.Tables[1].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPatientAddress);
            }
            if (ds.Tables[2].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPatientAllergies);
            }

            return returnCode;
        }

        public long UpdateRegPatient(Patient patient, long LID)
        {

            long lResult = -1;
            int addressCount = patient.PatientAddress.Count;
            SqlCommand cmdInsertPatient = new SqlCommand();
            SqlCommand[] cmdInsertAddress = new SqlCommand[addressCount];
            AddressDetails_DAL address = new AddressDetails_DAL(globalContextDetails);
            long patientID = 0;
            long addressID = 0;
            int i;
            cmdInsertPatient = Command.pUpdatePatientRegDetailsCommand(patient.EMail, patient.URNO, patient.SEX, patient.OCCUPATION, patient.MartialStatus,
                                                    patient.Religion, patient.PersonalIdentification, patient.BloodGroup, patient.PlaceOfBirth, patient.RelationName, LID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdInsertPatient.Parameters.Add("@retCode", SqlDbType.Int);
            cmdInsertPatient.Parameters["@retCode"].Direction = ParameterDirection.ReturnValue;
            for (i = 0; i < addressCount; i++)
            {
                cmdInsertAddress[i] = Command.pUpdatePatientAddressCommand(patientID, patient.PatientAddress[i].AddressType, patient.PatientAddress[i].Add1,
                                    patient.PatientAddress[i].Add2, patient.PatientAddress[i].Add3, patient.PatientAddress[i].PostalCode, patient.PatientAddress[i].CountryID,
                                    patient.PatientAddress[i].City, patient.PatientAddress[i].StateID, patient.PatientAddress[i].MobileNumber, patient.PatientAddress[i].LandLineNumber,
                                    patient.CreatedBy, patient.PatientAddress[i].AddressID, patient.ModifiedBy, patient.PatientAddress[i].OtherCountryName, patient.PatientAddress[i].OtherStateName,
                                    patient.PatientAddress[i].CountryCode,
                                                     patient.PatientAddress[i].StateCode, patient.PatientAddress[i].CityCode, patient.PatientAddress[i].AddLevel1, patient.PatientAddress[i].AddLevel2, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                cmdInsertAddress[i].Parameters.Add("@retCode", SqlDbType.Int);
                cmdInsertAddress[i].Parameters["@retCode"].Direction = ParameterDirection.ReturnValue;

            }

            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteTransactionalNonQuery(cmdInsertPatient);
                        lResult = Convert.ToInt64(cmdInsertPatient.Parameters["@retCode"].Value);
                        if (lResult != -1)
                        {
                            patientID = lResult;
                            for (i = 0; i < addressCount; i++)
                            {
                                cmdInsertAddress[i].Parameters["@pPatientID"].Value = patientID;
                                dbEngine.ExecuteTransactionalNonQuery(cmdInsertAddress[i]);
                                lResult = Convert.ToInt64(cmdInsertPatient.Parameters["@retCode"].Value);
                                if (lResult == -1)
                                    tranScope.Dispose();
                            }
                        }
                    }
                    tranScope.Complete();
                }
                catch (Exception ex)
                {
                    CLogger.LogError("Error whil updating patient information. Query: " + cmdInsertPatient.CommandText, ex);
                    tranScope.Dispose();
                }

            }
            return lResult;
        }
        // changed dataset to datareader by Arivalagan.k
        public long GetURNType(out List<URNTypes> objURNTypes, out List<URNof> objURNof)
        {
            long returnCode = -1;
            int rsCount=0;
            SqlCommand objCommand = new SqlCommand();
            objURNTypes = new List<URNTypes>();
            objURNof = new List<URNof>();
            IDataReader dataReader = null;
            try
            {
                objCommand = Command.pGetURNTypeCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out objURNTypes);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out objURNof);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing GetURNType in Patient_DAL", excep);
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
        public long GetSpecies(int OrgID, out List<Species> objSpecies)
        {
            long returnCode = -1;
            SqlCommand objCommand = new SqlCommand();
            objSpecies = new List<Species>();
            objCommand = Command.pGetSpeciesCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out objSpecies);
                }
            }
            return returnCode;
        }

        public long SavePatientVisitForUpload(long PatientID, long visitID, int OrgID, int OrgAddressID, int VisitType, string PerformingOrgName,
                                                string PerformingOrgLocation, string DocumentTitle, DateTime docDate, string physicainName, out long PatientOldNotesID)
        {
            long returnCode = -1;

            SqlCommand cmd = Command.pInsertPatientVisitForUploadCommand(PatientID, visitID, OrgID, OrgAddressID,
                                                    VisitType, PerformingOrgName, DocumentTitle, docDate, physicainName, PerformingOrgLocation, out PatientOldNotesID, out returnCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@preturnStatus"].Value);
                    PatientOldNotesID = Convert.ToInt64(cmd.Parameters["@pPatientOldNotesID"].Value);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing UpdateReferingPhysician in Patient_DAL", excep);
            }
            return returnCode;
        }

        public long SavePatientOldNotesFilemapping(List<PatientOldNotesFileMapping> lblob)
        {
            long returnCode = -1;
            DataTable dtOldnotes = UDT_DAL.ConvertToPatientOldNotesFileMapping(lblob);

            SqlCommand cmd = Command.pInsertOldNotesFileMappingCommand(dtOldnotes, out returnCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@pReturnStatus"].Value);
                }

            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing UpdateReferingPhysician in Patient_DAL", excep);
            }
            return returnCode;
        }



        public long GetDoctorWiseReport(DateTime strBillFromDate, DateTime strBillToDate, int ReferingPhysicianID, long HospitalID, int clientID, int collectionCentreID, int InsuranceID, int OrgID, int flag, long deptID, out List<DailyReport> lstDoctorWiseReport, out List<DailyReport> lstDisplayName)
        {
            long returnCode = -1;

            System.Data.SqlClient.SqlCommand cmd;
            cmd = Command.pGetDoctorWiseReportCommand(strBillFromDate, strBillToDate, ReferingPhysicianID, HospitalID, clientID, collectionCentreID, InsuranceID, OrgID, flag, deptID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstDoctorWiseReport = new List<DailyReport>();
            lstDisplayName = new List<DailyReport>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }

            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDoctorWiseReport);

                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstDisplayName);
            }
            return returnCode;
        }




        public long GetAllDoctorReport(DateTime strBillFromDate, DateTime strBillToDate, int OrgID, int ReportFormatId, out List<DailyReport> lstAllDoctorWiseReport, out List<DailyReport> lstDisplayName)
        {
            long returnCode = -1;

            System.Data.SqlClient.SqlCommand cmd;
            cmd = Command.pGetAllDoctorReportCommand(strBillFromDate, strBillToDate, OrgID, ReportFormatId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstAllDoctorWiseReport = new List<DailyReport>();
            lstDisplayName = new List<DailyReport>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstAllDoctorWiseReport);
            }
            if (ds.Tables[1].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstDisplayName);
            }
            return returnCode;
        }














        public long SaveKnowledgeOfServices(long visitID, int OrgID, long LID, List<VisitKnowledgeMapping> lstVisitKnowledgeMapping)
        {
            long returnCode = -1;
            DataTable dtVisitKnowledgeMapping = UDT_DAL.ConvertToVisitKnowledgeMapping(lstVisitKnowledgeMapping);
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pSaveKnowledgeOfServicesCommand(visitID, OrgID, LID, dtVisitKnowledgeMapping, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteTransactionalNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);

            }



            return returnCode;
        }


        public long SaveHistoryPKG(
            List<PatientHistory> lstPatientHisPKG,
            List<PatientHistoryAttribute> lstPatientHisPKGAttributes,
            List<DrugDetails> drgList,
           List<PatientPastVaccinationHistory> lstVaccHis,
            List<GPALDetails> lstGPALDetails, byte G, byte P, byte L, byte A, string GPLAOthers,
            List<PatientComplaint> lstPatientComplaint,
            List<PatientComplaintAttribute> lstPatientComplaintAttribute,
            List<SurgicalDetail> lstSurgicalDetail,
            long createdBy, long VisitID, long PatientID)
        {
            long returnCode = -1;

            DataTable dtPatientComplaint = UDT_DAL.ConvertToPatientComplaintHealth(lstPatientComplaint);
            DataTable dtPatientComplaintAttribute = UDT_DAL.ConvertToPatientComplaintAttribute(lstPatientComplaintAttribute);
            DataTable dtSurgicalDetail = UDT_DAL.ConvertToSurgicalDetail(lstSurgicalDetail);
            DataTable drugDT = UDT_DAL.ConvertToPrescriptionType(drgList);
            DataTable dtHisPKGType = UDT_DAL.ConvertToHistoryPKGType(lstPatientHisPKG);
            DataTable dtHisPHGAttributes = UDT_DAL.ConvertToHistoryPKGAttribute(lstPatientHisPKGAttributes);
            DataTable dtVaccHis = UDT_DAL.ConvertToANCVaccincation(lstVaccHis);
            DataTable dtGPALDetails = UDT_DAL.ConvertToANCGPALDetails(lstGPALDetails);

            SqlCommand cmdComplaintPKG = new SqlCommand();
            SqlCommand cmdHistoryPKG = new SqlCommand();

            cmdComplaintPKG = Command.pInsertComplientPKGCommand(dtPatientComplaint, dtPatientComplaintAttribute, dtSurgicalDetail, createdBy, VisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            cmdComplaintPKG.Parameters.Add("@Return", SqlDbType.Int);
            cmdComplaintPKG.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;


            cmdHistoryPKG = Command.pInsertHistoryPKGCommand(dtHisPKGType, dtHisPHGAttributes, drugDT, dtVaccHis, dtGPALDetails, G, P, L, A, GPLAOthers, VisitID, PatientID, createdBy, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdHistoryPKG.Parameters.Add("@Return", SqlDbType.Int);
            cmdHistoryPKG.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(false))
                    {
                        dbEngine.ExecuteTransactionalNonQuery(cmdComplaintPKG);
                        returnCode = Convert.ToInt64(cmdComplaintPKG.Parameters["@Return"].Value);

                        if (returnCode == 0)
                        {
                            dbEngine.ExecuteTransactionalNonQuery(cmdHistoryPKG);
                            returnCode = Convert.ToInt64(cmdHistoryPKG.Parameters["@Return"].Value);
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
                }
                catch (Exception ex)
                {
                    CLogger.LogError("Error in DAL SaveHistoryPKG", ex);
                }

                return returnCode;

            }
        }


        public long GetPatientHistoryPackage(long pVisitId, out List<PatientHistoryAttribute> lstPatHisAttribute, out List<DrugDetails> lstPatientPrescription, out List<GPALDetails> lstGPALDetails, out List<ANCPatientDetails> lstANCPatientDetails, out List<PatientPastVaccinationHistory> lstPPVH, out List<PatientComplaintAttribute> lstPCA, out List<SurgicalDetail> lstSurgicalDetails)
        {
            long returnCode = -1;
            lstPatHisAttribute = new List<PatientHistoryAttribute>();
            lstPatientPrescription = new List<DrugDetails>();
            lstGPALDetails = new List<GPALDetails>();
            lstANCPatientDetails = new List<ANCPatientDetails>();
            lstPPVH = new List<PatientPastVaccinationHistory>();
            lstPCA = new List<PatientComplaintAttribute>();
            lstSurgicalDetails = new List<SurgicalDetail>();

            try
            {

                SqlCommand cmd = Command.pGetPatientHistoryPackageCommand(pVisitId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatHisAttribute);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPatientPrescription);
                }

                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstGPALDetails);
                }
                if (ds.Tables[3].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstANCPatientDetails);
                }
                if (ds.Tables[4].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[4], out lstPPVH);
                }
                if (ds.Tables[5].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[5], out lstPCA);
                }
                if (ds.Tables[6].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[6], out lstSurgicalDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetPatientHistoryPackage", ex);
            }
            return returnCode;
        }
        public long GetLabelPrintingDetails(long pVisitId, int OrgID, out string pOrgAddress, out string pDOB,
                                           out string pURN
                                           , out string pAge, out string pSEX, out string pPhysicianName)
        {
            long returnCode = -1;
            pOrgAddress = string.Empty;
            pDOB = string.Empty;
            pURN = string.Empty;
            pAge = string.Empty;
            pSEX = string.Empty;
            pPhysicianName = string.Empty;

            try
            {

                SqlCommand cmd = Command.pGetLabelPrintDetailsCommand(pVisitId, OrgID);
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    pOrgAddress = Convert.ToString(cmd.Parameters["@pOrgAddress"].Value);
                    pDOB = Convert.ToString(cmd.Parameters["@pDOB"].Value);
                    pURN = Convert.ToString(cmd.Parameters["@pURN"].Value);
                    pAge = Convert.ToString(cmd.Parameters["@pAge"].Value);

                    pSEX = Convert.ToString(cmd.Parameters["@pSex"].Value);

                    pPhysicianName = Convert.ToString(cmd.Parameters["@pPhysicianName"].Value);
                    returnCode = 0;
                }


            }
            catch (Exception ex)
            {
                returnCode = -1;
                CLogger.LogError("Error in DAL GetPatientHistoryPackage", ex);
            }
            return returnCode;
        }
        public long SaveInvestigationInstrument(InvInstrumentMaster InvInsMaster, out long pInstrumentID)
        {
            long returnCode = -1;
            SqlCommand cmdInsertInvInstrumentMaster = new SqlCommand();
            cmdInsertInvInstrumentMaster = Command.pInsertInvInstrumentCommand(InvInsMaster.OrgID, InvInsMaster.InstrumentName, InvInsMaster.QCData, InvInsMaster.CreatedBy, out pInstrumentID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdInsertInvInstrumentMaster.Parameters.Add("@Return", SqlDbType.Int);
            cmdInsertInvInstrumentMaster.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;


            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(cmdInsertInvInstrumentMaster);
                    returnCode = Convert.ToInt64(cmdInsertInvInstrumentMaster.Parameters["@Return"].Value);
                    pInstrumentID = Convert.ToInt32(cmdInsertInvInstrumentMaster.Parameters["@pInstrumentID"].Value);
                }

            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing SaveInvestigationInstrument DAL", excep);
            }
            return returnCode;
        }
        public long GetInvestigationInstrument(int OrgID, string instrumentName, string Status, out List<InvInstrumentMaster> lstInvInstrumentMaster)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetInvInstrumentCommand(OrgID, instrumentName, Status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstInvInstrumentMaster = new List<InvInstrumentMaster>();
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvInstrumentMaster);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing GetInvestigationInstrument in Patient_DAL", excep);
            }
            return returnCode;
        }
        public long UpdateInvestigationInstrument(InvInstrumentMaster objInvInstrumentMaster)
        {
            long returnCode = -1;
            SqlCommand cmdUpdateInvInstrumentMaster = new SqlCommand();
            cmdUpdateInvInstrumentMaster = Command.pUpdateInvInstrumentCommand(objInvInstrumentMaster.InstrumentID,
                                                objInvInstrumentMaster.OrgID, objInvInstrumentMaster.Status, objInvInstrumentMaster.InstrumentName, objInvInstrumentMaster.QCData, objInvInstrumentMaster.ModifiedBy, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdUpdateInvInstrumentMaster.Parameters.Add("@Return", SqlDbType.Int);
            cmdUpdateInvInstrumentMaster.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(cmdUpdateInvInstrumentMaster);
                    returnCode = Convert.ToInt64(cmdUpdateInvInstrumentMaster.Parameters["@Return"].Value);
                }

            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing UpdateInvestigationInstrument in Patient_DAL", excep);
            }
            return returnCode;
        }
        public long SaveInvestigationKit(InvKitMaster InvKitMaster, out long pKitID)
        {
            long returnCode = -1;
            SqlCommand cmdInsertInvKitMaster = new SqlCommand();
            cmdInsertInvKitMaster = Command.pInsertInvKitCommand(InvKitMaster.OrgID, InvKitMaster.KitName, InvKitMaster.CreatedBy, out pKitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdInsertInvKitMaster.Parameters.Add("@Return", SqlDbType.Int);
            cmdInsertInvKitMaster.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;


            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(cmdInsertInvKitMaster);
                    returnCode = Convert.ToInt64(cmdInsertInvKitMaster.Parameters["@Return"].Value);
                    pKitID = Convert.ToInt32(cmdInsertInvKitMaster.Parameters["@pKitID"].Value);
                }

            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing SaveInvestigationKit DAL", excep);
            }
            return returnCode;
        }
        public long SaveInvestigationDrugBrand(InvestigationDrugBrand InvDrugBrand, out long DrugID)
        {
            long returnCode = -1;
            SqlCommand cmdInvDrugBrand = new SqlCommand();
            cmdInvDrugBrand = Command.pInsertDrugBrandCommand(InvDrugBrand.OrgID, InvDrugBrand.BrandName,out DrugID, InvDrugBrand.Code,InvDrugBrand.FMID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(cmdInvDrugBrand);
                    returnCode = Convert.ToInt64(cmdInvDrugBrand.Parameters["@DrugID"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing SaveInvestigationDrugBrand DAL", ex);
            }
            return returnCode;
        }
        public long GetInvestigationKit(int OrgID, string kitName, string Status, out List<InvKitMaster> lstInvKitMaster)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetInvKitCommand(OrgID, kitName, Status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstInvKitMaster = new List<InvKitMaster>();
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvKitMaster);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing GetInvestigationKit in Patient_DAL", excep);
            }
            return returnCode;
        }

        public long SearchInvestigationDrugBrand(int OrgID, string brandName, out List<InvestigationDrugBrand> lstInvDrugBrand)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pSearchDrugBrandCommand(OrgID, brandName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstInvDrugBrand = new List<InvestigationDrugBrand>();
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvDrugBrand);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing SearchInvestigationDrugBrand", excep);
            }
            return returnCode;
        }
        public long GetInvestigationDrugBrand(int OrgID, string brandName, out List<InvestigationDrugBrand> lstInvDrugBrand)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetDrugBrandCommand(OrgID, brandName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstInvDrugBrand = new List<InvestigationDrugBrand>();
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvDrugBrand);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing GetInvestigationDrugBrands", excep);
            }
            return returnCode;
        }
        public long UpdateInvestigationKit(InvKitMaster objInvKitMaster)
        {
            long returnCode = -1;
            SqlCommand cmdUpdateInvKitMaster = new SqlCommand();
            cmdUpdateInvKitMaster = Command.pUpdateInvKitCommand(objInvKitMaster.KitID,
                                                objInvKitMaster.OrgID, objInvKitMaster.Status, objInvKitMaster.KitName, objInvKitMaster.ModifiedBy, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdUpdateInvKitMaster.Parameters.Add("@Return", SqlDbType.Int);
            cmdUpdateInvKitMaster.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(cmdUpdateInvKitMaster);
                    returnCode = Convert.ToInt64(cmdUpdateInvKitMaster.Parameters["@Return"].Value);
                }

            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing UpdateInvestigationKit in Patient_DAL", excep);
            }
            return returnCode;
        }
        public long UpdateInvestigationDrugBrand(InvestigationDrugBrand invDrugBrand)
        {
            long returnCode = -1;
            SqlCommand cmdUpdateInvDrugBrand = new SqlCommand();
            cmdUpdateInvDrugBrand = Command.pUpdateInvDrugBrandCommand(invDrugBrand.OrgID, invDrugBrand.DrugID, invDrugBrand.BrandName, invDrugBrand.ModifiedBy, invDrugBrand.Code,invDrugBrand.FMID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdUpdateInvDrugBrand.Parameters.Add("@Return", SqlDbType.Int);
            cmdUpdateInvDrugBrand.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(cmdUpdateInvDrugBrand);
                    returnCode = Convert.ToInt64(cmdUpdateInvDrugBrand.Parameters["@Return"].Value);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing UpdateInvestigation in Patient_DAL", excep);
            }
            return returnCode;
        }
        public long SaveInvestigationMethod(InvestigationMethod InvMethod, out long pMethodID)
        {
            long returnCode = -1;
            SqlCommand cmdInsertInvMethod = new SqlCommand();
            cmdInsertInvMethod = Command.pInsertInvMethodCommand(InvMethod.OrgID, InvMethod.MethodName, InvMethod.CreatedBy, out pMethodID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdInsertInvMethod.Parameters.Add("@Return", SqlDbType.Int);
            cmdInsertInvMethod.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;


            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(cmdInsertInvMethod);
                    returnCode = Convert.ToInt64(cmdInsertInvMethod.Parameters["@Return"].Value);
                    pMethodID = Convert.ToInt32(cmdInsertInvMethod.Parameters["@pMethodID"].Value);
                }

            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing SaveInvestigationMethod DAL", excep);
            }
            return returnCode;
        }
        // changed dataset to datareader by Arivalagan.k
        public long GetInvestigationMethod(int OrgID, string methodName, string Status, out List<InvestigationMethod> lstInvMethod)
        {
            long returnCode = -1;
            lstInvMethod = new List<InvestigationMethod>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetInvMethodCommand(OrgID, methodName, Status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvMethod);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing GetInvestigationMethod in Patient_DAL", excep);
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
        public long UpdateInvestigationMethod(InvestigationMethod objInvMethod)
        {
            long returnCode = -1;
            SqlCommand cmdUpdateInvMethod = new SqlCommand();
            cmdUpdateInvMethod = Command.pUpdateInvMethodCommand(objInvMethod.MethodID,
                                                objInvMethod.OrgID, objInvMethod.Status, objInvMethod.MethodName, objInvMethod.ModifiedBy, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdUpdateInvMethod.Parameters.Add("@Return", SqlDbType.Int);
            cmdUpdateInvMethod.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(cmdUpdateInvMethod);
                    returnCode = Convert.ToInt64(cmdUpdateInvMethod.Parameters["@Return"].Value);
                }


            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing UpdateInvestigationMethod in Patient_DAL", excep);
            }
            return returnCode;
        }

        public long SaveInvestigationPrinciple(InvPrincipleMaster InvPrincipleMaster, out long pPrincipleID)
        {
            long returnCode = -1;
            SqlCommand cmdInsertInvPrincipleMaster = new SqlCommand();
            cmdInsertInvPrincipleMaster = Command.pInsertInvPrincipleCommand(InvPrincipleMaster.OrgID, InvPrincipleMaster.PrincipleName, InvPrincipleMaster.CreatedBy, out pPrincipleID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdInsertInvPrincipleMaster.Parameters.Add("@Return", SqlDbType.Int);
            cmdInsertInvPrincipleMaster.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;


            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(cmdInsertInvPrincipleMaster);
                    returnCode = Convert.ToInt64(cmdInsertInvPrincipleMaster.Parameters["@Return"].Value);
                    pPrincipleID = Convert.ToInt32(cmdInsertInvPrincipleMaster.Parameters["@pPrincipleID"].Value);
                }

            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing SaveInvestigationPrinciple DAL", excep);
            }
            return returnCode;
        }
        // changed dataset to datareader by Arivalagan.k
        public long GetInvestigationPrinciple(int OrgID, string principleName, string Status, out List<InvPrincipleMaster> lstInvPrincipleMaster)
        {
            long returnCode = -1;
            lstInvPrincipleMaster = new List<InvPrincipleMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetInvPrincipleCommand(OrgID, principleName, Status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvPrincipleMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing GetInvestigationPrinciple in Patient_DAL", excep);
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



        public long UpdateInvestigationPrinciple(InvPrincipleMaster objInvPrincipleMaster)
        {
            long returnCode = -1;
            SqlCommand cmdUpdateInvPrincipleMaster = new SqlCommand();
            cmdUpdateInvPrincipleMaster = Command.pUpdateInvPrincipleCommand(objInvPrincipleMaster.PrincipleID,
                                                objInvPrincipleMaster.OrgID, objInvPrincipleMaster.Status, objInvPrincipleMaster.PrincipleName, objInvPrincipleMaster.ModifiedBy, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdUpdateInvPrincipleMaster.Parameters.Add("@Return", SqlDbType.Int);
            cmdUpdateInvPrincipleMaster.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(cmdUpdateInvPrincipleMaster);
                    returnCode = Convert.ToInt64(cmdUpdateInvPrincipleMaster.Parameters["@Return"].Value);
                }

            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing UpdateInvestigationPrinciple in Patient_DAL", excep);
            }
            return returnCode;
        }
        public long GetPatientRecommendationDetails(int OrgID, long PatientId, long PatientVisitId,
                        out List<PatientRecommendationDtls> lstPatientRecommendation,
                        out List<PhysicianSchedule> schedules,
                        out List<Patient> lstPatient)
        {
            long result = -1;
            lstPatientRecommendation = new List<PatientRecommendationDtls>();
            schedules = new List<PhysicianSchedule>();
            lstPatient = new List<Patient>();

            SqlCommand cmd = Command.pGetPatientRecommendationCommand(OrgID, PatientVisitId, PatientId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        result = Utilities.ConvertTo(ds.Tables[0], out lstPatientRecommendation);
                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        result = Utilities.ConvertTo(ds.Tables[1], out schedules);
                    }
                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        result = Utilities.ConvertTo(ds.Tables[2], out lstPatient);
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetPatientRecommendation ", e);
            }
            return result;
        }
        public long UpdatePatientRecommendationDetails(PatientRecommendation precommendation, DataTable dtrecommendation)
        {
            long returnCode = -1;

            SqlCommand cmd = Command.pUpdatePatientRecommendationdetailsCommand(dtrecommendation, precommendation.PatientID, precommendation.PatientVisitId, precommendation.OrgID, precommendation.OrgAddressID, precommendation.CreatedBy, precommendation.Status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEng = new DBEngine())
                {
                    returnCode = dbEng.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While Insert Investigation values in UpdatePatientRecommendation", ex);
            }
            return returnCode;
        }

        public long UpdatePatientRecommendation(PatientRecommendation precommendation)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pUpdatePatientRecommendationCommand(precommendation.PatientID, precommendation.PatientVisitId, precommendation.OrgID, precommendation.OrgAddressID, precommendation.CreatedBy, precommendation.Status, precommendation.Remarks, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEng = new DBEngine())
                {
                    returnCode = dbEng.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error While Insert Investigation values in UpdatePatientRecommendation", ex);
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

        public long GetPatientRecommendationDetails(int orgID, out List<PatientVisit> lstPatientVisit)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetRecommendationDetailsCommand(orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

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

        public long GetPayerType(int orgID, out List<PayerMaster> lstPayerType)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetPayerTypeCommand(orgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstPayerType = new List<PayerMaster>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPayerType);
            }
            return returnCode;
        }
        public long GetPCClient(int orgID, long refOrgID, int refPhyID, int payerID, long TpaOrClientID, string Type, out List<InvClientMaster> lstInvClientMaster)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetPCClientCommand(orgID, refOrgID, refPhyID, payerID, TpaOrClientID, Type, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstInvClientMaster = new List<InvClientMaster>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstInvClientMaster);
            }
            return returnCode;
        }
        public long GetPCPayer(int orgID, long refOrgID, int refPhyID, out List<PayerMaster> lstPayerMaster)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetPCPayerCommand(orgID, refOrgID, refPhyID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstPayerMaster = new List<PayerMaster>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPayerMaster);
            }
            return returnCode;
        }

        public long GetPhysicianByType(string FilterText, int OrgID, string pType, out List<Physician> lstPhysician)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetPhysicianByTypeCommand(FilterText, OrgID, pType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
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


        public long GetPrimaryConsultant(long pVisitID, int pType, out List<PrimaryConsultant> lstPrimaryConsultant)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetPrimaryConsultantCommand(pVisitID, pType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstPrimaryConsultant = new List<PrimaryConsultant>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPrimaryConsultant);
            }
            return returnCode;
        }
        public long SaveReferingPhysician(ReferingPhysician refPhy, out int pRefPhyID)
        {
            long result = -1;
            pRefPhyID = 0;
            int LoginID = 0;
            try
            {
                List<PhysicianOrgMapping> POM = new List<PhysicianOrgMapping>();

                result = SaveReferingPhysician(refPhy, out pRefPhyID);


            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing SaveReferingPhysician DAL", excep);
            }
            return result;
        }

        public long SaveOrderedPhysiotherapy(long visitID, int ILocationID, int OrgID, long LID, string pType, List<OrderedPhysiotherapy> lstOrderedPhysiotherapy, out int Physiocount)
        {

            DataTable dtOrderphy = UDT_DAL.ConvertToOrderedPhysiotherapy(lstOrderedPhysiotherapy);
            long returnCode = -1;

            SqlCommand cmd = new SqlCommand();
            cmd = Command.pSaveOrderedPhysiotherapyCommand(visitID, ILocationID, OrgID, LID, pType, dtOrderphy, out Physiocount, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteTransactionalNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                Physiocount = Convert.ToInt32(cmd.Parameters["@Physiocount"].Value);

            }

            return returnCode;
        }


        public long BindPatientRegDetail(long pPatientID, long pVisitID, string pType, out List<Patient> lstPatient)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetOPAndIPRegDetailCommand(pPatientID, pVisitID, pType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
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



        public long BindOrderedPhysiotherapy(long pPatientID, long pVisitID, long ProcID, out List<OrderedPhysiotherapy> lstOrderedPhysiotherapy)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pOrderedPhysiotherapyCommand(pPatientID, pVisitID, ProcID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstOrderedPhysiotherapy = new List<OrderedPhysiotherapy>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstOrderedPhysiotherapy);
            }
            return returnCode;
        }


        public long GetClinicalSotting(long pPatientID, long pVisitID, out List<IPTreatmentPlan> lstIPTreatmentPlan, out List<BackgroundProblem> lstBackgroundProblem)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetIPTreatmentPlanNameCommand(pPatientID, pVisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstIPTreatmentPlan = new List<IPTreatmentPlan>();
            lstBackgroundProblem = new List<BackgroundProblem>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstIPTreatmentPlan);
                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstBackgroundProblem);
            }
            return returnCode;
        }

        public long GetPatientVisitType(long pPatientID, long pVisitID, out List<PatientVisit> lstPatientVisit)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetPatientVisitTypeCommand(pPatientID, pVisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstPatientVisit = new List<PatientVisit>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientVisit);
            }
            return returnCode;
        }






        public long SavePhysioDetails(long PatientID, long visitID, int ILocationID, int OrgID, long LID, string pType, List<PatientPhysioDetails> lstPatientPhysioDetails, PatientPhysioDetails objPPD, List<PhysioCompliant> lstPhysioCompliant, long PhysicanID)
        {

            DataTable dtPhysioComplaint = UDT_DAL.ConvertToPhysioCompliant(lstPhysioCompliant);
            DataTable dtPatientPhysioDetails = UDT_DAL.ConvertToPatientPhysioDetails(lstPatientPhysioDetails);
            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pSavePhysioDetailsCommand(PatientID, visitID,
                                                 ILocationID, OrgID, LID, objPPD.NextReview, dtPatientPhysioDetails, dtPhysioComplaint, PhysicanID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteTransactionalNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);

            }

            return returnCode;
        }


        public long GetPatientPhysioDetail(long pPatientID, long pVisitID, string type, out List<PatientPhysioDetails> lsPatientPhysioDetails)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetPatientPhysioDetailCommand(pPatientID, pVisitID, type, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lsPatientPhysioDetails = new List<PatientPhysioDetails>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lsPatientPhysioDetails);
            }
            return returnCode;
        }

        public long GetPatientPhysioDetailByProcID(long PatientPhysioDtlID, out List<PatientPhysioDetails> lsPatientPhysioDetails, out List<PhysioCompliant> lstPhysioCompliant, out List<OrderedPhysiotherapy> lstOrderedPhysiotherapy)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetPatientPhysioDetailByProcIDCommand(PatientPhysioDtlID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lsPatientPhysioDetails = new List<PatientPhysioDetails>();
            lstPhysioCompliant = new List<PhysioCompliant>();
            lstOrderedPhysiotherapy = new List<OrderedPhysiotherapy>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lsPatientPhysioDetails);
                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPhysioCompliant);
                returnCode = Utilities.ConvertTo(ds.Tables[2], out lstOrderedPhysiotherapy);
            }
            return returnCode;
        }

        public long UpdatePhysioDetails(long PatientID, long visitID, int ILocationID, int OrgID, long LID, string pType, List<PatientPhysioDetails> lstPatientPhysioDetails, PatientPhysioDetails objPPD, List<PhysioCompliant> lstPhysioCompliant, long PhysicanID)
        {

            DataTable dtPhysioComplaint = UDT_DAL.ConvertToPhysioCompliant(lstPhysioCompliant);
            DataTable dtPatientPhysioDetails = UDT_DAL.ConvertToPatientPhysioDetails(lstPatientPhysioDetails);
            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pUpdatePhysioDetailsCommand(PatientID, visitID,
                                                 ILocationID, OrgID, LID, objPPD.NextReview, dtPatientPhysioDetails, dtPhysioComplaint, PhysicanID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteTransactionalNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);

            }

            return returnCode;
        }


        public long SearchPendingPhysio(int OrgID, string PatientNo, string PName, string Type, string Procedure, string EmpNo, string FromDt, string ToDt, out List<Patient> lstPatient)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pSearchPendingPhysioCommand(OrgID, PatientNo, PName, Type, Procedure, EmpNo, FromDt, ToDt, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
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
        public long GetProcedureStatus(int OrgID, long PatientID, long ProcedureID, out List<Patient> lstPatient)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetProcedureStatusCommand(OrgID, PatientID, ProcedureID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
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


        public long CheckVistDetails(int OrgID, long PatientId, out long VisitID)
        {
            long returncode = -1;

            SqlCommand cmd = Command.pCheckVistDetailsCommand(OrgID, PatientId, out VisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();

            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                    VisitID = Convert.ToInt32(cmd.Parameters["@pVisitID"].Value);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in CheckVistDetails patientbl", ex);
            }

            return returncode;
        }


        public long GetPatientPhysioByProcID(long pProcID, long pPatientID, long pVisitID, string pType, out decimal Quantity, out int CurrentNoOfSitting, out int AdvisedNoOfSitting)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pGetPatientPhysioByProcIDCommand(pProcID, pPatientID, pVisitID, pType, out Quantity, out CurrentNoOfSitting, out AdvisedNoOfSitting, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                Quantity = Convert.ToDecimal(cmd.Parameters["@pQuantity"].Value);
                CurrentNoOfSitting = Convert.ToInt32(cmd.Parameters["@pCurrentNoOfSitting"].Value);
                AdvisedNoOfSitting = Convert.ToInt32(cmd.Parameters["@pAdvisedNoOfSitting"].Value);
            }

            return returnCode;
        }

        // changed dataset to datareader by Arivalagan.k
        public long GetComplaint(string complaintName, out List<Complaint> complaints)
        {
            long returnCode = -1;
            complaints = new List<Complaint>();
            SqlCommand cmd = new SqlCommand();
            IDataReader dataReader = null;
            try
            {
                cmd = Command.pGetComplaintByNameIDCommand(complaintName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dBEngine = new DBEngine())
                {
                    dataReader = dBEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out complaints);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetComplaint Patient_DAL", e);
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

        public long GetPreviousPhysioVisit(long pPatientID, out List<PatientPhysioDetails> lsPatientPhysioDetails)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetPreviousPhysioVisitCommand(pPatientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lsPatientPhysioDetails = new List<PatientPhysioDetails>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lsPatientPhysioDetails);
            }
            return returnCode;
        }


        public long GetPreviousPhysioVisitDt(long pPatientID, string VisitDate, out List<PatientPhysioDetails> lsPatientPhysioDetails, out List<PhysioCompliant> lstPhysioCompliant)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetPreviousPhysioVisitDtCommand(pPatientID, VisitDate, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lsPatientPhysioDetails = new List<PatientPhysioDetails>();
            lstPhysioCompliant = new List<PhysioCompliant>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lsPatientPhysioDetails);
                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPhysioCompliant);
            }


            return returnCode;
        }

        public long GetPhysioName(int OrgID, out List<PatientPhysioDetails> lsPatientPhysioDetails)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetPhysioNameCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lsPatientPhysioDetails = new List<PatientPhysioDetails>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lsPatientPhysioDetails);
            }
            return returnCode;
        }



        public long GetPhysioReport(string ProcedureName, DateTime FromDate, DateTime Todate, int OrgID, out List<PatientPhysioDetails> lsPatientPhysioDetails)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetPhysioReportCommand(ProcedureName, FromDate, Todate, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lsPatientPhysioDetails = new List<PatientPhysioDetails>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lsPatientPhysioDetails);
            }
            return returnCode;
        }


        public long GetComplaintName(int OrgID, out List<PatientPhysioDetails> lsPatientPhysioDetails)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetPhysioCompliantNameCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lsPatientPhysioDetails = new List<PatientPhysioDetails>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lsPatientPhysioDetails);
            }
            return returnCode;
        }

        public long GetPhysioCompliantReport(string CName, DateTime FromDate, DateTime Todate, int OrgID, out List<PatientPhysioDetails> lsPatientPhysioDetails)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetPhysioCompliantReportCommand(CName, FromDate, Todate, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lsPatientPhysioDetails = new List<PatientPhysioDetails>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lsPatientPhysioDetails);
            }
            return returnCode;
        }

        public long GetPhysioCompliantPatient(int RptType, string CName, DateTime FromDate, DateTime Todate, int OrgID, out List<Patient> lsPatient)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetPhysioCompliantPatientCommand(RptType, CName, FromDate, Todate, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lsPatient = new List<Patient>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lsPatient);
            }
            return returnCode;
        }


        public long GetICDCODE(string ICDCode, out List<ICDCodes> lstICDCodes)
        {
            long returnCode = -1;
            using (DBEngine dBEngine = new DBEngine())
            {
                DataSet ds = new DataSet();
                lstICDCodes = new List<ICDCodes>();
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetICDCODECommand(ICDCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                returnCode = dBEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstICDCodes);
                }
                else
                {
                    returnCode = -1;
                }
            }
            return returnCode;
        }


        public long GetICDCODEDESC(string ICDCode, out List<ICDCodes> lstICDCodes)
        {
            long returnCode = -1;
            using (DBEngine dBEngine = new DBEngine())
            {
                DataSet ds = new DataSet();
                lstICDCodes = new List<ICDCodes>();
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetICDCODEDESCCommand(ICDCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                returnCode = dBEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstICDCodes);
            }
            return returnCode;
        }


        public long SaveReferingPhysician(ReferingPhysician refPhy, List<AddressDetails> lstRefPhyAddresDetails, List<PhysicianOrgMapping> POM, int LoginID, out int pRefPhyID, out  List<ReferingPhysician> lstPhysician, out long PhysicianRoleID)
        {

            long result = -1;
            PhysicianRoleID = 0;
            DataTable DtHptl = UDT_DAL.ConvertToPhysicianOrgMappingUDT(POM);
            DataTable DTRefPhyAddDtls = UDT_DAL.ConvertToUDTAddressDetails(lstRefPhyAddresDetails);
            lstPhysician = new List<ReferingPhysician>();
            SqlCommand cmdInsertReferingPhysician = new SqlCommand();
            cmdInsertReferingPhysician = Command.pInsertReferingPhysicianCommand(refPhy.OrgID, refPhy.Salutation, refPhy.PhysicianName,
                refPhy.PhysicianCode, refPhy.Qualification, refPhy.OrganizationName, refPhy.Gender, refPhy.IsClient, refPhy.IsActive, refPhy.CreatedBy,refPhy.RefFeeCategoryid,
                DtHptl, LoginID, out pRefPhyID, DTRefPhyAddDtls, refPhy.DOB, refPhy.Age, refPhy.Category, refPhy.Rate, UDT_DAL.ConvertToUDT_Context(globalContextDetails),
                out PhysicianRoleID, refPhy.DiscountPeriod, refPhy.DiscountLimit, refPhy.DiscountValidFrom, refPhy.DiscountValidTo);
            cmdInsertReferingPhysician.Parameters.Add("@Return", SqlDbType.Int);
            cmdInsertReferingPhysician.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    DataSet ds = new DataSet();
                    result = dbEngine.ExecuteDataSet(cmdInsertReferingPhysician, out ds);

                    pRefPhyID = Convert.ToInt32(cmdInsertReferingPhysician.Parameters["@pRefPhyID"].Value);
                    PhysicianRoleID = Convert.ToInt64(cmdInsertReferingPhysician.Parameters["@RoleID"].Value);
                    if (ds.Tables.Count > 0)
                        result = Utilities.ConvertTo(ds.Tables[0], out lstPhysician);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing SaveReferingPhysician DAL", excep);
            }
            return result;
        }


        public long SaveSampleRegistrationDetails(Patient patient, PatientAddress pAddress, PatientVisit labVisit,
                                           long OrgAddressID, out long pVisitID,
                                           out long pPatientID, int pAgeValue, string pAgeUnits, int PayerTypeID, string PayerName,

            List<VisitClientMapping> lstVisitClientMapping)
        {
            long result = -1;
            pVisitID = -1;
            pPatientID = -1;
            long addressID = -1;
            long patientID = -1;
            SqlCommand cmdInsertSampleRegistrationDetails = new SqlCommand();
            SqlCommand cmdInsertAddress = new SqlCommand();
            cmdInsertSampleRegistrationDetails = Command.pInsertSampleRegistrationDetailsCommand(patient.OrgID,
                                    patient.Name, patient.TITLECode,
                                    patient.Age, patient.SEX, patient.CreatedBy,
                                    labVisit.PriorityID,
                                    labVisit.ReferingPhysicianID,
                                    labVisit.ReferingPhysicianName,
                                    labVisit.HospitalID, labVisit.HospitalName,
                                    OrgAddressID, labVisit.CollectionCentreID,
                                    labVisit.CollectionCentreName,
                                    patient.URNO,
                                    patient.URNofId,
                                    patient.URNTypeId,
                                    patient.Race,
                                    patient.Nationality,
                                    out pVisitID,
                                    out patientID,
                                    pAgeValue,
                                    pAgeUnits,
                    patient.DOB, PayerTypeID, PayerName, patient.PatientNumber, labVisit.ExternalVisitID, labVisit.WardNo, labVisit.VisitType,
                    labVisit.ReferVisitID, patient.TPAAttributes, patient.TypeName, patient.PreviousKnownName, patient.AliasName, patient.RelationName,
                    patient.RelationTypeId, patient.NotifyType, patient.EMail,labVisit.IsDueBill, UDT_DAL.ConvertToUDT_Context(globalContextDetails), UDT_DAL.ConvertToVisitClientMapping(lstVisitClientMapping));
            cmdInsertSampleRegistrationDetails.Parameters.Add("@Return", SqlDbType.Int);
            cmdInsertSampleRegistrationDetails.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            cmdInsertAddress = Command.pInsertPatientAddressCommand(patientID, pAddress.AddressType, pAddress.Add1,
                                    pAddress.Add2, pAddress.Add3, pAddress.PostalCode, pAddress.CountryID,
                                    pAddress.City, pAddress.StateID, pAddress.MobileNumber, pAddress.LandLineNumber,
                                                patient.CreatedBy, pAddress.OtherCountryName, pAddress.OtherStateName,
 pAddress.CountryCode, pAddress.StateCode, pAddress.CityCode, pAddress.AddLevel1, pAddress.AddLevel2, out addressID,
 UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteNonQuery(cmdInsertSampleRegistrationDetails);
                        pVisitID = Convert.ToInt64(cmdInsertSampleRegistrationDetails.Parameters["@pVisitID"].Value);
                        result = Convert.ToInt64(cmdInsertSampleRegistrationDetails.Parameters["@Return"].Value);
                        if (result == 0)
                        {
                            pPatientID = Convert.ToInt64(cmdInsertSampleRegistrationDetails.Parameters["@pPatientID"].Value);
                            patientID = Convert.ToInt64(cmdInsertSampleRegistrationDetails.Parameters["@pPatientID"].Value);
                            pAddress.PatientID = patientID;
                            cmdInsertAddress.Parameters["@pPatientID"].Value = patientID;
                            dbEngine.ExecuteTransactionalNonQuery(cmdInsertAddress);

                        }
                    }
                    tranScope.Complete();
                }
                catch (Exception excep)
                {
                    CLogger.LogError("Error while executing SaveSampleRegistrationDetails DAL", excep);
                    tranScope.Dispose();
                }
                return result;
            }
        }

        public long GetIsCredit(int orgID, long refOrgID, int refPhyID, int clientID, out int isCredit)
        {
            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pGetIsCreditCommand(orgID, refOrgID, refPhyID, clientID, out isCredit, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    isCredit = Convert.ToInt32(cmd.Parameters["@pIsCredit"].Value);
                    returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing GetIsCredit DAL", excep);
            }
            return returnCode;
        }
        public long GetMappedOrganisation(int OrgID, long PhysicianID, out List<LabReferenceOrg> lstLabRefOrg)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.PgetMappingOrganisationCommand(PhysicianID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstLabRefOrg = new List<LabReferenceOrg>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstLabRefOrg);
            }
            return returnCode;
        }
        // changed dataset to datareader by Arivalagan.k
        public long GetURN(int URnTypeId, string URnNo, out List<URNTypes> lstURN)
        {
            long returnCode = -1;
            lstURN = new List<URNTypes>();
            try
            {
                SqlCommand objCommand = Command.pGetURNCommand(URnTypeId, URnNo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));


                using (DBEngine dbEngine = new DBEngine())
                {
                    IDataReader dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstURN);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetURN Patient_DAL", e);
            }
            return returnCode;
        }
        public long GetPhysicianOrgMapping(int PhysicianId, out List<PhysicianOrgMapping> lstReferingPhysician)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetPhysicianOrgMappingCommand(PhysicianId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstReferingPhysician = new List<PhysicianOrgMapping>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstReferingPhysician);
            }
            return returnCode;
        }
        public long UpdatePatientICDStatus(long VisitID)
        {
            long returnCode = -1;
            using (DBEngine dBEngine = new DBEngine())
            {
                DataSet ds = new DataSet();

                SqlCommand cmd = new SqlCommand();
                cmd = Command.pUpdatePatientICDStatusCommand(VisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                returnCode = dBEngine.ExecuteNonQuery(cmd);

            }
            return returnCode;
        }

        public long GetPendingICDCodes(long VisitID, string VisitType, string ICDStatus, out List<PatientComplaint> lstPatientComplaint, out List<PatientComplaint> lstBackgroundProblem, out List<PatientComplaint> lstPatientComplication, out List<PatientComplaint> lstOperationComplication, out  List<PatientComplaint> lstCauseOfDeath, out List<PatientComplaint> lstPhysioCompliant)
        {
            long returnCode = -1;
            lstPatientComplaint = new List<PatientComplaint>();
            lstBackgroundProblem = new List<PatientComplaint>();
            lstPatientComplication = new List<PatientComplaint>();
            lstOperationComplication = new List<PatientComplaint>();
            lstCauseOfDeath = new List<PatientComplaint>();
            lstPhysioCompliant = new List<PatientComplaint>();
            using (DBEngine dBEngine = new DBEngine())
            {
                DataSet ds = new DataSet();

                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetPendingICDCodesCommand(VisitID, VisitType, ICDStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                returnCode = dBEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientComplaint);
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstBackgroundProblem);
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPatientComplication);
                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstOperationComplication);
                    returnCode = Utilities.ConvertTo(ds.Tables[4], out lstCauseOfDeath);
                    returnCode = Utilities.ConvertTo(ds.Tables[5], out lstPhysioCompliant);
                }
            }
            return returnCode;
        }

        public long UpdatePendingICDCodes(long VisitID, string VisitType, List<PatientComplaint> lstPatientComplaint, List<PatientComplaint> lstBackgroundProblem, List<PatientComplaint> lstPatientComplication)
        {

            DataTable dtPatientComplaint = UDT_DAL.ConvertToPendingICD(lstPatientComplaint);
            DataTable dtBackgroundProblem = UDT_DAL.ConvertToPendingICD(lstBackgroundProblem);
            DataTable dtPatientComplication = UDT_DAL.ConvertToPendingICD(lstPatientComplication);

            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pUpdatePendingICDCodesCommand(VisitID, VisitType, dtPatientComplaint, dtBackgroundProblem, dtPatientComplication, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteTransactionalNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);

            }

            return returnCode;
        }


        public long ViewPageByICDCode(long VisitID, string VisitType, string ICDStatus, out List<PatientComplaint> lstPCT, out List<BackgroundProblem> lstBP, out  List<PatientComplication> lstPCN, out  List<OperationComplication> lstOPC, out  List<CauseOfDeath> lstCOD, out  List<PhysioCompliant> lstPHYC)
        {
            long returnCode = -1;
            lstPCT = new List<PatientComplaint>();
            lstBP = new List<BackgroundProblem>();
            lstPCN = new List<PatientComplication>();
            lstOPC = new List<OperationComplication>();
            lstCOD = new List<CauseOfDeath>();
            lstPHYC = new List<PhysioCompliant>();
            using (DBEngine dBEngine = new DBEngine())
            {
                DataSet ds = new DataSet();

                SqlCommand cmd = new SqlCommand();
                cmd = Command.pViewPageByICDCodeCommand(VisitID, VisitType, ICDStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                returnCode = dBEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPCT);
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstBP);
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPCN);
                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstOPC);
                    returnCode = Utilities.ConvertTo(ds.Tables[4], out lstCOD);
                    returnCode = Utilities.ConvertTo(ds.Tables[5], out lstPHYC);
                }
            }
            return returnCode;
        }



        public long SearchICDStatus(string strStatus, string strICDFromDate, string strICDToDate, string strVisitType, string strPatientName, int OrgID, out List<PatientVisit> patientVisit)
        {
            long returnCode = -1;
            System.Data.SqlClient.SqlCommand cmd;
            cmd = Command.pICDStatusSearchCommand(strStatus, strICDFromDate, strICDToDate, strVisitType, strPatientName, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            patientVisit = new List<PatientVisit>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out patientVisit);
            }
            return returnCode;
        }
        public long UpdateICDStatus(long visitID, string ICDStatus)
        {
            long returnCode = -1;
            SqlCommand cmdUpdateICDDetails = new SqlCommand();
            cmdUpdateICDDetails = Command.pUpdateICDStatusCommand(visitID, ICDStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdUpdateICDDetails.Parameters.Add("@Return", SqlDbType.Int);
            cmdUpdateICDDetails.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(cmdUpdateICDDetails);
                    returnCode = Convert.ToInt64(cmdUpdateICDDetails.Parameters["@Return"].Value);
                }

            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing UpdateDispatchDetails in Patient_DAL", excep);
            }
            return returnCode;
        }

        public long SaveAddDiagonasis(long visitID, long pid, List<BackgroundProblem> lstBackgroundPrb, List<PatientComplaint> lstPatientComplaint, long LID)
        {
            long returnCode = -1;
            DataTable dtPatientComplaint = UDT_DAL.ConvertToPendingICD(lstPatientComplaint);
            DataTable dtBackgroundProblem = UDT_DAL.ConvertToPendingICD(lstBackgroundPrb);
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pSaveAddDiagonasisCommand(visitID, pid, dtPatientComplaint, dtBackgroundProblem, LID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine())
            {

                returnCode = dbEngine.ExecuteNonQuery(cmd);

            }
            return returnCode;
        }

        public long SaveCommunicableDiseases(int OrgId, int ILocationID, List<CommunicableDiseaseMaster> CDS, long LID)
        {
            long returnCode = -1;

            DataTable dtCommunicableDiseases = UDT_DAL.ConvertToCommunicableDiseaseMaster(CDS);

            SqlCommand cmd = new SqlCommand();
            cmd = Command.pSaveCommunicableDiseaseCommand(OrgId, ILocationID, dtCommunicableDiseases, LID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine(false))
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
            }
            return returnCode;
        }
        public long GetCommunicableDiseases(int OrgID, out List<CommunicableDiseaseMaster> CDS)
        {
            long returnCode = -1;
            System.Data.SqlClient.SqlCommand cmd;
            cmd = Command.pGetCommunicableDiseasesCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            CDS = new List<CommunicableDiseaseMaster>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out CDS);
            }
            return returnCode;
        }

        public long GetPatientDetailsVisitID(long visitID, out List<Patient> lstPatient)
        {
            long returnCode = -1;
            lstPatient = new List<Patient>();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetPatientDetailsVisitIDCommand(visitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatient);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while get patient details passing visit id", ex);
            }

            return returnCode;
        }


        public long GetICDCodeByComplaintID(int ComplaintID, out List<Complaint> lstComplaint)
        {
            lstComplaint = new List<Complaint>();
            long returnCode = -1;
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pGetICDCodeByComplaintIDCommand(ComplaintID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstComplaint);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while gGetICDCodeByComplaintID in PatientDal", ex);
            }

            return returnCode;
        }
        //Change dataset to datareader made by Arivalagan.k
        public long GetPatientListForRegis(string pName, string pNo, int pOrgID, out List<Patient> lstPatientDetails)
        {
            long returnCode = -1;
            lstPatientDetails = new List<Patient>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetPatientListForRegisCommand(pName, pNo, pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstPatientDetails);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientListForRegis in Patient_DAL.cs", ex);
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

        public long GetRefundReceipt(int OrgID, out List<IDMaster> lstIDMaster)
        {
            long returnCode = -1;
            lstIDMaster = new List<IDMaster>();
            SqlCommand cmd = Command.pGetRefundReceiptCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstIDMaster);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetRefundReceipt in Inventory_DAL", ex);
            }
            return returnCode;
        }

        public long GetXSLBillValue(int OrgID, int BillTypeID, out List<XslBillType> xbt)
        {
            long returnCode = -1;
            xbt = new List<XslBillType>();
            SqlCommand cmd = Command.pGetXSLBillValueCommand(OrgID, BillTypeID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out xbt);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetXSLBillValue in Patient_DAL", ex);
            }
            return returnCode;
        }


        public long SearchPatientForRefPhysician(string iPatientNo, string strPatientName, string strDOB
                                , string strRelation, string strLocation, string strOccupation
                                , string strCity, string strMobile, int currOrgID, List<TrustedOrgDetails> lstTOD
                                , int parentID, string urno, long urnTypeID, long LoginID, out List<Patient> lstPatient)
        {
            long returnCode = -1;

            DataTable dtOrgIDs = UDT_DAL.ConvertToGetOrgIDs(lstTOD);

            System.Data.SqlClient.SqlCommand cmd;
            cmd = Command.pSearchPatientForRefPhyCommand(iPatientNo, strPatientName, strRelation, strDOB, strLocation, strOccupation, strCity, strMobile, currOrgID, dtOrgIDs, parentID, urno, urnTypeID, LoginID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstPatient = new List<Patient>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatient);
            }
            return returnCode;
        }
        public long GetPatientListForQuickBill(string pName, string pVisitType, int pOrgID, int searchType, out List<Patient> lstPatientDetails)
        {
            long returnCode = -1;
            lstPatientDetails = new List<Patient>();
            SqlCommand cmd = Command.pSearchPatientNVisitDetailsCommand(pName, pVisitType, pOrgID, searchType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientListForQuickBill in Inventory_DAL", ex);
            }
            return returnCode;
        }
        public long UpdatePatientDetailsForIntegration(Patient patient, PatientAddress pAddress)
        {
            long returnCode = -1;
            SqlCommand cmdUpdatePatientDetails = new SqlCommand();
            cmdUpdatePatientDetails = Command.pUpdatePatientDetailsForIntegrationCommand(patient.OrgID, patient.PatientNumber, patient.Name, patient.TITLECode, patient.Age,patient.DOB,
                                                                                patient.SEX,"", 0, 0, "", patient.Nationality, pAddress.AddressType, pAddress.Add1, pAddress.Add2, pAddress.Add3, pAddress.PostalCode, pAddress.CountryID, pAddress.City, pAddress.StateID, pAddress.MobileNumber, pAddress.LandLineNumber, -1,patient.EMail,patient.RefDocName,patient.ReferedHospitalName,patient.ExternalPatientNumber,patient.VisitType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdUpdatePatientDetails.Parameters.Add("@Return", SqlDbType.Int);
            cmdUpdatePatientDetails.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (DBEngine dbEngine = new DBEngine(true))
            {
                dbEngine.ExecuteTransactionalNonQuery(cmdUpdatePatientDetails);

                returnCode = Convert.ToInt64(cmdUpdatePatientDetails.Parameters["@Return"].Value);

            }

            return returnCode;
        }


        public long GetPhysioComplaint(long PatientID, long VisitID, out List<PhysioCompliant> lstPhysioCompliant)
        {
            long returnCode = -1;
            lstPhysioCompliant = new List<PhysioCompliant>();
            SqlCommand cmd = Command.pGetPhysioComplaintCommand(PatientID, VisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPhysioCompliant);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPhysioComplaint in Inventory_DAL", ex);
            }
            return returnCode;
        }

        public long InsertSmartCardDetail(string SmartCardNo, string SmartCardIssued, string SmartCardStatus, long LID, long patientID)
        {
            long returnCode = -1;
            SqlCommand cmdInsertSmartCardDetails = new SqlCommand();
            cmdInsertSmartCardDetails = Command.pInsertSmartCardDetailCommand(patientID, SmartCardNo, SmartCardIssued, SmartCardStatus, LID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdInsertSmartCardDetails.Parameters.Add("@returnStatus", SqlDbType.Int);
            cmdInsertSmartCardDetails.Parameters["@returnStatus"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmdInsertSmartCardDetails);

                    returnCode = Convert.ToInt64(cmdInsertSmartCardDetails.Parameters["@returnStatus"].Value);

                }
            }
            catch (Exception er)
            {
                CLogger.LogError("Error while executing InsertSmartCardDetail in Patient_DAL", er);
            }

            return returnCode;
        }
        public long GetPatientListForQuickBillSmartCard(string pSmartCardNo, int pOrgID, out List<Patient> lstPatientDetails)
        {
            long returnCode = -1;
            lstPatientDetails = new List<Patient>();
            SqlCommand cmd = Command.pSearchPatientNVisitDetailsSmartCardCommand(pSmartCardNo, pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientListForQuickBill in Patient_DAL", ex);
            }
            return returnCode;
        }
        //Changes of DataSet To DataReader Made By Arivalagan.k
        public long GetInvestigationOrgChange(string ExternalVisitID, int OrgID, string FromDate, string toDate, string PatientName, string patientnumber, string pVisitNumber, out List<PatientVisit> lstpatientVisit, out List<OrderedInvestigations> lstOrderinvestication)
        {
            IDataReader dataReader = null;
            long returncode = -1;
            lstpatientVisit = new List<PatientVisit>();
            lstOrderinvestication = new List<OrderedInvestigations>();
            int rsCount = 0;
            try
            {
                SqlCommand cmd = Command.pGetInvesticationOrgChangeCommand(ExternalVisitID, OrgID, FromDate, toDate, PatientName, patientnumber, pVisitNumber, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returncode = Utilities.ConvertTo(dataReader, out lstpatientVisit);
                            }
                            else if (rsCount == 1)
                            {
                                returncode = Utilities.ConvertTo(dataReader, out lstOrderinvestication);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationOrgChange in Patient_DAL", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returncode;

        }

        public long GETOPCreditBillReport(string TPAID, string ClientID, string FDate, string TDate, int OrgID, out List<BillSearch> lstDetails)
        {
            long returncode = -1;
            lstDetails = new List<BillSearch>();
            DataSet ds = new DataSet();


            return returncode;

        }
        public long GetDiscountReason(int OrgID, out List<DiscountReasonMaster> lstDiscountReason)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetDiscountReasonMasterCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstDiscountReason = new List<DiscountReasonMaster>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstDiscountReason);
            }
            return returnCode;
        }

        public long GetReportTemplateByDeptID(long patientVisitID, int OrgID, out List<InvReportMaster> lstReportMaster, out List<InvReportMaster> lstReportName, out List<InvDeptMaster> lstDpts, string deptids)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pGetReportTemplateDeptIDCommand(patientVisitID, OrgID, deptids, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstReportMaster = new List<InvReportMaster>();
            lstReportName = new List<InvReportMaster>();
            lstDpts = new List<InvDeptMaster>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                Utilities.ConvertTo(ds.Tables[0], out lstReportMaster);
            }

            if (ds.Tables[1].Rows.Count > 0)
            {
                Utilities.ConvertTo(ds.Tables[1], out lstReportName);
            }
            if (ds.Tables[2].Rows.Count > 0)
            {
                Utilities.ConvertTo(ds.Tables[2], out lstDpts);
            }

            return returnCode;
        }

        public long InsertPatientEmployee(string pName, long pCreatedBy, long PatientID, long Type, List<EmployeeRegMaster> EmpDetails, string picExtension, out string EmpTypeNumber)
        {
            long returnCode = -1;
            SqlCommand cmdInsertPatientEmployee = new SqlCommand();
            EmpTypeNumber = string.Empty;
            if (EmpDetails.Count > 0)
            {
                cmdInsertPatientEmployee = Command.pInsertPatientEmployeeCommand(EmpDetails[0].Type, pName, EmpDetails[0].DOJ, EmpDetails[0].EmployementTypeID,
                                    EmpDetails[0].EmployementTypeNumber, EmpDetails[0].Qualification,
                                    EmpDetails[0].DeptID, EmpDetails[0].GradeID, EmpDetails[0].DesignationID,
                                    EmpDetails[0].EmployerID, PatientID, EmpDetails[0].EmployerLocationID,
                                                                                                                     EmpDetails[0].OrgID, EmpDetails[0].EmpID, pCreatedBy, Type, picExtension, out EmpTypeNumber, UDT_DAL.ConvertToUDT_Context(globalContextDetails));


                cmdInsertPatientEmployee.Parameters.Add("@returnStatus", SqlDbType.Int);
                cmdInsertPatientEmployee.Parameters["@returnStatus"].Direction = ParameterDirection.ReturnValue;
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteTransactionalNonQuery(cmdInsertPatientEmployee);
                        returnCode = Convert.ToInt64(cmdInsertPatientEmployee.Parameters["@returnStatus"].Value);
                        EmpTypeNumber = cmdInsertPatientEmployee.Parameters["@EmpTypeNumber"].Value.ToString();
                    }
                }
                catch (Exception er)
                {
                    CLogger.LogError("Error while executing InsertPatientEmployee in Patient_DAL", er);
                }
            }
            return returnCode;

        }

        public long GetEmployerList(long pPatientID, string @PatientEmployerName, string @PatientEmployerNo, int OrgID, out List<EmployeeRegMaster> lstDetails)
        {
            long returncode = -1;
            lstDetails = new List<EmployeeRegMaster>();
            SqlCommand cmd = Command.pGetEmployerListCommand(pPatientID, @PatientEmployerName, @PatientEmployerNo, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returncode = Utilities.ConvertTo(ds.Tables[0], out lstDetails);
            }

            return returncode;
        }

        public long SearchCorporatePatient(string EmpNo, string EmpName, string EmpDependentNumber, string EmpDependentName, int EmployerID, int OrgID, string FromDate, string ToDate, out List<Patient> lstPatient)
        {
            long returncode = -1;
            lstPatient = new List<Patient>();
            SqlCommand cmd = Command.pSearchCorporatePatientCommand(EmpNo, EmpName, EmpDependentNumber, EmpDependentName, EmployerID, OrgID, FromDate, ToDate, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returncode = Utilities.ConvertTo(ds.Tables[0], out lstPatient);
            }
            return returncode;
        }
        public long GetEMPPatientListForRegis(string pName, string pNo, int pOrgID, out List<Patient> lstPatientDetails)
        {
            long returnCode = -1;
            lstPatientDetails = new List<Patient>();
            SqlCommand cmd = Command.pGetEmployeeListForRegisCommand(pName, pNo, pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetProductList in Inventory_DAL", ex);
            }
            return returnCode;
        }
        public long GetComplaintNameDESC(string ComplaintName, out List<Complaint> lstCName)
        {
            long returnCode = -1;
            using (DBEngine dBEngine = new DBEngine())
            {
                DataSet ds = new DataSet();
                lstCName = new List<Complaint>();
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pGetComplaintDESCCommand(ComplaintName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                returnCode = dBEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstCName);
            }
            return returnCode;
        }
        public long GetEmployeeDemoandAddress(long patientID, out List<Patient> lstPatient)
        {
            long returnCode = -1;
            SqlCommand objCommand = new SqlCommand();
            List<PatientAddress> pAddress = new List<PatientAddress>();
            objCommand = Command.pGetEmployeeDetailandAddressCommand(patientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstPatient = new List<Patient>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 1)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatient);
                returnCode = Utilities.ConvertTo(ds.Tables[1], out pAddress);
            }
            if (lstPatient.Count > 0)
                lstPatient[0].PatientAddress = pAddress;
            return returnCode;
        }
        public long GetMappedOrganisation(int OrgID, long PhysicianID, out List<LabReferenceOrg> lstLabRefOrg, out List<PCClientMapping> lstPCClientMapping)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.PgetMappingOrganisationCommand(PhysicianID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstLabRefOrg = new List<LabReferenceOrg>();
            lstPCClientMapping = new List<PCClientMapping>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstLabRefOrg);
            }
            if (ds.Tables[1].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPCClientMapping);
            }
            return returnCode;
        }
        public long ServiceSearchDetails(string strBillNo, string strBillFromDate, string strBillToDate, string strPatientName, int OrgID, string PatientNumber, out List<EmployeeSearch> billSearch, int pageSize, int StartRowIndex, out int totalRows)
        {
            long returnCode = -1;
            System.Data.SqlClient.SqlCommand cmd;
            cmd = Command.pSearchCorporateServiceDetailsCommand(strBillNo, strBillFromDate, strBillToDate, strPatientName, OrgID, PatientNumber, pageSize, StartRowIndex, out totalRows, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            billSearch = new List<EmployeeSearch>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out billSearch);
                totalRows = Convert.ToInt32(ds.Tables[1].Rows[0]["totalRows"]);
            }
            return returnCode;
        }
        public long GetRelationshipList(out List<RelationshipMaster> lstrelation)
        {
            long returncode = -1;
            SqlCommand objcommand = Command.pGetRelationshipListCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstrelation = new List<RelationshipMaster>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objcommand, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returncode = Utilities.ConvertTo(ds.Tables[0], out lstrelation);
            }
            return returncode;
        }
        public long GetLabAllRefOrg(string prefixText, int OrgID, out List<LabReferenceOrg> lstLabRefOrg)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetLabAllRefOrgCommand(prefixText, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstLabRefOrg = new List<LabReferenceOrg>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstLabRefOrg);
            }
            return returnCode;
        }


        public long SaveTRFDetails(String FileName, int PatientID, int VisitID, int OrgID, long IdentifyingID, String IdentifyingType, String FilePath, long Createdby, DateTime Createdat, string Isactive,long accessionno)
        {
            long returncode = -1;
            SqlCommand objCommand = Command.pInsertTRFDetailsCommand(FileName,PatientID,VisitID,OrgID,IdentifyingID,IdentifyingType,FilePath,Createdby,
                Createdat, Isactive,accessionno, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            objCommand.Parameters.Add("@Return", SqlDbType.Int);
            objCommand.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(objCommand);

                    returncode = Convert.ToInt64(objCommand.Parameters["@Return"].Value);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing SaveTRFdetails Patient_DAL", excep);
            }
            return returncode;

        }
        // changed dataset to datareader by Arivalagan.k
        public long GetTRFDetails(int patientid, int visitid, int OrgID, string Type, out List<TRFfilemanager> TRFdetails)
        {
            IDataReader dataReader = null;
            long returncode = -1;
            TRFdetails = new List<TRFfilemanager>();
            try
            {
            SqlCommand objcmd = Command.pGetTRFDetailsCommand(patientid, visitid, OrgID, Type, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
           
           
           
               // SqlCommand objcmd = Command.pGetTRFDetailsCommand(patientid, visitid, OrgID, Type, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objcmd);
                    if (dataReader != null)
                    {
                        returncode = Utilities.ConvertTo(dataReader, out TRFdetails);
                        dataReader.Close();
                    } 
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing TRFdetails Patient_DAL", excep);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            } 
            return returncode;
        }
        //Change dataset to datareader made by Arivalagan.k
        public long GetTrustedOrgInvClientMaster(int OrgID, out List<InvClientMaster> lstInvClientMaster)
        {
            long returnCode = -1;
            lstInvClientMaster = new List<InvClientMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetTrustedOrgInvClientMasterCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));


                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);


                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvClientMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetTrustedOrgInvClientMaster in Patient_DAL.CS", ex);
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
        //Change dataset to datareader made by Arivalagan.k
        public long GetTrustedOrgReferingPhysician(string DrName, int OrgID, out List<ReferingPhysician> lstReferingPhysician)
        {
            long returnCode = -1;
            lstReferingPhysician = new List<ReferingPhysician>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetTrustedOrgRefPhysicianCommand(OrgID, DrName, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstReferingPhysician);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetTrustedOrgReferingPhysician  in Patient_DAL", ex);
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
        public long GetQuickInternalExternalPhysician(string prefixText, int OrgID, out List<Physician> lstLabPhy)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetQuickInternalExternalPhysicianCommand(prefixText, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstLabPhy = new List<Physician>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstLabPhy);
            }
            return returnCode;
        }

        // changed dataset to datareader by Arivalagan.k
        public long Getpatientphoto(int patientid, out List<Patient> lstpat)
        {
            long returncode = -1;
            IDataReader dataReader = null;
            lstpat = new List<Patient>();
            try
            {
                SqlCommand objcommand = Command.pGetpatientphotoCommand(patientid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objcommand);
                    if (dataReader != null)
                    {
                        returncode = Utilities.ConvertTo(dataReader, out lstpat);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing PatientPhoto Patient_DAL", excep);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            } 
            return returncode;
        }
        public long GetEmployeeNumber(int OrgID, string EmployeeNo, int EmployerID, out List<EmployeeRegMaster> lstpat)
        {
            long returncode = -1;

            SqlCommand objcommand = Command.PgetEmployeeIDCommand(OrgID, EmployerID, EmployeeNo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstpat = new List<EmployeeRegMaster>();
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objcommand, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstpat);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing GetEmployeeNumber Patient_DAL", excep);
            }

            return returncode;
        }
        public long MakeVisitToPhysio(long PatientID, long SVisitID, int OrgID, long ProcedureID)
        {
            long returnCode = -1;
            SqlCommand cmdMakeVisitToPhysio = new SqlCommand();
            cmdMakeVisitToPhysio = Command.pConfirmVisitToPhysioCommand(PatientID, SVisitID, OrgID, ProcedureID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdMakeVisitToPhysio.Parameters.Add("@Return", SqlDbType.Int);
            cmdMakeVisitToPhysio.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(cmdMakeVisitToPhysio);
                    returnCode = Convert.ToInt64(cmdMakeVisitToPhysio.Parameters["@Return"].Value);
                }

            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing UpdateDispatchDetails in Patient_DAL", excep);
            }
            return returnCode;
        }

        public long LoadSearchTypeMetaData(out List<CustomPeriodRange> lstCustomPeriod, out List<PatientSearchType> lstPatientType, out List<OtherSearchCriteria> lstsearchCreteria)
        {
            long returncode = -1;

            SqlCommand objcommand = Command.pLoadSearchTypeMetaDataCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstCustomPeriod = new List<CustomPeriodRange>();
            lstPatientType = new List<PatientSearchType>();
            lstsearchCreteria = new List<OtherSearchCriteria>();

            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objcommand, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstCustomPeriod);
                }
                {
                    returncode = Utilities.ConvertTo(ds.Tables[1], out lstPatientType);
                }
                {
                    returncode = Utilities.ConvertTo(ds.Tables[2], out lstsearchCreteria);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing GetEmployeeNumber Patient_DAL", excep);
            }

            return returncode;
        }


        public long GetExternalDetails(string pName, string pNo, int pOrgID, out List<Patient> lstPatientDetails)
        {
            long returnCode = -1;
            lstPatientDetails = new List<Patient>();
            SqlCommand cmd = Command.PgetexternalIDCommand(pName, pNo, pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetExternalDetails", ex);
            }
            return returnCode;
        }
        public long InsertFamilytree(int OrgID, List<Familytree> lstFamilytree)
        {
            long returnCode = -1;

            DataTable dtFamilytree = UDT_DAL.ConvertToFamilytree(lstFamilytree);

            SqlCommand cmd = new SqlCommand();
            cmd = Command.PinsertfamilytreeCommand(OrgID, dtFamilytree, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(cmd);
                }

            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing Pinsertfamilytree in Patient_DAL", excep);
            }
            return returnCode;
        }
        //Changes of DataSet To DataReader Made By Arivalagan.k
        public long GetClientRateMappingDetail(int OrgId, int ClientTypeID, out List<InvClientMaster> lstInvClientMaster)
        {
            IDataReader dataReader = null;
            long returncode = -1;
            lstInvClientMaster = new List<InvClientMaster>();
            SqlCommand cmd = Command.pGetClientRateMappingDetailCommand(OrgId, ClientTypeID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returncode = Utilities.ConvertTo(dataReader, out lstInvClientMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing GetClientRateMappingDetail Patient_DAL", excep);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returncode;
        }
        public long SaveClientRateMappingDetail(int OrgID, int ClientTypeID, int ClientID, int RateID, List<InvClientMaster> lstInvClientMaster, long CreatedBy,string Reason)
        {
            long returnCode = -1;
            DataTable dtClientMaster = UDT_DAL.ConvertToInvClientMaster(lstInvClientMaster);

            SqlCommand cmd = Command.pSaveClientRateMappingDetailCommand(OrgID, ClientTypeID, ClientID, RateID, dtClientMaster, CreatedBy,Reason, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveClientRateMappingDetail in Patient_DAL", ex);

            }
            return returnCode;
        }

        public long GetClientRateMappingItems(int OrgID, int ClientID, int RateID, int ClientTypeID, DateTime FromDate, DateTime ToDate, out List<InvClientMaster> lstInvClientRate, out List<InvClientMaster> lstCMaster)
        {
            long returncode = -1;
            lstInvClientRate = new List<InvClientMaster>();
            lstCMaster = new List<InvClientMaster>();
            SqlCommand objcommand = Command.pGetClientRateMappingItemsCommand(OrgID, ClientID, RateID, ClientTypeID, FromDate, ToDate, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objcommand, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[0], out lstInvClientRate);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    returncode = Utilities.ConvertTo(ds.Tables[1], out lstCMaster);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing pGetClientRateMappingItems Patient_DAL", excep);
            }
            return returncode;
        }
        // changed dataset to datareader by Arivalagan.k
        public long GetQuickBillRefOrg(string prefixText, int OrgID, int pClientTypeID, string pStatus, string contextkey, out List<LabReferenceOrg> lstLabRefOrg)
        {
            long returnCode = -1;
            lstLabRefOrg = new List<LabReferenceOrg>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetQuickBillRefOrgCommand(prefixText, OrgID, pClientTypeID, pStatus, contextkey, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstLabRefOrg);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetQuickBillRefOrg Patient_DAL", e);
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

        public long GetOrderedPhysio(long patientID, long visitID, long createdBy, out List<OrderedPhysiotherapy> lstOrderedPhysiotherapy, out long proTaskStatusID)
        {
            long returnCode = -1;
            proTaskStatusID = -1;
            lstOrderedPhysiotherapy = new List<OrderedPhysiotherapy>();
            SqlCommand cmd = Command.pGetOrderedPhysioCommand(patientID, visitID, createdBy, out proTaskStatusID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                    proTaskStatusID = Convert.ToInt64(cmd.Parameters["@TaskActionStatusID"].Value);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstOrderedPhysiotherapy);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetOrderedPhysio", ex);
            }
            return returnCode;
        }

        public long DeletePendingProcedure(long PatientID, long VisitID, long ProcedureID, int OrgID)
        {
            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pDeletePendingProcedureCommand(PatientID, VisitID, ProcedureID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                }

            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing DeletePendingProcedure in Patient_DAL", excep);
            }
            return returnCode;
        }
        public long UpdatepatientPhoto(string PictureName, int OrgID, long PatientID)
        {
            long lResult = -1;
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pUpdatePatientPhotoCommand(PictureName, OrgID, PatientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            using (DBEngine dBEngine = new DBEngine(false))
            {
                dBEngine.ExecuteNonQuery(cmd);
                lResult = Convert.ToInt64(cmd.Parameters["@Return"].Value);

            }
            return lResult;

        }

        // changed dataset to datareader by Arivalagan.k
        public long InsertPatientBilling(Patient pdetails, FinalBill finalBill, long ReferingPhysicianID, int ReferingspecialityID,
                                     long SpecialityID, List<PatientDueChart> lstDueChart, int AgeValue, string AgeUnit, long pSpecialityID, string ReferralType,
                                     string Paymentstaus, string pGuID, DataTable dtAmtReceived, List<OrderedInvestigations> lstOrderedInves,
                                     List<TaxBillDetails> lstTaxDetails, out List<BillingDetails> lstBillingdetails,
                                     out int returnStatus, int IsExternelPatient, string WardNo, long EpisodeID, long EpisodeVisitID, long SiteID, string VisitSampleStatus,
                              long EpisodeTrackID, DateTime SamplePickupDate, string ConsignmentNo,
           List<ControlMappingDetails> lstControlSavedValues, string IsEditMode, List<PatientDisPatchDetails> lstDispatchDetails,
           List<VisitClientMapping> lstVisitClientMapping, out long PatientRoleID, long OnBehalfOfClientID, long TodayVisitID, string externalVisitID, string approvalNo, String IsCopay, List<PatientDiscount> lstPatientDiscount, string strMyCardActiveDays, string strMemebershipcardType, string strHealthCardType, string strOTP, string strStatus, long strMembershipCardMappingID, string strCreditRedeem, long RedeemPatientid, long RedeemVisitid, long RedeemOrgId,
            decimal RedemPoints, decimal RedemValue, List<PatientRedemDetails> lstPatientRedemDetails, List<OrderedInvestigations> lstUnOrderedInves, string StatFlag, string ClientFlag, long CollectionID,string EmailCC,string VisitNumber,string ClinicCode,string value,List<VisitTemplate> visittemplate,
            List<PatientVisitLanguage> lstpatlanguage, string DueReason, string DueAuthorizer, string HealthHubId)
        {

            lstBillingdetails = new List<BillingDetails>();
            IDataReader dataReader = null;
            DataTable dtTax = new DataTable();
            dtTax = UDT_DAL.ConvertToUDTaxBillDetails(lstTaxDetails);
            DataTable dtBillingDetails = UDT_DAL.ConvertToUDTPatientDueChart(lstDueChart);
            DataTable invs = UDT_DAL.ConvertToOrderedInvestigation(lstOrderedInves);
            DataTable ControlSavedValues = UDT_DAL.ConvertToControlMappingDetails(lstControlSavedValues);
            DataTable dtDispatchDetails = UDT_DAL.ConvertToUDTDisPatchMode(lstDispatchDetails);
            DataTable dtPatientDiscount = UDT_DAL.ConvertToUDTPatientDiscount(lstPatientDiscount);

            DataTable dtRedemPoints = UDT_DAL.ConvertToPatientRedemDetails(lstPatientRedemDetails);
            DataTable lstUnOrderedInv = UDT_DAL.ConvertToOrderedInvestigation(lstUnOrderedInves);
            DataTable visittemplates = UDT_DAL.ConvertToVisittemplate(visittemplate);
            DataTable PatientLanguage = UDT_DAL.ConvertToUDTPatientVisitLanguage(lstpatlanguage);
            string Address1 = "";
            long returnCode = -1;
            PatientRoleID = 0;
            returnStatus = -1;

            Address1 = pdetails.PatientAddress[0].Add1 == null ? "" : pdetails.PatientAddress[0].Add1;

            string Addresss2 = "";
            Addresss2 = pdetails.PatientAddress[0].Add2 == null ? "" : pdetails.PatientAddress[0].Add2;

            string Address3 = "";
            Address3 = pdetails.PatientAddress[0].Add3 == null ? "" : pdetails.PatientAddress[0].Add3;

            string City = "";
            City = pdetails.PatientAddress[0].City == null ? "" : pdetails.PatientAddress[0].City;

            string PhoneNo = "";
            PhoneNo = pdetails.PatientAddress[0].LandLineNumber == null ? "" : pdetails.PatientAddress[0].LandLineNumber;

            string MobileNo = "";
            MobileNo = pdetails.PatientAddress[0].MobileNumber == null ? "" : pdetails.PatientAddress[0].MobileNumber;
            try
            {
                SqlCommand cmd = Command.pInsertPatientBillingCommand(pdetails.PatientID, pdetails.OrgID, finalBill.OrgAddressID, pdetails.CreatedBy, pdetails.Name, pdetails.TITLECode.ToString(),
                                    pdetails.SEX, pdetails.Age, pdetails.PatientNumber, Address1, Addresss2,
                                    Address3, City, PhoneNo, MobileNo, pdetails.MartialStatus, pdetails.DOB, AgeValue, AgeUnit, pdetails.CompressedName,
                                   pdetails.Nationality, pdetails.StateID, pdetails.CountryID, pdetails.PostalCode, pdetails.SmartCardNumber, pdetails.EMail, pdetails.NotifyType, pdetails.URNO, pdetails.URNofId, pdetails.URNTypeId,
                                    pdetails.PatientHistory, pdetails.PatientType, pdetails.PatientStatus, pdetails.VisitPurposeID, pdetails.SecuredCode,
                                    Convert.ToInt32(pdetails.PriorityID), IsExternelPatient, WardNo, EpisodeID, EpisodeVisitID,
                                      pdetails.PatientVisitID,
                                    ReferingPhysicianID, pdetails.ReferingPhysicianName, pdetails.ReferedHospitalID,
                                    pdetails.ReferedHospitalName, ReferingspecialityID, SpecialityID, ReferralType, finalBill.GrossBillValue, finalBill.DiscountAmount, finalBill.DiscountReason,
                                    finalBill.DiscountApprovedBy, finalBill.TaxAmount, finalBill.ServiceCharge, finalBill.RoundOff, finalBill.NetValue, finalBill.Due,
                                    dtTax, dtBillingDetails, finalBill.IsCreditBill, dtAmtReceived, invs, Paymentstaus, pGuID, EpisodeTrackID, SiteID, VisitSampleStatus, SamplePickupDate, ConsignmentNo, ControlSavedValues, pdetails.RegistrationRemarks,
                            out returnStatus, pdetails.ExternalPatientNumber, dtDispatchDetails, finalBill.TATDate,
                            finalBill.EDCess, finalBill.SHEDCess, IsEditMode, pdetails.VistTypeID, pdetails.PStatusID,
                            UDT_DAL.ConvertToUDT_Context(globalContextDetails), UDT_DAL.ConvertToVisitClientMapping(lstVisitClientMapping),
                            out PatientRoleID, OnBehalfOfClientID, TodayVisitID, pdetails.PhleboID, pdetails.LogisticsID, pdetails.RoundNo,
                             pdetails.ExAutoAuthorization, pdetails.ParentPatientID, externalVisitID, approvalNo, pdetails.NewPassword, pdetails.ZoneID, pdetails.UnknownFlag, finalBill.DiscountID, IsCopay, dtPatientDiscount, finalBill.IsFoc, strMyCardActiveDays, strMemebershipcardType, strHealthCardType, strOTP, strStatus, strMembershipCardMappingID, strCreditRedeem, finalBill.RedeemPoints,finalBill.RedeemValue, pdetails.HasHealthCard,
                             RedemPoints, RedemValue, dtRedemPoints, lstUnOrderedInv,StatFlag, ClientFlag, finalBill.ItemLevelDiscountTotal, finalBill.DiscountAmount,CollectionID, EmailCC, value, VisitNumber, ClinicCode,visittemplates,PatientLanguage,DueReason,DueAuthorizer,HealthHubId);

                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstBillingdetails);
                        dataReader.Close();
                    }
               
               
                        returnStatus = Convert.ToInt32(cmd.Parameters["@pReturnStatus"].Value);
                        PatientRoleID = Convert.ToInt64(cmd.Parameters["@RoleID"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL InsertPatientBilling", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            } 
            return returnStatus;
        }
		public long InsertPatientBillingHL(Patient pdetails, FinalBill finalBill, long ReferingPhysicianID, int ReferingspecialityID,
                                     long SpecialityID, List<PatientDueChart> lstDueChart, int AgeValue, string AgeUnit, long pSpecialityID, string ReferralType,
                                     string Paymentstaus, string pGuID, DataTable dtAmtReceived, List<OrderedInvestigations> lstOrderedInves,
                                     List<TaxBillDetails> lstTaxDetails, out List<BillingDetails> lstBillingdetails,
                                     out int returnStatus, int IsExternelPatient, string WardNo, long EpisodeID, long EpisodeVisitID, long SiteID, string VisitSampleStatus,
                              long EpisodeTrackID, DateTime SamplePickupDate, string ConsignmentNo,
           List<ControlMappingDetails> lstControlSavedValues, string IsEditMode, List<PatientDisPatchDetails> lstDispatchDetails,
           List<VisitClientMapping> lstVisitClientMapping, out long PatientRoleID, long OnBehalfOfClientID, long TodayVisitID, string externalVisitID, string approvalNo, String IsCopay, List<PatientDiscount> lstPatientDiscount, string strMyCardActiveDays, string strMemebershipcardType, string strHealthCardType, string strOTP, string strStatus, long strMembershipCardMappingID, string strCreditRedeem, long RedeemPatientid, long RedeemVisitid, long RedeemOrgId,
            decimal RedemPoints, decimal RedemValue, List<PatientRedemDetails> lstPatientRedemDetails, List<OrderedInvestigations> lstUnOrderedInves, 
            string StatFlag, string ClientFlag, long CollectionID, string EmailCC, string VisitNumber, string ClinicCode, string value, string PersonIdentifier,
            string physicianPNo, string FutureDate, int ExternalVisitType, string ORCNumber, string MigratedvisitNumber, string MigratedRequestNumber, 
            string ReportMode,DateTime PatientRegDateTime,DateTime OrderedDateTime,string HLEnteredby,long reportClientid, bool IsCumulative,string ParentOrder,
            string Relevant_Clinical_Information,string Placer_Field2,string Collectors_Comment,string ClientInvoiceNo)
        {
            lstBillingdetails = new List<BillingDetails>();
            IDataReader dataReader = null;
            DataTable dtTax = new DataTable();
            dtTax = UDT_DAL.ConvertToUDTaxBillDetails(lstTaxDetails);
            DataTable dtBillingDetails = UDT_DAL.ConvertToUDTPatientDueChart(lstDueChart);
            DataTable invs = UDT_DAL.ConvertToOrderedInvestigation(lstOrderedInves);
            DataTable ControlSavedValues = UDT_DAL.ConvertToControlMappingDetails(lstControlSavedValues);
            DataTable dtDispatchDetails = UDT_DAL.ConvertToUDTDisPatchMode(lstDispatchDetails);
            DataTable dtPatientDiscount = UDT_DAL.ConvertToUDTPatientDiscount(lstPatientDiscount);
            DataTable dtRedemPoints = UDT_DAL.ConvertToPatientRedemDetails(lstPatientRedemDetails);
            DataTable lstUnOrderedInv = UDT_DAL.ConvertToOrderedInvestigation(lstUnOrderedInves);
            string Address1 = "";
            long returnCode = -1;
            PatientRoleID = 0;
            returnStatus = -1;
            Address1 = pdetails.PatientAddress[0].Add1 == null ? "" : pdetails.PatientAddress[0].Add1;
            string Addresss2 = "";
            Addresss2 = pdetails.PatientAddress[0].Add2 == null ? "" : pdetails.PatientAddress[0].Add2;
            string Address3 = "";
            Address3 = pdetails.PatientAddress[0].Add3 == null ? "" : pdetails.PatientAddress[0].Add3;
            string City = "";
            City = pdetails.PatientAddress[0].City == null ? "" : pdetails.PatientAddress[0].City;
            string PhoneNo = "";
            PhoneNo = pdetails.PatientAddress[0].LandLineNumber == null ? "" : pdetails.PatientAddress[0].LandLineNumber;
            string MobileNo = "";
            MobileNo = pdetails.PatientAddress[0].MobileNumber == null ? "" : pdetails.PatientAddress[0].MobileNumber;
            int CityID = 0;
            CityID = pdetails.PatientAddress[0].CityID == null ? 0 : Convert.ToInt32(pdetails.PatientAddress[0].CityID);
            int SuburbID = 0;
            SuburbID = pdetails.PatientAddress[0].SuburbID == null ? 0 : pdetails.PatientAddress[0].SuburbID;
            try
            {
                SqlCommand cmd = Command.pInsertPatientBillingHLCommand(pdetails.PatientID, pdetails.OrgID, finalBill.OrgAddressID, pdetails.CreatedBy, pdetails.Name, pdetails.TITLECode.ToString(),
                                    pdetails.SEX, pdetails.Age, pdetails.PatientNumber, Address1, Addresss2,
                                    Address3, City, PhoneNo, MobileNo, pdetails.MartialStatus, pdetails.DOB, AgeValue, AgeUnit, pdetails.CompressedName,
                                   pdetails.Nationality, pdetails.StateID, pdetails.CountryID, pdetails.PostalCode, pdetails.SmartCardNumber, pdetails.EMail, pdetails.NotifyType, pdetails.URNO, pdetails.URNofId, pdetails.URNTypeId,
                                    pdetails.PatientHistory, pdetails.PatientType, pdetails.PatientStatus, pdetails.VisitPurposeID, pdetails.SecuredCode,
                                    Convert.ToInt32(pdetails.PriorityID), IsExternelPatient, WardNo, EpisodeID, EpisodeVisitID,
                                      pdetails.PatientVisitID,
                                    ReferingPhysicianID, pdetails.ReferingPhysicianName, pdetails.ReferedHospitalID,
                                    pdetails.ReferedHospitalName, ReferingspecialityID, SpecialityID, ReferralType, finalBill.GrossBillValue, finalBill.DiscountAmount, finalBill.DiscountReason,
                                    finalBill.DiscountApprovedBy, finalBill.TaxAmount, finalBill.ServiceCharge, finalBill.RoundOff, finalBill.NetValue, finalBill.Due,
                                    dtTax, dtBillingDetails, finalBill.IsCreditBill, dtAmtReceived, invs, Paymentstaus, pGuID, EpisodeTrackID, SiteID, VisitSampleStatus, SamplePickupDate, ConsignmentNo, ControlSavedValues, pdetails.RegistrationRemarks,
                            out returnStatus, pdetails.ExternalPatientNumber, dtDispatchDetails, finalBill.TATDate,
                            finalBill.EDCess, finalBill.SHEDCess, IsEditMode, pdetails.VistTypeID, pdetails.PStatusID,
                            UDT_DAL.ConvertToUDT_Context(globalContextDetails), UDT_DAL.ConvertToVisitClientMapping(lstVisitClientMapping),
                            out PatientRoleID, OnBehalfOfClientID, TodayVisitID, pdetails.PhleboID, pdetails.LogisticsID, pdetails.RoundNo,
                             pdetails.ExAutoAuthorization, pdetails.Confidential, pdetails.ParentPatientID, externalVisitID, approvalNo, pdetails.NewPassword, pdetails.ZoneID, pdetails.UnknownFlag, finalBill.DiscountID, IsCopay, dtPatientDiscount, finalBill.IsFoc,
                             strMyCardActiveDays, strMemebershipcardType, strHealthCardType, strOTP, strStatus, strMembershipCardMappingID, strCreditRedeem, finalBill.RedeemPoints, finalBill.RedeemValue, pdetails.HasHealthCard,
                             RedemPoints, RedemValue, ExternalVisitType, ORCNumber, MigratedvisitNumber, MigratedRequestNumber, dtRedemPoints, lstUnOrderedInv, StatFlag, ClientFlag, finalBill.ItemLevelDiscountTotal, finalBill.DiscountAmount,
                             CollectionID, EmailCC, value, VisitNumber, ClinicCode, pdetails.FirstName, pdetails.MiddleName, pdetails.LastName,
                             pdetails.SpeciesID, CityID, SuburbID, PersonIdentifier, physicianPNo, ReportMode, pdetails.SpeciesName, PatientRegDateTime,
                             OrderedDateTime, HLEnteredby, IsCumulative, ParentOrder, reportClientid, Relevant_Clinical_Information, Placer_Field2, Collectors_Comment, ClientInvoiceNo);
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstBillingdetails);
                        dataReader.Close();
                    }
                        returnStatus = Convert.ToInt32(cmd.Parameters["@pReturnStatus"].Value);
                        PatientRoleID = Convert.ToInt64(cmd.Parameters["@RoleID"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL InsertPatientBilling", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            } 
            return returnStatus;
        }


        public long InsertPatientBilling_Quantum(Patient pdetails, FinalBill finalBill, long ReferingPhysicianID, int ReferingspecialityID,
                                   long SpecialityID, List<PatientDueChart> lstDueChart, int AgeValue, string AgeUnit, long pSpecialityID, string ReferralType,
                                   string Paymentstaus, string pGuID, DataTable dtAmtReceived, List<OrderedInvestigations> lstOrderedInves,
                                   List<TaxBillDetails> lstTaxDetails, out List<BillingDetails> lstBillingdetails,
                                   out int returnStatus, int IsExternelPatient, string WardNo, long EpisodeID, long EpisodeVisitID, long SiteID, string VisitSampleStatus,
                            long EpisodeTrackID, DateTime SamplePickupDate, string ConsignmentNo,
         List<ControlMappingDetails> lstControlSavedValues, string IsEditMode, List<PatientDisPatchDetails> lstDispatchDetails,
         List<VisitClientMapping> lstVisitClientMapping, out long PatientRoleID, long OnBehalfOfClientID, long TodayVisitID, string externalVisitID, string approvalNo, List<OrderedInvestigations> lstUnOrderedInves, string EmailCC, string value,string VisitNumber,string ClinicCode)
        {

            lstBillingdetails = new List<BillingDetails>();
            DataTable dtTax = new DataTable();
            dtTax = UDT_DAL.ConvertToUDTaxBillDetails(lstTaxDetails);
            DataTable dtBillingDetails = UDT_DAL.ConvertToUDTPatientDueChart(lstDueChart);
            DataTable invs = UDT_DAL.ConvertToOrderedInvestigation(lstOrderedInves);
            DataTable ControlSavedValues = UDT_DAL.ConvertToControlMappingDetails(lstControlSavedValues);
            DataTable dtDispatchDetails = UDT_DAL.ConvertToUDTDisPatchMode(lstDispatchDetails);
            DataTable lstUnOrderedInv = UDT_DAL.ConvertToOrderedInvestigation(lstUnOrderedInves);
            string Address1 = "";
            long returnCode = -1;
            PatientRoleID = 0;
            returnStatus = -1;

            Address1 = pdetails.PatientAddress[0].Add1 == null ? "" : pdetails.PatientAddress[0].Add1;

            string Addresss2 = "";
            Addresss2 = pdetails.PatientAddress[0].Add2 == null ? "" : pdetails.PatientAddress[0].Add2;

            string Address3 = "";
            Address3 = pdetails.PatientAddress[0].Add3 == null ? "" : pdetails.PatientAddress[0].Add3;

            string City = "";
            City = pdetails.PatientAddress[0].City == null ? "" : pdetails.PatientAddress[0].City;

            string PhoneNo = "";
            PhoneNo = pdetails.PatientAddress[0].LandLineNumber == null ? "" : pdetails.PatientAddress[0].LandLineNumber;

            string MobileNo = "";
            MobileNo = pdetails.PatientAddress[0].MobileNumber == null ? "" : pdetails.PatientAddress[0].MobileNumber;

            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = Command.pInsertPatientBilling_QuantumCommand(pdetails.PatientID, pdetails.OrgID, finalBill.OrgAddressID, pdetails.CreatedBy, pdetails.Name, pdetails.TITLECode.ToString(),
                                    pdetails.SEX, pdetails.Age, pdetails.PatientNumber, Address1, Addresss2,
                                    Address3, City, PhoneNo, MobileNo, pdetails.MartialStatus, pdetails.DOB, AgeValue, AgeUnit, pdetails.CompressedName,
                                    pdetails.Nationality, pdetails.StateID, pdetails.CountryID, pdetails.PostalCode, pdetails.SmartCardNumber, pdetails.EMail, pdetails.NotifyType, pdetails.URNO, pdetails.URNofId, pdetails.URNTypeId,
                                    pdetails.PatientHistory, pdetails.PatientType, pdetails.PatientStatus, pdetails.VisitPurposeID, pdetails.SecuredCode,
                                    Convert.ToInt32(pdetails.PriorityID), IsExternelPatient, WardNo, EpisodeID, EpisodeVisitID,
                                      pdetails.PatientVisitID,
                                    ReferingPhysicianID, pdetails.ReferingPhysicianName, pdetails.ReferedHospitalID,
                                    pdetails.ReferedHospitalName, ReferingspecialityID, SpecialityID, ReferralType, finalBill.GrossBillValue, finalBill.DiscountAmount, finalBill.DiscountReason,
                                    finalBill.DiscountApprovedBy, finalBill.TaxAmount, finalBill.ServiceCharge, finalBill.RoundOff, finalBill.NetValue, finalBill.Due,
                                    dtTax, dtBillingDetails, finalBill.IsCreditBill, dtAmtReceived, invs, Paymentstaus, pGuID, EpisodeTrackID, SiteID, VisitSampleStatus, SamplePickupDate, ConsignmentNo, ControlSavedValues, pdetails.RegistrationRemarks,
                            out returnStatus, pdetails.ExternalPatientNumber, dtDispatchDetails, finalBill.TATDate,
                            finalBill.EDCess, finalBill.SHEDCess, IsEditMode, pdetails.VistTypeID, pdetails.PStatusID,
                            UDT_DAL.ConvertToUDT_Context(globalContextDetails), UDT_DAL.ConvertToVisitClientMapping(lstVisitClientMapping),
                            out PatientRoleID, OnBehalfOfClientID, TodayVisitID, pdetails.PhleboID, pdetails.LogisticsID, pdetails.RoundNo,
                             pdetails.ExAutoAuthorization, pdetails.ParentPatientID, externalVisitID, approvalNo, pdetails.NewPassword, pdetails.ZoneID, lstUnOrderedInv, EmailCC, value,VisitNumber ,ClinicCode);

                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstBillingdetails);
                        returnStatus = Convert.ToInt32(cmd.Parameters["@pReturnStatus"].Value);
                        PatientRoleID = Convert.ToInt64(cmd.Parameters["@RoleID"].Value);
                    }
                }
                else
                {
                    returnStatus = Convert.ToInt32(cmd.Parameters["@pReturnStatus"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL InsertPatientBilling", ex);
            }
            return returnStatus;
        }


        //Changes of DataSet To DataReader Made By Arivalagan.k
        public long GetClientNamebyClientType(int OrgID, string prefixtext, int ClientTypeID, int CustomerTypeID, out List<ClientMaster> lstInvClientMaster)
        {
            lstInvClientMaster = new List<ClientMaster>();
            IDataReader dataReader = null;
            long returnCode = -1;
            try
            {
                SqlCommand cmd = Command.pGetClientNamebyClientTypeCommand(OrgID, prefixtext, ClientTypeID, CustomerTypeID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvClientMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetClientNamebyClientType in PatientDal", ex);
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
        public long GetMetaName(int OrgID, string prefixtext, int TypeID, out List<MetaType_Common> lstMeta)
        {
            long returnCode = -1;
            lstMeta = new List<MetaType_Common>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetMetaNameCommand(OrgID, prefixtext, TypeID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstMeta);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetMetaName in Patient_DAL.cs", ex);
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



        public long SaveMetaTypeDetails(int OrgID, string Code, string TypeName, long TypeID, string Descrip, string Isactive, string Syslock)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pInsertMetaTypeDetailsCommand(OrgID, Code, TypeName, TypeID, Descrip, Isactive, Syslock, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveMetaTypeDetails in Patient_DAL", ex);

            }
            return returnCode;
        }




        public long SaveMetaValueDetails(int OrgID, int MetaValueID, string Code, string value, long TypeID, string Descrip, string IsActive)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pInsertMetaValueDetailsCommand(OrgID, MetaValueID, Code, value, TypeID, Descrip, IsActive, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveMetaValueDetails in Patient_DAL", ex);

            }
            return returnCode;
        }
        // changed dataset to datareader by Arivalagan.k
        public long GetMetaValuebyName(int OrgID, long Typeid, long ValueID, string prefixtext, string TypeDetails, out List<MetaValue_Common> lstmeta)
        {
            long returnCode = -1;
            lstmeta = new List<MetaValue_Common>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetMetaValuebyNameCommand(OrgID, Typeid, ValueID, prefixtext, TypeDetails, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstmeta);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetMetaValuebyName in Patient_DAL.cs", ex);
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




        public long SaveMetaValueMapping(int OrgID, int MetaValueID, string IdentifyingType, long IdentifyingValue)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pInsertMetaValueMappingCommand(OrgID, MetaValueID, IdentifyingType, IdentifyingValue, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveGroupValueDetails in Patient_DAL", ex);

            }
            return returnCode;
        }

        public long GetIdentifyingValue(int OrgID, string MetaValue, string prefixtext, out List<EmployeeRegMaster> lstERM)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetIdentifyingValueCommand(OrgID, MetaValue, prefixtext, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstERM = new List<EmployeeRegMaster>();
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstERM);
            }
            return returnCode;
        }


        public long GetCheckMetaValueCode(string Code, string Type)
        {
            long lresult = -1;
            SqlCommand cmd = Command.pCheckMetaandValueCodeCommand(Code, Type, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@return", SqlDbType.Int);
            cmd.Parameters["@return"].Direction = ParameterDirection.ReturnValue;

            try
            {

                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    lresult = Convert.ToInt16(cmd.Parameters["@return"].Value.ToString());
                }


            }

            catch (Exception ex)
            {
                CLogger.LogError("Error while Check Group details" + cmd.CommandText, ex);
            }

            return lresult;



        }
        // changed dataset to datareader by Arivalagan.k
        public long GetSMSRecipientsList(int OrgID,string VisitNumber, string Types, string name, string bday, out List<Patient> lstRecipients, int startRowIndex, int pageSize, DateTime FromDate, DateTime ToDate, out int totalRows)
        {
            long returnCode = -1;
            totalRows = -1;
            IDataReader dataReader = null;
            lstRecipients = new List<Patient>();
            try
            {
                SqlCommand objCommand = Command.pGetSMSRecipientsListCommand(OrgID,VisitNumber, Types, name, bday, UDT_DAL.ConvertToUDT_Context(globalContextDetails), startRowIndex, pageSize, FromDate, ToDate, out totalRows);

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstRecipients);
                        dataReader.Close();
                    }
                    totalRows = Convert.ToInt32(objCommand.Parameters["@totalRows"].Value);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading LoadMetaData_New in MetaData_DAL.cs", ex);
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
        public long GetSMSTemplateList(out List<ActionTemplate> lstSMSTemplate)
        {
            long returnCode = -1;
            IDataReader dataReader = null;
            lstSMSTemplate = new List<ActionTemplate>();
            try
            {
                SqlCommand objCommand = Command.pGetSMSTemplateListCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstSMSTemplate);
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading GetSMSTemplateList() in Patient_DAL.cs", ex);
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

        public long updatePatientvisitchanges(PatientVisit PV, int orgid)
        {
            long returncode = -1;

            SqlCommand cmd = Command.pupdatePatientvisitchangesCommand(PV.ParentVisitId, PV.PatientHistory, PV.Remarks, PV.HospitalName, PV.ReferingPhysicianName,
                                                                                                    PV.ReferingPhysicianID, PV.HospitalID, orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returncode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveMetaTypeDetails in Patient_DAL", ex);

            }
            return returncode;
        }
        // changed dataset to datareader by Arivalagan.k
        public long SearchByFilterSendSMS(string fromDate, string ToDate, string type, long investigationid, int groupid, int packageid, string ResultType, string drpmartial,
                                        string age1, string age2, string PatientNo, string Pname, string billno, int orgid, out List<Patient> lstRecipients, int startRowIndex,
                                        int pageSize, string protocolGrpName, string clientName, string refPhyName, string visitNumber, out int totalRows)
        {
            long returnCode = -1;
            totalRows = -1;
            lstRecipients = new List<Patient>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pSearchByPatientFilterSendSMSCommand(fromDate, ToDate, type, investigationid, groupid, packageid, ResultType,
                                                                                     drpmartial, age1, age2, PatientNo, Pname, billno, orgid, startRowIndex, pageSize,
                                                                                     protocolGrpName, clientName, refPhyName, visitNumber,
                                                                                     out  totalRows, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstRecipients);
                        dataReader.Close();
                    }
                    totalRows = Convert.ToInt32(objCommand.Parameters["@totalRows"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while  SearchByFilterSendSMS in Patient_DAL", ex);
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
        public long insertNotificationAudit(int OrgID, int AddressID, long LID, List<NotificationAudit> lstNotify)
        {

            long returnCode = -1;
            try
            {
                DataTable dtnotify = UDT_DAL.ConvertToNotificationAudits(lstNotify);
                SqlCommand cmd = Command.pinsertNotificationAuditCommand(OrgID, AddressID, LID, dtnotify, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dBEngine = new DBEngine(false))
                {
                    returnCode = dBEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while  insertNotificationAudit in Patient_BL", ex);
            }
            return returnCode;

        }
        // changed dataset to datareader by Arivalagan.k
        public long GetPatientVisitInvestigation(long visitid, int orgid, out List<OrderedInvestigations> lstorderedinve)
        {
            long returnCode = -1;
            lstorderedinve = new List<OrderedInvestigations>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetPatientVisitInvestigationCommand(visitid, orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstorderedinve);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while  GetPatientVisitInvestigation in Patient_DAL", ex);
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
        public long saveDispatchInvestigationRestult(DataTable dtvisit, string couriername, string doctorCourier, string emid, long LID, string comments, int orgid, string despatchtype, int despatchmode, string homedate, string doctordate, List<PatientDisPatchDetails> lstPatDispatchDetails, string despatchMobileNo, string despatchMail)
        {
            long returncode = -1;
            try
            {
                SqlCommand cmd = Command.psaveDispatchInvestigationRestultCommand(dtvisit, couriername, doctorCourier, emid, LID, comments, orgid, despatchtype, despatchmode, homedate, doctordate, UDT_DAL.ConvertToUDT_Context(globalContextDetails), UDT_DAL.ConvertToUDTDisPatchDetails(lstPatDispatchDetails), despatchMobileNo, despatchMail);
                //  SqlCommand cmd = Command.psaveDispatchInvestigationRestultCommand(dtvisit, couriername, emid, LID, comments, orgid, despatchtype, despatchmode, despatchdate, UDT_DAL.ConvertToUDT_Context(globalContextDetails), UDT_DAL.ConvertToUDTDisPatchMode(lstDispatchDetails1));

                using (DBEngine dBEngine = new DBEngine(false))
                {
                    returncode = dBEngine.ExecuteNonQuery(cmd);
                }
            }

            catch (Exception ex)
            {

                CLogger.LogError("Error while  saveDispatchInvestigationRestult in Patient_DAL", ex);
            }

            return returncode;

        }
        public long GetApprovedInvestigationPatient(long visitid, string PatientNo, string Name, string fromDate, string ToDate, int OrgID, out List<PatientVisit> lstpatientvisit)
        {
            long returnCode = -1;
            lstpatientvisit = new List<PatientVisit>();
            SqlCommand objCommand = Command.pGetApprovedInvestigationPatientCommand(visitid, PatientNo, Name, fromDate, ToDate, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstpatientvisit);
                }

            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while  GetApprovedInvestigationPatient in Patient_DAL", ex);
            }
            return returnCode;



        }

        public long insertpublishvisitInvestigation(DataTable dtvisit, long LID, int orgid)
        {
            long returncode = -1;
            try
            {
                SqlCommand cmd = Command.pinsertpublishvisitInvestigationCommand(dtvisit, orgid, LID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dBEngine = new DBEngine(false))
                {
                    returncode = dBEngine.ExecuteNonQuery(cmd);
                }
            }

            catch (Exception ex)
            {

                CLogger.LogError("Error while  insertpublishvisitInvestigation in Patient_DAL", ex);
            }

            return returncode;

        }

        public long InsertAmbulanceDetails(List<PatientAmbulancedetails> lstAmbulance)
        {
            long returnCode = -1;

            DataTable dtPatientAmbulance = UDT_DAL.ConvertToPatientAmbulancedetails(lstAmbulance);

            SqlCommand cmd = Command.pInsertambulancedetailsCommand(dtPatientAmbulance, out returnCode, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                }
            }

            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL GetAutoAuthorizeUser", ex);
            }

            return returnCode;
        }

        public long SaveEMRHistory(List<PatientHistory> lstPatientHisPKG, List<PatientHistoryAttribute> lstPatientHisPKGAttributes, long createdBy, long VisitID, long PatientID)
        {
            long returnCode = -1;

            DataTable dtHisPKGType = UDT_DAL.ConvertToHistoryPKGType(lstPatientHisPKG);
            DataTable dtHisPHGAttributes = UDT_DAL.ConvertToHistoryPKGAttribute(lstPatientHisPKGAttributes);
            try
            {
                SqlCommand cmd = Command.pInsertEMRHistoryPKGCommand(dtHisPKGType, dtHisPHGAttributes, createdBy, VisitID, PatientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dBEngine = new DBEngine(false))
                {
                    returnCode = dBEngine.ExecuteNonQuery(cmd);
                }
            }

            catch (Exception ex)
            {

                CLogger.LogError("Error while  pInsertEMRHistoryPKGCommand in Patient_DAL", ex);
            }

            return returnCode;
        }


        public long SaveHistoryQuickBilling(List<InvHistoryAttributes> lstInvHistoryAttributes, int OrgID, long createdBy, long VisitID, long PatientID)
        {
            long returnCode = -1;
            DataTable dtHistory = UDT_DAL.ConvertToInvHistoryAttributes(lstInvHistoryAttributes);

            try
            {
                SqlCommand cmd = Command.pSaveHistoryCommand(dtHistory, OrgID, createdBy, VisitID, PatientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dBEngine = new DBEngine(false))
                {
                    returnCode = dBEngine.ExecuteNonQuery(cmd);
                }
            }

            catch (Exception ex)
            {

                CLogger.LogError("Error while  pSaveHistoryCommand in Patient_DAL", ex);
            }

            return returnCode;
        }



        public long GetPatientMRDDetils(string PatientNo, string PatientName, string DateFrom, string DateTO, int OrgID, string SearchType, string SearchName, string MrdStatus, out List<PatientMRDDetails> lstPatientMRDDetails)
        {
            long returnCode = -1;
            lstPatientMRDDetails = new List<PatientMRDDetails>();
            SqlCommand objCommand = Command.pGetPatientMRDDetilsCommand(PatientNo, PatientName, DateFrom, DateTO, OrgID, SearchType, SearchName, MrdStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientMRDDetails);
                }

            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while GetPatientMRDDetils in Patient_DAL", ex);
            }
            return returnCode;

        }

        public long GetMRDFileDetails(long PatiendID, long PatiendVisitID, long OrgID, out List<PatientMRDDetails> lstPatientMRDDetails)
        {
            long returnCode = -1;
            lstPatientMRDDetails = new List<PatientMRDDetails>();
            SqlCommand objCommand = Command.pGetMRDFileDetailsCommand(PatiendID, PatiendVisitID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientMRDDetails);
                }

            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while GetMRDFileDetails in Patient_DAL", ex);
            }
            return returnCode;

        }
        public long GetMRDType(string liType, string Desc, int OrgID, out List<PatientMRDDetails> lstPatientMRDDetails)
        {
            long returnCode = -1;
            lstPatientMRDDetails = new List<PatientMRDDetails>();
            SqlCommand objCommand = Command.PGetMRDTypeCommand(liType, Desc, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientMRDDetails);
                }

            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while GetMRDFileDetails in Patient_DAL", ex);
            }
            return returnCode;

        }

        public long InsertMRDFileDetails(long PatientID, long PatientVisitID, string CatTypeID, long CatID, long ToPerson, long CreatedBy, string Status)
        {
            long returnCode = -1;

            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                SqlCommand objCommand = Command.pInsertMRDFileDetailsCommand(PatientID, PatientVisitID, CatTypeID, CatID, ToPerson, CreatedBy, Status, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(objCommand);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while InsertMRDFileDetails patient BL ", ex);
            }

            return returnCode;
        }

        public long GetPatientQualification(long patientID, out List<PatientQualification> lstPatientQualification)
        {
            long returnCode = -1;
            SqlCommand objCommand = new SqlCommand();
            objCommand = Command.pGetPatientQualificationCommand(patientID);
            lstPatientQualification = new List<PatientQualification>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }
            if (ds.Tables.Count == 1)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientQualification);
            }

            return returnCode;
        }

        public long GetRelationshipMaster(long OrgID, out List<RelationshipMaster> lstRelationshipMaster)
        {
            long returnCode = -1;
            SqlCommand objCommand = new SqlCommand();
            objCommand = Command.pGetRelationshipMasterCommand(OrgID);
            lstRelationshipMaster = new List<RelationshipMaster>();
            DataSet ds = new DataSet();

            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables.Count == 1)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstRelationshipMaster);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetRelationshipMaster patient DAL ", ex);
            }
            return returnCode;
        }

        public long InsertEmegencyPatient(Patient lstPatient, int SeverityOrgMappingID, List<PatientAmbulancedetails> lstAmbulance, out List<Patient> lstPatientOut)
        {
            long returnCode = -1;
            SqlCommand objCommand = new SqlCommand();
            DataSet ds = new DataSet();
            lstPatientOut = new List<Patient>();

            DataTable dtPatientAmbulance = UDT_DAL.ConvertToPatientAmbulancedetails(lstAmbulance);

            objCommand = Command.pInsertEmegencyPatientCommand(lstPatient.Name, lstPatient.SEX, lstPatient.URNO,
                lstPatient.URNofId, lstPatient.URNTypeId, Convert.ToInt32(lstPatient.Condition), lstPatient.AccompaniedBy, lstPatient.Address, Convert.ToInt64(lstPatient.RelationshipID),
                lstPatient.ContactNo, lstPatient.Comments, lstPatient.OrgID, lstPatient.CreatedBy, lstPatient.AgeValue, lstPatient.AgeUnit,
                SeverityOrgMappingID,
                dtPatientAmbulance, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            objCommand.Parameters.Add("@Return", SqlDbType.Int);
            objCommand.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientOut);
                        returnCode = Convert.ToInt32(objCommand.Parameters["@Return"].Value);
                    }
                }
            }

            catch (Exception ex)
            {
                CLogger.LogError("Error In DAL InsertEmegencyPatient", ex);
            }

            return returnCode;
        }

        public long InsertTemporaryBills(long PatientID, long PatientVisitID, List<PatientDueChart> lstDueChart)
        {
            long returnCode = -1;
            DataTable dtBillingDetails = new DataTable();
            dtBillingDetails = UDT_DAL.ConvertToUDTPatientDueChart(lstDueChart);
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                SqlCommand objCommand = Command.pInsertTemporaryBillsCommand(PatientID, PatientVisitID, dtBillingDetails, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(objCommand);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Insert TemporaryBills patient BL ", ex);
            }

            return returnCode;
        }
        public long GetVisitWiseBillDetails(long VisitID, long PatientID, string Type, out List<DayWiseCollectionReport> lstVisitWiseBillDetails)
        {
            long returnCode = -1;
            SqlCommand objCommand = new SqlCommand();
            objCommand = Command.pGetVisitWiseBillDetailsCommand(VisitID, PatientID, Type, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstVisitWiseBillDetails = new List<DayWiseCollectionReport>();
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstVisitWiseBillDetails);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetRelationshipMaster Patient_DAL.cs", ex);
            }
            return returnCode;
        }
        public long ConvertOPtoIPBill(long PatientID, List<SaveBillingDetails> lstBillingIDDetails, string Type)
        {
            long returnCode = -1;
            DataTable dtBillingDetails = new DataTable();
            dtBillingDetails = UDT_DAL.ConvertToBillingDetailTablesWFT(lstBillingIDDetails);
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                SqlCommand objCommand = Command.pConvertOPtoIPBillCommand(PatientID, dtBillingDetails, UDT_DAL.ConvertToUDT_Context(globalContextDetails), Type);
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(objCommand);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while ConvertOPtoIPBill patient DAL ", ex);
            }

            return returnCode;
        }

        public long GetPatientDispatchDetails(long visitid, long PatientID, int OrgID, out  List<ActionManagerType> lstPatientActiontype, out List<PatientDisPatchDetails> GetPatientDispatchDetails, out List<MetaData> lstpatientmetadataOutput, out List<PatientVisit> lstPatientVisitDespatch)
        {
            long returnCode = -1;
            lstPatientActiontype = new List<ActionManagerType>();
            GetPatientDispatchDetails = new List<PatientDisPatchDetails>();
            lstpatientmetadataOutput = new List<MetaData>();
            lstPatientVisitDespatch = new List<PatientVisit>();

            SqlCommand objCommand = Command.pGetPatientDespatchDetailCommand(visitid, PatientID, OrgID);
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientActiontype);
                }

                if (ds.Tables[1].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out GetPatientDispatchDetails);
                }

                if (ds.Tables[2].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstpatientmetadataOutput);
                }

                if (ds.Tables[3].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstPatientVisitDespatch);
                }

            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while  GetPatientDispatchDetails in Patient_DAL", ex);
            }
            return returnCode;

        }

        public long GetEmergencySeverity(long OrgID, out List<EmergencySeverityOrgMapping> lstEmergencySeverity)
        {
            long returnCode = -1;
            SqlCommand objCommand = new SqlCommand();
            objCommand = Command.pgetEmergencySeverityCommand(OrgID);
            lstEmergencySeverity = new List<EmergencySeverityOrgMapping>();
            DataSet ds = new DataSet();

            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables.Count == 1)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstEmergencySeverity);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetEmergencySeverity patient DAL ", ex);
            }
            return returnCode;
        }

        public long UpdateEmpPatient(long OldPatientID, long NewPatientID)
        {
            long returnCode = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                SqlCommand objCommand = Command.pUpdateEmpPatientCommand(OldPatientID, NewPatientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(objCommand);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Update EMP  patient BL ", ex);
            }

            return returnCode;
        }
        public long SearchBankcheckNo(string BankName, string ChequeorCardNumber, int OrgID, out List<AmountReceivedDetails> lstAmountReceivedDetails)
        {
            long returnCode = -1;
            lstAmountReceivedDetails = new List<AmountReceivedDetails>();
            SqlCommand objCommand = Command.pGetandcheckAmountReceivedDetailsCommand(BankName, ChequeorCardNumber, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            //SqlCommand objCommand = Command.pGetAmountReceivedDetailCommand(BankName, ChequeorCardNumber, OrgID);
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstAmountReceivedDetails);
                }

            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while  GetPatientVisitInvestigation in Patient_DAL", ex);
            }
            return returnCode;


        }
        public long GetAmountApprovalDetails(long AmountApprovalDetailsID, int OrgID, out List<AmountApprovalDetails> lstAmountApprovalDetails)
        {
            long returnCode = -1;
            lstAmountApprovalDetails = new List<AmountApprovalDetails>();

            SqlCommand objCommand = Command.pGetAmountApprovalDetailsCommand(AmountApprovalDetailsID, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstAmountApprovalDetails);
                }


            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while  GetPatientVisitInvestigation in Patient_DAL", ex);
            }
            return returnCode;

        }

        public long GetUpdateAmountApprovalDetails(long AmountApprovalID, string RefType, string comments, string ApprovalStatus, int OrgId, out string GetStatus)
        {
            GetStatus = "";
            long returnCode = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                SqlCommand objCommand = Command.PUpdateAmountApprovalDetailsCommand(AmountApprovalID, RefType, comments, ApprovalStatus, OrgId, out GetStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                //objCommand.Parameters.Add("@retCode", SqlDbType.Int);
                //  objCommand.Parameters["@retCode"].Direction = ParameterDirection.ReturnValue;
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(objCommand);
                    //  returnCode = Convert.ToInt64(objCommand.Parameters["@retCode"].Value);
                    GetStatus = Convert.ToString(objCommand.Parameters["@GetStatus"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetUpdateAmountApprovalDetails   patient BL ", ex);
            }

            return returnCode;
        }

        public long InsertAmountApprovalDetails(AmountApprovalDetails AAD, int OrgId, int RoleId, int CreatedBy, out int BillApprovalID)
        {
            BillApprovalID = -1;
            long returnCode = -1;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                SqlCommand objCommand = Command.PInsertAmountApprovalDetailsCommand(AAD.PatientId, AAD.PatientName, AAD.Age, AAD.VisitPurposeID, AAD.ApprovalType, AAD.PaymentAmount, AAD.BankName, AAD.PaymentCardNo, AAD.ChequeValidDate, AAD.CardHolderName, AAD.Discount, AAD.NetAmount, AAD.FeeDescription, AAD.Comments, OrgId, RoleId, CreatedBy, out  BillApprovalID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                objCommand.Parameters.Add("@retCode", SqlDbType.Int);
                objCommand.Parameters["@retCode"].Direction = ParameterDirection.ReturnValue;
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(objCommand);
                    returnCode = Convert.ToInt64(objCommand.Parameters["@retCode"].Value);
                    BillApprovalID = Convert.ToInt32(objCommand.Parameters["@BillApprovalID"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while InsertAmountApprovalDetails   patient BL ", ex);
            }

            return returnCode;
        }
        //Change dataset to datareader made by Arivalagan.k
        public long GetInvTransferClientMaster(int OrgID, out List<InvClientMaster> lstInvClientMaster)
        {
            long returnCode = -1;
            lstInvClientMaster = new List<InvClientMaster>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand objCommand = Command.pGetInvTransferClientMasterCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));


                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(objCommand);


                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstInvClientMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvTransferClientMaster in Patient_DAL", ex);
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


        public long GetPatientInvestigationDetails(string visitnumber, string patientname, string status, long ClientID, string Fdate, string Tdate, int OrgID, long OrgAddID, long PatientID, string Category, out List<Patient> lstPatient)
        {
            long returnCode = -1;
            lstPatient = new List<Patient>();
            try
            {
                SqlCommand objCommand = Command.pGetPatientInvestigationDetailsCommand(visitnumber, patientname, status, ClientID, Fdate, Tdate, OrgID, OrgAddID, PatientID, Category, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(objCommand, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatient);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while loading Ordered Investigation details", ex);
            }
            return returnCode;
        }

        public long GetPatientListforBookings(string pName, int pOrgID, out List<Patient> lstPatientDetails)
        {
            long returnCode = -1;
            lstPatientDetails = new List<Patient>();
            SqlCommand cmd = Command.pGetPatientListForBookingsCommand(pName, pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetProductList in Inventory_DAL", ex);
            }
            return returnCode;
        }

        public long InsertPatientDiscount(DataTable dtPatientDiscount)
        {
            long returnCode = -1;
            SqlCommand cmd = Command.pInsertPatientDiscountCommand(dtPatientDiscount);
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveMetaTypeDetails in Patient_DAL", ex);

            }
            return returnCode;
        }

        public long SavePATAttributes(List<PatientHistoryAttribute> lstPatientAttributes, long VisitID)
        {
            long returnCode = -1;
            DataTable dtPatAttributes = UDT_DAL.ConvertToHistoryPKGAttribute(lstPatientAttributes);
            try
            {
                SqlCommand cmd = Command.pInsertPatientAttributesCommand(dtPatAttributes, VisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dBEngine = new DBEngine(false))
                {
                    returnCode = dBEngine.ExecuteNonQuery(cmd);
                }
            }

            catch (Exception ex)
            {

                CLogger.LogError("Error while  pInsertPatientAttributesCommand in Patient_DAL", ex);
            }

            return returnCode;
        }
        // changed dataset to datareader by Arivalagan.k
        public long GetPatientTrackingDetails(long OrgID, string Name, string VisitNumber, string BarcodeNumber, string CaseNumber, long VsitID, string PatientNumber, long ClientID,
           out List<PatientVisitDetails> lstPatientVisitDetails, out List<PatientInvSample> lstPatientInvSample,
           out List<PatientInvestigation> lstPatientInvestigation, out List<WorklistMaster> lstWLMaster, out List<Notifications> lstNotifications)
        {
            long returnCode = -1;
            int rsCount = 0;
            lstPatientVisitDetails = new List<PatientVisitDetails>();
            lstPatientInvSample = new List<PatientInvSample>();
            lstPatientInvestigation = new List<PatientInvestigation>();
            lstWLMaster = new List<WorklistMaster>();
            lstNotifications = new List<Notifications>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetPatientTrackingDetailsCommand(OrgID, Name, VisitNumber, BarcodeNumber, CaseNumber, VsitID, PatientNumber, ClientID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstPatientVisitDetails);
                            }
                            else if (rsCount == 1)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstPatientInvSample);
                            }
                            else if (rsCount == 2)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstPatientInvestigation);
                            }
                            else if (rsCount == 3)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstWLMaster);
                            }
                            else if (rsCount == 4)
                            {
                                returnCode = Utilities.ConvertTo(dataReader, out lstNotifications);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientTrackingDetails in Patient_DAL", ex);
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
        public long GetPatientVisitNumber(long PatientId, out String VisitId, out String VisitNumber) 
        {
            long returnCode = -1;
            VisitId = String.Empty;
            VisitNumber = String.Empty;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                SqlCommand objCommand = Command.pGetPatientVisitNumberCommand(PatientId, out VisitId, out VisitNumber, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                objCommand.Parameters.Add("@retCode", SqlDbType.Int);
                objCommand.Parameters["@retCode"].Direction = ParameterDirection.ReturnValue;
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(objCommand);
                    returnCode = Convert.ToInt64(objCommand.Parameters["@retCode"].Value);
                    VisitId = Convert.ToString(objCommand.Parameters["@VisitId"].Value);
                    VisitNumber = Convert.ToString(objCommand.Parameters["@VisitNumber"].Value);
                }
            }
                
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetPatientVisitNumber in Patient_DAL", ex);
            }
            return returnCode;
        }
        public long GetPatientFilePath(long PatientId,String VisitId, out String FilePath)
        {
            long returnCode = -1;
            FilePath = String.Empty;
            try
            {
                Patient_DAL patientDAL = new Patient_DAL(globalContextDetails);
                SqlCommand objCommand = Command.pGetPatientFilePathCommand(PatientId, VisitId, out FilePath, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                objCommand.Parameters.Add("@retCode", SqlDbType.Int);
                objCommand.Parameters["@retCode"].Direction = ParameterDirection.ReturnValue;
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(objCommand);
                    returnCode = Convert.ToInt64(objCommand.Parameters["@retCode"].Value);

                    FilePath= Convert.ToString(objCommand.Parameters["@FilePath"].Value);
                }
            }

            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetFilePath in Patient_DAL", ex);
            }
            return returnCode;
        }
        public long pGetPatientListForNameandID(string pName, string pNo, int pOrgID, out List<Patient> lstPatientDetails)
        {
            long returnCode = -1;
            lstPatientDetails = new List<Patient>();
            SqlCommand cmd = Command.pGetPatientListForNameandIDCommand(pName, pNo, pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetProductList in Inventory_DAL", ex);
            }
            return returnCode;
        }
        //Changes of DataSet To DataReader Made By Arivalagan.k
        public long GetPatientDetailsForInvestigation(long visitid, int orgid, out List<OrderedInvestigations> lstorderedinve)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstorderedinve = new List<OrderedInvestigations>();
            try
            {
                SqlCommand cmd = Command.pGetPatientDetailsForInvestigationCommand(visitid, orgid, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstorderedinve);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while  GetPatientDetailsForInvestigation in Patient_DAL", ex);
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
        //Ab Code For MS Report
        public long SearchAdvanceClientDetails(int orgid, long ClientID, string type, string fromdate, string todate, int GridPageNo, int GridPageSize, out List<AdvanceClientDetails> lstAdvanceClientDetails)
        {
            long returnCode = -1;
            IDataReader dataReader = null;
            lstAdvanceClientDetails = new List<AdvanceClientDetails>();
            try
            {

                SqlCommand cmd = Command.pGetSearchAdvanceClientDetailsCommand(orgid, ClientID, type, fromdate, todate, GridPageNo, GridPageSize);
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstAdvanceClientDetails);
                        dataReader.Close();
                    }

                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL ", ex);
            }
            return returnCode;

        }
        //Ab Code For MS Report
        public long SearchAdvancePatientDetails(int orgid, long ClientID, long type, string fromdate, string todate, int GridPageNo, int GridPageSize, out List<AdvanceClientDetails> lstAdvanceClientDetails)
        {
            long returnCode = -1;
            IDataReader dataReader = null;
            lstAdvanceClientDetails = new List<AdvanceClientDetails>();
            try
            {

                SqlCommand cmd = Command.pGetSearchAdvancePatientDetailsCommand(orgid, ClientID, type, fromdate, todate, GridPageNo, GridPageSize);
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstAdvanceClientDetails);
                        dataReader.Close();
                    }

                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL ", ex);
            }
            return returnCode;

        }
        public long SearchParentClientPatientDetails(int orgid, long ClientID, long type, string fromdate, string todate, int GridPageNo, int GridPageSize, out List<AdvanceClientDetails> lstAdvanceClientDetails)
        {
            long returnCode = -1;
            IDataReader dataReader = null;
            lstAdvanceClientDetails = new List<AdvanceClientDetails>();
            try
            {

                SqlCommand cmd = Command.pGetSearchParentClientPatientDetailsCommand(orgid, ClientID, type, fromdate, todate, GridPageNo, GridPageSize);
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);

                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstAdvanceClientDetails);
                        dataReader.Close();
                    }

                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL ", ex);
            }
            return returnCode;

        }
        public long GetAdvanceAmountDetails(long CollectionID, int orgid, out List<CollectionsMaster> lstCollectionsMaster)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lstCollectionsMaster = new List<CollectionsMaster>();
            try
            {
                SqlCommand cmd = Command.pGetAdvanceAmountDetailsCommand(CollectionID, orgid);
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstCollectionsMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while  GetPatientDetailsForInvestigation in Patient_DAL", ex);
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
        #region For CancelTest
        public long CheckStatusForCancelBill(long pPatientVisitID, long pPatientID, int pOrgID, out string outStatus)
        {
            long returnCode = -1;

            SqlCommand cmd = Command.pCheckStatusForCancelBillCommand(pPatientVisitID, pPatientID, pOrgID, out outStatus, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
                    outStatus = cmd.Parameters["@pOutStatus"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL CheckStatusForCancelBill", ex);
            }
            return returnCode;
        }
        #endregion

        #region For PDF Upload
        public long pBulkInsertTRFDetails(List<TRFfilemanager> TRFfilemanager)
        {
            long returncode = -1;
            DataTable dtTRFfilemanager = UDT_DAL.ConvertToTRFFilecollection(TRFfilemanager);
            SqlCommand objCommand = Command.pBulkInsertTRFDetailsCommand(dtTRFfilemanager, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            objCommand.Parameters.Add("@Return", SqlDbType.Int);
            objCommand.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteNonQuery(objCommand);

                    returncode = Convert.ToInt64(objCommand.Parameters["@Return"].Value);
                }
            }
            catch (Exception excep)
            {
                CLogger.LogError("Error while executing SaveTRFdetails Patient_DAL", excep);
            }
            return returncode;

        }
        #endregion


        public long GetPatientList(string pName, string pNo, string SmartCardNo, int pOrgID, out List<Patient> lstPatientDetails)
        {
            long returnCode = -1;
            lstPatientDetails = new List<Patient>();
            SqlCommand cmd = Command.pGetPatientListCommand(pName, pNo, SmartCardNo, pOrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetProductList in Inventory_DAL", ex);
            }
            return returnCode;
        }
        #region HL7 integration
        public long GetPatientData(string flag, string PatientId, int orgid, out  List<HLMessages> objHlmessage)
        {
            objHlmessage = new List<HLMessages>();
            long returnCode = -1;
            SqlCommand cmd = Command.pGetPatientDataCommand(flag, PatientId, orgid);
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out objHlmessage);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetPatientData patient BL ", ex);
            }
            return returnCode;
        }

        public long insertHLMessage(HLMessages objHLMessage, string parentctrlId, string SendMsgContent, string HL7MSG)
        {
            long returnCode = -1;
            string MsgContent = string.Empty;
            string status = string.Empty;
            if (parentctrlId == "1" && SendMsgContent == "")
            {
                MsgContent = objHLMessage.Msg_Content;
                status = "Processed Successfully";
            }
            else if (parentctrlId == "2" && SendMsgContent == "")
            {
                MsgContent = objHLMessage.Msg_Content;
                status = "Process Failure";
            }
            else if (SendMsgContent == "")
            {
                MsgContent = objHLMessage.Msg_Content;
                status = "Recieved Successfully";
            }

            else
            {
                MsgContent = SendMsgContent;
                status = "Sent Successfully";
            }
            SqlCommand cmd = Command.pinsertHLMessageCommand(objHLMessage.MsgControlId, parentctrlId, objHLMessage.MsgType, objHLMessage.Sending_App, objHLMessage.Sending_Facility,
                                                            objHLMessage.Rec_App, objHLMessage.Rec_Facility, objHLMessage.TransferDatetime, MsgContent, 
                                                            status, objHLMessage.ErrorList, objHLMessage.PatientVisitID, objHLMessage.PatientIdentifier,
                                                            HL7MSG, string.IsNullOrEmpty(objHLMessage.ControlType) ? "" : objHLMessage.ControlType,
                                                            string.IsNullOrEmpty(objHLMessage.Placer_Order_Number) ? "" : objHLMessage.Placer_Order_Number,
                                                            objHLMessage.Futuredate, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveGroupValueDetails in Patient_DAL", ex);

            }
            return returnCode;
        }
        public long GetOrgDetails(string OrgName, string OrgAddressName, out  List<Organization> objorgnaization)
        {
            objorgnaization = new List<Organization>();
            long returnCode = -1;
            SqlCommand cmd = Command.pGetOrgDetailsListCommand(OrgName, OrgAddressName);
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out objorgnaization);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetOrgDetails patient BL ", ex);
            }
            return returnCode;
        }

		public long GetOrgDet(int OrgID,int OrgAddressID, out  List<Organization> objorgnaization)
        {
            objorgnaization = new List<Organization>();
            long returnCode = -1;
            SqlCommand cmd = Command.pGetOrgDetListCommand(OrgID, OrgAddressID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out objorgnaization);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetOrgDetails patient BL ", ex);
            }
            return returnCode;
        }
        public long InsertQuotationbillingDetails(Patient pdetails, List<OrderedInvestigations> lstinvestigation, DataTable dtAmountReceivedDet, List<PatientDueChart> lstBillingAmountDetails,long QuotationID,out long VisitID)
        {

            //lstBillingdetails = new List<BillingDetails>();
            IDataReader dataReader = null;
            DataTable dtTax = new DataTable();
            DataTable invs = UDT_DAL.ConvertToOrderedInvestigation(lstinvestigation);
            DataTable BillingamountDetails = UDT_DAL.ConvertToUDTPatientDueChart(lstBillingAmountDetails);
            long returnCode = -1;
            VisitID = 0;
            
            try
            {
                 

                SqlCommand cmd = Command.pInsertQuotationbillingDetailsCommand(pdetails.Name, pdetails.Add1, pdetails.City, pdetails.CountryID, pdetails.StateID, pdetails.OrgID, pdetails.SecuredCode, invs, dtAmountReceivedDet,BillingamountDetails,QuotationID,out VisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));


                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    VisitID = Convert.ToInt64(cmd.Parameters["@pPatientVisitID"].Value);

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL InsertQuotationbillingDetails", ex);
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

        #endregion 
		
		//-------------------------------------Capture patient history start---------------------------------//
        public long SaveCapturePatientHistory(List<CapturePatientHistory> lstHistoryAttributes, int OrgID, long VisitID)
        {
            long retruncode = -1;

            DataTable dtpatienthistory = UDT_DAL.ConvertToCapturePatientHistory(lstHistoryAttributes);
            SqlCommand cmdCapturePatientHistory = Command.pSaveCapturePatientHistoryCommand(OrgID, VisitID, dtpatienthistory, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    retruncode = dbEngine.ExecuteNonQuery(cmdCapturePatientHistory);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while saving UpdateResultValues. Query: " + cmdCapturePatientHistory.CommandText, ex);
            }
            return retruncode;
        }

        public long LoadAndCheckCapturePatientHistory(int Orgid, long InvestigationID, string ActionType, out List<CapturePatientHistory> lstHistoryAttributes)
        {
            long returnCode = -1;
            lstHistoryAttributes = new List<CapturePatientHistory>();
            SqlCommand cmd = Command.pLoadAndCheckCapturePatientHistoryCommand(Orgid, InvestigationID, ActionType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstHistoryAttributes);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing LoadHistoryDetails in Patient_DAL", ex);
            }
            return returnCode;
        }
        public long GetEditPatientHistory(int OrgID, long VisitID, out List<CapturePatientHistory> lsPatientHistory)
        {
            IDataReader dataReader = null;
            long returnCode = -1;
            lsPatientHistory = new List<CapturePatientHistory>();
            try
            {
                SqlCommand cmd = Command.pGetEditPatientHistoryCommand(OrgID, VisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lsPatientHistory);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                CLogger.LogError("Error while  GetEditPatientHistory in Patient_DAL", ex);
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


        //------------------------------Update Patient History------------------------------//
        public long UpdatePatientHistory(List<CapturePatientHistory> lstupdateHistory)
        {
            long returnCode = -1;
            DataTable dtupatehistory = UDT_DAL.ConvertToCapturePatientHistory(lstupdateHistory);
            SqlCommand cmd = Command.pUpdatePatientHistoryCommand(dtupatehistory, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmd);
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdatePatientHistory in Patient_DAL", ex);
            }
            return returnCode;
        }

        //-------------------------------------Capture patient history end---------------------------------//
        public long InsertQuotationPatientInvSample(List<PatientInvSample> lstPatientInvSample, List<PatientInvSampleMapping> lstPatientInvSampleMapping,long QuotationID,long ClientID,long VisitID)
        {

            //lstBillingdetails = new List<BillingDetails>();
            IDataReader dataReader = null;
            DataTable dtTax = new DataTable();
            DataTable invs = UDT_DAL.ConvertToPatientInvSampleCollected(lstPatientInvSample);
            DataTable PatientSampleMapping = UDT_DAL.ConvertToPatientInvSampleMapping(lstPatientInvSampleMapping);
            //DataTable BillingamountDetails = UDT_DAL.ConvertToUDTPatientDueChart(lstBillingAmountDetails);
            long returnCode = -1;
            try
            {


                SqlCommand cmd = Command.pInsertQuotationPatientInvSampleCommand(invs, PatientSampleMapping,QuotationID,ClientID,VisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));


                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                    
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL InsertQuotationPatientInvSample", ex);
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

        public long InsertPatientBilling_Integration(Patient pdetails, FinalBill finalBill, long ReferingPhysicianID, int ReferingspecialityID,
                                    long SpecialityID, List<PatientDueChart> lstDueChart, int AgeValue, string AgeUnit, long pSpecialityID, string ReferralType,
                                    string Paymentstaus, string pGuID, DataTable dtAmtReceived, List<OrderedInvestigations> lstOrderedInves,
                                    List<TaxBillDetails> lstTaxDetails, out List<BillingDetails> lstBillingdetails,
                                    out int returnStatus, int IsExternelPatient, string WardNo, long EpisodeID, long EpisodeVisitID, long SiteID, string VisitSampleStatus,
                             long EpisodeTrackID, DateTime SamplePickupDate, string ConsignmentNo,
          List<ControlMappingDetails> lstControlSavedValues, string IsEditMode, List<PatientDisPatchDetails> lstDispatchDetails,
          List<VisitClientMapping> lstVisitClientMapping, out long PatientRoleID, long OnBehalfOfClientID, long TodayVisitID, string externalVisitID, string approvalNo, String IsCopay, List<PatientDiscount> lstPatientDiscount, string strMyCardActiveDays, string strMemebershipcardType, string strHealthCardType, string strOTP, string strStatus, long strMembershipCardMappingID, string strCreditRedeem, long RedeemPatientid, long RedeemVisitid, long RedeemOrgId,
           decimal RedemPoints, decimal RedemValue, List<PatientRedemDetails> lstPatientRedemDetails, List<OrderedInvestigations> lstUnOrderedInves, string StatFlag, string ClientFlag, long CollectionID, string EmailCC, string VisitNumber, string ClinicCode, string value)
        {

            lstBillingdetails = new List<BillingDetails>();
            IDataReader dataReader = null;
            DataTable dtTax = new DataTable();
            dtTax = UDT_DAL.ConvertToUDTaxBillDetails(lstTaxDetails);
            DataTable dtBillingDetails = UDT_DAL.ConvertToUDTPatientDueChart(lstDueChart);
            DataTable invs = UDT_DAL.ConvertToOrderedInvestigation(lstOrderedInves);
            DataTable ControlSavedValues = UDT_DAL.ConvertToControlMappingDetails(lstControlSavedValues);
            DataTable dtDispatchDetails = UDT_DAL.ConvertToUDTDisPatchMode(lstDispatchDetails);
            DataTable dtPatientDiscount = UDT_DAL.ConvertToUDTPatientDiscount(lstPatientDiscount);

            DataTable dtRedemPoints = UDT_DAL.ConvertToPatientRedemDetails(lstPatientRedemDetails);
            DataTable lstUnOrderedInv = UDT_DAL.ConvertToOrderedInvestigation(lstUnOrderedInves);
            string Address1 = "";
            long returnCode = -1;
            PatientRoleID = 0;
            returnStatus = -1;

            Address1 = pdetails.PatientAddress[0].Add1 == null ? "" : pdetails.PatientAddress[0].Add1;

            string Addresss2 = "";
            Addresss2 = pdetails.PatientAddress[0].Add2 == null ? "" : pdetails.PatientAddress[0].Add2;

            string Address3 = "";
            Address3 = pdetails.PatientAddress[0].Add3 == null ? "" : pdetails.PatientAddress[0].Add3;

            string City = "";
            City = pdetails.PatientAddress[0].City == null ? "" : pdetails.PatientAddress[0].City;

            string PhoneNo = "";
            PhoneNo = pdetails.PatientAddress[0].LandLineNumber == null ? "" : pdetails.PatientAddress[0].LandLineNumber;

            string MobileNo = "";
            MobileNo = pdetails.PatientAddress[0].MobileNumber == null ? "" : pdetails.PatientAddress[0].MobileNumber;
            try
            {
                SqlCommand cmd = Command.pInsertPatientBillingintegrationCommand(pdetails.PatientID, pdetails.OrgID, finalBill.OrgAddressID, pdetails.CreatedBy, pdetails.Name, pdetails.TITLECode.ToString(),
                                    pdetails.SEX, pdetails.Age, pdetails.PatientNumber, Address1, Addresss2,
                                    Address3, City, PhoneNo, MobileNo, pdetails.MartialStatus, pdetails.DOB, AgeValue, AgeUnit, pdetails.CompressedName,
                                   pdetails.Nationality, pdetails.StateID, pdetails.CountryID, pdetails.PostalCode, pdetails.SmartCardNumber, pdetails.EMail, pdetails.NotifyType, pdetails.URNO, pdetails.URNofId, pdetails.URNTypeId,
                                    pdetails.PatientHistory, pdetails.PatientType, pdetails.PatientStatus, pdetails.VisitPurposeID, pdetails.SecuredCode,
                                    Convert.ToInt32(pdetails.PriorityID), IsExternelPatient, WardNo, EpisodeID, EpisodeVisitID,
                                      pdetails.PatientVisitID,
                                    ReferingPhysicianID, pdetails.ReferingPhysicianName, pdetails.ReferedHospitalID,
                                    pdetails.ReferedHospitalName, ReferingspecialityID, SpecialityID, ReferralType, finalBill.GrossBillValue, finalBill.DiscountAmount, finalBill.DiscountReason,
                                    finalBill.DiscountApprovedBy, finalBill.TaxAmount, finalBill.ServiceCharge, finalBill.RoundOff, finalBill.NetValue, finalBill.Due,
                                    dtTax, dtBillingDetails, finalBill.IsCreditBill, dtAmtReceived, invs, Paymentstaus, pGuID, EpisodeTrackID, SiteID, VisitSampleStatus, SamplePickupDate, ConsignmentNo, ControlSavedValues, pdetails.RegistrationRemarks,
                            out returnStatus, pdetails.ExternalPatientNumber, dtDispatchDetails, finalBill.TATDate,
                            finalBill.EDCess, finalBill.SHEDCess, IsEditMode, pdetails.VistTypeID, pdetails.PStatusID,
                            UDT_DAL.ConvertToUDT_Context(globalContextDetails), UDT_DAL.ConvertToVisitClientMapping(lstVisitClientMapping),
                            out PatientRoleID, OnBehalfOfClientID, TodayVisitID, pdetails.PhleboID, pdetails.LogisticsID, pdetails.RoundNo,
                             pdetails.ExAutoAuthorization, pdetails.ParentPatientID, externalVisitID, approvalNo, pdetails.NewPassword, pdetails.ZoneID, pdetails.UnknownFlag, finalBill.DiscountID, IsCopay, dtPatientDiscount, finalBill.IsFoc, strMyCardActiveDays, strMemebershipcardType, strHealthCardType, strOTP, strStatus, strMembershipCardMappingID, strCreditRedeem, finalBill.RedeemPoints, finalBill.RedeemValue, pdetails.HasHealthCard,
                             RedemPoints, RedemValue, dtRedemPoints, lstUnOrderedInv, StatFlag, ClientFlag, finalBill.ItemLevelDiscountTotal, finalBill.DiscountAmount, CollectionID, EmailCC, value, VisitNumber, ClinicCode);

                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstBillingdetails);
                        dataReader.Close();
                    }


                    returnStatus = Convert.ToInt32(cmd.Parameters["@pReturnStatus"].Value);
                    PatientRoleID = Convert.ToInt64(cmd.Parameters["@RoleID"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL InsertPatientBilling", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returnStatus;
        }


        public long UpdateWardDetails(String ExternalVisitId, String PatientNumber, String AssignedWardDetails, String PriorWardDetails, String MsgType)
        {
            long returnStatus = -1;
            SqlCommand cmd = Command.pUpdateWardDetailsCommand(ExternalVisitId, PatientNumber, AssignedWardDetails, PriorWardDetails, MsgType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnStatus = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing UpdateWardDetails in Patient_DAL", ex);
            }
            return returnStatus;
        }
        public long PatientmergeHl7(String PatientNumber, String PatientName, String PriorPatientId, String MsgType)
        {
            long returnstatus = -1;
            SqlCommand cmd = Command.pPatientmergeHl7Command(PatientNumber, PatientName, PriorPatientId, MsgType, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbbEngine = new DBEngine())
                {
                    returnstatus = dbbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception Ex)
            {
                CLogger.LogError("Error While Executing PatientMerge in Patient_DAL", Ex);
            }
            return returnstatus;
        }
		public long UpdateCancelBilling(String Orderid, String ObjStatus, string Person_Identifier, string physicianPNo)
        {
            long returnCancelStatus = -1;
            SqlCommand cmd = Command.pUpdateCancelBillingCommand(Orderid, ObjStatus, Person_Identifier, physicianPNo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@ret", SqlDbType.Int);
            cmd.Parameters["@ret"].Direction = ParameterDirection.ReturnValue;
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    returnCancelStatus = Convert.ToInt64(cmd.Parameters["@ret"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while CancelBilling Patient_DAL", ex);
            }
            return returnCancelStatus;
        }
        public long InsertHistoSpecimenDetails(long OrgID, long OrgAddressID, List<HistoSpecimenDetails> lstspec)
        {
            long returnCode = -1;
            DataTable dtSpec = new DataTable();
            dtSpec = UDT_DAL.ConvertToUDTHistoSpecimenDetails(lstspec);
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = Command.pInsertHistoSpecimenDetailsCommand(OrgID, OrgAddressID, dtSpec, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);

                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while InsertHistoSpecimenDetails ", ex);
            }
            return returnCode;
        }
public long GetHL7Segments(int OrgID, out List<HL7Segments> lstGuid)
 {
     long returnCode = -1;
     SqlCommand objCommand = Command.pGetHL7SegmentsCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
     lstGuid = new List<HL7Segments>();
     DataSet ds = new DataSet();
     using (DBEngine dbEngine = new DBEngine())
     {
         dbEngine.ExecuteDataSet(objCommand, out ds);
     }
     if (ds.Tables.Count > 0)
     {
         returnCode = Utilities.ConvertTo(ds.Tables[0], out lstGuid);
     }
     return returnCode;
 }

       
		public long InsertHLMessageDetails(HLMessages objHLMessage, string parentctrlId, string SendMsgContent, string HL7MSG, List<HLMessageHeaderDetails> lstHLMessageHeaderDetails, List<HLMessageOBRDetails> lstHLMessageOBRDetails, List<HLMessageORCDetails> lstHLMessageORCDetails, List<HLMessagePatientIDDetails> lstHLMessagePatientIDDetails, List<HLMessageErrorDetails> lstHLMessageErrorDetails,List<HLMessages> lstHLMessages)
        {
            long returnCode = -1;
            string MsgContent = string.Empty;
            string status = string.Empty;
            DataTable dtHLMessages = UDT_DAL.ConvertToUDTHLMessages(lstHLMessages);
            DataTable dtHLMessageHeaderDetails = UDT_DAL.ConvertToUDTHLMessageHeaderDetails(lstHLMessageHeaderDetails);
            DataTable dtHLMessageOBRDetails = UDT_DAL.ConvertToUDTHLMessageOBRDetails(lstHLMessageOBRDetails);
            DataTable dtHLMessageORCDetails = UDT_DAL.ConvertToUDTHLMessageORCDetails(lstHLMessageORCDetails);
            DataTable dtHLMessagePatientIDDetails = UDT_DAL.ConvertToUDTHLMessagePatientIDDetails(lstHLMessagePatientIDDetails);
            DataTable dlHLMessageErrorDetails = UDT_DAL.ConvertToUDTHLMessageErrorDetails(lstHLMessageErrorDetails);
            if (parentctrlId == "1" && SendMsgContent == "")
            {
                MsgContent = objHLMessage.Msg_Content;
                status = "Processed Successfully";
            }
            else if (parentctrlId == "2" && SendMsgContent == "")
            {
                MsgContent = objHLMessage.Msg_Content;
                status = "Process Failure";
            }
            else if (SendMsgContent == "")
            {
                MsgContent = objHLMessage.Msg_Content;
                status = "Recieved Successfully";
            }
            else
            {
            }
            {
                MsgContent = SendMsgContent;
                status = "Sent Successfully";
            }
            SqlCommand cmd = Command.pInsertHLMessageDetailsCommand(objHLMessage.MsgControlId, parentctrlId, objHLMessage.MsgType, objHLMessage.Sending_App, objHLMessage.Sending_Facility,
                                                            objHLMessage.Rec_App, objHLMessage.Rec_Facility, objHLMessage.TransferDatetime, MsgContent,
                                                            status, objHLMessage.ErrorList, objHLMessage.PatientVisitID, objHLMessage.PatientIdentifier,
                                                            HL7MSG, string.IsNullOrEmpty(objHLMessage.ControlType) ? "" : objHLMessage.ControlType,
                                                            string.IsNullOrEmpty(objHLMessage.Placer_Order_Number) ? "" : objHLMessage.Placer_Order_Number,
                                                            objHLMessage.Futuredate, dtHLMessageHeaderDetails, dtHLMessageOBRDetails, dtHLMessageORCDetails, dtHLMessagePatientIDDetails,dlHLMessageErrorDetails,dtHLMessages, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveGroupValueDetails in Patient_DAL", ex);
            }
            return returnCode;
        }
       public long GetHLMessageMandatoryDetails(int pOrgID, int LocationId, out List<HLMessageMandatoryDetails> lstHLMessageMandatoryDetails)
        {
            long lresult = -1;
            lstHLMessageMandatoryDetails = new List<HLMessageMandatoryDetails>();
            SqlCommand cmd = Command.pGetHLMessageMandatoryDetailsCommand(pOrgID, LocationId,  UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstHLMessageMandatoryDetails);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetHLMessageMandatoryDetails in Patient_DAL" + cmd.CommandText, ex);
            }
            return lresult;
        }
       public long GetOtherLocationFiledet(out List<HLMessageOBRDetails> lstHLMessageOBRDetails)
       {
           long lresult = -1;
           lstHLMessageOBRDetails = new List<HLMessageOBRDetails>();
           SqlCommand cmd = Command.pGetOtherLocationFileDetailsCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
           DataSet ds = new DataSet();
           try
           {
               using (DBEngine dbEngine = new DBEngine())
               {
                   dbEngine.ExecuteDataSet(cmd, out ds);
               }
               if (ds.Tables.Count > 0)
               {
                   lresult = Utilities.ConvertTo(ds.Tables[0], out lstHLMessageOBRDetails);
               }
           }
           catch (Exception ex)
           {
               CLogger.LogError("Error while executing GetOtherLocationFiledet in Patient_DAL" + cmd.CommandText, ex);
           }
           return lresult;
       }
       public long GetSecBarCodeDetForSamples(long patientVisitId, int OrgID, out List<PatientInvSample> lstPatientInvSample)
       {
           long returnCode = -1;
           SqlCommand objCommand = Command.pGetSecBarCodeDetForSamplesCommand(patientVisitId, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
           lstPatientInvSample = new List<PatientInvSample>();
           DataSet ds = new DataSet();
           using (DBEngine dbEngine = new DBEngine())
           {
               dbEngine.ExecuteDataSet(objCommand, out ds);
           }
           if (ds.Tables.Count > 0)
           {
               returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientInvSample);
           }
           return returnCode;
       }
 public long GetGuidForSameVisit(string ExVisitNumber, int OrgID, out List<OrderedInvestigations> lstGuid)
 {
     long returnCode = -1;
     SqlCommand objCommand = Command.pGetGuidForSameVisitCommand(ExVisitNumber, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
     lstGuid = new List<OrderedInvestigations>();
     DataSet ds = new DataSet();
     using (DBEngine dbEngine = new DBEngine())
     {
         dbEngine.ExecuteDataSet(objCommand, out ds);
     }
     if (ds.Tables.Count > 0)
     {
         returnCode = Utilities.ConvertTo(ds.Tables[0], out lstGuid);
     }
     return returnCode;
 }
	   public long UpdateOtherLocationFileDetails(List<HLMessages> lstHLMessages,List<HLMessageErrorDetails> lstHLErrorDetails)
 {
     long returnCode = -1;
     DataTable dtHLMessages = UDT_DAL.ConvertToUDTHLMessages(lstHLMessages);
     DataTable dtHLErrorDetails = UDT_DAL.ConvertToUDTHLMessageErrorDetails(lstHLErrorDetails);
     SqlCommand cmd = Command.pUpdateOtherLocationFileDetailsCommand(dtHLMessages, dtHLErrorDetails, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
     try
     {
         using (DBEngine dbEngine = new DBEngine())
         {
             returnCode = dbEngine.ExecuteNonQuery(cmd);
         }
     }
     catch (Exception ex)
     {
         CLogger.LogError("Error while executing UpdateOtherLocationFileDetails in Patient_DAL", ex);
     }
     return returnCode;
 }
       public long InsertUnRegisteredUserDetails(string ExVisitNumber, int OrgID)
       {
           long returnCancelStatus = -1;
           SqlCommand cmd = Command.PinsertScanInDetailsCommand(ExVisitNumber, OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
           cmd.Parameters.Add("@ret", SqlDbType.Int);
           cmd.Parameters["@ret"].Direction = ParameterDirection.ReturnValue;

           try
           {
               using (DBEngine dbEngine = new DBEngine())
               {
                   dbEngine.ExecuteNonQuery(cmd);
                   returnCancelStatus = Convert.ToInt64(cmd.Parameters["@ret"].Value);
               }
           }
           catch (Exception ex)
           {
               CLogger.LogError("Error while CancelBilling Patient_DAL", ex);

           }
           return returnCancelStatus;
       }
       public long GetClientName(int OrgID, string prefixtext, int ClientTypeID, out List<ClientMaster> lstInvClientMaster)
       {
           lstInvClientMaster = new List<ClientMaster>();
           IDataReader dataReader = null;
           long returnCode = -1;
           try
           {
               SqlCommand cmd = Command.pGetClientNameCommand(OrgID, prefixtext, ClientTypeID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
               using (DBEngine dbEngine = new DBEngine())
               {
                   dataReader = dbEngine.ExecuteReader(cmd);
                   if (dataReader != null)
                   {
                       returnCode = Utilities.ConvertTo(dataReader, out lstInvClientMaster);
                       dataReader.Close();
                   }
               }
           }
           catch (Exception ex)
           {
               CLogger.LogError("Error while executing GetClientName in Patient_Dal", ex);
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
   //Alex

        public long ActiveInactiveInvestigationDrugBrand(int Id, out long DrugID)
        {
            long returnCode = -1;
            SqlCommand cmdInvDrugBrand = new SqlCommand();
            cmdInvDrugBrand = Command.pActiveInactiveInvestigationDrugBrandCommand(Id, out DrugID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
           
            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmdInvDrugBrand);
                    DrugID = Convert.ToInt32(cmdInvDrugBrand.Parameters["@DrugID"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing ActiveInactiveInvestigationDrugBrand DAL", ex);
            }
            return returnCode;
        }

        public long GetDrugBrandMasterHistory(long pID, out List<InvestigationDrugBrand> lstDrugMaster)
        {
            long returnCode = -1;
            lstDrugMaster = new List<InvestigationDrugBrand>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetInvestigationDrugBrandHistoryCommand(pID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstDrugMaster);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting GetDrugBrandMasterHistory", ex);
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
		
		        public long pEditPatientBillingByID(int pOrgId, long pfinalBillID, decimal pGrossValue, decimal pDiscount, decimal pNetValue, decimal pAmountReceived, List<PatientDueChart> lstPatientdue)
        {
            long returnCode = -1;
            SqlCommand cmdInvDrugBrand = new SqlCommand();
            DataTable dtBillingDetails = UDT_DAL.ConvertToUDTPatientDueChart(lstPatientdue);
            cmdInvDrugBrand = Command.pEditPatientBillingByIDCommand(pOrgId, pfinalBillID, pGrossValue, pDiscount, pNetValue,
                pAmountReceived, dtBillingDetails);

            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    returnCode = dbEngine.ExecuteNonQuery(cmdInvDrugBrand);                    
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while Executing ActiveInactiveInvestigationDrugBrand DAL", ex);
            }
            return returnCode;
        }

        public long GetBillingDetailsForEdit(long finalBillID, string pBillNo, int pOrgId, out List<FinalBill> lstFinalbill, out List<PatientDueChart> lstBillingDetails)
        {
            long returnCode = -1;
            IDataReader dataReader = null;
            lstFinalbill = new List<FinalBill>();
            lstBillingDetails=new List<PatientDueChart>();
            try
            {
                SqlCommand cmd = Command.pGetBillingdetailsForEditCommand(finalBillID, pBillNo, pOrgId, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstFinalbill);
                    }
                    dataReader.NextResult();
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstBillingDetails);

                    }
                    dataReader.Close();

                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL CheckBilltobeCancelled", ex);
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


        public long GetHistoSpecimenDetails(long OrgID, long PatientVisitID, long TestID, string type,out List<HistoSpecimenDetails> lHistoSpecimendetails)
        {
           
            long returnCode = -1;
            lHistoSpecimendetails = new List<HistoSpecimenDetails>();
            IDataReader dataReader = null;
            try
            {
                SqlCommand cmd = Command.pGetHistoSpecimenDetailsCommand(OrgID, PatientVisitID, TestID, type, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lHistoSpecimendetails);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while getting GetHistoSpecimenDetails DAL", ex);
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
public long GetInvestigationOrgChange(string ExternalVisitID, int OrgID, string FromDate, string toDate, string PatientName, string patientnumber, string pVisitNumber, string Param1, string Param2, string Param3, out List<PatientVisit> lstpatientVisit, out List<OrderedInvestigations> lstOrderinvestication)
        {
            IDataReader dataReader = null;
            long returncode = -1;
            lstpatientVisit = new List<PatientVisit>();
            lstOrderinvestication = new List<OrderedInvestigations>();
            int rsCount = 0;
            try
            {
                SqlCommand cmd = Command.pGetInvesticationForCancellationCommand(ExternalVisitID, OrgID, FromDate, toDate, PatientName, patientnumber, pVisitNumber, Param1, Param2, Param3, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        do
                        {
                            if (rsCount == 0)
                            {
                                returncode = Utilities.ConvertTo(dataReader, out lstpatientVisit);
                            }
                            else if (rsCount == 1)
                            {
                                returncode = Utilities.ConvertTo(dataReader, out lstOrderinvestication);
                            }
                            rsCount = rsCount + 1;
                        } while (dataReader.NextResult());
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing GetInvestigationOrgChange in Patient_DAL", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returncode;

        }
		
		  public long GetReprintRDLSize(int OrgID, out List<ReprintMergeRDLSize> lstReprintSize)
        {
            long returnCode = -1;
            SqlCommand objCommand = new SqlCommand();
            objCommand = Command.PgetReprintMergeRDLSizeCommand(OrgID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            lstReprintSize = new List<ReprintMergeRDLSize>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }

            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstReprintSize);
            }

            return returnCode;
        }
		public long GetVisitNumberbyPID(string Patientnumber, long PageID, out List<PatientVisit> lstVisitNumbers)
        {
            long returnCode = -1;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            lstVisitNumbers = new List<PatientVisit>();
            SqlCommand cmd = Command.pgetVisitnumbersbyPIDCommand(Patientnumber, PageID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    dt = ds.Tables[0];
                    returnCode = Utilities.ConvertTo(dt, out lstVisitNumbers);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing pgetVisitnumbersbyPID Patient DAL", ex);
            }
            return returnCode;
        }
        public long PatientTestHistoryValues(int OrgID, long PatientVisitID, out List<ClientAttributesKeyFields> lstFieldDetails)
        {
            long returnCode = -1;
            lstFieldDetails = new List<ClientAttributesKeyFields>();
            SqlCommand cmd = Command.pGetPatientTestHistoryCommand(OrgID,PatientVisitID, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(cmd, out ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstFieldDetails);
            }
            return returnCode;
        }
		 public long CheckPatientConsentformAvailability(long VisitID, out string CT, out string MRI)
        {
            long returncode = -1; 
            SqlCommand cmd = Command.pCheckPatientConsentFormCommand(VisitID, out CT, out MRI, UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            using (DBEngine dbEngine = new DBEngine())
            {
                  dbEngine.ExecuteTransactionalNonQuery(cmd);
                  CT = Convert.ToString(cmd.Parameters["@CT"].Value);
                  MRI = Convert.ToString(cmd.Parameters["@MRI"].Value); 
            }
            return returncode;
        }
		
		  public long InsertPatientBillingFranchisee(Patient pdetails, FinalBill finalBill, long ReferingPhysicianID, int ReferingspecialityID,
                                     long SpecialityID, List<PatientDueChart> lstDueChart, int AgeValue, string AgeUnit, long pSpecialityID, string ReferralType,
                                     string Paymentstaus, string pGuID, DataTable dtAmtReceived, List<OrderedInvestigations> lstOrderedInves,
                                     List<TaxBillDetails> lstTaxDetails, out List<BillingDetails> lstBillingdetails,
                                     out int returnStatus, int IsExternelPatient, string WardNo, long EpisodeID, long EpisodeVisitID, long SiteID, string VisitSampleStatus,
                              long EpisodeTrackID, DateTime SamplePickupDate, string ConsignmentNo,
           List<ControlMappingDetails> lstControlSavedValues, string IsEditMode, List<PatientDisPatchDetails> lstDispatchDetails,
           List<VisitClientMapping> lstVisitClientMapping, out long PatientRoleID, long OnBehalfOfClientID, long TodayVisitID, string externalVisitID, string approvalNo, String IsCopay, List<PatientDiscount> lstPatientDiscount, string strMyCardActiveDays, string strMemebershipcardType, string strHealthCardType, string strOTP, string strStatus, long strMembershipCardMappingID, string strCreditRedeem, long RedeemPatientid, long RedeemVisitid, long RedeemOrgId,
            decimal RedemPoints, decimal RedemValue, List<PatientRedemDetails> lstPatientRedemDetails, List<OrderedInvestigations> lstUnOrderedInves, string StatFlag, string ClientFlag, long CollectionID, string EmailCC, string VisitNumber, string ClinicCode, string value, List<VisitTemplate> visittemplate,
            List<PatientVisitLanguage> lstpatlanguage, string DueReason, string DueAuthorizer , string HealthHubId)
        {

            lstBillingdetails = new List<BillingDetails>();
            IDataReader dataReader = null;
            DataTable dtTax = new DataTable();
            dtTax = UDT_DAL.ConvertToUDTaxBillDetails(lstTaxDetails);
            DataTable dtBillingDetails = UDT_DAL.ConvertToUDTPatientDueChart(lstDueChart);
            DataTable invs = UDT_DAL.ConvertToOrderedInvestigation(lstOrderedInves);
            DataTable ControlSavedValues = UDT_DAL.ConvertToControlMappingDetails(lstControlSavedValues);
            DataTable dtDispatchDetails = UDT_DAL.ConvertToUDTDisPatchMode(lstDispatchDetails);
            DataTable dtPatientDiscount = UDT_DAL.ConvertToUDTPatientDiscount(lstPatientDiscount);

            DataTable dtRedemPoints = UDT_DAL.ConvertToPatientRedemDetails(lstPatientRedemDetails);
            DataTable lstUnOrderedInv = UDT_DAL.ConvertToOrderedInvestigation(lstUnOrderedInves);
            DataTable visittemplates = UDT_DAL.ConvertToVisittemplate(visittemplate);
            DataTable PatientLanguage = UDT_DAL.ConvertToUDTPatientVisitLanguage(lstpatlanguage);
            string Address1 = "";
            long returnCode = -1;
            PatientRoleID = 0;
            returnStatus = -1;

            Address1 = pdetails.PatientAddress[0].Add1 == null ? "" : pdetails.PatientAddress[0].Add1;

            string Addresss2 = "";
            Addresss2 = pdetails.PatientAddress[0].Add2 == null ? "" : pdetails.PatientAddress[0].Add2;

            string Address3 = "";
            Address3 = pdetails.PatientAddress[0].Add3 == null ? "" : pdetails.PatientAddress[0].Add3;

            string City = "";
            City = pdetails.PatientAddress[0].City == null ? "" : pdetails.PatientAddress[0].City;

            string PhoneNo = "";
            PhoneNo = pdetails.PatientAddress[0].LandLineNumber == null ? "" : pdetails.PatientAddress[0].LandLineNumber;

            string MobileNo = "";
            MobileNo = pdetails.PatientAddress[0].MobileNumber == null ? "" : pdetails.PatientAddress[0].MobileNumber;
            try
            {
                SqlCommand cmd = Command.pInsertPatientBilling_FranchiseeCommand(pdetails.PatientID, pdetails.OrgID, finalBill.OrgAddressID, pdetails.CreatedBy, pdetails.Name, pdetails.TITLECode.ToString(),
                                    pdetails.SEX, pdetails.Age, pdetails.PatientNumber, Address1, Addresss2,
                                    Address3, City, PhoneNo, MobileNo, pdetails.MartialStatus, pdetails.DOB, AgeValue, AgeUnit, pdetails.CompressedName,
                                   pdetails.Nationality, pdetails.StateID, pdetails.CountryID, pdetails.PostalCode, pdetails.SmartCardNumber, pdetails.EMail, pdetails.NotifyType, pdetails.URNO, pdetails.URNofId, pdetails.URNTypeId,
                                    pdetails.PatientHistory, pdetails.PatientType, pdetails.PatientStatus, pdetails.VisitPurposeID, pdetails.SecuredCode,
                                    Convert.ToInt32(pdetails.PriorityID), IsExternelPatient, WardNo, EpisodeID, EpisodeVisitID,
                                      pdetails.PatientVisitID,
                                    ReferingPhysicianID, pdetails.ReferingPhysicianName, pdetails.ReferedHospitalID,
                                    pdetails.ReferedHospitalName, ReferingspecialityID, SpecialityID, ReferralType, finalBill.GrossBillValue, finalBill.DiscountAmount, finalBill.DiscountReason,
                                    finalBill.DiscountApprovedBy, finalBill.TaxAmount, finalBill.ServiceCharge, finalBill.RoundOff, finalBill.NetValue, finalBill.Due,
                                    dtTax, dtBillingDetails, finalBill.IsCreditBill, dtAmtReceived, invs, Paymentstaus, pGuID, EpisodeTrackID, SiteID, VisitSampleStatus, SamplePickupDate, ConsignmentNo, ControlSavedValues, pdetails.RegistrationRemarks,
                            out returnStatus, pdetails.ExternalPatientNumber, dtDispatchDetails, finalBill.TATDate,
                            finalBill.EDCess, finalBill.SHEDCess, IsEditMode, pdetails.VistTypeID, pdetails.PStatusID,
                            UDT_DAL.ConvertToUDT_Context(globalContextDetails), UDT_DAL.ConvertToVisitClientMapping(lstVisitClientMapping),
                            out PatientRoleID, OnBehalfOfClientID, TodayVisitID, pdetails.PhleboID, pdetails.LogisticsID, pdetails.RoundNo,
                             pdetails.ExAutoAuthorization, pdetails.ParentPatientID, externalVisitID, approvalNo, pdetails.NewPassword, pdetails.ZoneID, pdetails.UnknownFlag, finalBill.DiscountID, IsCopay, dtPatientDiscount, finalBill.IsFoc, strMyCardActiveDays, strMemebershipcardType, strHealthCardType, strOTP, strStatus, strMembershipCardMappingID, strCreditRedeem, finalBill.RedeemPoints, finalBill.RedeemValue, pdetails.HasHealthCard,
                             RedemPoints, RedemValue, dtRedemPoints, lstUnOrderedInv, StatFlag, ClientFlag, finalBill.ItemLevelDiscountTotal, finalBill.DiscountAmount, CollectionID, EmailCC, value, VisitNumber, ClinicCode, visittemplates, PatientLanguage, DueReason, DueAuthorizer ,HealthHubId);

                using (DBEngine dbEngine = new DBEngine(false))
                {
                    dataReader = dbEngine.ExecuteReader(cmd);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstBillingdetails);
                        dataReader.Close();
                    }


                    returnStatus = Convert.ToInt32(cmd.Parameters["@pReturnStatus"].Value);
                    PatientRoleID = Convert.ToInt64(cmd.Parameters["@RoleID"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in Billing DAL InsertPatientBilling", ex);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return returnStatus;
        }
        public long GetPassportNo(string PassportNo, out List<URNTypes> lstURN)
        {
            long returnCode = -1;
            lstURN = new List<URNTypes>();
            try
            {
                SqlCommand objCommand = Command.pGetPassportDuplicateCommand(PassportNo, UDT_DAL.ConvertToUDT_Context(globalContextDetails));


                using (DBEngine dbEngine = new DBEngine())
                {
                    IDataReader dataReader = dbEngine.ExecuteReader(objCommand);
                    if (dataReader != null)
                    {
                        returnCode = Utilities.ConvertTo(dataReader, out lstURN);
                        dataReader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("Error while executing GetPassportNo Patient_DAL", e);
            }
            return returnCode;
        }
    }
}







