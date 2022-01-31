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

    public class Immunize_DAL
    {
        ContextDetails globalContextDetails;
        public Immunize_DAL()
        {
        }
        public Immunize_DAL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public long GetVaccinationtoImmunize(out List<Vaccination> lstVacctoImmunize)
        {
            long returnCode = -1;
            lstVacctoImmunize = new List<Vaccination>();
            try
            {
                SqlCommand cmd = Command.pGetVaccinationtoImmunizeCommand(UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstVacctoImmunize);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetVaccinationtoImmunize", ex);
            }

            return returnCode;
        }

        public long InsertPatientBabyVaccination(List<PatientBabyVaccination> lstPatientBabyVaccination, out int pOrderedCount)
        {
            long returnCode = -1;
            pOrderedCount = -1;

            try
            {
                DataTable dtPBV = UDT_DAL.ConvertToImmunization(lstPatientBabyVaccination);
                SqlCommand cmd = Command.pInsertPatientBabyVaccinationCommand(dtPBV, out pOrderedCount,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteNonQuery(cmd);
                    pOrderedCount = Convert.ToInt32(cmd.Parameters["@pOrderedCount"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL InsertPatientBabyVaccination", ex);
            }

            return returnCode;
        }

        public long GetPatientBabyVaccListbyPID(long pID, out List<PatientBabyVaccination> lstPBV)
        {
            long returnCode = -1;
            lstPBV = new List<PatientBabyVaccination>();
            try
            {
                SqlCommand cmd = Command.pGetPatientBabyVaccListbyPIDCommand(pID,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                DataSet ds = new DataSet();
                using (DBEngine dbEngine = new DBEngine())
                {
                    dbEngine.ExecuteDataSet(cmd, out ds);
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    returnCode = Utilities.ConvertTo(ds.Tables[0], out lstPBV);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in DAL GetPatientBabyVaccListbyPID", ex);
            }

            return returnCode;
        }
        public long InsertMasterData(List<CasualtyCharges> lCasuality)
        {
            long returnCode = -1;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = Command.pInsertMasterDataCommand(lCasuality[0].TestName, lCasuality[0].CasualtyRate, lCasuality[0].OrgID,lCasuality[0].FeeType,UDT_DAL.ConvertToUDT_Context(globalContextDetails));
                using (DBEngine db = new DBEngine())
                {
                    returnCode = db.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                CLogger.LogError("Error in InsertMasterData DAL", ex);
            }
            return returnCode;
        }
    }
}
