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
    public class Neonatal_DAL
    {
         ContextDetails globalContextDetails;
        public Neonatal_DAL()
        {

        }
        public Neonatal_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetDeliveryNotesData(int OrgID, out List<SurgeryType> lstSurgeryType, out List<AnesthesiaType> lstAnesthesiaType, out List<DeliveryTypeMaster> lstDeliveryTypeMaster, out List<Physician> lstDeliveringObstretician, out List<Physician> lstNeonatologist, out List<FetalPresentations> lstFetalPresentations)
        {

            long returnCode = -1;
            lstAnesthesiaType = new List<AnesthesiaType>();
            lstSurgeryType = new List<SurgeryType>();
            lstDeliveryTypeMaster = new List<DeliveryTypeMaster>();
            lstFetalPresentations = new List<FetalPresentations>();
            lstDeliveringObstretician = new List<Physician>();
            lstNeonatologist = new List<Physician>();

            SqlCommand cmd = Command.pGetDeliveryNotesDataCommand(OrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {

                using (DBEngine dbEngine = new DBEngine())
                {

                    dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {

                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstSurgeryType);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {

                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstAnesthesiaType);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {

                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstDeliveryTypeMaster);
                }
                if (ds.Tables[3].Rows.Count > 0)
                {

                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstDeliveringObstretician);
                }

                if (ds.Tables[4].Rows.Count > 0)
                {

                    returnCode = Utilities.ConvertTo(ds.Tables[4], out lstNeonatologist);
                }
                if (ds.Tables[5].Rows.Count > 0)
                {

                    returnCode = Utilities.ConvertTo(ds.Tables[5], out lstFetalPresentations);
                }


            }

            catch (Exception ex)
            {

                CLogger.LogError("Error while executing Load GetDeliveryNotesData in Neonatal_DAL", ex);
            }

            return returnCode;
        }
        public long SaveLabourAndDeliveryNotes(int OrgID, long patientVisitID, long patientID, long LID,string pType,int ChildCount, List<LabourAndDeliveryNotes> lstLabourAndDeliveryNotes, List<PatientComplication> lstPatientComplication, List<BirthInstructions> lstBirthInstructions, List<NewBornDetails> lstNewBornDetails, string needIPNumber)
        {
            long returncode = -1;

            DataTable dsLAD = UDT_DAL.ConvertToLabourAndDeliveryNotes(lstLabourAndDeliveryNotes);
            DataTable dsPC = UDT_DAL.ConvertToPatientComplication(lstPatientComplication);
            DataTable dsPI = UDT_DAL.ConvertToBirthInstructions(lstBirthInstructions);

            SqlCommand cmdLabourAndDelivery = new SqlCommand();
            cmdLabourAndDelivery = Command.pSaveLabourAndDeliveryNotesCommand(OrgID, patientVisitID, patientID, LID,pType,ChildCount, dsLAD, dsPC, dsPI,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            cmdLabourAndDelivery.Parameters.Add("@Return", SqlDbType.Int);
            cmdLabourAndDelivery.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteTransactionalNonQuery(cmdLabourAndDelivery);
                        returncode = Convert.ToInt64(cmdLabourAndDelivery.Parameters["@Return"].Value);
                        if (returncode > 0)
                        {
                            long NewBornRegID = returncode;
                            foreach (NewBornDetails NBD in lstNewBornDetails)
                            {
                                #region Get NewBornDetails
                                System.Data.DataTable dtNewBornDetail = new DataTable();
                                DataColumn dbCol1 = new DataColumn("BirthRegID");
                                DataColumn dbCol2 = new DataColumn("PatientID");
                                DataColumn dbCol3 = new DataColumn("VisitID");
                                DataColumn dbCol4 = new DataColumn("ParentVisitID");
                                DataColumn dbCol5 = new DataColumn("OrgID");
                                DataColumn dbCol6 = new DataColumn("Name");
                                DataColumn dbCol7 = new DataColumn("Sex");
                                DataColumn dbCol8 = new DataColumn("IdentiFicationMarks1");
                                DataColumn dbCol9 = new DataColumn("IdentiFicationMarks2");
                                DataColumn dbCol10 = new DataColumn("DOB");
                                DataColumn dbCol11 = new DataColumn("BirthWeight");
                                DataColumn dbCol12 = new DataColumn("PresentationID");
                                DataColumn dbCol13 = new DataColumn("HeadCIRC");
                                DataColumn dbCol14 = new DataColumn("CHL");
                                DataColumn dbCol15 = new DataColumn("Status");
                                DataColumn dbCol16 = new DataColumn("APGARScore");
                                DataColumn dbCol17 = new DataColumn("NewBornDetailID");
                                

                                dtNewBornDetail.Columns.Add(dbCol1);
                                dtNewBornDetail.Columns.Add(dbCol2);
                                dtNewBornDetail.Columns.Add(dbCol3);
                                dtNewBornDetail.Columns.Add(dbCol4);
                                dtNewBornDetail.Columns.Add(dbCol5);
                                dtNewBornDetail.Columns.Add(dbCol6);
                                dtNewBornDetail.Columns.Add(dbCol7);
                                dtNewBornDetail.Columns.Add(dbCol8);
                                dtNewBornDetail.Columns.Add(dbCol9);
                                dtNewBornDetail.Columns.Add(dbCol10);
                                dtNewBornDetail.Columns.Add(dbCol11);
                                dtNewBornDetail.Columns.Add(dbCol12);
                                dtNewBornDetail.Columns.Add(dbCol13);
                                dtNewBornDetail.Columns.Add(dbCol14);
                                dtNewBornDetail.Columns.Add(dbCol15);
                                dtNewBornDetail.Columns.Add(dbCol16);
                                dtNewBornDetail.Columns.Add(dbCol17);

                                DataRow dr;


                                dr = dtNewBornDetail.NewRow();
                                dr["BirthRegID"] = NewBornRegID;
                                dr["PatientID"] = NBD.PatientID;
                                dr["VisitID"] = NBD.VisitID;
                                dr["ParentVisitID"] = NBD.ParentVisitID;
                                dr["OrgID"] = NBD.OrgID;
                                dr["Name"] = NBD.Name;
                                string compName = Utilities.getCompressedName(NBD.Name.Trim());
                                string Pname = NBD.Name;
                                dr["Sex"] = NBD.Sex;
                                dr["IdentiFicationMarks1"] = NBD.IdentiFicationMarks1;
                                dr["IdentiFicationMarks2"] = NBD.IdentiFicationMarks2;
                                dr["DOB"] = NBD.DOB;
                                DateTime pDOB = NBD.DOB;
                                dr["BirthWeight"] = NBD.BirthWeight;
                                dr["PresentationID"] = NBD.PresentationID;
                                dr["HeadCIRC"] = NBD.HeadCIRC;
                                dr["CHL"] = NBD.CHL;
                                dr["Status"] = NBD.Status;
                                dr["APGARScore"] = NBD.APGARScore;
                                dr["NewBornDetailID"] = NBD.NewBornDetailID;
                                dtNewBornDetail.Rows.Add(dr);
                                SqlCommand cmdSaveNewBorn = Command.pSaveNewbornDetailsCommand(OrgID, patientVisitID, patientID, LID, compName, Pname, pDOB, NewBornRegID, pType, dtNewBornDetail, needIPNumber,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                                cmdSaveNewBorn.Parameters.Add("@Return", SqlDbType.Int);
                                cmdSaveNewBorn.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
                                dbEngine.ExecuteTransactionalNonQuery(cmdSaveNewBorn);
                                returncode = Convert.ToInt64(cmdSaveNewBorn.Parameters["@Return"].Value);
                                #endregion
                                if (returncode != 0)
                                {
                                    return 0;
                                    tranScope.Dispose();
                                }
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
                    }
                }
                catch (Exception ex)
                {
                    CLogger.LogError("Exception while saving SaveLabourAndDeliveryNotes data.", ex);
                    tranScope.Dispose();
                }

            }




            return returncode;
        }

        public long GetDeliveryNotesDataForUpdate(long patientVisitID, out List<LabourAndDeliveryNotes> lstLabourAndDeliveryNotes, out List<PatientComplication> lstPatientComplication, out List<BirthInstructions> lstBirthInstructions, out List<NewBornDetails> lstNewBornDetails)
        {

            long returnCode = -1;
            lstLabourAndDeliveryNotes = new List<LabourAndDeliveryNotes>();
            lstPatientComplication = new List<PatientComplication>();
            lstBirthInstructions = new List<BirthInstructions>();
            lstNewBornDetails = new List<NewBornDetails>();

            SqlCommand cmd = Command.pGetDeliveryNotesDataForUpdateCommand(patientVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {

                using (DBEngine dbEngine = new DBEngine())
                {

                    dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {

                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstLabourAndDeliveryNotes);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {

                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstPatientComplication);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {

                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstBirthInstructions);
                }
                if (ds.Tables[3].Rows.Count > 0)
                {

                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstNewBornDetails);
                }

            }

            catch (Exception ex)
            {

                CLogger.LogError("Error while executing Load GetDeliveryNotesData in Neonatal_DAL", ex);
            }

            return returnCode;
        }

        public long CheckIsNewBornBaby(int OrgID, long patientVisitID, out long pBornVisitID)
        {

            long returnCode = -1;
        
            SqlCommand cmd = Command.pCheckIsNewBornBabyCommand(OrgID, patientVisitID, out @pBornVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {

                using (DBEngine dbEngine = new DBEngine())
                {

                    dbEngine.ExecuteDataSet(cmd, out ds);
                    @pBornVisitID =Convert.ToInt64( cmd.Parameters["@pBornVisitID"].Value);
                }

              

            }

            catch (Exception ex)
            {

                CLogger.LogError("Error while executing Load CheckIsNewBornBaby in Neonatal_DAL", ex);
            }

            return returnCode;
        }

        public long GetSystemicExaminatiom(out List<Examination> lstExamination)
        {

            long returnCode = -1;

            lstExamination = new List<Examination>();
            SqlCommand cmd = Command.pGetSystemicExaminationCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {

                using (DBEngine dbEngine = new DBEngine())
                {

                    dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {

                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstExamination);
                }
            

            }

            catch (Exception ex)
            {

                CLogger.LogError("Error while executing Load GetDeliveryNotesData in Neonatal_DAL", ex);
            }

            return returnCode;
        }


        public long GetNeonatalNotes(int OrgID, long patientVisitID, long patientID, long LID, string BrfHistory, List<BackgroundProblem> lstRiskFactor, List<PatientVitals> lstPatientVitals, List<PatientExamination> lstPatientExamination, List<PatientAdvice> lstPatientAdvice, List<DrugDetails> lstDrugDetails, List<PatientBabyVaccination> lstPBV, List<NeonatalNotes> lstNeonatalNotes)
        {
            long returncode = -1;

            return returncode;
        }


        public long SaveNeonatalNotes(int OrgID, long patientVisitID, long patientID, long LID, string BrfHistory, 
            List<BackgroundProblem> lstRiskFactor,
            List<PatientVitals> lstPatientVitals,
            List<PatientExamination> lstPatientExamination,
            List<PatientAdvice> lstPatientAdvice,
            List<DrugDetails> lstDrugDetails, 
            List<PatientBabyVaccination> lstPBV, 
            NeonatalNotes objNeonatalNotes, string pType)
        {

            DataTable dtRiskFactor = UDT_DAL.ConvertToBackgroundProblem(lstRiskFactor);
            DataTable dtPatientVitals = UDT_DAL.ConvertToPatientVitals(lstPatientVitals);
            DataTable dtPatientExamination = UDT_DAL.ConvertToHIDECType(lstPatientExamination);
            DataTable dtPatientAdvice = UDT_DAL.ConvertTouddInsertGeneralAdvice(lstPatientAdvice);
            DataTable dtDrugDetails = UDT_DAL.ConvertToPrescriptionType(lstDrugDetails);
            DataTable dtPBV = UDT_DAL.ConvertToImmunization(lstPBV);       


            long returnCode = -1;
            SqlCommand cmd = new SqlCommand();
            cmd = Command.pSaveNeonatalNotesCommand(OrgID, patientVisitID, patientID, LID, BrfHistory, dtRiskFactor, dtPatientVitals, dtPatientExamination, dtPatientAdvice, dtDrugDetails, dtPBV, objNeonatalNotes.RespiratorySupport, objNeonatalNotes.FluidsandNutrition, objNeonatalNotes.GeneralCourse,objNeonatalNotes.Plans, objNeonatalNotes.ImmunizationSchedule, objNeonatalNotes.NextReviewAfter, pType,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (DBEngine dbEngine = new DBEngine(false))
            {
                dbEngine.ExecuteTransactionalNonQuery(cmd);
                returnCode = Convert.ToInt64(cmd.Parameters["@Return"].Value);

            }

            return returnCode;
        }

        public long GetNeonatalNotesForUpdate(long patientVisitID, out List<PatientHistoryExt> lstPatientHistoryExt, out List<BackgroundProblem> lstRiskFactor, out List<PatientVitals> lstPatientVitals, out List<PatientExamination> lstPatientExamination, out List<PatientAdvice> lstPatientAdvice, out List<DrugDetails> lstDrugDetails, out List<PatientBabyVaccination> lstPBV, out List<NeonatalNotes> lstNeonatalNotes)
        {

            long returnCode = -1;
            lstPatientHistoryExt = new List<PatientHistoryExt>();
            lstRiskFactor = new List<BackgroundProblem>();
            lstPatientVitals = new List<PatientVitals>();
            lstPatientExamination = new List<PatientExamination>();
            lstPatientAdvice = new List<PatientAdvice>();
            lstDrugDetails = new List<DrugDetails>();
            lstPBV = new List<PatientBabyVaccination>();
            lstNeonatalNotes = new List<NeonatalNotes>();

            SqlCommand cmd = Command.pGetNeonatalNotesCommand(patientVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {

                using (DBEngine dbEngine = new DBEngine())
                {

                    dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {

                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientHistoryExt);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {

                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstRiskFactor);
                }
                if (ds.Tables[2].Rows.Count > 0)
                {

                    returnCode = Utilities.ConvertTo(ds.Tables[2], out lstPatientVitals);
                }
                if (ds.Tables[3].Rows.Count > 0)
                {

                    returnCode = Utilities.ConvertTo(ds.Tables[3], out lstPatientExamination);
                }
                if (ds.Tables[4].Rows.Count > 0)
                {

                    returnCode = Utilities.ConvertTo(ds.Tables[4], out lstPatientAdvice);
                }
                if (ds.Tables[5].Rows.Count > 0)
                {

                    returnCode = Utilities.ConvertTo(ds.Tables[5], out lstDrugDetails);
                }
                if (ds.Tables[6].Rows.Count > 0)
                {

                    returnCode = Utilities.ConvertTo(ds.Tables[6], out lstPBV);
                }
                if (ds.Tables[7].Rows.Count > 0)
                {

                    returnCode = Utilities.ConvertTo(ds.Tables[7], out lstNeonatalNotes);
                }

            }

            catch (Exception ex)
            {

                CLogger.LogError("Error while executing Load GetNeonatalNotesForUpdate in Neonatal_DAL", ex);
            }

            return returnCode;
        }

        public long GetNewBornDetails(long patientVisitID, int pOrgID, out List<LabourAndDeliveryNotes> lstLabourAndDeliveryNotes, out List<NewBornDetails> lstNewBornDetails)
        {

            long returnCode = -1;

            lstLabourAndDeliveryNotes = new List<LabourAndDeliveryNotes>();
            lstNewBornDetails = new List<NewBornDetails>();

            SqlCommand cmd = Command.pGetNewbornDetailCommand(patientVisitID,pOrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {

                using (DBEngine dbEngine = new DBEngine())
                {

                    dbEngine.ExecuteDataSet(cmd, out ds);
                }

                if (ds.Tables[0].Rows.Count > 0)
                {

                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstLabourAndDeliveryNotes);
                }
                if (ds.Tables[1].Rows.Count > 0)
                {

                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstNewBornDetails);
                }
               

            }

            catch (Exception ex)
            {

                CLogger.LogError("Error while executing Load GetNewBornDetails in Neonatal_DAL", ex);
            }

            return returnCode;
        }
        public long GetInpatientDetails(long patientVisitID, out List<Patient> lstPatient, out List<InPatientAdmissionDetails> lstIPAdmissionDetails)
        {

            long returnCode = -1;

            lstPatient = new List<Patient>();
            lstIPAdmissionDetails = new List<InPatientAdmissionDetails>();

            SqlCommand cmd = Command.pGetInpatientDetailsCommand(patientVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();
            try
            {

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

                    returnCode = Utilities.ConvertTo(ds.Tables[1], out lstIPAdmissionDetails);
                }


            }

            catch (Exception ex)
            {

                CLogger.LogError("Error while executing Load GetInpatientDetails in Neonatal_DAL", ex);
            }

            return returnCode;
        }
    
    
    
    
    }
    
}
