using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Attune.Podium.DataAccessLayer;
using Attune.Podium.BusinessEntities;
using System.Data;
using Attune.Podium.Common;
using System.Collections;

namespace Attune.Podium.SmartAccessor
{
    public class SmartAccessor
    {
        ContextDetails globalContextDetails;
        public SmartAccessor()
        {

        }
        public SmartAccessor(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        static ArrayList listofAttributes = new ArrayList();
        static ArrayList listofAttValues = new ArrayList();

        public void InitForSave(){
            listofAttributes.Clear();
            listofAttValues.Clear();
        }

        public void SetAll(ArrayList attr, ArrayList attrVal){

            listofAttributes.Add(attr);
            listofAttValues.Add(attrVal);
        }

        public long GetExamAttributeValues(long pAttId, out List<ExaminationAttributeValues> lstExamAttValues)
        {
            long returnCode = -1;
            lstExamAttValues = new List<ExaminationAttributeValues>();
            try
            {
                returnCode = new SmartAccessorDAL(globalContextDetails).GetExamAttributeValues(pAttId, out lstExamAttValues);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in SmartAccessor.cs GetExamAttributeValues", ex);
            }

            return returnCode;
        }

        public long InsertExaminationPKG(long visitID, long patientId, long createdBy,int OrgID, List<PatientVitals> lstPatientVitals)
        {
            long returnCode = -1;
            List<PatientExamination> lstPE = new List<PatientExamination>();
            List<PatientExaminationAttribute> lstPAE = new List<PatientExaminationAttribute>();

            //ArrayList att = new ArrayList();
            //ArrayList attval = new ArrayList();

            for (int i = 0; i < listofAttributes.Count; i++)
            {
                ArrayList att = (ArrayList)listofAttributes[i];
                for (int j = 0; j < att.Count; j++)
                {
                    PatientExamination pe = new PatientExamination();
                    pe = (PatientExamination)att[j];
                    lstPE.Add(pe);
                }
            }

            for (int i = 0; i < listofAttValues.Count; i++)
            {
                ArrayList attval = (ArrayList)listofAttValues[i];
                for (int j = 0; j < attval.Count; j++)
                {
                    PatientExaminationAttribute pae = new PatientExaminationAttribute();
                    pae = (PatientExaminationAttribute)attval[j];
                    lstPAE.Add(pae);
                }
            }

            DataTable dtGetPatExam = GetAttributes(lstPE);
            DataTable dtGetPatExamAtt = GetAttributesValues(lstPAE);
            DataTable dtPatientVitals = GetDataTable(lstPatientVitals);
            try
            {
                returnCode = new SmartAccessorDAL(globalContextDetails).InsertExaminationPKG(dtGetPatExam, dtGetPatExamAtt, dtPatientVitals, visitID, patientId, createdBy, OrgID);
                InitForSave();
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in SmartAccessor.cs InsertExaminationPKG", ex);
            }

            return returnCode;
        }
        private DataTable GetDataTable(List<PatientVitals> lstPatientVitals)
        {
            System.Data.DataTable dt = new DataTable();
            DataColumn dbCol1 = new DataColumn("PatientVitalsID");
            DataColumn dbCol2 = new DataColumn("PatientID");
            DataColumn dbCol3 = new DataColumn("PatientVisitID");
            DataColumn dbCol4 = new DataColumn("VitalsID");
            DataColumn dbCol5 = new DataColumn("VitalsValue");
            DataColumn dbCol6 = new DataColumn("CreatedBy");
            DataColumn dbCol7 = new DataColumn("CreatedAt");
            DataColumn dbCol8 = new DataColumn("ModifiedBy");
            DataColumn dbCol9 = new DataColumn("ModifiedAt");
            DataColumn dbCo1l0 = new DataColumn("UOMID");
            DataColumn dbCol11 = new DataColumn("ConditionID");
            DataColumn dbCol12 = new DataColumn("NurseNotes");
            DataColumn dbCol13 = new DataColumn("VitalsName");
            DataColumn dbCol14 = new DataColumn("VitalsDescription");
            DataColumn dbCol15 = new DataColumn("UOMCode");
            DataColumn dbCol16 = new DataColumn("UOMDescription");
            DataColumn dbCol17 = new DataColumn("VitalsSetID");
            DataColumn dbCol18 = new DataColumn("VitalsType");
            DataColumn dbCol19 = new DataColumn("VitalsTypeID");
            DataColumn dbCol20 = new DataColumn("EntryDate");



            //add columns
            dt.Columns.Add(dbCol1);
            dt.Columns.Add(dbCol2);
            dt.Columns.Add(dbCol3);
            dt.Columns.Add(dbCol4);
            dt.Columns.Add(dbCol5);
            dt.Columns.Add(dbCol6);
            dt.Columns.Add(dbCol7);
            dt.Columns.Add(dbCol8);
            dt.Columns.Add(dbCol9);
            dt.Columns.Add(dbCo1l0);
            dt.Columns.Add(dbCol11);
            dt.Columns.Add(dbCol12);
            dt.Columns.Add(dbCol13);
            dt.Columns.Add(dbCol14);
            dt.Columns.Add(dbCol15);
            dt.Columns.Add(dbCol16);
            dt.Columns.Add(dbCol17);
            dt.Columns.Add(dbCol18);
            dt.Columns.Add(dbCol19);
            dt.Columns.Add(dbCol20);


            DataRow dr;
            foreach (PatientVitals Vitals in lstPatientVitals)
            {
                dr = dt.NewRow();
                dr["PatientVitalsID"] = Vitals.PatientVitalsID;
                dr["PatientID"] = Vitals.PatientID;
                dr["PatientVisitID"] = Vitals.PatientVisitID;
                dr["VitalsID"] = Vitals.VitalsID;
                dr["VitalsValue"] = Vitals.VitalsValue;
                dr["CreatedBy"] = Vitals.CreatedBy;
                dr["CreatedAt"] = Vitals.CreatedAt;
                dr["ModifiedBy"] = Vitals.ModifiedBy;
                dr["ModifiedAt"] = Vitals.ModifiedAt;
                dr["UOMID"] = Vitals.UOMID;
                dr["ConditionID"] = Vitals.ConditionID;
                dr["NurseNotes"] = Vitals.NurseNotes;
                dr["VitalsName"] = Vitals.VitalsName;
                dr["VitalsDescription"] = Vitals.VitalsDescription;
                dr["UOMCode"] = Vitals.UOMCode;
                dr["UOMDescription"] = Vitals.UOMDescription;
                dr["VitalsSetID"] = Vitals.VitalsSetID;
                dr["VitalsType"] = Vitals.VitalsType;
                dr["VitalsTypeID"] = Vitals.VitalsTypeID;
                dr["EntryDate"] = Vitals.EnterDate;
                dt.Rows.Add(dr);


            }

            return dt;
        }

        private DataTable GetAttributes(List<PatientExamination> lstAtt)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("PatientVisitID");
            dt.Columns.Add("EID");
            dt.Columns.Add("Description");
            dt.Columns.Add("ExaminationName");
            dt.Columns.Add("ComplaintId");

            DataRow dr;
            foreach (PatientExamination pe in lstAtt)
            {
                dr = dt.NewRow();
                dr["PatientVisitID"] = pe.PatientVisitID;
                dr["EID"] = pe.ExaminationID;
                dr["Description"] = pe.Description;
                dr["ExaminationName"] = pe.ExaminationName;
                dr["ComplaintId"] = pe.ComplaintId;
                
                dt.Rows.Add(dr);
            }

            return dt;
        }

        private DataTable GetAttributesValues(List<PatientExaminationAttribute> lstattVal)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("PatientVisitID");
            dt.Columns.Add("EID");
            dt.Columns.Add("AttributeID");
            dt.Columns.Add("AttributevalueID");
            dt.Columns.Add("AttributeValueName");

            DataRow dr;
            foreach (PatientExaminationAttribute attVal in lstattVal)
            {
                dr = dt.NewRow();
                dr["PatientVisitID"] = attVal.PatientVisitID;
                dr["EID"] = attVal.ExaminationID;
                dr["AttributeID"] = attVal.AttributeID;
                dr["AttributevalueID"] = attVal.AttributevalueID;
                dr["AttributeValueName"] = attVal.AttributeValueName;

                dt.Rows.Add(dr);
            }

            return dt;
        }

        public long GetPatientExamPackage(long pVisitId, int OrgID, out List<PatientExaminationAttribute> lstPatExamAttribute, out List<VitalsUOMJoin> lstVitalsUOMJoin, out List<PatientExaminationAttribute> lstPatExam, out List<PatientExaminationAttribute> lstPatAttribute)
        {
            long returnCode = -1;
            lstPatExamAttribute = new List<PatientExaminationAttribute>();
            lstPatExam = new List<PatientExaminationAttribute>();
            lstPatAttribute = new List<PatientExaminationAttribute>();
            lstVitalsUOMJoin = new List<VitalsUOMJoin>();
            try
            {
                returnCode = new SmartAccessorDAL(globalContextDetails).GetPatientExamPackage(pVisitId, OrgID, out lstPatExamAttribute, out lstVitalsUOMJoin, out lstPatExam, out lstPatAttribute);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in SmartAccessor.CS", ex);
            }
            return returnCode;
        }
        
        public long GetEMRPackgeDetails(int pkgID, int pOrgID, out List<InvPackageMapping> lstIPM)
        {
            long returnCode = -1;
            lstIPM = new List<InvPackageMapping>();
            try
            {
                returnCode = new SmartAccessorDAL(globalContextDetails).GetEMRPackgeDetails(pkgID, pOrgID, out lstIPM);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetEMRPackgeDetails", ex);
            }

            return returnCode;
        }
        public long GetAllergyHistory(string strDesc, string strPre, out List<PatientHistoryAttribute> lstPHA)
        {
            long returnCode = -1;
            lstPHA = new List<PatientHistoryAttribute>();
            try
            {
                returnCode = new SmartAccessorDAL(globalContextDetails).GetAllergyHistory(strDesc, strPre, out lstPHA);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetEMRPackgeDetails", ex);
            }

            return returnCode;

        }
        public long GetAllergyHistoryDet(long lngHistoryID, out List<PatientHistoryAttribute> lstPHA)
        {
            long returnCode = -1;
            lstPHA = new List<PatientHistoryAttribute>();
            try
            {
                returnCode = new SmartAccessorDAL(globalContextDetails).GetAllergyHistoryDet(lngHistoryID, out lstPHA);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetEMRPackgeDetails", ex);
            }

            return returnCode;

        }

        public long GetPatientHistoryPKGEdit(long visitID, out List<PatientHistoryAttribute> lstPHA, out List<DrugDetails> lstDrugDetails, out List<GPALDetails> lstGPALDetails, out List<ANCPatientDetails> lstANCPatientDetails, out List<PatientPastVaccinationHistory> lstPPVH, out List<PatientComplaintAttribute> lstPCA, out List<SurgicalDetail> lstSurgicalDetails, out List<PatientComplaintAttribute> lsthisPCA, out List<PatientHistoryAttribute> lsthisPHA)
        {
            long returnCode = -1;
            lstPHA = new List<PatientHistoryAttribute>();
            lstDrugDetails = new List<DrugDetails>();
            lstGPALDetails = new List<GPALDetails>();
            lstANCPatientDetails = new List<ANCPatientDetails>();
            lstPPVH = new List<PatientPastVaccinationHistory>();
            lstPCA = new List<PatientComplaintAttribute>();
            lstSurgicalDetails = new List<SurgicalDetail>();
            lsthisPHA = new List<PatientHistoryAttribute>();
            lsthisPCA = new List<PatientComplaintAttribute>();
            try
            {
                returnCode = new SmartAccessorDAL(globalContextDetails).GetPatientHistoryPKGEdit(visitID, out lstPHA, out lstDrugDetails, out lstGPALDetails, out lstANCPatientDetails, out lstPPVH, out lstPCA, out lstSurgicalDetails,out lsthisPCA,out lsthisPHA);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in BL GetPatientHistoryPKGEdit", ex);
            }
            return returnCode;
        }

        
        public long GetDiagnosticsAttributeValues(long pAttId, string IsParentAttID, out List<DiagnosticsAttributeValues> lstDiagnosticsAttValues)
        {
            long returnCode = -1;
            lstDiagnosticsAttValues = new List<DiagnosticsAttributeValues>();
            try
            {
                returnCode = new SmartAccessorDAL(globalContextDetails).GetDiagnosticsAttributeValues(pAttId, IsParentAttID, out lstDiagnosticsAttValues);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in SmartAccessor.cs GetDiagnosticsAttributeValues", ex);
            }

            return returnCode;
        }
        public long InsertDiagnosticsPKG(long visitID, long patientId, long createdBy, int OrgID)
        {
            long returnCode = -1;
            List<PatientDiagnostics> lstPD = new List<PatientDiagnostics>();
            List<PatientDiagnosticsAttribute> lstPDA = new List<PatientDiagnosticsAttribute>();          

            for (int i = 0; i < listofAttributes.Count; i++)
            {
                ArrayList att = (ArrayList)listofAttributes[i];
                for (int j = 0; j < att.Count; j++)
                {
                    PatientDiagnostics pe = new PatientDiagnostics();
                    pe = (PatientDiagnostics)att[j];
                    lstPD.Add(pe);
                }
            }

            for (int i = 0; i < listofAttValues.Count; i++)
            {
                ArrayList attval = (ArrayList)listofAttValues[i];
                for (int j = 0; j < attval.Count; j++)
                {
                    PatientDiagnosticsAttribute pae = new PatientDiagnosticsAttribute();
                    pae = (PatientDiagnosticsAttribute)attval[j];
                    lstPDA.Add(pae);
                }
            }

            DataTable dtGetPatDiagnostics = GetDiagnosticsAttributes(lstPD);
            DataTable dtGetPatDiagnosticsAtt = GetDiagnosticsAttributesValues(lstPDA);
           
            try
            {
                returnCode = new SmartAccessorDAL(globalContextDetails).InsertDiagnosticsPKG(dtGetPatDiagnostics, dtGetPatDiagnosticsAtt, visitID, patientId, createdBy, OrgID);
                InitForSave();
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in SmartAccessor.cs InsertDiagnosticsPKG", ex);
            }

            return returnCode;
        }

        private DataTable GetDiagnosticsAttributes(List<PatientDiagnostics> lstAtt)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("PatientVisitID");
            dt.Columns.Add("DID");
            dt.Columns.Add("Description");
            dt.Columns.Add("DiagnosticsName");
          
            DataRow dr;
            foreach (PatientDiagnostics pe in lstAtt)
            {
                dr = dt.NewRow();
                dr["PatientVisitID"] = pe.PatientVisitID;
                dr["DID"] = pe.DiagnosticsID;
                dr["Description"] = pe.Description;
                dr["DiagnosticsName"] = pe.DiagnosticsName;           

                dt.Rows.Add(dr);
            }
            return dt;
        }

        private DataTable GetDiagnosticsAttributesValues(List<PatientDiagnosticsAttribute> lstattVal)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("PatientVisitID");
            dt.Columns.Add("DID");
            dt.Columns.Add("AttributeID");
            dt.Columns.Add("AttributevalueID");
            dt.Columns.Add("AttributeValueName");
            DataRow dr;
            foreach (PatientDiagnosticsAttribute attVal in lstattVal)
            {
                dr = dt.NewRow();
                dr["PatientVisitID"] = attVal.PatientVisitID;
                dr["DID"] = attVal.DiagnosticsID;
                dr["AttributeID"] = attVal.AttributeID;
                dr["AttributevalueID"] = attVal.AttributevalueID;
                dr["AttributeValueName"] = attVal.AttributeValueName;
                dt.Rows.Add(dr);
            }
            return dt;
        }
        public long GetPatientDiagnosticsPackage(long pVisitId, int OrgID, out List<PatientDiagnosticsAttribute> lstPatientDiagnosticsAttribute, out List<PatientDiagnosticsAttribute> lstPatientDiagnostics)
        {
            long returnCode = -1;
            lstPatientDiagnosticsAttribute = new List<PatientDiagnosticsAttribute>();
            lstPatientDiagnostics = new List<PatientDiagnosticsAttribute>();
            try
            {
                returnCode = new SmartAccessorDAL(globalContextDetails).GetPatientDiagnosticsPackage(pVisitId, OrgID, out lstPatientDiagnosticsAttribute,out lstPatientDiagnostics);
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in SmartAccessor.CS", ex);
            }
            return returnCode;
        }
    }
}
