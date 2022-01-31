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
    public class PatientPrescription_DAL
    {
        ContextDetails globalContextDetails;
        public PatientPrescription_DAL()
        {

        }
        public PatientPrescription_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetTreatment(long visitID, string pPrescriptionNo, out List<PatientPrescription> lstPatientPrescription)
        {
            long returnCode = -1;
            SqlCommand objCommand = Command.pGetCaseSheetTreatmentCommand(visitID, pPrescriptionNo,UDT_DAL.ConvertToUDT_Context(globalContextDetails));

            lstPatientPrescription = new List<PatientPrescription>();
            DataSet ds = new DataSet();

            using (DBEngine dbEngine = new DBEngine())
            {
                dbEngine.ExecuteDataSet(objCommand, out ds);
            }


            if (ds.Tables.Count > 0)
            {
                returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPatientPrescription);
            }

            return returnCode;
        }



        public long GetPrescription(string DrugName, int Filter, int pOrgID,
            out List<PatientPrescription> lstPrescription,int 
            OrgAddressId,int LocationId, long PatientVisitID)
        {
            long lresult = -1;
            lstPrescription = new List<PatientPrescription>();
            SqlCommand cmd = Command.pGetDrugsCommand(DrugName, Filter, pOrgID, OrgAddressId, LocationId, PatientVisitID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
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
                CLogger.LogError("Error while executing GetPrescription in DAL" + cmd.CommandText, ex);
            }

            return lresult;

        }

        public long GetDose(string drugName, string brandName,
            out List<PatientPrescription> lstPrescription)
        {
            long lresult = -1;
            lstPrescription = new List<PatientPrescription>();
            SqlCommand cmd = Command.pGetDoseCommand(drugName, brandName,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
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
                CLogger.LogError("Error while executing GetPrescription in DAL" + cmd.CommandText, ex);
            }

            return lresult;

        }

        public long GetDrugUseInstruction(out List<DrugUseInstruction> lstDrugUseInstruction)
        {
            long lresult = -1;
            lstDrugUseInstruction = new List<DrugUseInstruction>();
            SqlCommand cmd = Command.pGetDrugUseInstructionCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();

            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstDrugUseInstruction);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing  DrugUseInstruction in DAL" + cmd.CommandText, ex);
            }
            return lresult;
        }
        public long GetDrugUseInstructionDetails(out List<DrugUseInstruction> lstDrugUseInstruction, out List<DrugFrequency> lstDrugFrequency)
        {
            long lresult = -1;
            lstDrugUseInstruction = new List<DrugUseInstruction>();
            lstDrugFrequency=new List<DrugFrequency>();
            SqlCommand cmd = Command.pGetDrugUseInstructionDetailsCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
            DataSet ds = new DataSet();

            try
            {
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables.Count > 0)
                {
                    lresult = Utilities.ConvertTo(ds.Tables[0], out lstDrugUseInstruction);
                    lresult = Utilities.ConvertTo(ds.Tables[1], out lstDrugFrequency);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while executing  GetDrugUseInstructionDetails in DAL" + cmd.CommandText, ex);
            }
            return lresult;
        }
    }
}
