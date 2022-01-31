using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using Attune.Solution.DAL;
using Attune.Podium.BusinessEntities;
using System.Collections;
using Attune.Podium.Common;


namespace Attune.Solution.BusinessComponent
{
    public class Dialysis_BL
    {
        ContextDetails globalContextDetails;
        public Dialysis_BL()
        {

        }
        public Dialysis_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        #region Get Methods

        public long GetDialysisRecord(int orgID, long visitID, out int HDNo, out long patientID, out decimal prevWeight, out DialysisRecord dialysisRecord)
        {
            long returnCode = -1;
            HDNo = -1;
            patientID = 0;
            prevWeight = -1;
            dialysisRecord = new DialysisRecord();

            try
            {
                Dialysis_DAL diaDAL = new Dialysis_DAL(globalContextDetails);
                returnCode = diaDAL.GetDialysisRecord(orgID, visitID, out HDNo,out patientID, out prevWeight, out dialysisRecord);

                if (returnCode != 0)
                {
                    HDNo = -1;
                }
                else
                {
                    HDNo = HDNo + 1;
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError( "Error in Dialysis_BL.GetDialysisRecord :" , ex);
            }

            return returnCode;
        }

        public long GetDialysisVitals(int iOrgID, out List<VitalsUOMJoin> lstVitalsUOMJoin)
        {
            long returnCode = -1;
            lstVitalsUOMJoin = new List<VitalsUOMJoin>();

            try
            {
                Dialysis_DAL diaDAL = new Dialysis_DAL(globalContextDetails);
                returnCode = diaDAL.GetDialysisVitals(iOrgID, out lstVitalsUOMJoin);
            }
            catch (Exception ex)
            {
                CLogger.LogError( "Error in Dialysis_BL.GetDialysisVitals :", ex);
            }

            return returnCode;
        }

        public long GetDialysisOnFlowVitals(int iOrgID, out List<VitalsUOMJoin> lstVitalsUOMJoin)
        {
            long returnCode = -1;
            lstVitalsUOMJoin = new List<VitalsUOMJoin>();

            try
            {
                Dialysis_DAL diaDAL = new Dialysis_DAL(globalContextDetails);
                returnCode = diaDAL.GetDialysisOnFlowVitals(iOrgID, out lstVitalsUOMJoin);
            }
            catch (Exception ex)
            {
                CLogger.LogError( "Error in Dialysis_BL.GetDialysisVitals :" , ex);
            }

            return returnCode;
        }

        public long GetDialysisVitalsForUpd(int iOrgID, long PatientVisitID, out List<VitalsUOMJoin> lstVitalsUOMJoin)
        {
            long returnCode = -1;
            lstVitalsUOMJoin = new List<VitalsUOMJoin>();

            try
            {
                Dialysis_DAL diaDAL = new Dialysis_DAL(globalContextDetails);
                returnCode = diaDAL.GetDialysisVitalsForUpd(iOrgID, PatientVisitID, out lstVitalsUOMJoin);
            }
            catch (Exception ex)
            {
                CLogger.LogError( "Error in Dialysis_BL.GetDialysisVitalsForUpd :", ex);
            }

            return returnCode;
        }

        public long GetDialysisCaseSheet(long visitID, int OrgID, out DialysisRecord dr, 
                out List<VitalsUOMJoin> vitalsUOMJoin, out List<Complication> parentComplications,
                out List<Complication> complications,out long patientID,out string PatientName, out string Age, out decimal AmountReceived)
        {
            long returnCode = -1;
            PatientName = string.Empty;
            Age = "0";
            AmountReceived = 0;
            dr = new DialysisRecord();
            vitalsUOMJoin = new List<VitalsUOMJoin>();
            parentComplications = new List<Complication>();
            complications = new List<Complication>();
            patientID = 0;

            try
            {
                Dialysis_DAL ddl = new Dialysis_DAL(globalContextDetails);
                returnCode = ddl.GetDialysisCaseSheet(visitID, OrgID, out dr, out vitalsUOMJoin, 
                        out parentComplications, out complications, out PatientName, out Age,out patientID, out AmountReceived);
            }
            catch (Exception ex)
            {
                CLogger.LogError( "Error in Dialysis_BL.GetDialysisCaseSheet :" , ex);
            }

            return returnCode;
        }

        public long GetDialysisAccess(out List<DialysisAccess> lstAccess)
        {
            long returnCode = -1;
            lstAccess = new List<DialysisAccess>();

            try
            {
                Dialysis_DAL diaDAL = new Dialysis_DAL(globalContextDetails);
                returnCode = diaDAL.GetDialysisAccess(out lstAccess);
            }
            catch (Exception ex)
            {
                CLogger.LogError( "Error in Dialysis_BL.GetDialysisAccess :", ex);
            }

            return returnCode;
        }

        #endregion

        #region Save Methods

        public long SaveDialysisDetails(DialysisDetails dd, List<PatientHistory> hst, List<PatientPrescription> pres)
        {
            long returnCode = -1;

            
            try
            {
                Dialysis_DAL diaDAL = new Dialysis_DAL(globalContextDetails);
                returnCode = diaDAL.SaveDialysisDetails(dd, hst, pres);
            }
            catch (Exception ex)
            {
                CLogger.LogError( "Error in Dialysis_BL.SaveDialysisDetails :" , ex);
            }

            return returnCode;
        }



        public long SavePrescription(List<PatientPrescription> pres)
        {
            long returnCode = -1;
            try
            {
                Dialysis_DAL diaDAL = new Dialysis_DAL(globalContextDetails);

                returnCode = diaDAL.SaveDialysisPrescription(pres);
            }
            catch (Exception ex)
            {
                CLogger.LogError( "Error in Dialysis_BL.SavePrescription :", ex);
            }

            return returnCode;
        }


        public long SavePreDialysisDetails(long pOrgID, DialysisRecord dr, List<DialysisPatientVitals> lstDPV)
        {
            long returnCode = -1;

            

            try
            {
                Dialysis_DAL diaDAL = new Dialysis_DAL(globalContextDetails);
                returnCode = diaDAL.SavePreDialysisDetails(pOrgID, dr, lstDPV);
            }
            catch (Exception ex)
            {
                CLogger.LogError( "Error in Dialysis_BL.SavePreDialysisDetails :" , ex);
            }

            return returnCode;
        }

        public long SavePostDialysisDetails(long pOrgID, DialysisRecord dr,
            List<DialysisPatientVitals> lstPreDialysisVitals,
            List<DialysisPatientVitals> lstPostDialysisVitals,
            List<PatientComplication> lstComplications)
        {
            long returnCode = -1;

           
            try
            {
                Dialysis_DAL diaDal = new Dialysis_DAL(globalContextDetails);
                returnCode = diaDal.SavePostDialysisDetails(pOrgID, dr, lstPreDialysisVitals, lstPostDialysisVitals, lstComplications);
            }
            catch( Exception ex)
            {
                CLogger.LogError( "Error in Dialysis_BL.SavePostDialysisDetails :" , ex);
            }
            return returnCode;
        }

        public long SaveDialysisOnFlow(DialysisOnFlow dialysisOnFlow, 
            List<DialysisOnFlowDetails> lstDialysisOnFlow)
        {
            long returnCode = -1;

            
            try
            {
                Dialysis_DAL diaDAL = new Dialysis_DAL(globalContextDetails);
                returnCode = diaDAL.SaveDialysisOnFlow(dialysisOnFlow, lstDialysisOnFlow);
            }
            catch (Exception ex)
            {
                CLogger.LogError( "Error in Dialysis_BL.SavePreDialysisDetails :" , ex);
            }

            return returnCode;
        }

        #endregion

        #region Get DisplayText Parameters

        public long GetHTParamsForPreDialysisTask(long PatientVisitID, out long PatientID, out Hashtable taskParams)
        {
            long returnCode = -1;

            string PatientName = string.Empty;
            PatientID = 0;

            taskParams = new Hashtable();
            Dialysis_DAL dialysisDal = new Dialysis_DAL(globalContextDetails);
            dialysisDal.GetHTParamsForPreDialysisTask(PatientVisitID, out PatientID, out PatientName);

            taskParams.Add("PatientName", PatientName);

            return returnCode;
        }

        public long GetHTParamsForOnFlowTask(long PatientVisitID, out long PatientID, out string PatientName, out string MachineName, out string LastTestTime)
        {
            long returnCode = -1;

            PatientName = string.Empty;
            PatientID = 0;
            MachineName = string.Empty;
            LastTestTime = string.Empty;

            
            Dialysis_DAL dialysisDal = new Dialysis_DAL(globalContextDetails);

            try
            {
                returnCode = dialysisDal.GetHTParamsForOnFlowTask(PatientVisitID, out PatientID, out PatientName, out MachineName, out LastTestTime);
                //Add parantheses to Machine name 
                if (MachineName != string.Empty)
                    MachineName = "(" + MachineName + ")";
            }
            catch (Exception ex)
            {
                CLogger.LogError( "Error forming hashtable in GetHTParamsForOnFlowTask(BL) :" , ex);
            }

            return returnCode;
        }

        public long GetHTParamsForPostDialysisTask(long PatientVisitID, out long PatientID, out string patientName)
        {
            long returnCode = -1;

            string PatientName = string.Empty;
            PatientID = 0;
                       
            Dialysis_DAL dialysisDal = new Dialysis_DAL(globalContextDetails);
            dialysisDal.GetHTParamsForPostDialysisTask(PatientVisitID, out PatientID, out patientName);

            return returnCode;
        }

        #endregion

        #region Conversion Methods for Bulk Insert


        /// <summary>
        /// Converts a given PatientHistory List to a DataTable
        /// </summary>
        /// <param name="hists"></param>
        /// <returns></returns>
      

        /// <summary>
        /// Converts a given PatientComplication List to a DataTable
        /// </summary>
        /// <param name="hists"></param>
        /// <returns></returns>
        

        #endregion


        public long GetDialysisOnflowCount(long PatientVisitId, out int outStatus)
        {
            long returncode = -1;
            outStatus = 0;
            try
            {
                returncode = new Dialysis_DAL(globalContextDetails).GetDialysisOnflowCount(PatientVisitId, out outStatus);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetDialysisOnflowCount", ex);
            }
            return returncode;
        }
        public long InsertPatientTreatmentProcedure(List<PatientTreatmentProcedure> lstPPRO, int pOrgID, out int returnStatus)
        {
            long returnCode = -1;
            returnStatus = -1;
            try
            {
                returnCode = new Dialysis_DAL(globalContextDetails).InsertPatientTreatmentProcedure(lstPPRO, pOrgID, out returnStatus);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL InsertPatientTreatmentProcedure", ex);
            }


            return returnCode;
        }
        
        public long UpdatePatientTreatmentProcedure(long pVisitID, int pOrgID)
        {
            long returnCode = -1;

            try
            {
                returnCode = new Dialysis_DAL(globalContextDetails).UpdatePatientTreatmentProcedure(pVisitID, pOrgID);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL UpdatePatientTreatmentProcedure", ex);
            }

            return returnCode;
        }
    }
}
