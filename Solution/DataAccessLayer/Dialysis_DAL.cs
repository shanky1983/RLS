using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel;
using Attune.Podium.DataAccessEngine;
using Attune.Podium.BusinessEntities;
using System.Data.SqlClient;
using Attune.Podium.Common;
using System.Data.Common;
using System.Transactions;


namespace Attune.Solution.DAL
{
    public class Dialysis_DAL
    {
        ContextDetails globalContextDetails;
        public Dialysis_DAL()
        {

        }
        public Dialysis_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetDialysisRecord(int orgID, long visitID, out int hdno, out long patientID, out decimal prevWeight, out DialysisRecord dialysisRecord)
        {
            long returnCode = -1;
            
            dialysisRecord = new DialysisRecord();
            hdno = -1;

            using (DBEngine dBEngine = new DBEngine())
            {

                DataSet ds = new DataSet();
                List<DialysisRecord> lstdialysisRecord = new List<DialysisRecord>();
                SqlCommand cmd = new SqlCommand();

                cmd = Command.pGetDialysisRecordCommand(orgID, visitID, out hdno, out patientID, out prevWeight,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

                returnCode = dBEngine.ExecuteDataSet(cmd, out ds);
                if (ds.Tables.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstdialysisRecord);
                    if (lstdialysisRecord.Count > 0)
                    {
                        dialysisRecord = lstdialysisRecord[0];
                    }
                    else
                    {
                        dialysisRecord = null;
                    }
                }

                hdno = Convert.ToInt32(cmd.Parameters["@HDNo"].Value);
                patientID = Convert.ToInt64(cmd.Parameters["@PatientID"].Value);
                prevWeight = Convert.ToDecimal(cmd.Parameters["@Weight"].Value);
            }

            return returnCode;
        }

        public long GetDialysisVitals(int iOrgID, out List<VitalsUOMJoin> lstVitalsUOMJoin)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetDialysisVitalsCommand(iOrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstVitalsUOMJoin = new List<VitalsUOMJoin>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }

            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstVitalsUOMJoin);
            }

            return returnCode;
        }

        public long GetDialysisOnFlowVitals(int iOrgID, out List<VitalsUOMJoin> lstVitalsUOMJoin)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetDialysisOnFlowVitalsCommand(iOrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstVitalsUOMJoin = new List<VitalsUOMJoin>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }

            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstVitalsUOMJoin);
            }

            return returnCode;
        }


        public long GetDialysisVitalsForUpd(int iOrgID, long PatientVisitID, out List<VitalsUOMJoin> lstVitalsUOMJoin)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetDiaVitalsForUpdCommand(iOrgID, PatientVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstVitalsUOMJoin = new List<VitalsUOMJoin>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }

            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstVitalsUOMJoin);
            }

            return returnCode;
        }

        public long GetDialysisAccess(out List<DialysisAccess> lstAccess)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetDialysisAccessCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstAccess = new List<DialysisAccess>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }

            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstAccess);
            }

            return returnCode;
        }

        public long GetDialysisCaseSheet(long visitID, int OrgID, out DialysisRecord dr, 
            out List<VitalsUOMJoin> vitalsUOMJoin, out List<Complication> parentComplications, 
            out List<Complication> complications, out string PatientName, out string Age,out long patientID, out decimal AmountReceived)
        {
            long returnCode = -1;
            PatientName = string.Empty;
            AmountReceived = 0;

            SqlCommand cmd = new SqlCommand();
            
            List<DialysisRecord> drs = new List<DialysisRecord>();
            dr = new DialysisRecord();
            vitalsUOMJoin = new List<VitalsUOMJoin>();
            parentComplications = new List<Complication>();
            complications = new List<Complication>();
            Age = "0";
            patientID = 0;

            cmd = Command.pGetDialysisCaseSheetCommand(OrgID, visitID, out PatientName, out Age, out patientID, out AmountReceived,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteDataSet(cmd, out ds);
            }

            if (ds.Tables.Count > 0)
            {
                PatientName = cmd.Parameters["@pPatientName"].Value.ToString();
                Age = cmd.Parameters["@pPatientAge"].Value.ToString();
                AmountReceived = Convert.ToDecimal(cmd.Parameters["@pAmount"].Value);
                patientID = Convert.ToInt64(cmd.Parameters["@pPatientId"].Value);
                returnCode = Utilities.ConvertTo(ds.Tables[0], out drs);
                if (drs.Count > 0)
                    dr = drs[0];
                if (ds.Tables[1] != null)
                    returnCode = Utilities.ConvertTo(ds.Tables[1], out vitalsUOMJoin);
                if (ds.Tables[2] != null)
                    returnCode = Utilities.ConvertTo(ds.Tables[2], out parentComplications);
                if (ds.Tables[3] != null)
                    returnCode = Utilities.ConvertTo(ds.Tables[3], out complications);

            }
            return returnCode;
        }

        public long SaveDialysisDetails(DialysisDetails dd, List<PatientHistory> hst, List<PatientPrescription> pres)
        {
            long lResult = -1;

            DataTable dtHist = UDT_DAL.ConvertToHIDECType(hst);

            SqlCommand cmdDD = new SqlCommand();
            cmdDD = Command.pInsertDialysisDetailsCommand(dd.PatientVisitID, dd.IsFirstDialysis, dd.DialysisSince, dd.CreatedBy,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdDD.Parameters.Add("@Return", SqlDbType.Int);
            cmdDD.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            SqlCommand cmdHist = new SqlCommand();
            cmdHist = Command.pInsertPatientHistoryBulkCommand(dtHist,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdHist.Parameters.Add("@Return", SqlDbType.Int);
            cmdHist.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;


            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteTransactionalNonQuery(cmdDD);
                        lResult = Convert.ToInt64(cmdDD.Parameters["@Return"].Value);

                        if (lResult == 0 && dtHist.Rows.Count > 0)
                        {
                            lResult = -1;
                            dbEngine.ExecuteTransactionalNonQuery(cmdHist);
                            lResult = Convert.ToInt64(cmdHist.Parameters["@Return"].Value);
                        }

                    }
                    tranScope.Complete();
                }

                catch (Exception ex)
                {
                    CLogger.LogError("Error while saving dialysis. Query : " + cmdDD.CommandText, ex);
                    tranScope.Dispose();
                }
            }
            return lResult;
        }


        public long SaveDialysisPrescription(List<PatientPrescription> pres)
        {
            long lResult = -1;

            DataTable dtPres = UDT_DAL.ConvertToPrescriptionType(pres);

            SqlCommand cmdPres = new SqlCommand();
            cmdPres = Command.pInsertPatientPrescriptionBulkCommand(dtPres,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdPres.Parameters.Add("@Return", SqlDbType.Int);
            cmdPres.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            try
            {
                using (DBEngine dbEngine = new DBEngine(true))
                {
                    dbEngine.ExecuteTransactionalNonQuery(cmdPres);
                    lResult = Convert.ToInt64(cmdPres.Parameters["@Return"].Value);
                }
            }

            catch (Exception ex)
            {
                CLogger.LogError("Error while executing SaveDialysisPrescription" + cmdPres.CommandText, ex);
            }
            return lResult;
        }

        public long SavePreDialysisDetails(long pOrgID, DialysisRecord dr, List<DialysisPatientVitals> lstDPV)
        {
            long lResult = -1;


            DataTable PatientVitalsTable = UDT_DAL.ConvertToPatientVitalsType(lstDPV);

            SqlCommand cmdDR = new SqlCommand();
            cmdDR = Command.pInsertDialysisRecordCommand(dr.PatientVisitID, dr.HDNo, dr.HDDate, dr.HDStartTime, dr.AccessID, dr.AccessSide, dr.OrgID, dr.WeightGain, dr.MachineName, dr.CreatedBy,dr.DryWeight,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdDR.Parameters.Add("@Return", SqlDbType.Int);
            cmdDR.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            SqlCommand cmdPV = new SqlCommand();
            cmdPV = Command.pInsertDialysisVitalsCommand(pOrgID, PatientVitalsTable,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdPV.Parameters.Add("@Return", SqlDbType.Int);
            cmdPV.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteTransactionalNonQuery(cmdDR);
                        lResult = Convert.ToInt64(cmdDR.Parameters["@Return"].Value);

                        if (lResult == 0 && PatientVitalsTable.Rows.Count > 0)
                        {
                            lResult = -1;
                            dbEngine.ExecuteTransactionalNonQuery(cmdPV);
                            lResult = Convert.ToInt64(cmdPV.Parameters["@Return"].Value);
                        }
                    }
                    tranScope.Complete();
                }
                catch (Exception ex)
                {
                    CLogger.LogError("Error while saving predialysis details. Query : " + cmdPV.CommandText, ex);
                    tranScope.Dispose();
                }

            }

            return lResult;
        }

        public long SavePostDialysisDetails(long pOrgID, DialysisRecord dr,   
            List<DialysisPatientVitals> lstPreDialysisVitals,
            List<DialysisPatientVitals> lstPostDialysisVitals,
            List<PatientComplication> lstComplications)
        {
            long lResult = -1;
            
            

            SqlCommand cmdDR = Command.pUpdateDialysisRecordCommand(dr.PatientVisitID, dr.HDEndTime, dr.PostConditionID, dr.BTS, dr.DialyserUsed, dr.NextHDDateTime, dr.AccessID, dr.AccessSide,dr.WeightGain, dr.ModifiedBy,dr.Remarks,dr.Comments ,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdDR.Parameters.Add("@Return", SqlDbType.Int);
            cmdDR.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            DataTable PreDialysisVitals = UDT_DAL.ConvertToPatientVitalsType(lstPreDialysisVitals);
            SqlCommand cmdPV = Command.pUpdateDialysisVitalsCommand(PreDialysisVitals,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdPV.Parameters.Add("@Return", SqlDbType.Int);
            cmdPV.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            DataTable PostDialysisVitals = UDT_DAL.ConvertToPatientVitalsType(lstPostDialysisVitals);
            SqlCommand cmdPost = Command.pInsertDialysisVitalsCommand(pOrgID, PostDialysisVitals,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdPost.Parameters.Add("@Return", SqlDbType.Int);
            cmdPost.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            DataTable Complications = UDT_DAL.ConvertToHIDECType(lstComplications); 
            SqlCommand cmd = Command.pInsertPatientComplicationCommand(Complications,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmd.Parameters.Add("@Return", SqlDbType.Int);
            cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteTransactionalNonQuery(cmdDR);
                        lResult = Convert.ToInt64(cmdDR.Parameters["@Return"].Value);

                        if (lResult == 0 && PreDialysisVitals.Rows.Count > 0)
                        {
                            lResult = -1;
                            dbEngine.ExecuteTransactionalNonQuery(cmdPV);
                            lResult = Convert.ToInt64(cmdPV.Parameters["@Return"].Value);
                        }

                        if (lResult == 0 && PostDialysisVitals.Rows.Count > 0)
                        {
                            lResult = -1;
                            dbEngine.ExecuteTransactionalNonQuery(cmdPost);
                            lResult = Convert.ToInt64(cmdPost.Parameters["@Return"].Value);
                        }

                        if (lResult == 0 && Complications.Rows.Count > 0)
                        {
                            lResult = -1;
                            dbEngine.ExecuteTransactionalNonQuery(cmd);
                            lResult = Convert.ToInt64(cmd.Parameters["@Return"].Value);
                        }
                    }
                    tranScope.Complete();
                }

                catch (Exception ex)
                {
                    CLogger.LogError("Error while saving post dialysis details. Query : " + cmd.CommandText, ex);
                    tranScope.Dispose();
                }

            }

            return lResult;
        }

        public long SaveDialysisOnFlow(DialysisOnFlow dialysisOnFlow, List<DialysisOnFlowDetails> lstDialysisOnFlow)
        {
            long lResult = -1;
            long lDialysisOnFlowID = -1;
            

            SqlCommand cmdDR = new SqlCommand();
            cmdDR = Command.pInsertDialysisOnFlowCommand(dialysisOnFlow.PatientVisitID, dialysisOnFlow.OnFlowDateTime,
									                dialysisOnFlow.Remarks, dialysisOnFlow.OrgID, dialysisOnFlow.CreatedBy, out lDialysisOnFlowID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdDR.Parameters.Add("@Return", SqlDbType.Int);
            cmdDR.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            DataTable PatientVitalsTable = UDT_DAL.ConvertToPatientVitalsType(lstDialysisOnFlow);
            
            SqlCommand cmdPV = new SqlCommand();
            cmdPV = Command.pInsertDialysisOnFlowVitalsCommand(dialysisOnFlow.OrgID, lDialysisOnFlowID, PatientVitalsTable,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            cmdPV.Parameters.Add("@Return", SqlDbType.Int);
            cmdPV.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;

            using (TransactionScope tranScope = new TransactionScope())
            {
                try
                {
                    using (DBEngine dbEngine = new DBEngine(true))
                    {
                        dbEngine.ExecuteTransactionalNonQuery(cmdDR);
                        lResult = Convert.ToInt64(cmdDR.Parameters["@Return"].Value);
                        lDialysisOnFlowID = Convert.ToInt64(cmdDR.Parameters["@pDialysisOnFlowID"].Value);

                        if (lResult == 0 && PatientVitalsTable.Rows.Count > 0)
                        {
                            lResult = -1;
                            cmdPV.Parameters["@pDialysisOnFlowID"].Value = lDialysisOnFlowID;
                            dbEngine.ExecuteTransactionalNonQuery(cmdPV);
                            lResult = Convert.ToInt64(cmdPV.Parameters["@Return"].Value);
                        }
                    }
                    tranScope.Complete();
                }
                catch(Exception ex)
                {
                    CLogger.LogError("Error while saving dialysis onflow. Query: " + cmdPV.CommandText, ex);
                    tranScope.Dispose();
                }
            }

            return lResult;
        }

        #region Get DisplayText Parameters
        
        public long GetHTParamsForPreDialysisTask(long PatientVisitID, out long PatientID, out string PatientName)
        {
            long returnCode = -1;

            PatientName = "";
            PatientID = 0;

            SqlCommand cmd = Command.pGetHTParamsForPreDialysisTaskCommand(PatientVisitID, out PatientID, out PatientName,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
                PatientName = cmd.Parameters["@pPatientName"].Value.ToString();
                PatientID = Convert.ToInt64(cmd.Parameters["@pPatientID"].Value);
            }

            return returnCode;

        }

        public long GetHTParamsForOnFlowTask(long PatientVisitID, out long PatientID, out string PatientName, out string MachineName, out string LastTestTime)
        {
            long returnCode = -1;

            PatientName = string.Empty;
            PatientID = 0;
            MachineName = string.Empty;
            LastTestTime = string.Empty;

            SqlCommand cmd = Command.pGetHTParamsDiaOnFlowTaskCommand(PatientVisitID, out PatientID, out PatientName, out MachineName, out LastTestTime,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
                PatientName = cmd.Parameters["@pPatientName"].Value.ToString();
                PatientID = Convert.ToInt64(cmd.Parameters["@pPatientID"].Value);
                MachineName = cmd.Parameters["@pMachineName"].Value.ToString();
                LastTestTime = cmd.Parameters["@pLastTestTime"].Value.ToString();
            }

            return returnCode;

        }

        public long GetHTParamsForPostDialysisTask(long PatientVisitID, out long PatientID, out string PatientName)
        {
            long returnCode = -1;

            PatientName = "";
            PatientID = 0;

            SqlCommand cmd = Command.pGetHTParamsForPreDialysisTaskCommand(PatientVisitID, out PatientID, out PatientName,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            using (DBEngine dbEngine = new DBEngine())
            {
                returnCode = dbEngine.ExecuteNonQuery(cmd);
                PatientName = cmd.Parameters["@pPatientName"].Value.ToString();
                PatientID = Convert.ToInt64(cmd.Parameters["@pPatientID"].Value);
            }

            return returnCode;

        }

        #endregion

        public long GetDialysisOnflowCount(long PatientVisitId, out int outStatus)
        {
            long returncode = -1;

            SqlCommand cmd = Command.pGetDialysisOnflowCountCommand(PatientVisitId, out outStatus,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();

            try
            {
                using (DBEngine dbengine = new DBEngine())
                {
                    returncode = dbengine.ExecuteDataSet(cmd, out ds);
                    outStatus = Convert.ToInt32(cmd.Parameters["@pOutStatus"].Value);
                    
                }
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
                DataTable dtPro = UDT_DAL.ConvertTopatientPRO(lstPPRO);
                SqlCommand cmd = Command.pInsertPatientTreatmentProcedureCommand(dtPro, pOrgID, out returnStatus,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    returnStatus = Convert.ToInt32(cmd.Parameters["@returnstatus"].Value);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL InsertPatientTreatmentProcedure", ex);
            }
            return returnCode;
        }

        public long UpdatePatientTreatmentProcedure(long pVisitID, int pOrgID)
        {
            long returnCode = -1;

            try
            {
                SqlCommand cmd = Command.pUpdatePatientTreatmentProcedureCommand(pVisitID, pOrgID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL UpdatePatientTreatmentProcedure", ex);
            }

            return returnCode;
        }
    }
}
